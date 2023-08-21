using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Rooms : Form
    {
        private List<(string RoomId, string RoomInfo)> availableRooms;
        private string username;
        private Data data = new Data();

        public Rooms(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        // Find available rooms
        private void FindRooms_btn_Click(object sender, EventArgs e)
        {
            string startDatestr = arrivalDate_text.Text;
            string endDatestr = departDate_text.Text;

            string selectedRoomType = roomType_combo.SelectedItem?.ToString();

            Data data = new Data();
            availableRooms = data.DBFindRooms(startDatestr, endDatestr, selectedRoomType);

            if (availableRooms.Count > 0)
            {
                availableRooms_list.Items.Clear();
                foreach (var room in availableRooms)
                {
                    string roomDetails = $"Room ID: {room.RoomId}, Info: {room.RoomInfo}";
                    availableRooms_list.Items.Add(roomDetails);
                }
            }
            else
            {
                MessageBox.Show("No rooms are available for the selected dates.");
            }
        }

        //Room booking
        private void AvailableRooms_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (availableRooms_list.SelectedIndex >= 0)
            {
                var selectedRoom = availableRooms[availableRooms_list.SelectedIndex];

                var result = MessageBox.Show($"Are you sure you want to proceed with Room no.{selectedRoom.RoomId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string arrivalDateStr = arrivalDate_text.Text;
                    string departureDateStr = departDate_text.Text;

                    if (data.DBInsertBooking(username, arrivalDateStr, departureDateStr, selectedRoom.RoomId))
                    {
                        MessageBox.Show($"Booking for Room ID: {selectedRoom.RoomId} is successful! A confirmation has been sent to your mailbox.");
                    }
                    else {
                        MessageBox.Show($"Booking for Room ID: {selectedRoom.RoomId} failed!");
                    }
                }
            }
        }

        //Get booking history
        private void BookingHistory_btn_Click(object sender, EventArgs e)
        {
            List<string> bookingHistory = data.DBGetBookingHistory(username);

            BookingHistory historyForm = new BookingHistory(bookingHistory);
            historyForm.ShowDialog();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
            MessageBox.Show("Logged out");
        }
    }
}