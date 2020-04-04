using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace DAL
{
    public interface IUserRepository
    {
        IEnumerable<User> ReadUsers();       
        User CreateUser(User user);
        void UpdateUser(User user);
        User GetUser(string userID);
        void DeleteUser(string userID);
        //void ReadUser(int? userID);
        User SearchUserByEmailAddres(string emailAddress);

    }
}
