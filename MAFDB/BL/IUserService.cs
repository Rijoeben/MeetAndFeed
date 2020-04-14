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

        public User CreateUser(string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender, DateTime dayOfBirth);

        public void RemoveUser(long userId);

        public User ChangeUser(long userId, string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender, DateTime dayOfBirth);

        public User ReadUser(long userId);

        public User Login(string emailAddress, string password);
    }
}
