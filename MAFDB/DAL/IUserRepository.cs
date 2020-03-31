using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace DAL
{
    public interface IUserRepository
    {
        IEnumerable<User> ReadUsers();

        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        //void ReadUser(int? userID);
    }
}
