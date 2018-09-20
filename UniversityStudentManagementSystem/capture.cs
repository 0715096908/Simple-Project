using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityStudentManagementSystem
{
    public partial class capture : Form
    {
        int Progress=0;
        public capture()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {         
            studes sd = new studes();
            sd.Show();
            this.Hide();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (txtnetwork.Text.Equals("pass"))
            {
                timer1.Enabled = true;
                timer1.Interval = 100;
            }
            else
            {
               MessageBox.Show("WRONG UNIVERSITY SERVICE CODE!!! \n PLEASE USE THE CORRECT SERVICE CODE!!!", "WRONG CODE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             }
                
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progress += 1;
            if (Progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("The code confirmed! Proceed.", "CONFIRMATION DONE",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                social sc = new social();
                sc.Show();
                this.Hide();
            }
            else
            {
                progressBar2.Value = Progress;
            }
        }

        private void capture_Load(object sender, EventArgs e)
        {
           
        }

        private void capture_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
