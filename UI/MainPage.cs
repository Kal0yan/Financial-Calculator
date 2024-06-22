using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using DataAccess_Layer;
using Service_Layer;

namespace UI
{
    public partial class MainPage : Form
    {
        private UserContext _context;
        private User _user;
        private TransactionContext _transactionContext;
        private List<Transaction>? _transactions;
        private MainPageService _mainPageService;
        public MainPage(int userId)
        {
            _mainPageService = new MainPageService();
            _context = new UserContext();
            _transactionContext = new TransactionContext();
            _user = _context.Read(userId);
            _transactions = new List<Transaction>();
            InitializeComponent();
            InitializeListView();
            LoadUserTransactions();
            UsernameLabel.Text = _user.Username;
            BalanceLabel.Text = _user.Balance.ToString();
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
        }

        private void LoadUserTransactions()
        {
            _transactions = _transactionContext.ReadAll();
            if (_transactions != null)
            {
                foreach (var item in _transactions)
                {
                    if (item.UserId == _user.Id)
                    {
                        ListViewItem transaction = new ListViewItem(item.Id.ToString());
                        transaction.SubItems.Add(item.Category);
                        transaction.SubItems.Add(item.Amount.ToString());
                        if (item.IncomeOrOutcome == true)
                        {
                            transaction.SubItems.Add("Income");
                        }
                        else
                            transaction.SubItems.Add("Outcome");
                        transaction.SubItems.Add(item.Description);
                        listView1.Items.Add(transaction);
                    }
                }
            }
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            AddTransactionPage addTransactionPage = new AddTransactionPage(_user);
            this.Hide();
            addTransactionPage.Show();
        }

        private void DeleteTransaction_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                _transactionContext.Delete(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}
