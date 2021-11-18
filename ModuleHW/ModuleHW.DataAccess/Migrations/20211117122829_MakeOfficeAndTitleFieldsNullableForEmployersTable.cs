using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuleHW.DataAccess.Migrations
{
    public partial class MakeOfficeAndTitleFieldsNullableForEmployersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2011, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1986, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2013, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1991, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2015, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2017, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2001, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2006, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1981, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2011, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1986, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2013, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1991, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2015, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1996, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2017, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2001, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2006, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
