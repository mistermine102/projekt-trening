using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_trening.UserControls
{
    public partial class addExercisesGroupModal : Form
    {
        public event EventHandler exercisesGroupAddedEvent;
        List<ExercisesGroupItem> selectedExercises = new List<ExercisesGroupItem>();

        public static bool inEditMode = false;
        public static ExercisesGroup exercisesGroupToEdit;

        void removeExerciseFromList(object sender, EventArgs e, ExercisesGroupItem exercise, FlowLayoutPanel exercise_container)
        {
            selectedExercises.Remove(exercise);
            selected_exercises_container.Controls.Remove(exercise_container);
            exercise_container.Dispose();
            select_exercise_combobox.Items.Clear();
            createComboboxOptions();
        }
        void addExerciseToList(ExercisesGroupItem exercise)
        {
            FlowLayoutPanel exercise_container = new FlowLayoutPanel();
            exercise_container.FlowDirection = FlowDirection.LeftToRight;
            exercise_container.MaximumSize = new Size(selected_exercises_container.Width, 20);

            Label exerciseName = new Label();
            exerciseName.Text = exercise.exercise.name;
            exercise_container.Controls.Add(exerciseName);

            Button remove_exercise_btn = new Button();
            remove_exercise_btn.Text = "Usuń";
            remove_exercise_btn.Click += delegate (object sender, EventArgs e)
            {
                removeExerciseFromList(sender, e, exercise, exercise_container);
            };
            exercise_container.Controls.Add(remove_exercise_btn);

            selected_exercises_container.Controls.Add(exercise_container);

            selectedExercises.Add(exercise);

            select_exercise_combobox.SelectedItem = null;

            //clear combobox options
            select_exercise_combobox.Items.Clear();
            createComboboxOptions();
        }

        void prepopulateValues()
        {
            exercise_name_textbox.Text = exercisesGroupToEdit.name;
            foreach(ExercisesGroupItem exercise in exercisesGroupToEdit.exercises)
            {
                addExerciseToList(exercise);
            }
        }

        void changeLabelsInEditMode()
        {
            title.Text = "Edytuj zestaw";
            add_exercises_group_btn.Text = "Edytuj zestaw";
        }
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
            if (inEditMode)
            {
                prepopulateValues();
                changeLabelsInEditMode();
            }
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

            if(inEditMode)
            {
                newExercisesGroup._id = exercisesGroupToEdit._id;
                await ExercisesGroup.editExercisesGroup(newExercisesGroup);
            } else
            {
                await ExercisesGroup.createExercisesGroup(newExercisesGroup);
            }
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

            ExercisesGroupItem exerciseGroup = new ExercisesGroupItem()
            {
                exercise = selectedExercise,
                sets = int.Parse(sets_textbox.Text),
                reps = int.Parse(reps_textbox.Text),
                order = 0
            };

            addExerciseToList(exerciseGroup);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void selected_exercises_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
