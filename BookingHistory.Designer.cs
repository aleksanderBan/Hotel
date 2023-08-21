namespace Hotel
{
    partial class BookingHistory
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
            this.bookingHistory_list = new System.Windows.Forms.CheckedListBox();
            this.removeBooking_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookingHistory_list
            // 
            this.bookingHistory_list.FormattingEnabled = true;
            this.bookingHistory_list.Location = new System.Drawing.Point(62, 104);
            this.bookingHistory_list.Name = "bookingHistory_list";
            this.bookingHistory_list.Size = new System.Drawing.Size(607, 348);
            this.bookingHistory_list.TabIndex = 1;
            // 
            // removeBooking_btn
            // 
            this.removeBooking_btn.Location = new System.Drawing.Point(764, 104);
            this.removeBooking_btn.Name = "removeBooking_btn";
            this.removeBooking_btn.Size = new System.Drawing.Size(240, 132);
            this.removeBooking_btn.TabIndex = 2;
            this.removeBooking_btn.Text = "Remove Booking";
            this.removeBooking_btn.UseVisualStyleBackColor = true;
            this.removeBooking_btn.Click += new System.EventHandler(this.RemoveBooking_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(764, 348);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(240, 104);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Go back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // BookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 668);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.removeBooking_btn);
            this.Controls.Add(this.bookingHistory_list);
            this.Name = "BookingHistory";
            this.Text = "Booking History";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox bookingHistory_list;
        private System.Windows.Forms.Button removeBooking_btn;
        private System.Windows.Forms.Button back_btn;
    }
}