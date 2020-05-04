﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(MeetAndFeedDbContext))]
    partial class MeetAndFeedDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MAFDB.Allergy", b =>
                {
                    b.Property<long>("AllergyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AllergyName")
                        .HasColumnType("TEXT");

                    b.Property<long?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AllergyId");

                    b.HasIndex("UserId");

                    b.ToTable("Allergies");

                    b.HasData(
                        new
                        {
                            AllergyId = 1L,
                            AllergyName = "Cereals containing gluten"
                        },
                        new
                        {
                            AllergyId = 2L,
                            AllergyName = "Crustaceans"
                        },
                        new
                        {
                            AllergyId = 3L,
                            AllergyName = "Eggs"
                        },
                        new
                        {
                            AllergyId = 4L,
                            AllergyName = "Fish"
                        },
                        new
                        {
                            AllergyId = 5L,
                            AllergyName = "Peanuts"
                        },
                        new
                        {
                            AllergyId = 6L,
                            AllergyName = "Soya"
                        },
                        new
                        {
                            AllergyId = 7L,
                            AllergyName = "Lactose(Milk)"
                        },
                        new
                        {
                            AllergyId = 8L,
                            AllergyName = "Nuts(Tree Nuts)"
                        },
                        new
                        {
                            AllergyId = 9L,
                            AllergyName = "Celery"
                        },
                        new
                        {
                            AllergyId = 10L,
                            AllergyName = "Mustard"
                        },
                        new
                        {
                            AllergyId = 11L,
                            AllergyName = "Sesame"
                        },
                        new
                        {
                            AllergyId = 12L,
                            AllergyName = "Sulphur Dioxide(Sulphite"
                        },
                        new
                        {
                            AllergyId = 13L,
                            AllergyName = "Luping"
                        },
                        new
                        {
                            AllergyId = 14L,
                            AllergyName = "Molluscs"
                        });
                });

            modelBuilder.Entity("MAFDB.Post", b =>
                {
                    b.Property<long>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AmountOfPeople")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Chef")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dish")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PostId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1L,
                            AmountOfPeople = 3,
                            Date = new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ballen in tomatensaus maar zonder saus",
                            Dish = "Ballen in tomatensaus",
                            UserId = 0L
                        },
                        new
                        {
                            PostId = 2L,
                            AmountOfPeople = 2,
                            Date = new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ballen in tomatensaus met vegetarische saus",
                            Dish = "Ballen in tomatensaus",
                            UserId = 0L
                        },
                        new
                        {
                            PostId = 3L,
                            AmountOfPeople = 5,
                            Date = new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ballen in tomatensaus maar zonder Ballen",
                            Dish = "Ballen in tomatensaus",
                            UserId = 0L
                        });
                });

            modelBuilder.Entity("MAFDB.Review", b =>
                {
                    b.Property<long>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<long?>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Score")
                        .HasColumnType("REAL");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReviewId");

                    b.HasIndex("PostId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("MAFDB.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<char>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<long?>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Preference")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.HasIndex("PostId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            Address = "EersteStraat",
                            Birthday = new DateTime(2000, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "ruben.laureys@gmail.com",
                            FirstName = "Ruben",
                            Gender = 'M',
                            LastName = "Laureys",
                            Password = "Password123",
                            Preference = false
                        },
                        new
                        {
                            UserId = 2L,
                            Address = "TweedeStraat",
                            Birthday = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "jord.goossens@gmail.com",
                            FirstName = "Jord",
                            Gender = 'X',
                            LastName = "Goossens",
                            Password = "Password",
                            Preference = true
                        },
                        new
                        {
                            UserId = 3L,
                            Address = "DerdeStraat",
                            Birthday = new DateTime(1969, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "yannick.robijn@gmail.com",
                            FirstName = "Yannick",
                            Gender = 'V',
                            LastName = "Robijn",
                            Password = "StinkHoer",
                            Preference = true
                        });
                });

            modelBuilder.Entity("MAFDB.Allergy", b =>
                {
                    b.HasOne("MAFDB.User", null)
                        .WithMany("Allergies")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MAFDB.Review", b =>
                {
                    b.HasOne("MAFDB.Post", null)
                        .WithMany("Reviews")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("MAFDB.User", b =>
                {
                    b.HasOne("MAFDB.Post", null)
                        .WithMany("Participants")
                        .HasForeignKey("PostId");
                });
#pragma warning restore 612, 618
        }
    }
}
