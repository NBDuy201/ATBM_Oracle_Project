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

        private bool Check_Role(int option)
        {
            // option:
            // 0: DBA (toàn quyền)
            // 1: Bác Sĩ
            // 2: Bệnh Nhân
            // 3: Thanh Tra
            // 4: Nghiên Cứu
            // 5: Cơ Sở Y Tế
            // 6: DBA (ở Phân hệ 2)

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
                        "Where granted_role = 'BAC_SI'"; // Sql statement
                    break;
                case 2:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'BENH_NHAN'"; // Sql statement
                    break;
                case 3:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'THANH_TRA'"; // Sql statement
                    break;
                case 4:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'NGHIEN_CUU'"; // Sql statement
                    break;
                case 5:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = upper('CoSo_YTe')"; // Sql statement
                    break;
                case 6:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'DBA_2'"; // Sql statement
                    break;
            }

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            int count = dt.Rows.Count;
            if (count == 1)
            {
                // DBA_BV dang nhap vo tai khoan khac
                if (user_txtBox_login.Text == "DBA_BV" && (VaiTro_cm.Text == "Admin" || VaiTro_cm.Text == "Admin 2"))
                    return true;
                else if (user_txtBox_login.Text != "DBA_BV")
                    return true;
                return false;
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
                return;
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
                case "Admin 2":
                    if (Check_Role(0) == true)
                    {
                        this.Hide();

                        Form_DBA form7 = new Form_DBA(user, password);
                        con.Close();
                        form7.ShowDialog();

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
