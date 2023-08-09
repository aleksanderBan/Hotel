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

            string currentDate = data.DBGetCurrentDateForRoom(roomId);
            // Display the current date in the label
            currentDate_label.Text = "Current Date: " + currentDate;
        }

        private void updateDate_btn_Click(object sender, EventArgs e)
        {
            // Read the new date from the TextBox
            string newDate = newDate_textbox.Text;

            // Update the database with the new date for the selected room
            if (data.DBUpdateRoomDate(selectedRoomId, newDate))
            {
                MessageBox.Show("Date updated successfully!");
                //Close(); // Close the form
                currentDate_label.Text = "Current Date: " + newDate;
            }
            else
            {
                MessageBox.Show("Failed to update date. Please try again.");
            }
        }
    }
}