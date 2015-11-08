namespace PeopleSearch.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleSearchContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PeopleSearchContext context)
        {
            context.People.AddOrUpdate(p => p.PersonId,
                new Person
                {
                    FirstName = "Julie",
                    LastName = "Mccoy",
                    DOB = new DateTime(1965, 8, 3),
                    Addr = new Address("185 Autumn Leaf Alley", "Washington", "District of Columbia", 20319),
                    Picture = "/porttitor/id/consequat/in/consequat/ut/nulla.html,basketball",
                    Interests = new List<String> { "basketball", "soccer" }
                },
                new Person
                {
                    FirstName = "Joyce",
                    LastName = "Brooks",
                    DOB = new DateTime(1977, 6, 24),
                    Addr = new Address("668 Hauk Center", "Washington", "District of Columbia", 20210),
                    Picture = "/porttitor/id/consequat/in/consequat/ut/nulla.html",
                    Interests = new List<String> { "basketball" }
                },
                new Person
                {
                    FirstName = "James",
                    LastName = "Stewart",
                    DOB = new DateTime(1997, 4, 9),
                    Addr = new Address("93463 Kings Circle", "Albany", "New York", 12205),
                    Picture = "/metus/aenean/fermentum/donec/ut/mauris.aspx",
                    Interests = new List<String> { "computers" }
                },
                new Person
                {
                    FirstName = "Brian",
                    LastName = "Lawson",
                    DOB = new DateTime(1967, 9, 8),
                    Addr = new Address("76427 Almo Junction", "Miami Beach", "Florida", 33141),
                    Picture = "/interdum.png",
                    Interests = new List<String> { "hockey" }
                },
                new Person
                {
                    FirstName = "Wayne",
                    LastName = "Frazier",
                    DOB = new DateTime(1947, 4, 27),
                    Addr = new Address("29662 Eggendart Point", "San Jose", "California", 95128),
                    Picture = "/ipsum/aliquam/non/mauris/morbi/non/lectus.jpg",
                    Interests = new List<String> { "computers" }
                },
                new Person
                {
                    FirstName = "Stephen",
                    LastName = "Sanchez",
                    DOB = new DateTime(1949, 5, 17),
                    Addr = new Address("885 Haas Junction", "Huntsville", "Alabama", 35810),
                    Picture = "/adipiscing/elit/proin/risus.jpg",
                    Interests = new List<String> { "long boarding" }
                },
                new Person
                {
                    FirstName = "Rose",
                    LastName = "Bryant",
                    DOB = new DateTime(1974, 1, 16),
                    Addr = new Address("1 Service Avenue", "Austin", "Texas", 78703),
                    Picture = "/sit/amet/consectetuer/adipiscing/elit/proin.json",
                    Interests = new List<String> { "traveling" }
                });
        }
    }
}
