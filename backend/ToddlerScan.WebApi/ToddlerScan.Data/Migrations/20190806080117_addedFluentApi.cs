using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToddlerScan.Data.Migrations
{
    public partial class addedFluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Toddlers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Scans",
                columns: new[] { "Id", "Name", "TeacherId", "TripId" },
                values: new object[] { 1, "Middagpauze", 1, 1 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 5, "Kris", "Hermans" });

            migrationBuilder.InsertData(
                table: "Toddlers",
                columns: new[] { "Id", "FirstName", "Grade", "LastName", "TripId" },
                values: new object[] { 5, "Kevin", "3", "Traets", null });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Date", "TeacherId", "Title" },
                values: new object[] { 1, new DateTime(2019, 8, 6, 10, 1, 16, 239, DateTimeKind.Local).AddTicks(7683), 1, "Zee" });

            migrationBuilder.InsertData(
                table: "ToddlerTrips",
                columns: new[] { "Id", "ToddlerId", "TripId" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Scans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ToddlerTrips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Toddlers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Toddlers",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
