using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UnitOfWork
    {
        internal MeetAndFeedDbContext Context { get; }

        public UnitOfWork(MeetAndFeedDbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
