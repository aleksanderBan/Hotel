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
    public partial class AdminDateForm : Form
    {
        private Data data = new Data();
        private int selectedRoomId;

        public AdminDateForm(int roomId)
        {
            InitializeComponent();
            selectedRoomId = roomId;

            string dateFrom = data.DBGetDateFromForRoom(roomId);
            string dateUntil = data.DBGetDateUntilForRoom(roomId);

            // Display the "datefrom" and "dateuntil" values in the labels
            currentDateFrom_label.Text = "Date From: " + dateFrom;
            currentDateUntil_label.Text = "Date Until: " + dateUntil;
        }

        private void updateDate_btn_Click(object sender, EventArgs e)
        {
            // Read the new date from the TextBox
            string newDateFrom = newDateFrom_textbox.Text;
            string newDateUntil = newDateUntil_textbox.Text;

            // Update the database with the new date for the selected room
            if (data.DBUpdateRoomDate(selectedRoomId, newDateFrom, newDateUntil))
            {
                MessageBox.Show("Date updated successfully!");
                //Close(); // Close the form
                currentDateFrom_label.Text = "Current Date: " + newDateFrom;
                currentDateUntil_label.Text = "Current Date: " + newDateUntil;
            }
            else
            {
                MessageBox.Show("Failed to update date. Please try again.");
            }
        }
    }
}