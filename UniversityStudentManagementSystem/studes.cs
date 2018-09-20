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
    public partial class studes : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public studes()
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


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {          
            student sta = new student();
            sta.Show();
            this.Hide();
        }        

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtregnumber.Text.Length > 0)
               {
            try
            {
               

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    string query = "select * from  addstudent where regno='"+txtregnumber.Text+"'";
                    cmd.CommandText = query;
                    MySqlDataAdapter dsa = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dsa.Fill(dt);
                    dview.DataSource = dt;
                    txtregnumber.Text = "";
                    this.closeConnection();                                                                              
                }
                else
                {
                    MessageBox.Show("Failed to load. Please check the connection and try again!");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect", ex.Message);
                this.closeConnection();
            }

            }
                else
                {
                    MessageBox.Show("Enter your registration number please!!!");
                }

        }

        private void studes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void studes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            capture cp = new capture();
            cp.Show();
            this.Hide();
        }
    }
    }

