using Microsoft.EntityFrameworkCore.Migrations;

namespace Reward_Backoffice.Migrations
{
    public partial class changeDealerDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IC",
                table: "Dealers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "cost_sharing",
                table: "Dealers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Dealers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Dealers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IC",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "cost_sharing",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Dealers");
        }
    }
}
