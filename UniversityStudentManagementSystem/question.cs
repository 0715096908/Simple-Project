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
    public partial class question : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public question()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO comment(click, name, phoneno) VALUES('" + txtclick.Text + "','" + txtname.Text + "','" + txtphoneno.Text + "')";
            if ((txtname.Text.Length > 0) && (txtclick.Text.Length > 4) && (txtphoneno.Text.Length > 7))
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your comment sent successfully. Thank you.");
                        this.closeConnection();
                        txtclick.Text = "";
                        txtname.Text = "";
                        txtphoneno.Text = "";
                        main mn = new main();
                        mn.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show(" Check the connection and try again","CONNECTION ERROR",MessageBoxButtons.OK, MessageBoxIcon.None);
                                            

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
            if (MessageBox.Show("Your comment matters to me.\nYou can cancel and comment or just exit.", "Exit Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {                              
                    MessageBox.Show("Thank you. Come again!", "",MessageBoxButtons.OK,MessageBoxIcon.None);
                    main mn = new main();
                    mn.Show();
                    this.Hide();
                
            }
            else
            {
                MessageBox.Show("Your comment matters as it may help improve the quality of this software!!!");
            }

        }

        private void question_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
