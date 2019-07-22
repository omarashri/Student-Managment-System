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
    public partial class ViewStudentinCourse : Form
    {
        public ViewStudentinCourse()
        {
            InitializeComponent();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            lstBoxStudents.Items.Clear();
            Admin admn = new Admin();

            List<string> student_names = new List<string>();
            student_names= admn.studentincourse(txtName.Text);

            if (student_names.Count != 0)
            {
                for (int i = 0; i < student_names.Count; i++)
                {
                    lstBoxStudents.Items.Add(student_names[i]);
                }
            }
            else
            {
                lstBoxStudents.Items.Add("No Students in this Course !");
            }
            txtName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminmenu admn = new adminmenu();
            this.Hide();
            admn.Show();
        }
    }
}
