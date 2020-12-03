using Microsoft.EntityFrameworkCore.Migrations;

namespace Reward_Backoffice.Migrations
{
    public partial class addDealerToDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dealer",
                table: "Dealer");

            migrationBuilder.RenameTable(
                name: "Dealer",
                newName: "Dealers");

            migrationBuilder.RenameColumn(
                name: "branch",
                table: "Dealers",
                newName: "Branch");

            migrationBuilder.RenameColumn(
                name: "dealer_name",
                table: "Dealers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "dealer_code",
                table: "Dealers",
                newName: "Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dealers",
                table: "Dealers",
                column: "DealerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dealers",
                table: "Dealers");

            migrationBuilder.RenameTable(
                name: "Dealers",
                newName: "Dealer");

            migrationBuilder.RenameColumn(
                name: "Branch",
                table: "Dealer",
                newName: "branch");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Dealer",
                newName: "dealer_name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Dealer",
                newName: "dealer_code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dealer",
                table: "Dealer",
                column: "DealerId");
        }
    }
}
