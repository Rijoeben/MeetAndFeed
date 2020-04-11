using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace DAL
{
    public interface IUserRepository
    {
        IEnumerable<User> ReadUsers();       
        User AddUser(User user);
        void UpdateUser(User user);
        User GetUser(long userId);
        void DeleteUser(long userId);
        //void ReadUser(int? userID);
        User SearchUserByEmailAddres(string emailAddress);

        void UserAddPost();

    }
}
