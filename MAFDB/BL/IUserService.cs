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

        public void RemoveUser(string userId);

        public void ChangeUser(User user);

        public User ReadUser(int userId);

        public User FindUserByEmailAddress(string emailAddress);
    }
}
