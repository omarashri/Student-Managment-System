using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management
{
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void grpChoices_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radView.Checked)
            {
                AvCourses av = new AvCourses();
                this.Hide();
                av.Show();
            }
            else if(radDetails.Checked)
            {
                CourseDetails cd = new CourseDetails();
                this.Hide();
                cd.Show();
            }
            else if (radYourCourses.Checked)
            {
                ViewCourses vc = new ViewCourses();
                this.Hide();
                vc.Show();
            }
            else if(radRegister.Checked)
            {
                Registeration reg = new Registeration();
                this.Hide();
                reg.Show();
            }
            else if(radEdit.Checked)
            {
                EditData ed = new EditData();
                this.Hide();
                ed.Show();
            }

          else
            {
                label1.Text = "*Please chooose one option !";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckAvCourses_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radDetails_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radRegister_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLblContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Feedback feedbck = new Feedback();
            this.Hide();
            feedbck.Show();
        }
    }
}
