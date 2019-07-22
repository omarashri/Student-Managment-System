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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCnt_Click(object sender, EventArgs e)
        {
            if (radStudent.Checked)
            {
                loginStudent st = new loginStudent();
                this.Hide();
                st.Show();
            }
            if(radAdmin.Checked)
            {
                loginAdmin ad = new loginAdmin();
                this.Hide();
                ad.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCnt.Enabled = false;
        }

        private void radAdmin_CheckedChanged(object sender, EventArgs e)
        {
            btnCnt.Enabled = true;
        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            btnCnt.Enabled = true;
        }
    }//Form1-welcome

}//namespace
