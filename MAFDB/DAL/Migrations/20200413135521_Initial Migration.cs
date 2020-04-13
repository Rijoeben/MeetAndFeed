using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<long>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
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

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Dish = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    AmountOfPeople = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
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
                values: new object[] { 12L, "Sulphur Dioxide(Sulphite", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 11L, "Sesame", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 10L, "Mustad", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 8L, "Nuts(Tree Nuts)", null });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "AllergyName", "UserId" },
                values: new object[] { 9L, "Celery", null });

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
                name: "IX_Posts_CreatorUserId",
                table: "Posts",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PostId",
                table: "Users",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Posts_PostId",
                table: "Users",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_CreatorUserId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
