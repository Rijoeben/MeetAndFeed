using MAFDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class UserService : IUserService
    {
        private IUserService _repo;

        public User AddUser(string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender)
        {
            User newUser = new User();

            newUser.FirstName = firstName;
            newUser.LastName = lastName;
            newUser.Address = address;
            newUser.EmailAddress = emailAddress;
            newUser.Preference = preference;
            newUser.Password = password;
            newUser.MaleOrFemale = gender;
        }

        public void DeleteUser(string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ListOfUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender)
        {
            throw new NotImplementedException();
        }
    }
}
