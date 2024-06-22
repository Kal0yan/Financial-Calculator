using Service_Layer;
using System.Net;

namespace UI
{
    public partial class Form1 : Form
    {
        private string _response;
        private string _dbResponse;
        private LoginPageService _loginPageService;
        public Form1()
        {
            _loginPageService = new LoginPageService();
            InitializeComponent();
            ResponsePanel.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _dbResponse = _loginPageService.Login(UsernameTextBox.Text, PasswordTextBox.Text);

            if (_dbResponse == "Wrong password")
            {
                ShowResponse(_dbResponse);
            }
            else if(_dbResponse == "The username you have entered is not used by any profile")
            {
                ShowResponse(_dbResponse);
            }
            else
            {
                MainPage mainPage = new MainPage(int.Parse(_dbResponse));
                this.Hide();
                mainPage.Show();

            }
        }

        private void ShowResponse(string response)
        {
            ResponsePanel.Visible = true;
            ResponseLabel.Visible = true;
            ResponseLabel.Text = response;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            this.Hide(); 
            signUpPage.Show();
        }
    }
}
