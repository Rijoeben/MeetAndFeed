using System;
using MAFDB;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    class MeetAndFeedDBInitializer
    {
        private static bool _hasRunDuringApplicationExecution;

        public static void Initialize(MeetAndFeedDbContext context, bool forceDropCreateDatabase = false)
        {
            if (!_hasRunDuringApplicationExecution)
            {
                if (forceDropCreateDatabase)
                    context..ensureDeleted();

                if (context.Database.EnsureCreated())
                    Seed(context);

                _hasRunDuringApplicationExecution = true;
            }
        }
        private static void Seed(MeetAndFeedDbContext context)
        {
            //User
            
            
        }
    }
}
