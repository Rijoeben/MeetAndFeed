using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetAndFeedAPI.Models
{
    public class PostAllergyModul
    {
        //[Key]
        public int UserId { get; set; }

        public User User { get; set; }
        public int AllergyId { get; set; }
        public Allergy Allergy { get; set; }
    }
}