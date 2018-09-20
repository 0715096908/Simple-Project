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
    public partial class searchstudent : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        
        public searchstudent()
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
        private void btnclose_Click(object sender, EventArgs e)
        {
            administrator adm = new administrator();
            adm.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {


            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    string query = "select * from  addstudent";
                    cmd.CommandText = query;
                    MySqlDataAdapter dsa = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dsa.Fill(dt);
                    dgrid.DataSource = dt;
                    this.closeConnection();
                    
                }
                else
                {
                    MessageBox.Show("Failed to load. Please check the connection and try again!");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect",ex.Message);
                this.closeConnection();
            }



        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

                
               // DataView dv = new DataView(dt);
               //dv.RowFilter = string.Format("reg LIKE '%{0}%'", txtsearch.Text);
               //dgrid.DataSource = dv;

            BindingSource bs = new BindingSource();
            bs.DataSource = dgrid.DataSource;
            bs.Filter ="firstname like '%" + txtsearch.Text + "%'";
            dgrid.DataSource=bs;

            

        }

        private void searchstudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void searchstudent_Load(object sender, EventArgs e)
        {

        }
    }
}
