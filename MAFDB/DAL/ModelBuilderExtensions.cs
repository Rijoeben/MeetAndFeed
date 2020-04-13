using MAFDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder) // De main allergenen in de database voorzien
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
    }
    
}
