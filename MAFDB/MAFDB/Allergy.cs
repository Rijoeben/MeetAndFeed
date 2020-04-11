using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class Allergy
    {
        [Key]
        public string AllergyId { get; set; }

        public string AllergyName { get; set; }
        public Product ProductName { get; set; }
        public User User { get; set; }
    }   
}
