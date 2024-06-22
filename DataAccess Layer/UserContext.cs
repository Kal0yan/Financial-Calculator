using Business_Layer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer
{
    public class UserContext : IDB<User, int>
    {
        private readonly AppDbContext _context;

        public UserContext()
        {
            _context = new();
        }

        public void Create(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public User Read(int key, bool isReadOnly = true, bool useNavigationalProperties = false)
        {
            IQueryable<User> query = _context.Users;

            if (isReadOnly)
            {
                query = query.AsNoTrackingWithIdentityResolution();
            }
            if (useNavigationalProperties)
            {
                query = query.Include(x => x.Transactions);
            }

            User user = query.SingleOrDefault(x => x.Id == key);

            if (user == null)
            {
                throw new ArgumentException("User with id:" + key + "doesn`t exist");
            }

            return user;
        }

        public List<User> ReadAll(bool isReadOnly = true, bool useNavigationalProperties = false)
        {
            IQueryable<User> query = _context.Users;

            if (isReadOnly)
            {
                query = query.AsNoTrackingWithIdentityResolution();
            }
            if (useNavigationalProperties)
            {
                query = query.Include(x => x.Transactions);
            }
            return query.ToList();
        }

        public void Update(User entity, bool useNavigationalProperties = false)
        {
            User userFromDb = Read(entity.Id, false, useNavigationalProperties);
            _context.Entry(userFromDb).CurrentValues.SetValues(entity);

            if (useNavigationalProperties)
            {
                List<Transaction> transactions = new List<Transaction>(userFromDb.Transactions);

                for (int i = 0; i < entity.Transactions.Count; i++)
                {
                    Transaction transactionFromDb =  _context.Transactions.Find(entity.Transactions[i].Id);

                    if (transactionFromDb is not null && !transactions.Contains(transactionFromDb))
                    {
                        transactions.Add(transactionFromDb);
                    }
                    else
                    {
                        transactions.Add(entity.Transactions[i]);
                    }
                }

                entity.Transactions = transactions;
                _context.SaveChanges();
            }

            _context.SaveChanges();
        }

        public void Delete(int key)
        {
            User userFromDb = Read(key, false);

            if (userFromDb is null)
            {
                throw new ArgumentException($"User with id {key} does not exist.");
            }
            _context.Users.Remove(userFromDb);
            _context.SaveChanges();
        }
    }
}
