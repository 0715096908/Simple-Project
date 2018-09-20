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
    public partial class adminconnect : Form
    {
        public adminconnect()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnviber_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.viber.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            administrator adm = new administrator();
            adm.Show();
            this.Hide();
        }

        private void btngoogle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancel the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) 
               
            {
                System.Diagnostics.Process.Start("https://www.google.com/");
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

        private void btnopera_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) 
            {
                System.Diagnostics.Process.Start("https://www.opera.com/");
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

        private void btnskype_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) 
            {
                System.Diagnostics.Process.Start("https://www.skype.com/");
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

        private void btnchrome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We wish you a happy browsing experience.\nClick yes to continue or no to cancell the connection...", " Browse the web", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) 
            {
                System.Diagnostics.Process.Start("https://www.chrome.com/");
            }
            else
            {
                MessageBox.Show("You cancelled the connection. You can still connect again!!");
            }
        }

        private void adminconnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
