using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch.Models;

namespace PeopleSearch.Tests
{
    [TestClass]
    public class TestPeopleSearchContext : IPeopleSearchContext
    {
        public TestPeopleSearchContext()
        {
            this.People = new TestPersonDbSet();
        }

        public DbSet<Address> Addresses { get; }

        public DbSet<Person> People { get; }

        public void Dispose()
        {
        }

        public void MarkAsModified(Person person)
        {
        }

        public int SaveChanges()
        {
            return 0;
        }
    }
}
