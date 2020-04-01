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
        User UpdateUser(User user);
        void DeleteUser(User user);
        //void ReadUser(int? userID);
    }
}
