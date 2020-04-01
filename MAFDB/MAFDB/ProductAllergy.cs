using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class ProductAllergy
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AllergyId { get; set; }
        public Allergy Allergy { get; set; }
    }
}
