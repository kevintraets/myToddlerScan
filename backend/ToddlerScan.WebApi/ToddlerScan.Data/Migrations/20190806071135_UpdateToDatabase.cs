using Microsoft.EntityFrameworkCore.Migrations;

namespace ToddlerScan.Data.Migrations
{
    public partial class UpdateToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scans_Trips_TripId",
                table: "Scans");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Teachers_TeacherId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Scans_TripId",
                table: "Scans");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Trips",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "Toddlers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Scans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Toddlers_TripId",
                table: "Toddlers",
                column: "TripId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toddlers_Trips_TripId",
                table: "Toddlers",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Teachers_TeacherId",
                table: "Trips",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toddlers_Trips_TripId",
                table: "Toddlers");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Teachers_TeacherId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Toddlers_TripId",
                table: "Toddlers");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Toddlers");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Scans");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Trips",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Scans_TripId",
                table: "Scans",
                column: "TripId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scans_Trips_TripId",
                table: "Scans",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Teachers_TeacherId",
                table: "Trips",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
