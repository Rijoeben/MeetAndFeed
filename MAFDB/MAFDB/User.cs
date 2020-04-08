using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class User
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

    }
}
