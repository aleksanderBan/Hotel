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
    public partial class Login : Form
    {
        private Data data = new Data();
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
                // Proceed with further actions since the email exists in the database
                MessageBox.Show($"Logged in as{input_email}");
                Rooms RoomsForm = new Rooms();
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
