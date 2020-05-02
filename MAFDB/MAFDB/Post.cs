using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class Post
    {
        [Key]
        public long PostId { get; set; }
        public string Cheff { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }        
        public DateTime Date { get; set; }
        public int AmountOfPeople { get; set; }
        public long UserId { get; set; }
        public ICollection<User> Participants { get; set; }
        public ICollection<Review> Reviews { get; set; }
        //public double Score { get; set; }
    }
}
