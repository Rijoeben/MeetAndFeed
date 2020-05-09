using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MAFDB
{
    public class Allergy
    {
        [Key]
        public long AllergyId { get; set; }
        public string AllergyName { get; set; }
        
        //public long PostId { get; set; } //moest erbij anders werkte het niet kregen error message a.postid not present in database
    }   
}
