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
    public partial class loginAdmin : Form
    {
        public loginAdmin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin objectadmin = new Admin();
            if (txtID.Text == objectadmin.id && txtPass.Text == objectadmin.password)
            {
                adminmenu menu = new adminmenu();
                this.Hide();
                menu.Show();
            }
            else
            {
                txtID.Clear();
                txtPass.Clear();
                txtID.Focus();
                lblReq.Text = "Wrong Username or Password !";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void loginAdmin_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }
    }
}
