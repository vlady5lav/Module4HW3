using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuleHW.DataAccess.Migrations
{
    public partial class MakeOfficeAndTitleFieldsNullableForEmployersTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[] { 7, new DateTime(2011, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "FName [7]", new DateTime(2019, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "LName [7]", 4, null });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[] { 8, new DateTime(2016, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "FName [8]", new DateTime(2017, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "LName [8]", null, 2 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[] { 9, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "FName [9]", new DateTime(2015, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "LName [9]", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9);
        }
    }
}
