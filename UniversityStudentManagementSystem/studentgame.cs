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
    public partial class studentgame : Form
    {
        public studentgame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            MessageBox.Show("WELCOME TO THE GAME CHALLENGE!!! DO YOUR BEST!!!","Tony Blair",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I HOPE YOU ENJOYED THE GAME. \n COME BACK AGAIN.","Tony Blair",MessageBoxButtons.OK, MessageBoxIcon.None);
            social sc = new social();
            sc.Show();
            this.Hide();
        }
    }
}
