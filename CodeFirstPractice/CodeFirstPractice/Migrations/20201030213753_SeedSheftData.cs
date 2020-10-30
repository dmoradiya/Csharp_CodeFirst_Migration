using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class SeedSheftData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "shelf",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { -1, "Groceries" },
                    { -2, "Medicine" },
                    { -3, "Books" },
                    { -4, "Electronics" },
                    { -5, "Bedding" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
