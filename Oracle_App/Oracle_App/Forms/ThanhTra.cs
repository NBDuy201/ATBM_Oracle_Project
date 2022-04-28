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
