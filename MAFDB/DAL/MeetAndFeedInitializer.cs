using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DAL
{
    class MeetAndFeedInitializer
    {
        //public static void Creator(MeetAndFeedDbContext context)
        //{
        //    if (context.Database.EnsureCreated())
        //    {
        //        AllergyValues(context);
        //    }
        //}

        public static void TestUsers(MeetAndFeedDbContext db)
        {
            User test = new User()
            {
                Address = "test 2452 test test",
                EmailAddress = "test@gmail.com",
                FirstName = "Johnny",
                LastName = "Test",
                Password = "testing123",
                Preference = true,
                UserId = 1
            };
            db.Add(test);
            db.SaveChanges();
        }

        public static void AllergyValues(MeetAndFeedDbContext db) // De main allergenen in de database voorzien
        {
            Allergy allergy1 = new Allergy()
            {
                AllergyId = 1,
                AllergyName = "Cereals containing gluten"

            };
            db.Add(allergy1);
            db.SaveChanges();

            Allergy allergy2 = new Allergy()
            {
                AllergyId = 2,
                AllergyName = "Crustaceans"
            };
            db.Add(allergy2);
            db.SaveChanges();

            Allergy allergy3 = new Allergy()
            {
                AllergyId = 3,
                AllergyName = "Eggs"
            };
            db.Add(allergy3);
            db.SaveChanges();

            Allergy allergy4 = new Allergy()
            {
                AllergyId = 4,
                AllergyName = "Fish"
            };
            db.Add(allergy4);
            db.SaveChanges();

            Allergy allergy5 = new Allergy()
            {
                AllergyId = 5,
                AllergyName = "Peanuts"
            };
            db.Add(allergy5);
            db.SaveChanges();

            Allergy allergy6 = new Allergy()
            {
                AllergyId = 6,
                AllergyName = "Soya"
            };
            db.Add(allergy6);
            db.SaveChanges();

            Allergy allergy7 = new Allergy()
            {
                AllergyId = 7,
                AllergyName = "Lactose(Milk)"
            };
            db.Add(allergy7);
            db.SaveChanges();

            Allergy allergy8 = new Allergy()
            {
                AllergyId = 8,
                AllergyName = "Nuts(Tree Nuts)"
            };
            db.Add(allergy8);
            db.SaveChanges();

            Allergy allergy9 = new Allergy()
            {
                AllergyId = 9,
                AllergyName = "Celery"
            };
            db.Add(allergy9);
            db.SaveChanges();

            Allergy allergy10 = new Allergy()
            {
                AllergyId = 10,
                AllergyName = "Mustard"
            };
            db.Add(allergy10);
            db.SaveChanges();

            Allergy allergy11 = new Allergy()
            {
                AllergyId = 11,
                AllergyName = "Sesame"
            };
            db.Add(allergy11);
            db.SaveChanges();

            Allergy allergy12 = new Allergy()
            {
                AllergyId = 12,
                AllergyName = "Sulphur Dioxide(Sulphites)"
            };
            db.Add(allergy12);
            db.SaveChanges();

            Allergy allergy13 = new Allergy()
            {
                AllergyId = 13,
                AllergyName = "Lupin"
            };
            db.Add(allergy13);
            db.SaveChanges();

            Allergy allergy14 = new Allergy()
            {
                AllergyId = 14,
                AllergyName = "Molluscs"
            };
            db.Add(allergy14);
            db.SaveChanges();
        }
    }
}

