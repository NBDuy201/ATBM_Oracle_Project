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
    public partial class Form_CoSoYTe : Form
    {
        // Instance connection object
        private OracleConnection con = null;
        public string username = null;
        public string password = null;
        public string MaCS = null;

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

        public Form_CoSoYTe(string user, string pass)
        {
            // User + pass from login
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();
        }

        private void CoSoYTe_Load(object sender, EventArgs e)
        {
            // Set Role
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SET ROLE CoSo_YTe"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Set Role Failed");
                throw;
            }

            // Lay CSYT
            cmd.CommandText = "Select CSYT from NV_xem_thong_tin"; // Sql statement

            try
            {
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable(); // Data table object
                da.Fill(dt);

                MaCS = dt.Rows[0].Field<string>("CSYT");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Find CSYT failed");
                throw;
            }

            // Load gridview
            // HSBA
            DataTable dt1 = LoadHSBA(); // Data table object
            dataGridView1.DataSource = dt1.DefaultView;

            MCSYT_txtBox_tab1.Text = MaCS;

            //DataTable dt2 = LoadBN_CSYT(); // Benh nhan thuoc CSYT cua user
            //MABN_cm_tab1.DataSource = dt2;
            //MABN_cm_tab1.DisplayMember = "MABN";
            //MABN_cm_tab1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //MABN_cm_tab1.AutoCompleteSource = AutoCompleteSource.ListItems;

            //DataTable dt3 = LoadBS_CSYT(); // Bac si thuoc CSYT cua user
            //MABS_cm_tab1.DataSource = dt3;
            //MABS_cm_tab1.DisplayMember = "MABN";
            //MABS_cm_tab1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //MABS_cm_tab1.AutoCompleteSource = AutoCompleteSource.ListItems;

            // HSBA_DV
            DataTable dt4 = LoadHSBA_DV(); // Data table object
            dataGridView2.DataSource = dt4.DefaultView;

            // ComboBox
            MAHS_cm_tab2.DataSource = dt1;
            MAHS_cm_tab2.DisplayMember = "MAHSBA";
            //MAHS_cm_tab2.AutoCompleteMode = AutoCompleteMode.Suggest;
            //MAHS_cm_tab2.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Form_CoSoYTe_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
        }

        private DataTable LoadHSBA()
        {
            // Sua thanh view khi co
            OracleCommand cmd = con.CreateCommand();
            //cmd.CommandText = "Select * from HSBA where MACSYT = :MACSYT"; // Sql statement
            cmd.CommandText = "Select * from NHANVIEN_CSYT_HSBA"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            //cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = username;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            return dt;
        }

        private DataTable LoadHSBA_DV()
        {
            // Sua thanh view khi co
            OracleCommand cmd = con.CreateCommand();
            //cmd.CommandText = 
            //    "Select * " +
            //    "from HSBA_DV " +
            //    "where MAHSBA in " +
            //    "   (Select MAHSBA " +
            //    "   from HSBA " +
            //    "   where MACSYT = :MACSYT)"; // Sql statement
            cmd.CommandText = "Select * from NHANVIEN_CSYT_HSBA_DV"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            //cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = username;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private void Insert_btn_tab1_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            //cmd.CommandText =
            //    "Insert into HSBA(MAHSBA, MABN, NGAY, CHANĐOAN, MABS, MAKHOA, MACSYT, KETLUAN) " +
            //    "Values(:MAHSBA, :MABN, :NGAY, :CHANĐOAN, :MABS, :MAKHOA, :MACSYT, :KETLUAN)"; // Sql statement

            cmd.CommandText =
                "Insert into NHANVIEN_CSYT_HSBA(MAHSBA, MABN, NGAY, CHANĐOAN, MABS, MAKHOA, MACSYT, KETLUAN) " +
                "Values(:MAHSBA, :MABN, :NGAY, :CHANĐOAN, :MABS, :MAKHOA, :MACSYT, :KETLUAN)"; // Sql statement

            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MAHSBA_txtBox_tab1.Text;
            cmd.Parameters.Add("MABN", OracleDbType.NVarchar2, 30).Value = MaBN_txtBox_tab1.Text;
            cmd.Parameters.Add("NGAY", OracleDbType.Date).Value = Ngay_picker_tab1.Value.Date;
            cmd.Parameters.Add("CHANĐOAN", OracleDbType.NVarchar2, 250).Value = CD_txtBox_tab1.Text;
            cmd.Parameters.Add("MABS", OracleDbType.Varchar2, 30).Value = MaBS_txtBox_tab1.Text;
            cmd.Parameters.Add("MAKHOA", OracleDbType.Varchar2, 30).Value = MK_txtBox_tab1.Text;
            cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = MCSYT_txtBox_tab1.Text;
            cmd.Parameters.Add("KETLUAN", OracleDbType.NVarchar2, 250).Value = KL_txtBox_tab1.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Insert Successfull");
                    DataTable dt = LoadHSBA(); // Data table object
                    dataGridView1.DataSource = dt.DefaultView;
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
                //MessageBox.Show(exp.Message);
                throw;
            }
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

        private void Reset_btn_tab1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Ngay_picker_tab1.Value = DateTime.Now;

            Insert_btn_tab1.Enabled = true;
            Delete_btn_tab1.Enabled = false;
            MAHSBA_txtBox_tab1.Enabled = true;

            MCSYT_txtBox_tab1.Text = MaCS;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                MAHSBA_txtBox_tab1.Text = selectedRow.Cells["MAHSBA"].Value.ToString();
                MaBN_txtBox_tab1.Text = selectedRow.Cells["MABN"].Value.ToString();
                Ngay_picker_tab1.Text = selectedRow.Cells["NGAY"].Value.ToString();
                CD_txtBox_tab1.Text = selectedRow.Cells["CHANĐOAN"].Value.ToString();
                MaBS_txtBox_tab1.Text = selectedRow.Cells["MABS"].Value.ToString();
                MK_txtBox_tab1.Text = selectedRow.Cells["MAKHOA"].Value.ToString();
                MCSYT_txtBox_tab1.Text = selectedRow.Cells["MACSYT"].Value.ToString();
                KL_txtBox_tab1.Text = selectedRow.Cells["KETLUAN"].Value.ToString();
            }

            Insert_btn_tab1.Enabled = false;
            Delete_btn_tab1.Enabled = true;

            MAHSBA_txtBox_tab1.Enabled = false;
        }

        private void Delete_btn_tab1_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            //cmd.CommandText =
            //    "Delete from HSBA " +
            //    "Where MAHSBA = :MAHSBA"; // Sql statement

            cmd.CommandText =
                "Delete from NHANVIEN_CSYT_HSBA " +
                "Where MAHSBA = :MAHSBA"; // Sql statement

            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MAHSBA_txtBox_tab1.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Delete Successfull");
                    DataTable dt = LoadHSBA(); // Data table object
                    dataGridView1.DataSource = dt.DefaultView;
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
                //MessageBox.Show(exp.Message);
                throw;
            }
        }

        private void MAHS_srchBtn_tab1_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            OracleCommand cmd = con.CreateCommand();
            //cmd.CommandText = 
            //    "Select * " +
            //    "from HSBA " +
            //    "where lower(MAHSBA) like '%' || :MAHSBA || '%' and " +
            //    "MACSYT = :MACSYT"; // Sql statement

            cmd.CommandText =
                "Select * " +
                "from NHANVIEN_CSYT_HSBA " +
                "where lower(MAHSBA) like '%' || :MAHSBA || '%'"; // Sql statement

            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MAHS_srchTxtBox_tab1.Text.ToLower();
            //cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = username;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            dataGridView1.DataSource = dt.DefaultView;
        }

        private void MAHS_srchTxtBox_tab1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MAHS_srchTxtBox_tab1.Text))
            {
                DataTable dt = LoadHSBA();
                dataGridView1.DataSource = dt.DefaultView;
            }
        }

        private void MAHS_srchBtn_tab2_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText =
                "Select * " +
                "from NHANVIEN_CSYT_HSBA_DV " +
                "where lower(MAHSBA) like '%' || :MAHSBA || '%'"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MAHS_srchTxtBox_tab2.Text.ToLower();
            //cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = username;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            dataGridView2.DataSource = dt.DefaultView;
        }

        private void MAHS_srchTxtBox_tab2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MAHS_srchTxtBox_tab2.Text))
            {
                DataTable dt = LoadHSBA_DV();
                dataGridView2.DataSource = dt.DefaultView;
            }
        }

        private void Reset_btn_tab2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Ngay_picker_tab2.Value = DateTime.Now;

            MCSYT_txtBox_tab1.Text = MaCS;

            Insert_btn_tab2.Enabled = true;
            Delete_btn_tab2.Enabled = false;
            MAHS_cm_tab2.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[index];
                MAHS_cm_tab2.Text = selectedRow.Cells["MAHSBA"].Value.ToString();
                MADV_txtBox_tab2.Text = selectedRow.Cells["MADV"].Value.ToString();
                Ngay_picker_tab2.Text = selectedRow.Cells["NGAY"].Value.ToString();
                MAKTV_txtBox_tab2.Text = selectedRow.Cells["MAKTV"].Value.ToString();
                KETQUA_txtBox_tab2.Text = selectedRow.Cells["KETQUA"].Value.ToString();
            }

            Insert_btn_tab2.Enabled = false;
            Delete_btn_tab2.Enabled = true;

            MAHS_cm_tab2.Enabled = false;
        }

        private void Insert_btn_tab2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText =
                "Insert into NHANVIEN_CSYT_HSBA_DV(MAHSBA, MADV, NGAY, MAKTV, KETQUA) " +
                "Values(:MAHSBA, :MADV, :NGAY, :MAKTV, :KETQUA)"; // Sql statement

            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MAHS_cm_tab2.Text;
            cmd.Parameters.Add("MADV", OracleDbType.Varchar2, 30).Value = MADV_txtBox_tab2.Text;
            cmd.Parameters.Add("NGAY", OracleDbType.Date).Value = Ngay_picker_tab2.Value.Date;
            cmd.Parameters.Add("MAKTV", OracleDbType.Varchar2, 250).Value = MAKTV_txtBox_tab2.Text;
            cmd.Parameters.Add("KETQUA", OracleDbType.NVarchar2, 30).Value = KETQUA_txtBox_tab2.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Insert Successfull");
                    DataTable dt = LoadHSBA_DV(); // Data table object
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
                //MessageBox.Show(exp.Message);
                throw;
            }
        }

        private void Delete_btn_tab2_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText =
                "Delete from NHANVIEN_CSYT_HSBA_DV " +
                "Where " +
                "   MAHSBA = :MAHSBA and " +
                "   MADV = :MADV and " +
                "   NGAY = :NGAY"; // Sql statement

            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MAHS_cm_tab2.Text;
            cmd.Parameters.Add("MADV", OracleDbType.Varchar2, 30).Value = MADV_txtBox_tab2.Text;
            cmd.Parameters.Add("NGAY", OracleDbType.Date).Value = Ngay_picker_tab2.Value.Date;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Delete Successfull");
                    DataTable dt = LoadHSBA_DV(); // Data table object
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
                //MessageBox.Show(exp.Message);
                throw;
            }
        }

        private void Edit_btn_tab3_Click(object sender, EventArgs e)
        {
            // Can grant select on NHAVIEN
            this.Hide();

            Form_NhanVien form = new Form_NhanVien(username, password);
            con.Close();
            form.ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Can grant select on NV
            this.Hide();

            Login form = new Login();
            con.Close();
            form.ShowDialog();

            this.Close();
        }
    }
}
