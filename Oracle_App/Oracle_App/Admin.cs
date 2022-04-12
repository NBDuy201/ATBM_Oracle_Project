﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace Oracle_App
{
    public partial class Admin : Form
    {
        // Instance connection object
        private OracleConnection con = null;
        public string username = null;
        public string password = null;

        public Admin(string user, string pass)
        {
            // User + pass from login
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();

            Priv_comboBox_tab4.Items.Add("SELECT");
            Priv_comboBox_tab4.Items.Add("UPDATE");
            Priv_comboBox_tab4.Items.Add("DELETE");
            Priv_comboBox_tab4.Items.Add("INSERT");
            Priv_comboBox_tab4.Items.Add("EXEC");

            VAITRO_cmbBox_tab6.Items.Add("Thanh tra");
            VAITRO_cmbBox_tab6.Items.Add("Cơ sở y tế");
            VAITRO_cmbBox_tab6.Items.Add("Bác sĩ");
            VAITRO_cmbBox_tab6.Items.Add("Nghiên cứu");

            PHAI_cmbBox_tab6.Items.Add("Nam");
            PHAI_cmbBox_tab6.Items.Add("Nữ");
            PHAI_cmbBox_tab6.Items.Add("Khác");

            // Datagridview
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView5.EnableHeadersVisualStyles = false;
            dataGridView5.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView5.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView5.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView6.EnableHeadersVisualStyles = false;
            dataGridView6.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView6.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView7.EnableHeadersVisualStyles = false;
            dataGridView7.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView7.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
        }

        private void setConnection()
        {
            string connectionString = new ConnectionString(username, password).ToString();
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
            }
            catch(Exception exp)
            {
                con.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            DataTable dt = LoadUser(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;

            dt = LoadCSYT();
            dataGridView4.DataSource = dt.DefaultView;

            dt =LoadNhanVien();
            dataGridView5.DataSource = dt.DefaultView;

            DataTable dt2 = LoadCSYT();
            CSYT_cmbBox_tab6.DataSource = dt2;
            CSYT_cmbBox_tab6.DisplayMember = "MACSYT";
            CSYT_cmbBox_tab6.AutoCompleteMode = AutoCompleteMode.Suggest;
            CSYT_cmbBox_tab6.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
        }

        private void IAD_CSYT(String sql_stm, int state) // insert + update + delete
        {
            String msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stm;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = MACSYT_txtBox_tab5.Text;
                    cmd.Parameters.Add("TENCSYT", OracleDbType.Varchar2, 50).Value = TENCSYT_txtBox_tab5.Text;
                    cmd.Parameters.Add("DCCSYT", OracleDbType.Varchar2, 250).Value = DCCSYT_txtBox_tab5.Text;
                    cmd.Parameters.Add("SDTCSYT", OracleDbType.Varchar2, 12).Value = SDTCSYT_txtBox_tab5.Text;
                    msg = "Inserted Successfully";
                    break;
                case 1:
                    cmd.Parameters.Add("TENCSYT", OracleDbType.Varchar2, 50).Value = TENCSYT_txtBox_tab5.Text;
                    cmd.Parameters.Add("DCCSYT", OracleDbType.Varchar2, 250).Value = DCCSYT_txtBox_tab5.Text;
                    cmd.Parameters.Add("SDTCSYT", OracleDbType.Varchar2, 12).Value = SDTCSYT_txtBox_tab5.Text;
                    cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = MACSYT_txtBox_tab5.Text;
                    msg = "Updated Successfully";
                    break;
            }
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    DataTable dt = LoadCSYT();
                    dataGridView4.DataSource = dt.DefaultView;
                }
                else
                {
                    string message = "Nothing Happened";
                    string title = "Warning";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                throw;
            }
        }

        private void Insert_btn_tab5_Click(object sender, EventArgs e)
        {
            String sql = "Insert into CSYT(MACSYT, TENCSYT, DCCSYT, SDTCSYT) " +
                "Values(:MACSYT, :TENCSYT, :DCCSYT, :SDTCSYT)";
            this.IAD_CSYT(sql, 0); // insert
        }

        private void Update_btn_tab5_Click(object sender, EventArgs e)
        {
            String sql = "Update CSYT set " +
                "TENCSYT = :TENCSYT, " +
                "DCCSYT = :DCCSYT, " +
                "SDTCSYT = :SDTCSYT " +
                "Where MACSYT = :MACSYT";
            this.IAD_CSYT(sql, 1); // update
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void Reset_btn_tab5_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            Insert_btn_tab5.Enabled = true;
            Update_btn_tab5.Enabled = false;

            MACSYT_txtBox_tab5.Enabled = true;
        }

        private DataTable LoadNhanVien()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from NhanVien"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadCSYT()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from CSYT"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadUser()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "view_users"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("out_usersList", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadRole()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "view_roles"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("out_rolesList", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadTable()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "view_all_tables"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("out_tableList", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadView()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "view_all_views"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("out_viewList", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadProc()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "view_all_proc"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("out_procList", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private void View_user_button_Click1(object sender, EventArgs e)
        {
            DataTable dt = LoadUser(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void View_user_button_Click2(object sender, EventArgs e)
        {
            DataTable dt = LoadUser(); // Data table object
            dataGridView2.DataSource = dt.DefaultView;
        }

        private void LoadPriv(TextBox textBox, DataGridView dgv, int option)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement

            if (option == 0)
            {
                cmd.CommandText = "view_allPrivi"; // Sql statement
            }
            else
            {
                switch (option)
                {
                    case 1:
                        cmd.CommandText = "view_privi"; // Sql statement
                        break;
                    case 2:
                        cmd.CommandText = "view_sysPrivi"; // Sql statement
                        break;
                    case 3:
                        cmd.CommandText = "view_grantedRole"; // Sql statement
                        break;
                    case 4:
                        cmd.CommandText = "view_colPriv"; // Sql statement
                        break;
                    default:
                        break;
                }
                cmd.Parameters.Add("in_user", OracleDbType.Varchar2, 30).Value = textBox.Text;
            }
            cmd.Parameters.Add("T_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            dgv.DataSource = dt.DefaultView;
        }

        private void View_AllObj_priv_button_Click(object sender, EventArgs e)
        {
            LoadPriv(Table_View_SP_txtBoxl_tab4, dataGridView1, 0); // luoi
        }

        private void Create_user_button2_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Grant_NewUser"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("User_name", OracleDbType.Varchar2, 100).Value = User_textbox_tab2.Text;
            cmd.Parameters.Add("Pass_Word", OracleDbType.Varchar2, 100).Value = Pass_textbox_tab2.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                //MessageBox.Show(n.ToString());
                if (n != 0)
                {
                    MessageBox.Show("User Created");
                    DataTable dt = LoadUser(); // Data table object
                    dataGridView2.DataSource = dt.DefaultView;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        private void Delete_user_button2_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Drop_User"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("User_name", OracleDbType.Varchar2, 100).Value = SelectedUser_textbox_tab2.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                //MessageBox.Show(n.ToString());
                if (n != 0)
                {
                    MessageBox.Show("User dropped");
                    DataTable dt = LoadUser(); // Data table object
                    dataGridView2.DataSource = dt.DefaultView;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        private void View_role_button_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadRole(); // Data table object
            dataGridView3.DataSource = dt.DefaultView;
        }

        private void Create_role_button_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Create_Role"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("Role_Name", OracleDbType.Varchar2, 100).Value = Role_textbox_tab3.Text;
            cmd.Parameters.Add("Pass_Word", OracleDbType.Varchar2, 100).Value = Pass_textbox_tab3.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Role created");
                    DataTable dt = LoadRole(); // Data table object
                    dataGridView3.DataSource = dt.DefaultView;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[index];
                SelectedUser_textbox_tab2.Text = selectedRow.Cells[0].Value.ToString();

                //Add_button.Enabled = false;
                //Update_button.Enabled = true;
                //Delete_button.Enabled = true;
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[index];
                SelectedRole_textbox_tab3.Text = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void Drop_role_button_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Delete_Role"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("p_role", OracleDbType.Varchar2, 100).Value = SelectedRole_textbox_tab3.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                //MessageBox.Show(n.ToString());
                if (n != 0)
                {
                    MessageBox.Show("Role dropped");
                    DataTable dt = LoadRole(); // Data table object
                    dataGridView3.DataSource = dt.DefaultView;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        private void ChangePass_button_tab3_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Alter_Role"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("Role_name", OracleDbType.Varchar2, 100).Value = SelectedRole_textbox_tab3.Text;
            cmd.Parameters.Add("Pass_Word", OracleDbType.Varchar2, 100).Value = NewPass_textbox_tab3.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Role altered");
                    DataTable dt = LoadRole(); // Data table object
                    dataGridView3.DataSource = dt.DefaultView;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        private void ChangePass_button_tab2_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Alter_User"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("Role_name", OracleDbType.Varchar2, 100).Value = SelectedUser_textbox_tab2.Text;
            cmd.Parameters.Add("Pass_Word", OracleDbType.Varchar2, 100).Value = NewPass_textbox_tab2.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("User altered");
                    DataTable dt = LoadUser(); // Data table object
                    dataGridView2.DataSource = dt.DefaultView;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        private void Priv_comboBox_tab4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Priv_comboBox_tab4.SelectedItem.ToString())
            {
                case "UPDATE":
                    Column_txtbox_tab4.Enabled = true;
                    break;
                default:
                    Column_txtbox_tab4.Clear();
                    Column_txtbox_tab4.Enabled = false;
                    break;
            }
        }

        private void ShowTable_btn_tab4_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadTable(); // Data table object
            dataGridView7.DataSource = dt.DefaultView;
        }

        private void ShowView_btn_tab4_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadView(); // Data table object
            dataGridView7.DataSource = dt.DefaultView;
        }

        private void ShowSP_btn_tab4_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadProc(); // Data table object
            dataGridView7.DataSource = dt.DefaultView;
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView7.Rows[index];
                Table_View_SP_txtBoxl_tab4.Text = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void Grant_btn1_tab4_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "GRANT_PRIVILEGES_USER"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2, 100).Value = User_Role_txtBox_tab4.Text;
            cmd.Parameters.Add("n_pri", OracleDbType.Varchar2, 100).Value = Priv_comboBox_tab4.SelectedItem.ToString();
            cmd.Parameters.Add("n_col", OracleDbType.Varchar2, 10).Value = Column_txtbox_tab4.Text;
            cmd.Parameters.Add("n_tab", OracleDbType.Varchar2, 100).Value = Table_View_SP_txtBoxl_tab4.Text;
            if (wgo_chckBox1_tab4.Checked)
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "TRUE";
            else
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "FALSE";

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Grant success");
                    User_Role_txtBox3_tab4.Text = User_Role_txtBox_tab4.Text;
                    LoadPriv(User_Role_txtBox3_tab4, dataGridView6, 1);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid privilege");
                throw;
            }
        }
       
        private void Grant_btn2_tab4_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "GRANT_PRIVILEGES_SYS_USER"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2, 100).Value = User_Role_txtBox2_tab4.Text;
            cmd.Parameters.Add("n_pri", OracleDbType.Varchar2, 100).Value = Priv_txtBox2_tab4.Text;
            if (wgo_chckBox2_Obj_tab4.Checked)
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "TRUE";
            else
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "FALSE";

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Grant success");
                    User_Role_txtBox3_tab4.Text = User_Role_txtBox2_tab4.Text;
                    LoadPriv(User_Role_txtBox3_tab4, dataGridView6, 2);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid privilege");
                throw;
            }
        }

        private void Grant_btn3_tab4_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "GRANT_ROLE_TO_USER"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("role_name", OracleDbType.Varchar2, 100).Value = Role_txtBox3_tab4.Text;
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2, 100).Value = User_txtBox3_tab4.Text;
            if (wgo_chckBox3_Obj_tab5.Checked)
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "TRUE";
            else
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "FALSE";

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Grant success");
                    User_Role_txtBox3_tab4.Text = User_txtBox3_tab4.Text;
                    LoadPriv(User_Role_txtBox3_tab4, dataGridView6, 3);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid privilege");
                throw;
            }
        }

        private void ViewPrivUser_Role_btn_tab4_Click(object sender, EventArgs e)
        {
            LoadPriv(User_Role_txtBox3_tab4, dataGridView6, 1);
        }

        private void ViewSysPriv_btn_tab4_Click(object sender, EventArgs e)
        {
            LoadPriv(User_Role_txtBox3_tab4, dataGridView6, 2);
        }

        private void ViewGrantedRole_btn_tab4_Click(object sender, EventArgs e)
        {
            LoadPriv(User_Role_txtBox3_tab4, dataGridView6, 3);
        }

        private void ViewColPriv_btn_tab4_Click(object sender, EventArgs e)
        {
            LoadPriv(User_Role_txtBox3_tab4, dataGridView6, 4);
        }

        public string[] res_CellClick_dtg6;
        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView6.Rows[index];
                string table = null;
                string priv = null;
                string g_role = null;

                string grantee = selectedRow.Cells["GRANTEE"].Value.ToString();
                if (dataGridView6.Columns.Contains("TABLE_NAME"))
                    table = selectedRow.Cells["TABLE_NAME"].Value.ToString();
                if (dataGridView6.Columns.Contains("GRANTED_ROLE"))
                    g_role = selectedRow.Cells["GRANTED_ROLE"].Value.ToString();
                if (dataGridView6.Columns.Contains("PRIVILEGE"))
                    priv = selectedRow.Cells["PRIVILEGE"].Value.ToString();

                res_CellClick_dtg6 = new string[] { grantee, table, priv, g_role }; // Add values to res
                //MessageBox.Show(res_CellClick_dtg6[0] + ' ' + res_CellClick_dtg6[1] + ' ' + res_CellClick_dtg6[2] + ' ' + res_CellClick_dtg6[3]);
            }
        }

        private void Revoke_btn_tab4_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Revoke_Privs"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("in_user", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg6[0];
            if(res_CellClick_dtg6[2] == null) // TH revoke role
                cmd.Parameters.Add("in_priv", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg6[3];
            else // Revoke privilege
                cmd.Parameters.Add("in_priv", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg6[2];
            cmd.Parameters.Add("in_obj", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg6[1];

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Revoke success");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        private void CSYT_txtBox_tab5_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CSYT_txtBox_tab5.Text))
            {
                DataTable dt = LoadCSYT(); // Data table object
                dataGridView4.DataSource = dt.DefaultView;
            }
        }

        private void CSYT_srchBtn_tab5_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from CSYT where lower(TENCSYT) like '%' || lower('" + CSYT_txtBox_tab5.Text + "') || '%'"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            dataGridView4.DataSource = dt.DefaultView;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView4.Rows[index];
                MACSYT_txtBox_tab5.Text = selectedRow.Cells["MACSYT"].Value.ToString();
                TENCSYT_txtBox_tab5.Text = selectedRow.Cells["TENCSYT"].Value.ToString();
                DCCSYT_txtBox_tab5.Text = selectedRow.Cells["DCCSYT"].Value.ToString();
                SDTCSYT_txtBox_tab5.Text = selectedRow.Cells["SDTCSYT"].Value.ToString();
            }

            Insert_btn_tab5.Enabled = false;
            Update_btn_tab5.Enabled = true;

            MACSYT_txtBox_tab5.Enabled = false;
        }

        private void NhanVien_srchBtn_tab6_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from NhanVien where lower(HOTEN) like '%' || lower('" + NhanVien_txtBox_tab6.Text + "') || '%'"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            dataGridView5.DataSource = dt.DefaultView;
        }

        private void NhanVien_txtBox_tab6_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NhanVien_txtBox_tab6.Text))
            {
                DataTable dt = LoadNhanVien();
                dataGridView5.DataSource = dt.DefaultView;
            }
        }

        private void Insert_btn_tab6_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText =
                "Insert into NHANVIEN(MANV, HOTEN, PHAI, NGAYSINH, CMND, QUEQUAN, SODT, CSYT, VAITRO, CHUYENKHOA) " +
                "Values(:MANV, :HOTEN, :PHAI, :NGAYSINH, :CMND, :QUEQUAN, :SODT, :CSYT, :VAITRO, :CHUYENKHOA)"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MANV", OracleDbType.Varchar2, 30).Value = MANV_txtBox_tab6.Text;
            cmd.Parameters.Add("HOTEN", OracleDbType.NVarchar2, 50).Value = HOTEN_txtBox_tab6.Text;
            // Ko chon combobox
            if (PHAI_cmbBox_tab6.SelectedIndex != -1)
                cmd.Parameters.Add("PHAI", OracleDbType.NVarchar2, 20).Value = PHAI_cmbBox_tab6.SelectedItem.ToString();
            else
                cmd.Parameters.Add("PHAI", OracleDbType.NVarchar2, 20).Value = null;
            cmd.Parameters.Add("NGAYSINH", OracleDbType.Date).Value = NGAYSINH_picker_tab6.Text;
            //cmd.Parameters.Add("NGAYSINH", OracleDbType.Date).Value = null;
            cmd.Parameters.Add("CMND", OracleDbType.Varchar2, 12).Value = CMND_txtBox_tab6.Text;
            cmd.Parameters.Add("QUEQUAN", OracleDbType.NVarchar2, 50).Value = QUEQUAN_txtBox_tab6.Text;
            cmd.Parameters.Add("SODT", OracleDbType.Varchar2, 50).Value = SODT_txtBox_tab6.Text;
            cmd.Parameters.Add("CSYT", OracleDbType.Varchar2, 30).Value = CSYT_cmbBox_tab6.Text;
            // Ko chon combobox
            if (VAITRO_cmbBox_tab6.SelectedIndex != -1)
                cmd.Parameters.Add("VAITRO", OracleDbType.NVarchar2, 50).Value = VAITRO_cmbBox_tab6.SelectedItem.ToString();
            else
                cmd.Parameters.Add("VAITRO", OracleDbType.NVarchar2, 50).Value = null;
            cmd.Parameters.Add("CHUYENKHOA", OracleDbType.NVarchar2, 50).Value = CHUYENKHOA_txtBox_tab6.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Insert Successfull");
                    DataTable dt = LoadNhanVien(); // Data table object
                    dataGridView5.DataSource = dt.DefaultView;
                }
                else
                {
                    string message = "Nothing Happened";
                    string title = "Warning";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                //throw;
            }
        }

        private void Reset_btn_tab6_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            PHAI_cmbBox_tab6.SelectedIndex = -1;
            VAITRO_cmbBox_tab6.SelectedIndex = -1;
            CSYT_cmbBox_tab6.SelectedIndex = -1;
            NGAYSINH_picker_tab6.Value = DateTimePicker.MinimumDateTime;
        }
    }
}