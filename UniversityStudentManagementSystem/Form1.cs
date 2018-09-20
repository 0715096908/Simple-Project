using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UniversityStudentManagementSystem
{
    public partial class splash : Form
    {
        private MySqlConnection connection;
        private string server ;
        private string database;
        private string uid;
        private string password;

        int progress = 0;
        public splash()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MessageBox.Show("WELCOME TO UNIVERSITY STUDENT MANAGEMENT SYSTEM.","UNIVERSITY STUDENT MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.None);
            server = "localhost";
            database = "university";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();              
                return true;
            }
            catch (MySqlException ex)
            {
               
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact the administrator!!!");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username or password, please try again");
                        break;
                }
                return false;
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
             progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                main mn = new main();
                mn.Show();
            }
            else
            {
                progressBar1.Value = progress;
            }
          
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void splash_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
            timer1.Interval = 200;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splash_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* if (e.CloseReason == CloseReason.UserClosing)
            {
                MessageBox.Show("You might lose important data.\n It is not good exiting this way.\n You should folow the normal exit way.", "WRONG EXIT METHOD", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Cancel = true;

            }*/

            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}