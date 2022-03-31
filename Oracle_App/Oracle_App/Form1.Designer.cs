namespace ATBM
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
            this.Login_btn = new System.Windows.Forms.Button();
            this.user_txtBox_login = new System.Windows.Forms.TextBox();
            this.pass_txtBox_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(207, 103);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(140, 34);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "LOGIN";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // user_txtBox_login
            // 
            this.user_txtBox_login.Location = new System.Drawing.Point(105, 41);
            this.user_txtBox_login.Name = "user_txtBox_login";
            this.user_txtBox_login.Size = new System.Drawing.Size(373, 20);
            this.user_txtBox_login.TabIndex = 1;
            // 
            // pass_txtBox_login
            // 
            this.pass_txtBox_login.Location = new System.Drawing.Point(105, 77);
            this.pass_txtBox_login.Name = "pass_txtBox_login";
            this.pass_txtBox_login.PasswordChar = '*';
            this.pass_txtBox_login.Size = new System.Drawing.Size(373, 20);
            this.pass_txtBox_login.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 153);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_txtBox_login);
            this.Controls.Add(this.user_txtBox_login);
            this.Controls.Add(this.Login_btn);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox user_txtBox_login;
        private System.Windows.Forms.TextBox pass_txtBox_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

