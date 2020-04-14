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
    
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Allergy> Allergies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MafDatabase");
        }

        public MeetAndFeedDbContext(DbContextOptions<MeetAndFeedDbContext> options)
        : base(options)
        { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedAllergies();
            modelBuilder.SeedUsers();
            modelBuilder.SeedPost();
            modelBuilder.SeedReview();
        }
    }
}
