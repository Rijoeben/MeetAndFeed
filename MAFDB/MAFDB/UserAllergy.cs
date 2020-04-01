using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class UserAllergy
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int AllergyId { get; set; }
        public Allergy Allergy { get; set; }
    }
}
