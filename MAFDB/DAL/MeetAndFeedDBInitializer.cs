using System;
using System.Collections.Generic;
using System.Text;

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
                    context.Database.EnsureDeleted();

                if (context.Database.EnsureCreated())
                    Seed(context);

                _hasRunDuringApplicationExecution = true;
            }
        }
    }
}
