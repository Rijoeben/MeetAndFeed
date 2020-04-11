using System;
using System.Collections.Generic;
using System.Text;

namespace MAFDB
{
    public class Review
    {
        public long ReviewId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
    }
}
