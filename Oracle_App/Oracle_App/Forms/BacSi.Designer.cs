
namespace Oracle_App.Forms
{
    partial class Form_BacSi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MAHS_srchBtn_tab1 = new System.Windows.Forms.Button();
            this.MAHS_srchTxtBox_tab1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DSDV_btn_tab1 = new System.Windows.Forms.Button();
            this.DSHS_btn_tab1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MAHS_srchBtn_tab2 = new System.Windows.Forms.Button();
            this.srchTxtBox_tab2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CMND_rb_tab2 = new System.Windows.Forms.RadioButton();
            this.MABN_rb_tab2 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabControl1.TabIndex = 18;
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Location = new System.Drawing.Point(6, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 478);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MABN_rb_tab2);
            this.tabPage2.Controls.Add(this.CMND_rb_tab2);
            this.tabPage2.Controls.Add(this.MAHS_srchBtn_tab2);
            this.tabPage2.Controls.Add(this.srchTxtBox_tab2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1081, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BỆNH NHÂN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MAHS_srchBtn_tab2
            // 
            this.MAHS_srchBtn_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAHS_srchBtn_tab2.Location = new System.Drawing.Point(386, 6);
            this.MAHS_srchBtn_tab2.Name = "MAHS_srchBtn_tab2";
            this.MAHS_srchBtn_tab2.Size = new System.Drawing.Size(95, 26);
            this.MAHS_srchBtn_tab2.TabIndex = 62;
            this.MAHS_srchBtn_tab2.Text = "Search";
            this.MAHS_srchBtn_tab2.UseVisualStyleBackColor = true;
            this.MAHS_srchBtn_tab2.Click += new System.EventHandler(this.MAHS_srchBtn_tab2_Click);
            // 
            // srchTxtBox_tab2
            // 
            this.srchTxtBox_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchTxtBox_tab2.Location = new System.Drawing.Point(120, 6);
            this.srchTxtBox_tab2.Name = "srchTxtBox_tab2";
            this.srchTxtBox_tab2.Size = new System.Drawing.Size(260, 26);
            this.srchTxtBox_tab2.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Mã BN/ CMND";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.Location = new System.Drawing.Point(6, 62);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1070, 493);
            this.dataGridView2.TabIndex = 58;
            // 
            // CMND_rb_tab2
            // 
            this.CMND_rb_tab2.AutoSize = true;
            this.CMND_rb_tab2.Location = new System.Drawing.Point(223, 38);
            this.CMND_rb_tab2.Name = "CMND_rb_tab2";
            this.CMND_rb_tab2.Size = new System.Drawing.Size(57, 17);
            this.CMND_rb_tab2.TabIndex = 63;
            this.CMND_rb_tab2.TabStop = true;
            this.CMND_rb_tab2.Text = "CMND";
            this.CMND_rb_tab2.UseVisualStyleBackColor = true;
            // 
            // MABN_rb_tab2
            // 
            this.MABN_rb_tab2.AutoSize = true;
            this.MABN_rb_tab2.Checked = true;
            this.MABN_rb_tab2.Location = new System.Drawing.Point(120, 38);
            this.MABN_rb_tab2.Name = "MABN_rb_tab2";
            this.MABN_rb_tab2.Size = new System.Drawing.Size(97, 17);
            this.MABN_rb_tab2.TabIndex = 63;
            this.MABN_rb_tab2.TabStop = true;
            this.MABN_rb_tab2.Text = "Mã Bệnh Nhân";
            this.MABN_rb_tab2.UseVisualStyleBackColor = true;
            // 
            // Form_BacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_BacSi";
            this.Text = "BacSi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_BacSi_FormClosed);
            this.Load += new System.EventHandler(this.Form_BacSi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button MAHS_srchBtn_tab1;
        private System.Windows.Forms.TextBox MAHS_srchTxtBox_tab1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button DSDV_btn_tab1;
        private System.Windows.Forms.Button DSHS_btn_tab1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button MAHS_srchBtn_tab2;
        private System.Windows.Forms.TextBox srchTxtBox_tab2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton MABN_rb_tab2;
        private System.Windows.Forms.RadioButton CMND_rb_tab2;
    }
}