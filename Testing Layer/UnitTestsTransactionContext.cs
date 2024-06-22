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
            Transaction newTransaction = new Transaction("Food", 25, true, 1);
            TransactionContext transactionContext = new TransactionContext();

            transactionContext.Create(newTransaction);

            Transaction transactionFromDb = await _context.Transactions.FirstOrDefaultAsync(
                t => t.Category == "Food" && t.Amount == 25);

            Assert.IsNotNull(transactionFromDb, "CreateAsync for transactions does not work! ");
        }

        [Test]
        public async Task ReadWithoutTransactionsTest()
        {
            TransactionContext transactionContext = new TransactionContext();

            Transaction emptyTransaction = transactionContext.Read(0);

            Assert.That(() => emptyTransaction == null, "There should be no transactions in the context! ");
        }

        [Test]
        public async Task ReadWithTransactionTest()
        {
            TransactionContext transactionContext = new TransactionContext();
            Transaction newTransaction = new Transaction("House", 100);
            transactionContext.Create(newTransaction);

            Transaction transactionFromDb = transactionContext.Read(1);

            Assert.That(() => transactionFromDb != null, "The ReadAsync() method should return correct transaction! ");
        }

        [Test]
        public async Task ReadAllTest()
        {
            TransactionContext transactionContext = new TransactionContext();
            Transaction newTransaction = new Transaction("House", 100);
            Transaction newTransaction2 = new Transaction("Food", 10);
            Transaction newTransaction3 = new Transaction("Entertainment", 50);

            int countBefore = (transactionContext.ReadAll()).Count;

            transactionContext.Create(newTransaction);
            transactionContext.Create(newTransaction2);
            transactionContext.Create(newTransaction3);

            int countAfter = transactionContext.ReadAll().Count;

            Assert.That(countAfter == countBefore + 3, "ReadAllAsync() for transactions does not work!");

        }

        [Test]
        public async Task UpdateTest()
        {
            TransactionContext transactionContext = new TransactionContext();
            Transaction newTransaction = new Transaction("House", 100);

            transactionContext.Create(newTransaction);

            Transaction transactionFromDb = transactionContext.Read(1, false, false);
            transactionFromDb.Amount += 50;

             transactionContext.Update(transactionFromDb);

            Assert.That(transactionFromDb.Amount == 150, "UpdateAsync() for transactions does not work!");
        }

        [Test]
        public async Task DeleteTestV1()
        {
            TransactionContext transactionContext = new TransactionContext();
            Transaction newTransaction = new Transaction("House", 100);

            transactionContext.Create(newTransaction);

            int countBefore =  transactionContext.ReadAll().Count;
             transactionContext.Delete(newTransaction.Id);
            int countAfter = ( transactionContext.ReadAll()).Count;

            Assert.That(countAfter + 1 == countBefore, "DeleteAsync() for transactions does not work!");
        }

        [Test]
        public async Task DeleteTestV2()
        {
            TransactionContext transactionContext = new TransactionContext();
            Transaction newTransaction = new Transaction("House", 100);

            transactionContext.Create(newTransaction);
            int idFromDb = newTransaction.Id;

            transactionContext.Delete(newTransaction.Id);

            Transaction emptyTransaction = transactionContext.Read(idFromDb);

            Assert.IsNull(emptyTransaction, "DeleteAsync() for transactions does not work!");
        }
    }
}