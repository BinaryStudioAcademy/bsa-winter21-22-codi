using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    public partial class RemoveCourseUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseUsers_CourseRoles_CourseRoleId",
                table: "CourseUsers");

            migrationBuilder.DropTable(
                name: "CourseRoles");

            migrationBuilder.DropIndex(
                name: "IX_CourseUsers_CourseRoleId",
                table: "CourseUsers");

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 13L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 21L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 39L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, 47L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 30L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 26L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 19L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 17L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 17L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 18L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 36L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 20L, 4L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 20L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 20L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 46L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 30L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 23L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 23L, 15L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 18L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 32L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 32L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 34L, 9L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 18L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 38L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 38L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 40L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 40L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 30L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 26L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 49L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 25L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 15L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 39L });

            migrationBuilder.DropColumn(
                name: "CourseRoleId",
                table: "CourseUsers");

            migrationBuilder.AddColumn<int>(
                name: "CourseRole",
                table: "CourseUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 6L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 10, 27, 6, 13, 20, 326, DateTimeKind.Unspecified).AddTicks(1462), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 6L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 11, 8, 18, 0, 16, 927, DateTimeKind.Unspecified).AddTicks(5586), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 14L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 57, 38, 734, DateTimeKind.Unspecified).AddTicks(6879), 1L, 37L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 21L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 12, 31, 14, 15, 15, 957, DateTimeKind.Unspecified).AddTicks(2900), 2L, 32L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 23L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 9, 17, 5, 31, 45, 103, DateTimeKind.Unspecified).AddTicks(1071), 3L, 22L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 24L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 9, 28, 1, 52, 4, 463, DateTimeKind.Unspecified).AddTicks(5896), 4L, 42L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 26L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 11, 5, 16, 40, 8, 932, DateTimeKind.Unspecified).AddTicks(5529), 5L, 60L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 26L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 5, 13, 1, 7, 29, 486, DateTimeKind.Unspecified).AddTicks(5868), 3L, 47L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 28L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 8, 25, 2, 8, 47, 611, DateTimeKind.Unspecified).AddTicks(1564), 52L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 30L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 22, 53, 748, DateTimeKind.Unspecified).AddTicks(2742), 7L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 32L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 6, 19, 21, 43, 3, 218, DateTimeKind.Unspecified).AddTicks(7346), 1L, 23L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 33L },
                column: "CreatedAt",
                value: new DateTime(2021, 3, 2, 14, 52, 5, 486, DateTimeKind.Unspecified).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 33L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 6, 18, 17, 16, 6, 830, DateTimeKind.Unspecified).AddTicks(1231), 3L, 62L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 36L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 12, 24, 10, 4, 32, 706, DateTimeKind.Unspecified).AddTicks(5106), 2L, 26L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 39L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 3, 8, 7, 14, 46, 769, DateTimeKind.Unspecified).AddTicks(774), 67L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 45L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 11, 12, 6, 17, 13, 136, DateTimeKind.Unspecified).AddTicks(9133), 3L, 57L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 47L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 11, 24, 11, 9, 57, 22, DateTimeKind.Unspecified).AddTicks(3823), 5L, 27L });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "CourseId", "UserId", "CourseRole", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 19L, 3L, 0, new DateTime(2021, 8, 27, 19, 41, 24, 300, DateTimeKind.Unspecified).AddTicks(4452), 5L, 41L, false },
                    { 11L, 4L, 0, new DateTime(2021, 6, 7, 4, 36, 12, 773, DateTimeKind.Unspecified).AddTicks(1216), 5L, 18L, false },
                    { 2L, 5L, 0, new DateTime(2021, 2, 11, 10, 19, 46, 101, DateTimeKind.Unspecified).AddTicks(5568), 5L, 68L, false },
                    { 6L, 5L, 0, new DateTime(2021, 5, 15, 6, 37, 46, 585, DateTimeKind.Unspecified).AddTicks(5444), 4L, 40L, false },
                    { 16L, 10L, 0, new DateTime(2021, 9, 14, 1, 7, 56, 693, DateTimeKind.Unspecified).AddTicks(7215), 4L, 46L, false },
                    { 21L, 10L, 0, new DateTime(2022, 1, 10, 6, 35, 41, 132, DateTimeKind.Unspecified).AddTicks(7949), 4L, 39L, false },
                    { 10L, 11L, 0, new DateTime(2022, 1, 1, 8, 0, 43, 579, DateTimeKind.Unspecified).AddTicks(9957), 5L, 55L, false },
                    { 11L, 16L, 0, new DateTime(2021, 3, 15, 10, 36, 37, 39, DateTimeKind.Unspecified).AddTicks(3850), 4L, 24L, false },
                    { 10L, 17L, 0, new DateTime(2021, 10, 9, 12, 2, 55, 709, DateTimeKind.Unspecified).AddTicks(3065), 3L, 53L, false },
                    { 14L, 17L, 0, new DateTime(2021, 9, 2, 10, 11, 44, 81, DateTimeKind.Unspecified).AddTicks(8013), 1L, 4L, false },
                    { 8L, 18L, 0, new DateTime(2022, 1, 20, 13, 33, 47, 790, DateTimeKind.Unspecified).AddTicks(9417), 5L, 35L, false },
                    { 16L, 18L, 0, new DateTime(2021, 8, 20, 3, 34, 58, 940, DateTimeKind.Unspecified).AddTicks(7838), 5L, 28L, false },
                    { 19L, 18L, 0, new DateTime(2021, 11, 22, 16, 17, 22, 215, DateTimeKind.Unspecified).AddTicks(8052), 2L, 16L, false },
                    { 4L, 19L, 0, new DateTime(2021, 8, 7, 23, 29, 48, 809, DateTimeKind.Unspecified).AddTicks(7024), 3L, 14L, false },
                    { 20L, 20L, 0, new DateTime(2021, 5, 19, 9, 44, 31, 938, DateTimeKind.Unspecified).AddTicks(6517), 2L, 33L, false },
                    { 20L, 22L, 0, new DateTime(2021, 12, 26, 3, 59, 35, 399, DateTimeKind.Unspecified).AddTicks(8451), 2L, 25L, false },
                    { 21L, 22L, 0, new DateTime(2021, 7, 12, 19, 40, 55, 116, DateTimeKind.Unspecified).AddTicks(6164), 2L, 5L, false },
                    { 17L, 24L, 0, new DateTime(2021, 8, 18, 9, 50, 35, 137, DateTimeKind.Unspecified).AddTicks(1647), 3L, 6L, false },
                    { 20L, 24L, 0, new DateTime(2021, 12, 2, 12, 45, 7, 339, DateTimeKind.Unspecified).AddTicks(9936), 3L, 43L, false },
                    { 11L, 25L, 0, new DateTime(2021, 9, 6, 13, 25, 50, 369, DateTimeKind.Unspecified).AddTicks(5519), 4L, 30L, false },
                    { 3L, 26L, 0, new DateTime(2021, 6, 22, 6, 9, 8, 797, DateTimeKind.Unspecified).AddTicks(1945), 3L, 9L, false },
                    { 14L, 26L, 0, new DateTime(2021, 2, 16, 10, 44, 44, 139, DateTimeKind.Unspecified).AddTicks(7004), 4L, 31L, false },
                    { 16L, 26L, 0, new DateTime(2021, 11, 28, 19, 13, 2, 676, DateTimeKind.Unspecified).AddTicks(5621), 4L, 44L, false },
                    { 21L, 28L, 0, new DateTime(2021, 3, 10, 1, 24, 52, 962, DateTimeKind.Unspecified).AddTicks(8426), 3L, 15L, false },
                    { 4L, 31L, 0, new DateTime(2021, 5, 19, 5, 10, 24, 60, DateTimeKind.Unspecified).AddTicks(2461), 4L, 19L, false }
                });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "CourseId", "UserId", "CourseRole", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 7L, 31L, 0, new DateTime(2021, 3, 19, 7, 41, 55, 577, DateTimeKind.Unspecified).AddTicks(3024), 1L, 49L, false },
                    { 11L, 31L, 0, new DateTime(2021, 4, 2, 12, 30, 50, 306, DateTimeKind.Unspecified).AddTicks(5408), 2L, 8L, false },
                    { 16L, 31L, 0, new DateTime(2021, 4, 29, 3, 53, 11, 424, DateTimeKind.Unspecified).AddTicks(3376), 4L, 45L, false },
                    { 2L, 32L, 0, new DateTime(2021, 9, 29, 15, 56, 4, 706, DateTimeKind.Unspecified).AddTicks(8619), 4L, 56L, false },
                    { 11L, 32L, 0, new DateTime(2021, 12, 26, 12, 30, 32, 369, DateTimeKind.Unspecified).AddTicks(9654), 4L, 70L, false },
                    { 14L, 32L, 0, new DateTime(2021, 4, 21, 14, 2, 17, 597, DateTimeKind.Unspecified).AddTicks(9227), 1L, 29L, false },
                    { 17L, 32L, 0, new DateTime(2021, 12, 29, 7, 40, 52, 112, DateTimeKind.Unspecified).AddTicks(5490), 2L, 10L, false },
                    { 3L, 33L, 0, new DateTime(2021, 3, 24, 18, 47, 16, 239, DateTimeKind.Unspecified).AddTicks(6868), 2L, 20L, false },
                    { 4L, 34L, 0, new DateTime(2022, 1, 4, 14, 9, 27, 298, DateTimeKind.Unspecified).AddTicks(4286), 1L, 48L, false },
                    { 6L, 34L, 0, new DateTime(2021, 8, 3, 8, 31, 20, 83, DateTimeKind.Unspecified).AddTicks(2921), 4L, 66L, false },
                    { 8L, 35L, 0, new DateTime(2021, 3, 31, 4, 38, 21, 637, DateTimeKind.Unspecified).AddTicks(6812), 3L, 64L, false },
                    { 7L, 36L, 0, new DateTime(2021, 8, 1, 4, 29, 22, 482, DateTimeKind.Unspecified).AddTicks(4480), 5L, 3L, false },
                    { 7L, 37L, 0, new DateTime(2021, 12, 12, 18, 33, 47, 851, DateTimeKind.Unspecified).AddTicks(5546), 1L, 34L, false },
                    { 15L, 37L, 0, new DateTime(2022, 1, 10, 4, 4, 38, 6, DateTimeKind.Unspecified).AddTicks(5322), 4L, 63L, false },
                    { 17L, 37L, 0, new DateTime(2021, 2, 10, 11, 8, 33, 631, DateTimeKind.Unspecified).AddTicks(5249), 4L, 58L, false },
                    { 8L, 38L, 0, new DateTime(2021, 3, 21, 10, 45, 0, 605, DateTimeKind.Unspecified).AddTicks(2719), 1L, 36L, false },
                    { 16L, 40L, 0, new DateTime(2021, 8, 16, 13, 6, 6, 364, DateTimeKind.Unspecified).AddTicks(1851), 1L, 11L, false },
                    { 12L, 42L, 0, new DateTime(2021, 3, 18, 6, 1, 50, 575, DateTimeKind.Unspecified).AddTicks(5520), 3L, 21L, false },
                    { 21L, 43L, 0, new DateTime(2022, 1, 24, 14, 17, 46, 65, DateTimeKind.Unspecified).AddTicks(5887), 3L, 71L, false },
                    { 15L, 45L, 0, new DateTime(2021, 8, 14, 17, 31, 37, 910, DateTimeKind.Unspecified).AddTicks(59), 2L, 51L, false },
                    { 4L, 46L, 0, new DateTime(2021, 11, 16, 21, 8, 21, 868, DateTimeKind.Unspecified).AddTicks(5263), 3L, 61L, false },
                    { 19L, 50L, 0, new DateTime(2021, 12, 8, 17, 5, 52, 178, DateTimeKind.Unspecified).AddTicks(152), 4L, 65L, false }
                });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 16L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 5, 3, 9, 52, 26, 332, DateTimeKind.Unspecified).AddTicks(6590), 58L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 20L, 17L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 7, 24, 14, 3, 2, 4, DateTimeKind.Unspecified).AddTicks(7227), 73L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 42L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 11, 19, 15, 0, 24, 613, DateTimeKind.Unspecified).AddTicks(480), 77L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 44L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2022, 1, 7, 8, 40, 38, 688, DateTimeKind.Unspecified).AddTicks(8322), 1L, 92L });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 19L, new DateTime(2022, 1, 14, 1, 18, 38, 482, DateTimeKind.Unspecified).AddTicks(734), 4L, 98L, false },
                    { 2L, 27L, new DateTime(2021, 12, 25, 7, 11, 56, 794, DateTimeKind.Unspecified).AddTicks(9842), 4L, 32L, false },
                    { 3L, 23L, new DateTime(2022, 1, 9, 13, 8, 30, 765, DateTimeKind.Unspecified).AddTicks(6550), 2L, 53L, false },
                    { 3L, 30L, new DateTime(2021, 12, 29, 4, 44, 43, 631, DateTimeKind.Unspecified).AddTicks(9481), 3L, 86L, false },
                    { 4L, 16L, new DateTime(2021, 2, 25, 1, 56, 20, 275, DateTimeKind.Unspecified).AddTicks(5195), 2L, 74L, false },
                    { 5L, 41L, new DateTime(2021, 9, 4, 0, 39, 11, 259, DateTimeKind.Unspecified).AddTicks(9092), 4L, 19L, false },
                    { 6L, 2L, new DateTime(2021, 9, 12, 14, 13, 24, 343, DateTimeKind.Unspecified).AddTicks(5320), 4L, 60L, false },
                    { 6L, 7L, new DateTime(2021, 6, 28, 13, 39, 23, 716, DateTimeKind.Unspecified).AddTicks(3779), 2L, 44L, false },
                    { 6L, 31L, new DateTime(2022, 1, 2, 19, 42, 47, 951, DateTimeKind.Unspecified).AddTicks(7316), 4L, 25L, false },
                    { 7L, 13L, new DateTime(2021, 5, 12, 16, 56, 24, 241, DateTimeKind.Unspecified).AddTicks(2443), 2L, 14L, false },
                    { 7L, 43L, new DateTime(2021, 10, 7, 17, 12, 18, 574, DateTimeKind.Unspecified).AddTicks(3906), 3L, 59L, false },
                    { 9L, 16L, new DateTime(2021, 6, 6, 4, 10, 32, 715, DateTimeKind.Unspecified).AddTicks(5720), 4L, 87L, false },
                    { 10L, 7L, new DateTime(2021, 11, 30, 19, 11, 13, 761, DateTimeKind.Unspecified).AddTicks(8843), 4L, 70L, false },
                    { 10L, 8L, new DateTime(2021, 6, 24, 12, 13, 7, 813, DateTimeKind.Unspecified).AddTicks(3696), 5L, 42L, false },
                    { 10L, 17L, new DateTime(2021, 11, 7, 6, 53, 41, 938, DateTimeKind.Unspecified).AddTicks(5605), 3L, 7L, false },
                    { 11L, 6L, new DateTime(2021, 3, 5, 4, 9, 21, 569, DateTimeKind.Unspecified).AddTicks(5487), 4L, 18L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 11L, 8L, new DateTime(2021, 12, 25, 5, 40, 13, 834, DateTimeKind.Unspecified).AddTicks(8883), 5L, 2L, false },
                    { 12L, 3L, new DateTime(2022, 1, 30, 17, 44, 31, 548, DateTimeKind.Unspecified).AddTicks(148), 1L, 78L, false },
                    { 12L, 22L, new DateTime(2021, 6, 10, 13, 31, 40, 829, DateTimeKind.Unspecified).AddTicks(5703), 3L, 62L, false },
                    { 13L, 7L, new DateTime(2021, 7, 10, 21, 6, 3, 821, DateTimeKind.Unspecified).AddTicks(3169), 2L, 52L, false },
                    { 13L, 44L, new DateTime(2021, 11, 23, 6, 24, 36, 20, DateTimeKind.Unspecified).AddTicks(9727), 3L, 89L, false },
                    { 13L, 48L, new DateTime(2021, 12, 18, 0, 14, 10, 585, DateTimeKind.Unspecified).AddTicks(4894), 4L, 49L, false },
                    { 14L, 28L, new DateTime(2021, 3, 8, 9, 48, 26, 952, DateTimeKind.Unspecified).AddTicks(4244), 1L, 50L, false },
                    { 15L, 23L, new DateTime(2021, 2, 20, 8, 55, 35, 874, DateTimeKind.Unspecified).AddTicks(5516), 3L, 30L, false },
                    { 16L, 5L, new DateTime(2021, 9, 30, 23, 34, 1, 695, DateTimeKind.Unspecified).AddTicks(5568), 3L, 94L, false },
                    { 16L, 22L, new DateTime(2021, 10, 5, 11, 58, 18, 327, DateTimeKind.Unspecified).AddTicks(9101), 1L, 35L, false },
                    { 16L, 42L, new DateTime(2022, 1, 18, 10, 29, 40, 894, DateTimeKind.Unspecified).AddTicks(6696), 3L, 96L, false },
                    { 16L, 47L, new DateTime(2022, 1, 30, 21, 19, 51, 68, DateTimeKind.Unspecified).AddTicks(1680), 1L, 54L, false },
                    { 16L, 50L, new DateTime(2021, 8, 31, 8, 58, 16, 536, DateTimeKind.Unspecified).AddTicks(9673), 4L, 3L, false },
                    { 17L, 7L, new DateTime(2022, 1, 24, 20, 9, 56, 697, DateTimeKind.Unspecified).AddTicks(5148), 2L, 56L, false },
                    { 18L, 28L, new DateTime(2021, 12, 29, 17, 28, 25, 737, DateTimeKind.Unspecified).AddTicks(4815), 1L, 12L, false },
                    { 18L, 33L, new DateTime(2021, 5, 8, 4, 48, 51, 687, DateTimeKind.Unspecified).AddTicks(5330), 4L, 85L, false },
                    { 18L, 36L, new DateTime(2021, 6, 29, 16, 43, 14, 471, DateTimeKind.Unspecified).AddTicks(3977), 2L, 69L, false },
                    { 18L, 49L, new DateTime(2021, 12, 9, 3, 46, 35, 522, DateTimeKind.Unspecified).AddTicks(9241), 4L, 27L, false },
                    { 19L, 2L, new DateTime(2021, 10, 4, 21, 9, 49, 746, DateTimeKind.Unspecified).AddTicks(5852), 2L, 66L, false },
                    { 20L, 29L, new DateTime(2021, 4, 8, 19, 22, 52, 999, DateTimeKind.Unspecified).AddTicks(9748), 1L, 99L, false },
                    { 21L, 21L, new DateTime(2021, 3, 20, 12, 53, 34, 227, DateTimeKind.Unspecified).AddTicks(7695), 2L, 57L, false },
                    { 21L, 28L, new DateTime(2021, 11, 22, 19, 7, 1, 835, DateTimeKind.Unspecified).AddTicks(1074), 5L, 64L, false },
                    { 22L, 7L, new DateTime(2021, 12, 20, 9, 7, 29, 337, DateTimeKind.Unspecified).AddTicks(3487), 1L, 21L, false },
                    { 22L, 19L, new DateTime(2021, 8, 16, 18, 52, 19, 61, DateTimeKind.Unspecified).AddTicks(6212), 1L, 95L, false },
                    { 22L, 44L, new DateTime(2021, 11, 18, 9, 59, 52, 592, DateTimeKind.Unspecified).AddTicks(4394), 5L, 5L, false },
                    { 23L, 34L, new DateTime(2021, 3, 17, 11, 49, 45, 67, DateTimeKind.Unspecified).AddTicks(7286), 5L, 22L, false },
                    { 23L, 49L, new DateTime(2021, 11, 7, 5, 25, 17, 623, DateTimeKind.Unspecified).AddTicks(7361), 2L, 83L, false },
                    { 24L, 6L, new DateTime(2021, 10, 24, 13, 47, 27, 704, DateTimeKind.Unspecified).AddTicks(567), 1L, 37L, false },
                    { 24L, 7L, new DateTime(2021, 2, 16, 20, 56, 58, 492, DateTimeKind.Unspecified).AddTicks(677), 5L, 15L, false },
                    { 24L, 18L, new DateTime(2021, 6, 13, 15, 22, 16, 781, DateTimeKind.Unspecified).AddTicks(671), 4L, 55L, false },
                    { 24L, 20L, new DateTime(2021, 12, 21, 14, 38, 52, 428, DateTimeKind.Unspecified).AddTicks(7869), 3L, 17L, false },
                    { 25L, 32L, new DateTime(2021, 6, 12, 22, 30, 23, 79, DateTimeKind.Unspecified).AddTicks(3734), 5L, 82L, false },
                    { 25L, 51L, new DateTime(2021, 4, 26, 11, 57, 0, 1, DateTimeKind.Unspecified).AddTicks(3987), 4L, 9L, false },
                    { 26L, 10L, new DateTime(2021, 5, 15, 7, 31, 40, 404, DateTimeKind.Unspecified).AddTicks(8593), 5L, 65L, false },
                    { 26L, 32L, new DateTime(2021, 6, 17, 11, 2, 30, 530, DateTimeKind.Unspecified).AddTicks(5371), 1L, 47L, false },
                    { 27L, 15L, new DateTime(2021, 11, 19, 16, 53, 40, 933, DateTimeKind.Unspecified).AddTicks(4597), 2L, 61L, false },
                    { 28L, 27L, new DateTime(2021, 11, 27, 13, 3, 50, 209, DateTimeKind.Unspecified).AddTicks(3814), 3L, 51L, false },
                    { 28L, 44L, new DateTime(2021, 3, 22, 15, 3, 5, 745, DateTimeKind.Unspecified).AddTicks(9097), 2L, 46L, false },
                    { 29L, 42L, new DateTime(2021, 8, 2, 5, 56, 7, 43, DateTimeKind.Unspecified).AddTicks(7599), 4L, 71L, false },
                    { 30L, 15L, new DateTime(2021, 10, 2, 6, 35, 1, 367, DateTimeKind.Unspecified).AddTicks(1687), 4L, 90L, false },
                    { 30L, 24L, new DateTime(2021, 12, 30, 7, 38, 6, 320, DateTimeKind.Unspecified).AddTicks(1672), 1L, 31L, false },
                    { 31L, 5L, new DateTime(2021, 8, 8, 2, 19, 59, 370, DateTimeKind.Unspecified).AddTicks(4984), 2L, 13L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 31L, 28L, new DateTime(2021, 10, 4, 23, 31, 39, 465, DateTimeKind.Unspecified).AddTicks(669), 2L, 41L, false },
                    { 31L, 50L, new DateTime(2021, 4, 14, 22, 56, 9, 590, DateTimeKind.Unspecified).AddTicks(5191), 2L, 67L, false },
                    { 32L, 36L, new DateTime(2022, 1, 5, 0, 57, 5, 923, DateTimeKind.Unspecified).AddTicks(1211), 2L, 16L, false },
                    { 33L, 45L, new DateTime(2021, 8, 18, 4, 41, 39, 816, DateTimeKind.Unspecified).AddTicks(6506), 5L, 79L, false },
                    { 34L, 35L, new DateTime(2021, 10, 3, 23, 16, 22, 143, DateTimeKind.Unspecified).AddTicks(6289), 4L, 39L, false },
                    { 34L, 40L, new DateTime(2021, 12, 12, 3, 9, 31, 281, DateTimeKind.Unspecified).AddTicks(4771), 5L, 43L, false },
                    { 35L, 7L, new DateTime(2021, 4, 13, 22, 50, 8, 863, DateTimeKind.Unspecified).AddTicks(5276), 2L, 24L, false },
                    { 39L, 14L, new DateTime(2021, 8, 10, 8, 7, 10, 269, DateTimeKind.Unspecified).AddTicks(6305), 2L, 48L, false },
                    { 39L, 32L, new DateTime(2021, 6, 28, 2, 40, 51, 751, DateTimeKind.Unspecified).AddTicks(8372), 2L, 91L, false },
                    { 39L, 38L, new DateTime(2021, 11, 7, 4, 56, 54, 182, DateTimeKind.Unspecified).AddTicks(1601), 5L, 68L, false },
                    { 40L, 33L, new DateTime(2021, 2, 4, 13, 54, 55, 575, DateTimeKind.Unspecified).AddTicks(4558), 1L, 80L, false },
                    { 40L, 50L, new DateTime(2021, 9, 11, 18, 54, 13, 886, DateTimeKind.Unspecified).AddTicks(3052), 5L, 76L, false },
                    { 41L, 9L, new DateTime(2022, 1, 1, 19, 56, 24, 117, DateTimeKind.Unspecified).AddTicks(5727), 4L, 63L, false },
                    { 41L, 20L, new DateTime(2021, 9, 27, 23, 41, 26, 176, DateTimeKind.Unspecified).AddTicks(9924), 3L, 81L, false },
                    { 41L, 31L, new DateTime(2021, 5, 12, 6, 25, 9, 503, DateTimeKind.Unspecified).AddTicks(1891), 5L, 4L, false },
                    { 41L, 48L, new DateTime(2022, 1, 17, 6, 56, 18, 544, DateTimeKind.Unspecified).AddTicks(5508), 1L, 84L, false },
                    { 43L, 40L, new DateTime(2021, 8, 25, 17, 46, 23, 740, DateTimeKind.Unspecified).AddTicks(5667), 2L, 100L, false },
                    { 44L, 26L, new DateTime(2021, 10, 27, 3, 21, 7, 394, DateTimeKind.Unspecified).AddTicks(4589), 5L, 29L, false },
                    { 44L, 38L, new DateTime(2021, 12, 7, 1, 10, 52, 552, DateTimeKind.Unspecified).AddTicks(8361), 3L, 36L, false },
                    { 44L, 51L, new DateTime(2022, 1, 6, 8, 33, 45, 580, DateTimeKind.Unspecified).AddTicks(1091), 1L, 45L, false },
                    { 45L, 13L, new DateTime(2021, 4, 9, 6, 42, 42, 53, DateTimeKind.Unspecified).AddTicks(7468), 2L, 75L, false },
                    { 45L, 16L, new DateTime(2021, 11, 24, 18, 42, 58, 427, DateTimeKind.Unspecified).AddTicks(1643), 1L, 34L, false },
                    { 45L, 23L, new DateTime(2021, 10, 17, 17, 52, 49, 347, DateTimeKind.Unspecified).AddTicks(9704), 5L, 93L, false },
                    { 46L, 7L, new DateTime(2021, 5, 24, 0, 31, 51, 112, DateTimeKind.Unspecified).AddTicks(8697), 2L, 97L, false },
                    { 46L, 37L, new DateTime(2021, 11, 13, 8, 17, 42, 111, DateTimeKind.Unspecified).AddTicks(9087), 5L, 8L, false },
                    { 46L, 42L, new DateTime(2021, 2, 13, 7, 34, 57, 428, DateTimeKind.Unspecified).AddTicks(112), 5L, 20L, false },
                    { 47L, 8L, new DateTime(2021, 8, 12, 9, 44, 52, 505, DateTimeKind.Unspecified).AddTicks(2270), 2L, 88L, false },
                    { 48L, 6L, new DateTime(2021, 3, 2, 12, 19, 55, 763, DateTimeKind.Unspecified).AddTicks(6012), 4L, 10L, false },
                    { 48L, 46L, new DateTime(2021, 3, 18, 6, 44, 55, 357, DateTimeKind.Unspecified).AddTicks(7512), 1L, 26L, false },
                    { 48L, 47L, new DateTime(2021, 2, 23, 21, 6, 11, 196, DateTimeKind.Unspecified).AddTicks(6138), 2L, 40L, false },
                    { 49L, 17L, new DateTime(2021, 11, 13, 7, 29, 50, 838, DateTimeKind.Unspecified).AddTicks(2035), 5L, 28L, false },
                    { 50L, 17L, new DateTime(2021, 8, 21, 15, 48, 58, 718, DateTimeKind.Unspecified).AddTicks(7478), 2L, 72L, false },
                    { 50L, 43L, new DateTime(2021, 10, 8, 0, 50, 57, 60, DateTimeKind.Unspecified).AddTicks(8287), 2L, 38L, false },
                    { 51L, 7L, new DateTime(2021, 6, 14, 22, 29, 4, 650, DateTimeKind.Unspecified).AddTicks(9515), 4L, 23L, false },
                    { 51L, 22L, new DateTime(2021, 8, 8, 0, 12, 40, 830, DateTimeKind.Unspecified).AddTicks(5547), 5L, 6L, false },
                    { 51L, 43L, new DateTime(2021, 5, 10, 7, 36, 44, 771, DateTimeKind.Unspecified).AddTicks(1426), 5L, 33L, false }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 24, 18, 52, 9, 721, DateTimeKind.Unspecified).AddTicks(3781), 5L, "Omnis voluptatem vel quas non libero.\nNobis amet nostrum qui inventore perferendis reiciendis cumque beatae.", 40L, "Vel voluptatem temporibus ducimus iste quibusdam voluptatibus quisquam voluptatem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 14, 2, 57, 22, 932, DateTimeKind.Unspecified).AddTicks(6614), "Ea culpa dicta cum quo.", 30L, "Harum voluptatem quam reprehenderit velit et ut dolor." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 13, 4, 32, 10, 317, DateTimeKind.Unspecified).AddTicks(236), 1L, "A enim odit omnis consequuntur fugiat qui fugit.\nId animi quas voluptatem perferendis quod deleniti molestiae ullam.\nCumque eligendi qui voluptates ut vitae eum omnis sit.\nHarum deserunt velit praesentium.", 18L, "Animi aut iste labore voluptatem omnis rem vero." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 7, 23, 28, 49, 544, DateTimeKind.Unspecified).AddTicks(1619), 2L, "Explicabo repellendus perspiciatis et.\nPariatur ipsum asperiores voluptatem accusantium error commodi similique eligendi.", true, 5L, "Unde alias maiores qui similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 13, 12, 0, 24, 212, DateTimeKind.Unspecified).AddTicks(4416), 5L, "Consequatur et facere vero quo et dolorem.\nEa maiores quae numquam soluta ut dolor.\nEsse odio quam possimus assumenda et.\nDolore non est totam in aliquid hic.", true, 12L, "Aut amet quae in." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 23, 0, 59, 37, 299, DateTimeKind.Unspecified).AddTicks(5280), 3L, "Provident quidem iure officia assumenda id sequi recusandae quo.\nRepellat quas molestiae.", 40L, "Ut quam eos nemo repellendus id vel neque impedit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 6, 5, 9, 25, 836, DateTimeKind.Unspecified).AddTicks(3816), 1L, "Dolores quidem voluptatem tenetur quod.", 51L, "Itaque quo ea temporibus similique unde." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 2, 0, 30, 15, 21, DateTimeKind.Unspecified).AddTicks(955), 4L, "Commodi perferendis nemo dolorum.\nAssumenda esse dolores quod quasi voluptas qui quos.\nSint repudiandae aut ex sunt excepturi.\nCumque earum quam molestiae minima quos repellendus odio id.\nEnim sunt quasi assumenda fuga quo suscipit aperiam eos culpa.", false, 26L, "Aut voluptas dolor dignissimos illo et illo soluta ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 23, 22, 17, 2, 787, DateTimeKind.Unspecified).AddTicks(7573), 3L, "Ratione in ex distinctio architecto.", 11L, "Est ut sed aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 3, 15, 44, 47, 482, DateTimeKind.Unspecified).AddTicks(6129), "Quia tenetur non veniam sed dolor dolore.", true, 31L, "Inventore consequatur sit provident quos quam cumque saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 8, 22, 14, 373, DateTimeKind.Unspecified).AddTicks(7594), "Qui id eos hic sint quos in rerum est.\nEnim facilis consequatur fuga alias.\nRem quasi blanditiis saepe.", 49L, "Error error neque est porro aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 15, 7, 3, 22, 371, DateTimeKind.Unspecified).AddTicks(9042), 3L, "Quis ea quisquam sunt voluptatibus.\nImpedit animi est natus quia magnam id dolorum earum.\nUt eius facilis et expedita amet sed.", 7L, "Et odio dolorum consequatur et nihil." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 28, 21, 43, 18, 248, DateTimeKind.Unspecified).AddTicks(9890), 5L, "Corporis iusto eius minima aut corrupti nemo placeat.\nDoloremque eum sint quas dolor.\nEt illo qui.", false, 4L, "A enim necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 21, 51, 40, 110, DateTimeKind.Unspecified).AddTicks(1577), 4L, "Rerum laboriosam libero omnis sunt ullam sit quisquam.\nAccusamus qui laboriosam et commodi.\nIllum dolore animi repellendus.\nOmnis ut debitis nemo quas quod dolorum magnam perferendis quia.\nQuasi molestiae sunt.", false, 36L, "Sed a maiores esse." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 2, 3, 10, 51, 408, DateTimeKind.Unspecified).AddTicks(2202), 3L, "Eum harum alias aut quod praesentium commodi aliquam.\nSoluta non nihil sapiente facere distinctio repudiandae vel quo.", true, 7L, "Deleniti eum omnis est non pariatur quisquam doloremque voluptatem doloremque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 7, 13, 46, 50, 192, DateTimeKind.Unspecified).AddTicks(5321), 2L, "Corporis eius et laborum minus odio nihil maiores.\nIncidunt aliquid dolores aut quibusdam eveniet quasi consequatur est consectetur.\nNumquam id similique veniam numquam quo quia tenetur voluptas.\nAut et rem sed vel quo beatae.", true, 2L, "Ab omnis magni aliquid blanditiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 13, 6, 55, 38, 674, DateTimeKind.Unspecified).AddTicks(1978), 2L, "Reiciendis quos cumque et ut.\nVoluptatem fugit rem distinctio corporis sed.\nAccusantium voluptatibus quam sit asperiores praesentium.", 50L, "Et ut placeat repellat similique molestias sequi nihil quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 25, 13, 20, 39, 493, DateTimeKind.Unspecified).AddTicks(1451), 4L, "Et cum inventore qui hic repellat.\nSit ipsum et.\nCorporis aut officia.\nUt quo eos.", false, 16L, "Sit provident numquam qui illum quibusdam fuga quis sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 1, 5, 802, DateTimeKind.Unspecified).AddTicks(9842), 1L, "Quod quia voluptatem molestias facere.\nUllam eius corporis eius incidunt et omnis est eum.\nNihil quo ut fugiat occaecati dolor quod sint assumenda sed.", false, 19L, "Voluptatem vel sit debitis ullam tempore aperiam sit qui consequatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 18, 10, 13, 19, 725, DateTimeKind.Unspecified).AddTicks(8611), "Ea rerum mollitia aut qui itaque.", true, 30L, "Quos dignissimos ut ut nulla ducimus ex." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 4, 8, 0, 56, 372, DateTimeKind.Unspecified).AddTicks(405), 4L, "Quasi a dicta qui est quod et voluptatem.\nMaiores laudantium et rerum molestiae voluptatum.\nAmet rerum suscipit fugiat autem tempora quas aut.\nExpedita accusantium placeat ea iure praesentium aspernatur dolorum iusto aliquid.", true, 42L, "Officiis laudantium eligendi fugiat sapiente eum ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 23, 12, 898, DateTimeKind.Unspecified).AddTicks(3916), 5L, "Maxime perferendis et voluptas voluptas blanditiis beatae itaque aperiam.", false, 4L, "Eos consequatur velit vero distinctio non incidunt ut eius." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 21, 3, 23, 19, 906, DateTimeKind.Unspecified).AddTicks(7557), "Eligendi temporibus doloremque facilis ut ex.\nCorrupti provident sed et porro dicta.", false, 31L, "Commodi ducimus quia sunt architecto fugiat esse." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 17, 11, 9, 18, 472, DateTimeKind.Unspecified).AddTicks(3600), 3L, "Ut qui commodi.", true, 27L, "Fugiat vel magni sunt sunt quia sit exercitationem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 1, 12, 22, 56, 128, DateTimeKind.Unspecified).AddTicks(1832), 3L, "Tempora occaecati quo autem consequatur minima minus.\nInventore consequuntur aut qui nulla ea id.\nQui ipsam ab ad in sint iure voluptas.", true, 12L, "Consequatur consequatur qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 19, 2, 17, 24, 400, DateTimeKind.Unspecified).AddTicks(5885), 2L, "Occaecati perferendis aliquid velit voluptates sit aliquam omnis libero.\nId ex maiores quos.", false, 17L, "Cumque eos asperiores magnam est et similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 7, 42, 945, DateTimeKind.Unspecified).AddTicks(6116), 5L, "Ea maiores fugit.\nArchitecto blanditiis eaque voluptatem doloribus.", 3L, "Accusamus sed est quisquam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 1, 0, 59, 15, 148, DateTimeKind.Unspecified).AddTicks(2098), 4L, "Voluptatem earum error adipisci odio molestias porro repudiandae.\nQuia nisi omnis doloremque qui.\nMollitia nihil similique eaque repellat optio.\nIure modi aut omnis quis quidem beatae voluptatem.", true, 45L, "Quis qui deleniti provident in ut consectetur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 4, 9, 17, 20, 29, 794, DateTimeKind.Unspecified).AddTicks(2974), 4L, "Laboriosam dignissimos eaque.\nEligendi suscipit voluptatem porro hic cum iste laboriosam sunt cum.\nBeatae quo aut quibusdam.\nVoluptates est nisi ab vitae dignissimos.", false, 13L, "Reprehenderit excepturi voluptatem mollitia consequatur ad aut quod et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 12, 2, 15, 53, 75, DateTimeKind.Unspecified).AddTicks(8374), 2L, "Sed quo ipsum ipsum et officia.\nIpsa voluptas alias dolor.\nEst aspernatur maiores at.\nCommodi molestiae doloribus dolores.\nUt omnis ipsa aliquam vel deleniti eligendi ut aut.", false, 51L, "Qui culpa ab quam voluptas animi qui et doloribus qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 19, 15, 6, 14, 985, DateTimeKind.Unspecified).AddTicks(7202), 2L, "Eos culpa ea et assumenda quod laborum nostrum vel.\nEt itaque aliquam ut accusamus velit magni nam.\nQuo aliquid quam adipisci.", 10L, "Voluptates enim quae rerum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 28, 21, 11, 0, 808, DateTimeKind.Unspecified).AddTicks(4408), "Quidem accusamus ea delectus dolor recusandae.", 4L, "Earum reiciendis voluptatem quis praesentium ea quidem iure ex." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 13, 10, 4, 54, 66, DateTimeKind.Unspecified).AddTicks(8454), 1L, "Quod quam accusamus quo aliquid ea nemo sint deleniti eveniet.\nDeleniti inventore asperiores sit sunt nulla rerum qui.", true, 27L, "Qui vel et illum nihil porro." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 12, 12, 45, 20, 284, DateTimeKind.Unspecified).AddTicks(393), 5L, "Assumenda doloremque illo.\nOfficiis quam error ratione ipsum et odio.", true, 11L, "Molestiae dignissimos quo itaque vero facilis itaque sint consequatur reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 14, 18, 29, 32, 451, DateTimeKind.Unspecified).AddTicks(8937), 4L, "Similique quis distinctio fugiat sapiente temporibus voluptatum nam id sed.\nIllum saepe rerum qui dicta iste nesciunt dolorem natus.\nEst id repellat.", false, 24L, "Ut consequatur praesentium dolorum fugit officiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 5, 0, 27, 5, 721, DateTimeKind.Unspecified).AddTicks(3779), "Omnis perspiciatis vitae illo sequi qui.\nModi quis veritatis a quae pariatur.", 45L, "Est hic eveniet et ratione repellat et possimus qui amet." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 8, 4, 40, 46, 524, DateTimeKind.Unspecified).AddTicks(8857), 1L, "Et velit maxime rerum.\nVoluptas eum aut dignissimos dolorem tempora ratione expedita.\nSint debitis ut velit natus impedit doloribus pariatur assumenda et.\nEt explicabo error.\nEt iste quae impedit voluptates ratione tenetur voluptas.", true, 31L, "Et eos quo qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 8, 23, 1, 37, 68, DateTimeKind.Unspecified).AddTicks(8878), 4L, "Dolor inventore et.", 40L, "Animi soluta cum qui reiciendis porro facilis fuga accusamus molestiae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 8, 11, 52, 38, 75, DateTimeKind.Unspecified).AddTicks(6014), "Error aperiam assumenda eum sint rem consequatur magnam dicta.\nReprehenderit necessitatibus autem sint veritatis quis magni.\nOfficia minus sunt cupiditate laboriosam id aut vel aut optio.\nEt et exercitationem ut sint vitae.", false, 7L, "Quis sed laborum dolor iusto." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 7, 22, 19, 9, 35, 433, DateTimeKind.Unspecified).AddTicks(1880), 2L, "Atque ullam pariatur perferendis impedit eaque optio doloremque voluptatem.\nEt enim pariatur sit et aspernatur et blanditiis.", 25L, "Ipsum aut nisi recusandae quis necessitatibus vero nisi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 34, 20, 696, DateTimeKind.Unspecified).AddTicks(4680), 3L, "Sint a et rem similique.\nVelit ducimus modi non quae saepe quasi.\nHic voluptatem eos a quia accusamus ad.", 21L, "Itaque natus veniam sit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 18, 14, 10, 11, 519, DateTimeKind.Unspecified).AddTicks(6331), 4L, "Placeat officiis quo.\nIusto et est et dolore.\nIn velit a ad repellendus optio voluptas vero sed.\nNobis iste sed.", false, 2L, "Tenetur architecto repudiandae qui molestiae vero nostrum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 2, 1, 48, 37, 773, DateTimeKind.Unspecified).AddTicks(5419), 1L, "Cum necessitatibus consequatur.\nEt voluptatem quisquam dolor commodi asperiores et.", 39L, "Assumenda dolor consectetur animi voluptate totam sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 1, 6, 4, 23, 838, DateTimeKind.Unspecified).AddTicks(1687), 2L, "Animi reiciendis temporibus quos quasi molestias.\nEst delectus non totam rerum ea in ut.\nQuidem quia voluptate sit soluta consectetur nulla fugiat.\nPerferendis cupiditate ut.", true, 6L, "Sunt nihil consectetur facere quia enim aut quod sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 15, 12, 47, 25, 481, DateTimeKind.Unspecified).AddTicks(4693), 2L, "Et beatae qui aperiam tempora aut sed repellendus.\nCulpa fuga dolorem esse impedit.\nDolor voluptate magni a ducimus inventore voluptatibus est.", 46L, "Nobis quia velit sunt." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 18, 1, 53, 31, 265, DateTimeKind.Unspecified).AddTicks(2110), 5L, "Et qui molestias tempora.\nVoluptatem dolor sint nulla.", false, 26L, "Quisquam minima laboriosam architecto eos deserunt temporibus itaque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 2, 20, 44, 11, 3, DateTimeKind.Unspecified).AddTicks(8545), "Quia voluptatem sapiente qui autem.\nArchitecto et omnis.\nDolorem et impedit.\nMagnam excepturi tempora earum eum consequatur qui.", 50L, "Et illo tempore." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 9, 22, 6, 57, 527, DateTimeKind.Unspecified).AddTicks(287), 1L, "Quidem accusantium consequatur expedita.\nPorro neque aspernatur beatae tempora necessitatibus voluptatem.\nRepellendus ex praesentium iste iure fugit voluptas dolorem pariatur.\nAmet ut aut sed magnam quas ut explicabo.\nUt assumenda quasi cupiditate et vero quidem modi libero quo.", true, 13L, "Vel similique enim blanditiis vitae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 7, 2, 4, 35, 798, DateTimeKind.Unspecified).AddTicks(8026), 3L, "Sit repellendus veniam.\nFugit et dolor voluptates deserunt odit dolores earum sed.\nQuo eum eius.\nPlaceat necessitatibus quia aut voluptatum molestias aut qui.\nVeritatis autem in aliquam accusantium aut qui odio.", 14L, "Rem praesentium odit porro et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 21, 15, 46, 47, 190, DateTimeKind.Unspecified).AddTicks(304), "Magni minima consectetur.\nEt necessitatibus sit voluptatem vitae et eius nemo est.", 50L, "Quae possimus sed." });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 6, 18, 18, 2, 6, 115, DateTimeKind.Unspecified).AddTicks(2987), 3L, new DateTime(2022, 1, 11, 0, 16, 21, 524, DateTimeKind.Unspecified).AddTicks(1073), 6L, new DateTime(2019, 12, 26, 0, 48, 16, 135, DateTimeKind.Unspecified).AddTicks(67), new DateTime(2021, 8, 17, 0, 31, 26, 347, DateTimeKind.Unspecified).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 12, 15, 19, 0, 14, 671, DateTimeKind.Unspecified).AddTicks(1117), 3L, new DateTime(2022, 1, 19, 15, 11, 36, 370, DateTimeKind.Unspecified).AddTicks(162), 76L, new DateTime(2019, 6, 27, 6, 18, 15, 285, DateTimeKind.Unspecified).AddTicks(2787), new DateTime(2021, 9, 14, 16, 5, 33, 235, DateTimeKind.Unspecified).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 2, 16, 19, 21, 18, 426, DateTimeKind.Unspecified).AddTicks(4382), 3L, new DateTime(2022, 1, 18, 23, 16, 37, 27, DateTimeKind.Unspecified).AddTicks(5956), 59L, new DateTime(2019, 4, 28, 16, 0, 50, 883, DateTimeKind.Unspecified).AddTicks(607), new DateTime(2021, 8, 23, 2, 37, 17, 833, DateTimeKind.Unspecified).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 5, 22, 14, 15, 9, 915, DateTimeKind.Unspecified).AddTicks(3191), 2L, new DateTime(2022, 1, 8, 18, 0, 43, 155, DateTimeKind.Unspecified).AddTicks(9820), 42L, new DateTime(2019, 12, 11, 13, 36, 36, 444, DateTimeKind.Unspecified).AddTicks(201), new DateTime(2021, 12, 27, 20, 17, 40, 256, DateTimeKind.Unspecified).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2022, 1, 28, 2, 41, 0, 797, DateTimeKind.Unspecified).AddTicks(9358), 4L, new DateTime(2022, 1, 13, 16, 25, 9, 352, DateTimeKind.Unspecified).AddTicks(4791), 3L, new DateTime(2019, 5, 10, 9, 31, 42, 404, DateTimeKind.Unspecified).AddTicks(203), new DateTime(2021, 9, 13, 22, 53, 26, 31, DateTimeKind.Unspecified).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 5, 31, 8, 25, 45, 583, DateTimeKind.Unspecified).AddTicks(7182), 1L, new DateTime(2022, 1, 12, 21, 48, 21, 627, DateTimeKind.Unspecified).AddTicks(660), 45L, new DateTime(2019, 8, 18, 1, 52, 19, 111, DateTimeKind.Unspecified).AddTicks(7500), new DateTime(2021, 3, 11, 20, 25, 26, 211, DateTimeKind.Unspecified).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 21L, new DateTime(2021, 9, 15, 9, 46, 2, 353, DateTimeKind.Unspecified).AddTicks(4500), 1L, new DateTime(2022, 1, 11, 19, 6, 46, 6, DateTimeKind.Unspecified).AddTicks(6275), 67L, new DateTime(2020, 1, 23, 6, 53, 47, 199, DateTimeKind.Unspecified).AddTicks(2844), new DateTime(2021, 8, 1, 1, 33, 49, 717, DateTimeKind.Unspecified).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 12, 27, 5, 6, 53, 347, DateTimeKind.Unspecified).AddTicks(8906), 3L, new DateTime(2022, 1, 27, 18, 23, 22, 945, DateTimeKind.Unspecified).AddTicks(3079), new DateTime(2019, 12, 14, 5, 58, 49, 714, DateTimeKind.Unspecified).AddTicks(8551), new DateTime(2021, 5, 9, 23, 57, 53, 935, DateTimeKind.Unspecified).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 5, 4, 23, 3, 39, 632, DateTimeKind.Unspecified).AddTicks(5361), new DateTime(2022, 1, 30, 7, 34, 17, 768, DateTimeKind.Unspecified).AddTicks(7614), 28L, new DateTime(2019, 9, 14, 17, 12, 51, 224, DateTimeKind.Unspecified).AddTicks(4248), new DateTime(2021, 11, 19, 3, 3, 10, 385, DateTimeKind.Unspecified).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2021, 6, 28, 21, 14, 40, 106, DateTimeKind.Unspecified).AddTicks(5473), 5L, new DateTime(2022, 1, 8, 11, 44, 2, 619, DateTimeKind.Unspecified).AddTicks(528), 51L, new DateTime(2019, 3, 21, 13, 27, 18, 761, DateTimeKind.Unspecified).AddTicks(2673), new DateTime(2021, 7, 20, 1, 56, 10, 643, DateTimeKind.Unspecified).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 3, 3, 20, 1, 13, 761, DateTimeKind.Unspecified).AddTicks(8678), new DateTime(2022, 1, 15, 8, 30, 42, 917, DateTimeKind.Unspecified).AddTicks(2092), 12L, new DateTime(2019, 3, 23, 1, 41, 41, 976, DateTimeKind.Unspecified).AddTicks(6419), new DateTime(2021, 7, 26, 18, 7, 42, 831, DateTimeKind.Unspecified).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 9, 18, 7, 49, 58, 629, DateTimeKind.Unspecified).AddTicks(9631), 2L, new DateTime(2022, 2, 1, 17, 40, 23, 513, DateTimeKind.Unspecified).AddTicks(5926), 52L, new DateTime(2019, 7, 14, 9, 38, 49, 510, DateTimeKind.Unspecified).AddTicks(1328), new DateTime(2021, 1, 6, 2, 2, 58, 405, DateTimeKind.Unspecified).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 5, 23, 21, 31, 27, 8, DateTimeKind.Unspecified).AddTicks(8312), 1L, new DateTime(2022, 1, 16, 13, 42, 7, 686, DateTimeKind.Unspecified).AddTicks(780), 37L, new DateTime(2019, 5, 13, 10, 3, 53, 574, DateTimeKind.Unspecified).AddTicks(3551), new DateTime(2021, 4, 10, 1, 5, 22, 531, DateTimeKind.Unspecified).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 7, 27, 15, 9, 33, 82, DateTimeKind.Unspecified).AddTicks(6140), 1L, new DateTime(2022, 1, 11, 6, 55, 11, 280, DateTimeKind.Unspecified).AddTicks(1400), 38L, new DateTime(2019, 6, 15, 11, 31, 56, 202, DateTimeKind.Unspecified).AddTicks(8759), new DateTime(2021, 8, 4, 2, 33, 58, 145, DateTimeKind.Unspecified).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 10, 31, 7, 32, 50, 156, DateTimeKind.Unspecified).AddTicks(9252), new DateTime(2022, 1, 9, 23, 9, 7, 143, DateTimeKind.Unspecified).AddTicks(5339), 73L, new DateTime(2019, 7, 28, 13, 52, 38, 822, DateTimeKind.Unspecified).AddTicks(7073), new DateTime(2021, 3, 29, 4, 30, 7, 451, DateTimeKind.Unspecified).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 11, 5, 1, 8, 58, 977, DateTimeKind.Unspecified).AddTicks(691), 3L, new DateTime(2022, 1, 4, 21, 45, 54, 652, DateTimeKind.Unspecified).AddTicks(8481), 11L, new DateTime(2019, 7, 4, 21, 9, 49, 32, DateTimeKind.Unspecified).AddTicks(6080), new DateTime(2021, 12, 31, 5, 8, 2, 686, DateTimeKind.Unspecified).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 9, 1, 19, 49, 20, 960, DateTimeKind.Unspecified).AddTicks(9057), 5L, null, 49L, new DateTime(2019, 9, 29, 18, 55, 1, 684, DateTimeKind.Unspecified).AddTicks(2355), new DateTime(2021, 11, 10, 17, 55, 28, 503, DateTimeKind.Unspecified).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 12, 29, 13, 26, 32, 869, DateTimeKind.Unspecified).AddTicks(9048), 2L, new DateTime(2022, 1, 31, 4, 38, 30, 188, DateTimeKind.Unspecified).AddTicks(2685), 38L, new DateTime(2019, 9, 1, 19, 38, 0, 938, DateTimeKind.Unspecified).AddTicks(2410), new DateTime(2021, 10, 2, 15, 6, 47, 783, DateTimeKind.Unspecified).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2021, 4, 2, 18, 38, 28, 977, DateTimeKind.Unspecified).AddTicks(6903), 4L, new DateTime(2022, 1, 11, 2, 28, 55, 828, DateTimeKind.Unspecified).AddTicks(6631), 79L, new DateTime(2019, 2, 8, 23, 11, 42, 206, DateTimeKind.Unspecified).AddTicks(6639), new DateTime(2021, 6, 22, 14, 59, 38, 784, DateTimeKind.Unspecified).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 7, 27, 8, 41, 36, 650, DateTimeKind.Unspecified).AddTicks(145), 2L, new DateTime(2022, 1, 22, 1, 46, 3, 832, DateTimeKind.Unspecified).AddTicks(2726), 52L, new DateTime(2019, 10, 2, 22, 29, 24, 570, DateTimeKind.Unspecified).AddTicks(9802), new DateTime(2021, 3, 25, 22, 5, 14, 76, DateTimeKind.Unspecified).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 3, 3, 15, 58, 13, 151, DateTimeKind.Unspecified).AddTicks(9508), 2L, new DateTime(2022, 1, 17, 5, 28, 49, 683, DateTimeKind.Unspecified).AddTicks(8614), 78L, new DateTime(2020, 1, 24, 22, 35, 0, 817, DateTimeKind.Unspecified).AddTicks(2757), new DateTime(2021, 1, 29, 9, 34, 43, 266, DateTimeKind.Unspecified).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 12, 16, 13, 47, 8, 428, DateTimeKind.Unspecified).AddTicks(7237), 3L, new DateTime(2022, 1, 27, 7, 24, 19, 505, DateTimeKind.Unspecified).AddTicks(1383), 30L, new DateTime(2019, 10, 25, 23, 43, 57, 704, DateTimeKind.Unspecified).AddTicks(3943), new DateTime(2021, 11, 11, 1, 53, 59, 316, DateTimeKind.Unspecified).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 9, 16, 9, 26, 9, 970, DateTimeKind.Unspecified).AddTicks(1765), 5L, new DateTime(2022, 1, 18, 2, 12, 34, 800, DateTimeKind.Unspecified).AddTicks(9120), 52L, new DateTime(2019, 6, 5, 22, 26, 42, 67, DateTimeKind.Unspecified).AddTicks(537), new DateTime(2021, 1, 11, 2, 57, 5, 628, DateTimeKind.Unspecified).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 48L, new DateTime(2021, 4, 20, 9, 38, 12, 466, DateTimeKind.Unspecified).AddTicks(8816), 1L, new DateTime(2022, 1, 24, 19, 7, 28, 138, DateTimeKind.Unspecified).AddTicks(23), 28L, new DateTime(2019, 12, 19, 9, 52, 14, 122, DateTimeKind.Unspecified).AddTicks(7071), new DateTime(2021, 2, 15, 9, 26, 54, 733, DateTimeKind.Unspecified).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2022, 1, 23, 12, 32, 28, 315, DateTimeKind.Unspecified).AddTicks(3837), 3L, new DateTime(2022, 1, 18, 16, 16, 9, 838, DateTimeKind.Unspecified).AddTicks(5675), 51L, new DateTime(2019, 9, 10, 20, 34, 11, 100, DateTimeKind.Unspecified).AddTicks(2885), new DateTime(2021, 6, 4, 18, 8, 17, 234, DateTimeKind.Unspecified).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 5, 19, 50, 269, DateTimeKind.Unspecified).AddTicks(6878), 5L, new DateTime(2022, 1, 22, 11, 4, 12, 857, DateTimeKind.Unspecified).AddTicks(6426), 70L, new DateTime(2020, 1, 1, 23, 12, 28, 684, DateTimeKind.Unspecified).AddTicks(4243), new DateTime(2021, 5, 25, 21, 46, 57, 447, DateTimeKind.Unspecified).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 9, 10, 4, 26, 45, 827, DateTimeKind.Unspecified).AddTicks(916), 4L, new DateTime(2022, 2, 1, 2, 14, 34, 4, DateTimeKind.Unspecified).AddTicks(8521), 41L, new DateTime(2019, 4, 23, 12, 27, 41, 123, DateTimeKind.Unspecified).AddTicks(4188), new DateTime(2021, 7, 12, 22, 41, 55, 890, DateTimeKind.Unspecified).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 2, 25, 10, 34, 50, 809, DateTimeKind.Unspecified).AddTicks(4643), 5L, new DateTime(2022, 1, 20, 4, 7, 44, 403, DateTimeKind.Unspecified).AddTicks(5900), 40L, new DateTime(2019, 11, 28, 7, 39, 15, 896, DateTimeKind.Unspecified).AddTicks(8970), new DateTime(2021, 2, 16, 11, 56, 51, 676, DateTimeKind.Unspecified).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2022, 1, 16, 19, 32, 53, 840, DateTimeKind.Unspecified).AddTicks(1681), 1L, new DateTime(2022, 1, 16, 16, 5, 40, 345, DateTimeKind.Unspecified).AddTicks(595), 59L, new DateTime(2019, 4, 28, 21, 39, 33, 497, DateTimeKind.Unspecified).AddTicks(396), new DateTime(2021, 1, 13, 11, 36, 17, 447, DateTimeKind.Unspecified).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 10, 26, 16, 24, 25, 788, DateTimeKind.Unspecified).AddTicks(4023), 2L, new DateTime(2022, 1, 25, 23, 35, 2, 926, DateTimeKind.Unspecified).AddTicks(6872), 35L, new DateTime(2019, 8, 27, 18, 37, 3, 897, DateTimeKind.Unspecified).AddTicks(5241), new DateTime(2021, 7, 5, 11, 29, 42, 763, DateTimeKind.Unspecified).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 3, 9, 8, 27, 14, 660, DateTimeKind.Unspecified).AddTicks(7246), 4L, new DateTime(2022, 1, 4, 21, 22, 15, 583, DateTimeKind.Unspecified).AddTicks(1758), 65L, new DateTime(2019, 11, 8, 20, 46, 41, 470, DateTimeKind.Unspecified).AddTicks(672), new DateTime(2021, 10, 9, 15, 43, 9, 343, DateTimeKind.Unspecified).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 2L, new DateTime(2021, 6, 28, 16, 51, 30, 781, DateTimeKind.Unspecified).AddTicks(1984), 5L, new DateTime(2022, 1, 18, 13, 10, 14, 993, DateTimeKind.Unspecified).AddTicks(8968), 19L, new DateTime(2019, 5, 21, 5, 49, 9, 963, DateTimeKind.Unspecified).AddTicks(5839), new DateTime(2021, 2, 26, 19, 46, 8, 48, DateTimeKind.Unspecified).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2022, 1, 12, 2, 41, 4, 945, DateTimeKind.Unspecified).AddTicks(8513), 1L, new DateTime(2022, 1, 24, 1, 30, 5, 461, DateTimeKind.Unspecified).AddTicks(471), 31L, new DateTime(2019, 9, 2, 17, 4, 2, 533, DateTimeKind.Unspecified).AddTicks(254), new DateTime(2021, 9, 26, 5, 36, 2, 466, DateTimeKind.Unspecified).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 4, 27, 21, 10, 12, 516, DateTimeKind.Unspecified).AddTicks(9304), new DateTime(2022, 1, 28, 14, 28, 7, 626, DateTimeKind.Unspecified).AddTicks(8525), 27L, new DateTime(2019, 9, 29, 21, 24, 17, 991, DateTimeKind.Unspecified).AddTicks(1218), new DateTime(2021, 12, 5, 11, 22, 47, 958, DateTimeKind.Unspecified).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 2, 14, 19, 33, 5, 714, DateTimeKind.Unspecified).AddTicks(6561), 3L, new DateTime(2022, 1, 5, 13, 26, 29, 640, DateTimeKind.Unspecified).AddTicks(7532), 47L, new DateTime(2019, 3, 14, 14, 3, 55, 47, DateTimeKind.Unspecified).AddTicks(6456), new DateTime(2021, 5, 1, 8, 45, 12, 891, DateTimeKind.Unspecified).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 11, 15, 12, 38, 50, 554, DateTimeKind.Unspecified).AddTicks(2279), 1L, new DateTime(2022, 1, 27, 3, 58, 21, 593, DateTimeKind.Unspecified).AddTicks(1643), 31L, new DateTime(2019, 9, 29, 11, 42, 33, 5, DateTimeKind.Unspecified).AddTicks(146), new DateTime(2021, 8, 3, 2, 16, 56, 721, DateTimeKind.Unspecified).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 3, 23, 22, 0, 40, 90, DateTimeKind.Unspecified).AddTicks(5322), 5L, new DateTime(2022, 2, 1, 12, 18, 27, 396, DateTimeKind.Unspecified).AddTicks(1062), 12L, new DateTime(2019, 5, 24, 21, 0, 21, 886, DateTimeKind.Unspecified).AddTicks(6998), new DateTime(2021, 3, 8, 15, 51, 54, 788, DateTimeKind.Unspecified).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 48L, new DateTime(2021, 9, 14, 12, 12, 38, 458, DateTimeKind.Unspecified).AddTicks(3085), 1L, new DateTime(2022, 1, 3, 3, 53, 28, 895, DateTimeKind.Unspecified).AddTicks(8180), 10L, new DateTime(2019, 6, 24, 11, 25, 56, 908, DateTimeKind.Unspecified).AddTicks(9887), new DateTime(2021, 1, 24, 11, 41, 51, 441, DateTimeKind.Unspecified).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 3, 29, 13, 26, 11, 536, DateTimeKind.Unspecified).AddTicks(8884), 2L, new DateTime(2022, 1, 30, 16, 36, 42, 394, DateTimeKind.Unspecified).AddTicks(3449), 32L, new DateTime(2019, 5, 17, 12, 56, 32, 772, DateTimeKind.Unspecified).AddTicks(3252), new DateTime(2021, 10, 13, 1, 8, 59, 791, DateTimeKind.Unspecified).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 2, 11, 15, 20, 45, 859, DateTimeKind.Unspecified).AddTicks(9750), 5L, new DateTime(2022, 1, 25, 10, 3, 7, 78, DateTimeKind.Unspecified).AddTicks(4094), 42L, new DateTime(2019, 12, 4, 12, 48, 7, 736, DateTimeKind.Unspecified).AddTicks(3598), new DateTime(2021, 10, 3, 20, 55, 41, 754, DateTimeKind.Unspecified).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 5, 1, 15, 7, 55, 913, DateTimeKind.Unspecified).AddTicks(9195), new DateTime(2022, 1, 29, 16, 5, 34, 571, DateTimeKind.Unspecified).AddTicks(3230), 19L, new DateTime(2019, 3, 10, 12, 18, 53, 532, DateTimeKind.Unspecified).AddTicks(1543), new DateTime(2021, 8, 25, 8, 55, 55, 48, DateTimeKind.Unspecified).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 11, 5, 7, 28, 9, 139, DateTimeKind.Unspecified).AddTicks(9419), 1L, new DateTime(2022, 1, 27, 13, 25, 43, 197, DateTimeKind.Unspecified).AddTicks(7944), 12L, new DateTime(2019, 8, 31, 10, 7, 51, 714, DateTimeKind.Unspecified).AddTicks(8861), new DateTime(2021, 4, 12, 22, 19, 44, 430, DateTimeKind.Unspecified).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 10, 8, 18, 16, 8, 845, DateTimeKind.Unspecified).AddTicks(8317), new DateTime(2022, 1, 31, 2, 28, 17, 595, DateTimeKind.Unspecified).AddTicks(7584), 29L, new DateTime(2019, 9, 11, 0, 23, 9, 64, DateTimeKind.Unspecified).AddTicks(8059), new DateTime(2021, 6, 7, 23, 1, 26, 5, DateTimeKind.Unspecified).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 12, 26, 18, 50, 7, 732, DateTimeKind.Unspecified).AddTicks(4602), 2L, new DateTime(2022, 1, 2, 19, 39, 50, 892, DateTimeKind.Unspecified).AddTicks(8649), 12L, new DateTime(2019, 2, 20, 6, 38, 18, 828, DateTimeKind.Unspecified).AddTicks(9020), new DateTime(2021, 2, 20, 0, 4, 12, 773, DateTimeKind.Unspecified).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 8, 6, 16, 24, 42, 707, DateTimeKind.Unspecified).AddTicks(5220), 1L, new DateTime(2022, 1, 18, 4, 3, 1, 879, DateTimeKind.Unspecified).AddTicks(3529), 55L, new DateTime(2019, 11, 27, 23, 22, 27, 64, DateTimeKind.Unspecified).AddTicks(4016), new DateTime(2021, 2, 4, 7, 13, 54, 827, DateTimeKind.Unspecified).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2022, 1, 22, 23, 34, 6, 910, DateTimeKind.Unspecified).AddTicks(4551), 2L, new DateTime(2022, 1, 9, 10, 31, 56, 361, DateTimeKind.Unspecified).AddTicks(39), 76L, new DateTime(2019, 5, 20, 13, 32, 27, 112, DateTimeKind.Unspecified).AddTicks(391), new DateTime(2021, 3, 4, 7, 21, 36, 974, DateTimeKind.Unspecified).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 7, 12, 16, 0, 23, 244, DateTimeKind.Unspecified).AddTicks(5061), 3L, new DateTime(2022, 1, 13, 5, 25, 8, 773, DateTimeKind.Unspecified).AddTicks(5327), 41L, new DateTime(2019, 5, 12, 5, 54, 44, 806, DateTimeKind.Unspecified).AddTicks(7889), new DateTime(2021, 7, 9, 20, 7, 28, 3, DateTimeKind.Unspecified).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 10, 17, 18, 35, 23, 438, DateTimeKind.Unspecified).AddTicks(3224), 2L, new DateTime(2022, 1, 19, 12, 17, 13, 958, DateTimeKind.Unspecified).AddTicks(8461), 13L, new DateTime(2019, 7, 31, 8, 42, 32, 80, DateTimeKind.Unspecified).AddTicks(8947), new DateTime(2021, 7, 30, 18, 49, 45, 49, DateTimeKind.Unspecified).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 5, 11, 6, 2, 30, 86, DateTimeKind.Unspecified).AddTicks(9852), 1L, new DateTime(2022, 1, 4, 20, 15, 27, 668, DateTimeKind.Unspecified).AddTicks(9645), 61L, new DateTime(2019, 2, 13, 13, 14, 24, 405, DateTimeKind.Unspecified).AddTicks(6602), new DateTime(2021, 9, 23, 17, 30, 22, 332, DateTimeKind.Unspecified).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2022, 1, 26, 8, 12, 8, 286, DateTimeKind.Unspecified).AddTicks(8031), 4L, new DateTime(2022, 1, 23, 0, 0, 42, 421, DateTimeKind.Unspecified).AddTicks(4155), 29L, new DateTime(2019, 9, 15, 17, 0, 28, 278, DateTimeKind.Unspecified).AddTicks(4643), new DateTime(2021, 6, 14, 1, 6, 10, 909, DateTimeKind.Unspecified).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 5, 26, 1, 21, 8, 813, DateTimeKind.Unspecified).AddTicks(223), 3L, new DateTime(2022, 1, 7, 15, 39, 36, 428, DateTimeKind.Unspecified).AddTicks(135), 17L, new DateTime(2019, 4, 19, 6, 0, 35, 653, DateTimeKind.Unspecified).AddTicks(4478), new DateTime(2021, 1, 11, 17, 36, 45, 532, DateTimeKind.Unspecified).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 7, 10, 13, 1, 15, 189, DateTimeKind.Unspecified).AddTicks(9043), 2L, new DateTime(2022, 1, 25, 23, 47, 33, 458, DateTimeKind.Unspecified).AddTicks(1226), 70L, new DateTime(2019, 7, 11, 23, 42, 32, 503, DateTimeKind.Unspecified).AddTicks(7701), new DateTime(2021, 12, 23, 11, 57, 27, 805, DateTimeKind.Unspecified).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 2, 5, 16, 4, 38, 692, DateTimeKind.Unspecified).AddTicks(4870), 3L, new DateTime(2022, 1, 27, 12, 11, 49, 461, DateTimeKind.Unspecified).AddTicks(2296), 77L, new DateTime(2019, 4, 22, 13, 5, 45, 108, DateTimeKind.Unspecified).AddTicks(4967), new DateTime(2021, 12, 21, 0, 43, 26, 931, DateTimeKind.Unspecified).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 12, 3, 6, 58, 1, 323, DateTimeKind.Unspecified).AddTicks(3135), new DateTime(2022, 1, 24, 14, 44, 32, 74, DateTimeKind.Unspecified).AddTicks(2190), 22L, new DateTime(2019, 8, 10, 1, 12, 22, 926, DateTimeKind.Unspecified).AddTicks(2345), new DateTime(2021, 8, 26, 16, 51, 12, 35, DateTimeKind.Unspecified).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 48L, new DateTime(2021, 4, 24, 9, 24, 48, 173, DateTimeKind.Unspecified).AddTicks(5974), 3L, new DateTime(2022, 1, 13, 23, 33, 25, 272, DateTimeKind.Unspecified).AddTicks(3385), 45L, new DateTime(2019, 4, 14, 12, 18, 33, 744, DateTimeKind.Unspecified).AddTicks(8949), new DateTime(2021, 7, 24, 11, 51, 11, 879, DateTimeKind.Unspecified).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 7, 24, 13, 21, 8, 78, DateTimeKind.Unspecified).AddTicks(1037), 4L, new DateTime(2022, 1, 28, 1, 54, 12, 182, DateTimeKind.Unspecified).AddTicks(9533), 34L, new DateTime(2019, 11, 23, 12, 56, 47, 313, DateTimeKind.Unspecified).AddTicks(3850), new DateTime(2021, 6, 6, 21, 40, 0, 37, DateTimeKind.Unspecified).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 3, 27, 14, 50, 18, 872, DateTimeKind.Unspecified).AddTicks(5795), 2L, new DateTime(2022, 1, 16, 15, 11, 4, 323, DateTimeKind.Unspecified).AddTicks(7205), 78L, new DateTime(2019, 12, 18, 21, 3, 35, 69, DateTimeKind.Unspecified).AddTicks(8806), new DateTime(2021, 2, 14, 11, 39, 19, 59, DateTimeKind.Unspecified).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 10, 15, 12, 17, 50, 1, DateTimeKind.Unspecified).AddTicks(4991), 5L, null, 35L, new DateTime(2019, 6, 27, 16, 0, 12, 944, DateTimeKind.Unspecified).AddTicks(6223), new DateTime(2021, 3, 21, 13, 12, 2, 324, DateTimeKind.Unspecified).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 11, 5, 17, 15, 53, 191, DateTimeKind.Unspecified).AddTicks(2914), new DateTime(2022, 1, 27, 8, 20, 40, 427, DateTimeKind.Unspecified).AddTicks(4574), 17L, new DateTime(2019, 8, 5, 22, 28, 42, 729, DateTimeKind.Unspecified).AddTicks(9680), new DateTime(2021, 8, 13, 8, 21, 6, 80, DateTimeKind.Unspecified).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2022, 1, 6, 22, 9, 58, 974, DateTimeKind.Unspecified).AddTicks(7270), 1L, new DateTime(2022, 1, 20, 23, 12, 49, 739, DateTimeKind.Unspecified).AddTicks(4298), 66L, new DateTime(2019, 8, 31, 7, 2, 19, 855, DateTimeKind.Unspecified).AddTicks(3251), new DateTime(2021, 1, 19, 18, 2, 10, 465, DateTimeKind.Unspecified).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 3, 29, 14, 21, 42, 512, DateTimeKind.Unspecified).AddTicks(7875), 4L, new DateTime(2022, 2, 1, 19, 19, 27, 717, DateTimeKind.Unspecified).AddTicks(9258), 32L, new DateTime(2020, 1, 30, 23, 6, 0, 448, DateTimeKind.Unspecified).AddTicks(8313), new DateTime(2021, 3, 18, 21, 45, 21, 424, DateTimeKind.Unspecified).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 4, 24, 21, 47, 25, 246, DateTimeKind.Unspecified).AddTicks(3620), 2L, new DateTime(2022, 1, 18, 2, 59, 11, 888, DateTimeKind.Unspecified).AddTicks(2965), 37L, new DateTime(2019, 9, 25, 22, 41, 41, 599, DateTimeKind.Unspecified).AddTicks(5317), new DateTime(2021, 7, 21, 16, 32, 9, 10, DateTimeKind.Unspecified).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 2, 26, 3, 24, 35, 267, DateTimeKind.Unspecified).AddTicks(6425), new DateTime(2022, 1, 5, 3, 0, 37, 0, DateTimeKind.Unspecified).AddTicks(4883), 11L, new DateTime(2019, 7, 18, 21, 38, 13, 270, DateTimeKind.Unspecified).AddTicks(4782), new DateTime(2021, 7, 19, 9, 15, 27, 713, DateTimeKind.Unspecified).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 4, 17, 22, 45, 44, 614, DateTimeKind.Unspecified).AddTicks(5886), 4L, new DateTime(2022, 1, 22, 20, 15, 45, 897, DateTimeKind.Unspecified).AddTicks(5521), 67L, new DateTime(2019, 8, 7, 20, 58, 1, 305, DateTimeKind.Unspecified).AddTicks(845), new DateTime(2021, 4, 1, 0, 42, 48, 133, DateTimeKind.Unspecified).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 12, 21, 12, 4, 53, 977, DateTimeKind.Unspecified).AddTicks(1825), 3L, new DateTime(2022, 1, 3, 21, 46, 37, 211, DateTimeKind.Unspecified).AddTicks(964), 18L, new DateTime(2019, 11, 26, 9, 56, 29, 854, DateTimeKind.Unspecified).AddTicks(97), new DateTime(2021, 4, 18, 15, 39, 35, 901, DateTimeKind.Unspecified).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 2, 11, 10, 0, 28, 901, DateTimeKind.Unspecified).AddTicks(4358), 1L, new DateTime(2022, 1, 6, 11, 34, 51, 804, DateTimeKind.Unspecified).AddTicks(8203), 75L, new DateTime(2019, 2, 15, 19, 2, 45, 646, DateTimeKind.Unspecified).AddTicks(3942), new DateTime(2021, 12, 23, 3, 2, 31, 138, DateTimeKind.Unspecified).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 3, 16, 0, 54, 7, 383, DateTimeKind.Unspecified).AddTicks(5543), 3L, new DateTime(2022, 1, 27, 20, 18, 54, 594, DateTimeKind.Unspecified).AddTicks(3762), 57L, new DateTime(2019, 5, 12, 8, 46, 50, 939, DateTimeKind.Unspecified).AddTicks(2775), new DateTime(2021, 11, 6, 15, 49, 22, 586, DateTimeKind.Unspecified).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 7, 24, 1, 39, 36, 882, DateTimeKind.Unspecified).AddTicks(3294), 3L, new DateTime(2022, 1, 7, 4, 23, 49, 928, DateTimeKind.Unspecified).AddTicks(7900), 17L, new DateTime(2019, 12, 15, 18, 14, 40, 835, DateTimeKind.Unspecified).AddTicks(2046), new DateTime(2021, 1, 22, 22, 4, 42, 50, DateTimeKind.Unspecified).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2021, 10, 2, 1, 15, 7, 757, DateTimeKind.Unspecified).AddTicks(9296), 2L, new DateTime(2022, 1, 17, 22, 0, 50, 584, DateTimeKind.Unspecified).AddTicks(1386), 8L, new DateTime(2019, 4, 19, 4, 45, 26, 609, DateTimeKind.Unspecified).AddTicks(9086), new DateTime(2021, 9, 28, 6, 34, 43, 340, DateTimeKind.Unspecified).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 7, 9, 16, 25, 59, 548, DateTimeKind.Unspecified).AddTicks(226), 2L, new DateTime(2022, 1, 13, 4, 4, 28, 159, DateTimeKind.Unspecified).AddTicks(5930), 16L, new DateTime(2020, 1, 25, 21, 18, 19, 729, DateTimeKind.Unspecified).AddTicks(8985), new DateTime(2021, 1, 5, 13, 25, 3, 514, DateTimeKind.Unspecified).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 8, 5, 8, 39, 18, 983, DateTimeKind.Unspecified).AddTicks(5714), new DateTime(2022, 1, 24, 12, 17, 7, 280, DateTimeKind.Unspecified).AddTicks(9905), 19L, new DateTime(2019, 11, 28, 19, 20, 47, 518, DateTimeKind.Unspecified).AddTicks(5391), new DateTime(2021, 9, 16, 13, 52, 48, 45, DateTimeKind.Unspecified).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 2L, new DateTime(2021, 4, 26, 2, 50, 40, 888, DateTimeKind.Unspecified).AddTicks(2919), 3L, new DateTime(2022, 1, 4, 12, 53, 18, 231, DateTimeKind.Unspecified).AddTicks(8394), 2L, new DateTime(2019, 4, 12, 1, 53, 37, 701, DateTimeKind.Unspecified).AddTicks(3861), new DateTime(2021, 3, 17, 4, 47, 45, 572, DateTimeKind.Unspecified).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 21L, new DateTime(2021, 6, 10, 21, 35, 3, 347, DateTimeKind.Unspecified).AddTicks(5895), 4L, new DateTime(2022, 1, 4, 8, 33, 30, 61, DateTimeKind.Unspecified).AddTicks(3037), 17L, new DateTime(2019, 8, 17, 22, 34, 34, 921, DateTimeKind.Unspecified).AddTicks(2182), new DateTime(2021, 8, 23, 14, 30, 24, 31, DateTimeKind.Unspecified).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 2, 20, 8, 8, 2, 443, DateTimeKind.Unspecified).AddTicks(2360), 5L, new DateTime(2022, 1, 17, 19, 58, 54, 29, DateTimeKind.Unspecified).AddTicks(4935), 71L, new DateTime(2019, 8, 4, 20, 12, 41, 16, DateTimeKind.Unspecified).AddTicks(5190), new DateTime(2021, 7, 3, 6, 28, 19, 225, DateTimeKind.Unspecified).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 7, 6, 23, 26, 24, 435, DateTimeKind.Unspecified).AddTicks(9970), 3L, new DateTime(2022, 1, 12, 3, 12, 7, 183, DateTimeKind.Unspecified).AddTicks(7899), 4L, new DateTime(2019, 4, 22, 23, 58, 41, 210, DateTimeKind.Unspecified).AddTicks(2443), new DateTime(2021, 8, 17, 5, 5, 19, 673, DateTimeKind.Unspecified).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2022, 1, 25, 23, 26, 32, 751, DateTimeKind.Unspecified).AddTicks(5423), new DateTime(2022, 1, 3, 4, 19, 54, 341, DateTimeKind.Unspecified).AddTicks(4135), 81L, new DateTime(2019, 6, 19, 13, 14, 9, 911, DateTimeKind.Unspecified).AddTicks(7939), new DateTime(2021, 1, 13, 7, 45, 10, 958, DateTimeKind.Unspecified).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 2, 5, 20, 23, 27, 915, DateTimeKind.Unspecified).AddTicks(4446), 1L, new DateTime(2022, 1, 5, 20, 3, 37, 530, DateTimeKind.Unspecified).AddTicks(3497), 31L, new DateTime(2019, 7, 1, 12, 46, 10, 405, DateTimeKind.Unspecified).AddTicks(5538), new DateTime(2021, 8, 10, 22, 19, 9, 583, DateTimeKind.Unspecified).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 2, 24, 14, 12, 35, 19, DateTimeKind.Unspecified).AddTicks(5187), 1L, new DateTime(2022, 2, 1, 14, 34, 2, 288, DateTimeKind.Unspecified).AddTicks(8598), 38L, new DateTime(2019, 12, 30, 1, 2, 12, 196, DateTimeKind.Unspecified).AddTicks(1331), new DateTime(2021, 2, 2, 1, 57, 50, 771, DateTimeKind.Unspecified).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 8, 29, 7, 59, 52, 140, DateTimeKind.Unspecified).AddTicks(1218), 2L, new DateTime(2022, 1, 19, 15, 28, 49, 999, DateTimeKind.Unspecified).AddTicks(8155), 36L, new DateTime(2019, 10, 26, 5, 20, 47, 257, DateTimeKind.Unspecified).AddTicks(8317), new DateTime(2021, 2, 28, 16, 23, 32, 275, DateTimeKind.Unspecified).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 7, 31, 16, 8, 55, 519, DateTimeKind.Unspecified).AddTicks(6195), new DateTime(2022, 1, 10, 7, 29, 26, 622, DateTimeKind.Unspecified).AddTicks(9657), 39L, new DateTime(2019, 12, 27, 10, 5, 15, 270, DateTimeKind.Unspecified).AddTicks(9147), new DateTime(2021, 7, 13, 6, 18, 31, 697, DateTimeKind.Unspecified).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 9, 3, 6, 4, 46, 339, DateTimeKind.Unspecified).AddTicks(3140), new DateTime(2022, 1, 3, 9, 13, 46, 435, DateTimeKind.Unspecified).AddTicks(420), 52L, new DateTime(2019, 11, 29, 1, 18, 58, 654, DateTimeKind.Unspecified).AddTicks(8467), new DateTime(2021, 7, 4, 23, 21, 30, 275, DateTimeKind.Unspecified).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 12, 1, 17, 2, 44, 544, DateTimeKind.Unspecified).AddTicks(9149), 5L, new DateTime(2022, 1, 29, 13, 40, 0, 767, DateTimeKind.Unspecified).AddTicks(4744), 6L, new DateTime(2019, 8, 22, 6, 6, 34, 511, DateTimeKind.Unspecified).AddTicks(870), new DateTime(2021, 5, 11, 20, 9, 49, 855, DateTimeKind.Unspecified).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 12, 7, 19, 6, 20, 267, DateTimeKind.Unspecified).AddTicks(2379), 2L, new DateTime(2022, 1, 29, 5, 29, 25, 702, DateTimeKind.Unspecified).AddTicks(3343), 76L, new DateTime(2019, 3, 29, 4, 21, 9, 623, DateTimeKind.Unspecified).AddTicks(3226), new DateTime(2021, 2, 17, 11, 7, 7, 976, DateTimeKind.Unspecified).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 6, 16, 21, 40, 27, 153, DateTimeKind.Unspecified).AddTicks(2362), new DateTime(2022, 1, 7, 14, 33, 23, 815, DateTimeKind.Unspecified).AddTicks(9644), 67L, new DateTime(2019, 10, 18, 19, 25, 1, 709, DateTimeKind.Unspecified).AddTicks(9587), new DateTime(2021, 9, 21, 11, 48, 43, 345, DateTimeKind.Unspecified).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 6, 12, 17, 2, 24, 333, DateTimeKind.Unspecified).AddTicks(3569), new DateTime(2022, 1, 10, 19, 0, 38, 202, DateTimeKind.Unspecified).AddTicks(3459), 40L, new DateTime(2019, 9, 4, 19, 54, 23, 304, DateTimeKind.Unspecified).AddTicks(6290), new DateTime(2021, 6, 25, 4, 33, 25, 376, DateTimeKind.Unspecified).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2022, 1, 17, 19, 24, 29, 982, DateTimeKind.Unspecified).AddTicks(2289), 2L, new DateTime(2022, 1, 31, 1, 0, 23, 381, DateTimeKind.Unspecified).AddTicks(9174), 77L, new DateTime(2019, 10, 19, 16, 27, 10, 935, DateTimeKind.Unspecified).AddTicks(3240), new DateTime(2021, 3, 2, 22, 9, 16, 649, DateTimeKind.Unspecified).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 11, 5, 23, 14, 1, 845, DateTimeKind.Unspecified).AddTicks(8181), 1L, new DateTime(2022, 1, 17, 6, 44, 52, 377, DateTimeKind.Unspecified).AddTicks(6024), 71L, new DateTime(2019, 6, 11, 23, 29, 3, 564, DateTimeKind.Unspecified).AddTicks(818), new DateTime(2021, 2, 13, 22, 14, 12, 588, DateTimeKind.Unspecified).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 6, 17, 4, 41, 33, 386, DateTimeKind.Unspecified).AddTicks(7518), new DateTime(2022, 1, 14, 3, 38, 45, 484, DateTimeKind.Unspecified).AddTicks(7573), 27L, new DateTime(2019, 12, 12, 22, 50, 5, 891, DateTimeKind.Unspecified).AddTicks(4657), new DateTime(2021, 12, 2, 23, 52, 49, 291, DateTimeKind.Unspecified).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 9, 21, 11, 32, 19, 354, DateTimeKind.Unspecified).AddTicks(9934), new DateTime(2022, 1, 31, 14, 6, 10, 441, DateTimeKind.Unspecified).AddTicks(7614), 58L, new DateTime(2019, 8, 7, 3, 18, 34, 788, DateTimeKind.Unspecified).AddTicks(8492), new DateTime(2021, 4, 6, 18, 33, 43, 407, DateTimeKind.Unspecified).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 9, 30, 11, 41, 55, 956, DateTimeKind.Unspecified).AddTicks(8551), 4L, new DateTime(2022, 1, 17, 16, 11, 4, 656, DateTimeKind.Unspecified).AddTicks(3563), 7L, new DateTime(2019, 3, 5, 14, 10, 10, 891, DateTimeKind.Unspecified).AddTicks(6341), new DateTime(2021, 3, 29, 16, 39, 56, 875, DateTimeKind.Unspecified).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 7, 18, 5, 37, 27, 79, DateTimeKind.Unspecified).AddTicks(4057), 1L, new DateTime(2022, 1, 29, 22, 22, 24, 106, DateTimeKind.Unspecified).AddTicks(3123), 72L, new DateTime(2019, 10, 2, 7, 10, 37, 152, DateTimeKind.Unspecified).AddTicks(6078), new DateTime(2021, 3, 2, 3, 56, 41, 8, DateTimeKind.Unspecified).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 2, 15, 0, 35, 11, 497, DateTimeKind.Unspecified).AddTicks(2586), 2L, new DateTime(2022, 1, 2, 9, 9, 39, 806, DateTimeKind.Unspecified).AddTicks(5265), 19L, new DateTime(2019, 9, 16, 23, 25, 54, 910, DateTimeKind.Unspecified).AddTicks(7497), new DateTime(2021, 1, 24, 15, 49, 25, 91, DateTimeKind.Unspecified).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 2, 23, 9, 52, 8, 799, DateTimeKind.Unspecified).AddTicks(1794), 2L, new DateTime(2022, 1, 26, 17, 20, 16, 308, DateTimeKind.Unspecified).AddTicks(1504), 67L, new DateTime(2019, 4, 6, 18, 51, 19, 925, DateTimeKind.Unspecified).AddTicks(1083), new DateTime(2021, 4, 23, 20, 40, 22, 586, DateTimeKind.Unspecified).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2022, 1, 8, 14, 49, 40, 832, DateTimeKind.Unspecified).AddTicks(3915), 2L, new DateTime(2022, 1, 3, 11, 32, 42, 332, DateTimeKind.Unspecified).AddTicks(5392), 71L, new DateTime(2019, 10, 5, 9, 40, 57, 258, DateTimeKind.Unspecified).AddTicks(5447), new DateTime(2021, 2, 22, 4, 30, 24, 287, DateTimeKind.Unspecified).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 6, 23, 9, 45, 59, 969, DateTimeKind.Unspecified).AddTicks(3552), new DateTime(2022, 1, 22, 5, 32, 0, 650, DateTimeKind.Unspecified).AddTicks(4780), 33L, new DateTime(2019, 10, 11, 19, 33, 56, 833, DateTimeKind.Unspecified).AddTicks(1477), new DateTime(2021, 1, 26, 12, 2, 8, 517, DateTimeKind.Unspecified).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 5, 23, 18, 46, 6, 992, DateTimeKind.Unspecified).AddTicks(6273), new DateTime(2022, 1, 6, 22, 22, 5, 755, DateTimeKind.Unspecified).AddTicks(2149), 28L, new DateTime(2019, 11, 16, 10, 45, 7, 24, DateTimeKind.Unspecified).AddTicks(6698), new DateTime(2021, 5, 31, 2, 59, 7, 430, DateTimeKind.Unspecified).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2021, 7, 29, 9, 42, 35, 666, DateTimeKind.Unspecified).AddTicks(2186), 2L, new DateTime(2022, 1, 14, 5, 46, 11, 723, DateTimeKind.Unspecified).AddTicks(2309), 28L, new DateTime(2020, 1, 25, 11, 8, 12, 741, DateTimeKind.Unspecified).AddTicks(3546), new DateTime(2021, 7, 23, 5, 11, 32, 733, DateTimeKind.Unspecified).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 7, 28, 21, 42, 47, 655, DateTimeKind.Unspecified).AddTicks(4314), 1L, new DateTime(2022, 1, 21, 0, 49, 12, 921, DateTimeKind.Unspecified).AddTicks(998), 58L, new DateTime(2019, 3, 19, 7, 54, 57, 543, DateTimeKind.Unspecified).AddTicks(8921), new DateTime(2021, 12, 18, 10, 3, 55, 11, DateTimeKind.Unspecified).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 8, 26, 9, 11, 32, 2, DateTimeKind.Unspecified).AddTicks(1763), 3L, null, 78L, new DateTime(2019, 4, 8, 3, 0, 19, 71, DateTimeKind.Unspecified).AddTicks(8791), new DateTime(2021, 12, 23, 9, 4, 16, 750, DateTimeKind.Unspecified).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 2, 4, 18, 26, 50, 788, DateTimeKind.Unspecified).AddTicks(7190), 2L, new DateTime(2022, 1, 3, 4, 44, 46, 880, DateTimeKind.Unspecified).AddTicks(94), 50L, new DateTime(2019, 2, 5, 17, 1, 10, 82, DateTimeKind.Unspecified).AddTicks(8644), new DateTime(2021, 3, 11, 19, 16, 35, 984, DateTimeKind.Unspecified).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Quia debitis distinctio.\nQui at et dolorem nisi aut.\nOfficia vero aut.\nQuos eos vero at veritatis rerum possimus eum ex aut.\nCum aut ut est pariatur quia non ad velit repellat.", new DateTime(2021, 9, 22, 22, 19, 30, 418, DateTimeKind.Unspecified).AddTicks(973), 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 21L, "Cum mollitia fugiat quia quis eligendi hic sed et.", new DateTime(2021, 12, 25, 1, 56, 36, 460, DateTimeKind.Unspecified).AddTicks(6660), 4L, 56L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Nemo quia voluptas.\nIure velit id aliquam.\nInventore qui repudiandae delectus eligendi consequatur qui quos rerum architecto.", new DateTime(2021, 2, 7, 14, 37, 14, 811, DateTimeKind.Unspecified).AddTicks(4929), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Nesciunt at ut totam dignissimos eum dolorem fugiat hic corrupti.\nEnim amet qui cum earum laboriosam officiis et.\nDolor maiores nihil aliquam natus sit possimus aperiam.\nVel temporibus laboriosam sunt adipisci.\nUt adipisci temporibus sint.", new DateTime(2022, 1, 27, 16, 44, 10, 519, DateTimeKind.Unspecified).AddTicks(8163), 1L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Unde nemo numquam.\nEos eveniet est sint aut sed.", new DateTime(2021, 3, 8, 16, 30, 30, 744, DateTimeKind.Unspecified).AddTicks(3389), 2L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 43L, "Dolores unde dolores.\nIure sit asperiores et sit maxime unde ex.", new DateTime(2021, 2, 12, 9, 57, 38, 101, DateTimeKind.Unspecified).AddTicks(4368), 24L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Perferendis debitis ut quidem.\nSint eos quam fugit.", new DateTime(2021, 3, 6, 13, 27, 21, 222, DateTimeKind.Unspecified).AddTicks(7305), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 30L, "Sequi minima non debitis et.\nCommodi ipsam porro et reprehenderit ut nostrum dicta.\nEt sed quia aut necessitatibus eum provident et.\nEius error ut et alias dignissimos.\nQuo nam aut cum consequatur quia.\nPorro atque est.", new DateTime(2021, 5, 2, 19, 58, 43, 511, DateTimeKind.Unspecified).AddTicks(8277), 3L, 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 37L, "Suscipit molestiae quos at impedit et asperiores officiis fuga.\nConsequuntur distinctio itaque quisquam ullam enim enim et iste.\nConsectetur voluptate soluta voluptas aut quos fuga labore.\nImpedit recusandae est est porro quidem rerum molestias deserunt.", new DateTime(2021, 11, 11, 11, 16, 51, 772, DateTimeKind.Unspecified).AddTicks(5368), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Quae iusto dolor omnis.", new DateTime(2021, 3, 5, 6, 48, 32, 975, DateTimeKind.Unspecified).AddTicks(1990), 3L, 22L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Expedita non placeat dolorem maxime eius quia facere inventore repudiandae.\nVoluptatum perferendis modi dicta distinctio aut soluta hic cupiditate.", new DateTime(2021, 8, 20, 4, 35, 10, 372, DateTimeKind.Unspecified).AddTicks(6151), 2L, 79L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Quo et rerum similique nesciunt sit qui possimus.\nNihil necessitatibus laboriosam.", new DateTime(2021, 3, 3, 14, 25, 28, 308, DateTimeKind.Unspecified).AddTicks(8673), 5L, 40L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 16L, "Vel similique quam iste.\nEligendi ducimus officiis delectus cum rerum eligendi in.", new DateTime(2021, 7, 31, 22, 42, 52, 133, DateTimeKind.Unspecified).AddTicks(5285), 1L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Corrupti possimus eum accusantium aliquam dolorem vel assumenda laudantium.\nPraesentium nam sunt quibusdam quia architecto impedit aliquam sequi.", new DateTime(2021, 10, 21, 2, 56, 8, 619, DateTimeKind.Unspecified).AddTicks(7270), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Officiis consequatur magni mollitia qui dolor reiciendis perspiciatis ab.", new DateTime(2021, 7, 18, 14, 16, 13, 766, DateTimeKind.Unspecified).AddTicks(9543), 3L, 32L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Exercitationem molestiae voluptatibus ipsa quas aut.", new DateTime(2021, 11, 14, 3, 55, 49, 415, DateTimeKind.Unspecified).AddTicks(7157), 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 3L, "Aliquid quia tempore consequatur rem omnis magnam eum quibusdam.\nIpsum perferendis illo atque sed.", new DateTime(2021, 7, 26, 3, 2, 24, 986, DateTimeKind.Unspecified).AddTicks(5854), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Voluptas eveniet ut.", new DateTime(2021, 4, 28, 10, 55, 57, 528, DateTimeKind.Unspecified).AddTicks(8464), 3L, 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Omnis vel enim delectus et nihil.", new DateTime(2021, 4, 24, 18, 55, 10, 361, DateTimeKind.Unspecified).AddTicks(5571), 5L, 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Deserunt ipsa possimus delectus doloribus voluptatem saepe omnis dolor.\nOptio perferendis est qui modi voluptate tempora.", new DateTime(2021, 10, 12, 2, 18, 9, 868, DateTimeKind.Unspecified).AddTicks(5777), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Temporibus maxime dicta at eligendi expedita.\nEt placeat officiis enim quia at molestias quia aliquam.", new DateTime(2021, 5, 26, 0, 40, 43, 540, DateTimeKind.Unspecified).AddTicks(3180), 2L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 50L, "Aliquam labore ipsa velit ut vitae est unde.\nTotam voluptatem omnis delectus eius ut ipsum velit aut.", new DateTime(2021, 12, 12, 3, 59, 9, 521, DateTimeKind.Unspecified).AddTicks(4097), 5L, 53L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 29L, "Quis eveniet ab aut cumque est.\nQuidem veniam odit corrupti pariatur consequatur quos est quisquam numquam.\nVeritatis voluptas voluptates corporis.", new DateTime(2021, 9, 24, 8, 6, 8, 95, DateTimeKind.Unspecified).AddTicks(1537), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Quo error minus fugit.\nHarum eum architecto doloremque porro pariatur sed voluptatum et.\nEos minus illo ea nihil.\nAliquam et placeat vitae sunt et.\nEx explicabo dolorum.", new DateTime(2021, 3, 2, 6, 53, 41, 178, DateTimeKind.Unspecified).AddTicks(9590), 4L, 76L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Quis voluptatem quia nam laborum.\nDolores ut vero commodi veniam aperiam nobis tempora.\nRepellat ut et praesentium dolores.\nAperiam aliquam dolores voluptas quisquam itaque aspernatur molestias ut cumque.\nOmnis corrupti ea doloremque sit ipsa et error.", new DateTime(2021, 11, 18, 0, 44, 15, 636, DateTimeKind.Unspecified).AddTicks(6531), 2L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Libero accusamus voluptatem.\nSapiente aut praesentium culpa iure.", new DateTime(2021, 3, 10, 15, 44, 16, 910, DateTimeKind.Unspecified).AddTicks(9018), 1L, 63L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "In voluptas deserunt nam culpa deleniti adipisci et ut.\nNon alias eveniet sed qui vel quae sint minus.\nEt omnis neque.\nEst et ut aspernatur sit.\nEos qui voluptates consequatur provident.\nHarum perspiciatis rerum omnis rem alias ab.", new DateTime(2021, 7, 11, 2, 28, 39, 965, DateTimeKind.Unspecified).AddTicks(1804), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Non quisquam consequuntur dolorem voluptas est dolorum soluta veniam.\nSuscipit excepturi aspernatur pariatur consequatur cum temporibus sunt sunt libero.\nDolor et ad.", new DateTime(2021, 5, 11, 22, 5, 44, 98, DateTimeKind.Unspecified).AddTicks(2176), 1L, 48L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Facere soluta officia exercitationem quos.\nPerferendis aut et quia voluptates debitis ut.\nCorporis eaque autem sequi quae at et.\nVoluptatum quo dolor ut modi pariatur maiores ut fuga saepe.", new DateTime(2021, 6, 7, 7, 18, 1, 940, DateTimeKind.Unspecified).AddTicks(7407), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Ea laudantium nam vel accusantium delectus possimus ratione fugiat.\nAut qui sed voluptates nobis dolor doloremque accusamus sed debitis.\nQui voluptatem neque maiores quibusdam et sit.\nSuscipit quam est sed sunt quibusdam culpa consectetur molestiae.\nMolestias a quidem sint voluptas debitis nulla et quo.\nVoluptatem reiciendis voluptatem qui.", new DateTime(2021, 12, 10, 20, 56, 19, 476, DateTimeKind.Unspecified).AddTicks(6285), 2L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Tempora totam id enim dolores rem voluptas accusantium harum.\nOdit deserunt id.\nOptio sint officiis.\nDoloribus veniam qui minus repellendus vel sunt ex.", new DateTime(2021, 10, 23, 18, 30, 34, 596, DateTimeKind.Unspecified).AddTicks(5174), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Est animi et eaque eius voluptas.\nVero omnis qui.\nMollitia aut libero autem corporis possimus.\nQuam officia sequi numquam.", new DateTime(2021, 3, 1, 4, 36, 46, 202, DateTimeKind.Unspecified).AddTicks(6727), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Consequatur dolores tenetur aliquid.\nTempore et alias eum expedita cumque unde.\nDolores minus quia ullam amet impedit et.\nQuibusdam iusto rerum vero doloribus minima rem sint dolores ex.\nOfficia debitis corrupti esse et.", new DateTime(2021, 4, 30, 4, 45, 59, 691, DateTimeKind.Unspecified).AddTicks(7247), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Aut molestiae officiis reiciendis sit deleniti ea adipisci dolores numquam.\nNesciunt similique optio aut dolores perspiciatis reprehenderit iusto dicta.\nUllam ea a minus.", new DateTime(2021, 11, 13, 21, 2, 13, 368, DateTimeKind.Unspecified).AddTicks(4529), 3L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Qui est debitis suscipit sint.", new DateTime(2021, 2, 5, 19, 47, 14, 271, DateTimeKind.Unspecified).AddTicks(8322), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Eos beatae possimus porro sint quisquam vero qui occaecati eaque.\nVeniam tempore et voluptatem repudiandae.\nQuis neque ut aut.\nItaque est omnis eligendi commodi.", new DateTime(2021, 12, 16, 0, 35, 55, 674, DateTimeKind.Unspecified).AddTicks(5286), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Nemo iusto voluptas sed sit minus mollitia.\nHarum id labore illum quia sed provident.\nQuasi assumenda necessitatibus dolorem et ut.", new DateTime(2021, 12, 4, 13, 12, 49, 653, DateTimeKind.Unspecified).AddTicks(2873), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Commodi architecto maiores et aut.\nConsequatur commodi optio quo modi rerum similique ullam laboriosam.", new DateTime(2021, 11, 10, 7, 53, 26, 136, DateTimeKind.Unspecified).AddTicks(5424), 5L, 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Alias odio voluptas et dolorum aut suscipit earum amet.\nVero molestias et labore.\nDolorum sit itaque sunt quo dolorem autem.", new DateTime(2021, 10, 30, 15, 51, 52, 4, DateTimeKind.Unspecified).AddTicks(6718), 2L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Minus dignissimos velit recusandae id cupiditate ea harum.\nNam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.", new DateTime(2021, 2, 26, 12, 1, 35, 855, DateTimeKind.Unspecified).AddTicks(3844), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nam quia dicta eius doloribus commodi non nihil.\nQuod recusandae et est.\nDebitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.", new DateTime(2021, 10, 28, 3, 37, 20, 886, DateTimeKind.Unspecified).AddTicks(3829), 1L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Est sit at placeat optio.\nSapiente pariatur et et enim.\nAccusamus molestiae labore.", new DateTime(2021, 6, 2, 19, 19, 7, 873, DateTimeKind.Unspecified).AddTicks(6561), 4L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 3L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 1L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Earum voluptate voluptatem.\nSunt sunt est non deleniti tempore provident nihil et omnis.", new DateTime(2021, 5, 22, 23, 42, 34, 208, DateTimeKind.Unspecified).AddTicks(457), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Libero dicta temporibus atque earum.\nReprehenderit eos qui eum totam.\nId cum adipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 1L, 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 5L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 1L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 2L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 3L, 47L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 3L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 2L, 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 1L, 65L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 3L, 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 3L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "Body", "CreatedAt", "ThreadId" },
                values: new object[] { "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 5L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 5L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 3L, 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 25L, "Ipsam minima vel totam vel deserunt ab.\nEnim dolorem aliquid aperiam quod tempore porro ad nemo sit.\nNisi quis dolore nihil.", new DateTime(2021, 3, 28, 17, 3, 2, 998, DateTimeKind.Unspecified).AddTicks(838), 3L, 81L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Non fugiat non porro vero reiciendis et.\nEnim facere autem molestiae.", new DateTime(2021, 4, 1, 7, 35, 59, 215, DateTimeKind.Unspecified).AddTicks(830), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Quo corporis voluptatem.\nQuia ut architecto adipisci quasi at aliquid voluptatum et.\nConsequatur voluptate dolor doloribus quam ipsam rerum optio.\nAperiam aperiam et.", new DateTime(2021, 12, 23, 16, 16, 38, 159, DateTimeKind.Unspecified).AddTicks(4359), 1L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Qui quam perferendis itaque dolore eligendi expedita.\nFacilis distinctio et omnis necessitatibus quibusdam rerum.\nEt qui ex itaque quam tempora quia eos.", new DateTime(2021, 5, 6, 9, 31, 38, 3, DateTimeKind.Unspecified).AddTicks(8430), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Illo a ex minus.\nDucimus qui officiis.\nDicta suscipit voluptas libero.\nTemporibus enim qui labore.", new DateTime(2021, 10, 9, 0, 43, 5, 480, DateTimeKind.Unspecified).AddTicks(7270), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Sed tempora non officiis est sit eveniet.\nArchitecto corrupti id rerum quam nesciunt assumenda odio ut maxime.\nUt animi in iste voluptatibus aliquid ut vitae.\nVelit exercitationem vero id sed quibusdam non.\nUt at ratione qui consectetur quam voluptas dolor dolorum.", new DateTime(2021, 8, 14, 13, 57, 37, 263, DateTimeKind.Unspecified).AddTicks(4946), 5L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Quo dolor harum et maxime.\nEt ut quia ab animi occaecati beatae.\nVel autem ea molestias.\nAspernatur sunt explicabo.\nCorporis vitae porro voluptas et magni alias sit quia quia.\nImpedit maiores unde possimus aspernatur enim ea et ut.", new DateTime(2021, 9, 6, 6, 15, 51, 816, DateTimeKind.Unspecified).AddTicks(508), 1L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 23L, "Cum illum sit corporis maiores laudantium ut.\nArchitecto aut expedita nihil et voluptatibus fugiat.\nQuisquam harum consequatur quasi ea voluptas hic dolorum.\nHarum laborum harum suscipit magnam aut.\nDolores amet tempore magni magni possimus odit quis et impedit.", new DateTime(2021, 6, 4, 11, 4, 16, 100, DateTimeKind.Unspecified).AddTicks(7149), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 34L, "Dolores ea assumenda alias.", new DateTime(2021, 3, 6, 4, 28, 7, 52, DateTimeKind.Unspecified).AddTicks(1993), 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 48L, "Sint aliquid pariatur harum enim dolorem repellat.\nMolestiae aut nemo nihil qui sapiente non harum.\nEligendi voluptas nobis tempore.\nMolestias vel dolores aut deleniti aut minima accusamus.\nOmnis voluptatem similique.\nFacere occaecati incidunt iusto laborum ut eius id dolore.", new DateTime(2021, 4, 12, 22, 5, 28, 434, DateTimeKind.Unspecified).AddTicks(9752), 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Quam ducimus qui.\nRerum velit nulla rem.\nUllam nisi eveniet dignissimos.", new DateTime(2021, 8, 25, 1, 50, 58, 81, DateTimeKind.Unspecified).AddTicks(488), 3L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Omnis fugit aut.", new DateTime(2021, 8, 20, 8, 30, 53, 58, DateTimeKind.Unspecified).AddTicks(3331), 3L, 59L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Qui et velit tempore et.\nQui animi dolor beatae soluta.\nEt ab explicabo eos enim consequatur omnis soluta.\nVel doloribus omnis est optio et.\nAmet et assumenda et numquam culpa.\nQuasi aspernatur tempore.", new DateTime(2021, 11, 8, 12, 17, 53, 802, DateTimeKind.Unspecified).AddTicks(2027), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Suscipit deleniti accusamus et debitis.\nDucimus ab cum.\nPariatur architecto architecto odio maiores.", new DateTime(2021, 9, 4, 18, 46, 20, 745, DateTimeKind.Unspecified).AddTicks(6003), 1L, 30L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Dolore nihil voluptas doloremque accusantium.\nAnimi aspernatur mollitia.", new DateTime(2021, 6, 17, 15, 1, 38, 939, DateTimeKind.Unspecified).AddTicks(7420), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Eum voluptas similique quasi.\nPorro possimus repudiandae minus rerum repellat.\nNobis laboriosam qui id qui inventore illo sunt.", new DateTime(2021, 3, 27, 21, 21, 10, 234, DateTimeKind.Unspecified).AddTicks(231), 1L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Hic vitae tempora tempore et dignissimos perferendis omnis aut.", new DateTime(2021, 3, 12, 22, 52, 25, 95, DateTimeKind.Unspecified).AddTicks(9008), 2L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Excepturi mollitia vitae accusantium autem repudiandae.\nEst rem ex rerum sunt suscipit voluptatem veniam aut.\nMaiores similique assumenda tempore est inventore aut omnis.\nEt ut corporis dolorem deleniti dolorem laudantium mollitia.", new DateTime(2021, 4, 6, 19, 23, 18, 77, DateTimeKind.Unspecified).AddTicks(4489), 5L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Adipisci enim facere voluptatem sed accusamus soluta fuga qui porro.\nEx quia dolorem qui qui sed sed rem.\nConsequatur occaecati rem corporis officiis dolor aut id.\nSuscipit pariatur necessitatibus minima harum sunt ea.\nQuod omnis nobis sapiente veniam esse qui ducimus quia voluptas.", new DateTime(2021, 9, 4, 11, 28, 1, 107, DateTimeKind.Unspecified).AddTicks(3093), 4L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 3L, "Aut non tempore voluptas qui.\nLaboriosam omnis earum sit atque et.\nBeatae est magnam praesentium rerum quibusdam dignissimos temporibus voluptas.\nOdit rerum at facere itaque rem sapiente rerum.\nAspernatur ut corporis nihil ut occaecati atque exercitationem nihil molestiae.", new DateTime(2021, 5, 15, 6, 26, 4, 917, DateTimeKind.Unspecified).AddTicks(507), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Sequi reprehenderit ipsam.\nEt enim error quia quia error tenetur mollitia eligendi.\nNostrum voluptatibus magni natus assumenda quis.\nMaiores ut itaque ea et voluptatem et maxime praesentium.", new DateTime(2021, 5, 20, 9, 52, 1, 466, DateTimeKind.Unspecified).AddTicks(4088), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Est ab nemo.\nAut aspernatur dolores suscipit similique necessitatibus id voluptatem quidem.\nDolores consequatur tenetur.\nAd dolorem ipsa autem et.\nNostrum cumque praesentium.", new DateTime(2021, 9, 22, 15, 38, 2, 296, DateTimeKind.Unspecified).AddTicks(2770), 4L, 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Non sit beatae aliquam reiciendis enim tempore.\nPerferendis quis excepturi eveniet repellat tempora.\nVoluptas aut numquam eveniet et et eaque enim.\nAdipisci et ad quidem placeat earum dolor.\nDolorum voluptate molestiae nihil illo fugit aut.\nAnimi soluta accusantium.", new DateTime(2021, 10, 18, 16, 4, 44, 926, DateTimeKind.Unspecified).AddTicks(6113), 2L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Nihil qui in laudantium iste repellat ipsum veritatis praesentium.\nDeleniti eaque eaque.\nQuasi deserunt maiores ad deserunt et alias enim.", new DateTime(2021, 4, 5, 3, 11, 52, 774, DateTimeKind.Unspecified).AddTicks(511), 5L, 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Ut cumque aut.\nAut aut voluptas ex.\nVeritatis et velit aliquam.\nDeserunt illo quos maiores natus earum a velit.\nEarum cumque libero facere voluptatem saepe suscipit qui est veritatis.\nAutem omnis dicta ad.", new DateTime(2021, 5, 17, 13, 53, 22, 284, DateTimeKind.Unspecified).AddTicks(1090), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 12, 21, 4, 44, 20, 278, DateTimeKind.Unspecified).AddTicks(6650), 5L, 510, true, 45L, 42 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 11, 16, 13, 6, 3, 818, DateTimeKind.Unspecified).AddTicks(714), 660, 79L, 260 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 4, 24, 14, 36, 52, 329, DateTimeKind.Unspecified).AddTicks(7400), 688, 36L, 227 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 6, 19, 22, 23, 50, 401, DateTimeKind.Unspecified).AddTicks(5997), 797, false, 19L, null, 81 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 3, 31, 17, 57, 53, 215, DateTimeKind.Unspecified).AddTicks(1616), 617, 31 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 4, 13, 13, 23, 8, 37, DateTimeKind.Unspecified).AddTicks(5818), 5L, 955, false, null, 29L, 83 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 4, 15, 3, 12, 39, 921, DateTimeKind.Unspecified).AddTicks(8542), 5L, 635, false, 26L, 169 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 10, 10, 9, 46, 50, 270, DateTimeKind.Unspecified).AddTicks(5106), 3L, 859, 46L, 136 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 9, 7, 14, 42, 1, 841, DateTimeKind.Unspecified).AddTicks(7608), 655, null, 32L, 465 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 7, 25, 5, 49, 34, 668, DateTimeKind.Unspecified).AddTicks(7406), 2L, 752, true, 19L, 253 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 5, 23, 21, 13, 50, 269, DateTimeKind.Unspecified).AddTicks(4408), 4L, 506, true, 22L, null, 15 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 6, 12, 17, 5, 5, 986, DateTimeKind.Unspecified).AddTicks(8756), 825, null, 44L, 27 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 7, 17, 17, 52, 20, 277, DateTimeKind.Unspecified).AddTicks(759), 3L, 819, 76L, 103 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 2, 2, 19, 7, 5, 924, DateTimeKind.Unspecified).AddTicks(411), 3L, 687, 61L, null, 383 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId" },
                values: new object[] { 28L, new DateTime(2021, 4, 10, 21, 21, 39, 563, DateTimeKind.Unspecified).AddTicks(4556), 1L, 518, 20L, null });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2021, 5, 1, 23, 24, 12, 630, DateTimeKind.Unspecified).AddTicks(1136), 3L, 501, false, 71L, 476 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2021, 10, 3, 10, 42, 27, 603, DateTimeKind.Unspecified).AddTicks(4061), 2L, 706, 26L, 414 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2022, 1, 31, 9, 23, 34, 334, DateTimeKind.Unspecified).AddTicks(1669), 3L, 628, true, null, 4L, 356 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 22L, new DateTime(2021, 12, 11, 14, 48, 0, 923, DateTimeKind.Unspecified).AddTicks(963), 3L, 535, null, 21L, 293 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 5, 24, 6, 4, 24, 455, DateTimeKind.Unspecified).AddTicks(4657), 531, false, 2L, null, 189 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 8, 18, 14, 19, 31, 530, DateTimeKind.Unspecified).AddTicks(338), 1L, 663, false, 28L, 108 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 2, 2, 4, 31, 12, 244, DateTimeKind.Unspecified).AddTicks(6771), 4L, 860, 49L, 114 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LessonId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 5, 5, 16, 5, 7, 462, DateTimeKind.Unspecified).AddTicks(6790), 5L, 56L, 142 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 10, 28, 7, 28, 4, 994, DateTimeKind.Unspecified).AddTicks(7622), 4L, 794, true, null, 2L, 344 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 6, 30, 22, 48, 14, 413, DateTimeKind.Unspecified).AddTicks(6957), 3L, 557, 12L, 456 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 3, 26, 5, 4, 34, 91, DateTimeKind.Unspecified).AddTicks(2329), 2L, 683, true, null, 20L, 278 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 16, 39, 766, DateTimeKind.Unspecified).AddTicks(5317), 4L, 816, 39L, null, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 9, 27, 23, 59, 31, 596, DateTimeKind.Unspecified).AddTicks(3721), 923, true, null, 50L, 453 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 7, 16, 23, 13, 14, 386, DateTimeKind.Unspecified).AddTicks(5703), 5L, 903, false, 57L, 409 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 5, 21, 19, 57, 29, 205, DateTimeKind.Unspecified).AddTicks(5319), 3L, 948, 68L, 437 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 11, 9, 7, 11, 32, 677, DateTimeKind.Unspecified).AddTicks(5129), 1L, 926, 8L, 444 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 6, 26, 9, 13, 17, 475, DateTimeKind.Unspecified).AddTicks(301), 1L, 789, null, 12L, 486 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 12, 17, 18, 43, 15, 647, DateTimeKind.Unspecified).AddTicks(7107), 5L, 612, false, 65L, null, 300 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 6, 10, 15, 52, 58, 652, DateTimeKind.Unspecified).AddTicks(271), 5L, 785, false, null, 12L, 81 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 6, 12, 13, 16, 25, 526, DateTimeKind.Unspecified).AddTicks(9908), 3L, 805, null, 31L, 242 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 4, 1, 3, 20, 37, 712, DateTimeKind.Unspecified).AddTicks(7852), 938, false, 15L, 233 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 3, 29, 17, 49, 35, 77, DateTimeKind.Unspecified).AddTicks(4086), 4L, 878, null, 40L, 499 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 7, 11, 15, 47, 15, 636, DateTimeKind.Unspecified).AddTicks(5066), 3L, 522, 27L, 214 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 7, 28, 2, 56, 26, 586, DateTimeKind.Unspecified).AddTicks(8394), 1L, 536, true, 49L, 335 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2022, 1, 15, 2, 3, 24, 94, DateTimeKind.Unspecified).AddTicks(4641), 3L, 660, null, 17L, 134 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 7, 6, 19, 4, 5, 436, DateTimeKind.Unspecified).AddTicks(4664), 4L, 764, 52L, null, 16 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 7, 26, 0, 17, 41, 66, DateTimeKind.Unspecified).AddTicks(3434), 4L, 893, 74L, null, 340 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 2, 3, 14, 27, 13, 241, DateTimeKind.Unspecified).AddTicks(9533), 4L, 640, false, 40L, 330 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 3, 8, 3, 31, 50, 307, DateTimeKind.Unspecified).AddTicks(5280), 971, true, 32L, null, 33 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 12, 25, 17, 33, 21, 236, DateTimeKind.Unspecified).AddTicks(3013), 823, true, null, 6L, 266 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 11, 13, 22, 4, 59, 537, DateTimeKind.Unspecified).AddTicks(1235), 3L, 754, false, 61L, null, 334 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 10, 10, 23, 58, 24, 559, DateTimeKind.Unspecified).AddTicks(8819), 574, true, 3L, 85 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 2, 28, 19, 16, 3, 327, DateTimeKind.Unspecified).AddTicks(6), 3L, 650, 40L, 160 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 11, 5, 9, 56, 1, 844, DateTimeKind.Unspecified).AddTicks(5861), 1L, 787, false, 46L, null, 274 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 2, 25, 14, 38, 38, 822, DateTimeKind.Unspecified).AddTicks(8659), 1L, 807, false, null, 44L, 354 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 2, 3, 14, 26, 28, 834, DateTimeKind.Unspecified).AddTicks(2280), 661, 19L, 331 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 4, 28, 14, 6, 42, 548, DateTimeKind.Unspecified).AddTicks(447), 685, null, 39L, 11 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 11, 3, 12, 24, 22, 49, DateTimeKind.Unspecified).AddTicks(7450), 546, 48L, 335 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 8, 25, 23, 37, 21, 622, DateTimeKind.Unspecified).AddTicks(5353), 906, 21L, 15 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 11, 23, 18, 39, 7, 516, DateTimeKind.Unspecified).AddTicks(4070), 4L, 601, 46L, null, 193 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 6, 13, 4, 18, 50, 409, DateTimeKind.Unspecified).AddTicks(7546), 4L, 862, true, 77L, null, 270 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 3, 1, 9, 32, 15, 531, DateTimeKind.Unspecified).AddTicks(7827), 2L, 897, null, 22L, 16 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 10, 12, 13, 54, 18, 814, DateTimeKind.Unspecified).AddTicks(6413), 3L, 691, 48L, null, 349 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 9, 10, 2, 52, 5, 118, DateTimeKind.Unspecified).AddTicks(6136), 4L, 602, true, 40L, 233 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 3, 19, 7, 23, 21, 830, DateTimeKind.Unspecified).AddTicks(3757), 2L, 587, 33L, null, 432 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 3, 22, 8, 16, 57, 256, DateTimeKind.Unspecified).AddTicks(2678), 5L, 796, 38L, 158 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 8, 3, 2, 57, 1, 110, DateTimeKind.Unspecified).AddTicks(8123), 867, true, 20L, null, 318 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 6, 13, 7, 0, 35, 98, DateTimeKind.Unspecified).AddTicks(4199), 714, true, 52L, null, 142 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2022, 1, 28, 16, 21, 11, 209, DateTimeKind.Unspecified).AddTicks(9767), 3L, 520, 67L, 336 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 8, 19, 7, 4, 5, 883, DateTimeKind.Unspecified).AddTicks(743), 4L, 615, true, 31L, 55 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 3, 15, 12, 41, 57, 981, DateTimeKind.Unspecified).AddTicks(931), 5L, 817, true, null, 20L, 16 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 4, 7, 4, 6, 1, 297, DateTimeKind.Unspecified).AddTicks(8125), 3L, 610, 35L, 43 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 12, 12, 13, 17, 33, 828, DateTimeKind.Unspecified).AddTicks(5314), 4L, 530, true, 33L, 135 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 11, 12, 22, 49, 17, 830, DateTimeKind.Unspecified).AddTicks(5716), 833, true, 43L, 278 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 8, 26, 17, 8, 57, 525, DateTimeKind.Unspecified).AddTicks(5515), 3L, 843, true, null, 41L, 384 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 9, 20, 7, 32, 16, 373, DateTimeKind.Unspecified).AddTicks(6443), 4L, 906, false, 24L, null, 69 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 4, 22, 20, 30, 20, 846, DateTimeKind.Unspecified).AddTicks(7395), 1L, 870, 46L, 195 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 7, 12, 5, 38, 42, 414, DateTimeKind.Unspecified).AddTicks(6237), 4L, 799, true, 70L, 324 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 2, 28, 0, 19, 44, 281, DateTimeKind.Unspecified).AddTicks(3661), 3L, 723, 68L, null, 301 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 5, 10, 6, 46, 20, 596, DateTimeKind.Unspecified).AddTicks(2348), 1L, 763, false, null, 11L, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2022, 1, 7, 19, 17, 57, 558, DateTimeKind.Unspecified).AddTicks(4872), 4L, 922, null, 51L, 219 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 43L, new DateTime(2021, 8, 9, 14, 43, 27, 946, DateTimeKind.Unspecified).AddTicks(2224), 1L, 764, 48L, null, 391 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 10, 6, 18, 50, 18, 292, DateTimeKind.Unspecified).AddTicks(9340), 2L, 543, null, 25L, 269 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2022, 1, 24, 15, 51, 46, 566, DateTimeKind.Unspecified).AddTicks(2784), 1L, 883, 47L, 243 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 2, 28, 0, 19, 22, 606, DateTimeKind.Unspecified).AddTicks(1668), 4L, 572, false, 44L, null, 357 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 28L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 19L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 30L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 17L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 36L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 49L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 20L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 19L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 23L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 23L, 49L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 18L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 25L, 32L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 25L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 32L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 15L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 29L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 15L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 31L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 31L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 31L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 32L, 36L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 34L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 34L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 32L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 40L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 40L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 9L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 26L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 46L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 43L });

            migrationBuilder.DropColumn(
                name: "CourseRole",
                table: "CourseUsers");

            migrationBuilder.AddColumn<long>(
                name: "CourseRoleId",
                table: "CourseUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "CourseRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRoles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CourseRoles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, false, "admin" },
                    { 2L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, false, "member" }
                });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 16L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 10, 5, 13, 4, 32, 966, DateTimeKind.Unspecified).AddTicks(1803), 31L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 20L, 17L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 9, 16, 1, 29, 40, 294, DateTimeKind.Unspecified).AddTicks(2152), 33L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 42L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 10, 2, 2, 51, 25, 182, DateTimeKind.Unspecified).AddTicks(4391), 90L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 44L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 8, 26, 1, 37, 5, 526, DateTimeKind.Unspecified).AddTicks(6425), 2L, 6L });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 30L, new DateTime(2021, 7, 27, 22, 0, 5, 859, DateTimeKind.Unspecified).AddTicks(8992), 1L, 8L, false },
                    { 2L, 44L, new DateTime(2021, 3, 25, 7, 57, 18, 813, DateTimeKind.Unspecified).AddTicks(8159), 1L, 22L, false },
                    { 2L, 48L, new DateTime(2021, 2, 21, 8, 1, 38, 63, DateTimeKind.Unspecified).AddTicks(2246), 5L, 3L, false },
                    { 3L, 14L, new DateTime(2021, 8, 1, 10, 45, 25, 792, DateTimeKind.Unspecified).AddTicks(1802), 5L, 27L, false },
                    { 3L, 40L, new DateTime(2021, 9, 23, 2, 24, 20, 79, DateTimeKind.Unspecified).AddTicks(5250), 5L, 57L, false },
                    { 5L, 6L, new DateTime(2021, 4, 4, 5, 17, 6, 150, DateTimeKind.Unspecified).AddTicks(6020), 4L, 35L, false },
                    { 5L, 22L, new DateTime(2021, 4, 13, 9, 58, 33, 486, DateTimeKind.Unspecified).AddTicks(7731), 3L, 72L, false },
                    { 5L, 26L, new DateTime(2021, 11, 5, 17, 16, 3, 0, DateTimeKind.Unspecified).AddTicks(9345), 4L, 24L, false },
                    { 5L, 44L, new DateTime(2021, 8, 28, 19, 38, 44, 308, DateTimeKind.Unspecified).AddTicks(6757), 1L, 69L, false },
                    { 5L, 45L, new DateTime(2021, 9, 7, 23, 28, 42, 593, DateTimeKind.Unspecified).AddTicks(5257), 1L, 11L, false },
                    { 6L, 12L, new DateTime(2021, 3, 21, 19, 10, 8, 202, DateTimeKind.Unspecified).AddTicks(3122), 1L, 55L, false },
                    { 8L, 20L, new DateTime(2021, 4, 27, 3, 14, 33, 671, DateTimeKind.Unspecified).AddTicks(2272), 5L, 76L, false },
                    { 9L, 20L, new DateTime(2021, 10, 19, 20, 33, 28, 868, DateTimeKind.Unspecified).AddTicks(8539), 3L, 50L, false },
                    { 9L, 24L, new DateTime(2021, 4, 3, 10, 0, 27, 801, DateTimeKind.Unspecified).AddTicks(5826), 2L, 14L, false },
                    { 10L, 16L, new DateTime(2021, 5, 13, 10, 30, 12, 545, DateTimeKind.Unspecified).AddTicks(713), 2L, 12L, false },
                    { 11L, 2L, new DateTime(2021, 6, 14, 21, 20, 21, 3, DateTimeKind.Unspecified).AddTicks(288), 5L, 99L, false },
                    { 11L, 41L, new DateTime(2021, 6, 16, 12, 46, 9, 4, DateTimeKind.Unspecified).AddTicks(8372), 1L, 61L, false },
                    { 11L, 42L, new DateTime(2021, 10, 25, 23, 55, 49, 6, DateTimeKind.Unspecified).AddTicks(3100), 2L, 92L, false },
                    { 12L, 13L, new DateTime(2021, 8, 29, 19, 21, 2, 490, DateTimeKind.Unspecified).AddTicks(5762), 3L, 29L, false },
                    { 12L, 21L, new DateTime(2021, 10, 16, 12, 17, 4, 994, DateTimeKind.Unspecified).AddTicks(184), 5L, 34L, false },
                    { 12L, 27L, new DateTime(2021, 9, 7, 2, 57, 45, 130, DateTimeKind.Unspecified).AddTicks(2879), 2L, 38L, false },
                    { 13L, 6L, new DateTime(2021, 2, 4, 17, 8, 52, 734, DateTimeKind.Unspecified).AddTicks(4288), 3L, 21L, false },
                    { 13L, 31L, new DateTime(2021, 5, 15, 2, 22, 44, 129, DateTimeKind.Unspecified).AddTicks(8140), 5L, 44L, false },
                    { 13L, 45L, new DateTime(2021, 2, 10, 22, 27, 1, 917, DateTimeKind.Unspecified).AddTicks(2780), 5L, 52L, false },
                    { 13L, 50L, new DateTime(2021, 10, 14, 7, 39, 58, 525, DateTimeKind.Unspecified).AddTicks(5131), 3L, 49L, false },
                    { 14L, 39L, new DateTime(2021, 3, 27, 22, 49, 44, 710, DateTimeKind.Unspecified).AddTicks(9328), 3L, 68L, false },
                    { 14L, 43L, new DateTime(2022, 1, 6, 16, 15, 29, 759, DateTimeKind.Unspecified).AddTicks(5654), 3L, 77L, false },
                    { 15L, 17L, new DateTime(2021, 10, 31, 15, 35, 51, 117, DateTimeKind.Unspecified).AddTicks(2258), 1L, 95L, false },
                    { 15L, 19L, new DateTime(2021, 2, 11, 21, 10, 26, 762, DateTimeKind.Unspecified).AddTicks(6790), 2L, 43L, false },
                    { 15L, 27L, new DateTime(2021, 11, 5, 8, 35, 30, 228, DateTimeKind.Unspecified).AddTicks(2641), 1L, 97L, false },
                    { 15L, 28L, new DateTime(2021, 6, 22, 8, 16, 56, 398, DateTimeKind.Unspecified).AddTicks(9400), 5L, 23L, false },
                    { 15L, 39L, new DateTime(2021, 2, 25, 13, 42, 44, 747, DateTimeKind.Unspecified).AddTicks(3133), 3L, 25L, false },
                    { 17L, 31L, new DateTime(2021, 12, 14, 20, 20, 28, 339, DateTimeKind.Unspecified).AddTicks(9148), 2L, 18L, false },
                    { 17L, 47L, new DateTime(2021, 3, 31, 8, 23, 23, 671, DateTimeKind.Unspecified).AddTicks(4724), 3L, 65L, false },
                    { 18L, 3L, new DateTime(2021, 3, 7, 2, 14, 37, 480, DateTimeKind.Unspecified).AddTicks(9949), 1L, 30L, false },
                    { 19L, 18L, new DateTime(2021, 12, 23, 23, 56, 55, 917, DateTimeKind.Unspecified).AddTicks(1118), 3L, 46L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 19L, 23L, new DateTime(2021, 2, 26, 6, 20, 9, 708, DateTimeKind.Unspecified).AddTicks(1946), 2L, 60L, false },
                    { 19L, 36L, new DateTime(2022, 1, 13, 7, 35, 41, 792, DateTimeKind.Unspecified).AddTicks(7676), 2L, 100L, false },
                    { 20L, 4L, new DateTime(2021, 11, 6, 12, 37, 44, 288, DateTimeKind.Unspecified).AddTicks(7655), 5L, 51L, false },
                    { 20L, 48L, new DateTime(2021, 7, 24, 8, 17, 29, 309, DateTimeKind.Unspecified).AddTicks(4837), 5L, 17L, false },
                    { 20L, 50L, new DateTime(2021, 6, 5, 13, 3, 57, 833, DateTimeKind.Unspecified).AddTicks(7617), 2L, 15L, false },
                    { 21L, 33L, new DateTime(2022, 1, 10, 19, 41, 4, 190, DateTimeKind.Unspecified).AddTicks(8380), 2L, 86L, false },
                    { 21L, 37L, new DateTime(2021, 7, 17, 8, 24, 52, 254, DateTimeKind.Unspecified).AddTicks(3354), 2L, 93L, false },
                    { 21L, 46L, new DateTime(2021, 9, 30, 6, 11, 7, 539, DateTimeKind.Unspecified).AddTicks(2582), 4L, 74L, false },
                    { 22L, 3L, new DateTime(2021, 4, 7, 5, 57, 23, 573, DateTimeKind.Unspecified).AddTicks(7814), 3L, 79L, false },
                    { 22L, 16L, new DateTime(2021, 9, 25, 19, 19, 46, 631, DateTimeKind.Unspecified).AddTicks(6434), 2L, 71L, false },
                    { 22L, 30L, new DateTime(2022, 1, 24, 19, 6, 19, 454, DateTimeKind.Unspecified).AddTicks(860), 2L, 54L, false },
                    { 23L, 3L, new DateTime(2021, 10, 20, 7, 31, 12, 34, DateTimeKind.Unspecified).AddTicks(8261), 1L, 63L, false },
                    { 23L, 15L, new DateTime(2021, 8, 23, 5, 41, 2, 167, DateTimeKind.Unspecified).AddTicks(8790), 5L, 7L, false },
                    { 24L, 13L, new DateTime(2021, 10, 26, 15, 40, 12, 133, DateTimeKind.Unspecified).AddTicks(1105), 1L, 66L, false },
                    { 26L, 12L, new DateTime(2021, 8, 20, 16, 42, 54, 341, DateTimeKind.Unspecified).AddTicks(9957), 5L, 82L, false },
                    { 26L, 41L, new DateTime(2021, 6, 24, 22, 32, 10, 661, DateTimeKind.Unspecified).AddTicks(68), 2L, 58L, false },
                    { 27L, 16L, new DateTime(2021, 12, 24, 11, 30, 29, 421, DateTimeKind.Unspecified).AddTicks(4516), 1L, 73L, false },
                    { 27L, 22L, new DateTime(2021, 8, 1, 16, 18, 3, 187, DateTimeKind.Unspecified).AddTicks(8622), 4L, 96L, false },
                    { 27L, 28L, new DateTime(2021, 12, 26, 3, 16, 54, 936, DateTimeKind.Unspecified).AddTicks(1621), 1L, 28L, false },
                    { 28L, 18L, new DateTime(2021, 11, 1, 6, 46, 16, 217, DateTimeKind.Unspecified).AddTicks(2604), 2L, 81L, false },
                    { 28L, 47L, new DateTime(2021, 4, 2, 15, 18, 9, 139, DateTimeKind.Unspecified).AddTicks(8433), 2L, 89L, false },
                    { 30L, 7L, new DateTime(2022, 1, 28, 2, 25, 21, 774, DateTimeKind.Unspecified).AddTicks(2618), 2L, 36L, false },
                    { 30L, 12L, new DateTime(2021, 12, 8, 14, 50, 47, 694, DateTimeKind.Unspecified).AddTicks(7124), 4L, 39L, false },
                    { 30L, 31L, new DateTime(2021, 12, 5, 4, 36, 28, 512, DateTimeKind.Unspecified).AddTicks(424), 3L, 85L, false },
                    { 30L, 44L, new DateTime(2022, 1, 3, 18, 31, 11, 477, DateTimeKind.Unspecified).AddTicks(2669), 1L, 13L, false },
                    { 32L, 6L, new DateTime(2021, 3, 12, 23, 13, 20, 744, DateTimeKind.Unspecified).AddTicks(8943), 1L, 2L, false },
                    { 32L, 10L, new DateTime(2021, 4, 11, 13, 52, 41, 742, DateTimeKind.Unspecified).AddTicks(6673), 1L, 47L, false },
                    { 33L, 34L, new DateTime(2021, 3, 3, 23, 16, 1, 129, DateTimeKind.Unspecified).AddTicks(1784), 2L, 16L, false },
                    { 34L, 9L, new DateTime(2021, 12, 14, 10, 35, 31, 742, DateTimeKind.Unspecified).AddTicks(6963), 4L, 64L, false },
                    { 37L, 17L, new DateTime(2021, 2, 27, 22, 52, 54, 861, DateTimeKind.Unspecified).AddTicks(6215), 5L, 94L, false },
                    { 37L, 18L, new DateTime(2021, 10, 11, 5, 1, 39, 200, DateTimeKind.Unspecified).AddTicks(8919), 1L, 4L, false },
                    { 37L, 24L, new DateTime(2021, 12, 26, 14, 9, 57, 587, DateTimeKind.Unspecified).AddTicks(4617), 4L, 32L, false },
                    { 38L, 20L, new DateTime(2021, 12, 30, 19, 26, 33, 706, DateTimeKind.Unspecified).AddTicks(2008), 3L, 83L, false },
                    { 38L, 29L, new DateTime(2021, 10, 15, 11, 1, 35, 124, DateTimeKind.Unspecified).AddTicks(6819), 3L, 48L, false },
                    { 39L, 40L, new DateTime(2021, 12, 4, 22, 19, 49, 370, DateTimeKind.Unspecified).AddTicks(6800), 4L, 84L, false },
                    { 40L, 2L, new DateTime(2021, 7, 18, 6, 46, 29, 421, DateTimeKind.Unspecified).AddTicks(4535), 1L, 75L, false },
                    { 40L, 6L, new DateTime(2021, 10, 22, 21, 0, 28, 803, DateTimeKind.Unspecified).AddTicks(2988), 2L, 37L, false },
                    { 41L, 2L, new DateTime(2021, 4, 2, 22, 12, 25, 483, DateTimeKind.Unspecified).AddTicks(50), 1L, 9L, false },
                    { 41L, 13L, new DateTime(2021, 7, 22, 10, 27, 28, 411, DateTimeKind.Unspecified).AddTicks(5821), 1L, 26L, false },
                    { 41L, 30L, new DateTime(2021, 6, 23, 21, 49, 18, 123, DateTimeKind.Unspecified).AddTicks(8427), 2L, 67L, false },
                    { 41L, 41L, new DateTime(2021, 7, 24, 16, 1, 43, 335, DateTimeKind.Unspecified).AddTicks(6429), 1L, 40L, false },
                    { 42L, 21L, new DateTime(2021, 12, 1, 19, 47, 55, 426, DateTimeKind.Unspecified).AddTicks(9902), 1L, 41L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 42L, 26L, new DateTime(2022, 1, 26, 4, 36, 45, 521, DateTimeKind.Unspecified).AddTicks(2441), 4L, 42L, false },
                    { 42L, 34L, new DateTime(2021, 8, 21, 13, 13, 41, 848, DateTimeKind.Unspecified).AddTicks(7395), 4L, 101L, false },
                    { 42L, 51L, new DateTime(2021, 10, 22, 4, 48, 56, 350, DateTimeKind.Unspecified).AddTicks(5936), 4L, 10L, false },
                    { 43L, 7L, new DateTime(2021, 7, 27, 19, 17, 16, 380, DateTimeKind.Unspecified).AddTicks(5975), 5L, 80L, false },
                    { 43L, 45L, new DateTime(2022, 1, 10, 8, 23, 13, 396, DateTimeKind.Unspecified).AddTicks(1309), 2L, 70L, false },
                    { 44L, 28L, new DateTime(2022, 1, 22, 15, 51, 25, 238, DateTimeKind.Unspecified).AddTicks(8543), 2L, 98L, false },
                    { 45L, 34L, new DateTime(2021, 12, 25, 16, 53, 14, 305, DateTimeKind.Unspecified).AddTicks(2798), 1L, 20L, false },
                    { 45L, 44L, new DateTime(2021, 12, 4, 3, 14, 46, 434, DateTimeKind.Unspecified).AddTicks(3042), 2L, 88L, false },
                    { 47L, 33L, new DateTime(2021, 6, 19, 21, 1, 21, 994, DateTimeKind.Unspecified).AddTicks(7223), 3L, 56L, false },
                    { 47L, 49L, new DateTime(2021, 8, 7, 19, 30, 56, 598, DateTimeKind.Unspecified).AddTicks(1566), 2L, 5L, false },
                    { 48L, 10L, new DateTime(2021, 4, 28, 5, 15, 11, 237, DateTimeKind.Unspecified).AddTicks(28), 4L, 19L, false },
                    { 48L, 40L, new DateTime(2021, 4, 15, 11, 26, 28, 656, DateTimeKind.Unspecified).AddTicks(3523), 2L, 53L, false },
                    { 49L, 13L, new DateTime(2021, 8, 15, 16, 58, 58, 568, DateTimeKind.Unspecified).AddTicks(3091), 1L, 87L, false },
                    { 49L, 25L, new DateTime(2021, 2, 19, 15, 24, 39, 900, DateTimeKind.Unspecified).AddTicks(3070), 4L, 59L, false },
                    { 51L, 15L, new DateTime(2021, 3, 25, 7, 42, 43, 964, DateTimeKind.Unspecified).AddTicks(43), 4L, 91L, false },
                    { 51L, 39L, new DateTime(2021, 5, 28, 2, 44, 53, 484, DateTimeKind.Unspecified).AddTicks(2618), 2L, 45L, false }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 15, 22, 46, 32, 274, DateTimeKind.Unspecified).AddTicks(3985), 2L, "Perferendis quod deleniti.\nUllam eos cumque eligendi qui voluptates ut vitae eum omnis.\nMagni harum deserunt velit.", 24L, "Et id animi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 7, 23, 28, 49, 544, DateTimeKind.Unspecified).AddTicks(1619), "Explicabo repellendus perspiciatis et.\nPariatur ipsum asperiores voluptatem accusantium error commodi similique eligendi.", 5L, "Enim unde alias maiores qui similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 13, 12, 0, 24, 212, DateTimeKind.Unspecified).AddTicks(4416), 5L, "Consequatur et facere vero quo et dolorem.\nEa maiores quae numquam soluta ut dolor.\nEsse odio quam possimus assumenda et.\nDolore non est totam in aliquid hic.", 12L, "Aut amet quae in." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 23, 0, 59, 37, 299, DateTimeKind.Unspecified).AddTicks(5280), 3L, "Provident quidem iure officia assumenda id sequi recusandae quo.\nRepellat quas molestiae.", false, 40L, "Ut quam eos nemo repellendus id vel neque impedit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 6, 5, 9, 25, 836, DateTimeKind.Unspecified).AddTicks(3816), 1L, "Dolores quidem voluptatem tenetur quod.", false, 51L, "Itaque quo ea temporibus similique unde." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 2, 0, 30, 15, 21, DateTimeKind.Unspecified).AddTicks(955), 4L, "Commodi perferendis nemo dolorum.\nAssumenda esse dolores quod quasi voluptas qui quos.\nSint repudiandae aut ex sunt excepturi.\nCumque earum quam molestiae minima quos repellendus odio id.\nEnim sunt quasi assumenda fuga quo suscipit aperiam eos culpa.", 26L, "Aut voluptas dolor dignissimos illo et illo soluta ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 23, 22, 17, 2, 787, DateTimeKind.Unspecified).AddTicks(7573), 3L, "Ratione in ex distinctio architecto.", 11L, "Est ut sed aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 3, 15, 44, 47, 482, DateTimeKind.Unspecified).AddTicks(6129), 3L, "Quia tenetur non veniam sed dolor dolore.", true, 31L, "Inventore consequatur sit provident quos quam cumque saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 8, 22, 14, 373, DateTimeKind.Unspecified).AddTicks(7594), 5L, "Qui id eos hic sint quos in rerum est.\nEnim facilis consequatur fuga alias.\nRem quasi blanditiis saepe.", 49L, "Error error neque est porro aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 15, 7, 3, 22, 371, DateTimeKind.Unspecified).AddTicks(9042), "Quis ea quisquam sunt voluptatibus.\nImpedit animi est natus quia magnam id dolorum earum.\nUt eius facilis et expedita amet sed.", false, 7L, "Et odio dolorum consequatur et nihil." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 28, 21, 43, 18, 248, DateTimeKind.Unspecified).AddTicks(9890), "Corporis iusto eius minima aut corrupti nemo placeat.\nDoloremque eum sint quas dolor.\nEt illo qui.", 4L, "A enim necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 21, 51, 40, 110, DateTimeKind.Unspecified).AddTicks(1577), 4L, "Rerum laboriosam libero omnis sunt ullam sit quisquam.\nAccusamus qui laboriosam et commodi.\nIllum dolore animi repellendus.\nOmnis ut debitis nemo quas quod dolorum magnam perferendis quia.\nQuasi molestiae sunt.", 36L, "Sed a maiores esse." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 2, 3, 10, 51, 408, DateTimeKind.Unspecified).AddTicks(2202), 3L, "Eum harum alias aut quod praesentium commodi aliquam.\nSoluta non nihil sapiente facere distinctio repudiandae vel quo.", true, 7L, "Deleniti eum omnis est non pariatur quisquam doloremque voluptatem doloremque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 7, 13, 46, 50, 192, DateTimeKind.Unspecified).AddTicks(5321), 2L, "Corporis eius et laborum minus odio nihil maiores.\nIncidunt aliquid dolores aut quibusdam eveniet quasi consequatur est consectetur.\nNumquam id similique veniam numquam quo quia tenetur voluptas.\nAut et rem sed vel quo beatae.", true, 2L, "Ab omnis magni aliquid blanditiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 13, 6, 55, 38, 674, DateTimeKind.Unspecified).AddTicks(1978), 2L, "Reiciendis quos cumque et ut.\nVoluptatem fugit rem distinctio corporis sed.\nAccusantium voluptatibus quam sit asperiores praesentium.", false, 50L, "Et ut placeat repellat similique molestias sequi nihil quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 25, 13, 20, 39, 493, DateTimeKind.Unspecified).AddTicks(1451), 4L, "Et cum inventore qui hic repellat.\nSit ipsum et.\nCorporis aut officia.\nUt quo eos.", false, 16L, "Sit provident numquam qui illum quibusdam fuga quis sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 1, 5, 802, DateTimeKind.Unspecified).AddTicks(9842), 1L, "Quod quia voluptatem molestias facere.\nUllam eius corporis eius incidunt et omnis est eum.\nNihil quo ut fugiat occaecati dolor quod sint assumenda sed.", 19L, "Voluptatem vel sit debitis ullam tempore aperiam sit qui consequatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 18, 10, 13, 19, 725, DateTimeKind.Unspecified).AddTicks(8611), 5L, "Ea rerum mollitia aut qui itaque.", true, 30L, "Quos dignissimos ut ut nulla ducimus ex." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 4, 8, 0, 56, 372, DateTimeKind.Unspecified).AddTicks(405), 4L, "Quasi a dicta qui est quod et voluptatem.\nMaiores laudantium et rerum molestiae voluptatum.\nAmet rerum suscipit fugiat autem tempora quas aut.\nExpedita accusantium placeat ea iure praesentium aspernatur dolorum iusto aliquid.", true, 42L, "Officiis laudantium eligendi fugiat sapiente eum ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 23, 12, 898, DateTimeKind.Unspecified).AddTicks(3916), "Maxime perferendis et voluptas voluptas blanditiis beatae itaque aperiam.", false, 4L, "Eos consequatur velit vero distinctio non incidunt ut eius." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 21, 3, 23, 19, 906, DateTimeKind.Unspecified).AddTicks(7557), 3L, "Eligendi temporibus doloremque facilis ut ex.\nCorrupti provident sed et porro dicta.", false, 31L, "Commodi ducimus quia sunt architecto fugiat esse." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 17, 11, 9, 18, 472, DateTimeKind.Unspecified).AddTicks(3600), 3L, "Ut qui commodi.", true, 27L, "Fugiat vel magni sunt sunt quia sit exercitationem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 1, 12, 22, 56, 128, DateTimeKind.Unspecified).AddTicks(1832), "Tempora occaecati quo autem consequatur minima minus.\nInventore consequuntur aut qui nulla ea id.\nQui ipsam ab ad in sint iure voluptas.", true, 12L, "Consequatur consequatur qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 19, 2, 17, 24, 400, DateTimeKind.Unspecified).AddTicks(5885), 2L, "Occaecati perferendis aliquid velit voluptates sit aliquam omnis libero.\nId ex maiores quos.", false, 17L, "Cumque eos asperiores magnam est et similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 7, 42, 945, DateTimeKind.Unspecified).AddTicks(6116), 5L, "Ea maiores fugit.\nArchitecto blanditiis eaque voluptatem doloribus.", false, 3L, "Accusamus sed est quisquam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 1, 0, 59, 15, 148, DateTimeKind.Unspecified).AddTicks(2098), 4L, "Voluptatem earum error adipisci odio molestias porro repudiandae.\nQuia nisi omnis doloremque qui.\nMollitia nihil similique eaque repellat optio.\nIure modi aut omnis quis quidem beatae voluptatem.", true, 45L, "Quis qui deleniti provident in ut consectetur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 4, 9, 17, 20, 29, 794, DateTimeKind.Unspecified).AddTicks(2974), 4L, "Laboriosam dignissimos eaque.\nEligendi suscipit voluptatem porro hic cum iste laboriosam sunt cum.\nBeatae quo aut quibusdam.\nVoluptates est nisi ab vitae dignissimos.", 13L, "Reprehenderit excepturi voluptatem mollitia consequatur ad aut quod et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 12, 2, 15, 53, 75, DateTimeKind.Unspecified).AddTicks(8374), 2L, "Sed quo ipsum ipsum et officia.\nIpsa voluptas alias dolor.\nEst aspernatur maiores at.\nCommodi molestiae doloribus dolores.\nUt omnis ipsa aliquam vel deleniti eligendi ut aut.", false, 51L, "Qui culpa ab quam voluptas animi qui et doloribus qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 19, 15, 6, 14, 985, DateTimeKind.Unspecified).AddTicks(7202), 2L, "Eos culpa ea et assumenda quod laborum nostrum vel.\nEt itaque aliquam ut accusamus velit magni nam.\nQuo aliquid quam adipisci.", true, 10L, "Voluptates enim quae rerum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 28, 21, 11, 0, 808, DateTimeKind.Unspecified).AddTicks(4408), 5L, "Quidem accusamus ea delectus dolor recusandae.", true, 4L, "Earum reiciendis voluptatem quis praesentium ea quidem iure ex." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 13, 10, 4, 54, 66, DateTimeKind.Unspecified).AddTicks(8454), 1L, "Quod quam accusamus quo aliquid ea nemo sint deleniti eveniet.\nDeleniti inventore asperiores sit sunt nulla rerum qui.", 27L, "Qui vel et illum nihil porro." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 12, 12, 45, 20, 284, DateTimeKind.Unspecified).AddTicks(393), "Assumenda doloremque illo.\nOfficiis quam error ratione ipsum et odio.", 11L, "Molestiae dignissimos quo itaque vero facilis itaque sint consequatur reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 14, 18, 29, 32, 451, DateTimeKind.Unspecified).AddTicks(8937), 4L, "Similique quis distinctio fugiat sapiente temporibus voluptatum nam id sed.\nIllum saepe rerum qui dicta iste nesciunt dolorem natus.\nEst id repellat.", false, 24L, "Ut consequatur praesentium dolorum fugit officiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 5, 0, 27, 5, 721, DateTimeKind.Unspecified).AddTicks(3779), 4L, "Omnis perspiciatis vitae illo sequi qui.\nModi quis veritatis a quae pariatur.", false, 45L, "Est hic eveniet et ratione repellat et possimus qui amet." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 8, 4, 40, 46, 524, DateTimeKind.Unspecified).AddTicks(8857), 1L, "Et velit maxime rerum.\nVoluptas eum aut dignissimos dolorem tempora ratione expedita.\nSint debitis ut velit natus impedit doloribus pariatur assumenda et.\nEt explicabo error.\nEt iste quae impedit voluptates ratione tenetur voluptas.", true, 31L, "Et eos quo qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 8, 23, 1, 37, 68, DateTimeKind.Unspecified).AddTicks(8878), "Dolor inventore et.", 40L, "Animi soluta cum qui reiciendis porro facilis fuga accusamus molestiae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 8, 11, 52, 38, 75, DateTimeKind.Unspecified).AddTicks(6014), 3L, "Error aperiam assumenda eum sint rem consequatur magnam dicta.\nReprehenderit necessitatibus autem sint veritatis quis magni.\nOfficia minus sunt cupiditate laboriosam id aut vel aut optio.\nEt et exercitationem ut sint vitae.", false, 7L, "Quis sed laborum dolor iusto." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 7, 22, 19, 9, 35, 433, DateTimeKind.Unspecified).AddTicks(1880), 2L, "Atque ullam pariatur perferendis impedit eaque optio doloremque voluptatem.\nEt enim pariatur sit et aspernatur et blanditiis.", 25L, "Ipsum aut nisi recusandae quis necessitatibus vero nisi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 34, 20, 696, DateTimeKind.Unspecified).AddTicks(4680), "Sint a et rem similique.\nVelit ducimus modi non quae saepe quasi.\nHic voluptatem eos a quia accusamus ad.", true, 21L, "Itaque natus veniam sit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 18, 14, 10, 11, 519, DateTimeKind.Unspecified).AddTicks(6331), 4L, "Placeat officiis quo.\nIusto et est et dolore.\nIn velit a ad repellendus optio voluptas vero sed.\nNobis iste sed.", 2L, "Tenetur architecto repudiandae qui molestiae vero nostrum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 2, 1, 48, 37, 773, DateTimeKind.Unspecified).AddTicks(5419), 1L, "Cum necessitatibus consequatur.\nEt voluptatem quisquam dolor commodi asperiores et.", 39L, "Assumenda dolor consectetur animi voluptate totam sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 1, 6, 4, 23, 838, DateTimeKind.Unspecified).AddTicks(1687), 2L, "Animi reiciendis temporibus quos quasi molestias.\nEst delectus non totam rerum ea in ut.\nQuidem quia voluptate sit soluta consectetur nulla fugiat.\nPerferendis cupiditate ut.", true, 6L, "Sunt nihil consectetur facere quia enim aut quod sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 15, 12, 47, 25, 481, DateTimeKind.Unspecified).AddTicks(4693), 2L, "Et beatae qui aperiam tempora aut sed repellendus.\nCulpa fuga dolorem esse impedit.\nDolor voluptate magni a ducimus inventore voluptatibus est.", 46L, "Nobis quia velit sunt." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 18, 1, 53, 31, 265, DateTimeKind.Unspecified).AddTicks(2110), 5L, "Et qui molestias tempora.\nVoluptatem dolor sint nulla.", false, 26L, "Quisquam minima laboriosam architecto eos deserunt temporibus itaque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 2, 20, 44, 11, 3, DateTimeKind.Unspecified).AddTicks(8545), 3L, "Quia voluptatem sapiente qui autem.\nArchitecto et omnis.\nDolorem et impedit.\nMagnam excepturi tempora earum eum consequatur qui.", 50L, "Et illo tempore." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 9, 22, 6, 57, 527, DateTimeKind.Unspecified).AddTicks(287), 1L, "Quidem accusantium consequatur expedita.\nPorro neque aspernatur beatae tempora necessitatibus voluptatem.\nRepellendus ex praesentium iste iure fugit voluptas dolorem pariatur.\nAmet ut aut sed magnam quas ut explicabo.\nUt assumenda quasi cupiditate et vero quidem modi libero quo.", true, 13L, "Vel similique enim blanditiis vitae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 7, 2, 4, 35, 798, DateTimeKind.Unspecified).AddTicks(8026), "Sit repellendus veniam.\nFugit et dolor voluptates deserunt odit dolores earum sed.\nQuo eum eius.\nPlaceat necessitatibus quia aut voluptatum molestias aut qui.\nVeritatis autem in aliquam accusantium aut qui odio.", 14L, "Rem praesentium odit porro et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 21, 15, 46, 47, 190, DateTimeKind.Unspecified).AddTicks(304), 5L, "Magni minima consectetur.\nEt necessitatibus sit voluptatem vitae et eius nemo est.", false, 50L, "Quae possimus sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 56, 24, 241, DateTimeKind.Unspecified).AddTicks(2443), 2L, "Nam nihil officia autem tenetur.\nVoluptas quam asperiores quia voluptate voluptatibus et corrupti.\nNeque excepturi labore impedit saepe.\nModi voluptatibus rem quo est dicta non quidem et quam.\nNeque voluptatibus non suscipit ipsa explicabo veritatis officia labore corrupti.", 7L, "Adipisci pariatur odit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 28, 18, 50, 2, 640, DateTimeKind.Unspecified).AddTicks(2327), "Qui beatae vel dignissimos dignissimos fugit beatae.\nFacilis repudiandae dolor architecto.\nVelit illum rerum sapiente ut sed esse quia sed.\nMolestiae repellat aut odit maiores nam quidem sed.", 13L, "Ducimus vel a." });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 6, 21, 14, 49, 16, 632, DateTimeKind.Unspecified).AddTicks(2411), 2L, new DateTime(2022, 1, 28, 19, 55, 37, 971, DateTimeKind.Unspecified).AddTicks(6149), 56L, new DateTime(2019, 2, 21, 10, 54, 14, 79, DateTimeKind.Unspecified).AddTicks(8802), new DateTime(2021, 10, 1, 0, 56, 20, 367, DateTimeKind.Unspecified).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 12, 17, 9, 40, 1, 67, DateTimeKind.Unspecified).AddTicks(4996), 1L, new DateTime(2022, 1, 28, 16, 45, 0, 100, DateTimeKind.Unspecified).AddTicks(6780), 48L, new DateTime(2019, 4, 2, 10, 9, 27, 241, DateTimeKind.Unspecified).AddTicks(5054), new DateTime(2021, 8, 7, 2, 45, 19, 893, DateTimeKind.Unspecified).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 6, 18, 12, 18, 19, 784, DateTimeKind.Unspecified).AddTicks(1982), 1L, null, 68L, new DateTime(2019, 10, 14, 23, 47, 0, 581, DateTimeKind.Unspecified).AddTicks(5759), new DateTime(2021, 12, 2, 3, 58, 46, 238, DateTimeKind.Unspecified).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 26L, new DateTime(2021, 8, 23, 5, 52, 21, 15, DateTimeKind.Unspecified).AddTicks(7362), 4L, new DateTime(2022, 1, 24, 4, 42, 23, 905, DateTimeKind.Unspecified).AddTicks(8100), 21L, new DateTime(2019, 11, 19, 3, 8, 47, 671, DateTimeKind.Unspecified).AddTicks(8163), new DateTime(2021, 5, 17, 16, 10, 1, 370, DateTimeKind.Unspecified).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 8, 17, 20, 12, 16, 640, DateTimeKind.Unspecified).AddTicks(2279), 3L, new DateTime(2022, 1, 21, 7, 8, 32, 552, DateTimeKind.Unspecified).AddTicks(766), 70L, new DateTime(2019, 12, 10, 10, 14, 16, 230, DateTimeKind.Unspecified).AddTicks(1211), new DateTime(2021, 9, 12, 2, 28, 32, 991, DateTimeKind.Unspecified).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 16L, new DateTime(2021, 3, 14, 15, 25, 24, 596, DateTimeKind.Unspecified).AddTicks(6648), 4L, new DateTime(2022, 1, 17, 12, 27, 36, 212, DateTimeKind.Unspecified).AddTicks(8037), 21L, new DateTime(2020, 1, 20, 22, 45, 19, 388, DateTimeKind.Unspecified).AddTicks(1714), new DateTime(2021, 7, 9, 8, 50, 26, 917, DateTimeKind.Unspecified).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 12, 22, 2, 50, 19, 552, DateTimeKind.Unspecified).AddTicks(8614), 2L, new DateTime(2022, 1, 19, 14, 19, 11, 646, DateTimeKind.Unspecified).AddTicks(4563), 43L, new DateTime(2019, 2, 25, 0, 25, 12, 897, DateTimeKind.Unspecified).AddTicks(4072), new DateTime(2021, 4, 4, 16, 27, 9, 843, DateTimeKind.Unspecified).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 6, 28, 21, 54, 25, 670, DateTimeKind.Unspecified).AddTicks(7565), 1L, new DateTime(2022, 1, 11, 23, 27, 33, 550, DateTimeKind.Unspecified).AddTicks(9711), new DateTime(2019, 7, 9, 22, 51, 1, 37, DateTimeKind.Unspecified).AddTicks(930), new DateTime(2021, 3, 30, 22, 51, 1, 22, DateTimeKind.Unspecified).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 8, 21, 7, 22, 40, 603, DateTimeKind.Unspecified).AddTicks(8843), new DateTime(2022, 1, 14, 10, 18, 41, 671, DateTimeKind.Unspecified).AddTicks(1679), 47L, new DateTime(2019, 2, 13, 19, 45, 54, 844, DateTimeKind.Unspecified).AddTicks(1399), new DateTime(2021, 6, 3, 4, 10, 39, 39, DateTimeKind.Unspecified).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 2, 15, 9, 28, 51, 714, DateTimeKind.Unspecified).AddTicks(589), 2L, new DateTime(2022, 2, 1, 9, 20, 30, 491, DateTimeKind.Unspecified).AddTicks(4706), 77L, new DateTime(2019, 10, 1, 20, 25, 15, 246, DateTimeKind.Unspecified).AddTicks(1439), new DateTime(2021, 2, 4, 10, 33, 27, 130, DateTimeKind.Unspecified).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 6, 16, 9, 59, 48, 471, DateTimeKind.Unspecified).AddTicks(3594), new DateTime(2022, 1, 11, 16, 50, 1, 462, DateTimeKind.Unspecified).AddTicks(2702), 52L, new DateTime(2019, 5, 8, 20, 12, 17, 373, DateTimeKind.Unspecified).AddTicks(7584), new DateTime(2021, 11, 2, 5, 21, 31, 22, DateTimeKind.Unspecified).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 2, 18, 10, 39, 13, 891, DateTimeKind.Unspecified).AddTicks(2803), 3L, null, 59L, new DateTime(2019, 9, 24, 12, 19, 1, 116, DateTimeKind.Unspecified).AddTicks(4624), new DateTime(2021, 7, 9, 15, 18, 23, 349, DateTimeKind.Unspecified).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 9, 22, 17, 9, 34, 301, DateTimeKind.Unspecified).AddTicks(2925), 5L, new DateTime(2022, 1, 9, 16, 19, 49, 23, DateTimeKind.Unspecified).AddTicks(1764), 72L, new DateTime(2019, 9, 13, 9, 47, 52, 531, DateTimeKind.Unspecified).AddTicks(460), new DateTime(2021, 12, 2, 8, 1, 46, 848, DateTimeKind.Unspecified).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 6, 18, 18, 8, 14, 990, DateTimeKind.Unspecified).AddTicks(1840), 4L, null, 71L, new DateTime(2019, 8, 21, 13, 27, 4, 800, DateTimeKind.Unspecified).AddTicks(3291), new DateTime(2021, 2, 17, 10, 12, 51, 571, DateTimeKind.Unspecified).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 10, 2, 13, 9, 6, 894, DateTimeKind.Unspecified).AddTicks(9300), new DateTime(2022, 1, 4, 21, 49, 10, 433, DateTimeKind.Unspecified).AddTicks(777), 74L, new DateTime(2019, 3, 11, 6, 46, 0, 836, DateTimeKind.Unspecified).AddTicks(9374), new DateTime(2021, 5, 19, 14, 33, 50, 29, DateTimeKind.Unspecified).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 6, 22, 2, 53, 48, 226, DateTimeKind.Unspecified).AddTicks(8856), 5L, new DateTime(2022, 1, 13, 15, 17, 33, 54, DateTimeKind.Unspecified).AddTicks(2213), 60L, new DateTime(2019, 12, 29, 0, 26, 27, 186, DateTimeKind.Unspecified).AddTicks(1212), new DateTime(2021, 10, 15, 14, 21, 47, 533, DateTimeKind.Unspecified).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 3, 27, 17, 27, 48, 334, DateTimeKind.Unspecified).AddTicks(3048), 1L, new DateTime(2022, 1, 3, 17, 17, 48, 608, DateTimeKind.Unspecified).AddTicks(4888), 40L, new DateTime(2019, 6, 30, 2, 25, 50, 473, DateTimeKind.Unspecified).AddTicks(5227), new DateTime(2021, 1, 10, 11, 27, 31, 684, DateTimeKind.Unspecified).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 8, 6, 12, 6, 56, 439, DateTimeKind.Unspecified).AddTicks(5640), 1L, new DateTime(2022, 1, 25, 22, 34, 43, 408, DateTimeKind.Unspecified).AddTicks(3578), 25L, new DateTime(2019, 3, 13, 17, 46, 23, 796, DateTimeKind.Unspecified).AddTicks(884), new DateTime(2021, 12, 21, 18, 40, 9, 730, DateTimeKind.Unspecified).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 8, 8, 6, 20, 57, 903, DateTimeKind.Unspecified).AddTicks(2259), 2L, new DateTime(2022, 1, 6, 18, 12, 0, 578, DateTimeKind.Unspecified).AddTicks(9022), 32L, new DateTime(2019, 5, 15, 0, 2, 32, 801, DateTimeKind.Unspecified).AddTicks(4646), new DateTime(2021, 5, 25, 19, 33, 14, 172, DateTimeKind.Unspecified).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 26L, new DateTime(2021, 5, 14, 9, 46, 36, 177, DateTimeKind.Unspecified).AddTicks(5675), 5L, null, 43L, new DateTime(2019, 2, 9, 9, 9, 0, 19, DateTimeKind.Unspecified).AddTicks(3353), new DateTime(2021, 12, 8, 13, 25, 9, 190, DateTimeKind.Unspecified).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 9, 4, 10, 29, 3, 379, DateTimeKind.Unspecified).AddTicks(9666), 5L, new DateTime(2022, 1, 14, 20, 55, 16, 261, DateTimeKind.Unspecified).AddTicks(390), 34L, new DateTime(2019, 11, 26, 3, 53, 46, 118, DateTimeKind.Unspecified).AddTicks(2955), new DateTime(2021, 1, 17, 4, 27, 6, 159, DateTimeKind.Unspecified).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 4, 16, 2, 6, 27, 782, DateTimeKind.Unspecified).AddTicks(3835), 2L, new DateTime(2022, 1, 8, 11, 7, 54, 391, DateTimeKind.Unspecified).AddTicks(6653), 34L, new DateTime(2019, 11, 6, 21, 59, 13, 275, DateTimeKind.Unspecified).AddTicks(6340), new DateTime(2021, 4, 9, 7, 35, 34, 211, DateTimeKind.Unspecified).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 11, 14, 5, 58, 13, 343, DateTimeKind.Unspecified).AddTicks(2962), 1L, new DateTime(2022, 1, 23, 12, 14, 45, 482, DateTimeKind.Unspecified).AddTicks(6447), 67L, new DateTime(2019, 5, 26, 0, 41, 9, 547, DateTimeKind.Unspecified).AddTicks(6201), new DateTime(2021, 11, 26, 15, 32, 45, 339, DateTimeKind.Unspecified).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 9, 19, 22, 46, 1, 379, DateTimeKind.Unspecified).AddTicks(5349), 2L, new DateTime(2022, 1, 14, 8, 25, 56, 819, DateTimeKind.Unspecified).AddTicks(224), 10L, new DateTime(2019, 4, 10, 15, 29, 55, 350, DateTimeKind.Unspecified).AddTicks(143), new DateTime(2021, 8, 7, 7, 8, 29, 218, DateTimeKind.Unspecified).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 10, 8, 17, 36, 31, 505, DateTimeKind.Unspecified).AddTicks(2754), 4L, new DateTime(2022, 1, 11, 23, 14, 28, 340, DateTimeKind.Unspecified).AddTicks(5044), 49L, new DateTime(2019, 12, 4, 20, 50, 53, 747, DateTimeKind.Unspecified).AddTicks(2344), new DateTime(2021, 1, 21, 21, 18, 55, 54, DateTimeKind.Unspecified).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2021, 7, 9, 3, 37, 50, 996, DateTimeKind.Unspecified).AddTicks(1371), 2L, new DateTime(2022, 1, 29, 10, 36, 8, 982, DateTimeKind.Unspecified).AddTicks(1242), 37L, new DateTime(2019, 8, 24, 15, 17, 19, 179, DateTimeKind.Unspecified).AddTicks(4223), new DateTime(2021, 10, 8, 2, 49, 47, 483, DateTimeKind.Unspecified).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 9, 20, 6, 3, 32, 131, DateTimeKind.Unspecified).AddTicks(1468), 1L, new DateTime(2022, 1, 12, 0, 5, 28, 503, DateTimeKind.Unspecified).AddTicks(6700), 54L, new DateTime(2019, 7, 8, 5, 35, 49, 796, DateTimeKind.Unspecified).AddTicks(6905), new DateTime(2021, 12, 19, 4, 26, 54, 285, DateTimeKind.Unspecified).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 12, 15, 22, 55, 59, 133, DateTimeKind.Unspecified).AddTicks(7261), 4L, new DateTime(2022, 1, 23, 4, 36, 7, 944, DateTimeKind.Unspecified).AddTicks(1797), 19L, new DateTime(2020, 1, 23, 0, 18, 18, 509, DateTimeKind.Unspecified).AddTicks(8337), new DateTime(2021, 3, 20, 11, 21, 9, 445, DateTimeKind.Unspecified).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 12, 27, 4, 14, 23, 865, DateTimeKind.Unspecified).AddTicks(727), 5L, null, 36L, new DateTime(2019, 3, 8, 5, 6, 55, 393, DateTimeKind.Unspecified).AddTicks(2627), new DateTime(2021, 11, 12, 1, 59, 19, 909, DateTimeKind.Unspecified).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 48L, new DateTime(2021, 9, 18, 2, 44, 13, 40, DateTimeKind.Unspecified).AddTicks(8682), 1L, new DateTime(2022, 1, 23, 20, 2, 16, 524, DateTimeKind.Unspecified).AddTicks(701), 56L, new DateTime(2019, 11, 23, 21, 19, 54, 213, DateTimeKind.Unspecified).AddTicks(6347), new DateTime(2021, 5, 21, 11, 47, 21, 541, DateTimeKind.Unspecified).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 7, 31, 16, 35, 49, 176, DateTimeKind.Unspecified).AddTicks(5286), 3L, new DateTime(2022, 1, 6, 5, 7, 27, 102, DateTimeKind.Unspecified).AddTicks(5657), 64L, new DateTime(2019, 11, 9, 1, 29, 46, 382, DateTimeKind.Unspecified).AddTicks(3737), new DateTime(2021, 11, 6, 10, 33, 48, 463, DateTimeKind.Unspecified).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 46L, new DateTime(2021, 11, 12, 20, 31, 50, 64, DateTimeKind.Unspecified).AddTicks(8032), 2L, new DateTime(2022, 1, 29, 19, 10, 20, 621, DateTimeKind.Unspecified).AddTicks(8385), 44L, new DateTime(2019, 3, 16, 12, 55, 41, 494, DateTimeKind.Unspecified).AddTicks(1483), new DateTime(2021, 12, 22, 8, 39, 14, 140, DateTimeKind.Unspecified).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 12, 14, 13, 14, 0, 825, DateTimeKind.Unspecified).AddTicks(9047), 3L, new DateTime(2022, 1, 14, 13, 14, 55, 630, DateTimeKind.Unspecified).AddTicks(4757), 26L, new DateTime(2020, 1, 5, 9, 18, 33, 96, DateTimeKind.Unspecified).AddTicks(8950), new DateTime(2021, 10, 4, 8, 52, 4, 86, DateTimeKind.Unspecified).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 9, 30, 20, 18, 30, 287, DateTimeKind.Unspecified).AddTicks(6482), new DateTime(2022, 1, 13, 14, 57, 28, 629, DateTimeKind.Unspecified).AddTicks(9348), 33L, new DateTime(2020, 1, 22, 21, 9, 33, 438, DateTimeKind.Unspecified).AddTicks(4862), new DateTime(2021, 3, 30, 16, 31, 50, 860, DateTimeKind.Unspecified).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 12, 16, 15, 32, 28, 276, DateTimeKind.Unspecified).AddTicks(5637), 2L, new DateTime(2022, 1, 31, 9, 32, 38, 458, DateTimeKind.Unspecified).AddTicks(8360), 76L, new DateTime(2019, 12, 13, 6, 21, 32, 871, DateTimeKind.Unspecified).AddTicks(910), new DateTime(2021, 4, 27, 5, 43, 51, 154, DateTimeKind.Unspecified).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 6, 4, 18, 20, 38, 977, DateTimeKind.Unspecified).AddTicks(8206), 2L, null, 25L, new DateTime(2019, 10, 11, 12, 25, 51, 163, DateTimeKind.Unspecified).AddTicks(9669), new DateTime(2021, 2, 7, 5, 9, 52, 267, DateTimeKind.Unspecified).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 2, 26, 22, 26, 10, 542, DateTimeKind.Unspecified).AddTicks(989), 3L, new DateTime(2022, 1, 23, 13, 40, 23, 266, DateTimeKind.Unspecified).AddTicks(8897), 65L, new DateTime(2020, 1, 14, 7, 58, 5, 716, DateTimeKind.Unspecified).AddTicks(1968), new DateTime(2021, 6, 29, 7, 35, 17, 292, DateTimeKind.Unspecified).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 21L, new DateTime(2021, 8, 6, 22, 1, 18, 251, DateTimeKind.Unspecified).AddTicks(3794), 3L, new DateTime(2022, 1, 24, 7, 10, 29, 277, DateTimeKind.Unspecified).AddTicks(2130), 11L, new DateTime(2019, 9, 28, 17, 55, 11, 572, DateTimeKind.Unspecified).AddTicks(8276), new DateTime(2021, 1, 11, 0, 25, 53, 89, DateTimeKind.Unspecified).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 12, 13, 0, 31, 11, 922, DateTimeKind.Unspecified).AddTicks(1347), 1L, new DateTime(2022, 1, 17, 6, 36, 3, 105, DateTimeKind.Unspecified).AddTicks(2366), 17L, new DateTime(2019, 7, 22, 17, 3, 32, 668, DateTimeKind.Unspecified).AddTicks(3312), new DateTime(2021, 7, 24, 7, 59, 36, 755, DateTimeKind.Unspecified).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 5, 8, 13, 50, 6, 114, DateTimeKind.Unspecified).AddTicks(3019), 3L, new DateTime(2022, 1, 31, 23, 41, 38, 463, DateTimeKind.Unspecified).AddTicks(654), 34L, new DateTime(2019, 9, 13, 3, 32, 37, 917, DateTimeKind.Unspecified).AddTicks(868), new DateTime(2021, 4, 18, 5, 24, 36, 561, DateTimeKind.Unspecified).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 9, 30, 1, 44, 30, 757, DateTimeKind.Unspecified).AddTicks(5812), new DateTime(2022, 1, 13, 5, 5, 3, 274, DateTimeKind.Unspecified).AddTicks(2168), 23L, new DateTime(2020, 1, 19, 2, 40, 9, 70, DateTimeKind.Unspecified).AddTicks(7168), new DateTime(2021, 9, 24, 17, 57, 29, 913, DateTimeKind.Unspecified).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 11, 24, 3, 49, 36, 232, DateTimeKind.Unspecified).AddTicks(627), 4L, null, 69L, new DateTime(2019, 4, 25, 16, 51, 41, 205, DateTimeKind.Unspecified).AddTicks(1209), new DateTime(2021, 1, 7, 15, 47, 51, 713, DateTimeKind.Unspecified).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 3, 27, 3, 39, 20, 200, DateTimeKind.Unspecified).AddTicks(3606), new DateTime(2022, 1, 18, 23, 22, 4, 711, DateTimeKind.Unspecified).AddTicks(9982), 52L, new DateTime(2019, 7, 21, 17, 32, 50, 354, DateTimeKind.Unspecified).AddTicks(3123), new DateTime(2021, 9, 9, 22, 38, 51, 186, DateTimeKind.Unspecified).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 2, 24, 15, 10, 16, 780, DateTimeKind.Unspecified).AddTicks(8683), 5L, new DateTime(2022, 1, 26, 0, 37, 37, 963, DateTimeKind.Unspecified).AddTicks(907), 67L, new DateTime(2019, 10, 6, 1, 50, 14, 20, DateTimeKind.Unspecified).AddTicks(9780), new DateTime(2021, 7, 26, 10, 58, 44, 810, DateTimeKind.Unspecified).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 10, 29, 11, 24, 42, 502, DateTimeKind.Unspecified).AddTicks(2710), 5L, new DateTime(2022, 1, 16, 10, 13, 3, 85, DateTimeKind.Unspecified).AddTicks(9192), 11L, new DateTime(2019, 8, 29, 14, 23, 1, 523, DateTimeKind.Unspecified).AddTicks(1818), new DateTime(2021, 12, 28, 7, 55, 21, 307, DateTimeKind.Unspecified).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 7, 19, 19, 49, 51, 917, DateTimeKind.Unspecified).AddTicks(2053), 5L, new DateTime(2022, 1, 26, 17, 31, 44, 548, DateTimeKind.Unspecified).AddTicks(3928), 12L, new DateTime(2019, 8, 9, 13, 33, 49, 464, DateTimeKind.Unspecified).AddTicks(1573), new DateTime(2021, 3, 2, 17, 1, 58, 676, DateTimeKind.Unspecified).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 44L, new DateTime(2021, 9, 5, 3, 2, 23, 951, DateTimeKind.Unspecified).AddTicks(5075), 5L, new DateTime(2022, 1, 7, 4, 15, 24, 290, DateTimeKind.Unspecified).AddTicks(3334), 51L, new DateTime(2019, 7, 17, 16, 14, 13, 213, DateTimeKind.Unspecified).AddTicks(6519), new DateTime(2021, 10, 11, 14, 35, 11, 826, DateTimeKind.Unspecified).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 26L, new DateTime(2021, 2, 17, 21, 56, 51, 232, DateTimeKind.Unspecified).AddTicks(1074), 3L, new DateTime(2022, 1, 4, 22, 56, 33, 747, DateTimeKind.Unspecified).AddTicks(2981), 10L, new DateTime(2019, 6, 11, 8, 2, 47, 516, DateTimeKind.Unspecified).AddTicks(766), new DateTime(2021, 7, 12, 10, 38, 51, 921, DateTimeKind.Unspecified).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 9, 2, 15, 9, 22, 67, DateTimeKind.Unspecified).AddTicks(230), 3L, new DateTime(2022, 1, 20, 5, 30, 3, 796, DateTimeKind.Unspecified).AddTicks(6358), 9L, new DateTime(2019, 11, 18, 13, 27, 6, 520, DateTimeKind.Unspecified).AddTicks(5773), new DateTime(2021, 11, 8, 9, 9, 41, 127, DateTimeKind.Unspecified).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 11, 24, 17, 38, 59, 802, DateTimeKind.Unspecified).AddTicks(2381), 3L, new DateTime(2022, 1, 16, 18, 52, 23, 212, DateTimeKind.Unspecified).AddTicks(7151), 43L, new DateTime(2019, 3, 15, 4, 41, 46, 692, DateTimeKind.Unspecified).AddTicks(3727), new DateTime(2021, 4, 20, 11, 42, 9, 998, DateTimeKind.Unspecified).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 4, 13, 17, 14, 28, 330, DateTimeKind.Unspecified).AddTicks(337), 1L, null, 32L, new DateTime(2019, 6, 15, 15, 22, 39, 635, DateTimeKind.Unspecified).AddTicks(7410), new DateTime(2021, 3, 30, 6, 44, 6, 808, DateTimeKind.Unspecified).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 9, 17, 10, 23, 48, 752, DateTimeKind.Unspecified).AddTicks(7855), 4L, new DateTime(2022, 1, 1, 4, 17, 13, 604, DateTimeKind.Unspecified).AddTicks(4860), 56L, new DateTime(2020, 1, 21, 0, 51, 27, 821, DateTimeKind.Unspecified).AddTicks(4746), new DateTime(2021, 1, 27, 1, 50, 1, 25, DateTimeKind.Unspecified).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 8, 21, 21, 1, 50, 953, DateTimeKind.Unspecified).AddTicks(8893), 1L, new DateTime(2022, 1, 12, 7, 32, 40, 407, DateTimeKind.Unspecified).AddTicks(7123), 59L, new DateTime(2019, 6, 8, 20, 36, 8, 273, DateTimeKind.Unspecified).AddTicks(5818), new DateTime(2021, 11, 6, 9, 38, 17, 487, DateTimeKind.Unspecified).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 12, 19, 22, 11, 53, 65, DateTimeKind.Unspecified).AddTicks(2770), new DateTime(2022, 1, 18, 8, 49, 15, 110, DateTimeKind.Unspecified).AddTicks(5334), 29L, new DateTime(2019, 10, 6, 21, 10, 58, 594, DateTimeKind.Unspecified).AddTicks(9746), new DateTime(2021, 10, 11, 2, 12, 34, 753, DateTimeKind.Unspecified).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 4, 6, 21, 2, 4, 717, DateTimeKind.Unspecified).AddTicks(2023), 2L, new DateTime(2022, 1, 16, 14, 47, 50, 680, DateTimeKind.Unspecified).AddTicks(1022), 39L, new DateTime(2020, 1, 4, 7, 59, 57, 740, DateTimeKind.Unspecified).AddTicks(1316), new DateTime(2021, 12, 7, 20, 35, 24, 732, DateTimeKind.Unspecified).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 11, 18, 20, 23, 5, 512, DateTimeKind.Unspecified).AddTicks(5486), 3L, new DateTime(2022, 1, 6, 22, 12, 28, 286, DateTimeKind.Unspecified).AddTicks(7718), 21L, new DateTime(2019, 4, 30, 2, 42, 24, 379, DateTimeKind.Unspecified).AddTicks(9005), new DateTime(2021, 10, 18, 1, 14, 15, 385, DateTimeKind.Unspecified).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 3, 3, 4, 32, 1, 757, DateTimeKind.Unspecified).AddTicks(619), 4L, new DateTime(2022, 1, 31, 18, 58, 36, 436, DateTimeKind.Unspecified).AddTicks(4805), 73L, new DateTime(2019, 7, 24, 17, 26, 12, 556, DateTimeKind.Unspecified).AddTicks(7916), new DateTime(2021, 2, 12, 11, 55, 6, 22, DateTimeKind.Unspecified).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 5, 26, 1, 17, 10, 870, DateTimeKind.Unspecified).AddTicks(4383), 4L, new DateTime(2022, 1, 24, 6, 55, 23, 972, DateTimeKind.Unspecified).AddTicks(4469), 45L, new DateTime(2020, 1, 8, 3, 56, 24, 347, DateTimeKind.Unspecified).AddTicks(7330), new DateTime(2021, 12, 22, 13, 59, 31, 98, DateTimeKind.Unspecified).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 11, 24, 16, 12, 4, 758, DateTimeKind.Unspecified).AddTicks(1023), null, 44L, new DateTime(2019, 8, 9, 6, 26, 46, 397, DateTimeKind.Unspecified).AddTicks(5338), new DateTime(2021, 11, 19, 23, 5, 52, 616, DateTimeKind.Unspecified).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2022, 1, 3, 11, 11, 47, 591, DateTimeKind.Unspecified).AddTicks(6880), 2L, new DateTime(2022, 1, 26, 7, 40, 14, 105, DateTimeKind.Unspecified).AddTicks(4327), 72L, new DateTime(2019, 7, 28, 22, 22, 53, 940, DateTimeKind.Unspecified).AddTicks(3087), new DateTime(2021, 7, 12, 22, 20, 23, 117, DateTimeKind.Unspecified).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 21L, new DateTime(2021, 11, 27, 10, 6, 38, 391, DateTimeKind.Unspecified).AddTicks(9686), 5L, null, 50L, new DateTime(2019, 9, 26, 11, 57, 56, 396, DateTimeKind.Unspecified).AddTicks(7476), new DateTime(2021, 5, 3, 22, 44, 52, 242, DateTimeKind.Unspecified).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 11, 15, 5, 19, 2, 173, DateTimeKind.Unspecified).AddTicks(9116), 5L, new DateTime(2022, 1, 6, 17, 10, 30, 354, DateTimeKind.Unspecified).AddTicks(5390), 40L, new DateTime(2019, 10, 23, 1, 56, 36, 739, DateTimeKind.Unspecified).AddTicks(5219), new DateTime(2021, 7, 27, 7, 34, 0, 451, DateTimeKind.Unspecified).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 7L, new DateTime(2022, 2, 1, 21, 51, 46, 978, DateTimeKind.Unspecified).AddTicks(3562), new DateTime(2022, 1, 26, 22, 39, 1, 461, DateTimeKind.Unspecified).AddTicks(7963), 31L, new DateTime(2019, 12, 21, 4, 11, 6, 747, DateTimeKind.Unspecified).AddTicks(7350), new DateTime(2021, 6, 30, 15, 20, 41, 16, DateTimeKind.Unspecified).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 7L, new DateTime(2021, 11, 24, 22, 57, 19, 603, DateTimeKind.Unspecified).AddTicks(945), 2L, new DateTime(2022, 1, 15, 17, 36, 54, 801, DateTimeKind.Unspecified).AddTicks(4274), 75L, new DateTime(2019, 8, 31, 21, 48, 46, 80, DateTimeKind.Unspecified).AddTicks(4438), new DateTime(2021, 10, 9, 21, 9, 19, 111, DateTimeKind.Unspecified).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 3, 20, 11, 41, 2, 681, DateTimeKind.Unspecified).AddTicks(8674), 2L, new DateTime(2022, 1, 16, 21, 10, 33, 554, DateTimeKind.Unspecified).AddTicks(7161), 55L, new DateTime(2019, 6, 22, 9, 4, 59, 758, DateTimeKind.Unspecified).AddTicks(4778), new DateTime(2021, 8, 25, 2, 24, 56, 652, DateTimeKind.Unspecified).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2022, 1, 21, 14, 34, 42, 781, DateTimeKind.Unspecified).AddTicks(964), 3L, new DateTime(2022, 1, 25, 23, 40, 23, 345, DateTimeKind.Unspecified).AddTicks(9512), 80L, new DateTime(2019, 2, 25, 13, 51, 27, 169, DateTimeKind.Unspecified).AddTicks(5453), new DateTime(2021, 12, 13, 15, 51, 57, 556, DateTimeKind.Unspecified).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 2, 6, 4, 3, 45, 496, DateTimeKind.Unspecified).AddTicks(8994), 5L, null, 14L, new DateTime(2019, 7, 18, 23, 24, 20, 698, DateTimeKind.Unspecified).AddTicks(239), new DateTime(2021, 7, 30, 0, 33, 35, 564, DateTimeKind.Unspecified).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 9, 21, 17, 53, 54, 870, DateTimeKind.Unspecified).AddTicks(9302), 1L, new DateTime(2022, 1, 19, 21, 22, 5, 334, DateTimeKind.Unspecified).AddTicks(3076), 26L, new DateTime(2019, 10, 6, 16, 12, 42, 120, DateTimeKind.Unspecified).AddTicks(1206), new DateTime(2021, 1, 8, 0, 33, 27, 248, DateTimeKind.Unspecified).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 8, 20, 20, 11, 25, 366, DateTimeKind.Unspecified).AddTicks(8790), 4L, null, 40L, new DateTime(2019, 11, 29, 12, 48, 5, 815, DateTimeKind.Unspecified).AddTicks(6300), new DateTime(2021, 12, 28, 3, 36, 32, 84, DateTimeKind.Unspecified).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 8, 26, 17, 39, 50, 138, DateTimeKind.Unspecified).AddTicks(3160), 4L, new DateTime(2022, 1, 9, 15, 50, 17, 226, DateTimeKind.Unspecified).AddTicks(7106), 32L, new DateTime(2019, 11, 26, 11, 53, 39, 417, DateTimeKind.Unspecified).AddTicks(7752), new DateTime(2021, 12, 9, 9, 47, 24, 980, DateTimeKind.Unspecified).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 16L, new DateTime(2021, 8, 17, 3, 21, 45, 42, DateTimeKind.Unspecified).AddTicks(8968), new DateTime(2022, 1, 4, 4, 58, 3, 592, DateTimeKind.Unspecified).AddTicks(6869), 30L, new DateTime(2019, 10, 9, 6, 15, 48, 706, DateTimeKind.Unspecified).AddTicks(3915), new DateTime(2021, 6, 6, 16, 0, 7, 859, DateTimeKind.Unspecified).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 6, 17, 12, 18, 22, 924, DateTimeKind.Unspecified).AddTicks(4748), 4L, new DateTime(2022, 1, 6, 16, 39, 6, 200, DateTimeKind.Unspecified).AddTicks(1230), 58L, new DateTime(2019, 5, 31, 2, 7, 45, 923, DateTimeKind.Unspecified).AddTicks(9834), new DateTime(2021, 7, 5, 7, 51, 4, 480, DateTimeKind.Unspecified).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 46L, new DateTime(2022, 1, 11, 14, 40, 45, 288, DateTimeKind.Unspecified).AddTicks(6857), 1L, new DateTime(2022, 1, 15, 8, 32, 18, 15, DateTimeKind.Unspecified).AddTicks(4663), 31L, new DateTime(2019, 3, 20, 15, 9, 16, 789, DateTimeKind.Unspecified).AddTicks(5219), new DateTime(2021, 6, 1, 17, 55, 13, 660, DateTimeKind.Unspecified).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 46L, new DateTime(2021, 2, 25, 2, 4, 56, 809, DateTimeKind.Unspecified).AddTicks(286), 3L, new DateTime(2022, 1, 28, 3, 53, 32, 526, DateTimeKind.Unspecified).AddTicks(1745), 66L, new DateTime(2019, 3, 15, 18, 12, 24, 738, DateTimeKind.Unspecified).AddTicks(1757), new DateTime(2021, 3, 4, 6, 57, 15, 455, DateTimeKind.Unspecified).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 4, 9, 1, 25, 1, 124, DateTimeKind.Unspecified).AddTicks(3352), 1L, new DateTime(2022, 1, 10, 7, 26, 14, 644, DateTimeKind.Unspecified).AddTicks(6064), 45L, new DateTime(2019, 9, 21, 1, 48, 23, 833, DateTimeKind.Unspecified).AddTicks(824), new DateTime(2021, 2, 26, 4, 53, 39, 732, DateTimeKind.Unspecified).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 8, 9, 16, 48, 50, 268, DateTimeKind.Unspecified).AddTicks(3293), new DateTime(2022, 1, 14, 3, 58, 31, 162, DateTimeKind.Unspecified).AddTicks(3339), 16L, new DateTime(2019, 3, 22, 0, 31, 35, 355, DateTimeKind.Unspecified).AddTicks(6025), new DateTime(2021, 8, 19, 2, 19, 32, 846, DateTimeKind.Unspecified).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 48L, new DateTime(2021, 2, 20, 7, 43, 5, 753, DateTimeKind.Unspecified).AddTicks(1036), 3L, new DateTime(2022, 1, 10, 5, 35, 35, 370, DateTimeKind.Unspecified).AddTicks(538), 25L, new DateTime(2019, 11, 14, 22, 42, 41, 132, DateTimeKind.Unspecified).AddTicks(996), new DateTime(2021, 8, 23, 6, 57, 35, 666, DateTimeKind.Unspecified).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 3, 22, 14, 16, 56, 225, DateTimeKind.Unspecified).AddTicks(2233), 3L, new DateTime(2022, 1, 21, 14, 30, 39, 468, DateTimeKind.Unspecified).AddTicks(3545), 81L, new DateTime(2019, 9, 14, 5, 0, 39, 501, DateTimeKind.Unspecified).AddTicks(7186), new DateTime(2021, 1, 16, 4, 35, 30, 17, DateTimeKind.Unspecified).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 10, 6, 15, 51, 59, 438, DateTimeKind.Unspecified).AddTicks(654), 3L, new DateTime(2022, 1, 5, 11, 24, 42, 223, DateTimeKind.Unspecified).AddTicks(2140), 81L, new DateTime(2019, 12, 26, 20, 0, 39, 712, DateTimeKind.Unspecified).AddTicks(3240), new DateTime(2021, 3, 30, 0, 45, 58, 154, DateTimeKind.Unspecified).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 5, 21, 13, 36, 54, 764, DateTimeKind.Unspecified).AddTicks(9025), new DateTime(2022, 1, 16, 16, 20, 43, 634, DateTimeKind.Unspecified).AddTicks(9502), 47L, new DateTime(2019, 9, 30, 6, 59, 23, 425, DateTimeKind.Unspecified).AddTicks(1816), new DateTime(2021, 8, 18, 19, 18, 26, 613, DateTimeKind.Unspecified).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2022, 1, 6, 8, 0, 25, 59, DateTimeKind.Unspecified).AddTicks(742), new DateTime(2022, 1, 30, 5, 31, 49, 182, DateTimeKind.Unspecified).AddTicks(1033), 21L, new DateTime(2019, 4, 18, 16, 4, 50, 153, DateTimeKind.Unspecified).AddTicks(3382), new DateTime(2021, 5, 14, 12, 27, 40, 645, DateTimeKind.Unspecified).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 47L, new DateTime(2021, 3, 18, 17, 32, 34, 819, DateTimeKind.Unspecified).AddTicks(4941), 2L, new DateTime(2022, 1, 11, 18, 10, 34, 551, DateTimeKind.Unspecified).AddTicks(42), 78L, new DateTime(2019, 6, 24, 4, 33, 13, 874, DateTimeKind.Unspecified).AddTicks(9166), new DateTime(2021, 5, 5, 12, 18, 4, 43, DateTimeKind.Unspecified).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 11, 14, 19, 24, 3, 899, DateTimeKind.Unspecified).AddTicks(69), 1L, null, 38L, new DateTime(2020, 1, 14, 18, 41, 9, 568, DateTimeKind.Unspecified).AddTicks(887), new DateTime(2021, 7, 18, 18, 22, 32, 920, DateTimeKind.Unspecified).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 4, 7, 21, 28, 1, 486, DateTimeKind.Unspecified).AddTicks(3893), new DateTime(2022, 1, 27, 9, 47, 16, 828, DateTimeKind.Unspecified).AddTicks(4837), 24L, new DateTime(2019, 11, 13, 20, 11, 50, 383, DateTimeKind.Unspecified).AddTicks(378), new DateTime(2021, 12, 18, 23, 24, 48, 502, DateTimeKind.Unspecified).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 3, 24, 1, 43, 7, 255, DateTimeKind.Unspecified).AddTicks(3184), new DateTime(2022, 1, 11, 11, 38, 39, 363, DateTimeKind.Unspecified).AddTicks(6344), 29L, new DateTime(2019, 10, 19, 12, 8, 21, 448, DateTimeKind.Unspecified).AddTicks(347), new DateTime(2021, 12, 10, 14, 7, 51, 200, DateTimeKind.Unspecified).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 9, 13, 9, 39, 47, 922, DateTimeKind.Unspecified).AddTicks(9320), 3L, null, 22L, new DateTime(2019, 11, 5, 5, 10, 15, 836, DateTimeKind.Unspecified).AddTicks(7944), new DateTime(2021, 1, 25, 9, 10, 19, 167, DateTimeKind.Unspecified).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 10, 2, 15, 14, 6, 469, DateTimeKind.Unspecified).AddTicks(8257), 4L, new DateTime(2022, 1, 7, 19, 10, 40, 480, DateTimeKind.Unspecified).AddTicks(289), 57L, new DateTime(2019, 10, 8, 10, 18, 27, 330, DateTimeKind.Unspecified).AddTicks(3887), new DateTime(2021, 8, 12, 14, 14, 0, 30, DateTimeKind.Unspecified).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 10, 4, 19, 26, 24, 75, DateTimeKind.Unspecified).AddTicks(3538), new DateTime(2022, 1, 1, 15, 51, 23, 376, DateTimeKind.Unspecified).AddTicks(1004), 57L, new DateTime(2019, 10, 17, 18, 23, 16, 526, DateTimeKind.Unspecified).AddTicks(1514), new DateTime(2021, 9, 12, 5, 13, 53, 7, DateTimeKind.Unspecified).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 5, 18, 23, 1, 55, 107, DateTimeKind.Unspecified).AddTicks(3335), new DateTime(2022, 1, 29, 0, 37, 15, 831, DateTimeKind.Unspecified).AddTicks(7684), 15L, new DateTime(2019, 9, 28, 6, 37, 9, 852, DateTimeKind.Unspecified).AddTicks(4103), new DateTime(2021, 7, 7, 14, 17, 24, 333, DateTimeKind.Unspecified).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 2, 15, 19, 24, 35, 424, DateTimeKind.Unspecified).AddTicks(6456), 3L, new DateTime(2022, 1, 27, 6, 58, 9, 834, DateTimeKind.Unspecified).AddTicks(7942), 2L, new DateTime(2019, 11, 21, 10, 44, 9, 617, DateTimeKind.Unspecified).AddTicks(6184), new DateTime(2021, 7, 8, 2, 17, 12, 344, DateTimeKind.Unspecified).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 6, 27, 13, 2, 47, 822, DateTimeKind.Unspecified).AddTicks(5140), 4L, new DateTime(2022, 2, 1, 16, 11, 43, 992, DateTimeKind.Unspecified).AddTicks(7352), 48L, new DateTime(2019, 7, 18, 8, 31, 25, 846, DateTimeKind.Unspecified).AddTicks(5680), new DateTime(2021, 6, 9, 14, 48, 27, 997, DateTimeKind.Unspecified).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 7, 14, 14, 26, 7, 241, DateTimeKind.Unspecified).AddTicks(238), 3L, new DateTime(2022, 1, 28, 4, 10, 37, 441, DateTimeKind.Unspecified).AddTicks(1549), 65L, new DateTime(2019, 10, 22, 2, 0, 38, 116, DateTimeKind.Unspecified).AddTicks(844), new DateTime(2021, 12, 29, 5, 33, 9, 211, DateTimeKind.Unspecified).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 21L, new DateTime(2021, 12, 8, 11, 24, 56, 987, DateTimeKind.Unspecified).AddTicks(43), 4L, new DateTime(2022, 1, 24, 3, 0, 58, 815, DateTimeKind.Unspecified).AddTicks(9805), 38L, new DateTime(2019, 4, 16, 21, 18, 39, 758, DateTimeKind.Unspecified).AddTicks(4763), new DateTime(2021, 12, 24, 23, 52, 27, 242, DateTimeKind.Unspecified).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 10, 18, 13, 12, 5, 179, DateTimeKind.Unspecified).AddTicks(9417), 1L, new DateTime(2022, 1, 7, 19, 13, 9, 878, DateTimeKind.Unspecified).AddTicks(2128), 56L, new DateTime(2019, 4, 11, 9, 2, 14, 794, DateTimeKind.Unspecified).AddTicks(3353), new DateTime(2021, 7, 3, 12, 16, 48, 82, DateTimeKind.Unspecified).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 4, 28, 22, 33, 16, 317, DateTimeKind.Unspecified).AddTicks(2188), new DateTime(2022, 1, 1, 9, 37, 8, 259, DateTimeKind.Unspecified).AddTicks(1027), 8L, new DateTime(2019, 12, 11, 19, 30, 3, 174, DateTimeKind.Unspecified).AddTicks(1052), new DateTime(2021, 1, 22, 8, 16, 22, 683, DateTimeKind.Unspecified).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 9, 5, 10, 39, 19, 422, DateTimeKind.Unspecified).AddTicks(87), new DateTime(2022, 1, 22, 18, 52, 40, 383, DateTimeKind.Unspecified).AddTicks(8149), 35L, new DateTime(2019, 3, 18, 20, 21, 17, 284, DateTimeKind.Unspecified).AddTicks(4090), new DateTime(2021, 4, 11, 5, 7, 50, 278, DateTimeKind.Unspecified).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2022, 1, 1, 6, 23, 45, 184, DateTimeKind.Unspecified).AddTicks(728), 3L, new DateTime(2022, 1, 6, 17, 19, 36, 22, DateTimeKind.Unspecified).AddTicks(7121), 34L, new DateTime(2020, 1, 8, 19, 25, 52, 932, DateTimeKind.Unspecified).AddTicks(104), new DateTime(2021, 4, 8, 11, 25, 48, 169, DateTimeKind.Unspecified).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 6, 28, 9, 4, 50, 682, DateTimeKind.Unspecified).AddTicks(4056), 4L, new DateTime(2022, 1, 13, 2, 44, 43, 246, DateTimeKind.Unspecified).AddTicks(3370), 79L, new DateTime(2019, 5, 31, 11, 10, 22, 322, DateTimeKind.Unspecified).AddTicks(9491), new DateTime(2021, 11, 2, 18, 23, 46, 904, DateTimeKind.Unspecified).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 5, 15, 8, 31, 2, 700, DateTimeKind.Unspecified).AddTicks(3649), 5L, new DateTime(2022, 1, 8, 14, 50, 4, 100, DateTimeKind.Unspecified).AddTicks(5815), 39L, new DateTime(2019, 4, 14, 8, 29, 31, 169, DateTimeKind.Unspecified).AddTicks(2580), new DateTime(2021, 7, 23, 12, 5, 45, 993, DateTimeKind.Unspecified).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 9, 11, 6, 21, 12, 271, DateTimeKind.Unspecified).AddTicks(1625), 5L, new DateTime(2022, 1, 9, 17, 10, 39, 155, DateTimeKind.Unspecified).AddTicks(7385), 12L, new DateTime(2019, 5, 15, 3, 2, 51, 457, DateTimeKind.Unspecified).AddTicks(3330), new DateTime(2021, 12, 16, 17, 12, 34, 686, DateTimeKind.Unspecified).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 13L, "Enim amet qui cum earum laboriosam officiis et.\nDolor maiores nihil aliquam natus sit possimus aperiam.\nVel temporibus laboriosam sunt adipisci.", new DateTime(2021, 4, 20, 2, 40, 53, 103, DateTimeKind.Unspecified).AddTicks(3889), 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Esse beatae perferendis sed.\nUnde nemo numquam.\nEos eveniet est sint aut sed.\nMolestiae veniam et quaerat.", new DateTime(2021, 12, 14, 5, 6, 53, 420, DateTimeKind.Unspecified).AddTicks(3505), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Sit asperiores et sit maxime unde.\nFugiat quis cumque ut eius.\nPerferendis debitis ut quidem.\nSint eos quam fugit.\nIllo sint voluptates rerum aliquam sequi minima non debitis et.", new DateTime(2021, 5, 16, 16, 7, 8, 97, DateTimeKind.Unspecified).AddTicks(277), 2L, 31L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Ut nostrum dicta est et sed.", new DateTime(2021, 9, 15, 15, 20, 47, 568, DateTimeKind.Unspecified).AddTicks(1935), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Ea eius error ut et alias dignissimos.\nQuo nam aut cum consequatur quia.\nPorro atque est.\nDolorem similique facere sunt pariatur suscipit molestiae.", new DateTime(2021, 4, 15, 7, 39, 39, 832, DateTimeKind.Unspecified).AddTicks(5548), 4L, 70L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 34L, "Fuga dolor consequuntur distinctio itaque quisquam ullam enim enim.\nIste soluta consectetur voluptate soluta voluptas aut quos.\nLabore illum impedit recusandae est est porro quidem.\nMolestias deserunt nihil aperiam tempore tempora illo tempora.\nIusto dolor omnis.\nMagnam omnis repudiandae velit necessitatibus.", new DateTime(2021, 12, 2, 15, 48, 11, 996, DateTimeKind.Unspecified).AddTicks(1688), 76L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 37L, "Quia facere inventore repudiandae.\nVoluptatum perferendis modi dicta distinctio aut soluta hic cupiditate.\nDelectus aliquid blanditiis.\nCum quo et rerum similique.\nSit qui possimus inventore.", new DateTime(2021, 3, 29, 12, 44, 27, 346, DateTimeKind.Unspecified).AddTicks(4869), 2L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Sint ipsum qui vel similique quam iste tempore eligendi.\nOfficiis delectus cum rerum eligendi in.\nNecessitatibus quasi molestias enim et.", new DateTime(2022, 1, 23, 15, 5, 11, 755, DateTimeKind.Unspecified).AddTicks(5260), 5L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Vel assumenda laudantium fugiat.\nNam sunt quibusdam quia architecto impedit.", new DateTime(2021, 11, 23, 13, 41, 20, 426, DateTimeKind.Unspecified).AddTicks(4268), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "Illo omnis officiis consequatur magni.", new DateTime(2021, 2, 9, 9, 42, 50, 145, DateTimeKind.Unspecified).AddTicks(5205), 4L, 38L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Soluta iure omnis.\nNeque reprehenderit exercitationem molestiae voluptatibus ipsa quas.\nQuibusdam eveniet quis.\nDolor vel aliquid quia.", new DateTime(2021, 4, 24, 21, 51, 16, 433, DateTimeKind.Unspecified).AddTicks(8025), 3L, 31L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Quibusdam magnam ipsum perferendis illo atque.\nEaque fugit qui.", new DateTime(2021, 4, 28, 9, 12, 3, 941, DateTimeKind.Unspecified).AddTicks(2507), 1L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Qui et unde voluptas architecto.\nOmnis vel enim delectus et nihil.\nEnim sint omnis exercitationem omnis deserunt.\nPossimus delectus doloribus.\nSaepe omnis dolor.\nOptio perferendis est qui modi voluptate tempora.", new DateTime(2021, 10, 12, 2, 18, 9, 868, DateTimeKind.Unspecified).AddTicks(5777), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Temporibus maxime dicta at eligendi expedita.\nEt placeat officiis enim quia at molestias quia aliquam.", new DateTime(2021, 5, 26, 0, 40, 43, 540, DateTimeKind.Unspecified).AddTicks(3180), 2L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 50L, "Aliquam labore ipsa velit ut vitae est unde.\nTotam voluptatem omnis delectus eius ut ipsum velit aut.", new DateTime(2021, 12, 12, 3, 59, 9, 521, DateTimeKind.Unspecified).AddTicks(4097), 5L, 53L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 29L, "Quis eveniet ab aut cumque est.\nQuidem veniam odit corrupti pariatur consequatur quos est quisquam numquam.\nVeritatis voluptas voluptates corporis.", new DateTime(2021, 9, 24, 8, 6, 8, 95, DateTimeKind.Unspecified).AddTicks(1537), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Quo error minus fugit.\nHarum eum architecto doloremque porro pariatur sed voluptatum et.\nEos minus illo ea nihil.\nAliquam et placeat vitae sunt et.\nEx explicabo dolorum.", new DateTime(2021, 3, 2, 6, 53, 41, 178, DateTimeKind.Unspecified).AddTicks(9590), 4L, 76L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Quis voluptatem quia nam laborum.\nDolores ut vero commodi veniam aperiam nobis tempora.\nRepellat ut et praesentium dolores.\nAperiam aliquam dolores voluptas quisquam itaque aspernatur molestias ut cumque.\nOmnis corrupti ea doloremque sit ipsa et error.", new DateTime(2021, 11, 18, 0, 44, 15, 636, DateTimeKind.Unspecified).AddTicks(6531), 2L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Libero accusamus voluptatem.\nSapiente aut praesentium culpa iure.", new DateTime(2021, 3, 10, 15, 44, 16, 910, DateTimeKind.Unspecified).AddTicks(9018), 1L, 63L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "In voluptas deserunt nam culpa deleniti adipisci et ut.\nNon alias eveniet sed qui vel quae sint minus.\nEt omnis neque.\nEst et ut aspernatur sit.\nEos qui voluptates consequatur provident.\nHarum perspiciatis rerum omnis rem alias ab.", new DateTime(2021, 7, 11, 2, 28, 39, 965, DateTimeKind.Unspecified).AddTicks(1804), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Non quisquam consequuntur dolorem voluptas est dolorum soluta veniam.\nSuscipit excepturi aspernatur pariatur consequatur cum temporibus sunt sunt libero.\nDolor et ad.", new DateTime(2021, 5, 11, 22, 5, 44, 98, DateTimeKind.Unspecified).AddTicks(2176), 1L, 48L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Facere soluta officia exercitationem quos.\nPerferendis aut et quia voluptates debitis ut.\nCorporis eaque autem sequi quae at et.\nVoluptatum quo dolor ut modi pariatur maiores ut fuga saepe.", new DateTime(2021, 6, 7, 7, 18, 1, 940, DateTimeKind.Unspecified).AddTicks(7407), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 4L, "Ea laudantium nam vel accusantium delectus possimus ratione fugiat.\nAut qui sed voluptates nobis dolor doloremque accusamus sed debitis.\nQui voluptatem neque maiores quibusdam et sit.\nSuscipit quam est sed sunt quibusdam culpa consectetur molestiae.\nMolestias a quidem sint voluptas debitis nulla et quo.\nVoluptatem reiciendis voluptatem qui.", new DateTime(2021, 12, 10, 20, 56, 19, 476, DateTimeKind.Unspecified).AddTicks(6285), 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Tempora totam id enim dolores rem voluptas accusantium harum.\nOdit deserunt id.\nOptio sint officiis.\nDoloribus veniam qui minus repellendus vel sunt ex.", new DateTime(2021, 10, 23, 18, 30, 34, 596, DateTimeKind.Unspecified).AddTicks(5174), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Est animi et eaque eius voluptas.\nVero omnis qui.\nMollitia aut libero autem corporis possimus.\nQuam officia sequi numquam.", new DateTime(2021, 3, 1, 4, 36, 46, 202, DateTimeKind.Unspecified).AddTicks(6727), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Consequatur dolores tenetur aliquid.\nTempore et alias eum expedita cumque unde.\nDolores minus quia ullam amet impedit et.\nQuibusdam iusto rerum vero doloribus minima rem sint dolores ex.\nOfficia debitis corrupti esse et.", new DateTime(2021, 4, 30, 4, 45, 59, 691, DateTimeKind.Unspecified).AddTicks(7247), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Aut molestiae officiis reiciendis sit deleniti ea adipisci dolores numquam.\nNesciunt similique optio aut dolores perspiciatis reprehenderit iusto dicta.\nUllam ea a minus.", new DateTime(2021, 11, 13, 21, 2, 13, 368, DateTimeKind.Unspecified).AddTicks(4529), 3L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Qui est debitis suscipit sint.", new DateTime(2021, 2, 5, 19, 47, 14, 271, DateTimeKind.Unspecified).AddTicks(8322), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Eos beatae possimus porro sint quisquam vero qui occaecati eaque.\nVeniam tempore et voluptatem repudiandae.\nQuis neque ut aut.\nItaque est omnis eligendi commodi.", new DateTime(2021, 12, 16, 0, 35, 55, 674, DateTimeKind.Unspecified).AddTicks(5286), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Nemo iusto voluptas sed sit minus mollitia.\nHarum id labore illum quia sed provident.\nQuasi assumenda necessitatibus dolorem et ut.", new DateTime(2021, 12, 4, 13, 12, 49, 653, DateTimeKind.Unspecified).AddTicks(2873), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Commodi architecto maiores et aut.\nConsequatur commodi optio quo modi rerum similique ullam laboriosam.", new DateTime(2021, 11, 10, 7, 53, 26, 136, DateTimeKind.Unspecified).AddTicks(5424), 5L, 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Alias odio voluptas et dolorum aut suscipit earum amet.\nVero molestias et labore.\nDolorum sit itaque sunt quo dolorem autem.", new DateTime(2021, 10, 30, 15, 51, 52, 4, DateTimeKind.Unspecified).AddTicks(6718), 2L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Minus dignissimos velit recusandae id cupiditate ea harum.\nNam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.", new DateTime(2021, 2, 26, 12, 1, 35, 855, DateTimeKind.Unspecified).AddTicks(3844), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nam quia dicta eius doloribus commodi non nihil.\nQuod recusandae et est.\nDebitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.", new DateTime(2021, 10, 28, 3, 37, 20, 886, DateTimeKind.Unspecified).AddTicks(3829), 1L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Est sit at placeat optio.\nSapiente pariatur et et enim.\nAccusamus molestiae labore.", new DateTime(2021, 6, 2, 19, 19, 7, 873, DateTimeKind.Unspecified).AddTicks(6561), 4L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 3L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 1L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Earum voluptate voluptatem.\nSunt sunt est non deleniti tempore provident nihil et omnis.", new DateTime(2021, 5, 22, 23, 42, 34, 208, DateTimeKind.Unspecified).AddTicks(457), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 1L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Libero dicta temporibus atque earum.\nReprehenderit eos qui eum totam.\nId cum adipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 4L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 5L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 1L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 3L, 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 2L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 1L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 3L, 47L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 2L, 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 1L, 65L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 3L, 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 3L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 5L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 3L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 5L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "Body", "CreatedAt", "ThreadId" },
                values: new object[] { "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 25L, "Ipsam minima vel totam vel deserunt ab.\nEnim dolorem aliquid aperiam quod tempore porro ad nemo sit.\nNisi quis dolore nihil.", new DateTime(2021, 3, 28, 17, 3, 2, 998, DateTimeKind.Unspecified).AddTicks(838), 3L, 81L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Non fugiat non porro vero reiciendis et.\nEnim facere autem molestiae.", new DateTime(2021, 4, 1, 7, 35, 59, 215, DateTimeKind.Unspecified).AddTicks(830), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Quo corporis voluptatem.\nQuia ut architecto adipisci quasi at aliquid voluptatum et.\nConsequatur voluptate dolor doloribus quam ipsam rerum optio.\nAperiam aperiam et.", new DateTime(2021, 12, 23, 16, 16, 38, 159, DateTimeKind.Unspecified).AddTicks(4359), 1L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Qui quam perferendis itaque dolore eligendi expedita.\nFacilis distinctio et omnis necessitatibus quibusdam rerum.\nEt qui ex itaque quam tempora quia eos.", new DateTime(2021, 5, 6, 9, 31, 38, 3, DateTimeKind.Unspecified).AddTicks(8430), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Illo a ex minus.\nDucimus qui officiis.\nDicta suscipit voluptas libero.\nTemporibus enim qui labore.", new DateTime(2021, 10, 9, 0, 43, 5, 480, DateTimeKind.Unspecified).AddTicks(7270), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 44L, "Sed tempora non officiis est sit eveniet.\nArchitecto corrupti id rerum quam nesciunt assumenda odio ut maxime.\nUt animi in iste voluptatibus aliquid ut vitae.\nVelit exercitationem vero id sed quibusdam non.\nUt at ratione qui consectetur quam voluptas dolor dolorum.", new DateTime(2021, 8, 14, 13, 57, 37, 263, DateTimeKind.Unspecified).AddTicks(4946), 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Quo dolor harum et maxime.\nEt ut quia ab animi occaecati beatae.\nVel autem ea molestias.\nAspernatur sunt explicabo.\nCorporis vitae porro voluptas et magni alias sit quia quia.\nImpedit maiores unde possimus aspernatur enim ea et ut.", new DateTime(2021, 9, 6, 6, 15, 51, 816, DateTimeKind.Unspecified).AddTicks(508), 1L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 23L, "Cum illum sit corporis maiores laudantium ut.\nArchitecto aut expedita nihil et voluptatibus fugiat.\nQuisquam harum consequatur quasi ea voluptas hic dolorum.\nHarum laborum harum suscipit magnam aut.\nDolores amet tempore magni magni possimus odit quis et impedit.", new DateTime(2021, 6, 4, 11, 4, 16, 100, DateTimeKind.Unspecified).AddTicks(7149), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Dolores ea assumenda alias.", new DateTime(2021, 3, 6, 4, 28, 7, 52, DateTimeKind.Unspecified).AddTicks(1993), 1L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Sint aliquid pariatur harum enim dolorem repellat.\nMolestiae aut nemo nihil qui sapiente non harum.\nEligendi voluptas nobis tempore.\nMolestias vel dolores aut deleniti aut minima accusamus.\nOmnis voluptatem similique.\nFacere occaecati incidunt iusto laborum ut eius id dolore.", new DateTime(2021, 4, 12, 22, 5, 28, 434, DateTimeKind.Unspecified).AddTicks(9752), 4L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Quam ducimus qui.\nRerum velit nulla rem.\nUllam nisi eveniet dignissimos.", new DateTime(2021, 8, 25, 1, 50, 58, 81, DateTimeKind.Unspecified).AddTicks(488), 3L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 14L, "Omnis fugit aut.", new DateTime(2021, 8, 20, 8, 30, 53, 58, DateTimeKind.Unspecified).AddTicks(3331), 59L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Qui et velit tempore et.\nQui animi dolor beatae soluta.\nEt ab explicabo eos enim consequatur omnis soluta.\nVel doloribus omnis est optio et.\nAmet et assumenda et numquam culpa.\nQuasi aspernatur tempore.", new DateTime(2021, 11, 8, 12, 17, 53, 802, DateTimeKind.Unspecified).AddTicks(2027), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Suscipit deleniti accusamus et debitis.\nDucimus ab cum.\nPariatur architecto architecto odio maiores.", new DateTime(2021, 9, 4, 18, 46, 20, 745, DateTimeKind.Unspecified).AddTicks(6003), 1L, 30L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Dolore nihil voluptas doloremque accusantium.\nAnimi aspernatur mollitia.", new DateTime(2021, 6, 17, 15, 1, 38, 939, DateTimeKind.Unspecified).AddTicks(7420), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 4L, "Eum voluptas similique quasi.\nPorro possimus repudiandae minus rerum repellat.\nNobis laboriosam qui id qui inventore illo sunt.", new DateTime(2021, 3, 27, 21, 21, 10, 234, DateTimeKind.Unspecified).AddTicks(231), 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 27L, "Hic vitae tempora tempore et dignissimos perferendis omnis aut.", new DateTime(2021, 3, 12, 22, 52, 25, 95, DateTimeKind.Unspecified).AddTicks(9008), 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Excepturi mollitia vitae accusantium autem repudiandae.\nEst rem ex rerum sunt suscipit voluptatem veniam aut.\nMaiores similique assumenda tempore est inventore aut omnis.\nEt ut corporis dolorem deleniti dolorem laudantium mollitia.", new DateTime(2021, 4, 6, 19, 23, 18, 77, DateTimeKind.Unspecified).AddTicks(4489), 5L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Adipisci enim facere voluptatem sed accusamus soluta fuga qui porro.\nEx quia dolorem qui qui sed sed rem.\nConsequatur occaecati rem corporis officiis dolor aut id.\nSuscipit pariatur necessitatibus minima harum sunt ea.\nQuod omnis nobis sapiente veniam esse qui ducimus quia voluptas.", new DateTime(2021, 9, 4, 11, 28, 1, 107, DateTimeKind.Unspecified).AddTicks(3093), 4L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 3L, "Aut non tempore voluptas qui.\nLaboriosam omnis earum sit atque et.\nBeatae est magnam praesentium rerum quibusdam dignissimos temporibus voluptas.\nOdit rerum at facere itaque rem sapiente rerum.\nAspernatur ut corporis nihil ut occaecati atque exercitationem nihil molestiae.", new DateTime(2021, 5, 15, 6, 26, 4, 917, DateTimeKind.Unspecified).AddTicks(507), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Sequi reprehenderit ipsam.\nEt enim error quia quia error tenetur mollitia eligendi.\nNostrum voluptatibus magni natus assumenda quis.\nMaiores ut itaque ea et voluptatem et maxime praesentium.", new DateTime(2021, 5, 20, 9, 52, 1, 466, DateTimeKind.Unspecified).AddTicks(4088), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Est ab nemo.\nAut aspernatur dolores suscipit similique necessitatibus id voluptatem quidem.\nDolores consequatur tenetur.\nAd dolorem ipsa autem et.\nNostrum cumque praesentium.", new DateTime(2021, 9, 22, 15, 38, 2, 296, DateTimeKind.Unspecified).AddTicks(2770), 4L, 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Non sit beatae aliquam reiciendis enim tempore.\nPerferendis quis excepturi eveniet repellat tempora.\nVoluptas aut numquam eveniet et et eaque enim.\nAdipisci et ad quidem placeat earum dolor.\nDolorum voluptate molestiae nihil illo fugit aut.\nAnimi soluta accusantium.", new DateTime(2021, 10, 18, 16, 4, 44, 926, DateTimeKind.Unspecified).AddTicks(6113), 2L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Nihil qui in laudantium iste repellat ipsum veritatis praesentium.\nDeleniti eaque eaque.\nQuasi deserunt maiores ad deserunt et alias enim.", new DateTime(2021, 4, 5, 3, 11, 52, 774, DateTimeKind.Unspecified).AddTicks(511), 5L, 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Ut cumque aut.\nAut aut voluptas ex.\nVeritatis et velit aliquam.\nDeserunt illo quos maiores natus earum a velit.\nEarum cumque libero facere voluptatem saepe suscipit qui est veritatis.\nAutem omnis dicta ad.", new DateTime(2021, 5, 17, 13, 53, 22, 284, DateTimeKind.Unspecified).AddTicks(1090), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Non sit perspiciatis ex cum quidem placeat saepe ut asperiores.\nAt voluptas aperiam.\nEos magni dolor praesentium accusamus deleniti laboriosam.", new DateTime(2021, 4, 3, 10, 20, 46, 341, DateTimeKind.Unspecified).AddTicks(3427), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Facere ea provident et.\nAut minus occaecati.\nQui rem quaerat.\nEst blanditiis et aspernatur earum asperiores illo.\nSunt doloremque incidunt magnam sint dignissimos accusamus fugiat dignissimos.\nVoluptas tempore provident eos et praesentium vel.", new DateTime(2021, 2, 6, 15, 19, 18, 560, DateTimeKind.Unspecified).AddTicks(1065), 2L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nihil sed quis temporibus aut minima repellat voluptates.", new DateTime(2021, 6, 5, 6, 45, 25, 705, DateTimeKind.Unspecified).AddTicks(2833), 3L, 74L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Doloribus excepturi similique eos est.\nSaepe et qui ab unde deserunt est quis.\nLabore facere dolor.", new DateTime(2022, 1, 15, 18, 52, 37, 713, DateTimeKind.Unspecified).AddTicks(9441), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Doloribus omnis dignissimos mollitia alias omnis vitae deleniti.\nNesciunt qui voluptatem amet odio ullam.", new DateTime(2021, 6, 20, 20, 32, 47, 556, DateTimeKind.Unspecified).AddTicks(3441), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 47L, "Nostrum tempore quo quibusdam.\nNesciunt tempore qui beatae omnis earum veniam.", new DateTime(2021, 11, 8, 19, 30, 2, 744, DateTimeKind.Unspecified).AddTicks(6567), 1L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Dolorem ut quasi aut qui laudantium quibusdam ab.\nDeleniti quod blanditiis ducimus molestiae.", new DateTime(2021, 3, 17, 21, 1, 51, 218, DateTimeKind.Unspecified).AddTicks(9854), 4L, 35L });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 10, 17, 6, 23, 50, 396, DateTimeKind.Unspecified).AddTicks(1548), 4L, 839, false, 29L, 321 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 11, 24, 13, 4, 55, 844, DateTimeKind.Unspecified).AddTicks(7527), 651, 45L, 273 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 11, 20, 9, 37, 56, 313, DateTimeKind.Unspecified).AddTicks(3583), 532, 8L, 499 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 2, 14, 11, 8, 34, 712, DateTimeKind.Unspecified).AddTicks(8709), 630, true, null, 31L, 407 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "StartPosition" },
                values: new object[] { 43L, new DateTime(2021, 2, 9, 23, 44, 6, 471, DateTimeKind.Unspecified).AddTicks(4359), 580, 379 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 12, 18, 13, 14, 53, 202, DateTimeKind.Unspecified).AddTicks(2853), 2L, 905, true, 42L, null, 167 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 31L, new DateTime(2021, 3, 13, 12, 23, 20, 337, DateTimeKind.Unspecified).AddTicks(9493), 1L, 860, true, 37L, 3 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 7, 6, 13, 41, 24, 534, DateTimeKind.Unspecified).AddTicks(6323), 1L, 863, 31L, 72 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 7, 23, 22, 39, 11, 192, DateTimeKind.Unspecified).AddTicks(3007), 673, 3L, null, 348 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 4, 7, 18, 35, 34, 647, DateTimeKind.Unspecified).AddTicks(9176), 4L, 758, false, 36L, 230 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2022, 1, 25, 7, 7, 43, 79, DateTimeKind.Unspecified).AddTicks(5226), 5L, 864, false, null, 45L, 500 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 11, 10, 13, 52, 42, 959, DateTimeKind.Unspecified).AddTicks(2771), 711, 62L, null, 374 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2022, 1, 16, 2, 14, 43, 737, DateTimeKind.Unspecified).AddTicks(6498), 1L, 952, 40L, 133 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 11, 25, 15, 7, 36, 412, DateTimeKind.Unspecified).AddTicks(8787), 2L, 518, null, 18L, 296 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId" },
                values: new object[] { 18L, new DateTime(2021, 10, 29, 19, 53, 58, 967, DateTimeKind.Unspecified).AddTicks(6055), 4L, 851, null, 35L });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 8, 25, 14, 3, 5, 926, DateTimeKind.Unspecified).AddTicks(8901), 5L, 572, true, 20L, 415 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 2, 17, 12, 45, 48, 123, DateTimeKind.Unspecified).AddTicks(9607), 5L, 884, 49L, 174 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 2, 15, 19, 57, 26, 134, DateTimeKind.Unspecified).AddTicks(9390), 5L, 735, false, 46L, null, 275 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 4, 4, 7, 26, 22, 832, DateTimeKind.Unspecified).AddTicks(1298), 5L, 681, 2L, null, 351 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 10, 24, 20, 10, 44, 664, DateTimeKind.Unspecified).AddTicks(6254), 671, true, null, 9L, 117 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 31L, new DateTime(2021, 3, 8, 23, 24, 46, 367, DateTimeKind.Unspecified).AddTicks(9310), 2L, 949, true, 46L, 303 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 4, 17, 2, 29, 24, 292, DateTimeKind.Unspecified).AddTicks(372), 3L, 712, 45L, 64 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LessonId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 7, 18, 0, 28, 18, 28, DateTimeKind.Unspecified).AddTicks(3283), 4L, 43L, 324 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 6, 26, 14, 10, 40, 40, DateTimeKind.Unspecified).AddTicks(9027), 5L, 979, false, 23L, null, 322 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 3, 11, 4, 13, 32, 228, DateTimeKind.Unspecified).AddTicks(7404), 4L, 770, 65L, 421 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 2, 14, 17, 2, 53, 149, DateTimeKind.Unspecified).AddTicks(1732), 1L, 966, false, 36L, null, 424 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 12, 10, 20, 51, 58, 360, DateTimeKind.Unspecified).AddTicks(9657), 1L, 608, null, 4L, 282 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2022, 1, 14, 12, 46, 20, 542, DateTimeKind.Unspecified).AddTicks(7348), 846, false, 43L, null, 259 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 4, 22, 17, 17, 25, 658, DateTimeKind.Unspecified).AddTicks(8648), 3L, 757, true, 61L, 25 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 2, 19, 9, 35, 50, 850, DateTimeKind.Unspecified).AddTicks(6712), 4L, 702, 56L, 288 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 5, 19, 22, 55, 34, 574, DateTimeKind.Unspecified).AddTicks(8168), 2L, 575, 57L, 262 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2022, 1, 8, 15, 39, 43, 420, DateTimeKind.Unspecified).AddTicks(2105), 5L, 605, 65L, null, 498 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 9, 7, 8, 56, 48, 369, DateTimeKind.Unspecified).AddTicks(3103), 4L, 618, true, null, 41L, 454 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 3, 23, 4, 32, 46, 563, DateTimeKind.Unspecified).AddTicks(9000), 3L, 787, true, 47L, null, 53 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 9, 21, 14, 29, 49, 631, DateTimeKind.Unspecified).AddTicks(5698), 1L, 640, 29L, null, 110 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2022, 1, 15, 21, 9, 59, 47, DateTimeKind.Unspecified).AddTicks(6412), 812, true, 27L, 157 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 2, 23, 10, 41, 57, 127, DateTimeKind.Unspecified).AddTicks(7717), 3L, 920, 11L, null, 464 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 7, 21, 20, 34, 23, 287, DateTimeKind.Unspecified).AddTicks(3880), 4L, 560, 12L, 122 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 10, 12, 8, 36, 59, 545, DateTimeKind.Unspecified).AddTicks(7439), 2L, 958, false, 29L, 468 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 7, 2, 4, 1, 35, 213, DateTimeKind.Unspecified).AddTicks(6793), 2L, 517, 6L, null, 498 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 5, 12, 17, 18, 3, 578, DateTimeKind.Unspecified).AddTicks(3936), 1L, 792, null, 15L, 383 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 7, 21, 22, 31, 4, 876, DateTimeKind.Unspecified).AddTicks(488), 5L, 813, null, 40L, 124 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 21L, new DateTime(2021, 12, 10, 13, 21, 55, 864, DateTimeKind.Unspecified).AddTicks(6882), 2L, 953, true, 51L, 220 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2022, 1, 28, 22, 36, 32, 35, DateTimeKind.Unspecified).AddTicks(7308), 615, false, null, 34L, 97 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 7, 28, 3, 30, 47, 507, DateTimeKind.Unspecified).AddTicks(6675), 748, false, 18L, null, 321 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 6, 21, 0, 52, 14, 754, DateTimeKind.Unspecified).AddTicks(9557), 2L, 783, true, null, 25L, 463 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 12, 29, 14, 22, 40, 88, DateTimeKind.Unspecified).AddTicks(6169), 720, false, 32L, 155 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 8, 21, 6, 56, 33, 219, DateTimeKind.Unspecified).AddTicks(7076), 1L, 561, 13L, 199 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 5, 23, 22, 4, 37, 220, DateTimeKind.Unspecified).AddTicks(9299), 3L, 636, true, null, 48L, 438 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 8, 7, 18, 53, 4, 153, DateTimeKind.Unspecified).AddTicks(2294), 4L, 587, true, 47L, null, 434 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 10, 21, 10, 16, 54, 389, DateTimeKind.Unspecified).AddTicks(3921), 545, 45L, 251 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 11, 30, 11, 51, 45, 837, DateTimeKind.Unspecified).AddTicks(9044), 661, 39L, null, 321 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 9, 3, 16, 10, 13, 694, DateTimeKind.Unspecified).AddTicks(2911), 588, 32L, 6 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 11, 13, 11, 19, 34, 869, DateTimeKind.Unspecified).AddTicks(8618), 831, 47L, 229 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 10, 25, 17, 58, 23, 364, DateTimeKind.Unspecified).AddTicks(4247), 2L, 952, null, 31L, 444 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 10, 11, 3, 6, 11, 977, DateTimeKind.Unspecified).AddTicks(5490), 1L, 921, false, null, 36L, 413 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 12, 17, 10, 51, 21, 126, DateTimeKind.Unspecified).AddTicks(3624), 4L, 994, 8L, null, 71 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 9, 2, 12, 11, 25, 988, DateTimeKind.Unspecified).AddTicks(7357), 4L, 810, null, 22L, 112 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 2, 20, 10, 27, 46, 941, DateTimeKind.Unspecified).AddTicks(9181), 5L, 863, false, 61L, 219 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 21L, new DateTime(2021, 6, 28, 9, 20, 7, 722, DateTimeKind.Unspecified).AddTicks(4933), 4L, 615, null, 9L, 185 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 10, 4, 7, 35, 0, 57, DateTimeKind.Unspecified).AddTicks(52), 3L, 953, 62L, 391 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2022, 1, 18, 6, 15, 53, 846, DateTimeKind.Unspecified).AddTicks(8987), 637, false, null, 22L, 281 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 5, 7, 1, 27, 43, 650, DateTimeKind.Unspecified).AddTicks(8728), 627, false, null, 11L, 465 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 2, 19, 7, 15, 10, 695, DateTimeKind.Unspecified).AddTicks(4815), 5L, 942, 51L, 367 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2021, 10, 27, 18, 15, 51, 91, DateTimeKind.Unspecified).AddTicks(8342), 3L, 841, false, 7L, 35 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 6, 8, 17, 30, 1, 536, DateTimeKind.Unspecified).AddTicks(9217), 1L, 513, false, 28L, null, 242 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 11, 15, 17, 40, 22, 869, DateTimeKind.Unspecified).AddTicks(5003), 4L, 939, 3L, 162 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 4, 13, 15, 40, 4, 729, DateTimeKind.Unspecified).AddTicks(6906), 1L, 849, false, 32L, 12 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 12, 18, 14, 22, 10, 399, DateTimeKind.Unspecified).AddTicks(575), 619, false, 35L, 465 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 9, 29, 5, 38, 24, 785, DateTimeKind.Unspecified).AddTicks(9525), 1L, 864, false, 8L, null, 217 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 3, 24, 9, 20, 41, 24, DateTimeKind.Unspecified).AddTicks(5456), 3L, 929, true, null, 44L, 295 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 43L, new DateTime(2021, 12, 24, 5, 56, 7, 12, DateTimeKind.Unspecified).AddTicks(6597), 2L, 974, 35L, 32 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 7, 23, 12, 47, 11, 796, DateTimeKind.Unspecified).AddTicks(5305), 1L, 985, false, 17L, 56 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 12, 20, 20, 29, 18, 236, DateTimeKind.Unspecified).AddTicks(1758), 2L, 900, null, 35L, 500 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 2, 19, 20, 48, 7, 794, DateTimeKind.Unspecified).AddTicks(4431), 4L, 916, true, 7L, null, 298 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2022, 1, 15, 1, 34, 16, 274, DateTimeKind.Unspecified).AddTicks(5329), 2L, 839, 27L, null, 191 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 10, 31, 16, 20, 6, 387, DateTimeKind.Unspecified).AddTicks(8780), 4L, 588, null, 4L, 383 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 4, 8, 21, 12, 18, 896, DateTimeKind.Unspecified).AddTicks(5709), 5L, 957, 77L, null, 292 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 5, 31, 5, 16, 13, 108, DateTimeKind.Unspecified).AddTicks(8861), 5L, 540, 9L, 38 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 12, 2, 16, 44, 49, 510, DateTimeKind.Unspecified).AddTicks(2305), 5L, 771, true, null, 49L, 426 });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 6L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 2L, new DateTime(2021, 7, 8, 0, 9, 14, 403, DateTimeKind.Unspecified).AddTicks(2696), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 6L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 1L, new DateTime(2022, 1, 11, 16, 46, 58, 758, DateTimeKind.Unspecified).AddTicks(9763), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 14L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 1L, new DateTime(2021, 9, 4, 0, 43, 28, 454, DateTimeKind.Unspecified).AddTicks(6519), 4L, 30L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 21L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 1L, new DateTime(2021, 9, 17, 22, 26, 47, 317, DateTimeKind.Unspecified).AddTicks(3571), 1L, 26L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 23L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 1L, new DateTime(2021, 6, 21, 4, 6, 31, 122, DateTimeKind.Unspecified).AddTicks(321), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 24L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 2L, new DateTime(2021, 8, 22, 5, 3, 43, 173, DateTimeKind.Unspecified).AddTicks(2632), 2L, 34L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 26L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 2L, new DateTime(2022, 1, 5, 2, 38, 25, 699, DateTimeKind.Unspecified).AddTicks(385), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 26L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 2L, new DateTime(2021, 6, 9, 6, 18, 51, 192, DateTimeKind.Unspecified).AddTicks(3863), 4L, 38L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 28L },
                columns: new[] { "CourseRoleId", "CreatedAt", "Id" },
                values: new object[] { 1L, new DateTime(2021, 10, 15, 10, 41, 36, 101, DateTimeKind.Unspecified).AddTicks(4122), 42L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 30L },
                columns: new[] { "CourseRoleId", "CreatedAt", "Id" },
                values: new object[] { 2L, new DateTime(2021, 7, 3, 9, 21, 3, 170, DateTimeKind.Unspecified).AddTicks(3921), 6L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 32L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 1L, new DateTime(2021, 5, 14, 14, 53, 5, 616, DateTimeKind.Unspecified).AddTicks(3543), 2L, 32L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 33L },
                columns: new[] { "CourseRoleId", "CreatedAt" },
                values: new object[] { 2L, new DateTime(2021, 5, 25, 3, 11, 24, 122, DateTimeKind.Unspecified).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 33L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 2L, new DateTime(2021, 5, 17, 0, 59, 55, 256, DateTimeKind.Unspecified).AddTicks(5821), 4L, 50L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 36L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 1L, new DateTime(2021, 10, 1, 6, 23, 26, 260, DateTimeKind.Unspecified).AddTicks(5786), 4L, 51L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 39L },
                columns: new[] { "CourseRoleId", "CreatedAt", "Id" },
                values: new object[] { 2L, new DateTime(2022, 1, 9, 16, 31, 16, 676, DateTimeKind.Unspecified).AddTicks(1356), 54L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 45L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 2L, new DateTime(2021, 5, 16, 10, 44, 27, 577, DateTimeKind.Unspecified).AddTicks(60), 2L, 46L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 47L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 2L, new DateTime(2021, 10, 3, 5, 1, 12, 14, DateTimeKind.Unspecified).AddTicks(7992), 1L, 22L });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "CourseId", "UserId", "CourseRoleId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 19L, 2L, 1L, new DateTime(2021, 8, 30, 14, 24, 9, 840, DateTimeKind.Unspecified).AddTicks(5743), 4L, 40L, false },
                    { 16L, 3L, 1L, new DateTime(2021, 3, 21, 10, 45, 0, 605, DateTimeKind.Unspecified).AddTicks(2719), 1L, 29L, false },
                    { 18L, 3L, 2L, new DateTime(2021, 5, 20, 20, 23, 50, 714, DateTimeKind.Unspecified).AddTicks(4358), 3L, 55L, false },
                    { 13L, 4L, 2L, new DateTime(2021, 5, 21, 7, 54, 26, 764, DateTimeKind.Unspecified).AddTicks(953), 4L, 59L, false },
                    { 10L, 5L, 1L, new DateTime(2021, 11, 4, 17, 28, 47, 651, DateTimeKind.Unspecified).AddTicks(4644), 5L, 4L, false },
                    { 3L, 6L, 2L, new DateTime(2021, 8, 4, 2, 29, 6, 850, DateTimeKind.Unspecified).AddTicks(8524), 2L, 19L, false },
                    { 14L, 6L, 1L, new DateTime(2021, 9, 29, 15, 56, 4, 706, DateTimeKind.Unspecified).AddTicks(8619), 4L, 45L, false },
                    { 17L, 6L, 2L, new DateTime(2021, 8, 16, 13, 6, 6, 364, DateTimeKind.Unspecified).AddTicks(1851), 1L, 9L, false },
                    { 19L, 6L, 2L, new DateTime(2021, 8, 14, 17, 31, 37, 910, DateTimeKind.Unspecified).AddTicks(59), 2L, 41L, false },
                    { 3L, 7L, 1L, new DateTime(2021, 10, 31, 5, 17, 6, 9, DateTimeKind.Unspecified).AddTicks(1826), 3L, 39L, false },
                    { 14L, 7L, 1L, new DateTime(2021, 12, 14, 23, 19, 23, 364, DateTimeKind.Unspecified).AddTicks(1708), 5L, 58L, false },
                    { 15L, 7L, 2L, new DateTime(2021, 12, 24, 10, 4, 32, 706, DateTimeKind.Unspecified).AddTicks(5106), 2L, 21L, false },
                    { 18L, 7L, 2L, new DateTime(2022, 1, 24, 14, 17, 46, 65, DateTimeKind.Unspecified).AddTicks(5887), 3L, 57L, false },
                    { 5L, 8L, 1L, new DateTime(2022, 1, 28, 2, 41, 0, 797, DateTimeKind.Unspecified).AddTicks(9358), 4L, 65L, false },
                    { 17L, 8L, 2L, new DateTime(2021, 5, 24, 15, 46, 49, 238, DateTimeKind.Unspecified).AddTicks(1787), 3L, 61L, false },
                    { 15L, 9L, 1L, new DateTime(2021, 8, 3, 8, 31, 20, 83, DateTimeKind.Unspecified).AddTicks(2921), 4L, 53L, false },
                    { 4L, 10L, 1L, new DateTime(2021, 2, 10, 11, 54, 52, 594, DateTimeKind.Unspecified).AddTicks(7270), 2L, 28L, false },
                    { 12L, 11L, 2L, new DateTime(2021, 5, 17, 17, 26, 24, 953, DateTimeKind.Unspecified).AddTicks(8678), 3L, 56L, false },
                    { 19L, 14L, 1L, new DateTime(2021, 11, 16, 21, 8, 21, 868, DateTimeKind.Unspecified).AddTicks(5263), 3L, 49L, false },
                    { 18L, 16L, 2L, new DateTime(2021, 6, 11, 22, 19, 2, 187, DateTimeKind.Unspecified).AddTicks(9546), 2L, 3L, false },
                    { 15L, 17L, 2L, new DateTime(2021, 9, 10, 7, 43, 3, 948, DateTimeKind.Unspecified).AddTicks(2854), 4L, 64L, false },
                    { 5L, 18L, 1L, new DateTime(2021, 12, 10, 15, 27, 44, 458, DateTimeKind.Unspecified).AddTicks(4289), 5L, 68L, false },
                    { 4L, 21L, 1L, new DateTime(2021, 12, 10, 19, 37, 3, 620, DateTimeKind.Unspecified).AddTicks(7084), 5L, 69L, false },
                    { 11L, 22L, 2L, new DateTime(2021, 2, 16, 10, 44, 44, 139, DateTimeKind.Unspecified).AddTicks(7004), 4L, 25L, false },
                    { 11L, 24L, 2L, new DateTime(2021, 8, 11, 19, 34, 19, 12, DateTimeKind.Unspecified).AddTicks(1463), 5L, 12L, false }
                });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "CourseId", "UserId", "CourseRoleId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 5L, 25L, 1L, new DateTime(2021, 12, 19, 9, 11, 51, 184, DateTimeKind.Unspecified).AddTicks(9328), 5L, 66L, false },
                    { 18L, 25L, 2L, new DateTime(2021, 12, 9, 9, 47, 55, 538, DateTimeKind.Unspecified).AddTicks(9154), 3L, 15L, false },
                    { 18L, 26L, 2L, new DateTime(2021, 6, 26, 13, 41, 54, 307, DateTimeKind.Unspecified).AddTicks(3535), 5L, 52L, false },
                    { 4L, 29L, 2L, new DateTime(2021, 7, 4, 22, 26, 10, 282, DateTimeKind.Unspecified).AddTicks(7562), 1L, 67L, false },
                    { 8L, 29L, 1L, new DateTime(2021, 2, 21, 13, 3, 59, 646, DateTimeKind.Unspecified).AddTicks(9887), 3L, 44L, false },
                    { 10L, 29L, 2L, new DateTime(2021, 8, 18, 9, 50, 35, 137, DateTimeKind.Unspecified).AddTicks(1647), 3L, 5L, false },
                    { 14L, 31L, 2L, new DateTime(2021, 9, 9, 3, 53, 59, 813, DateTimeKind.Unspecified).AddTicks(6949), 4L, 8L, false },
                    { 5L, 35L, 2L, new DateTime(2021, 5, 15, 17, 9, 39, 64, DateTimeKind.Unspecified).AddTicks(2922), 4L, 36L, false },
                    { 2L, 37L, 2L, new DateTime(2021, 8, 27, 19, 41, 24, 300, DateTimeKind.Unspecified).AddTicks(4452), 5L, 33L, false },
                    { 3L, 37L, 2L, new DateTime(2021, 12, 20, 0, 57, 36, 768, DateTimeKind.Unspecified).AddTicks(5382), 2L, 11L, false },
                    { 19L, 39L, 1L, new DateTime(2021, 6, 22, 0, 47, 2, 772, DateTimeKind.Unspecified).AddTicks(4595), 4L, 23L, false },
                    { 5L, 40L, 2L, new DateTime(2021, 9, 14, 1, 7, 56, 693, DateTimeKind.Unspecified).AddTicks(7215), 4L, 37L, false },
                    { 19L, 40L, 1L, new DateTime(2021, 9, 15, 9, 59, 38, 66, DateTimeKind.Unspecified).AddTicks(3866), 5L, 20L, false },
                    { 15L, 41L, 2L, new DateTime(2021, 6, 19, 2, 17, 11, 594, DateTimeKind.Unspecified).AddTicks(1000), 2L, 47L, false },
                    { 16L, 41L, 2L, new DateTime(2021, 9, 18, 14, 41, 58, 592, DateTimeKind.Unspecified).AddTicks(6535), 1L, 16L, false },
                    { 3L, 42L, 1L, new DateTime(2021, 9, 14, 17, 12, 51, 224, DateTimeKind.Unspecified).AddTicks(4248), 1L, 70L, false },
                    { 16L, 45L, 1L, new DateTime(2021, 12, 11, 13, 36, 36, 444, DateTimeKind.Unspecified).AddTicks(201), 5L, 62L, false },
                    { 18L, 45L, 2L, new DateTime(2021, 3, 18, 6, 1, 50, 575, DateTimeKind.Unspecified).AddTicks(5520), 3L, 17L, false },
                    { 12L, 46L, 1L, new DateTime(2021, 3, 27, 1, 0, 18, 942, DateTimeKind.Unspecified).AddTicks(1104), 2L, 48L, false },
                    { 20L, 46L, 2L, new DateTime(2021, 10, 4, 9, 22, 20, 190, DateTimeKind.Unspecified).AddTicks(4531), 3L, 71L, false },
                    { 8L, 47L, 2L, new DateTime(2021, 11, 22, 16, 17, 22, 215, DateTimeKind.Unspecified).AddTicks(8052), 2L, 13L, false },
                    { 11L, 49L, 1L, new DateTime(2021, 5, 13, 16, 47, 45, 962, DateTimeKind.Unspecified).AddTicks(5424), 3L, 35L, false },
                    { 6L, 51L, 1L, new DateTime(2021, 8, 3, 1, 11, 21, 937, DateTimeKind.Unspecified).AddTicks(3881), 1L, 63L, false },
                    { 10L, 51L, 2L, new DateTime(2021, 2, 10, 20, 33, 47, 696, DateTimeKind.Unspecified).AddTicks(8347), 1L, 31L, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseUsers_CourseRoleId",
                table: "CourseUsers",
                column: "CourseRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseUsers_CourseRoles_CourseRoleId",
                table: "CourseUsers",
                column: "CourseRoleId",
                principalTable: "CourseRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
