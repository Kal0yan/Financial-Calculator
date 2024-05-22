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
    internal class UserContext : IDB<User, int>
    {
        private readonly AppDbContext _context;

        public UserContext(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(User entity)
        {
            _context.Users.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<User> ReadAsync(int key, bool isReadOnly = true, bool useNavigationalProperties = false)
        {
            IQueryable<User> query = _context.Users;

            if (isReadOnly)
            {
                query = query.AsNoTrackingWithIdentityResolution();
            }
            if(useNavigationalProperties)
            {
                query = query.Include(x => x.Transactions);
            }
            return await query.SingleOrDefaultAsync(x => x.Id == key);
        }

        public async Task<List<User>> ReadAllAsync(bool isReadOnly = true, bool useNavigationalProperties = false)
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
            return await query.ToListAsync();
        }

        public async Task UpdateAsync(User entity, bool useNavigationalProperties = false)
        {
            User userFromDb = await ReadAsync(entity.Id, false, useNavigationalProperties);
            _context.Entry(userFromDb).CurrentValues.SetValues(entity);

            if (useNavigationalProperties)
            {
                List<Transaction> transactions = new List<Transaction>(userFromDb.Transactions);

                for(int i = 0; i < entity.Transactions.Count; i++)
                {
                    Transaction transactionFromDb = await _context.Transactions.FindAsync(entity.Transactions[i].Id);

                    if(transactionFromDb is not null && !transactions.Contains(transactionFromDb))
                    {
                        transactions.Add(transactionFromDb);
                    }
                    else
                    {
                        transactions.Add(entity.Transactions[i]);
                    }
                }

                entity.Transactions = transactions;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int key)
        {
            User userFromDb = await ReadAsync(key, false);
            
            if(userFromDb is null)
            {
                throw new ArgumentException($"Airport with id {key} does not exist.");
            }
            _context.Users.Remove(userFromDb);
            await _context.SaveChangesAsync();
        }
    }
}
