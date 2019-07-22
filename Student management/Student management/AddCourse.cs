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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin admn = new Admin();
            int numofstudents = 0;
            admn.ADDcourse(txtName.Text, txtCode.Text, Convert.ToInt32(txtMax.Text), txtPre.Text, txtHours.Text,numofstudents);
            txtName.Clear();
            txtCode.Clear();
            txtMax.Clear();
            txtPre.Clear();
            txtHours.Clear();
            lblSaved.Text = "*Saved !";
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }
    }
}
