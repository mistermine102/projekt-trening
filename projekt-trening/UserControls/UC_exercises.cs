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
        async void handleExerciseAdded(object sender, EventArgs e)
        {
            displayExercises();
        }

        async void handleEditClick(object sender, EventArgs e, Exercise exercise)
        {
            addExerciseModal.inEditMode = true;
            addExerciseModal.exerciseToEdit = exercise;

            addExerciseModal modal = new addExerciseModal();
            modal.ShowDialog();
        }
        async void displayExercises()
        {
            exercises_container.Controls.Clear();
            await Exercise.getExercises();
            renderExercises();
        }
        async void handleDeleteClick(object sender, EventArgs e, string exerciseId)
        {
            await Exercise.deleteExercise(exerciseId);
            displayExercises();
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
            foreach (Exercise exercise in Exercise.exercises)
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

                Button editBtn = new Button();
                editBtn.Click += delegate (object sender, EventArgs e)
                {
                    handleEditClick(sender, e, exercise);
                };
                editBtn.Text = "Edytuj";
                exercise_card.Controls.Add(editBtn);


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
            addExerciseModal.exerciseAddedEvent += handleExerciseAdded;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        addExerciseModal addExerciseModal = new addExerciseModal();

        private void add_exercise_btn_Click(object sender, EventArgs e)
        {
            addExerciseModal.inEditMode = false;
            addExerciseModal.ShowDialog();
        }
    }
    static class Global
    {
        public static string apiUrl = "http://localhost:8000";
    }
}
