
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
            this.Add_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.View_user_button = new System.Windows.Forms.Button();
            this.View_privilege_button = new System.Windows.Forms.Button();
            this.User_textbox = new System.Windows.Forms.TextBox();
            this.User_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Password_tab2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.User_tab2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.View_user_button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Create_user_button2 = new System.Windows.Forms.Button();
            this.user_pass_group2 = new System.Windows.Forms.GroupBox();
            this.Delete_user_button2 = new System.Windows.Forms.Button();
            this.Role_group2 = new System.Windows.Forms.GroupBox();
            this.Drop_role_button2 = new System.Windows.Forms.Button();
            this.Create_role_button2 = new System.Windows.Forms.Button();
            this.View_role_button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Role_label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.user_pass_group2.SuspendLayout();
            this.Role_group2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 521);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Add_button
            // 
            this.Add_button.Enabled = false;
            this.Add_button.Location = new System.Drawing.Point(6, 313);
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
            this.Update_button.Location = new System.Drawing.Point(6, 371);
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
            this.Delete_button.Location = new System.Drawing.Point(6, 342);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 9;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.Location = new System.Drawing.Point(10, 95);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(91, 33);
            this.Reset_button.TabIndex = 10;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // View_user_button
            // 
            this.View_user_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_user_button.Location = new System.Drawing.Point(10, 52);
            this.View_user_button.Name = "View_user_button";
            this.View_user_button.Size = new System.Drawing.Size(91, 37);
            this.View_user_button.TabIndex = 11;
            this.View_user_button.Text = "View user";
            this.View_user_button.UseVisualStyleBackColor = true;
            this.View_user_button.Click += new System.EventHandler(this.View_user_button_Click1);
            // 
            // View_privilege_button
            // 
            this.View_privilege_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_privilege_button.Location = new System.Drawing.Point(116, 52);
            this.View_privilege_button.Name = "View_privilege_button";
            this.View_privilege_button.Size = new System.Drawing.Size(125, 37);
            this.View_privilege_button.TabIndex = 12;
            this.View_privilege_button.Text = "View privileges";
            this.View_privilege_button.UseVisualStyleBackColor = true;
            this.View_privilege_button.Click += new System.EventHandler(this.View_privilege_button_Click);
            // 
            // User_textbox
            // 
            this.User_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_textbox.Location = new System.Drawing.Point(55, 10);
            this.User_textbox.Name = "User_textbox";
            this.User_textbox.Size = new System.Drawing.Size(186, 26);
            this.User_textbox.TabIndex = 13;
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.Location = new System.Drawing.Point(6, 13);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(43, 20);
            this.User_label.TabIndex = 14;
            this.User_label.Text = "User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 559);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.User_label);
            this.tabPage1.Controls.Add(this.Delete_button);
            this.tabPage1.Controls.Add(this.Reset_button);
            this.tabPage1.Controls.Add(this.Update_button);
            this.tabPage1.Controls.Add(this.User_textbox);
            this.tabPage1.Controls.Add(this.Add_button);
            this.tabPage1.Controls.Add(this.View_user_button);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.View_privilege_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View users/privileges";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.Role_group2);
            this.tabPage2.Controls.Add(this.user_pass_group2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create new user";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Password_tab2
            // 
            this.Password_tab2.AutoSize = true;
            this.Password_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_tab2.Location = new System.Drawing.Point(248, 21);
            this.Password_tab2.Name = "Password_tab2";
            this.Password_tab2.Size = new System.Drawing.Size(78, 20);
            this.Password_tab2.TabIndex = 21;
            this.Password_tab2.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(332, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 26);
            this.textBox2.TabIndex = 20;
            // 
            // User_tab2
            // 
            this.User_tab2.AutoSize = true;
            this.User_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_tab2.Location = new System.Drawing.Point(6, 23);
            this.User_tab2.Name = "User_tab2";
            this.User_tab2.Size = new System.Drawing.Size(43, 20);
            this.User_tab2.TabIndex = 18;
            this.User_tab2.Text = "User";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(55, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 17;
            // 
            // View_user_button2
            // 
            this.View_user_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_user_button2.Location = new System.Drawing.Point(10, 57);
            this.View_user_button2.Name = "View_user_button2";
            this.View_user_button2.Size = new System.Drawing.Size(91, 33);
            this.View_user_button2.TabIndex = 16;
            this.View_user_button2.Text = "View User";
            this.View_user_button2.UseVisualStyleBackColor = true;
            this.View_user_button2.Click += new System.EventHandler(this.View_user_button_Click2);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(526, 425);
            this.dataGridView2.TabIndex = 15;
            // 
            // Create_user_button2
            // 
            this.Create_user_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_user_button2.Location = new System.Drawing.Point(203, 57);
            this.Create_user_button2.Name = "Create_user_button2";
            this.Create_user_button2.Size = new System.Drawing.Size(105, 33);
            this.Create_user_button2.TabIndex = 22;
            this.Create_user_button2.Text = "Create User";
            this.Create_user_button2.UseVisualStyleBackColor = true;
            // 
            // user_pass_group2
            // 
            this.user_pass_group2.Controls.Add(this.Delete_user_button2);
            this.user_pass_group2.Controls.Add(this.Password_tab2);
            this.user_pass_group2.Controls.Add(this.Create_user_button2);
            this.user_pass_group2.Controls.Add(this.View_user_button2);
            this.user_pass_group2.Controls.Add(this.textBox1);
            this.user_pass_group2.Controls.Add(this.User_tab2);
            this.user_pass_group2.Controls.Add(this.textBox2);
            this.user_pass_group2.Location = new System.Drawing.Point(5, 6);
            this.user_pass_group2.Name = "user_pass_group2";
            this.user_pass_group2.Size = new System.Drawing.Size(527, 90);
            this.user_pass_group2.TabIndex = 23;
            this.user_pass_group2.TabStop = false;
            this.user_pass_group2.Text = "User/password";
            // 
            // Delete_user_button2
            // 
            this.Delete_user_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_user_button2.Location = new System.Drawing.Point(413, 57);
            this.Delete_user_button2.Name = "Delete_user_button2";
            this.Delete_user_button2.Size = new System.Drawing.Size(105, 33);
            this.Delete_user_button2.TabIndex = 23;
            this.Delete_user_button2.Text = "Delete User";
            this.Delete_user_button2.UseVisualStyleBackColor = true;
            // 
            // Role_group2
            // 
            this.Role_group2.Controls.Add(this.Drop_role_button2);
            this.Role_group2.Controls.Add(this.Create_role_button2);
            this.Role_group2.Controls.Add(this.View_role_button2);
            this.Role_group2.Controls.Add(this.textBox3);
            this.Role_group2.Controls.Add(this.Role_label2);
            this.Role_group2.Location = new System.Drawing.Point(547, 6);
            this.Role_group2.Name = "Role_group2";
            this.Role_group2.Size = new System.Drawing.Size(527, 90);
            this.Role_group2.TabIndex = 24;
            this.Role_group2.TabStop = false;
            this.Role_group2.Text = "Role";
            // 
            // Drop_role_button2
            // 
            this.Drop_role_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_role_button2.Location = new System.Drawing.Point(413, 57);
            this.Drop_role_button2.Name = "Drop_role_button2";
            this.Drop_role_button2.Size = new System.Drawing.Size(105, 33);
            this.Drop_role_button2.TabIndex = 23;
            this.Drop_role_button2.Text = "Drop Role";
            this.Drop_role_button2.UseVisualStyleBackColor = true;
            // 
            // Create_role_button2
            // 
            this.Create_role_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_role_button2.Location = new System.Drawing.Point(207, 57);
            this.Create_role_button2.Name = "Create_role_button2";
            this.Create_role_button2.Size = new System.Drawing.Size(105, 33);
            this.Create_role_button2.TabIndex = 22;
            this.Create_role_button2.Text = "Create Role";
            this.Create_role_button2.UseVisualStyleBackColor = true;
            // 
            // View_role_button2
            // 
            this.View_role_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_role_button2.Location = new System.Drawing.Point(10, 57);
            this.View_role_button2.Name = "View_role_button2";
            this.View_role_button2.Size = new System.Drawing.Size(91, 33);
            this.View_role_button2.TabIndex = 16;
            this.View_role_button2.Text = "View Role";
            this.View_role_button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(55, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(463, 26);
            this.textBox3.TabIndex = 17;
            // 
            // Role_label2
            // 
            this.Role_label2.AutoSize = true;
            this.Role_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_label2.Location = new System.Drawing.Point(6, 23);
            this.Role_label2.Name = "Role_label2";
            this.Role_label2.Size = new System.Drawing.Size(42, 20);
            this.Role_label2.TabIndex = 18;
            this.Role_label2.Text = "Role";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(547, 102);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(527, 425);
            this.dataGridView3.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.user_pass_group2.ResumeLayout(false);
            this.user_pass_group2.PerformLayout();
            this.Role_group2.ResumeLayout(false);
            this.Role_group2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button View_user_button;
        private System.Windows.Forms.Button View_privilege_button;
        private System.Windows.Forms.TextBox User_textbox;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Password_tab2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label User_tab2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button View_user_button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Create_user_button2;
        private System.Windows.Forms.GroupBox user_pass_group2;
        private System.Windows.Forms.Button Delete_user_button2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox Role_group2;
        private System.Windows.Forms.Button Drop_role_button2;
        private System.Windows.Forms.Button Create_role_button2;
        private System.Windows.Forms.Button View_role_button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Role_label2;
    }
}

