using DataAccess_Layer;
using Business_Layer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Layer
{
    public class UnitTestsUserContext
    {
        static AppDbContext _dbContext;
        static UserContext _userContext;

        [OneTimeSetUp]
        public void Setup()
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("TestDatabase");
            _dbContext = new AppDbContext(builder.Options);
            _userContext = new UserContext(_dbContext);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
                _dbContext = null;
            }
            if (_userContext != null)
            {
                _userContext = null;
            }
        }

        // Unit tests

        [Test]
        public async Task CreateTestV1()
        {
            User newUser = new User("Georgi", "go60123");


            await _userContext.CreateAsync(newUser);

            User userFromDb = await _dbContext.Users
                .FirstOrDefaultAsync(u => u.Username == "Georgi" && u.Password == "go60123");

            Assert.That(userFromDb != null, "CreateAsync() in UserContext does not create user!");
        }

        [Test]
        public async Task CreateTestV2()
        {
            User newUser = new User("Ivan", "ivan123");
            Transaction tr1 = new Transaction("Car", -300);
            Transaction tr2 = new Transaction("Home", -50);
            Transaction tr3 = new Transaction("Salary", 2000);

            newUser.Transactions.Add(tr1);
            newUser.Transactions.Add(tr2);
            newUser.Transactions.Add(tr3);

            await _userContext.CreateAsync(newUser);

            User userFromDb = await _dbContext.Users.Include(u => u.Transactions)
                .FirstOrDefaultAsync(u => u.Username == "Ivan" && u.Password == "ivan123");

            Assert.That(userFromDb.Transactions.Count == 3, "CreateAsync() in UserContext does not include transactions!");
        }

        [Test]
        public async Task ReadTestV1()
        {
            User userFromDb = await _userContext.ReadAsync(0);
            Assert.That(userFromDb is null, "ReadAsync() does not work without users!");
        }
        [Test]
        public async Task ReadTestV2()
        {
            User newUser = new User("Petar", "petar123");

            await _userContext.CreateAsync(newUser);
            User userFromDb = await _userContext.ReadAsync(newUser.Id);

            Assert.That(userFromDb is not null, "ReadAsync() does not work with users!");
        }
        [Test]
        public async Task ReadTestV3()
        {
            User newUser = new User("Dimitar", "mitko123");

            Transaction tr1 = new Transaction("Holiday", -300);
            Transaction tr2 = new Transaction("Shopping", -50);
            Transaction tr3 = new Transaction("Extra", 2000);

            newUser.Transactions.Add(tr1);
            newUser.Transactions.Add(tr2);
            newUser.Transactions.Add(tr3);
            await _userContext.CreateAsync(newUser);

            User userFromDb = await _userContext.ReadAsync(newUser.Id, true, true);

            Assert.That(userFromDb.Transactions.Count == 3,
                "ReadAsync() for users does not work properly with navigational properties! ");
        }

        [Test]
        public async Task ReadAllTestV1()
        {
            User u1 = new User("Ivaylo", "ivcho123");
            User u2 = new User("Kaloyan", "kaloyan123");
            User u3 = new User("Plamen", "plamen123");

            int countBefore = (await _userContext.ReadAllAsync()).Count;
            await _userContext.CreateAsync(u1);
            await _userContext.CreateAsync(u2);
            await _userContext.CreateAsync(u3);
            int countAfter = (await _userContext.ReadAllAsync()).Count;

            Assert.That(countBefore + 3 == countAfter, "ReadAllAsync() for users does not work!");
        }
        [Test]
        public async Task ReadAllTestV2()
        {
            User u1 = new User("Simona", "simona123");
            User u2 = new User("Violeta", "violeta123");

            Transaction tr1 = new Transaction("Holiday", -500);
            Transaction tr2 = new Transaction("Shopping", -120);
            Transaction tr3 = new Transaction("Sales", 200);

            u1.Transactions.Add(tr1);
            u2.Transactions.Add(tr2);
            u2.Transactions.Add(tr3);
            await _userContext.CreateAsync(u1);
            await _userContext.CreateAsync(u2);

            List<User> users = await _userContext.ReadAllAsync(true, true);
            Assert.That(users[1].Transactions.Count == 2,
                "ReadAllAsync() for users does not work properly with navigational properties!");
        }

        [Test]
        public async Task UpdateTestV1()
        {
            User u1 = new User("Svetlin", "svetlyo123");

            await _userContext.CreateAsync(u1);
            u1.Password = "svetlin123";
            await _userContext.UpdateAsync(u1, false);

            User userFromDb = await _userContext.ReadAsync(u1.Id);

            Assert.That(userFromDb.Password == "svetlin123", "UpdateAsync() for users does not work!");
        }

        [Test]
        public async Task UpdateTestV2()
        {
            User u1 = new User("Svetla", "svetla123");
            Transaction tr1 = new Transaction("Clothes", -500);
            Transaction tr2 = new Transaction("Entertainment", -120);
            u1.Transactions.Add(tr1);
            u1.Transactions.Add(tr2);

            await _userContext.CreateAsync(u1);
            u1.Transactions[0].Category = "Shoes";
            await _userContext.UpdateAsync(u1, true);

            User userFromDb = await _userContext.ReadAsync(u1.Id);

            Assert.That(userFromDb.Transactions[0].Category == "Shoes",
                "UpdateAsync() for users does not work properly with navigational properties!");
        }

        [Test]
        public async Task DeleteTest()
        {
            User u1 = new User("Ginka", "ginka123");

            await _userContext.CreateAsync(u1);
            int countBefore = (await _userContext.ReadAllAsync()).Count;
            await _userContext.DeleteAsync(u1.Id);
            int countAfter = (await _userContext.ReadAllAsync()).Count;

            Assert.That(countBefore - 1 == countAfter, "DeleteAsync() for users does not work!");
        }
    }
}
