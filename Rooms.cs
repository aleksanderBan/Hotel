using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Rooms : Form
    {
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
            List<(string RoomId, string RoomInfo)> availableRooms = data.AvailableRoomsDB(startDatestr, endDatestr);

            if (availableRooms.Count > 0)
            {
                // Display the list of available rooms in a ListBox or any other control
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
    }
}
