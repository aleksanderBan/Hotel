using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Login : Form
    {
        private Data data = new Data();
        private string loggedInUsername; // Store the logged-in username

        public Login()
        {
            InitializeComponent();
        }

        //account functionality
        private void createAccount_btn_Click(object sender, EventArgs e)
        {
            CreateAccount createAccountForm = new CreateAccount(this);
            createAccountForm.Show();
            this.Hide();
        }

        public void ShowLoginForm()
        {
            this.Show();
        }

        //login functionality
        private void login_btn_Click(object sender, EventArgs e)
        {
            string input_email = email_textbox.Text;

            // Check if the input email exists in the database
            bool emailExists = data.EmailDB(input_email);

            if (emailExists)
            {
                // Get the username associated with the input email
                loggedInUsername = data.GetUsernameByEmail(input_email);

                // Proceed with further actions since the email exists in the database
                MessageBox.Show($"Logged in as {loggedInUsername}");
                Rooms RoomsForm = new Rooms(loggedInUsername); // Pass the username to the Rooms form
                RoomsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email does not exist in the database.");
            }
        }
    }
}
