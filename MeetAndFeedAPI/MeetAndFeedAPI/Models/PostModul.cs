using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetAndFeedAPI.Models
{
    public class PostModul
    {
        
        public DateTime Date { get; set; }
        public string Dish { get; set; }
        public int AmountOfPeople { get; set; }
        public double Score { get; set; }
    }
}