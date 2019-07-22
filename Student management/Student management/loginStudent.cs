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
    public partial class loginStudent : Form
    {
        public loginStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.readdata();
            for(int i=0;i<s1.student_list.Count;i++)
            {
                if(txtID.Text==s1.student_list[i].ID && txtPass.Text==s1.student_list[i].pass)
                {

                    s1.login2(txtID.Text);
                    StudentMenu sm = new StudentMenu();
                    this.Hide();
                    sm.Show();
                    return;
                }
            }
            lblReenter.Text = "Wrong ID or Password !";
            txtID.Clear();
            txtPass.Clear();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void loginStudent_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }
    }//class
}//namespace
