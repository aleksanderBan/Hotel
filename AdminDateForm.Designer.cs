namespace Hotel
{
    partial class AdminDateForm
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
            this.currentDate_label = new System.Windows.Forms.Label();
            this.newDate_textbox = new System.Windows.Forms.TextBox();
            this.newDate_label = new System.Windows.Forms.Label();
            this.currentDate_label2 = new System.Windows.Forms.Label();
            this.updateDate_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentDate_label
            // 
            this.currentDate_label.AutoSize = true;
            this.currentDate_label.Location = new System.Drawing.Point(116, 130);
            this.currentDate_label.Name = "currentDate_label";
            this.currentDate_label.Size = new System.Drawing.Size(100, 37);
            this.currentDate_label.TabIndex = 0;
            this.currentDate_label.Text = "label1";
            // 
            // newDate_textbox
            // 
            this.newDate_textbox.Location = new System.Drawing.Point(123, 410);
            this.newDate_textbox.Name = "newDate_textbox";
            this.newDate_textbox.Size = new System.Drawing.Size(100, 44);
            this.newDate_textbox.TabIndex = 1;
            // 
            // newDate_label
            // 
            this.newDate_label.AutoSize = true;
            this.newDate_label.Location = new System.Drawing.Point(141, 333);
            this.newDate_label.Name = "newDate_label";
            this.newDate_label.Size = new System.Drawing.Size(152, 37);
            this.newDate_label.TabIndex = 2;
            this.newDate_label.Text = "New date";
            // 
            // currentDate_label2
            // 
            this.currentDate_label2.AutoSize = true;
            this.currentDate_label2.Location = new System.Drawing.Point(114, 45);
            this.currentDate_label2.Name = "currentDate_label2";
            this.currentDate_label2.Size = new System.Drawing.Size(195, 37);
            this.currentDate_label2.TabIndex = 3;
            this.currentDate_label2.Text = "Current date";
            // 
            // updateDate_btn
            // 
            this.updateDate_btn.Location = new System.Drawing.Point(491, 482);
            this.updateDate_btn.Name = "updateDate_btn";
            this.updateDate_btn.Size = new System.Drawing.Size(159, 87);
            this.updateDate_btn.TabIndex = 4;
            this.updateDate_btn.Text = "Update";
            this.updateDate_btn.UseVisualStyleBackColor = true;
            this.updateDate_btn.Click += new System.EventHandler(this.updateDate_btn_Click);
            // 
            // AdminDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 679);
            this.Controls.Add(this.updateDate_btn);
            this.Controls.Add(this.currentDate_label2);
            this.Controls.Add(this.newDate_label);
            this.Controls.Add(this.newDate_textbox);
            this.Controls.Add(this.currentDate_label);
            this.Name = "AdminDateForm";
            this.Text = "AdminDateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentDate_label;
        private System.Windows.Forms.TextBox newDate_textbox;
        private System.Windows.Forms.Label newDate_label;
        private System.Windows.Forms.Label currentDate_label2;
        private System.Windows.Forms.Button updateDate_btn;
    }
}