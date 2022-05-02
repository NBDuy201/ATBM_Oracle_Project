
namespace Oracle_App.Forms
{
    partial class Form_NghienCuu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MAHS_srchBtn_tab1 = new System.Windows.Forms.Button();
            this.MAHS_srchTxtBox_tab1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DSDV_btn_tab1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DSHS_btn_tab1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Edit_btn_tab2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignOut_btn_tab2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 7);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1089, 587);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MAHS_srchBtn_tab1);
            this.tabPage1.Controls.Add(this.MAHS_srchTxtBox_tab1);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.DSDV_btn_tab1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.DSHS_btn_tab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1081, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HỒ SƠ BỆNH ÁN VÀ DỊCH VỤ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MAHS_srchBtn_tab1
            // 
            this.MAHS_srchBtn_tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAHS_srchBtn_tab1.Location = new System.Drawing.Point(913, 6);
            this.MAHS_srchBtn_tab1.Name = "MAHS_srchBtn_tab1";
            this.MAHS_srchBtn_tab1.Size = new System.Drawing.Size(162, 26);
            this.MAHS_srchBtn_tab1.TabIndex = 57;
            this.MAHS_srchBtn_tab1.Text = "Search";
            this.MAHS_srchBtn_tab1.UseVisualStyleBackColor = true;
            this.MAHS_srchBtn_tab1.Click += new System.EventHandler(this.MAHS_srchBtn_tab1_Click);
            // 
            // MAHS_srchTxtBox_tab1
            // 
            this.MAHS_srchTxtBox_tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAHS_srchTxtBox_tab1.Location = new System.Drawing.Point(88, 6);
            this.MAHS_srchTxtBox_tab1.Name = "MAHS_srchTxtBox_tab1";
            this.MAHS_srchTxtBox_tab1.Size = new System.Drawing.Size(819, 26);
            this.MAHS_srchTxtBox_tab1.TabIndex = 55;
            this.MAHS_srchTxtBox_tab1.TextChanged += new System.EventHandler(this.MAHS_srchTxtBox_tab1_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(2, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 20);
            this.label17.TabIndex = 56;
            this.label17.Text = "Mã Hồ Sơ";
            // 
            // DSDV_btn_tab1
            // 
            this.DSDV_btn_tab1.Enabled = false;
            this.DSDV_btn_tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSDV_btn_tab1.Location = new System.Drawing.Point(557, 522);
            this.DSDV_btn_tab1.Name = "DSDV_btn_tab1";
            this.DSDV_btn_tab1.Size = new System.Drawing.Size(518, 33);
            this.DSDV_btn_tab1.TabIndex = 28;
            this.DSDV_btn_tab1.Text = "Xem Dịch Vụ Của Hồ Sơ";
            this.DSDV_btn_tab1.UseVisualStyleBackColor = true;
            this.DSDV_btn_tab1.Click += new System.EventHandler(this.DSDV_btn_tab1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 478);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DSHS_btn_tab1
            // 
            this.DSHS_btn_tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSHS_btn_tab1.Location = new System.Drawing.Point(5, 522);
            this.DSHS_btn_tab1.Name = "DSHS_btn_tab1";
            this.DSHS_btn_tab1.Size = new System.Drawing.Size(546, 33);
            this.DSHS_btn_tab1.TabIndex = 22;
            this.DSHS_btn_tab1.Text = "Xem Danh Sách Hồ Sơ";
            this.DSHS_btn_tab1.UseVisualStyleBackColor = true;
            this.DSHS_btn_tab1.Click += new System.EventHandler(this.DSHS_btn_tab1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.SignOut_btn_tab2);
            this.tabPage2.Controls.Add(this.Edit_btn_tab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1081, 561);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "THÔNG TIN CÁ NHÂN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Edit_btn_tab2
            // 
            this.Edit_btn_tab2.BackColor = System.Drawing.Color.Black;
            this.Edit_btn_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn_tab2.ForeColor = System.Drawing.SystemColors.Control;
            this.Edit_btn_tab2.Location = new System.Drawing.Point(541, 132);
            this.Edit_btn_tab2.Name = "Edit_btn_tab2";
            this.Edit_btn_tab2.Size = new System.Drawing.Size(535, 61);
            this.Edit_btn_tab2.TabIndex = 63;
            this.Edit_btn_tab2.Text = "Chỉnh Sửa Thông Tin";
            this.Edit_btn_tab2.UseVisualStyleBackColor = false;
            this.Edit_btn_tab2.Click += new System.EventHandler(this.Edit_btn_tab2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Oracle_App.Properties.Resources.NghienCuu;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 555);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // SignOut_btn_tab2
            // 
            this.SignOut_btn_tab2.BackColor = System.Drawing.Color.Black;
            this.SignOut_btn_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut_btn_tab2.ForeColor = System.Drawing.SystemColors.Control;
            this.SignOut_btn_tab2.Location = new System.Drawing.Point(541, 315);
            this.SignOut_btn_tab2.Name = "SignOut_btn_tab2";
            this.SignOut_btn_tab2.Size = new System.Drawing.Size(535, 61);
            this.SignOut_btn_tab2.TabIndex = 63;
            this.SignOut_btn_tab2.Text = "Đăng Xuất";
            this.SignOut_btn_tab2.UseVisualStyleBackColor = false;
            this.SignOut_btn_tab2.Click += new System.EventHandler(this.SignOut_btn_tab2_Click);
            // 
            // Form_NghienCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_NghienCuu";
            this.Text = "NghienCuu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_NghienCuu_FormClosed);
            this.Load += new System.EventHandler(this.NghienCuu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button MAHS_srchBtn_tab1;
        private System.Windows.Forms.TextBox MAHS_srchTxtBox_tab1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button DSDV_btn_tab1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DSHS_btn_tab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Edit_btn_tab2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SignOut_btn_tab2;
    }
}