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
            this.SuspendLayout();
            // 
            // adminDateFrom_text
            // 
            this.adminDateFrom_text.Location = new System.Drawing.Point(134, 121);
            this.adminDateFrom_text.Name = "adminDateFrom_text";
            this.adminDateFrom_text.Size = new System.Drawing.Size(226, 44);
            this.adminDateFrom_text.TabIndex = 0;
            // 
            // adminDateUntil_text
            // 
            this.adminDateUntil_text.Location = new System.Drawing.Point(134, 245);
            this.adminDateUntil_text.Name = "adminDateUntil_text";
            this.adminDateUntil_text.Size = new System.Drawing.Size(226, 44);
            this.adminDateUntil_text.TabIndex = 1;
            // 
            // adminFindRooms_btn
            // 
            this.adminFindRooms_btn.Location = new System.Drawing.Point(176, 456);
            this.adminFindRooms_btn.Name = "adminFindRooms_btn";
            this.adminFindRooms_btn.Size = new System.Drawing.Size(199, 121);
            this.adminFindRooms_btn.TabIndex = 2;
            this.adminFindRooms_btn.Text = "button1";
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
            this.adminRoomType_combo.Location = new System.Drawing.Point(734, 105);
            this.adminRoomType_combo.Name = "adminRoomType_combo";
            this.adminRoomType_combo.Size = new System.Drawing.Size(208, 45);
            this.adminRoomType_combo.TabIndex = 3;
            // 
            // adminAvailableRooms_list
            // 
            this.adminAvailableRooms_list.FormattingEnabled = true;
            this.adminAvailableRooms_list.ItemHeight = 37;
            this.adminAvailableRooms_list.Location = new System.Drawing.Point(736, 295);
            this.adminAvailableRooms_list.Name = "adminAvailableRooms_list";
            this.adminAvailableRooms_list.Size = new System.Drawing.Size(390, 300);
            this.adminAvailableRooms_list.TabIndex = 4;
            this.adminAvailableRooms_list.SelectedIndexChanged += new System.EventHandler(this.adminAvailableRooms_list_SelectedIndexChanged);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(1162, 64);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(142, 121);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Go back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // CreateBookingAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 715);
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
    }
}