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
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            lstBoxCondition.Items.Clear();
            Student s1 = new Student();
           

            List<string> availables = new List<string>();
            availables = s1.avcourse();
            for (int i = 0; i < availables.Count; i++)
            {
                if(txtName.Text==availables[i])
                {
                    string conditon1;
                    conditon1 = s1.register(txtName.Text);
                    lstBoxCondition.Items.Add(conditon1);
                    return;
                }
            }
            lblError.Text = "*Not available !!";
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

        private void Registeration_Load(object sender, EventArgs e)
        {
            Student s1 = new Student();
            List<string> availables = new List<string>();
            availables = s1.avcourse();
            for(int i=0;i<availables.Count;i++)
            {
                lstavailable.Items.Add(availables[i]);
            }
        }
    }
}
