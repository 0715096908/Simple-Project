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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" I CAN SEE YOU GO. WELCOME BACK AGAIN", "",MessageBoxButtons.OK,MessageBoxIcon.None);
            main mne = new main();
            mne.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void about_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            question qas = new question();
            qas.Show();
            this.Hide();
        }
    }
}
