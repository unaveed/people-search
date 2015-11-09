using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleSearch.Models
{
    public interface IPeopleSearchContext : IDisposable
    {
        DbSet<Person> People { get;  }
        DbSet<Address> Addresses { get; }
        int SaveChanges();
        void MarkAsModified(Person person);
    }
}
