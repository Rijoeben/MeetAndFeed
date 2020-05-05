using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Chef = table.Column<string>(nullable: true),
                    Dish = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    AmountOfPeople = table.Column<int>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<long>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Score = table.Column<float>(nullable: false),
                    PostId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Preference = table.Column<bool>(nullable: false),
                    Gender = table.Column<char>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    PostId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    AllergyId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AllergyName = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.AllergyId);
                    table.ForeignKey(
                        name: "FK_Allergies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 1L, "Cereals containing gluten", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 14L, "Molluscs", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 13L, "Luping", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 11L, "Sesame", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 10L, "Mustard", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 9L, "Celery", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 8L, "Nuts(Tree Nuts)", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 12L, "Sulphur Dioxide(Sulphite", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 6L, "Soya", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 5L, "Peanuts", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 4L, "Fish", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 3L, "Eggs", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 2L, "Crustaceans", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 7L, "Lactose(Milk)", null });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AmountOfPeople", "Chef", "Date", "Description", "Dish", "UserId" },
                values: new object[] { 1L, 3, null, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ballen in tomatensaus maar zonder saus", "Ballen in tomatensaus", 1L });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AmountOfPeople", "Chef", "Date", "Description", "Dish", "UserId" },
                values: new object[] { 2L, 2, null, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spaghetti Bolognaise met gehak", "Spaghetti bolognaise", 2L });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AmountOfPeople", "Chef", "Date", "Description", "Dish", "UserId" },
                values: new object[] { 3L, 5, null, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mijn geheime macaroni", "Macaroni", 3L });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "PostId", "Score", "UserId" },
                values: new object[] { 1L, "Ik vond het lekker", null, 0f, 1L });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "PostId", "Score", "UserId" },
                values: new object[] { 2L, "Ik vond het niet zo lekker", null, 0f, 2L });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "PostId", "Score", "UserId" },
                values: new object[] { 3L, "Hij kon niet van mijn lijf blijven, wel lekker eten", null, 0f, 3L });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Birthday", "EmailAddress", "FirstName", "Gender", "LastName", "Password", "PostId", "Preference" },
                values: new object[] { 2L, "TweedeStraat", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jord.goossens@gmail.com", "Jord", 'X', "Goossens", "Password", null, true });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Birthday", "EmailAddress", "FirstName", "Gender", "LastName", "Password", "PostId", "Preference" },
                values: new object[] { 1L, "EersteStraat", new DateTime(2000, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ruben.laureys@gmail.com", "Ruben", 'M', "Laureys", "Password123", null, false });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Birthday", "EmailAddress", "FirstName", "Gender", "LastName", "Password", "PostId", "Preference" },
                values: new object[] { 3L, "DerdeStraat", new DateTime(1969, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "yannick.robijn@gmail.com", "Yannick", 'V', "Robijn", "StinkHoer", null, true });

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_UserId",
                table: "Allergies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PostId",
                table: "Reviews",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PostId",
                table: "Users",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
