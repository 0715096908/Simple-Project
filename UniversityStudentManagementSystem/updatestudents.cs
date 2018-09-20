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
    public partial class updatestudents : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        MySqlDataAdapter dsa ;
        DataTable dt ;
        DataSet ds;

        public updatestudents()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
        // DataTable dt;
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

        private void updatestudents_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                  //  MySqlCommand cmd = new MySqlCommand();
                   // cmd.Connection = connection;
                      dsa = new MySqlDataAdapter();
                      ds = new DataSet();
                      MySqlCommand cmd;
                    string query = "select * from  addstudent";
                    cmd = new MySqlCommand(query,connection);
                    dsa.SelectCommand = cmd;
                    dsa.Fill(ds,"addstudent");
                    dataGridView1.DataSource = ds.Tables[0];
                   // cmd.CommandText = query;
                    //dsa = new MySqlDataAdapter(cmd);
                    //dt = new DataTable();
                    //dsa.Fill(dt);
                    //dataGridView1.DataSource = dt;
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

        private void updatestudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1close_Click(object sender, EventArgs e)
        {
            administrator adm = new administrator();
            adm.Show();
            this.Hide();
        }

        
        private void button1update_Click(object sender, EventArgs e)
        {
            
            MySqlCommandBuilder cmb = new MySqlCommandBuilder(dsa);
            dsa.Update(ds, "addstudent");
            MessageBox.Show("Updated successfully");

        }
    }
}