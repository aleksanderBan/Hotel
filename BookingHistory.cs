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
    public partial class BookingHistory : Form
    {
        public BookingHistory(List<string> bookingHistory)
        {
            InitializeComponent();

            // Display the booking history in the ListBox
            bookingHistory_list.Items.Clear();
            bookingHistory_list.Items.AddRange(bookingHistory.ToArray());
        }
    }
}
