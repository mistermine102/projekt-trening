using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace projekt_trening.UserControls
{
    public partial class UC_exercises : UserControl
    {
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

                //add information about the exercise 
                Label name_label = new Label();
                name_label.Text = exercise.name;
                name_label.Font = new Font("Microsoft YaHei", 10, FontStyle.Bold);
                name_label.AutoSize = true;
                name_label.Margin = new Padding(0, 0, 0, 10);
                exercise_card.Controls.Add(name_label);

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

            Exercise benchpress = new Exercise()
            {
                _id = "1",
                name = "Wyciskanie na ławce płaskiej.",
                description = "Klasyczne ćwiczenie aby rozwijać klatkę piersiową.",
                imgUrl = "",
                difficulty = 2,
                targetMuscles = new List<string> { "chest", "triceps" }
            };
            Exercise deadlift = new Exercise()
            {
                _id = "2",
                name = "Martwy ciąg",
                description = "Świetne ćwiczenie na dokurwione plecy.",
                imgUrl = "",
                difficulty = 3,
                targetMuscles = new List<string> { "lats", "lower back", "upper back", "traps"}
            };
            if(!Global.exercisesLoaded)
            {
                Global.exercises.Add(benchpress);
                Global.exercises.Add(deadlift);
            }
            Global.exercisesLoaded = true;
            Global.exercisesContainer = exercises_container;
            renderExercises();
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
    }
    static class Global
    {
        public static List<Exercise> exercises = new List<Exercise>();
        public static List<ExercisesGroup> ExercisesGroups = new List<ExercisesGroup>();
        public static bool exercisesLoaded = false;
        public static Control exercisesContainer;
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
