using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_trening.UserControls
{
    public partial class UC_plan : UserControl
    {
        
        public UC_plan()
        {
            InitializeComponent();

            foreach(ExercisesGroup exercisesGroup in Global.ExercisesGroups)
            {
                FlowLayoutPanel exercises_group_card = new FlowLayoutPanel();
                exercises_group_card.FlowDirection = FlowDirection.TopDown;
                exercises_group_card.BorderStyle = BorderStyle.FixedSingle;
                exercises_group_card.AutoSize = true;

                Label exercisesGroupName = new Label();
                exercisesGroupName.Text = exercisesGroup.name;
                exercises_group_card.Controls.Add(exercisesGroupName);

                FlowLayoutPanel exercises_container = new FlowLayoutPanel();
                exercises_container.FlowDirection = FlowDirection.TopDown;
                exercises_container.BorderStyle = BorderStyle.FixedSingle;
                exercises_group_card.Controls.Add(exercises_container);

                foreach (ExerciseGroupItem exercise in exercisesGroup.exercises)
                {
                    Label exerciseName = new Label();
                    exerciseName.Text = exercise.exercise.name + " " + exercise.sets.ToString() + " serie x" + exercise.reps.ToString() + " powtórzeń.";
                    exercises_container.Controls.Add(exerciseName);
                }
                
                exercises_groups_container.Controls.Add(exercises_group_card);
            }
        }

        addExercisesGroupModal addExercisesGroupModal = new addExercisesGroupModal();
        private void add_exercises_group_btn_Click(object sender, EventArgs e)
        {
            addExercisesGroupModal.ShowDialog();
        }
    }
    class ExerciseGroupItem
    {
        public Exercise exercise;
        public int order;
        public int sets;
        public int reps;
    }
    class ExercisesGroup
    {
        public string name;
        public List<ExerciseGroupItem> exercises;
    }
}
