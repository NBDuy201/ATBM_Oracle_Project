﻿using Oracle.ManagedDataAccess.Client;
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
            // Load gridview
            DataTable dt = LoadHSBA(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;

            MCSYT_txtBox_tab1.Text = username;

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
            cmd.CommandText = "Select * from HSBA where MACSYT = :MACSYT"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = "CS57";

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
            cmd.CommandText =
                "Insert into HSBA(MAHSBA, MABN, NGAY, CHANĐOAN, MABS, MAKHOA, MACSYT, KETLUAN) " +
                "Values(:MAHSBA, :MABN, :NGAY, :CHANĐOAN, :MABS, :MAKHOA, :MACSYT, :KETLUAN)"; // Sql statement

            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MAHSBA", OracleDbType.Varchar2, 30).Value = MAHSBA_txtBox_tab1.Text;
            cmd.Parameters.Add("MABN", OracleDbType.NVarchar2, 30).Value = MABN_cm_tab1.Text;
            cmd.Parameters.Add("NGAY", OracleDbType.Date).Value = Ngay_picker_tab1.Value.Date;
            cmd.Parameters.Add("CHANĐOAN", OracleDbType.NVarchar2, 250).Value = CD_txtBox_tab1.Text;
            cmd.Parameters.Add("MABS", OracleDbType.Varchar2, 30).Value = MABS_cm_tab1.Text;
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

        private void Reset_btn_tab5_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            MABN_cm_tab1.SelectedIndex = 0;
            MABS_cm_tab1.SelectedIndex = 0;
            Ngay_picker_tab1.Value = DateTimePicker.MinimumDateTime;

            Insert_btn_tab1.Enabled = true;
            Delete_btn_tab1.Enabled = false;
            MAHSBA_txtBox_tab1.Enabled = true;

            MCSYT_txtBox_tab1.Text = username;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                MAHSBA_txtBox_tab1.Text = selectedRow.Cells["MAHSBA"].Value.ToString();
                MABN_cm_tab1.Text = selectedRow.Cells["MABN"].Value.ToString();
                Ngay_picker_tab1.Text = selectedRow.Cells["NGAY"].Value.ToString();
                CD_txtBox_tab1.Text = selectedRow.Cells["CHANĐOAN"].Value.ToString();
                MABS_cm_tab1.Text = selectedRow.Cells["MABS"].Value.ToString();
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
            cmd.CommandText =
                "Delete from HSBA " +
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
    }
}
