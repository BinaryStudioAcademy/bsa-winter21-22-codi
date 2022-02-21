using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    public partial class AddFirebaseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 13L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 13L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 28L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 44L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 13L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 11L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 30L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 19L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 18L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 30L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 17L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 17L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 36L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 20L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 19L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 23L, 4L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 23L, 11L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 25L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 25L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 19L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 29L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 4L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 11L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 31L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 31L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 31L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 32L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 4L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 9L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 34L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 34L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 25L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 36L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 32L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 38L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 38L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 49L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 19L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 48L });

            migrationBuilder.AddColumn<string>(
                name: "FirebaseId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 14L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 6, 7, 13, 4, 23, 713, DateTimeKind.Unspecified).AddTicks(5650), 1L, 7L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 23L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 2, 10, 8, 45, 36, 787, DateTimeKind.Unspecified).AddTicks(4769), 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 35L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 11, 25, 8, 47, 8, 242, DateTimeKind.Unspecified).AddTicks(7846), 29L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 49L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 1L, new DateTime(2021, 6, 25, 18, 34, 31, 172, DateTimeKind.Unspecified).AddTicks(3818), 2L, 34L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 50L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 2L, new DateTime(2022, 2, 1, 15, 36, 28, 649, DateTimeKind.Unspecified).AddTicks(681), 2L, 17L });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "CourseId", "UserId", "CourseRoleId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 4L, 2L, 2L, new DateTime(2021, 3, 30, 15, 28, 23, 718, DateTimeKind.Unspecified).AddTicks(7269), 3L, 22L, false },
                    { 20L, 3L, 2L, new DateTime(2021, 10, 6, 18, 19, 34, 461, DateTimeKind.Unspecified).AddTicks(8559), 5L, 65L, false },
                    { 15L, 5L, 2L, new DateTime(2021, 4, 25, 16, 30, 54, 528, DateTimeKind.Unspecified).AddTicks(7200), 4L, 53L, false },
                    { 14L, 6L, 2L, new DateTime(2021, 9, 22, 5, 32, 26, 42, DateTimeKind.Unspecified).AddTicks(1327), 1L, 57L, false },
                    { 3L, 7L, 1L, new DateTime(2022, 1, 10, 3, 38, 10, 944, DateTimeKind.Unspecified).AddTicks(3290), 1L, 43L, false },
                    { 2L, 8L, 1L, new DateTime(2021, 5, 10, 6, 38, 40, 291, DateTimeKind.Unspecified).AddTicks(9520), 1L, 16L, false },
                    { 3L, 8L, 2L, new DateTime(2021, 2, 25, 2, 37, 23, 406, DateTimeKind.Unspecified).AddTicks(3970), 5L, 49L, false },
                    { 10L, 10L, 1L, new DateTime(2021, 8, 28, 23, 16, 47, 317, DateTimeKind.Unspecified).AddTicks(9844), 2L, 59L, false },
                    { 18L, 11L, 1L, new DateTime(2021, 4, 30, 10, 12, 37, 302, DateTimeKind.Unspecified).AddTicks(5949), 4L, 42L, false },
                    { 7L, 12L, 2L, new DateTime(2021, 5, 4, 1, 16, 55, 208, DateTimeKind.Unspecified).AddTicks(8455), 3L, 25L, false },
                    { 17L, 13L, 2L, new DateTime(2021, 5, 4, 9, 12, 46, 938, DateTimeKind.Unspecified).AddTicks(5230), 4L, 27L, false },
                    { 5L, 15L, 2L, new DateTime(2021, 7, 25, 1, 57, 45, 520, DateTimeKind.Unspecified).AddTicks(783), 3L, 26L, false },
                    { 16L, 15L, 2L, new DateTime(2021, 12, 30, 23, 12, 4, 375, DateTimeKind.Unspecified).AddTicks(9261), 2L, 66L, false },
                    { 17L, 15L, 1L, new DateTime(2021, 11, 10, 12, 39, 13, 598, DateTimeKind.Unspecified).AddTicks(1584), 5L, 2L, false },
                    { 7L, 17L, 2L, new DateTime(2021, 10, 21, 14, 41, 13, 380, DateTimeKind.Unspecified).AddTicks(8287), 2L, 58L, false },
                    { 12L, 17L, 2L, new DateTime(2021, 8, 7, 7, 27, 54, 274, DateTimeKind.Unspecified).AddTicks(2008), 2L, 54L, false },
                    { 10L, 19L, 1L, new DateTime(2021, 7, 31, 14, 4, 53, 99, DateTimeKind.Unspecified).AddTicks(1111), 1L, 68L, false },
                    { 13L, 20L, 1L, new DateTime(2021, 4, 21, 23, 31, 23, 775, DateTimeKind.Unspecified).AddTicks(8339), 2L, 36L, false },
                    { 18L, 20L, 2L, new DateTime(2021, 11, 2, 10, 0, 36, 243, DateTimeKind.Unspecified).AddTicks(2588), 5L, 8L, false },
                    { 13L, 22L, 2L, new DateTime(2021, 7, 26, 6, 18, 29, 333, DateTimeKind.Unspecified).AddTicks(1607), 2L, 56L, false },
                    { 18L, 23L, 1L, new DateTime(2021, 8, 13, 7, 25, 14, 925, DateTimeKind.Unspecified).AddTicks(5579), 2L, 64L, false },
                    { 12L, 25L, 1L, new DateTime(2021, 6, 16, 0, 16, 26, 622, DateTimeKind.Unspecified).AddTicks(3698), 1L, 60L, false },
                    { 19L, 25L, 2L, new DateTime(2021, 5, 27, 17, 5, 43, 455, DateTimeKind.Unspecified).AddTicks(2703), 2L, 44L, false },
                    { 16L, 26L, 1L, new DateTime(2021, 5, 21, 20, 3, 38, 976, DateTimeKind.Unspecified).AddTicks(2079), 2L, 50L, false },
                    { 9L, 27L, 2L, new DateTime(2021, 11, 9, 5, 5, 12, 55, DateTimeKind.Unspecified).AddTicks(5814), 4L, 40L, false },
                    { 10L, 27L, 2L, new DateTime(2022, 1, 25, 8, 58, 5, 660, DateTimeKind.Unspecified).AddTicks(5829), 1L, 45L, false },
                    { 10L, 28L, 1L, new DateTime(2021, 10, 1, 14, 55, 3, 350, DateTimeKind.Unspecified).AddTicks(3768), 1L, 52L, false },
                    { 14L, 30L, 1L, new DateTime(2021, 8, 7, 14, 48, 49, 354, DateTimeKind.Unspecified).AddTicks(2157), 5L, 35L, false },
                    { 17L, 30L, 1L, new DateTime(2021, 8, 2, 0, 8, 10, 96, DateTimeKind.Unspecified).AddTicks(8390), 4L, 48L, false },
                    { 17L, 31L, 2L, new DateTime(2021, 12, 4, 6, 58, 41, 812, DateTimeKind.Unspecified).AddTicks(4522), 2L, 39L, false },
                    { 15L, 32L, 2L, new DateTime(2021, 5, 14, 6, 31, 35, 255, DateTimeKind.Unspecified).AddTicks(9148), 1L, 51L, false },
                    { 3L, 33L, 2L, new DateTime(2021, 6, 27, 22, 43, 6, 636, DateTimeKind.Unspecified).AddTicks(4875), 4L, 71L, false },
                    { 9L, 33L, 2L, new DateTime(2021, 4, 26, 1, 42, 47, 668, DateTimeKind.Unspecified).AddTicks(9832), 1L, 3L, false },
                    { 7L, 34L, 1L, new DateTime(2022, 1, 31, 12, 48, 39, 18, DateTimeKind.Unspecified).AddTicks(7892), 1L, 70L, false },
                    { 14L, 34L, 2L, new DateTime(2021, 8, 29, 13, 22, 4, 420, DateTimeKind.Unspecified).AddTicks(7070), 2L, 19L, false },
                    { 11L, 35L, 1L, new DateTime(2021, 10, 9, 12, 41, 11, 459, DateTimeKind.Unspecified).AddTicks(4785), 1L, 69L, false },
                    { 17L, 35L, 1L, new DateTime(2021, 7, 16, 1, 8, 54, 515, DateTimeKind.Unspecified).AddTicks(7777), 4L, 55L, false }
                });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "CourseId", "UserId", "CourseRoleId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 9L, 36L, 1L, new DateTime(2021, 4, 16, 15, 35, 31, 417, DateTimeKind.Unspecified).AddTicks(7149), 5L, 32L, false },
                    { 17L, 36L, 1L, new DateTime(2021, 10, 5, 13, 7, 17, 644, DateTimeKind.Unspecified).AddTicks(8285), 2L, 9L, false },
                    { 15L, 37L, 1L, new DateTime(2021, 7, 8, 23, 16, 23, 614, DateTimeKind.Unspecified).AddTicks(7132), 5L, 23L, false },
                    { 9L, 38L, 1L, new DateTime(2021, 5, 23, 5, 11, 31, 767, DateTimeKind.Unspecified).AddTicks(8652), 4L, 37L, false },
                    { 11L, 38L, 1L, new DateTime(2022, 1, 28, 4, 6, 59, 994, DateTimeKind.Unspecified).AddTicks(6577), 1L, 4L, false },
                    { 21L, 38L, 2L, new DateTime(2021, 12, 4, 19, 40, 10, 533, DateTimeKind.Unspecified).AddTicks(2734), 5L, 24L, false },
                    { 16L, 39L, 1L, new DateTime(2021, 7, 22, 1, 2, 24, 992, DateTimeKind.Unspecified).AddTicks(9657), 4L, 12L, false },
                    { 10L, 40L, 2L, new DateTime(2021, 2, 8, 22, 1, 29, 684, DateTimeKind.Unspecified).AddTicks(5501), 1L, 6L, false },
                    { 4L, 41L, 1L, new DateTime(2021, 2, 10, 15, 18, 5, 995, DateTimeKind.Unspecified).AddTicks(7043), 5L, 46L, false },
                    { 20L, 42L, 1L, new DateTime(2021, 10, 3, 6, 49, 0, 563, DateTimeKind.Unspecified).AddTicks(9047), 2L, 20L, false },
                    { 5L, 43L, 1L, new DateTime(2021, 6, 19, 7, 51, 56, 162, DateTimeKind.Unspecified).AddTicks(6992), 5L, 33L, false },
                    { 7L, 43L, 1L, new DateTime(2021, 12, 18, 10, 16, 37, 695, DateTimeKind.Unspecified).AddTicks(6182), 1L, 31L, false },
                    { 17L, 43L, 1L, new DateTime(2021, 3, 8, 14, 59, 36, 714, DateTimeKind.Unspecified).AddTicks(9774), 1L, 18L, false },
                    { 19L, 43L, 2L, new DateTime(2021, 2, 8, 12, 10, 53, 142, DateTimeKind.Unspecified).AddTicks(822), 5L, 13L, false },
                    { 14L, 44L, 2L, new DateTime(2021, 10, 12, 21, 1, 31, 661, DateTimeKind.Unspecified).AddTicks(5377), 3L, 62L, false },
                    { 9L, 45L, 2L, new DateTime(2021, 7, 25, 4, 25, 12, 540, DateTimeKind.Unspecified).AddTicks(4924), 4L, 67L, false },
                    { 7L, 46L, 1L, new DateTime(2021, 12, 4, 22, 24, 20, 942, DateTimeKind.Unspecified).AddTicks(1301), 3L, 5L, false },
                    { 21L, 47L, 1L, new DateTime(2021, 10, 5, 23, 11, 17, 94, DateTimeKind.Unspecified).AddTicks(8307), 5L, 15L, false },
                    { 10L, 48L, 2L, new DateTime(2022, 1, 14, 4, 25, 9, 375, DateTimeKind.Unspecified).AddTicks(7137), 4L, 38L, false },
                    { 5L, 50L, 1L, new DateTime(2021, 2, 4, 10, 42, 6, 628, DateTimeKind.Unspecified).AddTicks(7462), 1L, 28L, false },
                    { 12L, 50L, 2L, new DateTime(2021, 5, 23, 6, 51, 36, 473, DateTimeKind.Unspecified).AddTicks(5802), 4L, 30L, false },
                    { 2L, 51L, 2L, new DateTime(2022, 1, 8, 17, 48, 28, 146, DateTimeKind.Unspecified).AddTicks(9730), 3L, 21L, false },
                    { 10L, 51L, 2L, new DateTime(2021, 2, 9, 10, 42, 54, 734, DateTimeKind.Unspecified).AddTicks(978), 4L, 11L, false },
                    { 16L, 51L, 1L, new DateTime(2022, 1, 21, 0, 18, 42, 544, DateTimeKind.Unspecified).AddTicks(6662), 5L, 61L, false },
                    { 18L, 51L, 2L, new DateTime(2021, 4, 12, 4, 35, 38, 602, DateTimeKind.Unspecified).AddTicks(3956), 1L, 47L, false }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 93L, new DateTime(2021, 7, 22, 0, 1, 31, 855, DateTimeKind.Unspecified).AddTicks(4664), 2L, "Corrupti quibusdam rem veritatis nesciunt sunt.\nNon reprehenderit iste.\nEum molestiae qui itaque ut nam ex aspernatur quia architecto.\nVero beatae a saepe quo.\nRatione vero quas soluta.", "Quos qui possimus et veniam facere aut natus doloremque.", "wirelessnationalintermediateRefined", 42L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 7L, new DateTime(2021, 12, 20, 6, 12, 33, 503, DateTimeKind.Unspecified).AddTicks(9097), 5L, "Nemo sed recusandae unde nisi consectetur itaque.\nAut voluptatem id recusandae vel provident.", "Laborum eveniet eum repudiandae.", "sky blueTengeMississippi", 12L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 37L, new DateTime(2022, 1, 16, 8, 59, 35, 42, DateTimeKind.Unspecified).AddTicks(4357), 5L, "Ullam maxime ea laudantium perferendis mollitia rerum.\nAliquam delectus occaecati.\nItaque nesciunt velit reiciendis.\nSed earum dolorum voluptas consequatur ut soluta illum.", "Eum est totam inventore veritatis et vel.", "functionalitiesCambridgeshiree-business", 16L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 66L, new DateTime(2022, 1, 25, 2, 28, 51, 529, DateTimeKind.Unspecified).AddTicks(1491), 2L, "Saepe corrupti illo vitae ex.\nOfficiis aut impedit recusandae quia soluta.", "Blanditiis natus expedita commodi consequatur tenetur quis in molestiae.", "back-endparse", 34L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvatarId", "CreatedAt", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 23L, new DateTime(2021, 11, 7, 11, 24, 3, 857, DateTimeKind.Unspecified).AddTicks(4192), "Et delectus pariatur molestiae et quod enim qui dolore.\nAut impedit et recusandae voluptatem cupiditate ad rerum rerum itaque.\nAspernatur distinctio ullam.", "Quam illo ipsum dolores nam rem temporibus aut sit blanditiis.", "Rustic Cotton ShirtGroup", 38L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 17L, new DateTime(2021, 7, 27, 17, 57, 55, 913, DateTimeKind.Unspecified).AddTicks(5577), 5L, "Ut ipsa praesentium harum minus voluptatem ut fugiat.\nMolestias non quisquam assumenda corporis unde.\nQuas reprehenderit aperiam cum.", "Sequi dicta quia est nesciunt cum nobis.", "Incrediblemint green", 28L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 15L, new DateTime(2021, 7, 3, 12, 52, 11, 722, DateTimeKind.Unspecified).AddTicks(2826), 4L, "Ut nobis nam repellendus eum.\nDistinctio molestias et veniam est voluptates natus perferendis tempora.\nRerum tenetur sint hic veniam deserunt et enim tempora vel.\nNostrum praesentium in omnis.\nEt necessitatibus iste magni at non reprehenderit qui expedita ipsa.", "Quia quaerat facere odit et dicta.", "compressknowledge useropen-sourcehuman-resource", 51L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvatarId", "CreatedAt", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 11L, new DateTime(2021, 7, 13, 0, 22, 29, 979, DateTimeKind.Unspecified).AddTicks(9243), "Quas cumque odit libero blanditiis.", "Dignissimos reprehenderit iste consequatur id consequatur.", "SteelonlinedepositPrincipal", 6L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 59L, new DateTime(2021, 12, 3, 22, 58, 21, 595, DateTimeKind.Unspecified).AddTicks(1944), 4L, "Est laudantium expedita iure.\nQuis asperiores aut deleniti et deleniti nesciunt et recusandae.\nEaque aut cumque harum id molestiae amet est.\nQui provident odit in quia reprehenderit sint tempora omnis minima.\nFuga est ipsum dolorum consequatur et.", "Quasi quaerat et recusandae fugit dolor debitis.", "coreForkpayment", 40L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 101L, new DateTime(2021, 4, 4, 9, 39, 41, 861, DateTimeKind.Unspecified).AddTicks(7700), 4L, "Sit mollitia natus sunt maiores.\nIn quis non aspernatur ut.\nBeatae et dolores aliquid voluptate sapiente placeat inventore fugit dolor.\nMolestiae vel quo voluptatibus officia accusantium.\nRerum doloremque ut nemo qui est aut est omnis repudiandae.", "Aliquam quas quod maxime.", "e-servicesInteractionsComputers", 4L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name" },
                values: new object[] { 85L, new DateTime(2021, 6, 30, 12, 37, 25, 293, DateTimeKind.Unspecified).AddTicks(6161), 2L, "Et non labore cumque est.\nNulla nisi porro amet fugiat inventore et maiores quidem.\nCorporis fugiat commodi voluptates consequuntur et odit aperiam aliquid.\nNihil occaecati debitis.\nFuga facilis amet nihil dolorem dolorum reprehenderit autem incidunt vel.", "Asperiores aut velit in magni magni impedit voluptatem ut.", "SmallCredit Card AccountDirect" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { new DateTime(2021, 8, 9, 12, 2, 11, 320, DateTimeKind.Unspecified).AddTicks(7724), 2L, "Sed ut nam.\nVoluptas laudantium id natus amet officiis.\nQui sit velit molestiae animi.\nBeatae similique nihil excepturi accusamus provident aut.\nAccusantium unde sunt.", "Voluptate voluptatem et ut eius.", "back-endconvergence", 38L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 13L, new DateTime(2021, 4, 21, 18, 56, 4, 190, DateTimeKind.Unspecified).AddTicks(1125), 3L, "Et deleniti porro ea qui et.\nMollitia suscipit vel est quis corporis.\nDolorem quaerat qui officia debitis deleniti quas modi eveniet aperiam.", "Aut rerum est.", "Cocos (Keeling) IslandsGrocery & BeautyGeneric", 30L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 32L, new DateTime(2021, 3, 1, 2, 30, 30, 793, DateTimeKind.Unspecified).AddTicks(9497), 3L, "Sint at numquam debitis veritatis sed dolor voluptatum est cupiditate.\nSaepe aut ut optio culpa.\nDolore dolore sit dolorum fugit iusto tempora corrupti.\nPlaceat exercitationem quasi tempore quasi consequuntur quae perspiciatis officia quis.\nNesciunt ab autem exercitationem nemo impedit autem tempora.", "Qui vel laudantium.", "CustomermaroonNew York", 17L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 54L, new DateTime(2021, 3, 15, 7, 45, 39, 618, DateTimeKind.Unspecified).AddTicks(4530), 5L, "Ut nulla similique vel voluptas eveniet.", "Maiores iure odit qui rerum ea.", "DirectProfit-focusedprojection", 11L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 26L, new DateTime(2021, 9, 7, 11, 9, 49, 292, DateTimeKind.Unspecified).AddTicks(2291), 3L, "Optio assumenda rerum et velit et id et asperiores praesentium.\nQuia mollitia et quis earum ut omnis aut.\nEx doloribus quia blanditiis nostrum sint.\nSit occaecati voluptas ducimus laboriosam mollitia quis velit omnis.", "Neque consequatur iste est recusandae et in tempora.", "paradigmsOfficer", 49L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 24L, new DateTime(2021, 5, 25, 17, 31, 16, 647, DateTimeKind.Unspecified).AddTicks(8802), 4L, "Ea libero perferendis qui laborum.", "Natus quidem eius eum animi impedit error corrupti harum saepe.", "SteelcircuitAccountsMarkets", 22L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 33L, new DateTime(2021, 7, 26, 10, 48, 47, 301, DateTimeKind.Unspecified).AddTicks(7290), 2L, "Est quos adipisci omnis.", "Sit placeat et non cupiditate assumenda consequatur.", "matrixFerryAnalyst", 31L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 49L, new DateTime(2022, 1, 25, 10, 56, 33, 422, DateTimeKind.Unspecified).AddTicks(4759), 4L, "Hic ullam ratione.\nUt debitis ut sed.\nIn qui molestiae esse non.\nNihil quaerat beatae.", "Aliquid et repellendus iure.", "cross-mediaGuadeloupeNebraskavirtual", 34L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 66L, new DateTime(2021, 3, 3, 17, 33, 12, 393, DateTimeKind.Unspecified).AddTicks(179), 4L, "Iusto et dolore rerum explicabo mollitia quis autem architecto.", "Assumenda sed vel perferendis iusto adipisci.", "greyConcreteInvestment AccountIsle of Man", 19L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 24L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 12, 26, 3, 19, 18, 894, DateTimeKind.Unspecified).AddTicks(1421), 2L, 47L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 13L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 3, 12, 22, 41, 31, 653, DateTimeKind.Unspecified).AddTicks(2569), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 34L, 45L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 11, 3, 14, 39, 22, 362, DateTimeKind.Unspecified).AddTicks(4809), 3L, 22L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 31L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 12, 27, 14, 26, 15, 499, DateTimeKind.Unspecified).AddTicks(5990), 1L, 70L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 50L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 10, 22, 23, 14, 32, 974, DateTimeKind.Unspecified).AddTicks(9190), 4L, 53L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 50L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2022, 1, 6, 23, 40, 58, 378, DateTimeKind.Unspecified).AddTicks(8330), 37L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 45L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 8, 27, 2, 32, 0, 643, DateTimeKind.Unspecified).AddTicks(8748), 21L });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 46L, new DateTime(2022, 1, 2, 17, 57, 19, 366, DateTimeKind.Unspecified).AddTicks(2605), 2L, 95L, false },
                    { 3L, 14L, new DateTime(2021, 4, 7, 16, 7, 12, 969, DateTimeKind.Unspecified).AddTicks(5823), 5L, 90L, false },
                    { 3L, 33L, new DateTime(2021, 6, 7, 8, 3, 40, 578, DateTimeKind.Unspecified).AddTicks(6736), 1L, 69L, false },
                    { 3L, 39L, new DateTime(2021, 5, 2, 2, 4, 39, 752, DateTimeKind.Unspecified).AddTicks(1104), 1L, 92L, false },
                    { 5L, 2L, new DateTime(2021, 6, 8, 2, 32, 6, 301, DateTimeKind.Unspecified).AddTicks(8606), 1L, 8L, false },
                    { 5L, 5L, new DateTime(2021, 7, 15, 10, 18, 30, 627, DateTimeKind.Unspecified).AddTicks(918), 2L, 62L, false },
                    { 5L, 18L, new DateTime(2021, 6, 30, 11, 38, 38, 829, DateTimeKind.Unspecified).AddTicks(7407), 1L, 54L, false },
                    { 5L, 35L, new DateTime(2021, 9, 9, 7, 41, 4, 820, DateTimeKind.Unspecified).AddTicks(4664), 4L, 89L, false },
                    { 5L, 37L, new DateTime(2022, 1, 13, 12, 57, 30, 518, DateTimeKind.Unspecified).AddTicks(4614), 4L, 59L, false },
                    { 5L, 50L, new DateTime(2021, 4, 22, 0, 44, 34, 46, DateTimeKind.Unspecified).AddTicks(3299), 2L, 82L, false },
                    { 6L, 24L, new DateTime(2021, 12, 7, 23, 23, 47, 811, DateTimeKind.Unspecified).AddTicks(7006), 5L, 68L, false },
                    { 7L, 25L, new DateTime(2022, 1, 8, 2, 1, 20, 738, DateTimeKind.Unspecified).AddTicks(218), 4L, 81L, false },
                    { 7L, 29L, new DateTime(2022, 1, 29, 14, 13, 12, 376, DateTimeKind.Unspecified).AddTicks(4676), 4L, 26L, false },
                    { 7L, 39L, new DateTime(2021, 5, 1, 16, 59, 8, 688, DateTimeKind.Unspecified).AddTicks(6324), 5L, 33L, false },
                    { 8L, 33L, new DateTime(2021, 4, 27, 0, 1, 10, 273, DateTimeKind.Unspecified).AddTicks(2861), 3L, 27L, false },
                    { 8L, 36L, new DateTime(2021, 7, 7, 20, 55, 22, 809, DateTimeKind.Unspecified).AddTicks(9473), 2L, 45L, false },
                    { 9L, 42L, new DateTime(2021, 11, 29, 11, 53, 30, 364, DateTimeKind.Unspecified).AddTicks(726), 4L, 31L, false },
                    { 10L, 33L, new DateTime(2021, 5, 18, 14, 1, 9, 360, DateTimeKind.Unspecified).AddTicks(5539), 3L, 49L, false },
                    { 10L, 34L, new DateTime(2021, 9, 29, 14, 46, 29, 249, DateTimeKind.Unspecified).AddTicks(9262), 5L, 2L, false },
                    { 11L, 8L, new DateTime(2021, 12, 25, 5, 40, 13, 834, DateTimeKind.Unspecified).AddTicks(8883), 5L, 98L, false },
                    { 11L, 15L, new DateTime(2021, 6, 16, 22, 1, 26, 635, DateTimeKind.Unspecified).AddTicks(394), 4L, 94L, false },
                    { 11L, 16L, new DateTime(2021, 9, 21, 7, 56, 45, 443, DateTimeKind.Unspecified).AddTicks(4477), 3L, 11L, false },
                    { 11L, 41L, new DateTime(2021, 9, 6, 15, 46, 0, 273, DateTimeKind.Unspecified).AddTicks(4472), 4L, 28L, false },
                    { 12L, 25L, new DateTime(2022, 1, 24, 9, 7, 41, 313, DateTimeKind.Unspecified).AddTicks(9484), 2L, 29L, false },
                    { 12L, 47L, new DateTime(2021, 4, 26, 1, 24, 37, 36, DateTimeKind.Unspecified).AddTicks(3950), 2L, 96L, false },
                    { 13L, 5L, new DateTime(2022, 1, 24, 22, 49, 8, 763, DateTimeKind.Unspecified).AddTicks(9944), 5L, 71L, false },
                    { 13L, 15L, new DateTime(2021, 7, 31, 9, 36, 38, 881, DateTimeKind.Unspecified).AddTicks(8330), 2L, 17L, false },
                    { 13L, 19L, new DateTime(2021, 8, 9, 3, 25, 29, 838, DateTimeKind.Unspecified).AddTicks(3383), 5L, 4L, false },
                    { 13L, 28L, new DateTime(2021, 7, 12, 8, 11, 31, 993, DateTimeKind.Unspecified).AddTicks(1355), 5L, 10L, false },
                    { 14L, 29L, new DateTime(2021, 11, 11, 1, 24, 29, 247, DateTimeKind.Unspecified).AddTicks(7429), 3L, 64L, false },
                    { 14L, 40L, new DateTime(2021, 10, 27, 22, 16, 3, 439, DateTimeKind.Unspecified).AddTicks(9400), 5L, 52L, false },
                    { 15L, 6L, new DateTime(2021, 12, 13, 22, 14, 37, 54, DateTimeKind.Unspecified).AddTicks(4097), 3L, 44L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 15L, 7L, new DateTime(2021, 12, 16, 5, 7, 12, 427, DateTimeKind.Unspecified).AddTicks(5296), 1L, 93L, false },
                    { 15L, 8L, new DateTime(2021, 5, 7, 15, 13, 23, 199, DateTimeKind.Unspecified).AddTicks(9337), 5L, 35L, false },
                    { 16L, 23L, new DateTime(2021, 8, 31, 15, 17, 40, 298, DateTimeKind.Unspecified).AddTicks(2375), 2L, 91L, false },
                    { 16L, 50L, new DateTime(2021, 8, 31, 8, 58, 16, 536, DateTimeKind.Unspecified).AddTicks(9673), 4L, 99L, false },
                    { 18L, 10L, new DateTime(2021, 3, 3, 16, 48, 4, 711, DateTimeKind.Unspecified).AddTicks(2639), 4L, 57L, false },
                    { 20L, 48L, new DateTime(2021, 3, 26, 10, 14, 19, 972, DateTimeKind.Unspecified).AddTicks(5269), 5L, 3L, false },
                    { 21L, 5L, new DateTime(2021, 8, 13, 21, 29, 50, 748, DateTimeKind.Unspecified).AddTicks(4802), 2L, 80L, false },
                    { 21L, 29L, new DateTime(2021, 3, 31, 19, 38, 5, 454, DateTimeKind.Unspecified).AddTicks(3300), 1L, 73L, false },
                    { 22L, 18L, new DateTime(2021, 5, 28, 20, 52, 10, 180, DateTimeKind.Unspecified).AddTicks(3343), 1L, 41L, false },
                    { 22L, 44L, new DateTime(2021, 11, 18, 9, 59, 52, 592, DateTimeKind.Unspecified).AddTicks(4394), 5L, 101L, false },
                    { 23L, 30L, new DateTime(2021, 5, 3, 7, 5, 21, 39, DateTimeKind.Unspecified).AddTicks(135), 1L, 34L, false },
                    { 24L, 47L, new DateTime(2021, 3, 26, 10, 19, 7, 536, DateTimeKind.Unspecified).AddTicks(447), 3L, 19L, false },
                    { 24L, 49L, new DateTime(2021, 2, 7, 22, 45, 59, 579, DateTimeKind.Unspecified).AddTicks(2228), 1L, 51L, false },
                    { 25L, 28L, new DateTime(2021, 9, 6, 22, 53, 18, 406, DateTimeKind.Unspecified).AddTicks(9776), 5L, 39L, false },
                    { 27L, 25L, new DateTime(2021, 12, 11, 9, 54, 33, 627, DateTimeKind.Unspecified).AddTicks(1205), 1L, 88L, false },
                    { 27L, 37L, new DateTime(2021, 3, 28, 17, 6, 34, 786, DateTimeKind.Unspecified).AddTicks(5147), 2L, 7L, false },
                    { 28L, 2L, new DateTime(2021, 9, 6, 20, 16, 4, 114, DateTimeKind.Unspecified).AddTicks(9548), 5L, 43L, false },
                    { 28L, 22L, new DateTime(2021, 6, 14, 4, 43, 46, 544, DateTimeKind.Unspecified).AddTicks(1870), 4L, 40L, false },
                    { 28L, 44L, new DateTime(2021, 5, 28, 5, 48, 50, 434, DateTimeKind.Unspecified).AddTicks(579), 1L, 25L, false },
                    { 30L, 5L, new DateTime(2021, 12, 9, 6, 16, 43, 653, DateTimeKind.Unspecified).AddTicks(5085), 5L, 15L, false },
                    { 30L, 39L, new DateTime(2022, 1, 5, 9, 39, 45, 736, DateTimeKind.Unspecified).AddTicks(5427), 5L, 18L, false },
                    { 30L, 41L, new DateTime(2021, 2, 16, 21, 17, 55, 51, DateTimeKind.Unspecified).AddTicks(5371), 1L, 23L, false },
                    { 31L, 30L, new DateTime(2021, 8, 23, 3, 17, 9, 858, DateTimeKind.Unspecified).AddTicks(2296), 2L, 13L, false },
                    { 33L, 35L, new DateTime(2021, 11, 18, 14, 8, 17, 243, DateTimeKind.Unspecified).AddTicks(6486), 2L, 60L, false },
                    { 35L, 7L, new DateTime(2021, 6, 28, 9, 58, 9, 947, DateTimeKind.Unspecified).AddTicks(6934), 3L, 36L, false },
                    { 35L, 16L, new DateTime(2021, 5, 5, 6, 48, 1, 676, DateTimeKind.Unspecified).AddTicks(7568), 1L, 20L, false },
                    { 35L, 27L, new DateTime(2021, 2, 13, 22, 45, 42, 103, DateTimeKind.Unspecified).AddTicks(2766), 4L, 38L, false },
                    { 36L, 3L, new DateTime(2022, 1, 24, 7, 9, 39, 295, DateTimeKind.Unspecified).AddTicks(258), 1L, 6L, false },
                    { 37L, 35L, new DateTime(2021, 11, 8, 11, 42, 3, 228, DateTimeKind.Unspecified).AddTicks(8736), 2L, 79L, false },
                    { 38L, 27L, new DateTime(2022, 1, 4, 15, 20, 0, 247, DateTimeKind.Unspecified).AddTicks(5087), 4L, 46L, false },
                    { 38L, 32L, new DateTime(2021, 11, 10, 15, 47, 45, 820, DateTimeKind.Unspecified).AddTicks(484), 3L, 56L, false },
                    { 40L, 47L, new DateTime(2021, 7, 25, 11, 11, 12, 13, DateTimeKind.Unspecified).AddTicks(4863), 1L, 77L, false },
                    { 41L, 15L, new DateTime(2021, 10, 5, 21, 4, 41, 244, DateTimeKind.Unspecified).AddTicks(4563), 4L, 24L, false },
                    { 41L, 28L, new DateTime(2021, 7, 4, 15, 29, 37, 338, DateTimeKind.Unspecified).AddTicks(8467), 2L, 48L, false },
                    { 41L, 31L, new DateTime(2021, 5, 12, 6, 25, 9, 503, DateTimeKind.Unspecified).AddTicks(1891), 5L, 100L, false },
                    { 41L, 34L, new DateTime(2021, 12, 15, 23, 11, 43, 825, DateTimeKind.Unspecified).AddTicks(8465), 3L, 50L, false },
                    { 41L, 44L, new DateTime(2021, 3, 8, 20, 16, 29, 638, DateTimeKind.Unspecified).AddTicks(8155), 3L, 58L, false },
                    { 41L, 45L, new DateTime(2021, 8, 17, 16, 3, 11, 458, DateTimeKind.Unspecified).AddTicks(1583), 2L, 72L, false },
                    { 42L, 14L, new DateTime(2021, 10, 26, 4, 37, 0, 94, DateTimeKind.Unspecified).AddTicks(4501), 3L, 67L, false },
                    { 43L, 3L, new DateTime(2021, 5, 19, 23, 59, 44, 389, DateTimeKind.Unspecified).AddTicks(7849), 5L, 63L, false },
                    { 43L, 16L, new DateTime(2021, 6, 22, 5, 55, 57, 344, DateTimeKind.Unspecified).AddTicks(338), 1L, 83L, false },
                    { 43L, 24L, new DateTime(2021, 10, 26, 21, 29, 50, 833, DateTimeKind.Unspecified).AddTicks(503), 3L, 9L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 43L, 37L, new DateTime(2021, 5, 23, 8, 57, 52, 778, DateTimeKind.Unspecified).AddTicks(939), 2L, 86L, false },
                    { 43L, 49L, new DateTime(2021, 8, 20, 14, 46, 31, 50, DateTimeKind.Unspecified).AddTicks(9625), 5L, 65L, false },
                    { 44L, 11L, new DateTime(2022, 1, 16, 14, 16, 15, 660, DateTimeKind.Unspecified).AddTicks(1647), 5L, 42L, false },
                    { 44L, 14L, new DateTime(2021, 11, 11, 22, 42, 58, 145, DateTimeKind.Unspecified).AddTicks(1234), 4L, 78L, false },
                    { 44L, 17L, new DateTime(2021, 5, 19, 0, 8, 6, 368, DateTimeKind.Unspecified).AddTicks(320), 1L, 5L, false },
                    { 44L, 43L, new DateTime(2021, 11, 25, 20, 8, 42, 1, DateTimeKind.Unspecified).AddTicks(2794), 4L, 74L, false },
                    { 46L, 35L, new DateTime(2021, 6, 19, 11, 39, 58, 279, DateTimeKind.Unspecified).AddTicks(8027), 1L, 30L, false },
                    { 46L, 39L, new DateTime(2021, 12, 23, 3, 8, 59, 748, DateTimeKind.Unspecified).AddTicks(8781), 1L, 87L, false },
                    { 47L, 11L, new DateTime(2021, 12, 25, 5, 11, 28, 321, DateTimeKind.Unspecified).AddTicks(6155), 3L, 84L, false },
                    { 48L, 41L, new DateTime(2021, 12, 6, 10, 32, 27, 235, DateTimeKind.Unspecified).AddTicks(1877), 2L, 55L, false },
                    { 49L, 8L, new DateTime(2021, 12, 26, 3, 36, 56, 881, DateTimeKind.Unspecified).AddTicks(7655), 1L, 85L, false },
                    { 49L, 45L, new DateTime(2021, 3, 21, 12, 6, 22, 283, DateTimeKind.Unspecified).AddTicks(805), 2L, 16L, false },
                    { 49L, 47L, new DateTime(2021, 8, 13, 22, 46, 42, 587, DateTimeKind.Unspecified).AddTicks(6800), 4L, 12L, false },
                    { 50L, 9L, new DateTime(2021, 4, 19, 4, 22, 21, 394, DateTimeKind.Unspecified).AddTicks(3275), 1L, 61L, false },
                    { 50L, 25L, new DateTime(2021, 12, 2, 20, 44, 11, 3, DateTimeKind.Unspecified).AddTicks(8545), 3L, 66L, false },
                    { 50L, 27L, new DateTime(2021, 2, 21, 19, 15, 39, 843, DateTimeKind.Unspecified).AddTicks(8851), 1L, 76L, false },
                    { 50L, 29L, new DateTime(2021, 11, 2, 6, 55, 37, 146, DateTimeKind.Unspecified).AddTicks(1433), 3L, 75L, false },
                    { 50L, 37L, new DateTime(2021, 12, 21, 15, 46, 47, 190, DateTimeKind.Unspecified).AddTicks(304), 5L, 97L, false },
                    { 51L, 20L, new DateTime(2021, 12, 17, 16, 35, 0, 41, DateTimeKind.Unspecified).AddTicks(4903), 5L, 32L, false }
                });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 9, 21, 13, 18, 42, 128, DateTimeKind.Unspecified).AddTicks(4628), 4L, "Nulla quae culpa in id corrupti aspernatur aut tempora et.\nVel sapiente et provident.", new DateTime(2023, 12, 19, 22, 56, 22, 918, DateTimeKind.Unspecified).AddTicks(2279), "Aperiam qui sit itaque placeat rerum perferendis voluptas rem.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 10, 30, 8, 42, 54, 335, DateTimeKind.Unspecified).AddTicks(5718), 4L, "Illo excepturi sint omnis.\nNemo in minima laudantium quaerat ad.\nNon reiciendis et voluptas illo architecto eius cumque sed.\nNihil et nobis qui quas aut.", new DateTime(2023, 10, 27, 1, 49, 7, 384, DateTimeKind.Unspecified).AddTicks(9685), "Ut est quo fuga veniam atque.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 8, 13, 20, 42, 49, 66, DateTimeKind.Unspecified).AddTicks(3387), 3L, "Voluptate molestiae natus.\nEum sunt quia voluptatem et quae iste aut est sunt.\nEt deserunt velit.", new DateTime(2023, 1, 21, 12, 5, 8, 161, DateTimeKind.Unspecified).AddTicks(8974), false, "Distinctio ullam amet quam tempora ut et et.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 48, 28, 418, DateTimeKind.Unspecified).AddTicks(3354), "Optio velit illum ad rem rerum eveniet.", new DateTime(2023, 1, 20, 17, 51, 15, 247, DateTimeKind.Unspecified).AddTicks(2938), "Doloremque et et doloribus.", 2L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 4, 27, 18, 16, 53, 796, DateTimeKind.Unspecified).AddTicks(204), "Quia voluptatem qui molestiae qui qui sit nihil aliquid nihil.\nEnim omnis perspiciatis eos id autem vel.\nVero optio non architecto inventore nemo dolore.", null, true, "At est aspernatur consequatur.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 9, 7, 17, 59, 48, 616, DateTimeKind.Unspecified).AddTicks(8692), "Magni nihil odio vitae.\nLaudantium sit magnam eveniet veniam temporibus similique.\nMinima et reprehenderit quia.\nDoloribus exercitationem ex perferendis itaque enim nihil.", new DateTime(2023, 3, 6, 11, 52, 12, 627, DateTimeKind.Unspecified).AddTicks(2582), "Numquam exercitationem vel placeat iure blanditiis sit.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 7, 2, 2, 32, 11, 600, DateTimeKind.Unspecified).AddTicks(4438), 5L, "Aspernatur odio atque dolores repellat delectus sit dolores.\nVoluptatem aut accusantium voluptatem quo.\nVoluptas ipsum autem.\nNumquam pariatur reprehenderit.\nMolestiae modi voluptas maxime deleniti accusamus.", new DateTime(2023, 8, 21, 21, 28, 4, 491, DateTimeKind.Unspecified).AddTicks(1205), "Et quas quibusdam quis et tempora libero.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 5, 19, 16, 34, 21, 42, DateTimeKind.Unspecified).AddTicks(4662), 5L, "Sed et nam soluta id ducimus.", new DateTime(2023, 10, 16, 2, 49, 13, 886, DateTimeKind.Unspecified).AddTicks(3095), false, "Qui est nihil in incidunt ut quas.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 12, 15, 9, 52, 44, 746, DateTimeKind.Unspecified).AddTicks(4799), 1L, "Minus culpa unde.\nIn libero blanditiis maiores quas.\nEx dignissimos est ea beatae et voluptatem voluptas quae enim.\nMinus unde et saepe.\nAperiam ea est vitae molestiae est.", new DateTime(2023, 2, 5, 0, 51, 30, 573, DateTimeKind.Unspecified).AddTicks(2199), true, "Ad tempore eius ut voluptatem culpa consequatur.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 2, 23, 18, 42, 4, 965, DateTimeKind.Unspecified).AddTicks(4949), "Officia fugit qui ut qui id alias magnam voluptatem.\nQui repellat aperiam sint quam eveniet quidem aspernatur.", new DateTime(2022, 9, 7, 4, 5, 39, 568, DateTimeKind.Unspecified).AddTicks(4594), false, "Sit dolor autem.", 9L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 3, 17, 16, 20, 25, 812, DateTimeKind.Unspecified).AddTicks(8783), "Quam eum qui.\nOmnis sint voluptas.\nTenetur vitae tempore qui.\nCum adipisci ab numquam debitis voluptatem unde vitae dolores.\nAt alias quia qui illo ratione quasi doloremque aut blanditiis.", new DateTime(2023, 4, 27, 21, 37, 9, 595, DateTimeKind.Unspecified).AddTicks(4664), false, "Repellat libero ut minima.", 27L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2021, 3, 16, 17, 33, 0, 131, DateTimeKind.Unspecified).AddTicks(9297), 1L, "Consequuntur ipsam aut.\nBlanditiis officiis eaque id occaecati impedit quasi aut ab cumque.\nSit minima culpa maxime suscipit ut dolorem cum velit voluptatem.", new DateTime(2023, 4, 5, 21, 46, 14, 478, DateTimeKind.Unspecified).AddTicks(6106), "Accusamus aut ut nisi nostrum dolores qui excepturi voluptatem rerum.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 7, 28, 8, 6, 22, 453, DateTimeKind.Unspecified).AddTicks(9976), 4L, "Sequi et nulla aperiam praesentium neque.\nLaudantium nostrum deserunt qui sapiente ut odio sed sed.\nSapiente rerum consequatur omnis accusamus enim ipsum sunt rerum.\nOfficiis voluptatem fugit at at sunt et nihil.", new DateTime(2022, 9, 18, 10, 38, 24, 662, DateTimeKind.Unspecified).AddTicks(2574), true, "Et recusandae nulla qui.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 9, 13, 22, 27, 20, 922, DateTimeKind.Unspecified).AddTicks(2041), 2L, "Et quibusdam cumque veniam sed tempore laudantium qui atque itaque.", new DateTime(2022, 6, 27, 19, 30, 44, 592, DateTimeKind.Unspecified).AddTicks(8707), false, "Exercitationem ut est quasi est deserunt asperiores dolores.", 19L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 4, 24, 21, 30, 21, 401, DateTimeKind.Unspecified).AddTicks(5829), 2L, "Quam sunt in.\nDignissimos et doloribus vitae debitis.", null, "Necessitatibus harum expedita.", 6L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 6, 16, 23, 45, 34, 55, DateTimeKind.Unspecified).AddTicks(9940), 3L, "Atque quia tempora iusto nobis numquam.", new DateTime(2023, 3, 30, 7, 12, 37, 665, DateTimeKind.Unspecified).AddTicks(100), "Adipisci vel id rerum.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 9, 9, 20, 25, 17, 338, DateTimeKind.Unspecified).AddTicks(8302), 5L, "Et dolores assumenda.\nLaborum sit debitis optio illum sint quis sunt ut id.\nFugit consequatur vel est quas est.", new DateTime(2023, 11, 22, 6, 34, 14, 53, DateTimeKind.Unspecified).AddTicks(3236), "Est impedit est incidunt delectus fugiat.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 11, 11, 17, 34, 13, 89, DateTimeKind.Unspecified).AddTicks(4902), 4L, "Blanditiis et architecto rerum cumque voluptate ab et quaerat nostrum.", null, "Quam qui est illo et qui.", 8L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 2, 6, 11, 19, 27, 975, DateTimeKind.Unspecified).AddTicks(3106), 4L, "Delectus numquam voluptas dignissimos ad incidunt.\nVoluptatem praesentium sunt omnis.\nDistinctio quas id necessitatibus aut consequatur.", new DateTime(2023, 10, 16, 6, 44, 40, 594, DateTimeKind.Unspecified).AddTicks(6448), "Eveniet veniam provident.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2022, 1, 22, 23, 46, 30, 637, DateTimeKind.Unspecified).AddTicks(591), 3L, "Cupiditate totam accusantium.\nEos ipsa aliquam dolores illum ex earum.\nQuo blanditiis temporibus repellat quisquam esse ipsum explicabo repudiandae.\nEa aliquid veniam tempora ex enim excepturi officiis.", new DateTime(2023, 2, 23, 10, 51, 14, 647, DateTimeKind.Unspecified).AddTicks(3792), "Omnis ea dolorum asperiores.", 2L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 5, 4, 13, 45, 37, 279, DateTimeKind.Unspecified).AddTicks(6304), 5L, "Doloremque eum voluptas rerum.\nDolorem quidem velit nulla.\nTempore dolore quidem.\nVoluptatibus dolorum rerum dolorem dolorum aspernatur vel molestiae.\nConsequatur placeat sed quia perspiciatis soluta est rerum numquam.", new DateTime(2022, 12, 14, 13, 3, 24, 6, DateTimeKind.Unspecified).AddTicks(7877), "Ut debitis nulla unde ut doloremque omnis dolores.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 10, 17, 4, 26, 11, 227, DateTimeKind.Unspecified).AddTicks(2391), "Labore neque error laborum dicta itaque sint facere.\nId deserunt qui necessitatibus libero quas sunt sint velit.\nBlanditiis illum natus ea explicabo officiis.\nEt sed consequatur fugit et at voluptate accusantium.\nNesciunt reiciendis quasi natus nihil.", new DateTime(2023, 6, 27, 10, 15, 44, 129, DateTimeKind.Unspecified).AddTicks(5438), true, "Et explicabo voluptatem sit itaque.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 4, 16, 10, 45, 47, 335, DateTimeKind.Unspecified).AddTicks(1734), 4L, "Et soluta et rem quod autem iusto.\nPlaceat expedita ea quod doloribus et.\nNisi aut dignissimos quidem porro.", new DateTime(2023, 8, 8, 13, 12, 30, 977, DateTimeKind.Unspecified).AddTicks(5085), true, "Expedita asperiores alias maxime maiores.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 5, 5, 6, 12, 5, 214, DateTimeKind.Unspecified).AddTicks(7048), 5L, "Sed et ex molestias sit amet ut corporis non facilis.\nIste ea voluptatum quis et.", new DateTime(2023, 11, 12, 18, 54, 19, 670, DateTimeKind.Unspecified).AddTicks(598), true, "Voluptas consequuntur consequatur consequatur quaerat.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 11, 26, 2, 15, 53, 505, DateTimeKind.Unspecified).AddTicks(43), 2L, "Aut ea sunt placeat facere.\nId fugit ducimus ducimus blanditiis non laborum enim et nesciunt.\nOmnis rem fugit et voluptates provident sequi aliquid velit consectetur.\nAut sit tempore doloremque sit ex voluptatem voluptatem enim.", new DateTime(2023, 7, 19, 4, 56, 19, 281, DateTimeKind.Unspecified).AddTicks(16), false, "Dolorem tempore eius consequatur mollitia enim.", 38L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2021, 9, 10, 6, 1, 31, 998, DateTimeKind.Unspecified).AddTicks(4248), 5L, "Ipsa et et.", new DateTime(2022, 7, 12, 10, 18, 56, 157, DateTimeKind.Unspecified).AddTicks(4704), "Nostrum iste aut saepe molestiae.", 24L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 2, 4, 5, 5, 58, 590, DateTimeKind.Unspecified).AddTicks(705), 1L, "Sit aut eum aut.\nDolor eos autem.\nExercitationem voluptate quae quasi et incidunt.\nEos quasi minima suscipit sit voluptatibus accusamus.\nDolor quidem culpa et non unde rerum.", new DateTime(2022, 10, 3, 1, 16, 2, 682, DateTimeKind.Unspecified).AddTicks(5160), "Assumenda consequatur voluptatem omnis nihil doloremque aliquam aut explicabo.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 6, 25, 14, 54, 19, 404, DateTimeKind.Unspecified).AddTicks(1657), "A adipisci ratione adipisci voluptatum.\nItaque illum iste.\nAperiam recusandae enim cumque consequatur animi asperiores ut nulla.", new DateTime(2022, 11, 27, 19, 17, 59, 489, DateTimeKind.Unspecified).AddTicks(3558), false, "Amet eligendi architecto animi nesciunt.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title" },
                values: new object[] { 18L, new DateTime(2021, 10, 8, 8, 9, 34, 791, DateTimeKind.Unspecified).AddTicks(1560), 4L, "Tempore ab molestiae rerum sint et.\nDoloribus inventore corrupti.\nIllum sunt beatae suscipit ipsam sunt veniam vitae.", new DateTime(2022, 3, 27, 5, 4, 8, 306, DateTimeKind.Unspecified).AddTicks(5407), "Et rerum qui voluptatem qui dolorem quis nesciunt modi." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 11, 29, 11, 22, 40, 703, DateTimeKind.Unspecified).AddTicks(120), 4L, "Molestiae dolorem quia numquam esse laudantium.", new DateTime(2023, 3, 17, 10, 27, 38, 409, DateTimeKind.Unspecified).AddTicks(4759), "Nostrum aspernatur non error.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 4, 22, 0, 7, 36, 83, DateTimeKind.Unspecified).AddTicks(1027), 5L, "Officiis eos quis saepe impedit.\nAut saepe veniam quia sit.\nDolores sit sequi saepe molestiae facere sed eveniet et.", new DateTime(2023, 7, 16, 12, 38, 30, 855, DateTimeKind.Unspecified).AddTicks(8435), "Et quos sit qui.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 11, 8, 21, 41, 8, 389, DateTimeKind.Unspecified).AddTicks(5847), 1L, "Veniam nisi iste enim laborum.\nNemo similique ad itaque voluptatibus voluptas soluta recusandae aut ipsum.\nMolestiae ad laborum et ratione ipsam ullam.\nMolestiae accusamus tenetur ut perspiciatis numquam ipsam architecto non ab.", new DateTime(2023, 9, 17, 19, 53, 40, 204, DateTimeKind.Unspecified).AddTicks(8427), false, "Doloribus quod aut nihil.", 25L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 6, 15, 23, 3, 45, 61, DateTimeKind.Unspecified).AddTicks(2333), 1L, "Cupiditate ratione illum.", new DateTime(2022, 6, 7, 20, 54, 12, 809, DateTimeKind.Unspecified).AddTicks(5223), "Ducimus rerum dicta.", 7L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 3, 6, 9, 39, 26, 81, DateTimeKind.Unspecified).AddTicks(469), 5L, "Libero minus quisquam libero voluptas.", new DateTime(2023, 1, 12, 13, 40, 41, 40, DateTimeKind.Unspecified).AddTicks(1991), "Aliquam exercitationem nobis.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 6, 13, 13, 27, 42, 12, DateTimeKind.Unspecified).AddTicks(8813), 4L, "Saepe dolorem nisi consequatur.\nQuis provident rerum.\nIn repudiandae repellendus vitae ea blanditiis numquam labore reprehenderit porro.", new DateTime(2022, 6, 2, 10, 15, 30, 472, DateTimeKind.Unspecified).AddTicks(8084), true, "Voluptatem deserunt optio.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 6, 3, 9, 45, 43, 915, DateTimeKind.Unspecified).AddTicks(9319), 4L, "Culpa ea amet dolor omnis saepe aut.\nPlaceat omnis fugiat dolorem dolor velit.\nVoluptatem quibusdam in adipisci nihil vero aut aut qui et.\nSed voluptatum consectetur ipsa tenetur deserunt perspiciatis eligendi consequatur ex.", new DateTime(2024, 1, 16, 3, 53, 14, 546, DateTimeKind.Unspecified).AddTicks(8714), false, "Voluptatem reprehenderit iure quasi ipsa iusto mollitia ipsa ea eos.", 23L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 6, 18, 5, 15, 50, 506, DateTimeKind.Unspecified).AddTicks(4740), 5L, "Sit dolore dolorem nam delectus nobis.\nMagnam quae veniam et ea dolores.\nImpedit mollitia et veniam.\nIure fuga quis.\nEaque laudantium eaque quia.", new DateTime(2023, 10, 29, 5, 27, 18, 505, DateTimeKind.Unspecified).AddTicks(1163), false, "Impedit iste natus quis.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 9, 22, 3, 10, 41, 786, DateTimeKind.Unspecified).AddTicks(5061), 5L, "Consequatur sit odit non aliquid tempore autem.\nIpsam cupiditate aut ipsam.\nVelit blanditiis fugiat ipsa vitae.\nSed non commodi laborum pariatur praesentium nisi labore nam.\nEa voluptates totam enim impedit vitae.", new DateTime(2022, 3, 15, 8, 53, 30, 414, DateTimeKind.Unspecified).AddTicks(7211), "Eos quibusdam consequuntur.", 5L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 8, 30, 22, 48, 0, 825, DateTimeKind.Unspecified).AddTicks(4773), "Qui est rerum quisquam quaerat.\nAut iusto quo eligendi a laborum.\nConsequatur similique fugit qui ipsam nobis ad nihil.\nVeritatis ea ut.", new DateTime(2023, 3, 16, 6, 19, 47, 91, DateTimeKind.Unspecified).AddTicks(974), false, "Consequatur nisi nostrum enim nam molestiae labore amet illum.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 4, 30, 22, 13, 55, 230, DateTimeKind.Unspecified).AddTicks(2149), 3L, "Molestiae autem quia ab qui est voluptatem aspernatur enim.\nAccusamus magni odio repudiandae laborum qui veniam qui cumque.\nSuscipit et quis in velit.\nExcepturi quam molestias cum veritatis inventore.\nVoluptatum et quod rerum enim sed voluptates molestiae culpa.", new DateTime(2023, 1, 30, 12, 45, 8, 358, DateTimeKind.Unspecified).AddTicks(7771), true, "Velit magni qui inventore odio suscipit quaerat.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2022, 2, 1, 9, 37, 5, 467, DateTimeKind.Unspecified).AddTicks(6876), "Voluptas officia quidem dolor.\nSit delectus esse officiis optio aut sint temporibus aliquid.", new DateTime(2023, 8, 6, 18, 5, 46, 770, DateTimeKind.Unspecified).AddTicks(3884), "Voluptatum nesciunt aut iste est laudantium ullam sunt est quidem.", 28L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 2, 4, 22, 13, 41, 315, DateTimeKind.Unspecified).AddTicks(9874), "Velit et aut.", new DateTime(2023, 6, 9, 13, 21, 42, 585, DateTimeKind.Unspecified).AddTicks(8626), "Qui aperiam occaecati dolor et.", 36L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 10, 16, 1, 23, 7, 244, DateTimeKind.Unspecified).AddTicks(2448), 3L, "Dolorem eum quibusdam harum expedita quo reprehenderit omnis.\nId enim qui.", new DateTime(2023, 12, 31, 6, 22, 35, 266, DateTimeKind.Unspecified).AddTicks(51), true, "Est beatae autem et aspernatur omnis sit delectus voluptas.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 4, 21, 17, 39, 26, 742, DateTimeKind.Unspecified).AddTicks(3053), 2L, "Et eos dolores ex quaerat.\nNon minus recusandae ullam aperiam.\nIpsam ipsa error itaque eligendi.\nQuod velit exercitationem recusandae voluptas qui.\nConsectetur rerum enim placeat doloribus hic saepe deleniti nihil impedit.", new DateTime(2023, 9, 5, 23, 19, 34, 423, DateTimeKind.Unspecified).AddTicks(6562), true, "Ut omnis enim.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 2, 8, 0, 14, 16, 243, DateTimeKind.Unspecified).AddTicks(1131), 5L, "Quia provident nihil architecto maiores voluptatem repudiandae.", new DateTime(2023, 1, 15, 9, 38, 33, 714, DateTimeKind.Unspecified).AddTicks(8050), "Non expedita sit tenetur enim quaerat magni.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 2, 28, 11, 30, 15, 742, DateTimeKind.Unspecified).AddTicks(1052), 2L, "Qui a aut porro est sit in molestiae.\nEt qui tempore esse fuga commodi omnis ut quisquam est.\nNatus tempora suscipit qui mollitia ut.", null, "Eos repellendus saepe sit assumenda.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 12, 6, 11, 32, 58, 756, DateTimeKind.Unspecified).AddTicks(2281), 2L, "Omnis ratione qui autem enim provident est.\nAut perspiciatis est asperiores dolorem sunt sint dolorum ex.\nPraesentium officiis ex.\nPerspiciatis cumque repellendus consectetur quos ducimus temporibus debitis doloribus.\nRecusandae repudiandae aut beatae excepturi expedita.", new DateTime(2022, 8, 28, 3, 30, 41, 573, DateTimeKind.Unspecified).AddTicks(8031), "Et dolor in eveniet ea voluptatem.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 8L, new DateTime(2021, 6, 28, 0, 46, 39, 290, DateTimeKind.Unspecified).AddTicks(3097), "Et delectus nesciunt autem.\nQuia aut quia eaque minima maiores magni.\nRatione veritatis magnam vitae voluptas odit optio.", new DateTime(2023, 10, 6, 3, 5, 32, 595, DateTimeKind.Unspecified).AddTicks(1434), "Commodi ipsam eum quaerat tenetur.", 30L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 4, 13, 7, 3, 35, 773, DateTimeKind.Unspecified).AddTicks(6420), 4L, "Ut possimus eius rem reprehenderit est neque optio.\nVeniam accusantium ad quia corporis.\nPlaceat quam nulla.\nEa architecto tempore quasi adipisci saepe quod deserunt magnam.", new DateTime(2022, 11, 1, 18, 34, 19, 372, DateTimeKind.Unspecified).AddTicks(8883), "Quam officiis nam amet fugiat sit.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 12, 16, 9, 0, 54, 989, DateTimeKind.Unspecified).AddTicks(1757), 1L, "Cum doloremque maiores.\nSunt iusto quia fugit consequatur sint assumenda doloribus atque.\nQui exercitationem est voluptatem culpa.\nIllo repudiandae quia non magni tempora totam nobis.", new DateTime(2022, 7, 6, 6, 57, 2, 673, DateTimeKind.Unspecified).AddTicks(4606), false, "Quos et consequatur.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 7, 4, 21, 29, 44, 604, DateTimeKind.Unspecified).AddTicks(8805), 1L, "Neque ipsam praesentium et autem.\nVoluptas temporibus veritatis asperiores voluptas nihil est tempore ut.\nOccaecati et labore aperiam quisquam vero nobis dolorum sed laborum.", new DateTime(2022, 12, 5, 15, 19, 31, 468, DateTimeKind.Unspecified).AddTicks(1435), true, "Quae nobis ut dolorum blanditiis sed voluptatum odio.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 4, 1, 18, 58, 51, 127, DateTimeKind.Unspecified).AddTicks(6501), 4L, "Sapiente nisi voluptates mollitia ad corrupti perferendis similique velit.", new DateTime(2022, 12, 8, 22, 13, 19, 490, DateTimeKind.Unspecified).AddTicks(7588), true, "Necessitatibus ut repudiandae consequatur dolor esse voluptas ipsa quaerat.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 11, 9, 6, 57, 3, 393, DateTimeKind.Unspecified).AddTicks(3521), 3L, "Quo rerum cumque et sapiente.\nCorrupti voluptatum doloribus praesentium autem debitis distinctio consectetur.\nDolorem magni quidem aut aut enim odio veniam.", new DateTime(2023, 6, 4, 2, 30, 15, 420, DateTimeKind.Unspecified).AddTicks(641), "Iure odio nam rerum.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title" },
                values: new object[] { 6L, new DateTime(2021, 2, 26, 20, 29, 59, 219, DateTimeKind.Unspecified).AddTicks(4177), 4L, "Minima vitae est iusto ratione excepturi facere.\nQuia atque natus nemo.\nNulla in voluptatem.\nId aperiam voluptatem autem quia aliquam.\nIure et tempore.", new DateTime(2023, 1, 20, 5, 32, 24, 706, DateTimeKind.Unspecified).AddTicks(7950), "Deserunt sed qui libero quas accusantium saepe." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 10, 24, 10, 54, 26, 326, DateTimeKind.Unspecified).AddTicks(2431), "Nesciunt provident doloribus labore.", new DateTime(2023, 8, 1, 18, 56, 17, 776, DateTimeKind.Unspecified).AddTicks(8825), "Dolorem non unde.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 8, 14, 12, 54, 0, 489, DateTimeKind.Unspecified).AddTicks(9888), 1L, "Quo enim amet corrupti consequatur.", null, "Odit nihil vero eligendi id tenetur dolorem fuga.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 3, 25, 16, 31, 29, 597, DateTimeKind.Unspecified).AddTicks(8117), 5L, "Ullam qui corrupti.\nCulpa magnam architecto mollitia quis.", new DateTime(2023, 10, 30, 19, 0, 21, 113, DateTimeKind.Unspecified).AddTicks(3218), "Laudantium debitis dolorum et dicta molestias.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 8L, new DateTime(2021, 12, 27, 9, 39, 11, 866, DateTimeKind.Unspecified).AddTicks(3985), "Cupiditate quia quisquam a voluptatibus.\nRecusandae accusamus ipsam.\nA reiciendis odio dolor nulla.\nIste iste nihil unde voluptatem commodi unde et id natus.", null, "Et placeat itaque amet ad.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 6, 18, 6, 8, 39, 990, DateTimeKind.Unspecified).AddTicks(3904), 1L, "Qui alias debitis debitis deleniti tenetur voluptas vel et.", new DateTime(2023, 10, 17, 7, 21, 42, 701, DateTimeKind.Unspecified).AddTicks(4021), "Qui sapiente dolorem eos exercitationem explicabo cupiditate odio.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 8, 29, 17, 45, 49, 19, DateTimeKind.Unspecified).AddTicks(6526), "Quia ullam illum soluta.\nVoluptatem praesentium eveniet.", new DateTime(2022, 4, 21, 10, 42, 15, 250, DateTimeKind.Unspecified).AddTicks(231), false, "Quam porro recusandae provident maxime.", 31L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 8L, new DateTime(2021, 7, 26, 3, 37, 40, 168, DateTimeKind.Unspecified).AddTicks(8371), 4L, "Sunt earum tempore consequatur molestias totam ab.\nVero iste culpa distinctio ad.\nSed dolorem tenetur doloribus sapiente deserunt nam eos fuga.\nQuo rerum eaque omnis voluptas dolor assumenda ut.\nEos voluptatum voluptatem.", new DateTime(2023, 9, 1, 2, 29, 31, 175, DateTimeKind.Unspecified).AddTicks(9669), false, "Debitis quae dolores consectetur rem sapiente iste aperiam.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 5, 30, 12, 49, 5, 83, DateTimeKind.Unspecified).AddTicks(5041), 3L, "Architecto non debitis impedit voluptatem non aut.", new DateTime(2023, 4, 30, 16, 13, 55, 482, DateTimeKind.Unspecified).AddTicks(9494), true, "Quia aut eius assumenda cumque architecto corporis.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 12, 20, 19, 51, 9, 35, DateTimeKind.Unspecified).AddTicks(5559), "Veniam et ab nostrum qui rerum.\nFugit laboriosam deleniti laudantium ipsum velit adipisci.\nVoluptatem voluptas alias vero sed voluptatibus magnam accusantium aperiam.\nEum temporibus sunt harum eum ad molestiae ratione dolor temporibus.\nDolorem quam accusamus nostrum.", new DateTime(2022, 10, 17, 18, 50, 4, 602, DateTimeKind.Unspecified).AddTicks(7246), "Facilis eos ipsam quibusdam vel.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 3, 5, 9, 17, 31, 145, DateTimeKind.Unspecified).AddTicks(9938), 1L, "Eaque sit in.\nPariatur quae atque.\nQuia sed accusantium voluptatem ea distinctio iusto ut magni similique.", new DateTime(2023, 8, 14, 2, 31, 49, 731, DateTimeKind.Unspecified).AddTicks(8841), "Sed quo officiis omnis quibusdam occaecati maxime.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 11, 19, 13, 46, 55, 178, DateTimeKind.Unspecified).AddTicks(5038), 3L, "Sit et odio nemo voluptatem eos consequatur culpa deleniti.", new DateTime(2023, 3, 20, 5, 5, 26, 150, DateTimeKind.Unspecified).AddTicks(5764), true, "Libero id possimus fugiat voluptatum ea in assumenda possimus.", 28L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 11, 19, 15, 43, 42, 171, DateTimeKind.Unspecified).AddTicks(2793), "Dolores et aliquam facilis iste et voluptas sit.", new DateTime(2022, 5, 4, 7, 59, 53, 262, DateTimeKind.Unspecified).AddTicks(1837), "Voluptatibus recusandae officiis accusantium odit perferendis ut dolor enim est.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 4, 13, 10, 30, 42, 417, DateTimeKind.Unspecified).AddTicks(9730), "Consequatur sed quaerat repellat ullam sit beatae ducimus.", new DateTime(2023, 10, 15, 3, 3, 39, 878, DateTimeKind.Unspecified).AddTicks(6757), "Ut tenetur natus quia et consequatur qui esse fugiat rerum.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 5, 2, 20, 10, 53, 507, DateTimeKind.Unspecified).AddTicks(8685), "Aperiam tempora placeat.\nQuos et soluta non quam omnis.\nNon quia quibusdam et praesentium sequi.\nConsequuntur rerum inventore.", new DateTime(2023, 12, 11, 6, 8, 50, 739, DateTimeKind.Unspecified).AddTicks(3967), false, "Eum cupiditate voluptatum pariatur dolorem.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2021, 3, 18, 3, 37, 13, 520, DateTimeKind.Unspecified).AddTicks(4200), 1L, "Eveniet cupiditate nesciunt voluptas.", new DateTime(2023, 5, 12, 23, 59, 0, 9, DateTimeKind.Unspecified).AddTicks(7802), true, "Necessitatibus ex aperiam magnam non eveniet quas.", 24L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 2, 3, 6, 59, 24, 644, DateTimeKind.Unspecified).AddTicks(3663), 2L, "Consequatur necessitatibus id dignissimos inventore.", new DateTime(2022, 9, 24, 13, 0, 19, 475, DateTimeKind.Unspecified).AddTicks(7829), false, "Delectus et quia nulla cumque rerum ab.", 19L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2021, 7, 14, 22, 35, 39, 632, DateTimeKind.Unspecified).AddTicks(5147), "Ipsa error aut quidem sed recusandae.", new DateTime(2023, 5, 28, 1, 20, 22, 471, DateTimeKind.Unspecified).AddTicks(5315), true, "Fugiat non quaerat deleniti delectus.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 11, 2, 3, 36, 25, 623, DateTimeKind.Unspecified).AddTicks(3553), 4L, "Aut consequuntur dolore dolores vero veritatis commodi minus voluptas et.\nRepellendus consequatur magnam.\nMolestias ea dolores accusantium sed cum hic.", new DateTime(2023, 4, 1, 12, 48, 49, 85, DateTimeKind.Unspecified).AddTicks(9244), true, "Qui nobis iusto aut temporibus quo nihil ipsam qui.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 8, 3, 18, 29, 27, 737, DateTimeKind.Unspecified).AddTicks(1737), 1L, "Est cupiditate delectus.\nQui qui veniam eius suscipit eveniet molestiae possimus aliquam sed.\nIllum quibusdam ab incidunt recusandae.\nUt maiores vitae consequatur tempore deleniti aliquid.", new DateTime(2023, 2, 20, 1, 27, 32, 474, DateTimeKind.Unspecified).AddTicks(3894), false, "Velit odit eius reiciendis eveniet.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 10, 8, 20, 54, 59, 986, DateTimeKind.Unspecified).AddTicks(518), "Iusto ab aut quis nihil molestiae.\nQui provident nisi ut rerum dolorem ratione laboriosam.", new DateTime(2023, 12, 12, 16, 23, 13, 397, DateTimeKind.Unspecified).AddTicks(7670), "Debitis provident illo porro at libero commodi error dolore.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2022, 1, 8, 22, 19, 37, 131, DateTimeKind.Unspecified).AddTicks(5591), 3L, "Ipsam labore et et labore nihil aut dignissimos.\nMolestiae voluptatum laboriosam est rerum similique sint id.\nArchitecto sequi accusantium labore rerum nam soluta repellat.\nDeserunt nostrum iste ut iste et ratione pariatur.", new DateTime(2023, 11, 28, 6, 17, 50, 812, DateTimeKind.Unspecified).AddTicks(1465), "Eum molestiae quis maxime suscipit autem voluptatem sit repellendus.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 6, 30, 12, 45, 44, 454, DateTimeKind.Unspecified).AddTicks(6586), "Culpa quo beatae mollitia assumenda natus labore maxime.\nSequi quia culpa et sed.\nAperiam expedita id ab numquam aut rerum.", new DateTime(2022, 5, 25, 9, 53, 9, 381, DateTimeKind.Unspecified).AddTicks(9528), "In accusamus voluptates sunt rerum vero assumenda eos cupiditate.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 8L, new DateTime(2021, 12, 13, 0, 12, 36, 882, DateTimeKind.Unspecified).AddTicks(9197), "Numquam quia sint porro.", new DateTime(2022, 12, 31, 12, 30, 26, 683, DateTimeKind.Unspecified).AddTicks(8164), false, "Dolorem molestiae doloremque quo nulla modi et est enim.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 8, 20, 21, 36, 53, 739, DateTimeKind.Unspecified).AddTicks(5878), 3L, "Iste esse dolorem perferendis delectus aut sint totam.\nSunt quod beatae ipsam et quaerat nisi totam.\nAlias nobis accusantium iusto sed atque voluptas ipsa eius alias.\nQuia iste perspiciatis eos officia debitis ea corrupti.", new DateTime(2022, 5, 4, 2, 33, 33, 302, DateTimeKind.Unspecified).AddTicks(7969), "Aliquam rem exercitationem.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 6, 2, 6, 11, 25, 733, DateTimeKind.Unspecified).AddTicks(843), 2L, "Unde exercitationem sit id sed numquam nisi dolore molestiae.\nSint facere iste provident velit itaque qui consectetur.\nVero nisi voluptas libero veniam in ducimus voluptas recusandae vero.\nRatione dignissimos hic eum aut dolore quia voluptatibus possimus.", new DateTime(2022, 5, 18, 22, 33, 57, 790, DateTimeKind.Unspecified).AddTicks(5404), false, "Unde voluptates labore quasi natus.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 3, 17, 21, 0, 7, 821, DateTimeKind.Unspecified).AddTicks(2360), "Fuga id doloremque tempore quis voluptate reprehenderit quia sint.\nAut ipsum cupiditate hic vel placeat.\nPossimus quo laudantium sed repellat quibusdam.", null, "Iusto eum aliquid aut molestias aut expedita et.", 13L });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2022, 1, 6, 22, 9, 58, 974, DateTimeKind.Unspecified).AddTicks(7270), 1L, "Quia at animi eius consequatur aspernatur qui esse rerum ullam.\nEt dolorem cupiditate ducimus consectetur harum.\nNihil ab fuga eum.", 42L, "Facilis non quia quia corrupti odit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 17, 8, 20, 24, 98, DateTimeKind.Unspecified).AddTicks(9199), 1L, "Et pariatur ex omnis sed quo.\nDucimus quia omnis perspiciatis.\nMagni nisi officia quia beatae recusandae corrupti.\nSoluta laudantium sit dolorem.", false, 41L, "Non asperiores soluta." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 4, 19, 4, 45, 26, 609, DateTimeKind.Unspecified).AddTicks(9086), 3L, "Sapiente aut ipsum.\nExpedita et et aut qui pariatur quo perspiciatis cum est.\nRerum magni inventore adipisci non eligendi.", 27L, "Et nihil quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2022, 2, 1, 21, 51, 46, 978, DateTimeKind.Unspecified).AddTicks(3562), 1L, "Hic sit minima similique dolor impedit minus.\nMaiores numquam sed dolores consequatur quia.", 20L, "Non debitis ea vitae aliquid suscipit sit perferendis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 18, 18, 54, 40, 326, DateTimeKind.Unspecified).AddTicks(7170), 4L, "Est dolores quas cupiditate nam enim officiis.", 49L, "Est praesentium facilis odit repudiandae reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 27, 10, 5, 15, 270, DateTimeKind.Unspecified).AddTicks(9147), 3L, "Et sequi ut.\nQuia sit officia est voluptatem nemo beatae commodi quia doloribus.\nDicta maiores atque.\nQui amet itaque enim neque qui iure et.", true, 17L, "Maiores blanditiis doloremque perspiciatis in." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 4, 9, 1, 25, 1, 124, DateTimeKind.Unspecified).AddTicks(3352), 1L, "Cumque quisquam et.\nEsse ducimus ea saepe consequatur ipsa inventore rerum ipsum.\nMagni aut consequatur voluptate itaque consequatur sequi nostrum quisquam.", true, 29L, "Nostrum ea quia laudantium cum molestias dolor." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 12, 22, 50, 5, 891, DateTimeKind.Unspecified).AddTicks(4657), 2L, "Itaque exercitationem perspiciatis hic.\nIpsa facilis sed molestias doloribus culpa.", 7L, "Et velit deleniti nemo sit vel atque numquam rerum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Title" },
                values: new object[] { new DateTime(2021, 10, 12, 3, 19, 37, 413, DateTimeKind.Unspecified).AddTicks(2531), 5L, "Autem consequatur repudiandae labore occaecati labore repellat architecto.\nLaboriosam suscipit dolorem et tenetur enim debitis.\nPerspiciatis vel et.\nBlanditiis quasi eius.", true, "Velit repellat nihil quia nisi et quos voluptatem a error." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 3, 23, 26, 12, 531, DateTimeKind.Unspecified).AddTicks(8974), 3L, "Et et enim quasi nam quaerat quam iure voluptatem.\nNon velit amet est distinctio suscipit exercitationem.", false, 3L, "Veniam asperiores qui quis earum voluptas qui beatae laboriosam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 4, 11, 9, 2, 14, 794, DateTimeKind.Unspecified).AddTicks(3353), "Velit sint qui reiciendis ratione alias omnis sapiente.\nIusto doloribus consectetur quasi qui quidem animi.\nAsperiores pariatur vel voluptatem temporibus.\nIste quibusdam voluptatibus quisquam voluptatem eum.", true, 40L, "Enim voluptas ut excepturi debitis sapiente fuga dolorem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 24, 18, 52, 9, 721, DateTimeKind.Unspecified).AddTicks(3781), 5L, "Reiciendis cumque beatae.", 40L, "Non libero et nobis amet nostrum qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 14, 2, 57, 22, 932, DateTimeKind.Unspecified).AddTicks(6614), 2L, "Ea culpa dicta cum quo.", 30L, "Harum voluptatem quam reprehenderit velit et ut dolor." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 13, 4, 32, 10, 317, DateTimeKind.Unspecified).AddTicks(236), "A enim odit omnis consequuntur fugiat qui fugit.\nId animi quas voluptatem perferendis quod deleniti molestiae ullam.\nCumque eligendi qui voluptates ut vitae eum omnis sit.\nHarum deserunt velit praesentium.", true, 18L, "Animi aut iste labore voluptatem omnis rem vero." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 7, 23, 28, 49, 544, DateTimeKind.Unspecified).AddTicks(1619), 2L, "Explicabo repellendus perspiciatis et.\nPariatur ipsum asperiores voluptatem accusantium error commodi similique eligendi.", true, 5L, "Unde alias maiores qui similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Title" },
                values: new object[] { new DateTime(2021, 3, 13, 12, 0, 24, 212, DateTimeKind.Unspecified).AddTicks(4416), "Consequatur et facere vero quo et dolorem.\nEa maiores quae numquam soluta ut dolor.\nEsse odio quam possimus assumenda et.\nDolore non est totam in aliquid hic.", true, "Aut amet quae in." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 23, 0, 59, 37, 299, DateTimeKind.Unspecified).AddTicks(5280), 3L, "Provident quidem iure officia assumenda id sequi recusandae quo.\nRepellat quas molestiae.", 40L, "Ut quam eos nemo repellendus id vel neque impedit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 6, 5, 9, 25, 836, DateTimeKind.Unspecified).AddTicks(3816), 1L, "Dolores quidem voluptatem tenetur quod.", false, 51L, "Itaque quo ea temporibus similique unde." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Title" },
                values: new object[] { new DateTime(2021, 12, 2, 0, 30, 15, 21, DateTimeKind.Unspecified).AddTicks(955), 4L, "Commodi perferendis nemo dolorum.\nAssumenda esse dolores quod quasi voluptas qui quos.\nSint repudiandae aut ex sunt excepturi.\nCumque earum quam molestiae minima quos repellendus odio id.\nEnim sunt quasi assumenda fuga quo suscipit aperiam eos culpa.", "Aut voluptas dolor dignissimos illo et illo soluta ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 23, 22, 17, 2, 787, DateTimeKind.Unspecified).AddTicks(7573), 3L, "Ratione in ex distinctio architecto.", 11L, "Est ut sed aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 3, 15, 44, 47, 482, DateTimeKind.Unspecified).AddTicks(6129), 3L, "Quia tenetur non veniam sed dolor dolore.", true, 31L, "Inventore consequatur sit provident quos quam cumque saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 8, 22, 14, 373, DateTimeKind.Unspecified).AddTicks(7594), "Qui id eos hic sint quos in rerum est.\nEnim facilis consequatur fuga alias.\nRem quasi blanditiis saepe.", false, 49L, "Error error neque est porro aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 15, 7, 3, 22, 371, DateTimeKind.Unspecified).AddTicks(9042), 3L, "Quis ea quisquam sunt voluptatibus.\nImpedit animi est natus quia magnam id dolorum earum.\nUt eius facilis et expedita amet sed.", false, 7L, "Et odio dolorum consequatur et nihil." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 28, 21, 43, 18, 248, DateTimeKind.Unspecified).AddTicks(9890), 5L, "Corporis iusto eius minima aut corrupti nemo placeat.\nDoloremque eum sint quas dolor.\nEt illo qui.", 4L, "A enim necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 21, 51, 40, 110, DateTimeKind.Unspecified).AddTicks(1577), 4L, "Rerum laboriosam libero omnis sunt ullam sit quisquam.\nAccusamus qui laboriosam et commodi.\nIllum dolore animi repellendus.\nOmnis ut debitis nemo quas quod dolorum magnam perferendis quia.\nQuasi molestiae sunt.", 36L, "Sed a maiores esse." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 2, 3, 10, 51, 408, DateTimeKind.Unspecified).AddTicks(2202), 3L, "Eum harum alias aut quod praesentium commodi aliquam.\nSoluta non nihil sapiente facere distinctio repudiandae vel quo.", 7L, "Deleniti eum omnis est non pariatur quisquam doloremque voluptatem doloremque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 7, 13, 46, 50, 192, DateTimeKind.Unspecified).AddTicks(5321), 2L, "Corporis eius et laborum minus odio nihil maiores.\nIncidunt aliquid dolores aut quibusdam eveniet quasi consequatur est consectetur.\nNumquam id similique veniam numquam quo quia tenetur voluptas.\nAut et rem sed vel quo beatae.", true, 2L, "Ab omnis magni aliquid blanditiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 13, 6, 55, 38, 674, DateTimeKind.Unspecified).AddTicks(1978), 2L, "Reiciendis quos cumque et ut.\nVoluptatem fugit rem distinctio corporis sed.\nAccusantium voluptatibus quam sit asperiores praesentium.", false, 50L, "Et ut placeat repellat similique molestias sequi nihil quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 25, 13, 20, 39, 493, DateTimeKind.Unspecified).AddTicks(1451), 4L, "Et cum inventore qui hic repellat.\nSit ipsum et.\nCorporis aut officia.\nUt quo eos.", false, 16L, "Sit provident numquam qui illum quibusdam fuga quis sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 1, 5, 802, DateTimeKind.Unspecified).AddTicks(9842), 1L, "Quod quia voluptatem molestias facere.\nUllam eius corporis eius incidunt et omnis est eum.\nNihil quo ut fugiat occaecati dolor quod sint assumenda sed.", false, 19L, "Voluptatem vel sit debitis ullam tempore aperiam sit qui consequatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 18, 10, 13, 19, 725, DateTimeKind.Unspecified).AddTicks(8611), 5L, "Ea rerum mollitia aut qui itaque.", 30L, "Quos dignissimos ut ut nulla ducimus ex." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 4, 8, 0, 56, 372, DateTimeKind.Unspecified).AddTicks(405), 4L, "Quasi a dicta qui est quod et voluptatem.\nMaiores laudantium et rerum molestiae voluptatum.\nAmet rerum suscipit fugiat autem tempora quas aut.\nExpedita accusantium placeat ea iure praesentium aspernatur dolorum iusto aliquid.", 42L, "Officiis laudantium eligendi fugiat sapiente eum ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 23, 12, 898, DateTimeKind.Unspecified).AddTicks(3916), "Maxime perferendis et voluptas voluptas blanditiis beatae itaque aperiam.", false, 4L, "Eos consequatur velit vero distinctio non incidunt ut eius." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 21, 3, 23, 19, 906, DateTimeKind.Unspecified).AddTicks(7557), "Eligendi temporibus doloremque facilis ut ex.\nCorrupti provident sed et porro dicta.", 31L, "Commodi ducimus quia sunt architecto fugiat esse." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 17, 11, 9, 18, 472, DateTimeKind.Unspecified).AddTicks(3600), 3L, "Ut qui commodi.", true, 27L, "Fugiat vel magni sunt sunt quia sit exercitationem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 1, 12, 22, 56, 128, DateTimeKind.Unspecified).AddTicks(1832), 3L, "Tempora occaecati quo autem consequatur minima minus.\nInventore consequuntur aut qui nulla ea id.\nQui ipsam ab ad in sint iure voluptas.", true, 12L, "Consequatur consequatur qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 19, 2, 17, 24, 400, DateTimeKind.Unspecified).AddTicks(5885), 2L, "Occaecati perferendis aliquid velit voluptates sit aliquam omnis libero.\nId ex maiores quos.", 17L, "Cumque eos asperiores magnam est et similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 7, 42, 945, DateTimeKind.Unspecified).AddTicks(6116), 5L, "Ea maiores fugit.\nArchitecto blanditiis eaque voluptatem doloribus.", false, 3L, "Accusamus sed est quisquam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 1, 0, 59, 15, 148, DateTimeKind.Unspecified).AddTicks(2098), 4L, "Voluptatem earum error adipisci odio molestias porro repudiandae.\nQuia nisi omnis doloremque qui.\nMollitia nihil similique eaque repellat optio.\nIure modi aut omnis quis quidem beatae voluptatem.", true, 45L, "Quis qui deleniti provident in ut consectetur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 4, 9, 17, 20, 29, 794, DateTimeKind.Unspecified).AddTicks(2974), 4L, "Laboriosam dignissimos eaque.\nEligendi suscipit voluptatem porro hic cum iste laboriosam sunt cum.\nBeatae quo aut quibusdam.\nVoluptates est nisi ab vitae dignissimos.", 13L, "Reprehenderit excepturi voluptatem mollitia consequatur ad aut quod et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 12, 2, 15, 53, 75, DateTimeKind.Unspecified).AddTicks(8374), 2L, "Sed quo ipsum ipsum et officia.\nIpsa voluptas alias dolor.\nEst aspernatur maiores at.\nCommodi molestiae doloribus dolores.\nUt omnis ipsa aliquam vel deleniti eligendi ut aut.", 51L, "Qui culpa ab quam voluptas animi qui et doloribus qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 19, 15, 6, 14, 985, DateTimeKind.Unspecified).AddTicks(7202), 2L, "Eos culpa ea et assumenda quod laborum nostrum vel.\nEt itaque aliquam ut accusamus velit magni nam.\nQuo aliquid quam adipisci.", true, 10L, "Voluptates enim quae rerum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 28, 21, 11, 0, 808, DateTimeKind.Unspecified).AddTicks(4408), 5L, "Quidem accusamus ea delectus dolor recusandae.", 4L, "Earum reiciendis voluptatem quis praesentium ea quidem iure ex." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 13, 10, 4, 54, 66, DateTimeKind.Unspecified).AddTicks(8454), 1L, "Quod quam accusamus quo aliquid ea nemo sint deleniti eveniet.\nDeleniti inventore asperiores sit sunt nulla rerum qui.", 27L, "Qui vel et illum nihil porro." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 12, 12, 45, 20, 284, DateTimeKind.Unspecified).AddTicks(393), 5L, "Assumenda doloremque illo.\nOfficiis quam error ratione ipsum et odio.", true, 11L, "Molestiae dignissimos quo itaque vero facilis itaque sint consequatur reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 14, 18, 29, 32, 451, DateTimeKind.Unspecified).AddTicks(8937), "Similique quis distinctio fugiat sapiente temporibus voluptatum nam id sed.\nIllum saepe rerum qui dicta iste nesciunt dolorem natus.\nEst id repellat.", 24L, "Ut consequatur praesentium dolorum fugit officiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 5, 0, 27, 5, 721, DateTimeKind.Unspecified).AddTicks(3779), 4L, "Omnis perspiciatis vitae illo sequi qui.\nModi quis veritatis a quae pariatur.", 45L, "Est hic eveniet et ratione repellat et possimus qui amet." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 8, 4, 40, 46, 524, DateTimeKind.Unspecified).AddTicks(8857), 1L, "Et velit maxime rerum.\nVoluptas eum aut dignissimos dolorem tempora ratione expedita.\nSint debitis ut velit natus impedit doloribus pariatur assumenda et.\nEt explicabo error.\nEt iste quae impedit voluptates ratione tenetur voluptas.", 31L, "Et eos quo qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 8, 23, 1, 37, 68, DateTimeKind.Unspecified).AddTicks(8878), "Dolor inventore et.", false, 40L, "Animi soluta cum qui reiciendis porro facilis fuga accusamus molestiae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 8, 11, 52, 38, 75, DateTimeKind.Unspecified).AddTicks(6014), 3L, "Error aperiam assumenda eum sint rem consequatur magnam dicta.\nReprehenderit necessitatibus autem sint veritatis quis magni.\nOfficia minus sunt cupiditate laboriosam id aut vel aut optio.\nEt et exercitationem ut sint vitae.", 7L, "Quis sed laborum dolor iusto." });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2021, 7, 29, 12, 24, 39, 856, DateTimeKind.Unspecified).AddTicks(6892), 5L, new DateTime(2022, 1, 10, 9, 38, 27, 511, DateTimeKind.Unspecified).AddTicks(6602), 13L, new DateTime(2020, 1, 10, 18, 25, 2, 266, DateTimeKind.Unspecified).AddTicks(2740), new DateTime(2021, 2, 26, 9, 27, 56, 848, DateTimeKind.Unspecified).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2022, 1, 25, 16, 47, 8, 57, DateTimeKind.Unspecified).AddTicks(9401), 5L, new DateTime(2022, 1, 20, 9, 54, 2, 598, DateTimeKind.Unspecified).AddTicks(3610), 5L, new DateTime(2019, 9, 16, 12, 31, 25, 749, DateTimeKind.Unspecified).AddTicks(5592), new DateTime(2021, 6, 8, 17, 11, 0, 7, DateTimeKind.Unspecified).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 6, 16, 13, 44, 5, 333, DateTimeKind.Unspecified).AddTicks(8004), 3L, new DateTime(2022, 1, 27, 1, 6, 58, 453, DateTimeKind.Unspecified).AddTicks(1201), 69L, new DateTime(2019, 4, 16, 5, 33, 0, 92, DateTimeKind.Unspecified).AddTicks(9639), new DateTime(2021, 5, 22, 10, 25, 28, 28, DateTimeKind.Unspecified).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 16L, new DateTime(2021, 8, 10, 0, 18, 14, 935, DateTimeKind.Unspecified).AddTicks(8036), 4L, new DateTime(2022, 1, 8, 16, 34, 51, 662, DateTimeKind.Unspecified).AddTicks(8594), 39L, new DateTime(2019, 6, 4, 6, 58, 52, 766, DateTimeKind.Unspecified).AddTicks(3658), new DateTime(2021, 1, 5, 12, 19, 47, 337, DateTimeKind.Unspecified).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 7L, new DateTime(2021, 9, 22, 8, 39, 3, 132, DateTimeKind.Unspecified).AddTicks(8829), 2L, new DateTime(2022, 1, 15, 20, 49, 18, 3, DateTimeKind.Unspecified).AddTicks(3562), 46L, new DateTime(2019, 11, 16, 14, 39, 46, 314, DateTimeKind.Unspecified).AddTicks(8354), new DateTime(2021, 1, 5, 23, 17, 46, 392, DateTimeKind.Unspecified).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 9, 1, 2, 57, 30, 519, DateTimeKind.Unspecified).AddTicks(3030), new DateTime(2022, 1, 23, 21, 46, 54, 103, DateTimeKind.Unspecified).AddTicks(3806), 79L, new DateTime(2019, 4, 26, 17, 24, 33, 224, DateTimeKind.Unspecified).AddTicks(7212), new DateTime(2021, 12, 12, 5, 30, 35, 521, DateTimeKind.Unspecified).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 11, 13, 16, 31, 22, 622, DateTimeKind.Unspecified).AddTicks(7540), new DateTime(2022, 1, 27, 8, 29, 22, 99, DateTimeKind.Unspecified).AddTicks(9449), 65L, new DateTime(2019, 11, 29, 3, 7, 53, 756, DateTimeKind.Unspecified).AddTicks(7999), new DateTime(2021, 12, 26, 3, 58, 29, 39, DateTimeKind.Unspecified).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 47L, new DateTime(2021, 3, 6, 4, 32, 22, 514, DateTimeKind.Unspecified).AddTicks(1008), new DateTime(2022, 1, 26, 23, 5, 54, 966, DateTimeKind.Unspecified).AddTicks(3022), 18L, new DateTime(2019, 6, 11, 18, 15, 17, 434, DateTimeKind.Unspecified).AddTicks(6440), new DateTime(2021, 8, 30, 19, 27, 7, 888, DateTimeKind.Unspecified).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 11, 7, 4, 7, 57, 618, DateTimeKind.Unspecified).AddTicks(5254), new DateTime(2022, 1, 16, 4, 38, 3, 244, DateTimeKind.Unspecified).AddTicks(9827), 56L, new DateTime(2019, 6, 8, 20, 23, 4, 897, DateTimeKind.Unspecified).AddTicks(2230), new DateTime(2021, 2, 15, 10, 29, 3, 323, DateTimeKind.Unspecified).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 5, 25, 3, 11, 24, 122, DateTimeKind.Unspecified).AddTicks(6274), new DateTime(2022, 1, 2, 6, 33, 35, 780, DateTimeKind.Unspecified).AddTicks(5478), 71L, new DateTime(2020, 1, 1, 8, 2, 55, 804, DateTimeKind.Unspecified).AddTicks(5853), new DateTime(2021, 6, 14, 10, 52, 58, 613, DateTimeKind.Unspecified).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 9, 3, 15, 55, 13, 292, DateTimeKind.Unspecified).AddTicks(4153), 3L, new DateTime(2022, 1, 17, 4, 52, 0, 1, DateTimeKind.Unspecified).AddTicks(5388), 8L, new DateTime(2019, 10, 19, 19, 38, 28, 188, DateTimeKind.Unspecified).AddTicks(3044), new DateTime(2021, 10, 26, 20, 20, 8, 548, DateTimeKind.Unspecified).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 7, 11, 15, 51, 13, 490, DateTimeKind.Unspecified).AddTicks(9800), 3L, new DateTime(2022, 1, 18, 21, 37, 0, 921, DateTimeKind.Unspecified).AddTicks(2829), 45L, new DateTime(2019, 2, 6, 20, 38, 22, 621, DateTimeKind.Unspecified).AddTicks(8373), new DateTime(2021, 3, 31, 6, 31, 12, 348, DateTimeKind.Unspecified).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 26L, new DateTime(2021, 8, 4, 6, 29, 21, 871, DateTimeKind.Unspecified).AddTicks(6453), new DateTime(2022, 2, 1, 13, 0, 27, 507, DateTimeKind.Unspecified).AddTicks(6), 18L, new DateTime(2019, 5, 12, 22, 44, 58, 209, DateTimeKind.Unspecified).AddTicks(2881), new DateTime(2021, 10, 21, 11, 29, 13, 380, DateTimeKind.Unspecified).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 4, 25, 23, 44, 30, 362, DateTimeKind.Unspecified).AddTicks(8774), 1L, new DateTime(2022, 1, 20, 16, 53, 6, 954, DateTimeKind.Unspecified).AddTicks(7665), 33L, new DateTime(2020, 1, 5, 2, 38, 25, 699, DateTimeKind.Unspecified).AddTicks(385), new DateTime(2021, 8, 2, 18, 27, 56, 571, DateTimeKind.Unspecified).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 7, 8, 0, 9, 14, 403, DateTimeKind.Unspecified).AddTicks(2696), 2L, null, 74L, new DateTime(2019, 5, 7, 13, 40, 46, 624, DateTimeKind.Unspecified).AddTicks(5583), new DateTime(2021, 2, 13, 6, 24, 30, 457, DateTimeKind.Unspecified).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 7, 20, 11, 15, 54, 190, DateTimeKind.Unspecified).AddTicks(5920), 3L, new DateTime(2022, 1, 17, 23, 56, 48, 704, DateTimeKind.Unspecified).AddTicks(6786), 38L, new DateTime(2019, 5, 20, 3, 19, 12, 594, DateTimeKind.Unspecified).AddTicks(8401), new DateTime(2021, 1, 22, 23, 1, 46, 555, DateTimeKind.Unspecified).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 46L, new DateTime(2022, 1, 3, 3, 6, 28, 297, DateTimeKind.Unspecified).AddTicks(7985), 1L, new DateTime(2022, 1, 29, 20, 7, 40, 890, DateTimeKind.Unspecified).AddTicks(9289), 28L, new DateTime(2019, 2, 5, 3, 16, 26, 249, DateTimeKind.Unspecified).AddTicks(515), new DateTime(2021, 6, 24, 4, 25, 40, 987, DateTimeKind.Unspecified).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 7, 2, 16, 44, 22, 808, DateTimeKind.Unspecified).AddTicks(1424), null, 66L, new DateTime(2019, 2, 8, 15, 9, 1, 144, DateTimeKind.Unspecified).AddTicks(6661), new DateTime(2021, 1, 4, 1, 59, 59, 389, DateTimeKind.Unspecified).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 4, 9, 23, 39, 14, 566, DateTimeKind.Unspecified).AddTicks(6421), 5L, new DateTime(2022, 1, 23, 16, 30, 38, 986, DateTimeKind.Unspecified).AddTicks(4990), 31L, new DateTime(2019, 12, 9, 9, 47, 55, 538, DateTimeKind.Unspecified).AddTicks(9154), new DateTime(2021, 10, 15, 4, 3, 35, 246, DateTimeKind.Unspecified).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 6, 21, 4, 6, 31, 122, DateTimeKind.Unspecified).AddTicks(321), 2L, new DateTime(2022, 1, 29, 2, 53, 25, 648, DateTimeKind.Unspecified).AddTicks(1708), 41L, new DateTime(2019, 7, 21, 6, 17, 26, 293, DateTimeKind.Unspecified).AddTicks(680), new DateTime(2021, 5, 31, 18, 46, 20, 654, DateTimeKind.Unspecified).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 26L, new DateTime(2021, 9, 7, 8, 9, 44, 308, DateTimeKind.Unspecified).AddTicks(1835), new DateTime(2022, 1, 20, 21, 49, 58, 731, DateTimeKind.Unspecified).AddTicks(5082), 63L, new DateTime(2019, 12, 28, 6, 2, 14, 619, DateTimeKind.Unspecified).AddTicks(2759), new DateTime(2021, 1, 29, 5, 6, 45, 393, DateTimeKind.Unspecified).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 3, 9, 18, 6, 57, 980, DateTimeKind.Unspecified).AddTicks(8250), new DateTime(2022, 1, 4, 7, 36, 21, 882, DateTimeKind.Unspecified).AddTicks(7533), 18L, new DateTime(2019, 3, 2, 1, 18, 7, 327, DateTimeKind.Unspecified).AddTicks(1830), new DateTime(2021, 5, 20, 14, 0, 21, 933, DateTimeKind.Unspecified).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 6, 21, 12, 34, 27, 656, DateTimeKind.Unspecified).AddTicks(3980), 3L, new DateTime(2022, 1, 7, 2, 18, 31, 493, DateTimeKind.Unspecified).AddTicks(9281), 70L, new DateTime(2019, 9, 7, 20, 22, 0, 671, DateTimeKind.Unspecified).AddTicks(3794), new DateTime(2021, 12, 11, 13, 53, 0, 845, DateTimeKind.Unspecified).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 8, 8, 23, 36, 3, 399, DateTimeKind.Unspecified).AddTicks(4230), new DateTime(2022, 1, 26, 2, 38, 55, 333, DateTimeKind.Unspecified).AddTicks(8808), 62L, new DateTime(2019, 6, 22, 0, 47, 2, 772, DateTimeKind.Unspecified).AddTicks(4595), new DateTime(2021, 1, 31, 22, 14, 21, 603, DateTimeKind.Unspecified).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 9, 17, 22, 26, 47, 317, DateTimeKind.Unspecified).AddTicks(3571), 1L, new DateTime(2022, 1, 31, 17, 36, 1, 390, DateTimeKind.Unspecified).AddTicks(4920), 32L, new DateTime(2019, 6, 16, 16, 28, 15, 507, DateTimeKind.Unspecified).AddTicks(6956), new DateTime(2021, 8, 13, 10, 6, 14, 194, DateTimeKind.Unspecified).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 10, 5, 16, 51, 4, 725, DateTimeKind.Unspecified).AddTicks(8981), 1L, new DateTime(2022, 1, 23, 16, 6, 36, 980, DateTimeKind.Unspecified).AddTicks(7209), 15L, new DateTime(2019, 3, 10, 9, 19, 47, 714, DateTimeKind.Unspecified).AddTicks(3539), new DateTime(2021, 4, 22, 2, 59, 20, 247, DateTimeKind.Unspecified).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 11, 5, 17, 35, 5, 75, DateTimeKind.Unspecified).AddTicks(4082), 5L, new DateTime(2022, 1, 2, 2, 9, 51, 536, DateTimeKind.Unspecified).AddTicks(1366), 5L, new DateTime(2019, 10, 13, 19, 9, 6, 638, DateTimeKind.Unspecified).AddTicks(4941), new DateTime(2021, 12, 23, 12, 5, 7, 405, DateTimeKind.Unspecified).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 12, 3, 18, 56, 33, 573, DateTimeKind.Unspecified).AddTicks(6989), 5L, new DateTime(2022, 1, 22, 5, 59, 13, 206, DateTimeKind.Unspecified).AddTicks(8219), 35L, new DateTime(2019, 6, 19, 15, 18, 15, 665, DateTimeKind.Unspecified).AddTicks(8188), new DateTime(2021, 1, 2, 14, 51, 24, 437, DateTimeKind.Unspecified).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 14L, new DateTime(2022, 1, 23, 7, 30, 29, 405, DateTimeKind.Unspecified).AddTicks(4053), 4L, null, 59L, new DateTime(2019, 2, 10, 20, 33, 47, 696, DateTimeKind.Unspecified).AddTicks(8347), new DateTime(2021, 8, 14, 19, 36, 27, 999, DateTimeKind.Unspecified).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 8, 22, 5, 3, 43, 173, DateTimeKind.Unspecified).AddTicks(2632), 2L, new DateTime(2022, 1, 14, 20, 49, 37, 814, DateTimeKind.Unspecified).AddTicks(7555), 62L, new DateTime(2019, 3, 26, 19, 51, 43, 196, DateTimeKind.Unspecified).AddTicks(8271), new DateTime(2021, 10, 25, 11, 16, 50, 294, DateTimeKind.Unspecified).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 7, 2, 15, 57, 42, 419, DateTimeKind.Unspecified).AddTicks(3876), 1L, new DateTime(2022, 1, 6, 9, 20, 12, 507, DateTimeKind.Unspecified).AddTicks(1786), 56L, new DateTime(2019, 2, 22, 7, 11, 50, 544, DateTimeKind.Unspecified).AddTicks(6459), new DateTime(2021, 6, 17, 2, 48, 47, 127, DateTimeKind.Unspecified).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 8, 8, 6, 37, 24, 653, DateTimeKind.Unspecified).AddTicks(4566), 2L, new DateTime(2022, 1, 25, 10, 42, 21, 25, DateTimeKind.Unspecified).AddTicks(8115), 56L, new DateTime(2019, 5, 6, 3, 8, 45, 200, DateTimeKind.Unspecified).AddTicks(2545), new DateTime(2021, 9, 20, 6, 50, 20, 935, DateTimeKind.Unspecified).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 7L, new DateTime(2021, 7, 4, 4, 16, 1, 22, DateTimeKind.Unspecified).AddTicks(1398), 1L, new DateTime(2022, 1, 24, 5, 29, 25, 524, DateTimeKind.Unspecified).AddTicks(4636), 8L, new DateTime(2019, 9, 24, 12, 20, 7, 184, DateTimeKind.Unspecified).AddTicks(7020), new DateTime(2021, 7, 18, 9, 12, 1, 635, DateTimeKind.Unspecified).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 3, 21, 9, 24, 33, 908, DateTimeKind.Unspecified).AddTicks(4565), 1L, new DateTime(2022, 1, 29, 0, 38, 24, 387, DateTimeKind.Unspecified).AddTicks(7434), 36L, new DateTime(2019, 10, 31, 5, 17, 6, 9, DateTimeKind.Unspecified).AddTicks(1826), new DateTime(2021, 1, 3, 17, 56, 41, 614, DateTimeKind.Unspecified).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 14L, new DateTime(2021, 10, 15, 10, 41, 36, 101, DateTimeKind.Unspecified).AddTicks(4122), 3L, new DateTime(2022, 1, 16, 0, 22, 12, 785, DateTimeKind.Unspecified).AddTicks(9721), 39L, new DateTime(2019, 6, 7, 7, 16, 31, 98, DateTimeKind.Unspecified).AddTicks(7469), new DateTime(2021, 3, 20, 14, 6, 4, 438, DateTimeKind.Unspecified).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 11, 28, 6, 19, 55, 694, DateTimeKind.Unspecified).AddTicks(1890), 2L, new DateTime(2022, 1, 11, 3, 1, 13, 362, DateTimeKind.Unspecified).AddTicks(4718), 45L, new DateTime(2019, 8, 25, 9, 10, 29, 323, DateTimeKind.Unspecified).AddTicks(8600), new DateTime(2021, 6, 23, 9, 22, 1, 286, DateTimeKind.Unspecified).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 3, 23, 3, 49, 43, 602, DateTimeKind.Unspecified).AddTicks(6524), 2L, new DateTime(2022, 1, 3, 18, 37, 44, 672, DateTimeKind.Unspecified).AddTicks(4387), 57L, new DateTime(2019, 8, 29, 11, 35, 13, 11, DateTimeKind.Unspecified).AddTicks(3036), new DateTime(2021, 12, 12, 10, 56, 0, 353, DateTimeKind.Unspecified).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 10, 8, 12, 44, 35, 359, DateTimeKind.Unspecified).AddTicks(6803), new DateTime(2022, 1, 8, 3, 59, 8, 875, DateTimeKind.Unspecified).AddTicks(6679), 56L, new DateTime(2019, 9, 16, 7, 1, 45, 573, DateTimeKind.Unspecified).AddTicks(5959), new DateTime(2021, 8, 2, 15, 30, 53, 682, DateTimeKind.Unspecified).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 3, 13, 15, 13, 53, 763, DateTimeKind.Unspecified).AddTicks(4372), new DateTime(2022, 1, 17, 16, 12, 47, 584, DateTimeKind.Unspecified).AddTicks(9471), 70L, new DateTime(2019, 6, 19, 2, 17, 11, 594, DateTimeKind.Unspecified).AddTicks(1000), new DateTime(2021, 11, 23, 5, 31, 22, 484, DateTimeKind.Unspecified).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 5, 17, 0, 59, 55, 256, DateTimeKind.Unspecified).AddTicks(5821), 4L, new DateTime(2022, 1, 7, 18, 16, 2, 27, DateTimeKind.Unspecified).AddTicks(9648), 45L, new DateTime(2019, 12, 26, 12, 39, 10, 753, DateTimeKind.Unspecified).AddTicks(7964), new DateTime(2021, 6, 5, 9, 34, 6, 614, DateTimeKind.Unspecified).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 2, 16, 11, 43, 17, 827, DateTimeKind.Unspecified).AddTicks(5436), 5L, new DateTime(2022, 1, 3, 0, 2, 13, 435, DateTimeKind.Unspecified).AddTicks(438), 41L, new DateTime(2019, 5, 24, 20, 26, 41, 511, DateTimeKind.Unspecified).AddTicks(4173), new DateTime(2021, 9, 11, 22, 38, 0, 116, DateTimeKind.Unspecified).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 14L, new DateTime(2021, 5, 3, 5, 37, 17, 665, DateTimeKind.Unspecified).AddTicks(1337), 3L, new DateTime(2022, 1, 5, 20, 19, 52, 137, DateTimeKind.Unspecified).AddTicks(8178), 59L, new DateTime(2019, 3, 20, 17, 57, 50, 854, DateTimeKind.Unspecified).AddTicks(5628), new DateTime(2021, 8, 9, 10, 18, 5, 692, DateTimeKind.Unspecified).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 7, 7, 10, 34, 54, 69, DateTimeKind.Unspecified).AddTicks(1932), 5L, null, 67L, new DateTime(2019, 8, 4, 3, 29, 25, 81, DateTimeKind.Unspecified).AddTicks(8824), new DateTime(2021, 12, 31, 0, 41, 39, 650, DateTimeKind.Unspecified).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 26L, new DateTime(2021, 4, 4, 2, 24, 16, 638, DateTimeKind.Unspecified).AddTicks(3447), 1L, new DateTime(2022, 1, 17, 1, 7, 1, 612, DateTimeKind.Unspecified).AddTicks(1454), 59L, new DateTime(2019, 5, 20, 20, 23, 50, 714, DateTimeKind.Unspecified).AddTicks(4358), new DateTime(2021, 3, 13, 7, 13, 10, 183, DateTimeKind.Unspecified).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 12, 14, 23, 19, 23, 364, DateTimeKind.Unspecified).AddTicks(1708), 5L, new DateTime(2022, 1, 1, 17, 41, 1, 57, DateTimeKind.Unspecified).AddTicks(2635), 27L, new DateTime(2019, 2, 16, 15, 12, 59, 487, DateTimeKind.Unspecified).AddTicks(7307), new DateTime(2021, 7, 5, 18, 42, 42, 119, DateTimeKind.Unspecified).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 9, 16, 21, 14, 50, 719, DateTimeKind.Unspecified).AddTicks(6461), 4L, new DateTime(2022, 1, 21, 0, 15, 35, 792, DateTimeKind.Unspecified).AddTicks(6313), 48L, new DateTime(2020, 1, 14, 13, 50, 15, 878, DateTimeKind.Unspecified).AddTicks(1999), new DateTime(2021, 7, 24, 16, 39, 13, 93, DateTimeKind.Unspecified).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 3, 18, 22, 50, 1, 607, DateTimeKind.Unspecified).AddTicks(1598), 4L, new DateTime(2022, 1, 5, 5, 26, 6, 932, DateTimeKind.Unspecified).AddTicks(9436), 46L, new DateTime(2019, 3, 1, 5, 54, 33, 301, DateTimeKind.Unspecified).AddTicks(8825), new DateTime(2021, 6, 17, 8, 28, 55, 796, DateTimeKind.Unspecified).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 12, 6, 0, 31, 25, 900, DateTimeKind.Unspecified).AddTicks(6950), new DateTime(2022, 1, 31, 16, 50, 44, 83, DateTimeKind.Unspecified).AddTicks(1616), 21L, new DateTime(2019, 5, 14, 15, 2, 13, 781, DateTimeKind.Unspecified).AddTicks(5567), new DateTime(2021, 6, 28, 6, 30, 16, 62, DateTimeKind.Unspecified).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 11, 26, 8, 6, 0, 591, DateTimeKind.Unspecified).AddTicks(2315), new DateTime(2022, 1, 23, 9, 24, 8, 993, DateTimeKind.Unspecified).AddTicks(7254), 33L, new DateTime(2019, 8, 3, 1, 11, 21, 937, DateTimeKind.Unspecified).AddTicks(3881), new DateTime(2021, 4, 27, 9, 18, 24, 460, DateTimeKind.Unspecified).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 12, 19, 9, 11, 51, 184, DateTimeKind.Unspecified).AddTicks(9328), new DateTime(2022, 1, 1, 10, 17, 6, 998, DateTimeKind.Unspecified).AddTicks(5371), 31L, new DateTime(2020, 1, 26, 16, 57, 11, 250, DateTimeKind.Unspecified).AddTicks(5246), new DateTime(2021, 10, 9, 16, 4, 36, 595, DateTimeKind.Unspecified).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 9, 9, 14, 28, 9, 333, DateTimeKind.Unspecified).AddTicks(7433), 1L, null, 28L, new DateTime(2019, 7, 17, 16, 21, 56, 337, DateTimeKind.Unspecified).AddTicks(4728), new DateTime(2021, 2, 14, 21, 59, 22, 233, DateTimeKind.Unspecified).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2021, 4, 12, 23, 32, 13, 126, DateTimeKind.Unspecified).AddTicks(1195), 1L, new DateTime(2022, 1, 13, 5, 43, 8, 505, DateTimeKind.Unspecified).AddTicks(9989), 68L, new DateTime(2019, 4, 10, 13, 30, 28, 642, DateTimeKind.Unspecified).AddTicks(1525), new DateTime(2021, 2, 23, 8, 32, 15, 541, DateTimeKind.Unspecified).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 46L, new DateTime(2021, 7, 23, 22, 11, 29, 353, DateTimeKind.Unspecified).AddTicks(5971), 4L, new DateTime(2022, 1, 4, 5, 24, 13, 76, DateTimeKind.Unspecified).AddTicks(3493), 75L, new DateTime(2020, 1, 1, 18, 2, 20, 481, DateTimeKind.Unspecified).AddTicks(7869), new DateTime(2021, 6, 20, 6, 29, 19, 785, DateTimeKind.Unspecified).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 9, 27, 11, 0, 42, 965, DateTimeKind.Unspecified).AddTicks(2786), new DateTime(2022, 1, 24, 22, 30, 15, 265, DateTimeKind.Unspecified).AddTicks(927), 20L, new DateTime(2019, 10, 4, 9, 22, 20, 190, DateTimeKind.Unspecified).AddTicks(4531), new DateTime(2021, 12, 12, 13, 5, 45, 920, DateTimeKind.Unspecified).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 12, 4, 4, 41, 40, 450, DateTimeKind.Unspecified).AddTicks(4834), 3L, new DateTime(2022, 1, 20, 2, 56, 14, 894, DateTimeKind.Unspecified).AddTicks(7685), 37L, new DateTime(2019, 6, 21, 14, 49, 16, 632, DateTimeKind.Unspecified).AddTicks(2411), new DateTime(2021, 11, 2, 13, 50, 32, 758, DateTimeKind.Unspecified).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 2L, new DateTime(2021, 11, 28, 0, 12, 38, 595, DateTimeKind.Unspecified).AddTicks(4431), 5L, new DateTime(2022, 1, 30, 9, 13, 32, 163, DateTimeKind.Unspecified).AddTicks(3431), 81L, new DateTime(2019, 12, 17, 9, 40, 1, 67, DateTimeKind.Unspecified).AddTicks(4996), new DateTime(2021, 4, 21, 0, 12, 59, 418, DateTimeKind.Unspecified).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 6, 17, 1, 28, 45, 262, DateTimeKind.Unspecified).AddTicks(4075), 2L, new DateTime(2022, 1, 12, 23, 34, 34, 640, DateTimeKind.Unspecified).AddTicks(6608), 40L, new DateTime(2019, 6, 18, 12, 18, 19, 784, DateTimeKind.Unspecified).AddTicks(1982), new DateTime(2021, 3, 16, 20, 51, 12, 328, DateTimeKind.Unspecified).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 7, 4, 23, 35, 58, 515, DateTimeKind.Unspecified).AddTicks(7239), 5L, new DateTime(2022, 1, 23, 6, 39, 39, 221, DateTimeKind.Unspecified).AddTicks(1436), 27L, new DateTime(2019, 8, 23, 5, 52, 21, 15, DateTimeKind.Unspecified).AddTicks(7362), new DateTime(2021, 2, 23, 13, 45, 43, 769, DateTimeKind.Unspecified).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 6, 14, 11, 37, 41, 256, DateTimeKind.Unspecified).AddTicks(2047), 2L, new DateTime(2022, 1, 17, 14, 27, 6, 469, DateTimeKind.Unspecified).AddTicks(4695), 24L, new DateTime(2019, 8, 17, 20, 12, 16, 640, DateTimeKind.Unspecified).AddTicks(2279), new DateTime(2021, 1, 13, 1, 14, 40, 611, DateTimeKind.Unspecified).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 10, 1, 9, 12, 25, 892, DateTimeKind.Unspecified).AddTicks(3688), new DateTime(2022, 1, 9, 5, 7, 28, 643, DateTimeKind.Unspecified).AddTicks(7764), 11L, new DateTime(2019, 3, 14, 15, 25, 24, 596, DateTimeKind.Unspecified).AddTicks(6648), new DateTime(2021, 12, 8, 23, 34, 47, 102, DateTimeKind.Unspecified).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 44L, new DateTime(2021, 12, 16, 5, 21, 40, 551, DateTimeKind.Unspecified).AddTicks(5680), 1L, new DateTime(2022, 1, 8, 19, 9, 53, 843, DateTimeKind.Unspecified).AddTicks(1063), 78L, new DateTime(2019, 12, 22, 2, 50, 19, 552, DateTimeKind.Unspecified).AddTicks(8614), new DateTime(2021, 7, 27, 1, 8, 58, 962, DateTimeKind.Unspecified).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 4, 13, 18, 5, 45, 356, DateTimeKind.Unspecified).AddTicks(5960), 3L, new DateTime(2022, 1, 14, 10, 17, 42, 52, DateTimeKind.Unspecified).AddTicks(7425), 77L, new DateTime(2019, 6, 28, 21, 54, 25, 670, DateTimeKind.Unspecified).AddTicks(7565), new DateTime(2021, 12, 20, 4, 14, 5, 155, DateTimeKind.Unspecified).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 9, 28, 18, 22, 58, 140, DateTimeKind.Unspecified).AddTicks(1317), 5L, new DateTime(2022, 1, 4, 0, 27, 55, 145, DateTimeKind.Unspecified).AddTicks(6522), 27L, new DateTime(2019, 8, 21, 7, 22, 40, 603, DateTimeKind.Unspecified).AddTicks(8843), new DateTime(2021, 5, 4, 3, 34, 44, 753, DateTimeKind.Unspecified).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 10, 6, 19, 22, 53, 774, DateTimeKind.Unspecified).AddTicks(7845), 4L, new DateTime(2022, 1, 27, 18, 13, 23, 596, DateTimeKind.Unspecified).AddTicks(4765), 54L, new DateTime(2019, 2, 15, 9, 28, 51, 714, DateTimeKind.Unspecified).AddTicks(589), new DateTime(2021, 9, 27, 3, 47, 42, 626, DateTimeKind.Unspecified).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 8, 3, 11, 0, 42, 396, DateTimeKind.Unspecified).AddTicks(3821), 4L, 42L, new DateTime(2019, 6, 16, 9, 59, 48, 471, DateTimeKind.Unspecified).AddTicks(3594), new DateTime(2021, 5, 11, 11, 40, 58, 883, DateTimeKind.Unspecified).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 2, 22, 0, 52, 5, 181, DateTimeKind.Unspecified).AddTicks(6019), 5L, new DateTime(2022, 1, 30, 9, 34, 50, 463, DateTimeKind.Unspecified).AddTicks(3906), 67L, new DateTime(2019, 2, 18, 10, 39, 13, 891, DateTimeKind.Unspecified).AddTicks(2803), new DateTime(2021, 5, 22, 14, 12, 7, 468, DateTimeKind.Unspecified).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 4, 16, 8, 39, 3, 848, DateTimeKind.Unspecified).AddTicks(5499), 5L, new DateTime(2022, 1, 5, 3, 47, 19, 151, DateTimeKind.Unspecified).AddTicks(4544), 44L, new DateTime(2019, 9, 22, 17, 9, 34, 301, DateTimeKind.Unspecified).AddTicks(2925), new DateTime(2021, 6, 14, 10, 32, 55, 199, DateTimeKind.Unspecified).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 2, 24, 6, 49, 13, 132, DateTimeKind.Unspecified).AddTicks(6155), 5L, new DateTime(2022, 1, 13, 3, 38, 38, 249, DateTimeKind.Unspecified).AddTicks(1900), 61L, new DateTime(2019, 6, 18, 18, 8, 14, 990, DateTimeKind.Unspecified).AddTicks(1840), new DateTime(2021, 11, 24, 17, 13, 59, 163, DateTimeKind.Unspecified).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 2, 22, 9, 53, 22, 310, DateTimeKind.Unspecified).AddTicks(4282), 4L, new DateTime(2022, 1, 26, 5, 8, 19, 290, DateTimeKind.Unspecified).AddTicks(5748), 46L, new DateTime(2019, 10, 2, 13, 9, 6, 894, DateTimeKind.Unspecified).AddTicks(9300), new DateTime(2021, 2, 4, 23, 33, 32, 813, DateTimeKind.Unspecified).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 21L, new DateTime(2021, 12, 12, 11, 26, 56, 694, DateTimeKind.Unspecified).AddTicks(5426), 3L, 55L, new DateTime(2019, 6, 22, 2, 53, 48, 226, DateTimeKind.Unspecified).AddTicks(8856), new DateTime(2021, 8, 5, 21, 34, 9, 526, DateTimeKind.Unspecified).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 12, 28, 8, 57, 2, 919, DateTimeKind.Unspecified).AddTicks(2616), 2L, new DateTime(2022, 2, 1, 2, 29, 29, 620, DateTimeKind.Unspecified).AddTicks(1918), 79L, new DateTime(2019, 3, 27, 17, 27, 48, 334, DateTimeKind.Unspecified).AddTicks(3048), new DateTime(2021, 11, 22, 6, 13, 36, 203, DateTimeKind.Unspecified).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 11, 16, 21, 2, 32, 965, DateTimeKind.Unspecified).AddTicks(3693), 2L, new DateTime(2022, 1, 13, 16, 42, 21, 954, DateTimeKind.Unspecified).AddTicks(8851), 49L, new DateTime(2019, 8, 6, 12, 6, 56, 439, DateTimeKind.Unspecified).AddTicks(5640), new DateTime(2021, 9, 20, 23, 57, 27, 198, DateTimeKind.Unspecified).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 4, 12, 8, 28, 56, 522, DateTimeKind.Unspecified).AddTicks(4533), 3L, new DateTime(2022, 1, 30, 22, 40, 40, 257, DateTimeKind.Unspecified).AddTicks(8004), 41L, new DateTime(2019, 8, 8, 6, 20, 57, 903, DateTimeKind.Unspecified).AddTicks(2259), new DateTime(2021, 12, 24, 14, 50, 59, 980, DateTimeKind.Unspecified).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 2, 18, 13, 9, 26, 647, DateTimeKind.Unspecified).AddTicks(6694), new DateTime(2022, 1, 2, 10, 3, 21, 745, DateTimeKind.Unspecified).AddTicks(5195), 64L, new DateTime(2019, 5, 14, 9, 46, 36, 177, DateTimeKind.Unspecified).AddTicks(5675), new DateTime(2021, 3, 9, 20, 6, 13, 881, DateTimeKind.Unspecified).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 9, 22, 4, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7738), 3L, new DateTime(2022, 1, 9, 14, 52, 6, 287, DateTimeKind.Unspecified).AddTicks(442), 11L, new DateTime(2019, 9, 4, 10, 29, 3, 379, DateTimeKind.Unspecified).AddTicks(9666), new DateTime(2021, 3, 29, 2, 0, 46, 724, DateTimeKind.Unspecified).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2022, 1, 26, 19, 14, 35, 330, DateTimeKind.Unspecified).AddTicks(3344), 5L, new DateTime(2022, 1, 29, 21, 36, 53, 947, DateTimeKind.Unspecified).AddTicks(5529), 45L, new DateTime(2019, 4, 16, 2, 6, 27, 782, DateTimeKind.Unspecified).AddTicks(3835), new DateTime(2021, 9, 9, 23, 18, 50, 452, DateTimeKind.Unspecified).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 9, 22, 11, 17, 30, 395, DateTimeKind.Unspecified).AddTicks(1396), 1L, new DateTime(2022, 1, 20, 3, 19, 19, 164, DateTimeKind.Unspecified).AddTicks(3881), 59L, new DateTime(2019, 11, 14, 5, 58, 13, 343, DateTimeKind.Unspecified).AddTicks(2962), new DateTime(2021, 10, 25, 8, 30, 4, 649, DateTimeKind.Unspecified).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 48L, new DateTime(2021, 5, 18, 11, 7, 20, 447, DateTimeKind.Unspecified).AddTicks(898), new DateTime(2022, 1, 2, 19, 57, 3, 347, DateTimeKind.Unspecified).AddTicks(2130), 71L, new DateTime(2019, 9, 19, 22, 46, 1, 379, DateTimeKind.Unspecified).AddTicks(5349), new DateTime(2021, 3, 1, 3, 9, 6, 252, DateTimeKind.Unspecified).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 9, 21, 15, 21, 44, 398, DateTimeKind.Unspecified).AddTicks(8247), 3L, new DateTime(2022, 1, 25, 13, 23, 55, 614, DateTimeKind.Unspecified).AddTicks(9540), 13L, new DateTime(2019, 10, 8, 17, 36, 31, 505, DateTimeKind.Unspecified).AddTicks(2754), new DateTime(2021, 6, 11, 8, 42, 40, 820, DateTimeKind.Unspecified).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 11, 30, 13, 45, 23, 451, DateTimeKind.Unspecified).AddTicks(7030), new DateTime(2022, 1, 31, 21, 2, 11, 663, DateTimeKind.Unspecified).AddTicks(3726), 67L, new DateTime(2019, 7, 9, 3, 37, 50, 996, DateTimeKind.Unspecified).AddTicks(1371), new DateTime(2021, 7, 28, 18, 24, 10, 203, DateTimeKind.Unspecified).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 5, 25, 11, 51, 39, 420, DateTimeKind.Unspecified).AddTicks(354), 2L, new DateTime(2022, 1, 7, 21, 6, 57, 47, DateTimeKind.Unspecified).AddTicks(3006), 80L, new DateTime(2019, 9, 20, 6, 3, 32, 131, DateTimeKind.Unspecified).AddTicks(1468), new DateTime(2021, 1, 10, 23, 41, 41, 490, DateTimeKind.Unspecified).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 2, 24, 22, 23, 32, 276, DateTimeKind.Unspecified).AddTicks(1699), 3L, new DateTime(2022, 1, 28, 14, 58, 7, 992, DateTimeKind.Unspecified).AddTicks(629), 7L, new DateTime(2019, 12, 15, 22, 55, 59, 133, DateTimeKind.Unspecified).AddTicks(7261), new DateTime(2021, 11, 27, 18, 53, 4, 606, DateTimeKind.Unspecified).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2022, 1, 5, 6, 17, 17, 683, DateTimeKind.Unspecified).AddTicks(1369), 4L, new DateTime(2022, 1, 13, 7, 36, 32, 135, DateTimeKind.Unspecified).AddTicks(1620), 76L, new DateTime(2019, 12, 27, 4, 14, 23, 865, DateTimeKind.Unspecified).AddTicks(727), new DateTime(2021, 3, 12, 2, 40, 5, 786, DateTimeKind.Unspecified).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 7, 15, 9, 34, 48, 926, DateTimeKind.Unspecified).AddTicks(5653), 4L, new DateTime(2022, 1, 28, 3, 5, 45, 509, DateTimeKind.Unspecified).AddTicks(947), 63L, new DateTime(2019, 9, 18, 2, 44, 13, 40, DateTimeKind.Unspecified).AddTicks(8682), new DateTime(2021, 3, 26, 22, 30, 13, 617, DateTimeKind.Unspecified).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 10, 3, 4, 14, 32, 742, DateTimeKind.Unspecified).AddTicks(1116), 3L, new DateTime(2022, 2, 1, 3, 43, 3, 376, DateTimeKind.Unspecified).AddTicks(6597), 73L, new DateTime(2019, 7, 31, 16, 35, 49, 176, DateTimeKind.Unspecified).AddTicks(5286), new DateTime(2021, 11, 19, 11, 4, 18, 505, DateTimeKind.Unspecified).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 8, 2, 19, 30, 59, 964, DateTimeKind.Unspecified).AddTicks(607), 2L, new DateTime(2022, 1, 25, 5, 30, 42, 111, DateTimeKind.Unspecified).AddTicks(6564), 68L, new DateTime(2019, 11, 12, 20, 31, 50, 64, DateTimeKind.Unspecified).AddTicks(8032), new DateTime(2021, 1, 28, 14, 41, 26, 903, DateTimeKind.Unspecified).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 8, 24, 22, 17, 13, 191, DateTimeKind.Unspecified).AddTicks(6438), 2L, new DateTime(2022, 1, 8, 18, 36, 39, 308, DateTimeKind.Unspecified).AddTicks(2791), 77L, new DateTime(2019, 12, 14, 13, 14, 0, 825, DateTimeKind.Unspecified).AddTicks(9047), new DateTime(2021, 1, 11, 2, 50, 26, 561, DateTimeKind.Unspecified).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 9, 20, 11, 35, 17, 996, DateTimeKind.Unspecified).AddTicks(8328), 5L, new DateTime(2022, 1, 11, 4, 34, 44, 923, DateTimeKind.Unspecified).AddTicks(1052), 6L, new DateTime(2019, 9, 30, 20, 18, 30, 287, DateTimeKind.Unspecified).AddTicks(6482), new DateTime(2021, 2, 20, 17, 38, 27, 128, DateTimeKind.Unspecified).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 11, 19, 4, 48, 0, 69, DateTimeKind.Unspecified).AddTicks(2251), 2L, new DateTime(2022, 1, 4, 6, 18, 17, 404, DateTimeKind.Unspecified).AddTicks(2775), 44L, new DateTime(2019, 12, 16, 15, 32, 28, 276, DateTimeKind.Unspecified).AddTicks(5637), new DateTime(2021, 4, 24, 11, 34, 8, 836, DateTimeKind.Unspecified).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 7, 18, 1, 24, 27, 640, DateTimeKind.Unspecified).AddTicks(7107), 4L, new DateTime(2022, 1, 16, 17, 18, 3, 159, DateTimeKind.Unspecified).AddTicks(8885), 23L, new DateTime(2019, 6, 4, 18, 20, 38, 977, DateTimeKind.Unspecified).AddTicks(8206), new DateTime(2021, 1, 19, 16, 1, 54, 283, DateTimeKind.Unspecified).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 7, 10, 1, 17, 17, 378, DateTimeKind.Unspecified).AddTicks(1479), 1L, new DateTime(2022, 1, 1, 21, 4, 44, 106, DateTimeKind.Unspecified).AddTicks(4806), 32L, new DateTime(2019, 2, 26, 22, 26, 10, 542, DateTimeKind.Unspecified).AddTicks(989), new DateTime(2021, 5, 7, 6, 4, 48, 427, DateTimeKind.Unspecified).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 12, 3, 14, 34, 28, 686, DateTimeKind.Unspecified).AddTicks(5440), 1L, new DateTime(2022, 1, 18, 21, 56, 20, 975, DateTimeKind.Unspecified).AddTicks(8241), 48L, new DateTime(2019, 8, 6, 22, 1, 18, 251, DateTimeKind.Unspecified).AddTicks(3794), new DateTime(2021, 7, 14, 6, 56, 27, 331, DateTimeKind.Unspecified).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 6, 28, 9, 11, 5, 387, DateTimeKind.Unspecified).AddTicks(2733), 3L, new DateTime(2022, 1, 10, 9, 36, 50, 547, DateTimeKind.Unspecified).AddTicks(8731), 11L, new DateTime(2019, 12, 13, 0, 31, 11, 922, DateTimeKind.Unspecified).AddTicks(1347), new DateTime(2021, 5, 22, 20, 27, 22, 82, DateTimeKind.Unspecified).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2022, 1, 5, 2, 26, 33, 780, DateTimeKind.Unspecified).AddTicks(3488), new DateTime(2022, 1, 24, 9, 16, 3, 280, DateTimeKind.Unspecified).AddTicks(451), 57L, new DateTime(2019, 5, 8, 13, 50, 6, 114, DateTimeKind.Unspecified).AddTicks(3019), new DateTime(2021, 1, 14, 21, 19, 50, 929, DateTimeKind.Unspecified).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 5, 5, 2, 21, 10, 224, DateTimeKind.Unspecified).AddTicks(6705), 5L, new DateTime(2022, 1, 1, 14, 0, 34, 780, DateTimeKind.Unspecified).AddTicks(3351), 18L, new DateTime(2019, 9, 30, 1, 44, 30, 757, DateTimeKind.Unspecified).AddTicks(5812), new DateTime(2021, 10, 10, 7, 8, 18, 794, DateTimeKind.Unspecified).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2022, 1, 1, 21, 59, 42, 570, DateTimeKind.Unspecified).AddTicks(9086), new DateTime(2022, 1, 23, 2, 7, 1, 364, DateTimeKind.Unspecified).AddTicks(3378), 64L, new DateTime(2019, 11, 24, 3, 49, 36, 232, DateTimeKind.Unspecified).AddTicks(627), new DateTime(2021, 7, 15, 6, 27, 9, 645, DateTimeKind.Unspecified).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 4, 11, 18, 45, 1, 766, DateTimeKind.Unspecified).AddTicks(2258), 5L, new DateTime(2022, 1, 19, 2, 24, 32, 860, DateTimeKind.Unspecified).AddTicks(632), 68L, new DateTime(2019, 3, 27, 3, 39, 20, 200, DateTimeKind.Unspecified).AddTicks(3606), new DateTime(2021, 4, 29, 22, 9, 45, 979, DateTimeKind.Unspecified).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 4, 14, 20, 39, 22, 120, DateTimeKind.Unspecified).AddTicks(6496), new DateTime(2022, 2, 1, 16, 16, 41, 320, DateTimeKind.Unspecified).AddTicks(1107), 61L, new DateTime(2019, 2, 24, 15, 10, 16, 780, DateTimeKind.Unspecified).AddTicks(8683), new DateTime(2021, 6, 6, 9, 36, 58, 476, DateTimeKind.Unspecified).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 2, 26, 21, 38, 35, 554, DateTimeKind.Unspecified).AddTicks(1634), 1L, new DateTime(2022, 1, 6, 7, 44, 23, 555, DateTimeKind.Unspecified).AddTicks(2164), 34L, new DateTime(2019, 10, 29, 11, 24, 42, 502, DateTimeKind.Unspecified).AddTicks(2710), new DateTime(2021, 6, 26, 10, 26, 10, 535, DateTimeKind.Unspecified).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 2, 17, 15, 13, 10, 871, DateTimeKind.Unspecified).AddTicks(124), 4L, new DateTime(2022, 1, 25, 20, 44, 30, 625, DateTimeKind.Unspecified).AddTicks(8764), 69L, new DateTime(2019, 7, 19, 19, 49, 51, 917, DateTimeKind.Unspecified).AddTicks(2053), new DateTime(2021, 7, 19, 7, 45, 46, 786, DateTimeKind.Unspecified).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 39L, "Et sint eveniet consequuntur.\nTemporibus nesciunt similique quibusdam dolor et.\nVoluptates sed atque est perspiciatis vel sint rerum.\nQui laudantium officiis id autem ad voluptas ut ut repellat.", new DateTime(2021, 4, 16, 20, 32, 42, 837, DateTimeKind.Unspecified).AddTicks(6009), 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Omnis molestiae quae delectus iusto iusto error numquam quia libero.\nRatione perspiciatis inventore.\nEligendi a ut voluptatem ab accusantium cupiditate.\nExcepturi voluptatem doloremque.\nDolor aut placeat in ea quidem cum.\nTenetur rem cum cupiditate voluptatem ut distinctio minima impedit.", new DateTime(2021, 11, 17, 11, 36, 5, 506, DateTimeKind.Unspecified).AddTicks(2915), 5L, 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 15L, "Earum et deleniti.\nEt labore vel provident facilis ea et dolor odit.\nExplicabo libero molestias et ad error eius.", new DateTime(2021, 12, 9, 14, 9, 10, 114, DateTimeKind.Unspecified).AddTicks(9370), 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 37L, "Nisi enim fuga aperiam.\nUllam quae consequatur molestias molestiae.\nEst unde in earum doloremque sed et quia omnis.", new DateTime(2021, 11, 26, 0, 13, 7, 461, DateTimeKind.Unspecified).AddTicks(6716), 3L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 3L, "Repudiandae nulla distinctio quia nemo est ut asperiores aperiam eius.", new DateTime(2021, 8, 10, 19, 48, 30, 40, DateTimeKind.Unspecified).AddTicks(4013), 3L, 31L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Qui quod libero explicabo est doloribus minima dolore fuga.", new DateTime(2021, 7, 21, 22, 31, 4, 876, DateTimeKind.Unspecified).AddTicks(488), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 25L, "Odio et eum iure sed ratione amet et consectetur.\nOmnis ut est aut.\nEt rerum dolores earum doloremque autem sint eaque.\nMolestiae similique esse optio.\nDolorum qui praesentium nemo odio culpa.", new DateTime(2021, 3, 26, 14, 6, 27, 536, DateTimeKind.Unspecified).AddTicks(2975), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 16L, "Quia voluptatum eos quia qui iste.\nDebitis enim iure ipsam.\nOptio voluptatibus et accusamus quia praesentium quidem.\nCorrupti ut sunt et sunt incidunt veniam molestiae.", new DateTime(2021, 6, 13, 7, 0, 35, 98, DateTimeKind.Unspecified).AddTicks(4199), 3L, 37L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Tempore ipsa quia aperiam rem aut dolor qui.\nIncidunt esse accusamus.", new DateTime(2021, 6, 28, 19, 24, 54, 385, DateTimeKind.Unspecified).AddTicks(738), 4L, 38L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Eius rerum voluptates rerum ut commodi vitae eius.", new DateTime(2021, 4, 7, 4, 6, 1, 297, DateTimeKind.Unspecified).AddTicks(8125), 3L, 66L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Enim veritatis enim aut eligendi qui maiores fuga.\nNam consequuntur nisi dicta modi dolorum dolorem.\nNobis quam repudiandae quam iusto est repellendus eos vel.\nAliquam quod consequatur incidunt veniam reprehenderit quod animi omnis ratione.\nEt necessitatibus facilis mollitia sit et possimus natus ad.\nAnimi dignissimos ipsa et voluptate non aliquam fugiat suscipit.", new DateTime(2021, 11, 24, 2, 49, 46, 886, DateTimeKind.Unspecified).AddTicks(6133), 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 47L, "Amet iusto voluptas tenetur ut fuga quasi soluta maiores dolor.\nUt qui odit atque accusantium in sed.\nEt exercitationem voluptas.\nDebitis praesentium atque voluptas numquam.\nEaque voluptatem optio repudiandae quo qui aut.", new DateTime(2021, 11, 6, 18, 29, 11, 56, DateTimeKind.Unspecified).AddTicks(3147), 5L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Illo quia debitis distinctio et qui at et dolorem.\nAut vitae officia vero aut.\nQuos eos vero at veritatis rerum possimus eum ex aut.\nCum aut ut est pariatur quia non ad velit repellat.", new DateTime(2021, 9, 22, 22, 19, 30, 418, DateTimeKind.Unspecified).AddTicks(973), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 21L, "Cum mollitia fugiat quia quis eligendi hic sed et.", new DateTime(2021, 12, 25, 1, 56, 36, 460, DateTimeKind.Unspecified).AddTicks(6660), 4L, 56L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Nemo quia voluptas.\nIure velit id aliquam.\nInventore qui repudiandae delectus eligendi consequatur qui quos rerum architecto.", new DateTime(2021, 2, 7, 14, 37, 14, 811, DateTimeKind.Unspecified).AddTicks(4929), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Nesciunt at ut totam dignissimos eum dolorem fugiat hic corrupti.\nEnim amet qui cum earum laboriosam officiis et.\nDolor maiores nihil aliquam natus sit possimus aperiam.\nVel temporibus laboriosam sunt adipisci.\nUt adipisci temporibus sint.", new DateTime(2022, 1, 27, 16, 44, 10, 519, DateTimeKind.Unspecified).AddTicks(8163), 1L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Unde nemo numquam.\nEos eveniet est sint aut sed.", new DateTime(2021, 3, 8, 16, 30, 30, 744, DateTimeKind.Unspecified).AddTicks(3389), 2L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Dolores unde dolores.\nIure sit asperiores et sit maxime unde ex.", new DateTime(2021, 2, 12, 9, 57, 38, 101, DateTimeKind.Unspecified).AddTicks(4368), 4L, 24L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Perferendis debitis ut quidem.\nSint eos quam fugit.", new DateTime(2021, 3, 6, 13, 27, 21, 222, DateTimeKind.Unspecified).AddTicks(7305), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 30L, "Sequi minima non debitis et.\nCommodi ipsam porro et reprehenderit ut nostrum dicta.\nEt sed quia aut necessitatibus eum provident et.\nEius error ut et alias dignissimos.\nQuo nam aut cum consequatur quia.\nPorro atque est.", new DateTime(2021, 5, 2, 19, 58, 43, 511, DateTimeKind.Unspecified).AddTicks(8277), 3L, 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 37L, "Suscipit molestiae quos at impedit et asperiores officiis fuga.\nConsequuntur distinctio itaque quisquam ullam enim enim et iste.\nConsectetur voluptate soluta voluptas aut quos fuga labore.\nImpedit recusandae est est porro quidem rerum molestias deserunt.", new DateTime(2021, 11, 11, 11, 16, 51, 772, DateTimeKind.Unspecified).AddTicks(5368), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Quae iusto dolor omnis.", new DateTime(2021, 3, 5, 6, 48, 32, 975, DateTimeKind.Unspecified).AddTicks(1990), 3L, 22L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Expedita non placeat dolorem maxime eius quia facere inventore repudiandae.\nVoluptatum perferendis modi dicta distinctio aut soluta hic cupiditate.", new DateTime(2021, 8, 20, 4, 35, 10, 372, DateTimeKind.Unspecified).AddTicks(6151), 2L, 79L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Quo et rerum similique nesciunt sit qui possimus.\nNihil necessitatibus laboriosam.", new DateTime(2021, 3, 3, 14, 25, 28, 308, DateTimeKind.Unspecified).AddTicks(8673), 5L, 40L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 16L, "Vel similique quam iste.\nEligendi ducimus officiis delectus cum rerum eligendi in.", new DateTime(2021, 7, 31, 22, 42, 52, 133, DateTimeKind.Unspecified).AddTicks(5285), 1L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Corrupti possimus eum accusantium aliquam dolorem vel assumenda laudantium.\nPraesentium nam sunt quibusdam quia architecto impedit aliquam sequi.", new DateTime(2021, 10, 21, 2, 56, 8, 619, DateTimeKind.Unspecified).AddTicks(7270), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Officiis consequatur magni mollitia qui dolor reiciendis perspiciatis ab.", new DateTime(2021, 7, 18, 14, 16, 13, 766, DateTimeKind.Unspecified).AddTicks(9543), 3L, 32L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Exercitationem molestiae voluptatibus ipsa quas aut.", new DateTime(2021, 11, 14, 3, 55, 49, 415, DateTimeKind.Unspecified).AddTicks(7157), 2L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 3L, "Aliquid quia tempore consequatur rem omnis magnam eum quibusdam.\nIpsum perferendis illo atque sed.", new DateTime(2021, 7, 26, 3, 2, 24, 986, DateTimeKind.Unspecified).AddTicks(5854), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Voluptas eveniet ut.", new DateTime(2021, 4, 28, 10, 55, 57, 528, DateTimeKind.Unspecified).AddTicks(8464), 3L, 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Omnis vel enim delectus et nihil.", new DateTime(2021, 4, 24, 18, 55, 10, 361, DateTimeKind.Unspecified).AddTicks(5571), 5L, 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 13L, "Deserunt ipsa possimus delectus doloribus voluptatem saepe omnis dolor.\nOptio perferendis est qui modi voluptate tempora.", new DateTime(2021, 10, 12, 2, 18, 9, 868, DateTimeKind.Unspecified).AddTicks(5777), 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Temporibus maxime dicta at eligendi expedita.\nEt placeat officiis enim quia at molestias quia aliquam.", new DateTime(2021, 5, 26, 0, 40, 43, 540, DateTimeKind.Unspecified).AddTicks(3180), 2L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 50L, "Aliquam labore ipsa velit ut vitae est unde.\nTotam voluptatem omnis delectus eius ut ipsum velit aut.", new DateTime(2021, 12, 12, 3, 59, 9, 521, DateTimeKind.Unspecified).AddTicks(4097), 5L, 53L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Quis eveniet ab aut cumque est.\nQuidem veniam odit corrupti pariatur consequatur quos est quisquam numquam.\nVeritatis voluptas voluptates corporis.", new DateTime(2021, 9, 24, 8, 6, 8, 95, DateTimeKind.Unspecified).AddTicks(1537), 2L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 19L, "Quo error minus fugit.\nHarum eum architecto doloremque porro pariatur sed voluptatum et.\nEos minus illo ea nihil.\nAliquam et placeat vitae sunt et.\nEx explicabo dolorum.", new DateTime(2021, 3, 2, 6, 53, 41, 178, DateTimeKind.Unspecified).AddTicks(9590), 76L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 48L, "Quis voluptatem quia nam laborum.\nDolores ut vero commodi veniam aperiam nobis tempora.\nRepellat ut et praesentium dolores.\nAperiam aliquam dolores voluptas quisquam itaque aspernatur molestias ut cumque.\nOmnis corrupti ea doloremque sit ipsa et error.", new DateTime(2021, 11, 18, 0, 44, 15, 636, DateTimeKind.Unspecified).AddTicks(6531), 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 18L, "Libero accusamus voluptatem.\nSapiente aut praesentium culpa iure.", new DateTime(2021, 3, 10, 15, 44, 16, 910, DateTimeKind.Unspecified).AddTicks(9018), 63L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "In voluptas deserunt nam culpa deleniti adipisci et ut.\nNon alias eveniet sed qui vel quae sint minus.\nEt omnis neque.\nEst et ut aspernatur sit.\nEos qui voluptates consequatur provident.\nHarum perspiciatis rerum omnis rem alias ab.", new DateTime(2021, 7, 11, 2, 28, 39, 965, DateTimeKind.Unspecified).AddTicks(1804), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Non quisquam consequuntur dolorem voluptas est dolorum soluta veniam.\nSuscipit excepturi aspernatur pariatur consequatur cum temporibus sunt sunt libero.\nDolor et ad.", new DateTime(2021, 5, 11, 22, 5, 44, 98, DateTimeKind.Unspecified).AddTicks(2176), 1L, 48L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Facere soluta officia exercitationem quos.\nPerferendis aut et quia voluptates debitis ut.\nCorporis eaque autem sequi quae at et.\nVoluptatum quo dolor ut modi pariatur maiores ut fuga saepe.", new DateTime(2021, 6, 7, 7, 18, 1, 940, DateTimeKind.Unspecified).AddTicks(7407), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 4L, "Ea laudantium nam vel accusantium delectus possimus ratione fugiat.\nAut qui sed voluptates nobis dolor doloremque accusamus sed debitis.\nQui voluptatem neque maiores quibusdam et sit.\nSuscipit quam est sed sunt quibusdam culpa consectetur molestiae.\nMolestias a quidem sint voluptas debitis nulla et quo.\nVoluptatem reiciendis voluptatem qui.", new DateTime(2021, 12, 10, 20, 56, 19, 476, DateTimeKind.Unspecified).AddTicks(6285), 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Tempora totam id enim dolores rem voluptas accusantium harum.\nOdit deserunt id.\nOptio sint officiis.\nDoloribus veniam qui minus repellendus vel sunt ex.", new DateTime(2021, 10, 23, 18, 30, 34, 596, DateTimeKind.Unspecified).AddTicks(5174), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Est animi et eaque eius voluptas.\nVero omnis qui.\nMollitia aut libero autem corporis possimus.\nQuam officia sequi numquam.", new DateTime(2021, 3, 1, 4, 36, 46, 202, DateTimeKind.Unspecified).AddTicks(6727), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 6L, "Consequatur dolores tenetur aliquid.\nTempore et alias eum expedita cumque unde.\nDolores minus quia ullam amet impedit et.\nQuibusdam iusto rerum vero doloribus minima rem sint dolores ex.\nOfficia debitis corrupti esse et.", new DateTime(2021, 4, 30, 4, 45, 59, 691, DateTimeKind.Unspecified).AddTicks(7247), 7L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Aut molestiae officiis reiciendis sit deleniti ea adipisci dolores numquam.\nNesciunt similique optio aut dolores perspiciatis reprehenderit iusto dicta.\nUllam ea a minus.", new DateTime(2021, 11, 13, 21, 2, 13, 368, DateTimeKind.Unspecified).AddTicks(4529), 3L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 51L, "Qui est debitis suscipit sint.", new DateTime(2021, 2, 5, 19, 47, 14, 271, DateTimeKind.Unspecified).AddTicks(8322), 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Eos beatae possimus porro sint quisquam vero qui occaecati eaque.\nVeniam tempore et voluptatem repudiandae.\nQuis neque ut aut.\nItaque est omnis eligendi commodi.", new DateTime(2021, 12, 16, 0, 35, 55, 674, DateTimeKind.Unspecified).AddTicks(5286), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 26L, "Nemo iusto voluptas sed sit minus mollitia.\nHarum id labore illum quia sed provident.\nQuasi assumenda necessitatibus dolorem et ut.", new DateTime(2021, 12, 4, 13, 12, 49, 653, DateTimeKind.Unspecified).AddTicks(2873), 1L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 40L, "Commodi architecto maiores et aut.\nConsequatur commodi optio quo modi rerum similique ullam laboriosam.", new DateTime(2021, 11, 10, 7, 53, 26, 136, DateTimeKind.Unspecified).AddTicks(5424), 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Alias odio voluptas et dolorum aut suscipit earum amet.\nVero molestias et labore.\nDolorum sit itaque sunt quo dolorem autem.", new DateTime(2021, 10, 30, 15, 51, 52, 4, DateTimeKind.Unspecified).AddTicks(6718), 2L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Minus dignissimos velit recusandae id cupiditate ea harum.\nNam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.", new DateTime(2021, 2, 26, 12, 1, 35, 855, DateTimeKind.Unspecified).AddTicks(3844), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nam quia dicta eius doloribus commodi non nihil.\nQuod recusandae et est.\nDebitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.", new DateTime(2021, 10, 28, 3, 37, 20, 886, DateTimeKind.Unspecified).AddTicks(3829), 1L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Est sit at placeat optio.\nSapiente pariatur et et enim.\nAccusamus molestiae labore.", new DateTime(2021, 6, 2, 19, 19, 7, 873, DateTimeKind.Unspecified).AddTicks(6561), 4L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 3L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 1L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Earum voluptate voluptatem.\nSunt sunt est non deleniti tempore provident nihil et omnis.", new DateTime(2021, 5, 22, 23, 42, 34, 208, DateTimeKind.Unspecified).AddTicks(457), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 1L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Libero dicta temporibus atque earum.\nReprehenderit eos qui eum totam.\nId cum adipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 4L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 5L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 1L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 3L, 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 8L, "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 1L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 3L, 47L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 3L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 2L, 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 65L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "Body", "CreatedAt", "ThreadId" },
                values: new object[] { "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 5L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 3L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 3L, 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 25L, "Ipsam minima vel totam vel deserunt ab.\nEnim dolorem aliquid aperiam quod tempore porro ad nemo sit.\nNisi quis dolore nihil.", new DateTime(2021, 3, 28, 17, 3, 2, 998, DateTimeKind.Unspecified).AddTicks(838), 3L, 81L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Non fugiat non porro vero reiciendis et.\nEnim facere autem molestiae.", new DateTime(2021, 4, 1, 7, 35, 59, 215, DateTimeKind.Unspecified).AddTicks(830), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 44L, "Quo corporis voluptatem.\nQuia ut architecto adipisci quasi at aliquid voluptatum et.\nConsequatur voluptate dolor doloribus quam ipsam rerum optio.\nAperiam aperiam et.", new DateTime(2021, 12, 23, 16, 16, 38, 159, DateTimeKind.Unspecified).AddTicks(4359), 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Qui quam perferendis itaque dolore eligendi expedita.\nFacilis distinctio et omnis necessitatibus quibusdam rerum.\nEt qui ex itaque quam tempora quia eos.", new DateTime(2021, 5, 6, 9, 31, 38, 3, DateTimeKind.Unspecified).AddTicks(8430), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Illo a ex minus.\nDucimus qui officiis.\nDicta suscipit voluptas libero.\nTemporibus enim qui labore.", new DateTime(2021, 10, 9, 0, 43, 5, 480, DateTimeKind.Unspecified).AddTicks(7270), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Sed tempora non officiis est sit eveniet.\nArchitecto corrupti id rerum quam nesciunt assumenda odio ut maxime.\nUt animi in iste voluptatibus aliquid ut vitae.\nVelit exercitationem vero id sed quibusdam non.\nUt at ratione qui consectetur quam voluptas dolor dolorum.", new DateTime(2021, 8, 14, 13, 57, 37, 263, DateTimeKind.Unspecified).AddTicks(4946), 5L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Quo dolor harum et maxime.\nEt ut quia ab animi occaecati beatae.\nVel autem ea molestias.\nAspernatur sunt explicabo.\nCorporis vitae porro voluptas et magni alias sit quia quia.\nImpedit maiores unde possimus aspernatur enim ea et ut.", new DateTime(2021, 9, 6, 6, 15, 51, 816, DateTimeKind.Unspecified).AddTicks(508), 1L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 23L, "Cum illum sit corporis maiores laudantium ut.\nArchitecto aut expedita nihil et voluptatibus fugiat.\nQuisquam harum consequatur quasi ea voluptas hic dolorum.\nHarum laborum harum suscipit magnam aut.\nDolores amet tempore magni magni possimus odit quis et impedit.", new DateTime(2021, 6, 4, 11, 4, 16, 100, DateTimeKind.Unspecified).AddTicks(7149), 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Dolores ea assumenda alias.", new DateTime(2021, 3, 6, 4, 28, 7, 52, DateTimeKind.Unspecified).AddTicks(1993), 1L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Sint aliquid pariatur harum enim dolorem repellat.\nMolestiae aut nemo nihil qui sapiente non harum.\nEligendi voluptas nobis tempore.\nMolestias vel dolores aut deleniti aut minima accusamus.\nOmnis voluptatem similique.\nFacere occaecati incidunt iusto laborum ut eius id dolore.", new DateTime(2021, 4, 12, 22, 5, 28, 434, DateTimeKind.Unspecified).AddTicks(9752), 4L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Quam ducimus qui.\nRerum velit nulla rem.\nUllam nisi eveniet dignissimos.", new DateTime(2021, 8, 25, 1, 50, 58, 81, DateTimeKind.Unspecified).AddTicks(488), 3L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Omnis fugit aut.", new DateTime(2021, 8, 20, 8, 30, 53, 58, DateTimeKind.Unspecified).AddTicks(3331), 3L, 59L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Qui et velit tempore et.\nQui animi dolor beatae soluta.\nEt ab explicabo eos enim consequatur omnis soluta.\nVel doloribus omnis est optio et.\nAmet et assumenda et numquam culpa.\nQuasi aspernatur tempore.", new DateTime(2021, 11, 8, 12, 17, 53, 802, DateTimeKind.Unspecified).AddTicks(2027), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 12, 5, 6, 30, 38, 947, DateTimeKind.Unspecified).AddTicks(269), 2L, 991, null, 13L, 205 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 8, 14, 6, 9, 17, 731, DateTimeKind.Unspecified).AddTicks(9278), 5L, 946, 355 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 2, 3, 21, 56, 37, 556, DateTimeKind.Unspecified).AddTicks(9854), 3L, 965, 80L, null, 43 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 7, 1, 17, 26, 9, 580, DateTimeKind.Unspecified).AddTicks(7868), 1L, 668, 40L, 264 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 8, 21, 22, 31, 33, 334, DateTimeKind.Unspecified).AddTicks(6753), 550, null, 49L, 112 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 8, 24, 1, 29, 16, 142, DateTimeKind.Unspecified).AddTicks(3044), 2L, 807, true, 11L, 343 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2022, 1, 6, 8, 42, 52, 614, DateTimeKind.Unspecified).AddTicks(5592), 4L, 592, false, 22L, 41 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 9, 2, 22, 28, 21, 237, DateTimeKind.Unspecified).AddTicks(5880), 942, 11L, 410 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 2, 6, 10, 50, 40, 773, DateTimeKind.Unspecified).AddTicks(2520), 1L, 715, 33L, 327 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2022, 1, 1, 17, 0, 10, 174, DateTimeKind.Unspecified).AddTicks(1167), 3L, 838, 6L, 59 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 10, 6, 9, 2, 35, 254, DateTimeKind.Unspecified).AddTicks(8560), 964, 9L, 447 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 3, 31, 13, 36, 47, 920, DateTimeKind.Unspecified).AddTicks(1196), 3L, 976, false, 15L, 156 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 7, 11, 23, 56, 58, 601, DateTimeKind.Unspecified).AddTicks(2655), 3L, 638, true, 9L, 220 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 2, 8, 5, 29, 59, 735, DateTimeKind.Unspecified).AddTicks(8250), 5L, 503, false, 38L, 260 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 10, 16, 22, 27, 34, 245, DateTimeKind.Unspecified).AddTicks(1654), 3L, 940, 28L, null, 141 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 9L, new DateTime(2021, 8, 23, 13, 26, 20, 279, DateTimeKind.Unspecified).AddTicks(7900), 1L, 924, 24L, 363 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 6, 8, 17, 46, 25, 820, DateTimeKind.Unspecified).AddTicks(565), 4L, 985, null, 18L, 418 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 6, 28, 10, 16, 1, 959, DateTimeKind.Unspecified).AddTicks(5819), 3L, 961, true, 28L, 459 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2021, 6, 8, 20, 56, 37, 592, DateTimeKind.Unspecified).AddTicks(2012), 4L, 587, 9L, 68 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 3, 27, 10, 7, 30, 363, DateTimeKind.Unspecified).AddTicks(5234), 5L, 548, 7L, null, 53 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 8, 5, 4, 58, 11, 558, DateTimeKind.Unspecified).AddTicks(8477), 4L, 761, 52L, null, 430 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 11, 9, 3, 59, 40, 77, DateTimeKind.Unspecified).AddTicks(5103), 872, 8L, 121 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 7, 20, 14, 45, 0, 239, DateTimeKind.Unspecified).AddTicks(4253), 620, 11L, 267 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2022, 1, 19, 0, 22, 22, 67, DateTimeKind.Unspecified).AddTicks(4748), 3L, 612, true, 7L, 52 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 8, 22, 14, 31, 4, 294, DateTimeKind.Unspecified).AddTicks(94), 2L, 644, true, null, 33L, 455 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 9, 14, 19, 45, 14, 531, DateTimeKind.Unspecified).AddTicks(3028), 2L, 655, 71L, 52 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 12, 25, 3, 18, 27, 890, DateTimeKind.Unspecified).AddTicks(4759), 5L, 549, true, null, 18L, 149 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 21L, new DateTime(2021, 7, 31, 21, 26, 43, 116, DateTimeKind.Unspecified).AddTicks(640), 544, 18L, null, 7 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 4, 18, 6, 20, 57, 950, DateTimeKind.Unspecified).AddTicks(2585), 1L, 603, false, 6L, 203 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 8, 8, 12, 22, 19, 769, DateTimeKind.Unspecified).AddTicks(5391), 1L, 691, null, 37L, 264 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 7, 2, 20, 15, 3, 76, DateTimeKind.Unspecified).AddTicks(5411), 5L, 671, 66L, null, 10 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 10, 7, 1, 1, 18, 722, DateTimeKind.Unspecified).AddTicks(5949), 4L, 880, false, 49L, null, 361 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 7, 12, 23, 55, 5, 704, DateTimeKind.Unspecified).AddTicks(5935), 5L, 582, false, 27L, 55 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 9, 19, 2, 41, 17, 952, DateTimeKind.Unspecified).AddTicks(8216), 990, 44L, 151 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 3, 20, 18, 31, 38, 293, DateTimeKind.Unspecified).AddTicks(3757), 2L, 521, true, 67L, 145 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 21L, new DateTime(2021, 7, 12, 6, 12, 43, 437, DateTimeKind.Unspecified).AddTicks(1489), 5L, 885, false, 18L, null, 488 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 6, 17, 16, 22, 56, 153, DateTimeKind.Unspecified).AddTicks(2820), 5L, 604, true, 24L, 12 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 4, 22, 16, 2, 25, 896, DateTimeKind.Unspecified).AddTicks(3052), 2L, 882, true, 29L, 312 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 8, 31, 16, 25, 27, 702, DateTimeKind.Unspecified).AddTicks(2488), 5L, 733, 21L, 305 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 10, 5, 3, 8, 32, 646, DateTimeKind.Unspecified).AddTicks(7519), 4L, 900, true, 38L, 467 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 12, 11, 3, 39, 51, 599, DateTimeKind.Unspecified).AddTicks(3856), 2L, 510, null, 34L, 290 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 11, 7, 5, 48, 18, 595, DateTimeKind.Unspecified).AddTicks(3250), 5L, 956, 17L, null, 68 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 4, 30, 18, 41, 7, 553, DateTimeKind.Unspecified).AddTicks(9375), 4L, 790, false, 49L, 135 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 3, 23, 10, 42, 40, 117, DateTimeKind.Unspecified).AddTicks(6412), 3L, 924, true, 16L, 427 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 9, 7, 10, 31, 27, 433, DateTimeKind.Unspecified).AddTicks(578), 2L, 645, 39L, null, 32 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 3, 17, 18, 20, 37, 677, DateTimeKind.Unspecified).AddTicks(4052), 1L, 645, false, 57L, 404 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 9, 21, 11, 54, 37, 20, DateTimeKind.Unspecified).AddTicks(2389), 3L, 501, 67L, 171 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 7, 2, 10, 12, 15, 113, DateTimeKind.Unspecified).AddTicks(5783), 1L, 914, 23L, null, 385 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 12, 21, 4, 44, 20, 278, DateTimeKind.Unspecified).AddTicks(6650), 5L, 510, true, null, 45L, 42 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 11, 16, 13, 6, 3, 818, DateTimeKind.Unspecified).AddTicks(714), 2L, 660, false, 79L, null, 260 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 4, 24, 14, 36, 52, 329, DateTimeKind.Unspecified).AddTicks(7400), 1L, 688, 36L, 227 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 6, 19, 22, 23, 50, 401, DateTimeKind.Unspecified).AddTicks(5997), 1L, 797, false, 19L, 81 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 3, 31, 17, 57, 53, 215, DateTimeKind.Unspecified).AddTicks(1616), 3L, 617, false, null, 13L, 31 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 4, 13, 13, 23, 8, 37, DateTimeKind.Unspecified).AddTicks(5818), 5L, 955, false, 29L, 83 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 4, 15, 3, 12, 39, 921, DateTimeKind.Unspecified).AddTicks(8542), 5L, 635, false, 26L, 169 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 10, 10, 9, 46, 50, 270, DateTimeKind.Unspecified).AddTicks(5106), 3L, 859, 46L, 136 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 9, 7, 14, 42, 1, 841, DateTimeKind.Unspecified).AddTicks(7608), 2L, 655, null, 32L, 465 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 7, 25, 5, 49, 34, 668, DateTimeKind.Unspecified).AddTicks(7406), 2L, 752, true, 19L, 253 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 5, 23, 21, 13, 50, 269, DateTimeKind.Unspecified).AddTicks(4408), 506, 22L, 15 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 6, 12, 17, 5, 5, 986, DateTimeKind.Unspecified).AddTicks(8756), 3L, 825, false, null, 44L, 27 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 7, 17, 17, 52, 20, 277, DateTimeKind.Unspecified).AddTicks(759), 3L, 819, true, 76L, null, 103 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 2, 2, 19, 7, 5, 924, DateTimeKind.Unspecified).AddTicks(411), 3L, 687, 61L, 383 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 4, 10, 21, 21, 39, 563, DateTimeKind.Unspecified).AddTicks(4556), 1L, 518, true, 20L, 429 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2021, 5, 1, 23, 24, 12, 630, DateTimeKind.Unspecified).AddTicks(1136), 3L, 501, false, 71L, 476 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2021, 10, 3, 10, 42, 27, 603, DateTimeKind.Unspecified).AddTicks(4061), 706, null, 26L, 414 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2022, 1, 31, 9, 23, 34, 334, DateTimeKind.Unspecified).AddTicks(1669), 3L, 628, true, null, 4L, 356 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 22L, new DateTime(2021, 12, 11, 14, 48, 0, 923, DateTimeKind.Unspecified).AddTicks(963), 3L, 535, null, 21L, 293 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 5, 24, 6, 4, 24, 455, DateTimeKind.Unspecified).AddTicks(4657), 3L, 531, 2L, 189 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 8, 18, 14, 19, 31, 530, DateTimeKind.Unspecified).AddTicks(338), 1L, 663, false, null, 28L, 108 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 2, 2, 4, 31, 12, 244, DateTimeKind.Unspecified).AddTicks(6771), 4L, 860, null, 49L, 114 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 5, 5, 16, 5, 7, 462, DateTimeKind.Unspecified).AddTicks(6790), 5L, 955, 56L, 142 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 10, 28, 7, 28, 4, 994, DateTimeKind.Unspecified).AddTicks(7622), 4L, 794, 2L, 344 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 6, 30, 22, 48, 14, 413, DateTimeKind.Unspecified).AddTicks(6957), 3L, 557, true, 12L, null, 456 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 3, 26, 5, 4, 34, 91, DateTimeKind.Unspecified).AddTicks(2329), 2L, 683, null, 20L, 278 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 4, 5, 14, 16, 39, 766, DateTimeKind.Unspecified).AddTicks(5317), 4L, 816, true, 39L, null, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 9, 27, 23, 59, 31, 596, DateTimeKind.Unspecified).AddTicks(3721), 2L, 923, null, 50L, 453 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 7, 16, 23, 13, 14, 386, DateTimeKind.Unspecified).AddTicks(5703), 5L, 903, 57L, 409 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 5, 21, 19, 57, 29, 205, DateTimeKind.Unspecified).AddTicks(5319), 948, 68L, 437 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 11, 9, 7, 11, 32, 677, DateTimeKind.Unspecified).AddTicks(5129), 1L, 926, 8L, null, 444 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 6, 26, 9, 13, 17, 475, DateTimeKind.Unspecified).AddTicks(301), 789, true, null, 12L, 486 });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 20L, new DateTime(2021, 11, 18, 23, 9, 42, 199, DateTimeKind.Unspecified).AddTicks(6302), "Ullam molestiae ipsam." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 3L, new DateTime(2022, 1, 9, 13, 9, 32, 119, DateTimeKind.Unspecified).AddTicks(9793), 2L, "Exercitationem quod voluptas reiciendis quasi nesciunt ullam fugit." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 18L, new DateTime(2021, 5, 15, 22, 16, 34, 789, DateTimeKind.Unspecified).AddTicks(3978), 1L, "Est numquam minima est ipsa aut temporibus assumenda pariatur provident." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 21L, new DateTime(2021, 12, 12, 13, 12, 47, 851, DateTimeKind.Unspecified).AddTicks(38), 2L, "Eligendi qui rerum cumque quos molestiae." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 18L, new DateTime(2021, 3, 24, 20, 51, 31, 421, DateTimeKind.Unspecified).AddTicks(5423), 2L, "Deleniti ut accusantium iusto architecto quaerat consequatur vel nostrum." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 21L, new DateTime(2021, 4, 12, 14, 25, 8, 63, DateTimeKind.Unspecified).AddTicks(3524), 3L, "Voluptatem enim fugiat." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 14L, new DateTime(2021, 9, 8, 6, 59, 17, 426, DateTimeKind.Unspecified).AddTicks(3809), 5L, "Non et quaerat id totam voluptatum incidunt consequatur est." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 3L, new DateTime(2021, 5, 24, 3, 31, 58, 549, DateTimeKind.Unspecified).AddTicks(3260), 2L, "Occaecati exercitationem architecto." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 16L, new DateTime(2021, 6, 6, 9, 39, 33, 359, DateTimeKind.Unspecified).AddTicks(2613), 3L, "Non et vero repudiandae sequi fugiat et." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 10L, new DateTime(2021, 6, 29, 2, 8, 17, 799, DateTimeKind.Unspecified).AddTicks(5700), 5L, "Provident qui vel eum eos impedit." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 19L, new DateTime(2021, 4, 20, 15, 57, 9, 809, DateTimeKind.Unspecified).AddTicks(6671), 5L, "Quidem est et." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 6L, new DateTime(2021, 5, 1, 10, 51, 40, 943, DateTimeKind.Unspecified).AddTicks(1932), 3L, "Vero velit placeat harum quod eius." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { new DateTime(2021, 9, 8, 18, 29, 0, 95, DateTimeKind.Unspecified).AddTicks(7224), 1L, "Ducimus quidem cum dolores earum." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 9L, new DateTime(2021, 9, 16, 11, 45, 53, 29, DateTimeKind.Unspecified).AddTicks(7193), 4L, "Eligendi est et." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 6L, new DateTime(2021, 11, 4, 8, 4, 48, 450, DateTimeKind.Unspecified).AddTicks(7657), 1L, "Natus necessitatibus qui." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 20L, new DateTime(2021, 4, 18, 13, 52, 44, 857, DateTimeKind.Unspecified).AddTicks(5568), 5L, "Corporis debitis incidunt." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 21L, new DateTime(2021, 3, 2, 17, 2, 13, 903, DateTimeKind.Unspecified).AddTicks(8822), 2L, "Ratione sit odit consequatur." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 10L, new DateTime(2022, 1, 1, 21, 21, 35, 426, DateTimeKind.Unspecified).AddTicks(2019), 5L, "Optio dolores praesentium totam ut explicabo consequatur." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 7L, new DateTime(2021, 7, 1, 4, 35, 6, 878, DateTimeKind.Unspecified).AddTicks(3673), 2L, "Rerum expedita nisi tempore omnis." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 18L, new DateTime(2021, 9, 24, 14, 49, 52, 509, DateTimeKind.Unspecified).AddTicks(3348), "Et impedit sed vel est." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 5L, new DateTime(2021, 5, 6, 7, 0, 13, 128, DateTimeKind.Unspecified).AddTicks(9555), "Repellat eligendi quae dolor accusantium." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 5L, new DateTime(2021, 4, 14, 12, 8, 24, 724, DateTimeKind.Unspecified).AddTicks(6615), 3L, "Nisi hic quos blanditiis qui dolorem natus." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 3L, new DateTime(2022, 1, 5, 12, 19, 47, 673, DateTimeKind.Unspecified).AddTicks(6028), 5L, "Omnis et assumenda maxime unde sint maiores nostrum." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 4L, new DateTime(2021, 4, 12, 21, 24, 28, 255, DateTimeKind.Unspecified).AddTicks(8016), 2L, "Qui explicabo quo reprehenderit quia laudantium harum." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 8L, new DateTime(2021, 5, 22, 21, 31, 26, 66, DateTimeKind.Unspecified).AddTicks(6517), 4L, "Eos rerum aut neque ipsam vel illum blanditiis." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 7L, new DateTime(2022, 1, 18, 20, 41, 42, 617, DateTimeKind.Unspecified).AddTicks(8558), 3L, "Non molestiae ullam et aut non aperiam nam porro." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { new DateTime(2021, 5, 6, 13, 3, 22, 901, DateTimeKind.Unspecified).AddTicks(3420), 2L, "Natus et ex nobis necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 20L, new DateTime(2021, 9, 7, 10, 27, 43, 309, DateTimeKind.Unspecified).AddTicks(1476), 2L, "Et aut nam facere tempore." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 8L, new DateTime(2022, 1, 30, 14, 35, 13, 170, DateTimeKind.Unspecified).AddTicks(8732), 1L, "Et facere voluptatem et totam et fugiat occaecati itaque." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 10L, new DateTime(2021, 9, 13, 13, 48, 2, 926, DateTimeKind.Unspecified).AddTicks(342), 1L, "Ut nulla aut facere rerum laudantium assumenda." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 21L, new DateTime(2021, 7, 20, 23, 26, 28, 66, DateTimeKind.Unspecified).AddTicks(5144), "Officia sit velit." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 14L, new DateTime(2022, 1, 18, 22, 41, 12, 982, DateTimeKind.Unspecified).AddTicks(3061), 2L, "In enim et." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 8L, new DateTime(2021, 4, 8, 5, 25, 40, 343, DateTimeKind.Unspecified).AddTicks(8302), "Sapiente ducimus pariatur consequatur quisquam repellat animi laboriosam." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 16L, new DateTime(2021, 12, 4, 20, 5, 41, 953, DateTimeKind.Unspecified).AddTicks(6540), 5L, "Sint delectus et harum nisi porro consequatur quis voluptatem qui." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 17L, new DateTime(2021, 2, 7, 21, 58, 5, 970, DateTimeKind.Unspecified).AddTicks(5876), 1L, "Consectetur maxime optio explicabo quidem natus." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 9L, new DateTime(2021, 11, 3, 8, 1, 23, 268, DateTimeKind.Unspecified).AddTicks(2938), "Sint illo commodi." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 19L, new DateTime(2021, 5, 4, 2, 54, 55, 722, DateTimeKind.Unspecified).AddTicks(7175), 5L, "Sit qui voluptate dolorum sequi animi cum sequi." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 18L, new DateTime(2021, 6, 12, 7, 42, 39, 684, DateTimeKind.Unspecified).AddTicks(839), "Excepturi quod voluptatibus quia voluptatem." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 21L, new DateTime(2021, 5, 17, 9, 0, 9, 320, DateTimeKind.Unspecified).AddTicks(7853), 4L, "Incidunt voluptatem sit illum." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 9L, new DateTime(2021, 5, 2, 21, 16, 13, 223, DateTimeKind.Unspecified).AddTicks(8858), 4L, "Aliquid reiciendis at quasi maxime." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 50L, "Ut vel eligendi ipsam officia.\nQui doloribus et vero ipsa velit quam neque error.", new DateTime(2021, 9, 3, 21, 11, 55, 628, DateTimeKind.Unspecified).AddTicks(3004), "Abbigail.Wilderman@yahoo.com", "3f885a74-7341-bbd2-c376-2e21631ffaa8", "Wellington", "Predovic", "Kale_Osinski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 30L, "Autem aut consequatur et.\nUt sint dolorem.", new DateTime(2022, 1, 14, 16, 24, 27, 340, DateTimeKind.Unspecified).AddTicks(7979), 3L, "Grayce79@hotmail.com", "a5a5d448-37aa-8755-0c9f-3688cb39e811", "Keshawn", "Cremin", "Bernardo_Turner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 36L, "Delectus aut vel dignissimos et adipisci enim qui.", new DateTime(2021, 9, 12, 19, 29, 28, 424, DateTimeKind.Unspecified).AddTicks(7463), 5L, "King.VonRueden84@yahoo.com", "7b48ee95-df07-d356-e456-d46aeb1c297d", "Tracy", "Stanton", "Randal79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 48L, "Ipsa veniam debitis molestiae aut delectus ipsam.\nVoluptate eum officiis illo.\nBlanditiis quo repellendus necessitatibus magnam debitis qui dolorum laborum.\nVoluptas qui cum veniam consequatur eos.", new DateTime(2021, 12, 7, 19, 38, 52, 826, DateTimeKind.Unspecified).AddTicks(7546), 4L, "Berneice.Kunde@gmail.com", "af82c15e-ceee-3446-7321-c96a5d45e640", "Zane", "Kshlerin", "Georgianna_Maggio27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 6L, "Hic aspernatur exercitationem quisquam vel ut voluptatum maiores.\nEt voluptatem voluptatum cupiditate.", new DateTime(2021, 12, 1, 0, 6, 51, 270, DateTimeKind.Unspecified).AddTicks(5918), 1L, "Maia48@gmail.com", "ef907709-c4e5-f99d-14e6-dcdfd9b0b761", "Bert", "Kozey", "Jason_Vandervort" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 90L, "Beatae voluptatem dolore sequi est.", new DateTime(2021, 9, 24, 22, 23, 40, 568, DateTimeKind.Unspecified).AddTicks(6617), "Hilda_Block@yahoo.com", "1a438df7-304d-239c-d30c-9d3e2eecc81f", "Yazmin", "Gulgowski", "Kelvin.Turner12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 38L, "Non esse est quos neque qui reiciendis voluptatum quia esse.", new DateTime(2021, 5, 25, 23, 4, 23, 883, DateTimeKind.Unspecified).AddTicks(6741), 2L, "Alize_Daugherty1@yahoo.com", "8e61c4ef-0895-1d92-f166-e6e1b6068af3", "Randy", "Torp", "Alysson_Feil9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 45L, "Dolorem illum consequatur accusamus sed quia.\nQui officia adipisci maxime sapiente quia quis.\nBlanditiis cumque et aut excepturi rerum.\nId velit fugit dolorum ut harum tenetur sed.", new DateTime(2021, 7, 1, 7, 37, 57, 319, DateTimeKind.Unspecified).AddTicks(3711), 1L, "Linnea_Cummings@yahoo.com", "f63ba1a8-6a38-8ae5-c79e-fce24853efb3", "Emiliano", "Senger", "Celestino_Hoppe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Bio", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { "Omnis illo qui sed autem ut corrupti eaque et aut.\nDolore eos esse et enim aspernatur aut quo.\nQuisquam repellat perspiciatis impedit consequatur molestiae quia blanditiis.\nEius fugiat aperiam sunt quam.", "7acbbce9-1a25-f1ef-0bdf-14c4962e3c05", "Nicolette", "VonRueden", "Jacques80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 29L, "Quisquam nam et cumque.\nCumque aliquid nihil.\nRem nam placeat labore qui dolores soluta deserunt molestias.\nEum nesciunt amet.", new DateTime(2021, 10, 11, 16, 33, 2, 419, DateTimeKind.Unspecified).AddTicks(745), 1L, "Julianne.Kuphal99@hotmail.com", "b288c1b3-8b05-f123-2651-63794459ccac", "Cristal", "Gorczany", "Samir67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 16L, "Provident optio sunt quia ducimus aliquam ex ratione et neque.\nPraesentium eum iusto.\nNon non repudiandae ipsa reiciendis et et distinctio nobis.\nAnimi in assumenda molestiae.\nId esse qui.", new DateTime(2021, 8, 4, 1, 10, 59, 207, DateTimeKind.Unspecified).AddTicks(1955), 4L, "Roxane85@yahoo.com", "8e49cc46-ac69-31e0-dd24-02d25526f477", "Melany", "Dibbert", "Alvah.Feeney" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 20L, "Aut velit qui architecto laudantium libero voluptas magnam.\nNostrum quasi excepturi ut ut ea.\nExercitationem aspernatur iste consequatur ad officia architecto sed facilis.", new DateTime(2021, 12, 14, 1, 45, 7, 939, DateTimeKind.Unspecified).AddTicks(332), 3L, "Pasquale_Gutkowski13@yahoo.com", "3a02fb31-8be8-a707-def8-34acce1f8987", "Damon", "Littel", "Gust_Bernier58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 22L, "Aut aut totam enim similique sequi.\nEt voluptas nisi non assumenda eveniet id tempore dolor vel.\nSit blanditiis quia sequi.", new DateTime(2021, 4, 28, 7, 35, 17, 43, DateTimeKind.Unspecified).AddTicks(7567), 5L, "Raphael.Thompson@hotmail.com", "a2f0bad9-9303-37da-9b42-a129c55baf92", "Helmer", "Hauck", "Elaina_Cassin37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 40L, "Enim et non.\nEt rerum qui soluta beatae alias officiis aperiam.", new DateTime(2021, 5, 31, 19, 15, 31, 675, DateTimeKind.Unspecified).AddTicks(298), 1L, "Toni.Deckow79@gmail.com", "986fe6f8-4d90-0c43-8342-cc3d122a935f", "Yazmin", "Erdman", "Glennie96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 78L, "Vitae laudantium quia facilis maxime consectetur fugiat velit suscipit autem.\nTotam et voluptas quisquam.\nAutem quia modi fuga vero distinctio ad.\nMollitia ipsam est sint commodi.", new DateTime(2021, 11, 5, 22, 31, 34, 921, DateTimeKind.Unspecified).AddTicks(7921), 3L, "Yoshiko_Parisian50@yahoo.com", "80979094-1157-8e11-1f2c-a9cce461c0c8", "Judy", "Rippin", "Sydney_Corwin9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 59L, "Fugiat omnis et omnis fuga.\nSuscipit a aspernatur omnis architecto quidem quia aut qui.\nEst doloribus quia laboriosam consequatur consequuntur.", new DateTime(2021, 11, 24, 2, 17, 44, 79, DateTimeKind.Unspecified).AddTicks(978), 3L, "Marcia_Cummings8@gmail.com", "28686141-be82-da81-c17b-37aaf2633961", "Amari", "Kemmer", "Annabel92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 46L, "Quos dolores iure omnis aut magnam vel est.\nVel mollitia odit id alias.\nQuos consequatur ut consequatur dolor.\nOccaecati molestiae nostrum veritatis cum fugit aut quia magni rem.\nVoluptatem iusto a molestiae qui quia incidunt quisquam consequatur.", new DateTime(2021, 9, 2, 9, 34, 13, 796, DateTimeKind.Unspecified).AddTicks(6814), 5L, "Gillian68@yahoo.com", "8f613610-f030-9243-e219-16ebde47443a", "Danial", "Doyle", "Christiana.Wisozk6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 17L, "Est quis blanditiis magni natus aut vel ut.\nIure ut beatae numquam.\nEum porro doloribus eius quidem quos eveniet culpa incidunt aspernatur.\nA cupiditate qui qui.\nDoloribus et magnam occaecati consectetur qui voluptatem voluptas ratione vitae.", new DateTime(2021, 5, 1, 8, 41, 20, 778, DateTimeKind.Unspecified).AddTicks(24), "Ava8@yahoo.com", "fc38df74-c618-34f3-f5fa-3dc61e360d3d", "Hilario", "Ruecker", "Niko4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 78L, "Omnis sequi et.", new DateTime(2021, 7, 12, 9, 36, 45, 577, DateTimeKind.Unspecified).AddTicks(9544), 1L, "Aliza26@yahoo.com", "c326ce26-bbe3-63e9-8dcf-f1ef0589c762", "Wyatt", "Koch", "Gordon_Goyette81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 99L, "Eaque deleniti aspernatur aliquid.\nLaboriosam quisquam quos non suscipit et laboriosam rerum perferendis est.\nIste ad non tenetur totam quibusdam consequatur dolore.", new DateTime(2021, 9, 20, 22, 4, 3, 358, DateTimeKind.Unspecified).AddTicks(1081), 4L, "Marilou_Gleason43@gmail.com", "d3d7fadf-4672-f0de-6f57-f3dc06fb274c", "Sunny", "Collier", "Erich_Zulauf12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 57L, "At voluptatem veniam architecto et sint explicabo commodi.\nAut aspernatur autem quae sunt aut quis quia vitae ad.", new DateTime(2021, 3, 23, 0, 43, 11, 710, DateTimeKind.Unspecified).AddTicks(4256), 4L, "Frank.Bergstrom28@gmail.com", "2d75ad46-55f4-86bd-3719-79060d30a992", "Lexus", "Pfannerstill", "Ruben_Marks" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 76L, "Velit et nemo repellendus esse quae autem.\nAdipisci tempora sit molestiae modi.", new DateTime(2021, 12, 22, 20, 3, 18, 830, DateTimeKind.Unspecified).AddTicks(6724), "Watson61@gmail.com", "0bb65f19-3b07-7e30-0108-dd27065832a0", "Keith", "Gerhold", "Eva28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 44L, "Veniam enim laboriosam.", new DateTime(2021, 2, 5, 18, 27, 34, 273, DateTimeKind.Unspecified).AddTicks(6169), 3L, "Brigitte_Anderson8@yahoo.com", "7bc5fef3-ffd8-6ca9-b878-b371fee9661f", "Lily", "Block", "Jose.Wuckert" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 95L, "Natus eaque quia molestiae ex culpa libero autem minima corrupti.\nQui et et modi dolorum quia incidunt dolores.\nVoluptatem voluptatem qui.", new DateTime(2021, 11, 16, 19, 26, 35, 13, DateTimeKind.Unspecified).AddTicks(2949), 3L, "Destiney.Hamill@hotmail.com", "bf25d257-0bd0-e516-5403-b8a6aa71bae8", "Orlando", "Erdman", "Chad_Stark" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 17L, "Saepe corrupti ipsum eaque et et vero.\nAd dolorem tempora officia pariatur eos dolorem asperiores nam.\nDolorum quae maiores dolores earum sunt corrupti deserunt est.\nRerum nam quisquam.", new DateTime(2021, 12, 25, 11, 22, 46, 476, DateTimeKind.Unspecified).AddTicks(1853), 3L, "Johan30@hotmail.com", "c43714e1-d2a7-404a-2885-edebe6a8ac8c", "Arturo", "Kling", "Naomie_Murphy54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 13L, "Laborum odit voluptatem vitae et tenetur sint quo dolores cum.\nEst quod ea maiores voluptatem dolore cumque.\nSit veniam repellendus.\nQuasi at dolores molestiae voluptas beatae.", new DateTime(2021, 6, 20, 6, 48, 45, 927, DateTimeKind.Unspecified).AddTicks(4925), "Jacinto.Franecki@hotmail.com", "6cc33791-b1c1-5a68-953a-6212a7cf7627", "Macey", "Schuster", "Noelia54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 74L, "Possimus voluptatem modi nemo consequuntur in quis eos non.\nEst qui quos.\nAperiam et temporibus rerum nobis quasi quia.", new DateTime(2021, 12, 3, 6, 8, 52, 365, DateTimeKind.Unspecified).AddTicks(4591), 2L, "Marjolaine_Kuvalis@gmail.com", "0ed2c5bf-161a-2cb9-6876-df034268fed0", "Danyka", "Hackett", "Orrin_Mraz24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 2L, "Blanditiis unde id totam quisquam omnis ut.\nAsperiores ut nesciunt nesciunt qui in porro molestias.", new DateTime(2021, 5, 1, 10, 54, 41, 672, DateTimeKind.Unspecified).AddTicks(6495), 4L, "Gregorio27@yahoo.com", "01301a1d-6ce4-3d42-012e-9b06ee37324f", "Sharon", "Koch", "Bettye79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 32L, "Sunt animi ex atque facilis corporis ex.\nVoluptas nulla asperiores error suscipit at.\nDolores est et.", new DateTime(2021, 6, 26, 19, 14, 53, 745, DateTimeKind.Unspecified).AddTicks(3622), "Maida.Aufderhar@yahoo.com", "454c238d-f964-86cc-1227-41b9132e3380", "Davonte", "Becker", "Jermaine44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 79L, "Omnis repellat deleniti eos occaecati beatae et.\nPossimus eaque facere.\nProvident nihil voluptas in non ducimus non ipsa ex.\nUt quis vero et aperiam ut quia laborum est et.", new DateTime(2021, 3, 30, 8, 32, 13, 830, DateTimeKind.Unspecified).AddTicks(4156), 2L, "Fannie_Mayert@hotmail.com", "b25370f0-76d5-6352-275b-b2dd02770c8e", "Shad", "Nitzsche", "Jaime11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 12L, "Ipsam nulla delectus sit.\nAut rerum sequi beatae vitae cupiditate voluptatem nulla quod.\nAccusamus ex repellat nemo et molestiae exercitationem adipisci modi.\nNihil et quod assumenda.\nEt natus eius saepe sint nobis voluptatem eum amet.", new DateTime(2022, 1, 23, 4, 38, 17, 545, DateTimeKind.Unspecified).AddTicks(7299), "Terrill_Balistreri@yahoo.com", "0f85878e-62cc-342e-7596-b979ca69c1b1", "Alvah", "Williamson", "Alberto59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 25L, "Consequatur aut optio in earum error fugit dolorem soluta numquam.\nHarum cupiditate facere repudiandae a.\nEveniet aperiam minima voluptas.\nQuia voluptatem rerum.\nNisi ratione repudiandae.", new DateTime(2021, 7, 12, 5, 52, 38, 84, DateTimeKind.Unspecified).AddTicks(6036), 4L, "Jaiden27@gmail.com", "9d46b827-7a4a-80d7-dfb3-bf40e8fabd0e", "Ressie", "Bernhard", "Elvie.Grady94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 73L, "Magnam animi facere non aliquid magnam sint qui in vero.\nRerum est iusto qui doloremque molestiae rerum magnam illum.", new DateTime(2021, 8, 12, 11, 6, 39, 852, DateTimeKind.Unspecified).AddTicks(5806), 4L, "Richard.Gutmann@gmail.com", "1a9967f0-d0b6-8bab-a88b-f5fe50f86e73", "Nona", "Turner", "Kiana_Nitzsche67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 48L, "Ea officiis quam ullam eius mollitia quidem et.\nDolores excepturi corporis.\nBeatae doloribus quibusdam est est assumenda deleniti porro.\nAmet qui iure nihil et temporibus molestiae ullam ad.\nCum occaecati laudantium temporibus eius natus sed et.", new DateTime(2021, 2, 26, 18, 46, 3, 943, DateTimeKind.Unspecified).AddTicks(361), 1L, "Tessie.Witting61@hotmail.com", "bb5025b1-673c-1b89-904f-047542e33cf4", "Mose", "Franecki", "Bernadine.Borer17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 25L, "Cumque quo quibusdam fugiat velit ut omnis.", new DateTime(2021, 10, 23, 14, 58, 32, 767, DateTimeKind.Unspecified).AddTicks(1046), 1L, "Darrell84@hotmail.com", "c7b27e2f-a014-ae0c-52d4-e1f23d238c38", "Cole", "Mayer", "Savanna61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 57L, "Enim magni fugiat sed doloribus.\nEveniet fuga impedit ut.\nPossimus aspernatur quidem excepturi dolore maiores quibusdam.\nId et nam.", new DateTime(2021, 9, 14, 13, 59, 0, 189, DateTimeKind.Unspecified).AddTicks(1362), 4L, "Lincoln18@hotmail.com", "15fa9cae-59fc-01a4-ecdc-416b86de74bf", "Marques", "Conn", "Robb_Green" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 100L, "Facilis nisi non minima et maiores suscipit et voluptas.", new DateTime(2021, 9, 13, 2, 36, 51, 81, DateTimeKind.Unspecified).AddTicks(2857), "Ashlee0@hotmail.com", "e0aec8d3-5b43-34fa-12dc-1d87c9b07a41", "Sigurd", "Bernier", "Lorenza.Donnelly79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 82L, "Molestiae ut rerum porro aut consequatur consectetur temporibus totam ea.\nError eveniet error.\nAdipisci iure architecto quis alias iste voluptas.", new DateTime(2022, 1, 7, 21, 28, 37, 783, DateTimeKind.Unspecified).AddTicks(5169), 3L, "Ana.Quigley2@hotmail.com", "cc24f1ee-fc4b-cc29-4d21-8e7b47c4b000", "Emmet", "Berge", "Andre27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 58L, "Provident eum consequatur.\nNeque ipsum reiciendis doloribus.\nNumquam fuga fuga dolor omnis.", new DateTime(2021, 7, 19, 18, 9, 56, 962, DateTimeKind.Unspecified).AddTicks(3930), 2L, "Easton20@hotmail.com", "9f386a3b-4eea-0f4a-a906-75d73ba48978", "Mary", "Marquardt", "Jeremy_Johns24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 54L, "Quo expedita inventore est in odio.", new DateTime(2021, 7, 11, 12, 50, 7, 372, DateTimeKind.Unspecified).AddTicks(8866), 3L, "Shane.Skiles11@yahoo.com", "600b6099-0fe3-d54f-9b18-ee52acde55d5", "Ryan", "Koepp", "Vidal7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 53L, "Cum repellat hic pariatur veniam maiores.\nRem sint et vero cum ut ea non id et.\nSimilique nihil unde sequi.\nSit est enim provident esse non ducimus laborum reprehenderit.\nDicta nihil voluptatem nulla et sed.", new DateTime(2021, 7, 14, 2, 11, 6, 948, DateTimeKind.Unspecified).AddTicks(1195), 2L, "Colby_Hirthe69@yahoo.com", "4924558a-61a3-db07-cbf1-b0e24a50d6a5", "Valentine", "Runolfsdottir", "Terence0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 9L, "Delectus et modi quia vel.\nQuidem dolores reiciendis reiciendis rerum.\nVeritatis eum adipisci eos non et inventore.\nIpsa ut ab harum.", new DateTime(2021, 12, 24, 21, 22, 59, 332, DateTimeKind.Unspecified).AddTicks(8480), 4L, "Meggie25@gmail.com", "a7d81e67-6d51-0e1b-1805-9fa10abf5f9d", "Tre", "O'Reilly", "Izaiah26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 99L, "Sit deserunt inventore tempore modi voluptate debitis et.\nSed error ab perferendis veritatis.", new DateTime(2021, 7, 8, 7, 50, 5, 275, DateTimeKind.Unspecified).AddTicks(8333), 2L, "Johan23@yahoo.com", "1b7e11e8-1f25-e5d6-372a-786e25344d78", "Lelia", "Lind", "Domenick3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 90L, "Est quia et perspiciatis ut rem ullam ex corrupti dignissimos.", new DateTime(2022, 1, 20, 16, 50, 26, 485, DateTimeKind.Unspecified).AddTicks(9527), "Maxwell.Wiza1@hotmail.com", "7632744a-20c7-1441-0a3d-a33b9e4dcc1d", "Blanche", "Huel", "Maximus8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 65L, "Tempore at earum quos repudiandae magni quia.\nAliquid ea aperiam officia.", new DateTime(2021, 10, 4, 8, 56, 23, 467, DateTimeKind.Unspecified).AddTicks(6550), 3L, "Deshawn_Bode3@hotmail.com", "34869b04-fb8e-0fe3-fbee-aba8d18124bf", "Alexandrea", "Brekke", "Nicole.Zulauf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 47L, "Nesciunt voluptatem et sint.\nUt repellat voluptatum facere ut cum ad voluptate ut.\nOdio sequi omnis ut ex doloribus unde aliquid reiciendis voluptatem.\nIpsum excepturi aspernatur sapiente consequatur saepe fuga ea et.\nConsectetur aspernatur dolorum aut consequatur sunt veniam veritatis animi.", new DateTime(2021, 11, 22, 2, 55, 48, 531, DateTimeKind.Unspecified).AddTicks(7652), 1L, "Jordyn.Lesch@yahoo.com", "615dbb89-a20c-9d36-5dc8-203523c9cd0d", "Vidal", "Bradtke", "Priscilla_Ledner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 41L, "Nostrum vel dolores labore quidem.\nConsequatur quas amet optio accusantium quaerat praesentium aut tempore sit.\nMolestiae occaecati velit quos nesciunt vel alias.", new DateTime(2021, 5, 12, 17, 43, 58, 729, DateTimeKind.Unspecified).AddTicks(8866), 2L, "Estevan.Kassulke2@yahoo.com", "8374c3ea-5f07-f810-d1e7-3e6b1543c587", "Presley", "Heller", "Burley15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 61L, "Qui corporis occaecati sequi odit nesciunt.\nOmnis provident aut quas provident.\nDolor eum aut.", new DateTime(2021, 10, 24, 2, 22, 15, 695, DateTimeKind.Unspecified).AddTicks(6894), 2L, "Colleen.King76@hotmail.com", "f69c6354-822f-6c5a-9854-7b6cbc4c5311", "Omari", "Christiansen", "Mitchel_Marvin21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 87L, "Vero reprehenderit sunt nobis quo sed.\nImpedit incidunt debitis et nihil omnis commodi accusantium ut consequuntur.\nMinima nihil ratione hic laborum sit necessitatibus itaque cupiditate iste.\nExpedita ut aut distinctio doloremque iste fugit repellat eligendi id.", new DateTime(2021, 8, 8, 12, 39, 12, 747, DateTimeKind.Unspecified).AddTicks(3483), "Bethany.Lehner75@yahoo.com", "27add938-120a-02c3-1108-9b08c385745e", "Aliya", "O'Reilly", "Ross_Ebert" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "LastName", "UserName" },
                values: new object[] { 73L, "Modi dolorum deserunt et voluptatem minima.\nEaque non eaque quis officiis.\nSequi fuga sunt nobis.", new DateTime(2021, 11, 11, 13, 26, 9, 658, DateTimeKind.Unspecified).AddTicks(2423), 4L, "Eudora_Kilback6@yahoo.com", "cbeb93d2-86d0-04ad-ba3a-bd4a3372ca6d", "Rachelle", "Vandervort", "Ludie74" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 15L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 15L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 15L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 13L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 13L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 28L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 39L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 44L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 47L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 48L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 46L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 18L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 25L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 36L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 15L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 25L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 15L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 19L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 20L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 18L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 23L, 30L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 49L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 25L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 25L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 31L, 30L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 36L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 38L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 38L, 32L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 40L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 15L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 49L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 11L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 11L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 9L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 25L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 20L });

            migrationBuilder.DropColumn(
                name: "FirebaseId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, 14L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 10, 5, 6, 37, 43, 438, DateTimeKind.Unspecified).AddTicks(8707), 4L, 5L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, 23L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 10, 6, 20, 38, 10, 263, DateTimeKind.Unspecified).AddTicks(6665), 16L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, 35L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 7, 20, 4, 45, 21, 302, DateTimeKind.Unspecified).AddTicks(9971), 52L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, 49L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 2L, new DateTime(2022, 1, 22, 23, 47, 7, 731, DateTimeKind.Unspecified).AddTicks(6075), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 50L },
                columns: new[] { "CourseRoleId", "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { 1L, new DateTime(2021, 5, 22, 22, 4, 21, 314, DateTimeKind.Unspecified).AddTicks(6392), 5L, 24L });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "CourseId", "UserId", "CourseRoleId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 3L, 2L, 1L, new DateTime(2021, 10, 12, 19, 29, 30, 668, DateTimeKind.Unspecified).AddTicks(1459), 5L, 11L, false },
                    { 12L, 2L, 1L, new DateTime(2021, 10, 16, 3, 25, 0, 758, DateTimeKind.Unspecified).AddTicks(9949), 5L, 10L, false },
                    { 12L, 3L, 2L, new DateTime(2021, 7, 5, 5, 35, 35, 457, DateTimeKind.Unspecified).AddTicks(378), 5L, 38L, false },
                    { 15L, 3L, 2L, new DateTime(2021, 11, 15, 0, 39, 59, 668, DateTimeKind.Unspecified).AddTicks(4577), 1L, 71L, false },
                    { 4L, 4L, 1L, new DateTime(2021, 2, 28, 23, 32, 37, 711, DateTimeKind.Unspecified).AddTicks(4217), 3L, 51L, false },
                    { 6L, 4L, 2L, new DateTime(2021, 9, 27, 19, 8, 53, 2, DateTimeKind.Unspecified).AddTicks(7603), 3L, 45L, false },
                    { 16L, 4L, 2L, new DateTime(2021, 9, 22, 11, 52, 21, 464, DateTimeKind.Unspecified).AddTicks(4664), 4L, 49L, false },
                    { 5L, 5L, 1L, new DateTime(2021, 6, 13, 4, 6, 53, 556, DateTimeKind.Unspecified).AddTicks(8732), 2L, 61L, false },
                    { 14L, 5L, 2L, new DateTime(2021, 10, 2, 14, 58, 17, 504, DateTimeKind.Unspecified).AddTicks(3429), 5L, 12L, false },
                    { 16L, 5L, 1L, new DateTime(2021, 8, 30, 4, 24, 14, 662, DateTimeKind.Unspecified).AddTicks(4317), 5L, 27L, false },
                    { 2L, 7L, 1L, new DateTime(2021, 10, 11, 23, 43, 45, 71, DateTimeKind.Unspecified).AddTicks(9140), 1L, 3L, false },
                    { 13L, 8L, 2L, new DateTime(2021, 8, 3, 0, 55, 54, 632, DateTimeKind.Unspecified).AddTicks(4194), 3L, 70L, false },
                    { 19L, 8L, 1L, new DateTime(2021, 3, 18, 4, 17, 52, 846, DateTimeKind.Unspecified).AddTicks(7596), 5L, 18L, false },
                    { 19L, 9L, 2L, new DateTime(2021, 5, 27, 5, 9, 1, 915, DateTimeKind.Unspecified).AddTicks(8113), 5L, 64L, false },
                    { 8L, 12L, 2L, new DateTime(2021, 2, 19, 7, 33, 29, 713, DateTimeKind.Unspecified).AddTicks(2586), 2L, 7L, false },
                    { 6L, 14L, 1L, new DateTime(2021, 4, 17, 15, 1, 41, 58, DateTimeKind.Unspecified).AddTicks(9017), 5L, 44L, false },
                    { 10L, 14L, 1L, new DateTime(2021, 2, 10, 15, 49, 40, 857, DateTimeKind.Unspecified).AddTicks(4852), 2L, 40L, false },
                    { 12L, 14L, 2L, new DateTime(2021, 8, 4, 10, 16, 3, 382, DateTimeKind.Unspecified).AddTicks(2658), 3L, 37L, false },
                    { 13L, 16L, 1L, new DateTime(2021, 4, 15, 8, 17, 47, 623, DateTimeKind.Unspecified).AddTicks(4057), 3L, 63L, false },
                    { 18L, 16L, 1L, new DateTime(2021, 8, 10, 18, 38, 50, 251, DateTimeKind.Unspecified).AddTicks(3629), 2L, 28L, false },
                    { 4L, 17L, 2L, new DateTime(2021, 7, 20, 4, 47, 34, 790, DateTimeKind.Unspecified).AddTicks(5049), 3L, 23L, false },
                    { 4L, 18L, 1L, new DateTime(2022, 1, 24, 19, 46, 48, 339, DateTimeKind.Unspecified).AddTicks(3235), 3L, 6L, false },
                    { 9L, 18L, 1L, new DateTime(2021, 4, 21, 4, 0, 25, 555, DateTimeKind.Unspecified).AddTicks(7992), 1L, 56L, false },
                    { 12L, 19L, 2L, new DateTime(2021, 12, 23, 11, 37, 43, 862, DateTimeKind.Unspecified).AddTicks(9497), 5L, 47L, false },
                    { 11L, 22L, 2L, new DateTime(2021, 11, 16, 10, 27, 40, 65, DateTimeKind.Unspecified).AddTicks(5522), 4L, 15L, false },
                    { 18L, 22L, 2L, new DateTime(2021, 5, 21, 14, 57, 58, 56, DateTimeKind.Unspecified).AddTicks(9730), 1L, 9L, false },
                    { 3L, 24L, 1L, new DateTime(2021, 7, 5, 22, 20, 13, 980, DateTimeKind.Unspecified).AddTicks(6451), 5L, 65L, false },
                    { 11L, 26L, 2L, new DateTime(2021, 7, 23, 8, 21, 33, 182, DateTimeKind.Unspecified).AddTicks(5122), 5L, 48L, false },
                    { 5L, 28L, 2L, new DateTime(2021, 3, 15, 9, 44, 53, 476, DateTimeKind.Unspecified).AddTicks(8572), 4L, 22L, false },
                    { 8L, 29L, 2L, new DateTime(2021, 8, 21, 8, 49, 40, 229, DateTimeKind.Unspecified).AddTicks(7695), 5L, 8L, false },
                    { 6L, 30L, 1L, new DateTime(2021, 8, 26, 17, 35, 57, 100, DateTimeKind.Unspecified).AddTicks(5535), 3L, 50L, false },
                    { 16L, 31L, 1L, new DateTime(2021, 4, 27, 6, 41, 20, 182, DateTimeKind.Unspecified).AddTicks(2938), 3L, 68L, false },
                    { 20L, 31L, 2L, new DateTime(2021, 11, 4, 12, 39, 38, 211, DateTimeKind.Unspecified).AddTicks(605), 1L, 34L, false },
                    { 15L, 35L, 2L, new DateTime(2021, 7, 1, 3, 38, 49, 336, DateTimeKind.Unspecified).AddTicks(339), 4L, 62L, false },
                    { 20L, 35L, 1L, new DateTime(2021, 6, 10, 22, 44, 31, 652, DateTimeKind.Unspecified).AddTicks(8842), 2L, 59L, false },
                    { 11L, 36L, 1L, new DateTime(2021, 10, 31, 2, 12, 31, 597, DateTimeKind.Unspecified).AddTicks(7107), 2L, 54L, false },
                    { 4L, 38L, 2L, new DateTime(2021, 6, 17, 9, 25, 1, 251, DateTimeKind.Unspecified).AddTicks(8608), 1L, 4L, false }
                });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "CourseId", "UserId", "CourseRoleId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 16L, 38L, 1L, new DateTime(2021, 8, 28, 7, 0, 26, 993, DateTimeKind.Unspecified).AddTicks(3744), 2L, 57L, false },
                    { 4L, 40L, 1L, new DateTime(2021, 5, 3, 21, 31, 43, 585, DateTimeKind.Unspecified).AddTicks(6876), 2L, 14L, false },
                    { 14L, 40L, 1L, new DateTime(2022, 1, 30, 6, 50, 14, 384, DateTimeKind.Unspecified).AddTicks(5464), 4L, 36L, false },
                    { 19L, 40L, 2L, new DateTime(2021, 5, 18, 4, 8, 58, 143, DateTimeKind.Unspecified).AddTicks(2826), 3L, 67L, false },
                    { 9L, 41L, 1L, new DateTime(2021, 5, 6, 19, 15, 28, 224, DateTimeKind.Unspecified).AddTicks(4349), 2L, 55L, false },
                    { 16L, 41L, 2L, new DateTime(2021, 4, 7, 14, 1, 5, 270, DateTimeKind.Unspecified).AddTicks(5338), 2L, 33L, false },
                    { 19L, 41L, 1L, new DateTime(2022, 1, 30, 19, 25, 37, 108, DateTimeKind.Unspecified).AddTicks(7609), 1L, 17L, false },
                    { 14L, 42L, 1L, new DateTime(2021, 6, 6, 23, 19, 48, 764, DateTimeKind.Unspecified).AddTicks(2343), 5L, 30L, false },
                    { 2L, 43L, 1L, new DateTime(2022, 1, 16, 0, 41, 45, 325, DateTimeKind.Unspecified).AddTicks(5391), 3L, 31L, false },
                    { 12L, 43L, 1L, new DateTime(2021, 4, 7, 8, 3, 25, 560, DateTimeKind.Unspecified).AddTicks(3282), 5L, 13L, false },
                    { 9L, 44L, 2L, new DateTime(2022, 1, 29, 20, 8, 46, 749, DateTimeKind.Unspecified).AddTicks(3928), 3L, 32L, false },
                    { 20L, 45L, 1L, new DateTime(2021, 3, 26, 12, 47, 39, 772, DateTimeKind.Unspecified).AddTicks(9629), 4L, 66L, false },
                    { 3L, 46L, 1L, new DateTime(2021, 4, 12, 0, 27, 43, 982, DateTimeKind.Unspecified).AddTicks(2044), 2L, 25L, false },
                    { 4L, 46L, 2L, new DateTime(2021, 5, 25, 21, 15, 34, 259, DateTimeKind.Unspecified).AddTicks(2611), 2L, 39L, false },
                    { 5L, 46L, 1L, new DateTime(2021, 2, 27, 15, 48, 23, 301, DateTimeKind.Unspecified).AddTicks(1165), 2L, 53L, false },
                    { 9L, 46L, 1L, new DateTime(2021, 2, 26, 23, 54, 4, 253, DateTimeKind.Unspecified).AddTicks(1867), 2L, 20L, false },
                    { 12L, 46L, 1L, new DateTime(2021, 3, 11, 21, 10, 42, 717, DateTimeKind.Unspecified).AddTicks(2897), 2L, 21L, false },
                    { 13L, 46L, 2L, new DateTime(2021, 6, 2, 5, 25, 21, 234, DateTimeKind.Unspecified).AddTicks(7002), 4L, 60L, false },
                    { 16L, 46L, 1L, new DateTime(2021, 10, 7, 17, 29, 50, 262, DateTimeKind.Unspecified).AddTicks(1086), 1L, 26L, false },
                    { 17L, 46L, 1L, new DateTime(2021, 7, 25, 12, 32, 52, 532, DateTimeKind.Unspecified).AddTicks(2710), 4L, 41L, false },
                    { 12L, 49L, 2L, new DateTime(2021, 6, 19, 22, 0, 39, 605, DateTimeKind.Unspecified).AddTicks(6827), 3L, 19L, false },
                    { 4L, 50L, 1L, new DateTime(2021, 7, 10, 22, 4, 43, 412, DateTimeKind.Unspecified).AddTicks(5680), 1L, 29L, false },
                    { 21L, 50L, 2L, new DateTime(2021, 10, 22, 7, 17, 49, 587, DateTimeKind.Unspecified).AddTicks(1967), 5L, 42L, false },
                    { 3L, 51L, 2L, new DateTime(2021, 8, 10, 16, 21, 41, 370, DateTimeKind.Unspecified).AddTicks(6258), 4L, 46L, false }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 58L, new DateTime(2021, 9, 17, 0, 4, 59, 621, DateTimeKind.Unspecified).AddTicks(264), 3L, "Consectetur cum illum.\nDolores esse maiores.\nEt est sunt dignissimos aspernatur provident eum consequatur ut neque.\nReiciendis doloribus suscipit numquam.\nFuga dolor omnis non veniam nulla magnam sed.", "Incidunt quia quibusdam.", "Avonsolid stateregionalopen-source", 15L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 70L, new DateTime(2021, 10, 11, 16, 11, 5, 577, DateTimeKind.Unspecified).AddTicks(2928), 4L, "Consectetur in quo expedita inventore est.\nOdio consequatur debitis fugiat asperiores qui.\nOccaecati ducimus error.\nIn molestias aut voluptatem.\nExplicabo atque quos sit pariatur quis in unde amet.", "Nobis ad iusto aspernatur asperiores sapiente et perferendis architecto.", "Swedish KronaStreamStreamCotton", 47L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 56L, new DateTime(2021, 10, 4, 13, 22, 38, 500, DateTimeKind.Unspecified).AddTicks(7072), 4L, "Cum ut ea non id et ipsum similique nihil.", "Repellat hic pariatur veniam maiores voluptatibus rem sint.", "AccountsAdministrator", 9L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 54L, new DateTime(2021, 11, 19, 16, 38, 36, 889, DateTimeKind.Unspecified).AddTicks(6805), 4L, "Velit autem est excepturi eligendi excepturi suscipit.\nEst nihil eum dolor adipisci iste officiis.", "Quam dicta nihil voluptatem nulla et.", "internet solutioneyeballsPlain", 12L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvatarId", "CreatedAt", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 24L, new DateTime(2022, 1, 15, 5, 18, 51, 713, DateTimeKind.Unspecified).AddTicks(6183), "Reiciendis rerum molestias veritatis eum adipisci eos non et inventore.", "Nam omnis quis delectus et modi quia vel veniam quidem.", "ParkwayactuatingLodgedemand-driven", 4L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 54L, new DateTime(2021, 12, 14, 10, 38, 57, 25, DateTimeKind.Unspecified).AddTicks(6304), 4L, "Possimus consequatur dolorum ut reprehenderit illo doloremque id sed sit.\nSit deserunt inventore tempore modi voluptate debitis et.\nSed error ab perferendis veritatis.", "Perferendis illum magni suscipit cumque qui et maiores et asperiores.", "MetalIntelligent Concrete CarChecking Account", 27L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 31L, new DateTime(2021, 8, 23, 17, 38, 32, 138, DateTimeKind.Unspecified).AddTicks(7792), 3L, "Voluptate nobis dicta fugit quod facilis totam.\nIn consectetur dicta sed reprehenderit consectetur tenetur est.\nEt perspiciatis ut rem.", "Cumque iusto sapiente et sit.", "EngineerRiver", 19L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvatarId", "CreatedAt", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 3L, new DateTime(2022, 2, 1, 4, 6, 17, 35, DateTimeKind.Unspecified).AddTicks(4057), "Possimus repellat rem voluptatem doloremque aut voluptas animi tempore.\nEarum quos repudiandae magni quia adipisci aliquid ea aperiam.\nSoluta aliquam vitae cum aut aperiam harum.\nSit asperiores in provident tempora a eligendi.", "Repellendus et exercitationem iusto nam repellendus nesciunt qui enim dolorem.", "RandonlineShoes, Books & Gamescultivate", 22L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 28L, new DateTime(2021, 9, 6, 2, 42, 47, 251, DateTimeKind.Unspecified).AddTicks(9148), 2L, "Sint autem ut repellat voluptatum facere.", "Provident laborum sapiente aspernatur tenetur magni nesciunt.", "Incredible Plastic SausagesForward", 35L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 80L, new DateTime(2021, 11, 20, 22, 23, 19, 540, DateTimeKind.Unspecified).AddTicks(4514), 1L, "Ea et consequatur consectetur aspernatur dolorum aut.\nSunt veniam veritatis.\nExpedita sint sed similique explicabo blanditiis sit.\nMollitia qui est quibusdam.\nAssumenda eaque quia corrupti autem autem ut.", "Unde aliquid reiciendis voluptatem facere ipsum excepturi aspernatur sapiente consequatur.", "DivisionLicensed Fresh Pants", 34L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name" },
                values: new object[] { 82L, new DateTime(2021, 9, 19, 23, 44, 59, 297, DateTimeKind.Unspecified).AddTicks(7838), 3L, "Quas amet optio.\nQuaerat praesentium aut.\nSit qui molestiae occaecati velit quos nesciunt vel.\nExcepturi suscipit nihil.\nIn accusantium qui dolore est ut molestias eos ad.", "Nostrum vel dolores labore quidem.", "BalancedLicensed Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { new DateTime(2021, 12, 23, 0, 13, 32, 386, DateTimeKind.Unspecified).AddTicks(5414), 3L, "Quos qui corporis occaecati sequi odit nesciunt.", "Dolores sunt est sunt officiis fugiat eius est.", "Burundi FrancCredit Card Account", 40L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 23L, new DateTime(2022, 1, 18, 10, 30, 11, 469, DateTimeKind.Unspecified).AddTicks(361), 4L, "Ad cum qui occaecati esse.\nSunt vel in dolor architecto labore accusantium.\nSit iste temporibus pariatur.", "Ducimus est quis assumenda.", "AzerbaijannavigateAssistant", 33L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 3L, new DateTime(2021, 7, 26, 2, 11, 36, 772, DateTimeKind.Unspecified).AddTicks(1782), 5L, "Consequuntur a minima nihil ratione hic laborum.", "Sed sapiente impedit incidunt debitis et nihil omnis commodi.", "onlineAIRapid", 46L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 44L, new DateTime(2021, 4, 13, 14, 56, 19, 387, DateTimeKind.Unspecified).AddTicks(2607), 4L, "Placeat pariatur aut corrupti sit.\nMolestias vitae eum.\nNisi voluptates omnis.\nAutem ut mollitia ea maxime sunt facilis.", "Fugit repellat eligendi id distinctio fugit provident.", "BrandingAdvanceddeposit", 4L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 43L, new DateTime(2021, 8, 14, 4, 41, 54, 110, DateTimeKind.Unspecified).AddTicks(5984), 4L, "Fugiat veritatis quo repellendus tempora eligendi sit aut voluptatem soluta.\nUnde architecto vero voluptas quos.\nPossimus et veniam facere aut natus doloremque officiis.", "Eaque quis officiis voluptatem sequi fuga sunt nobis est laboriosam.", "MichiganPolarisedPlainsGorgeous Concrete Chair", 26L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 23L, new DateTime(2021, 4, 5, 5, 3, 27, 840, DateTimeKind.Unspecified).AddTicks(7372), 5L, "Beatae a saepe quo neque ratione vero quas soluta.\nAut quia sed suscipit velit occaecati cumque blanditiis unde totam.", "Eum molestiae qui itaque ut nam ex aspernatur quia architecto.", "Awesome Wooden Hatmesh", 32L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 54L, new DateTime(2021, 8, 15, 8, 43, 44, 14, DateTimeKind.Unspecified).AddTicks(1195), 4L, "Ea eveniet totam fugiat qui accusamus.", "Reprehenderit aut voluptatem id recusandae vel provident illo sed et.", "sexyconceptInfrastructuremission-critical", 43L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 13L, new DateTime(2021, 5, 3, 10, 28, 4, 12, DateTimeKind.Unspecified).AddTicks(4753), 5L, "Itaque nesciunt velit reiciendis.\nSed earum dolorum voluptas consequatur ut soluta illum.\nNostrum et quae sed vel.", "Ea laudantium perferendis mollitia rerum explicabo aliquam delectus.", "Unbranded Soft TunaIowa", 39L });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "Name", "OwnerId" },
                values: new object[] { 97L, new DateTime(2021, 9, 2, 8, 24, 55, 991, DateTimeKind.Unspecified).AddTicks(2292), 5L, "Officiis aut impedit recusandae quia soluta.\nExpedita nemo voluptatem ab illo voluptatem ea esse.", "Molestiae aliquid ea saepe corrupti illo vitae.", "North CarolinaengineerIdentity", 22L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 24L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 5, 25, 3, 45, 16, 466, DateTimeKind.Unspecified).AddTicks(2618), 5L, 48L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 13L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 10, 25, 15, 40, 30, 663, DateTimeKind.Unspecified).AddTicks(3661), 5L, 67L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 34L, 45L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 4, 17, 7, 39, 16, 282, DateTimeKind.Unspecified).AddTicks(3305), 2L, 44L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 31L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 10, 3, 797, DateTimeKind.Unspecified).AddTicks(5500), 3L, 40L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 50L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 10, 31, 17, 33, 36, 835, DateTimeKind.Unspecified).AddTicks(6936), 1L, 64L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 50L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 3, 7, 6, 46, 46, 659, DateTimeKind.Unspecified).AddTicks(7829), 52L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 45L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 9, 8, 9, 20, 27, 744, DateTimeKind.Unspecified).AddTicks(7544), 84L });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 24L, new DateTime(2021, 12, 19, 14, 38, 25, 212, DateTimeKind.Unspecified).AddTicks(6400), 3L, 88L, false },
                    { 3L, 6L, new DateTime(2021, 12, 11, 11, 42, 43, 866, DateTimeKind.Unspecified).AddTicks(1104), 5L, 11L, false },
                    { 3L, 29L, new DateTime(2021, 8, 24, 5, 12, 12, 368, DateTimeKind.Unspecified).AddTicks(8922), 1L, 39L, false },
                    { 4L, 11L, new DateTime(2022, 1, 31, 18, 11, 13, 723, DateTimeKind.Unspecified).AddTicks(5136), 4L, 60L, false },
                    { 4L, 12L, new DateTime(2021, 4, 13, 1, 45, 22, 625, DateTimeKind.Unspecified).AddTicks(1334), 5L, 13L, false },
                    { 4L, 17L, new DateTime(2021, 9, 9, 7, 33, 18, 818, DateTimeKind.Unspecified).AddTicks(3670), 2L, 19L, false },
                    { 4L, 48L, new DateTime(2021, 3, 18, 7, 15, 34, 974, DateTimeKind.Unspecified).AddTicks(2072), 1L, 80L, false },
                    { 5L, 13L, new DateTime(2021, 2, 6, 15, 35, 13, 575, DateTimeKind.Unspecified).AddTicks(8482), 2L, 30L, false },
                    { 5L, 21L, new DateTime(2022, 1, 22, 10, 29, 34, 618, DateTimeKind.Unspecified).AddTicks(7833), 4L, 92L, false },
                    { 5L, 30L, new DateTime(2021, 9, 3, 10, 25, 39, 93, DateTimeKind.Unspecified).AddTicks(2854), 5L, 3L, false },
                    { 5L, 33L, new DateTime(2021, 10, 6, 7, 38, 8, 383, DateTimeKind.Unspecified).AddTicks(3223), 2L, 43L, false },
                    { 7L, 8L, new DateTime(2021, 3, 29, 23, 36, 59, 702, DateTimeKind.Unspecified).AddTicks(4369), 3L, 17L, false },
                    { 7L, 13L, new DateTime(2021, 10, 20, 11, 29, 29, 31, DateTimeKind.Unspecified).AddTicks(5156), 4L, 42L, false },
                    { 7L, 45L, new DateTime(2021, 5, 15, 9, 37, 8, 953, DateTimeKind.Unspecified).AddTicks(4462), 4L, 29L, false },
                    { 8L, 19L, new DateTime(2021, 6, 14, 18, 1, 22, 124, DateTimeKind.Unspecified).AddTicks(1070), 3L, 78L, false },
                    { 8L, 37L, new DateTime(2021, 11, 2, 19, 55, 38, 732, DateTimeKind.Unspecified).AddTicks(7856), 5L, 22L, false },
                    { 9L, 10L, new DateTime(2021, 12, 27, 17, 22, 8, 61, DateTimeKind.Unspecified).AddTicks(5576), 4L, 61L, false },
                    { 9L, 18L, new DateTime(2021, 2, 20, 5, 39, 9, 896, DateTimeKind.Unspecified).AddTicks(8323), 4L, 49L, false },
                    { 9L, 24L, new DateTime(2021, 3, 25, 23, 49, 18, 970, DateTimeKind.Unspecified).AddTicks(1232), 1L, 95L, false },
                    { 9L, 30L, new DateTime(2021, 3, 22, 14, 5, 25, 599, DateTimeKind.Unspecified).AddTicks(9205), 1L, 94L, false },
                    { 10L, 10L, new DateTime(2021, 7, 2, 7, 45, 20, 253, DateTimeKind.Unspecified).AddTicks(5208), 5L, 59L, false },
                    { 12L, 6L, new DateTime(2021, 10, 16, 23, 5, 22, 666, DateTimeKind.Unspecified).AddTicks(3768), 2L, 10L, false },
                    { 12L, 17L, new DateTime(2021, 12, 15, 23, 6, 2, 705, DateTimeKind.Unspecified).AddTicks(7895), 4L, 28L, false },
                    { 13L, 35L, new DateTime(2021, 4, 2, 17, 24, 51, 804, DateTimeKind.Unspecified).AddTicks(1015), 1L, 51L, false },
                    { 15L, 42L, new DateTime(2021, 5, 7, 22, 48, 18, 693, DateTimeKind.Unspecified).AddTicks(2138), 5L, 46L, false },
                    { 16L, 47L, new DateTime(2021, 9, 29, 8, 52, 58, 892, DateTimeKind.Unspecified).AddTicks(6229), 1L, 38L, false },
                    { 17L, 3L, new DateTime(2021, 4, 18, 2, 5, 10, 323, DateTimeKind.Unspecified).AddTicks(1778), 5L, 32L, false },
                    { 17L, 34L, new DateTime(2021, 7, 11, 15, 42, 37, 618, DateTimeKind.Unspecified).AddTicks(3001), 5L, 36L, false },
                    { 18L, 7L, new DateTime(2021, 8, 19, 4, 42, 23, 477, DateTimeKind.Unspecified).AddTicks(7696), 1L, 31L, false },
                    { 19L, 10L, new DateTime(2021, 4, 25, 15, 41, 8, 6, DateTimeKind.Unspecified).AddTicks(3943), 5L, 75L, false },
                    { 19L, 14L, new DateTime(2021, 9, 4, 5, 19, 33, 270, DateTimeKind.Unspecified).AddTicks(4639), 5L, 72L, false },
                    { 19L, 20L, new DateTime(2021, 7, 25, 21, 24, 0, 82, DateTimeKind.Unspecified).AddTicks(8303), 3L, 12L, false },
                    { 19L, 24L, new DateTime(2021, 9, 13, 0, 31, 39, 244, DateTimeKind.Unspecified).AddTicks(3362), 4L, 77L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 19L, 36L, new DateTime(2022, 1, 2, 14, 52, 26, 466, DateTimeKind.Unspecified).AddTicks(2548), 1L, 53L, false },
                    { 20L, 28L, new DateTime(2021, 11, 18, 7, 57, 38, 254, DateTimeKind.Unspecified).AddTicks(2255), 3L, 2L, false },
                    { 21L, 27L, new DateTime(2021, 10, 31, 7, 32, 36, 352, DateTimeKind.Unspecified).AddTicks(9365), 5L, 20L, false },
                    { 21L, 43L, new DateTime(2021, 12, 31, 17, 15, 58, 696, DateTimeKind.Unspecified).AddTicks(7132), 1L, 9L, false },
                    { 21L, 48L, new DateTime(2021, 4, 2, 5, 29, 42, 883, DateTimeKind.Unspecified).AddTicks(5326), 1L, 58L, false },
                    { 22L, 19L, new DateTime(2021, 8, 25, 11, 28, 21, 936, DateTimeKind.Unspecified).AddTicks(8081), 1L, 74L, false },
                    { 22L, 45L, new DateTime(2021, 11, 28, 1, 12, 36, 869, DateTimeKind.Unspecified).AddTicks(4299), 5L, 79L, false },
                    { 23L, 4L, new DateTime(2021, 6, 28, 7, 41, 33, 491, DateTimeKind.Unspecified).AddTicks(6446), 5L, 56L, false },
                    { 23L, 11L, new DateTime(2021, 5, 16, 15, 23, 15, 456, DateTimeKind.Unspecified).AddTicks(1059), 3L, 37L, false },
                    { 25L, 37L, new DateTime(2021, 2, 3, 13, 34, 8, 147, DateTimeKind.Unspecified).AddTicks(7816), 1L, 86L, false },
                    { 25L, 50L, new DateTime(2021, 9, 20, 13, 18, 40, 422, DateTimeKind.Unspecified).AddTicks(6583), 2L, 96L, false },
                    { 26L, 13L, new DateTime(2021, 4, 20, 9, 58, 54, 76, DateTimeKind.Unspecified).AddTicks(9250), 4L, 4L, false },
                    { 26L, 19L, new DateTime(2021, 9, 15, 22, 20, 7, 657, DateTimeKind.Unspecified).AddTicks(8470), 1L, 81L, false },
                    { 26L, 20L, new DateTime(2021, 9, 28, 11, 24, 56, 307, DateTimeKind.Unspecified).AddTicks(3460), 4L, 65L, false },
                    { 26L, 23L, new DateTime(2021, 11, 19, 9, 8, 15, 317, DateTimeKind.Unspecified).AddTicks(4655), 3L, 6L, false },
                    { 27L, 17L, new DateTime(2021, 3, 11, 13, 51, 47, 908, DateTimeKind.Unspecified).AddTicks(1976), 3L, 85L, false },
                    { 27L, 21L, new DateTime(2021, 6, 28, 14, 19, 46, 272, DateTimeKind.Unspecified).AddTicks(3397), 2L, 45L, false },
                    { 27L, 31L, new DateTime(2021, 5, 13, 14, 27, 9, 140, DateTimeKind.Unspecified).AddTicks(8692), 5L, 8L, false },
                    { 28L, 43L, new DateTime(2021, 9, 27, 9, 17, 30, 554, DateTimeKind.Unspecified).AddTicks(6875), 1L, 24L, false },
                    { 29L, 35L, new DateTime(2021, 12, 30, 16, 36, 36, 670, DateTimeKind.Unspecified).AddTicks(3768), 2L, 50L, false },
                    { 30L, 4L, new DateTime(2021, 9, 2, 3, 22, 54, 335, DateTimeKind.Unspecified).AddTicks(1382), 5L, 93L, false },
                    { 30L, 11L, new DateTime(2021, 2, 21, 12, 59, 30, 689, DateTimeKind.Unspecified).AddTicks(4854), 5L, 87L, false },
                    { 30L, 12L, new DateTime(2021, 7, 18, 13, 23, 44, 49, DateTimeKind.Unspecified).AddTicks(1749), 3L, 21L, false },
                    { 31L, 8L, new DateTime(2021, 3, 8, 5, 2, 29, 5, DateTimeKind.Unspecified).AddTicks(6510), 3L, 69L, false },
                    { 31L, 20L, new DateTime(2021, 7, 23, 9, 5, 22, 78, DateTimeKind.Unspecified).AddTicks(7350), 3L, 34L, false },
                    { 31L, 38L, new DateTime(2021, 11, 11, 11, 58, 57, 329, DateTimeKind.Unspecified).AddTicks(7505), 4L, 14L, false },
                    { 32L, 20L, new DateTime(2021, 4, 7, 14, 52, 44, 779, DateTimeKind.Unspecified).AddTicks(9756), 4L, 18L, false },
                    { 33L, 4L, new DateTime(2021, 4, 25, 19, 9, 2, 861, DateTimeKind.Unspecified).AddTicks(8901), 3L, 68L, false },
                    { 33L, 9L, new DateTime(2021, 5, 12, 13, 48, 31, 243, DateTimeKind.Unspecified).AddTicks(2413), 5L, 57L, false },
                    { 33L, 20L, new DateTime(2021, 2, 24, 16, 3, 53, 110, DateTimeKind.Unspecified).AddTicks(2357), 5L, 71L, false },
                    { 33L, 24L, new DateTime(2021, 3, 20, 20, 59, 16, 459, DateTimeKind.Unspecified).AddTicks(7765), 1L, 97L, false },
                    { 34L, 3L, new DateTime(2021, 9, 25, 6, 45, 29, 520, DateTimeKind.Unspecified).AddTicks(4306), 2L, 5L, false },
                    { 34L, 42L, new DateTime(2021, 9, 30, 18, 8, 31, 268, DateTimeKind.Unspecified).AddTicks(9933), 1L, 47L, false },
                    { 35L, 8L, new DateTime(2021, 5, 17, 11, 30, 37, 569, DateTimeKind.Unspecified).AddTicks(9490), 2L, 73L, false },
                    { 35L, 25L, new DateTime(2021, 12, 20, 21, 35, 51, 495, DateTimeKind.Unspecified).AddTicks(1457), 4L, 100L, false },
                    { 35L, 40L, new DateTime(2021, 6, 26, 14, 40, 30, 344, DateTimeKind.Unspecified).AddTicks(8118), 1L, 26L, false },
                    { 36L, 51L, new DateTime(2021, 9, 14, 6, 2, 4, 638, DateTimeKind.Unspecified).AddTicks(386), 4L, 41L, false },
                    { 37L, 27L, new DateTime(2021, 4, 12, 22, 2, 20, 25, DateTimeKind.Unspecified).AddTicks(2145), 2L, 15L, false },
                    { 37L, 32L, new DateTime(2021, 5, 16, 23, 32, 14, 600, DateTimeKind.Unspecified).AddTicks(5432), 1L, 7L, false },
                    { 38L, 16L, new DateTime(2022, 1, 11, 10, 34, 7, 119, DateTimeKind.Unspecified).AddTicks(958), 4L, 16L, false },
                    { 38L, 42L, new DateTime(2021, 10, 15, 6, 34, 59, 33, DateTimeKind.Unspecified).AddTicks(2043), 5L, 66L, false },
                    { 39L, 40L, new DateTime(2021, 10, 18, 23, 43, 7, 24, DateTimeKind.Unspecified).AddTicks(4841), 4L, 70L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 42L, 23L, new DateTime(2021, 5, 15, 16, 34, 48, 200, DateTimeKind.Unspecified).AddTicks(5567), 3L, 82L, false },
                    { 42L, 42L, new DateTime(2021, 3, 16, 4, 8, 58, 289, DateTimeKind.Unspecified).AddTicks(9726), 5L, 101L, false },
                    { 43L, 35L, new DateTime(2021, 4, 19, 23, 12, 35, 280, DateTimeKind.Unspecified).AddTicks(4054), 5L, 99L, false },
                    { 44L, 51L, new DateTime(2021, 9, 21, 18, 23, 43, 60, DateTimeKind.Unspecified).AddTicks(1858), 2L, 62L, false },
                    { 47L, 21L, new DateTime(2021, 5, 17, 12, 1, 26, 247, DateTimeKind.Unspecified).AddTicks(1082), 1L, 35L, false },
                    { 47L, 22L, new DateTime(2021, 10, 31, 21, 35, 18, 248, DateTimeKind.Unspecified).AddTicks(8967), 1L, 25L, false },
                    { 47L, 40L, new DateTime(2021, 9, 16, 12, 54, 18, 409, DateTimeKind.Unspecified).AddTicks(3847), 3L, 23L, false },
                    { 47L, 42L, new DateTime(2021, 7, 5, 2, 43, 1, 466, DateTimeKind.Unspecified).AddTicks(9252), 3L, 55L, false },
                    { 47L, 48L, new DateTime(2021, 9, 11, 13, 58, 44, 380, DateTimeKind.Unspecified).AddTicks(9741), 1L, 91L, false },
                    { 48L, 3L, new DateTime(2021, 6, 25, 20, 7, 8, 849, DateTimeKind.Unspecified).AddTicks(1393), 5L, 33L, false },
                    { 48L, 43L, new DateTime(2021, 6, 12, 9, 23, 35, 24, DateTimeKind.Unspecified).AddTicks(42), 5L, 90L, false },
                    { 50L, 21L, new DateTime(2021, 9, 1, 6, 2, 45, 799, DateTimeKind.Unspecified).AddTicks(3925), 4L, 83L, false },
                    { 50L, 24L, new DateTime(2021, 5, 13, 10, 29, 23, 217, DateTimeKind.Unspecified).AddTicks(8393), 2L, 54L, false },
                    { 50L, 49L, new DateTime(2021, 10, 20, 16, 44, 40, 334, DateTimeKind.Unspecified).AddTicks(5007), 2L, 76L, false },
                    { 51L, 17L, new DateTime(2021, 8, 24, 5, 31, 41, 287, DateTimeKind.Unspecified).AddTicks(7184), 3L, 89L, false },
                    { 51L, 19L, new DateTime(2021, 5, 30, 16, 43, 26, 824, DateTimeKind.Unspecified).AddTicks(9819), 3L, 27L, false },
                    { 51L, 48L, new DateTime(2021, 4, 25, 7, 32, 50, 273, DateTimeKind.Unspecified).AddTicks(9231), 1L, 63L, false }
                });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 5, 4, 21, 1, 16, 850, DateTimeKind.Unspecified).AddTicks(3929), 5L, "Explicabo qui vel laudantium eum itaque sint.\nNumquam debitis veritatis sed dolor voluptatum est cupiditate ea.\nAut ut optio culpa nobis dolore dolore sit dolorum fugit.", new DateTime(2022, 12, 17, 12, 30, 48, 32, DateTimeKind.Unspecified).AddTicks(6445), "Aperiam fugit in rem repellendus deleniti eveniet officia sed esse.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 10, 12, 18, 16, 19, 957, DateTimeKind.Unspecified).AddTicks(971), 2L, "Officia quis nobis nesciunt ab autem exercitationem.", new DateTime(2022, 9, 15, 17, 35, 2, 636, DateTimeKind.Unspecified).AddTicks(1537), "Tempore quasi consequuntur.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 2, 18, 15, 24, 17, 238, DateTimeKind.Unspecified).AddTicks(8728), 4L, "Maiores iure odit qui rerum ea.\nQui ut nulla.\nVel voluptas eveniet non adipisci accusamus rerum.\nEa veritatis repellat sit et.\nConsequatur iste est recusandae.", new DateTime(2023, 11, 26, 2, 5, 15, 878, DateTimeKind.Unspecified).AddTicks(2070), true, "Molestiae excepturi ut dolores eius est voluptatem.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 8, 22, 19, 19, 31, 764, DateTimeKind.Unspecified).AddTicks(4136), "Et quis earum ut omnis aut in.\nDoloribus quia blanditiis nostrum sint.", new DateTime(2023, 10, 13, 3, 53, 21, 594, DateTimeKind.Unspecified).AddTicks(3086), "Rerum et velit et id et asperiores praesentium id.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 10, 20, 14, 55, 43, 543, DateTimeKind.Unspecified).AddTicks(7617), "Alias quisquam repudiandae a.\nEarum in asperiores natus quidem eius eum animi impedit.\nCorrupti harum saepe inventore ad ea libero.\nQui laborum modi.", new DateTime(2022, 12, 3, 16, 53, 48, 103, DateTimeKind.Unspecified).AddTicks(849), false, "Quis velit omnis magnam rerum voluptatum ea.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2022, 1, 2, 1, 24, 18, 355, DateTimeKind.Unspecified).AddTicks(2652), "Assumenda consequatur quia non est quos adipisci.\nIpsam qui ut occaecati quod suscipit nihil occaecati ut.\nCupiditate temporibus corporis nesciunt aliquid et repellendus.\nEst beatae hic ullam ratione voluptatem.\nDebitis ut sed ad in.", new DateTime(2022, 12, 28, 20, 52, 58, 832, DateTimeKind.Unspecified).AddTicks(1324), "Non maiores atque ut sit placeat et.", 30L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 5, 6, 21, 4, 26, 13, DateTimeKind.Unspecified).AddTicks(7604), 2L, "Eum qui modi est.\nMolestias nihil eum assumenda sed vel.\nIusto adipisci quia.\nIusto et dolore rerum explicabo mollitia quis autem architecto.\nEx nihil sint architecto ullam molestiae ipsam earum.", new DateTime(2023, 8, 16, 17, 40, 13, 846, DateTimeKind.Unspecified).AddTicks(932), "Beatae rem est dolor voluptatem.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 8, 11, 3, 55, 56, 228, DateTimeKind.Unspecified).AddTicks(1913), 4L, "Ipsa aut temporibus assumenda pariatur provident vel voluptatem porro.\nEligendi qui rerum cumque quos molestiae.", new DateTime(2024, 1, 10, 14, 36, 47, 666, DateTimeKind.Unspecified).AddTicks(8403), true, "Quasi nesciunt ullam fugit quasi ut veritatis ut est numquam.", 40L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 4, 12, 14, 25, 8, 63, DateTimeKind.Unspecified).AddTicks(3524), 3L, "Nostrum aut enim eos sit voluptatem.", new DateTime(2022, 8, 19, 14, 50, 45, 923, DateTimeKind.Unspecified).AddTicks(1268), false, "Iusto architecto quaerat.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 9, 10, 4, 52, 45, 31, DateTimeKind.Unspecified).AddTicks(6708), "Occaecati exercitationem architecto.\nAliquid optio officia.\nEt vero repudiandae sequi fugiat et minus.", new DateTime(2022, 12, 12, 3, 7, 31, 318, DateTimeKind.Unspecified).AddTicks(9413), true, "Et quaerat id totam voluptatum incidunt consequatur est quidem recusandae.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 12, 25, 14, 52, 32, 541, DateTimeKind.Unspecified).AddTicks(9008), "Temporibus et vero velit placeat harum quod eius ut dolores.\nNisi ducimus quidem cum dolores earum fugit adipisci in.\nEligendi est et.\nNam vel aspernatur natus necessitatibus.\nSed quae dolore quae corporis debitis incidunt voluptates vel.", new DateTime(2023, 9, 3, 20, 14, 30, 284, DateTimeKind.Unspecified).AddTicks(8863), true, "Eos impedit quam ut mollitia doloremque quidem est et.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 9, 30, 1, 54, 36, 400, DateTimeKind.Unspecified).AddTicks(2430), 3L, "Dicta magnam rerum expedita nisi tempore omnis ullam sed.\nAutem et impedit sed vel est eum.\nEx voluptas repellat eligendi quae dolor accusantium.", new DateTime(2022, 6, 24, 18, 37, 33, 353, DateTimeKind.Unspecified).AddTicks(3289), "Suscipit et provident optio dolores praesentium totam ut explicabo consequatur.", 40L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 10, 15, 1, 34, 56, 869, DateTimeKind.Unspecified).AddTicks(7262), 5L, "Omnis et assumenda maxime unde sint maiores nostrum.\nEos architecto unde.\nExplicabo quo reprehenderit quia laudantium harum.\nUt consequatur quisquam eos.\nAut neque ipsam vel illum blanditiis enim maxime.", new DateTime(2023, 6, 27, 4, 57, 7, 866, DateTimeKind.Unspecified).AddTicks(6967), false, "Blanditiis qui dolorem natus voluptatem occaecati.", 27L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2022, 1, 30, 14, 35, 13, 170, DateTimeKind.Unspecified).AddTicks(8732), 1L, "Ea eaque ea natus et.\nNobis necessitatibus expedita enim maxime.\nEt aut nam facere tempore.\nVoluptatem ea voluptas et facere voluptatem et totam et fugiat.", new DateTime(2023, 2, 16, 8, 13, 33, 156, DateTimeKind.Unspecified).AddTicks(9121), true, "Non aperiam nam.", 25L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 3, 4, 1, 41, 47, 512, DateTimeKind.Unspecified).AddTicks(6408), 5L, "Quam dicta iure doloremque officia sit velit delectus ea.\nQuia in enim et animi veniam eaque.\nSapiente ducimus pariatur consequatur quisquam repellat animi laboriosam.", new DateTime(2022, 9, 17, 23, 7, 5, 262, DateTimeKind.Unspecified).AddTicks(1994), "Nulla aut facere rerum.", 40L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 8L, new DateTime(2021, 3, 3, 8, 13, 58, 420, DateTimeKind.Unspecified).AddTicks(9071), 1L, "Consectetur maxime optio explicabo quidem natus.", new DateTime(2023, 8, 15, 1, 38, 14, 682, DateTimeKind.Unspecified).AddTicks(4533), "Harum nisi porro consequatur quis voluptatem qui impedit accusamus.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 5, 7, 7, 8, 41, 118, DateTimeKind.Unspecified).AddTicks(732), 3L, "Dolorum sequi animi cum sequi rerum.", new DateTime(2023, 12, 4, 8, 25, 37, 91, DateTimeKind.Unspecified).AddTicks(5494), "Iure et dolore nihil sit.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2022, 1, 26, 13, 13, 26, 988, DateTimeKind.Unspecified).AddTicks(9931), 1L, "Voluptatem sit illum voluptatibus.\nQuo nostrum aliquid reiciendis at quasi maxime autem est.", new DateTime(2023, 8, 6, 5, 27, 33, 552, DateTimeKind.Unspecified).AddTicks(2284), "Voluptatem consequatur at facilis.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 10, 23, 17, 29, 32, 545, DateTimeKind.Unspecified).AddTicks(1658), 2L, "Corrupti aspernatur aut tempora et ipsum vel.\nEt provident itaque saepe ut voluptas consequatur aliquam qui ut.\nQuo fuga veniam atque dolorum dolorem illo excepturi sint.", new DateTime(2023, 8, 21, 21, 39, 8, 609, DateTimeKind.Unspecified).AddTicks(8280), "Rerum perferendis voluptas rem enim itaque nulla quae culpa.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 3, 22, 23, 5, 26, 307, DateTimeKind.Unspecified).AddTicks(5158), 5L, "Architecto eius cumque.\nDolores nihil et.", new DateTime(2023, 6, 16, 21, 26, 18, 839, DateTimeKind.Unspecified).AddTicks(3902), "Ad nulla non reiciendis et.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 7, 2, 23, 37, 38, 531, DateTimeKind.Unspecified).AddTicks(2345), 4L, "Amet quam tempora ut et.\nMolestias sunt voluptate molestiae natus voluptates eum sunt quia.\nEt quae iste aut est.\nAb et deserunt.", new DateTime(2022, 11, 29, 11, 11, 47, 524, DateTimeKind.Unspecified).AddTicks(6999), "Et quaerat inventore placeat.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 4, 19, 4, 27, 46, 257, DateTimeKind.Unspecified).AddTicks(9850), "Quas optio velit illum.\nRem rerum eveniet atque voluptate.\nAliquid laboriosam aut adipisci at est aspernatur consequatur nihil rerum.\nVoluptatem qui molestiae qui.\nSit nihil aliquid nihil iste enim.", new DateTime(2023, 8, 10, 15, 57, 26, 709, DateTimeKind.Unspecified).AddTicks(2334), false, "Sed doloremque et et.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 10, 3, 13, 46, 15, 184, DateTimeKind.Unspecified).AddTicks(1120), 3L, "Ut laboriosam assumenda.\nSimilique numquam exercitationem vel placeat.\nBlanditiis sit laborum adipisci magni nihil.", new DateTime(2022, 12, 20, 16, 20, 56, 536, DateTimeKind.Unspecified).AddTicks(6706), false, "Vero optio non architecto inventore nemo dolore.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 9, 19, 7, 0, 8, 71, DateTimeKind.Unspecified).AddTicks(5699), 4L, "Perferendis itaque enim nihil perspiciatis.\nAtque vero ea ea.", new DateTime(2023, 3, 19, 19, 13, 53, 187, DateTimeKind.Unspecified).AddTicks(9759), false, "Veniam temporibus similique magnam minima et reprehenderit quia sunt doloribus.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 4, 25, 1, 15, 57, 754, DateTimeKind.Unspecified).AddTicks(4397), 5L, "Dolores repellat delectus sit dolores ex.\nAut accusantium voluptatem quo sed.\nIpsum autem aperiam numquam pariatur reprehenderit dolores molestiae modi.", new DateTime(2022, 9, 27, 20, 21, 33, 785, DateTimeKind.Unspecified).AddTicks(5868), true, "Libero repellat nihil aspernatur.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 7, 17, 14, 38, 25, 188, DateTimeKind.Unspecified).AddTicks(7013), 3L, "Deleniti sed et nam.\nId ducimus pariatur quidem dolor at impedit rerum.\nAd tempore eius ut voluptatem culpa consequatur.", null, "Asperiores officia aliquam sunt qui est nihil in incidunt ut.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2021, 12, 21, 21, 58, 41, 323, DateTimeKind.Unspecified).AddTicks(814), 3L, "Ea beatae et voluptatem voluptas quae enim numquam.\nUnde et saepe et aperiam ea est vitae.\nEst quas et consectetur vitae dolores exercitationem ab sit dolor.", new DateTime(2023, 9, 3, 13, 55, 22, 545, DateTimeKind.Unspecified).AddTicks(541), "Libero blanditiis maiores quas necessitatibus ex.", 25L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 11, 15, 22, 59, 21, 336, DateTimeKind.Unspecified).AddTicks(2102), "Repellat aperiam sint quam eveniet quidem aspernatur ullam nihil.\nQui earum consectetur numquam repellat libero ut minima et sunt.\nEum qui eaque omnis sint voluptas.\nTenetur vitae tempore qui.", new DateTime(2023, 9, 7, 14, 3, 12, 741, DateTimeKind.Unspecified).AddTicks(7395), true, "Qui id alias magnam voluptatem.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title" },
                values: new object[] { 8L, new DateTime(2021, 5, 19, 0, 53, 43, 126, DateTimeKind.Unspecified).AddTicks(2729), 3L, "Quia qui illo.\nQuasi doloremque aut blanditiis.\nIn laborum nemo aut rerum voluptatibus accusamus.\nUt nisi nostrum dolores qui excepturi voluptatem rerum qui explicabo.\nIpsam aut molestiae blanditiis.", null, "Unde vitae dolores molestiae." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 3, 25, 22, 46, 29, 556, DateTimeKind.Unspecified).AddTicks(468), 1L, "Voluptatem qui natus et.\nAut aperiam velit.\nRecusandae nulla qui est voluptatum sequi et.\nAperiam praesentium neque consequatur laudantium nostrum deserunt qui sapiente.", new DateTime(2022, 7, 22, 16, 6, 20, 849, DateTimeKind.Unspecified).AddTicks(8891), "Ab cumque asperiores sit minima culpa maxime suscipit ut dolorem.", 40L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 8, 28, 0, 47, 40, 552, DateTimeKind.Unspecified).AddTicks(172), 2L, "Fugit at at sunt et.\nEnim corrupti sed nihil sint iure.\nExercitationem ut est quasi est deserunt asperiores dolores.\nRerum et quibusdam.\nVeniam sed tempore laudantium qui atque itaque velit.", new DateTime(2022, 6, 9, 3, 43, 47, 362, DateTimeKind.Unspecified).AddTicks(7418), "Consequatur omnis accusamus enim ipsum sunt rerum cum.", 2L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 12, 14, 9, 1, 41, 712, DateTimeKind.Unspecified).AddTicks(4789), 3L, "Debitis assumenda eaque.\nAliquid omnis aut eos adipisci vel id rerum doloremque qui.\nQuia tempora iusto nobis numquam in.\nEt quam et.\nVel est impedit est incidunt delectus.", new DateTime(2023, 10, 2, 8, 52, 28, 942, DateTimeKind.Unspecified).AddTicks(309), true, "Harum expedita aliquam quia quam sunt in nisi dignissimos et.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2022, 1, 5, 16, 11, 51, 668, DateTimeKind.Unspecified).AddTicks(8955), 3L, "Consequatur vel est.\nEst ut et laboriosam ut in quos.\nQuam qui est illo et qui.", new DateTime(2022, 3, 13, 5, 2, 40, 545, DateTimeKind.Unspecified).AddTicks(1177), "Laborum sit debitis optio illum sint quis sunt ut id.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 2, 6, 11, 19, 27, 975, DateTimeKind.Unspecified).AddTicks(3106), 4L, "Voluptatem inventore eveniet veniam.\nOccaecati et delectus numquam voluptas dignissimos ad.\nRatione voluptatem praesentium sunt.\nTotam distinctio quas id necessitatibus aut consequatur.", new DateTime(2023, 10, 16, 6, 44, 40, 594, DateTimeKind.Unspecified).AddTicks(6448), "Voluptate ab et quaerat nostrum velit consequatur aliquam.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2022, 1, 22, 23, 46, 30, 637, DateTimeKind.Unspecified).AddTicks(591), 3L, "Cupiditate totam accusantium.\nEos ipsa aliquam dolores illum ex earum.\nQuo blanditiis temporibus repellat quisquam esse ipsum explicabo repudiandae.\nEa aliquid veniam tempora ex enim excepturi officiis.", new DateTime(2023, 2, 23, 10, 51, 14, 647, DateTimeKind.Unspecified).AddTicks(3792), false, "Omnis ea dolorum asperiores.", 2L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 5, 4, 13, 45, 37, 279, DateTimeKind.Unspecified).AddTicks(6304), 5L, "Doloremque eum voluptas rerum.\nDolorem quidem velit nulla.\nTempore dolore quidem.\nVoluptatibus dolorum rerum dolorem dolorum aspernatur vel molestiae.\nConsequatur placeat sed quia perspiciatis soluta est rerum numquam.", new DateTime(2022, 12, 14, 13, 3, 24, 6, DateTimeKind.Unspecified).AddTicks(7877), true, "Ut debitis nulla unde ut doloremque omnis dolores.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 10, 17, 4, 26, 11, 227, DateTimeKind.Unspecified).AddTicks(2391), 4L, "Labore neque error laborum dicta itaque sint facere.\nId deserunt qui necessitatibus libero quas sunt sint velit.\nBlanditiis illum natus ea explicabo officiis.\nEt sed consequatur fugit et at voluptate accusantium.\nNesciunt reiciendis quasi natus nihil.", new DateTime(2023, 6, 27, 10, 15, 44, 129, DateTimeKind.Unspecified).AddTicks(5438), true, "Et explicabo voluptatem sit itaque.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 4, 16, 10, 45, 47, 335, DateTimeKind.Unspecified).AddTicks(1734), 4L, "Et soluta et rem quod autem iusto.\nPlaceat expedita ea quod doloribus et.\nNisi aut dignissimos quidem porro.", new DateTime(2023, 8, 8, 13, 12, 30, 977, DateTimeKind.Unspecified).AddTicks(5085), "Expedita asperiores alias maxime maiores.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 5, 5, 6, 12, 5, 214, DateTimeKind.Unspecified).AddTicks(7048), "Sed et ex molestias sit amet ut corporis non facilis.\nIste ea voluptatum quis et.", new DateTime(2023, 11, 12, 18, 54, 19, 670, DateTimeKind.Unspecified).AddTicks(598), true, "Voluptas consequuntur consequatur consequatur quaerat.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 11, 26, 2, 15, 53, 505, DateTimeKind.Unspecified).AddTicks(43), 2L, "Aut ea sunt placeat facere.\nId fugit ducimus ducimus blanditiis non laborum enim et nesciunt.\nOmnis rem fugit et voluptates provident sequi aliquid velit consectetur.\nAut sit tempore doloremque sit ex voluptatem voluptatem enim.", new DateTime(2023, 7, 19, 4, 56, 19, 281, DateTimeKind.Unspecified).AddTicks(16), false, "Dolorem tempore eius consequatur mollitia enim.", 38L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 9, 10, 6, 1, 31, 998, DateTimeKind.Unspecified).AddTicks(4248), "Ipsa et et.", new DateTime(2022, 7, 12, 10, 18, 56, 157, DateTimeKind.Unspecified).AddTicks(4704), "Nostrum iste aut saepe molestiae.", 24L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 2, 4, 5, 5, 58, 590, DateTimeKind.Unspecified).AddTicks(705), "Sit aut eum aut.\nDolor eos autem.\nExercitationem voluptate quae quasi et incidunt.\nEos quasi minima suscipit sit voluptatibus accusamus.\nDolor quidem culpa et non unde rerum.", new DateTime(2022, 10, 3, 1, 16, 2, 682, DateTimeKind.Unspecified).AddTicks(5160), "Assumenda consequatur voluptatem omnis nihil doloremque aliquam aut explicabo.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 6, 25, 14, 54, 19, 404, DateTimeKind.Unspecified).AddTicks(1657), 1L, "A adipisci ratione adipisci voluptatum.\nItaque illum iste.\nAperiam recusandae enim cumque consequatur animi asperiores ut nulla.", new DateTime(2022, 11, 27, 19, 17, 59, 489, DateTimeKind.Unspecified).AddTicks(3558), false, "Amet eligendi architecto animi nesciunt.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 8L, new DateTime(2021, 10, 8, 8, 9, 34, 791, DateTimeKind.Unspecified).AddTicks(1560), 4L, "Tempore ab molestiae rerum sint et.\nDoloribus inventore corrupti.\nIllum sunt beatae suscipit ipsam sunt veniam vitae.", new DateTime(2022, 3, 27, 5, 4, 8, 306, DateTimeKind.Unspecified).AddTicks(5407), false, "Et rerum qui voluptatem qui dolorem quis nesciunt modi.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 11, 29, 11, 22, 40, 703, DateTimeKind.Unspecified).AddTicks(120), 4L, "Molestiae dolorem quia numquam esse laudantium.", new DateTime(2023, 3, 17, 10, 27, 38, 409, DateTimeKind.Unspecified).AddTicks(4759), "Nostrum aspernatur non error.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 4, 22, 0, 7, 36, 83, DateTimeKind.Unspecified).AddTicks(1027), 5L, "Officiis eos quis saepe impedit.\nAut saepe veniam quia sit.\nDolores sit sequi saepe molestiae facere sed eveniet et.", new DateTime(2023, 7, 16, 12, 38, 30, 855, DateTimeKind.Unspecified).AddTicks(8435), "Et quos sit qui.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2021, 11, 8, 21, 41, 8, 389, DateTimeKind.Unspecified).AddTicks(5847), 1L, "Veniam nisi iste enim laborum.\nNemo similique ad itaque voluptatibus voluptas soluta recusandae aut ipsum.\nMolestiae ad laborum et ratione ipsam ullam.\nMolestiae accusamus tenetur ut perspiciatis numquam ipsam architecto non ab.", new DateTime(2023, 9, 17, 19, 53, 40, 204, DateTimeKind.Unspecified).AddTicks(8427), "Doloribus quod aut nihil.", 25L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 6, 15, 23, 3, 45, 61, DateTimeKind.Unspecified).AddTicks(2333), "Cupiditate ratione illum.", new DateTime(2022, 6, 7, 20, 54, 12, 809, DateTimeKind.Unspecified).AddTicks(5223), "Ducimus rerum dicta.", 7L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 3, 6, 9, 39, 26, 81, DateTimeKind.Unspecified).AddTicks(469), 5L, "Libero minus quisquam libero voluptas.", new DateTime(2023, 1, 12, 13, 40, 41, 40, DateTimeKind.Unspecified).AddTicks(1991), "Aliquam exercitationem nobis.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 6, 13, 13, 27, 42, 12, DateTimeKind.Unspecified).AddTicks(8813), 4L, "Saepe dolorem nisi consequatur.\nQuis provident rerum.\nIn repudiandae repellendus vitae ea blanditiis numquam labore reprehenderit porro.", new DateTime(2022, 6, 2, 10, 15, 30, 472, DateTimeKind.Unspecified).AddTicks(8084), true, "Voluptatem deserunt optio.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 6, 3, 9, 45, 43, 915, DateTimeKind.Unspecified).AddTicks(9319), 4L, "Culpa ea amet dolor omnis saepe aut.\nPlaceat omnis fugiat dolorem dolor velit.\nVoluptatem quibusdam in adipisci nihil vero aut aut qui et.\nSed voluptatum consectetur ipsa tenetur deserunt perspiciatis eligendi consequatur ex.", new DateTime(2024, 1, 16, 3, 53, 14, 546, DateTimeKind.Unspecified).AddTicks(8714), false, "Voluptatem reprehenderit iure quasi ipsa iusto mollitia ipsa ea eos.", 23L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 6, 18, 5, 15, 50, 506, DateTimeKind.Unspecified).AddTicks(4740), 5L, "Sit dolore dolorem nam delectus nobis.\nMagnam quae veniam et ea dolores.\nImpedit mollitia et veniam.\nIure fuga quis.\nEaque laudantium eaque quia.", new DateTime(2023, 10, 29, 5, 27, 18, 505, DateTimeKind.Unspecified).AddTicks(1163), false, "Impedit iste natus quis.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 9, 22, 3, 10, 41, 786, DateTimeKind.Unspecified).AddTicks(5061), 5L, "Consequatur sit odit non aliquid tempore autem.\nIpsam cupiditate aut ipsam.\nVelit blanditiis fugiat ipsa vitae.\nSed non commodi laborum pariatur praesentium nisi labore nam.\nEa voluptates totam enim impedit vitae.", new DateTime(2022, 3, 15, 8, 53, 30, 414, DateTimeKind.Unspecified).AddTicks(7211), "Eos quibusdam consequuntur.", 5L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title" },
                values: new object[] { 9L, new DateTime(2021, 8, 30, 22, 48, 0, 825, DateTimeKind.Unspecified).AddTicks(4773), 5L, "Qui est rerum quisquam quaerat.\nAut iusto quo eligendi a laborum.\nConsequatur similique fugit qui ipsam nobis ad nihil.\nVeritatis ea ut.", new DateTime(2023, 3, 16, 6, 19, 47, 91, DateTimeKind.Unspecified).AddTicks(974), "Consequatur nisi nostrum enim nam molestiae labore amet illum." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 4, 30, 22, 13, 55, 230, DateTimeKind.Unspecified).AddTicks(2149), "Molestiae autem quia ab qui est voluptatem aspernatur enim.\nAccusamus magni odio repudiandae laborum qui veniam qui cumque.\nSuscipit et quis in velit.\nExcepturi quam molestias cum veritatis inventore.\nVoluptatum et quod rerum enim sed voluptates molestiae culpa.", new DateTime(2023, 1, 30, 12, 45, 8, 358, DateTimeKind.Unspecified).AddTicks(7771), "Velit magni qui inventore odio suscipit quaerat.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2022, 2, 1, 9, 37, 5, 467, DateTimeKind.Unspecified).AddTicks(6876), 5L, "Voluptas officia quidem dolor.\nSit delectus esse officiis optio aut sint temporibus aliquid.", new DateTime(2023, 8, 6, 18, 5, 46, 770, DateTimeKind.Unspecified).AddTicks(3884), "Voluptatum nesciunt aut iste est laudantium ullam sunt est quidem.", 28L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 2, 4, 22, 13, 41, 315, DateTimeKind.Unspecified).AddTicks(9874), 1L, "Velit et aut.", new DateTime(2023, 6, 9, 13, 21, 42, 585, DateTimeKind.Unspecified).AddTicks(8626), "Qui aperiam occaecati dolor et.", 36L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 10, 16, 1, 23, 7, 244, DateTimeKind.Unspecified).AddTicks(2448), "Dolorem eum quibusdam harum expedita quo reprehenderit omnis.\nId enim qui.", new DateTime(2023, 12, 31, 6, 22, 35, 266, DateTimeKind.Unspecified).AddTicks(51), "Est beatae autem et aspernatur omnis sit delectus voluptas.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2021, 4, 21, 17, 39, 26, 742, DateTimeKind.Unspecified).AddTicks(3053), 2L, "Et eos dolores ex quaerat.\nNon minus recusandae ullam aperiam.\nIpsam ipsa error itaque eligendi.\nQuod velit exercitationem recusandae voluptas qui.\nConsectetur rerum enim placeat doloribus hic saepe deleniti nihil impedit.", new DateTime(2023, 9, 5, 23, 19, 34, 423, DateTimeKind.Unspecified).AddTicks(6562), "Ut omnis enim.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 2, 8, 0, 14, 16, 243, DateTimeKind.Unspecified).AddTicks(1131), "Quia provident nihil architecto maiores voluptatem repudiandae.", new DateTime(2023, 1, 15, 9, 38, 33, 714, DateTimeKind.Unspecified).AddTicks(8050), true, "Non expedita sit tenetur enim quaerat magni.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 2, 28, 11, 30, 15, 742, DateTimeKind.Unspecified).AddTicks(1052), 2L, "Qui a aut porro est sit in molestiae.\nEt qui tempore esse fuga commodi omnis ut quisquam est.\nNatus tempora suscipit qui mollitia ut.", null, true, "Eos repellendus saepe sit assumenda.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 8L, new DateTime(2021, 12, 6, 11, 32, 58, 756, DateTimeKind.Unspecified).AddTicks(2281), 2L, "Omnis ratione qui autem enim provident est.\nAut perspiciatis est asperiores dolorem sunt sint dolorum ex.\nPraesentium officiis ex.\nPerspiciatis cumque repellendus consectetur quos ducimus temporibus debitis doloribus.\nRecusandae repudiandae aut beatae excepturi expedita.", new DateTime(2022, 8, 28, 3, 30, 41, 573, DateTimeKind.Unspecified).AddTicks(8031), false, "Et dolor in eveniet ea voluptatem.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 6, 28, 0, 46, 39, 290, DateTimeKind.Unspecified).AddTicks(3097), "Et delectus nesciunt autem.\nQuia aut quia eaque minima maiores magni.\nRatione veritatis magnam vitae voluptas odit optio.", new DateTime(2023, 10, 6, 3, 5, 32, 595, DateTimeKind.Unspecified).AddTicks(1434), "Commodi ipsam eum quaerat tenetur.", 30L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 4, 13, 7, 3, 35, 773, DateTimeKind.Unspecified).AddTicks(6420), 4L, "Ut possimus eius rem reprehenderit est neque optio.\nVeniam accusantium ad quia corporis.\nPlaceat quam nulla.\nEa architecto tempore quasi adipisci saepe quod deserunt magnam.", new DateTime(2022, 11, 1, 18, 34, 19, 372, DateTimeKind.Unspecified).AddTicks(8883), "Quam officiis nam amet fugiat sit.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 12, 16, 9, 0, 54, 989, DateTimeKind.Unspecified).AddTicks(1757), 1L, "Cum doloremque maiores.\nSunt iusto quia fugit consequatur sint assumenda doloribus atque.\nQui exercitationem est voluptatem culpa.\nIllo repudiandae quia non magni tempora totam nobis.", new DateTime(2022, 7, 6, 6, 57, 2, 673, DateTimeKind.Unspecified).AddTicks(4606), false, "Quos et consequatur.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 7, 4, 21, 29, 44, 604, DateTimeKind.Unspecified).AddTicks(8805), "Neque ipsam praesentium et autem.\nVoluptas temporibus veritatis asperiores voluptas nihil est tempore ut.\nOccaecati et labore aperiam quisquam vero nobis dolorum sed laborum.", new DateTime(2022, 12, 5, 15, 19, 31, 468, DateTimeKind.Unspecified).AddTicks(1435), "Quae nobis ut dolorum blanditiis sed voluptatum odio.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 4, 1, 18, 58, 51, 127, DateTimeKind.Unspecified).AddTicks(6501), "Sapiente nisi voluptates mollitia ad corrupti perferendis similique velit.", new DateTime(2022, 12, 8, 22, 13, 19, 490, DateTimeKind.Unspecified).AddTicks(7588), "Necessitatibus ut repudiandae consequatur dolor esse voluptas ipsa quaerat.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2021, 11, 9, 6, 57, 3, 393, DateTimeKind.Unspecified).AddTicks(3521), "Quo rerum cumque et sapiente.\nCorrupti voluptatum doloribus praesentium autem debitis distinctio consectetur.\nDolorem magni quidem aut aut enim odio veniam.", new DateTime(2023, 6, 4, 2, 30, 15, 420, DateTimeKind.Unspecified).AddTicks(641), true, "Iure odio nam rerum.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 2, 26, 20, 29, 59, 219, DateTimeKind.Unspecified).AddTicks(4177), 4L, "Minima vitae est iusto ratione excepturi facere.\nQuia atque natus nemo.\nNulla in voluptatem.\nId aperiam voluptatem autem quia aliquam.\nIure et tempore.", new DateTime(2023, 1, 20, 5, 32, 24, 706, DateTimeKind.Unspecified).AddTicks(7950), false, "Deserunt sed qui libero quas accusantium saepe.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 10, 24, 10, 54, 26, 326, DateTimeKind.Unspecified).AddTicks(2431), 3L, "Nesciunt provident doloribus labore.", new DateTime(2023, 8, 1, 18, 56, 17, 776, DateTimeKind.Unspecified).AddTicks(8825), true, "Dolorem non unde.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 8, 14, 12, 54, 0, 489, DateTimeKind.Unspecified).AddTicks(9888), "Quo enim amet corrupti consequatur.", null, false, "Odit nihil vero eligendi id tenetur dolorem fuga.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 3, 25, 16, 31, 29, 597, DateTimeKind.Unspecified).AddTicks(8117), 5L, "Ullam qui corrupti.\nCulpa magnam architecto mollitia quis.", new DateTime(2023, 10, 30, 19, 0, 21, 113, DateTimeKind.Unspecified).AddTicks(3218), false, "Laudantium debitis dolorum et dicta molestias.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 12, 27, 9, 39, 11, 866, DateTimeKind.Unspecified).AddTicks(3985), 3L, "Cupiditate quia quisquam a voluptatibus.\nRecusandae accusamus ipsam.\nA reiciendis odio dolor nulla.\nIste iste nihil unde voluptatem commodi unde et id natus.", null, true, "Et placeat itaque amet ad.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 9L, new DateTime(2021, 6, 18, 6, 8, 39, 990, DateTimeKind.Unspecified).AddTicks(3904), "Qui alias debitis debitis deleniti tenetur voluptas vel et.", new DateTime(2023, 10, 17, 7, 21, 42, 701, DateTimeKind.Unspecified).AddTicks(4021), "Qui sapiente dolorem eos exercitationem explicabo cupiditate odio.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 8, 29, 17, 45, 49, 19, DateTimeKind.Unspecified).AddTicks(6526), 5L, "Quia ullam illum soluta.\nVoluptatem praesentium eveniet.", new DateTime(2022, 4, 21, 10, 42, 15, 250, DateTimeKind.Unspecified).AddTicks(231), "Quam porro recusandae provident maxime.", 31L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 7, 26, 3, 37, 40, 168, DateTimeKind.Unspecified).AddTicks(8371), "Sunt earum tempore consequatur molestias totam ab.\nVero iste culpa distinctio ad.\nSed dolorem tenetur doloribus sapiente deserunt nam eos fuga.\nQuo rerum eaque omnis voluptas dolor assumenda ut.\nEos voluptatum voluptatem.", new DateTime(2023, 9, 1, 2, 29, 31, 175, DateTimeKind.Unspecified).AddTicks(9669), "Debitis quae dolores consectetur rem sapiente iste aperiam.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 5, 30, 12, 49, 5, 83, DateTimeKind.Unspecified).AddTicks(5041), "Architecto non debitis impedit voluptatem non aut.", new DateTime(2023, 4, 30, 16, 13, 55, 482, DateTimeKind.Unspecified).AddTicks(9494), true, "Quia aut eius assumenda cumque architecto corporis.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 12, 20, 19, 51, 9, 35, DateTimeKind.Unspecified).AddTicks(5559), 1L, "Veniam et ab nostrum qui rerum.\nFugit laboriosam deleniti laudantium ipsum velit adipisci.\nVoluptatem voluptas alias vero sed voluptatibus magnam accusantium aperiam.\nEum temporibus sunt harum eum ad molestiae ratione dolor temporibus.\nDolorem quam accusamus nostrum.", new DateTime(2022, 10, 17, 18, 50, 4, 602, DateTimeKind.Unspecified).AddTicks(7246), "Facilis eos ipsam quibusdam vel.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 3L, new DateTime(2021, 3, 5, 9, 17, 31, 145, DateTimeKind.Unspecified).AddTicks(9938), 1L, "Eaque sit in.\nPariatur quae atque.\nQuia sed accusantium voluptatem ea distinctio iusto ut magni similique.", new DateTime(2023, 8, 14, 2, 31, 49, 731, DateTimeKind.Unspecified).AddTicks(8841), true, "Sed quo officiis omnis quibusdam occaecati maxime.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 11, 19, 13, 46, 55, 178, DateTimeKind.Unspecified).AddTicks(5038), "Sit et odio nemo voluptatem eos consequatur culpa deleniti.", new DateTime(2023, 3, 20, 5, 5, 26, 150, DateTimeKind.Unspecified).AddTicks(5764), "Libero id possimus fugiat voluptatum ea in assumenda possimus.", 28L });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 7, 26, 19, 4, 4, 734, DateTimeKind.Unspecified).AddTicks(1970), 5L, "Dolor molestiae rerum dicta id.\nOptio nisi et.\nQui modi porro et est reiciendis.", 33L, "Ullam odio voluptatum ipsam provident a." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 13, 15, 24, 20, 34, DateTimeKind.Unspecified).AddTicks(1504), 2L, "Omnis unde fuga porro eligendi optio veritatis nam.\nQuos voluptas sapiente officiis id.", true, 34L, "Quia at et necessitatibus aut molestiae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 22, 1, 6, 33, 968, DateTimeKind.Unspecified).AddTicks(5617), 4L, "Nihil adipisci et animi atque quo aut.\nSapiente molestias voluptatem aut fuga enim voluptatibus dolores ab.\nFuga animi nihil culpa est vel molestiae.\nMagni voluptas rerum natus eligendi debitis.\nCorrupti a qui doloribus et voluptatum nesciunt et.", 36L, "Facere et repellat et veritatis voluptatem illum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 24, 5, 1, 34, 472, DateTimeKind.Unspecified).AddTicks(1709), 2L, "Accusamus quia perspiciatis quia cum.", 31L, "Consequuntur amet sit est perferendis praesentium." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 7, 16, 22, 3, 49, 356, DateTimeKind.Unspecified).AddTicks(517), 5L, "Dicta totam aut eum aut sint cum non sit.", 39L, "Vel ratione eum dolores ex quo." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 7, 27, 15, 9, 33, 82, DateTimeKind.Unspecified).AddTicks(6140), 1L, "Similique ducimus in neque consequuntur corporis sint iste perferendis.\nFugiat sit fuga quia autem est enim corrupti labore et.\nRatione optio harum officia quia pariatur.", false, 25L, "Nobis aliquid et quo." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 8, 20, 12, 17, 373, DateTimeKind.Unspecified).AddTicks(7584), 5L, "Quia sint laboriosam fugit similique et nisi eos sapiente beatae.\nMollitia delectus quam quam.\nEarum in aut qui laboriosam explicabo voluptatibus rem ipsam.", false, 19L, "Labore minima et quidem necessitatibus itaque aliquam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 22, 17, 9, 34, 301, DateTimeKind.Unspecified).AddTicks(2925), 5L, "Quisquam et tenetur iure sint enim eos.", 46L, "Suscipit incidunt expedita harum quia harum ea occaecati voluptatem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Title" },
                values: new object[] { new DateTime(2021, 12, 28, 8, 57, 2, 919, DateTimeKind.Unspecified).AddTicks(2616), 2L, "Vel quia quia maxime ut itaque suscipit explicabo temporibus qui.\nOmnis qui rerum et deserunt accusantium.\nQui libero atque.\nAt necessitatibus aut dolor.", false, "Magni distinctio accusantium provident et quibusdam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 4, 26, 8, 16, 50, 656, DateTimeKind.Unspecified).AddTicks(2232), 2L, "Reiciendis itaque voluptas aperiam corrupti occaecati.\nQuisquam amet quae et molestias dolor ea tenetur velit.", true, 15L, "Quisquam qui dolor consequuntur animi autem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 20, 6, 3, 32, 131, DateTimeKind.Unspecified).AddTicks(1468), "Nihil sequi unde illum sit eius vel mollitia esse minus.\nOdit commodi quis neque inventore nisi molestiae eos.\nQuo voluptatem dignissimos assumenda necessitatibus sit qui.\nCommodi similique sunt delectus nisi officia.", false, 34L, "Velit commodi et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2022, 1, 22, 21, 9, 33, 438, DateTimeKind.Unspecified).AddTicks(4862), 1L, "Eligendi magni et eos.\nEt et iusto itaque aut consectetur eum.\nDolor non est architecto autem incidunt pariatur neque.\nVoluptas omnis omnis molestias aut aut ut est eveniet.\nSuscipit modi architecto possimus nihil minima eum.", 27L, "Numquam eligendi sit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 26, 22, 26, 10, 542, DateTimeKind.Unspecified).AddTicks(989), 3L, "Eos voluptatem hic eos inventore.\nConsequatur magni enim aut sit explicabo sed nostrum quia nam.\nQuos nihil ipsum.", 41L, "Qui et earum reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 30, 1, 44, 30, 757, DateTimeKind.Unspecified).AddTicks(5812), "Provident natus molestias in culpa adipisci.\nEos iure exercitationem ut.\nSed voluptate animi id eaque qui eum ducimus.", false, 15L, "Accusantium qui occaecati eum sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 56, 47, 313, DateTimeKind.Unspecified).AddTicks(3850), 4L, "Dolor et dicta at voluptas error dolor ut eum illum.\nItaque molestiae doloribus atque et id sed et voluptatem.\nDolorem aut natus voluptate dolores recusandae.", false, 29L, "Sit temporibus doloremque quia pariatur placeat consectetur sed est." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Title" },
                values: new object[] { new DateTime(2021, 6, 27, 16, 0, 12, 944, DateTimeKind.Unspecified).AddTicks(6223), "Corrupti odit excepturi.", false, "Nulla dolorum a velit facilis non." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 26, 3, 24, 35, 267, DateTimeKind.Unspecified).AddTicks(6425), 1L, "Quos et dolorem cupiditate ducimus.\nHarum et nihil ab.\nEum sunt aut aperiam quasi consequatur non.\nSoluta est autem et pariatur ex omnis sed quo quia.\nQuia omnis perspiciatis unde magni nisi.", 8L, "Consequatur aspernatur qui esse." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 24, 16, 12, 4, 758, DateTimeKind.Unspecified).AddTicks(1023), 4L, "Exercitationem sunt et nihil.\nNon fugit sapiente aut.\nEveniet expedita et et.\nQui pariatur quo perspiciatis cum est atque rerum magni inventore.", true, 28L, "Dolore soluta laudantium sit dolorem omnis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Title" },
                values: new object[] { new DateTime(2021, 11, 15, 5, 19, 2, 173, DateTimeKind.Unspecified).AddTicks(9116), 5L, "Sit perferendis vel laborum hic.\nMinima similique dolor impedit.", "Non autem quod non debitis ea vitae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 12, 3, 37, 53, 732, DateTimeKind.Unspecified).AddTicks(3926), 5L, "Perferendis alias nihil est praesentium.", 7L, "Dolores consequatur quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 13, 1, 33, 4, 245, DateTimeKind.Unspecified).AddTicks(704), 1L, "Enim officiis recusandae hic dolor fuga ut maiores.\nDoloremque perspiciatis in fuga aperiam et.\nUt doloribus quia sit.", false, 32L, "Et est dolores quas." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 26, 5, 20, 47, 257, DateTimeKind.Unspecified).AddTicks(8317), "Maiores atque est.", true, 11L, "Commodi quia doloribus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 13, 3, 6, 43, 745, DateTimeKind.Unspecified).AddTicks(9947), 2L, "Aspernatur non nostrum ea quia laudantium.\nMolestias dolor molestias architecto cumque quisquam et officiis.", true, 24L, "Qui iure et iusto." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 4, 19, 54, 23, 304, DateTimeKind.Unspecified).AddTicks(6290), 4L, "Consequatur voluptate itaque consequatur sequi nostrum quisquam quia unde architecto.", 45L, "Ipsa inventore rerum ipsum pariatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 12, 22, 50, 5, 891, DateTimeKind.Unspecified).AddTicks(4657), 2L, "Itaque exercitationem perspiciatis hic.\nIpsa facilis sed molestias doloribus culpa.", 7L, "Nemo sit vel atque numquam rerum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 12, 3, 19, 37, 413, DateTimeKind.Unspecified).AddTicks(2531), 5L, "Autem consequatur repudiandae labore occaecati labore repellat architecto.\nLaboriosam suscipit dolorem et tenetur enim debitis.\nPerspiciatis vel et.\nBlanditiis quasi eius.", 50L, "Velit repellat nihil quia nisi et quos voluptatem a error." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 3, 23, 26, 12, 531, DateTimeKind.Unspecified).AddTicks(8974), 3L, "Et et enim quasi nam quaerat quam iure voluptatem.\nNon velit amet est distinctio suscipit exercitationem.", false, 3L, "Veniam asperiores qui quis earum voluptas qui beatae laboriosam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 4, 11, 9, 2, 14, 794, DateTimeKind.Unspecified).AddTicks(3353), 1L, "Velit sint qui reiciendis ratione alias omnis sapiente.\nIusto doloribus consectetur quasi qui quidem animi.\nAsperiores pariatur vel voluptatem temporibus.\nIste quibusdam voluptatibus quisquam voluptatem eum.", true, 40L, "Enim voluptas ut excepturi debitis sapiente fuga dolorem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 24, 18, 52, 9, 721, DateTimeKind.Unspecified).AddTicks(3781), 5L, "Reiciendis cumque beatae.", true, 40L, "Non libero et nobis amet nostrum qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 14, 2, 57, 22, 932, DateTimeKind.Unspecified).AddTicks(6614), 2L, "Ea culpa dicta cum quo.", true, 30L, "Harum voluptatem quam reprehenderit velit et ut dolor." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 13, 4, 32, 10, 317, DateTimeKind.Unspecified).AddTicks(236), 1L, "A enim odit omnis consequuntur fugiat qui fugit.\nId animi quas voluptatem perferendis quod deleniti molestiae ullam.\nCumque eligendi qui voluptates ut vitae eum omnis sit.\nHarum deserunt velit praesentium.", 18L, "Animi aut iste labore voluptatem omnis rem vero." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 7, 23, 28, 49, 544, DateTimeKind.Unspecified).AddTicks(1619), 2L, "Explicabo repellendus perspiciatis et.\nPariatur ipsum asperiores voluptatem accusantium error commodi similique eligendi.", 5L, "Unde alias maiores qui similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 13, 12, 0, 24, 212, DateTimeKind.Unspecified).AddTicks(4416), "Consequatur et facere vero quo et dolorem.\nEa maiores quae numquam soluta ut dolor.\nEsse odio quam possimus assumenda et.\nDolore non est totam in aliquid hic.", true, 12L, "Aut amet quae in." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 23, 0, 59, 37, 299, DateTimeKind.Unspecified).AddTicks(5280), "Provident quidem iure officia assumenda id sequi recusandae quo.\nRepellat quas molestiae.", 40L, "Ut quam eos nemo repellendus id vel neque impedit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 6, 5, 9, 25, 836, DateTimeKind.Unspecified).AddTicks(3816), 1L, "Dolores quidem voluptatem tenetur quod.", false, 51L, "Itaque quo ea temporibus similique unde." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 2, 0, 30, 15, 21, DateTimeKind.Unspecified).AddTicks(955), 4L, "Commodi perferendis nemo dolorum.\nAssumenda esse dolores quod quasi voluptas qui quos.\nSint repudiandae aut ex sunt excepturi.\nCumque earum quam molestiae minima quos repellendus odio id.\nEnim sunt quasi assumenda fuga quo suscipit aperiam eos culpa.", false, 26L, "Aut voluptas dolor dignissimos illo et illo soluta ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 23, 22, 17, 2, 787, DateTimeKind.Unspecified).AddTicks(7573), 3L, "Ratione in ex distinctio architecto.", 11L, "Est ut sed aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 3, 15, 44, 47, 482, DateTimeKind.Unspecified).AddTicks(6129), 3L, "Quia tenetur non veniam sed dolor dolore.", true, 31L, "Inventore consequatur sit provident quos quam cumque saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 8, 22, 14, 373, DateTimeKind.Unspecified).AddTicks(7594), 5L, "Qui id eos hic sint quos in rerum est.\nEnim facilis consequatur fuga alias.\nRem quasi blanditiis saepe.", false, 49L, "Error error neque est porro aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 15, 7, 3, 22, 371, DateTimeKind.Unspecified).AddTicks(9042), 3L, "Quis ea quisquam sunt voluptatibus.\nImpedit animi est natus quia magnam id dolorum earum.\nUt eius facilis et expedita amet sed.", 7L, "Et odio dolorum consequatur et nihil." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 28, 21, 43, 18, 248, DateTimeKind.Unspecified).AddTicks(9890), 5L, "Corporis iusto eius minima aut corrupti nemo placeat.\nDoloremque eum sint quas dolor.\nEt illo qui.", 4L, "A enim necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 21, 51, 40, 110, DateTimeKind.Unspecified).AddTicks(1577), 4L, "Rerum laboriosam libero omnis sunt ullam sit quisquam.\nAccusamus qui laboriosam et commodi.\nIllum dolore animi repellendus.\nOmnis ut debitis nemo quas quod dolorum magnam perferendis quia.\nQuasi molestiae sunt.", false, 36L, "Sed a maiores esse." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 2, 3, 10, 51, 408, DateTimeKind.Unspecified).AddTicks(2202), 3L, "Eum harum alias aut quod praesentium commodi aliquam.\nSoluta non nihil sapiente facere distinctio repudiandae vel quo.", 7L, "Deleniti eum omnis est non pariatur quisquam doloremque voluptatem doloremque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 7, 13, 46, 50, 192, DateTimeKind.Unspecified).AddTicks(5321), 2L, "Corporis eius et laborum minus odio nihil maiores.\nIncidunt aliquid dolores aut quibusdam eveniet quasi consequatur est consectetur.\nNumquam id similique veniam numquam quo quia tenetur voluptas.\nAut et rem sed vel quo beatae.", 2L, "Ab omnis magni aliquid blanditiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 13, 6, 55, 38, 674, DateTimeKind.Unspecified).AddTicks(1978), 2L, "Reiciendis quos cumque et ut.\nVoluptatem fugit rem distinctio corporis sed.\nAccusantium voluptatibus quam sit asperiores praesentium.", false, 50L, "Et ut placeat repellat similique molestias sequi nihil quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 25, 13, 20, 39, 493, DateTimeKind.Unspecified).AddTicks(1451), "Et cum inventore qui hic repellat.\nSit ipsum et.\nCorporis aut officia.\nUt quo eos.", 16L, "Sit provident numquam qui illum quibusdam fuga quis sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 1, 5, 802, DateTimeKind.Unspecified).AddTicks(9842), 1L, "Quod quia voluptatem molestias facere.\nUllam eius corporis eius incidunt et omnis est eum.\nNihil quo ut fugiat occaecati dolor quod sint assumenda sed.", 19L, "Voluptatem vel sit debitis ullam tempore aperiam sit qui consequatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 18, 10, 13, 19, 725, DateTimeKind.Unspecified).AddTicks(8611), 5L, "Ea rerum mollitia aut qui itaque.", 30L, "Quos dignissimos ut ut nulla ducimus ex." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 4, 8, 0, 56, 372, DateTimeKind.Unspecified).AddTicks(405), "Quasi a dicta qui est quod et voluptatem.\nMaiores laudantium et rerum molestiae voluptatum.\nAmet rerum suscipit fugiat autem tempora quas aut.\nExpedita accusantium placeat ea iure praesentium aspernatur dolorum iusto aliquid.", true, 42L, "Officiis laudantium eligendi fugiat sapiente eum ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 23, 12, 898, DateTimeKind.Unspecified).AddTicks(3916), 5L, "Maxime perferendis et voluptas voluptas blanditiis beatae itaque aperiam.", 4L, "Eos consequatur velit vero distinctio non incidunt ut eius." });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { new DateTime(2021, 9, 24, 8, 33, 0, 415, DateTimeKind.Unspecified).AddTicks(7192), 3L, new DateTime(2022, 1, 5, 22, 15, 48, 575, DateTimeKind.Unspecified).AddTicks(6472), 62L, new DateTime(2020, 1, 30, 1, 31, 50, 280, DateTimeKind.Unspecified).AddTicks(9574), new DateTime(2021, 12, 12, 15, 15, 31, 178, DateTimeKind.Unspecified).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 8, 27, 17, 34, 16, 686, DateTimeKind.Unspecified).AddTicks(2118), 2L, null, 69L, new DateTime(2019, 4, 7, 10, 4, 46, 826, DateTimeKind.Unspecified).AddTicks(6111), new DateTime(2021, 10, 28, 18, 16, 40, 334, DateTimeKind.Unspecified).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 5, 16, 12, 12, 8, 188, DateTimeKind.Unspecified).AddTicks(9897), 5L, new DateTime(2022, 1, 5, 11, 0, 5, 718, DateTimeKind.Unspecified).AddTicks(6490), 27L, new DateTime(2019, 4, 25, 3, 59, 37, 662, DateTimeKind.Unspecified).AddTicks(3554), new DateTime(2021, 4, 25, 0, 35, 53, 321, DateTimeKind.Unspecified).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 10, 31, 22, 1, 37, 689, DateTimeKind.Unspecified).AddTicks(5359), 1L, new DateTime(2022, 2, 1, 14, 34, 43, 378, DateTimeKind.Unspecified).AddTicks(1561), 67L, new DateTime(2019, 8, 19, 17, 44, 46, 658, DateTimeKind.Unspecified).AddTicks(918), new DateTime(2021, 4, 16, 18, 25, 11, 992, DateTimeKind.Unspecified).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2022, 1, 27, 16, 47, 33, 923, DateTimeKind.Unspecified).AddTicks(583), 5L, new DateTime(2022, 1, 23, 12, 31, 35, 639, DateTimeKind.Unspecified).AddTicks(4674), 35L, new DateTime(2019, 8, 13, 6, 6, 28, 880, DateTimeKind.Unspecified).AddTicks(3793), new DateTime(2021, 4, 18, 17, 26, 31, 11, DateTimeKind.Unspecified).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2022, 1, 5, 3, 27, 29, 296, DateTimeKind.Unspecified).AddTicks(8334), new DateTime(2022, 1, 30, 10, 16, 45, 196, DateTimeKind.Unspecified).AddTicks(5632), 9L, new DateTime(2019, 2, 13, 19, 51, 19, 928, DateTimeKind.Unspecified).AddTicks(738), new DateTime(2021, 11, 18, 16, 32, 53, 683, DateTimeKind.Unspecified).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 5, 27, 21, 17, 9, 452, DateTimeKind.Unspecified).AddTicks(7098), new DateTime(2022, 1, 9, 8, 13, 34, 718, DateTimeKind.Unspecified).AddTicks(9636), 76L, new DateTime(2019, 10, 9, 20, 17, 22, 390, DateTimeKind.Unspecified).AddTicks(885), new DateTime(2021, 1, 25, 16, 38, 22, 53, DateTimeKind.Unspecified).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2022, 1, 31, 21, 26, 51, 827, DateTimeKind.Unspecified).AddTicks(8252), new DateTime(2022, 1, 7, 12, 42, 8, 83, DateTimeKind.Unspecified).AddTicks(1103), 5L, new DateTime(2020, 1, 22, 18, 37, 0, 498, DateTimeKind.Unspecified).AddTicks(1863), new DateTime(2021, 6, 9, 17, 8, 42, 879, DateTimeKind.Unspecified).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 9, 24, 8, 2, 52, 357, DateTimeKind.Unspecified).AddTicks(5310), new DateTime(2022, 1, 18, 20, 26, 49, 817, DateTimeKind.Unspecified).AddTicks(5079), 48L, new DateTime(2019, 5, 17, 8, 55, 4, 105, DateTimeKind.Unspecified).AddTicks(7840), new DateTime(2021, 3, 5, 5, 24, 18, 513, DateTimeKind.Unspecified).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 9, 22, 4, 17, 16, 234, DateTimeKind.Unspecified).AddTicks(9686), new DateTime(2022, 1, 6, 1, 58, 44, 374, DateTimeKind.Unspecified).AddTicks(3557), 38L, new DateTime(2019, 8, 8, 3, 43, 38, 530, DateTimeKind.Unspecified).AddTicks(1605), new DateTime(2021, 2, 15, 13, 16, 46, 651, DateTimeKind.Unspecified).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 7, 17, 0, 36, 1, 898, DateTimeKind.Unspecified).AddTicks(7555), 4L, null, 63L, new DateTime(2019, 7, 16, 15, 58, 47, 536, DateTimeKind.Unspecified).AddTicks(3952), new DateTime(2021, 11, 29, 15, 59, 47, 828, DateTimeKind.Unspecified).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 2, 28, 15, 8, 40, 294, DateTimeKind.Unspecified).AddTicks(4473), 2L, new DateTime(2022, 1, 20, 9, 21, 30, 917, DateTimeKind.Unspecified).AddTicks(9382), 29L, new DateTime(2019, 10, 17, 18, 38, 44, 154, DateTimeKind.Unspecified).AddTicks(1922), new DateTime(2021, 1, 7, 18, 40, 1, 590, DateTimeKind.Unspecified).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 5, 12, 1, 58, 30, 518, DateTimeKind.Unspecified).AddTicks(7479), new DateTime(2022, 1, 25, 1, 57, 52, 396, DateTimeKind.Unspecified).AddTicks(4843), 17L, new DateTime(2019, 6, 4, 23, 6, 42, 783, DateTimeKind.Unspecified).AddTicks(9467), new DateTime(2021, 12, 1, 13, 26, 42, 351, DateTimeKind.Unspecified).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 7, 6, 21, 0, 6, 758, DateTimeKind.Unspecified).AddTicks(5984), 2L, new DateTime(2022, 1, 28, 10, 45, 44, 644, DateTimeKind.Unspecified).AddTicks(2203), 55L, new DateTime(2019, 11, 23, 22, 58, 16, 285, DateTimeKind.Unspecified).AddTicks(2252), new DateTime(2021, 11, 26, 11, 52, 45, 245, DateTimeKind.Unspecified).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 2, 20, 13, 49, 55, 978, DateTimeKind.Unspecified).AddTicks(1268), 3L, new DateTime(2022, 1, 30, 21, 7, 54, 588, DateTimeKind.Unspecified).AddTicks(6904), 13L, new DateTime(2019, 8, 22, 2, 20, 20, 432, DateTimeKind.Unspecified).AddTicks(2228), new DateTime(2021, 11, 3, 15, 40, 22, 182, DateTimeKind.Unspecified).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 12, 11, 4, 14, 52, 140, DateTimeKind.Unspecified).AddTicks(5983), 1L, new DateTime(2022, 1, 8, 22, 57, 6, 439, DateTimeKind.Unspecified).AddTicks(9392), 62L, new DateTime(2019, 9, 14, 10, 30, 10, 103, DateTimeKind.Unspecified).AddTicks(4), new DateTime(2021, 1, 4, 15, 34, 33, 879, DateTimeKind.Unspecified).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 9, 27, 2, 58, 53, 389, DateTimeKind.Unspecified).AddTicks(2217), 5L, new DateTime(2022, 1, 22, 10, 57, 50, 839, DateTimeKind.Unspecified).AddTicks(8392), 36L, new DateTime(2019, 3, 18, 20, 21, 44, 216, DateTimeKind.Unspecified).AddTicks(8720), new DateTime(2021, 3, 26, 14, 28, 2, 689, DateTimeKind.Unspecified).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 47L, new DateTime(2021, 6, 18, 12, 2, 7, 836, DateTimeKind.Unspecified).AddTicks(5426), new DateTime(2022, 1, 29, 3, 57, 21, 82, DateTimeKind.Unspecified).AddTicks(6094), 37L, new DateTime(2019, 2, 10, 21, 25, 44, 799, DateTimeKind.Unspecified).AddTicks(196), new DateTime(2021, 7, 5, 14, 12, 48, 87, DateTimeKind.Unspecified).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 7, 28, 7, 37, 18, 187, DateTimeKind.Unspecified).AddTicks(8593), 1L, new DateTime(2022, 1, 22, 11, 30, 28, 385, DateTimeKind.Unspecified).AddTicks(9312), 33L, new DateTime(2019, 5, 9, 4, 17, 20, 308, DateTimeKind.Unspecified).AddTicks(4529), new DateTime(2021, 1, 12, 0, 59, 53, 791, DateTimeKind.Unspecified).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 8, 26, 16, 54, 32, 529, DateTimeKind.Unspecified).AddTicks(4382), 4L, new DateTime(2022, 1, 6, 10, 13, 40, 172, DateTimeKind.Unspecified).AddTicks(990), 67L, new DateTime(2019, 8, 13, 5, 34, 13, 708, DateTimeKind.Unspecified).AddTicks(143), new DateTime(2021, 10, 21, 6, 14, 25, 500, DateTimeKind.Unspecified).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2022, 1, 27, 10, 54, 53, 759, DateTimeKind.Unspecified).AddTicks(4075), new DateTime(2022, 1, 15, 21, 5, 52, 329, DateTimeKind.Unspecified).AddTicks(5667), 65L, new DateTime(2019, 5, 1, 11, 24, 13, 649, DateTimeKind.Unspecified).AddTicks(5609), new DateTime(2021, 9, 18, 6, 15, 23, 238, DateTimeKind.Unspecified).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 2, 24, 5, 37, 31, 677, DateTimeKind.Unspecified).AddTicks(5702), new DateTime(2022, 1, 29, 3, 40, 55, 204, DateTimeKind.Unspecified).AddTicks(7136), 64L, new DateTime(2020, 1, 29, 8, 28, 23, 986, DateTimeKind.Unspecified).AddTicks(1583), new DateTime(2021, 8, 1, 22, 45, 59, 166, DateTimeKind.Unspecified).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 8, 9, 0, 26, 7, 705, DateTimeKind.Unspecified).AddTicks(3980), 4L, new DateTime(2022, 1, 13, 8, 2, 34, 20, DateTimeKind.Unspecified).AddTicks(2335), 63L, new DateTime(2019, 11, 10, 12, 39, 13, 598, DateTimeKind.Unspecified).AddTicks(1584), new DateTime(2021, 8, 16, 6, 4, 45, 667, DateTimeKind.Unspecified).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 12, 4, 22, 24, 20, 942, DateTimeKind.Unspecified).AddTicks(1301), new DateTime(2022, 1, 1, 10, 9, 34, 685, DateTimeKind.Unspecified).AddTicks(3999), 26L, new DateTime(2019, 12, 24, 11, 20, 14, 218, DateTimeKind.Unspecified).AddTicks(7934), new DateTime(2021, 2, 26, 1, 25, 52, 454, DateTimeKind.Unspecified).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 2, 23, 12, 55, 55, 909, DateTimeKind.Unspecified).AddTicks(9623), 4L, new DateTime(2022, 1, 29, 18, 46, 1, 250, DateTimeKind.Unspecified).AddTicks(7956), 21L, new DateTime(2019, 4, 30, 6, 7, 20, 297, DateTimeKind.Unspecified).AddTicks(5215), new DateTime(2021, 6, 11, 23, 1, 49, 877, DateTimeKind.Unspecified).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 5, 27, 4, 55, 42, 899, DateTimeKind.Unspecified).AddTicks(8270), 2L, new DateTime(2022, 1, 12, 14, 34, 21, 637, DateTimeKind.Unspecified).AddTicks(2964), 68L, new DateTime(2019, 12, 7, 16, 1, 22, 712, DateTimeKind.Unspecified).AddTicks(573), new DateTime(2021, 8, 28, 10, 55, 36, 286, DateTimeKind.Unspecified).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 2, 7, 9, 41, 25, 980, DateTimeKind.Unspecified).AddTicks(5776), 2L, new DateTime(2022, 1, 10, 10, 35, 56, 38, DateTimeKind.Unspecified).AddTicks(5211), 65L, new DateTime(2019, 4, 30, 1, 1, 17, 747, DateTimeKind.Unspecified).AddTicks(1425), new DateTime(2021, 3, 26, 3, 2, 11, 765, DateTimeKind.Unspecified).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 5, 21, 4, 37, 46, 439, DateTimeKind.Unspecified).AddTicks(388), 4L, new DateTime(2022, 1, 14, 15, 32, 35, 476, DateTimeKind.Unspecified).AddTicks(4040), 80L, new DateTime(2019, 2, 10, 8, 45, 36, 787, DateTimeKind.Unspecified).AddTicks(4769), new DateTime(2021, 12, 24, 17, 34, 58, 964, DateTimeKind.Unspecified).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 46L, new DateTime(2021, 2, 8, 12, 10, 53, 142, DateTimeKind.Unspecified).AddTicks(822), 5L, new DateTime(2022, 1, 18, 2, 12, 36, 603, DateTimeKind.Unspecified).AddTicks(3564), 69L, new DateTime(2019, 11, 27, 5, 17, 39, 422, DateTimeKind.Unspecified).AddTicks(369), new DateTime(2021, 9, 20, 1, 24, 13, 120, DateTimeKind.Unspecified).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 10, 22, 20, 18, 16, 417, DateTimeKind.Unspecified).AddTicks(5162), 5L, new DateTime(2022, 1, 26, 11, 39, 25, 590, DateTimeKind.Unspecified).AddTicks(5010), 74L, new DateTime(2019, 2, 4, 6, 18, 17, 80, DateTimeKind.Unspecified).AddTicks(9238), new DateTime(2021, 6, 12, 5, 40, 12, 703, DateTimeKind.Unspecified).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 2L, new DateTime(2021, 2, 15, 1, 46, 1, 378, DateTimeKind.Unspecified).AddTicks(2525), 4L, null, 7L, new DateTime(2019, 3, 9, 12, 33, 31, 301, DateTimeKind.Unspecified).AddTicks(9662), new DateTime(2021, 4, 30, 0, 48, 42, 905, DateTimeKind.Unspecified).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 11, 30, 5, 18, 27, 977, DateTimeKind.Unspecified).AddTicks(9595), 1L, null, 64L, new DateTime(2019, 12, 30, 14, 8, 3, 875, DateTimeKind.Unspecified).AddTicks(4250), new DateTime(2021, 11, 30, 16, 45, 6, 497, DateTimeKind.Unspecified).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 16L, new DateTime(2021, 3, 5, 11, 38, 3, 459, DateTimeKind.Unspecified).AddTicks(3432), 5L, new DateTime(2022, 1, 21, 13, 20, 56, 818, DateTimeKind.Unspecified).AddTicks(7401), 36L, new DateTime(2019, 3, 8, 14, 59, 36, 714, DateTimeKind.Unspecified).AddTicks(9774), new DateTime(2021, 8, 29, 14, 5, 56, 989, DateTimeKind.Unspecified).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 2L, new DateTime(2022, 1, 8, 17, 48, 28, 146, DateTimeKind.Unspecified).AddTicks(9730), 3L, new DateTime(2022, 1, 11, 16, 6, 13, 430, DateTimeKind.Unspecified).AddTicks(138), 75L, new DateTime(2019, 10, 25, 13, 21, 46, 241, DateTimeKind.Unspecified).AddTicks(4051), new DateTime(2021, 4, 25, 4, 49, 30, 456, DateTimeKind.Unspecified).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 44L, new DateTime(2021, 12, 23, 22, 28, 35, 655, DateTimeKind.Unspecified).AddTicks(3735), 4L, new DateTime(2022, 1, 31, 2, 38, 54, 94, DateTimeKind.Unspecified).AddTicks(2576), 59L, new DateTime(2020, 1, 30, 4, 54, 22, 20, DateTimeKind.Unspecified).AddTicks(3220), new DateTime(2021, 2, 23, 12, 20, 38, 570, DateTimeKind.Unspecified).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 11, 17, 20, 32, 22, 868, DateTimeKind.Unspecified).AddTicks(2865), 1L, new DateTime(2022, 1, 24, 9, 13, 36, 179, DateTimeKind.Unspecified).AddTicks(9779), 78L, new DateTime(2019, 2, 7, 15, 57, 6, 587, DateTimeKind.Unspecified).AddTicks(1539), new DateTime(2021, 7, 28, 0, 43, 36, 385, DateTimeKind.Unspecified).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 8, 12, 23, 11, 26, 881, DateTimeKind.Unspecified).AddTicks(2592), 5L, new DateTime(2022, 1, 17, 17, 42, 32, 253, DateTimeKind.Unspecified).AddTicks(8720), 16L, new DateTime(2019, 10, 20, 16, 38, 15, 790, DateTimeKind.Unspecified).AddTicks(6197), new DateTime(2021, 8, 15, 22, 1, 17, 994, DateTimeKind.Unspecified).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 12, 2, 20, 18, 0, 198, DateTimeKind.Unspecified).AddTicks(508), new DateTime(2022, 1, 25, 8, 43, 21, 5, DateTimeKind.Unspecified).AddTicks(1516), 61L, new DateTime(2019, 7, 25, 1, 57, 45, 520, DateTimeKind.Unspecified).AddTicks(783), new DateTime(2021, 3, 22, 16, 23, 32, 443, DateTimeKind.Unspecified).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 44L, new DateTime(2021, 11, 25, 8, 47, 8, 242, DateTimeKind.Unspecified).AddTicks(7846), new DateTime(2022, 2, 1, 18, 51, 12, 733, DateTimeKind.Unspecified).AddTicks(9181), 58L, new DateTime(2019, 10, 1, 8, 44, 25, 741, DateTimeKind.Unspecified).AddTicks(3525), new DateTime(2021, 2, 24, 23, 13, 2, 469, DateTimeKind.Unspecified).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 10, 9, 21, 22, 12, 897, DateTimeKind.Unspecified).AddTicks(4531), 2L, new DateTime(2022, 1, 26, 22, 4, 55, 432, DateTimeKind.Unspecified).AddTicks(4184), 68L, new DateTime(2019, 2, 14, 1, 45, 31, 433, DateTimeKind.Unspecified).AddTicks(116), new DateTime(2021, 7, 14, 9, 44, 23, 744, DateTimeKind.Unspecified).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 4, 5, 3, 43, 24, 816, DateTimeKind.Unspecified).AddTicks(2940), 4L, new DateTime(2022, 1, 23, 8, 7, 39, 610, DateTimeKind.Unspecified).AddTicks(9318), 67L, new DateTime(2019, 12, 8, 23, 30, 19, 10, DateTimeKind.Unspecified).AddTicks(2629), new DateTime(2021, 2, 15, 13, 43, 22, 304, DateTimeKind.Unspecified).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 11, 8, 6, 44, 19, 648, DateTimeKind.Unspecified).AddTicks(6309), 2L, new DateTime(2022, 1, 30, 18, 30, 45, 760, DateTimeKind.Unspecified).AddTicks(9710), 81L, new DateTime(2019, 12, 5, 5, 20, 37, 820, DateTimeKind.Unspecified).AddTicks(5463), new DateTime(2021, 6, 20, 9, 53, 55, 143, DateTimeKind.Unspecified).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 7, 4, 2, 59, 51, 593, DateTimeKind.Unspecified).AddTicks(4926), 2L, new DateTime(2022, 1, 21, 6, 46, 32, 584, DateTimeKind.Unspecified).AddTicks(6631), 41L, new DateTime(2019, 6, 25, 18, 34, 31, 172, DateTimeKind.Unspecified).AddTicks(3818), new DateTime(2021, 7, 25, 13, 47, 32, 250, DateTimeKind.Unspecified).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 5, 23, 5, 11, 31, 767, DateTimeKind.Unspecified).AddTicks(8652), 4L, new DateTime(2022, 1, 26, 1, 49, 1, 696, DateTimeKind.Unspecified).AddTicks(3652), 22L, new DateTime(2019, 10, 18, 12, 8, 37, 746, DateTimeKind.Unspecified).AddTicks(1560), new DateTime(2021, 5, 3, 6, 46, 42, 388, DateTimeKind.Unspecified).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 7, 29, 11, 30, 53, 189, DateTimeKind.Unspecified).AddTicks(153), 4L, new DateTime(2022, 1, 18, 12, 39, 48, 488, DateTimeKind.Unspecified).AddTicks(919), 48L, new DateTime(2019, 2, 24, 14, 46, 12, 707, DateTimeKind.Unspecified).AddTicks(4290), new DateTime(2021, 6, 12, 18, 51, 40, 612, DateTimeKind.Unspecified).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 2, 11, 18, 55, 45, 173, DateTimeKind.Unspecified).AddTicks(4383), 2L, new DateTime(2022, 1, 17, 9, 30, 40, 582, DateTimeKind.Unspecified).AddTicks(2675), 58L, new DateTime(2019, 9, 26, 9, 11, 26, 112, DateTimeKind.Unspecified).AddTicks(3671), new DateTime(2021, 3, 1, 17, 1, 18, 187, DateTimeKind.Unspecified).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 6, 5, 8, 41, 29, 656, DateTimeKind.Unspecified).AddTicks(472), 2L, new DateTime(2022, 1, 4, 18, 48, 53, 214, DateTimeKind.Unspecified).AddTicks(5783), 66L, new DateTime(2019, 12, 4, 15, 47, 3, 803, DateTimeKind.Unspecified).AddTicks(2576), new DateTime(2021, 7, 29, 22, 21, 44, 424, DateTimeKind.Unspecified).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 3, 10, 13, 45, 3, 404, DateTimeKind.Unspecified).AddTicks(9399), null, 7L, new DateTime(2019, 4, 30, 10, 12, 37, 302, DateTimeKind.Unspecified).AddTicks(5949), new DateTime(2021, 2, 11, 22, 12, 14, 30, DateTimeKind.Unspecified).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2022, 1, 25, 8, 58, 5, 660, DateTimeKind.Unspecified).AddTicks(5829), new DateTime(2022, 1, 22, 22, 37, 57, 834, DateTimeKind.Unspecified).AddTicks(585), 62L, new DateTime(2019, 5, 25, 21, 46, 14, 448, DateTimeKind.Unspecified).AddTicks(4357), new DateTime(2021, 3, 26, 19, 6, 9, 978, DateTimeKind.Unspecified).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 7, 3, 6, 10, 29, 649, DateTimeKind.Unspecified).AddTicks(6227), new DateTime(2022, 1, 5, 2, 7, 10, 468, DateTimeKind.Unspecified).AddTicks(5330), 80L, new DateTime(2019, 4, 17, 5, 44, 5, 374, DateTimeKind.Unspecified).AddTicks(1274), new DateTime(2021, 2, 13, 19, 48, 1, 107, DateTimeKind.Unspecified).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 12, 14, 15, 56, 48, 939, DateTimeKind.Unspecified).AddTicks(4926), 3L, new DateTime(2022, 1, 19, 8, 5, 40, 456, DateTimeKind.Unspecified).AddTicks(3175), 53L, new DateTime(2019, 12, 26, 12, 8, 5, 555, DateTimeKind.Unspecified).AddTicks(9061), new DateTime(2021, 10, 23, 19, 24, 21, 397, DateTimeKind.Unspecified).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 26L, new DateTime(2021, 10, 19, 5, 33, 15, 168, DateTimeKind.Unspecified).AddTicks(381), 3L, new DateTime(2022, 1, 28, 8, 10, 27, 6, DateTimeKind.Unspecified).AddTicks(7248), 58L, new DateTime(2019, 12, 29, 13, 3, 33, 205, DateTimeKind.Unspecified).AddTicks(2894), new DateTime(2021, 11, 20, 6, 53, 3, 348, DateTimeKind.Unspecified).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 9, 6, 7, 1, 56, 857, DateTimeKind.Unspecified).AddTicks(7834), 3L, new DateTime(2022, 1, 22, 23, 22, 38, 845, DateTimeKind.Unspecified).AddTicks(3074), 59L, new DateTime(2019, 5, 21, 20, 3, 38, 976, DateTimeKind.Unspecified).AddTicks(2079), new DateTime(2021, 8, 12, 14, 14, 20, 46, DateTimeKind.Unspecified).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 4, 25, 16, 30, 54, 528, DateTimeKind.Unspecified).AddTicks(7200), null, 46L, new DateTime(2019, 9, 11, 23, 19, 5, 302, DateTimeKind.Unspecified).AddTicks(4301), new DateTime(2021, 2, 5, 12, 49, 27, 639, DateTimeKind.Unspecified).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 26L, new DateTime(2022, 1, 15, 2, 5, 32, 765, DateTimeKind.Unspecified).AddTicks(2609), 4L, new DateTime(2022, 1, 31, 19, 43, 42, 934, DateTimeKind.Unspecified).AddTicks(2940), 55L, new DateTime(2019, 10, 14, 2, 20, 56, 784, DateTimeKind.Unspecified).AddTicks(273), new DateTime(2021, 7, 2, 23, 13, 40, 465, DateTimeKind.Unspecified).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 47L, new DateTime(2021, 12, 28, 23, 52, 3, 210, DateTimeKind.Unspecified).AddTicks(7935), 3L, new DateTime(2022, 1, 14, 6, 59, 30, 95, DateTimeKind.Unspecified).AddTicks(8354), 21L, new DateTime(2019, 5, 12, 4, 45, 39, 924, DateTimeKind.Unspecified).AddTicks(2198), new DateTime(2021, 7, 20, 22, 51, 5, 484, DateTimeKind.Unspecified).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 9, 16, 5, 36, 30, 299, DateTimeKind.Unspecified).AddTicks(9912), 3L, new DateTime(2022, 1, 4, 3, 33, 1, 946, DateTimeKind.Unspecified).AddTicks(1659), 23L, new DateTime(2019, 6, 10, 14, 23, 14, 479, DateTimeKind.Unspecified).AddTicks(6595), new DateTime(2021, 11, 2, 20, 43, 50, 199, DateTimeKind.Unspecified).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 7, 18, 19, 17, 31, 925, DateTimeKind.Unspecified).AddTicks(7958), 3L, null, 36L, new DateTime(2019, 10, 21, 14, 41, 13, 380, DateTimeKind.Unspecified).AddTicks(8287), new DateTime(2021, 3, 2, 10, 51, 40, 187, DateTimeKind.Unspecified).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2022, 1, 21, 0, 18, 42, 544, DateTimeKind.Unspecified).AddTicks(6662), 5L, new DateTime(2022, 1, 21, 6, 1, 31, 35, DateTimeKind.Unspecified).AddTicks(8470), 21L, new DateTime(2019, 11, 20, 23, 43, 32, 991, DateTimeKind.Unspecified).AddTicks(3117), new DateTime(2021, 1, 30, 13, 0, 6, 324, DateTimeKind.Unspecified).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 12, 10, 23, 37, 18, 435, DateTimeKind.Unspecified).AddTicks(9100), new DateTime(2022, 1, 26, 23, 21, 6, 852, DateTimeKind.Unspecified).AddTicks(5655), 79L, new DateTime(2019, 3, 26, 15, 27, 32, 943, DateTimeKind.Unspecified).AddTicks(216), new DateTime(2021, 8, 21, 17, 29, 29, 594, DateTimeKind.Unspecified).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2022, 1, 21, 1, 33, 19, 985, DateTimeKind.Unspecified).AddTicks(8823), 3L, new DateTime(2022, 1, 14, 15, 19, 23, 765, DateTimeKind.Unspecified).AddTicks(5500), 27L, new DateTime(2019, 7, 7, 4, 52, 3, 27, DateTimeKind.Unspecified).AddTicks(4729), new DateTime(2021, 3, 30, 8, 56, 59, 860, DateTimeKind.Unspecified).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 10, 16, 5, 28, 52, 606, DateTimeKind.Unspecified).AddTicks(2354), 4L, new DateTime(2022, 1, 31, 7, 48, 34, 692, DateTimeKind.Unspecified).AddTicks(961), 58L, new DateTime(2019, 2, 25, 7, 28, 14, 526, DateTimeKind.Unspecified).AddTicks(3943), new DateTime(2021, 8, 1, 19, 8, 15, 644, DateTimeKind.Unspecified).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 9, 6, 17, 41, 0, 241, DateTimeKind.Unspecified).AddTicks(2550), 2L, new DateTime(2022, 1, 12, 12, 40, 28, 466, DateTimeKind.Unspecified).AddTicks(686), 44L, new DateTime(2019, 12, 30, 23, 12, 4, 375, DateTimeKind.Unspecified).AddTicks(9261), new DateTime(2021, 11, 15, 9, 47, 28, 331, DateTimeKind.Unspecified).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 10, 9, 12, 41, 11, 459, DateTimeKind.Unspecified).AddTicks(4785), 1L, new DateTime(2022, 1, 17, 6, 7, 47, 454, DateTimeKind.Unspecified).AddTicks(3245), 9L, new DateTime(2020, 1, 19, 5, 10, 48, 906, DateTimeKind.Unspecified).AddTicks(4199), new DateTime(2021, 1, 24, 22, 3, 36, 618, DateTimeKind.Unspecified).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 2L, new DateTime(2021, 3, 18, 11, 52, 35, 373, DateTimeKind.Unspecified).AddTicks(1015), 1L, 51L, new DateTime(2019, 6, 6, 11, 20, 41, 695, DateTimeKind.Unspecified).AddTicks(4901), new DateTime(2021, 4, 4, 7, 46, 17, 333, DateTimeKind.Unspecified).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 16L, new DateTime(2021, 12, 11, 5, 25, 49, 966, DateTimeKind.Unspecified).AddTicks(2282), 4L, new DateTime(2022, 1, 2, 22, 46, 47, 472, DateTimeKind.Unspecified).AddTicks(5458), 40L, new DateTime(2019, 6, 25, 3, 34, 38, 750, DateTimeKind.Unspecified).AddTicks(2677), new DateTime(2021, 8, 8, 1, 16, 53, 363, DateTimeKind.Unspecified).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2022, 1, 15, 0, 26, 50, 486, DateTimeKind.Unspecified).AddTicks(9805), 3L, new DateTime(2022, 1, 13, 3, 22, 23, 715, DateTimeKind.Unspecified).AddTicks(1071), 56L, new DateTime(2019, 3, 13, 9, 10, 35, 972, DateTimeKind.Unspecified).AddTicks(9891), new DateTime(2021, 7, 7, 11, 35, 20, 143, DateTimeKind.Unspecified).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 4, 1, 1, 53, 39, 643, DateTimeKind.Unspecified).AddTicks(5200), 3L, new DateTime(2022, 1, 26, 13, 54, 48, 320, DateTimeKind.Unspecified).AddTicks(6169), 66L, new DateTime(2019, 3, 16, 10, 34, 44, 436, DateTimeKind.Unspecified).AddTicks(4150), new DateTime(2021, 1, 8, 7, 12, 51, 942, DateTimeKind.Unspecified).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 14L, new DateTime(2021, 8, 15, 7, 59, 3, 235, DateTimeKind.Unspecified).AddTicks(4584), 2L, null, 56L, new DateTime(2019, 7, 30, 20, 16, 45, 717, DateTimeKind.Unspecified).AddTicks(2638), new DateTime(2021, 8, 19, 10, 15, 54, 666, DateTimeKind.Unspecified).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 7, 12, 1, 25, 2, 474, DateTimeKind.Unspecified).AddTicks(4385), 1L, 18L, new DateTime(2019, 4, 22, 10, 25, 55, 95, DateTimeKind.Unspecified).AddTicks(7333), new DateTime(2021, 6, 25, 23, 41, 45, 64, DateTimeKind.Unspecified).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 2, 12, 3, 47, 28, 643, DateTimeKind.Unspecified).AddTicks(7384), 4L, new DateTime(2022, 1, 25, 15, 49, 57, 415, DateTimeKind.Unspecified).AddTicks(9149), 53L, new DateTime(2019, 10, 15, 5, 31, 36, 166, DateTimeKind.Unspecified).AddTicks(4829), new DateTime(2021, 5, 13, 15, 20, 56, 867, DateTimeKind.Unspecified).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 4, 16, 22, 44, 33, 22, DateTimeKind.Unspecified).AddTicks(4201), 1L, new DateTime(2022, 1, 6, 16, 29, 33, 259, DateTimeKind.Unspecified).AddTicks(6778), 58L, new DateTime(2019, 5, 13, 16, 1, 44, 474, DateTimeKind.Unspecified).AddTicks(6027), new DateTime(2021, 6, 3, 21, 2, 29, 480, DateTimeKind.Unspecified).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 11, 18, 1, 33, 19, 733, DateTimeKind.Unspecified).AddTicks(7412), 5L, new DateTime(2022, 1, 21, 14, 58, 9, 978, DateTimeKind.Unspecified).AddTicks(3326), 62L, new DateTime(2020, 1, 23, 4, 3, 50, 985, DateTimeKind.Unspecified).AddTicks(8256), new DateTime(2021, 3, 22, 7, 28, 37, 377, DateTimeKind.Unspecified).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 5, 29, 20, 38, 31, 885, DateTimeKind.Unspecified).AddTicks(1546), new DateTime(2022, 1, 21, 21, 5, 42, 145, DateTimeKind.Unspecified).AddTicks(9969), 43L, new DateTime(2019, 11, 13, 19, 44, 26, 269, DateTimeKind.Unspecified).AddTicks(2431), new DateTime(2021, 11, 29, 19, 27, 37, 485, DateTimeKind.Unspecified).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 3, 20, 18, 30, 47, 71, DateTimeKind.Unspecified).AddTicks(7666), 1L, new DateTime(2022, 1, 3, 18, 37, 33, 80, DateTimeKind.Unspecified).AddTicks(1459), 52L, new DateTime(2019, 3, 7, 17, 23, 5, 261, DateTimeKind.Unspecified).AddTicks(8107), new DateTime(2021, 3, 28, 19, 52, 2, 381, DateTimeKind.Unspecified).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2022, 1, 3, 20, 13, 50, 493, DateTimeKind.Unspecified).AddTicks(9535), 4L, new DateTime(2022, 1, 10, 5, 18, 49, 145, DateTimeKind.Unspecified).AddTicks(1350), 26L, new DateTime(2019, 3, 2, 14, 52, 5, 486, DateTimeKind.Unspecified).AddTicks(7669), new DateTime(2021, 9, 10, 20, 48, 35, 877, DateTimeKind.Unspecified).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 7, 16, 20, 47, 1, 613, DateTimeKind.Unspecified).AddTicks(9933), 4L, new DateTime(2022, 2, 1, 13, 46, 26, 619, DateTimeKind.Unspecified).AddTicks(4554), 37L, new DateTime(2019, 9, 2, 10, 11, 44, 81, DateTimeKind.Unspecified).AddTicks(8013), new DateTime(2021, 6, 1, 8, 4, 46, 707, DateTimeKind.Unspecified).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 11, 18, 16, 31, 59, 890, DateTimeKind.Unspecified).AddTicks(5060), new DateTime(2022, 1, 24, 5, 41, 55, 225, DateTimeKind.Unspecified).AddTicks(4871), 48L, new DateTime(2019, 8, 18, 9, 50, 35, 137, DateTimeKind.Unspecified).AddTicks(1647), new DateTime(2021, 7, 25, 8, 8, 46, 509, DateTimeKind.Unspecified).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 9, 9, 3, 53, 59, 813, DateTimeKind.Unspecified).AddTicks(6949), 4L, new DateTime(2022, 1, 3, 10, 41, 0, 870, DateTimeKind.Unspecified).AddTicks(2213), 51L, new DateTime(2019, 4, 2, 12, 30, 50, 306, DateTimeKind.Unspecified).AddTicks(5408), new DateTime(2021, 7, 1, 17, 30, 38, 128, DateTimeKind.Unspecified).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 3, 6, 23, 5, 43, 642, DateTimeKind.Unspecified).AddTicks(6460), new DateTime(2022, 1, 24, 17, 0, 51, 802, DateTimeKind.Unspecified).AddTicks(7785), 8L, new DateTime(2019, 12, 29, 7, 40, 52, 112, DateTimeKind.Unspecified).AddTicks(5490), new DateTime(2021, 10, 10, 0, 15, 29, 637, DateTimeKind.Unspecified).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 8, 18, 22, 31, 54, 577, DateTimeKind.Unspecified).AddTicks(63), 1L, null, 29L, new DateTime(2019, 10, 27, 6, 13, 20, 326, DateTimeKind.Unspecified).AddTicks(1462), new DateTime(2021, 7, 28, 23, 50, 45, 596, DateTimeKind.Unspecified).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 47L, new DateTime(2021, 10, 2, 5, 31, 2, 316, DateTimeKind.Unspecified).AddTicks(3748), 5L, new DateTime(2022, 2, 1, 17, 24, 2, 301, DateTimeKind.Unspecified).AddTicks(4530), 27L, new DateTime(2019, 8, 7, 23, 29, 48, 809, DateTimeKind.Unspecified).AddTicks(7024), new DateTime(2021, 7, 16, 12, 44, 5, 809, DateTimeKind.Unspecified).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 4, 14, 9, 12, 14, 614, DateTimeKind.Unspecified).AddTicks(152), 3L, null, 6L, new DateTime(2019, 11, 22, 16, 17, 22, 215, DateTimeKind.Unspecified).AddTicks(8052), new DateTime(2021, 1, 30, 20, 53, 31, 702, DateTimeKind.Unspecified).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 9, 18, 14, 41, 58, 592, DateTimeKind.Unspecified).AddTicks(6535), 1L, new DateTime(2022, 1, 5, 18, 52, 1, 48, DateTimeKind.Unspecified).AddTicks(6430), 52L, new DateTime(2019, 6, 7, 4, 36, 12, 773, DateTimeKind.Unspecified).AddTicks(1216), new DateTime(2021, 8, 3, 7, 15, 37, 191, DateTimeKind.Unspecified).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 8, 4, 15, 32, 57, 745, DateTimeKind.Unspecified).AddTicks(2432), 4L, new DateTime(2022, 1, 18, 3, 51, 14, 297, DateTimeKind.Unspecified).AddTicks(5940), 36L, new DateTime(2019, 3, 24, 18, 47, 16, 239, DateTimeKind.Unspecified).AddTicks(6868), new DateTime(2021, 10, 26, 0, 20, 45, 433, DateTimeKind.Unspecified).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 4, 25, 11, 21, 8, 221, DateTimeKind.Unspecified).AddTicks(5583), 3L, null, 24L, new DateTime(2019, 9, 17, 5, 31, 45, 103, DateTimeKind.Unspecified).AddTicks(1071), new DateTime(2021, 8, 14, 19, 53, 28, 877, DateTimeKind.Unspecified).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 7L, new DateTime(2021, 11, 17, 13, 26, 21, 567, DateTimeKind.Unspecified).AddTicks(1699), 4L, new DateTime(2022, 1, 30, 12, 58, 14, 809, DateTimeKind.Unspecified).AddTicks(6716), 57L, new DateTime(2019, 3, 15, 10, 36, 37, 39, DateTimeKind.Unspecified).AddTicks(3850), new DateTime(2021, 5, 28, 15, 50, 15, 691, DateTimeKind.Unspecified).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 3, 26, 12, 27, 9, 543, DateTimeKind.Unspecified).AddTicks(8677), 4L, new DateTime(2022, 1, 13, 21, 37, 21, 475, DateTimeKind.Unspecified).AddTicks(3859), 28L, new DateTime(2019, 12, 24, 10, 4, 32, 706, DateTimeKind.Unspecified).AddTicks(5106), new DateTime(2021, 11, 26, 5, 53, 2, 19, DateTimeKind.Unspecified).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 5, 1, 6, 21, 33, 753, DateTimeKind.Unspecified).AddTicks(4841), 3L, null, 39L, new DateTime(2019, 8, 20, 3, 34, 58, 940, DateTimeKind.Unspecified).AddTicks(7838), new DateTime(2021, 8, 14, 11, 25, 32, 343, DateTimeKind.Unspecified).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 9, 17, 12, 51, 31, 265, DateTimeKind.Unspecified).AddTicks(9741), 1L, new DateTime(2022, 1, 21, 4, 36, 19, 23, DateTimeKind.Unspecified).AddTicks(9829), 32L, new DateTime(2019, 9, 6, 13, 25, 50, 369, DateTimeKind.Unspecified).AddTicks(5519), new DateTime(2021, 6, 27, 0, 23, 56, 600, DateTimeKind.Unspecified).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 12, 2, 19, 43, 19, 599, DateTimeKind.Unspecified).AddTicks(1963), 2L, new DateTime(2022, 1, 29, 19, 26, 2, 720, DateTimeKind.Unspecified).AddTicks(9334), 58L, new DateTime(2019, 12, 31, 14, 15, 15, 957, DateTimeKind.Unspecified).AddTicks(2900), new DateTime(2021, 5, 18, 1, 33, 12, 682, DateTimeKind.Unspecified).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2022, 1, 17, 0, 30, 33, 88, DateTimeKind.Unspecified).AddTicks(3079), 2L, new DateTime(2022, 1, 10, 17, 58, 52, 349, DateTimeKind.Unspecified).AddTicks(5019), 60L, new DateTime(2019, 12, 12, 18, 33, 47, 851, DateTimeKind.Unspecified).AddTicks(5546), new DateTime(2021, 4, 30, 7, 8, 55, 274, DateTimeKind.Unspecified).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 9, 4, 2, 42, 23, 60, DateTimeKind.Unspecified).AddTicks(8974), 5L, null, 35L, new DateTime(2019, 3, 21, 10, 45, 0, 605, DateTimeKind.Unspecified).AddTicks(2719), new DateTime(2021, 3, 30, 6, 24, 54, 924, DateTimeKind.Unspecified).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 5, 14, 14, 53, 5, 616, DateTimeKind.Unspecified).AddTicks(3543), new DateTime(2022, 2, 1, 5, 21, 51, 544, DateTimeKind.Unspecified).AddTicks(3871), 6L, new DateTime(2019, 2, 21, 8, 40, 32, 567, DateTimeKind.Unspecified).AddTicks(3606), new DateTime(2021, 3, 2, 5, 3, 26, 426, DateTimeKind.Unspecified).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 5, 3, 5, 53, 41, 757, DateTimeKind.Unspecified).AddTicks(3622), 1L, new DateTime(2022, 1, 28, 8, 50, 41, 911, DateTimeKind.Unspecified).AddTicks(5110), 37L, new DateTime(2019, 5, 15, 6, 37, 46, 585, DateTimeKind.Unspecified).AddTicks(5444), new DateTime(2021, 1, 10, 16, 29, 30, 594, DateTimeKind.Unspecified).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 5, 31, 9, 52, 11, 595, DateTimeKind.Unspecified).AddTicks(4225), new DateTime(2022, 1, 31, 5, 17, 12, 500, DateTimeKind.Unspecified).AddTicks(1954), 40L, new DateTime(2019, 9, 28, 1, 52, 4, 463, DateTimeKind.Unspecified).AddTicks(5896), new DateTime(2021, 6, 13, 18, 56, 16, 826, DateTimeKind.Unspecified).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 5, 31, 13, 31, 47, 502, DateTimeKind.Unspecified).AddTicks(6381), 4L, new DateTime(2022, 1, 24, 20, 2, 31, 215, DateTimeKind.Unspecified).AddTicks(3202), 16L, new DateTime(2019, 11, 28, 19, 13, 2, 676, DateTimeKind.Unspecified).AddTicks(5621), new DateTime(2021, 8, 3, 8, 2, 17, 580, DateTimeKind.Unspecified).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2022, 1, 4, 3, 22, 6, 941, DateTimeKind.Unspecified).AddTicks(9935), new DateTime(2022, 1, 12, 10, 33, 24, 849, DateTimeKind.Unspecified).AddTicks(5604), 54L, new DateTime(2019, 9, 14, 1, 7, 56, 693, DateTimeKind.Unspecified).AddTicks(7215), new DateTime(2021, 6, 27, 17, 22, 35, 346, DateTimeKind.Unspecified).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 8, 30, 14, 24, 9, 840, DateTimeKind.Unspecified).AddTicks(5743), 4L, null, 41L, new DateTime(2020, 1, 4, 14, 9, 27, 298, DateTimeKind.Unspecified).AddTicks(4286), new DateTime(2021, 8, 1, 19, 43, 58, 977, DateTimeKind.Unspecified).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 8, 15, 21, 6, 13, 421, DateTimeKind.Unspecified).AddTicks(2648), 2L, new DateTime(2022, 1, 22, 0, 20, 54, 479, DateTimeKind.Unspecified).AddTicks(140), 44L, new DateTime(2019, 12, 29, 14, 52, 27, 470, DateTimeKind.Unspecified).AddTicks(1922), new DateTime(2021, 11, 14, 14, 35, 26, 91, DateTimeKind.Unspecified).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 50L, "Debitis rerum quia.\nVoluptatem enim hic voluptates modi corrupti voluptas voluptas.\nOdio minima nihil hic ducimus.\nAut sunt sint consequatur quibusdam odit quo.\nIllum minus veniam debitis architecto consectetur ea exercitationem ipsum voluptas.\nPariatur similique sequi beatae dignissimos ratione ad fugiat.", new DateTime(2021, 6, 5, 13, 3, 57, 833, DateTimeKind.Unspecified).AddTicks(7617), 31L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Sit sint et ea earum non animi ipsam.\nDolores quia itaque est voluptas.\nEt qui odit aspernatur modi animi asperiores at.\nArchitecto vero occaecati.", new DateTime(2021, 8, 5, 4, 58, 11, 558, DateTimeKind.Unspecified).AddTicks(8477), 4L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Et maxime enim deleniti recusandae incidunt et consequuntur.", new DateTime(2021, 3, 8, 9, 48, 26, 952, DateTimeKind.Unspecified).AddTicks(4244), 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 16L, "Molestias sit aut tempora numquam error molestiae.\nLaboriosam veritatis voluptates.\nVitae consequatur voluptas ducimus quo.\nAut enim consequatur voluptatem vel eum quia officiis.", new DateTime(2021, 5, 3, 9, 52, 26, 332, DateTimeKind.Unspecified).AddTicks(6590), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Similique quia perferendis.\nOmnis reprehenderit minima.\nSed sed ea quia sunt est voluptatem.\nQuibusdam dicta non eum aut adipisci ipsum corrupti et.\nSit nisi ut voluptas aut officia incidunt et.", new DateTime(2021, 11, 7, 4, 56, 54, 182, DateTimeKind.Unspecified).AddTicks(1601), 5L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 22L, "Ea mollitia aut neque et.\nVel natus quisquam quas.\nVoluptatibus tempora qui corporis quis.\nNon quis ipsa quis.\nLabore officiis incidunt illum aut assumenda molestiae reprehenderit et natus.", new DateTime(2021, 11, 18, 2, 55, 14, 893, DateTimeKind.Unspecified).AddTicks(5650), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Accusamus et et.", new DateTime(2022, 1, 22, 10, 8, 14, 621, DateTimeKind.Unspecified).AddTicks(9033), 4L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Dolor et ut est laudantium.\nRerum hic nihil ex labore recusandae quibusdam velit ipsa harum.\nCumque quod culpa voluptatem molestiae.\nQuis ratione expedita.\nDolores repudiandae ipsam voluptatum voluptas labore blanditiis adipisci.\nCulpa repellendus suscipit laborum omnis.", new DateTime(2021, 3, 29, 13, 44, 48, 294, DateTimeKind.Unspecified).AddTicks(2594), 5L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 16L, "Et et eum.", new DateTime(2021, 9, 3, 23, 50, 55, 21, DateTimeKind.Unspecified).AddTicks(5435), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Ea veritatis laudantium aut nostrum.\nEaque odit aut qui optio nisi alias.\nAb perspiciatis consequatur consequuntur qui assumenda eum et odio.", new DateTime(2021, 10, 25, 23, 52, 51, 625, DateTimeKind.Unspecified).AddTicks(552), 2L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 7L, "Velit omnis dolorem.", new DateTime(2021, 7, 27, 19, 17, 16, 380, DateTimeKind.Unspecified).AddTicks(5975), 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Voluptatem aliquam non quos aut qui autem.\nMolestiae sunt omnis placeat optio neque deserunt sunt.", new DateTime(2021, 9, 12, 2, 36, 49, 302, DateTimeKind.Unspecified).AddTicks(557), 4L, 14L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Ut a dicta.\nVoluptas officiis modi neque voluptates provident.", new DateTime(2021, 7, 10, 12, 36, 36, 782, DateTimeKind.Unspecified).AddTicks(7144), 5L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Enim maiores optio vero et.\nNemo enim porro reprehenderit.\nUnde ipsam nihil eveniet.\nEnim quaerat sit aliquam ea quas laborum quas quas voluptatem.", new DateTime(2021, 3, 25, 5, 10, 27, 236, DateTimeKind.Unspecified).AddTicks(486), 3L, 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 17L, "Perferendis consectetur necessitatibus.\nOptio ea quaerat illo est illum placeat qui.\nCum pariatur sed quidem exercitationem non perspiciatis perspiciatis.", new DateTime(2021, 9, 18, 2, 18, 28, 271, DateTimeKind.Unspecified).AddTicks(7368), 4L, 76L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Ut repellat veritatis maxime vero.\nSed provident consequuntur.", new DateTime(2021, 2, 20, 4, 46, 35, 98, DateTimeKind.Unspecified).AddTicks(103), 2L, 22L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Id officia possimus nesciunt eos dolorem velit reiciendis id incidunt.", new DateTime(2021, 5, 18, 7, 38, 19, 435, DateTimeKind.Unspecified).AddTicks(2439), 3L, 66L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 21L, "Quaerat quas consequatur.\nIllo qui quasi saepe esse odio qui est.", new DateTime(2021, 7, 6, 13, 41, 24, 534, DateTimeKind.Unspecified).AddTicks(6323), 1L, 32L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Optio ut aut numquam voluptas non consequuntur.\nPraesentium sint cupiditate.\nQuisquam qui accusamus est.\nEst rerum veniam voluptates voluptatem sint et maxime nihil nobis.", new DateTime(2021, 12, 2, 18, 40, 58, 468, DateTimeKind.Unspecified).AddTicks(6116), 2L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 23L, "Ut sit voluptates fugit quae.\nVoluptatum deserunt eaque consequuntur.\nConsequatur amet quisquam voluptatem vero cumque autem.\nHarum quaerat libero tempore eum.\nTotam et nulla odio.", new DateTime(2021, 4, 27, 15, 59, 4, 824, DateTimeKind.Unspecified).AddTicks(9757), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Aut a sunt tenetur unde rem eligendi officiis saepe.\nDolores natus cumque commodi eum rerum pariatur fugiat consequuntur consequatur.\nNisi vitae ut in.\nEt voluptatem id eveniet quia.\nTempora et sint eveniet consequuntur nihil temporibus.\nSimilique quibusdam dolor et.", new DateTime(2021, 8, 9, 8, 26, 1, 548, DateTimeKind.Unspecified).AddTicks(2263), 2L, 74L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Vel sint rerum a qui laudantium officiis.\nAutem ad voluptas ut ut repellat possimus.\nSuscipit quibusdam nulla non omnis molestiae quae delectus iusto iusto.\nNumquam quia libero quasi ratione perspiciatis inventore.", new DateTime(2021, 10, 27, 13, 0, 41, 624, DateTimeKind.Unspecified).AddTicks(4859), 5L, 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 22L, "Accusantium cupiditate ab.\nVoluptatem doloremque non dolor aut placeat in.", new DateTime(2021, 4, 21, 11, 47, 32, 763, DateTimeKind.Unspecified).AddTicks(2762), 4L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Cum cupiditate voluptatem ut distinctio minima.\nSed optio asperiores non deleniti et earum et.\nQuibusdam et labore vel provident facilis.\nEt dolor odit sunt explicabo libero.\nEt ad error eius minima maxime ipsum.\nConsequatur et nisi enim.", new DateTime(2021, 10, 15, 2, 41, 19, 937, DateTimeKind.Unspecified).AddTicks(2405), 2L, 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Molestias molestiae voluptas est unde in earum doloremque sed.", new DateTime(2021, 5, 19, 19, 10, 35, 947, DateTimeKind.Unspecified).AddTicks(9674), 3L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Amet magni recusandae repudiandae nulla distinctio quia.\nEst ut asperiores aperiam eius.\nQuis officia deleniti.\nVoluptas qui quod.", new DateTime(2021, 2, 5, 11, 43, 14, 453, DateTimeKind.Unspecified).AddTicks(6733), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Fuga molestiae doloremque vel.\nQui omnis odio et eum iure sed.", new DateTime(2021, 11, 23, 18, 39, 7, 516, DateTimeKind.Unspecified).AddTicks(4070), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Ut est aut placeat et rerum dolores.\nDoloremque autem sint eaque quia molestiae similique esse optio eum.", new DateTime(2021, 10, 12, 13, 54, 18, 814, DateTimeKind.Unspecified).AddTicks(6413), 3L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Laudantium quia explicabo vero dolorum qui quia.\nEos quia qui iste ut debitis.\nIure ipsam deserunt optio voluptatibus.", new DateTime(2021, 8, 17, 19, 53, 34, 420, DateTimeKind.Unspecified).AddTicks(18), 1L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Corrupti ut sunt et sunt incidunt veniam molestiae.\nDucimus unde rerum quia harum.\nIpsa quia aperiam rem aut dolor qui aut.\nEsse accusamus laborum blanditiis.", new DateTime(2021, 6, 15, 18, 29, 5, 668, DateTimeKind.Unspecified).AddTicks(6151), 1L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Voluptates rerum ut commodi vitae eius enim consequatur deserunt dolorem.\nCum enim veritatis enim aut eligendi qui maiores fuga.", new DateTime(2021, 9, 30, 2, 37, 37, 261, DateTimeKind.Unspecified).AddTicks(5220), 1L, 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 22L, "Dolorum dolorem assumenda nobis.", new DateTime(2021, 8, 26, 17, 8, 57, 525, DateTimeKind.Unspecified).AddTicks(5515), 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 46L, "Eos vel hic aliquam quod consequatur incidunt veniam reprehenderit.\nAnimi omnis ratione dolor et necessitatibus facilis mollitia.\nEt possimus natus ad eos.\nDignissimos ipsa et voluptate non aliquam fugiat.\nNon quod aut consectetur minus.", new DateTime(2021, 3, 31, 7, 59, 44, 959, DateTimeKind.Unspecified).AddTicks(1911), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Fuga quasi soluta maiores dolor.\nUt qui odit atque accusantium in sed.\nEt exercitationem voluptas.\nDebitis praesentium atque voluptas numquam.\nEaque voluptatem optio repudiandae quo qui aut.\nEst non labore provident voluptas illo quia debitis distinctio et.", new DateTime(2021, 12, 3, 13, 55, 10, 671, DateTimeKind.Unspecified).AddTicks(5719), 3L, 70L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Vitae officia vero.\nDelectus quos eos.\nAt veritatis rerum possimus eum ex aut sapiente cum.", new DateTime(2021, 3, 29, 8, 0, 14, 721, DateTimeKind.Unspecified).AddTicks(2103), 4L, 79L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 7L, "Ad velit repellat quibusdam ab eaque commodi.", new DateTime(2021, 6, 30, 1, 7, 18, 614, DateTimeKind.Unspecified).AddTicks(1453), 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Quis eligendi hic.\nEt vel cum.\nOdit consequatur ab nemo quia voluptas quia iure.\nId aliquam a inventore.\nRepudiandae delectus eligendi consequatur qui quos rerum.", new DateTime(2021, 7, 26, 18, 42, 24, 222, DateTimeKind.Unspecified).AddTicks(2402), 8L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 12L, "Voluptatibus nesciunt at ut totam dignissimos eum dolorem.\nHic corrupti qui enim amet qui cum earum laboriosam.\nEt cumque dolor maiores nihil aliquam natus sit possimus.\nVeniam vel temporibus.\nSunt adipisci incidunt ut adipisci.\nSint incidunt esse beatae perferendis sed vitae unde nemo.", new DateTime(2021, 3, 11, 20, 31, 48, 815, DateTimeKind.Unspecified).AddTicks(2425), 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 47L, "Aut sed quia molestiae veniam et quaerat architecto dolores unde.\nCumque iure sit asperiores.\nSit maxime unde ex fugiat quis.\nUt eius quia perferendis debitis ut quidem ratione.", new DateTime(2021, 12, 21, 18, 31, 26, 176, DateTimeKind.Unspecified).AddTicks(808), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Sint voluptates rerum.\nSequi minima non debitis et.\nCommodi ipsam porro et reprehenderit ut nostrum dicta.\nEt sed quia aut necessitatibus eum provident et.\nEius error ut et alias dignissimos.\nQuo nam aut cum consequatur quia.", new DateTime(2021, 6, 9, 15, 14, 31, 650, DateTimeKind.Unspecified).AddTicks(7392), 3L, 59L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Similique facere sunt pariatur suscipit molestiae quos at impedit.\nAsperiores officiis fuga dolor consequuntur distinctio itaque quisquam ullam.\nEnim et iste soluta consectetur.\nSoluta voluptas aut quos fuga labore.", new DateTime(2021, 6, 10, 1, 0, 44, 669, DateTimeKind.Unspecified).AddTicks(1888), 5L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 25L, "Quidem rerum molestias deserunt nihil aperiam tempore tempora.\nTempora quae iusto.\nOmnis aliquid magnam omnis repudiandae velit necessitatibus expedita non.\nDolorem maxime eius quia facere inventore repudiandae nulla.", new DateTime(2022, 1, 1, 5, 17, 25, 464, DateTimeKind.Unspecified).AddTicks(7600), 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Soluta hic cupiditate consequatur delectus aliquid blanditiis minima cum.\nEt rerum similique nesciunt sit qui possimus inventore.\nNecessitatibus laboriosam pariatur corrupti vero sint ipsum qui.\nSimilique quam iste tempore eligendi ducimus.", new DateTime(2021, 3, 16, 8, 6, 1, 244, DateTimeKind.Unspecified).AddTicks(4164), 4L, 79L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 21L, "Exercitationem necessitatibus quasi molestias enim et corrupti.\nEum accusantium aliquam dolorem vel assumenda laudantium fugiat praesentium.\nSunt quibusdam quia architecto impedit aliquam sequi consectetur.\nQuia veniam illo omnis.\nConsequatur magni mollitia qui dolor reiciendis perspiciatis ab soluta.", new DateTime(2021, 12, 4, 1, 6, 57, 745, DateTimeKind.Unspecified).AddTicks(8618), 3L, 46L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 2L, "Molestiae voluptatibus ipsa quas aut.\nEveniet quis eius dolor vel aliquid quia tempore consequatur.\nOmnis magnam eum quibusdam magnam ipsum.", new DateTime(2021, 12, 20, 16, 40, 33, 899, DateTimeKind.Unspecified).AddTicks(4261), 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Qui cupiditate dolorem.", new DateTime(2021, 10, 27, 16, 54, 10, 646, DateTimeKind.Unspecified).AddTicks(4750), 5L, 63L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 39L, "Unde voluptas architecto rem.", new DateTime(2021, 2, 14, 21, 17, 59, 540, DateTimeKind.Unspecified).AddTicks(5089), 32L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Vel enim sint omnis exercitationem omnis.\nIpsa possimus delectus doloribus voluptatem saepe omnis.\nUnde optio perferendis est qui modi voluptate tempora tempora.\nAtque enim voluptas quos.", new DateTime(2021, 3, 27, 12, 59, 9, 343, DateTimeKind.Unspecified).AddTicks(2725), 1L, 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 49L, "Aut et placeat officiis enim quia at molestias.\nAliquam non officiis ipsam.\nNon nobis aliquam labore ipsa velit ut vitae.\nUnde consequatur totam voluptatem omnis delectus eius ut.\nVelit aut aut facilis.", new DateTime(2021, 9, 5, 4, 2, 2, 474, DateTimeKind.Unspecified).AddTicks(424), 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 38L, "Ab aut cumque est asperiores quidem veniam odit corrupti pariatur.\nQuos est quisquam numquam velit veritatis voluptas voluptates corporis.\nA ex ea cum numquam quo error.", new DateTime(2021, 6, 15, 19, 56, 21, 286, DateTimeKind.Unspecified).AddTicks(5681), 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Doloremque porro pariatur.\nVoluptatum et enim eos.\nIllo ea nihil esse aliquam et placeat vitae.\nEt et ex explicabo dolorum nisi recusandae.\nEt porro quis quis voluptatem quia nam laborum est.", new DateTime(2021, 9, 22, 1, 11, 23, 140, DateTimeKind.Unspecified).AddTicks(7612), 5L, 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Nobis tempora ullam.\nUt et praesentium dolores maiores aperiam aliquam dolores voluptas quisquam.", new DateTime(2021, 10, 27, 3, 28, 48, 271, DateTimeKind.Unspecified).AddTicks(4604), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Omnis corrupti ea doloremque sit ipsa et error.\nIn modi quia eius doloremque libero accusamus voluptatem nisi sapiente.\nPraesentium culpa iure laboriosam assumenda ipsa eveniet saepe facere in.\nDeserunt nam culpa deleniti adipisci et ut illum non.\nEveniet sed qui.", new DateTime(2021, 5, 10, 21, 43, 1, 407, DateTimeKind.Unspecified).AddTicks(2377), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Omnis neque nemo.", new DateTime(2021, 12, 27, 20, 46, 28, 118, DateTimeKind.Unspecified).AddTicks(1782), 5L, 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Eos qui voluptates consequatur provident.", new DateTime(2021, 6, 13, 19, 20, 51, 517, DateTimeKind.Unspecified).AddTicks(3506), 3L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Alias ab non doloremque aut error.\nAut non quisquam consequuntur dolorem voluptas.\nDolorum soluta veniam itaque suscipit excepturi aspernatur pariatur.\nCum temporibus sunt.", new DateTime(2021, 11, 28, 7, 27, 57, 166, DateTimeKind.Unspecified).AddTicks(5207), 1L, 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 46L, "Sit in et qui quidem.\nFacere soluta officia exercitationem quos.\nPerferendis aut et quia voluptates debitis ut.\nCorporis eaque autem sequi quae at et.", new DateTime(2021, 4, 22, 12, 53, 26, 301, DateTimeKind.Unspecified).AddTicks(3993), 4L, 40L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Pariatur maiores ut fuga.\nQuae aut amet expedita et aut ea laudantium nam vel.\nDelectus possimus ratione.", new DateTime(2021, 12, 12, 2, 21, 48, 187, DateTimeKind.Unspecified).AddTicks(3695), 5L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 30L, "Nobis dolor doloremque accusamus sed debitis excepturi qui voluptatem neque.\nQuibusdam et sit fugiat suscipit quam est sed sunt quibusdam.", new DateTime(2021, 3, 26, 11, 35, 37, 920, DateTimeKind.Unspecified).AddTicks(3216), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Quidem sint voluptas debitis nulla et quo quia voluptatem reiciendis.\nQui quae exercitationem numquam ratione.\nEum tempora totam id enim dolores rem.\nAccusantium harum fugit odit deserunt.", new DateTime(2021, 3, 3, 14, 43, 13, 110, DateTimeKind.Unspecified).AddTicks(3744), 4L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 36L, "Doloribus veniam qui minus repellendus vel sunt ex.\nAdipisci quasi minima.\nIusto est animi et eaque eius voluptas.\nVero omnis qui.\nMollitia aut libero autem corporis possimus.\nQuam officia sequi numquam.", new DateTime(2021, 3, 1, 4, 36, 46, 202, DateTimeKind.Unspecified).AddTicks(6727), 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Consequatur dolores tenetur aliquid.\nTempore et alias eum expedita cumque unde.\nDolores minus quia ullam amet impedit et.\nQuibusdam iusto rerum vero doloribus minima rem sint dolores ex.\nOfficia debitis corrupti esse et.", new DateTime(2021, 4, 30, 4, 45, 59, 691, DateTimeKind.Unspecified).AddTicks(7247), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Aut molestiae officiis reiciendis sit deleniti ea adipisci dolores numquam.\nNesciunt similique optio aut dolores perspiciatis reprehenderit iusto dicta.\nUllam ea a minus.", new DateTime(2021, 11, 13, 21, 2, 13, 368, DateTimeKind.Unspecified).AddTicks(4529), 3L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Qui est debitis suscipit sint.", new DateTime(2021, 2, 5, 19, 47, 14, 271, DateTimeKind.Unspecified).AddTicks(8322), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Eos beatae possimus porro sint quisquam vero qui occaecati eaque.\nVeniam tempore et voluptatem repudiandae.\nQuis neque ut aut.\nItaque est omnis eligendi commodi.", new DateTime(2021, 12, 16, 0, 35, 55, 674, DateTimeKind.Unspecified).AddTicks(5286), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 26L, "Nemo iusto voluptas sed sit minus mollitia.\nHarum id labore illum quia sed provident.\nQuasi assumenda necessitatibus dolorem et ut.", new DateTime(2021, 12, 4, 13, 12, 49, 653, DateTimeKind.Unspecified).AddTicks(2873), 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Commodi architecto maiores et aut.\nConsequatur commodi optio quo modi rerum similique ullam laboriosam.", new DateTime(2021, 11, 10, 7, 53, 26, 136, DateTimeKind.Unspecified).AddTicks(5424), 5L, 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Alias odio voluptas et dolorum aut suscipit earum amet.\nVero molestias et labore.\nDolorum sit itaque sunt quo dolorem autem.", new DateTime(2021, 10, 30, 15, 51, 52, 4, DateTimeKind.Unspecified).AddTicks(6718), 2L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Minus dignissimos velit recusandae id cupiditate ea harum.\nNam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.", new DateTime(2021, 2, 26, 12, 1, 35, 855, DateTimeKind.Unspecified).AddTicks(3844), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nam quia dicta eius doloribus commodi non nihil.\nQuod recusandae et est.\nDebitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.", new DateTime(2021, 10, 28, 3, 37, 20, 886, DateTimeKind.Unspecified).AddTicks(3829), 1L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 44L, "Est sit at placeat optio.\nSapiente pariatur et et enim.\nAccusamus molestiae labore.", new DateTime(2021, 6, 2, 19, 19, 7, 873, DateTimeKind.Unspecified).AddTicks(6561), 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 1L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Earum voluptate voluptatem.\nSunt sunt est non deleniti tempore provident nihil et omnis.", new DateTime(2021, 5, 22, 23, 42, 34, 208, DateTimeKind.Unspecified).AddTicks(457), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 1L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 26L, "Libero dicta temporibus atque earum.\nReprehenderit eos qui eum totam.\nId cum adipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 4L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 1L, 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 1L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "Body", "CreatedAt", "ThreadId" },
                values: new object[] { "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 2L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 3L, 47L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 3L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 1L, 65L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 3L, 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 3L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 5L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 3L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 5L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 5L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 3L, 67L });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 9L, new DateTime(2021, 7, 12, 4, 24, 41, 598, DateTimeKind.Unspecified).AddTicks(330), 5L, 542, 57L, null, 72 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 6, 14, 18, 29, 32, 451, DateTimeKind.Unspecified).AddTicks(8937), 4L, 1000, 369 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 9L, new DateTime(2021, 8, 3, 4, 27, 11, 745, DateTimeKind.Unspecified).AddTicks(7199), 5L, 949, null, 38L, 474 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2022, 1, 3, 7, 18, 47, 381, DateTimeKind.Unspecified).AddTicks(8541), 3L, 691, 14L, 94 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 2, 17, 19, 34, 43, 641, DateTimeKind.Unspecified).AddTicks(8659), 692, 69L, null, 293 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 8, 3, 6, 48, 25, 426, DateTimeKind.Unspecified).AddTicks(9800), 1L, 939, false, 69L, 452 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 5, 6, 6, 58, 49, 512, DateTimeKind.Unspecified).AddTicks(282), 1L, 916, true, 34L, 365 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 11, 11, 17, 50, 18, 516, DateTimeKind.Unspecified).AddTicks(9638), 914, 54L, 164 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 7, 12, 6, 30, 27, 386, DateTimeKind.Unspecified).AddTicks(9206), 3L, 759, 51L, 473 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 12, 29, 9, 9, 5, 46, DateTimeKind.Unspecified).AddTicks(4253), 5L, 884, 36L, 426 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 12, 10, 18, 51, 30, 372, DateTimeKind.Unspecified).AddTicks(2051), 778, 43L, 122 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 6, 27, 13, 24, 58, 306, DateTimeKind.Unspecified).AddTicks(7484), 5L, 791, true, 35L, 250 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 3, 21, 0, 12, 11, 309, DateTimeKind.Unspecified).AddTicks(8941), 4L, 990, false, 15L, 366 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 4, 29, 18, 43, 39, 630, DateTimeKind.Unspecified).AddTicks(4412), 3L, 589, true, 13L, 62 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2021, 8, 26, 23, 16, 4, 80, DateTimeKind.Unspecified).AddTicks(3995), 1L, 643, null, 41L, 132 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 43L, new DateTime(2021, 8, 13, 8, 16, 35, 138, DateTimeKind.Unspecified).AddTicks(7857), 3L, 517, 21L, 282 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 3, 3, 11, 54, 52, 658, DateTimeKind.Unspecified).AddTicks(4160), 2L, 783, 31L, null, 44 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 7, 25, 11, 33, 47, 315, DateTimeKind.Unspecified).AddTicks(5302), 1L, 939, false, 60L, 65 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2022, 1, 8, 3, 23, 10, 141, DateTimeKind.Unspecified).AddTicks(2887), 2L, 906, 16L, 403 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 6, 29, 5, 1, 19, 676, DateTimeKind.Unspecified).AddTicks(6768), 1L, 960, null, 34L, 117 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 3, 14, 21, 10, 47, 585, DateTimeKind.Unspecified).AddTicks(565), 2L, 904, null, 19L, 86 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2022, 1, 28, 12, 29, 50, 770, DateTimeKind.Unspecified).AddTicks(6738), 915, 3L, 114 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 10, 11, 22, 47, 33, 344, DateTimeKind.Unspecified).AddTicks(8780), 515, 2L, 349 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 8, 13, 23, 22, 21, 985, DateTimeKind.Unspecified).AddTicks(6523), 5L, 548, false, 44L, 33 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 9, 7, 8, 34, 37, 650, DateTimeKind.Unspecified).AddTicks(1144), 1L, 968, false, 75L, null, 113 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 11, 20, 23, 49, 57, 256, DateTimeKind.Unspecified).AddTicks(1759), 3L, 814, 19L, 479 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 2, 20, 3, 40, 33, 500, DateTimeKind.Unspecified).AddTicks(1038), 3L, 523, false, 70L, null, 105 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 9, 9, 8, 35, 3, 427, DateTimeKind.Unspecified).AddTicks(1220), 662, null, 39L, 479 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 8, 30, 5, 36, 12, 623, DateTimeKind.Unspecified).AddTicks(5230), 3L, 977, true, 16L, 281 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 10, 22, 19, 42, 10, 380, DateTimeKind.Unspecified).AddTicks(7827), 5L, 553, 71L, null, 333 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2021, 11, 22, 1, 0, 54, 746, DateTimeKind.Unspecified).AddTicks(3822), 3L, 716, null, 15L, 326 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 12, 30, 6, 31, 47, 599, DateTimeKind.Unspecified).AddTicks(4407), 3L, 850, true, null, 29L, 394 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 7, 22, 8, 9, 25, 122, DateTimeKind.Unspecified).AddTicks(5704), 1L, 859, true, 41L, 60 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 10, 23, 17, 26, 3, 76, DateTimeKind.Unspecified).AddTicks(9798), 801, 56L, 96 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 5, 15, 8, 14, 28, 255, DateTimeKind.Unspecified).AddTicks(1448), 1L, 502, false, 31L, 445 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 2, 2, 1, 48, 37, 773, DateTimeKind.Unspecified).AddTicks(5419), 1L, 901, true, null, 30L, 497 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 4, 14, 10, 50, 14, 746, DateTimeKind.Unspecified).AddTicks(747), 2L, 595, false, 7L, 211 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 8, 6, 6, 8, 22, 247, DateTimeKind.Unspecified).AddTicks(6582), 4L, 732, false, 42L, 332 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 3, 16, 9, 22, 46, 401, DateTimeKind.Unspecified).AddTicks(8982), 3L, 825, 34L, 338 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2022, 1, 26, 18, 45, 51, 417, DateTimeKind.Unspecified).AddTicks(7369), 3L, 823, false, 11L, 270 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 3, 9, 19, 19, 12, 447, DateTimeKind.Unspecified).AddTicks(9624), 3L, 917, 8L, null, 423 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 11, 20, 20, 26, 47, 629, DateTimeKind.Unspecified).AddTicks(2679), 1L, 753, null, 27L, 132 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 11, 11, 3, 13, 40, 885, DateTimeKind.Unspecified).AddTicks(1123), 1L, 809, true, 45L, 365 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 9, 2, 14, 9, 27, 214, DateTimeKind.Unspecified).AddTicks(6632), 1L, 676, false, 34L, 393 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2022, 1, 11, 16, 47, 28, 760, DateTimeKind.Unspecified).AddTicks(6241), 3L, 704, null, 40L, 392 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 5, 15, 14, 13, 18, 145, DateTimeKind.Unspecified).AddTicks(4164), 4L, 941, true, 29L, 122 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2021, 11, 9, 7, 40, 17, 926, DateTimeKind.Unspecified).AddTicks(4540), 5L, 568, 51L, 37 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 4, 22, 22, 50, 1, 204, DateTimeKind.Unspecified).AddTicks(2250), 2L, 754, null, 44L, 365 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 6, 22, 5, 15, 20, 396, DateTimeKind.Unspecified).AddTicks(6795), 1L, 745, false, 55L, null, 398 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 9L, new DateTime(2021, 12, 12, 14, 31, 53, 412, DateTimeKind.Unspecified).AddTicks(6728), 5L, 652, true, null, 5L, 318 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 3, 2, 5, 55, 2, 703, DateTimeKind.Unspecified).AddTicks(7750), 5L, 621, 29L, 37 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 4, 11, 21, 59, 47, 297, DateTimeKind.Unspecified).AddTicks(8996), 5L, 757, true, 39L, 126 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 7, 9, 21, 21, 1, 709, DateTimeKind.Unspecified).AddTicks(7080), 5L, 710, true, 38L, null, 482 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2022, 1, 30, 7, 20, 40, 755, DateTimeKind.Unspecified).AddTicks(473), 1L, 961, true, 31L, 42 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 3, 14, 10, 35, 45, 947, DateTimeKind.Unspecified).AddTicks(6082), 2L, 581, true, 71L, 358 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 12, 22, 19, 51, 8, 849, DateTimeKind.Unspecified).AddTicks(3167), 2L, 677, 43L, 393 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 7, 21, 12, 3, 13, 541, DateTimeKind.Unspecified).AddTicks(2356), 5L, 872, 42L, null, 426 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2022, 1, 6, 17, 17, 47, 306, DateTimeKind.Unspecified).AddTicks(9871), 4L, 547, false, 14L, 486 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 9, 18, 0, 34, 29, 382, DateTimeKind.Unspecified).AddTicks(8220), 819, 7L, 429 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 5, 16, 17, 32, 22, 93, DateTimeKind.Unspecified).AddTicks(292), 1L, 647, true, 79L, null, 199 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 12, 22, 0, 2, 9, 424, DateTimeKind.Unspecified).AddTicks(5244), 5L, 665, false, null, 11L, 40 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 12, 20, 11, 19, 10, 813, DateTimeKind.Unspecified).AddTicks(9070), 5L, 797, 58L, 456 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 11, 30, 9, 33, 42, 681, DateTimeKind.Unspecified).AddTicks(586), 5L, 609, false, 40L, 415 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 4, 19, 4, 32, 5, 582, DateTimeKind.Unspecified).AddTicks(663), 1L, 556, true, 22L, 255 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 11, 5, 7, 33, 54, 768, DateTimeKind.Unspecified).AddTicks(3229), 988, 61L, null, 14 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 12, 27, 3, 36, 51, 391, DateTimeKind.Unspecified).AddTicks(8738), 2L, 522, false, 24L, null, 12 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 10, 8, 23, 51, 19, 83, DateTimeKind.Unspecified).AddTicks(9759), 1L, 880, 74L, null, 96 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 2, 24, 22, 44, 14, 165, DateTimeKind.Unspecified).AddTicks(2301), 5L, 653, 11L, 110 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 6, 4, 9, 46, 58, 254, DateTimeKind.Unspecified).AddTicks(2130), 2L, 926, true, 48L, null, 98 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 2, 3, 21, 2, 48, 378, DateTimeKind.Unspecified).AddTicks(1604), 3L, 978, 34L, null, 398 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 7, 30, 15, 56, 46, 975, DateTimeKind.Unspecified).AddTicks(696), 1L, 933, 58L, 491 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 5, 17, 3, 47, 5, 14, DateTimeKind.Unspecified).AddTicks(4962), 3L, 959, 6L, 446 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 22L, new DateTime(2021, 12, 4, 17, 57, 16, 97, DateTimeKind.Unspecified).AddTicks(2378), 5L, 818, false, null, 28L, 465 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 11, 6, 13, 11, 56, 824, DateTimeKind.Unspecified).AddTicks(4047), 3L, 521, 19L, null, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 4, 11, 21, 11, 45, 348, DateTimeKind.Unspecified).AddTicks(1308), 3L, 682, false, null, 36L, 51 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 8, 24, 11, 46, 43, 668, DateTimeKind.Unspecified).AddTicks(9941), 3L, 698, 8L, null, 307 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2021, 4, 20, 4, 20, 8, 599, DateTimeKind.Unspecified).AddTicks(3527), 1L, 822, 67L, 93 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 11, 30, 5, 12, 29, 602, DateTimeKind.Unspecified).AddTicks(9166), 981, 54L, 443 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 6, 3, 20, 56, 11, 117, DateTimeKind.Unspecified).AddTicks(9935), 5L, 999, null, 7L, 215 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 31L, new DateTime(2021, 6, 27, 2, 42, 1, 694, DateTimeKind.Unspecified).AddTicks(6081), 618, false, 73L, null, 339 });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 11L, new DateTime(2021, 12, 23, 11, 26, 13, 957, DateTimeKind.Unspecified).AddTicks(2165), "Ipsum dolores nam." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 18L, new DateTime(2021, 11, 4, 18, 26, 2, 495, DateTimeKind.Unspecified).AddTicks(360), 3L, "Blanditiis laudantium et et delectus." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 8L, new DateTime(2021, 10, 24, 8, 55, 46, 551, DateTimeKind.Unspecified).AddTicks(9429), 3L, "Enim qui dolore debitis aut impedit et recusandae." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 4L, new DateTime(2021, 9, 26, 13, 29, 0, 514, DateTimeKind.Unspecified).AddTicks(7689), 1L, "Rerum itaque vitae aspernatur distinctio ullam numquam quod ut labore." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 6L, new DateTime(2021, 12, 6, 12, 14, 17, 556, DateTimeKind.Unspecified).AddTicks(1013), 4L, "Consectetur quas sequi dicta." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 5L, new DateTime(2021, 4, 3, 2, 30, 27, 405, DateTimeKind.Unspecified).AddTicks(2736), 2L, "Nobis officia impedit ut ipsa praesentium harum minus." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 6L, new DateTime(2021, 9, 11, 10, 8, 13, 533, DateTimeKind.Unspecified).AddTicks(2349), 3L, "Molestias non quisquam assumenda corporis unde." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 18L, new DateTime(2021, 2, 3, 22, 26, 35, 27, DateTimeKind.Unspecified).AddTicks(2206), 3L, "Cum voluptatem non." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 7L, new DateTime(2021, 12, 25, 8, 34, 28, 94, DateTimeKind.Unspecified).AddTicks(8252), 4L, "Ut ipsam omnis temporibus ut aliquam quos iure quia." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 9L, new DateTime(2021, 6, 6, 11, 36, 54, 289, DateTimeKind.Unspecified).AddTicks(2898), 4L, "Dicta officiis voluptatem ut nobis nam repellendus." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 20L, new DateTime(2021, 2, 19, 10, 33, 36, 944, DateTimeKind.Unspecified).AddTicks(1236), 4L, "Et veniam est voluptates natus perferendis tempora." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 9L, new DateTime(2021, 2, 20, 10, 40, 8, 774, DateTimeKind.Unspecified).AddTicks(1450), 4L, "Hic veniam deserunt et enim tempora vel dolor nostrum praesentium." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { new DateTime(2021, 6, 26, 4, 38, 29, 153, DateTimeKind.Unspecified).AddTicks(8745), 5L, "Necessitatibus iste magni at non reprehenderit qui expedita ipsa." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 20L, new DateTime(2021, 9, 16, 20, 43, 41, 644, DateTimeKind.Unspecified).AddTicks(8908), 5L, "Eum aut doloremque consequatur totam nam dolorem." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 7L, new DateTime(2021, 5, 22, 11, 5, 22, 593, DateTimeKind.Unspecified).AddTicks(8566), 3L, "Reprehenderit iste consequatur id consequatur ab." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 3L, new DateTime(2021, 7, 13, 0, 22, 29, 979, DateTimeKind.Unspecified).AddTicks(9243), 3L, "Libero blanditiis explicabo." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 13L, new DateTime(2021, 10, 29, 19, 57, 0, 284, DateTimeKind.Unspecified).AddTicks(4656), 1L, "Exercitationem labore blanditiis aliquam libero facilis." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 15L, new DateTime(2021, 3, 30, 0, 8, 6, 926, DateTimeKind.Unspecified).AddTicks(8703), 2L, "Recusandae fugit dolor debitis voluptates dolor est laudantium." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 5L, new DateTime(2021, 2, 25, 18, 1, 10, 929, DateTimeKind.Unspecified).AddTicks(3578), 4L, "Asperiores aut deleniti et deleniti." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 20L, new DateTime(2021, 7, 22, 8, 24, 49, 5, DateTimeKind.Unspecified).AddTicks(9120), "Eaque aut cumque harum id molestiae amet est." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 20L, new DateTime(2021, 4, 30, 18, 11, 39, 101, DateTimeKind.Unspecified).AddTicks(4488), "In quia reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 2L, new DateTime(2021, 7, 8, 10, 42, 58, 973, DateTimeKind.Unspecified).AddTicks(3426), 2L, "Ea fuga est ipsum dolorum." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 6L, new DateTime(2021, 11, 1, 10, 21, 36, 515, DateTimeKind.Unspecified).AddTicks(7236), 1L, "Omnis neque qui quam voluptas non saepe aut vitae." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 3L, new DateTime(2021, 11, 2, 13, 12, 24, 731, DateTimeKind.Unspecified).AddTicks(4350), 5L, "Quod maxime itaque ipsam sit mollitia natus." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 14L, new DateTime(2021, 9, 26, 5, 41, 54, 129, DateTimeKind.Unspecified).AddTicks(6572), 3L, "Quis non aspernatur ut recusandae beatae." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 10L, new DateTime(2021, 4, 3, 2, 9, 44, 356, DateTimeKind.Unspecified).AddTicks(911), 2L, "Sapiente placeat inventore fugit dolor totam." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { new DateTime(2021, 3, 5, 9, 45, 56, 863, DateTimeKind.Unspecified).AddTicks(7594), 4L, "Officia accusantium ut rerum doloremque ut nemo qui est aut." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 17L, new DateTime(2021, 3, 17, 19, 43, 0, 459, DateTimeKind.Unspecified).AddTicks(8915), 5L, "Ab quibusdam fugiat et beatae alias dolorum cum ut aspernatur." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 5L, new DateTime(2021, 4, 12, 3, 2, 27, 326, DateTimeKind.Unspecified).AddTicks(1422), 2L, "In magni magni impedit." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 18L, new DateTime(2021, 9, 30, 2, 59, 16, 951, DateTimeKind.Unspecified).AddTicks(1136), 5L, "Et non labore cumque est." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 18L, new DateTime(2021, 3, 6, 23, 12, 35, 177, DateTimeKind.Unspecified).AddTicks(7305), "Amet fugiat inventore et maiores quidem et corporis." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 4L, new DateTime(2021, 7, 27, 16, 18, 5, 613, DateTimeKind.Unspecified).AddTicks(9203), 3L, "Et odit aperiam aliquid." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 18L, new DateTime(2021, 7, 13, 1, 40, 25, 434, DateTimeKind.Unspecified).AddTicks(9528), "Reiciendis fuga facilis amet nihil dolorem dolorum reprehenderit autem incidunt." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 8L, new DateTime(2021, 10, 8, 9, 2, 45, 583, DateTimeKind.Unspecified).AddTicks(1444), 3L, "Deserunt neque qui dolores velit quos." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 16L, new DateTime(2021, 11, 25, 3, 25, 51, 16, DateTimeKind.Unspecified).AddTicks(6181), 3L, "Ut eius dolorem odit sed ut nam vel voluptas laudantium." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 10L, new DateTime(2021, 3, 21, 4, 16, 40, 456, DateTimeKind.Unspecified).AddTicks(2450), "Commodi qui sit velit molestiae animi unde beatae similique." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 7L, new DateTime(2021, 10, 1, 6, 21, 38, 31, DateTimeKind.Unspecified).AddTicks(4332), 3L, "Aut aut accusantium unde sunt corporis id." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CourseId", "CreatedAt", "Title" },
                values: new object[] { 2L, new DateTime(2021, 2, 21, 12, 47, 33, 557, DateTimeKind.Unspecified).AddTicks(5873), "Amet doloremque similique iusto quas explicabo rerum." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 13L, new DateTime(2021, 4, 10, 20, 40, 12, 158, DateTimeKind.Unspecified).AddTicks(1171), 2L, "Deserunt rem et deleniti porro ea qui et ea." });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Title" },
                values: new object[] { 11L, new DateTime(2021, 11, 12, 10, 3, 33, 221, DateTimeKind.Unspecified).AddTicks(9811), 3L, "Quis corporis sint dolorem quaerat qui officia debitis." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 20L, "Ex et quam molestiae adipisci temporibus iste sed tempore.\nExpedita aut optio tempora enim ut.\nEligendi ipsam officia facere qui doloribus et vero ipsa.\nQuam neque error voluptate alias tenetur.", new DateTime(2021, 8, 16, 23, 5, 9, 674, DateTimeKind.Unspecified).AddTicks(5744), "Elsa.Kuhic9@yahoo.com", "Cloyd", "Nitzsche", "Luigi.Brekke65" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 92L, "Voluptas quas quia veritatis aut et fuga sint.\nSequi autem dolores autem aut consequatur et.\nUt sint dolorem.\nIn mollitia magni autem quis perspiciatis ab alias et.", new DateTime(2021, 3, 14, 5, 11, 28, 476, DateTimeKind.Unspecified).AddTicks(5936), 4L, "Justice_Schaefer@gmail.com", "Ulises", "Tillman", "Syble.Weimann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 33L, "Quibusdam recusandae pariatur.\nQuo delectus aut vel.\nEt adipisci enim qui ea in.\nSint inventore nulla ut pariatur iure aut aut magni aut.", new DateTime(2021, 11, 21, 6, 52, 43, 759, DateTimeKind.Unspecified).AddTicks(5158), 1L, "Vivianne_Bartell@yahoo.com", "Trudie", "Schroeder", "Felton_Jakubowski84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 30L, "Ad asperiores deleniti dolorum provident ipsa veniam debitis.\nAut delectus ipsam labore voluptate eum officiis illo eum blanditiis.\nRepellendus necessitatibus magnam debitis qui dolorum laborum praesentium voluptas.\nCum veniam consequatur eos fugit aut.\nExcepturi aliquid totam nobis sequi et.", new DateTime(2021, 7, 14, 21, 50, 39, 161, DateTimeKind.Unspecified).AddTicks(1421), 3L, "Fernando.Schultz28@hotmail.com", "Georgianna", "Maggio", "Neal46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 5L, "Dolorem aut rem sed soluta hic.\nExercitationem quisquam vel.\nVoluptatum maiores sequi et voluptatem voluptatum cupiditate.\nDistinctio ad quia atque quae.\nIpsum modi numquam.", new DateTime(2022, 1, 17, 11, 52, 12, 1, DateTimeKind.Unspecified).AddTicks(2709), 5L, "Freda44@hotmail.com", "Lee", "Kreiger", "Bernie.Conroy74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 23L, "Beatae consequuntur doloribus exercitationem quia enim beatae voluptatem dolore.\nEst et molestiae beatae.\nEst rerum similique ex corrupti molestias aperiam.\nNostrum officia aut et at praesentium et incidunt laborum culpa.\nQuae quae ut sint.", new DateTime(2021, 5, 13, 5, 16, 30, 72, DateTimeKind.Unspecified).AddTicks(2220), "Austin.Schulist88@yahoo.com", "Althea", "Maggio", "Cara_Marquardt86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 64L, "Ipsa dolor optio impedit perferendis.\nTempora est ducimus et eaque.\nMagnam aperiam praesentium.", new DateTime(2022, 1, 9, 19, 23, 23, 381, DateTimeKind.Unspecified).AddTicks(3429), 5L, "Viviane67@yahoo.com", "Jarrod", "Durgan", "Jennifer97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 82L, "Ea dolorem illum consequatur accusamus sed quia officia qui.\nAdipisci maxime sapiente quia quis rem blanditiis.\nEt aut excepturi rerum quod id velit fugit.\nUt harum tenetur sed quis fuga dolorem.\nAut iusto accusantium deserunt hic omnis autem provident.", new DateTime(2021, 2, 18, 5, 13, 33, 566, DateTimeKind.Unspecified).AddTicks(9632), 5L, "Hilbert90@gmail.com", "Maryse", "Hamill", "Arjun.DAmore" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Bio", "FirstName", "LastName", "UserName" },
                values: new object[] { "Sint libero a omnis illo qui sed autem ut.\nEaque et aut nihil dolore eos.\nEt enim aspernatur aut quo id.\nRepellat perspiciatis impedit consequatur molestiae quia blanditiis ea.\nFugiat aperiam sunt quam.", "Hermann", "Blick", "Yazmin.Ondricka45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 69L, "Maxime sed recusandae ut dolor molestias aut enim.\nCommodi aperiam cum numquam ad libero sequi quisquam nam.\nCumque sed cumque aliquid nihil pariatur rem.\nPlaceat labore qui dolores soluta deserunt molestias sunt.", new DateTime(2021, 2, 2, 19, 47, 39, 758, DateTimeKind.Unspecified).AddTicks(1554), 3L, "Carmine_Denesik49@hotmail.com", "Allen", "Rutherford", "Shane.Willms" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 101L, "Sequi veritatis deserunt quae at molestias.\nEnim voluptas ea quasi quae incidunt.", new DateTime(2021, 5, 24, 6, 50, 23, 843, DateTimeKind.Unspecified).AddTicks(4370), 3L, "Arthur84@yahoo.com", "Efrain", "Jerde", "Doyle60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 16L, "Veritatis praesentium eum iusto.\nNon non repudiandae ipsa reiciendis et et distinctio nobis.\nAnimi in assumenda molestiae.\nId esse qui.", new DateTime(2021, 8, 4, 1, 10, 59, 207, DateTimeKind.Unspecified).AddTicks(1955), 4L, "Roxane85@yahoo.com", "Ferne", "Corkery", "Aubree.DuBuque" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 9L, "Dolorem iste autem qui eos nisi.\nAperiam voluptate quasi nulla at officia modi perspiciatis.\nFacilis aut velit qui architecto laudantium libero.\nMagnam deleniti nostrum quasi excepturi ut ut ea autem.", new DateTime(2021, 6, 11, 6, 51, 20, 760, DateTimeKind.Unspecified).AddTicks(8108), 1L, "Aylin.Lynch58@gmail.com", "Stephany", "Flatley", "Forest78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 54L, "Eos saepe fugiat accusantium qui ea rerum.", new DateTime(2021, 4, 3, 4, 28, 30, 393, DateTimeKind.Unspecified).AddTicks(4125), 3L, "Sincere66@gmail.com", "Tanner", "Collins", "Madyson93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 80L, "Laboriosam totam et aut aut totam.\nSimilique sequi aut et voluptas.", new DateTime(2021, 11, 19, 19, 53, 36, 284, DateTimeKind.Unspecified).AddTicks(834), 2L, "Julien_Runte67@yahoo.com", "Wyatt", "Rohan", "Jed12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 60L, "Aut sed voluptas voluptas totam quos natus.\nIste alias natus culpa illum eveniet dolor id id quos.\nNostrum qui iure ipsam delectus doloribus eius voluptatem aut enim.\nNon et et rerum qui soluta beatae alias.\nAperiam non recusandae sit libero modi quibusdam iure quia.", new DateTime(2021, 6, 19, 2, 34, 53, 649, DateTimeKind.Unspecified).AddTicks(4945), 2L, "Jordyn_Johnson@hotmail.com", "Velda", "Schulist", "Aimee15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 78L, "Et voluptatem accusamus.\nAspernatur cupiditate id et molestiae vitae laudantium quia facilis.\nConsectetur fugiat velit suscipit autem ut totam et.\nQuisquam occaecati autem quia modi fuga vero distinctio ad.\nMollitia ipsam est sint commodi.", new DateTime(2021, 11, 5, 22, 31, 34, 921, DateTimeKind.Unspecified).AddTicks(7921), 3L, "Yoshiko_Parisian50@yahoo.com", "Katarina", "O'Kon", "Sheridan.Swift17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 29L, "Odit nemo ratione labore corporis voluptatem excepturi.\nEt quam amet molestiae ab et perspiciatis ipsam fugiat omnis.\nOmnis fuga accusamus suscipit a aspernatur omnis architecto quidem.\nAut qui esse est.", new DateTime(2021, 12, 2, 22, 26, 27, 126, DateTimeKind.Unspecified).AddTicks(4789), "Constantin.Hayes@hotmail.com", "Cory", "Stoltenberg", "Braulio_McGlynn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 2L, "Aut qui qui.\nSed voluptatibus labore.\nConsectetur eos facere et debitis temporibus sit ut est voluptatem.\nTempora quia hic.", new DateTime(2021, 9, 15, 18, 21, 57, 915, DateTimeKind.Unspecified).AddTicks(5941), 2L, "Jennifer_Cole@hotmail.com", "Jerad", "Dicki", "Rosetta57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 69L, "Quos consequatur ut consequatur dolor.", new DateTime(2021, 4, 14, 8, 14, 8, 960, DateTimeKind.Unspecified).AddTicks(171), 1L, "Josiah6@hotmail.com", "Bennett", "Ritchie", "Lenny_Hettinger" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 58L, "Qui quia incidunt quisquam consequatur provident iure et minima soluta.\nUt quam dolorem illo quaerat quo.\nPorro ut nihil explicabo porro sit eos in iusto.\nEt possimus tenetur corporis.\nMolestiae omnis et.", new DateTime(2021, 9, 16, 16, 39, 11, 676, DateTimeKind.Unspecified).AddTicks(1746), 1L, "Lydia.Hilpert@hotmail.com", "Candace", "Kertzmann", "Chad_Cole" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 67L, "Porro doloribus eius quidem quos eveniet.\nIncidunt aspernatur nesciunt a cupiditate qui qui.\nDoloribus et magnam occaecati consectetur qui voluptatem voluptas ratione vitae.\nAspernatur asperiores consectetur dicta voluptatem.\nPossimus similique qui ab quia consequuntur enim voluptas.", new DateTime(2021, 11, 15, 20, 5, 12, 289, DateTimeKind.Unspecified).AddTicks(4818), "Brooklyn_Hessel48@gmail.com", "Aric", "Emard", "Darrel.Considine" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 78L, "Omnis sequi et.", new DateTime(2021, 7, 12, 9, 36, 45, 577, DateTimeKind.Unspecified).AddTicks(9544), 1L, "Aliza26@yahoo.com", "Wyatt", "Koch", "Gordon_Goyette81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 66L, "Perspiciatis mollitia nobis consequatur dolor autem consequatur voluptas repellat.\nQui consequuntur et dolores sunt sequi eaque deleniti aspernatur aliquid.\nLaboriosam quisquam quos non suscipit et laboriosam rerum perferendis est.\nIste ad non tenetur totam quibusdam consequatur dolore.\nSoluta voluptatem illum in.", new DateTime(2021, 12, 6, 17, 20, 43, 778, DateTimeKind.Unspecified).AddTicks(8524), 4L, "Waylon_Oberbrunner@yahoo.com", "Bonnie", "Gerhold", "Shad_Sauer67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 59L, "Totam odio voluptatibus quaerat.\nSimilique et id et est labore tempore at voluptatem.\nArchitecto et sint explicabo commodi.", new DateTime(2021, 9, 19, 15, 58, 2, 648, DateTimeKind.Unspecified).AddTicks(8897), 1L, "Warren.Bradtke@hotmail.com", "Clay", "Kris", "Katelyn87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 43L, "Veniam iste quisquam et.\nIpsa placeat aspernatur in ut.\nQui dolorum magni ut ad.\nVitae non dolores laboriosam est numquam.", new DateTime(2021, 10, 12, 7, 15, 57, 780, DateTimeKind.Unspecified).AddTicks(9232), "Keith53@gmail.com", "Frank", "Bergstrom", "Enrique31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 32L, "Molestiae modi alias.\nBeatae enim laborum placeat consectetur fugit alias recusandae veniam vero.", new DateTime(2021, 4, 30, 18, 51, 42, 478, DateTimeKind.Unspecified).AddTicks(6774), 1L, "Stefan.Pacocha@gmail.com", "Fabiola", "Dietrich", "Pamela79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 18L, "Dolorum beatae sequi veritatis veniam.\nLaboriosam quidem eos aut hic.\nSunt nihil voluptate doloribus accusantium non dolor.", new DateTime(2021, 10, 10, 3, 3, 59, 177, DateTimeKind.Unspecified).AddTicks(9072), 1L, "Birdie_Abbott92@gmail.com", "Jose", "Wuckert", "Cristina_Pfeffer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 2L, "Eius sunt delectus natus eaque quia molestiae ex culpa.\nAutem minima corrupti quidem qui et et modi.\nQuia incidunt dolores sed voluptatem voluptatem qui.\nQuaerat voluptatem suscipit labore recusandae corrupti non consequatur.\nNon qui vitae autem voluptas.", new DateTime(2021, 12, 3, 2, 45, 51, 373, DateTimeKind.Unspecified).AddTicks(3865), "Federico3@yahoo.com", "Rowland", "Kuhn", "Jermey_Johns17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 24L, "Nihil sed saepe corrupti ipsum eaque.", new DateTime(2021, 3, 29, 15, 49, 38, 852, DateTimeKind.Unspecified).AddTicks(5072), 3L, "Hipolito.Stokes82@gmail.com", "Lawrence", "Lockman", "Richard_Robel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 67L, "Earum sunt corrupti deserunt.\nVeritatis rerum nam quisquam et molestias quae.\nNemo nesciunt provident odit.\nEa dolore qui.\nEarum labore saepe corrupti quae id aut ullam fugiat expedita.", new DateTime(2021, 4, 17, 2, 40, 37, 265, DateTimeKind.Unspecified).AddTicks(8566), "Noelia54@yahoo.com", "Lila", "Bayer", "Brook_Shanahan78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 64L, "Quo dolores cum omnis est quod ea.\nVoluptatem dolore cumque quia sit veniam repellendus nihil quasi at.\nMolestiae voluptas beatae voluptatibus blanditiis dolore.\nNisi sed pariatur dolorum nesciunt sunt sed.\nVoluptas placeat dolorum veniam ut consequatur ex.", new DateTime(2021, 5, 28, 20, 11, 9, 545, DateTimeKind.Unspecified).AddTicks(9227), 5L, "Tierra_Gusikowski77@yahoo.com", "Armand", "Schmitt", "Stewart31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 51L, "Nemo consequuntur in quis.", new DateTime(2022, 1, 20, 6, 51, 8, 284, DateTimeKind.Unspecified).AddTicks(8777), 3L, "Justice_Borer@gmail.com", "Nicklaus", "Rosenbaum", "Delmer52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 17L, "Perspiciatis dolor quisquam nostrum dolorem quis non.\nAut est aut mollitia in aut voluptas velit quasi.\nQui non nisi fugit quis odit.\nAut praesentium nisi fuga blanditiis unde id totam quisquam.", new DateTime(2021, 7, 7, 4, 41, 23, 241, DateTimeKind.Unspecified).AddTicks(9668), 5L, "Ezequiel_Padberg15@hotmail.com", "Constance", "Cremin", "Pinkie_Schamberger7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 24L, "Repellendus possimus rem.\nMolestiae quos et dolores.", new DateTime(2021, 12, 16, 15, 43, 10, 866, DateTimeKind.Unspecified).AddTicks(9229), 3L, "Taurean55@gmail.com", "Raul", "Baumbach", "Mikel.Lakin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 8L, "Cupiditate ut sunt.\nEx atque facilis corporis ex blanditiis voluptas.", new DateTime(2021, 5, 26, 16, 17, 45, 659, DateTimeKind.Unspecified).AddTicks(496), 3L, "Zella_Maggio@hotmail.com", "Arch", "King", "Mariane_Effertz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 59L, "Id unde provident molestiae laboriosam occaecati quam harum.\nEt sit qui et enim veniam aut aspernatur praesentium natus.", new DateTime(2021, 2, 3, 9, 57, 31, 853, DateTimeKind.Unspecified).AddTicks(9551), "Bertrand_Thiel@gmail.com", "Jeremie", "Bradtke", "Declan.Marquardt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 54L, "Facere qui provident.\nVoluptas in non ducimus non ipsa.\nNecessitatibus ut quis vero et.\nUt quia laborum.", new DateTime(2021, 4, 25, 17, 43, 36, 148, DateTimeKind.Unspecified).AddTicks(5969), 5L, "Suzanne_Stiedemann@hotmail.com", "Jessie", "Beahan", "Jayden.Stoltenberg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 82L, "Similique aperiam incidunt iste sit et quo harum modi officiis.\nAdipisci consequatur mollitia.\nA officiis ratione.", new DateTime(2021, 12, 6, 22, 53, 54, 113, DateTimeKind.Unspecified).AddTicks(2011), 4L, "Rose84@gmail.com", "Ally", "Feeney", "Frederik.Sporer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 91L, "Ex repellat nemo et molestiae exercitationem adipisci modi consequuntur.\nEt quod assumenda assumenda et natus eius saepe.\nNobis voluptatem eum amet molestiae sint accusantium aliquid et aut.\nAccusantium veniam odio dolores et quae est quaerat quisquam voluptatem.", new DateTime(2021, 10, 11, 6, 46, 31, 102, DateTimeKind.Unspecified).AddTicks(9974), 2L, "Naomi30@yahoo.com", "Rosalyn", "Robel", "Arlo.Boehm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 25L, "Consequatur aut optio in earum error fugit dolorem soluta numquam.\nHarum cupiditate facere repudiandae a.\nEveniet aperiam minima voluptas.\nQuia voluptatem rerum.\nNisi ratione repudiandae.", new DateTime(2021, 7, 12, 5, 52, 38, 84, DateTimeKind.Unspecified).AddTicks(6036), 4L, "Jaiden27@gmail.com", "Ressie", "Bernhard", "Ebba94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 78L, "Facere repellendus non ab dicta est molestiae.", new DateTime(2021, 11, 13, 11, 28, 17, 365, DateTimeKind.Unspecified).AddTicks(5193), 5L, "Kiana_Nitzsche67@gmail.com", "Sim", "Koepp", "Emilio62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 2L, "Qui in vero illum rerum est iusto.\nDoloremque molestiae rerum magnam illum explicabo eum.", new DateTime(2021, 7, 14, 3, 28, 30, 37, DateTimeKind.Unspecified).AddTicks(2000), 5L, "Kacey_Harvey47@gmail.com", "Tommie", "Heller", "Vito_Fritsch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 49L, "Sed perferendis voluptates est repudiandae odit.\nEt quia dolor.\nDolore debitis et ea officiis quam ullam eius.\nQuidem et ipsa dolores excepturi corporis facilis.", new DateTime(2021, 4, 14, 17, 3, 32, 731, DateTimeKind.Unspecified).AddTicks(145), "Yazmin_Schinner76@gmail.com", "Rylee", "Hayes", "Chad_Streich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 81L, "Ad rerum cum occaecati laudantium.\nEius natus sed et voluptas sint ut est quia.\nLaudantium aut recusandae velit qui ipsa deleniti.", new DateTime(2021, 3, 29, 6, 33, 32, 453, DateTimeKind.Unspecified).AddTicks(1066), 2L, "Tracy.Mills90@yahoo.com", "Dejah", "Schamberger", "Ciara.Conroy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 73L, "Neque similique cumque quo quibusdam fugiat velit.\nOmnis sapiente ut vero sit nulla ut neque minima officia.", new DateTime(2021, 5, 11, 11, 32, 41, 57, DateTimeKind.Unspecified).AddTicks(5914), 5L, "Beatrice.Weimann@hotmail.com", "Bradford", "Mosciski", "Claire_Roberts62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 11L, "Quis rem omnis nobis eos assumenda enim enim magni.\nSed doloribus ipsum eveniet fuga impedit ut sed possimus.\nQuidem excepturi dolore.\nQuibusdam et id et nam temporibus fuga voluptas consequuntur sit.", new DateTime(2021, 6, 17, 5, 38, 31, 577, DateTimeKind.Unspecified).AddTicks(4264), 5L, "Noemi.Hoppe@yahoo.com", "Eulah", "Huels", "Daphnee98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 10L, "Rerum et quidem harum velit omnis tempora.\nNecessitatibus quasi dolorem est facilis nisi non minima et.", new DateTime(2021, 10, 27, 23, 57, 47, 255, DateTimeKind.Unspecified).AddTicks(3568), 4L, "Ethyl75@hotmail.com", "Keegan", "Hartmann", "Jovanny_Kuhn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 33L, "Voluptatem qui sed.\nMaiores dolor sed deserunt cumque vel.", new DateTime(2021, 7, 8, 7, 55, 1, 386, DateTimeKind.Unspecified).AddTicks(761), "Andre27@hotmail.com", "Joesph", "Glover", "Adalberto.Yundt86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { 75L, "Temporibus totam ea voluptatem.\nEveniet error similique adipisci iure architecto quis.", new DateTime(2022, 1, 25, 2, 40, 42, 581, DateTimeKind.Unspecified).AddTicks(4182), 2L, "Kaylah.Harber70@gmail.com", "Michale", "Wiza", "Zetta88" });
        }
    }
}
