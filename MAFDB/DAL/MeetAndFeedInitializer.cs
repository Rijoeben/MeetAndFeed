﻿using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    class MeetAndFeedInitializer
    {
        //private static bool _hasRunDuringApplicationExecution;

        public static void Initialize(MeetAndFeedDbContext context, bool forceDropCreateDatabase = false)
        {
            if (forceDropCreateDatabase) context.Database.EnsureDeleted();

            if (context.Database.EnsureCreated())
        }

        public static void Testwaarden(MeetAndFeedDbContext context)
        {
            User test = new User()
            {
                Address = "test 2452 test test",
                DickSize = 25,
                EmailAddress = "test@gmail.com",
                FirstName = "Johnny",
                LastName = "Test",
                Password = "testing123",
                Preference = true,
                UserId = 1
            };
        }
    }
}

