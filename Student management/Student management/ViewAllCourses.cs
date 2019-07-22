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
    public partial class ViewAllCourses : Form
    {
        public ViewAllCourses()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lstboxCourses.Items.Clear();
            Admin admn = new Admin();
            List<string> finished = new List<string>();
            List<string> in_progress = new List<string>();
            finished = admn.finish(txtName.Text);
            in_progress = admn.progress(txtName.Text);
            

            if(finished.Count==0 && in_progress.Count==0)
            {
                lstboxCourses.Items.Add("No students with this name !");
                return;
            }





            for (int i = 0; i < finished.Count; i++)
            {
                if (finished[i].Contains("_") )
                {
                    lstboxCourses.Items.Add("Finished :  NONE ");
                    break;
                }
                if (i == 0)
                    lstboxCourses.Items.Add("Finished : " + finished[i]);
                else
                    lstboxCourses.Items.Add("                   " + finished[i]);
            }



            lstboxCourses.Items.Add("---------------------------------");



            for (int i = 0; i < in_progress.Count; i++)
            {
                if (in_progress[i].Contains("_") )
                {
                    lstboxCourses.Items.Add("In progress : NONE ");
                    break;
                }
                if (i == 0)
                    lstboxCourses.Items.Add("In progress : " + in_progress[i]);
                else
                    lstboxCourses.Items.Add("                        " + in_progress[i]);
            }
            


            
            btnView.Enabled = false;
                     
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

        private void ViewAllCourses_Load(object sender, EventArgs e)
        {
            txtName.Clear();
            btnView.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnView.Enabled = true;
        }
    }
}
