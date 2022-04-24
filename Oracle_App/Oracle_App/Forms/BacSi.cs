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
    public partial class Form_BacSi : Form
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

        public Form_BacSi(string user, string pass)
        {
            // User + pass from login
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();
        }

        private DataTable LoadHSBA_BS()
        {
            // Sua thanh view khi co
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from HSBA where MABS = :MABS"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MABS", OracleDbType.Varchar2, 30).Value = username;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadHSBA_DV_BS()
        {
            // Sua thanh view khi co
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from HSBA_DV where MAHSBA = :MAHSBA"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MABS", OracleDbType.Varchar2, 30).Value = MaHS;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadBN_CSYT_BS(int option)
        {
            // Sua thanh view khi co
            OracleCommand cmd = con.CreateCommand();

            if(option == 1)
                cmd.CommandText = "Select * from BENHNHAN Where MABN = :item"; // Sql statement
            else if(option == 2)
                cmd.CommandText = "Select * from BENHNHAN Where CMND = :item"; // Sql statement
            
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MABN", OracleDbType.Varchar2, 30).Value = srchTxtBox_tab2.Text;


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

        private void Form_BacSi_Load(object sender, EventArgs e)
        {
            // HSBA
            LoadGrid(LoadHSBA_BS(), dataGridView1);
        }

        private void DSHS_btn_tab1_Click(object sender, EventArgs e)
        {
            LoadGrid(LoadHSBA_BS(), dataGridView1);
            DSDV_btn_tab1.Enabled = false;
        }

        private void Form_BacSi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
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

        private void DSDV_btn_tab1_Click(object sender, EventArgs e)
        {
            LoadGrid(LoadHSBA_DV_BS(), dataGridView1);
        }

        private void MAHS_srchBtn_tab1_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText =
                "Select * " +
                "from HSBA " +
                "where lower(MAHSBA) like '%' || :MAHSBA || '%' and " +
                "MABS = :MABS"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MAHS_srchTxtBox_tab1.Text.ToLower();
            cmd.Parameters.Add("MABS", OracleDbType.Varchar2, 30).Value = username;

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
                LoadGrid(LoadHSBA_BS(), dataGridView2);
            }
        }

        private void MAHS_srchBtn_tab2_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            if (!String.IsNullOrEmpty(srchTxtBox_tab2.Text))
            {
                int option = 0;

                // Check radio
                if (MABN_rb_tab2.Checked == true)
                    option = 1;
                else if (CMND_rb_tab2.Checked == true)
                    option = 2;

                LoadGrid(LoadBN_CSYT_BS(option), dataGridView2);
            }
        }

        private void Edit_btn_tab3_Click(object sender, EventArgs e)
        {
            // Can grant select on NV
            this.Hide();
            
            Form_NhanVien form = new Form_NhanVien(username, password);
            con.Close();
            form.ShowDialog();

            this.Close();
        }
    }
}
