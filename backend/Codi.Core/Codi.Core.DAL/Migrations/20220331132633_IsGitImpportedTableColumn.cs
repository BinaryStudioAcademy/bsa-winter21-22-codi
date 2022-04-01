using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    public partial class IsGitImpportedTableColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsGitImported",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGitImported",
                table: "Projects");
        }
    }
}
