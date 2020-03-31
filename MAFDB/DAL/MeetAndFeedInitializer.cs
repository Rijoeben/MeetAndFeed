using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    class MeetAndFeedInitializer
    {
        private static bool _hasRunDuringApplicationExecution;

        public static void Initialize(MeetAndFeedDbContext context, bool forceDropCreateDatabase = false)
        {
            if (!_hasRunDuringApplicationExecution)
            {
                if (forceDropCreateDatabase)
                    context.Database.ens

                if (context.Database.EnsureCreated())
                    Seed(context);

                _hasRunDuringApplicationExecution = true;
            }
        }
    }
}
