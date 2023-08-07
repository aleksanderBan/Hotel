namespace Hotel
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
            this.room_label = new System.Windows.Forms.Label();
            this.roomType_combo = new System.Windows.Forms.ComboBox();
            this.findRooms_btn = new System.Windows.Forms.Button();
            this.availableRooms_list = new System.Windows.Forms.ListBox();
            this.bookingHistory_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrivalDate_label
            // 
            this.arrivalDate_label.AutoSize = true;
            this.arrivalDate_label.Location = new System.Drawing.Point(77, 56);
            this.arrivalDate_label.Name = "arrivalDate_label";
            this.arrivalDate_label.Size = new System.Drawing.Size(184, 37);
            this.arrivalDate_label.TabIndex = 0;
            this.arrivalDate_label.Text = "Arrival Date";
            // 
            // departDate_label
            // 
            this.departDate_label.AutoSize = true;
            this.departDate_label.Location = new System.Drawing.Point(84, 225);
            this.departDate_label.Name = "departDate_label";
            this.departDate_label.Size = new System.Drawing.Size(191, 37);
            this.departDate_label.TabIndex = 1;
            this.departDate_label.Text = "Staying until";
            // 
            // arrivalDate_text
            // 
            this.arrivalDate_text.Location = new System.Drawing.Point(84, 119);
            this.arrivalDate_text.Name = "arrivalDate_text";
            this.arrivalDate_text.Size = new System.Drawing.Size(249, 44);
            this.arrivalDate_text.TabIndex = 2;
            // 
            // departDate_text
            // 
            this.departDate_text.Location = new System.Drawing.Point(84, 310);
            this.departDate_text.Name = "departDate_text";
            this.departDate_text.Size = new System.Drawing.Size(249, 44);
            this.departDate_text.TabIndex = 3;
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Location = new System.Drawing.Point(772, 56);
            this.room_label.Name = "room_label";
            this.room_label.Size = new System.Drawing.Size(206, 37);
            this.room_label.TabIndex = 4;
            this.room_label.Text = "Type of room";
            // 
            // roomType_combo
            // 
            this.roomType_combo.BackColor = System.Drawing.SystemColors.Window;
            this.roomType_combo.FormattingEnabled = true;
            this.roomType_combo.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.roomType_combo.Location = new System.Drawing.Point(779, 141);
            this.roomType_combo.Name = "roomType_combo";
            this.roomType_combo.Size = new System.Drawing.Size(226, 45);
            this.roomType_combo.TabIndex = 5;
            // 
            // findRooms_btn
            // 
            this.findRooms_btn.Location = new System.Drawing.Point(91, 441);
            this.findRooms_btn.Name = "findRooms_btn";
            this.findRooms_btn.Size = new System.Drawing.Size(242, 143);
            this.findRooms_btn.TabIndex = 6;
            this.findRooms_btn.Text = "Find available rooms";
            this.findRooms_btn.UseVisualStyleBackColor = true;
            this.findRooms_btn.Click += new System.EventHandler(this.findRooms_btn_Click);
            // 
            // availableRooms_list
            // 
            this.availableRooms_list.FormattingEnabled = true;
            this.availableRooms_list.ItemHeight = 37;
            this.availableRooms_list.Location = new System.Drawing.Point(623, 275);
            this.availableRooms_list.Name = "availableRooms_list";
            this.availableRooms_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.availableRooms_list.Size = new System.Drawing.Size(548, 374);
            this.availableRooms_list.TabIndex = 7;
            this.availableRooms_list.SelectedIndexChanged += new System.EventHandler(this.availableRooms_list_SelectedIndexChanged);
            // 
            // bookingHistory_btn
            // 
            this.bookingHistory_btn.Location = new System.Drawing.Point(804, 697);
            this.bookingHistory_btn.Name = "bookingHistory_btn";
            this.bookingHistory_btn.Size = new System.Drawing.Size(261, 80);
            this.bookingHistory_btn.TabIndex = 8;
            this.bookingHistory_btn.Text = "History";
            this.bookingHistory_btn.UseVisualStyleBackColor = true;
            this.bookingHistory_btn.Click += new System.EventHandler(this.bookingHistory_btn_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1455, 832);
            this.Controls.Add(this.bookingHistory_btn);
            this.Controls.Add(this.availableRooms_list);
            this.Controls.Add(this.findRooms_btn);
            this.Controls.Add(this.roomType_combo);
            this.Controls.Add(this.room_label);
            this.Controls.Add(this.departDate_text);
            this.Controls.Add(this.arrivalDate_text);
            this.Controls.Add(this.departDate_label);
            this.Controls.Add(this.arrivalDate_label);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arrivalDate_label;
        private System.Windows.Forms.Label departDate_label;
        private System.Windows.Forms.TextBox arrivalDate_text;
        private System.Windows.Forms.TextBox departDate_text;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.ComboBox roomType_combo;
        private System.Windows.Forms.Button findRooms_btn;
        private System.Windows.Forms.ListBox availableRooms_list;
        private System.Windows.Forms.Button bookingHistory_btn;
    }
}