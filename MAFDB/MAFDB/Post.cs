using System;
using System.Collections.Generic;
using System.Text;

namespace MAFDB
{
    public class Post
    {
        public int PostId { get; set; }
        public DateTime Date { get; set; }
        public string Dish { get; set; }
        public int AmountOfPeople { get; set; }
        public double Score { get; set; }
    }
}
