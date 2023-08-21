using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hotel
{
    public partial class CreateBookingAdmin : Form
    {
        string admin = "admin";
        private Data data = new Data();
        private List<(string RoomId, string RoomInfo)> availableRooms;
        public CreateBookingAdmin()
        {
            InitializeComponent();
        }

        private void adminFindRooms_btn_Click(object sender, EventArgs e)
        {
            string startDatestr = adminDateFrom_text.Text;
            string endDatestr = adminDateUntil_text.Text;

            string selectedRoomType = adminRoomType_combo.SelectedItem?.ToString();

            availableRooms = data.DBFindRooms(startDatestr, endDatestr, selectedRoomType);

            if (availableRooms.Count > 0)
            {
                adminAvailableRooms_list.Items.Clear();
                foreach (var room in availableRooms)
                {
                    string roomDetails = $"Room ID: {room.RoomId}, Info: {room.RoomInfo}";
                    adminAvailableRooms_list.Items.Add(roomDetails);
                }
            }
            else
            {
                MessageBox.Show("No rooms are available for the selected dates.");
            }
        }

        private void adminAvailableRooms_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adminAvailableRooms_list.SelectedIndex >= 0)
            {
                var selectedRoom = availableRooms[adminAvailableRooms_list.SelectedIndex];

                var result = MessageBox.Show($"Are you sure you want to proceed with Room no.{selectedRoom.RoomId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string arrivalDateStr = adminDateFrom_text.Text;
                    string departureDateStr = adminDateUntil_text.Text;

                    if (data.DBInsertBooking(admin, arrivalDateStr, departureDateStr, selectedRoom.RoomId))
                    {
                        MessageBox.Show($"Booking for Room ID: {selectedRoom.RoomId} is successful!");
                    }
                    else
                    {
                        MessageBox.Show($"Booking for Room ID: {selectedRoom.RoomId} failed!");
                    }
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}