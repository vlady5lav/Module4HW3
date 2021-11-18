using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuleHW.DataAccess.Migrations
{
    public partial class AddEmployeeProjectTableData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1, 5, 3000m, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 2, 4, 4000m, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 3, 3, 5000m, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 4, 2, 6000m, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 5, 1, 7000m, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 5);
        }
    }
}
