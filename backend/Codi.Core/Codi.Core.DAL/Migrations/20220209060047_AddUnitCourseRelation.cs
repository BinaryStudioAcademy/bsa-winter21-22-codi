using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    public partial class AddUnitCourseRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CourseId",
                table: "Units",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Units_CourseId",
                table: "Units",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Courses_CourseId",
                table: "Units",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Courses_CourseId",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Units_CourseId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Units");
        }
    }
}
