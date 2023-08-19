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
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrom_textbox = new System.Windows.Forms.TextBox();
            this.roomInfo_textbox = new System.Windows.Forms.TextBox();
            this.dateUntil_textbox = new System.Windows.Forms.TextBox();
            this.addRoom_btn = new System.Windows.Forms.Button();
            this.roomType_combo = new System.Windows.Forms.ComboBox();
            this.roomType_label = new System.Windows.Forms.Label();
            this.dateFrom_label = new System.Windows.Forms.Label();
            this.dateUntil_label = new System.Windows.Forms.Label();
            this.roomInfo_label = new System.Windows.Forms.Label();
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
            this.roomInfo_list.Location = new System.Drawing.Point(759, 71);
            this.roomInfo_list.Name = "roomInfo_list";
            this.roomInfo_list.Size = new System.Drawing.Size(442, 559);
            this.roomInfo_list.TabIndex = 8;
            this.roomInfo_list.SelectedIndexChanged += new System.EventHandler(this.roomInfo_list_SelectedIndexChanged);
            // 
            // loadRooms_btn
            // 
            this.loadRooms_btn.Location = new System.Drawing.Point(907, 702);
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(1262, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 677);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // dateFrom_textbox
            // 
            this.dateFrom_textbox.Location = new System.Drawing.Point(1384, 255);
            this.dateFrom_textbox.Name = "dateFrom_textbox";
            this.dateFrom_textbox.Size = new System.Drawing.Size(313, 44);
            this.dateFrom_textbox.TabIndex = 13;
            // 
            // roomInfo_textbox
            // 
            this.roomInfo_textbox.Location = new System.Drawing.Point(1384, 542);
            this.roomInfo_textbox.Name = "roomInfo_textbox";
            this.roomInfo_textbox.Size = new System.Drawing.Size(313, 44);
            this.roomInfo_textbox.TabIndex = 15;
            // 
            // dateUntil_textbox
            // 
            this.dateUntil_textbox.Location = new System.Drawing.Point(1384, 395);
            this.dateUntil_textbox.Name = "dateUntil_textbox";
            this.dateUntil_textbox.Size = new System.Drawing.Size(313, 44);
            this.dateUntil_textbox.TabIndex = 14;
            // 
            // addRoom_btn
            // 
            this.addRoom_btn.Location = new System.Drawing.Point(1482, 690);
            this.addRoom_btn.Name = "addRoom_btn";
            this.addRoom_btn.Size = new System.Drawing.Size(176, 84);
            this.addRoom_btn.TabIndex = 16;
            this.addRoom_btn.Text = "button1";
            this.addRoom_btn.UseVisualStyleBackColor = true;
            this.addRoom_btn.Click += new System.EventHandler(this.addRoom_btn_Click);
            // 
            // roomType_combo
            // 
            this.roomType_combo.FormattingEnabled = true;
            this.roomType_combo.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.roomType_combo.Location = new System.Drawing.Point(1384, 109);
            this.roomType_combo.Name = "roomType_combo";
            this.roomType_combo.Size = new System.Drawing.Size(313, 45);
            this.roomType_combo.TabIndex = 17;
            // 
            // roomType_label
            // 
            this.roomType_label.AutoSize = true;
            this.roomType_label.Location = new System.Drawing.Point(1377, 46);
            this.roomType_label.Name = "roomType_label";
            this.roomType_label.Size = new System.Drawing.Size(170, 37);
            this.roomType_label.TabIndex = 18;
            this.roomType_label.Text = "Room type";
            // 
            // dateFrom_label
            // 
            this.dateFrom_label.AutoSize = true;
            this.dateFrom_label.Location = new System.Drawing.Point(1384, 190);
            this.dateFrom_label.Name = "dateFrom_label";
            this.dateFrom_label.Size = new System.Drawing.Size(220, 37);
            this.dateFrom_label.TabIndex = 19;
            this.dateFrom_label.Text = "Available from";
            // 
            // dateUntil_label
            // 
            this.dateUntil_label.AutoSize = true;
            this.dateUntil_label.Location = new System.Drawing.Point(1384, 333);
            this.dateUntil_label.Name = "dateUntil_label";
            this.dateUntil_label.Size = new System.Drawing.Size(214, 37);
            this.dateUntil_label.TabIndex = 20;
            this.dateUntil_label.Text = "Available until";
            // 
            // roomInfo_label
            // 
            this.roomInfo_label.AutoSize = true;
            this.roomInfo_label.Location = new System.Drawing.Point(1384, 481);
            this.roomInfo_label.Name = "roomInfo_label";
            this.roomInfo_label.Size = new System.Drawing.Size(163, 37);
            this.roomInfo_label.TabIndex = 21;
            this.roomInfo_label.Text = "Room info";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1879, 874);
            this.Controls.Add(this.roomInfo_label);
            this.Controls.Add(this.dateUntil_label);
            this.Controls.Add(this.dateFrom_label);
            this.Controls.Add(this.roomType_label);
            this.Controls.Add(this.roomType_combo);
            this.Controls.Add(this.addRoom_btn);
            this.Controls.Add(this.roomInfo_textbox);
            this.Controls.Add(this.dateUntil_textbox);
            this.Controls.Add(this.dateFrom_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadBookings_btn);
            this.Controls.Add(this.loadRooms_btn);
            this.Controls.Add(this.roomInfo_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingsOverwatch_list);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox bookingsOverwatch_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox roomInfo_list;
        private System.Windows.Forms.Button loadRooms_btn;
        private System.Windows.Forms.Button loadBookings_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateFrom_textbox;
        private System.Windows.Forms.TextBox roomInfo_textbox;
        private System.Windows.Forms.TextBox dateUntil_textbox;
        private System.Windows.Forms.Button addRoom_btn;
        private System.Windows.Forms.ComboBox roomType_combo;
        private System.Windows.Forms.Label roomType_label;
        private System.Windows.Forms.Label dateFrom_label;
        private System.Windows.Forms.Label dateUntil_label;
        private System.Windows.Forms.Label roomInfo_label;
    }
}