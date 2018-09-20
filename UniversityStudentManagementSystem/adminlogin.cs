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
    public partial class adminlogin : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public adminlogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            server = "localhost";
            database = "university";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        private void adminlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT username,password FROM adminlogin WHERE username= '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
            if ((txtusername.Text.Length > 0) && (txtpassword.Text.Length > 0))
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            MessageBox.Show("ADMIN LOGIN CONFIRMED.", "ADMINISTRATOR!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            rd.Close();
                            this.closeConnection();
                            txtusername.Text = "";
                            txtpassword.Text = "";
                            administrator ad = new administrator();
                            ad.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("ADMIN DETAILS NOT FOUND \n MAKE SURE YOU ARE THE AUTHENTIFIED ADMIN!!! .", "NOT REGISTERED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.closeConnection();
                            rd.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Check the connection and try again.", "CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.closeConnection();
                }

            }
            else
            {
                MessageBox.Show("Please make your entries valid!!!");

            }

        }
        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }


        private void btnback_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickertwo_ValueChanged(object sender, EventArgs e)
        {

        }


        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void adminlogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {


           DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

      
    }
}