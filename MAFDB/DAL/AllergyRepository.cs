﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MAFDB;


namespace DAL
{
    public class AllergyRepository : IAllergyRepository
    {
        private readonly MeetAndFeedDbContext ctx;
        public AllergyRepository()
        {
            ctx = new MeetAndFeedDbContext();
        }
        public IEnumerable<Allergy> ReadAllergy()
        {
            return ctx.Allergies.AsEnumerable();
        }
        public Allergy CreateAllergy(Allergy allergy)
        {
            ctx.Allergies.Add(allergy);
            ctx.SaveChanges();
            return allergy;
        }

        public void UpdateAllergy(Allergy allergy)
        {
            ctx.Allergies.Add(allergy);
            ctx.SaveChanges();
        }

        public Allergy GetAllergy(string allergyId)
        {
            return ctx.Allergies.Find(allergyId);
        }

        public void DeleteAllergy(Allergy allergy) /*Dit is voorzien.We gaan het waarschijnlijk niet gebruiken, maar we laten het staan stel we hebben het nog nodig*/
        {
            ctx.Allergies.Remove(allergy);
            ctx.SaveChanges();
        }
}
}
