using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Reward_Backoffice.Migrations
{
    public partial class addclientDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "z3s1o_client",
               columns: table => new
               {
                   client_id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   client_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   client_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   balance_reward_points = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                   salutation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   client_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                   race = table.Column<string>(type: "nvarchar(1)", nullable: false),
                   IC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   PermRes = table.Column<bool>(type: "bit", nullable: false),
                   bumi = table.Column<bool>(type: "bit", nullable: false),
                   telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                   client_tier_id = table.Column<int>(type: "int", nullable: false),
                   remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   date_added = table.Column<DateTime>(type: "datetime2", nullable: false),
                   date_modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                   created_by = table.Column<int>(type: "int", nullable: false),
                   modified_by = table.Column<int>(type: "int", nullable: false),
                   status = table.Column<byte>(type: "tinyint", nullable: false),
                   branch_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   trading_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   UserIDHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_z3s1o_client", x => x.client_id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "z3s1o_client");
        }
    }
}
