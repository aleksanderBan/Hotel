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
            this.currentDateFrom_label = new System.Windows.Forms.Label();
            this.newDateFrom_textbox = new System.Windows.Forms.TextBox();
            this.newDateFrom_label = new System.Windows.Forms.Label();
            this.currentDateFrom_label2 = new System.Windows.Forms.Label();
            this.updateDate_btn = new System.Windows.Forms.Button();
            this.currentDateUntil_label2 = new System.Windows.Forms.Label();
            this.currentDateUntil_label = new System.Windows.Forms.Label();
            this.newDateUntil_label = new System.Windows.Forms.Label();
            this.newDateUntil_textbox = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentDateFrom_label
            // 
            this.currentDateFrom_label.AutoSize = true;
            this.currentDateFrom_label.Location = new System.Drawing.Point(116, 130);
            this.currentDateFrom_label.Name = "currentDateFrom_label";
            this.currentDateFrom_label.Size = new System.Drawing.Size(100, 37);
            this.currentDateFrom_label.TabIndex = 0;
            this.currentDateFrom_label.Text = "label1";
            // 
            // newDateFrom_textbox
            // 
            this.newDateFrom_textbox.Location = new System.Drawing.Point(123, 410);
            this.newDateFrom_textbox.Name = "newDateFrom_textbox";
            this.newDateFrom_textbox.Size = new System.Drawing.Size(222, 44);
            this.newDateFrom_textbox.TabIndex = 1;
            // 
            // newDateFrom_label
            // 
            this.newDateFrom_label.AutoSize = true;
            this.newDateFrom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newDateFrom_label.Location = new System.Drawing.Point(116, 333);
            this.newDateFrom_label.Name = "newDateFrom_label";
            this.newDateFrom_label.Size = new System.Drawing.Size(251, 40);
            this.newDateFrom_label.TabIndex = 2;
            this.newDateFrom_label.Text = "New date from";
            // 
            // currentDateFrom_label2
            // 
            this.currentDateFrom_label2.AutoSize = true;
            this.currentDateFrom_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.currentDateFrom_label2.Location = new System.Drawing.Point(114, 45);
            this.currentDateFrom_label2.Name = "currentDateFrom_label2";
            this.currentDateFrom_label2.Size = new System.Drawing.Size(299, 40);
            this.currentDateFrom_label2.TabIndex = 3;
            this.currentDateFrom_label2.Text = "Current date from";
            // 
            // updateDate_btn
            // 
            this.updateDate_btn.Location = new System.Drawing.Point(412, 491);
            this.updateDate_btn.Name = "updateDate_btn";
            this.updateDate_btn.Size = new System.Drawing.Size(159, 87);
            this.updateDate_btn.TabIndex = 4;
            this.updateDate_btn.Text = "Update";
            this.updateDate_btn.UseVisualStyleBackColor = true;
            this.updateDate_btn.Click += new System.EventHandler(this.updateDate_btn_Click);
            // 
            // currentDateUntil_label2
            // 
            this.currentDateUntil_label2.AutoSize = true;
            this.currentDateUntil_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.currentDateUntil_label2.Location = new System.Drawing.Point(498, 45);
            this.currentDateUntil_label2.Name = "currentDateUntil_label2";
            this.currentDateUntil_label2.Size = new System.Drawing.Size(293, 40);
            this.currentDateUntil_label2.TabIndex = 5;
            this.currentDateUntil_label2.Text = "Current date until";
            // 
            // currentDateUntil_label
            // 
            this.currentDateUntil_label.AutoSize = true;
            this.currentDateUntil_label.Location = new System.Drawing.Point(498, 130);
            this.currentDateUntil_label.Name = "currentDateUntil_label";
            this.currentDateUntil_label.Size = new System.Drawing.Size(100, 37);
            this.currentDateUntil_label.TabIndex = 6;
            this.currentDateUntil_label.Text = "label1";
            // 
            // newDateUntil_label
            // 
            this.newDateUntil_label.AutoSize = true;
            this.newDateUntil_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newDateUntil_label.Location = new System.Drawing.Point(615, 333);
            this.newDateUntil_label.Name = "newDateUntil_label";
            this.newDateUntil_label.Size = new System.Drawing.Size(245, 40);
            this.newDateUntil_label.TabIndex = 7;
            this.newDateUntil_label.Text = "New date until";
            // 
            // newDateUntil_textbox
            // 
            this.newDateUntil_textbox.Location = new System.Drawing.Point(622, 410);
            this.newDateUntil_textbox.Name = "newDateUntil_textbox";
            this.newDateUntil_textbox.Size = new System.Drawing.Size(220, 44);
            this.newDateUntil_textbox.TabIndex = 8;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(811, 547);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(191, 93);
            this.back_btn.TabIndex = 9;
            this.back_btn.Text = "Go back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // AdminDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 679);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.newDateUntil_textbox);
            this.Controls.Add(this.newDateUntil_label);
            this.Controls.Add(this.currentDateUntil_label);
            this.Controls.Add(this.currentDateUntil_label2);
            this.Controls.Add(this.updateDate_btn);
            this.Controls.Add(this.currentDateFrom_label2);
            this.Controls.Add(this.newDateFrom_label);
            this.Controls.Add(this.newDateFrom_textbox);
            this.Controls.Add(this.currentDateFrom_label);
            this.Name = "AdminDateForm";
            this.Text = "Date Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentDateFrom_label;
        private System.Windows.Forms.TextBox newDateFrom_textbox;
        private System.Windows.Forms.Label newDateFrom_label;
        private System.Windows.Forms.Label currentDateFrom_label2;
        private System.Windows.Forms.Button updateDate_btn;
        private System.Windows.Forms.Label currentDateUntil_label2;
        private System.Windows.Forms.Label currentDateUntil_label;
        private System.Windows.Forms.Label newDateUntil_label;
        private System.Windows.Forms.TextBox newDateUntil_textbox;
        private System.Windows.Forms.Button back_btn;
    }
}