using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Windows.Forms;
using Oracle_App;

namespace ATBM
{
    public partial class Login : Form
    {
        private OracleConnection con = null;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string user = user_txtBox_login.Text;
            string password = pass_txtBox_login.Text;
            string connectionString = new ConnectionString(user, password).ToString();
            con = new OracleConnection(connectionString);
            
            // Connect
            try
            {
                con.Open(); // Connect to database
            }
            catch (Exception exp)
            {
                MessageBox.Show("User doesn't exists");
            }

            // Check
            if (user == "DBA_BV")
            {
                MessageBox.Show("Welcome DBA");

                this.Hide();
                Admin form = new Admin(user, password);
                form.Show();
            }
            else
            {
                MessageBox.Show("Login denied");
            }
            con.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(con != null)
                con.Close();
            Application.ExitThread();
        }
    }
}
