using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch.Controllers;
using PeopleSearch.Models;
using System.Web.Mvc;
using System.Net;

namespace PeopleSearch.Tests
{
    /// <summary>
    /// Summary description for TestPeopleController
    /// </summary>
    [TestClass]
    public class TestPeopleController
    {
        public TestPeopleController()
        {
        }

        private TestContext testContextInstance;
        private PeopleController controller = new PeopleController(new TestPeopleSearchContext());

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        #endregion

        [TestMethod]
        public void TestCreatePerson()
        {
            var person = GetTestPerson();
            var result = controller.Create(person) as ActionResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        [TestMethod]
        public void TestGetDetails()
        {
            var person = GetTestPerson();
            var result = controller.Details(1) as ActionResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        [TestMethod]
        public void TestDelete()
        {
            var person = GetTestPerson();
            var result = controller.Delete(null) as HttpStatusCodeResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, 400);
        }

        public Person GetTestPerson()
        {
            Person person = new Person();
            person.PersonId = 1;
            person.FirstName = "James";
            person.LastName = "Folland";
            person.AddressId = 1;
            person.Addr = new Address("342 Evergreen Terrace", "Springfield", "Utah", 84441);
            person.DOB = new DateTime(1966, 12, 13);
            person.Phone = "8017731234";
            person.Email = "yah@yahoo.com";
            return person;
        }
    }
}
