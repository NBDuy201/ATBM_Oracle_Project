using System;
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
    public partial class Form2 : Form
    {
        // Instance connection object
        private OracleConnection con = null;
        public string username = null;
        public string password = null;

        public Form2(string user, string pass)
        {
            // User + pass from login
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();

            Priv_comboBox_tab5.Items.Add("SELECT");
            Priv_comboBox_tab5.Items.Add("UPDATE");
            Priv_comboBox_tab5.Items.Add("DELETE");
            Priv_comboBox_tab5.Items.Add("INSERT");
            Priv_comboBox_tab5.Items.Add("EXEC");

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
            DataTable dt = LoadUser(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
            Application.ExitThread();
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

        private void Reset_button_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            //Hire_Date_picker.Text = null;
            //Add_button.Enabled = true;
            //Update_button.Enabled = false;
            //Delete_button.Enabled = false;
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
            LoadPriv(Table_View_SP_txtBoxl_tab5, dataGridView1, 0); // luoi
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

        private void Priv_comboBox_tab5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Priv_comboBox_tab5.SelectedItem.ToString())
            {
                case "UPDATE":
                    Column_txtbox_tab5.Enabled = true;
                    break;
                default:
                    Column_txtbox_tab5.Clear();
                    Column_txtbox_tab5.Enabled = false;
                    break;
            }
        }

        private void ShowTable_btn_tab5_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadTable(); // Data table object
            dataGridView7.DataSource = dt.DefaultView;
        }

        private void ShowView_btn_tab5_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadView(); // Data table object
            dataGridView7.DataSource = dt.DefaultView;
        }

        private void ShowSP_btn_tab5_Click(object sender, EventArgs e)
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
                Table_View_SP_txtBoxl_tab5.Text = selectedRow.Cells[0].Value.ToString();
            }
        }
        private void Grant_btn1_tab5_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "GRANT_PRIVILEGES_USER"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2, 100).Value = User_Role_txtBox_tab5.Text;
            cmd.Parameters.Add("n_pri", OracleDbType.Varchar2, 100).Value = Priv_comboBox_tab5.SelectedItem.ToString();
            cmd.Parameters.Add("n_col", OracleDbType.Varchar2, 10).Value = Column_txtbox_tab5.Text;
            cmd.Parameters.Add("n_tab", OracleDbType.Varchar2, 100).Value = Table_View_SP_txtBoxl_tab5.Text;
            if (wgo_chckBox1_tab5.Checked)
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "TRUE";
            else
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "FALSE";

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Grant success");
                    User_Role_txtBox3_tab5.Text = User_Role_txtBox_tab5.Text;
                    LoadPriv(User_Role_txtBox3_tab5, dataGridView6, 1);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid privilege");
                throw;
            }
        }
       
        private void Grant_btn2_tab5_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "GRANT_PRIVILEGES_SYS_USER"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2, 100).Value = User_Role_txtBox2_tab5.Text;
            cmd.Parameters.Add("n_pri", OracleDbType.Varchar2, 100).Value = Priv_txtBox2_tab5.Text;
            if (wgo_chckBox2_Obj_tab5.Checked)
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "TRUE";
            else
                cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 5).Value = "FALSE";

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Grant success");
                    User_Role_txtBox3_tab5.Text = User_Role_txtBox2_tab5.Text;
                    LoadPriv(User_Role_txtBox3_tab5, dataGridView6, 2);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid privilege");
                throw;
            }
        }

        private void Grant_btn3_tab5_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "GRANT_ROLE_TO_USER"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("role_name", OracleDbType.Varchar2, 100).Value = Role_txtBox3_tab5.Text;
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2, 100).Value = User_txtBox3_tab5.Text;
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
                    User_Role_txtBox3_tab5.Text = User_txtBox3_tab5.Text;
                    LoadPriv(User_Role_txtBox3_tab5, dataGridView6, 3);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid privilege");
                throw;
            }
        }

        private void ViewPrivUser_Role_btn_tab5_Click(object sender, EventArgs e)
        {
            LoadPriv(User_Role_txtBox3_tab5, dataGridView6, 1);
        }

        private void ViewSysPriv_btn_tab5_Click(object sender, EventArgs e)
        {
            LoadPriv(User_Role_txtBox3_tab5, dataGridView6, 2);
        }

        private void ViewGrantedRole_btn_tab5_Click(object sender, EventArgs e)
        {
            LoadPriv(User_Role_txtBox3_tab5, dataGridView6, 3);
        }

        private void ViewColPriv_btn_tab5_Click(object sender, EventArgs e)
        {
            LoadPriv(User_Role_txtBox3_tab5, dataGridView6, 4);
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

        private void Revoke_btn_tab5_Click(object sender, EventArgs e)
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
    }
}
