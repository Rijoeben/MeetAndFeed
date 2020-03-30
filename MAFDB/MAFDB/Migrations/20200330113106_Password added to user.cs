using Microsoft.EntityFrameworkCore.Migrations;

namespace MAFDB.Migrations
{
    public partial class Passwordaddedtouser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostProducts_Posts_PostId1",
                table: "PostProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAllergies_Products_ProductId1",
                table: "ProductAllergies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAllergies",
                table: "UserAllergies");

            migrationBuilder.DropIndex(
                name: "IX_UserAllergies_UserId",
                table: "UserAllergies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAllergies",
                table: "ProductAllergies");

            migrationBuilder.DropIndex(
                name: "IX_ProductAllergies_AllergyId",
                table: "ProductAllergies");

            migrationBuilder.DropIndex(
                name: "IX_ProductAllergies_ProductId1",
                table: "ProductAllergies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostProducts",
                table: "PostProducts");

            migrationBuilder.DropIndex(
                name: "IX_PostProducts_PostId1",
                table: "PostProducts");

            migrationBuilder.DropColumn(
                name: "DickSize",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "ProductAllergies");

            migrationBuilder.DropColumn(
                name: "PostId1",
                table: "PostProducts");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductAllergies",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<double>(
                name: "Score",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "PostProducts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAllergies",
                table: "UserAllergies",
                columns: new[] { "UserId", "AllergyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAllergies",
                table: "ProductAllergies",
                columns: new[] { "AllergyId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostProducts",
                table: "PostProducts",
                columns: new[] { "PostId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserAllergies_AllergyId",
                table: "UserAllergies",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAllergies_ProductId",
                table: "ProductAllergies",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostProducts_Posts_PostId",
                table: "PostProducts",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAllergies_Products_ProductId",
                table: "ProductAllergies",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostProducts_Posts_PostId",
                table: "PostProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAllergies_Products_ProductId",
                table: "ProductAllergies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAllergies",
                table: "UserAllergies");

            migrationBuilder.DropIndex(
                name: "IX_UserAllergies_AllergyId",
                table: "UserAllergies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAllergies",
                table: "ProductAllergies");

            migrationBuilder.DropIndex(
                name: "IX_ProductAllergies_ProductId",
                table: "ProductAllergies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostProducts",
                table: "PostProducts");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.AddColumn<float>(
                name: "DickSize",
                table: "Users",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductAllergies",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "ProductAllergies",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "PostProducts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "PostId1",
                table: "PostProducts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAllergies",
                table: "UserAllergies",
                columns: new[] { "AllergyId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAllergies",
                table: "ProductAllergies",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostProducts",
                table: "PostProducts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAllergies_UserId",
                table: "UserAllergies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAllergies_AllergyId",
                table: "ProductAllergies",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAllergies_ProductId1",
                table: "ProductAllergies",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_PostProducts_PostId1",
                table: "PostProducts",
                column: "PostId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PostProducts_Posts_PostId1",
                table: "PostProducts",
                column: "PostId1",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAllergies_Products_ProductId1",
                table: "ProductAllergies",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
