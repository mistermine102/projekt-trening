using projekt_trening.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace projekt_trening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_exercises uc = new UC_exercises();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl) 
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront(); 
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_exercises uc = new UC_exercises();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_plan uc = new UC_plan();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_calendar uc = new UC_calendar();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_statistics uc = new UC_statistics();
            addUserControl(uc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
