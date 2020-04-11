using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MAFDB;
namespace API.Models
{
    public class PostModel
    {
        [Key]
        public long PostId { get; set; }

        public User Creator { get; set; }
        public string Title { get; set; }
        public string Dish { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int AmountOfPeople { get; set; }
        public ICollection<User> Participants { get; set; }
    }
}
