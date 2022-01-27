using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module4HW3.Migrations
{
    public partial class Queries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 1, 14, 19, 44, 46, 787, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 1, 15, 19, 44, 46, 787, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 1, 16, 19, 44, 46, 787, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2022, 1, 17, 19, 44, 46, 787, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2022, 1, 18, 19, 44, 46, 787, DateTimeKind.Local).AddTicks(2476));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 1, 10, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 1, 11, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 1, 12, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2022, 1, 13, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2022, 1, 14, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7415));
        }
    }
}
