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
            this.bookingHistory_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bookingHistory_list
            // 
            this.bookingHistory_list.FormattingEnabled = true;
            this.bookingHistory_list.ItemHeight = 37;
            this.bookingHistory_list.Location = new System.Drawing.Point(360, 92);
            this.bookingHistory_list.Name = "bookingHistory_list";
            this.bookingHistory_list.Size = new System.Drawing.Size(386, 263);
            this.bookingHistory_list.TabIndex = 0;
            // 
            // BookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 668);
            this.Controls.Add(this.bookingHistory_list);
            this.Name = "BookingHistory";
            this.Text = "BookingHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookingHistory_list;
    }
}