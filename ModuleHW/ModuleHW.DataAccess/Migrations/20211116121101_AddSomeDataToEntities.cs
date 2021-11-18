using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuleHW.DataAccess.Migrations
{
    public partial class AddSomeDataToEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Office",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Andrew [1]", "Babashev [1]" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dave [2]", "Cunningham [2]" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Everett [3]", "Grunz [3]" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ian [4]", "Fleming [4]" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Henry [5]", "Jones [5]" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Company", "Email", "FirstName", "LastName", "Location" },
                values: new object[] { 6, "VQ", "client_6@ma.il", "Volt [6]", "Querier [6]", "VQ Location" });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "OfficeId", "Location", "Name", "Title" },
                values: new object[,]
                {
                    { 6, "Office 6 Location", "Office 6", "Title of Office 6" },
                    { 4, "Office 4 Location", "Office 4", "Title of Office 4" },
                    { 3, "Office 3 Location", "Office 3", "Title of Office 3" },
                    { 2, "Office 2 Location", "Office 2", "Title of Office 2" },
                    { 1, "Office 1 Location", "Office 1", "Title of Office 1" },
                    { 5, "Office 5 Location", "Office 5", "Title of Office 5" }
                });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "Name",
                value: "Anaconda [1]");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "Name",
                value: "Cyclon [2]");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "Name",
                value: "Drager [3]");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "Name",
                value: "Golum [4]");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "Name",
                value: "Oblivion [5]");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6,
                column: "Name",
                value: "Raptor [6]");

            migrationBuilder.InsertData(
                table: "Title",
                columns: new[] { "TitleId", "Name" },
                values: new object[,]
                {
                    { 4, "Title 4" },
                    { 3, "Title 3" },
                    { 2, "Title 2" },
                    { 1, "Title 1" },
                    { 6, "Title 6" },
                    { 5, "Title 5" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 1, new DateTime(1981, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "FName [1]", new DateTime(2011, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "LName [1]", 1, 1 },
                    { 2, new DateTime(1986, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "FName [2]", new DateTime(2013, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "LName [2]", 2, 2 },
                    { 3, new DateTime(1991, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "FName [3]", new DateTime(2015, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "LName [3]", 3, 3 },
                    { 4, new DateTime(1996, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "FName [4]", new DateTime(2017, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "LName [4]", 4, 4 },
                    { 5, new DateTime(2001, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "FName [5]", new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "LName [5]", 5, 5 },
                    { 6, new DateTime(2006, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "FName [6]", new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "LName [6]", 6, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Office");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Andrew", "Babashev" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dave", "Cunningham" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Everett", "Grunz" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ian", "Fleming" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Henry", "Jones" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "Name",
                value: "Anaconda");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "Name",
                value: "Cyclon");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "Name",
                value: "Drager");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "Name",
                value: "Golum");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "Name",
                value: "Oblivion");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6,
                column: "Name",
                value: "Raptor");
        }
    }
}
