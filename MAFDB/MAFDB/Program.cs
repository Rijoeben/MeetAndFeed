using System;

namespace MAFDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Database())
            {
                User user = new User
                {
                    FirstName = "Ruben",
                    LastName = "Laureys",
                    Preference = false,
                    UserId = 2,
                    Address = "Niet in de buurt",
                    DickSize = 18,
                    EmailAddress = "Rijoeben@gmail.br"
                };
                db.Add(user);
                db.SaveChanges();

                Post TestPost = new Post
                {
                    AmountOfPeople = 3,
                    Date = DateTime.Now,
                    Dish = "patatjes",
                    PostId = 1,
                    Score = 3.4
                };

                UserPost TestUserPost = new UserPost
                {
                    PostId = TestPost.PostId,
                    Post = TestPost,
                    UserId = user.UserId,

                }

                Allergy TestAllergy = new Allergy
                {
                    AllergyId = 1,
                    AllergyName = "testallergy"
                };
                
            }
        }
    }
}
