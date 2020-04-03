using System;
using System.Collections.Generic;
using System.Text;

namespace MAFDB
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public bool Preference { get; set; }
<<<<<<< HEAD
        public float BigDickSize { get; set; }

=======
        public float DickSize { get; set; }
        public string Password { get; set; }
>>>>>>> DAL
    }
}
