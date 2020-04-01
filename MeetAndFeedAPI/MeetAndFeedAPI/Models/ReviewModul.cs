using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetAndFeedAPI.Models
{
    public class ReviewModul
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
    }
}