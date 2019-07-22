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
    public partial class ViewCourses : Form
    {
        public ViewCourses()
        {
            InitializeComponent();

            List<string> vcrs = new List<string>();
            Student s1 = new Student();
            vcrs=s1.viewcourses();
            for(int i=0;i<vcrs.Count;i++)
            {
                lstCourses.Items.Add(vcrs[i]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentMenu sm = new StudentMenu();
            this.Hide();
            sm.Show();
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
