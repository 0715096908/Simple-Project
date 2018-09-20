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
    public partial class deletestudent : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public deletestudent()
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
                        MessageBox.Show("Invalid username/password, please try again");
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            administrator adm = new administrator();
            adm.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            try
            {
                if(this.OpenConnection()==true)
                {
                if (txtreg.Text.Length > 0)
                {                                     
                    string query = "DELETE FROM addstudent WHERE regno='" + txtreg.Text + "'";

                    if (MessageBox.Show("Do you want to delete this record?", "Delete Reqeust", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        cmd = new MySqlCommand(query, connection);

                        int RowsAffected = cmd.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Record Deleted sucessfully!", "Deleted Record");
                            txtreg.Text = "";
                            this.closeConnection();
                           
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("Delete cancelled");
                      this.closeConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete data!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.closeConnection();
                }
                }
                    else
                    {
                        MessageBox.Show("Check your connection and try again!!");
        
                    }
            

            }

            catch (Exception ex)
            {
                MessageBox.Show( "Unable to delete " + ex.Message);
                this.closeConnection();
            }

           /* string query = "DELETE FROM addstudent WHERE regno='" + txtreg.Text + "'";

            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted successfully!!.");
                        this.closeConnection();
                        txtreg.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Record could not be deleted!!. Please try again.");
                        this.closeConnection();

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }*/

        }

        private void deletestudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
