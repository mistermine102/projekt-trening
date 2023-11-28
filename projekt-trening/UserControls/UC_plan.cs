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
    public partial class UC_plan : UserControl
    {
        void handleExercisesGroupAdded(object sender, EventArgs e)
        {
            displayExercisesGroups();
        }
        async void handleDeleteClick(object sender, EventArgs e, string exercisesGroupId)
        {
            exercises_groups_container.Controls.Clear();
            await ExercisesGroup.deleteExercisesGroup(exercisesGroupId);
            displayExercisesGroups();
        }
        async Task displayExercisesGroups()
        {
            exercises_groups_container.Controls.Clear();
            await ExercisesGroup.getExcercisesGroups();
            renderExercisesGroups();
        }
        void renderExercisesGroups()
        {
            foreach (ExercisesGroup exercisesGroup in ExercisesGroup.ExercisesGroups)
            {
                FlowLayoutPanel exercises_group_card = new FlowLayoutPanel();
                exercises_group_card.FlowDirection = FlowDirection.TopDown;
                exercises_group_card.BorderStyle = BorderStyle.FixedSingle;
                exercises_group_card.AutoSize = true;
                exercises_group_card.MinimumSize = new Size(this.ClientSize.Width / 2 - 30, 500);
                exercises_group_card.BackColor = Color.MediumSeaGreen;

                Button delete_exercises_group = new Button();
                delete_exercises_group.Click += delegate (object sender, EventArgs e)
                {
                    handleDeleteClick(sender, e, exercisesGroup._id);
                };
                delete_exercises_group.Text = "Usuń";
                exercises_group_card.Controls.Add(delete_exercises_group);

                Label exercisesGroupName = new Label();
                exercisesGroupName.Text = exercisesGroup.name;
                exercisesGroupName.Font = new Font("Microsoft YaHei", 10, FontStyle.Bold);
                exercisesGroupName.MinimumSize = new Size(this.ClientSize.Width / 2 - 30, 20);
                exercisesGroupName.TextAlign = ContentAlignment.TopCenter;
                exercises_group_card.Controls.Add(exercisesGroupName);

                FlowLayoutPanel exercises_container = new FlowLayoutPanel();
                exercises_container.FlowDirection = FlowDirection.TopDown;
                exercises_container.MinimumSize = new Size(exercises_group_card.Width, Height);
                exercises_group_card.Controls.Add(exercises_container);

                foreach (ExercisesGroupItem exercise in exercisesGroup.exercises)
                {
                    Label exerciseName = new Label();
                    exerciseName.Text = exercise.exercise.name + " " + exercise.sets.ToString() + " serie x" + exercise.reps.ToString() + " powtórzeń.";
                    exerciseName.MinimumSize = new Size(this.ClientSize.Width / 2 - 30, 20);
                    exerciseName.Font = new Font("Microsoft YaHei", 9, FontStyle.Regular);
                    exerciseName.AutoSize = false;
                    exercises_container.Controls.Add(exerciseName);
                }

                exercises_groups_container.Controls.Add(exercises_group_card);
            }
        }
        public UC_plan()
        {
            InitializeComponent();
            displayExercisesGroups();
            addExercisesGroupModal.exercisesGroupAddedEvent += handleExercisesGroupAdded;
        }

        addExercisesGroupModal addExercisesGroupModal = new addExercisesGroupModal();
        private void add_exercises_group_btn_Click(object sender, EventArgs e)
        {
            addExercisesGroupModal.ShowDialog();
        }

        private void exercises_groups_container_Paint(object sender, PaintEventArgs e)
        {
        }
    }
    class ExercisesGroupItem
    {
        public Exercise exercise;
        public int order;
        public int sets;
        public int reps;
    }
}
