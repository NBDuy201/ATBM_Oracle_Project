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
    public partial class Form_NghienCuu : Form
    {
        // Instance connection object
        private OracleConnection con = null;
        public string username = null;
        public string password = null;
        public string MaHS = null;

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

        public Form_NghienCuu(string user, string pass)
        {
            // User + pass from login
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();
        }

        private void NghienCuu_Load(object sender, EventArgs e)
        {
            // Style
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            // Set Role
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SET ROLE NGHIEN_CUU"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            try
            {
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Load Gridview
            LoadGrid(LoadHSBA_NC(), dataGridView1);
            DSDV_btn_tab1.Enabled = false;

            // Enable search
            MAHS_srchTxtBox_tab1.Enabled = true;
            MAHS_srchBtn_tab1.Enabled = true;
        }

        private void Form_NghienCuu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
        }

        private DataTable LoadHSBA_NC()
        {
            // Sua thanh view khi co
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from NHANVIEN_CSYT_HSBA"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadHSBA_DV_NC()
        {
            // Sua thanh view khi co
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from NHANVIEN_CSYT_HSBA_DV where MAHSBA = :MAHSBA"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MaHS;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private void LoadGrid(DataTable dt, DataGridView dgv)
        {
            dgv.DataSource = dt.DefaultView;
        }

        private void MAHS_srchBtn_tab1_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText =
                "Select * " +
                "from NHANVIEN_CSYT_HSBA " +
                "where lower(MAHSBA) like '%' || :MAHSBA || '%'"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MAHS_srchTxtBox_tab1.Text.ToLower();

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            LoadGrid(dt, dataGridView1);
        }

        private void DSDV_btn_tab1_Click(object sender, EventArgs e)
        {
            LoadGrid(LoadHSBA_DV_NC(), dataGridView1);

            // Disable search
            MAHS_srchTxtBox_tab1.Enabled = false;
            MAHS_srchBtn_tab1.Enabled = false;
        }

        private void Edit_btn_tab2_Click(object sender, EventArgs e)
        {
            // Can grant select on NV
            this.Hide();

            Form_NhanVien form = new Form_NhanVien(username, password);
            con.Close();
            form.ShowDialog();

            this.Close();
        }

        private void MAHS_srchTxtBox_tab1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MAHS_srchTxtBox_tab1.Text))
            {
                LoadGrid(LoadHSBA_NC(), dataGridView1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                MaHS = selectedRow.Cells["MAHSBA"].Value.ToString();
            }

            DSDV_btn_tab1.Enabled = true;
        }

        private void DSHS_btn_tab1_Click(object sender, EventArgs e)
        {
            NghienCuu_Load(this, EventArgs.Empty);
        }

        private void SignOut_btn_tab2_Click(object sender, EventArgs e)
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
