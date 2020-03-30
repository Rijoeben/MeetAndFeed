using System;
using MAFDB;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore.Infrastructure;
namespace DAL
{
    public class MeetAndFeedDBInitializer
    {
        private static bool _hasRunDuringApplicationExecution;

        public void Initialize(MeetAndFeedDbContext database, bool forceDropCreateDatabase = false)
        {
            if (!_hasRunDuringApplicationExecution)
            {
                if (forceDropCreateDatabase) //bool
                    //verwuhdere

                    if (database.Database. ;//database naam ? 
                    Seed(context); // zelfgemaakte functie 

                _hasRunDuringApplicationExecution = true;
            }
        }
        public static void Seed(MeetAndFeedDbContext context)
        {
            //User
            User jord = new User();
            
            
        }
    }
}
