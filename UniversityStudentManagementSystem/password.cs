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
    public partial class password : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string conn;        
        public password(string value)
        {
            InitializeComponent();
            txtuserid.Text = value;
            StartPosition = FormStartPosition.CenterScreen;
            server = "localhost";
            database = "university";
            uid = "root";
            conn = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + conn+ ";";
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

        private void btnsubmitt_Click(object sender, EventArgs e)
        {
            string query = "UPDATE studentregister SET password='"+txtpass.Text+"' WHERE userid ='"+ txtuserid.Text +"'";
            if (txtpass.Text.Contains(txtconfam.Text))
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                          int RowsAffected=cmd.ExecuteNonQuery();

                        if (RowsAffected >0)
                        {                      
                           MessageBox.Show("Your password has been set successfully. Click OK to access the login page. Thank you.", "PASSWORD SET!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                           this.closeConnection();
                           txtuserid.Text = "";
                           txtpass.Text = "";
                           txtconfam.Text = "";
                           student stu = new student();
                           stu.Show();
                           this.Hide();
                       }
                       else
                       {
                           MessageBox.Show("Registration number not found.Use the correct registration number please!!!","FAILED",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                           this.closeConnection();
                       }
                    }
                        else
                        {
                            MessageBox.Show("Check the connection and try again.","CONNECTION ERROR",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        
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
                MessageBox.Show("Make your entries valid and the passwords must be the same!!!");

            }
            
            
        }

        private void password_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
