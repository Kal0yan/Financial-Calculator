using System;
using System.Linq;
using System.Collections.Generic;
using DataAccess_Layer;
using Microsoft.EntityFrameworkCore;
using Business_Layer;
using NUnit.Framework;


namespace Testing_Layer
{
    public class Tests
    {

        static AppDbContext _context;

        [SetUp]
        public void Setup()
        {

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            _context = new AppDbContext(builder.Options);

        }

        [TearDown]
        public void TearDown()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }

        // Unit tests

        [Test]
        public async Task TransactionCreateTest()
        {
            Transaction newTransaction = new Transaction("Food", 25);
            TransactionContext transactionContext = new TransactionContext(_context);

            await transactionContext.CreateAsync(newTransaction);

            Transaction transactionFromDb = await _context.Transactions.FirstOrDefaultAsync(
                t => t.Category == "Food" && t.Amount == 25);

            Assert.IsNotNull(transactionFromDb, "CreateAsync for transactions does not work! ");
        }

        [Test]
        public async Task ReadWithoutTransactionsTest()
        {
            TransactionContext transactionContext = new TransactionContext(_context);

            Transaction emptyTransaction = await transactionContext.ReadAsync(0);

            Assert.That(() => emptyTransaction == null, "There should be no transactions in the context! ");
        }

        [Test]
        public async Task ReadWithTransactionTest()
        {
            TransactionContext transactionContext = new TransactionContext(_context);
            Transaction newTransaction = new Transaction("House", 100);
            await transactionContext.CreateAsync(newTransaction);

            Transaction transactionFromDb = await transactionContext.ReadAsync(1);

            Assert.That(() => transactionFromDb != null, "The ReadAsync() method should return correct transaction! ");
        }

        [Test]
        public async Task ReadAllTest()
        {
            TransactionContext transactionContext = new TransactionContext(_context);
            Transaction newTransaction = new Transaction("House", 100);
            Transaction newTransaction2 = new Transaction("Food", 10);
            Transaction newTransaction3 = new Transaction("Entertainment", 50);

            int countBefore = (await transactionContext.ReadAllAsync()).Count;

            await transactionContext.CreateAsync(newTransaction);
            await transactionContext.CreateAsync(newTransaction2);
            await transactionContext.CreateAsync(newTransaction3);

            int countAfter = (await transactionContext.ReadAllAsync()).Count;

            Assert.That(countAfter == countBefore + 3, "ReadAllAsync() for transactions does not work!");

        }

        [Test]
        public async Task UpdateTest()
        {
            TransactionContext transactionContext = new TransactionContext(_context);
            Transaction newTransaction = new Transaction("House", 100);

            await transactionContext.CreateAsync(newTransaction);

            Transaction transactionFromDb = await transactionContext.ReadAsync(1, false, false);
            transactionFromDb.Amount += 50;

            await transactionContext.UpdateAsync(transactionFromDb);

            Assert.That(transactionFromDb.Amount == 150, "UpdateAsync() for transactions does not work!");
        }

        [Test]
        public async Task DeleteTestV1()
        {
            TransactionContext transactionContext = new TransactionContext(_context);
            Transaction newTransaction = new Transaction("House", 100);

            await transactionContext.CreateAsync(newTransaction);

            int countBefore = (await transactionContext.ReadAllAsync()).Count;
            await transactionContext.DeleteAsync(newTransaction.Id);
            int countAfter = (await transactionContext.ReadAllAsync()).Count;

            Assert.That(countAfter + 1 == countBefore, "DeleteAsync() for transactions does not work!");
        }

        [Test]
        public async Task DeleteTestV2()
        {
            TransactionContext transactionContext = new TransactionContext(_context);
            Transaction newTransaction = new Transaction("House", 100);

            await transactionContext.CreateAsync(newTransaction);
            int idFromDb = newTransaction.Id;

            await transactionContext.DeleteAsync(newTransaction.Id);

            Transaction emptyTransaction = await transactionContext.ReadAsync(idFromDb);

            Assert.IsNull(emptyTransaction, "DeleteAsync() for transactions does not work!");
        }
    }
}