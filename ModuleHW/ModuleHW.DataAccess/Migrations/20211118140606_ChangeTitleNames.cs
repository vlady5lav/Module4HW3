using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuleHW.DataAccess.Migrations
{
    public partial class ChangeTitleNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1981, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1986, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2013, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1991, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2015, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(1996, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2001, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2006, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2016, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2015, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 6,
                column: "StartedDate",
                value: new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 2,
                column: "Name",
                value: "A title 2");

            migrationBuilder.UpdateData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 5,
                column: "Name",
                value: "A title 5");

            migrationBuilder.UpdateData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 6,
                column: "Name",
                value: "A Title 6");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2011, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2016, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2017, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "DateOfBirth", "HiredDate" },
                values: new object[] { new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2015, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 6,
                column: "StartedDate",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 2,
                column: "Name",
                value: "Title 2");

            migrationBuilder.UpdateData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 5,
                column: "Name",
                value: "Title 5");

            migrationBuilder.UpdateData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 6,
                column: "Name",
                value: "Title 6");
        }
    }
}
