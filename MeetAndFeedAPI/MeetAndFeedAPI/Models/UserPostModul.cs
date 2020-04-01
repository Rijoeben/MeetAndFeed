using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetAndFeedAPI.Models
{
    public class UserPostModul
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}