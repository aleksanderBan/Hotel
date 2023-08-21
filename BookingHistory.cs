using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class BookingHistory : Form
    {
        private Data data = new Data();

        public BookingHistory(List<string> bookingHistory)
        {
            InitializeComponent();

            bookingHistory_list.Items.Clear();
            bookingHistory_list.Items.AddRange(bookingHistory.ToArray());
        }

        private void RemoveBooking_btn_Click(object sender, EventArgs e)
        {
            if (bookingHistory_list.CheckedItems.Count > 0)
            {
                var selectedBookings = new List<string>();

                foreach (var selectedItem in bookingHistory_list.CheckedItems)
                {
                    selectedBookings.Add(selectedItem.ToString());
                }

                var result = MessageBox.Show($"Are you sure you want to remove {selectedBookings.Count} bookings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (var selectedBooking in selectedBookings)
                    {
                        int bookingId = ExtractBookingId(selectedBooking);
                        if (bookingId != -1)
                        {
                            if (data.DBRemoveBooking(bookingId))
                            {
                                bookingHistory_list.Items.Remove(selectedBooking);
                            }
                            else
                            {
                                MessageBox.Show($"Failed to remove booking with ID: {bookingId}.");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Failed to extract Booking ID from selected booking.");
                        }
                    }

                    MessageBox.Show($"{selectedBookings.Count} bookings have been removed successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select bookings from the list to remove.");
            }
        }

        // Method to extract booking ID from booking details string
        private int ExtractBookingId(string bookingDetails)
        {
            Match match = Regex.Match(bookingDetails, @"Booking ID:\s*(\d+)");

            if (match.Success)
            {
                string bookingIdStr = match.Groups[1].Value;
                int bookingId = int.Parse(bookingIdStr);
                return bookingId;
            }

            return -1;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}