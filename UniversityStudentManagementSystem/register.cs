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
    public partial class register : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public register()
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

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtoname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {            
            student st = new student();
            st.Show();
            this.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            

            string query = "INSERT INTO studentregister(firstname, othername, gender, idno, course,userid) VALUES('" + txtfname.Text + "','" + txtoname.Text + "', '" + gender + "','" + txtid.Text + "','" + cmbcourse.SelectedItem + "','" + txtuseridd.Text + "')";
            if ((txtfname.Text.Length > 0) && (txtoname.Text.Length > 0) && (txtuseridd.Text.Length >= 4)  &&   (txtid.Text.Length >= 7))
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration details submitted. Click OK to set up your password. Thank you.","REGISTRATION CONFIRMED!!", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        this.closeConnection();                                                              
                        txtfname.Text = "";                    
                        txtoname.Text = "";
                        txtid.Text = "";                       
                       
                        cmbcourse.SelectedItem = "";                       
                        password ps = new password(txtuseridd.Text);
                        ps.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Details not submitted. Check the connection and try again.", "CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk
                            );


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

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        public string gender { get; set; }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void register_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtreg_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
