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
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentMenu sm = new StudentMenu();
            this.Hide();
            sm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            if (txtPass.Text == txtConfirmPass.Text)
            {
                s1.editdata(txtName.Text, txtPass.Text);
                lblSaved.Text = "Saved !";
                label2.Hide();
            }
            else
            {
                label2.Text = "*Password doesn't match !!";
                txtConfirmPass.Clear();
            }

              

          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            var t = Task.Delay(2000);
            t.Wait();
            txtPass.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = false;
            var t = Task.Delay(2000);
            t.Wait();
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void EditData_Load(object sender, EventArgs e)
        {
           

        }

      
    }
}
