using MAFDB;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BL
{
    public class UserService : IUserService
    {
        private IUserRepository _repo;

        public User AddUser(string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender, DateTime dayOfBirth)
        {
            User newUser = new User();

            newUser.FirstName = firstName;
            newUser.LastName = lastName;
            newUser.Address = address;
            newUser.EmailAddress = emailAddress;
            newUser.Preference = preference;
            newUser.Password = password;
            newUser.Gender = gender;
            newUser.Birthday = dayOfBirth;

            _repo.CreateUser(newUser);
            return newUser;
        }

        public void RemoveUser(string userID)
        {
            _repo.DeleteUser(userID);
        }

        public IEnumerable<User> ListOfUsers()
        {
            return _repo.ReadUsers();
        }

        public void ChangeUser(User user)
        {
            _repo.UpdateUser(user);
        }
    }
}
