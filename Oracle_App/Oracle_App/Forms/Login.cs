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
using Oracle_App.Forms;

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
            
            // Ham kiem tra dieu kien login dua tren cac bang + storeproc

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
            switch (VaiTro_cm.SelectedItem)
            {
                case "Admin":
                    MessageBox.Show("Welcome DBA");

                    this.Hide();
                    Admin form1 = new Admin(user, password);
                    form1.Show();
                    con.Close();
                    break;
                case "Thanh Tra":
                    this.Hide();
                    Form_ThanhTra form2 = new Form_ThanhTra(user, password);
                    form2.Show();
                    con.Close();
                    break;
                case "Cơ Sở Y Tế":
                    this.Hide();
                    Form_CoSoYTe form3 = new Form_CoSoYTe(user, password);
                    con.Close();
                    form3.Show();
                    break;
                // Viet tiep o day
                case "Bác Sĩ":
                    this.Hide();
                    Form_BacSi form4 = new Form_BacSi(user, password);
                    con.Close();
                    form4.Show();
                    break;
            }
            con.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(con != null)
                con.Close();
            Application.ExitThread();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            VaiTro_cm.SelectedIndex = 0;
        }
    }
}
