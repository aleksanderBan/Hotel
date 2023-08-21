using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AdminDateForm : Form
    {
        private Data data = new Data();
        private int selectedRoomId;

        public AdminDateForm(int roomId)
        {
            InitializeComponent();
            selectedRoomId = roomId;

            string dateFrom = data.DBGetDateFromForRoom(roomId);
            string dateUntil = data.DBGetDateUntilForRoom(roomId);

            currentDateFrom_label.Text = "Date From: " + dateFrom;
            currentDateUntil_label.Text = "Date Until: " + dateUntil;
        }

        private void updateDate_btn_Click(object sender, EventArgs e)
        {
            string newDateFrom = newDateFrom_textbox.Text;
            string newDateUntil = newDateUntil_textbox.Text;

            if (data.DBUpdateRoomDate(selectedRoomId, newDateFrom, newDateUntil))
            {
                MessageBox.Show("Date updated successfully!");
                currentDateFrom_label.Text = "Current Date: " + newDateFrom;
                currentDateUntil_label.Text = "Current Date: " + newDateUntil;
            }
            else
            {
                MessageBox.Show("Failed to update date. Please try again.");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}