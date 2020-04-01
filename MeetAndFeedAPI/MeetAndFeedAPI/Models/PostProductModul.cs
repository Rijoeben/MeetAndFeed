using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetAndFeedAPI.Models
{
    public class PostProductModul
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int ProductId { get; set; }
        public Product ProductName { get; set; }
    }
}