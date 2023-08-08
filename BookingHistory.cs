using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Add this for regular expressions
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

            // Display the booking history in the ListBox
            bookingHistory_list.Items.Clear();
            bookingHistory_list.Items.AddRange(bookingHistory.ToArray());
        }

        private void removeBooking_btn_Click(object sender, EventArgs e)
        {
            // Check if items are checked in the booking history checked list box
            if (bookingHistory_list.CheckedItems.Count > 0)
            {
                var selectedBookings = new List<string>();

                // Get the selected booking details for all checked items
                foreach (var selectedItem in bookingHistory_list.CheckedItems)
                {
                    selectedBookings.Add(selectedItem.ToString());
                }

                // Show a confirmation dialog
                var result = MessageBox.Show($"Are you sure you want to remove {selectedBookings.Count} bookings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms, proceed with removal
                if (result == DialogResult.Yes)
                {
                    foreach (var selectedBooking in selectedBookings)
                    {
                        int bookingId = ExtractBookingId(selectedBooking);
                        if (bookingId != -1) // Check if booking ID extraction is successful
                        {
                            if (data.DBRemoveBooking(bookingId))
                            {
                                // Remove the selected booking from the list
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

                    // Show a success message or perform any other actions you need
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

            return -1; // Return a sentinel value to indicate failure
        }
    }
}
