namespace Hotel
{
    partial class CreateBookingAdmin
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
            this.adminDateFrom_text = new System.Windows.Forms.TextBox();
            this.adminDateUntil_text = new System.Windows.Forms.TextBox();
            this.adminFindRooms_btn = new System.Windows.Forms.Button();
            this.adminRoomType_combo = new System.Windows.Forms.ComboBox();
            this.adminAvailableRooms_list = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.adminDateFrom_label = new System.Windows.Forms.Label();
            this.adminDateUntil_label = new System.Windows.Forms.Label();
            this.adminRoomType_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminDateFrom_text
            // 
            this.adminDateFrom_text.Location = new System.Drawing.Point(322, 74);
            this.adminDateFrom_text.Name = "adminDateFrom_text";
            this.adminDateFrom_text.Size = new System.Drawing.Size(288, 44);
            this.adminDateFrom_text.TabIndex = 0;
            // 
            // adminDateUntil_text
            // 
            this.adminDateUntil_text.Location = new System.Drawing.Point(322, 182);
            this.adminDateUntil_text.Name = "adminDateUntil_text";
            this.adminDateUntil_text.Size = new System.Drawing.Size(288, 44);
            this.adminDateUntil_text.TabIndex = 1;
            // 
            // adminFindRooms_btn
            // 
            this.adminFindRooms_btn.Location = new System.Drawing.Point(229, 418);
            this.adminFindRooms_btn.Name = "adminFindRooms_btn";
            this.adminFindRooms_btn.Size = new System.Drawing.Size(238, 159);
            this.adminFindRooms_btn.TabIndex = 2;
            this.adminFindRooms_btn.Text = "Find available rooms";
            this.adminFindRooms_btn.UseVisualStyleBackColor = true;
            this.adminFindRooms_btn.Click += new System.EventHandler(this.adminFindRooms_btn_Click);
            // 
            // adminRoomType_combo
            // 
            this.adminRoomType_combo.FormattingEnabled = true;
            this.adminRoomType_combo.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.adminRoomType_combo.Location = new System.Drawing.Point(322, 297);
            this.adminRoomType_combo.Name = "adminRoomType_combo";
            this.adminRoomType_combo.Size = new System.Drawing.Size(208, 45);
            this.adminRoomType_combo.TabIndex = 3;
            // 
            // adminAvailableRooms_list
            // 
            this.adminAvailableRooms_list.FormattingEnabled = true;
            this.adminAvailableRooms_list.ItemHeight = 37;
            this.adminAvailableRooms_list.Location = new System.Drawing.Point(703, 60);
            this.adminAvailableRooms_list.Name = "adminAvailableRooms_list";
            this.adminAvailableRooms_list.Size = new System.Drawing.Size(978, 300);
            this.adminAvailableRooms_list.TabIndex = 4;
            this.adminAvailableRooms_list.SelectedIndexChanged += new System.EventHandler(this.adminAvailableRooms_list_SelectedIndexChanged);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(62, 689);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(241, 105);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Go back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // adminDateFrom_label
            // 
            this.adminDateFrom_label.AutoSize = true;
            this.adminDateFrom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.adminDateFrom_label.Location = new System.Drawing.Point(85, 73);
            this.adminDateFrom_label.Name = "adminDateFrom_label";
            this.adminDateFrom_label.Size = new System.Drawing.Size(199, 40);
            this.adminDateFrom_label.TabIndex = 6;
            this.adminDateFrom_label.Text = "Arrival date";
            // 
            // adminDateUntil_label
            // 
            this.adminDateUntil_label.AutoSize = true;
            this.adminDateUntil_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.adminDateUntil_label.Location = new System.Drawing.Point(27, 181);
            this.adminDateUntil_label.Name = "adminDateUntil_label";
            this.adminDateUntil_label.Size = new System.Drawing.Size(257, 40);
            this.adminDateUntil_label.TabIndex = 7;
            this.adminDateUntil_label.Text = "Departure date";
            // 
            // adminRoomType_label
            // 
            this.adminRoomType_label.AutoSize = true;
            this.adminRoomType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.adminRoomType_label.Location = new System.Drawing.Point(55, 297);
            this.adminRoomType_label.Name = "adminRoomType_label";
            this.adminRoomType_label.Size = new System.Drawing.Size(229, 40);
            this.adminRoomType_label.TabIndex = 8;
            this.adminRoomType_label.Text = "Type of room";
            // 
            // CreateBookingAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1721, 851);
            this.Controls.Add(this.adminRoomType_label);
            this.Controls.Add(this.adminDateUntil_label);
            this.Controls.Add(this.adminDateFrom_label);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.adminAvailableRooms_list);
            this.Controls.Add(this.adminRoomType_combo);
            this.Controls.Add(this.adminFindRooms_btn);
            this.Controls.Add(this.adminDateUntil_text);
            this.Controls.Add(this.adminDateFrom_text);
            this.Name = "CreateBookingAdmin";
            this.Text = "CreateBookingAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminDateFrom_text;
        private System.Windows.Forms.TextBox adminDateUntil_text;
        private System.Windows.Forms.Button adminFindRooms_btn;
        private System.Windows.Forms.ComboBox adminRoomType_combo;
        private System.Windows.Forms.ListBox adminAvailableRooms_list;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label adminDateFrom_label;
        private System.Windows.Forms.Label adminDateUntil_label;
        private System.Windows.Forms.Label adminRoomType_label;
    }
}