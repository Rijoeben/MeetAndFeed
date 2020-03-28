using System;
using System.Collections.Generic;
using System.Text;

namespace MAFDB
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
    }
}
