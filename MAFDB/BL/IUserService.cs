﻿using System; 
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

        public void RemoveUser(string userID);

        public void ChangeUser(User user);

        public User FindUserByEmailAddress(string emailAddress);

        public Post UserCreatePost(string title, string dish, string description, DateTime date, int amountOfPeople, double score);


    }
}