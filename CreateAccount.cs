using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel
{
    public partial class CreateAccount : Form
    {
        private MyHotelDb data = new MyHotelDb();

        private Login login; // A variable to store the reference of Form1

        public CreateAccount(Login loginReference)
        {
            InitializeComponent();
            login = loginReference; // Store the reference of Form1
        }

        private void createAccount_btn2_Click(object sender, EventArgs e)
        {
            string email = email_textbox2.Text;
            string username = usrnm_textbox.Text;

            Account account = new Account(username, email);

            int accountId = data.AccountDB(account);

            if (accountId != -1)
            {
                MessageBox.Show($"Account created with the name: {username}");
            }
            else
            {
                MessageBox.Show("Failed to create the account.");
            }

            login.Show(); // Call the method in Form1 to show it again
            this.Close(); // Close Form2
        }
    }
}
