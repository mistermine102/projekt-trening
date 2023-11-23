using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace projekt_trening.UserControls
{

    public partial class UC_exercises : UserControl
    {
        async void displayExercises()
        {
            await getExercises();
            renderExercises();

        }

        async void handleDeleteClick(object sender, EventArgs e, string exerciseId)
        {
            await deleteExercise(exerciseId);
        }
        async Task deleteExercise(string exerciseId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var body = new { exerciseId = exerciseId};

                    string json = JsonConvert.SerializeObject(body);

                    HttpRequestMessage request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(Global.apiUrl + "/exercise"),
                        Content = new StringContent(json, Encoding.UTF8, "application/json")

                    };
                    HttpResponseMessage response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();

                }
                renderExercises();
            } catch(Exception ex)
            {

            }
        }
        async Task getExercises()
        {
            using (HttpClient client = new HttpClient()) 
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(Global.apiUrl + "/exercise");
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    GetExerciseResponse data = JsonConvert.DeserializeObject<GetExerciseResponse>(json);

                    Global.exercises = data.exercises;
                } catch(HttpRequestException ex)
                {
                    //failed to read the exercises
                }
            }
        }
        void setImageSourceAsync(PictureBox picture, string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream str = response.GetResponseStream())
                    {
                        picture.Image = Bitmap.FromStream(str);
                    }
                }
            } catch(Exception e)
            {
                setImageSourceAsync(picture, "https://t4.ftcdn.net/jpg/04/99/93/31/360_F_499933117_ZAUBfv3P1HEOsZDrnkbNCt4jc3AodArl.jpg");
            }
        }
        void renderExercises()
        {
            foreach (Exercise exercise in Global.exercises)
            {
                //create an exercise card
                FlowLayoutPanel exercise_card = new FlowLayoutPanel();
                exercise_card.FlowDirection = FlowDirection.TopDown;
                exercise_card.BorderStyle = BorderStyle.FixedSingle;
                exercise_card.BackColor = Color.DarkSeaGreen;
                exercise_card.Padding = new Padding(5, 10, 5, 10);
                exercise_card.MinimumSize = new Size(this.ClientSize.Width/2-20, 500);

                //button to delete the exercise
                Button deleteBtn = new Button();
                deleteBtn.Click += delegate (object sender, EventArgs e)
                {
                    handleDeleteClick(sender, e, exercise._id);
                };
                deleteBtn.Text = "Usuń";
                exercise_card.Controls.Add(deleteBtn);


                //add information about the exercise 
                Label name_label = new Label();
                name_label.Text = exercise.name;
                name_label.Font = new Font("Microsoft YaHei", 10, FontStyle.Bold);
                name_label.AutoSize = true;
                name_label.Margin = new Padding(0, 0, 0, 10);
                name_label.MinimumSize = new Size(this.ClientSize.Width / 2 - 30, 50);
                name_label.TextAlign = ContentAlignment.MiddleCenter;
                exercise_card.Controls.Add(name_label);

                PictureBox picture = new PictureBox();
                picture.MinimumSize = new Size(this.ClientSize.Width / 2 - 30, this.ClientSize.Height / 2 - 30);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                setImageSourceAsync(picture, exercise.imgUrl);

                exercise_card.Controls.Add(picture);

                Label description_label = new Label();
                description_label.Text = exercise.description;
                description_label.AutoSize = true;
                //description_label.Font = new Font("Microsoft YaHei", 8, FontStyle.Regular);
                exercise_card.Controls.Add(description_label);

                //add the card to the exercises container
                exercises_container.Controls.Add(exercise_card);
            }
        }
        public UC_exercises()
        {
            InitializeComponent();
            displayExercises();
            Global.exercisesLoaded = true;
            Global.exercisesContainer = exercises_container;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ćwiczenai_Click(object sender, EventArgs e)
        {

        }

        addExerciseModal addExerciseModal = new addExerciseModal();

        private void add_exercise_btn_Click(object sender, EventArgs e)
        {
            addExerciseModal.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    class GetExerciseResponse
    {
        public string message;
        public List<Exercise> exercises;
    }
    static class Global
    {
        public static List<Exercise> exercises = new List<Exercise>();
        public static List<ExercisesGroup> ExercisesGroups = new List<ExercisesGroup>();
        public static bool exercisesLoaded = false;
        public static Control exercisesContainer;
        public static string apiUrl = "http://localhost:8000";
    }
    class Exercise
    {
        public string _id;
        public string name;
        public string description;
        public string imgUrl;
        public int difficulty;
        public List<string> targetMuscles;
    }

}
