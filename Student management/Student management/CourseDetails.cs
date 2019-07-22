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
    public partial class CourseDetails : Form
    {
        public CourseDetails()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            listDetails.Items.Clear();

            Courses c1 = new Courses();
            List<string> details = new List<string>();
            details = c1.details(txtName.Text);
            if (details.Count==0)
            {
                listDetails.Items.Add("            No Courses with this name !");
            }
            for (int i = 0; i < details.Count; i++)
            {
                if (i == 0)
                {
                    listDetails.Items.Add("Name : " +details[i]);
                }
                else if(i==1)
                {
                    listDetails.Items.Add("Code : " + details[i]);

                }
                else if(i==2)
                {
                    listDetails.Items.Add("Max number of students : " + details[i]);
                }
                else if(i==3)
                {
                    listDetails.Items.Add("Pre : " + details[i]);
                }
                else if(i==4)
                {
                    listDetails.Items.Add("Hours : " + details[i]);
                }
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
            StudentMenu st = new StudentMenu();
            this.Hide();
            st.Show();
        }
    }
}
