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
    public partial class calendarDayModal : Form
    {
        void createComboboxOptions()
        {

            foreach(ExercisesGroup exercisesGroup in ExercisesGroup.ExercisesGroups)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = exercisesGroup.name;
                item.Value = exercisesGroup;
                exercises_groups_combobox.Items.Add(item);
            }
        }
        public calendarDayModal()
        {
            InitializeComponent();
            day_name.Text = Calendar.selectedDay.dayName;
            day_name.TextAlign = ContentAlignment.TopCenter;
            createComboboxOptions();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (exercises_groups_combobox.SelectedItem == null)
            {
                return;
            }
            ExercisesGroup selectedExercisesGroup = (ExercisesGroup)(exercises_groups_combobox.SelectedItem as ComboboxItem).Value;

            Calendar.selectExerciseGroupForTheDay(selectedExercisesGroup, Calendar.selectedDay);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void calendarDayModal_Load(object sender, EventArgs e)
        {

        }
    }
}
