using System.Linq;
using System.Collections.Generic;
using DataAccess_Layer;
using Microsoft.EntityFrameworkCore;
using Business_Layer;
using DataAccess_Layer;
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

        [Test]
        public void TransactionCreateTest()
        {
            
        }
    }
}