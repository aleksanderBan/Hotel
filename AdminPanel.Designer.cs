namespace Hotel
{
    partial class AdminPanel
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
            this.bookingsOverwatch_list = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomInfo_list = new System.Windows.Forms.ListBox();
            this.loadRooms_btn = new System.Windows.Forms.Button();
            this.loadBookings_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookingsOverwatch_list
            // 
            this.bookingsOverwatch_list.FormattingEnabled = true;
            this.bookingsOverwatch_list.Location = new System.Drawing.Point(77, 71);
            this.bookingsOverwatch_list.Name = "bookingsOverwatch_list";
            this.bookingsOverwatch_list.Size = new System.Drawing.Size(536, 391);
            this.bookingsOverwatch_list.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(653, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 677);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // roomInfo_list
            // 
            this.roomInfo_list.FormattingEnabled = true;
            this.roomInfo_list.ItemHeight = 37;
            this.roomInfo_list.Location = new System.Drawing.Point(879, 71);
            this.roomInfo_list.Name = "roomInfo_list";
            this.roomInfo_list.Size = new System.Drawing.Size(442, 559);
            this.roomInfo_list.TabIndex = 8;
            this.roomInfo_list.SelectedIndexChanged += new System.EventHandler(this.roomInfo_list_SelectedIndexChanged);
            // 
            // loadRooms_btn
            // 
            this.loadRooms_btn.Location = new System.Drawing.Point(1033, 685);
            this.loadRooms_btn.Name = "loadRooms_btn";
            this.loadRooms_btn.Size = new System.Drawing.Size(168, 60);
            this.loadRooms_btn.TabIndex = 9;
            this.loadRooms_btn.Text = "Load";
            this.loadRooms_btn.UseVisualStyleBackColor = true;
            this.loadRooms_btn.Click += new System.EventHandler(this.loadRooms_btn_Click);
            // 
            // loadBookings_btn
            // 
            this.loadBookings_btn.Location = new System.Drawing.Point(122, 675);
            this.loadBookings_btn.Name = "loadBookings_btn";
            this.loadBookings_btn.Size = new System.Drawing.Size(166, 70);
            this.loadBookings_btn.TabIndex = 10;
            this.loadBookings_btn.Text = "Load";
            this.loadBookings_btn.UseVisualStyleBackColor = true;
            this.loadBookings_btn.Click += new System.EventHandler(this.loadBookings_btn_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1879, 874);
            this.Controls.Add(this.loadBookings_btn);
            this.Controls.Add(this.loadRooms_btn);
            this.Controls.Add(this.roomInfo_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingsOverwatch_list);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox bookingsOverwatch_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox roomInfo_list;
        private System.Windows.Forms.Button loadRooms_btn;
        private System.Windows.Forms.Button loadBookings_btn;
    }
}