using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAFDB
{
    public class Post
    {
<<<<<<< HEAD
        public long PostId { get; set; }
=======
        [Key]
        public long PostId { get; set; }

        public User Creator { get; set; }
>>>>>>> 11416422e39e612832674056d6b04233a476484f
        public string Title { get; set; }
        public string Dish { get; set; }
        public string Description { get; set; }        
        public DateTime Date { get; set; }
        public int AmountOfPeople { get; set; }
        public ICollection<User> Participants { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
        //public double Score { get; set; }
    }
}
