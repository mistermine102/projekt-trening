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
        public event EventHandler exercisesGroupAddedEvent;
        List<ExercisesGroupItem> selectedExercises = new List<ExercisesGroupItem>();

        public void createComboboxOptions()
        {
            foreach (Exercise exercise in Exercise.exercises)
            {
                //check if exercise is already selected
                bool isExerciseSelected = false;
                foreach(ExercisesGroupItem selectedExercise in selectedExercises)
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

        private async void add_exercises_group_btn_Click(object sender, EventArgs e)
        {
            ExercisesGroup newExercisesGroup = new ExercisesGroup() {
                name = exercise_name_textbox.Text,
                exercises = new List<ExercisesGroupItem>()
            };

            foreach(ExercisesGroupItem exercise in selectedExercises)
            {
                newExercisesGroup.exercises.Add(exercise);
            }

            await ExercisesGroup.createExercisesGroup(newExercisesGroup);
            exercisesGroupAddedEvent?.Invoke(sender, e);
            this.Close();
        }

        private void add_exercise_btn_Click(object sender, EventArgs e)
        {
            if(select_exercise_combobox.SelectedItem == null)
            {
                return;
            }
            Exercise selectedExercise = (Exercise)(select_exercise_combobox.SelectedItem as ComboboxItem).Value;

            Label exerciseName = new Label();
            exerciseName.Text = selectedExercise.name;
            selected_exercises_container.Controls.Add(exerciseName);

            ExercisesGroupItem exerciseGroup = new ExercisesGroupItem()
            {
                exercise = selectedExercise,
                sets = int.Parse(sets_textbox.Text),
                reps = int.Parse(reps_textbox.Text),
                order = 0
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
}
