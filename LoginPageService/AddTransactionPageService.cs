using DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;

namespace Service_Layer
{
    public class AddTransactionPageService
    {
        private TransactionContext _transactionContext;
        private List<Transaction> _transactions;
        private UserContext _userContext;

        public AddTransactionPageService()
        {
            _transactionContext = new TransactionContext();
            _userContext = new UserContext();
            _transactions = _transactionContext.ReadAll(true, false);
        }

        public string AddTransaction(User user, float amount, string category, bool incomeOrOutcome, string description)
        {
            if(category.Length > 3 || category.Length < 101)
            {
                Transaction transactionToCreate = new Transaction(category, amount, description, incomeOrOutcome, user.Id);
                _transactionContext.Create(transactionToCreate);
                if(incomeOrOutcome == true)
                {
                    user.Balance += amount;
                }
                else if(incomeOrOutcome == false)
                {
                    user.Balance -= amount;
                }

                _userContext.Update(user);

                return "Transaction Added Successfully!";
            }
            else
            {
                return "Category has to be between 3 and 100 characters";
            }
        }

        public string AddTransaction(User user, float amount, string category, bool incomeOrOutcome)
        {
            if (category.Length > 3 || category.Length < 101)
            {
                Transaction transactionToCreate = new Transaction(category, amount, incomeOrOutcome, user.Id);
                _transactionContext.Create(transactionToCreate);
                if (incomeOrOutcome == true)
                {
                    user.Balance += amount;
                }
                else if (incomeOrOutcome == false)
                {
                    user.Balance -= amount;
                }

                _userContext.Update(user);

                return "Transaction Added Successfully!";
            }
            else
            {
                return "Category has to be between 3 and 100 characters";
            }
        }
    }
}
