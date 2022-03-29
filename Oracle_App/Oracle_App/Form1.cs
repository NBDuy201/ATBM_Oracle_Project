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
    public partial class Form1 : Form
    {
        // Instance connection object
        OracleConnection con = null;
        public Form1()
        {
            this.setConnection();
            InitializeComponent();

            Priv_comboBox_tab5.Items.Add("SELECT");
            Priv_comboBox_tab5.Items.Add("UPDATE");
            Priv_comboBox_tab5.Items.Add("DELETE");
            Priv_comboBox_tab5.Items.Add("INSERT");
            Priv_comboBox_tab5.Items.Add("EXEC");

            dataGridView7.EnableHeadersVisualStyles = false;
            dataGridView7.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView7.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView7.Font, FontStyle.Bold);
        }

        private void setConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HrDB"].ConnectionString;
            con = new OracleConnection(connectionString); // Oracle connection object
            try
            {
                con.Open();
            }
            catch(Exception exp)
            {

            }
        }

        private void updateDataGrid()
        {
            //OracleCommand cmd = con.CreateCommand();
            //cmd.CommandText = "Select Employee_ID, Last_Name, Email, Job_ID, Hire_Date from employees"; // Sql statement
            //cmd.CommandType = CommandType.Text; // Type of Sql statement
            //OracleDataReader dr = cmd.ExecuteReader(); // Execute sql statement
            //DataTable dt = new DataTable(); // Data table object
            //dt.Load(dr); // Save executed sql statement
            //dataGridView1.DataSource = dt.DefaultView;
            //dr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.updateDataGrid();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }

        private void IAD(String sql_stm, int state) // insert + update + delete
        {
            //String msg = "";
            //OracleCommand cmd = con.CreateCommand();
            //cmd.CommandText = sql_stm;
            //cmd.CommandType = CommandType.Text;

            //switch (state)
            //{
            //    case 0:
            //        cmd.Parameters.Add("EMPLOYEE_ID", OracleDbType.Int32, 6).Value = Int32.Parse(Employee_ID_textbox.Text);
            //        cmd.Parameters.Add("LAST_NAME", OracleDbType.Varchar2, 25).Value = Last_Name_textbox.Text;
            //        cmd.Parameters.Add("EMAIL", OracleDbType.Varchar2, 25).Value = Email_textbox.Text;
            //        cmd.Parameters.Add("JOB_ID", OracleDbType.Varchar2, 10).Value = Job_ID_textbox.Text;
            //        //cmd.Parameters.Add("HIRE_DATE", OracleDbType.Date, 7).Value = Hire_Date_picker.Text;
            //        cmd.Parameters.Add("HIRE_DATE", OracleDbType.Date, 7).Value = Hire_Date_picker.Value.ToShortDateString();
            //        msg = "Inserted Successfully";
            //        break;
            //    case 1:
            //        cmd.Parameters.Add("EMPLOYEE_ID", OracleDbType.Int32, 6).Value = Int32.Parse(Employee_ID_textbox.Text);
            //        cmd.Parameters.Add("LAST_NAME", OracleDbType.Varchar2, 25).Value = Last_Name_textbox.Text;
            //        cmd.Parameters.Add("EMAIL", OracleDbType.Varchar2, 25).Value = Email_textbox.Text;
            //        cmd.Parameters.Add("JOB_ID", OracleDbType.Varchar2, 10).Value = Job_ID_textbox.Text;
            //        cmd.Parameters.Add("HIRE_DATE", OracleDbType.Date, 7).Value = Hire_Date_picker.Value.ToShortDateString();
            //        msg = "Updated Successfully";
            //        break;
            //    case 2:
            //        cmd.Parameters.Add("EMPLOYEE_ID", OracleDbType.Int32, 6).Value = Int32.Parse(Employee_ID_textbox.Text);
            //        msg = "Deleted Successfully";
            //        break;
            //}

            //try
            //{
            //    int n = cmd.ExecuteNonQuery();
            //    if (n > 0)
            //    {
            //        MessageBox.Show(msg);
            //        this.updateDataGrid();
            //    }
            //}
            //catch (Exception exp)
            //{

            //    throw;
            //}
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            String sql = "Insert into EMPLOYEES(EMPLOYEE_ID, LAST_NAME, EMAIL, JOB_ID, HIRE_DATE)" +
                "Values(:EMPLOYEE_ID, :LAST_NAME, :EMAIL, :JOB_ID, :HIRE_DATE)";
            //String sql = "Insert into EMPLOYEES(EMPLOYEE_ID, LAST_NAME, EMAIL, JOB_ID)" +
            //    "Values(:EMPLOYEE_ID, :LAST_NAME, :EMAIL, :JOB_ID)";
            this.IAD(sql, 0); // insert
            Add_button.Enabled = false;
            Update_button.Enabled = true;
            Delete_button.Enabled = true;
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            String sql = "Update EMPLOYEES " +
                "set LAST_NAME = :LAST_NAME," +
                "JOB_ID = :JOB_ID," +
                "EMAIL = :EMAIL," +
                "HIRE_DATE = :HIRE_DATE " +
                "Where EMPLOYEE_ID = :EMPLOYEE_ID";

            //String sql = "Update EMPLOYEES " +
            //    "set LAST_NAME = :LAST_NAME," +
            //    "JOB_ID = :JOB_ID," +
            //    "EMAIL = :EMAIL " +
            //    "Where EMPLOYEE_ID = :EMPLOYEE_ID";
            this.IAD(sql, 1); // update
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            String sql = "Delete from EMPLOYEES "+
                "where EMPLOYEE_ID = :EMPLOYEE_ID";
            this.IAD(sql, 2); // delete
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                User_textbox.Text = selectedRow.Cells[0].Value.ToString();

                //Add_button.Enabled = false;
                //Update_button.Enabled = true;
                //Delete_button.Enabled = true;
            }
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

        private void View_privilege_button_Click(object sender, EventArgs e)
        {
            LoadPriv(User_textbox, dataGridView1, 0);
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
                MessageBox.Show(n.ToString());
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

        private void ViewPrivUser_btn_tab4_Click(object sender, EventArgs e)
        {
            LoadPriv(SelectedUser_txtbox_tab4, dataGridView4, 1);
        }

        private void ViewPrivRole_btn_tab4_Click(object sender, EventArgs e)
        {
            LoadPriv(SelectedRole_txtbox_tab4, dataGridView5, 1);
        }

        private void RevokeUser_btn_tab4_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Revoke_Privs_User"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("User_Name", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg4[0];
            cmd.Parameters.Add("priv", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg4[2];
            cmd.Parameters.Add("obj", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg4[1];

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Revoke success");
                    LoadPriv(SelectedUser_txtbox_tab4, dataGridView4, 1); // Refresh
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        public string[] res_CellClick_dtg4;
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView4.Rows[index];
                string grantee = selectedRow.Cells["GRANTEE"].Value.ToString();
                string table = selectedRow.Cells["TABLE_NAME"].Value.ToString();
                string priv = selectedRow.Cells["PRIVILEGE"].Value.ToString();

                res_CellClick_dtg4 = new string[] { grantee, table, priv }; // Add values to res
                //MessageBox.Show(res_CellClick_dtg4[0] + ' ' + res_CellClick_dtg4[1]);
            }
        }

        private void RevokeRole_btn_tab4_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Revoke_Privs_Role"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("a_role", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg5[0];
            cmd.Parameters.Add("TABLE_NAME", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg5[2];
            cmd.Parameters.Add("a_priv", OracleDbType.Varchar2, 100).Value = res_CellClick_dtg5[1];

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Revoke success");
                    LoadPriv(SelectedRole_txtbox_tab4, dataGridView5, 1); // Refresh
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        public string[] res_CellClick_dtg5;
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView5.Rows[index];
                string grantee = selectedRow.Cells["GRANTEE"].Value.ToString();
                string table = selectedRow.Cells["TABLE_NAME"].Value.ToString();
                string priv = selectedRow.Cells["PRIVILEGE"].Value.ToString();

                res_CellClick_dtg5 = new string[] { grantee, table, priv }; // Add values to res
                //MessageBox.Show(res_CellClick_dtg5[0] + ' ' + res_CellClick_dtg5[1]);
            }
        }

        private void Priv_comboBox_tab5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Priv_comboBox_tab5.SelectedItem.ToString())
            {
                case "SELECT":
                case "UPDATE":
                    Column_txtbox_tab5.Enabled = true;
                    break;
                default:
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
    }
}
