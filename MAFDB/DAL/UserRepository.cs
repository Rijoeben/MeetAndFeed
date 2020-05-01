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
        public User AddUser(User user)
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
        public void DeleteUser(long userId)
        {
            ctx.Users.Remove(GetUser(userId));
            ctx.SaveChanges();
        }
        public User GetUser(long userId)
        {
            return ctx.Users.Find(userId);
        }
        public User SearchUserByEmailAddres(string emailAddress)
        {
            User searchedUser = ctx.Users
                .FirstOrDefault(u => string.Equals(u.EmailAddress, emailAddress)); //Zoekt naar de user met het gegeven email address

            return searchedUser;       
        }
        public void UserAddPost()
        {
            throw new NotImplementedException();
        }
    }
}
