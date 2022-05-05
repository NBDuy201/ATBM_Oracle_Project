using ATBM;
using Oracle.ManagedDataAccess.Client;
using Oracle_App.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_App
{
    public partial class Form_ThanhTra : Form
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

        public Form_ThanhTra(string user, string pass)
        {
            // User + pass from login
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();
        }

        private void Form_ThanhTra_Load(object sender, EventArgs e)
        {
            // Style
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);

            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.Font, FontStyle.Bold);

            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView4.Font, FontStyle.Bold);

            dataGridView5.EnableHeadersVisualStyles = false;
            dataGridView5.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView5.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView5.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView5.Font, FontStyle.Bold);

            // Set Role
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SET ROLE THANH_TRA"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            try
            {
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Load gridview
            DataTable dt = LoadCSYT(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;

            dt = LoadBenhNhan(); // Data table object
            dataGridView2.DataSource = dt.DefaultView;

            dt = LoadNhanVien(); // Data table object
            dataGridView3.DataSource = dt.DefaultView;

            dt = LoadHSBA(); // Data table object
            dataGridView4.DataSource = dt.DefaultView;

            dt = LoadHSBA_DV(); // Data table object
            dataGridView5.DataSource = dt.DefaultView;
        }

        private void Form_ThanhTra_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
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

        private DataTable LoadHSBA()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from HSBA"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadHSBA_DV()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from HSBA_DV"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private void Edit_btn_tab6_Click(object sender, EventArgs e)
        {
            // Can grant select on NHAVIEN
            this.Hide();

            Form_NhanVien form = new Form_NhanVien(username, password);
            con.Close();
            form.ShowDialog();

            this.Close();
        }

        private void SignOut_btn_tab6_Click(object sender, EventArgs e)
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
