using System;
using MAFDB;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class MeetAndFeedDbContext : DbContext 
    {
        public MeetAndFeedDbContext()
        {
           // MeetAndFeedDbContext.Initialize(this, true);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<UserAllergy> UserAllergies { get; set; }
        public DbSet<ProductAllergy> ProductAllergies { get; set; }
        public DbSet<PostProduct> PostProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MafDatabase");
        }

        //protected override void OnModelCreating(ModelBuilder modelbuilder)
        //{
        //    modelbuilder.Entity<UserAllergy>()
        //        .HasKey(ua => new { ua.AllergyId, ua.UserId });
        //    modelbuilder.Entity<PostProduct>()
        //        .HasKey(pp => new { pp.PostId, pp.ProductId });
        //    modelbuilder.Entity<ProductAllergy>()
        //        .HasKey(pa => new { pa.AllergyId, pa.ProductId });
        //    modelbuilder.Entity<UserAllergy>()
        //        .HasKey(pa => new { pa.UserId, pa.AllergyId });
        //    modelbuilder.Entity<Post>()
        //        .HasOne(u => u.Creator)
        //        .WithMany(p => p.Posts);
        
    }
}
