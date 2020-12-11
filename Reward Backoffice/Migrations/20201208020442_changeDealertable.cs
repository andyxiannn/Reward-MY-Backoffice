using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reward_Backoffice.Migrations
{
    public partial class changeDealertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "z3s1o_client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_z3s1o_Dealers",
                table: "z3s1o_Dealers");

            migrationBuilder.RenameTable(
                name: "z3s1o_Dealers",
                newName: "z3s1o_dealers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_z3s1o_dealers",
                table: "z3s1o_dealers",
                column: "DealerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_z3s1o_dealers",
                table: "z3s1o_dealers");

            migrationBuilder.RenameTable(
                name: "z3s1o_dealers",
                newName: "z3s1o_Dealers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_z3s1o_Dealers",
                table: "z3s1o_Dealers",
                column: "DealerId");

            migrationBuilder.CreateTable(
                name: "z3s1o_client",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermRes = table.Column<bool>(type: "bit", nullable: false),
                    UserIDHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    balance_reward_points = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    branch_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bumi = table.Column<bool>(type: "bit", nullable: false),
                    client_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_tier_id = table.Column<int>(type: "int", nullable: false),
                    client_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    modified_by = table.Column<int>(type: "int", nullable: false),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    race = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salutation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<byte>(type: "tinyint", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trading_type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_z3s1o_client", x => x.client_id);
                });
        }
    }
}
