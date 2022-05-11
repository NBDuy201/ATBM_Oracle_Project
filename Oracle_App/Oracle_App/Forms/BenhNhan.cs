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
    public partial class Form_BenhNhan : Form
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
                MessageBox.Show(exp.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
        }

        public Form_BenhNhan(string user, string pass)
        {
            // User + pass from login
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();
        }

        private void BenhNhan_Load(object sender, EventArgs e)
        {
            // Set Role
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SET ROLE BENH_NHAN"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            try
            {
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cmd.CommandText = "Select * from BN_xem_thong_tin"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MABN", OracleDbType.Varchar2, 30).Value = username;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            MaBN_txtBox.Text = dt.Rows[0].Field<string>("MABN");
            MaCSYT_cm.Text = dt.Rows[0].Field<string>("MACSYT");
            TenBN_txtBox.Text = dt.Rows[0].Field<string>("TENBN");
            CMND_txtBox.Text = dt.Rows[0].Field<string>("CMND");
            NGAYSINH_picker.Value = dt.Rows[0].Field<DateTime>("NGAYSINH");
            SoNha_txtBox.Text = dt.Rows[0].Field<int>("SONHA").ToString();
            TenDuong_txtBox.Text = dt.Rows[0].Field<string>("TENĐUONG");
            QuanHuyen_txtBox.Text = dt.Rows[0].Field<string>("QUANHUYEN");
            TinhTP_txtBox.Text = dt.Rows[0].Field<string>("TINHTP");
            TienSu_txtBox.Text = dt.Rows[0].Field<string>("TIENSUBENH");
            TienSuGD_txtBox.Text = dt.Rows[0].Field<string>("TIENSUBENHGD");
            DungThuoc_txtBox.Text = dt.Rows[0].Field<string>("DIUNGTHUOC");

            // Load combobox
            DataTable dt2 = LoadMaCSYT(); // Danh sach MaCSYT
            MaCSYT_cm.DataSource = dt2;
            MaCSYT_cm.DisplayMember = "MACSYT";
            MaCSYT_cm.AutoCompleteMode = AutoCompleteMode.Suggest;
            MaCSYT_cm.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Form_BenhNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
        }

        private DataTable LoadMaCSYT()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select MACSYT from xem_MaCSYT"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            OracleCommand cmd = con.CreateCommand();

            cmd.CommandText =
                "Update BN_xem_thong_tin set " +
                "MACSYT = :MACSYT, " +
                "TENBN = :TENBN, " +
                "CMND = :CMND, " +
                "NGAYSINH = :NGAYSINH, " +
                "SONHA = :SONHA, " +
                "TENĐUONG = :TENĐUONG, " +
                "QUANHUYEN = :QUANHUYEN, " +
                "TINHTP = :TINHTP, " +
                "TIENSUBENH = :TIENSUBENH, " +
                "TIENSUBENHGD = :TIENSUBENHGD, " +
                "DIUNGTHUOC = :DIUNGTHUOC " +
                "Where MABN = :MABN"; ; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = MaCSYT_cm.Text;
            cmd.Parameters.Add("TENBN", OracleDbType.NVarchar2, 50).Value = TenBN_txtBox.Text;
            cmd.Parameters.Add("CMND", OracleDbType.Varchar2, 12).Value = CMND_txtBox.Text;
            cmd.Parameters.Add("NGAYSINH", OracleDbType.Date, 30).Value = NGAYSINH_picker.Value.Date;
            cmd.Parameters.Add("SONHA", OracleDbType.Decimal).Value = Decimal.Parse(SoNha_txtBox.Text);
            cmd.Parameters.Add("TENĐUONG", OracleDbType.NVarchar2, 50).Value = TenDuong_txtBox.Text;
            cmd.Parameters.Add("QUANHUYEN", OracleDbType.NVarchar2, 50).Value = QuanHuyen_txtBox.Text;
            cmd.Parameters.Add("TINHTP", OracleDbType.NVarchar2, 50).Value = TinhTP_txtBox.Text;
            cmd.Parameters.Add("TIENSUBENH", OracleDbType.NVarchar2, 250).Value = TienSu_txtBox.Text;
            cmd.Parameters.Add("TIENSUBENHGD", OracleDbType.NVarchar2, 250).Value = TienSuGD_txtBox.Text;
            cmd.Parameters.Add("DIUNGTHUOC", OracleDbType.NVarchar2, 250).Value = DungThuoc_txtBox.Text;

            cmd.Parameters.Add("MABN", OracleDbType.Varchar2, 30).Value = username;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Update Successfull");
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
                MessageBox.Show(exp.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            BenhNhan_Load(this, EventArgs.Empty);
        }

        private void SignOut_btn_Click(object sender, EventArgs e)
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
