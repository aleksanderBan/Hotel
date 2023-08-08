using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Rooms : Form
    {
        private List<(string RoomId, string RoomInfo)> availableRooms; // Declare at class level
        private string username; // Add a field to store the username
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

            // Get the selected room type from the combo box
            string selectedRoomType = roomType_combo.SelectedItem?.ToString();

            // Perform the database query to find available rooms
            Data data = new Data();
            availableRooms = data.DBFindRooms(startDatestr, endDatestr, selectedRoomType);

            if (availableRooms.Count > 0)
            {
                // Display the list of available rooms in a ListBox control
                availableRooms_list.Items.Clear();
                foreach (var room in availableRooms)
                {
                    string roomDetails = $"Room ID: {room.RoomId}, Info: {room.RoomInfo}";
                    availableRooms_list.Items.Add(roomDetails);
                }
            }
            else
            {
                // Handle the case when no available rooms are found
                MessageBox.Show("No rooms are available for the selected dates.");
            }

            // TEAST
            Console.WriteLine($"YIPEEEE {username}");
            // TEAST
        }

        //Room booking
        private void AvailableRooms_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (availableRooms_list.SelectedIndex >= 0)
            {
                // Get the selected room details
                var selectedRoom = availableRooms[availableRooms_list.SelectedIndex];

                // Show a confirmation dialog
                var result = MessageBox.Show($"Are you sure you want to proceed with Room ID: {selectedRoom.RoomId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms, proceed with further actions
                if (result == DialogResult.Yes)
                {
                    // Get the date of arrival and date of departure from the input fields
                    string arrivalDateStr = arrivalDate_text.Text;
                    string departureDateStr = departDate_text.Text;

                    // Perform database insertion for booking details
                    if (data.DBInsertBooking(username, arrivalDateStr, departureDateStr, selectedRoom.RoomId))
                    {
                        // Show a success message or perform any other actions you need
                        MessageBox.Show($"Booking for Room ID: {selectedRoom.RoomId} is successful!");
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
            // Get the user's booking history
            List<string> bookingHistory = data.DBGetBookingHistory(username);

            // Open the BookingHistoryForm and pass the booking history
            BookingHistory historyForm = new BookingHistory(bookingHistory);
            historyForm.ShowDialog();
        }
    }
}