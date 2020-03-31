using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MAFDB;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class UserRepository
    {

        private readonly MeetAndFeedDbContext ctx;

        public UserRepository()
        {
            ctx = new MeetAndFeedDbContext();
        }

        public UserRepository(UnitOfWork unitOfWork)
        {
            ctx = unitOfWork.Context;
        }

        public IEnumerable<User> ReadUsers()
        {
            return ctx.Users.AsEnumerable();
        }

        public void CreateUser(User user)
        {
            ctx.Add(user);
            ctx.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            ctx.Users.Update(user);
            ctx.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            ctx.Users.Remove(user);
            ctx.SaveChanges();
        }
    }
}
