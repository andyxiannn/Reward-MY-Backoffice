using Microsoft.EntityFrameworkCore.Migrations;

namespace Reward_Backoffice.Migrations
{
    public partial class addDealerToDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GL_code",
                table: "Dealer");

            migrationBuilder.DropColumn(
                name: "IC",
                table: "Dealer");

            migrationBuilder.DropColumn(
                name: "code",
                table: "Dealer");

            migrationBuilder.DropColumn(
                name: "cost_sharing",
                table: "Dealer");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Dealer");

            migrationBuilder.DropColumn(
                name: "obligation",
                table: "Dealer");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Dealer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GL_code",
                table: "Dealer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IC",
                table: "Dealer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Dealer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cost_sharing",
                table: "Dealer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Dealer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "obligation",
                table: "Dealer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Dealer",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
