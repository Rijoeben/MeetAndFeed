using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MAFDB;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class UserRepository : IUserRepository  
    {

        private readonly MeetAndFeedDbContext ctx;

        public UserRepository()
        {
            ctx = new MeetAndFeedDbContext();
        }

        public IEnumerable<User> ReadUsers()
        {
            return ctx.Users.AsEnumerable();
        }

        public User CreateUser(User user)
        {
            ctx.Add(user);
            ctx.SaveChanges();
            return user;
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
