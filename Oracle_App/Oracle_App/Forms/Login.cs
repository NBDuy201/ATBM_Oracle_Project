﻿using System;
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

        private bool Check_Role(int option)
        {
            // option:
            // 0: DBA
            // 1: Bác Sĩ
            // 2: Bệnh Nhân
            // 3: Thanh Tra
            // 4: Nghiên Cứu
            // 5: Cơ Sở Y Tế

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            switch (option)
            {
                case 0:
                    cmd.CommandText = 
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'DBA'"; // Sql statement
                    break;
                case 1:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'BacSi'"; // Sql statement
                    break;
                case 2:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'BenhNhan'"; // Sql statement
                    break;
                case 3:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'ThanhTra'"; // Sql statement
                    break;
                case 4:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'NghienCuu'"; // Sql statement
                    break;
                case 5:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'CoSoYTe'"; // Sql statement
                    break;
            }

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            int count = dt.Rows.Count;
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            switch (VaiTro_cm.SelectedItem)
            {
                case "Admin":
                    // Check exist
                    if(Check_Role(0) == true) 
                    {
                        MessageBox.Show("Welcome DBA");

                        this.Hide();

                        Admin form1 = new Admin(user, password);
                        con.Close();
                        form1.ShowDialog();

                        this.Close();
                    }
                    else
                        MessageBox.Show("User doesn't exists");
                    break;
                case "Thanh Tra":
                    if (Check_Role(3) == true)
                    {
                        this.Hide();

                        Form_ThanhTra form2 = new Form_ThanhTra(user, password);
                        con.Close();
                        form2.ShowDialog();

                        this.Close();
                    }
                    else
                        MessageBox.Show("User doesn't exists");
                    break;
                case "Cơ Sở Y Tế":
                    if (Check_Role(5) == true)
                    {
                        this.Hide();

                        Form_CoSoYTe form3 = new Form_CoSoYTe(user, password);
                        con.Close();
                        form3.ShowDialog();

                        this.Close();
                    }
                    else
                        MessageBox.Show("User doesn't exists");
                    break;
                // Viet tiep o day
                case "Bác Sĩ":
                    if (Check_Role(1) == true)
                    {
                        this.Hide();

                        Form_BacSi form4 = new Form_BacSi(user, password);
                        con.Close();
                        form4.ShowDialog();

                        this.Close();
                    }
                    else
                        MessageBox.Show("User doesn't exists");
                    break;
                case "Bệnh Nhân":
                    if (Check_Role(2) == true)
                    {
                        this.Hide();

                        Form_BenhNhan form5 = new Form_BenhNhan(user, password);
                        con.Close();
                        form5.ShowDialog();

                        this.Close();
                    }
                    else
                        MessageBox.Show("User doesn't exists");
                    break;
                case "Nghiên Cứu":
                    if (Check_Role(5) == true)
                    {
                        this.Hide();

                        Form_NghienCuu form6 = new Form_NghienCuu(user, password);
                        con.Close();
                        form6.ShowDialog();

                        this.Close();
                    }
                    else
                        MessageBox.Show("User doesn't exists");
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
