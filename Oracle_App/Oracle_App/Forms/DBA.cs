using ATBM;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_App.Forms
{
    public partial class Form_DBA : Form
    {
        // Instance connection object
        private OracleConnection con = null;
        public string username = null;
        public string password = null;

        private void setConnection()
        {
            string connectionString = new ConnectionString(username, password).ToString();
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                con.Close();
            }
        }

        public Form_DBA(string user, string pass)
        {
            // User + pass from login
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();
        }

        private void Form_DBA_Load(object sender, EventArgs e)
        {
            // Gridview
            DataTable dt = LoadBenhNhan(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;

            dt = LoadCSYT(); // Data table object
            dataGridView2.DataSource = dt.DefaultView;

            dt = LoadNhanVien(); // Data table object
            dataGridView3.DataSource = dt.DefaultView;

            // Combobox
            DataTable dt2 = LoadCSYT();
            CSYT_cmbBox_tab1.DataSource = dt2;
            CSYT_cmbBox_tab1.DisplayMember = "MACSYT";
            CSYT_cmbBox_tab1.AutoCompleteMode = AutoCompleteMode.Suggest;
            CSYT_cmbBox_tab1.AutoCompleteSource = AutoCompleteSource.ListItems;

            CSYT_cmbBox_tab3.DataSource = dt2;
            CSYT_cmbBox_tab3.DisplayMember = "MACSYT";
            CSYT_cmbBox_tab3.AutoCompleteMode = AutoCompleteMode.Suggest;
            CSYT_cmbBox_tab3.AutoCompleteSource = AutoCompleteSource.ListItems;

            VaiTro_cm_tab1.SelectedIndex = 0;
            PHAI_cmbBox_tab3.SelectedIndex = 0;
            VAITRO_cmbBox_tab3.SelectedIndex = 0;
            CSYT_cmbBox_tab3.SelectedIndex = 0;
        }

        private void Form_DBA_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
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

        private void ViewBN_btn_tab1_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadBenhNhan(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;
        }

        private DataTable LoadBenhNhan()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from BENHNHAN"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private void ViewNV_btn_tab1_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadNhanVien(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;
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

        private void Grant_Role(string Role, string Username)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "GRANT_ROLE_TO_USER"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            switch (Role)
            {
                case "Thanh Tra":
                    Role = "THANH_TRA";
                    break;
                case "Cơ Sở Y Tế":
                    Role = "CoSo_YTe";
                    break;
                case "Bác Sĩ":
                    Role = "BAC_SI";
                    break;
                case "Bệnh Nhân":
                    Role = "BENH_NHAN";
                    break;
                case "Nghiên Cứu":
                    Role = "NGHIEN_CUU";
                    break;
            }
            cmd.Parameters.Add("role_name", OracleDbType.Varchar2, 50).Value = Role;
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2, 50).Value = Username;
            cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 50).Value = null;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Grant success");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Grant failed");
                throw;
            }
        }

        private void Create_user_button_tab1_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Grant_NewUser"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("User_name", OracleDbType.Varchar2, 100).Value = User_textbox_tab1.Text;
            cmd.Parameters.Add("Pass_Word", OracleDbType.Varchar2, 100).Value = Pass_textbox_tab1.Text;
            cmd.Parameters.Add("vaitro", OracleDbType.NVarchar2, 100).Value = VaiTro_cm_tab1.Text;
            cmd.Parameters.Add("CoSoYTe", OracleDbType.Varchar2, 100).Value = CSYT_cmbBox_tab1.Text;

            //MessageBox.Show(cmd.Parameters["CoSoYTe"].Value.ToString());

            try
            {
                int n = cmd.ExecuteNonQuery();
                //MessageBox.Show(n.ToString());
                if (n != 0)
                {
                    MessageBox.Show("User Created");
                    Grant_Role(VaiTro_cm_tab1.Text, User_textbox_tab1.Text); // Grant role for new user
                    
                    if (VaiTro_cm_tab1.Text == "Bệnh Nhân")
                    {
                        DataTable dt = LoadBenhNhan(); // Data table object
                        dataGridView1.DataSource = dt.DefaultView;
                    }
                    else
                    {
                        DataTable dt = LoadNhanVien(); // Data table object
                        dataGridView1.DataSource = dt.DefaultView;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Nothing happend!!!");
                throw;
            }
        }

        private void CSYT_srchBtn_tab2_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from CSYT where lower(TENCSYT) like '%' || :tenCS || '%'"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("tenCS", OracleDbType.NVarchar2, 100).Value = CSYT_txtBox_tab2.Text.ToLower();

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            dataGridView2.DataSource = dt.DefaultView;
        }

        private void CSYT_txtBox_tab2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CSYT_txtBox_tab2.Text))
            {
                DataTable dt = LoadCSYT(); // Data table object
                dataGridView2.DataSource = dt.DefaultView;
            }
        }

        private void IAD_CSYT(string sql_stm, int state) // insert + update + delete
        {
            string msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stm;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = MACSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("TENCSYT", OracleDbType.Varchar2, 50).Value = TENCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("DCCSYT", OracleDbType.Varchar2, 250).Value = DCCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("SDTCSYT", OracleDbType.Varchar2, 12).Value = SDTCSYT_txtBox_tab2.Text;
                    msg = "Inserted Successfully";
                    break;
                case 1:
                    cmd.Parameters.Add("TENCSYT", OracleDbType.Varchar2, 50).Value = TENCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("DCCSYT", OracleDbType.Varchar2, 250).Value = DCCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("SDTCSYT", OracleDbType.Varchar2, 12).Value = SDTCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = MACSYT_txtBox_tab2.Text;
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
                    dataGridView2.DataSource = dt.DefaultView;
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

        private void Insert_btn_tab2_Click(object sender, EventArgs e)
        {
            string sql = "Insert into CSYT(MACSYT, TENCSYT, DCCSYT, SDTCSYT) " +
                "Values(:MACSYT, :TENCSYT, :DCCSYT, :SDTCSYT)";
            this.IAD_CSYT(sql, 0); // insert
        }

        private void Update_btn_tab2_Click(object sender, EventArgs e)
        {
            string sql = "Update CSYT set " +
                "TENCSYT = :TENCSYT, " +
                "DCCSYT = :DCCSYT, " +
                "SDTCSYT = :SDTCSYT " +
                "Where MACSYT = :MACSYT";
            this.IAD_CSYT(sql, 1); // update
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[index];
                MACSYT_txtBox_tab2.Text = selectedRow.Cells["MACSYT"].Value.ToString();
                TENCSYT_txtBox_tab2.Text = selectedRow.Cells["TENCSYT"].Value.ToString();
                DCCSYT_txtBox_tab2.Text = selectedRow.Cells["DCCSYT"].Value.ToString();
                SDTCSYT_txtBox_tab2.Text = selectedRow.Cells["SDTCSYT"].Value.ToString();
            }

            Insert_btn_tab2.Enabled = false;
            Update_btn_tab2.Enabled = true;

            MACSYT_txtBox_tab2.Enabled = false;
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

        private void Reset_btn_tab2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            Insert_btn_tab2.Enabled = true;
            Update_btn_tab2.Enabled = false;

            MACSYT_txtBox_tab2.Enabled = true;
        }

        private void NhanVien_srchBtn_tab3_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from NHANVIEN where lower(HOTEN) like '%' || :tenNV || '%'"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("tenNV", OracleDbType.NVarchar2, 100).Value = NhanVien_txtBox_tab3.Text.ToLower();

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            dataGridView3.DataSource = dt.DefaultView;
        }

        private void NhanVien_txtBox_tab3_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NhanVien_txtBox_tab3.Text))
            {
                DataTable dt = LoadNhanVien(); // Data table object
                dataGridView3.DataSource = dt.DefaultView;
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
            cmd.Parameters.Add("MANV", OracleDbType.Varchar2, 30).Value = MANV_txtBox_tab3.Text;
            cmd.Parameters.Add("HOTEN", OracleDbType.NVarchar2, 50).Value = HOTEN_txtBox_tab3.Text;
            cmd.Parameters.Add("PHAI", OracleDbType.NVarchar2, 20).Value = PHAI_cmbBox_tab3.Text;
            cmd.Parameters.Add("NGAYSINH", OracleDbType.Date).Value = NGAYSINH_picker_tab3.Value.Date;
            cmd.Parameters.Add("CMND", OracleDbType.Varchar2, 12).Value = CMND_txtBox_tab3.Text;
            cmd.Parameters.Add("QUEQUAN", OracleDbType.NVarchar2, 50).Value = QUEQUAN_txtBox_tab3.Text;
            cmd.Parameters.Add("SODT", OracleDbType.Varchar2, 50).Value = SODT_txtBox_tab3.Text;
            cmd.Parameters.Add("CSYT", OracleDbType.Varchar2, 30).Value = CSYT_cmbBox_tab3.Text;
            cmd.Parameters.Add("VAITRO", OracleDbType.NVarchar2, 50).Value = VAITRO_cmbBox_tab3.Text;
            cmd.Parameters.Add("CHUYENKHOA", OracleDbType.NVarchar2, 50).Value = CHUYENKHOA_txtBox_tab3.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Insert Successfull");
                    DataTable dt = LoadNhanVien(); // Data table object
                    dataGridView3.DataSource = dt.DefaultView;
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

            PHAI_cmbBox_tab3.SelectedIndex = 0;
            VAITRO_cmbBox_tab3.SelectedIndex = 0;
            CSYT_cmbBox_tab3.SelectedIndex = 0;
            NGAYSINH_picker_tab3.Value = DateTime.Now;
        }

        private void DangXuat_btn_tab4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login form = new Login();
            con.Close();
            form.ShowDialog();

            this.Close();
        }
    }
}
