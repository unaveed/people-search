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
                    FirstName = "Teresa",
                    LastName = "Jenkins",
                    DOB = new DateTime(1962, 6, 26),
                    Picture = "0.jpg",
                    Interests = "orci nullam molestie nibh in lectus pellentesque at nulla suspendisse potenti cras in",
                    Phone = "1-(225)931-2635",
                    Email = "tjenkins0@fema.gov",
                    Sex = 'F',
                    Income = 40000,
                    Employer = "Tavu",
                    MaritalStatus = 'm',
                    Addr = new Address("7 Dottie Hill", "Baton Rouge", "Louisiana", 70805)
                },

                new Person
                {
                    FirstName = "Steven",
                    LastName = "Nguyen",
                    DOB = new DateTime(1947, 4, 18),
                    Picture = "1.jpg",
                    Interests = "ipsum dolor sit amet consectetuer adipiscing elit proin risus praesent",
                    Phone = "1-(215)592-0950",
                    Email = "snguyen1@upenn.edu",
                    Sex = 'M',
                    Income = 39999,
                    Employer = "Browsedrive",
                    MaritalStatus = 's',
                    Addr = new Address("1496 Arkansas Road", "Philadelphia", "Pennsylvania", 19141)
                },

                new Person
                {
                    FirstName = "Diana",
                    LastName = "Rodriguez",
                    DOB = new DateTime(1982, 12, 10),
                    Picture = "2.jpg",
                    Interests = "phasellus id sapien in sapien iaculis congue vivamus metus arcu adipiscing",
                    Phone = "1-(954)206-1409",
                    Email = "drodriguez2@weibo.com",
                    Sex = 'F',
                    Income = 39997,
                    Employer = "Oloo",
                    MaritalStatus = 's',
                    Addr = new Address("0 Weeping Birch Center", "Fort Lauderdale", "Florida", 33330)
                },

                new Person
                {
                    FirstName = "Jane",
                    LastName = "Peterson",
                    DOB = new DateTime(1993, 1, 29),
                    Picture = "3.jpg",
                    Interests = "ut tellus nulla ut erat id mauris vulputate elementum nullam varius nulla facilisi cras",
                    Phone = "1-(720)661-3513",
                    Email = "jpeterson3@reuters.com",
                    Sex = 'F',
                    Income = 39999,
                    Employer = "Realbridge",
                    MaritalStatus = 'd',
                    Addr = new Address("90 Fulton Circle", "Littleton", "Colorado", 80126)
                },

                new Person
                {
                    FirstName = "Dorothy",
                    LastName = "Harper",
                    DOB = new DateTime(1939, 2, 16),
                    Picture = "4.jpg",
                    Interests = "vel ipsum praesent blandit lacinia erat vestibulum sed magna at",
                    Phone = "1-(508)329-4777",
                    Email = "dharper4@imgur.com",
                    Sex = 'F',
                    Income = 40004,
                    Employer = "Edgeblab",
                    MaritalStatus = 's',
                    Addr = new Address("08482 Amoth Street", "Worcester", "Massachusetts", 01654)
                },

                new Person
                {
                    FirstName = "Annie",
                    LastName = "Hanson",
                    DOB = new DateTime(1983, 5, 6),
                    Picture = "5.jpg",
                    Interests = "dis parturient montes nascetur",
                    Phone = "1-(203)616-5790",
                    Email = "ahanson5@dropbox.com",
                    Sex = 'F',
                    Income = 39997,
                    Employer = "Shuffledrive",
                    MaritalStatus = 'm',
                    Addr = new Address("0458 Waubesa Circle", "Waterbury", "Connecticut", 06721)
                },

                new Person
                {
                    FirstName = "Paula",
                    LastName = "Black",
                    DOB = new DateTime(1938, 12, 8),
                    Picture = "6.jpg",
                    Interests = "dui luctus rutrum nulla",
                    Phone = "1-(901)795-2678",
                    Email = "pblack6@nih.gov",
                    Sex = 'F',
                    Income = 39999,
                    Employer = "Eire",
                    MaritalStatus = 's',
                    Addr = new Address("0 Sugar Drive", "Memphis", "Tennessee", 38188)
                },

                new Person
                {
                    FirstName = "Anne",
                    LastName = "Wright",
                    DOB = new DateTime(1997, 11, 5),
                    Picture = "7.jpg",
                    Interests = "suscipit a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique fusce",
                    Phone = "1-(816)145-4568",
                    Email = "awright7@google.com.hk",
                    Sex = 'F',
                    Income = 39999,
                    Employer = "Skippad",
                    MaritalStatus = 'm',
                    Addr = new Address("6395 Comanche Way", "Kansas City", "Missouri", 64199)
                },

                new Person
                {
                    FirstName = "Brandon",
                    LastName = "Anderson",
                    DOB = new DateTime(1986, 10, 5),
                    Picture = "8.jpg",
                    Interests = "vestibulum ante ipsum",
                    Phone = "1-(402)989-3955",
                    Email = "banderson8@baidu.com",
                    Sex = 'M',
                    Income = 40001,
                    Employer = "Lazzy",
                    MaritalStatus = 's',
                    Addr = new Address("8546 Service Park", "Omaha", "Nebraska", 68197)
                },

                new Person
                {
                    FirstName = "Ronald",
                    LastName = "Pierce",
                    DOB = new DateTime(1991, 5, 23),
                    Picture = "9.jpg",
                    Interests = "ac tellus semper interdum mauris ullamcorper purus sit amet nulla quisque arcu libero",
                    Phone = "1-(810)741-9682",
                    Email = "rpierce9@sphinn.com",
                    Sex = 'M',
                    Income = 39996,
                    Employer = "Twiyo",
                    MaritalStatus = 'd',
                    Addr = new Address("441 Mitchell Circle", "Flint", "Michigan", 48505)
                },

                new Person
                {
                    FirstName = "Timothy",
                    LastName = "Peters",
                    DOB = new DateTime(1997, 10, 21),
                    Picture = "10.jpg",
                    Interests = "parturient montes nascetur ridiculus mus etiam vel augue",
                    Phone = "1-(203)970-9381",
                    Email = "tpetersa@ehow.com",
                    Sex = 'M',
                    Income = 40002,
                    Employer = "Einti",
                    MaritalStatus = 'd',
                    Addr = new Address("12 Dahle Avenue", "Fairfield", "Connecticut", 06825)
                });
        }
    }
}
