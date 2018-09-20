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
    public partial class student : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public student()
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

        private void student_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We can see you have exited.\n You can always come back.","",MessageBoxButtons.OK,MessageBoxIcon.None);
            question qas = new question();
            qas.Show();
            this.Hide();
        }

        private void btnREGISTER_Click(object sender, EventArgs e)
        {
            register rs = new register();
            rs.Show();
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string query = "SELECT userid,password FROM studentregister WHERE userid= '"+txtuserid.Text+"' AND password = '"+txtpass.Text+"'";                     
            if ((txtuserid.Text.Length > 0) &&(txtpass.Text.Length>0)) 
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            MessageBox.Show("Login details confirmed!. Click OK to proceed. Thank you.", "LOGIN CONFIRMED!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            rd.Close();
                            this.closeConnection();
                            txtuserid.Text = "";
                            txtpass.Text = "";
                            studes rs = new studes();
                            rs.Show();
                            this.Hide();
                
                        }
                        else
                        {
                            MessageBox.Show("login details not found.Register and try again.","NOT REGISTERED",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                            this.closeConnection();
                            rd.Close();
                        }
                                                
                    }
                    else
                    {
                        MessageBox.Show("Check the connection and try again.","CONNECTION ERROR",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);


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
                MessageBox.Show("Make your entries valid!");

            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void student_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
