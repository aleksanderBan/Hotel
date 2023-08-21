using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Login : Form
    {
        private Data data = new Data();
        private string loggedInUsername;
        string adminPswd = "admin";

        public Login()
        {
            InitializeComponent();
        }

        //account functionality
        private void CreateAccount_btn_Click(object sender, EventArgs e)
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
        private void Login_btn_Click(object sender, EventArgs e)
        {
            string input_email = email_textbox.Text;

            bool emailExists = data.DBCheckEmail(input_email);

            if (emailExists)
            {
                loggedInUsername = data.DBGetAccountUsername(input_email);

                MessageBox.Show($"Logged in as {loggedInUsername}");
                Rooms RoomsForm = new Rooms(loggedInUsername);
                RoomsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email does not exist in the database.");
            }
        }

        //Admin login
        private void AdminLogin_btn_Click(object sender, EventArgs e)
        {
            if (adminPswd_textbox.Text == adminPswd)
            {
                MessageBox.Show("Logged in as system admin.");
                AdminPanel AdminForm = new AdminPanel();
                AdminForm.Show();
                this.Hide();
            }
            else if (adminPswd_textbox.Text != adminPswd)
            {
                MessageBox.Show("Incorrect password.");
            }
        }
    }
}