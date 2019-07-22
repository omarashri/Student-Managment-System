using System;
using System.IO;
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
    public partial class AvCourses : Form
    {



        public AvCourses()
        {
            InitializeComponent();
            
            Student s1 = new Student();
            List<string> x = new List<string>();
            
            x = s1.avcourse();

            listBox1.Items.Clear();
           
            for (int i = 0; i < x.Count; i++)
            {
                listBox1.Items.Add(x[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
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


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }
    }
}
