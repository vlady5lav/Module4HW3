using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuleHW.DataAccess.Migrations
{
    public partial class AddClientTable : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Company", "FirstName", "LastName", "Location" },
                values: new object[,]
                {
                    { 1, "Apple", "Andrew", "Babashev", "One Apple Park Way, Cupertino, California, U.S." },
                    { 2, "Google", "Dave", "Cunningham", "1600 Amphitheatre Parkway, Mountain View, California, U.S." },
                    { 3, "Microsoft", "Everett", "Grunz", "One Microsoft Way, Redmond, Washington, U.S." },
                    { 4, "Panasonic", "Ian", "Fleming", "Kadoma, Osaka, Japan" },
                    { 5, "Samsung", "Henry", "Jones", "40th floor Samsung Electronics Building, 11, Seocho-daero 74-gil, Seocho District, Seoul, South Korea" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 10000.0m, 1, "Anaconda", new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 20000.0m, 2, "Cyclon", new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 30000.0m, 3, "Drager", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 40000.0m, 4, "Golum", new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 50000.0m, 5, "Oblivion", new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 60000.0m, 5, "Raptor", new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}
