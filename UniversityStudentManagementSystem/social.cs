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
    public partial class social : Form
    {
        public social()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {           
            studes sd = new studes();
            sd.Show();
            this.Hide();
            
        }

        private void btngoogle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.google.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void btngmail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.gmail.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void btnfacebook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void btnyahoo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.yahoo.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void btninstagram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.instagram.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void btntwitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.twitter.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void btnyoutube_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void btnamazon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.amazon.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void social_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1game_Click(object sender, EventArgs e)
        {
            studentgame sg = new studentgame();
            sg.Show();
            this.Hide();
        }
    }
}
