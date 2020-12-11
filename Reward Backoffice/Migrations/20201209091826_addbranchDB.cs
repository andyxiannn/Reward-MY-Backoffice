using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reward_Backoffice.Migrations
{
    public partial class addbranchDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "z3s1o_branch",
                columns: table => new
                {
                    branch_table_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branch_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    added_by = table.Column<int>(type: "int", nullable: false),
                    modified_by = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_z3s1o_branch", x => x.branch_table_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "z3s1o_branch");
        }
    }
}
