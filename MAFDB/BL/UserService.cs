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
        public UserService()
        {
            _repo = new UserRepository();
        }
        public User CreateUser(string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender, DateTime dayOfBirth)
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

            _repo.AddUser(newUser);
            return newUser;
        }

        public void RemoveUser(long userId)
        {
            _repo.DeleteUser(userId);
        }

        public IEnumerable<User> ListOfUsers()
        {
            return _repo.ReadUsers();
        }

        public User ChangeUser(long userId, string firstName, string lastName, string address, string emailAddress, bool preference, string password, char gender, DateTime dayOfBirth)
        {
            User userToChange = ReadUser(userId);
            if (userToChange != null) // Checkt of er een user is gevonden met de mee gegeven id
            {
                userToChange.FirstName = firstName;
                userToChange.LastName = lastName;
                userToChange.Address = address;
                userToChange.EmailAddress = emailAddress;
                userToChange.Preference = preference;
                userToChange.Password = password;
                userToChange.Gender = gender;
                userToChange.Birthday = dayOfBirth;

                _repo.UpdateUser(userToChange);
                return userToChange;
            }
            else
            {
                return null;

            }
        }

         public User ReadUser(long userId)
         {
            return _repo.GetUser(userId);
         }

        public bool LoginBool(string emailAddress, string password)
        {
            User userToLogin = _repo.SearchUserByEmailAddres(emailAddress); // User gaan zoeken aan de hanv van het gegeven email address

            if(userToLogin.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public long LoginId(string email,string password)
        {
            User userToLogin = _repo.SearchUserByEmailAddres(email);
            if (userToLogin.Password == password) return userToLogin.UserId;
            else return 0;
        }

       
    }
}
