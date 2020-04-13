using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MAFDB;

namespace API.Models
{
    public class AllergyModel
    {
        public long AllergyId { get; set; }
        public string AllergyName { get; set; }
        public Product ProductName { get; set; }
        public User User { get; set; }
    }
}
