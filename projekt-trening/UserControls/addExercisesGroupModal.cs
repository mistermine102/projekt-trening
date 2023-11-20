using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekt_trening.UserControls
{
    public partial class addExercisesGroupModal : Form
    {
        List<ExerciseGroupItem> selectedExercises = new List<ExerciseGroupItem>();

        public void createComboboxOptions()
        {
            foreach (Exercise exercise in Global.exercises)
            {
                //check if exercise is already selected
                bool isExerciseSelected = false;
                foreach(ExerciseGroupItem selectedExercise in selectedExercises)
                {
                    if(selectedExercise.exercise._id == exercise._id)
                    {
                        isExerciseSelected = true;
                    }
                }
                if (isExerciseSelected)
                {
                    continue;
                }

                //add exercise to the group
                ComboboxItem item = new ComboboxItem();
                item.Text = exercise.name;
                item.Value = exercise;
                select_exercise_combobox.Items.Add(item);
            }
        }
        public addExercisesGroupModal()
        {
            InitializeComponent();
            createComboboxOptions();
        }

        private void add_exercises_group_btn_Click(object sender, EventArgs e)
        {
            ExercisesGroup newExercisesGroup = new ExercisesGroup() {
                name = exercise_name_textbox.Text,
                exercises = new List<ExerciseGroupItem>()
            };

            foreach(ExerciseGroupItem exercise in selectedExercises)
            {
                newExercisesGroup.exercises.Add(exercise);
            }

            Global.ExercisesGroups.Add(newExercisesGroup);
        }

        private void add_exercise_btn_Click(object sender, EventArgs e)
        {
            if(select_exercise_combobox.SelectedItem == null)
            {
                return;
            }
            Exercise selectedExercise = (Exercise)(select_exercise_combobox.SelectedItem as ComboboxItem).Value;

            Label exerciseName = new Label();
            exerciseName.Text = selectedExercise.description;
            selected_exercises_container.Controls.Add(exerciseName);

            ExerciseGroupItem exerciseGroup = new ExerciseGroupItem()
            {
                exercise = selectedExercise,
                sets = int.Parse(sets_textbox.Text),
                reps = int.Parse(reps_textbox.Text),
                order = 1
            };

            selectedExercises.Add(exerciseGroup);

            select_exercise_combobox.SelectedItem = null;

            //clear combobox options
            select_exercise_combobox.Items.Clear();
            createComboboxOptions();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
