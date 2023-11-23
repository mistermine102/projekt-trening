using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_trening.UserControls
{
    public partial class addExerciseModal : Form
    {
        public addExerciseModal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        async Task createExercise(Exercise newExercise)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(newExercise);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    await client.PostAsync(Global.apiUrl + "/exercise", content);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void add_exercise_btn_Click(object sender, EventArgs e)
        {
            List<string> targetMuscles = new List<string>();

            string[] targetMusclesArr = target_muscles_textbox.Text.Split(',');
            
            foreach(string muscle in targetMusclesArr)
            {
                targetMuscles.Add(muscle);
            }

            Exercise newExercise = new Exercise()
            {
                name = name_textbox.Text,
                description = desc_textbox.Text,
                imgUrl = img_url_textbox.Text,
                difficulty = 1,
                targetMuscles = targetMuscles
            };
            createExercise(newExercise);
            this.Close();
        }

        private void addExerciseModal_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void form_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
