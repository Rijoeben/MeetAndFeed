using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using DAL;

namespace BL
{
    public interface IUserService
    {
        IEnumerable<User> ListOfUsers();

        public User AddUser(string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender);

        public void DeleteUser(string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender);

        public void UpdateUser(string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender);


    }
}
