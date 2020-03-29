using System;

namespace MAFDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Database())
            {
                //User Yannick = new User
                //{
                //    FirstName = "yannick",
                //    LastName = "Robijn",
                //    Preference = true,
                //    UserId = 1,
                //    Address = "ergens in de buurt",
                //    DickSize = 2,
                //    EmailAddress = "yannick@test.com"
                //};
                //db.Add(Yannick);
                //db.SaveChanges();

                Post TestPost = new Post
                {
                    AmountOfPeople = 3,
                    Date = DateTime.Now,
                    Dish = "patatjes",
                    PostId = 1,
                    Score = 3.4
                };
            }
        }
    }
}
