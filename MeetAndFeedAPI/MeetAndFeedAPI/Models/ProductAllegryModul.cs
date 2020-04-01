using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetAndFeedAPI.Models
{
    public class ProductAllegryModul
    {
        //[Key]
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public int AllergyId { get; set; }
        public Allergy Allergy { get; set; }
    }
}