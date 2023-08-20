using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            // Get the selected room type from the combo box
            string selectedRoomType = adminRoomType_combo.SelectedItem?.ToString();

            // Perform the database query to find available rooms
            availableRooms = data.DBFindRooms(startDatestr, endDatestr, selectedRoomType);

            if (availableRooms.Count > 0)
            {
                // Display the list of available rooms in a ListBox control
                adminAvailableRooms_list.Items.Clear();
                foreach (var room in availableRooms)
                {
                    string roomDetails = $"Room ID: {room.RoomId}, Info: {room.RoomInfo}";
                    adminAvailableRooms_list.Items.Add(roomDetails);
                }
            }
            else
            {
                // Handle the case when no available rooms are found
                MessageBox.Show("No rooms are available for the selected dates.");
            }
        }


        private void adminAvailableRooms_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (adminAvailableRooms_list.SelectedIndex >= 0)
            {
                // Get the selected room details
                var selectedRoom = availableRooms[adminAvailableRooms_list.SelectedIndex];

                // Show a confirmation dialog
                var result = MessageBox.Show($"Are you sure you want to proceed with Room ID: {selectedRoom.RoomId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms, proceed with further actions
                if (result == DialogResult.Yes)
                {
                    // Get the date of arrival and date of departure from the input fields
                    string arrivalDateStr = adminDateFrom_text.Text;
                    string departureDateStr = adminDateUntil_text.Text;

                    // Perform database insertion for booking details
                    if (data.DBInsertBooking(admin, arrivalDateStr, departureDateStr, selectedRoom.RoomId))
                    {
                        // Show a success message or perform any other actions you need
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
