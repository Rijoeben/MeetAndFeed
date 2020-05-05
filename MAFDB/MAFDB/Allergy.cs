using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class Allergy
    {
        [Key]
        public long AllergyId { get; set; }
        public string AllergyName { get; set; }
    }   
}
