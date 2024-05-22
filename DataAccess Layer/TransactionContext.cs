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
        public TransactionContext(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Transaction entity)
        {
            await _context.Transactions.AddAsync(entity);
            _context.SaveChanges();
        }


        public async Task<Transaction> ReadAsync(int key, bool isReadOnly = true, bool useNavigationalProperties = false)
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
            return await query.SingleOrDefaultAsync(t => t.Id == key);
        }

        public async Task<List<Transaction>> ReadAllAsync(bool isReadOnly = true, bool useNavigationalProperties = false)
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

            return await query.ToListAsync();
        }

        public async Task UpdateAsync(Transaction entity, bool useNavigationalProperties = false)
        {
            Transaction transactionFromDb = await ReadAsync(entity.Id, false, useNavigationalProperties);
            _context.Entry(transactionFromDb).CurrentValues.SetValues(entity);

            if (useNavigationalProperties)
            {
                User userFromDb = await _context.Users.FindAsync(entity.UserId);
                if (userFromDb is null)
                {
                    throw new ArgumentException("There is no user making this transaction. ");
                }
                entity.UserId = userFromDb.Id;
            }

            _context.SaveChanges();
        }

        public async Task DeleteAsync(int key)
        {
            Transaction transactionFromDb = await ReadAsync(key, false, false);
            if (transactionFromDb != null)
            {
                _context.Transactions.Remove(transactionFromDb);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("There is no transaction with this id.");
            }
        }
    }
}
