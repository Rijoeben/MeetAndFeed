using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAFDB;
namespace API.Models
{
    public class ReviewModel
    {
        public long ReviewId { get; set; }
        public long UserId { get; set; }
        public string Content { get; set; }
    }
}
