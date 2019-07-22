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
    public partial class AddStudent : Form

    {
        public List<string> finished_courses = new List<string>();
        public List<string> in_progress = new List<string>();
        public AddStudent()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            finished_courses.Add(txtfinished.Text);
            txtfinished.Clear();
            txtfinished.Focus();
        }

        private void btnAddInProgress_Click(object sender, EventArgs e)
        {
            in_progress.Add(txtInProgress.Text);
            txtInProgress.Clear();
            txtInProgress.Focus();
        }

        private void btnAddSt_Click(object sender, EventArgs e)
        {
            Admin admn = new Admin();
            Student stud = new Student();
            stud.readdata();

            for(int i=0;i<stud.student_list.Count;i++)
            {
                if(txtID.Text==stud.student_list[i].ID)
                {
                    lblWrngID.Text = "*This ID is already existed !";
                    txtPass.Clear();

                    txtID.Focus();
                    return;
                }
            }
            admn.ADDstudent(txtName.Text, txtID.Text, txtPass.Text, txtYear.Text, finished_courses, in_progress);
            txtID.Clear();
            txtName.Clear();
            txtPass.Clear();
            txtYear.Clear();
            lblSaved.Text = "*Saved !";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminmenu am =new adminmenu();
            this.Hide();
            am.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
