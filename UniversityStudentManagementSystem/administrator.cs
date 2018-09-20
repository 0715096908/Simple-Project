using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityStudentManagementSystem
{
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void administrator_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            adminconnect cn = new adminconnect();
            cn.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            addstudent add = new addstudent();
            add.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            updatestudents upd = new updatestudents();
            upd.Show();
            this.Hide();
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            deletestudent dt = new deletestudent();
            dt.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            searchstudent st = new searchstudent();
            st.Show();
            this.Hide();
        }

        private void administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }

            }
        }

    }

