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
    public partial class UC_calendar : UserControl
    {
        async Task displayCalendar()
        {
            await Calendar.getCalendarDays();
            renderCalendar();
        }
        void openCalendarDayModal(object sender, EventArgs e, CalendarDay day) 
        {
            Calendar.selectedDay = day;
            calendarDayModal calendarDayModal = new calendarDayModal();
            calendarDayModal.ShowDialog();
        }
        void renderCalendar()
        {
            foreach(CalendarDay day in Calendar.days)
            {
                FlowLayoutPanel day_container = new FlowLayoutPanel();
                day_container.FlowDirection = FlowDirection.TopDown;
                day_container.BorderStyle = BorderStyle.FixedSingle;
                day_container.MaximumSize = new Size(this.ClientSize.Width / 5, 500);

                Label day_name = new Label();
                day_name.Text = day.dayName;
                day_container.Controls.Add(day_name);

                Label exercises_group_name = new Label();
                if(day.exercisesGroup == null)
                {
                    exercises_group_name.Text = "Dzień odpoczynku";
                } else
                {
                    exercises_group_name.Text = day.exercisesGroup.name;
                }
                day_container.Controls.Add(exercises_group_name);

                day_container.Click += delegate (object sender, EventArgs e)
                {
                    openCalendarDayModal(sender, e, day);
                };
                
                calendar_container.Controls.Add(day_container);
            }
        }
        public UC_calendar()
        {
            InitializeComponent();
            displayCalendar();
        }

        private void calendar_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
