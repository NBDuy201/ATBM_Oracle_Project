
namespace Oracle_App
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Employee_ID_label = new System.Windows.Forms.Label();
            this.Last_Name_label = new System.Windows.Forms.Label();
            this.Job_ID_label = new System.Windows.Forms.Label();
            this.Employee_ID_textbox = new System.Windows.Forms.TextBox();
            this.Last_Name_textbox = new System.Windows.Forms.TextBox();
            this.Job_ID_textbox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Employee_Info_Group = new System.Windows.Forms.GroupBox();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.Hire_Date_picker = new System.Windows.Forms.DateTimePicker();
            this.Hire_Date_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Employee_Info_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Employee_ID_label
            // 
            this.Employee_ID_label.AutoSize = true;
            this.Employee_ID_label.Location = new System.Drawing.Point(16, 59);
            this.Employee_ID_label.Name = "Employee_ID_label";
            this.Employee_ID_label.Size = new System.Drawing.Size(70, 13);
            this.Employee_ID_label.TabIndex = 1;
            this.Employee_ID_label.Text = "Employee_ID";
            // 
            // Last_Name_label
            // 
            this.Last_Name_label.AutoSize = true;
            this.Last_Name_label.Location = new System.Drawing.Point(15, 95);
            this.Last_Name_label.Name = "Last_Name_label";
            this.Last_Name_label.Size = new System.Drawing.Size(61, 13);
            this.Last_Name_label.TabIndex = 2;
            this.Last_Name_label.Text = "Last_Name";
            // 
            // Job_ID_label
            // 
            this.Job_ID_label.AutoSize = true;
            this.Job_ID_label.Location = new System.Drawing.Point(4, 136);
            this.Job_ID_label.Name = "Job_ID_label";
            this.Job_ID_label.Size = new System.Drawing.Size(41, 13);
            this.Job_ID_label.TabIndex = 3;
            this.Job_ID_label.Text = "Job_ID";
            // 
            // Employee_ID_textbox
            // 
            this.Employee_ID_textbox.Location = new System.Drawing.Point(92, 56);
            this.Employee_ID_textbox.Name = "Employee_ID_textbox";
            this.Employee_ID_textbox.Size = new System.Drawing.Size(198, 20);
            this.Employee_ID_textbox.TabIndex = 4;
            // 
            // Last_Name_textbox
            // 
            this.Last_Name_textbox.Location = new System.Drawing.Point(92, 92);
            this.Last_Name_textbox.Name = "Last_Name_textbox";
            this.Last_Name_textbox.Size = new System.Drawing.Size(198, 20);
            this.Last_Name_textbox.TabIndex = 5;
            // 
            // Job_ID_textbox
            // 
            this.Job_ID_textbox.Location = new System.Drawing.Point(80, 133);
            this.Job_ID_textbox.Name = "Job_ID_textbox";
            this.Job_ID_textbox.Size = new System.Drawing.Size(198, 20);
            this.Job_ID_textbox.TabIndex = 6;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(16, 248);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 7;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Enabled = false;
            this.Update_button.Location = new System.Drawing.Point(111, 248);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 8;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Enabled = false;
            this.Delete_button.Location = new System.Drawing.Point(212, 248);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 9;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(111, 318);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(75, 23);
            this.Reset_button.TabIndex = 10;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Employee_Info_Group
            // 
            this.Employee_Info_Group.Controls.Add(this.Email_textbox);
            this.Employee_Info_Group.Controls.Add(this.Email_label);
            this.Employee_Info_Group.Controls.Add(this.Job_ID_textbox);
            this.Employee_Info_Group.Controls.Add(this.Job_ID_label);
            this.Employee_Info_Group.Location = new System.Drawing.Point(12, 30);
            this.Employee_Info_Group.Name = "Employee_Info_Group";
            this.Employee_Info_Group.Size = new System.Drawing.Size(285, 200);
            this.Employee_Info_Group.TabIndex = 11;
            this.Employee_Info_Group.TabStop = false;
            this.Employee_Info_Group.Text = "Employee Info";
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(80, 97);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(198, 20);
            this.Email_textbox.TabIndex = 13;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(4, 100);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(32, 13);
            this.Email_label.TabIndex = 12;
            this.Email_label.Text = "Email";
            // 
            // Hire_Date_picker
            // 
            this.Hire_Date_picker.Location = new System.Drawing.Point(92, 199);
            this.Hire_Date_picker.Name = "Hire_Date_picker";
            this.Hire_Date_picker.Size = new System.Drawing.Size(198, 20);
            this.Hire_Date_picker.TabIndex = 12;
            // 
            // Hire_Date_label
            // 
            this.Hire_Date_label.AutoSize = true;
            this.Hire_Date_label.Location = new System.Drawing.Point(16, 205);
            this.Hire_Date_label.Name = "Hire_Date_label";
            this.Hire_Date_label.Size = new System.Drawing.Size(55, 13);
            this.Hire_Date_label.TabIndex = 14;
            this.Hire_Date_label.Text = "Hire_Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hire_Date_label);
            this.Controls.Add(this.Hire_Date_picker);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Last_Name_textbox);
            this.Controls.Add(this.Employee_ID_textbox);
            this.Controls.Add(this.Last_Name_label);
            this.Controls.Add(this.Employee_ID_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Employee_Info_Group);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Employee_Info_Group.ResumeLayout(false);
            this.Employee_Info_Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Employee_ID_label;
        private System.Windows.Forms.Label Last_Name_label;
        private System.Windows.Forms.Label Job_ID_label;
        private System.Windows.Forms.TextBox Employee_ID_textbox;
        private System.Windows.Forms.TextBox Last_Name_textbox;
        private System.Windows.Forms.TextBox Job_ID_textbox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.GroupBox Employee_Info_Group;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.DateTimePicker Hire_Date_picker;
        private System.Windows.Forms.Label Hire_Date_label;
    }
}

