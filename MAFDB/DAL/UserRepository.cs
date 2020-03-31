using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UserRepository
    {

        private readonly MeetAndFeedDbContext ctx;

        public UserRepository()
        {
            ctx = new MeetAndFeedDbContext();
        }
    }
}
