using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch.Models;
using System.Linq;

namespace PeopleSearch.Tests
{
    [TestClass]
    public class TestPersonDbSet : TestDbSet<Person>
    {
        public override Person Find(params object[] keyValues)
        {
            return this.SingleOrDefault(person => person.PersonId == (int)keyValues.Single());
        }
    }
}
