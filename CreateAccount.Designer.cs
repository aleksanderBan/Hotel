namespace Hotel
{
    partial class CreateAccount
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
            this.email_label2 = new System.Windows.Forms.Label();
            this.usrnm_label = new System.Windows.Forms.Label();
            this.email_textbox2 = new System.Windows.Forms.TextBox();
            this.usrnm_textbox = new System.Windows.Forms.TextBox();
            this.createAccount_btn2 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_label2
            // 
            this.email_label2.AutoSize = true;
            this.email_label2.Location = new System.Drawing.Point(99, 42);
            this.email_label2.Name = "email_label2";
            this.email_label2.Size = new System.Drawing.Size(97, 37);
            this.email_label2.TabIndex = 0;
            this.email_label2.Text = "Email";
            // 
            // usrnm_label
            // 
            this.usrnm_label.AutoSize = true;
            this.usrnm_label.Location = new System.Drawing.Point(99, 240);
            this.usrnm_label.Name = "usrnm_label";
            this.usrnm_label.Size = new System.Drawing.Size(164, 37);
            this.usrnm_label.TabIndex = 1;
            this.usrnm_label.Text = "Username";
            // 
            // email_textbox2
            // 
            this.email_textbox2.Location = new System.Drawing.Point(106, 113);
            this.email_textbox2.Name = "email_textbox2";
            this.email_textbox2.Size = new System.Drawing.Size(100, 44);
            this.email_textbox2.TabIndex = 2;
            // 
            // usrnm_textbox
            // 
            this.usrnm_textbox.Location = new System.Drawing.Point(106, 352);
            this.usrnm_textbox.Name = "usrnm_textbox";
            this.usrnm_textbox.Size = new System.Drawing.Size(100, 44);
            this.usrnm_textbox.TabIndex = 3;
            // 
            // createAccount_btn2
            // 
            this.createAccount_btn2.Location = new System.Drawing.Point(448, 472);
            this.createAccount_btn2.Name = "createAccount_btn2";
            this.createAccount_btn2.Size = new System.Drawing.Size(282, 98);
            this.createAccount_btn2.TabIndex = 4;
            this.createAccount_btn2.Text = "Create Account";
            this.createAccount_btn2.UseVisualStyleBackColor = true;
            this.createAccount_btn2.Click += new System.EventHandler(this.createAccount_btn2_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(767, 107);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(187, 95);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Go back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 604);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.createAccount_btn2);
            this.Controls.Add(this.usrnm_textbox);
            this.Controls.Add(this.email_textbox2);
            this.Controls.Add(this.usrnm_label);
            this.Controls.Add(this.email_label2);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_label2;
        private System.Windows.Forms.Label usrnm_label;
        private System.Windows.Forms.TextBox email_textbox2;
        private System.Windows.Forms.TextBox usrnm_textbox;
        private System.Windows.Forms.Button createAccount_btn2;
        private System.Windows.Forms.Button back_btn;
    }
}