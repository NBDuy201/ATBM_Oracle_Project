
namespace Oracle_App.Forms
{
    partial class Form_NhanVien
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NGAYSINH_picker = new System.Windows.Forms.DateTimePicker();
            this.CSYT_cmbBox = new System.Windows.Forms.ComboBox();
            this.PHAI_cmbBox = new System.Windows.Forms.ComboBox();
            this.VAITRO_cmbBox = new System.Windows.Forms.ComboBox();
            this.Reset_btn_tab6 = new System.Windows.Forms.Button();
            this.CHUYENKHOA_label_tab6 = new System.Windows.Forms.Label();
            this.VAITRO_label_tab6 = new System.Windows.Forms.Label();
            this.CSYT_label_tab6 = new System.Windows.Forms.Label();
            this.SODT_label_tab6 = new System.Windows.Forms.Label();
            this.QUEQUAN_label_tab6 = new System.Windows.Forms.Label();
            this.CMND_label_tab6 = new System.Windows.Forms.Label();
            this.NGAYSINH_label_tab6 = new System.Windows.Forms.Label();
            this.PHAI_label_tab6 = new System.Windows.Forms.Label();
            this.HOTEN_label_tab6 = new System.Windows.Forms.Label();
            this.MANV_txtBox = new System.Windows.Forms.TextBox();
            this.MANV_label_tab6 = new System.Windows.Forms.Label();
            this.CHUYENKHOA_txtBox = new System.Windows.Forms.TextBox();
            this.SODT_txtBox = new System.Windows.Forms.TextBox();
            this.QUEQUAN_txtBox = new System.Windows.Forms.TextBox();
            this.CMND_txtBox = new System.Windows.Forms.TextBox();
            this.HOTEN_txtBox = new System.Windows.Forms.TextBox();
            this.Update_btn_tab6 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NGAYSINH_picker);
            this.groupBox3.Controls.Add(this.CSYT_cmbBox);
            this.groupBox3.Controls.Add(this.PHAI_cmbBox);
            this.groupBox3.Controls.Add(this.VAITRO_cmbBox);
            this.groupBox3.Controls.Add(this.Reset_btn_tab6);
            this.groupBox3.Controls.Add(this.CHUYENKHOA_label_tab6);
            this.groupBox3.Controls.Add(this.VAITRO_label_tab6);
            this.groupBox3.Controls.Add(this.CSYT_label_tab6);
            this.groupBox3.Controls.Add(this.SODT_label_tab6);
            this.groupBox3.Controls.Add(this.QUEQUAN_label_tab6);
            this.groupBox3.Controls.Add(this.CMND_label_tab6);
            this.groupBox3.Controls.Add(this.NGAYSINH_label_tab6);
            this.groupBox3.Controls.Add(this.PHAI_label_tab6);
            this.groupBox3.Controls.Add(this.HOTEN_label_tab6);
            this.groupBox3.Controls.Add(this.MANV_txtBox);
            this.groupBox3.Controls.Add(this.MANV_label_tab6);
            this.groupBox3.Controls.Add(this.CHUYENKHOA_txtBox);
            this.groupBox3.Controls.Add(this.SODT_txtBox);
            this.groupBox3.Controls.Add(this.QUEQUAN_txtBox);
            this.groupBox3.Controls.Add(this.CMND_txtBox);
            this.groupBox3.Controls.Add(this.HOTEN_txtBox);
            this.groupBox3.Controls.Add(this.Update_btn_tab6);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 400);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DML NhanVien";
            // 
            // NGAYSINH_picker
            // 
            this.NGAYSINH_picker.CustomFormat = "";
            this.NGAYSINH_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAYSINH_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NGAYSINH_picker.Location = new System.Drawing.Point(134, 116);
            this.NGAYSINH_picker.Name = "NGAYSINH_picker";
            this.NGAYSINH_picker.Size = new System.Drawing.Size(117, 26);
            this.NGAYSINH_picker.TabIndex = 54;
            // 
            // CSYT_cmbBox
            // 
            this.CSYT_cmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSYT_cmbBox.FormattingEnabled = true;
            this.CSYT_cmbBox.Location = new System.Drawing.Point(134, 247);
            this.CSYT_cmbBox.Name = "CSYT_cmbBox";
            this.CSYT_cmbBox.Size = new System.Drawing.Size(229, 24);
            this.CSYT_cmbBox.TabIndex = 36;
            // 
            // PHAI_cmbBox
            // 
            this.PHAI_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PHAI_cmbBox.FormattingEnabled = true;
            this.PHAI_cmbBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.PHAI_cmbBox.Location = new System.Drawing.Point(134, 86);
            this.PHAI_cmbBox.Name = "PHAI_cmbBox";
            this.PHAI_cmbBox.Size = new System.Drawing.Size(229, 21);
            this.PHAI_cmbBox.TabIndex = 36;
            // 
            // VAITRO_cmbBox
            // 
            this.VAITRO_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VAITRO_cmbBox.FormattingEnabled = true;
            this.VAITRO_cmbBox.Items.AddRange(new object[] {
            "Thanh tra",
            "Cơ Sở Y Tế",
            "Bác Sĩ",
            "Nghiên Cứu"});
            this.VAITRO_cmbBox.Location = new System.Drawing.Point(134, 278);
            this.VAITRO_cmbBox.Name = "VAITRO_cmbBox";
            this.VAITRO_cmbBox.Size = new System.Drawing.Size(229, 21);
            this.VAITRO_cmbBox.TabIndex = 36;
            // 
            // Reset_btn_tab6
            // 
            this.Reset_btn_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn_tab6.Location = new System.Drawing.Point(185, 351);
            this.Reset_btn_tab6.Name = "Reset_btn_tab6";
            this.Reset_btn_tab6.Size = new System.Drawing.Size(178, 33);
            this.Reset_btn_tab6.TabIndex = 29;
            this.Reset_btn_tab6.Text = "Reset";
            this.Reset_btn_tab6.UseVisualStyleBackColor = true;
            this.Reset_btn_tab6.Click += new System.EventHandler(this.Reset_btn_tab6_Click);
            // 
            // CHUYENKHOA_label_tab6
            // 
            this.CHUYENKHOA_label_tab6.AutoSize = true;
            this.CHUYENKHOA_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHUYENKHOA_label_tab6.Location = new System.Drawing.Point(6, 311);
            this.CHUYENKHOA_label_tab6.Name = "CHUYENKHOA_label_tab6";
            this.CHUYENKHOA_label_tab6.Size = new System.Drawing.Size(122, 20);
            this.CHUYENKHOA_label_tab6.TabIndex = 21;
            this.CHUYENKHOA_label_tab6.Text = "CHUYENKHOA";
            // 
            // VAITRO_label_tab6
            // 
            this.VAITRO_label_tab6.AutoSize = true;
            this.VAITRO_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAITRO_label_tab6.Location = new System.Drawing.Point(6, 279);
            this.VAITRO_label_tab6.Name = "VAITRO_label_tab6";
            this.VAITRO_label_tab6.Size = new System.Drawing.Size(69, 20);
            this.VAITRO_label_tab6.TabIndex = 21;
            this.VAITRO_label_tab6.Text = "VAITRO";
            // 
            // CSYT_label_tab6
            // 
            this.CSYT_label_tab6.AutoSize = true;
            this.CSYT_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSYT_label_tab6.Location = new System.Drawing.Point(6, 247);
            this.CSYT_label_tab6.Name = "CSYT_label_tab6";
            this.CSYT_label_tab6.Size = new System.Drawing.Size(51, 20);
            this.CSYT_label_tab6.TabIndex = 21;
            this.CSYT_label_tab6.Text = "CSYT";
            // 
            // SODT_label_tab6
            // 
            this.SODT_label_tab6.AutoSize = true;
            this.SODT_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SODT_label_tab6.Location = new System.Drawing.Point(6, 215);
            this.SODT_label_tab6.Name = "SODT_label_tab6";
            this.SODT_label_tab6.Size = new System.Drawing.Size(53, 20);
            this.SODT_label_tab6.TabIndex = 21;
            this.SODT_label_tab6.Text = "SODT";
            // 
            // QUEQUAN_label_tab6
            // 
            this.QUEQUAN_label_tab6.AutoSize = true;
            this.QUEQUAN_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUEQUAN_label_tab6.Location = new System.Drawing.Point(6, 183);
            this.QUEQUAN_label_tab6.Name = "QUEQUAN_label_tab6";
            this.QUEQUAN_label_tab6.Size = new System.Drawing.Size(90, 20);
            this.QUEQUAN_label_tab6.TabIndex = 21;
            this.QUEQUAN_label_tab6.Text = "QUEQUAN";
            // 
            // CMND_label_tab6
            // 
            this.CMND_label_tab6.AutoSize = true;
            this.CMND_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMND_label_tab6.Location = new System.Drawing.Point(6, 151);
            this.CMND_label_tab6.Name = "CMND_label_tab6";
            this.CMND_label_tab6.Size = new System.Drawing.Size(56, 20);
            this.CMND_label_tab6.TabIndex = 21;
            this.CMND_label_tab6.Text = "CMND";
            // 
            // NGAYSINH_label_tab6
            // 
            this.NGAYSINH_label_tab6.AutoSize = true;
            this.NGAYSINH_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAYSINH_label_tab6.Location = new System.Drawing.Point(6, 119);
            this.NGAYSINH_label_tab6.Name = "NGAYSINH_label_tab6";
            this.NGAYSINH_label_tab6.Size = new System.Drawing.Size(94, 20);
            this.NGAYSINH_label_tab6.TabIndex = 21;
            this.NGAYSINH_label_tab6.Text = "NGAYSINH";
            // 
            // PHAI_label_tab6
            // 
            this.PHAI_label_tab6.AutoSize = true;
            this.PHAI_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHAI_label_tab6.Location = new System.Drawing.Point(6, 87);
            this.PHAI_label_tab6.Name = "PHAI_label_tab6";
            this.PHAI_label_tab6.Size = new System.Drawing.Size(47, 20);
            this.PHAI_label_tab6.TabIndex = 21;
            this.PHAI_label_tab6.Text = "PHAI";
            // 
            // HOTEN_label_tab6
            // 
            this.HOTEN_label_tab6.AutoSize = true;
            this.HOTEN_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOTEN_label_tab6.Location = new System.Drawing.Point(6, 55);
            this.HOTEN_label_tab6.Name = "HOTEN_label_tab6";
            this.HOTEN_label_tab6.Size = new System.Drawing.Size(64, 20);
            this.HOTEN_label_tab6.TabIndex = 21;
            this.HOTEN_label_tab6.Text = "HOTEN";
            // 
            // MANV_txtBox
            // 
            this.MANV_txtBox.Enabled = false;
            this.MANV_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANV_txtBox.Location = new System.Drawing.Point(134, 19);
            this.MANV_txtBox.Name = "MANV_txtBox";
            this.MANV_txtBox.ReadOnly = true;
            this.MANV_txtBox.Size = new System.Drawing.Size(229, 26);
            this.MANV_txtBox.TabIndex = 17;
            // 
            // MANV_label_tab6
            // 
            this.MANV_label_tab6.AutoSize = true;
            this.MANV_label_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANV_label_tab6.Location = new System.Drawing.Point(6, 23);
            this.MANV_label_tab6.Name = "MANV_label_tab6";
            this.MANV_label_tab6.Size = new System.Drawing.Size(55, 20);
            this.MANV_label_tab6.TabIndex = 18;
            this.MANV_label_tab6.Text = "MANV";
            // 
            // CHUYENKHOA_txtBox
            // 
            this.CHUYENKHOA_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHUYENKHOA_txtBox.Location = new System.Drawing.Point(134, 308);
            this.CHUYENKHOA_txtBox.Name = "CHUYENKHOA_txtBox";
            this.CHUYENKHOA_txtBox.Size = new System.Drawing.Size(229, 26);
            this.CHUYENKHOA_txtBox.TabIndex = 20;
            // 
            // SODT_txtBox
            // 
            this.SODT_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SODT_txtBox.Location = new System.Drawing.Point(134, 212);
            this.SODT_txtBox.Name = "SODT_txtBox";
            this.SODT_txtBox.Size = new System.Drawing.Size(229, 26);
            this.SODT_txtBox.TabIndex = 20;
            // 
            // QUEQUAN_txtBox
            // 
            this.QUEQUAN_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUEQUAN_txtBox.Location = new System.Drawing.Point(134, 180);
            this.QUEQUAN_txtBox.Name = "QUEQUAN_txtBox";
            this.QUEQUAN_txtBox.Size = new System.Drawing.Size(229, 26);
            this.QUEQUAN_txtBox.TabIndex = 20;
            // 
            // CMND_txtBox
            // 
            this.CMND_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMND_txtBox.Location = new System.Drawing.Point(134, 148);
            this.CMND_txtBox.Name = "CMND_txtBox";
            this.CMND_txtBox.Size = new System.Drawing.Size(229, 26);
            this.CMND_txtBox.TabIndex = 20;
            // 
            // HOTEN_txtBox
            // 
            this.HOTEN_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOTEN_txtBox.Location = new System.Drawing.Point(134, 52);
            this.HOTEN_txtBox.Name = "HOTEN_txtBox";
            this.HOTEN_txtBox.Size = new System.Drawing.Size(229, 26);
            this.HOTEN_txtBox.TabIndex = 20;
            // 
            // Update_btn_tab6
            // 
            this.Update_btn_tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn_tab6.Location = new System.Drawing.Point(10, 351);
            this.Update_btn_tab6.Name = "Update_btn_tab6";
            this.Update_btn_tab6.Size = new System.Drawing.Size(169, 33);
            this.Update_btn_tab6.TabIndex = 22;
            this.Update_btn_tab6.Text = "Update";
            this.Update_btn_tab6.UseVisualStyleBackColor = true;
            this.Update_btn_tab6.Click += new System.EventHandler(this.Update_btn_tab6_Click);
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 424);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form_NhanVien";
            this.Text = "NhanVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_NhanVien_FormClosed);
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker NGAYSINH_picker;
        private System.Windows.Forms.ComboBox CSYT_cmbBox;
        private System.Windows.Forms.ComboBox PHAI_cmbBox;
        private System.Windows.Forms.ComboBox VAITRO_cmbBox;
        private System.Windows.Forms.Button Reset_btn_tab6;
        private System.Windows.Forms.Label CHUYENKHOA_label_tab6;
        private System.Windows.Forms.Label VAITRO_label_tab6;
        private System.Windows.Forms.Label CSYT_label_tab6;
        private System.Windows.Forms.Label SODT_label_tab6;
        private System.Windows.Forms.Label QUEQUAN_label_tab6;
        private System.Windows.Forms.Label CMND_label_tab6;
        private System.Windows.Forms.Label NGAYSINH_label_tab6;
        private System.Windows.Forms.Label PHAI_label_tab6;
        private System.Windows.Forms.Label HOTEN_label_tab6;
        private System.Windows.Forms.TextBox MANV_txtBox;
        private System.Windows.Forms.Label MANV_label_tab6;
        private System.Windows.Forms.TextBox CHUYENKHOA_txtBox;
        private System.Windows.Forms.TextBox SODT_txtBox;
        private System.Windows.Forms.TextBox QUEQUAN_txtBox;
        private System.Windows.Forms.TextBox CMND_txtBox;
        private System.Windows.Forms.TextBox HOTEN_txtBox;
        private System.Windows.Forms.Button Update_btn_tab6;
    }
}