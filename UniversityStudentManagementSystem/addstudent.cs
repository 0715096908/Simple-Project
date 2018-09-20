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
    public partial class addstudent : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public addstudent()
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
        private void addstudent_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtemail.Text = "";
            txtfname.Text = "";
            txtidno.Text = "";
            txtoname.Text = "";
            txtphone.Text = "";
            txtreg.Text = "";
            txtyear.Text = "";
            cmbcourse.Text = "";
            administrator adm = new administrator();
            adm.Show();
            this.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO addstudent(firstname, othername, regno, idno, yearofstudy, course, email, phoneno, address, gender) VALUES('" + txtfname.Text + "','" + txtoname.Text + "','" + txtreg.Text + "','"+txtidno.Text+"','"+txtyear.Text+"','"+cmbcourse.SelectedItem+"','"+txtemail.Text+"','"+txtphone.Text+"','"+txtaddress.Text+"','"+gender+"')";
            if ((txtfname.Text.Length > 0) && (txtoname.Text.Length > 0) && (txtreg.Text.Length >= 4) && (txtemail.Text.Contains("@")) && (txtyear.Text.Length > 0) && (txtphone.Text.Length >= 8) && (txtidno.Text.Length >= 7) && (txtaddress.Text.Length >= 4) && (txtfname.Text.Length > 0))
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your details added successfully!!. Thank you.","STUDENT DETAILS ADDED SUCCESSFULLY!!!", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        this.closeConnection();
                        txtaddress.Text = "";
                        txtemail.Text = "";
                        txtfname.Text = "";
                        txtidno.Text = "";
                        txtoname.Text = "";
                        txtphone.Text = "";
                        txtreg.Text = "";
                        txtyear.Text = "";                     
                        cmbcourse.Text = "";
                        addstudent add = new addstudent();
                        add.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Details not added. Check the connection and try again.");
                       
                                             

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

        private void radioButton1male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
         

        }

        public string gender { get; set; }

        private void radioButton2female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void dateTimePickerone_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void addstudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void cmbcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
