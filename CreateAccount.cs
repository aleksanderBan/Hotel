using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class CreateAccount : Form
    {
        private Data data = new Data();

        private Login login;

        public CreateAccount(Login loginReference)
        {
            InitializeComponent();
            login = loginReference;
        }

        private void createAccount_btn2_Click(object sender, EventArgs e)
        {
            string email = email_textbox2.Text;
            string username = usrnm_textbox.Text;

            Account account = new Account(username, email);

            int accountId = data.DBInsertAccount(account);

            if (accountId != -1)
            {
                MessageBox.Show($"Account created with the name: {username}");
            }
            else
            {
                MessageBox.Show("Failed to create the account.");
            }

            login.Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
        }
    }
}