using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetAndFeedAPI.Models
{
    public class PostAllergyModul
    {
        //[Key]
       

        public User User { get; set; }
        
        public Allergy Allergy { get; set; }
    }
}