using System;
using System.Collections.Generic;
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

        //Load rooms
        private void loadRooms_btn_Click(object sender, EventArgs e)
        {
            List<string> roomInfoList = data.DBGetRoomInformation();

            roomInfo_list.Items.Clear();
            roomInfo_list.Items.AddRange(roomInfoList.ToArray());
        }

        //Load bookings
        private void loadBookings_btn_Click(object sender, EventArgs e)
        {
            List<string> roomInfoList = data.DBGetBookingsAdmin();

            bookingsOverwatch_list.Items.Clear();
            bookingsOverwatch_list.Items.AddRange(roomInfoList.ToArray());
        }

        //Find selected room ID
        private int ExtractRoomId(string roomInfo)
        {
            int idIndex = roomInfo.IndexOf("ID:") + 4;
            int commaIndex = roomInfo.IndexOf(",", idIndex);
            string idSubstring = roomInfo.Substring(idIndex, commaIndex - idIndex);

            if (int.TryParse(idSubstring.Trim(), out int roomId))
            {
                return roomId;
            }

            return -1;
        }

        //Select a room to change the date of
        private void roomInfo_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomInfo_list.SelectedIndex != -1)
            {
                string selectedRoomInfo = roomInfo_list.SelectedItem.ToString();

                int roomId = ExtractRoomId(selectedRoomInfo);

                AdminDateForm changeDateForm = new AdminDateForm(roomId);
                changeDateForm.ShowDialog();
            }
        }

        //Add a room
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

                List<string> roomInfoList = data.DBGetRoomInformation();

                roomInfo_list.Items.Clear();
                roomInfo_list.Items.AddRange(roomInfoList.ToArray());
            }
            else
            {
                MessageBox.Show("Failed to add room.");
            }
        }

        //Remove a booking
        private void removeBookings_btn_Click(object sender, EventArgs e)
        {
            List<string> selectedBookings = new List<string>();
            foreach (var item in bookingsOverwatch_list.CheckedItems)
            {
                selectedBookings.Add(item.ToString());
            }

            if (selectedBookings.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected bookings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (string bookingDetails in selectedBookings)
                    {
                        int bookingId = data.ExtractBookingId(bookingDetails);

                        if (bookingId != -1)
                        {
                            if (data.DBRemoveBooking(bookingId))
                            {
                                int index = bookingsOverwatch_list.Items.IndexOf(bookingDetails);
                                if (index != -1)
                                {
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

        //Logout
        private void logoutAdmin_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
            MessageBox.Show("k bye");
        }

        //Book a room as admin
        private void adminBookingForm_btn_Click(object sender, EventArgs e)
        {
            CreateBookingAdmin adminbookform = new CreateBookingAdmin();
            adminbookform.Show();
        }
    }
}