using Microsoft.EntityFrameworkCore.Migrations;

namespace Examples.Charge.Infra.Data.Configuration.Migrations
{
    public partial class PersonID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonPhone_Person_BusinessEntityID",
                schema: "dbo",
                table: "PersonPhone");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PersonPhone",
                keyColumns: new[] { "BusinessEntityID", "PhoneNumber", "PhoneNumberTypeID" },
                keyValues: new object[] { 1, "(19)99999-4021", 2 });

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                schema: "dbo",
                table: "PersonPhone",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_PersonPhone_BusinessEntityID",
                schema: "dbo",
                table: "PersonPhone",
                column: "BusinessEntityID");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "PersonPhone",
                keyColumns: new[] { "BusinessEntityID", "PhoneNumber", "PhoneNumberTypeID" },
                keyValues: new object[] { 1, "(19)99999-2883", 1 },
                column: "PersonID",
                value: 1);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PersonPhone",
                columns: new[] { "BusinessEntityID", "PhoneNumber", "PhoneNumberTypeID", "PersonID" },
                values: new object[] { 2, "(19)99999-4021", 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_PersonPhone_PersonID",
                schema: "dbo",
                table: "PersonPhone",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonPhone_Person_PersonID",
                schema: "dbo",
                table: "PersonPhone",
                column: "PersonID",
                principalSchema: "dbo",
                principalTable: "Person",
                principalColumn: "BusinessEntityID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonPhone_Person_PersonID",
                schema: "dbo",
                table: "PersonPhone");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_PersonPhone_BusinessEntityID",
                schema: "dbo",
                table: "PersonPhone");

            migrationBuilder.DropIndex(
                name: "IX_PersonPhone_PersonID",
                schema: "dbo",
                table: "PersonPhone");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PersonPhone",
                keyColumns: new[] { "BusinessEntityID", "PhoneNumber", "PhoneNumberTypeID" },
                keyValues: new object[] { 2, "(19)99999-4021", 2 });

            migrationBuilder.DropColumn(
                name: "PersonID",
                schema: "dbo",
                table: "PersonPhone");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PersonPhone",
                columns: new[] { "BusinessEntityID", "PhoneNumber", "PhoneNumberTypeID" },
                values: new object[] { 1, "(19)99999-4021", 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonPhone_Person_BusinessEntityID",
                schema: "dbo",
                table: "PersonPhone",
                column: "BusinessEntityID",
                principalSchema: "dbo",
                principalTable: "Person",
                principalColumn: "BusinessEntityID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
