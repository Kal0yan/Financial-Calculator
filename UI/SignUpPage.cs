using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Layer;


namespace UI
{
    public partial class SignUpPage : Form
    {
        private string _response;
        private string _dbResponse;
        private SignUpPageService _signUpPageService;
        public SignUpPage()
        {
            _signUpPageService = new SignUpPageService();
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            _response = ValidateInformation();
            if (_response == " ")
            {
                Register();
                MessageBox.Show("User has been created successfully!", "User created", MessageBoxButtons.OK);
                Form1 loginPage = new Form1();
                this.Hide();
                loginPage.Visible = true;
            }

        }

        private void Register()
        {
            string message = _signUpPageService.Registration(UsernameTextBox.Text, PasswordTextBox.Text, float.Parse(BalanceTextBox.Text));
            _dbResponse = message;
        }

        private string ValidateInformation()
        {
            if (BalanceTextBox.Text == string.Empty)
            {
                BalanceTextBox.Text = "0";
            }

            if (PasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("You can`t Register without a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
            else if (UsernameTextBox.Text == string.Empty)
            {
                MessageBox.Show("You can`t register without an username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
            else
                return " ";


        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            this.Hide();
            loginPage.Show();
        }
    }
}
