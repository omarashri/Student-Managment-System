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
    public partial class adminmenu : Form
    {
        public adminmenu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCnt_Click(object sender, EventArgs e)
        {
            if(radAddStudent.Checked)
            {
                AddStudent add_student = new AddStudent();
                this.Hide();
                add_student.Show();
            }
            else if(radAddcourse.Checked)
            {
                AddCourse add_course = new AddCourse();
                this.Hide();
                add_course.Show();
            }
            else if(radPre.Checked)
            {

            }    
            else if(radViewst.Checked)
            {
                ViewStudentinCourse view_student = new ViewStudentinCourse();
                this.Hide();
                view_student.Show();
            }
            else if(radViewCrs.Checked)
            {
                ViewAllCourses view_courses = new ViewAllCourses();
                this.Hide();
                view_courses.Show();
            }
            else if(radEdit.Checked)
            {
                AdminEdit admn_edit = new AdminEdit();
                this.Hide();
               admn_edit.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void adminmenu_Load(object sender, EventArgs e)
        {
            btnCnt.Enabled = false;
        }


        /*---------------Enable the Continue button if any Radio button is Checked---------------*/
        private void radAddStudent_CheckedChanged(object sender, EventArgs e)
        {
            btnCnt.Enabled = true;
        }

        private void radAddcourse_CheckedChanged(object sender, EventArgs e)
        {
            btnCnt.Enabled = true;
        }

        private void radPre_CheckedChanged(object sender, EventArgs e)
        {
            btnCnt.Enabled = true;
        }

        private void radViewst_CheckedChanged(object sender, EventArgs e)
        {
            btnCnt.Enabled = true;
        }

        private void radViewCrs_CheckedChanged(object sender, EventArgs e)
        {
            btnCnt.Enabled = true;
        }
        private void radEdit_CheckedChanged(object sender, EventArgs e)
        {
            btnCnt.Enabled = true;
        }
    }
}
