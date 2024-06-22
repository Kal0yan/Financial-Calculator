using System;
using System.Collections.Generic;
using System.Linq;
using Business_Layer;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace DataAccess_Layer
{
    public class TransactionContext : IDB<Transaction, int>
    {
        private readonly AppDbContext _context;
        public TransactionContext()
        {
            _context = new AppDbContext();
        }

        public void Create(Transaction entity)
        {
            _context.Transactions.Add(entity);
            _context.SaveChanges();
        }


        public Transaction Read(int key, bool isReadOnly = true, bool useNavigationalProperties = false)
        {
            IQueryable<Transaction> query = _context.Transactions;

            if (isReadOnly)
            {
                query = query.AsNoTrackingWithIdentityResolution();
            }
            if (useNavigationalProperties)
            {
                query = query.Include(t => t.UserId);
            }
            return query.SingleOrDefault(t => t.Id == key);
        }

        public List<Transaction> ReadAll(bool isReadOnly = true, bool useNavigationalProperties = false)
        {
            IQueryable<Transaction> query = _context.Transactions;

            if (isReadOnly)
            {
                query = query.AsNoTrackingWithIdentityResolution();
            }
            if (useNavigationalProperties)
            {
                query = query.Include(t => t.UserId);
            }

            return query.ToList();
        }

        public void Update(Transaction entity, bool useNavigationalProperties = false)
        {
            Transaction transactionFromDb = Read(entity.Id, false, useNavigationalProperties);
            _context.Entry(transactionFromDb).CurrentValues.SetValues(entity);

            if (useNavigationalProperties)
            {
                User userFromDb = _context.Users.Find(entity.UserId);
                if (userFromDb is null)
                {
                    throw new ArgumentException("There is no user making this transaction. ");
                }
                entity.UserId = userFromDb.Id;
            }

            _context.SaveChanges();
        }

        public void Delete(int key)
        {
            Transaction transactionFromDb =  Read(key, false, false);
            if (transactionFromDb is null)
            {
                throw new ArgumentException("There is no transaction with this id.");
            }

            _context.Transactions.Remove(transactionFromDb);
            _context.SaveChanges();
        }
    }
}
