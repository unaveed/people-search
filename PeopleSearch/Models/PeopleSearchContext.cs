using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeopleSearch.Models
{
    public class PeopleSearchContext : DbContext, IPeopleSearchContext
    {
    
        public PeopleSearchContext() : base("name=PeopleSearchContext")
        {
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Address> Addresses { get; set; }

        int IPeopleSearchContext.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IPeopleSearchContext.MarkAsModified(Person person)
        {
            Entry(person).State = EntityState.Modified;
        }
    }
}
