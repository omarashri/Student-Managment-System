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
    public partial class AdminEdit : Form
    {
        public AdminEdit()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // Admin admnedit = new Admin();
           // admnedit.editcoursedata(txtOldName.Text, txtName.Text, txtCode.Text, Convert.ToInt32(txtMax.Text), Convert.ToInt32(txtNoSt.Text), txtPrecrs.Text, txtHrs.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminmenu admn_menu = new adminmenu();
            this.Hide();
            admn_menu.Show();
        }

        private void AdminEdit_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
        }

        private void txtOldName_TextChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Courses crs = new Courses();
            crs.read();
            for(int i=0;i<crs.course_list.Count;i++)
            {
                if(txtOldName.Text==crs.course_list[i].name)
                {
                    Admin admnedit = new Admin();
                    admnedit.editcoursedata(txtOldName.Text, txtName.Text, txtCode.Text, Convert.ToInt32(txtMax.Text), Convert.ToInt32(txtNoSt.Text), txtPrecrs.Text, txtHrs.Text);
                    return;
                }
                
            }
            lblerror.Text = "*Course name not found !";
           
        }
    }
}