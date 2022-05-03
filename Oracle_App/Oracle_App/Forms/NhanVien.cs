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
    public partial class Form_NhanVien : Form
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

        public Form_NhanVien(string user, string pass)
        {
            // User + pass from login
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // Sua thanh view khi co
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from NV_xem_thong_tin"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            MANV_txtBox.Text = dt.Rows[0].Field<string>("MANV");
            HOTEN_txtBox.Text = dt.Rows[0].Field<string>("HOTEN");
            PHAI_cmbBox.Text = dt.Rows[0].Field<string>("PHAI");
            NGAYSINH_picker.Value = dt.Rows[0].Field<DateTime>("NGAYSINH");
            CMND_txtBox.Text = dt.Rows[0].Field<string>("CMND");
            QUEQUAN_txtBox.Text = dt.Rows[0].Field<string>("QUEQUAN");
            SODT_txtBox.Text = dt.Rows[0].Field<string>("SODT");
            CSYT_cmbBox.Text = dt.Rows[0].Field<string>("CSYT");
            VAITRO_cmbBox.Text = dt.Rows[0].Field<string>("VAITRO");
            CHUYENKHOA_txtBox.Text = dt.Rows[0].Field<string>("CHUYENKHOA");
        }

        private void Form_NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
        }

        private void Update_btn_tab6_Click(object sender, EventArgs e)
        {
            // Sua khi co view
            OracleCommand cmd = con.CreateCommand();

            cmd.CommandText =
                "Update NV_xem_thong_tin set " +
                "HOTEN = :HOTEN, " +
                "PHAI = :PHAI, " +
                "NGAYSINH = :NGAYSINH, " +
                "CMND = :CMND, " +
                "QUEQUAN = :QUEQUAN, " +
                "SODT = :SODT, " +
                "CSYT = :CSYT, " +
                "VAITRO = :VAITRO, " +
                "CHUYENKHOA = :CHUYENKHOA " +
                "Where MANV = :MANV"; ; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            cmd.Parameters.Add("HOTEN", OracleDbType.NVarchar2, 50).Value = HOTEN_txtBox.Text;
            cmd.Parameters.Add("PHAI", OracleDbType.NVarchar2, 20).Value = PHAI_cmbBox.Text;
            cmd.Parameters.Add("NGAYSINH", OracleDbType.Date).Value = NGAYSINH_picker.Value.Date;
            cmd.Parameters.Add("CMND", OracleDbType.Varchar2, 12).Value = CMND_txtBox.Text;
            cmd.Parameters.Add("QUEQUAN", OracleDbType.NVarchar2, 50).Value = QUEQUAN_txtBox.Text;
            cmd.Parameters.Add("SODT", OracleDbType.Varchar2, 12).Value = SODT_txtBox.Text;
            cmd.Parameters.Add("CSYT", OracleDbType.Varchar2, 30).Value = CSYT_cmbBox.Text;
            cmd.Parameters.Add("VAITRO", OracleDbType.NVarchar2, 50).Value = VAITRO_cmbBox.Text;
            cmd.Parameters.Add("CHUYENKHOA", OracleDbType.NVarchar2, 50).Value = CHUYENKHOA_txtBox.Text;

            cmd.Parameters.Add("MANV", OracleDbType.Varchar2, 30).Value = username;

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
                //MessageBox.Show(exp.Message);
                throw;
            }
        }

        private void Reset_btn_tab6_Click(object sender, EventArgs e)
        {
            NhanVien_Load(this, EventArgs.Empty);
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

        private void Return_btn_Click(object sender, EventArgs e)
        {
            switch (VAITRO_cmbBox.Text)
            {
                case "Thanh Tra":
                    this.Hide();
                    Form_ThanhTra form1 = new Form_ThanhTra(username, password);
                    con.Close();
                    form1.ShowDialog();

                    this.Close();
                    break;
                case "Cơ Sở Y Tế":
                    this.Hide();

                    Form_CoSoYTe form3 = new Form_CoSoYTe(username, password);
                    con.Close();
                    form3.ShowDialog();

                    this.Close();
                    break;
                case "Bác Sĩ":
                    this.Hide();

                    Form_BacSi form4 = new Form_BacSi(username, password);
                    con.Close();
                    form4.ShowDialog();

                    this.Close();
                    break;
                case "Nghiên Cứu":
                    this.Hide();

                    Form_NghienCuu form6 = new Form_NghienCuu(username, password);
                    con.Close();
                    form6.ShowDialog();

                    this.Close();
                    break;
            }
        }
    }
}
