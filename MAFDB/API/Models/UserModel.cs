using MAFDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API;

namespace API.Models
{
    public class UserModel
    {
        [Key]
        public long UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public bool Preference { get; set; }
        public char Gender { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<Allergy> Allergies { get; set; }
    }
}
