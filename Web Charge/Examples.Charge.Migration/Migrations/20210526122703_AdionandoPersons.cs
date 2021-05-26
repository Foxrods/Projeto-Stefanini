using Microsoft.EntityFrameworkCore.Migrations;

namespace Examples.Charge.Infra.Data.Configuration.Migrations
{
    public partial class AdionandoPersons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Person",
                columns: new[] { "BusinessEntityID", "Name" },
                values: new object[] { 2, "Ken Masters" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Person",
                columns: new[] { "BusinessEntityID", "Name" },
                values: new object[] { 3, "Laura Matsuda" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Person",
                keyColumn: "BusinessEntityID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Person",
                keyColumn: "BusinessEntityID",
                keyValue: 3);
        }
    }
}
