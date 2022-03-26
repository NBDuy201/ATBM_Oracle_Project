
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChangePass_button_tab2 = new System.Windows.Forms.Button();
            this.DropUser_button_tab2 = new System.Windows.Forms.Button();
            this.NewPass_textbox_tab2 = new System.Windows.Forms.TextBox();
            this.NewPass_label_tab2 = new System.Windows.Forms.Label();
            this.SelectedUser_textbox_tab2 = new System.Windows.Forms.TextBox();
            this.SelectedUser_label_tab2 = new System.Windows.Forms.Label();
            this.View_user_button2 = new System.Windows.Forms.Button();
            this.user_pass_group2 = new System.Windows.Forms.GroupBox();
            this.Password_label_tab2 = new System.Windows.Forms.Label();
            this.User_textbox_tab2 = new System.Windows.Forms.TextBox();
            this.User_label_tab2 = new System.Windows.Forms.Label();
            this.Pass_textbox_tab2 = new System.Windows.Forms.TextBox();
            this.Create_user_button_tab2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangePass_button_tab3 = new System.Windows.Forms.Button();
            this.NewPass_textbox_tab3 = new System.Windows.Forms.TextBox();
            this.NewPass_label_tab3 = new System.Windows.Forms.Label();
            this.DropRole_button3 = new System.Windows.Forms.Button();
            this.SelectedRole_textbox_tab3 = new System.Windows.Forms.TextBox();
            this.SelectedRole_label2_tab3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Role_group2 = new System.Windows.Forms.GroupBox();
            this.Pass_textbox_tab3 = new System.Windows.Forms.TextBox();
            this.Password_label2_tab2 = new System.Windows.Forms.Label();
            this.Role_textbox_tab3 = new System.Windows.Forms.TextBox();
            this.Role_label2 = new System.Windows.Forms.Label();
            this.CreateRole_button_tab3 = new System.Windows.Forms.Button();
            this.ViewRole_button_tab3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RevokeRole_btn_tab4 = new System.Windows.Forms.Button();
            this.ViewPrivRole_btn_tab4 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.SelectedRole_label_tab4 = new System.Windows.Forms.Label();
            this.SelectedRole_txtbox_tab4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SelectedUser_label_tab4 = new System.Windows.Forms.Label();
            this.SelectedUser_txtbox_tab4 = new System.Windows.Forms.TextBox();
            this.RevokeUser_btn_tab4 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ViewPrivUser_btn_tab4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.user_pass_group2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Role_group2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 549);
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1089, 587);
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
            this.tabPage1.Size = new System.Drawing.Size(1081, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View users/privileges";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.View_user_button2);
            this.tabPage2.Controls.Add(this.user_pass_group2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1081, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChangePass_button_tab2);
            this.groupBox2.Controls.Add(this.DropUser_button_tab2);
            this.groupBox2.Controls.Add(this.NewPass_textbox_tab2);
            this.groupBox2.Controls.Add(this.NewPass_label_tab2);
            this.groupBox2.Controls.Add(this.SelectedUser_textbox_tab2);
            this.groupBox2.Controls.Add(this.SelectedUser_label_tab2);
            this.groupBox2.Location = new System.Drawing.Point(5, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 179);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adjust user";
            // 
            // ChangePass_button_tab2
            // 
            this.ChangePass_button_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePass_button_tab2.Location = new System.Drawing.Point(10, 96);
            this.ChangePass_button_tab2.Name = "ChangePass_button_tab2";
            this.ChangePass_button_tab2.Size = new System.Drawing.Size(266, 33);
            this.ChangePass_button_tab2.TabIndex = 28;
            this.ChangePass_button_tab2.Text = "Change Passoword";
            this.ChangePass_button_tab2.UseVisualStyleBackColor = true;
            this.ChangePass_button_tab2.Click += new System.EventHandler(this.ChangePass_button_tab2_Click);
            // 
            // DropUser_button_tab2
            // 
            this.DropUser_button_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropUser_button_tab2.Location = new System.Drawing.Point(10, 135);
            this.DropUser_button_tab2.Name = "DropUser_button_tab2";
            this.DropUser_button_tab2.Size = new System.Drawing.Size(266, 33);
            this.DropUser_button_tab2.TabIndex = 23;
            this.DropUser_button_tab2.Text = "Delete User";
            this.DropUser_button_tab2.UseVisualStyleBackColor = true;
            this.DropUser_button_tab2.Click += new System.EventHandler(this.Delete_user_button2_Click);
            // 
            // NewPass_textbox_tab2
            // 
            this.NewPass_textbox_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass_textbox_tab2.Location = new System.Drawing.Point(121, 57);
            this.NewPass_textbox_tab2.Name = "NewPass_textbox_tab2";
            this.NewPass_textbox_tab2.Size = new System.Drawing.Size(155, 26);
            this.NewPass_textbox_tab2.TabIndex = 26;
            // 
            // NewPass_label_tab2
            // 
            this.NewPass_label_tab2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.NewPass_label_tab2.AutoSize = true;
            this.NewPass_label_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass_label_tab2.Location = new System.Drawing.Point(6, 60);
            this.NewPass_label_tab2.Name = "NewPass_label_tab2";
            this.NewPass_label_tab2.Size = new System.Drawing.Size(113, 20);
            this.NewPass_label_tab2.TabIndex = 27;
            this.NewPass_label_tab2.Text = "New Password";
            // 
            // SelectedUser_textbox_tab2
            // 
            this.SelectedUser_textbox_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedUser_textbox_tab2.Location = new System.Drawing.Point(121, 21);
            this.SelectedUser_textbox_tab2.Name = "SelectedUser_textbox_tab2";
            this.SelectedUser_textbox_tab2.Size = new System.Drawing.Size(155, 26);
            this.SelectedUser_textbox_tab2.TabIndex = 17;
            // 
            // SelectedUser_label_tab2
            // 
            this.SelectedUser_label_tab2.AutoSize = true;
            this.SelectedUser_label_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedUser_label_tab2.Location = new System.Drawing.Point(6, 24);
            this.SelectedUser_label_tab2.Name = "SelectedUser_label_tab2";
            this.SelectedUser_label_tab2.Size = new System.Drawing.Size(110, 20);
            this.SelectedUser_label_tab2.TabIndex = 18;
            this.SelectedUser_label_tab2.Text = "Selected User";
            // 
            // View_user_button2
            // 
            this.View_user_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_user_button2.Location = new System.Drawing.Point(298, 522);
            this.View_user_button2.Name = "View_user_button2";
            this.View_user_button2.Size = new System.Drawing.Size(776, 33);
            this.View_user_button2.TabIndex = 16;
            this.View_user_button2.Text = "View User";
            this.View_user_button2.UseVisualStyleBackColor = true;
            this.View_user_button2.Click += new System.EventHandler(this.View_user_button_Click2);
            // 
            // user_pass_group2
            // 
            this.user_pass_group2.Controls.Add(this.Password_label_tab2);
            this.user_pass_group2.Controls.Add(this.User_textbox_tab2);
            this.user_pass_group2.Controls.Add(this.User_label_tab2);
            this.user_pass_group2.Controls.Add(this.Pass_textbox_tab2);
            this.user_pass_group2.Controls.Add(this.Create_user_button_tab2);
            this.user_pass_group2.Location = new System.Drawing.Point(5, 6);
            this.user_pass_group2.Name = "user_pass_group2";
            this.user_pass_group2.Size = new System.Drawing.Size(287, 123);
            this.user_pass_group2.TabIndex = 23;
            this.user_pass_group2.TabStop = false;
            this.user_pass_group2.Text = "Create user";
            // 
            // Password_label_tab2
            // 
            this.Password_label_tab2.AutoSize = true;
            this.Password_label_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label_tab2.Location = new System.Drawing.Point(6, 52);
            this.Password_label_tab2.Name = "Password_label_tab2";
            this.Password_label_tab2.Size = new System.Drawing.Size(78, 20);
            this.Password_label_tab2.TabIndex = 21;
            this.Password_label_tab2.Text = "Password";
            // 
            // User_textbox_tab2
            // 
            this.User_textbox_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_textbox_tab2.Location = new System.Drawing.Point(90, 19);
            this.User_textbox_tab2.Name = "User_textbox_tab2";
            this.User_textbox_tab2.Size = new System.Drawing.Size(186, 26);
            this.User_textbox_tab2.TabIndex = 17;
            // 
            // User_label_tab2
            // 
            this.User_label_tab2.AutoSize = true;
            this.User_label_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label_tab2.Location = new System.Drawing.Point(6, 23);
            this.User_label_tab2.Name = "User_label_tab2";
            this.User_label_tab2.Size = new System.Drawing.Size(43, 20);
            this.User_label_tab2.TabIndex = 18;
            this.User_label_tab2.Text = "User";
            // 
            // Pass_textbox_tab2
            // 
            this.Pass_textbox_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_textbox_tab2.Location = new System.Drawing.Point(90, 51);
            this.Pass_textbox_tab2.Name = "Pass_textbox_tab2";
            this.Pass_textbox_tab2.Size = new System.Drawing.Size(186, 26);
            this.Pass_textbox_tab2.TabIndex = 20;
            // 
            // Create_user_button_tab2
            // 
            this.Create_user_button_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_user_button_tab2.Location = new System.Drawing.Point(10, 83);
            this.Create_user_button_tab2.Name = "Create_user_button_tab2";
            this.Create_user_button_tab2.Size = new System.Drawing.Size(266, 33);
            this.Create_user_button_tab2.TabIndex = 22;
            this.Create_user_button_tab2.Text = "Create User";
            this.Create_user_button_tab2.UseVisualStyleBackColor = true;
            this.Create_user_button_tab2.Click += new System.EventHandler(this.Create_user_button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(298, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 510);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.Role_group2);
            this.tabPage3.Controls.Add(this.ViewRole_button_tab3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1081, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Role";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangePass_button_tab3);
            this.groupBox1.Controls.Add(this.NewPass_textbox_tab3);
            this.groupBox1.Controls.Add(this.NewPass_label_tab3);
            this.groupBox1.Controls.Add(this.DropRole_button3);
            this.groupBox1.Controls.Add(this.SelectedRole_textbox_tab3);
            this.groupBox1.Controls.Add(this.SelectedRole_label2_tab3);
            this.groupBox1.Location = new System.Drawing.Point(6, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 179);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adjust role";
            // 
            // ChangePass_button_tab3
            // 
            this.ChangePass_button_tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePass_button_tab3.Location = new System.Drawing.Point(10, 96);
            this.ChangePass_button_tab3.Name = "ChangePass_button_tab3";
            this.ChangePass_button_tab3.Size = new System.Drawing.Size(254, 33);
            this.ChangePass_button_tab3.TabIndex = 28;
            this.ChangePass_button_tab3.Text = "Change Passoword";
            this.ChangePass_button_tab3.UseVisualStyleBackColor = true;
            this.ChangePass_button_tab3.Click += new System.EventHandler(this.ChangePass_button_tab3_Click);
            // 
            // NewPass_textbox_tab3
            // 
            this.NewPass_textbox_tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass_textbox_tab3.Location = new System.Drawing.Point(121, 57);
            this.NewPass_textbox_tab3.Name = "NewPass_textbox_tab3";
            this.NewPass_textbox_tab3.Size = new System.Drawing.Size(143, 26);
            this.NewPass_textbox_tab3.TabIndex = 26;
            // 
            // NewPass_label_tab3
            // 
            this.NewPass_label_tab3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.NewPass_label_tab3.AutoSize = true;
            this.NewPass_label_tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass_label_tab3.Location = new System.Drawing.Point(6, 60);
            this.NewPass_label_tab3.Name = "NewPass_label_tab3";
            this.NewPass_label_tab3.Size = new System.Drawing.Size(113, 20);
            this.NewPass_label_tab3.TabIndex = 27;
            this.NewPass_label_tab3.Text = "New Password";
            // 
            // DropRole_button3
            // 
            this.DropRole_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropRole_button3.Location = new System.Drawing.Point(10, 135);
            this.DropRole_button3.Name = "DropRole_button3";
            this.DropRole_button3.Size = new System.Drawing.Size(254, 33);
            this.DropRole_button3.TabIndex = 23;
            this.DropRole_button3.Text = "Drop Role";
            this.DropRole_button3.UseVisualStyleBackColor = true;
            this.DropRole_button3.Click += new System.EventHandler(this.Drop_role_button_Click);
            // 
            // SelectedRole_textbox_tab3
            // 
            this.SelectedRole_textbox_tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRole_textbox_tab3.Location = new System.Drawing.Point(121, 21);
            this.SelectedRole_textbox_tab3.Name = "SelectedRole_textbox_tab3";
            this.SelectedRole_textbox_tab3.Size = new System.Drawing.Size(143, 26);
            this.SelectedRole_textbox_tab3.TabIndex = 17;
            // 
            // SelectedRole_label2_tab3
            // 
            this.SelectedRole_label2_tab3.AutoSize = true;
            this.SelectedRole_label2_tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRole_label2_tab3.Location = new System.Drawing.Point(6, 24);
            this.SelectedRole_label2_tab3.Name = "SelectedRole_label2_tab3";
            this.SelectedRole_label2_tab3.Size = new System.Drawing.Size(109, 20);
            this.SelectedRole_label2_tab3.TabIndex = 18;
            this.SelectedRole_label2_tab3.Text = "Selected Role";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(283, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(791, 510);
            this.dataGridView3.TabIndex = 29;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // Role_group2
            // 
            this.Role_group2.Controls.Add(this.Pass_textbox_tab3);
            this.Role_group2.Controls.Add(this.Password_label2_tab2);
            this.Role_group2.Controls.Add(this.Role_textbox_tab3);
            this.Role_group2.Controls.Add(this.Role_label2);
            this.Role_group2.Controls.Add(this.CreateRole_button_tab3);
            this.Role_group2.Location = new System.Drawing.Point(6, 21);
            this.Role_group2.Name = "Role_group2";
            this.Role_group2.Size = new System.Drawing.Size(271, 140);
            this.Role_group2.TabIndex = 28;
            this.Role_group2.TabStop = false;
            this.Role_group2.Text = "Create Role";
            // 
            // Pass_textbox_tab3
            // 
            this.Pass_textbox_tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_textbox_tab3.Location = new System.Drawing.Point(90, 56);
            this.Pass_textbox_tab3.Name = "Pass_textbox_tab3";
            this.Pass_textbox_tab3.Size = new System.Drawing.Size(174, 26);
            this.Pass_textbox_tab3.TabIndex = 24;
            // 
            // Password_label2_tab2
            // 
            this.Password_label2_tab2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Password_label2_tab2.AutoSize = true;
            this.Password_label2_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label2_tab2.Location = new System.Drawing.Point(6, 57);
            this.Password_label2_tab2.Name = "Password_label2_tab2";
            this.Password_label2_tab2.Size = new System.Drawing.Size(78, 20);
            this.Password_label2_tab2.TabIndex = 25;
            this.Password_label2_tab2.Text = "Password";
            // 
            // Role_textbox_tab3
            // 
            this.Role_textbox_tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_textbox_tab3.Location = new System.Drawing.Point(90, 18);
            this.Role_textbox_tab3.Name = "Role_textbox_tab3";
            this.Role_textbox_tab3.Size = new System.Drawing.Size(174, 26);
            this.Role_textbox_tab3.TabIndex = 17;
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
            // CreateRole_button_tab3
            // 
            this.CreateRole_button_tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRole_button_tab3.Location = new System.Drawing.Point(10, 96);
            this.CreateRole_button_tab3.Name = "CreateRole_button_tab3";
            this.CreateRole_button_tab3.Size = new System.Drawing.Size(254, 33);
            this.CreateRole_button_tab3.TabIndex = 22;
            this.CreateRole_button_tab3.Text = "Create Role";
            this.CreateRole_button_tab3.UseVisualStyleBackColor = true;
            this.CreateRole_button_tab3.Click += new System.EventHandler(this.Create_role_button_Click);
            // 
            // ViewRole_button_tab3
            // 
            this.ViewRole_button_tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRole_button_tab3.Location = new System.Drawing.Point(283, 522);
            this.ViewRole_button_tab3.Name = "ViewRole_button_tab3";
            this.ViewRole_button_tab3.Size = new System.Drawing.Size(791, 33);
            this.ViewRole_button_tab3.TabIndex = 27;
            this.ViewRole_button_tab3.Text = "View Role";
            this.ViewRole_button_tab3.UseVisualStyleBackColor = true;
            this.ViewRole_button_tab3.Click += new System.EventHandler(this.View_role_button_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1081, 561);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Revoke";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RevokeRole_btn_tab4);
            this.groupBox4.Controls.Add(this.ViewPrivRole_btn_tab4);
            this.groupBox4.Controls.Add(this.dataGridView5);
            this.groupBox4.Controls.Add(this.SelectedRole_label_tab4);
            this.groupBox4.Controls.Add(this.SelectedRole_txtbox_tab4);
            this.groupBox4.Location = new System.Drawing.Point(529, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 542);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Revoke Role";
            // 
            // RevokeRole_btn_tab4
            // 
            this.RevokeRole_btn_tab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevokeRole_btn_tab4.Location = new System.Drawing.Point(16, 500);
            this.RevokeRole_btn_tab4.Name = "RevokeRole_btn_tab4";
            this.RevokeRole_btn_tab4.Size = new System.Drawing.Size(515, 33);
            this.RevokeRole_btn_tab4.TabIndex = 33;
            this.RevokeRole_btn_tab4.Text = "Revoke";
            this.RevokeRole_btn_tab4.UseVisualStyleBackColor = true;
            this.RevokeRole_btn_tab4.Click += new System.EventHandler(this.RevokeRole_btn_tab4_Click);
            // 
            // ViewPrivRole_btn_tab4
            // 
            this.ViewPrivRole_btn_tab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPrivRole_btn_tab4.Location = new System.Drawing.Point(322, 13);
            this.ViewPrivRole_btn_tab4.Name = "ViewPrivRole_btn_tab4";
            this.ViewPrivRole_btn_tab4.Size = new System.Drawing.Size(209, 32);
            this.ViewPrivRole_btn_tab4.TabIndex = 34;
            this.ViewPrivRole_btn_tab4.Text = "View privileges";
            this.ViewPrivRole_btn_tab4.UseVisualStyleBackColor = true;
            this.ViewPrivRole_btn_tab4.Click += new System.EventHandler(this.ViewPrivRole_btn_tab4_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(16, 53);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(515, 441);
            this.dataGridView5.TabIndex = 30;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            // 
            // SelectedRole_label_tab4
            // 
            this.SelectedRole_label_tab4.AutoSize = true;
            this.SelectedRole_label_tab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRole_label_tab4.Location = new System.Drawing.Point(16, 19);
            this.SelectedRole_label_tab4.Name = "SelectedRole_label_tab4";
            this.SelectedRole_label_tab4.Size = new System.Drawing.Size(109, 20);
            this.SelectedRole_label_tab4.TabIndex = 32;
            this.SelectedRole_label_tab4.Text = "Selected Role";
            // 
            // SelectedRole_txtbox_tab4
            // 
            this.SelectedRole_txtbox_tab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRole_txtbox_tab4.Location = new System.Drawing.Point(131, 16);
            this.SelectedRole_txtbox_tab4.Name = "SelectedRole_txtbox_tab4";
            this.SelectedRole_txtbox_tab4.Size = new System.Drawing.Size(185, 26);
            this.SelectedRole_txtbox_tab4.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SelectedUser_label_tab4);
            this.groupBox3.Controls.Add(this.SelectedUser_txtbox_tab4);
            this.groupBox3.Controls.Add(this.RevokeUser_btn_tab4);
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Controls.Add(this.ViewPrivUser_btn_tab4);
            this.groupBox3.Location = new System.Drawing.Point(5, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 542);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Revoke User";
            // 
            // SelectedUser_label_tab4
            // 
            this.SelectedUser_label_tab4.AutoSize = true;
            this.SelectedUser_label_tab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedUser_label_tab4.Location = new System.Drawing.Point(2, 15);
            this.SelectedUser_label_tab4.Name = "SelectedUser_label_tab4";
            this.SelectedUser_label_tab4.Size = new System.Drawing.Size(110, 20);
            this.SelectedUser_label_tab4.TabIndex = 24;
            this.SelectedUser_label_tab4.Text = "Selected User";
            // 
            // SelectedUser_txtbox_tab4
            // 
            this.SelectedUser_txtbox_tab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedUser_txtbox_tab4.Location = new System.Drawing.Point(118, 12);
            this.SelectedUser_txtbox_tab4.Name = "SelectedUser_txtbox_tab4";
            this.SelectedUser_txtbox_tab4.Size = new System.Drawing.Size(183, 26);
            this.SelectedUser_txtbox_tab4.TabIndex = 23;
            // 
            // RevokeUser_btn_tab4
            // 
            this.RevokeUser_btn_tab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevokeUser_btn_tab4.Location = new System.Drawing.Point(6, 499);
            this.RevokeUser_btn_tab4.Name = "RevokeUser_btn_tab4";
            this.RevokeUser_btn_tab4.Size = new System.Drawing.Size(481, 33);
            this.RevokeUser_btn_tab4.TabIndex = 21;
            this.RevokeUser_btn_tab4.Text = "Revoke";
            this.RevokeUser_btn_tab4.UseVisualStyleBackColor = true;
            this.RevokeUser_btn_tab4.Click += new System.EventHandler(this.RevokeUser_btn_tab4_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 52);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(481, 441);
            this.dataGridView4.TabIndex = 20;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // ViewPrivUser_btn_tab4
            // 
            this.ViewPrivUser_btn_tab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPrivUser_btn_tab4.Location = new System.Drawing.Point(307, 8);
            this.ViewPrivUser_btn_tab4.Name = "ViewPrivUser_btn_tab4";
            this.ViewPrivUser_btn_tab4.Size = new System.Drawing.Size(180, 34);
            this.ViewPrivUser_btn_tab4.TabIndex = 22;
            this.ViewPrivUser_btn_tab4.Text = "View privileges";
            this.ViewPrivUser_btn_tab4.UseVisualStyleBackColor = true;
            this.ViewPrivUser_btn_tab4.Click += new System.EventHandler(this.ViewPrivUser_btn_tab4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 606);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.user_pass_group2.ResumeLayout(false);
            this.user_pass_group2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Role_group2.ResumeLayout(false);
            this.Role_group2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
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
        private System.Windows.Forms.Label Password_label_tab2;
        private System.Windows.Forms.TextBox Pass_textbox_tab2;
        private System.Windows.Forms.Label User_label_tab2;
        private System.Windows.Forms.TextBox User_textbox_tab2;
        private System.Windows.Forms.Button View_user_button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Create_user_button_tab2;
        private System.Windows.Forms.GroupBox user_pass_group2;
        private System.Windows.Forms.Button DropUser_button_tab2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChangePass_button_tab3;
        private System.Windows.Forms.TextBox NewPass_textbox_tab3;
        private System.Windows.Forms.Label NewPass_label_tab3;
        private System.Windows.Forms.Button DropRole_button3;
        private System.Windows.Forms.TextBox SelectedRole_textbox_tab3;
        private System.Windows.Forms.Label SelectedRole_label2_tab3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox Role_group2;
        private System.Windows.Forms.TextBox Pass_textbox_tab3;
        private System.Windows.Forms.Label Password_label2_tab2;
        private System.Windows.Forms.TextBox Role_textbox_tab3;
        private System.Windows.Forms.Label Role_label2;
        private System.Windows.Forms.Button CreateRole_button_tab3;
        private System.Windows.Forms.Button ViewRole_button_tab3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ChangePass_button_tab2;
        private System.Windows.Forms.TextBox NewPass_textbox_tab2;
        private System.Windows.Forms.Label NewPass_label_tab2;
        private System.Windows.Forms.TextBox SelectedUser_textbox_tab2;
        private System.Windows.Forms.Label SelectedUser_label_tab2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label SelectedUser_label_tab4;
        private System.Windows.Forms.TextBox SelectedUser_txtbox_tab4;
        private System.Windows.Forms.Button RevokeUser_btn_tab4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button ViewPrivUser_btn_tab4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button RevokeRole_btn_tab4;
        private System.Windows.Forms.Button ViewPrivRole_btn_tab4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label SelectedRole_label_tab4;
        private System.Windows.Forms.TextBox SelectedRole_txtbox_tab4;
    }
}

