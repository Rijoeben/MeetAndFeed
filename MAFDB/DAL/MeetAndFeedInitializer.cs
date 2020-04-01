using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    class MeetAndFeedInitializer
    {
        //enkel usefull voor migrations over te slagen

        //private static bool _hasRunDuringApplicationExecution;

        //public static void Initialize(MeetAndFeedDbContext context, bool forceDropCreateDatabase = false)
        //{
        //    if (forceDropCreateDatabase) context.Database.EnsureDeleted();

        //    if (context.Database.EnsureCreated())
                 
        //}

        public static void Testwaarden(MeetAndFeedDbContext db)
        {
            User test = new User()
            {
                Address = "test 2452 test test",
                EmailAddress = "test@gmail.com",
                FirstName = "Johnny",
                LastName = "Test",
                Password = "testing123",
                Preference = true,
                UserId = 1
            };
            db.Add(test);
            db.SaveChanges();
        }
    }
}

