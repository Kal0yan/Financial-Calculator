using Business_Layer;
using DataAccess_Layer;
using Service_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace UI
{
    public partial class AddTransactionPage : Form
    {
        private UserContext _context;
        private User _user;
        private string _response;
        private string _dbResponse;
        private AddTransactionPageService _service;
        public AddTransactionPage(User user)
        {
            _service = new AddTransactionPageService();
            _context = new UserContext();
            _user = user;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddTransactionPage_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _response = Validation();

            if (_response == " ")
            {
                AddTransaction();
                MessageBox.Show("Transaction Added Successfully!", "Transaction Added", MessageBoxButtons.OK);
                this.Hide();
            }
        }

        private void AddTransaction()
        {
            _response = Validation();

            bool incomeoutcome = true;
            if (IncomeOutcome.Text == "Outcome")
            {
                incomeoutcome = false;
            }

            if (_response == " ")
            {
                if (DescriptionTextBox.Text == string.Empty)
                {
                    _dbResponse = _service.AddTransaction(_user, float.Parse(AmountTextBox.Text), CategoryTextBox.Text, incomeoutcome);
                    Return();
                }
                else
                {
                    _dbResponse = _service.AddTransaction(_user, float.Parse(AmountTextBox.Text), CategoryTextBox.Text, incomeoutcome,
                    DescriptionTextBox.Text);
                    Return();
                }
            }
        }

        private string Validation()
        {
            if (AmountTextBox.Text == string.Empty)
            {
                MessageBox.Show("Amount is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
            if (CategoryTextBox.Text == string.Empty)
            {
                MessageBox.Show("Category is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
            if (IncomeOutcome.Text == string.Empty)
            {
                MessageBox.Show("Select income or outcome", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
            else
                return " ";
        }

        private void Return()
        {
            MainPage mainPage = new MainPage(_user.Id);
            this.Hide();
            mainPage.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Return();
        }
    }
}
