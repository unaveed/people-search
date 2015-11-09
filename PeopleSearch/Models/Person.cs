using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeopleSearch.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        public int AddressId { get; set; }
        [MaxLength(35), MinLength(2)]
        public string FirstName { get; set; }
        [MaxLength(35), MinLength(2)]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        [ForeignKey("AddressId")]
        public Address Addr { get; set; }
        public string Picture { get; set; }
        public string Interests { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public char Sex { get; set; }
        public int Income { get; set; }
        public string Employer { get; set; }
        public char MaritalStatus { get; set; }
    }
}