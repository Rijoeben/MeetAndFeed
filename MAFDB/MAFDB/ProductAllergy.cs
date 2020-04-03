using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class ProductAllergy
    {
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public string AllergyId { get; set; }
        public Allergy Allergy { get; set; }
    }
}
