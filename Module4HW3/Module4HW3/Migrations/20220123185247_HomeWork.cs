using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module4HW3.Migrations
{
    public partial class HomeWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Country", "Email", "PhoneNumber", "Title" },
                values: new object[,]
                {
                    { 1, "11111", "111111@1111.com", "111111111111", "1" },
                    { 2, "22222", "222222@2222.com", "222222222222", "2" },
                    { 3, "33333", "333333@3333.com", "333333333333", "3" },
                    { 4, "44444", "444444@4444.com", "444444444444", "4" },
                    { 5, "55555", "555555@5555.com", "555555555555", "5" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 100m, 1, "111", new DateTime(2022, 1, 10, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7371) },
                    { 2, 200m, 2, "222", new DateTime(2022, 1, 11, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7408) },
                    { 3, 300m, 3, "333", new DateTime(2022, 1, 12, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7411) },
                    { 4, 400m, 4, "444", new DateTime(2022, 1, 13, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7413) },
                    { 5, 500m, 5, "555", new DateTime(2022, 1, 14, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7415) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}
