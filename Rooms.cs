using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Rooms : Form
    {
        private List<(string RoomId, string RoomInfo)> availableRooms; // Declare at class level

        public Rooms()
        {
            InitializeComponent();
        }

        // Find available rooms
        private void findRooms_btn_Click(object sender, EventArgs e)
        {
            string startDatestr = arrivalDate_text.Text;
            string endDatestr = departDate_text.Text;

            // Perform the database query to find available rooms
            Data data = new Data();
            availableRooms = data.AvailableRoomsDB(startDatestr, endDatestr);

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
        }

        // Handle the DoubleClick event of the ListBox
        private void availableRooms_list_SelectedIndexChanged(object sender, EventArgs e)
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
                    // TODO: Implement the actions you want to perform when the user proceeds with the selected room
                    // For example, you can open a new form or perform any other actions here.
                }
            }

        }
    }

}
