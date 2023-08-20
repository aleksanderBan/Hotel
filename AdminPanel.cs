using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AdminPanel : Form
    {
        private Data data = new Data();

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void loadRooms_btn_Click(object sender, EventArgs e)
        {
            // Call the method to get room information from the database
            List<string> roomInfoList = data.DBGetRoomInformation();

            // Populate the ListBox with room information
            roomInfo_list.Items.Clear();
            roomInfo_list.Items.AddRange(roomInfoList.ToArray());
        }

        private void loadBookings_btn_Click(object sender, EventArgs e)
        {
            List<string> roomInfoList = data.DBGetBookingsAdmin();

            bookingsOverwatch_list.Items.Clear();
            bookingsOverwatch_list.Items.AddRange(roomInfoList.ToArray());
        }

        //Find selected room ID
        private int ExtractRoomId(string roomInfo)
        {
            // Find the index of "ID:" and extract the substring after it
            int idIndex = roomInfo.IndexOf("ID:") + 4;
            int commaIndex = roomInfo.IndexOf(",", idIndex);
            string idSubstring = roomInfo.Substring(idIndex, commaIndex - idIndex);

            // Convert the extracted substring to an integer
            if (int.TryParse(idSubstring.Trim(), out int roomId))
            {
                return roomId;
            }

            // Return -1 if extraction fails
            return -1;
        }

        //Select a room to change the date of
        private void roomInfo_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomInfo_list.SelectedIndex != -1)
            {
                string selectedRoomInfo = roomInfo_list.SelectedItem.ToString();

                // Extract room ID from the selected item (you might need to adjust this logic)
                int roomId = ExtractRoomId(selectedRoomInfo);

                // Open the ChangeDateForm and pass the room ID
                AdminDateForm changeDateForm = new AdminDateForm(roomId);
                changeDateForm.ShowDialog();
            }
        }

        private void addRoom_btn_Click(object sender, EventArgs e)
        {
            string roomType = roomType_combo.Text;
            string dateFrom = dateFrom_textbox.Text;
            string dateUntil = dateUntil_textbox.Text;
            string roomInfo = roomInfo_textbox.Text;

            bool success = data.DBAddRoomAdmin(roomType, dateFrom, dateUntil, roomInfo);
            if (success)
            {
                MessageBox.Show($"{roomType} room added successfully.");

                // Call the method to get room information from the database
                List<string> roomInfoList = data.DBGetRoomInformation();

                // Populate the ListBox with room information
                roomInfo_list.Items.Clear();
                roomInfo_list.Items.AddRange(roomInfoList.ToArray());
            }
            else
            {
                MessageBox.Show("Failed to add room.");
            }
        }

        private void removeBookings_btn_Click(object sender, EventArgs e)
        {
            // Get the selected booking items from the checked list box
            List<string> selectedBookings = new List<string>();
            foreach (var item in bookingsOverwatch_list.CheckedItems)
            {
                selectedBookings.Add(item.ToString());
            }

            if (selectedBookings.Count > 0)
            {
                // Show a confirmation dialog
                var result = MessageBox.Show("Are you sure you want to delete the selected bookings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (string bookingDetails in selectedBookings)
                    {
                        // Extract the booking ID from the booking details string using the Data class method
                        int bookingId = data.ExtractBookingId(bookingDetails);

                        if (bookingId != -1)
                        {
                            // Call the Data class method to remove the booking
                            if (data.DBRemoveBooking(bookingId))
                            {
                                // Find the index of the booking details in the list box
                                int index = bookingsOverwatch_list.Items.IndexOf(bookingDetails);
                                if (index != -1)
                                {
                                    // Remove the selected booking from the checked list box
                                    bookingsOverwatch_list.Items.RemoveAt(index);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Failed to delete booking with Booking ID: {bookingId}.");
                            }
                        }
                    }

                    MessageBox.Show("Selected bookings deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select at least one booking to delete.");
            }
        }

        private void logoutAdmin_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
            MessageBox.Show("k bye");
        }

        private void adminBookingForm_btn_Click(object sender, EventArgs e)
        {
            CreateBookingAdmin adminbookform = new CreateBookingAdmin();
            adminbookform.Show();
        }
    }
}