﻿namespace Hotel
{
    partial class Rooms
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
            this.arrivalDate_label = new System.Windows.Forms.Label();
            this.departDate_label = new System.Windows.Forms.Label();
            this.arrivalDate_text = new System.Windows.Forms.TextBox();
            this.departDate_text = new System.Windows.Forms.TextBox();
            this.roomType_label = new System.Windows.Forms.Label();
            this.roomType_combo = new System.Windows.Forms.ComboBox();
            this.findRooms_btn = new System.Windows.Forms.Button();
            this.availableRooms_list = new System.Windows.Forms.ListBox();
            this.bookingHistory_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrivalDate_label
            // 
            this.arrivalDate_label.AutoSize = true;
            this.arrivalDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.arrivalDate_label.Location = new System.Drawing.Point(83, 84);
            this.arrivalDate_label.Name = "arrivalDate_label";
            this.arrivalDate_label.Size = new System.Drawing.Size(199, 40);
            this.arrivalDate_label.TabIndex = 0;
            this.arrivalDate_label.Text = "Arrival date";
            // 
            // departDate_label
            // 
            this.departDate_label.AutoSize = true;
            this.departDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.departDate_label.Location = new System.Drawing.Point(32, 178);
            this.departDate_label.Name = "departDate_label";
            this.departDate_label.Size = new System.Drawing.Size(257, 40);
            this.departDate_label.TabIndex = 1;
            this.departDate_label.Text = "Departure date";
            // 
            // arrivalDate_text
            // 
            this.arrivalDate_text.Location = new System.Drawing.Point(314, 85);
            this.arrivalDate_text.Name = "arrivalDate_text";
            this.arrivalDate_text.Size = new System.Drawing.Size(249, 44);
            this.arrivalDate_text.TabIndex = 2;
            // 
            // departDate_text
            // 
            this.departDate_text.Location = new System.Drawing.Point(314, 179);
            this.departDate_text.Name = "departDate_text";
            this.departDate_text.Size = new System.Drawing.Size(249, 44);
            this.departDate_text.TabIndex = 3;
            // 
            // roomType_label
            // 
            this.roomType_label.AutoSize = true;
            this.roomType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.roomType_label.Location = new System.Drawing.Point(56, 275);
            this.roomType_label.Name = "roomType_label";
            this.roomType_label.Size = new System.Drawing.Size(229, 40);
            this.roomType_label.TabIndex = 4;
            this.roomType_label.Text = "Type of room";
            // 
            // roomType_combo
            // 
            this.roomType_combo.BackColor = System.Drawing.SystemColors.Window;
            this.roomType_combo.FormattingEnabled = true;
            this.roomType_combo.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.roomType_combo.Location = new System.Drawing.Point(314, 276);
            this.roomType_combo.Name = "roomType_combo";
            this.roomType_combo.Size = new System.Drawing.Size(226, 45);
            this.roomType_combo.TabIndex = 5;
            // 
            // findRooms_btn
            // 
            this.findRooms_btn.Location = new System.Drawing.Point(217, 410);
            this.findRooms_btn.Name = "findRooms_btn";
            this.findRooms_btn.Size = new System.Drawing.Size(242, 143);
            this.findRooms_btn.TabIndex = 6;
            this.findRooms_btn.Text = "Find available rooms";
            this.findRooms_btn.UseVisualStyleBackColor = true;
            this.findRooms_btn.Click += new System.EventHandler(this.FindRooms_btn_Click);
            // 
            // availableRooms_list
            // 
            this.availableRooms_list.FormattingEnabled = true;
            this.availableRooms_list.ItemHeight = 37;
            this.availableRooms_list.Location = new System.Drawing.Point(661, 68);
            this.availableRooms_list.Name = "availableRooms_list";
            this.availableRooms_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.availableRooms_list.Size = new System.Drawing.Size(1338, 300);
            this.availableRooms_list.TabIndex = 7;
            this.availableRooms_list.SelectedIndexChanged += new System.EventHandler(this.AvailableRooms_list_SelectedIndexChanged);
            // 
            // bookingHistory_btn
            // 
            this.bookingHistory_btn.Location = new System.Drawing.Point(875, 431);
            this.bookingHistory_btn.Name = "bookingHistory_btn";
            this.bookingHistory_btn.Size = new System.Drawing.Size(271, 122);
            this.bookingHistory_btn.TabIndex = 8;
            this.bookingHistory_btn.Text = "Booking history";
            this.bookingHistory_btn.UseVisualStyleBackColor = true;
            this.bookingHistory_btn.Click += new System.EventHandler(this.BookingHistory_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(63, 674);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(200, 94);
            this.logout_btn.TabIndex = 9;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2037, 832);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.bookingHistory_btn);
            this.Controls.Add(this.availableRooms_list);
            this.Controls.Add(this.findRooms_btn);
            this.Controls.Add(this.roomType_combo);
            this.Controls.Add(this.roomType_label);
            this.Controls.Add(this.departDate_text);
            this.Controls.Add(this.arrivalDate_text);
            this.Controls.Add(this.departDate_label);
            this.Controls.Add(this.arrivalDate_label);
            this.Name = "Rooms";
            this.Text = "Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arrivalDate_label;
        private System.Windows.Forms.Label departDate_label;
        private System.Windows.Forms.TextBox arrivalDate_text;
        private System.Windows.Forms.TextBox departDate_text;
        private System.Windows.Forms.Label roomType_label;
        private System.Windows.Forms.ComboBox roomType_combo;
        private System.Windows.Forms.Button findRooms_btn;
        private System.Windows.Forms.ListBox availableRooms_list;
        private System.Windows.Forms.Button bookingHistory_btn;
        private System.Windows.Forms.Button logout_btn;
    }
}