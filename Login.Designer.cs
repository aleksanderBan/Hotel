namespace Hotel
{
    partial class Login
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
            this.email_label = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.createAccount_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.adminLogin_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminPswd_textbox = new System.Windows.Forms.TextBox();
            this.adminPswd_label = new System.Windows.Forms.Label();
            this.adminLogin_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.email_label.Location = new System.Drawing.Point(58, 190);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(107, 40);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "Email";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(203, 191);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(426, 44);
            this.email_textbox.TabIndex = 2;
            // 
            // createAccount_btn
            // 
            this.createAccount_btn.Location = new System.Drawing.Point(181, 562);
            this.createAccount_btn.Name = "createAccount_btn";
            this.createAccount_btn.Size = new System.Drawing.Size(264, 101);
            this.createAccount_btn.TabIndex = 3;
            this.createAccount_btn.Text = "Create account";
            this.createAccount_btn.UseVisualStyleBackColor = true;
            this.createAccount_btn.Click += new System.EventHandler(this.CreateAccount_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(214, 344);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(207, 77);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // adminLogin_btn
            // 
            this.adminLogin_btn.Location = new System.Drawing.Point(901, 344);
            this.adminLogin_btn.Name = "adminLogin_btn";
            this.adminLogin_btn.Size = new System.Drawing.Size(207, 77);
            this.adminLogin_btn.TabIndex = 5;
            this.adminLogin_btn.Text = "Login";
            this.adminLogin_btn.UseVisualStyleBackColor = true;
            this.adminLogin_btn.Click += new System.EventHandler(this.AdminLogin_btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(697, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(5, 677);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // adminPswd_textbox
            // 
            this.adminPswd_textbox.Location = new System.Drawing.Point(979, 186);
            this.adminPswd_textbox.Name = "adminPswd_textbox";
            this.adminPswd_textbox.Size = new System.Drawing.Size(254, 44);
            this.adminPswd_textbox.TabIndex = 7;
            // 
            // adminPswd_label
            // 
            this.adminPswd_label.AutoSize = true;
            this.adminPswd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.adminPswd_label.Location = new System.Drawing.Point(768, 189);
            this.adminPswd_label.Name = "adminPswd_label";
            this.adminPswd_label.Size = new System.Drawing.Size(175, 40);
            this.adminPswd_label.TabIndex = 8;
            this.adminPswd_label.Text = "Password";
            // 
            // adminLogin_label
            // 
            this.adminLogin_label.AutoSize = true;
            this.adminLogin_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_label.Location = new System.Drawing.Point(768, 39);
            this.adminLogin_label.Name = "adminLogin_label";
            this.adminLogin_label.Size = new System.Drawing.Size(391, 42);
            this.adminLogin_label.TabIndex = 9;
            this.adminLogin_label.Text = "Login as system Admin";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(58, 46);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(108, 42);
            this.login_label.TabIndex = 10;
            this.login_label.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 804);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.adminLogin_label);
            this.Controls.Add(this.adminPswd_label);
            this.Controls.Add(this.adminPswd_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminLogin_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.createAccount_btn);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.email_label);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Button createAccount_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button adminLogin_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminPswd_textbox;
        private System.Windows.Forms.Label adminPswd_label;
        private System.Windows.Forms.Label adminLogin_label;
        private System.Windows.Forms.Label login_label;
    }
}

