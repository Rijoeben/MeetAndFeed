﻿using MAFDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public static class ModelBuilderExtensions
    {
        public static void SeedAllergies(this ModelBuilder modelBuilder) // De main allergenen in de database voorzien
        {
            MakeAllergy(1, "Cereals containing gluten", modelBuilder);
            MakeAllergy(2, "Crustaceans", modelBuilder);
            MakeAllergy(3, "Eggs", modelBuilder);
            MakeAllergy(4, "Fish", modelBuilder);
            MakeAllergy(5, "Peanuts", modelBuilder);
            MakeAllergy(6, "Soya", modelBuilder);
            MakeAllergy(7, "Lactose(Milk)", modelBuilder);
            MakeAllergy(8, "Nuts(Tree Nuts)", modelBuilder);
            MakeAllergy(9, "Celery", modelBuilder);
            MakeAllergy(10, "Mustard", modelBuilder);
            MakeAllergy(11, "Sesame", modelBuilder);
            MakeAllergy(12, "Sulphur Dioxide(Sulphite", modelBuilder);
            MakeAllergy(13, "Luping", modelBuilder);
            MakeAllergy(14, "Molluscs", modelBuilder);
        }

        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            MakeUser(1, "Ruben", "Laureys", "EersteStraat", "ruben.laureys@gmail.com", false, 'M', "Password123", "27/07/2000", modelBuilder);
            MakeUser(2, "Jord", "Goossens", "TweedeStraat", "jord.goossens@gmail.com", true, 'X', "Password", "01/01/1999", modelBuilder);
            MakeUser(3, "Yannick", "Robijn", "DerdeStraat", "yannick.robijn@gmail.com", true, 'V', "StinkHoer", "06/9/1969", modelBuilder);
        }

        public static void SeedPost(this ModelBuilder modelBuilder)
        {
            // User nog aanpassen
            MakePost(1, null, "test" , "Ballen in tomatensaus", "Ballen in tomatensaus maar zonder saus", "20/05/2020", 3, modelBuilder);
            MakePost(2, null, "test1", "Ballen in tomatensaus", "Ballen in tomatensaus met vegetarische saus", "20/05/2020", 2, modelBuilder);
            MakePost(3, null, "test2", "Ballen in tomatensaus", "Ballen in tomatensaus maar zonder Ballen", "20/05/2020", 5, modelBuilder);
        }

        public static void SeedReview(this ModelBuilder modelBuilder)
        {
            MakeReview(1, 1, "Ik vond het lekker", modelBuilder);
            MakeReview(2, 2, "Ik vond het niet zo lekker", modelBuilder);
            MakeReview(3, 3, "Hij kon niet van mijn lijf blijven, wel lekker eten", modelBuilder);
        }

        public static void MakeAllergy(long id, string name, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Allergy>().HasData(
               new Allergy()
               {
                   AllergyId = id,
                   AllergyName = name
               }
           );
        }

        public static void MakeUser(long id, string firstName, string lastName,string address, string emailAddress, bool preference, char gender, string password, string birthday, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserId = id,
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    EmailAddress = emailAddress,
                    Preference = preference,
                    Gender = gender,
                    Password = password,
                    Birthday = Convert.ToDateTime(birthday)
                }
            ); 
        }
        public static void MakePost(long id, User creator, string title, string dish, string description, string date, int amountOfPeople, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    PostId = id,
                    Creator = creator,
                    Title = title,
                    Dish = dish,
                    Description = description,
                    Date = Convert.ToDateTime(date),
                    AmountOfPeople = amountOfPeople

                }
             );
        }

        public static void MakeReview(long reviewId, long userId, string content, ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Review>().HasData(
                new Review()
                {
                    ReviewId = reviewId,
                    UserId = userId,
                    Content = content
                }
            );
        }
        
    }
    
}
