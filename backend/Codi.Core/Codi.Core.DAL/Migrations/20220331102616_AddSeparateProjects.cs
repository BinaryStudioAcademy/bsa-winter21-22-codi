using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    public partial class AddSeparateProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_OwnerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 2L, 1L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 2L, 20L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 2L, 26L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 13L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 30L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 33L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 34L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 37L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 4L, 1L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 4L, 16L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 4L, 33L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 22L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 6L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 7L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 13L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 19L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 26L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 28L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 19L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 27L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 9L, 1L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 9L, 6L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 10L, 19L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 10L, 28L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 10L, 30L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 30L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 31L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 12L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 12L, 21L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 12L, 24L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 12L, 27L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 13L, 22L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 13L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 15L, 10L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 15L, 14L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 15L, 24L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 15L, 26L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 12L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 20L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 29L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 17L, 14L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 17L, 26L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 18L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 18L, 31L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 19L, 2L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 19L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 19L, 26L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 21L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 5L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 30L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 23L, 19L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 23L, 37L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 9L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 10L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 12L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 26L, 9L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 26L, 30L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 27L, 5L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 27L, 12L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 27L, 22L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 28L, 37L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 29L, 13L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 29L, 20L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 29L, 32L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 30L, 16L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 30L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 31L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 26L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 4L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 4L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 11L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 26L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 11L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 20L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 30L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 19L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 17L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 17L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 46L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 22L, 36L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 23L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 29L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 29L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 48L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 31L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 32L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 32L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 34L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 36L, 3L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 36L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 36L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 38L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 38L, 26L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 11L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 18L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 51L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 9L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 18L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 26L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 4L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 46L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 36L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 9L });

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Projects");

            migrationBuilder.AddColumn<bool>(
                name: "IsSubmitted",
                table: "Submissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "ProjectId",
                table: "Lessons",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "UserProjects",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    SubmissionId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjects", x => new { x.UserId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_UserProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProjects_Submissions_SubmissionId",
                        column: x => x.SubmissionId,
                        principalTable: "Submissions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProjects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 4L, 26L },
                column: "Id",
                value: 59L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 37L },
                column: "Id",
                value: 50L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 5L },
                column: "Id",
                value: 24L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 26L },
                column: "Id",
                value: 55L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 34L },
                column: "Id",
                value: 68L);

            migrationBuilder.InsertData(
                table: "AppTags",
                columns: new[] { "AppId", "TagId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 11L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 18L, false },
                    { 2L, 23L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 4L, false },
                    { 2L, 29L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 81L, false },
                    { 3L, 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 2L, false },
                    { 3L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 22L, false },
                    { 3L, 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 78L, false },
                    { 5L, 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L, false },
                    { 5L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 7L, false },
                    { 6L, 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 19L, false },
                    { 6L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 79L, false },
                    { 7L, 11L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 32L, false },
                    { 7L, 18L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 6L, false },
                    { 8L, 9L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 34L, false },
                    { 8L, 12L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 36L, false },
                    { 9L, 12L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 30L, false },
                    { 9L, 32L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 23L, false },
                    { 9L, 33L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 17L, false },
                    { 10L, 11L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 33L, false },
                    { 10L, 25L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 11L, false },
                    { 11L, 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 3L, false },
                    { 11L, 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 44L, false },
                    { 12L, 9L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 43L, false },
                    { 12L, 20L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 80L, false },
                    { 12L, 29L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 49L, false },
                    { 13L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 65L, false },
                    { 13L, 31L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 66L, false },
                    { 13L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 48L, false },
                    { 14L, 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 15L, false },
                    { 14L, 9L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 57L, false },
                    { 14L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 28L, false },
                    { 14L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 64L, false },
                    { 14L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 5L, false },
                    { 15L, 21L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 45L, false },
                    { 16L, 3L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 58L, false },
                    { 16L, 15L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 9L, false },
                    { 16L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 35L, false },
                    { 16L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 31L, false }
                });

            migrationBuilder.InsertData(
                table: "AppTags",
                columns: new[] { "AppId", "TagId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 16L, 32L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 20L, false },
                    { 17L, 10L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 14L, false },
                    { 17L, 32L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 54L, false },
                    { 17L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 12L, false },
                    { 19L, 4L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 27L, false },
                    { 19L, 20L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 10L, false },
                    { 19L, 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 25L, false },
                    { 20L, 3L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 39L, false },
                    { 20L, 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 52L, false },
                    { 20L, 35L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 51L, false },
                    { 21L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 74L, false },
                    { 22L, 2L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 40L, false },
                    { 22L, 12L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 75L, false },
                    { 22L, 18L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 71L, false },
                    { 22L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 42L, false },
                    { 22L, 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 16L, false },
                    { 23L, 7L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 73L, false },
                    { 23L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 53L, false },
                    { 24L, 7L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 63L, false },
                    { 24L, 14L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 8L, false },
                    { 24L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 26L, false },
                    { 24L, 21L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 21L, false },
                    { 25L, 21L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 69L, false },
                    { 25L, 27L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 38L, false },
                    { 25L, 35L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 62L, false },
                    { 26L, 16L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 41L, false },
                    { 26L, 35L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 70L, false },
                    { 27L, 4L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 77L, false },
                    { 27L, 20L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 56L, false },
                    { 27L, 29L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 72L, false },
                    { 28L, 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 13L, false },
                    { 28L, 7L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 47L, false },
                    { 29L, 3L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 60L, false },
                    { 29L, 25L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 76L, false },
                    { 29L, 27L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 67L, false },
                    { 29L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 37L, false },
                    { 30L, 2L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 61L, false }
                });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("d298334c-8ab2-bb37-dd5e-6535808f6eab"), new DateTime(2021, 7, 7, 4, 21, 30, 533, DateTimeKind.Unspecified).AddTicks(2877), 1L, "Voluptatem dolor dolorum quia consequatur dolores.\nOptio voluptas molestias officiis necessitatibus placeat ut officiis vel consequuntur.", "Culpa non voluptate ut velit voluptatem earum quae molestiae.", 30L, "protocolInvestment Account", 23L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b7045377-936b-41e9-9f3f-4c2c53e6cfe5"), new DateTime(2021, 11, 29, 22, 53, 14, 696, DateTimeKind.Unspecified).AddTicks(7583), "Sit eos eos soluta ad.\nQui distinctio vel itaque praesentium et vero.", "Libero voluptas suscipit illum repellendus quidem voluptatibus blanditiis.", 44L, "HDDlavenderGorgeous Metal Tuna", 50L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c049b115-7872-31ac-0235-542d533817a9"), new DateTime(2021, 11, 30, 13, 34, 1, 798, DateTimeKind.Unspecified).AddTicks(9928), 4L, "In itaque saepe quis.", "Dolorum saepe cumque velit et totam.", 98L, "North CarolinacircuitRegional", 34L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("a27d502a-9e22-4868-8ea4-a02190f60164"), new DateTime(2021, 11, 6, 4, 49, 57, 563, DateTimeKind.Unspecified).AddTicks(6995), 2L, "Cumque totam sit molestias id sunt labore ut quam et.", "Corrupti beatae praesentium nam qui odio et ipsum.", 18L, "ubiquitousToolsForwardhard drive", 50L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("179ca5de-a60d-4149-c2da-a44e368bf846"), new DateTime(2021, 7, 2, 4, 18, 57, 767, DateTimeKind.Unspecified).AddTicks(2685), 1L, "Ex voluptas voluptatum eveniet voluptas.\nReiciendis ipsa id qui explicabo beatae est nulla.\nMinima rerum dolor eveniet enim reprehenderit.\nQuisquam sit aperiam et non reprehenderit.\nHarum nam ipsa aperiam error.\nIn atque atque repudiandae rerum et quisquam.", "Iure et cum unde enim sit.", 88L, "Buckinghamshirezero administrationprogramming", 37L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b84671c0-1654-2d1d-d18a-a08ea72d9821"), new DateTime(2021, 7, 21, 10, 37, 44, 742, DateTimeKind.Unspecified).AddTicks(6590), 4L, "Rerum ex laboriosam fuga sed laudantium voluptates reiciendis.\nSit nihil voluptas pariatur modi vel.\nVoluptatem accusamus quia et ut rerum similique.", "Voluptatum sunt tempora est maiores repellat eveniet aut provident est.", 81L, "ErgonomicSmall Steel GlovesTools, Computers & Computerssynthesize", 45L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c08938ee-0914-8e7b-ad06-3a40bfb4e8d0"), new DateTime(2021, 10, 20, 13, 27, 22, 914, DateTimeKind.Unspecified).AddTicks(8959), "Doloribus numquam ad voluptatem magni minima expedita aliquam fugit.\nPerspiciatis est sequi corrupti consequatur eum.\nSunt voluptate minima.\nQuia aut molestiae ut iste nihil eos perferendis.\nInventore voluptatibus accusamus.", "Nostrum impedit nam et non ea eligendi.", 6L, "RSSPNG", 28L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("46f59a4c-e0f0-61bb-a08f-1c1a4790cc6b"), new DateTime(2021, 12, 5, 20, 1, 37, 845, DateTimeKind.Unspecified).AddTicks(6639), "Sapiente accusamus praesentium aut voluptatem facilis sunt eum.\nQuia beatae esse velit alias ut deserunt ad.\nCommodi dolorum ut id libero consectetur doloribus in.", "Asperiores quis error at.", 46L, "Licensed Wooden Pizzafront-endsynthesizing", 34L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("75a0f507-f23e-90a7-ed25-4646fb781bb6"), new DateTime(2021, 7, 24, 7, 12, 3, 836, DateTimeKind.Unspecified).AddTicks(9094), 4L, "Eaque placeat soluta odit temporibus cupiditate et.\nEt est voluptatibus ullam accusantium sint eum.\nIllo aspernatur hic voluptatibus temporibus omnis qui repellendus.\nReiciendis et possimus eum veritatis aliquam molestias at.", "Minus modi velit ut sit facere et porro deleniti.", 2L, "open-sourcepartnershipsXML", 39L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("fc47587e-10a0-e46c-a87c-5bf64d484c10"), new DateTime(2021, 11, 30, 10, 43, 46, 979, DateTimeKind.Unspecified).AddTicks(5195), 2L, "Quis et architecto eum atque error fuga eaque maxime.\nBlanditiis similique quis voluptatem quidem reiciendis dolore voluptatem maxime.\nDicta et tempore sequi at quia.", "Quod dolor odio reprehenderit voluptatum dignissimos earum nobis.", 71L, "connectHumanStation", 2L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("4be364cd-23ea-4190-0143-fd8857c07932"), new DateTime(2022, 1, 11, 20, 57, 26, 280, DateTimeKind.Unspecified).AddTicks(3700), 2L, "Voluptas voluptatem in autem autem magni rerum harum cupiditate.", "Rerum sint non commodi.", 86L, "SoftBedfordshirePersonal Loan AccountQuality", 30L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("9ca2a5b2-fadb-55af-f0bc-9b62fc41df56"), new DateTime(2021, 2, 25, 22, 37, 2, 396, DateTimeKind.Unspecified).AddTicks(4191), "Sed quod ducimus in ad doloremque pariatur.\nOfficia possimus maiores.", "Voluptatum vel soluta quia sed aut.", 32L, "East Caribbean DollarCentralPractical", 33L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b8798048-2bb2-5776-55d9-11d30d83ebf1"), new DateTime(2021, 7, 7, 14, 14, 6, 876, DateTimeKind.Unspecified).AddTicks(7554), 2L, "Maiores quo praesentium non ipsa enim blanditiis.\nEt unde velit.\nDolorem amet eos non rem.", "Accusamus quia qui aut qui laudantium ea et fugit.", 41L, "SteelCornersMetalgenerate", 42L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("8a73ddb7-1ce8-64cd-44b7-2d5cad620f05"), new DateTime(2021, 2, 7, 22, 31, 37, 167, DateTimeKind.Unspecified).AddTicks(6861), 4L, "Architecto minima temporibus quaerat id cum necessitatibus.\nIusto consequatur officia ex beatae temporibus facilis.", "Sint deserunt sed non qui nam dignissimos placeat molestias ut.", 94L, "Licensed Concrete FishSQLWay", 20L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("248ae82d-b546-e978-c077-a704bcbea16e"), new DateTime(2021, 11, 26, 0, 12, 29, 662, DateTimeKind.Unspecified).AddTicks(2387), "Et nesciunt esse perferendis aut neque impedit voluptatem.\nIure aperiam incidunt autem inventore distinctio doloribus.\nAut quia in natus ullam.\nEius sit deserunt error architecto veritatis tempora.", "Unde alias dolor at autem sit.", 69L, "supply-chainsmiddlewareMichigan", 26L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c0079e8b-d227-16f5-e5ab-d8c5acbaf661"), new DateTime(2021, 12, 27, 9, 47, 39, 765, DateTimeKind.Unspecified).AddTicks(722), "Saepe velit occaecati vero libero.\nIpsa omnis fugiat possimus nobis explicabo ut laboriosam nobis asperiores.\nArchitecto minus debitis nobis molestias itaque quos temporibus assumenda sit.\nMolestiae iste assumenda beatae molestias laudantium laboriosam laboriosam tempore.\nQui ducimus qui asperiores sequi qui sed ab vitae.\nExcepturi quo et occaecati.", "Eum esse mollitia quidem.", 101L, "AgentCustomizableHome Loan Account", 19L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("7ead84a0-d0ae-e666-aa45-34be0347fa3a"), new DateTime(2021, 10, 2, 18, 22, 6, 898, DateTimeKind.Unspecified).AddTicks(4864), "A beatae facilis placeat et id at consequatur aut.\nRecusandae totam consequatur magnam.\nOccaecati in voluptatem et.", "Tenetur quod est recusandae et sunt inventore magnam dolor.", 28L, "object-orientedNew Israeli Sheqel", 35L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("11ff1838-1312-1343-c8f1-4df5339ca690"), new DateTime(2022, 1, 13, 0, 53, 58, 471, DateTimeKind.Unspecified).AddTicks(8746), "Quam impedit sapiente aut fugiat nam esse.\nNemo omnis non saepe voluptas quae non.\nRem mollitia unde.\nIllo illo non sunt ut delectus omnis facere accusamus.", "Beatae similique distinctio maiores natus architecto molestiae recusandae.", 20L, "FTPBordersClothing", 38L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b7b48e2e-2975-cef4-5a6d-b2f85b9dee79"), new DateTime(2021, 6, 17, 12, 26, 32, 980, DateTimeKind.Unspecified).AddTicks(7588), 1L, "Modi voluptatum aut et minus sed corporis atque.\nOdit id deserunt sed dicta et.\nRepellendus labore itaque cumque autem deleniti ut.\nAt mollitia error dignissimos quo incidunt fuga optio.", "Accusamus quo et fugit.", 58L, "HighwayextendGuinea-Bissau", 14L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("f64aaeec-eb08-1034-10c6-795ef0189132"), new DateTime(2022, 1, 28, 14, 25, 11, 576, DateTimeKind.Unspecified).AddTicks(6305), "Doloremque expedita nisi.\nEt voluptas et odio.\nCommodi minima maxime beatae est dolorum veniam debitis praesentium dolor.", "Iure eos omnis eos assumenda dolorem.", 33L, "Functionalityfirewall", 48L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("1399410e-0bed-f3b6-3343-156d8eeefde4"), new DateTime(2021, 10, 1, 21, 22, 7, 929, DateTimeKind.Unspecified).AddTicks(9081), 5L, "Aliquam magnam quis iure et.", "Occaecati enim maiores nemo doloribus deleniti sint et.", 19L, "innovateHealth, Shoes & Home", 36L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("a95cdcf4-d88d-45a0-5abf-9f64c601dbdb"), new DateTime(2021, 3, 11, 7, 9, 12, 88, DateTimeKind.Unspecified).AddTicks(923), 2L, "Accusantium accusamus est nulla nemo aut beatae iste rem.\nDolorem sequi consectetur.\nMinus eum minus perferendis.", "Repellat ut tenetur est eius possimus dolorem voluptatem eius et.", 3L, "ChiefGorgeous Steel FishmaximizedSoft", 21L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("fd4893ed-eba1-4bd9-8e19-3fcaa60334bc"), new DateTime(2021, 10, 15, 20, 15, 36, 186, DateTimeKind.Unspecified).AddTicks(8021), 2L, "Quia quia maiores aliquam.\nNumquam aliquid corrupti distinctio.", "Voluptatem odio provident.", 16L, "auxiliaryturquoiseGroupmulti-byte", 43L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("539f6ff9-a14a-cb58-311b-d197543466a0"), new DateTime(2022, 1, 30, 18, 58, 24, 273, DateTimeKind.Unspecified).AddTicks(1186), 4L, "Reprehenderit sint non perferendis suscipit.\nLaudantium fugiat nobis.\nCumque dolorem adipisci aut eligendi ea.\nVoluptatem iure reiciendis consectetur voluptatem quaerat voluptates.", "Qui velit soluta.", 92L, "BridgeCustomersuperstructure", 25L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("2c05caa7-6520-7759-3534-e08bcffbd931"), new DateTime(2021, 7, 11, 19, 51, 47, 631, DateTimeKind.Unspecified).AddTicks(7658), 4L, "Et et soluta quos id unde possimus cupiditate debitis.", "Natus dolor nostrum est aut consequuntur aliquam dolorum.", 66L, "indexBedfordshire", 45L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("be81d2b8-2eb3-2131-d150-60100fca6f60"), new DateTime(2021, 11, 9, 8, 20, 27, 133, DateTimeKind.Unspecified).AddTicks(6651), "Quod facere distinctio.", "Et est rem veniam et ut libero sunt eum in.", 87L, "WoninvoiceHandcrafted Soft Bikeusers", 43L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b99e6d5e-e27e-3c4d-fb86-7d69b4bde758"), new DateTime(2021, 10, 28, 6, 56, 3, 787, DateTimeKind.Unspecified).AddTicks(9220), 4L, "Alias ut non.\nQuis ut quisquam consectetur neque dignissimos.\nSequi quia rem occaecati.", "Voluptates non corrupti iusto harum commodi.", 98L, "IllinoisElectronics, Electronics & GamesReactive", 22L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("d4291e06-6072-937b-591d-54a872b7e01e"), new DateTime(2021, 4, 18, 21, 1, 56, 521, DateTimeKind.Unspecified).AddTicks(5517), 1L, "Ratione officia velit fugit tempore dolores accusamus.\nNobis velit amet eos veniam quod totam quia consectetur corrupti.\nAperiam velit laboriosam quos omnis illo aut.\nUllam non ut vel eius qui blanditiis voluptatem voluptatem.\nNumquam ratione sapiente.", "Alias accusantium minus aut omnis sed odio est dolor possimus.", 11L, "primarySMTP", 23L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("4519f096-d750-a686-9109-1f99823b9997"), new DateTime(2021, 4, 23, 10, 19, 55, 269, DateTimeKind.Unspecified).AddTicks(1996), 2L, "Blanditiis amet tenetur similique optio nulla consequuntur quae saepe ratione.\nAb facilis voluptatem ex mollitia iusto.\nNon esse accusamus eaque et sit esse sunt.\nUt omnis expedita repellendus minus voluptate atque.\nId velit alias ex corrupti voluptatem et.", "Deleniti voluptatem qui aut laboriosam dolorum doloremque cupiditate architecto.", 17L, "Arizona24/365Designer", 32L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("31129157-56a9-b0b0-4f6b-e5a982d52731"), new DateTime(2021, 5, 22, 4, 41, 45, 309, DateTimeKind.Unspecified).AddTicks(1173), 4L, "Mollitia cumque ea cupiditate.\nNecessitatibus deserunt dolores.", "Enim dignissimos sequi hic autem consectetur.", 86L, "HorizontalalarmAwesome Soft Mouse", 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 9, 24, 12, 48, 23, 254, DateTimeKind.Unspecified).AddTicks(3606), 1L, 46L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CourseId", "CreatedAt" },
                values: new object[] { 3L, new DateTime(2021, 4, 26, 10, 34, 53, 64, DateTimeKind.Unspecified).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 12L, new DateTime(2022, 1, 2, 12, 58, 21, 685, DateTimeKind.Unspecified).AddTicks(316), 27L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 11, 27, 9, 36, 26, 721, DateTimeKind.Unspecified).AddTicks(2471), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 4, 9, 0, 6, 44, 23, DateTimeKind.Unspecified).AddTicks(4776), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 10, 26, 19, 11, 24, 415, DateTimeKind.Unspecified).AddTicks(150), 3L, 31L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 11, 2, 3, 21, 49, 378, DateTimeKind.Unspecified).AddTicks(4597), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 2, 3, 0, 44, 24, 451, DateTimeKind.Unspecified).AddTicks(1697), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 20L, new DateTime(2021, 3, 10, 21, 31, 49, 642, DateTimeKind.Unspecified).AddTicks(1022), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 8, 31, 18, 51, 41, 811, DateTimeKind.Unspecified).AddTicks(1694), 2L, 33L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 13L, new DateTime(2021, 11, 24, 20, 5, 36, 673, DateTimeKind.Unspecified).AddTicks(550), 50L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 19L, new DateTime(2021, 9, 1, 13, 50, 47, 473, DateTimeKind.Unspecified).AddTicks(8845), 1L, 15L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 4, 23, 18, 25, 57, 179, DateTimeKind.Unspecified).AddTicks(2330), 1L, 21L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 17L, new DateTime(2021, 2, 19, 12, 39, 43, 600, DateTimeKind.Unspecified).AddTicks(5304), 47L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy" },
                values: new object[] { 15L, new DateTime(2021, 4, 16, 16, 58, 23, 629, DateTimeKind.Unspecified).AddTicks(1303), 3L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 11, 15, 22, 59, 21, 336, DateTimeKind.Unspecified).AddTicks(2102), 1L, 35L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2022, 1, 3, 8, 30, 37, 119, DateTimeKind.Unspecified).AddTicks(2926), 3L, 45L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 20L, new DateTime(2022, 2, 1, 2, 47, 28, 464, DateTimeKind.Unspecified).AddTicks(3908), 5L, 26L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2021, 12, 11, 3, 49, 35, 96, DateTimeKind.Unspecified).AddTicks(9251), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 8, 19, 5, 37, 44, 335, DateTimeKind.Unspecified).AddTicks(6388), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy" },
                values: new object[] { 10L, new DateTime(2021, 10, 13, 13, 4, 22, 250, DateTimeKind.Unspecified).AddTicks(445), 4L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 14L, new DateTime(2021, 3, 21, 9, 24, 0, 573, DateTimeKind.Unspecified).AddTicks(2923), 5L, 46L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 10, 18, 4, 58, 45, 874, DateTimeKind.Unspecified).AddTicks(3727), 46L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2022, 1, 25, 7, 13, 41, 983, DateTimeKind.Unspecified).AddTicks(2288), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 12, 17, 6, 22, 30, 813, DateTimeKind.Unspecified).AddTicks(1224), 1L, 49L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 8, 19, 4, 14, 3, 369, DateTimeKind.Unspecified).AddTicks(7101), 17L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 7, 26, 11, 14, 54, 876, DateTimeKind.Unspecified).AddTicks(8119), 4L, 45L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2022, 1, 14, 6, 49, 13, 242, DateTimeKind.Unspecified).AddTicks(5324), 5L, 37L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 21L, new DateTime(2021, 10, 23, 20, 10, 45, 719, DateTimeKind.Unspecified).AddTicks(6187), 1L, 36L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 11, 7, 13, 29, 26, 208, DateTimeKind.Unspecified).AddTicks(8963), 31L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 15L, new DateTime(2021, 12, 9, 9, 47, 41, 896, DateTimeKind.Unspecified).AddTicks(4628), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 13L, new DateTime(2022, 1, 21, 1, 32, 55, 21, DateTimeKind.Unspecified).AddTicks(2218), 5L, 31L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 6, 21, 20, 1, 49, 71, DateTimeKind.Unspecified).AddTicks(8754), 1L, 46L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 18L, new DateTime(2021, 6, 25, 4, 17, 36, 439, DateTimeKind.Unspecified).AddTicks(5664), 48L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 3, 31, 0, 34, 56, 679, DateTimeKind.Unspecified).AddTicks(8777), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 12, 12, 8, 49, 56, 59, DateTimeKind.Unspecified).AddTicks(6575), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 11, 19, 20, 10, 40, 892, DateTimeKind.Unspecified).AddTicks(4873), 3L, 50L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2021, 6, 13, 20, 43, 36, 356, DateTimeKind.Unspecified).AddTicks(8487), 8L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 17L, new DateTime(2021, 10, 10, 22, 4, 48, 884, DateTimeKind.Unspecified).AddTicks(5158), 5L, 42L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 13L, new DateTime(2021, 5, 31, 10, 49, 22, 562, DateTimeKind.Unspecified).AddTicks(1292), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 3, 27, 9, 31, 34, 973, DateTimeKind.Unspecified).AddTicks(4833), 1L, 45L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 13L, new DateTime(2021, 8, 30, 23, 10, 34, 27, DateTimeKind.Unspecified).AddTicks(5527), 5L, 44L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 5, 20, 4, 34, 21, 403, DateTimeKind.Unspecified).AddTicks(4178), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 10, 16, 22, 24, 12, 295, DateTimeKind.Unspecified).AddTicks(7477), 4L, 27L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 6, 10, 1, 36, 10, 556, DateTimeKind.Unspecified).AddTicks(8743), 50L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy" },
                values: new object[] { 21L, new DateTime(2022, 1, 4, 15, 28, 9, 540, DateTimeKind.Unspecified).AddTicks(1678), 3L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 8, 16, 11, 25, 11, 831, DateTimeKind.Unspecified).AddTicks(9450), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 11, 21, 2, 14, 37, 703, DateTimeKind.Unspecified).AddTicks(5646), 5L, 43L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 9, 13, 22, 27, 20, 922, DateTimeKind.Unspecified).AddTicks(2041), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 9, 1, 12, 53, 56, 522, DateTimeKind.Unspecified).AddTicks(9614), 1L, 34L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 13L, new DateTime(2021, 8, 24, 4, 37, 15, 704, DateTimeKind.Unspecified).AddTicks(5445), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 21L, new DateTime(2021, 3, 18, 0, 47, 2, 401, DateTimeKind.Unspecified).AddTicks(5905), 1L, 26L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 9, 26, 20, 7, 7, 861, DateTimeKind.Unspecified).AddTicks(9791), 5L, 40L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 16L, new DateTime(2022, 1, 21, 10, 25, 27, 569, DateTimeKind.Unspecified).AddTicks(1073), 42L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 11, 10, 16, 52, 19, 659, DateTimeKind.Unspecified).AddTicks(8309), 1L, 24L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 15L, new DateTime(2021, 7, 6, 8, 23, 41, 167, DateTimeKind.Unspecified).AddTicks(4950), 2L, 23L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 19L, new DateTime(2021, 6, 16, 23, 45, 34, 55, DateTimeKind.Unspecified).AddTicks(9940), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2021, 5, 18, 21, 47, 22, 321, DateTimeKind.Unspecified).AddTicks(2923), 4L, 21L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 4, 4, 7, 33, 45, 528, DateTimeKind.Unspecified).AddTicks(9845), 5L, 40L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 12, 14, 9, 1, 41, 712, DateTimeKind.Unspecified).AddTicks(4789), 3L, 22L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 20L, new DateTime(2021, 10, 3, 17, 42, 11, 159, DateTimeKind.Unspecified).AddTicks(8404), 4L, 40L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 15L, new DateTime(2021, 3, 3, 9, 16, 4, 234, DateTimeKind.Unspecified).AddTicks(9384), 45L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 4, 11, 4, 51, 22, 499, DateTimeKind.Unspecified).AddTicks(1874), 1L, 24L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 12L, new DateTime(2021, 3, 9, 20, 42, 52, 973, DateTimeKind.Unspecified).AddTicks(3382), 4L, 40L });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "Id", "CourseId", "CourseRole", "CreatedAt", "CreatedBy", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { 13L, 21L, 0, new DateTime(2021, 2, 12, 17, 56, 20, 427, DateTimeKind.Unspecified).AddTicks(8555), 4L, false, 12L },
                    { 38L, 11L, 0, new DateTime(2021, 4, 12, 5, 10, 33, 577, DateTimeKind.Unspecified).AddTicks(9575), 1L, false, 3L },
                    { 50L, 12L, 0, new DateTime(2021, 5, 22, 8, 3, 39, 630, DateTimeKind.Unspecified).AddTicks(8614), 4L, false, 46L },
                    { 54L, 2L, 0, new DateTime(2021, 6, 16, 20, 22, 41, 170, DateTimeKind.Unspecified).AddTicks(936), 5L, false, 23L },
                    { 59L, 4L, 0, new DateTime(2021, 11, 22, 23, 51, 44, 579, DateTimeKind.Unspecified).AddTicks(5125), 1L, false, 40L },
                    { 69L, 3L, 0, new DateTime(2021, 6, 26, 7, 7, 26, 223, DateTimeKind.Unspecified).AddTicks(2873), 5L, false, 20L }
                });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 19L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 7, 1, 21, 32, 7, 601, DateTimeKind.Unspecified).AddTicks(3288), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 12L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 10, 21, 4, 49, 27, 128, DateTimeKind.Unspecified).AddTicks(2179), 3L, 41L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 28L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 2, 2, 2, 56, 24, 927, DateTimeKind.Unspecified).AddTicks(9066), 1L, 15L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 7L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 12, 23, 12, 29, 59, 629, DateTimeKind.Unspecified).AddTicks(8895), 13L });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 10L, new DateTime(2021, 7, 19, 23, 51, 44, 535, DateTimeKind.Unspecified).AddTicks(1354), 5L, 47L, false },
                    { 2L, 25L, new DateTime(2022, 1, 1, 5, 17, 25, 464, DateTimeKind.Unspecified).AddTicks(7600), 2L, 79L, false },
                    { 2L, 28L, new DateTime(2021, 9, 26, 23, 22, 50, 885, DateTimeKind.Unspecified).AddTicks(7973), 5L, 81L, false },
                    { 3L, 39L, new DateTime(2021, 4, 10, 20, 15, 15, 233, DateTimeKind.Unspecified).AddTicks(231), 2L, 34L, false },
                    { 4L, 13L, new DateTime(2022, 1, 16, 0, 1, 27, 42, DateTimeKind.Unspecified).AddTicks(9397), 2L, 73L, false },
                    { 4L, 29L, new DateTime(2021, 9, 13, 13, 56, 49, 988, DateTimeKind.Unspecified).AddTicks(7560), 4L, 100L, false },
                    { 4L, 39L, new DateTime(2021, 3, 29, 21, 34, 43, 381, DateTimeKind.Unspecified).AddTicks(7352), 5L, 78L, false },
                    { 4L, 41L, new DateTime(2021, 9, 22, 22, 19, 30, 418, DateTimeKind.Unspecified).AddTicks(973), 1L, 16L, false },
                    { 5L, 37L, new DateTime(2021, 9, 28, 14, 25, 29, 692, DateTimeKind.Unspecified).AddTicks(3641), 2L, 53L, false },
                    { 6L, 10L, new DateTime(2021, 8, 9, 14, 7, 39, 693, DateTimeKind.Unspecified).AddTicks(1381), 4L, 60L, false },
                    { 6L, 16L, new DateTime(2021, 8, 4, 1, 12, 59, 140, DateTimeKind.Unspecified).AddTicks(3612), 4L, 54L, false },
                    { 7L, 22L, new DateTime(2022, 1, 12, 19, 21, 57, 392, DateTimeKind.Unspecified).AddTicks(4309), 5L, 49L, false },
                    { 7L, 35L, new DateTime(2022, 1, 30, 16, 19, 9, 915, DateTimeKind.Unspecified).AddTicks(7643), 4L, 59L, false },
                    { 7L, 44L, new DateTime(2021, 8, 6, 12, 12, 28, 410, DateTimeKind.Unspecified).AddTicks(8072), 5L, 10L, false },
                    { 7L, 49L, new DateTime(2021, 9, 15, 18, 21, 1, 436, DateTimeKind.Unspecified).AddTicks(7212), 1L, 19L, false },
                    { 8L, 11L, new DateTime(2022, 1, 13, 18, 8, 35, 361, DateTimeKind.Unspecified).AddTicks(5078), 2L, 97L, false },
                    { 8L, 29L, new DateTime(2021, 9, 12, 21, 26, 8, 515, DateTimeKind.Unspecified).AddTicks(5274), 4L, 43L, false },
                    { 8L, 40L, new DateTime(2021, 2, 24, 6, 23, 49, 480, DateTimeKind.Unspecified).AddTicks(6498), 4L, 65L, false },
                    { 8L, 43L, new DateTime(2021, 5, 24, 14, 53, 17, 769, DateTimeKind.Unspecified).AddTicks(5774), 2L, 18L, false },
                    { 9L, 33L, new DateTime(2021, 12, 13, 4, 26, 50, 584, DateTimeKind.Unspecified).AddTicks(1368), 5L, 48L, false },
                    { 10L, 14L, new DateTime(2021, 4, 27, 19, 24, 27, 117, DateTimeKind.Unspecified).AddTicks(262), 2L, 93L, false },
                    { 12L, 2L, new DateTime(2021, 7, 17, 6, 39, 47, 767, DateTimeKind.Unspecified).AddTicks(1041), 1L, 38L, false },
                    { 12L, 12L, new DateTime(2021, 3, 14, 2, 1, 35, 971, DateTimeKind.Unspecified).AddTicks(2927), 1L, 55L, false },
                    { 12L, 17L, new DateTime(2021, 12, 13, 8, 2, 2, 688, DateTimeKind.Unspecified).AddTicks(3174), 2L, 39L, false },
                    { 13L, 6L, new DateTime(2021, 2, 7, 14, 37, 14, 811, DateTimeKind.Unspecified).AddTicks(4929), 3L, 26L, false },
                    { 13L, 27L, new DateTime(2022, 1, 4, 6, 12, 11, 100, DateTimeKind.Unspecified).AddTicks(883), 3L, 37L, false },
                    { 14L, 23L, new DateTime(2021, 11, 26, 16, 47, 53, 456, DateTimeKind.Unspecified).AddTicks(4064), 3L, 33L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 14L, 37L, new DateTime(2021, 11, 24, 11, 12, 2, 418, DateTimeKind.Unspecified).AddTicks(4030), 1L, 96L, false },
                    { 14L, 47L, new DateTime(2021, 12, 14, 14, 19, 6, 620, DateTimeKind.Unspecified).AddTicks(4526), 1L, 42L, false },
                    { 15L, 24L, new DateTime(2021, 5, 18, 9, 20, 11, 488, DateTimeKind.Unspecified).AddTicks(9987), 4L, 82L, false },
                    { 15L, 38L, new DateTime(2021, 5, 11, 20, 25, 25, 794, DateTimeKind.Unspecified).AddTicks(1052), 1L, 30L, false },
                    { 16L, 9L, new DateTime(2021, 3, 18, 11, 37, 17, 99, DateTimeKind.Unspecified).AddTicks(4658), 3L, 51L, false },
                    { 16L, 38L, new DateTime(2021, 10, 25, 23, 25, 40, 301, DateTimeKind.Unspecified).AddTicks(9776), 2L, 66L, false },
                    { 17L, 4L, new DateTime(2021, 4, 28, 12, 23, 19, 593, DateTimeKind.Unspecified).AddTicks(5558), 2L, 21L, false },
                    { 18L, 41L, new DateTime(2021, 11, 23, 12, 7, 23, 787, DateTimeKind.Unspecified).AddTicks(9170), 1L, 35L, false },
                    { 19L, 13L, new DateTime(2021, 4, 20, 2, 40, 53, 103, DateTimeKind.Unspecified).AddTicks(3889), 1L, 36L, false },
                    { 20L, 9L, new DateTime(2021, 9, 1, 5, 58, 11, 85, DateTimeKind.Unspecified).AddTicks(3322), 3L, 87L, false },
                    { 21L, 10L, new DateTime(2021, 5, 9, 4, 28, 15, 777, DateTimeKind.Unspecified).AddTicks(6398), 1L, 22L, false },
                    { 24L, 2L, new DateTime(2021, 4, 2, 22, 0, 56, 429, DateTimeKind.Unspecified).AddTicks(73), 3L, 58L, false },
                    { 24L, 31L, new DateTime(2021, 2, 9, 9, 42, 50, 145, DateTimeKind.Unspecified).AddTicks(5205), 4L, 99L, false },
                    { 25L, 29L, new DateTime(2021, 4, 5, 8, 8, 54, 898, DateTimeKind.Unspecified).AddTicks(2724), 3L, 28L, false },
                    { 25L, 45L, new DateTime(2021, 4, 28, 13, 21, 0, 488, DateTimeKind.Unspecified).AddTicks(4848), 3L, 2L, false },
                    { 26L, 23L, new DateTime(2021, 5, 19, 8, 16, 42, 251, DateTimeKind.Unspecified).AddTicks(2798), 5L, 63L, false },
                    { 26L, 42L, new DateTime(2022, 1, 5, 23, 30, 53, 570, DateTimeKind.Unspecified).AddTicks(8881), 5L, 25L, false },
                    { 27L, 5L, new DateTime(2021, 3, 22, 15, 28, 44, 743, DateTimeKind.Unspecified).AddTicks(7990), 2L, 91L, false },
                    { 28L, 13L, new DateTime(2022, 1, 13, 6, 34, 56, 555, DateTimeKind.Unspecified).AddTicks(8490), 4L, 6L, false },
                    { 28L, 21L, new DateTime(2021, 9, 7, 20, 59, 28, 181, DateTimeKind.Unspecified).AddTicks(165), 3L, 56L, false },
                    { 29L, 14L, new DateTime(2021, 11, 21, 21, 25, 54, 904, DateTimeKind.Unspecified).AddTicks(2554), 5L, 75L, false },
                    { 29L, 29L, new DateTime(2021, 9, 12, 16, 2, 33, 29, DateTimeKind.Unspecified).AddTicks(1975), 1L, 101L, false },
                    { 29L, 34L, new DateTime(2021, 11, 24, 6, 21, 30, 21, DateTimeKind.Unspecified).AddTicks(9011), 4L, 67L, false },
                    { 29L, 39L, new DateTime(2021, 4, 3, 5, 57, 55, 489, DateTimeKind.Unspecified).AddTicks(8425), 2L, 45L, false },
                    { 30L, 12L, new DateTime(2022, 1, 8, 12, 53, 58, 468, DateTimeKind.Unspecified).AddTicks(7163), 5L, 57L, false },
                    { 30L, 34L, new DateTime(2021, 7, 9, 18, 39, 35, 627, DateTimeKind.Unspecified).AddTicks(572), 5L, 61L, false },
                    { 30L, 36L, new DateTime(2021, 3, 14, 10, 18, 53, 131, DateTimeKind.Unspecified).AddTicks(3351), 2L, 90L, false },
                    { 30L, 39L, new DateTime(2021, 10, 2, 19, 41, 36, 866, DateTimeKind.Unspecified).AddTicks(7822), 5L, 62L, false },
                    { 32L, 12L, new DateTime(2022, 1, 24, 15, 51, 46, 566, DateTimeKind.Unspecified).AddTicks(2784), 1L, 3L, false },
                    { 32L, 50L, new DateTime(2021, 12, 19, 19, 46, 29, 120, DateTimeKind.Unspecified).AddTicks(6387), 5L, 14L, false },
                    { 33L, 26L, new DateTime(2021, 4, 9, 11, 10, 22, 891, DateTimeKind.Unspecified).AddTicks(8054), 2L, 69L, false },
                    { 33L, 37L, new DateTime(2021, 7, 31, 18, 3, 42, 447, DateTimeKind.Unspecified).AddTicks(635), 4L, 71L, false },
                    { 34L, 46L, new DateTime(2021, 2, 11, 12, 35, 40, 308, DateTimeKind.Unspecified).AddTicks(5890), 5L, 40L, false },
                    { 35L, 29L, new DateTime(2021, 8, 23, 6, 16, 36, 440, DateTimeKind.Unspecified).AddTicks(7534), 4L, 88L, false },
                    { 36L, 22L, new DateTime(2021, 12, 24, 4, 42, 4, 110, DateTimeKind.Unspecified).AddTicks(7856), 2L, 68L, false },
                    { 36L, 27L, new DateTime(2021, 10, 10, 11, 21, 25, 692, DateTimeKind.Unspecified).AddTicks(3547), 2L, 52L, false },
                    { 37L, 5L, new DateTime(2021, 2, 7, 2, 41, 48, 621, DateTimeKind.Unspecified).AddTicks(2531), 4L, 32L, false },
                    { 37L, 16L, new DateTime(2021, 11, 13, 18, 29, 38, 709, DateTimeKind.Unspecified).AddTicks(9969), 5L, 46L, false },
                    { 37L, 31L, new DateTime(2021, 6, 1, 11, 47, 10, 376, DateTimeKind.Unspecified).AddTicks(711), 1L, 72L, false },
                    { 37L, 35L, new DateTime(2021, 9, 21, 14, 21, 39, 927, DateTimeKind.Unspecified).AddTicks(7281), 1L, 20L, false },
                    { 39L, 10L, new DateTime(2021, 11, 29, 15, 59, 38, 135, DateTimeKind.Unspecified).AddTicks(5172), 2L, 77L, false },
                    { 39L, 26L, new DateTime(2022, 1, 23, 15, 5, 11, 755, DateTimeKind.Unspecified).AddTicks(5260), 5L, 92L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 39L, 49L, new DateTime(2021, 9, 25, 23, 50, 58, 127, DateTimeKind.Unspecified).AddTicks(3807), 5L, 12L, false },
                    { 40L, 23L, new DateTime(2021, 9, 26, 4, 54, 6, 997, DateTimeKind.Unspecified).AddTicks(1486), 4L, 74L, false },
                    { 41L, 6L, new DateTime(2022, 1, 5, 19, 48, 51, 781, DateTimeKind.Unspecified).AddTicks(9451), 2L, 95L, false },
                    { 42L, 34L, new DateTime(2021, 2, 20, 19, 22, 16, 750, DateTimeKind.Unspecified).AddTicks(2820), 4L, 80L, false },
                    { 43L, 10L, new DateTime(2021, 8, 7, 6, 45, 54, 32, DateTimeKind.Unspecified).AddTicks(9912), 5L, 29L, false },
                    { 43L, 25L, new DateTime(2021, 6, 4, 9, 49, 53, 550, DateTimeKind.Unspecified).AddTicks(1845), 3L, 94L, false },
                    { 44L, 26L, new DateTime(2021, 12, 2, 2, 51, 21, 624, DateTimeKind.Unspecified).AddTicks(1402), 5L, 86L, false },
                    { 44L, 38L, new DateTime(2021, 12, 3, 13, 55, 10, 671, DateTimeKind.Unspecified).AddTicks(5719), 3L, 8L, false },
                    { 44L, 45L, new DateTime(2022, 1, 9, 21, 5, 17, 314, DateTimeKind.Unspecified).AddTicks(7898), 5L, 11L, false },
                    { 45L, 7L, new DateTime(2021, 6, 30, 1, 7, 18, 614, DateTimeKind.Unspecified).AddTicks(1453), 4L, 17L, false },
                    { 45L, 8L, new DateTime(2021, 8, 28, 2, 23, 40, 31, DateTimeKind.Unspecified).AddTicks(3415), 4L, 7L, false },
                    { 45L, 40L, new DateTime(2021, 12, 16, 21, 10, 51, 535, DateTimeKind.Unspecified).AddTicks(5882), 2L, 98L, false },
                    { 46L, 37L, new DateTime(2021, 3, 29, 12, 44, 27, 346, DateTimeKind.Unspecified).AddTicks(4869), 2L, 85L, false },
                    { 46L, 45L, new DateTime(2021, 12, 6, 12, 11, 19, 969, DateTimeKind.Unspecified).AddTicks(2552), 3L, 83L, false },
                    { 47L, 36L, new DateTime(2021, 12, 11, 11, 32, 7, 296, DateTimeKind.Unspecified).AddTicks(6399), 4L, 4L, false },
                    { 47L, 42L, new DateTime(2021, 2, 28, 0, 19, 22, 606, DateTimeKind.Unspecified).AddTicks(1668), 4L, 5L, false },
                    { 47L, 47L, new DateTime(2021, 10, 31, 10, 56, 40, 608, DateTimeKind.Unspecified).AddTicks(3955), 5L, 50L, false },
                    { 48L, 37L, new DateTime(2021, 6, 10, 20, 5, 30, 277, DateTimeKind.Unspecified).AddTicks(1533), 4L, 70L, false },
                    { 49L, 14L, new DateTime(2021, 7, 4, 0, 5, 4, 262, DateTimeKind.Unspecified).AddTicks(7232), 1L, 23L, false },
                    { 49L, 35L, new DateTime(2021, 3, 20, 11, 38, 43, 966, DateTimeKind.Unspecified).AddTicks(4660), 2L, 31L, false },
                    { 50L, 45L, new DateTime(2021, 3, 16, 8, 6, 1, 244, DateTimeKind.Unspecified).AddTicks(4164), 4L, 89L, false },
                    { 50L, 47L, new DateTime(2021, 4, 12, 9, 36, 41, 283, DateTimeKind.Unspecified).AddTicks(1477), 4L, 24L, false },
                    { 51L, 11L, new DateTime(2021, 10, 4, 6, 33, 5, 653, DateTimeKind.Unspecified).AddTicks(2922), 3L, 44L, false },
                    { 51L, 35L, new DateTime(2021, 3, 28, 2, 57, 57, 951, DateTimeKind.Unspecified).AddTicks(8237), 1L, 27L, false },
                    { 51L, 42L, new DateTime(2021, 6, 19, 16, 14, 31, 284, DateTimeKind.Unspecified).AddTicks(4048), 5L, 64L, false }
                });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 3, 8, 22, 48, 27, 995, DateTimeKind.Unspecified).AddTicks(7182), 4L, "Assumenda rerum porro quidem impedit.\nEst quam dolor maiores dolorem cumque veritatis quibusdam accusantium eius.", new DateTime(2023, 5, 18, 11, 29, 25, 130, DateTimeKind.Unspecified).AddTicks(7120), 12L, "Non perferendis laudantium sed aut natus.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 2, 6, 20, 38, 22, 621, DateTimeKind.Unspecified).AddTicks(8373), 3L, "Consequuntur officiis et eligendi quis illum molestias enim.", new DateTime(2023, 5, 18, 3, 21, 55, 624, DateTimeKind.Unspecified).AddTicks(907), 14L, "Et quia voluptatum sint qui soluta et labore dicta qui.", 24L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2022, 1, 11, 16, 46, 58, 758, DateTimeKind.Unspecified).AddTicks(9763), 2L, "Dolores quia quo dolores beatae qui et.\nPossimus in explicabo est quod sed laudantium.\nCumque voluptates ut.\nNihil inventore provident laboriosam sed blanditiis corrupti.\nDoloribus voluptatum ut voluptatem rerum suscipit adipisci.", new DateTime(2022, 4, 2, 17, 47, 3, 404, DateTimeKind.Unspecified).AddTicks(4030), true, 25L, "Placeat unde praesentium error est aut.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 6, 22, 13, 53, 45, 805, DateTimeKind.Unspecified).AddTicks(5264), 4L, "Velit debitis iusto cum dolores autem dolorum.\nBeatae dolorum minima.\nEst rerum ea et eum aut.\nCum non aut ut ea rerum consectetur suscipit.\nVero blanditiis et et dicta repellendus rem blanditiis.", new DateTime(2023, 8, 9, 11, 16, 52, 493, DateTimeKind.Unspecified).AddTicks(318), 50L, "Officia voluptatem repellendus impedit harum vitae autem eos.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 2, 10, 20, 33, 47, 696, DateTimeKind.Unspecified).AddTicks(8347), 1L, "Cumque enim dolorem eos voluptas corporis reiciendis aperiam.\nNemo ipsa accusamus et fuga consequatur nam velit.", new DateTime(2024, 1, 25, 5, 22, 18, 752, DateTimeKind.Unspecified).AddTicks(7288), false, 32L, "Autem sunt autem ut.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 11, 28, 19, 13, 2, 676, DateTimeKind.Unspecified).AddTicks(5621), 4L, "Vel et dignissimos ratione facere ut ducimus rerum praesentium.", new DateTime(2022, 6, 4, 22, 29, 45, 320, DateTimeKind.Unspecified).AddTicks(127), false, 31L, "Magnam quisquam quisquam.", 31L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2022, 1, 23, 4, 46, 12, 270, DateTimeKind.Unspecified).AddTicks(7754), 4L, "Odit beatae beatae qui aliquam consequatur debitis quos.\nMolestiae explicabo accusamus expedita numquam totam provident.\nTotam odio ullam odio.\nIpsam provident a ut ipsam dolor.", new DateTime(2022, 12, 12, 0, 49, 33, 977, DateTimeKind.Unspecified).AddTicks(3928), 36L, "Voluptas dolor quo cum iure corrupti ea perspiciatis.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 7, 31, 5, 17, 17, 880, DateTimeKind.Unspecified).AddTicks(3312), 5L, "Dolores quia at et necessitatibus aut molestiae.\nEt omnis unde fuga.\nEligendi optio veritatis nam laboriosam quos voluptas sapiente.\nId voluptatem distinctio et est et facere et repellat.\nVeritatis voluptatem illum aut sunt nihil adipisci et animi atque.", new DateTime(2023, 7, 7, 13, 7, 10, 92, DateTimeKind.Unspecified).AddTicks(2644), false, 3L, "Vel qui modi porro et est reiciendis voluptatem fuga.", 6L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 12, 19, 9, 11, 51, 184, DateTimeKind.Unspecified).AddTicks(9328), 5L, "Est vel molestiae praesentium magni voluptas rerum.\nEligendi debitis quisquam corrupti a qui doloribus.\nVoluptatum nesciunt et voluptatem.\nMinus cumque qui consequuntur amet sit est perferendis.", new DateTime(2023, 1, 3, 20, 15, 21, 776, DateTimeKind.Unspecified).AddTicks(5000), true, 29L, "Enim voluptatibus dolores ab natus fuga animi.", 6L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 5, 30, 20, 8, 16, 751, DateTimeKind.Unspecified).AddTicks(844), "Quo ratione consequatur dicta totam.", new DateTime(2022, 4, 16, 13, 46, 13, 304, DateTimeKind.Unspecified).AddTicks(2188), false, 28L, "Accusantium culpa laboriosam consectetur in vel ratione eum.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 10, 7, 15, 34, 15, 710, DateTimeKind.Unspecified).AddTicks(9036), 3L, "In neque consequuntur corporis sint iste.\nDoloribus fugiat sit.\nQuia autem est enim corrupti labore et ducimus.", new DateTime(2022, 5, 20, 3, 31, 27, 539, DateTimeKind.Unspecified).AddTicks(7577), false, 44L, "Placeat accusamus unde ut nobis aliquid et quo mollitia et.", 25L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 10, 6, 19, 22, 53, 774, DateTimeKind.Unspecified).AddTicks(7845), "Itaque aliquam culpa repellat quia sint laboriosam fugit similique et.\nEos sapiente beatae magni mollitia.\nQuam quam facere earum in aut qui laboriosam explicabo voluptatibus.\nIpsam earum ut sapiente id quo.", new DateTime(2022, 10, 4, 3, 1, 10, 858, DateTimeKind.Unspecified).AddTicks(396), false, 33L, "Aperiam occaecati sint labore minima et.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 3, 13, 17, 46, 23, 796, DateTimeKind.Unspecified).AddTicks(884), "Eos qui rerum rerum commodi.\nMagni distinctio accusantium provident et quibusdam.\nEveniet vel quia quia maxime ut itaque suscipit.\nTemporibus qui nihil.\nQui rerum et deserunt accusantium dicta qui.", new DateTime(2023, 6, 6, 14, 2, 23, 314, DateTimeKind.Unspecified).AddTicks(9707), 50L, "Voluptatem beatae molestias quisquam et tenetur iure.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 11, 26, 3, 53, 46, 118, DateTimeKind.Unspecified).AddTicks(2955), 4L, "Autem non corrupti reiciendis itaque voluptas aperiam.", new DateTime(2023, 1, 25, 11, 39, 24, 121, DateTimeKind.Unspecified).AddTicks(6697), 4L, "Ut exercitationem aspernatur quos quisquam qui dolor.", 19L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 4, 27, 21, 10, 12, 516, DateTimeKind.Unspecified).AddTicks(9304), 3L, "Velit commodi et.\nUt nihil sequi unde illum sit eius vel.\nEsse minus quisquam odit commodi quis neque.\nNisi molestiae eos.", new DateTime(2023, 4, 8, 7, 6, 28, 634, DateTimeKind.Unspecified).AddTicks(9052), true, 46L, "Dolor ea tenetur velit labore enim ut.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 2, 11, 15, 20, 45, 859, DateTimeKind.Unspecified).AddTicks(9750), 5L, "Officia illum et quia consequatur.\nNumquam eligendi sit.\nEius eligendi magni et eos est et et iusto itaque.\nConsectetur eum quo.\nNon est architecto autem incidunt pariatur neque possimus voluptas.", new DateTime(2023, 8, 22, 20, 51, 5, 766, DateTimeKind.Unspecified).AddTicks(6020), 46L, "Odio commodi similique sunt.", 27L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 12, 13, 6, 21, 32, 871, DateTimeKind.Unspecified).AddTicks(910), 2L, "Et qui et.", new DateTime(2023, 12, 20, 17, 22, 56, 403, DateTimeKind.Unspecified).AddTicks(2387), true, 17L, "Non suscipit modi architecto possimus nihil minima eum ullam et.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 2, 26, 22, 26, 10, 542, DateTimeKind.Unspecified).AddTicks(989), 3L, "Sit explicabo sed.\nQuia nam ab quos nihil.", new DateTime(2022, 6, 6, 14, 43, 13, 948, DateTimeKind.Unspecified).AddTicks(8330), 19L, "Inventore itaque consequatur magni.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 4, 25, 16, 51, 41, 205, DateTimeKind.Unspecified).AddTicks(1209), 2L, "Adipisci dolorem eos iure exercitationem ut qui.\nVoluptate animi id.\nQui eum ducimus.", new DateTime(2023, 6, 18, 21, 16, 7, 738, DateTimeKind.Unspecified).AddTicks(5404), 2L, "Occaecati eum sed similique quos provident natus molestias.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 4, 5, 15, 22, 37, 707, DateTimeKind.Unspecified).AddTicks(8496), "Est natus reiciendis dolor et dicta at.", new DateTime(2022, 9, 27, 20, 19, 31, 958, DateTimeKind.Unspecified).AddTicks(440), false, 42L, "Quia pariatur placeat.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 11, 5, 17, 15, 53, 191, DateTimeKind.Unspecified).AddTicks(2914), 4L, "Voluptate dolores recusandae ut perspiciatis omnis adipisci.\nNulla dolorum a velit facilis non.\nQuia corrupti odit.\nA quia at animi eius consequatur aspernatur.\nEsse rerum ullam quos et dolorem.", new DateTime(2023, 2, 20, 4, 18, 11, 98, DateTimeKind.Unspecified).AddTicks(4007), true, 23L, "Molestiae doloribus atque et id sed et voluptatem atque dolorem.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 6, 8, 1, 27, 58, 528, DateTimeKind.Unspecified).AddTicks(1206), 5L, "Est autem et pariatur ex omnis sed quo.\nDucimus quia omnis perspiciatis.\nMagni nisi officia quia beatae recusandae corrupti.\nSoluta laudantium sit dolorem.\nAutem amet exercitationem sunt et nihil quia non fugit.", new DateTime(2024, 1, 5, 9, 54, 28, 707, DateTimeKind.Unspecified).AddTicks(2115), 48L, "Eum sunt aut aperiam quasi consequatur non.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 10, 2, 1, 15, 7, 757, DateTimeKind.Unspecified).AddTicks(9296), 2L, "Eligendi consectetur sint non autem quod non.", new DateTime(2023, 11, 5, 14, 1, 50, 510, DateTimeKind.Unspecified).AddTicks(7230), 2L, "Qui pariatur quo perspiciatis cum est atque rerum magni inventore.", 2L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 7, 18, 23, 24, 20, 698, DateTimeKind.Unspecified).AddTicks(239), 1L, "Atque maiores numquam sed dolores consequatur quia aut.\nPerferendis alias nihil est praesentium.\nOdit repudiandae reprehenderit consectetur et est dolores quas.\nNam enim officiis recusandae hic dolor fuga.", new DateTime(2022, 10, 13, 23, 32, 43, 880, DateTimeKind.Unspecified).AddTicks(2074), 30L, "Laborum hic sit minima similique dolor.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 11, 29, 1, 18, 58, 654, DateTimeKind.Unspecified).AddTicks(8467), 3L, "Sit officia est voluptatem nemo.\nCommodi quia doloribus.\nDicta maiores atque.\nQui amet itaque enim neque qui iure et.\nIpsam molestiae aspernatur non nostrum ea.", new DateTime(2022, 5, 1, 8, 16, 14, 880, DateTimeKind.Unspecified).AddTicks(3158), 27L, "Et sequi ut.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 2, 25, 2, 4, 56, 809, DateTimeKind.Unspecified).AddTicks(286), 3L, "Rerum ipsum pariatur.", new DateTime(2022, 5, 7, 22, 14, 15, 952, DateTimeKind.Unspecified).AddTicks(5326), 20L, "Quisquam et officiis esse ducimus ea saepe consequatur.", 8L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 2, 2, 18, 3, 46, 9, DateTimeKind.Unspecified).AddTicks(237), 2L, "Velit deleniti nemo sit vel atque numquam rerum.\nDolorem itaque exercitationem perspiciatis hic.\nIpsa facilis sed molestias doloribus culpa.\nAut et eos et velit repellat nihil quia nisi.\nQuos voluptatem a error facere cumque autem consequatur.", new DateTime(2023, 11, 30, 19, 39, 38, 216, DateTimeKind.Unspecified).AddTicks(7317), false, 5L, "Quisquam quia unde architecto illum.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 6, 4, 20, 8, 0, 80, DateTimeKind.Unspecified).AddTicks(4848), 1L, "Perspiciatis vel et.\nBlanditiis quasi eius.\nDelectus dolorem nemo aut.\nAsperiores qui quis earum voluptas.\nBeatae laboriosam ut eos.", new DateTime(2022, 7, 29, 13, 39, 28, 326, DateTimeKind.Unspecified).AddTicks(4112), true, 14L, "Suscipit dolorem et tenetur enim.", 18L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 10, 8, 8, 31, 1, 719, DateTimeKind.Unspecified).AddTicks(4006), 2L, "Exercitationem optio voluptatem iste esse.\nEnim voluptas ut excepturi debitis sapiente fuga dolorem.\nImpedit velit sint qui reiciendis ratione alias omnis sapiente.\nIusto doloribus consectetur quasi qui quidem animi.", new DateTime(2022, 8, 26, 19, 58, 43, 767, DateTimeKind.Unspecified).AddTicks(8311), false, 41L, "Voluptatem laborum non velit amet est.", 19L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 10, 29, 21, 4, 41, 300, DateTimeKind.Unspecified).AddTicks(4609), 1L, "Quas non libero et nobis amet nostrum qui inventore.", new DateTime(2022, 2, 11, 3, 25, 57, 160, DateTimeKind.Unspecified).AddTicks(7811), 40L, "Quibusdam voluptatibus quisquam voluptatem eum blanditiis omnis.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 8, 13, 12, 2, 14, 193, DateTimeKind.Unspecified).AddTicks(6999), 4L, "Ut dolor dolorem.\nEa culpa dicta cum quo.\nError quis delectus id animi aut.", new DateTime(2023, 3, 16, 0, 11, 31, 986, DateTimeKind.Unspecified).AddTicks(2288), true, 44L, "Soluta harum voluptatem quam reprehenderit.", 30L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 3, 28, 9, 54, 32, 540, DateTimeKind.Unspecified).AddTicks(4637), 4L, "Animi quas voluptatem perferendis quod deleniti molestiae.\nEos cumque eligendi qui voluptates.\nVitae eum omnis sit magni harum deserunt.\nPraesentium ducimus quia magni rem enim.\nAlias maiores qui similique commodi dolores explicabo.", new DateTime(2023, 8, 27, 16, 37, 8, 715, DateTimeKind.Unspecified).AddTicks(2643), 10L, "A enim odit omnis consequuntur fugiat qui fugit.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 4, 22, 10, 56, 58, 105, DateTimeKind.Unspecified).AddTicks(5446), "Ullam architecto numquam voluptatibus ipsum aut amet quae.\nEligendi est consequatur et facere vero quo.\nDolorem unde ea maiores.", new DateTime(2022, 3, 7, 13, 58, 18, 713, DateTimeKind.Unspecified).AddTicks(2798), false, 23L, "Accusantium error commodi.", 18L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 7, 17, 12, 44, 10, 406, DateTimeKind.Unspecified).AddTicks(9288), 3L, "Totam in aliquid hic ab quia at saepe omnis.\nQuam eos nemo repellendus.\nVel neque impedit aliquam vero provident quidem iure.\nAssumenda id sequi recusandae quo aspernatur repellat.\nMolestiae earum est molestiae adipisci blanditiis itaque.", new DateTime(2023, 10, 6, 15, 57, 44, 214, DateTimeKind.Unspecified).AddTicks(7108), false, 2L, "Quam possimus assumenda et et dolore.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 10, 2, 20, 34, 39, 112, DateTimeKind.Unspecified).AddTicks(457), 4L, "Quasi labore fugiat aut voluptas dolor dignissimos illo et illo.\nUt repudiandae non commodi perferendis nemo dolorum impedit.\nEsse dolores quod quasi voluptas qui quos rem sint.\nAut ex sunt excepturi vero cumque earum quam molestiae minima.\nRepellendus odio id rerum enim sunt.", new DateTime(2022, 3, 25, 11, 33, 41, 920, DateTimeKind.Unspecified).AddTicks(4277), false, 3L, "Quidem voluptatem tenetur quod.", 7L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 11, 21, 14, 15, 54, 779, DateTimeKind.Unspecified).AddTicks(4492), 5L, "Ipsum quia ratione.\nEx distinctio architecto necessitatibus consectetur et.\nHarum inventore consequatur sit provident.", new DateTime(2023, 1, 26, 18, 56, 29, 573, DateTimeKind.Unspecified).AddTicks(1975), 29L, "Sunt et omnis ipsum sit est ut.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 3, 12, 18, 5, 50, 421, DateTimeKind.Unspecified).AddTicks(7064), 3L, "Neque est porro aut omnis dolorem qui.\nEos hic sint quos in rerum est.\nEnim facilis consequatur fuga alias.", new DateTime(2022, 6, 22, 23, 1, 1, 617, DateTimeKind.Unspecified).AddTicks(7826), 33L, "Non veniam sed dolor dolore dolore deserunt occaecati dolore et.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 6, 8, 12, 10, 44, 405, DateTimeKind.Unspecified).AddTicks(4569), "Ea quisquam sunt voluptatibus voluptas.\nAnimi est natus quia magnam id dolorum earum.", new DateTime(2023, 3, 20, 13, 32, 51, 346, DateTimeKind.Unspecified).AddTicks(9509), 34L, "Possimus eum et odio dolorum consequatur et nihil deserunt.", 9L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 9, 14, 19, 30, 9, 621, DateTimeKind.Unspecified).AddTicks(1030), "Enim necessitatibus error soluta corporis iusto eius minima aut corrupti.", new DateTime(2022, 9, 13, 2, 40, 15, 923, DateTimeKind.Unspecified).AddTicks(6670), true, 27L, "Voluptas odit error rerum.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 4, 9, 17, 23, 52, 22, DateTimeKind.Unspecified).AddTicks(7319), "Maiores esse aut expedita rerum laboriosam libero omnis sunt ullam.\nQuisquam veniam accusamus qui.", new DateTime(2022, 10, 7, 11, 35, 41, 150, DateTimeKind.Unspecified).AddTicks(8412), 14L, "Aut et illo qui culpa inventore itaque soluta amet.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 8, 11, 8, 13, 51, 527, DateTimeKind.Unspecified).AddTicks(4824), 5L, "Fugit quasi molestiae sunt et.", new DateTime(2023, 6, 21, 23, 20, 27, 788, DateTimeKind.Unspecified).AddTicks(1626), false, 43L, "Debitis omnis ut debitis nemo quas quod dolorum magnam.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 11, 14, 1, 33, 38, 359, DateTimeKind.Unspecified).AddTicks(7919), 2L, "Aut quod praesentium.\nAliquam eum soluta non nihil.\nFacere distinctio repudiandae vel quo laudantium aut dolores tempore nemo.\nOmnis magni aliquid.", new DateTime(2023, 1, 1, 23, 25, 33, 206, DateTimeKind.Unspecified).AddTicks(2205), false, 33L, "Non pariatur quisquam doloremque voluptatem doloremque iure impedit eum.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 10, 57, 182, DateTimeKind.Unspecified).AddTicks(7865), 3L, "Quasi consequatur est consectetur aut numquam id similique veniam numquam.\nQuia tenetur voluptas est aut et rem sed.\nQuo beatae aliquid sit eius corrupti.\nEt ut placeat repellat similique molestias sequi nihil quia.", new DateTime(2023, 3, 30, 2, 24, 47, 171, DateTimeKind.Unspecified).AddTicks(6734), 34L, "Odio nihil maiores repudiandae incidunt aliquid dolores aut.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2022, 1, 26, 19, 2, 31, 61, DateTimeKind.Unspecified).AddTicks(4804), 1L, "Voluptatibus quam sit.\nPraesentium facere aut voluptatem iure et sit provident numquam qui.\nQuibusdam fuga quis sed quidem dolores et cum inventore.", new DateTime(2023, 7, 19, 17, 17, 37, 230, DateTimeKind.Unspecified).AddTicks(4777), false, 10L, "Voluptatem fugit rem distinctio corporis sed.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2022, 1, 26, 9, 55, 40, 37, DateTimeKind.Unspecified).AddTicks(6635), "Quo eos dolorem nostrum distinctio odit eveniet voluptatem vel sit.", new DateTime(2023, 11, 5, 9, 59, 17, 171, DateTimeKind.Unspecified).AddTicks(262), 31L, "Corporis aut officia.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 4, 26, 17, 31, 48, 402, DateTimeKind.Unspecified).AddTicks(8076), "Corporis eius incidunt et.\nEst eum voluptates nihil quo ut fugiat.", new DateTime(2023, 2, 17, 14, 38, 26, 894, DateTimeKind.Unspecified).AddTicks(5862), 8L, "Ex quod quia voluptatem molestias facere accusamus.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 6, 29, 13, 58, 50, 537, DateTimeKind.Unspecified).AddTicks(5691), 1L, "Nulla ducimus ex quasi nihil.\nRerum mollitia aut qui itaque.", new DateTime(2022, 9, 27, 11, 41, 59, 562, DateTimeKind.Unspecified).AddTicks(3877), false, 45L, "Dolores deleniti non quos dignissimos.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 6, 13, 11, 4, 49, 442, DateTimeKind.Unspecified).AddTicks(1957), "Est quod et voluptatem vel maiores laudantium et rerum.", new DateTime(2023, 12, 8, 8, 36, 53, 790, DateTimeKind.Unspecified).AddTicks(318), false, 18L, "Fugiat sapiente eum ut id harum quasi a.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 5, 6, 13, 28, 28, 857, DateTimeKind.Unspecified).AddTicks(7690), 4L, "Dolorum iusto aliquid.\nEt est velit voluptas eos consequatur.\nVero distinctio non incidunt.", new DateTime(2023, 3, 3, 16, 13, 45, 156, DateTimeKind.Unspecified).AddTicks(1496), true, 2L, "Tempora quas aut rerum expedita accusantium placeat ea iure.", 38L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 6, 29, 18, 1, 17, 224, DateTimeKind.Unspecified).AddTicks(9181), "Ducimus quia sunt architecto fugiat.\nTempora quos eligendi temporibus doloremque facilis.\nEx nihil corrupti provident sed.", new DateTime(2023, 4, 26, 21, 15, 44, 280, DateTimeKind.Unspecified).AddTicks(2488), true, 27L, "Voluptas blanditiis beatae itaque aperiam quo ab sint doloribus.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2022, 1, 14, 4, 37, 33, 175, DateTimeKind.Unspecified).AddTicks(7432), 2L, "Ut qui commodi.", new DateTime(2022, 10, 21, 12, 20, 56, 986, DateTimeKind.Unspecified).AddTicks(1217), false, 42L, "Fugiat vel magni sunt sunt quia sit exercitationem.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2022, 1, 27, 7, 10, 40, 759, DateTimeKind.Unspecified).AddTicks(1463), 3L, "Inventore consequuntur aut qui nulla ea id.\nQui ipsam ab ad in sint iure voluptas.\nVelit natus quas perspiciatis cumque.\nAsperiores magnam est et.", new DateTime(2023, 3, 24, 18, 44, 55, 439, DateTimeKind.Unspecified).AddTicks(21), false, 19L, "Qui est tempora occaecati quo autem consequatur minima.", 18L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 2, 5, 21, 1, 0, 638, DateTimeKind.Unspecified).AddTicks(2901), 2L, "Impedit magni accusamus sed.\nQuisquam tempora quasi ea maiores fugit sit.", new DateTime(2022, 3, 28, 12, 22, 12, 762, DateTimeKind.Unspecified).AddTicks(7777), 41L, "Sit aliquam omnis libero neque id ex maiores quos cum.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 6, 11, 21, 23, 5, 586, DateTimeKind.Unspecified).AddTicks(5658), 5L, "Earum error adipisci odio molestias.\nRepudiandae exercitationem quia nisi omnis doloremque qui dignissimos.\nNihil similique eaque repellat optio rerum iure.\nAut omnis quis quidem.", new DateTime(2022, 3, 30, 13, 52, 0, 434, DateTimeKind.Unspecified).AddTicks(8648), 18L, "Maiores id quis qui deleniti provident in ut consectetur quo.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 2, 28, 1, 28, 47, 739, DateTimeKind.Unspecified).AddTicks(4811), 4L, "Rerum illo laboriosam dignissimos eaque recusandae eligendi suscipit voluptatem.\nHic cum iste laboriosam sunt cum modi beatae.\nAut quibusdam laudantium voluptates est nisi ab vitae dignissimos.\nTempora est illum ut qui culpa ab quam voluptas animi.", new DateTime(2022, 5, 16, 22, 5, 19, 659, DateTimeKind.Unspecified).AddTicks(2031), false, 21L, "Excepturi voluptatem mollitia consequatur ad aut.", 6L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 10, 31, 17, 33, 36, 835, DateTimeKind.Unspecified).AddTicks(6936), 1L, "Aspernatur maiores at magnam commodi molestiae doloribus dolores.", new DateTime(2023, 8, 21, 8, 54, 19, 452, DateTimeKind.Unspecified).AddTicks(1538), false, 20L, "Ipsum ipsum et officia adipisci ipsa voluptas alias dolor.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 6, 18, 12, 21, 14, 37, DateTimeKind.Unspecified).AddTicks(5279), 2L, "Rerum provident est.\nCulpa ea et assumenda.", new DateTime(2023, 7, 29, 8, 7, 37, 85, DateTimeKind.Unspecified).AddTicks(9807), true, 42L, "Ut aut id voluptatibus ullam modi numquam voluptates.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 11, 28, 1, 12, 36, 869, DateTimeKind.Unspecified).AddTicks(4299), 5L, "Aliquid quam adipisci odio neque aliquid officiis est.\nReiciendis voluptatem quis praesentium ea quidem iure ex dolores atque.", new DateTime(2023, 5, 12, 11, 57, 15, 751, DateTimeKind.Unspecified).AddTicks(7860), 48L, "Ut accusamus velit magni nam.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 9, 27, 10, 59, 56, 442, DateTimeKind.Unspecified).AddTicks(8997), 5L, "Et illum nihil porro eum sapiente.", new DateTime(2023, 7, 28, 21, 40, 4, 34, DateTimeKind.Unspecified).AddTicks(1100), 22L, "Debitis ut dolores.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 2, 12, 12, 45, 20, 284, DateTimeKind.Unspecified).AddTicks(393), 5L, "Rerum qui perferendis quas quia nemo repellat molestiae dignissimos.\nItaque vero facilis itaque sint consequatur reprehenderit reprehenderit veritatis.\nDoloremque illo error officiis quam error ratione ipsum et.", new DateTime(2022, 12, 20, 20, 43, 54, 877, DateTimeKind.Unspecified).AddTicks(5690), 25L, "Deleniti eveniet impedit deleniti inventore asperiores sit.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 7, 18, 21, 48, 8, 237, DateTimeKind.Unspecified).AddTicks(763), "Quis distinctio fugiat sapiente temporibus voluptatum nam.\nSed aut illum saepe rerum qui dicta.\nNesciunt dolorem natus alias est id repellat.\nPraesentium et quidem recusandae est hic eveniet et.\nRepellat et possimus qui.", new DateTime(2022, 6, 18, 0, 51, 4, 509, DateTimeKind.Unspecified).AddTicks(1488), 6L, "Praesentium dolorum fugit officiis velit.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 11, 21, 9, 31, 46, 515, DateTimeKind.Unspecified).AddTicks(6456), 5L, "Quae pariatur et debitis harum nam neque et eos quo.", new DateTime(2023, 7, 19, 19, 32, 54, 181, DateTimeKind.Unspecified).AddTicks(4256), true, 39L, "Qui eum modi quis.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 10, 29, 0, 36, 50, 381, DateTimeKind.Unspecified).AddTicks(9768), 2L, "Debitis ut velit natus impedit doloribus pariatur.\nEt quia et explicabo error nobis et iste quae.\nVoluptates ratione tenetur voluptas et culpa quae ut.\nAnimi soluta cum qui reiciendis porro facilis fuga accusamus molestiae.\nQuia dolor inventore et.", new DateTime(2023, 2, 2, 7, 25, 34, 140, DateTimeKind.Unspecified).AddTicks(8631), false, 16L, "Voluptas eum aut dignissimos dolorem tempora ratione expedita.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 9, 29, 12, 41, 57, 723, DateTimeKind.Unspecified).AddTicks(5608), 5L, "Rem consequatur magnam dicta error reprehenderit necessitatibus.\nSint veritatis quis magni debitis officia.\nSunt cupiditate laboriosam id aut vel aut optio.\nEt et exercitationem ut sint vitae.\nAut mollitia et et ipsum aut nisi.", new DateTime(2023, 12, 16, 13, 20, 11, 482, DateTimeKind.Unspecified).AddTicks(3535), 13L, "Dolor iusto maxime quibusdam error aperiam assumenda.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 6, 8, 2, 32, 6, 301, DateTimeKind.Unspecified).AddTicks(8606), 1L, "Nihil et enim.", null, true, 24L, "Ullam pariatur perferendis impedit eaque optio.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 11, 17, 10, 59, 54, 182, DateTimeKind.Unspecified).AddTicks(9240), 2L, "Consequatur sint a et rem similique.", new DateTime(2023, 4, 4, 0, 4, 39, 394, DateTimeKind.Unspecified).AddTicks(992), true, 4L, "Ut provident modi itaque natus veniam.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 12L, new DateTime(2021, 12, 18, 14, 10, 11, 519, DateTimeKind.Unspecified).AddTicks(6331), 4L, "Quia accusamus ad ut in molestias facere natus tenetur architecto.\nQui molestiae vero nostrum nam odit placeat officiis quo minima.\nEt est et dolore temporibus in.\nA ad repellendus optio.\nVero sed explicabo nobis iste.", new DateTime(2022, 4, 30, 12, 29, 20, 924, DateTimeKind.Unspecified).AddTicks(9697), 28L, "Sunt hic voluptatem.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 5, 1, 16, 59, 8, 688, DateTimeKind.Unspecified).AddTicks(6324), 5L, "Et voluptatem quisquam dolor commodi asperiores et.", new DateTime(2022, 5, 5, 14, 49, 59, 917, DateTimeKind.Unspecified).AddTicks(194), true, 30L, "Consectetur animi voluptate totam sed minima voluptatem cum necessitatibus.", 18L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 3, 9, 19, 19, 12, 447, DateTimeKind.Unspecified).AddTicks(9624), "Nam laudantium animi.\nTemporibus quos quasi molestias cum est delectus non totam rerum.\nIn ut facilis quidem quia voluptate.\nSoluta consectetur nulla.", 22L, "Facere quia enim aut.", 5L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 5, 5, 11, 8, 9, 347, DateTimeKind.Unspecified).AddTicks(4885), 5L, "Qui et beatae qui aperiam tempora aut.\nRepellendus aliquid culpa fuga dolorem esse impedit.\nDolor voluptate magni a ducimus inventore voluptatibus est.", new DateTime(2022, 7, 30, 1, 52, 49, 979, DateTimeKind.Unspecified).AddTicks(5367), true, 37L, "Molestias eos nobis quia velit.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2022, 1, 7, 21, 15, 3, 803, DateTimeKind.Unspecified).AddTicks(4214), 4L, "Et qui molestias tempora.\nVoluptatem dolor sint nulla.", new DateTime(2023, 9, 5, 15, 53, 31, 44, DateTimeKind.Unspecified).AddTicks(7703), 32L, "Architecto eos deserunt temporibus itaque.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 11, 11, 1, 24, 29, 247, DateTimeKind.Unspecified).AddTicks(7429), 3L, "Omnis doloremque dolorem et.", new DateTime(2023, 7, 3, 0, 0, 31, 220, DateTimeKind.Unspecified).AddTicks(4302), true, 49L, "Quidem corporis quia voluptatem sapiente qui autem et.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 12, 22, 19, 51, 8, 849, DateTimeKind.Unspecified).AddTicks(3167), 2L, "Et sequi quidem.\nConsequatur expedita officia.\nNeque aspernatur beatae tempora necessitatibus voluptatem officiis repellendus.", new DateTime(2022, 10, 18, 16, 53, 26, 114, DateTimeKind.Unspecified).AddTicks(9523), 44L, "Qui laudantium sapiente quam dolorem aliquam vel similique enim.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 5, 30, 7, 11, 43, 178, DateTimeKind.Unspecified).AddTicks(8038), 1L, "Assumenda quasi cupiditate et vero quidem modi libero quo autem.\nArchitecto qui exercitationem rem.\nOdit porro et ut beatae sit.\nVeniam qui fugit et dolor voluptates deserunt odit dolores.\nSed aut quo eum eius optio placeat necessitatibus quia aut.", new DateTime(2023, 1, 15, 13, 14, 12, 692, DateTimeKind.Unspecified).AddTicks(7082), 5L, "Maxime amet ut aut sed magnam quas ut explicabo.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 10, 8, 23, 51, 19, 83, DateTimeKind.Unspecified).AddTicks(9759), 1L, "Quod voluptatem quae possimus sed ut.\nMagni minima consectetur.", new DateTime(2023, 8, 10, 8, 3, 18, 98, DateTimeKind.Unspecified).AddTicks(2886), 6L, "Aliquam accusantium aut qui odio quis.", 38L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 7, 24, 21, 12, 4, 94, DateTimeKind.Unspecified).AddTicks(360), "Sed adipisci pariatur.\nUt exercitationem nam.\nOfficia autem tenetur qui voluptas quam.\nQuia voluptate voluptatibus et corrupti corporis neque excepturi labore impedit.\nSint modi voluptatibus rem quo est dicta non quidem et.", new DateTime(2022, 12, 4, 12, 40, 32, 13, DateTimeKind.Unspecified).AddTicks(8265), true, 18L, "Nemo est impedit ut.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 9, 4, 0, 39, 11, 259, DateTimeKind.Unspecified).AddTicks(9092), 4L, "Aspernatur commodi est odit.\nVel a nobis laborum qui beatae.\nDignissimos dignissimos fugit beatae sit facilis.", new DateTime(2023, 12, 1, 15, 41, 16, 860, DateTimeKind.Unspecified).AddTicks(9027), 42L, "Veritatis officia labore.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 9, 7, 23, 28, 42, 593, DateTimeKind.Unspecified).AddTicks(5257), "Quidem sed cum labore aut mollitia dicta id.\nSaepe molestiae perferendis.\nRerum quia nihil voluptatem enim hic voluptates modi corrupti voluptas.\nUt odio minima nihil hic ducimus natus aut sunt.\nConsequatur quibusdam odit quo voluptatibus illum minus.", new DateTime(2022, 8, 26, 14, 22, 7, 298, DateTimeKind.Unspecified).AddTicks(8128), true, 16L, "Ut sed esse quia sed et molestiae repellat aut odit.", 8L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 12, 25, 16, 53, 14, 305, DateTimeKind.Unspecified).AddTicks(2798), 1L, "Ad fugiat ut consequatur.\nDistinctio et quidem sit sint.\nEa earum non animi ipsam voluptas dolores quia itaque est.", new DateTime(2023, 8, 15, 13, 29, 37, 525, DateTimeKind.Unspecified).AddTicks(9944), false, 6L, "Est pariatur similique sequi beatae.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2022, 1, 24, 20, 9, 56, 697, DateTimeKind.Unspecified).AddTicks(5148), 2L, "Dolores quasi et et maxime enim deleniti.\nIncidunt et consequuntur provident labore voluptatem et quas sed molestias.\nAut tempora numquam error.\nEaque laboriosam veritatis voluptates quis vitae.\nVoluptas ducimus quo.", new DateTime(2023, 5, 14, 17, 15, 26, 437, DateTimeKind.Unspecified).AddTicks(8658), 21L, "Asperiores at perferendis architecto vero occaecati enim.", 17L });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 7, 22, 47, 27, 981, DateTimeKind.Unspecified).AddTicks(769), "Aliquam expedita tempora.\nInventore eveniet veniam provident.\nEt delectus numquam voluptas dignissimos ad incidunt.", true, 0, new Guid("76b04717-dadf-3faa-b184-5b6ab1e8a957"), "Laboriosam ut in quos et quam qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 18, 6, 55, 14, 412, DateTimeKind.Unspecified).AddTicks(4907), 4L, "Ipsa aliquam dolores illum ex earum eum quo blanditiis.\nRepellat quisquam esse ipsum explicabo repudiandae soluta ea aliquid.\nTempora ex enim excepturi officiis.", false, 0, new Guid("57a02ac0-52b9-5f9e-1ac6-e732e5d00877"), "Totam distinctio quas id necessitatibus aut consequatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 30, 2, 35, 33, 481, DateTimeKind.Unspecified).AddTicks(9480), 2L, "Veritatis tempore dolore quidem nobis voluptatibus dolorum rerum dolorem.", 0, new Guid("54ffeebb-1927-4f88-81cb-873fb33ee0a5"), "Alias harum ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 31, 3, 45, 31, 986, DateTimeKind.Unspecified).AddTicks(7167), 1L, "Dicta itaque sint facere est id deserunt.\nNecessitatibus libero quas sunt sint velit.\nBlanditiis illum natus ea explicabo officiis.", false, 0, new Guid("44fe695d-49a7-c8d3-77e0-a82559e8994f"), "Consequatur placeat sed quia perspiciatis soluta est rerum numquam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 4, 9, 48, 15, 660, DateTimeKind.Unspecified).AddTicks(4317), 2L, "Maiores sint quas et soluta et rem quod.", new Guid("b2c93308-9cad-f173-f875-8f4e4a8661ff"), "Et at voluptate." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 23, 12, 36, 30, 481, DateTimeKind.Unspecified).AddTicks(6019), 3L, "Ex molestias sit amet ut corporis non.", false, new Guid("37e65dbf-1144-4991-cdc9-a615d2681606"), "Ea quod doloribus et quis nisi aut dignissimos." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 9, 13, 21, 39, 517, DateTimeKind.Unspecified).AddTicks(8447), 2L, "Fugit ducimus ducimus blanditiis non laborum enim.\nNesciunt saepe omnis rem.\nEt voluptates provident.\nAliquid velit consectetur quo.\nSit tempore doloremque.", 0, new Guid("9c9b819a-3b68-2569-cddb-745275ce6bea"), "Quis et necessitatibus corporis aliquid et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 30, 19, 34, 51, 471, DateTimeKind.Unspecified).AddTicks(731), "Quibusdam assumenda consequatur voluptatem omnis nihil doloremque.\nAut explicabo necessitatibus neque sit.", false, 1, new Guid("52321d32-5f85-6799-677f-27c024765561"), "Qui sed nam veniam amet." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 4, 19, 28, 7, 604, DateTimeKind.Unspecified).AddTicks(1023), 3L, "Non unde rerum sit ipsum hic voluptatem asperiores et.\nAmet eligendi architecto animi nesciunt.\nEa a adipisci ratione adipisci voluptatum sed.", false, new Guid("df9686b6-6b89-0d96-f745-c105b7f00fd6"), "Eos autem reprehenderit exercitationem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 8, 8, 9, 34, 791, DateTimeKind.Unspecified).AddTicks(1560), "Quis nesciunt modi dignissimos iusto tempore ab molestiae rerum.\nEt sed doloribus inventore corrupti quidem illum.\nBeatae suscipit ipsam.\nVeniam vitae architecto.", false, new Guid("2bbe5fd2-7807-4b9f-d1ce-ea786f3fa31d"), "Recusandae enim cumque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 13, 6, 19, 30, 558, DateTimeKind.Unspecified).AddTicks(9400), 5L, "Quos sit qui.", false, 0, new Guid("9c935e62-58c1-7372-a27d-12f9ed251c63"), "Incidunt nostrum aspernatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 5, 7, 29, 17, 450, DateTimeKind.Unspecified).AddTicks(4948), "Praesentium sequi doloribus quod aut nihil cumque veniam veniam.\nIste enim laborum rerum nemo.\nAd itaque voluptatibus voluptas soluta recusandae aut.\nSimilique molestiae ad laborum.\nRatione ipsam ullam aut molestiae accusamus tenetur ut.", 0, new Guid("46a188a5-826f-389b-9bf6-85554ff47708"), "Saepe impedit voluptas aut saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 6, 13, 12, 1, 920, DateTimeKind.Unspecified).AddTicks(520), "Accusantium aliquam exercitationem nobis.\nAliquid libero minus.\nLibero voluptas rem rerum velit fugiat voluptates quis.\nVoluptatem deserunt optio.", true, 0, new Guid("61c3ab8d-0687-c8bc-7bda-801a24587d9d"), "Ab vel laboriosam expedita." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 9, 21, 34, 52, 582, DateTimeKind.Unspecified).AddTicks(1681), 3L, "Voluptatem reprehenderit iure quasi ipsa iusto mollitia ipsa ea eos.\nPerspiciatis culpa ea amet dolor omnis saepe aut.\nPlaceat omnis fugiat dolorem dolor velit.\nVoluptatem quibusdam in adipisci nihil vero aut aut qui et.\nSed voluptatum consectetur ipsa tenetur deserunt perspiciatis eligendi consequatur ex.", new Guid("8d2f5254-f5ff-af04-24da-870873db842b"), "Consequatur dicta quis provident rerum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 23, 11, 13, 9, 51, DateTimeKind.Unspecified).AddTicks(4353), 3L, "Sunt iure fuga quis neque.\nLaudantium eaque quia.", new Guid("41cc5895-7c20-fc8d-f445-ebc08a91b767"), "Sed ut impedit iste natus quis voluptas blanditiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 14, 18, 44, 10, 469, DateTimeKind.Unspecified).AddTicks(1796), 5L, "Sed non commodi laborum pariatur praesentium nisi labore nam.", true, 0, new Guid("6b2ed513-2057-0222-6e88-b23301db8e5e"), "Eligendi sit eos quibusdam consequuntur non in consequatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 17, 33, 519, DateTimeKind.Unspecified).AddTicks(5544), 1L, "Quisquam quaerat rem aut iusto quo eligendi a.\nRerum consequatur similique fugit qui ipsam nobis.\nNihil fugit veritatis ea ut.\nConsectetur cum consequatur nihil nostrum perspiciatis velit.", true, new Guid("08e055c7-171a-4242-07d1-b369aa454b5e"), "Impedit vitae inventore sint ex." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 13, 16, 47, 1, 682, DateTimeKind.Unspecified).AddTicks(4768), 5L, "Suscipit et quis in velit.\nExcepturi quam molestias cum veritatis inventore.\nVoluptatum et quod rerum enim sed voluptates molestiae culpa.\nQui quam velit omnis numquam ut.", true, 0, new Guid("b6f5a079-4e3a-3d2d-7255-e880fdb2d41b"), "Quaerat rerum et molestiae autem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 15, 3, 25, 56, 330, DateTimeKind.Unspecified).AddTicks(6508), 2L, "Alias expedita exercitationem qui aperiam occaecati dolor et consectetur aut.\nEt aut cum modi.\nVitae asperiores eos et est beatae autem et aspernatur.\nSit delectus voluptas aliquam quo dolorem eum quibusdam harum.", new Guid("22cb6e7d-d871-cdf1-8d3e-2d207aefa9dc"), "Laudantium ullam sunt est quidem ipsam dolores." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 17, 7, 52, 37, 399, DateTimeKind.Unspecified).AddTicks(4500), "Non minus recusandae ullam aperiam.\nIpsam ipsa error itaque eligendi.", 1, new Guid("dd9f3a03-018b-ea1e-638d-116b63ce47ae"), "Id enim qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 24, 21, 46, 29, 702, DateTimeKind.Unspecified).AddTicks(9094), 5L, "In quia provident.", new Guid("108bf73f-61ea-24e7-88b9-2374eb01dfd8"), "Voluptas qui debitis consectetur rerum enim placeat doloribus hic saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 11, 0, 41, 47, 639, DateTimeKind.Unspecified).AddTicks(6283), 3L, "Commodi omnis ut quisquam est molestiae natus tempora.\nQui mollitia ut nemo quae.\nAutem molestiae ea atque.", 0, new Guid("94402e27-51a8-d84e-cab4-3d1e2bdc5ab5"), "Voluptatum quasi ducimus itaque voluptatibus rerum aliquid eos repellendus saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 6, 17, 57, 42, 714, DateTimeKind.Unspecified).AddTicks(7156), 3L, "Ex possimus perspiciatis cumque repellendus consectetur quos ducimus temporibus.\nDoloribus praesentium recusandae repudiandae aut beatae excepturi expedita veniam minus.\nEnim nesciunt fugiat voluptatem commodi ipsam eum.", true, 1, new Guid("799a4721-f76d-e859-11c3-75c1842b686f"), "Voluptatem voluptas excepturi omnis ratione." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 24, 10, 40, 58, 910, DateTimeKind.Unspecified).AddTicks(3848), 1L, "Officiis nam amet fugiat sit placeat.\nUt possimus eius rem reprehenderit est neque optio.", true, 0, new Guid("a7ca401b-8b4b-f95c-27c9-9f21618f2f63"), "Delectus nesciunt autem id quia aut quia eaque minima." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 4, 2, 33, 46, 338, DateTimeKind.Unspecified).AddTicks(6546), "Quos et consequatur.\nAb cum doloremque maiores aut sunt iusto quia.\nConsequatur sint assumenda.", false, new Guid("d0f1b971-68bc-e0c4-6989-d1a720d9aa3d"), "Corporis veritatis placeat quam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 29, 1, 1, 28, 171, DateTimeKind.Unspecified).AddTicks(2260), 5L, "Blanditiis sed voluptatum odio blanditiis quia neque.\nPraesentium et autem aut voluptas.", new Guid("66dfaf66-e760-94c9-1957-fa590d89055a"), "Est voluptatem culpa et illo." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 27, 15, 42, 24, 457, DateTimeKind.Unspecified).AddTicks(2369), "Esse voluptas ipsa quaerat et aut sapiente nisi voluptates.", new Guid("11cd77ab-43a3-0d72-c3cf-7da95e645d90"), "Est tempore ut ut occaecati et labore aperiam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 13, 2, 0, 4, 275, DateTimeKind.Unspecified).AddTicks(2300), 1L, "Debitis distinctio consectetur cumque dolorem magni quidem aut aut.\nOdio veniam libero veniam ipsum.\nIncidunt autem id deserunt sed qui.", false, 1, new Guid("8a309b0e-9aa4-bc57-1d8b-3311869ceee4"), "Velit nihil id corporis et quo consequatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 10, 10, 11, 19, 655, DateTimeKind.Unspecified).AddTicks(3797), 5L, "Tempore atque doloribus est tempore recusandae quis aut dolorem.\nUnde consequatur eos nesciunt provident doloribus labore placeat vel exercitationem.", false, new Guid("fe57a228-e013-7154-af87-bea45d25687e"), "Non minima vitae est iusto ratione excepturi facere dolor." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 29, 17, 56, 19, 64, DateTimeKind.Unspecified).AddTicks(4350), 2L, "Laudantium debitis dolorum et dicta molestias.\nSunt ullam qui corrupti nisi.\nMagnam architecto mollitia quis accusamus odit molestiae.", new Guid("56325edb-f171-adaa-b19a-f0b674d4a1a9"), "Nihil vero eligendi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 2, 1, 6, 32, 10, 203, DateTimeKind.Unspecified).AddTicks(3817), 3L, "Commodi unde et id.\nEa alias suscipit sunt aspernatur vel expedita.\nSapiente dolorem eos exercitationem.", new Guid("29c5f671-5c72-60f1-21b7-371a8971faed"), "Placeat itaque amet ad facilis aliquam cupiditate quia quisquam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 24, 17, 14, 20, 338, DateTimeKind.Unspecified).AddTicks(7272), 4L, "Quae voluptatem praesentium eveniet odit ratione sunt sapiente.\nQui soluta debitis quae dolores consectetur.\nSapiente iste aperiam et ut sunt.\nTempore consequatur molestias totam ab ut vero iste culpa distinctio.\nAutem sed dolorem tenetur doloribus.", 1, new Guid("2cfec789-90bc-2e87-3e72-2526eec88c82"), "Qui alias debitis debitis deleniti tenetur voluptas vel et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 21, 16, 28, 2, 568, DateTimeKind.Unspecified).AddTicks(2767), "Architecto corporis aut similique architecto non debitis impedit.\nNon aut dolorum molestiae dolores.\nCum temporibus enim facilis eos ipsam quibusdam.\nEt reprehenderit veniam et ab nostrum.", true, 1, new Guid("6d344bbd-ded6-a99e-7409-20ff080f6fa5"), "Quod quo rerum eaque omnis voluptas dolor." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 19, 18, 20, 12, 306, DateTimeKind.Unspecified).AddTicks(2292), "Ratione dolor temporibus qui dolorem quam accusamus nostrum aliquid quas.\nPerferendis sed quas.", false, new Guid("a945d65e-5fdb-ae4a-4c77-baa5ce784fb5"), "Deleniti laudantium ipsum velit adipisci." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 25, 21, 8, 37, 922, DateTimeKind.Unspecified).AddTicks(2312), 1L, "Nesciunt perferendis repudiandae eum quibusdam libero.\nPossimus fugiat voluptatum ea in assumenda possimus aut.\nSit et odio nemo voluptatem eos consequatur culpa deleniti.\nPorro dolor iusto sed nam tenetur voluptatibus.", false, 1, new Guid("1b959cbd-2b6f-1397-0c53-d77f212db57d"), "Quibusdam occaecati maxime voluptate aperiam eaque sit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 27, 0, 21, 11, 230, DateTimeKind.Unspecified).AddTicks(5626), 2L, "Ut tenetur natus quia et consequatur qui esse fugiat rerum.\nCumque consequatur sed.", 1, new Guid("f58c87d6-f765-4ae2-d7d2-5db50de5e605"), "Ut dolor enim." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 21, 0, 14, 15, 173, DateTimeKind.Unspecified).AddTicks(1531), 3L, "Soluta non quam omnis atque non quia quibusdam et praesentium.\nConsequatur consequuntur rerum inventore.\nDebitis earum sint facere voluptatum dolorum necessitatibus ex aperiam magnam.", new Guid("10bd0326-8431-079f-d947-460cc7c113d3"), "Ducimus pariatur nemo." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 17, 5, 5, 25, 212, DateTimeKind.Unspecified).AddTicks(8224), 4L, "Id dignissimos inventore quia veritatis est incidunt repellat molestiae exercitationem.\nNon quaerat deleniti delectus sed quam ipsa error aut.\nSed recusandae expedita dolorem aperiam amet omnis quae.\nQui nobis iusto aut temporibus quo nihil ipsam qui.\nEt aut consequuntur dolore dolores vero veritatis.", true, new Guid("a1781a67-519c-f047-bd46-ba0d90a44d01"), "Eveniet cupiditate nesciunt voluptas." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 11, 3, 13, 11, 377, DateTimeKind.Unspecified).AddTicks(1654), 5L, "Reiciendis eveniet facere beatae.", false, 1, new Guid("7542c3b5-b200-d12f-55dd-d56ead308c5b"), "Repellendus consequatur magnam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 17, 19, 7, 32, 299, DateTimeKind.Unspecified).AddTicks(5167), 2L, "Et praesentium illum.\nProvident illo porro at libero commodi error dolore nisi dolores.\nAb aut quis nihil molestiae nam.\nProvident nisi ut rerum dolorem ratione laboriosam non eligendi.\nSunt voluptatem quaerat quibusdam eum molestiae.", 1, new Guid("73f9df92-19af-2c43-e783-286c0105f888"), "Qui veniam eius suscipit eveniet molestiae possimus aliquam sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 13, 1, 8, 31, 515, DateTimeKind.Unspecified).AddTicks(3391), 1L, "Sequi accusantium labore.\nNam soluta repellat soluta deserunt nostrum iste ut.\nEt ratione pariatur voluptates voluptates est blanditiis.\nNon officiis in.", false, 1, new Guid("2d3ca573-e81d-8500-6cfe-c7a2921927da"), "Sit repellendus id id ipsam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 27, 17, 34, 16, 686, DateTimeKind.Unspecified).AddTicks(2118), 2L, "Sequi distinctio est facere deserunt ea dolorem dolorem molestiae doloremque.", 1, new Guid("f67774ae-5bfd-97a9-f1b5-e8caf6c99e36"), "Assumenda eos cupiditate excepturi quo culpa quo beatae mollitia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 12, 16, 27, 47, 886, DateTimeKind.Unspecified).AddTicks(9643), 1L, "Qui sunt quod beatae ipsam et.\nNisi totam molestiae alias nobis.\nIusto sed atque.\nIpsa eius alias quo quia iste perspiciatis eos officia.\nEa corrupti consequuntur nesciunt suscipit ea qui doloribus commodi unde.", new Guid("e78a8474-93b3-a74d-8295-d054ea1fe633"), "Enim eos consequuntur numquam quia sint porro blanditiis nostrum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 22, 19, 46, 12, 522, DateTimeKind.Unspecified).AddTicks(1369), 3L, "Voluptas recusandae vero aut ratione dignissimos.\nEum aut dolore quia voluptatibus possimus ratione ratione debitis incidunt.\nCorrupti cumque iusto eum aliquid aut molestias aut.", new Guid("2cf47add-145d-d24f-5054-0a1e8af42592"), "Temporibus unde exercitationem sit id sed numquam nisi dolore." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 2, 6, 4, 26, 282, DateTimeKind.Unspecified).AddTicks(8145), 5L, "Aut exercitationem ut repellendus ipsa itaque tempora.", false, new Guid("e821bb0f-2291-df26-c5ff-fef1b1342dbf"), "Id doloremque tempore quis voluptate reprehenderit quia sint." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 15, 1, 46, 1, 378, DateTimeKind.Unspecified).AddTicks(2525), 4L, "Incidunt exercitationem voluptas molestiae quibusdam aliquid maiores reiciendis voluptatibus.\nNulla dolor reiciendis placeat nihil sit.\nProvident qui rerum pariatur a voluptatibus asperiores dignissimos.\nMolestiae velit voluptates aut minima ut voluptas dolores aperiam.", 0, new Guid("d6a0d45e-efff-bb91-d623-0b7ecbf75f30"), "Id atque odit sequi perferendis eveniet voluptatem nemo in." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 12, 0, 27, 17, 822, DateTimeKind.Unspecified).AddTicks(5394), 4L, "In et consequatur ratione earum blanditiis nulla porro eligendi aut.", new Guid("78f0e781-738e-0ff2-736b-54d67527aeb0"), "Repudiandae eius alias." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 4, 2, 59, 51, 593, DateTimeKind.Unspecified).AddTicks(4926), 2L, "Amet delectus provident consequatur est.\nEum veniam ipsam voluptatem consequuntur optio vel in.\nQuibusdam eum neque totam non fuga tenetur asperiores quis.\nId error harum deleniti.", false, 0, new Guid("32420e47-f962-d16a-2eee-d48d5be6f4c1"), "A neque quia quis dolorum cupiditate placeat ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 9, 4, 53, 50, 21, DateTimeKind.Unspecified).AddTicks(588), 4L, "Neque in sed dolores adipisci et aliquid distinctio omnis fugit.\nEt ipsa veritatis.", true, 1, new Guid("a2465330-cfd9-945b-4c17-f8d576de63f6"), "Suscipit repellendus id consequatur voluptatem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 15, 9, 5, 39, 603, DateTimeKind.Unspecified).AddTicks(1622), 2L, "Cumque rem nostrum cumque laborum nobis.\nVoluptatem quisquam non voluptate reprehenderit aspernatur laboriosam.\nCum omnis nobis.\nCorporis et sapiente incidunt corrupti libero possimus ab qui.\nEsse natus ut dolore cupiditate explicabo est.", 0, new Guid("e80b2a61-2140-4d10-106a-a45d8c82e9b7"), "Molestias ducimus possimus sit voluptatem quibusdam sed consequuntur." });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 12, 25, 3, 18, 27, 890, DateTimeKind.Unspecified).AddTicks(4759), 5L, null, 62L, new DateTime(2019, 11, 18, 13, 26, 46, 534, DateTimeKind.Unspecified).AddTicks(1638), new DateTime(2021, 11, 15, 11, 6, 25, 772, DateTimeKind.Unspecified).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 7, 31, 21, 26, 43, 116, DateTimeKind.Unspecified).AddTicks(640), 2L, null, 33L, new DateTime(2019, 7, 9, 21, 48, 19, 787, DateTimeKind.Unspecified).AddTicks(9290), new DateTime(2021, 4, 28, 6, 47, 41, 425, DateTimeKind.Unspecified).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 4, 18, 6, 20, 57, 950, DateTimeKind.Unspecified).AddTicks(2585), 1L, new DateTime(2022, 1, 13, 23, 8, 54, 563, DateTimeKind.Unspecified).AddTicks(9200), 53L, new DateTime(2019, 11, 20, 15, 41, 28, 39, DateTimeKind.Unspecified).AddTicks(9609), new DateTime(2021, 3, 16, 7, 6, 19, 66, DateTimeKind.Unspecified).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 8, 8, 12, 22, 19, 769, DateTimeKind.Unspecified).AddTicks(5391), 1L, new DateTime(2022, 1, 17, 20, 41, 16, 419, DateTimeKind.Unspecified).AddTicks(8888), 17L, new DateTime(2019, 4, 16, 11, 9, 37, 619, DateTimeKind.Unspecified).AddTicks(3091), new DateTime(2021, 2, 1, 4, 3, 35, 882, DateTimeKind.Unspecified).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 7, 2, 20, 15, 3, 76, DateTimeKind.Unspecified).AddTicks(5411), 5L, new DateTime(2022, 1, 1, 14, 19, 27, 735, DateTimeKind.Unspecified).AddTicks(1238), 28L, new DateTime(2019, 4, 15, 11, 34, 9, 915, DateTimeKind.Unspecified).AddTicks(1662), new DateTime(2021, 9, 20, 16, 28, 19, 595, DateTimeKind.Unspecified).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 10, 7, 1, 1, 18, 722, DateTimeKind.Unspecified).AddTicks(5949), 4L, new DateTime(2022, 1, 24, 1, 10, 20, 131, DateTimeKind.Unspecified).AddTicks(848), 21L, new DateTime(2019, 11, 9, 7, 51, 24, 615, DateTimeKind.Unspecified).AddTicks(530), new DateTime(2021, 10, 21, 1, 3, 50, 409, DateTimeKind.Unspecified).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 7, 12, 23, 55, 5, 704, DateTimeKind.Unspecified).AddTicks(5935), 5L, new DateTime(2022, 1, 4, 12, 10, 7, 919, DateTimeKind.Unspecified).AddTicks(5957), 15L, new DateTime(2019, 9, 23, 18, 21, 47, 977, DateTimeKind.Unspecified).AddTicks(7683), new DateTime(2021, 8, 6, 7, 16, 45, 528, DateTimeKind.Unspecified).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 9, 19, 2, 41, 17, 952, DateTimeKind.Unspecified).AddTicks(8216), 2L, new DateTime(2022, 1, 10, 14, 29, 7, 276, DateTimeKind.Unspecified).AddTicks(7402), 38L, new DateTime(2019, 5, 14, 22, 2, 46, 533, DateTimeKind.Unspecified).AddTicks(571), new DateTime(2021, 7, 3, 18, 3, 52, 956, DateTimeKind.Unspecified).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 3, 20, 18, 31, 38, 293, DateTimeKind.Unspecified).AddTicks(3757), 2L, null, 76L, new DateTime(2019, 12, 8, 21, 24, 23, 147, DateTimeKind.Unspecified).AddTicks(4004), new DateTime(2021, 7, 12, 9, 56, 57, 995, DateTimeKind.Unspecified).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 48L, new DateTime(2021, 7, 12, 6, 12, 43, 437, DateTimeKind.Unspecified).AddTicks(1489), new DateTime(2022, 2, 1, 5, 11, 55, 886, DateTimeKind.Unspecified).AddTicks(7044), 33L, new DateTime(2019, 11, 9, 19, 43, 14, 170, DateTimeKind.Unspecified).AddTicks(7808), new DateTime(2021, 10, 26, 17, 17, 17, 946, DateTimeKind.Unspecified).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 6, 17, 16, 22, 56, 153, DateTimeKind.Unspecified).AddTicks(2820), 5L, new DateTime(2022, 1, 1, 17, 15, 43, 171, DateTimeKind.Unspecified).AddTicks(1486), 2L, new DateTime(2019, 9, 8, 17, 11, 30, 633, DateTimeKind.Unspecified).AddTicks(3109), new DateTime(2021, 3, 16, 8, 59, 35, 386, DateTimeKind.Unspecified).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 4, 22, 16, 2, 25, 896, DateTimeKind.Unspecified).AddTicks(3052), new DateTime(2022, 1, 20, 21, 53, 38, 16, DateTimeKind.Unspecified).AddTicks(9011), 81L, new DateTime(2019, 3, 7, 17, 38, 58, 662, DateTimeKind.Unspecified).AddTicks(1920), new DateTime(2021, 6, 17, 19, 18, 20, 183, DateTimeKind.Unspecified).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 8, 31, 16, 25, 27, 702, DateTimeKind.Unspecified).AddTicks(2488), 5L, new DateTime(2022, 1, 20, 11, 14, 26, 353, DateTimeKind.Unspecified).AddTicks(76), 53L, new DateTime(2019, 8, 3, 15, 16, 11, 65, DateTimeKind.Unspecified).AddTicks(59), new DateTime(2021, 5, 8, 0, 18, 33, 823, DateTimeKind.Unspecified).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 10, 5, 3, 8, 32, 646, DateTimeKind.Unspecified).AddTicks(7519), 4L, new DateTime(2022, 1, 30, 20, 56, 45, 176, DateTimeKind.Unspecified).AddTicks(2679), 5L, new DateTime(2019, 9, 25, 4, 5, 30, 182, DateTimeKind.Unspecified).AddTicks(6322), new DateTime(2021, 3, 28, 18, 34, 42, 376, DateTimeKind.Unspecified).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 12, 11, 3, 39, 51, 599, DateTimeKind.Unspecified).AddTicks(3856), 2L, null, 9L, new DateTime(2019, 5, 21, 18, 29, 38, 387, DateTimeKind.Unspecified).AddTicks(4077), new DateTime(2021, 9, 27, 19, 11, 8, 312, DateTimeKind.Unspecified).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 11, 7, 5, 48, 18, 595, DateTimeKind.Unspecified).AddTicks(3250), 5L, new DateTime(2022, 1, 5, 8, 16, 36, 669, DateTimeKind.Unspecified).AddTicks(1335), 40L, new DateTime(2019, 6, 6, 18, 52, 53, 802, DateTimeKind.Unspecified).AddTicks(4104), new DateTime(2021, 8, 29, 19, 49, 27, 284, DateTimeKind.Unspecified).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 4, 30, 18, 41, 7, 553, DateTimeKind.Unspecified).AddTicks(9375), 4L, new DateTime(2022, 1, 9, 14, 55, 58, 936, DateTimeKind.Unspecified).AddTicks(2752), 28L, new DateTime(2019, 8, 19, 4, 18, 21, 974, DateTimeKind.Unspecified).AddTicks(2218), new DateTime(2021, 3, 12, 17, 35, 23, 979, DateTimeKind.Unspecified).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 3, 23, 10, 42, 40, 117, DateTimeKind.Unspecified).AddTicks(6412), 3L, new DateTime(2022, 1, 28, 6, 28, 50, 655, DateTimeKind.Unspecified).AddTicks(4799), 7L, new DateTime(2019, 11, 1, 23, 35, 44, 712, DateTimeKind.Unspecified).AddTicks(7410), new DateTime(2021, 8, 7, 21, 19, 8, 248, DateTimeKind.Unspecified).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 9, 7, 10, 31, 27, 433, DateTimeKind.Unspecified).AddTicks(578), 2L, new DateTime(2022, 1, 2, 23, 39, 33, 181, DateTimeKind.Unspecified).AddTicks(7091), 29L, new DateTime(2019, 4, 5, 15, 55, 30, 811, DateTimeKind.Unspecified).AddTicks(8133), new DateTime(2021, 4, 18, 6, 7, 10, 652, DateTimeKind.Unspecified).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 3, 17, 18, 20, 37, 677, DateTimeKind.Unspecified).AddTicks(4052), 1L, new DateTime(2022, 1, 26, 19, 50, 15, 803, DateTimeKind.Unspecified).AddTicks(8993), 5L, new DateTime(2020, 1, 10, 16, 10, 14, 142, DateTimeKind.Unspecified).AddTicks(1664), new DateTime(2021, 6, 19, 5, 7, 40, 938, DateTimeKind.Unspecified).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 9, 21, 11, 54, 37, 20, DateTimeKind.Unspecified).AddTicks(2389), 3L, null, 6L, new DateTime(2019, 9, 10, 21, 1, 53, 952, DateTimeKind.Unspecified).AddTicks(2637), new DateTime(2021, 9, 11, 23, 28, 8, 887, DateTimeKind.Unspecified).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 14L, new DateTime(2021, 7, 2, 10, 12, 15, 113, DateTimeKind.Unspecified).AddTicks(5783), 1L, new DateTime(2022, 1, 25, 14, 58, 13, 815, DateTimeKind.Unspecified).AddTicks(1253), 37L, new DateTime(2019, 12, 17, 6, 59, 33, 563, DateTimeKind.Unspecified).AddTicks(6903), new DateTime(2021, 10, 27, 4, 37, 7, 0, DateTimeKind.Unspecified).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 12, 21, 4, 44, 20, 278, DateTimeKind.Unspecified).AddTicks(6650), null, 46L, new DateTime(2019, 11, 10, 8, 31, 48, 406, DateTimeKind.Unspecified).AddTicks(8963), new DateTime(2021, 4, 10, 0, 7, 8, 374, DateTimeKind.Unspecified).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 11, 16, 13, 6, 3, 818, DateTimeKind.Unspecified).AddTicks(714), 2L, new DateTime(2022, 1, 17, 14, 5, 23, 385, DateTimeKind.Unspecified).AddTicks(8106), 27L, new DateTime(2019, 4, 1, 11, 4, 49, 389, DateTimeKind.Unspecified).AddTicks(3294), new DateTime(2021, 11, 12, 18, 51, 15, 299, DateTimeKind.Unspecified).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 4, 24, 14, 36, 52, 329, DateTimeKind.Unspecified).AddTicks(7400), 1L, new DateTime(2022, 1, 15, 11, 49, 0, 331, DateTimeKind.Unspecified).AddTicks(6606), 36L, new DateTime(2019, 8, 6, 15, 10, 22, 330, DateTimeKind.Unspecified).AddTicks(3856), new DateTime(2021, 12, 21, 19, 30, 52, 966, DateTimeKind.Unspecified).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 6, 19, 22, 23, 50, 401, DateTimeKind.Unspecified).AddTicks(5997), 1L, new DateTime(2022, 1, 6, 4, 17, 19, 835, DateTimeKind.Unspecified).AddTicks(9952), 44L, new DateTime(2019, 5, 4, 11, 6, 19, 926, DateTimeKind.Unspecified).AddTicks(5169), new DateTime(2021, 9, 12, 3, 31, 23, 624, DateTimeKind.Unspecified).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 3, 31, 17, 57, 53, 215, DateTimeKind.Unspecified).AddTicks(1616), 3L, new DateTime(2022, 1, 2, 22, 40, 7, 522, DateTimeKind.Unspecified).AddTicks(9950), 9L, new DateTime(2019, 9, 12, 2, 36, 49, 302, DateTimeKind.Unspecified).AddTicks(557), new DateTime(2021, 3, 22, 0, 13, 41, 626, DateTimeKind.Unspecified).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 4, 13, 13, 23, 8, 37, DateTimeKind.Unspecified).AddTicks(5818), new DateTime(2022, 1, 6, 5, 57, 43, 107, DateTimeKind.Unspecified).AddTicks(1295), 19L, new DateTime(2019, 3, 20, 18, 34, 27, 539, DateTimeKind.Unspecified).AddTicks(883), new DateTime(2021, 3, 23, 22, 33, 12, 739, DateTimeKind.Unspecified).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 4, 15, 3, 12, 39, 921, DateTimeKind.Unspecified).AddTicks(8542), 5L, new DateTime(2022, 1, 11, 18, 33, 18, 11, DateTimeKind.Unspecified).AddTicks(4026), 57L, new DateTime(2019, 7, 10, 12, 36, 36, 782, DateTimeKind.Unspecified).AddTicks(7144), new DateTime(2021, 7, 23, 9, 51, 30, 146, DateTimeKind.Unspecified).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 21L, new DateTime(2021, 10, 10, 9, 46, 50, 270, DateTimeKind.Unspecified).AddTicks(5106), 3L, new DateTime(2022, 1, 9, 16, 18, 46, 662, DateTimeKind.Unspecified).AddTicks(4605), 20L, new DateTime(2019, 11, 28, 4, 26, 17, 918, DateTimeKind.Unspecified).AddTicks(8543), new DateTime(2021, 4, 23, 1, 37, 24, 135, DateTimeKind.Unspecified).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 9, 7, 14, 42, 1, 841, DateTimeKind.Unspecified).AddTicks(7608), 2L, new DateTime(2022, 1, 30, 17, 23, 28, 231, DateTimeKind.Unspecified).AddTicks(3099), 3L, new DateTime(2019, 5, 21, 0, 32, 16, 188, DateTimeKind.Unspecified).AddTicks(103), new DateTime(2021, 11, 24, 3, 6, 34, 21, DateTimeKind.Unspecified).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 7, 25, 5, 49, 34, 668, DateTimeKind.Unspecified).AddTicks(7406), 2L, new DateTime(2022, 1, 17, 3, 49, 52, 158, DateTimeKind.Unspecified).AddTicks(8724), 16L, new DateTime(2019, 8, 1, 11, 30, 8, 465, DateTimeKind.Unspecified).AddTicks(2185), new DateTime(2021, 8, 12, 1, 14, 58, 873, DateTimeKind.Unspecified).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 5, 23, 21, 13, 50, 269, DateTimeKind.Unspecified).AddTicks(4408), 4L, null, 73L, new DateTime(2019, 3, 25, 5, 10, 27, 236, DateTimeKind.Unspecified).AddTicks(486), new DateTime(2021, 5, 10, 15, 3, 18, 666, DateTimeKind.Unspecified).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 6, 12, 17, 5, 5, 986, DateTimeKind.Unspecified).AddTicks(8756), new DateTime(2022, 1, 2, 17, 24, 58, 801, DateTimeKind.Unspecified).AddTicks(7300), 61L, new DateTime(2019, 9, 23, 16, 3, 34, 409, DateTimeKind.Unspecified).AddTicks(1905), new DateTime(2021, 4, 5, 7, 31, 35, 731, DateTimeKind.Unspecified).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 16L, new DateTime(2021, 7, 17, 17, 52, 20, 277, DateTimeKind.Unspecified).AddTicks(759), new DateTime(2022, 1, 7, 12, 58, 4, 447, DateTimeKind.Unspecified).AddTicks(2655), 44L, new DateTime(2019, 5, 30, 17, 1, 55, 6, DateTimeKind.Unspecified).AddTicks(2578), new DateTime(2021, 11, 7, 6, 32, 3, 836, DateTimeKind.Unspecified).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 2, 2, 19, 7, 5, 924, DateTimeKind.Unspecified).AddTicks(411), 3L, new DateTime(2022, 1, 25, 11, 55, 46, 330, DateTimeKind.Unspecified).AddTicks(1024), 30L, new DateTime(2019, 10, 14, 22, 32, 38, 735, DateTimeKind.Unspecified).AddTicks(9300), new DateTime(2021, 12, 7, 11, 50, 36, 659, DateTimeKind.Unspecified).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 4, 10, 21, 21, 39, 563, DateTimeKind.Unspecified).AddTicks(4556), 1L, null, 44L, new DateTime(2020, 1, 9, 13, 47, 5, 635, DateTimeKind.Unspecified).AddTicks(8199), new DateTime(2021, 9, 30, 5, 53, 45, 662, DateTimeKind.Unspecified).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 5, 1, 23, 24, 12, 630, DateTimeKind.Unspecified).AddTicks(1136), 3L, null, 50L, new DateTime(2019, 10, 29, 23, 33, 4, 975, DateTimeKind.Unspecified).AddTicks(9690), new DateTime(2021, 3, 26, 22, 20, 55, 407, DateTimeKind.Unspecified).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 10, 3, 10, 42, 27, 603, DateTimeKind.Unspecified).AddTicks(4061), new DateTime(2022, 1, 27, 10, 44, 18, 728, DateTimeKind.Unspecified).AddTicks(900), 50L, new DateTime(2019, 12, 5, 9, 31, 19, 278, DateTimeKind.Unspecified).AddTicks(946), new DateTime(2021, 11, 12, 0, 47, 2, 799, DateTimeKind.Unspecified).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2022, 1, 31, 9, 23, 34, 334, DateTimeKind.Unspecified).AddTicks(1669), 3L, new DateTime(2022, 1, 23, 18, 23, 55, 665, DateTimeKind.Unspecified).AddTicks(9512), 22L, new DateTime(2019, 4, 12, 17, 28, 54, 630, DateTimeKind.Unspecified).AddTicks(7869), new DateTime(2021, 6, 26, 2, 0, 55, 38, DateTimeKind.Unspecified).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 46L, new DateTime(2021, 12, 11, 14, 48, 0, 923, DateTimeKind.Unspecified).AddTicks(963), 3L, null, 35L, new DateTime(2019, 5, 15, 15, 20, 6, 397, DateTimeKind.Unspecified).AddTicks(8676), new DateTime(2021, 1, 21, 11, 31, 24, 131, DateTimeKind.Unspecified).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 5, 24, 6, 4, 24, 455, DateTimeKind.Unspecified).AddTicks(4657), 3L, null, 45L, new DateTime(2019, 5, 13, 6, 7, 39, 829, DateTimeKind.Unspecified).AddTicks(6626), new DateTime(2021, 5, 23, 11, 46, 34, 40, DateTimeKind.Unspecified).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 8, 18, 14, 19, 31, 530, DateTimeKind.Unspecified).AddTicks(338), new DateTime(2022, 1, 7, 20, 45, 10, 882, DateTimeKind.Unspecified).AddTicks(7492), 12L, new DateTime(2019, 9, 28, 21, 59, 52, 981, DateTimeKind.Unspecified).AddTicks(2323), new DateTime(2021, 1, 4, 9, 28, 29, 207, DateTimeKind.Unspecified).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 2, 2, 4, 31, 12, 244, DateTimeKind.Unspecified).AddTicks(6771), 4L, new DateTime(2022, 1, 8, 6, 26, 18, 923, DateTimeKind.Unspecified).AddTicks(6132), 71L, new DateTime(2019, 7, 28, 18, 40, 30, 64, DateTimeKind.Unspecified).AddTicks(9837), new DateTime(2021, 7, 11, 10, 59, 52, 106, DateTimeKind.Unspecified).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 5, 5, 16, 5, 7, 462, DateTimeKind.Unspecified).AddTicks(6790), 5L, new DateTime(2022, 1, 10, 1, 35, 23, 996, DateTimeKind.Unspecified).AddTicks(1934), 43L, new DateTime(2019, 5, 12, 17, 30, 10, 167, DateTimeKind.Unspecified).AddTicks(4925), new DateTime(2021, 12, 12, 4, 36, 59, 236, DateTimeKind.Unspecified).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 10, 28, 7, 28, 4, 994, DateTimeKind.Unspecified).AddTicks(7622), 4L, new DateTime(2022, 1, 22, 23, 54, 50, 866, DateTimeKind.Unspecified).AddTicks(2109), 15L, new DateTime(2019, 8, 31, 15, 45, 47, 527, DateTimeKind.Unspecified).AddTicks(4693), new DateTime(2021, 9, 7, 6, 47, 12, 40, DateTimeKind.Unspecified).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 6, 30, 22, 48, 14, 413, DateTimeKind.Unspecified).AddTicks(6957), new DateTime(2022, 1, 30, 3, 35, 28, 209, DateTimeKind.Unspecified).AddTicks(1424), 16L, new DateTime(2019, 3, 9, 15, 15, 19, 397, DateTimeKind.Unspecified).AddTicks(5734), new DateTime(2021, 1, 6, 22, 26, 5, 20, DateTimeKind.Unspecified).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 3, 26, 5, 4, 34, 91, DateTimeKind.Unspecified).AddTicks(2329), new DateTime(2022, 1, 18, 18, 6, 10, 666, DateTimeKind.Unspecified).AddTicks(9798), 59L, new DateTime(2020, 1, 19, 17, 5, 36, 416, DateTimeKind.Unspecified).AddTicks(1212), new DateTime(2021, 2, 16, 4, 59, 0, 329, DateTimeKind.Unspecified).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 4, 5, 14, 16, 39, 766, DateTimeKind.Unspecified).AddTicks(5317), 4L, new DateTime(2022, 1, 11, 17, 49, 11, 177, DateTimeKind.Unspecified).AddTicks(756), 55L, new DateTime(2019, 5, 22, 4, 6, 39, 598, DateTimeKind.Unspecified).AddTicks(7514), new DateTime(2021, 5, 18, 18, 56, 21, 98, DateTimeKind.Unspecified).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 9, 27, 23, 59, 31, 596, DateTimeKind.Unspecified).AddTicks(3721), 2L, new DateTime(2022, 1, 29, 22, 31, 20, 888, DateTimeKind.Unspecified).AddTicks(4343), 36L, new DateTime(2019, 12, 11, 3, 30, 38, 499, DateTimeKind.Unspecified).AddTicks(9915), new DateTime(2021, 6, 20, 23, 17, 58, 469, DateTimeKind.Unspecified).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 7, 16, 23, 13, 14, 386, DateTimeKind.Unspecified).AddTicks(5703), 5L, new DateTime(2022, 1, 27, 3, 20, 27, 445, DateTimeKind.Unspecified).AddTicks(1282), 47L, new DateTime(2019, 4, 27, 15, 59, 4, 824, DateTimeKind.Unspecified).AddTicks(9757), new DateTime(2021, 12, 18, 5, 9, 29, 592, DateTimeKind.Unspecified).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 5, 21, 19, 57, 29, 205, DateTimeKind.Unspecified).AddTicks(5319), 3L, new DateTime(2022, 1, 28, 22, 43, 20, 554, DateTimeKind.Unspecified).AddTicks(2555), 41L, new DateTime(2019, 8, 14, 8, 38, 37, 621, DateTimeKind.Unspecified).AddTicks(9772), new DateTime(2021, 9, 10, 8, 41, 23, 745, DateTimeKind.Unspecified).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 11, 9, 7, 11, 32, 677, DateTimeKind.Unspecified).AddTicks(5129), 1L, new DateTime(2022, 1, 29, 9, 4, 57, 782, DateTimeKind.Unspecified).AddTicks(9907), 12L, new DateTime(2019, 9, 22, 21, 0, 21, 684, DateTimeKind.Unspecified).AddTicks(4479), new DateTime(2021, 10, 31, 2, 35, 48, 33, DateTimeKind.Unspecified).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 6, 26, 9, 13, 17, 475, DateTimeKind.Unspecified).AddTicks(301), 1L, new DateTime(2022, 2, 1, 1, 16, 28, 369, DateTimeKind.Unspecified).AddTicks(5221), 52L, new DateTime(2019, 9, 30, 2, 37, 13, 603, DateTimeKind.Unspecified).AddTicks(8350), new DateTime(2021, 1, 31, 1, 59, 22, 152, DateTimeKind.Unspecified).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 47L, new DateTime(2021, 12, 17, 18, 43, 15, 647, DateTimeKind.Unspecified).AddTicks(7107), 5L, new DateTime(2022, 1, 20, 4, 9, 3, 770, DateTimeKind.Unspecified).AddTicks(3694), 43L, new DateTime(2019, 3, 11, 18, 34, 11, 100, DateTimeKind.Unspecified).AddTicks(1511), new DateTime(2021, 3, 17, 12, 13, 44, 516, DateTimeKind.Unspecified).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 6, 10, 15, 52, 58, 652, DateTimeKind.Unspecified).AddTicks(271), 5L, new DateTime(2022, 1, 6, 3, 17, 43, 132, DateTimeKind.Unspecified).AddTicks(1590), 64L, new DateTime(2019, 8, 31, 2, 47, 10, 394, DateTimeKind.Unspecified).AddTicks(8047), new DateTime(2021, 10, 15, 11, 58, 38, 750, DateTimeKind.Unspecified).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 6, 12, 13, 16, 25, 526, DateTimeKind.Unspecified).AddTicks(9908), 3L, new DateTime(2022, 1, 16, 11, 41, 16, 795, DateTimeKind.Unspecified).AddTicks(7719), 32L, new DateTime(2019, 3, 6, 23, 44, 30, 481, DateTimeKind.Unspecified).AddTicks(1628), new DateTime(2021, 3, 15, 21, 51, 18, 89, DateTimeKind.Unspecified).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 4, 1, 3, 20, 37, 712, DateTimeKind.Unspecified).AddTicks(7852), 2L, new DateTime(2022, 1, 15, 20, 26, 7, 906, DateTimeKind.Unspecified).AddTicks(6911), 32L, new DateTime(2019, 2, 17, 7, 16, 24, 380, DateTimeKind.Unspecified).AddTicks(6180), new DateTime(2021, 8, 2, 10, 48, 0, 723, DateTimeKind.Unspecified).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 46L, new DateTime(2021, 3, 29, 17, 49, 35, 77, DateTimeKind.Unspecified).AddTicks(4086), new DateTime(2022, 2, 1, 22, 27, 43, 359, DateTimeKind.Unspecified).AddTicks(2580), 28L, new DateTime(2019, 7, 20, 6, 33, 27, 767, DateTimeKind.Unspecified).AddTicks(9178), new DateTime(2021, 4, 9, 3, 38, 55, 47, DateTimeKind.Unspecified).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2021, 7, 11, 15, 47, 15, 636, DateTimeKind.Unspecified).AddTicks(5066), 3L, null, 36L, new DateTime(2019, 2, 27, 5, 5, 25, 998, DateTimeKind.Unspecified).AddTicks(7767), new DateTime(2021, 10, 5, 11, 19, 14, 734, DateTimeKind.Unspecified).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 7, 28, 2, 56, 26, 586, DateTimeKind.Unspecified).AddTicks(8394), 1L, null, 45L, new DateTime(2019, 11, 15, 3, 41, 24, 216, DateTimeKind.Unspecified).AddTicks(3446), new DateTime(2021, 4, 28, 20, 40, 14, 741, DateTimeKind.Unspecified).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2022, 1, 15, 2, 3, 24, 94, DateTimeKind.Unspecified).AddTicks(4641), 3L, new DateTime(2022, 1, 9, 13, 3, 43, 200, DateTimeKind.Unspecified).AddTicks(451), 3L, new DateTime(2019, 5, 25, 19, 13, 6, 719, DateTimeKind.Unspecified).AddTicks(1473), new DateTime(2021, 12, 16, 5, 52, 17, 907, DateTimeKind.Unspecified).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 7, 6, 19, 4, 5, 436, DateTimeKind.Unspecified).AddTicks(4664), 4L, new DateTime(2022, 1, 1, 23, 19, 3, 895, DateTimeKind.Unspecified).AddTicks(2360), 10L, new DateTime(2019, 7, 29, 8, 58, 51, 527, DateTimeKind.Unspecified).AddTicks(9664), new DateTime(2021, 4, 27, 17, 40, 51, 563, DateTimeKind.Unspecified).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 7, 26, 0, 17, 41, 66, DateTimeKind.Unspecified).AddTicks(3434), new DateTime(2022, 1, 22, 16, 48, 21, 219, DateTimeKind.Unspecified).AddTicks(7642), 39L, new DateTime(2019, 9, 7, 5, 35, 59, 73, DateTimeKind.Unspecified).AddTicks(1640), new DateTime(2021, 8, 21, 9, 23, 33, 529, DateTimeKind.Unspecified).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 2, 3, 14, 27, 13, 241, DateTimeKind.Unspecified).AddTicks(9533), 4L, new DateTime(2022, 1, 22, 2, 7, 13, 879, DateTimeKind.Unspecified).AddTicks(6994), new DateTime(2019, 12, 9, 8, 29, 50, 891, DateTimeKind.Unspecified).AddTicks(179), new DateTime(2021, 11, 26, 1, 22, 49, 572, DateTimeKind.Unspecified).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 3, 8, 3, 31, 50, 307, DateTimeKind.Unspecified).AddTicks(5280), 4L, new DateTime(2022, 1, 3, 1, 21, 42, 230, DateTimeKind.Unspecified).AddTicks(5839), 40L, new DateTime(2019, 11, 17, 11, 36, 5, 506, DateTimeKind.Unspecified).AddTicks(2915), new DateTime(2021, 6, 25, 9, 23, 54, 278, DateTimeKind.Unspecified).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 12, 25, 17, 33, 21, 236, DateTimeKind.Unspecified).AddTicks(3013), 4L, new DateTime(2022, 1, 17, 23, 16, 56, 324, DateTimeKind.Unspecified).AddTicks(108), 74L, new DateTime(2019, 11, 7, 8, 8, 9, 658, DateTimeKind.Unspecified).AddTicks(2442), new DateTime(2021, 5, 18, 20, 1, 30, 431, DateTimeKind.Unspecified).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 11, 13, 22, 4, 59, 537, DateTimeKind.Unspecified).AddTicks(1235), new DateTime(2022, 1, 22, 8, 18, 45, 375, DateTimeKind.Unspecified).AddTicks(9389), 23L, new DateTime(2019, 7, 7, 15, 40, 18, 834, DateTimeKind.Unspecified).AddTicks(8243), new DateTime(2021, 2, 3, 17, 15, 53, 710, DateTimeKind.Unspecified).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 10, 10, 23, 58, 24, 559, DateTimeKind.Unspecified).AddTicks(8819), new DateTime(2022, 1, 6, 10, 18, 15, 785, DateTimeKind.Unspecified).AddTicks(1687), 21L, new DateTime(2019, 10, 22, 21, 54, 9, 714, DateTimeKind.Unspecified).AddTicks(4157), new DateTime(2021, 9, 29, 11, 16, 59, 441, DateTimeKind.Unspecified).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 2, 28, 19, 16, 3, 327, DateTimeKind.Unspecified).AddTicks(6), 3L, new DateTime(2022, 1, 11, 4, 33, 20, 321, DateTimeKind.Unspecified).AddTicks(5121), 66L, new DateTime(2019, 6, 18, 23, 50, 29, 84, DateTimeKind.Unspecified).AddTicks(2068), new DateTime(2021, 1, 13, 16, 25, 18, 296, DateTimeKind.Unspecified).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 11, 5, 9, 56, 1, 844, DateTimeKind.Unspecified).AddTicks(5861), new DateTime(2022, 1, 18, 12, 30, 4, 878, DateTimeKind.Unspecified).AddTicks(4629), 4L, new DateTime(2019, 4, 1, 9, 33, 11, 936, DateTimeKind.Unspecified).AddTicks(1439), new DateTime(2021, 10, 9, 15, 58, 22, 345, DateTimeKind.Unspecified).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 2, 25, 14, 38, 38, 822, DateTimeKind.Unspecified).AddTicks(8659), 1L, new DateTime(2022, 1, 23, 15, 16, 59, 314, DateTimeKind.Unspecified).AddTicks(1508), 16L, new DateTime(2019, 12, 20, 0, 7, 20, 450, DateTimeKind.Unspecified).AddTicks(1559), new DateTime(2021, 7, 22, 6, 29, 35, 176, DateTimeKind.Unspecified).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 2, 3, 14, 26, 28, 834, DateTimeKind.Unspecified).AddTicks(2280), 3L, new DateTime(2022, 1, 22, 4, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(8440), 53L, new DateTime(2019, 3, 4, 21, 15, 29, 985, DateTimeKind.Unspecified).AddTicks(4560), new DateTime(2021, 11, 5, 9, 6, 55, 604, DateTimeKind.Unspecified).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 4, 28, 14, 6, 42, 548, DateTimeKind.Unspecified).AddTicks(447), 1L, new DateTime(2022, 1, 1, 15, 52, 42, 27, DateTimeKind.Unspecified).AddTicks(518), 40L, new DateTime(2020, 1, 20, 0, 50, 40, 48, DateTimeKind.Unspecified).AddTicks(5291), new DateTime(2021, 3, 21, 13, 32, 14, 505, DateTimeKind.Unspecified).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 11, 3, 12, 24, 22, 49, DateTimeKind.Unspecified).AddTicks(7450), 2L, null, 81L, new DateTime(2019, 7, 4, 3, 19, 44, 272, DateTimeKind.Unspecified).AddTicks(8015), new DateTime(2021, 9, 28, 6, 49, 59, 646, DateTimeKind.Unspecified).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 8, 25, 23, 37, 21, 622, DateTimeKind.Unspecified).AddTicks(5353), 4L, new DateTime(2022, 1, 1, 21, 54, 54, 495, DateTimeKind.Unspecified).AddTicks(1425), 60L, new DateTime(2019, 6, 18, 21, 22, 7, 861, DateTimeKind.Unspecified).AddTicks(1094), new DateTime(2021, 12, 5, 8, 13, 5, 644, DateTimeKind.Unspecified).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 11, 23, 18, 39, 7, 516, DateTimeKind.Unspecified).AddTicks(4070), 4L, new DateTime(2022, 1, 13, 8, 12, 12, 59, DateTimeKind.Unspecified).AddTicks(216), 16L, new DateTime(2019, 3, 8, 21, 40, 15, 24, DateTimeKind.Unspecified).AddTicks(9576), new DateTime(2021, 5, 20, 20, 6, 24, 990, DateTimeKind.Unspecified).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 2L, new DateTime(2021, 6, 13, 4, 18, 50, 409, DateTimeKind.Unspecified).AddTicks(7546), 4L, new DateTime(2022, 1, 18, 6, 5, 26, 467, DateTimeKind.Unspecified).AddTicks(1592), 61L, new DateTime(2019, 11, 9, 18, 59, 36, 978, DateTimeKind.Unspecified).AddTicks(5782), new DateTime(2021, 7, 21, 10, 47, 5, 729, DateTimeKind.Unspecified).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 3, 1, 9, 32, 15, 531, DateTimeKind.Unspecified).AddTicks(7827), new DateTime(2022, 1, 2, 0, 7, 18, 4, DateTimeKind.Unspecified).AddTicks(3434), 4L, new DateTime(2019, 8, 4, 21, 7, 2, 634, DateTimeKind.Unspecified).AddTicks(7175), new DateTime(2021, 12, 10, 18, 56, 6, 600, DateTimeKind.Unspecified).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 10, 12, 13, 54, 18, 814, DateTimeKind.Unspecified).AddTicks(6413), 3L, new DateTime(2022, 1, 23, 8, 3, 32, 602, DateTimeKind.Unspecified).AddTicks(6557), 60L, new DateTime(2019, 7, 10, 3, 30, 1, 985, DateTimeKind.Unspecified).AddTicks(9268), new DateTime(2021, 6, 1, 0, 12, 41, 627, DateTimeKind.Unspecified).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 9, 10, 2, 52, 5, 118, DateTimeKind.Unspecified).AddTicks(6136), 4L, new DateTime(2022, 1, 15, 21, 22, 28, 20, DateTimeKind.Unspecified).AddTicks(4851), 70L, new DateTime(2019, 8, 25, 7, 3, 44, 221, DateTimeKind.Unspecified).AddTicks(8762), new DateTime(2021, 8, 1, 12, 44, 5, 993, DateTimeKind.Unspecified).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 3, 19, 7, 23, 21, 830, DateTimeKind.Unspecified).AddTicks(3757), 2L, new DateTime(2022, 1, 28, 14, 39, 38, 789, DateTimeKind.Unspecified).AddTicks(6298), 46L, new DateTime(2019, 12, 19, 6, 30, 56, 572, DateTimeKind.Unspecified).AddTicks(4393), new DateTime(2021, 6, 23, 21, 56, 47, 562, DateTimeKind.Unspecified).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 3, 22, 8, 16, 57, 256, DateTimeKind.Unspecified).AddTicks(2678), 5L, new DateTime(2022, 1, 11, 1, 59, 1, 508, DateTimeKind.Unspecified).AddTicks(789), 80L, new DateTime(2019, 10, 25, 9, 52, 27, 724, DateTimeKind.Unspecified).AddTicks(9266), new DateTime(2021, 5, 22, 14, 17, 0, 744, DateTimeKind.Unspecified).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 26L, new DateTime(2021, 8, 3, 2, 57, 1, 110, DateTimeKind.Unspecified).AddTicks(8123), 3L, new DateTime(2022, 1, 21, 7, 54, 34, 505, DateTimeKind.Unspecified).AddTicks(9563), 20L, new DateTime(2019, 11, 30, 6, 32, 59, 765, DateTimeKind.Unspecified).AddTicks(4143), new DateTime(2021, 6, 18, 4, 6, 25, 579, DateTimeKind.Unspecified).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 16L, new DateTime(2021, 6, 13, 7, 0, 35, 98, DateTimeKind.Unspecified).AddTicks(4199), 3L, new DateTime(2022, 1, 10, 1, 19, 18, 144, DateTimeKind.Unspecified).AddTicks(7430), 37L, new DateTime(2019, 12, 30, 21, 17, 30, 312, DateTimeKind.Unspecified).AddTicks(6248), new DateTime(2021, 3, 26, 9, 7, 37, 580, DateTimeKind.Unspecified).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2022, 1, 28, 16, 21, 11, 209, DateTimeKind.Unspecified).AddTicks(9767), 3L, null, 4L, new DateTime(2019, 10, 7, 4, 19, 6, 716, DateTimeKind.Unspecified).AddTicks(5662), new DateTime(2021, 8, 20, 14, 0, 21, 105, DateTimeKind.Unspecified).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 8, 19, 7, 4, 5, 883, DateTimeKind.Unspecified).AddTicks(743), 4L, new DateTime(2022, 1, 4, 11, 33, 14, 961, DateTimeKind.Unspecified).AddTicks(9740), new DateTime(2019, 11, 29, 9, 59, 28, 358, DateTimeKind.Unspecified).AddTicks(3323), new DateTime(2021, 10, 28, 1, 48, 46, 829, DateTimeKind.Unspecified).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 3, 15, 12, 41, 57, 981, DateTimeKind.Unspecified).AddTicks(931), 5L, new DateTime(2022, 1, 1, 23, 42, 27, 906, DateTimeKind.Unspecified).AddTicks(7723), 72L, new DateTime(2019, 6, 5, 15, 9, 19, 891, DateTimeKind.Unspecified).AddTicks(5369), new DateTime(2021, 8, 7, 4, 35, 5, 614, DateTimeKind.Unspecified).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 4, 7, 4, 6, 1, 297, DateTimeKind.Unspecified).AddTicks(8125), 3L, new DateTime(2022, 1, 3, 16, 37, 54, 279, DateTimeKind.Unspecified).AddTicks(8935), 66L, new DateTime(2019, 3, 9, 8, 16, 19, 676, DateTimeKind.Unspecified).AddTicks(1458), new DateTime(2021, 5, 13, 1, 25, 29, 180, DateTimeKind.Unspecified).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 12, 12, 13, 17, 33, 828, DateTimeKind.Unspecified).AddTicks(5314), null, 72L, new DateTime(2019, 3, 31, 19, 46, 48, 933, DateTimeKind.Unspecified).AddTicks(8888), new DateTime(2021, 9, 4, 7, 8, 12, 924, DateTimeKind.Unspecified).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 11, 12, 22, 49, 17, 830, DateTimeKind.Unspecified).AddTicks(5716), new DateTime(2022, 1, 18, 18, 49, 11, 527, DateTimeKind.Unspecified).AddTicks(9772), 29L, new DateTime(2019, 2, 6, 17, 17, 52, 107, DateTimeKind.Unspecified).AddTicks(9267), new DateTime(2021, 8, 16, 13, 34, 18, 543, DateTimeKind.Unspecified).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 8, 26, 17, 8, 57, 525, DateTimeKind.Unspecified).AddTicks(5515), 3L, new DateTime(2022, 1, 25, 13, 29, 5, 478, DateTimeKind.Unspecified).AddTicks(3308), 75L, new DateTime(2019, 6, 20, 23, 2, 40, 825, DateTimeKind.Unspecified).AddTicks(6130), new DateTime(2021, 10, 29, 13, 53, 38, 471, DateTimeKind.Unspecified).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 9, 20, 7, 32, 16, 373, DateTimeKind.Unspecified).AddTicks(6443), 4L, new DateTime(2022, 1, 5, 9, 48, 9, 828, DateTimeKind.Unspecified).AddTicks(4778), 22L, new DateTime(2019, 5, 13, 2, 0, 37, 928, DateTimeKind.Unspecified).AddTicks(9601), new DateTime(2021, 10, 14, 15, 48, 31, 619, DateTimeKind.Unspecified).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 4, 22, 20, 30, 20, 846, DateTimeKind.Unspecified).AddTicks(7395), 1L, new DateTime(2022, 1, 13, 11, 11, 20, 849, DateTimeKind.Unspecified).AddTicks(47), 46L, new DateTime(2019, 11, 10, 1, 4, 45, 729, DateTimeKind.Unspecified).AddTicks(5993), new DateTime(2021, 4, 14, 21, 8, 23, 832, DateTimeKind.Unspecified).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 7, 12, 5, 38, 42, 414, DateTimeKind.Unspecified).AddTicks(6237), 4L, new DateTime(2022, 1, 21, 16, 27, 56, 838, DateTimeKind.Unspecified).AddTicks(5150), 21L, new DateTime(2019, 3, 8, 22, 59, 42, 966, DateTimeKind.Unspecified).AddTicks(7104), new DateTime(2021, 11, 21, 19, 42, 33, 390, DateTimeKind.Unspecified).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 2, 28, 0, 19, 44, 281, DateTimeKind.Unspecified).AddTicks(3661), 3L, new DateTime(2022, 1, 20, 5, 24, 41, 426, DateTimeKind.Unspecified).AddTicks(8695), 74L, new DateTime(2019, 10, 24, 11, 47, 43, 403, DateTimeKind.Unspecified).AddTicks(4518), new DateTime(2021, 11, 11, 16, 1, 38, 835, DateTimeKind.Unspecified).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 5, 10, 6, 46, 20, 596, DateTimeKind.Unspecified).AddTicks(2348), 1L, new DateTime(2022, 1, 11, 17, 55, 20, 732, DateTimeKind.Unspecified).AddTicks(2630), 72L, new DateTime(2019, 10, 31, 21, 10, 46, 846, DateTimeKind.Unspecified).AddTicks(4968), new DateTime(2021, 11, 1, 4, 0, 52, 765, DateTimeKind.Unspecified).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2022, 1, 7, 19, 17, 57, 558, DateTimeKind.Unspecified).AddTicks(4872), 4L, new DateTime(2022, 1, 14, 22, 56, 15, 320, DateTimeKind.Unspecified).AddTicks(2808), 29L, new DateTime(2019, 3, 16, 12, 2, 53, 610, DateTimeKind.Unspecified).AddTicks(9071), new DateTime(2021, 3, 10, 3, 57, 7, 239, DateTimeKind.Unspecified).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 8, 9, 14, 43, 27, 946, DateTimeKind.Unspecified).AddTicks(2224), 1L, new DateTime(2022, 1, 26, 0, 23, 1, 958, DateTimeKind.Unspecified).AddTicks(3467), 67L, new DateTime(2019, 5, 29, 6, 8, 27, 622, DateTimeKind.Unspecified).AddTicks(9258), new DateTime(2021, 12, 27, 0, 19, 2, 708, DateTimeKind.Unspecified).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 10, 6, 18, 50, 18, 292, DateTimeKind.Unspecified).AddTicks(9340), null, 25L, new DateTime(2020, 1, 23, 6, 20, 51, 525, DateTimeKind.Unspecified).AddTicks(4291), new DateTime(2021, 7, 30, 12, 27, 27, 20, DateTimeKind.Unspecified).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Rerum similique ullam laboriosam.\nOptio accusamus incidunt corrupti eum alias odio voluptas et.\nAut suscipit earum amet dolores vero molestias.\nLabore natus dolorum sit.\nSunt quo dolorem autem ex perspiciatis magnam quaerat aliquid et.", new DateTime(2021, 2, 26, 5, 19, 23, 516, DateTimeKind.Unspecified).AddTicks(7450), 1L, 37L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 48L, "Ea harum modi nam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.\nQui commodi recusandae distinctio et nam quia dicta eius.\nCommodi non nihil non quod recusandae et est porro debitis.\nQui nam cum optio aut maxime veniam est quia sed.", new DateTime(2021, 7, 2, 9, 42, 4, 30, DateTimeKind.Unspecified).AddTicks(2606), 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Ad vitae eos sequi unde.", new DateTime(2021, 9, 29, 1, 24, 25, 226, DateTimeKind.Unspecified).AddTicks(4812), 5L, 56L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Assumenda est dignissimos ea.\nSit at placeat optio aliquam sapiente pariatur.", new DateTime(2022, 1, 16, 9, 47, 18, 459, DateTimeKind.Unspecified).AddTicks(6154), 2L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 21L, "Labore at fuga nam libero est.\nVero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.\nFacere praesentium rem ea impedit voluptatum est consequatur.", new DateTime(2021, 10, 9, 14, 57, 28, 795, DateTimeKind.Unspecified).AddTicks(5344), 1L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 16L, "Magni at repellendus.", new DateTime(2021, 8, 19, 20, 32, 22, 12, DateTimeKind.Unspecified).AddTicks(1254), 54L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Qui et sit nemo et consequatur.\nVoluptate voluptatem recusandae sunt sunt est non deleniti tempore provident.\nEt omnis qui illo rerum optio consequatur reiciendis.\nAut qui voluptatem laudantium numquam quo ut.\nMolestiae cupiditate dolorem commodi ea.\nAlias aperiam eum sit non atque.", new DateTime(2021, 12, 17, 15, 29, 24, 832, DateTimeKind.Unspecified).AddTicks(6984), 4L, 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Commodi libero dicta temporibus atque earum ut.\nEos qui eum totam debitis id.\nAdipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 5L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 1L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 3L, 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 2L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 47L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 3L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 1L, 65L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 3L, 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 3L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 5L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 3L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 5L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 5L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 25L, "Ipsam minima vel totam vel deserunt ab.\nEnim dolorem aliquid aperiam quod tempore porro ad nemo sit.\nNisi quis dolore nihil.", new DateTime(2021, 3, 28, 17, 3, 2, 998, DateTimeKind.Unspecified).AddTicks(838), 3L, 81L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 13L, "Non fugiat non porro vero reiciendis et.\nEnim facere autem molestiae.", new DateTime(2021, 4, 1, 7, 35, 59, 215, DateTimeKind.Unspecified).AddTicks(830), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Quo corporis voluptatem.\nQuia ut architecto adipisci quasi at aliquid voluptatum et.\nConsequatur voluptate dolor doloribus quam ipsam rerum optio.\nAperiam aperiam et.", new DateTime(2021, 12, 23, 16, 16, 38, 159, DateTimeKind.Unspecified).AddTicks(4359), 1L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Qui quam perferendis itaque dolore eligendi expedita.\nFacilis distinctio et omnis necessitatibus quibusdam rerum.\nEt qui ex itaque quam tempora quia eos.", new DateTime(2021, 5, 6, 9, 31, 38, 3, DateTimeKind.Unspecified).AddTicks(8430), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Illo a ex minus.\nDucimus qui officiis.\nDicta suscipit voluptas libero.\nTemporibus enim qui labore.", new DateTime(2021, 10, 9, 0, 43, 5, 480, DateTimeKind.Unspecified).AddTicks(7270), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 44L, "Sed tempora non officiis est sit eveniet.\nArchitecto corrupti id rerum quam nesciunt assumenda odio ut maxime.\nUt animi in iste voluptatibus aliquid ut vitae.\nVelit exercitationem vero id sed quibusdam non.\nUt at ratione qui consectetur quam voluptas dolor dolorum.", new DateTime(2021, 8, 14, 13, 57, 37, 263, DateTimeKind.Unspecified).AddTicks(4946), 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Quo dolor harum et maxime.\nEt ut quia ab animi occaecati beatae.\nVel autem ea molestias.\nAspernatur sunt explicabo.\nCorporis vitae porro voluptas et magni alias sit quia quia.\nImpedit maiores unde possimus aspernatur enim ea et ut.", new DateTime(2021, 9, 6, 6, 15, 51, 816, DateTimeKind.Unspecified).AddTicks(508), 1L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 23L, "Cum illum sit corporis maiores laudantium ut.\nArchitecto aut expedita nihil et voluptatibus fugiat.\nQuisquam harum consequatur quasi ea voluptas hic dolorum.\nHarum laborum harum suscipit magnam aut.\nDolores amet tempore magni magni possimus odit quis et impedit.", new DateTime(2021, 6, 4, 11, 4, 16, 100, DateTimeKind.Unspecified).AddTicks(7149), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Dolores ea assumenda alias.", new DateTime(2021, 3, 6, 4, 28, 7, 52, DateTimeKind.Unspecified).AddTicks(1993), 1L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Sint aliquid pariatur harum enim dolorem repellat.\nMolestiae aut nemo nihil qui sapiente non harum.\nEligendi voluptas nobis tempore.\nMolestias vel dolores aut deleniti aut minima accusamus.\nOmnis voluptatem similique.\nFacere occaecati incidunt iusto laborum ut eius id dolore.", new DateTime(2021, 4, 12, 22, 5, 28, 434, DateTimeKind.Unspecified).AddTicks(9752), 4L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Quam ducimus qui.\nRerum velit nulla rem.\nUllam nisi eveniet dignissimos.", new DateTime(2021, 8, 25, 1, 50, 58, 81, DateTimeKind.Unspecified).AddTicks(488), 3L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Omnis fugit aut.", new DateTime(2021, 8, 20, 8, 30, 53, 58, DateTimeKind.Unspecified).AddTicks(3331), 3L, 59L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Qui et velit tempore et.\nQui animi dolor beatae soluta.\nEt ab explicabo eos enim consequatur omnis soluta.\nVel doloribus omnis est optio et.\nAmet et assumenda et numquam culpa.\nQuasi aspernatur tempore.", new DateTime(2021, 11, 8, 12, 17, 53, 802, DateTimeKind.Unspecified).AddTicks(2027), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Suscipit deleniti accusamus et debitis.\nDucimus ab cum.\nPariatur architecto architecto odio maiores.", new DateTime(2021, 9, 4, 18, 46, 20, 745, DateTimeKind.Unspecified).AddTicks(6003), 1L, 30L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Dolore nihil voluptas doloremque accusantium.\nAnimi aspernatur mollitia.", new DateTime(2021, 6, 17, 15, 1, 38, 939, DateTimeKind.Unspecified).AddTicks(7420), 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Eum voluptas similique quasi.\nPorro possimus repudiandae minus rerum repellat.\nNobis laboriosam qui id qui inventore illo sunt.", new DateTime(2021, 3, 27, 21, 21, 10, 234, DateTimeKind.Unspecified).AddTicks(231), 1L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Hic vitae tempora tempore et dignissimos perferendis omnis aut.", new DateTime(2021, 3, 12, 22, 52, 25, 95, DateTimeKind.Unspecified).AddTicks(9008), 2L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Excepturi mollitia vitae accusantium autem repudiandae.\nEst rem ex rerum sunt suscipit voluptatem veniam aut.\nMaiores similique assumenda tempore est inventore aut omnis.\nEt ut corporis dolorem deleniti dolorem laudantium mollitia.", new DateTime(2021, 4, 6, 19, 23, 18, 77, DateTimeKind.Unspecified).AddTicks(4489), 5L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 34L, "Adipisci enim facere voluptatem sed accusamus soluta fuga qui porro.\nEx quia dolorem qui qui sed sed rem.\nConsequatur occaecati rem corporis officiis dolor aut id.\nSuscipit pariatur necessitatibus minima harum sunt ea.\nQuod omnis nobis sapiente veniam esse qui ducimus quia voluptas.", new DateTime(2021, 9, 4, 11, 28, 1, 107, DateTimeKind.Unspecified).AddTicks(3093), 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 3L, "Aut non tempore voluptas qui.\nLaboriosam omnis earum sit atque et.\nBeatae est magnam praesentium rerum quibusdam dignissimos temporibus voluptas.\nOdit rerum at facere itaque rem sapiente rerum.\nAspernatur ut corporis nihil ut occaecati atque exercitationem nihil molestiae.", new DateTime(2021, 5, 15, 6, 26, 4, 917, DateTimeKind.Unspecified).AddTicks(507), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Sequi reprehenderit ipsam.\nEt enim error quia quia error tenetur mollitia eligendi.\nNostrum voluptatibus magni natus assumenda quis.\nMaiores ut itaque ea et voluptatem et maxime praesentium.", new DateTime(2021, 5, 20, 9, 52, 1, 466, DateTimeKind.Unspecified).AddTicks(4088), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 39L, "Est ab nemo.\nAut aspernatur dolores suscipit similique necessitatibus id voluptatem quidem.\nDolores consequatur tenetur.\nAd dolorem ipsa autem et.\nNostrum cumque praesentium.", new DateTime(2021, 9, 22, 15, 38, 2, 296, DateTimeKind.Unspecified).AddTicks(2770), 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Non sit beatae aliquam reiciendis enim tempore.\nPerferendis quis excepturi eveniet repellat tempora.\nVoluptas aut numquam eveniet et et eaque enim.\nAdipisci et ad quidem placeat earum dolor.\nDolorum voluptate molestiae nihil illo fugit aut.\nAnimi soluta accusantium.", new DateTime(2021, 10, 18, 16, 4, 44, 926, DateTimeKind.Unspecified).AddTicks(6113), 2L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Nihil qui in laudantium iste repellat ipsum veritatis praesentium.\nDeleniti eaque eaque.\nQuasi deserunt maiores ad deserunt et alias enim.", new DateTime(2021, 4, 5, 3, 11, 52, 774, DateTimeKind.Unspecified).AddTicks(511), 5L, 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Ut cumque aut.\nAut aut voluptas ex.\nVeritatis et velit aliquam.\nDeserunt illo quos maiores natus earum a velit.\nEarum cumque libero facere voluptatem saepe suscipit qui est veritatis.\nAutem omnis dicta ad.", new DateTime(2021, 5, 17, 13, 53, 22, 284, DateTimeKind.Unspecified).AddTicks(1090), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Non sit perspiciatis ex cum quidem placeat saepe ut asperiores.\nAt voluptas aperiam.\nEos magni dolor praesentium accusamus deleniti laboriosam.", new DateTime(2021, 4, 3, 10, 20, 46, 341, DateTimeKind.Unspecified).AddTicks(3427), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Facere ea provident et.\nAut minus occaecati.\nQui rem quaerat.\nEst blanditiis et aspernatur earum asperiores illo.\nSunt doloremque incidunt magnam sint dignissimos accusamus fugiat dignissimos.\nVoluptas tempore provident eos et praesentium vel.", new DateTime(2021, 2, 6, 15, 19, 18, 560, DateTimeKind.Unspecified).AddTicks(1065), 2L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nihil sed quis temporibus aut minima repellat voluptates.", new DateTime(2021, 6, 5, 6, 45, 25, 705, DateTimeKind.Unspecified).AddTicks(2833), 3L, 74L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Doloribus excepturi similique eos est.\nSaepe et qui ab unde deserunt est quis.\nLabore facere dolor.", new DateTime(2022, 1, 15, 18, 52, 37, 713, DateTimeKind.Unspecified).AddTicks(9441), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Doloribus omnis dignissimos mollitia alias omnis vitae deleniti.\nNesciunt qui voluptatem amet odio ullam.", new DateTime(2021, 6, 20, 20, 32, 47, 556, DateTimeKind.Unspecified).AddTicks(3441), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 47L, "Nostrum tempore quo quibusdam.\nNesciunt tempore qui beatae omnis earum veniam.", new DateTime(2021, 11, 8, 19, 30, 2, 744, DateTimeKind.Unspecified).AddTicks(6567), 1L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Dolorem ut quasi aut qui laudantium quibusdam ab.\nDeleniti quod blanditiis ducimus molestiae.", new DateTime(2021, 3, 17, 21, 1, 51, 218, DateTimeKind.Unspecified).AddTicks(9854), 4L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "In id voluptate saepe velit eum aut aperiam enim.\nDolorem aut perspiciatis qui quibusdam voluptatem dolorem.\nModi magnam alias omnis.\nConsectetur nulla fuga voluptas sint nostrum et quia aliquam.\nEt incidunt eius natus dolor eligendi et.", new DateTime(2021, 5, 6, 23, 34, 5, 229, DateTimeKind.Unspecified).AddTicks(3940), 4L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 21L, "Voluptates repellat harum qui dolore molestias expedita deleniti.\nNulla possimus numquam ab temporibus illo commodi maxime assumenda.", new DateTime(2022, 1, 16, 8, 12, 55, 887, DateTimeKind.Unspecified).AddTicks(2289), 4L, 74L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Cumque doloribus dolores sequi libero labore est.\nDebitis quia quo.", new DateTime(2021, 11, 1, 6, 39, 5, 620, DateTimeKind.Unspecified).AddTicks(9235), 3L, 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Voluptatem cumque eum praesentium ut magni et.\nEius perferendis aut.\nEa eaque et omnis illo.\nQuaerat perferendis quas.", new DateTime(2021, 6, 7, 9, 32, 29, 109, DateTimeKind.Unspecified).AddTicks(2186), 1L, 46L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Architecto est deleniti sit sint minus enim culpa nisi.\nFugit ex eos officia eos ducimus tempora voluptas possimus.\nDolorem nulla omnis eum sed repellat.", new DateTime(2021, 12, 11, 20, 49, 24, 536, DateTimeKind.Unspecified).AddTicks(9357), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Aut quis eum nostrum quod eum quos et sunt.\nOccaecati earum itaque libero in nihil.", new DateTime(2021, 10, 12, 9, 43, 10, 483, DateTimeKind.Unspecified).AddTicks(3703), 2L, 31L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Tempore incidunt ipsum est est occaecati vitae eius consequatur.\nCupiditate enim ut sunt.\nPariatur nihil qui enim eos eum impedit quia laborum.\nAccusamus animi tempora minus nulla consequatur alias ut ratione laborum.\nSed sunt sit aut sed officiis sunt.\nEsse fuga voluptatem dolorem nam.", new DateTime(2022, 1, 19, 13, 53, 51, 173, DateTimeKind.Unspecified).AddTicks(3509), 5L, 54L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Delectus et natus possimus omnis et.\nAtque cupiditate reprehenderit cupiditate voluptate sed sapiente nesciunt qui.\nNon ullam id excepturi dolorum consequatur velit.\nUnde est error eius amet.\nDelectus qui libero est optio natus suscipit voluptate ab.", new DateTime(2021, 2, 28, 19, 5, 13, 864, DateTimeKind.Unspecified).AddTicks(172), 3L, 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Sed eos quas dolor.\nQui id nesciunt.\nNisi eveniet ea quos tempora ratione nostrum ut suscipit occaecati.\nUt provident ipsam laudantium ipsum minima et.\nEt quia illo beatae.\nQuae et voluptates veritatis iusto.", new DateTime(2021, 2, 7, 11, 22, 22, 847, DateTimeKind.Unspecified).AddTicks(7478), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 16L, "Quibusdam sed voluptas dolor ut.\nQuia incidunt ea suscipit hic qui.\nEaque laborum omnis molestiae corrupti ut voluptas.\nIllum illo dignissimos quibusdam ut.\nEum consectetur vel voluptas.", new DateTime(2021, 6, 3, 20, 57, 51, 343, DateTimeKind.Unspecified).AddTicks(7626), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Fuga ut non alias qui tempore.\nAspernatur pariatur commodi voluptatem qui eum numquam quod placeat et.\nReiciendis ratione qui.\nLibero neque nostrum eaque accusantium consequatur.\nPossimus sed quis facilis quia corporis qui nihil.\nRem qui vitae ut hic officiis quia consequatur consequatur.", new DateTime(2021, 2, 15, 1, 3, 50, 196, DateTimeKind.Unspecified).AddTicks(6476), 3L, 48L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 50L, "Qui ipsa et soluta consequatur impedit dolor est.", new DateTime(2021, 4, 6, 0, 15, 0, 666, DateTimeKind.Unspecified).AddTicks(3684), 1L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Inventore repudiandae animi quae.\nSed quo et.\nEt autem a.\nIncidunt eos nihil dolores temporibus.", new DateTime(2021, 10, 21, 20, 52, 38, 231, DateTimeKind.Unspecified).AddTicks(8015), 5L, 56L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Laboriosam consequuntur est dolores sed repudiandae.", new DateTime(2021, 4, 4, 18, 42, 21, 652, DateTimeKind.Unspecified).AddTicks(9924), 3L, 5L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Maiores corrupti itaque laudantium pariatur.\nDoloribus vel rerum velit nihil omnis temporibus ut exercitationem.\nExercitationem sapiente aliquid est vero.\nImpedit eveniet pariatur laboriosam.\nDolores in placeat in blanditiis voluptatum est iusto est at.", new DateTime(2021, 10, 18, 11, 35, 38, 665, DateTimeKind.Unspecified).AddTicks(3588), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Molestiae nihil eos impedit in dolorum omnis.\nMollitia deleniti reiciendis qui pariatur dolor eaque et molestias.", new DateTime(2021, 12, 14, 12, 15, 47, 755, DateTimeKind.Unspecified).AddTicks(9340), 2L, 70L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 30L, "Architecto dolor odit est ducimus tempora consequuntur minima atque laborum.", new DateTime(2021, 5, 19, 8, 26, 26, 321, DateTimeKind.Unspecified).AddTicks(5379), 1L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Sint voluptatem repellat aut aut.\nNumquam officia accusamus vel ducimus voluptas voluptatem.\nAut dignissimos sint minus et non.\nAut odit cupiditate totam velit dolores.", new DateTime(2021, 3, 30, 21, 30, 24, 45, DateTimeKind.Unspecified).AddTicks(3023), 1L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 24L, "Iusto laboriosam numquam eos quia asperiores sunt delectus sint omnis.\nOmnis et sit quae animi sed et praesentium.\nOdit eveniet perspiciatis sint voluptatum suscipit est consequatur.\nUllam accusamus ut ut qui dolorem.\nQuibusdam corporis impedit.\nQuos natus tenetur adipisci rem maxime libero sit.", new DateTime(2021, 12, 14, 6, 12, 27, 982, DateTimeKind.Unspecified).AddTicks(9982), 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Assumenda sed quibusdam exercitationem distinctio.\nEius similique sed numquam voluptates nam labore ut consectetur.\nAut vel sequi quisquam voluptatem perspiciatis rerum ut dignissimos minus.", new DateTime(2021, 11, 4, 1, 54, 34, 308, DateTimeKind.Unspecified).AddTicks(5223), 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 27L, "Officia ad soluta nostrum ullam et facilis quo.", new DateTime(2021, 5, 8, 5, 13, 27, 480, DateTimeKind.Unspecified).AddTicks(7761), 76L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Molestias voluptatem asperiores et autem ex voluptatibus distinctio sed.\nDeserunt ducimus pariatur non.", new DateTime(2021, 10, 18, 17, 12, 20, 582, DateTimeKind.Unspecified).AddTicks(5471), 1L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Beatae sapiente nam ut.", new DateTime(2021, 10, 8, 19, 16, 13, 405, DateTimeKind.Unspecified).AddTicks(388), 1L, 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Occaecati quia veritatis quidem.\nUt mollitia inventore accusamus.", new DateTime(2021, 12, 6, 11, 53, 10, 114, DateTimeKind.Unspecified).AddTicks(9770), 5L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "At est quo quidem necessitatibus sint minus et.\nQui perspiciatis et.\nPariatur quasi amet.", new DateTime(2021, 5, 20, 6, 19, 16, 242, DateTimeKind.Unspecified).AddTicks(5421), 5L, 38L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Numquam nihil at eaque hic quam.\nNihil voluptatem aut non sed.\nDistinctio blanditiis nobis ipsam nemo repellendus omnis tenetur voluptates.", new DateTime(2021, 11, 18, 4, 42, 11, 780, DateTimeKind.Unspecified).AddTicks(5086), 3L, 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Sunt totam voluptatem placeat nemo laudantium iusto.\nDolor pariatur delectus.\nNisi nobis in id dignissimos.\nIllo voluptate minus reiciendis qui officia sint quo et corporis.\nNesciunt sed maxime.", new DateTime(2021, 5, 27, 18, 14, 41, 112, DateTimeKind.Unspecified).AddTicks(7730), 2L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Eveniet sit modi ducimus ut laudantium.\nVoluptatum quia enim sit earum.\nEst sequi reprehenderit at aut.\nCum eum totam aperiam magni.", new DateTime(2021, 11, 12, 12, 42, 18, 605, DateTimeKind.Unspecified).AddTicks(6442), 2L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 41L, "Ut saepe adipisci voluptatibus asperiores est amet.\nArchitecto soluta dolore dignissimos et.\nAut vitae et non.\nTempora officiis modi commodi et harum molestiae.\nExplicabo totam veniam voluptatem sed.", new DateTime(2021, 8, 25, 23, 33, 24, 472, DateTimeKind.Unspecified).AddTicks(9464), 5L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Et molestiae quia similique aperiam.\nEt eum voluptas accusamus sequi eveniet quo iure.\nTotam maxime quia non sit aliquid similique nihil.\nIllum autem non.\nNam eaque et sed.", new DateTime(2021, 12, 5, 7, 3, 19, 128, DateTimeKind.Unspecified).AddTicks(1076), 2L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 23L, "Consectetur porro et dolore officia.", new DateTime(2021, 7, 9, 3, 3, 8, 311, DateTimeKind.Unspecified).AddTicks(9992), 3L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Ipsam nulla quibusdam voluptates esse sint.\nAlias fugit facere.\nFugit ullam quisquam et.\nDolorum natus architecto architecto rem ducimus dignissimos recusandae.\nEveniet odit voluptatibus repellat sequi magnam modi voluptas facilis.", new DateTime(2021, 6, 18, 3, 0, 57, 227, DateTimeKind.Unspecified).AddTicks(8982), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "Ut nesciunt et unde rerum id magni cupiditate.\nEt voluptatem consequatur quos eligendi aut accusamus in et.\nSint vel et.\nSapiente quas sit.\nExpedita autem est sit asperiores.\nEa aut ipsam ut saepe doloribus quia voluptas.", new DateTime(2021, 4, 2, 18, 10, 26, 609, DateTimeKind.Unspecified).AddTicks(2247), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2022, 1, 29, 3, 24, 29, 342, DateTimeKind.Unspecified).AddTicks(9512), 3L, 964, false, null, 46L, 147 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 12, 19, 18, 0, 16, 391, DateTimeKind.Unspecified).AddTicks(7739), 2L, 609, true, 20L, 185 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 21L, new DateTime(2021, 11, 2, 7, 13, 47, 675, DateTimeKind.Unspecified).AddTicks(9358), 888, 3L, null, 236 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 4, 8, 11, 56, 15, 698, DateTimeKind.Unspecified).AddTicks(5209), 1L, 741, null, 10L, 27 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 11, 5, 4, 0, 14, 710, DateTimeKind.Unspecified).AddTicks(3138), 883, 40L, 45 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 2, 14, 21, 17, 59, 540, DateTimeKind.Unspecified).AddTicks(5089), 2L, 735, 23L, 39 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 4, 23, 17, 26, 49, 642, DateTimeKind.Unspecified).AddTicks(2473), 2L, 655, 4L, 190 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 4, 30, 22, 28, 56, 322, DateTimeKind.Unspecified).AddTicks(2901), 5L, 983, false, 29L, 379 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 31L, new DateTime(2021, 9, 6, 8, 53, 13, 670, DateTimeKind.Unspecified).AddTicks(8972), 2L, 506, 20L, null, 348 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 4, 19, 12, 13, 32, 961, DateTimeKind.Unspecified).AddTicks(7747), 3L, 742, true, null, 6L, 114 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 5, 5, 8, 7, 14, 625, DateTimeKind.Unspecified).AddTicks(283), 5L, 847, false, 17L, 427 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 7, 24, 18, 22, 56, 179, DateTimeKind.Unspecified).AddTicks(8526), 928, false, null, 17L, 88 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2022, 1, 16, 23, 58, 23, 760, DateTimeKind.Unspecified).AddTicks(6105), 2L, 605, 79L, 346 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 10, 28, 13, 18, 30, 158, DateTimeKind.Unspecified).AddTicks(3406), 3L, 845, 50L, 42 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 2, 10, 20, 35, 43, 224, DateTimeKind.Unspecified).AddTicks(4721), 1L, 951, 49L, 110 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2022, 1, 14, 3, 28, 42, 111, DateTimeKind.Unspecified).AddTicks(8479), 707, true, 37L, 72 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 8, 7, 20, 31, 0, 276, DateTimeKind.Unspecified).AddTicks(2581), 1L, 997, 42L, 305 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2022, 1, 10, 20, 37, 29, 163, DateTimeKind.Unspecified).AddTicks(8291), 1L, 844, false, 47L, 247 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 5, 31, 6, 59, 37, 282, DateTimeKind.Unspecified).AddTicks(2378), 2L, 772, 59L, 152 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 43L, new DateTime(2021, 4, 4, 23, 15, 54, 624, DateTimeKind.Unspecified).AddTicks(9288), 4L, 868, 4L, null, 283 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 10, 26, 17, 42, 48, 851, DateTimeKind.Unspecified).AddTicks(4083), 4L, 925, null, 38L, 359 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 22L, new DateTime(2021, 8, 28, 17, 23, 40, 251, DateTimeKind.Unspecified).AddTicks(2407), 679, 6L, 27 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 6, 21, 0, 14, 43, 500, DateTimeKind.Unspecified).AddTicks(6196), 1L, 750, 76L, 287 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2022, 1, 25, 1, 21, 37, 107, DateTimeKind.Unspecified).AddTicks(8597), 962, false, 55L, null, 389 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 9, 22, 1, 11, 23, 140, DateTimeKind.Unspecified).AddTicks(7612), 5L, 846, 4L, 307 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 4, 15, 10, 11, 37, 983, DateTimeKind.Unspecified).AddTicks(8661), 5L, 612, true, 12L, null, 343 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 5, 15, 5, 41, 25, 342, DateTimeKind.Unspecified).AddTicks(5673), 516, null, 6L, 492 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 8, 8, 3, 41, 39, 580, DateTimeKind.Unspecified).AddTicks(8961), 634, 4L, 254 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 9, 8, 10, 50, 36, 514, DateTimeKind.Unspecified).AddTicks(6551), 5L, 520, 18L, null, 92 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 9, 29, 14, 53, 12, 957, DateTimeKind.Unspecified).AddTicks(8554), 2L, 516, null, 50L, 109 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2022, 1, 17, 6, 14, 26, 894, DateTimeKind.Unspecified).AddTicks(1215), 4L, 791, null, 46L, 231 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 31L, new DateTime(2021, 7, 5, 21, 9, 42, 441, DateTimeKind.Unspecified).AddTicks(3341), 4L, 700, 17L, null, 378 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 3, 11, 8, 47, 17, 286, DateTimeKind.Unspecified).AddTicks(5094), 1L, 634, 48L, null, 434 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2022, 1, 8, 13, 50, 30, 754, DateTimeKind.Unspecified).AddTicks(8844), 1L, 522, null, 10L, 406 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2022, 1, 26, 4, 23, 33, 480, DateTimeKind.Unspecified).AddTicks(6796), 1L, 863, 13L, null, 154 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 6, 16, 13, 47, 22, 818, DateTimeKind.Unspecified).AddTicks(9494), 3L, 955, false, 33L, 71 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2022, 1, 21, 10, 5, 46, 256, DateTimeKind.Unspecified).AddTicks(614), 3L, 737, true, null, 30L, 276 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 12, 2, 18, 1, 15, 503, DateTimeKind.Unspecified).AddTicks(6641), 1L, 903, false, 36L, 191 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 7, 30, 10, 28, 58, 978, DateTimeKind.Unspecified).AddTicks(5421), 2L, 840, 69L, null, 311 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 6, 3, 4, 42, 31, 242, DateTimeKind.Unspecified).AddTicks(7245), 1L, 838, false, 16L, null, 3 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 5, 11, 22, 5, 44, 98, DateTimeKind.Unspecified).AddTicks(2176), 1L, 638, true, 15L, 251 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 7, 19, 14, 9, 17, 608, DateTimeKind.Unspecified).AddTicks(3987), 3L, 840, 79L, null, 376 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 6, 25, 8, 22, 59, 54, DateTimeKind.Unspecified).AddTicks(3458), 2L, 560, false, 5L, 33 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 3, 16, 18, 51, 28, 437, DateTimeKind.Unspecified).AddTicks(5143), 2L, 577, 59L, null, 188 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 10, 27, 19, 59, 56, 603, DateTimeKind.Unspecified).AddTicks(7266), 674, true, 46L, 392 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 4, 14, 7, 57, 24, 984, DateTimeKind.Unspecified).AddTicks(1707), 5L, 505, 39L, null, 23 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 12, 11, 3, 50, 48, 81, DateTimeKind.Unspecified).AddTicks(8440), 4L, 908, null, 46L, 332 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 4, 22, 4, 28, 34, 314, DateTimeKind.Unspecified).AddTicks(6143), 4L, 571, true, 71L, 487 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 9L, new DateTime(2021, 12, 4, 21, 5, 36, 336, DateTimeKind.Unspecified).AddTicks(908), 2L, 938, null, 41L, 102 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 6, 10, 23, 3, 17, 368, DateTimeKind.Unspecified).AddTicks(1628), 3L, 509, false, 47L, 250 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 7, 31, 13, 56, 28, 842, DateTimeKind.Unspecified).AddTicks(3408), 5L, 790, null, 33L, 398 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 5, 17, 23, 46, 20, 831, DateTimeKind.Unspecified).AddTicks(4394), 1L, 664, false, 22L, null, 258 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 11, 15, 2, 56, 51, 0, DateTimeKind.Unspecified).AddTicks(5071), 2L, 659, 42L, 490 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 8, 4, 7, 6, 24, 431, DateTimeKind.Unspecified).AddTicks(3070), 2L, 613, true, 28L, 414 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 6, 26, 17, 47, 1, 488, DateTimeKind.Unspecified).AddTicks(988), 815, true, 57L, 13 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 12, 11, 17, 55, 16, 709, DateTimeKind.Unspecified).AddTicks(701), 2L, 937, false, 41L, 460 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2022, 1, 6, 23, 35, 35, 321, DateTimeKind.Unspecified).AddTicks(4421), 786, 48L, null, 406 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 11, 13, 17, 41, 37, 802, DateTimeKind.Unspecified).AddTicks(8698), 1L, 844, 3L, 217 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 12, 26, 16, 27, 56, 118, DateTimeKind.Unspecified).AddTicks(5028), 775, false, 20L, 428 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 22L, new DateTime(2021, 12, 7, 15, 29, 43, 547, DateTimeKind.Unspecified).AddTicks(5436), 3L, 879, 56L, null, 153 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 9, 20, 10, 25, 57, 78, DateTimeKind.Unspecified).AddTicks(1406), 1L, 841, 78L, null, 247 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 9, 14, 23, 2, 17, 221, DateTimeKind.Unspecified).AddTicks(7579), 767, null, 36L, 177 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 10, 15, 9, 43, 16, 188, DateTimeKind.Unspecified).AddTicks(1875), 805, true, 58L, null, 274 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 3, 25, 22, 57, 29, 915, DateTimeKind.Unspecified).AddTicks(3701), 991, null, 15L, 453 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 7, 1, 22, 56, 48, 203, DateTimeKind.Unspecified).AddTicks(4257), 2L, 958, true, null, 26L, 236 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 4, 30, 4, 45, 59, 691, DateTimeKind.Unspecified).AddTicks(7247), 3L, 933, true, 75L, 209 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 8, 10, 2, 46, 20, 680, DateTimeKind.Unspecified).AddTicks(8116), 1L, 714, false, 17L, 51 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 5, 23, 9, 19, 44, 157, DateTimeKind.Unspecified).AddTicks(206), 608, 41L, null, 248 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 10, 15, 16, 44, 14, 124, DateTimeKind.Unspecified).AddTicks(6248), 2L, 696, 78L, 272 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 12, 18, 5, 16, 38, 850, DateTimeKind.Unspecified).AddTicks(9714), 2L, 824, true, 13L, null, 368 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2022, 1, 28, 12, 59, 12, 394, DateTimeKind.Unspecified).AddTicks(5937), 5L, 939, 81L, 305 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 5, 16, 22, 57, 48, 422, DateTimeKind.Unspecified).AddTicks(4514), 4L, 972, 37L, 278 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 10, 20, 22, 23, 32, 596, DateTimeKind.Unspecified).AddTicks(5866), 2L, 793, null, 42L, 429 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 3, 9, 13, 59, 5, 137, DateTimeKind.Unspecified).AddTicks(5302), 1L, 958, true, null, 20L, 12 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 8, 5, 20, 20, 45, 876, DateTimeKind.Unspecified).AddTicks(6131), 2L, 844, false, null, 28L, 469 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 10, 5, 21, 40, 13, 358, DateTimeKind.Unspecified).AddTicks(6219), 3L, 723, false, 3L, null, 66 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 11, 6, 9, 53, 29, 298, DateTimeKind.Unspecified).AddTicks(1594), 799, 18L, 366 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 3, 14, 1, 21, 57, 103, DateTimeKind.Unspecified).AddTicks(4866), 766, 34L, 102 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 11, 12, 4, 31, 2, 170, DateTimeKind.Unspecified).AddTicks(2598), 1L, 747, 31L, null, 485 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 9, 20, 18, 4, 58, 678, DateTimeKind.Unspecified).AddTicks(9172), 4L, 994, false, 57L, null, 38 });

            migrationBuilder.InsertData(
                table: "UserProjects",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted", "SubmissionId" },
                values: new object[,]
                {
                    { 14L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49L, false, null },
                    { 41L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44L, false, null },
                    { 44L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11L, false, null },
                    { 48L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19L, false, null },
                    { 17L, 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5L, false, null },
                    { 46L, 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43L, false, null },
                    { 2L, 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33L, false, null }
                });

            migrationBuilder.InsertData(
                table: "UserProjects",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted", "SubmissionId" },
                values: new object[,]
                {
                    { 27L, 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28L, false, null },
                    { 5L, 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30L, false, null },
                    { 33L, 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8L, false, null },
                    { 16L, 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37L, false, null },
                    { 30L, 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15L, false, null },
                    { 46L, 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39L, false, null },
                    { 22L, 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4L, false, null },
                    { 23L, 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16L, false, null },
                    { 25L, 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32L, false, null },
                    { 42L, 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10L, false, null },
                    { 30L, 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2L, false, null },
                    { 6L, 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23L, false, null },
                    { 34L, 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31L, false, null },
                    { 15L, 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21L, false, null },
                    { 25L, 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18L, false, null },
                    { 16L, 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3L, false, null },
                    { 42L, 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45L, false, null },
                    { 3L, 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27L, false, null },
                    { 25L, 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6L, false, null },
                    { 32L, 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41L, false, null },
                    { 17L, 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13L, false, null },
                    { 40L, 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38L, false, null },
                    { 41L, 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51L, false, null },
                    { 20L, 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40L, false, null },
                    { 19L, 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26L, false, null },
                    { 12L, 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7L, false, null },
                    { 49L, 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20L, false, null },
                    { 5L, 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36L, false, null },
                    { 6L, 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34L, false, null },
                    { 35L, 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48L, false, null },
                    { 42L, 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12L, false, null },
                    { 24L, 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29L, false, null },
                    { 16L, 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50L, false, null },
                    { 28L, 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42L, false, null },
                    { 39L, 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22L, false, null },
                    { 30L, 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46L, false, null },
                    { 32L, 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25L, false, null },
                    { 24L, 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17L, false, null },
                    { 27L, 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47L, false, null },
                    { 20L, 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24L, false, null },
                    { 32L, 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35L, false, null },
                    { 27L, 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14L, false, null }
                });

            migrationBuilder.InsertData(
                table: "UserProjects",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted", "SubmissionId" },
                values: new object[] { 38L, 51L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9L, false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ProjectId",
                table: "Lessons",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_ProjectId",
                table: "UserProjects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_SubmissionId",
                table: "UserProjects",
                column: "SubmissionId",
                unique: true,
                filter: "[SubmissionId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Projects_ProjectId",
                table: "Lessons",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Projects_ProjectId",
                table: "Lessons");

            migrationBuilder.DropTable(
                name: "UserProjects");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_ProjectId",
                table: "Lessons");

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 2L, 11L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 2L, 23L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 2L, 29L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 5L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 22L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 5L, 5L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 5L, 19L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 6L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 26L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 11L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 18L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 9L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 12L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 9L, 12L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 9L, 32L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 9L, 33L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 10L, 11L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 10L, 25L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 1L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 6L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 12L, 9L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 12L, 20L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 12L, 29L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 13L, 30L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 13L, 31L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 13L, 37L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 5L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 9L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 28L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 37L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 15L, 21L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 3L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 15L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 28L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 32L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 17L, 10L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 17L, 32L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 17L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 19L, 4L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 19L, 20L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 19L, 34L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 20L, 3L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 20L, 5L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 20L, 35L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 21L, 26L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 2L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 12L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 18L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 19L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 34L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 23L, 7L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 23L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 7L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 14L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 21L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 25L, 21L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 25L, 27L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 25L, 35L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 26L, 16L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 26L, 35L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 27L, 4L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 27L, 20L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 27L, 29L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 28L, 1L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 28L, 7L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 29L, 3L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 29L, 25L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 29L, 27L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 29L, 28L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 30L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 25L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 28L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 4L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 5L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 44L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 49L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 11L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 8L, 43L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 9L, 33L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 12L, 17L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 13L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 14L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 24L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 9L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 16L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 17L, 4L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 18L, 41L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 19L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 20L, 9L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 21L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 2L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 24L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 25L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 25L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 26L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 27L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 13L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 28L, 21L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 29L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 29L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 29L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 29L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 36L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 30L, 39L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 32L, 12L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 32L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 26L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 33L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 34L, 46L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 35L, 29L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 36L, 22L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 36L, 27L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 5L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 16L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 31L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 37L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 26L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 39L, 49L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 40L, 23L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 6L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 42L, 34L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 10L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 43L, 25L });

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
                keyValues: new object[] { 44L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 8L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 36L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 42L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 37L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 14L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 49L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 11L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 35L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 51L, 42L });

            migrationBuilder.DropColumn(
                name: "IsSubmitted",
                table: "Submissions");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Lessons");

            migrationBuilder.AddColumn<long>(
                name: "OwnerId",
                table: "Projects",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 4L, 26L },
                column: "Id",
                value: 75L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 37L },
                column: "Id",
                value: 72L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 5L },
                column: "Id",
                value: 38L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 26L },
                column: "Id",
                value: 18L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 34L },
                column: "Id",
                value: 6L);

            migrationBuilder.InsertData(
                table: "AppTags",
                columns: new[] { "AppId", "TagId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 31L, false },
                    { 2L, 20L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 74L, false },
                    { 2L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 57L, false },
                    { 3L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 55L, false },
                    { 3L, 13L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 68L, false },
                    { 3L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 66L, false },
                    { 3L, 33L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 49L, false },
                    { 3L, 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 80L, false },
                    { 3L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 24L, false },
                    { 4L, 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 10L, false },
                    { 4L, 16L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 65L, false },
                    { 4L, 33L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 29L, false },
                    { 6L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 16L, false },
                    { 6L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 81L, false },
                    { 6L, 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 37L, false },
                    { 6L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 56L, false },
                    { 7L, 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 42L, false },
                    { 7L, 7L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 4L, false },
                    { 7L, 13L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 47L, false },
                    { 7L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 45L, false },
                    { 7L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 63L, false },
                    { 7L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 35L, false },
                    { 7L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 77L, false },
                    { 8L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 7L, false },
                    { 8L, 27L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 5L, false },
                    { 9L, 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 2L, false },
                    { 9L, 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 54L, false },
                    { 10L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 20L, false },
                    { 10L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 43L, false },
                    { 10L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 58L, false },
                    { 11L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 64L, false },
                    { 11L, 31L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 28L, false },
                    { 12L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 9L, false },
                    { 12L, 21L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L, false },
                    { 12L, 24L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 73L, false },
                    { 12L, 27L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 13L, false },
                    { 13L, 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 67L, false }
                });

            migrationBuilder.InsertData(
                table: "AppTags",
                columns: new[] { "AppId", "TagId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 13L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 69L, false },
                    { 15L, 10L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 15L, false },
                    { 15L, 14L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 12L, false },
                    { 15L, 24L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 8L, false },
                    { 15L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 34L, false },
                    { 16L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 44L, false },
                    { 16L, 12L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 71L, false },
                    { 16L, 20L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 17L, false },
                    { 16L, 29L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 48L, false },
                    { 17L, 14L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 23L, false },
                    { 17L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 62L, false },
                    { 18L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 33L, false },
                    { 18L, 31L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 70L, false },
                    { 19L, 2L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 46L, false },
                    { 19L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 53L, false },
                    { 19L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 78L, false },
                    { 21L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 30L, false },
                    { 22L, 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 39L, false },
                    { 22L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 3L, false },
                    { 22L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 60L, false },
                    { 23L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 36L, false },
                    { 23L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 32L, false },
                    { 24L, 9L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 61L, false },
                    { 24L, 10L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 27L, false },
                    { 24L, 12L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 50L, false },
                    { 26L, 9L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 52L, false },
                    { 26L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 21L, false },
                    { 27L, 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 79L, false },
                    { 27L, 12L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 22L, false },
                    { 27L, 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 59L, false },
                    { 28L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 40L, false },
                    { 29L, 13L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 51L, false },
                    { 29L, 20L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 11L, false },
                    { 29L, 32L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 19L, false },
                    { 30L, 16L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 26L, false },
                    { 30L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 76L, false },
                    { 31L, 12L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 25L, false }
                });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("77f04c2e-c112-f632-b0e8-aec7a28d7866"), new DateTime(2021, 12, 11, 16, 15, 40, 198, DateTimeKind.Unspecified).AddTicks(7363), 5L, "Saepe nihil iure iure numquam nihil.\nEaque hic quam enim nihil voluptatem aut non sed.\nDistinctio blanditiis nobis ipsam nemo repellendus omnis tenetur voluptates.\nEligendi et quia et qui sunt totam voluptatem.", "Minus et aut qui perspiciatis et explicabo pariatur quasi amet.", 42L, "Uzbekistan SumpaymentPersonal Loan Account", 38L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("5cdc7e05-2269-3418-9c46-4779b03bcd9d"), new DateTime(2021, 5, 13, 18, 27, 59, 288, DateTimeKind.Unspecified).AddTicks(4078), "Ut laudantium laboriosam voluptatum quia enim.\nEarum magnam est sequi reprehenderit.", "Dolorum est suscipit nobis ut praesentium eveniet sit.", 21L, "InternalGroveBeauty", 51L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c6e98ccf-944a-506a-7c0c-c30b8c011442"), new DateTime(2021, 11, 5, 16, 17, 32, 176, DateTimeKind.Unspecified).AddTicks(6846), 1L, "Officiis modi commodi et.\nMolestiae ullam explicabo totam veniam voluptatem sed dolor.\nEt odio maxime enim et molestiae quia.\nAperiam facilis et eum voluptas accusamus sequi.", "Et neque aut vitae et non.", 14L, "analyzingNakfa", 35L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("7cc93ac6-320c-ae66-5a55-bed3220d008e"), new DateTime(2021, 9, 27, 21, 16, 24, 348, DateTimeKind.Unspecified).AddTicks(1063), 4L, "Nulla quibusdam voluptates esse sint.\nAlias fugit facere.\nFugit ullam quisquam et.", "Et dolore officia molestiae itaque similique similique voluptas.", 24L, "turn-keycapacityElectronics", 40L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("cad131cb-c98b-059a-f530-b32b5ecf7e16"), new DateTime(2021, 4, 13, 15, 4, 15, 213, DateTimeKind.Unspecified).AddTicks(6882), 2L, "Repellendus et voluptatem consequatur quos eligendi aut.", "Nesciunt et unde rerum id.", 101L, "PlazaInternational", 33L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("9f77ab6e-b6a8-47f3-7b2d-3ec949977b90"), new DateTime(2021, 4, 9, 14, 49, 47, 476, DateTimeKind.Unspecified).AddTicks(8133), 2L, "Non voluptate ut velit voluptatem earum quae.\nAliquam voluptatum voluptatem dolor dolorum quia consequatur dolores rerum optio.\nMolestias officiis necessitatibus placeat ut.\nVel consequuntur quaerat nostrum ad voluptatem saepe vel id.\nIncidunt blanditiis est dolorem mollitia nulla.", "Culpa adipisci adipisci quo et qui architecto harum deleniti.", 68L, "VermontManager", 18L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c049b115-7872-31ac-0235-542d533817a9"), new DateTime(2021, 11, 30, 13, 34, 1, 798, DateTimeKind.Unspecified).AddTicks(9928), "Laborum iure optio dicta.\nMaxime provident eveniet.\nSunt repellendus veniam eum dolor inventore molestiae aut fugiat.\nEt natus et id.\nRepudiandae voluptate quam dolorum saepe cumque velit et totam aspernatur.\nIn itaque saepe quis.", "Ad provident qui distinctio vel itaque praesentium et.", 98L, "Personal Loan AccountForkimplementRAM", 34L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("a27d502a-9e22-4868-8ea4-a02190f60164"), new DateTime(2021, 11, 6, 4, 49, 57, 563, DateTimeKind.Unspecified).AddTicks(6995), "Cumque totam sit molestias id sunt labore ut quam et.", "Corrupti beatae praesentium nam qui odio et ipsum.", 18L, "ubiquitousToolsForwardhard drive", 50L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("179ca5de-a60d-4149-c2da-a44e368bf846"), new DateTime(2021, 7, 2, 4, 18, 57, 767, DateTimeKind.Unspecified).AddTicks(2685), 1L, "Ex voluptas voluptatum eveniet voluptas.\nReiciendis ipsa id qui explicabo beatae est nulla.\nMinima rerum dolor eveniet enim reprehenderit.\nQuisquam sit aperiam et non reprehenderit.\nHarum nam ipsa aperiam error.\nIn atque atque repudiandae rerum et quisquam.", "Iure et cum unde enim sit.", 88L, "Buckinghamshirezero administrationprogramming", 37L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b84671c0-1654-2d1d-d18a-a08ea72d9821"), new DateTime(2021, 7, 21, 10, 37, 44, 742, DateTimeKind.Unspecified).AddTicks(6590), 4L, "Rerum ex laboriosam fuga sed laudantium voluptates reiciendis.\nSit nihil voluptas pariatur modi vel.\nVoluptatem accusamus quia et ut rerum similique.", "Voluptatum sunt tempora est maiores repellat eveniet aut provident est.", 81L, "ErgonomicSmall Steel GlovesTools, Computers & Computerssynthesize", 45L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c08938ee-0914-8e7b-ad06-3a40bfb4e8d0"), new DateTime(2021, 10, 20, 13, 27, 22, 914, DateTimeKind.Unspecified).AddTicks(8959), 4L, "Doloribus numquam ad voluptatem magni minima expedita aliquam fugit.\nPerspiciatis est sequi corrupti consequatur eum.\nSunt voluptate minima.\nQuia aut molestiae ut iste nihil eos perferendis.\nInventore voluptatibus accusamus.", "Nostrum impedit nam et non ea eligendi.", 6L, "RSSPNG", 28L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("46f59a4c-e0f0-61bb-a08f-1c1a4790cc6b"), new DateTime(2021, 12, 5, 20, 1, 37, 845, DateTimeKind.Unspecified).AddTicks(6639), "Sapiente accusamus praesentium aut voluptatem facilis sunt eum.\nQuia beatae esse velit alias ut deserunt ad.\nCommodi dolorum ut id libero consectetur doloribus in.", "Asperiores quis error at.", 46L, "Licensed Wooden Pizzafront-endsynthesizing", 34L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("75a0f507-f23e-90a7-ed25-4646fb781bb6"), new DateTime(2021, 7, 24, 7, 12, 3, 836, DateTimeKind.Unspecified).AddTicks(9094), 4L, "Eaque placeat soluta odit temporibus cupiditate et.\nEt est voluptatibus ullam accusantium sint eum.\nIllo aspernatur hic voluptatibus temporibus omnis qui repellendus.\nReiciendis et possimus eum veritatis aliquam molestias at.", "Minus modi velit ut sit facere et porro deleniti.", 2L, "open-sourcepartnershipsXML", 39L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("fc47587e-10a0-e46c-a87c-5bf64d484c10"), new DateTime(2021, 11, 30, 10, 43, 46, 979, DateTimeKind.Unspecified).AddTicks(5195), 2L, "Quis et architecto eum atque error fuga eaque maxime.\nBlanditiis similique quis voluptatem quidem reiciendis dolore voluptatem maxime.\nDicta et tempore sequi at quia.", "Quod dolor odio reprehenderit voluptatum dignissimos earum nobis.", 71L, "connectHumanStation", 2L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("4be364cd-23ea-4190-0143-fd8857c07932"), new DateTime(2022, 1, 11, 20, 57, 26, 280, DateTimeKind.Unspecified).AddTicks(3700), "Voluptas voluptatem in autem autem magni rerum harum cupiditate.", "Rerum sint non commodi.", 86L, "SoftBedfordshirePersonal Loan AccountQuality", 30L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("9ca2a5b2-fadb-55af-f0bc-9b62fc41df56"), new DateTime(2021, 2, 25, 22, 37, 2, 396, DateTimeKind.Unspecified).AddTicks(4191), "Sed quod ducimus in ad doloremque pariatur.\nOfficia possimus maiores.", "Voluptatum vel soluta quia sed aut.", 32L, "East Caribbean DollarCentralPractical", 33L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b8798048-2bb2-5776-55d9-11d30d83ebf1"), new DateTime(2021, 7, 7, 14, 14, 6, 876, DateTimeKind.Unspecified).AddTicks(7554), "Maiores quo praesentium non ipsa enim blanditiis.\nEt unde velit.\nDolorem amet eos non rem.", "Accusamus quia qui aut qui laudantium ea et fugit.", 41L, "SteelCornersMetalgenerate", 42L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("8a73ddb7-1ce8-64cd-44b7-2d5cad620f05"), new DateTime(2021, 2, 7, 22, 31, 37, 167, DateTimeKind.Unspecified).AddTicks(6861), "Architecto minima temporibus quaerat id cum necessitatibus.\nIusto consequatur officia ex beatae temporibus facilis.", "Sint deserunt sed non qui nam dignissimos placeat molestias ut.", 94L, "Licensed Concrete FishSQLWay", 20L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("248ae82d-b546-e978-c077-a704bcbea16e"), new DateTime(2021, 11, 26, 0, 12, 29, 662, DateTimeKind.Unspecified).AddTicks(2387), 2L, "Et nesciunt esse perferendis aut neque impedit voluptatem.\nIure aperiam incidunt autem inventore distinctio doloribus.\nAut quia in natus ullam.\nEius sit deserunt error architecto veritatis tempora.", "Unde alias dolor at autem sit.", 69L, "supply-chainsmiddlewareMichigan", 26L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c0079e8b-d227-16f5-e5ab-d8c5acbaf661"), new DateTime(2021, 12, 27, 9, 47, 39, 765, DateTimeKind.Unspecified).AddTicks(722), "Saepe velit occaecati vero libero.\nIpsa omnis fugiat possimus nobis explicabo ut laboriosam nobis asperiores.\nArchitecto minus debitis nobis molestias itaque quos temporibus assumenda sit.\nMolestiae iste assumenda beatae molestias laudantium laboriosam laboriosam tempore.\nQui ducimus qui asperiores sequi qui sed ab vitae.\nExcepturi quo et occaecati.", "Eum esse mollitia quidem.", 101L, "AgentCustomizableHome Loan Account", 19L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("7ead84a0-d0ae-e666-aa45-34be0347fa3a"), new DateTime(2021, 10, 2, 18, 22, 6, 898, DateTimeKind.Unspecified).AddTicks(4864), 2L, "A beatae facilis placeat et id at consequatur aut.\nRecusandae totam consequatur magnam.\nOccaecati in voluptatem et.", "Tenetur quod est recusandae et sunt inventore magnam dolor.", 28L, "object-orientedNew Israeli Sheqel", 35L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("11ff1838-1312-1343-c8f1-4df5339ca690"), new DateTime(2022, 1, 13, 0, 53, 58, 471, DateTimeKind.Unspecified).AddTicks(8746), 4L, "Quam impedit sapiente aut fugiat nam esse.\nNemo omnis non saepe voluptas quae non.\nRem mollitia unde.\nIllo illo non sunt ut delectus omnis facere accusamus.", "Beatae similique distinctio maiores natus architecto molestiae recusandae.", 20L, "FTPBordersClothing", 38L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b7b48e2e-2975-cef4-5a6d-b2f85b9dee79"), new DateTime(2021, 6, 17, 12, 26, 32, 980, DateTimeKind.Unspecified).AddTicks(7588), 1L, "Modi voluptatum aut et minus sed corporis atque.\nOdit id deserunt sed dicta et.\nRepellendus labore itaque cumque autem deleniti ut.\nAt mollitia error dignissimos quo incidunt fuga optio.", "Accusamus quo et fugit.", 58L, "HighwayextendGuinea-Bissau", 14L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("f64aaeec-eb08-1034-10c6-795ef0189132"), new DateTime(2022, 1, 28, 14, 25, 11, 576, DateTimeKind.Unspecified).AddTicks(6305), 2L, "Doloremque expedita nisi.\nEt voluptas et odio.\nCommodi minima maxime beatae est dolorum veniam debitis praesentium dolor.", "Iure eos omnis eos assumenda dolorem.", 33L, "Functionalityfirewall", 48L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("1399410e-0bed-f3b6-3343-156d8eeefde4"), new DateTime(2021, 10, 1, 21, 22, 7, 929, DateTimeKind.Unspecified).AddTicks(9081), 5L, "Aliquam magnam quis iure et.", "Occaecati enim maiores nemo doloribus deleniti sint et.", 19L, "innovateHealth, Shoes & Home", 36L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("a95cdcf4-d88d-45a0-5abf-9f64c601dbdb"), new DateTime(2021, 3, 11, 7, 9, 12, 88, DateTimeKind.Unspecified).AddTicks(923), "Accusantium accusamus est nulla nemo aut beatae iste rem.\nDolorem sequi consectetur.\nMinus eum minus perferendis.", "Repellat ut tenetur est eius possimus dolorem voluptatem eius et.", 3L, "ChiefGorgeous Steel FishmaximizedSoft", 21L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("fd4893ed-eba1-4bd9-8e19-3fcaa60334bc"), new DateTime(2021, 10, 15, 20, 15, 36, 186, DateTimeKind.Unspecified).AddTicks(8021), 2L, "Quia quia maiores aliquam.\nNumquam aliquid corrupti distinctio.", "Voluptatem odio provident.", 16L, "auxiliaryturquoiseGroupmulti-byte", 43L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("539f6ff9-a14a-cb58-311b-d197543466a0"), new DateTime(2022, 1, 30, 18, 58, 24, 273, DateTimeKind.Unspecified).AddTicks(1186), 4L, "Reprehenderit sint non perferendis suscipit.\nLaudantium fugiat nobis.\nCumque dolorem adipisci aut eligendi ea.\nVoluptatem iure reiciendis consectetur voluptatem quaerat voluptates.", "Qui velit soluta.", 92L, "BridgeCustomersuperstructure", 25L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("2c05caa7-6520-7759-3534-e08bcffbd931"), new DateTime(2021, 7, 11, 19, 51, 47, 631, DateTimeKind.Unspecified).AddTicks(7658), 4L, "Et et soluta quos id unde possimus cupiditate debitis.", "Natus dolor nostrum est aut consequuntur aliquam dolorum.", 66L, "indexBedfordshire", 45L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("be81d2b8-2eb3-2131-d150-60100fca6f60"), new DateTime(2021, 11, 9, 8, 20, 27, 133, DateTimeKind.Unspecified).AddTicks(6651), 2L, "Quod facere distinctio.", "Et est rem veniam et ut libero sunt eum in.", 87L, "WoninvoiceHandcrafted Soft Bikeusers", 43L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 3, 2, 14, 52, 5, 486, DateTimeKind.Unspecified).AddTicks(7669), 5L, 33L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CourseId", "CreatedAt" },
                values: new object[] { 7L, new DateTime(2021, 8, 1, 4, 29, 22, 482, DateTimeKind.Unspecified).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 14L, new DateTime(2021, 9, 2, 10, 11, 44, 81, DateTimeKind.Unspecified).AddTicks(8013), 17L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 21L, new DateTime(2021, 7, 12, 19, 40, 55, 116, DateTimeKind.Unspecified).AddTicks(6164), 2L, 22L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 8, 18, 9, 50, 35, 137, DateTimeKind.Unspecified).AddTicks(1647), 3L, 24L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 2, 7, 5, 22, 53, 748, DateTimeKind.Unspecified).AddTicks(2742), 5L, 30L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 4, 2, 12, 30, 50, 306, DateTimeKind.Unspecified).AddTicks(5408), 2L, 31L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 6, 22, 6, 9, 8, 797, DateTimeKind.Unspecified).AddTicks(1945), 3L, 26L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 17L, new DateTime(2021, 12, 29, 7, 40, 52, 112, DateTimeKind.Unspecified).AddTicks(5490), 2L, 32L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 8, 16, 13, 6, 6, 364, DateTimeKind.Unspecified).AddTicks(1851), 1L, 40L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 10, 27, 6, 13, 20, 326, DateTimeKind.Unspecified).AddTicks(1462), 6L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 8, 7, 23, 29, 48, 809, DateTimeKind.Unspecified).AddTicks(7024), 3L, 19L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 21L, new DateTime(2021, 3, 10, 1, 24, 52, 962, DateTimeKind.Unspecified).AddTicks(8426), 3L, 28L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 19L, new DateTime(2021, 11, 22, 16, 17, 22, 215, DateTimeKind.Unspecified).AddTicks(8052), 18L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy" },
                values: new object[] { 21L, new DateTime(2021, 11, 8, 18, 0, 16, 927, DateTimeKind.Unspecified).AddTicks(5586), 1L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 6, 7, 4, 36, 12, 773, DateTimeKind.Unspecified).AddTicks(1216), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 5, 19, 5, 10, 24, 60, DateTimeKind.Unspecified).AddTicks(2461), 4L, 31L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 3, 24, 18, 47, 16, 239, DateTimeKind.Unspecified).AddTicks(6868), 2L, 33L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 12L, new DateTime(2021, 3, 18, 6, 1, 50, 575, DateTimeKind.Unspecified).AddTicks(5520), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 15L, new DateTime(2021, 9, 17, 5, 31, 45, 103, DateTimeKind.Unspecified).AddTicks(1071), 3L, 23L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy" },
                values: new object[] { 3L, new DateTime(2021, 6, 19, 21, 43, 3, 218, DateTimeKind.Unspecified).AddTicks(7346), 1L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 3, 15, 10, 36, 37, 39, DateTimeKind.Unspecified).AddTicks(3850), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 20L, new DateTime(2021, 12, 26, 3, 59, 35, 399, DateTimeKind.Unspecified).AddTicks(8451), 22L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 15L, new DateTime(2021, 12, 24, 10, 4, 32, 706, DateTimeKind.Unspecified).AddTicks(5106), 2L, 36L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 11, 24, 11, 9, 57, 22, DateTimeKind.Unspecified).AddTicks(3823), 5L, 47L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 8, 20, 3, 34, 58, 940, DateTimeKind.Unspecified).AddTicks(7838), 18L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 14L, new DateTime(2021, 4, 21, 14, 2, 17, 597, DateTimeKind.Unspecified).AddTicks(9227), 1L, 32L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 9, 6, 13, 25, 50, 369, DateTimeKind.Unspecified).AddTicks(5519), 4L, 25L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 14L, new DateTime(2021, 2, 16, 10, 44, 44, 139, DateTimeKind.Unspecified).AddTicks(7004), 4L, 26L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 12, 31, 14, 15, 15, 957, DateTimeKind.Unspecified).AddTicks(2900), 21L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 20L, new DateTime(2021, 5, 19, 9, 44, 31, 938, DateTimeKind.Unspecified).AddTicks(6517), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 12, 12, 18, 33, 47, 851, DateTimeKind.Unspecified).AddTicks(5546), 1L, 37L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2022, 1, 20, 13, 33, 47, 790, DateTimeKind.Unspecified).AddTicks(9417), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 3, 21, 10, 45, 0, 605, DateTimeKind.Unspecified).AddTicks(2719), 38L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 14L, new DateTime(2021, 6, 4, 14, 57, 38, 734, DateTimeKind.Unspecified).AddTicks(6879), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 21L, new DateTime(2022, 1, 10, 6, 35, 41, 132, DateTimeKind.Unspecified).AddTicks(7949), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 5, 15, 6, 37, 46, 585, DateTimeKind.Unspecified).AddTicks(5444), 4L, 5L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2021, 8, 27, 19, 41, 24, 300, DateTimeKind.Unspecified).AddTicks(4452), 3L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 9, 28, 1, 52, 4, 463, DateTimeKind.Unspecified).AddTicks(5896), 4L, 24L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 20L, new DateTime(2021, 12, 2, 12, 45, 7, 339, DateTimeKind.Unspecified).AddTicks(9936), 3L, 24L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 11, 28, 19, 13, 2, 676, DateTimeKind.Unspecified).AddTicks(5621), 4L, 26L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 4, 29, 3, 53, 11, 424, DateTimeKind.Unspecified).AddTicks(3376), 4L, 31L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 16L, new DateTime(2021, 9, 14, 1, 7, 56, 693, DateTimeKind.Unspecified).AddTicks(7215), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 5, 13, 1, 7, 29, 486, DateTimeKind.Unspecified).AddTicks(5868), 3L, 26L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2022, 1, 4, 14, 9, 27, 298, DateTimeKind.Unspecified).AddTicks(4286), 34L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy" },
                values: new object[] { 7L, new DateTime(2021, 3, 19, 7, 41, 55, 577, DateTimeKind.Unspecified).AddTicks(3024), 1L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 15L, new DateTime(2021, 8, 14, 17, 31, 37, 910, DateTimeKind.Unspecified).AddTicks(59), 2L, 45L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 8, 25, 2, 8, 47, 611, DateTimeKind.Unspecified).AddTicks(1564), 3L, 28L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 10, 9, 12, 2, 55, 709, DateTimeKind.Unspecified).AddTicks(3065), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2022, 1, 1, 8, 0, 43, 579, DateTimeKind.Unspecified).AddTicks(9957), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 9, 29, 15, 56, 4, 706, DateTimeKind.Unspecified).AddTicks(8619), 4L, 32L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2021, 11, 12, 6, 17, 13, 136, DateTimeKind.Unspecified).AddTicks(9133), 3L, 45L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 17L, new DateTime(2021, 2, 10, 11, 8, 33, 631, DateTimeKind.Unspecified).AddTicks(5249), 4L, 37L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 11, 5, 16, 40, 8, 932, DateTimeKind.Unspecified).AddTicks(5529), 26L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 11, 16, 21, 8, 21, 868, DateTimeKind.Unspecified).AddTicks(5263), 3L, 46L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 17L, new DateTime(2021, 6, 18, 17, 16, 6, 830, DateTimeKind.Unspecified).AddTicks(1231), 3L, 33L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 15L, new DateTime(2022, 1, 10, 4, 4, 38, 6, DateTimeKind.Unspecified).AddTicks(5322), 4L, 37L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 3, 31, 4, 38, 21, 637, DateTimeKind.Unspecified).AddTicks(6812), 3L, 35L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 19L, new DateTime(2021, 12, 8, 17, 5, 52, 178, DateTimeKind.Unspecified).AddTicks(152), 4L, 50L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 8, 3, 8, 31, 20, 83, DateTimeKind.Unspecified).AddTicks(2921), 4L, 34L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 3, 8, 7, 14, 46, 769, DateTimeKind.Unspecified).AddTicks(774), 5L, 39L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CourseId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 2, 11, 10, 19, 46, 101, DateTimeKind.Unspecified).AddTicks(5568), 5L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 11L, new DateTime(2021, 12, 26, 12, 30, 32, 369, DateTimeKind.Unspecified).AddTicks(9654), 4L, 32L });

            migrationBuilder.UpdateData(
                table: "CourseUsers",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 21L, new DateTime(2022, 1, 24, 14, 17, 46, 65, DateTimeKind.Unspecified).AddTicks(5887), 3L, 43L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 7L, 19L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 5, 30, 23, 3, 23, 216, DateTimeKind.Unspecified).AddTicks(5318), 5L, 56L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 10L, 12L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 3, 18, 15, 31, 50, 368, DateTimeKind.Unspecified).AddTicks(7428), 1L, 90L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 15L, 28L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 12, 25, 9, 33, 57, 468, DateTimeKind.Unspecified).AddTicks(5463), 5L, 42L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 50L, 7L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 3, 29, 8, 0, 14, 721, DateTimeKind.Unspecified).AddTicks(2103), 57L });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 5L, new DateTime(2022, 1, 3, 6, 20, 14, 560, DateTimeKind.Unspecified).AddTicks(4314), 2L, 81L, false },
                    { 3L, 26L, new DateTime(2021, 7, 21, 1, 29, 31, 614, DateTimeKind.Unspecified).AddTicks(4795), 3L, 43L, false },
                    { 4L, 20L, new DateTime(2021, 10, 6, 20, 27, 33, 18, DateTimeKind.Unspecified).AddTicks(6817), 2L, 64L, false },
                    { 4L, 24L, new DateTime(2021, 9, 6, 15, 54, 35, 309, DateTimeKind.Unspecified).AddTicks(768), 5L, 36L, false },
                    { 5L, 45L, new DateTime(2021, 4, 22, 18, 34, 38, 703, DateTimeKind.Unspecified).AddTicks(3407), 4L, 75L, false },
                    { 6L, 5L, new DateTime(2021, 7, 26, 18, 42, 24, 222, DateTimeKind.Unspecified).AddTicks(2402), 2L, 69L, false },
                    { 6L, 12L, new DateTime(2021, 6, 21, 0, 44, 46, 683, DateTimeKind.Unspecified).AddTicks(3565), 5L, 6L, false },
                    { 6L, 27L, new DateTime(2021, 10, 21, 17, 10, 27, 411, DateTimeKind.Unspecified).AddTicks(5254), 2L, 13L, false },
                    { 7L, 20L, new DateTime(2021, 5, 30, 10, 13, 21, 780, DateTimeKind.Unspecified).AddTicks(3259), 5L, 60L, false },
                    { 8L, 4L, new DateTime(2021, 6, 5, 6, 3, 53, 189, DateTimeKind.Unspecified).AddTicks(5319), 5L, 50L, false },
                    { 8L, 21L, new DateTime(2021, 3, 24, 1, 31, 31, 930, DateTimeKind.Unspecified).AddTicks(7854), 3L, 7L, false },
                    { 8L, 35L, new DateTime(2022, 1, 1, 10, 46, 47, 416, DateTimeKind.Unspecified).AddTicks(5212), 2L, 26L, false },
                    { 9L, 14L, new DateTime(2021, 7, 23, 16, 40, 14, 370, DateTimeKind.Unspecified).AddTicks(6646), 2L, 94L, false },
                    { 10L, 2L, new DateTime(2021, 12, 24, 6, 57, 37, 464, DateTimeKind.Unspecified).AddTicks(9838), 5L, 17L, false },
                    { 10L, 4L, new DateTime(2021, 8, 13, 2, 35, 42, 312, DateTimeKind.Unspecified).AddTicks(751), 1L, 16L, false },
                    { 10L, 40L, new DateTime(2021, 11, 22, 0, 46, 9, 411, DateTimeKind.Unspecified).AddTicks(4132), 2L, 65L, false },
                    { 10L, 43L, new DateTime(2021, 2, 20, 1, 22, 8, 653, DateTimeKind.Unspecified).AddTicks(3736), 5L, 72L, false },
                    { 10L, 45L, new DateTime(2021, 6, 15, 2, 46, 52, 666, DateTimeKind.Unspecified).AddTicks(4357), 3L, 11L, false },
                    { 11L, 21L, new DateTime(2021, 8, 3, 12, 3, 25, 187, DateTimeKind.Unspecified).AddTicks(4810), 5L, 87L, false },
                    { 12L, 22L, new DateTime(2021, 2, 12, 23, 39, 8, 723, DateTimeKind.Unspecified).AddTicks(4631), 3L, 100L, false },
                    { 12L, 26L, new DateTime(2021, 12, 24, 5, 47, 41, 390, DateTimeKind.Unspecified).AddTicks(1757), 2L, 98L, false },
                    { 12L, 40L, new DateTime(2022, 1, 18, 19, 2, 37, 195, DateTimeKind.Unspecified).AddTicks(8667), 4L, 46L, false },
                    { 12L, 50L, new DateTime(2021, 8, 29, 16, 0, 33, 959, DateTimeKind.Unspecified).AddTicks(1533), 1L, 84L, false },
                    { 13L, 11L, new DateTime(2021, 11, 22, 18, 16, 48, 350, DateTimeKind.Unspecified).AddTicks(9483), 2L, 79L, false },
                    { 13L, 20L, new DateTime(2021, 9, 12, 19, 22, 26, 566, DateTimeKind.Unspecified).AddTicks(405), 2L, 31L, false },
                    { 13L, 33L, new DateTime(2021, 3, 7, 7, 59, 0, 965, DateTimeKind.Unspecified).AddTicks(3842), 5L, 20L, false },
                    { 13L, 48L, new DateTime(2021, 4, 29, 1, 43, 34, 213, DateTimeKind.Unspecified).AddTicks(478), 3L, 49L, false },
                    { 14L, 38L, new DateTime(2022, 1, 11, 8, 44, 55, 804, DateTimeKind.Unspecified).AddTicks(7984), 5L, 66L, false },
                    { 14L, 48L, new DateTime(2021, 10, 2, 10, 4, 20, 397, DateTimeKind.Unspecified).AddTicks(6255), 5L, 37L, false },
                    { 15L, 13L, new DateTime(2021, 6, 30, 21, 6, 27, 440, DateTimeKind.Unspecified).AddTicks(9836), 5L, 22L, false },
                    { 15L, 30L, new DateTime(2021, 6, 27, 17, 1, 29, 974, DateTimeKind.Unspecified).AddTicks(7702), 5L, 35L, false },
                    { 15L, 45L, new DateTime(2021, 10, 9, 23, 52, 22, 173, DateTimeKind.Unspecified).AddTicks(4748), 2L, 9L, false },
                    { 16L, 19L, new DateTime(2021, 5, 27, 3, 15, 22, 260, DateTimeKind.Unspecified).AddTicks(7846), 1L, 97L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 16L, 23L, new DateTime(2021, 7, 17, 13, 56, 10, 321, DateTimeKind.Unspecified).AddTicks(1377), 3L, 14L, false },
                    { 16L, 43L, new DateTime(2021, 2, 12, 9, 57, 38, 101, DateTimeKind.Unspecified).AddTicks(4368), 4L, 89L, false },
                    { 17L, 5L, new DateTime(2021, 5, 24, 20, 25, 11, 418, DateTimeKind.Unspecified).AddTicks(3634), 5L, 24L, false },
                    { 17L, 29L, new DateTime(2021, 9, 9, 19, 9, 36, 458, DateTimeKind.Unspecified).AddTicks(64), 2L, 82L, false },
                    { 18L, 31L, new DateTime(2021, 5, 1, 1, 50, 36, 854, DateTimeKind.Unspecified).AddTicks(7307), 2L, 34L, false },
                    { 18L, 34L, new DateTime(2021, 6, 1, 20, 53, 26, 361, DateTimeKind.Unspecified).AddTicks(2528), 4L, 15L, false },
                    { 19L, 10L, new DateTime(2022, 1, 3, 13, 16, 19, 59, DateTimeKind.Unspecified).AddTicks(3131), 1L, 52L, false },
                    { 21L, 46L, new DateTime(2021, 8, 3, 7, 3, 0, 188, DateTimeKind.Unspecified).AddTicks(6811), 3L, 99L, false },
                    { 22L, 8L, new DateTime(2021, 2, 4, 22, 31, 57, 44, DateTimeKind.Unspecified).AddTicks(3033), 1L, 92L, false },
                    { 22L, 13L, new DateTime(2021, 6, 23, 15, 49, 41, 593, DateTimeKind.Unspecified).AddTicks(7114), 5L, 18L, false },
                    { 22L, 36L, new DateTime(2021, 9, 1, 19, 41, 0, 228, DateTimeKind.Unspecified).AddTicks(5581), 5L, 28L, false },
                    { 23L, 51L, new DateTime(2021, 7, 11, 21, 8, 42, 540, DateTimeKind.Unspecified).AddTicks(1503), 2L, 76L, false },
                    { 24L, 10L, new DateTime(2021, 11, 7, 13, 47, 50, 14, DateTimeKind.Unspecified).AddTicks(141), 3L, 8L, false },
                    { 24L, 17L, new DateTime(2021, 8, 16, 3, 41, 51, 641, DateTimeKind.Unspecified).AddTicks(3417), 3L, 5L, false },
                    { 26L, 38L, new DateTime(2021, 7, 7, 17, 46, 52, 761, DateTimeKind.Unspecified).AddTicks(4513), 2L, 12L, false },
                    { 27L, 41L, new DateTime(2021, 11, 17, 21, 20, 35, 244, DateTimeKind.Unspecified).AddTicks(4723), 1L, 2L, false },
                    { 27L, 45L, new DateTime(2021, 9, 21, 23, 14, 23, 122, DateTimeKind.Unspecified).AddTicks(3070), 4L, 95L, false },
                    { 28L, 8L, new DateTime(2021, 11, 21, 4, 28, 7, 893, DateTimeKind.Unspecified).AddTicks(8765), 2L, 58L, false },
                    { 29L, 8L, new DateTime(2021, 5, 21, 19, 15, 23, 193, DateTimeKind.Unspecified).AddTicks(802), 1L, 86L, false },
                    { 29L, 44L, new DateTime(2021, 8, 23, 23, 40, 31, 393, DateTimeKind.Unspecified).AddTicks(3427), 3L, 71L, false },
                    { 30L, 48L, new DateTime(2021, 5, 23, 5, 34, 35, 0, DateTimeKind.Unspecified).AddTicks(9586), 3L, 3L, false },
                    { 31L, 38L, new DateTime(2021, 12, 11, 3, 57, 53, 905, DateTimeKind.Unspecified).AddTicks(5253), 3L, 32L, false },
                    { 32L, 13L, new DateTime(2021, 4, 27, 20, 11, 18, 137, DateTimeKind.Unspecified).AddTicks(7892), 5L, 27L, false },
                    { 32L, 21L, new DateTime(2021, 8, 17, 15, 55, 23, 958, DateTimeKind.Unspecified).AddTicks(1792), 4L, 4L, false },
                    { 33L, 28L, new DateTime(2021, 3, 3, 23, 43, 26, 417, DateTimeKind.Unspecified).AddTicks(7806), 1L, 91L, false },
                    { 34L, 6L, new DateTime(2021, 10, 5, 1, 16, 22, 526, DateTimeKind.Unspecified).AddTicks(7455), 2L, 44L, false },
                    { 35L, 21L, new DateTime(2021, 12, 25, 1, 56, 36, 460, DateTimeKind.Unspecified).AddTicks(6660), 4L, 63L, false },
                    { 35L, 24L, new DateTime(2022, 1, 21, 17, 35, 0, 438, DateTimeKind.Unspecified).AddTicks(3784), 3L, 19L, false },
                    { 35L, 38L, new DateTime(2021, 10, 1, 8, 47, 12, 226, DateTimeKind.Unspecified).AddTicks(2673), 5L, 74L, false },
                    { 35L, 51L, new DateTime(2021, 12, 5, 15, 41, 51, 835, DateTimeKind.Unspecified).AddTicks(4464), 5L, 70L, false },
                    { 36L, 3L, new DateTime(2021, 5, 17, 12, 50, 59, 802, DateTimeKind.Unspecified).AddTicks(4956), 5L, 47L, false },
                    { 36L, 5L, new DateTime(2021, 4, 22, 15, 52, 17, 37, DateTimeKind.Unspecified).AddTicks(6078), 5L, 41L, false },
                    { 36L, 31L, new DateTime(2021, 3, 2, 20, 6, 34, 114, DateTimeKind.Unspecified).AddTicks(8678), 5L, 10L, false },
                    { 37L, 17L, new DateTime(2021, 9, 11, 20, 33, 45, 36, DateTimeKind.Unspecified).AddTicks(5796), 1L, 96L, false },
                    { 38L, 23L, new DateTime(2021, 12, 13, 17, 11, 15, 393, DateTimeKind.Unspecified).AddTicks(9246), 4L, 29L, false },
                    { 38L, 26L, new DateTime(2021, 11, 26, 2, 2, 1, 183, DateTimeKind.Unspecified).AddTicks(2259), 2L, 73L, false },
                    { 39L, 11L, new DateTime(2021, 10, 21, 0, 34, 31, 236, DateTimeKind.Unspecified).AddTicks(7246), 1L, 77L, false },
                    { 39L, 18L, new DateTime(2021, 9, 24, 17, 49, 25, 421, DateTimeKind.Unspecified).AddTicks(1343), 3L, 88L, false },
                    { 39L, 28L, new DateTime(2021, 11, 24, 2, 49, 46, 886, DateTimeKind.Unspecified).AddTicks(6133), 5L, 38L, false },
                    { 41L, 42L, new DateTime(2021, 12, 31, 7, 7, 6, 484, DateTimeKind.Unspecified).AddTicks(6698), 2L, 78L, false },
                    { 41L, 51L, new DateTime(2022, 1, 19, 2, 55, 50, 723, DateTimeKind.Unspecified).AddTicks(227), 1L, 59L, false },
                    { 42L, 9L, new DateTime(2021, 6, 24, 22, 23, 31, 719, DateTimeKind.Unspecified).AddTicks(1422), 5L, 48L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 42L, 42L, new DateTime(2021, 2, 22, 0, 35, 59, 78, DateTimeKind.Unspecified).AddTicks(6139), 3L, 68L, false },
                    { 43L, 31L, new DateTime(2021, 10, 20, 16, 45, 37, 63, DateTimeKind.Unspecified).AddTicks(203), 1L, 61L, false },
                    { 44L, 31L, new DateTime(2021, 2, 14, 21, 2, 44, 101, DateTimeKind.Unspecified).AddTicks(965), 1L, 53L, false },
                    { 44L, 43L, new DateTime(2021, 10, 26, 13, 8, 4, 759, DateTimeKind.Unspecified).AddTicks(5599), 4L, 23L, false },
                    { 45L, 18L, new DateTime(2021, 8, 9, 2, 7, 39, 772, DateTimeKind.Unspecified).AddTicks(7394), 3L, 45L, false },
                    { 45L, 26L, new DateTime(2021, 3, 27, 1, 37, 34, 688, DateTimeKind.Unspecified).AddTicks(9869), 5L, 54L, false },
                    { 46L, 8L, new DateTime(2021, 3, 3, 8, 3, 18, 415, DateTimeKind.Unspecified).AddTicks(1245), 4L, 83L, false },
                    { 46L, 38L, new DateTime(2021, 8, 26, 19, 37, 5, 253, DateTimeKind.Unspecified).AddTicks(472), 1L, 39L, false },
                    { 47L, 4L, new DateTime(2021, 3, 16, 10, 10, 22, 359, DateTimeKind.Unspecified).AddTicks(500), 5L, 93L, false },
                    { 47L, 16L, new DateTime(2022, 1, 6, 4, 6, 37, 78, DateTimeKind.Unspecified).AddTicks(6283), 2L, 85L, false },
                    { 47L, 31L, new DateTime(2021, 5, 24, 23, 13, 39, 315, DateTimeKind.Unspecified).AddTicks(6647), 5L, 67L, false },
                    { 47L, 41L, new DateTime(2021, 6, 11, 1, 11, 13, 560, DateTimeKind.Unspecified).AddTicks(6884), 5L, 33L, false },
                    { 47L, 46L, new DateTime(2022, 1, 2, 6, 47, 38, 994, DateTimeKind.Unspecified).AddTicks(9647), 2L, 21L, false },
                    { 49L, 5L, new DateTime(2021, 4, 5, 6, 26, 19, 655, DateTimeKind.Unspecified).AddTicks(6551), 4L, 55L, false },
                    { 49L, 36L, new DateTime(2022, 1, 8, 14, 58, 41, 581, DateTimeKind.Unspecified).AddTicks(6212), 1L, 62L, false },
                    { 49L, 42L, new DateTime(2021, 5, 7, 22, 22, 47, 845, DateTimeKind.Unspecified).AddTicks(5519), 2L, 30L, false },
                    { 49L, 44L, new DateTime(2021, 6, 19, 13, 29, 10, 108, DateTimeKind.Unspecified).AddTicks(784), 2L, 40L, false },
                    { 51L, 9L, new DateTime(2021, 7, 14, 3, 35, 9, 134, DateTimeKind.Unspecified).AddTicks(95), 4L, 25L, false }
                });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 12, 21, 21, 58, 41, 323, DateTimeKind.Unspecified).AddTicks(814), 3L, "Exercitationem ab sit dolor.", new DateTime(2023, 9, 3, 13, 55, 22, 545, DateTimeKind.Unspecified).AddTicks(541), "Et aperiam ea est vitae molestiae est quas et consectetur.", 25L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 11, 15, 22, 59, 21, 336, DateTimeKind.Unspecified).AddTicks(2102), 1L, "Repellat aperiam sint quam eveniet quidem aspernatur ullam nihil.\nQui earum consectetur numquam repellat libero ut minima et sunt.\nEum qui eaque omnis sint voluptas.\nTenetur vitae tempore qui.", new DateTime(2023, 9, 7, 14, 3, 12, 741, DateTimeKind.Unspecified).AddTicks(7395), "Qui id alias magnam voluptatem.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 5, 19, 0, 53, 43, 126, DateTimeKind.Unspecified).AddTicks(2729), 3L, "Quia qui illo.\nQuasi doloremque aut blanditiis.\nIn laborum nemo aut rerum voluptatibus accusamus.\nUt nisi nostrum dolores qui excepturi voluptatem rerum qui explicabo.\nIpsam aut molestiae blanditiis.", null, false, "Unde vitae dolores molestiae.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 3, 25, 22, 46, 29, 556, DateTimeKind.Unspecified).AddTicks(468), 1L, "Voluptatem qui natus et.\nAut aperiam velit.\nRecusandae nulla qui est voluptatum sequi et.\nAperiam praesentium neque consequatur laudantium nostrum deserunt qui sapiente.", new DateTime(2022, 7, 22, 16, 6, 20, 849, DateTimeKind.Unspecified).AddTicks(8891), "Ab cumque asperiores sit minima culpa maxime suscipit ut dolorem.", 40L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 8, 28, 0, 47, 40, 552, DateTimeKind.Unspecified).AddTicks(172), 2L, "Fugit at at sunt et.\nEnim corrupti sed nihil sint iure.\nExercitationem ut est quasi est deserunt asperiores dolores.\nRerum et quibusdam.\nVeniam sed tempore laudantium qui atque itaque velit.", new DateTime(2022, 6, 9, 3, 43, 47, 362, DateTimeKind.Unspecified).AddTicks(7418), true, "Consequatur omnis accusamus enim ipsum sunt rerum cum.", 2L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 12L, new DateTime(2021, 12, 14, 9, 1, 41, 712, DateTimeKind.Unspecified).AddTicks(4789), 3L, "Debitis assumenda eaque.\nAliquid omnis aut eos adipisci vel id rerum doloremque qui.\nQuia tempora iusto nobis numquam in.\nEt quam et.\nVel est impedit est incidunt delectus.", new DateTime(2023, 10, 2, 8, 52, 28, 942, DateTimeKind.Unspecified).AddTicks(309), true, "Harum expedita aliquam quia quam sunt in nisi dignissimos et.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2022, 1, 5, 16, 11, 51, 668, DateTimeKind.Unspecified).AddTicks(8955), 3L, "Consequatur vel est.\nEst ut et laboriosam ut in quos.\nQuam qui est illo et qui.", new DateTime(2022, 3, 13, 5, 2, 40, 545, DateTimeKind.Unspecified).AddTicks(1177), "Laborum sit debitis optio illum sint quis sunt ut id.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 2, 6, 11, 19, 27, 975, DateTimeKind.Unspecified).AddTicks(3106), 4L, "Voluptatem inventore eveniet veniam.\nOccaecati et delectus numquam voluptas dignissimos ad.\nRatione voluptatem praesentium sunt.\nTotam distinctio quas id necessitatibus aut consequatur.", new DateTime(2023, 10, 16, 6, 44, 40, 594, DateTimeKind.Unspecified).AddTicks(6448), true, "Voluptate ab et quaerat nostrum velit consequatur aliquam.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2022, 1, 22, 23, 46, 30, 637, DateTimeKind.Unspecified).AddTicks(591), 3L, "Cupiditate totam accusantium.\nEos ipsa aliquam dolores illum ex earum.\nQuo blanditiis temporibus repellat quisquam esse ipsum explicabo repudiandae.\nEa aliquid veniam tempora ex enim excepturi officiis.", new DateTime(2023, 2, 23, 10, 51, 14, 647, DateTimeKind.Unspecified).AddTicks(3792), false, "Omnis ea dolorum asperiores.", 2L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 5, 4, 13, 45, 37, 279, DateTimeKind.Unspecified).AddTicks(6304), "Doloremque eum voluptas rerum.\nDolorem quidem velit nulla.\nTempore dolore quidem.\nVoluptatibus dolorum rerum dolorem dolorum aspernatur vel molestiae.\nConsequatur placeat sed quia perspiciatis soluta est rerum numquam.", new DateTime(2022, 12, 14, 13, 3, 24, 6, DateTimeKind.Unspecified).AddTicks(7877), true, "Ut debitis nulla unde ut doloremque omnis dolores.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 10, 17, 4, 26, 11, 227, DateTimeKind.Unspecified).AddTicks(2391), 4L, "Labore neque error laborum dicta itaque sint facere.\nId deserunt qui necessitatibus libero quas sunt sint velit.\nBlanditiis illum natus ea explicabo officiis.\nEt sed consequatur fugit et at voluptate accusantium.\nNesciunt reiciendis quasi natus nihil.", new DateTime(2023, 6, 27, 10, 15, 44, 129, DateTimeKind.Unspecified).AddTicks(5438), true, "Et explicabo voluptatem sit itaque.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 4, 16, 10, 45, 47, 335, DateTimeKind.Unspecified).AddTicks(1734), "Et soluta et rem quod autem iusto.\nPlaceat expedita ea quod doloribus et.\nNisi aut dignissimos quidem porro.", new DateTime(2023, 8, 8, 13, 12, 30, 977, DateTimeKind.Unspecified).AddTicks(5085), true, "Expedita asperiores alias maxime maiores.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 12L, new DateTime(2021, 5, 5, 6, 12, 5, 214, DateTimeKind.Unspecified).AddTicks(7048), "Sed et ex molestias sit amet ut corporis non facilis.\nIste ea voluptatum quis et.", new DateTime(2023, 11, 12, 18, 54, 19, 670, DateTimeKind.Unspecified).AddTicks(598), "Voluptas consequuntur consequatur consequatur quaerat.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 11, 26, 2, 15, 53, 505, DateTimeKind.Unspecified).AddTicks(43), 2L, "Aut ea sunt placeat facere.\nId fugit ducimus ducimus blanditiis non laborum enim et nesciunt.\nOmnis rem fugit et voluptates provident sequi aliquid velit consectetur.\nAut sit tempore doloremque sit ex voluptatem voluptatem enim.", new DateTime(2023, 7, 19, 4, 56, 19, 281, DateTimeKind.Unspecified).AddTicks(16), "Dolorem tempore eius consequatur mollitia enim.", 38L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 9, 10, 6, 1, 31, 998, DateTimeKind.Unspecified).AddTicks(4248), 5L, "Ipsa et et.", new DateTime(2022, 7, 12, 10, 18, 56, 157, DateTimeKind.Unspecified).AddTicks(4704), false, "Nostrum iste aut saepe molestiae.", 24L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 2, 4, 5, 5, 58, 590, DateTimeKind.Unspecified).AddTicks(705), 1L, "Sit aut eum aut.\nDolor eos autem.\nExercitationem voluptate quae quasi et incidunt.\nEos quasi minima suscipit sit voluptatibus accusamus.\nDolor quidem culpa et non unde rerum.", new DateTime(2022, 10, 3, 1, 16, 2, 682, DateTimeKind.Unspecified).AddTicks(5160), "Assumenda consequatur voluptatem omnis nihil doloremque aliquam aut explicabo.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 6, 25, 14, 54, 19, 404, DateTimeKind.Unspecified).AddTicks(1657), 1L, "A adipisci ratione adipisci voluptatum.\nItaque illum iste.\nAperiam recusandae enim cumque consequatur animi asperiores ut nulla.", new DateTime(2022, 11, 27, 19, 17, 59, 489, DateTimeKind.Unspecified).AddTicks(3558), false, "Amet eligendi architecto animi nesciunt.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 10, 8, 8, 9, 34, 791, DateTimeKind.Unspecified).AddTicks(1560), 4L, "Tempore ab molestiae rerum sint et.\nDoloribus inventore corrupti.\nIllum sunt beatae suscipit ipsam sunt veniam vitae.", new DateTime(2022, 3, 27, 5, 4, 8, 306, DateTimeKind.Unspecified).AddTicks(5407), "Et rerum qui voluptatem qui dolorem quis nesciunt modi.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 11, 29, 11, 22, 40, 703, DateTimeKind.Unspecified).AddTicks(120), 4L, "Molestiae dolorem quia numquam esse laudantium.", new DateTime(2023, 3, 17, 10, 27, 38, 409, DateTimeKind.Unspecified).AddTicks(4759), "Nostrum aspernatur non error.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 4, 22, 0, 7, 36, 83, DateTimeKind.Unspecified).AddTicks(1027), "Officiis eos quis saepe impedit.\nAut saepe veniam quia sit.\nDolores sit sequi saepe molestiae facere sed eveniet et.", new DateTime(2023, 7, 16, 12, 38, 30, 855, DateTimeKind.Unspecified).AddTicks(8435), true, "Et quos sit qui.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 11, 8, 21, 41, 8, 389, DateTimeKind.Unspecified).AddTicks(5847), 1L, "Veniam nisi iste enim laborum.\nNemo similique ad itaque voluptatibus voluptas soluta recusandae aut ipsum.\nMolestiae ad laborum et ratione ipsam ullam.\nMolestiae accusamus tenetur ut perspiciatis numquam ipsam architecto non ab.", new DateTime(2023, 9, 17, 19, 53, 40, 204, DateTimeKind.Unspecified).AddTicks(8427), false, "Doloribus quod aut nihil.", 25L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 6, 15, 23, 3, 45, 61, DateTimeKind.Unspecified).AddTicks(2333), 1L, "Cupiditate ratione illum.", new DateTime(2022, 6, 7, 20, 54, 12, 809, DateTimeKind.Unspecified).AddTicks(5223), "Ducimus rerum dicta.", 7L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 3, 6, 9, 39, 26, 81, DateTimeKind.Unspecified).AddTicks(469), 5L, "Libero minus quisquam libero voluptas.", new DateTime(2023, 1, 12, 13, 40, 41, 40, DateTimeKind.Unspecified).AddTicks(1991), "Aliquam exercitationem nobis.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 6, 13, 13, 27, 42, 12, DateTimeKind.Unspecified).AddTicks(8813), 4L, "Saepe dolorem nisi consequatur.\nQuis provident rerum.\nIn repudiandae repellendus vitae ea blanditiis numquam labore reprehenderit porro.", new DateTime(2022, 6, 2, 10, 15, 30, 472, DateTimeKind.Unspecified).AddTicks(8084), "Voluptatem deserunt optio.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 6, 3, 9, 45, 43, 915, DateTimeKind.Unspecified).AddTicks(9319), 4L, "Culpa ea amet dolor omnis saepe aut.\nPlaceat omnis fugiat dolorem dolor velit.\nVoluptatem quibusdam in adipisci nihil vero aut aut qui et.\nSed voluptatum consectetur ipsa tenetur deserunt perspiciatis eligendi consequatur ex.", new DateTime(2024, 1, 16, 3, 53, 14, 546, DateTimeKind.Unspecified).AddTicks(8714), "Voluptatem reprehenderit iure quasi ipsa iusto mollitia ipsa ea eos.", 23L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 6, 18, 5, 15, 50, 506, DateTimeKind.Unspecified).AddTicks(4740), 5L, "Sit dolore dolorem nam delectus nobis.\nMagnam quae veniam et ea dolores.\nImpedit mollitia et veniam.\nIure fuga quis.\nEaque laudantium eaque quia.", new DateTime(2023, 10, 29, 5, 27, 18, 505, DateTimeKind.Unspecified).AddTicks(1163), "Impedit iste natus quis.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 9, 22, 3, 10, 41, 786, DateTimeKind.Unspecified).AddTicks(5061), 5L, "Consequatur sit odit non aliquid tempore autem.\nIpsam cupiditate aut ipsam.\nVelit blanditiis fugiat ipsa vitae.\nSed non commodi laborum pariatur praesentium nisi labore nam.\nEa voluptates totam enim impedit vitae.", new DateTime(2022, 3, 15, 8, 53, 30, 414, DateTimeKind.Unspecified).AddTicks(7211), true, "Eos quibusdam consequuntur.", 5L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 8, 30, 22, 48, 0, 825, DateTimeKind.Unspecified).AddTicks(4773), 5L, "Qui est rerum quisquam quaerat.\nAut iusto quo eligendi a laborum.\nConsequatur similique fugit qui ipsam nobis ad nihil.\nVeritatis ea ut.", new DateTime(2023, 3, 16, 6, 19, 47, 91, DateTimeKind.Unspecified).AddTicks(974), false, "Consequatur nisi nostrum enim nam molestiae labore amet illum.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 4, 30, 22, 13, 55, 230, DateTimeKind.Unspecified).AddTicks(2149), 3L, "Molestiae autem quia ab qui est voluptatem aspernatur enim.\nAccusamus magni odio repudiandae laborum qui veniam qui cumque.\nSuscipit et quis in velit.\nExcepturi quam molestias cum veritatis inventore.\nVoluptatum et quod rerum enim sed voluptates molestiae culpa.", new DateTime(2023, 1, 30, 12, 45, 8, 358, DateTimeKind.Unspecified).AddTicks(7771), true, "Velit magni qui inventore odio suscipit quaerat.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2022, 2, 1, 9, 37, 5, 467, DateTimeKind.Unspecified).AddTicks(6876), 5L, "Voluptas officia quidem dolor.\nSit delectus esse officiis optio aut sint temporibus aliquid.", new DateTime(2023, 8, 6, 18, 5, 46, 770, DateTimeKind.Unspecified).AddTicks(3884), "Voluptatum nesciunt aut iste est laudantium ullam sunt est quidem.", 28L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 2, 4, 22, 13, 41, 315, DateTimeKind.Unspecified).AddTicks(9874), 1L, "Velit et aut.", new DateTime(2023, 6, 9, 13, 21, 42, 585, DateTimeKind.Unspecified).AddTicks(8626), false, "Qui aperiam occaecati dolor et.", 36L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 10, 16, 1, 23, 7, 244, DateTimeKind.Unspecified).AddTicks(2448), 3L, "Dolorem eum quibusdam harum expedita quo reprehenderit omnis.\nId enim qui.", new DateTime(2023, 12, 31, 6, 22, 35, 266, DateTimeKind.Unspecified).AddTicks(51), "Est beatae autem et aspernatur omnis sit delectus voluptas.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 4, 21, 17, 39, 26, 742, DateTimeKind.Unspecified).AddTicks(3053), "Et eos dolores ex quaerat.\nNon minus recusandae ullam aperiam.\nIpsam ipsa error itaque eligendi.\nQuod velit exercitationem recusandae voluptas qui.\nConsectetur rerum enim placeat doloribus hic saepe deleniti nihil impedit.", new DateTime(2023, 9, 5, 23, 19, 34, 423, DateTimeKind.Unspecified).AddTicks(6562), true, "Ut omnis enim.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 2, 8, 0, 14, 16, 243, DateTimeKind.Unspecified).AddTicks(1131), 5L, "Quia provident nihil architecto maiores voluptatem repudiandae.", new DateTime(2023, 1, 15, 9, 38, 33, 714, DateTimeKind.Unspecified).AddTicks(8050), true, "Non expedita sit tenetur enim quaerat magni.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 2, 28, 11, 30, 15, 742, DateTimeKind.Unspecified).AddTicks(1052), 2L, "Qui a aut porro est sit in molestiae.\nEt qui tempore esse fuga commodi omnis ut quisquam est.\nNatus tempora suscipit qui mollitia ut.", null, true, "Eos repellendus saepe sit assumenda.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 12, 6, 11, 32, 58, 756, DateTimeKind.Unspecified).AddTicks(2281), 2L, "Omnis ratione qui autem enim provident est.\nAut perspiciatis est asperiores dolorem sunt sint dolorum ex.\nPraesentium officiis ex.\nPerspiciatis cumque repellendus consectetur quos ducimus temporibus debitis doloribus.\nRecusandae repudiandae aut beatae excepturi expedita.", new DateTime(2022, 8, 28, 3, 30, 41, 573, DateTimeKind.Unspecified).AddTicks(8031), "Et dolor in eveniet ea voluptatem.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 6, 28, 0, 46, 39, 290, DateTimeKind.Unspecified).AddTicks(3097), 1L, "Et delectus nesciunt autem.\nQuia aut quia eaque minima maiores magni.\nRatione veritatis magnam vitae voluptas odit optio.", new DateTime(2023, 10, 6, 3, 5, 32, 595, DateTimeKind.Unspecified).AddTicks(1434), "Commodi ipsam eum quaerat tenetur.", 30L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 4, 13, 7, 3, 35, 773, DateTimeKind.Unspecified).AddTicks(6420), "Ut possimus eius rem reprehenderit est neque optio.\nVeniam accusantium ad quia corporis.\nPlaceat quam nulla.\nEa architecto tempore quasi adipisci saepe quod deserunt magnam.", new DateTime(2022, 11, 1, 18, 34, 19, 372, DateTimeKind.Unspecified).AddTicks(8883), "Quam officiis nam amet fugiat sit.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 12, 16, 9, 0, 54, 989, DateTimeKind.Unspecified).AddTicks(1757), "Cum doloremque maiores.\nSunt iusto quia fugit consequatur sint assumenda doloribus atque.\nQui exercitationem est voluptatem culpa.\nIllo repudiandae quia non magni tempora totam nobis.", new DateTime(2022, 7, 6, 6, 57, 2, 673, DateTimeKind.Unspecified).AddTicks(4606), false, "Quos et consequatur.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 7, 4, 21, 29, 44, 604, DateTimeKind.Unspecified).AddTicks(8805), "Neque ipsam praesentium et autem.\nVoluptas temporibus veritatis asperiores voluptas nihil est tempore ut.\nOccaecati et labore aperiam quisquam vero nobis dolorum sed laborum.", new DateTime(2022, 12, 5, 15, 19, 31, 468, DateTimeKind.Unspecified).AddTicks(1435), "Quae nobis ut dolorum blanditiis sed voluptatum odio.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 4, 1, 18, 58, 51, 127, DateTimeKind.Unspecified).AddTicks(6501), 4L, "Sapiente nisi voluptates mollitia ad corrupti perferendis similique velit.", new DateTime(2022, 12, 8, 22, 13, 19, 490, DateTimeKind.Unspecified).AddTicks(7588), true, "Necessitatibus ut repudiandae consequatur dolor esse voluptas ipsa quaerat.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 11, 9, 6, 57, 3, 393, DateTimeKind.Unspecified).AddTicks(3521), 3L, "Quo rerum cumque et sapiente.\nCorrupti voluptatum doloribus praesentium autem debitis distinctio consectetur.\nDolorem magni quidem aut aut enim odio veniam.", new DateTime(2023, 6, 4, 2, 30, 15, 420, DateTimeKind.Unspecified).AddTicks(641), true, "Iure odio nam rerum.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 2, 26, 20, 29, 59, 219, DateTimeKind.Unspecified).AddTicks(4177), 4L, "Minima vitae est iusto ratione excepturi facere.\nQuia atque natus nemo.\nNulla in voluptatem.\nId aperiam voluptatem autem quia aliquam.\nIure et tempore.", new DateTime(2023, 1, 20, 5, 32, 24, 706, DateTimeKind.Unspecified).AddTicks(7950), "Deserunt sed qui libero quas accusantium saepe.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 10, 24, 10, 54, 26, 326, DateTimeKind.Unspecified).AddTicks(2431), 3L, "Nesciunt provident doloribus labore.", new DateTime(2023, 8, 1, 18, 56, 17, 776, DateTimeKind.Unspecified).AddTicks(8825), true, "Dolorem non unde.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 8, 14, 12, 54, 0, 489, DateTimeKind.Unspecified).AddTicks(9888), "Quo enim amet corrupti consequatur.", null, "Odit nihil vero eligendi id tenetur dolorem fuga.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 3, 25, 16, 31, 29, 597, DateTimeKind.Unspecified).AddTicks(8117), "Ullam qui corrupti.\nCulpa magnam architecto mollitia quis.", new DateTime(2023, 10, 30, 19, 0, 21, 113, DateTimeKind.Unspecified).AddTicks(3218), "Laudantium debitis dolorum et dicta molestias.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 12, 27, 9, 39, 11, 866, DateTimeKind.Unspecified).AddTicks(3985), 3L, "Cupiditate quia quisquam a voluptatibus.\nRecusandae accusamus ipsam.\nA reiciendis odio dolor nulla.\nIste iste nihil unde voluptatem commodi unde et id natus.", null, true, "Et placeat itaque amet ad.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 6, 18, 6, 8, 39, 990, DateTimeKind.Unspecified).AddTicks(3904), "Qui alias debitis debitis deleniti tenetur voluptas vel et.", new DateTime(2023, 10, 17, 7, 21, 42, 701, DateTimeKind.Unspecified).AddTicks(4021), true, "Qui sapiente dolorem eos exercitationem explicabo cupiditate odio.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 8, 29, 17, 45, 49, 19, DateTimeKind.Unspecified).AddTicks(6526), 5L, "Quia ullam illum soluta.\nVoluptatem praesentium eveniet.", new DateTime(2022, 4, 21, 10, 42, 15, 250, DateTimeKind.Unspecified).AddTicks(231), false, "Quam porro recusandae provident maxime.", 31L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 7, 26, 3, 37, 40, 168, DateTimeKind.Unspecified).AddTicks(8371), "Sunt earum tempore consequatur molestias totam ab.\nVero iste culpa distinctio ad.\nSed dolorem tenetur doloribus sapiente deserunt nam eos fuga.\nQuo rerum eaque omnis voluptas dolor assumenda ut.\nEos voluptatum voluptatem.", new DateTime(2023, 9, 1, 2, 29, 31, 175, DateTimeKind.Unspecified).AddTicks(9669), false, "Debitis quae dolores consectetur rem sapiente iste aperiam.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 5, 30, 12, 49, 5, 83, DateTimeKind.Unspecified).AddTicks(5041), 3L, "Architecto non debitis impedit voluptatem non aut.", new DateTime(2023, 4, 30, 16, 13, 55, 482, DateTimeKind.Unspecified).AddTicks(9494), true, "Quia aut eius assumenda cumque architecto corporis.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 12, 20, 19, 51, 9, 35, DateTimeKind.Unspecified).AddTicks(5559), 1L, "Veniam et ab nostrum qui rerum.\nFugit laboriosam deleniti laudantium ipsum velit adipisci.\nVoluptatem voluptas alias vero sed voluptatibus magnam accusantium aperiam.\nEum temporibus sunt harum eum ad molestiae ratione dolor temporibus.\nDolorem quam accusamus nostrum.", new DateTime(2022, 10, 17, 18, 50, 4, 602, DateTimeKind.Unspecified).AddTicks(7246), true, "Facilis eos ipsam quibusdam vel.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 3, 5, 9, 17, 31, 145, DateTimeKind.Unspecified).AddTicks(9938), 1L, "Eaque sit in.\nPariatur quae atque.\nQuia sed accusantium voluptatem ea distinctio iusto ut magni similique.", new DateTime(2023, 8, 14, 2, 31, 49, 731, DateTimeKind.Unspecified).AddTicks(8841), "Sed quo officiis omnis quibusdam occaecati maxime.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 11, 19, 13, 46, 55, 178, DateTimeKind.Unspecified).AddTicks(5038), 3L, "Sit et odio nemo voluptatem eos consequatur culpa deleniti.", new DateTime(2023, 3, 20, 5, 5, 26, 150, DateTimeKind.Unspecified).AddTicks(5764), "Libero id possimus fugiat voluptatum ea in assumenda possimus.", 28L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 11, 19, 15, 43, 42, 171, DateTimeKind.Unspecified).AddTicks(2793), 1L, "Dolores et aliquam facilis iste et voluptas sit.", new DateTime(2022, 5, 4, 7, 59, 53, 262, DateTimeKind.Unspecified).AddTicks(1837), true, "Voluptatibus recusandae officiis accusantium odit perferendis ut dolor enim est.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 4, 13, 10, 30, 42, 417, DateTimeKind.Unspecified).AddTicks(9730), 4L, "Consequatur sed quaerat repellat ullam sit beatae ducimus.", new DateTime(2023, 10, 15, 3, 3, 39, 878, DateTimeKind.Unspecified).AddTicks(6757), true, "Ut tenetur natus quia et consequatur qui esse fugiat rerum.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 5, 2, 20, 10, 53, 507, DateTimeKind.Unspecified).AddTicks(8685), 3L, "Aperiam tempora placeat.\nQuos et soluta non quam omnis.\nNon quia quibusdam et praesentium sequi.\nConsequuntur rerum inventore.", new DateTime(2023, 12, 11, 6, 8, 50, 739, DateTimeKind.Unspecified).AddTicks(3967), false, "Eum cupiditate voluptatum pariatur dolorem.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 3, 18, 3, 37, 13, 520, DateTimeKind.Unspecified).AddTicks(4200), 1L, "Eveniet cupiditate nesciunt voluptas.", new DateTime(2023, 5, 12, 23, 59, 0, 9, DateTimeKind.Unspecified).AddTicks(7802), "Necessitatibus ex aperiam magnam non eveniet quas.", 24L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 2, 3, 6, 59, 24, 644, DateTimeKind.Unspecified).AddTicks(3663), 2L, "Consequatur necessitatibus id dignissimos inventore.", new DateTime(2022, 9, 24, 13, 0, 19, 475, DateTimeKind.Unspecified).AddTicks(7829), "Delectus et quia nulla cumque rerum ab.", 19L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 7, 14, 22, 35, 39, 632, DateTimeKind.Unspecified).AddTicks(5147), 1L, "Ipsa error aut quidem sed recusandae.", new DateTime(2023, 5, 28, 1, 20, 22, 471, DateTimeKind.Unspecified).AddTicks(5315), "Fugiat non quaerat deleniti delectus.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 11, 2, 3, 36, 25, 623, DateTimeKind.Unspecified).AddTicks(3553), "Aut consequuntur dolore dolores vero veritatis commodi minus voluptas et.\nRepellendus consequatur magnam.\nMolestias ea dolores accusantium sed cum hic.", new DateTime(2023, 4, 1, 12, 48, 49, 85, DateTimeKind.Unspecified).AddTicks(9244), "Qui nobis iusto aut temporibus quo nihil ipsam qui.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 8, 3, 18, 29, 27, 737, DateTimeKind.Unspecified).AddTicks(1737), 1L, "Est cupiditate delectus.\nQui qui veniam eius suscipit eveniet molestiae possimus aliquam sed.\nIllum quibusdam ab incidunt recusandae.\nUt maiores vitae consequatur tempore deleniti aliquid.", new DateTime(2023, 2, 20, 1, 27, 32, 474, DateTimeKind.Unspecified).AddTicks(3894), false, "Velit odit eius reiciendis eveniet.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 10, 8, 20, 54, 59, 986, DateTimeKind.Unspecified).AddTicks(518), 1L, "Iusto ab aut quis nihil molestiae.\nQui provident nisi ut rerum dolorem ratione laboriosam.", new DateTime(2023, 12, 12, 16, 23, 13, 397, DateTimeKind.Unspecified).AddTicks(7670), true, "Debitis provident illo porro at libero commodi error dolore.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2022, 1, 8, 22, 19, 37, 131, DateTimeKind.Unspecified).AddTicks(5591), 3L, "Ipsam labore et et labore nihil aut dignissimos.\nMolestiae voluptatum laboriosam est rerum similique sint id.\nArchitecto sequi accusantium labore rerum nam soluta repellat.\nDeserunt nostrum iste ut iste et ratione pariatur.", new DateTime(2023, 11, 28, 6, 17, 50, 812, DateTimeKind.Unspecified).AddTicks(1465), "Eum molestiae quis maxime suscipit autem voluptatem sit repellendus.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 6, 30, 12, 45, 44, 454, DateTimeKind.Unspecified).AddTicks(6586), 4L, "Culpa quo beatae mollitia assumenda natus labore maxime.\nSequi quia culpa et sed.\nAperiam expedita id ab numquam aut rerum.", new DateTime(2022, 5, 25, 9, 53, 9, 381, DateTimeKind.Unspecified).AddTicks(9528), false, "In accusamus voluptates sunt rerum vero assumenda eos cupiditate.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 12, 13, 0, 12, 36, 882, DateTimeKind.Unspecified).AddTicks(9197), 3L, "Numquam quia sint porro.", new DateTime(2022, 12, 31, 12, 30, 26, 683, DateTimeKind.Unspecified).AddTicks(8164), false, "Dolorem molestiae doloremque quo nulla modi et est enim.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 8, 20, 21, 36, 53, 739, DateTimeKind.Unspecified).AddTicks(5878), 3L, "Iste esse dolorem perferendis delectus aut sint totam.\nSunt quod beatae ipsam et quaerat nisi totam.\nAlias nobis accusantium iusto sed atque voluptas ipsa eius alias.\nQuia iste perspiciatis eos officia debitis ea corrupti.", new DateTime(2022, 5, 4, 2, 33, 33, 302, DateTimeKind.Unspecified).AddTicks(7969), "Aliquam rem exercitationem.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 6, 2, 6, 11, 25, 733, DateTimeKind.Unspecified).AddTicks(843), 2L, "Unde exercitationem sit id sed numquam nisi dolore molestiae.\nSint facere iste provident velit itaque qui consectetur.\nVero nisi voluptas libero veniam in ducimus voluptas recusandae vero.\nRatione dignissimos hic eum aut dolore quia voluptatibus possimus.", new DateTime(2022, 5, 18, 22, 33, 57, 790, DateTimeKind.Unspecified).AddTicks(5404), false, "Unde voluptates labore quasi natus.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 3, 17, 21, 0, 7, 821, DateTimeKind.Unspecified).AddTicks(2360), "Fuga id doloremque tempore quis voluptate reprehenderit quia sint.\nAut ipsum cupiditate hic vel placeat.\nPossimus quo laudantium sed repellat quibusdam.", "Iusto eum aliquid aut molestias aut expedita et.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 6, 7, 13, 4, 23, 713, DateTimeKind.Unspecified).AddTicks(5650), 1L, "Vitae est id atque odit sequi perferendis eveniet voluptatem nemo.\nNeque omnis dignissimos eveniet adipisci voluptatibus.", new DateTime(2022, 7, 31, 23, 3, 19, 87, DateTimeKind.Unspecified).AddTicks(8477), false, "Repellendus ipsa itaque tempora fuga.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2022, 2, 1, 15, 36, 28, 649, DateTimeKind.Unspecified).AddTicks(681), 2L, "Maiores reiciendis voluptatibus molestiae nulla.\nReiciendis placeat nihil sit porro provident qui rerum pariatur.\nVoluptatibus asperiores dignissimos quibusdam molestiae velit voluptates aut minima ut.\nDolores aperiam aut architecto minus.", new DateTime(2024, 1, 6, 20, 27, 57, 243, DateTimeKind.Unspecified).AddTicks(4950), "Excepturi eum magnam est omnis incidunt exercitationem voluptas molestiae.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 2, 15, 4, 41, 52, 442, DateTimeKind.Unspecified).AddTicks(3314), 4L, "Enim suscipit voluptatibus alias molestiae.\nEt consequatur ratione earum blanditiis nulla porro.\nAut maiores similique qui aut harum a neque.\nQuis dolorum cupiditate placeat.\nDolor maiores voluptatum cupiditate modi.", new DateTime(2023, 8, 11, 18, 58, 55, 430, DateTimeKind.Unspecified).AddTicks(206), false, "Nesciunt quia et distinctio rerum autem exercitationem molestiae et.", 8L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 8, 15, 14, 6, 4, 856, DateTimeKind.Unspecified).AddTicks(1148), 1L, "Delectus provident consequatur est.\nEum veniam ipsam voluptatem consequuntur optio vel in.", new DateTime(2023, 9, 27, 5, 32, 54, 895, DateTimeKind.Unspecified).AddTicks(3257), "Voluptatem asperiores tempore nulla cumque.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 12, 20, 20, 8, 38, 21, DateTimeKind.Unspecified).AddTicks(2165), 3L, "Corrupti commodi qui nostrum suscipit repellendus id consequatur voluptatem omnis.\nItaque ducimus unde et ab qui voluptas excepturi.\nNeque excepturi autem est nihil.", new DateTime(2022, 7, 21, 13, 49, 35, 888, DateTimeKind.Unspecified).AddTicks(8372), "Tenetur asperiores quis ut id error harum.", 7L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 5, 27, 17, 5, 43, 455, DateTimeKind.Unspecified).AddTicks(2703), 2L, "Et ipsa veritatis.", new DateTime(2023, 1, 5, 2, 9, 54, 327, DateTimeKind.Unspecified).AddTicks(5115), "Et aliquid distinctio omnis.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 11, 9, 17, 6, 30, 174, DateTimeKind.Unspecified).AddTicks(1076), "Maiores consequatur qui aut consequatur sunt autem qui rerum quas.\nExplicabo rerum at itaque.\nCumque rem nostrum cumque laborum nobis.\nVoluptatem quisquam non voluptate reprehenderit aspernatur laboriosam.\nCum omnis nobis.", new DateTime(2023, 8, 20, 14, 58, 10, 942, DateTimeKind.Unspecified).AddTicks(5599), false, "Possimus sit voluptatem quibusdam sed consequuntur.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 6, 16, 0, 16, 26, 622, DateTimeKind.Unspecified).AddTicks(3698), 1L, "Est quo aspernatur.\nUllam enim error vel veniam.\nIn quae corporis et.", new DateTime(2023, 1, 3, 20, 6, 19, 720, DateTimeKind.Unspecified).AddTicks(2969), "Possimus ab qui omnis esse natus ut dolore.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 3, 18, 11, 52, 35, 373, DateTimeKind.Unspecified).AddTicks(1015), "Ratione in et molestiae quo qui quia.\nAperiam itaque qui rerum quia ut.\nMaxime ullam sunt officiis ea qui laborum cupiditate.\nVoluptate eaque et molestias nam.\nExplicabo architecto ipsam distinctio aliquam rem.", null, false, "Et et aperiam vero quidem vel rem nemo.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { new DateTime(2022, 1, 28, 0, 42, 13, 607, DateTimeKind.Unspecified).AddTicks(6629), 2L, "Iusto est est provident ab rerum.\nEt iure vel.\nSunt voluptas molestias harum nam perferendis labore nobis exercitationem.", new DateTime(2023, 1, 9, 8, 1, 53, 529, DateTimeKind.Unspecified).AddTicks(832), true, "Veritatis sequi exercitationem voluptatum voluptas ratione saepe.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 8, 21, 13, 7, 1, 386, DateTimeKind.Unspecified).AddTicks(2162), 1L, "Porro quidem impedit aut est quam dolor maiores dolorem cumque.\nQuibusdam accusantium eius.\nDistinctio vel facere et quia eius repudiandae et.\nVoluptatum sint qui.", new DateTime(2023, 6, 13, 6, 42, 56, 229, DateTimeKind.Unspecified).AddTicks(6908), "Aut natus ullam commodi.", 3L });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 7, 2, 32, 39, 477, DateTimeKind.Unspecified).AddTicks(7418), "Quaerat voluptas debitis.\nSoluta harum voluptatem quam reprehenderit.\nEt ut dolor dolorem minima ea.\nDicta cum quo vel error quis delectus.", false, 1, 42L, new Guid("783eb20f-a38c-9c37-d8d6-466fbb77b46c"), "Vel voluptatem temporibus ducimus iste quibusdam voluptatibus quisquam voluptatem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 6, 3, 44, 48, 680, DateTimeKind.Unspecified).AddTicks(7758), 2L, "Eos cumque eligendi qui voluptates.\nVitae eum omnis sit magni harum deserunt.\nPraesentium ducimus quia magni rem enim.\nAlias maiores qui similique commodi dolores explicabo.\nPerspiciatis et repellendus pariatur ipsum asperiores voluptatem accusantium error.", true, 1, 36L, new Guid("db2e9434-2d8d-5b2d-b5f8-165defff48cc"), "Omnis rem vero quisquam quisquam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 26, 9, 16, 46, 237, DateTimeKind.Unspecified).AddTicks(3257), 1L, "Dolor nihil esse odio quam.\nAssumenda et et dolore non est totam in aliquid.\nAb quia at saepe omnis ut quam eos nemo repellendus.\nVel neque impedit aliquam vero provident quidem iure.", 1, 32L, new Guid("6ac36ed7-cb50-216c-173a-8972101ccdbc"), "Voluptatibus ipsum aut amet." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 13, 14, 27, 55, 275, DateTimeKind.Unspecified).AddTicks(8433), 3L, "Aut voluptas dolor dignissimos illo et illo soluta ut.\nNon commodi perferendis nemo dolorum impedit assumenda esse dolores quod.", true, 1, 31L, new Guid("5d38c045-478f-fd15-8e3c-6e570b01fb64"), "Aspernatur repellat quas molestiae earum est molestiae adipisci blanditiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 21, 4, 28, 38, 930, DateTimeKind.Unspecified).AddTicks(1596), 5L, "Culpa sunt et omnis.", 36L, new Guid("577e995a-6147-9ae8-342d-332cafb298dd"), "Repudiandae aut ex sunt excepturi vero cumque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 19, 12, 56, 48, 635, DateTimeKind.Unspecified).AddTicks(8079), 5L, "Unde quia tenetur non.\nSed dolor dolore dolore deserunt.\nDolore et error error neque est porro.\nOmnis dolorem qui.\nEos hic sint quos in rerum est.", true, 34L, new Guid("2faee5e5-fc3b-66f0-554d-2bdb158a6d9a"), "Ipsum quia ratione." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 15, 7, 3, 22, 371, DateTimeKind.Unspecified).AddTicks(9042), 3L, "Sunt voluptatibus voluptas impedit animi est natus quia.\nId dolorum earum error ut.\nFacilis et expedita amet.", 1, 7L, new Guid("5012631b-d290-eee2-22f8-2e3c26993ad0"), "Adipisci rem quasi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 2, 20, 4, 26, 181, DateTimeKind.Unspecified).AddTicks(8260), "Illo qui culpa inventore itaque soluta.", true, 0, 49L, new Guid("8cf67f63-9dcc-6434-4cf9-4d44eebb589f"), "A enim necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 20, 1, 56, 1, 410, DateTimeKind.Unspecified).AddTicks(2828), 5L, "Magnam perferendis quia fugit quasi molestiae sunt.\nEligendi quo facere non deleniti eum omnis est.\nPariatur quisquam doloremque voluptatem doloremque iure impedit.\nHarum alias aut quod praesentium commodi.", true, 36L, new Guid("ebd2bbec-06d2-87a1-c26c-05f6971eef5b"), "Expedita rerum laboriosam libero omnis sunt ullam sit quisquam veniam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 23, 9, 52, 15, 483, DateTimeKind.Unspecified).AddTicks(699), "Dolores aut quibusdam eveniet quasi.\nEst consectetur aut numquam id similique veniam numquam quo.", true, 18L, new Guid("feab9b8e-258e-9303-86a9-c80858804a2f"), "Facere distinctio repudiandae vel quo laudantium aut dolores tempore nemo." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 11, 18, 7, 46, 821, DateTimeKind.Unspecified).AddTicks(5176), 4L, "Fugit rem distinctio.\nSed ducimus accusantium voluptatibus quam.", true, 1, 24L, new Guid("09d946af-3635-5485-860d-415e002a6a73"), "Rem sed vel quo beatae aliquid sit eius corrupti eum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 6, 5, 10, 57, 833, DateTimeKind.Unspecified).AddTicks(9112), "Fugit corporis aut officia sunt ut.", 1, 43L, new Guid("ebcfff1a-7791-9197-2ab2-7ef69f6d99c3"), "Iure et sit provident numquam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 26, 17, 31, 48, 402, DateTimeKind.Unspecified).AddTicks(8076), "Corporis eius incidunt et.\nEst eum voluptates nihil quo ut fugiat.", false, 1, 39L, new Guid("5b229e00-871f-bf21-b1d9-52a2e6855bf8"), "Eveniet voluptatem vel." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 8, 3, 47, 5, 853, DateTimeKind.Unspecified).AddTicks(2364), 4L, "In voluptas consequuntur mollitia officiis.\nEligendi fugiat sapiente eum ut id.\nQuasi a dicta qui est quod et voluptatem.\nMaiores laudantium et rerum molestiae voluptatum.\nAmet rerum suscipit fugiat autem tempora quas aut.", 3L, new Guid("15c28b10-de58-91c2-dbe8-b6715c506d3c"), "Et nisi dolores." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 8, 15, 44, 36, 222, DateTimeKind.Unspecified).AddTicks(8067), 2L, "Voluptas voluptas blanditiis beatae itaque aperiam quo ab sint doloribus.", 24L, new Guid("24d03f92-26e5-4863-c801-a2a50dcf213d"), "Praesentium aspernatur dolorum iusto aliquid ea." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 11, 11, 58, 57, 329, DateTimeKind.Unspecified).AddTicks(7505), 4L, "Est fugiat vel magni sunt sunt quia sit exercitationem vitae.\nUt qui commodi.\nSint cupiditate non ab consequatur.", false, 1, 31L, new Guid("c0f2527e-dc2d-fbb8-4561-63aacb2847e7"), "Fugiat esse tempora." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 25, 13, 56, 39, 281, DateTimeKind.Unspecified).AddTicks(9543), 4L, "Quas perspiciatis cumque eos asperiores magnam est.\nSimilique vel fugiat occaecati perferendis aliquid velit voluptates sit aliquam.", false, 10L, new Guid("d9c7564a-8186-802a-836b-16499d2a5739"), "Quo autem consequatur minima minus laborum inventore." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 29, 8, 52, 58, 892, DateTimeKind.Unspecified).AddTicks(6229), 1L, "Deleniti provident in ut consectetur quo est.\nEarum error adipisci odio molestias.", false, 1, 16L, new Guid("c7f1a22b-7d31-750c-635d-baab298b9f1d"), "Quos cum enim non impedit magni accusamus sed est quisquam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 30, 23, 44, 52, 98, DateTimeKind.Unspecified).AddTicks(3862), 3L, "Voluptatem mollitia consequatur ad aut quod et.\nIllo laboriosam dignissimos eaque recusandae eligendi suscipit voluptatem.", 35L, new Guid("fcb4da62-2c1a-004a-b019-061891d8cce9"), "Doloremque qui dignissimos mollitia nihil similique eaque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 29, 5, 27, 17, 373, DateTimeKind.Unspecified).AddTicks(2777), "Quam voluptas animi.\nEt doloribus qui non.\nSed quo ipsum ipsum et officia.", 0, 40L, new Guid("75464f24-58b5-719a-b43a-a9c62d6ce1cf"), "Cum modi beatae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 23, 17, 9, 37, 240, DateTimeKind.Unspecified).AddTicks(6448), 3L, "Modi numquam voluptates enim quae.\nProvident est eos culpa ea et assumenda quod.\nNostrum vel fuga et itaque aliquam ut.\nVelit magni nam non quo aliquid quam adipisci odio.\nAliquid officiis est earum.", 16L, new Guid("8750f2c2-b0b4-77f5-fe19-4887df46cafa"), "Est aspernatur maiores at." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 25, 3, 44, 29, 677, DateTimeKind.Unspecified).AddTicks(4590), 4L, "Quo aliquid ea nemo sint deleniti eveniet impedit deleniti.\nAsperiores sit sunt.\nRerum qui perferendis quas quia nemo repellat molestiae dignissimos.", 1, 44L, new Guid("b6f8d041-7b9c-122d-c1fd-f4ba22ce357d"), "Iure ex dolores atque quidem accusamus ea delectus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 26, 1, 21, 9, 442, DateTimeKind.Unspecified).AddTicks(3892), 4L, "Similique quis distinctio fugiat sapiente temporibus voluptatum nam id sed.\nIllum saepe rerum qui dicta iste nesciunt dolorem natus.\nEst id repellat.", false, 0, 34L, new Guid("87484f17-37bf-2700-470b-e5f4de2f0478"), "Consequatur reprehenderit reprehenderit veritatis assumenda doloremque illo error officiis quam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 1, 10, 11, 44, 838, DateTimeKind.Unspecified).AddTicks(5061), 5L, "Nam neque et eos quo qui fugiat ipsum.\nVelit maxime rerum facilis voluptas eum aut dignissimos dolorem tempora.\nExpedita rerum sint debitis.\nVelit natus impedit doloribus pariatur.\nEt quia et explicabo error nobis et iste quae.", false, 1, 9L, new Guid("1834d222-2085-5ce2-fa9b-c1f9f61d75fe"), "Hic eveniet et ratione repellat et possimus qui amet." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 14, 19, 21, 26, 123, DateTimeKind.Unspecified).AddTicks(3589), "Quis sed laborum dolor iusto.\nQuibusdam error aperiam assumenda eum sint rem consequatur.", true, 30L, new Guid("442d98b5-5801-bd8c-42fe-ee7b20a75e78"), "Culpa quae ut maiores animi soluta." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 3, 4, 12, 38, 995, DateTimeKind.Unspecified).AddTicks(8768), 4L, "Mollitia et et.\nAut nisi recusandae quis.\nVero nisi tempora eum atque ullam pariatur perferendis impedit eaque.", 3L, new Guid("89b9f25d-91df-e4a1-50f0-9a1be6f76340"), "Sint veritatis quis magni debitis officia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 30, 5, 36, 12, 623, DateTimeKind.Unspecified).AddTicks(5230), "Velit ducimus modi non quae saepe quasi.\nHic voluptatem eos a quia accusamus ad.\nIn molestias facere natus.", 47L, new Guid("3d831dfe-908f-125e-cbac-b04502c76898"), "Pariatur sit et aspernatur et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 24, 9, 7, 41, 313, DateTimeKind.Unspecified).AddTicks(9484), 2L, "Aut harum quia provident assumenda dolor consectetur animi.", true, 0, 12L, new Guid("e589d421-f21b-7787-2419-08178a8966ec"), "Nostrum nam odit placeat officiis quo minima iusto et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 13, 22, 14, 37, 54, DateTimeKind.Unspecified).AddTicks(4097), 3L, "Animi reiciendis temporibus quos quasi molestias.\nEst delectus non totam rerum ea in ut.\nQuidem quia voluptate sit soluta consectetur nulla fugiat.\nPerferendis cupiditate ut.", true, 15L, new Guid("aca62579-431b-6278-a80f-7c56f3697330"), "Necessitatibus consequatur fuga et voluptatem quisquam dolor commodi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 18, 1, 53, 31, 265, DateTimeKind.Unspecified).AddTicks(2110), 5L, "Voluptatibus est et.\nUt sapiente maxime quisquam minima laboriosam architecto eos deserunt temporibus.\nIncidunt nesciunt et qui molestias tempora ipsum voluptatem dolor sint.", 26L, new Guid("09744f50-eb74-430b-dd48-e4d10071cb95"), "Quia velit sunt et qui et beatae qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 23, 17, 32, 0, 682, DateTimeKind.Unspecified).AddTicks(8054), 4L, "Tempora earum eum consequatur qui laudantium sapiente.\nDolorem aliquam vel similique enim blanditiis.", 9L, new Guid("1658e0f9-f012-f5b5-c923-0b3be8cdf8f2"), "Et illo tempore." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 4, 12, 41, 16, 264, DateTimeKind.Unspecified).AddTicks(5219), 1L, "Ut aut sed magnam.\nUt explicabo rerum ut assumenda quasi cupiditate.\nVero quidem modi libero.\nAutem ut architecto qui exercitationem rem praesentium odit.", 0, 50L, new Guid("d3ba82a4-bca1-80b7-27d4-68d4b2cc09cb"), "Expedita officia porro." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 21, 6, 6, 11, 370, DateTimeKind.Unspecified).AddTicks(7177), "In aliquam accusantium aut qui odio quis et nihil.", false, 0, 4L, new Guid("8007b35d-ddea-5fc3-49be-9c7148fea0ab"), "Veniam qui fugit et dolor voluptates deserunt odit dolores." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 8, 0, 12, 40, 830, DateTimeKind.Unspecified).AddTicks(5547), "Exercitationem nam nihil officia autem tenetur qui voluptas quam asperiores.", true, 51L, new Guid("22257253-54fb-bb77-067a-6dfa33c489fe"), "Aut magni minima consectetur omnis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 56, 24, 241, DateTimeKind.Unspecified).AddTicks(2443), 2L, "Veritatis officia labore.", true, 0, 7L, new Guid("e61726a0-2803-7fd3-3506-7314fe6ad52b"), "Neque excepturi labore impedit saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 20, 8, 55, 35, 874, DateTimeKind.Unspecified).AddTicks(5516), 3L, "Sapiente ut sed esse quia sed et molestiae repellat aut.\nMaiores nam quidem.\nCum labore aut.\nDicta id vitae saepe molestiae perferendis debitis.\nQuia nihil voluptatem enim hic voluptates modi corrupti voluptas voluptas.", 0, 15L, new Guid("5bda3aa7-431c-1795-5b04-be168e058b33"), "Ducimus vel a." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 5, 13, 3, 57, 833, DateTimeKind.Unspecified).AddTicks(7617), 2L, "Dignissimos ratione ad.", 20L, new Guid("f852a520-beff-e804-6814-d8ae520e542b"), "Natus aut sunt sint consequatur quibusdam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 17, 11, 2, 30, 530, DateTimeKind.Unspecified).AddTicks(5371), 1L, "Vero occaecati enim.", false, 26L, new Guid("3792ddc0-f22a-b723-c596-ac69fd330d51"), "Quidem sit sint et ea earum non animi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 26, 14, 9, 57, 587, DateTimeKind.Unspecified).AddTicks(4617), 4L, "Veritatis voluptates quis vitae consequatur.", true, 0, 37L, new Guid("942d2556-0b4e-1ebb-5ac6-97bf34347e45"), "Maxime enim deleniti recusandae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 15, 7, 31, 40, 404, DateTimeKind.Unspecified).AddTicks(8593), 5L, "Quia sunt est voluptatem autem quibusdam.\nNon eum aut.", 0, 26L, new Guid("9fd04355-46bf-6982-d270-3a6154e49936"), "Consequatur voluptatem vel eum quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 20, 8, 23, 25, 313, DateTimeKind.Unspecified).AddTicks(3062), 3L, "Quisquam quas ullam voluptatibus tempora qui corporis.\nVoluptatem non quis ipsa quis.\nLabore officiis incidunt illum aut assumenda molestiae reprehenderit et natus.\nSed voluptatem quia dicta consequatur accusamus.\nEt praesentium dolorum voluptas doloremque asperiores ea dolor.", true, 0, 32L, new Guid("c7b78e36-5830-d685-3d00-958579d25a85"), "Nisi ut voluptas." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 18, 38, 482, DateTimeKind.Unspecified).AddTicks(734), 4L, "Blanditiis adipisci enim culpa.\nSuscipit laborum omnis magnam animi at pariatur architecto quasi.\nEt eum exercitationem veritatis nostrum esse.\nEx ea veritatis laudantium aut.\nQuas eaque odit aut qui.", 0, 2L, new Guid("6c6958d9-cdf2-ceb9-04de-6dcf4d705236"), "Hic nihil ex labore recusandae quibusdam velit ipsa." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 13, 23, 46, 18, 373, DateTimeKind.Unspecified).AddTicks(1948), 2L, "Quos aut qui autem.\nMolestiae sunt omnis placeat optio neque deserunt sunt.", 33L, new Guid("3a7f4531-f7bb-a978-c6eb-188382dd8eee"), "Consequatur consequuntur qui assumenda eum et odio." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 14, 9, 7, 56, 122, DateTimeKind.Unspecified).AddTicks(4781), 2L, "Dolor nemo enim porro reprehenderit incidunt unde ipsam nihil.\nNon enim quaerat sit aliquam ea quas laborum quas quas.\nSit et cupiditate eos ex.\nPerferendis consectetur necessitatibus.\nOptio ea quaerat illo est illum placeat qui.", 44L, new Guid("dabb0f78-5fa8-92a2-75cb-5b691ddf4106"), "Ut a dicta." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 23, 22, 39, 11, 192, DateTimeKind.Unspecified).AddTicks(3007), 2L, "Delectus id officia.\nNesciunt eos dolorem velit reiciendis id incidunt sit consequatur.\nQuo aliquam consequuntur quaerat quas consequatur.\nIllo qui quasi saepe esse odio qui est.\nAutem veritatis in perspiciatis culpa optio.", true, 12L, new Guid("5a98cd58-3b08-b13c-7a3f-27053ff6ed2f"), "Non perspiciatis perspiciatis corporis recusandae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 28, 7, 52, 18, 941, DateTimeKind.Unspecified).AddTicks(911), 3L, "Tempora dolorem possimus voluptatem ut sit voluptates.\nQuae dolor voluptatum.\nEaque consequuntur iste consequatur amet quisquam voluptatem.\nCumque autem suscipit harum quaerat libero tempore eum ratione.", 1, 44L, new Guid("941a7992-90f8-faf3-0704-7f258db0b060"), "Sit praesentium sint cupiditate." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 26, 14, 10, 40, 40, DateTimeKind.Unspecified).AddTicks(9027), 5L, "Consequuntur consequatur incidunt nisi vitae ut in ad et.\nId eveniet quia animi.\nEt sint eveniet consequuntur.\nTemporibus nesciunt similique quibusdam dolor et.\nVoluptates sed atque est perspiciatis vel sint rerum.", 25L, new Guid("8e866f16-8fd4-f066-ea83-fe805e6a597e"), "Ut assumenda sapiente illum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 8, 6, 19, 8, 436, DateTimeKind.Unspecified).AddTicks(264), 3L, "Inventore sint eligendi a ut voluptatem ab.", true, 1, 4L, new Guid("8a35047c-e212-6638-d3b6-921fe9742fa6"), "Ad voluptas ut ut repellat possimus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 15, 21, 9, 59, 47, DateTimeKind.Unspecified).AddTicks(6412), 2L, "Non deleniti et earum et deleniti quibusdam et labore vel.\nFacilis ea et dolor odit sunt explicabo.\nMolestias et ad error eius minima maxime ipsum.\nConsequatur et nisi enim.", false, 0, 17L, new Guid("92d72482-7b2e-1925-c6e6-9d5ac19e067b"), "Non dolor aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 51, 44, 12, DateTimeKind.Unspecified).AddTicks(9579), 5L, "Eius voluptatem quis.\nDeleniti inventore voluptas qui quod libero explicabo.\nDoloribus minima dolore fuga molestiae doloremque vel sed.\nOmnis odio et eum iure sed ratione amet.\nConsectetur incidunt omnis ut est aut placeat.", 1, 26L, new Guid("ac544cb7-acfb-09b2-8550-2f752ce01b9c"), "Molestias molestiae voluptas est unde in earum doloremque sed." });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 12, 27, 5, 6, 53, 347, DateTimeKind.Unspecified).AddTicks(8906), 3L, new DateTime(2022, 1, 27, 18, 23, 22, 945, DateTimeKind.Unspecified).AddTicks(3079), 8L, new DateTime(2019, 12, 14, 5, 58, 49, 714, DateTimeKind.Unspecified).AddTicks(8551), new DateTime(2021, 5, 9, 23, 57, 53, 935, DateTimeKind.Unspecified).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 5, 4, 23, 3, 39, 632, DateTimeKind.Unspecified).AddTicks(5361), 5L, new DateTime(2022, 1, 30, 7, 34, 17, 768, DateTimeKind.Unspecified).AddTicks(7614), 28L, new DateTime(2019, 9, 14, 17, 12, 51, 224, DateTimeKind.Unspecified).AddTicks(4248), new DateTime(2021, 11, 19, 3, 3, 10, 385, DateTimeKind.Unspecified).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2021, 6, 28, 21, 14, 40, 106, DateTimeKind.Unspecified).AddTicks(5473), new DateTime(2022, 1, 8, 11, 44, 2, 619, DateTimeKind.Unspecified).AddTicks(528), 51L, new DateTime(2019, 3, 21, 13, 27, 18, 761, DateTimeKind.Unspecified).AddTicks(2673), new DateTime(2021, 7, 20, 1, 56, 10, 643, DateTimeKind.Unspecified).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 3, 3, 20, 1, 13, 761, DateTimeKind.Unspecified).AddTicks(8678), 2L, new DateTime(2022, 1, 15, 8, 30, 42, 917, DateTimeKind.Unspecified).AddTicks(2092), 12L, new DateTime(2019, 3, 23, 1, 41, 41, 976, DateTimeKind.Unspecified).AddTicks(6419), new DateTime(2021, 7, 26, 18, 7, 42, 831, DateTimeKind.Unspecified).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 9, 18, 7, 49, 58, 629, DateTimeKind.Unspecified).AddTicks(9631), new DateTime(2022, 2, 1, 17, 40, 23, 513, DateTimeKind.Unspecified).AddTicks(5926), 52L, new DateTime(2019, 7, 14, 9, 38, 49, 510, DateTimeKind.Unspecified).AddTicks(1328), new DateTime(2021, 1, 6, 2, 2, 58, 405, DateTimeKind.Unspecified).AddTicks(1646) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 10, 31, 7, 32, 50, 156, DateTimeKind.Unspecified).AddTicks(9252), 5L, new DateTime(2022, 1, 9, 23, 9, 7, 143, DateTimeKind.Unspecified).AddTicks(5339), 73L, new DateTime(2019, 7, 28, 13, 52, 38, 822, DateTimeKind.Unspecified).AddTicks(7073), new DateTime(2021, 3, 29, 4, 30, 7, 451, DateTimeKind.Unspecified).AddTicks(4658) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 9, 16, 9, 26, 9, 970, DateTimeKind.Unspecified).AddTicks(1765), new DateTime(2022, 1, 18, 2, 12, 34, 800, DateTimeKind.Unspecified).AddTicks(9120), 52L, new DateTime(2019, 6, 5, 22, 26, 42, 67, DateTimeKind.Unspecified).AddTicks(537), new DateTime(2021, 1, 11, 2, 57, 5, 628, DateTimeKind.Unspecified).AddTicks(9532) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 2, 12, 5, 19, 50, 269, DateTimeKind.Unspecified).AddTicks(6878), 5L, new DateTime(2022, 1, 22, 11, 4, 12, 857, DateTimeKind.Unspecified).AddTicks(6426), 70L, new DateTime(2020, 1, 1, 23, 12, 28, 684, DateTimeKind.Unspecified).AddTicks(4243), new DateTime(2021, 5, 25, 21, 46, 57, 447, DateTimeKind.Unspecified).AddTicks(6393) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 2, 25, 10, 34, 50, 809, DateTimeKind.Unspecified).AddTicks(4643), new DateTime(2022, 1, 20, 4, 7, 44, 403, DateTimeKind.Unspecified).AddTicks(5900), 40L, new DateTime(2019, 11, 28, 7, 39, 15, 896, DateTimeKind.Unspecified).AddTicks(8970), new DateTime(2021, 2, 16, 11, 56, 51, 676, DateTimeKind.Unspecified).AddTicks(7204) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 2, 14, 19, 33, 5, 714, DateTimeKind.Unspecified).AddTicks(6561), new DateTime(2022, 1, 5, 13, 26, 29, 640, DateTimeKind.Unspecified).AddTicks(7532), 47L, new DateTime(2019, 3, 14, 14, 3, 55, 47, DateTimeKind.Unspecified).AddTicks(6456), new DateTime(2021, 5, 1, 8, 45, 12, 891, DateTimeKind.Unspecified).AddTicks(8511) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 3, 29, 13, 26, 11, 536, DateTimeKind.Unspecified).AddTicks(8884), new DateTime(2022, 1, 30, 16, 36, 42, 394, DateTimeKind.Unspecified).AddTicks(3449), 32L, new DateTime(2019, 5, 17, 12, 56, 32, 772, DateTimeKind.Unspecified).AddTicks(3252), new DateTime(2021, 10, 13, 1, 8, 59, 791, DateTimeKind.Unspecified).AddTicks(659) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 5, 1, 15, 7, 55, 913, DateTimeKind.Unspecified).AddTicks(9195), 1L, new DateTime(2022, 1, 29, 16, 5, 34, 571, DateTimeKind.Unspecified).AddTicks(3230), 19L, new DateTime(2019, 3, 10, 12, 18, 53, 532, DateTimeKind.Unspecified).AddTicks(1543), new DateTime(2021, 8, 25, 8, 55, 55, 48, DateTimeKind.Unspecified).AddTicks(143) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 7, 12, 16, 0, 23, 244, DateTimeKind.Unspecified).AddTicks(5061), new DateTime(2022, 1, 13, 5, 25, 8, 773, DateTimeKind.Unspecified).AddTicks(5327), 41L, new DateTime(2019, 5, 12, 5, 54, 44, 806, DateTimeKind.Unspecified).AddTicks(7889), new DateTime(2021, 7, 9, 20, 7, 28, 3, DateTimeKind.Unspecified).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 10, 17, 18, 35, 23, 438, DateTimeKind.Unspecified).AddTicks(3224), new DateTime(2022, 1, 19, 12, 17, 13, 958, DateTimeKind.Unspecified).AddTicks(8461), 13L, new DateTime(2019, 7, 31, 8, 42, 32, 80, DateTimeKind.Unspecified).AddTicks(8947), new DateTime(2021, 7, 30, 18, 49, 45, 49, DateTimeKind.Unspecified).AddTicks(9841) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 12, 3, 6, 58, 1, 323, DateTimeKind.Unspecified).AddTicks(3135), 3L, new DateTime(2022, 1, 24, 14, 44, 32, 74, DateTimeKind.Unspecified).AddTicks(2190), 22L, new DateTime(2019, 8, 10, 1, 12, 22, 926, DateTimeKind.Unspecified).AddTicks(2345), new DateTime(2021, 8, 26, 16, 51, 12, 35, DateTimeKind.Unspecified).AddTicks(921) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 2, 26, 3, 24, 35, 267, DateTimeKind.Unspecified).AddTicks(6425), 1L, new DateTime(2022, 1, 5, 3, 0, 37, 0, DateTimeKind.Unspecified).AddTicks(4883), 11L, new DateTime(2019, 7, 18, 21, 38, 13, 270, DateTimeKind.Unspecified).AddTicks(4782), new DateTime(2021, 7, 19, 9, 15, 27, 713, DateTimeKind.Unspecified).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 4, 17, 22, 45, 44, 614, DateTimeKind.Unspecified).AddTicks(5886), new DateTime(2022, 1, 22, 20, 15, 45, 897, DateTimeKind.Unspecified).AddTicks(5521), 67L, new DateTime(2019, 8, 7, 20, 58, 1, 305, DateTimeKind.Unspecified).AddTicks(845), new DateTime(2021, 4, 1, 0, 42, 48, 133, DateTimeKind.Unspecified).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 12, 21, 12, 4, 53, 977, DateTimeKind.Unspecified).AddTicks(1825), 3L, new DateTime(2022, 1, 3, 21, 46, 37, 211, DateTimeKind.Unspecified).AddTicks(964), new DateTime(2019, 11, 26, 9, 56, 29, 854, DateTimeKind.Unspecified).AddTicks(97), new DateTime(2021, 4, 18, 15, 39, 35, 901, DateTimeKind.Unspecified).AddTicks(801) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 7, 24, 1, 39, 36, 882, DateTimeKind.Unspecified).AddTicks(3294), new DateTime(2022, 1, 7, 4, 23, 49, 928, DateTimeKind.Unspecified).AddTicks(7900), 17L, new DateTime(2019, 12, 15, 18, 14, 40, 835, DateTimeKind.Unspecified).AddTicks(2046), new DateTime(2021, 1, 22, 22, 4, 42, 50, DateTimeKind.Unspecified).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2021, 10, 2, 1, 15, 7, 757, DateTimeKind.Unspecified).AddTicks(9296), new DateTime(2022, 1, 17, 22, 0, 50, 584, DateTimeKind.Unspecified).AddTicks(1386), 8L, new DateTime(2019, 4, 19, 4, 45, 26, 609, DateTimeKind.Unspecified).AddTicks(9086), new DateTime(2021, 9, 28, 6, 34, 43, 340, DateTimeKind.Unspecified).AddTicks(4711) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 50L, new DateTime(2022, 1, 25, 23, 26, 32, 751, DateTimeKind.Unspecified).AddTicks(5423), 2L, new DateTime(2022, 1, 3, 4, 19, 54, 341, DateTimeKind.Unspecified).AddTicks(4135), 81L, new DateTime(2019, 6, 19, 13, 14, 9, 911, DateTimeKind.Unspecified).AddTicks(7939), new DateTime(2021, 1, 13, 7, 45, 10, 958, DateTimeKind.Unspecified).AddTicks(9021) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 8, 29, 7, 59, 52, 140, DateTimeKind.Unspecified).AddTicks(1218), new DateTime(2022, 1, 19, 15, 28, 49, 999, DateTimeKind.Unspecified).AddTicks(8155), 36L, new DateTime(2019, 10, 26, 5, 20, 47, 257, DateTimeKind.Unspecified).AddTicks(8317), new DateTime(2021, 2, 28, 16, 23, 32, 275, DateTimeKind.Unspecified).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 7, 31, 16, 8, 55, 519, DateTimeKind.Unspecified).AddTicks(6195), 4L, new DateTime(2022, 1, 10, 7, 29, 26, 622, DateTimeKind.Unspecified).AddTicks(9657), 39L, new DateTime(2019, 12, 27, 10, 5, 15, 270, DateTimeKind.Unspecified).AddTicks(9147), new DateTime(2021, 7, 13, 6, 18, 31, 697, DateTimeKind.Unspecified).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 9, 3, 6, 4, 46, 339, DateTimeKind.Unspecified).AddTicks(3140), 5L, new DateTime(2022, 1, 3, 9, 13, 46, 435, DateTimeKind.Unspecified).AddTicks(420), 52L, new DateTime(2019, 11, 29, 1, 18, 58, 654, DateTimeKind.Unspecified).AddTicks(8467), new DateTime(2021, 7, 4, 23, 21, 30, 275, DateTimeKind.Unspecified).AddTicks(4520) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 6, 16, 21, 40, 27, 153, DateTimeKind.Unspecified).AddTicks(2362), 5L, new DateTime(2022, 1, 7, 14, 33, 23, 815, DateTimeKind.Unspecified).AddTicks(9644), 67L, new DateTime(2019, 10, 18, 19, 25, 1, 709, DateTimeKind.Unspecified).AddTicks(9587), new DateTime(2021, 9, 21, 11, 48, 43, 345, DateTimeKind.Unspecified).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 6, 12, 17, 2, 24, 333, DateTimeKind.Unspecified).AddTicks(3569), 2L, new DateTime(2022, 1, 10, 19, 0, 38, 202, DateTimeKind.Unspecified).AddTicks(3459), 40L, new DateTime(2019, 9, 4, 19, 54, 23, 304, DateTimeKind.Unspecified).AddTicks(6290), new DateTime(2021, 6, 25, 4, 33, 25, 376, DateTimeKind.Unspecified).AddTicks(9263) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 11, 5, 23, 14, 1, 845, DateTimeKind.Unspecified).AddTicks(8181), 1L, new DateTime(2022, 1, 17, 6, 44, 52, 377, DateTimeKind.Unspecified).AddTicks(6024), new DateTime(2019, 6, 11, 23, 29, 3, 564, DateTimeKind.Unspecified).AddTicks(818), new DateTime(2021, 2, 13, 22, 14, 12, 588, DateTimeKind.Unspecified).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 6, 17, 4, 41, 33, 386, DateTimeKind.Unspecified).AddTicks(7518), 2L, new DateTime(2022, 1, 14, 3, 38, 45, 484, DateTimeKind.Unspecified).AddTicks(7573), 27L, new DateTime(2019, 12, 12, 22, 50, 5, 891, DateTimeKind.Unspecified).AddTicks(4657), new DateTime(2021, 12, 2, 23, 52, 49, 291, DateTimeKind.Unspecified).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 9, 21, 11, 32, 19, 354, DateTimeKind.Unspecified).AddTicks(9934), 4L, new DateTime(2022, 1, 31, 14, 6, 10, 441, DateTimeKind.Unspecified).AddTicks(7614), 58L, new DateTime(2019, 8, 7, 3, 18, 34, 788, DateTimeKind.Unspecified).AddTicks(8492), new DateTime(2021, 4, 6, 18, 33, 43, 407, DateTimeKind.Unspecified).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 9, 30, 11, 41, 55, 956, DateTimeKind.Unspecified).AddTicks(8551), new DateTime(2022, 1, 17, 16, 11, 4, 656, DateTimeKind.Unspecified).AddTicks(3563), 7L, new DateTime(2019, 3, 5, 14, 10, 10, 891, DateTimeKind.Unspecified).AddTicks(6341), new DateTime(2021, 3, 29, 16, 39, 56, 875, DateTimeKind.Unspecified).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 7, 18, 5, 37, 27, 79, DateTimeKind.Unspecified).AddTicks(4057), new DateTime(2022, 1, 29, 22, 22, 24, 106, DateTimeKind.Unspecified).AddTicks(3123), 72L, new DateTime(2019, 10, 2, 7, 10, 37, 152, DateTimeKind.Unspecified).AddTicks(6078), new DateTime(2021, 3, 2, 3, 56, 41, 8, DateTimeKind.Unspecified).AddTicks(731) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 6, 23, 9, 45, 59, 969, DateTimeKind.Unspecified).AddTicks(3552), 2L, new DateTime(2022, 1, 22, 5, 32, 0, 650, DateTimeKind.Unspecified).AddTicks(4780), 33L, new DateTime(2019, 10, 11, 19, 33, 56, 833, DateTimeKind.Unspecified).AddTicks(1477), new DateTime(2021, 1, 26, 12, 2, 8, 517, DateTimeKind.Unspecified).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 5, 23, 18, 46, 6, 992, DateTimeKind.Unspecified).AddTicks(6273), 2L, new DateTime(2022, 1, 6, 22, 22, 5, 755, DateTimeKind.Unspecified).AddTicks(2149), 28L, new DateTime(2019, 11, 16, 10, 45, 7, 24, DateTimeKind.Unspecified).AddTicks(6698), new DateTime(2021, 5, 31, 2, 59, 7, 430, DateTimeKind.Unspecified).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 7, 29, 9, 42, 35, 666, DateTimeKind.Unspecified).AddTicks(2186), 2L, new DateTime(2022, 1, 14, 5, 46, 11, 723, DateTimeKind.Unspecified).AddTicks(2309), 28L, new DateTime(2020, 1, 25, 11, 8, 12, 741, DateTimeKind.Unspecified).AddTicks(3546), new DateTime(2021, 7, 23, 5, 11, 32, 733, DateTimeKind.Unspecified).AddTicks(8225) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 2, 4, 18, 26, 50, 788, DateTimeKind.Unspecified).AddTicks(7190), new DateTime(2022, 1, 3, 4, 44, 46, 880, DateTimeKind.Unspecified).AddTicks(94), 50L, new DateTime(2019, 2, 5, 17, 1, 10, 82, DateTimeKind.Unspecified).AddTicks(8644), new DateTime(2021, 3, 11, 19, 16, 35, 984, DateTimeKind.Unspecified).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Aut libero autem corporis possimus consequuntur quam.\nSequi numquam nobis quos soluta molestiae id.\nConsequatur dolores tenetur aliquid.", new DateTime(2022, 1, 31, 19, 58, 26, 44, DateTimeKind.Unspecified).AddTicks(4913), 5L, 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 26L, "Cumque unde est dolores minus quia ullam amet.\nEt voluptatibus quibusdam iusto rerum vero doloribus minima.\nSint dolores ex exercitationem officia debitis.", new DateTime(2022, 1, 3, 12, 41, 2, 819, DateTimeKind.Unspecified).AddTicks(7346), 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 50L, "Omnis quis et aut molestiae officiis.", new DateTime(2021, 9, 23, 8, 35, 30, 685, DateTimeKind.Unspecified).AddTicks(9563), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 22L, "Numquam fugiat nesciunt similique optio aut.\nPerspiciatis reprehenderit iusto dicta dolore ullam.", new DateTime(2021, 6, 10, 6, 46, 9, 977, DateTimeKind.Unspecified).AddTicks(8253), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Eius consequuntur minima qui est debitis.\nSint maiores perferendis quaerat doloribus.", new DateTime(2022, 1, 4, 10, 16, 30, 348, DateTimeKind.Unspecified).AddTicks(6856), 5L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 33L, "Sint quisquam vero qui occaecati eaque voluptas veniam.\nEt voluptatem repudiandae et quis neque ut aut.\nItaque est omnis eligendi commodi.\nExcepturi provident magni dignissimos provident nemo.\nVoluptas sed sit minus mollitia animi.", new DateTime(2021, 4, 9, 9, 57, 57, 117, DateTimeKind.Unspecified).AddTicks(1454), 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Provident quos quasi assumenda.\nDolorem et ut dolores qui quasi neque modi ex commodi.", new DateTime(2021, 3, 17, 13, 13, 36, 606, DateTimeKind.Unspecified).AddTicks(9252), 5L, 81L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Commodi optio quo modi rerum.\nUllam laboriosam omnis optio accusamus incidunt corrupti.\nAlias odio voluptas et dolorum aut suscipit earum amet.\nVero molestias et labore.\nDolorum sit itaque sunt quo dolorem autem.", new DateTime(2021, 10, 30, 15, 51, 52, 4, DateTimeKind.Unspecified).AddTicks(6718), 2L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Minus dignissimos velit recusandae id cupiditate ea harum.\nNam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.", new DateTime(2021, 2, 26, 12, 1, 35, 855, DateTimeKind.Unspecified).AddTicks(3844), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nam quia dicta eius doloribus commodi non nihil.\nQuod recusandae et est.\nDebitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.", new DateTime(2021, 10, 28, 3, 37, 20, 886, DateTimeKind.Unspecified).AddTicks(3829), 1L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Est sit at placeat optio.\nSapiente pariatur et et enim.\nAccusamus molestiae labore.", new DateTime(2021, 6, 2, 19, 19, 7, 873, DateTimeKind.Unspecified).AddTicks(6561), 4L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 3L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Earum voluptate voluptatem.\nSunt sunt est non deleniti tempore provident nihil et omnis.", new DateTime(2021, 5, 22, 23, 42, 34, 208, DateTimeKind.Unspecified).AddTicks(457), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 1L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Libero dicta temporibus atque earum.\nReprehenderit eos qui eum totam.\nId cum adipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 5L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 3L, 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 1L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 3L, 47L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 3L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 2L, 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 1L, 65L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 3L, 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 8L, "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 3L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 5L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 25L, "Ipsam minima vel totam vel deserunt ab.\nEnim dolorem aliquid aperiam quod tempore porro ad nemo sit.\nNisi quis dolore nihil.", new DateTime(2021, 3, 28, 17, 3, 2, 998, DateTimeKind.Unspecified).AddTicks(838), 3L, 81L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Non fugiat non porro vero reiciendis et.\nEnim facere autem molestiae.", new DateTime(2021, 4, 1, 7, 35, 59, 215, DateTimeKind.Unspecified).AddTicks(830), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Quo corporis voluptatem.\nQuia ut architecto adipisci quasi at aliquid voluptatum et.\nConsequatur voluptate dolor doloribus quam ipsam rerum optio.\nAperiam aperiam et.", new DateTime(2021, 12, 23, 16, 16, 38, 159, DateTimeKind.Unspecified).AddTicks(4359), 1L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Qui quam perferendis itaque dolore eligendi expedita.\nFacilis distinctio et omnis necessitatibus quibusdam rerum.\nEt qui ex itaque quam tempora quia eos.", new DateTime(2021, 5, 6, 9, 31, 38, 3, DateTimeKind.Unspecified).AddTicks(8430), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Illo a ex minus.\nDucimus qui officiis.\nDicta suscipit voluptas libero.\nTemporibus enim qui labore.", new DateTime(2021, 10, 9, 0, 43, 5, 480, DateTimeKind.Unspecified).AddTicks(7270), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Sed tempora non officiis est sit eveniet.\nArchitecto corrupti id rerum quam nesciunt assumenda odio ut maxime.\nUt animi in iste voluptatibus aliquid ut vitae.\nVelit exercitationem vero id sed quibusdam non.\nUt at ratione qui consectetur quam voluptas dolor dolorum.", new DateTime(2021, 8, 14, 13, 57, 37, 263, DateTimeKind.Unspecified).AddTicks(4946), 5L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 14L, "Quo dolor harum et maxime.\nEt ut quia ab animi occaecati beatae.\nVel autem ea molestias.\nAspernatur sunt explicabo.\nCorporis vitae porro voluptas et magni alias sit quia quia.\nImpedit maiores unde possimus aspernatur enim ea et ut.", new DateTime(2021, 9, 6, 6, 15, 51, 816, DateTimeKind.Unspecified).AddTicks(508), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 23L, "Cum illum sit corporis maiores laudantium ut.\nArchitecto aut expedita nihil et voluptatibus fugiat.\nQuisquam harum consequatur quasi ea voluptas hic dolorum.\nHarum laborum harum suscipit magnam aut.\nDolores amet tempore magni magni possimus odit quis et impedit.", new DateTime(2021, 6, 4, 11, 4, 16, 100, DateTimeKind.Unspecified).AddTicks(7149), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Dolores ea assumenda alias.", new DateTime(2021, 3, 6, 4, 28, 7, 52, DateTimeKind.Unspecified).AddTicks(1993), 1L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 48L, "Sint aliquid pariatur harum enim dolorem repellat.\nMolestiae aut nemo nihil qui sapiente non harum.\nEligendi voluptas nobis tempore.\nMolestias vel dolores aut deleniti aut minima accusamus.\nOmnis voluptatem similique.\nFacere occaecati incidunt iusto laborum ut eius id dolore.", new DateTime(2021, 4, 12, 22, 5, 28, 434, DateTimeKind.Unspecified).AddTicks(9752), 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Quam ducimus qui.\nRerum velit nulla rem.\nUllam nisi eveniet dignissimos.", new DateTime(2021, 8, 25, 1, 50, 58, 81, DateTimeKind.Unspecified).AddTicks(488), 3L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Omnis fugit aut.", new DateTime(2021, 8, 20, 8, 30, 53, 58, DateTimeKind.Unspecified).AddTicks(3331), 3L, 59L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 15L, "Qui et velit tempore et.\nQui animi dolor beatae soluta.\nEt ab explicabo eos enim consequatur omnis soluta.\nVel doloribus omnis est optio et.\nAmet et assumenda et numquam culpa.\nQuasi aspernatur tempore.", new DateTime(2021, 11, 8, 12, 17, 53, 802, DateTimeKind.Unspecified).AddTicks(2027), 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Suscipit deleniti accusamus et debitis.\nDucimus ab cum.\nPariatur architecto architecto odio maiores.", new DateTime(2021, 9, 4, 18, 46, 20, 745, DateTimeKind.Unspecified).AddTicks(6003), 1L, 30L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Dolore nihil voluptas doloremque accusantium.\nAnimi aspernatur mollitia.", new DateTime(2021, 6, 17, 15, 1, 38, 939, DateTimeKind.Unspecified).AddTicks(7420), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Eum voluptas similique quasi.\nPorro possimus repudiandae minus rerum repellat.\nNobis laboriosam qui id qui inventore illo sunt.", new DateTime(2021, 3, 27, 21, 21, 10, 234, DateTimeKind.Unspecified).AddTicks(231), 1L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Hic vitae tempora tempore et dignissimos perferendis omnis aut.", new DateTime(2021, 3, 12, 22, 52, 25, 95, DateTimeKind.Unspecified).AddTicks(9008), 2L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Excepturi mollitia vitae accusantium autem repudiandae.\nEst rem ex rerum sunt suscipit voluptatem veniam aut.\nMaiores similique assumenda tempore est inventore aut omnis.\nEt ut corporis dolorem deleniti dolorem laudantium mollitia.", new DateTime(2021, 4, 6, 19, 23, 18, 77, DateTimeKind.Unspecified).AddTicks(4489), 5L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Adipisci enim facere voluptatem sed accusamus soluta fuga qui porro.\nEx quia dolorem qui qui sed sed rem.\nConsequatur occaecati rem corporis officiis dolor aut id.\nSuscipit pariatur necessitatibus minima harum sunt ea.\nQuod omnis nobis sapiente veniam esse qui ducimus quia voluptas.", new DateTime(2021, 9, 4, 11, 28, 1, 107, DateTimeKind.Unspecified).AddTicks(3093), 4L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 3L, "Aut non tempore voluptas qui.\nLaboriosam omnis earum sit atque et.\nBeatae est magnam praesentium rerum quibusdam dignissimos temporibus voluptas.\nOdit rerum at facere itaque rem sapiente rerum.\nAspernatur ut corporis nihil ut occaecati atque exercitationem nihil molestiae.", new DateTime(2021, 5, 15, 6, 26, 4, 917, DateTimeKind.Unspecified).AddTicks(507), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Sequi reprehenderit ipsam.\nEt enim error quia quia error tenetur mollitia eligendi.\nNostrum voluptatibus magni natus assumenda quis.\nMaiores ut itaque ea et voluptatem et maxime praesentium.", new DateTime(2021, 5, 20, 9, 52, 1, 466, DateTimeKind.Unspecified).AddTicks(4088), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Est ab nemo.\nAut aspernatur dolores suscipit similique necessitatibus id voluptatem quidem.\nDolores consequatur tenetur.\nAd dolorem ipsa autem et.\nNostrum cumque praesentium.", new DateTime(2021, 9, 22, 15, 38, 2, 296, DateTimeKind.Unspecified).AddTicks(2770), 4L, 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Non sit beatae aliquam reiciendis enim tempore.\nPerferendis quis excepturi eveniet repellat tempora.\nVoluptas aut numquam eveniet et et eaque enim.\nAdipisci et ad quidem placeat earum dolor.\nDolorum voluptate molestiae nihil illo fugit aut.\nAnimi soluta accusantium.", new DateTime(2021, 10, 18, 16, 4, 44, 926, DateTimeKind.Unspecified).AddTicks(6113), 2L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Nihil qui in laudantium iste repellat ipsum veritatis praesentium.\nDeleniti eaque eaque.\nQuasi deserunt maiores ad deserunt et alias enim.", new DateTime(2021, 4, 5, 3, 11, 52, 774, DateTimeKind.Unspecified).AddTicks(511), 5L, 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Ut cumque aut.\nAut aut voluptas ex.\nVeritatis et velit aliquam.\nDeserunt illo quos maiores natus earum a velit.\nEarum cumque libero facere voluptatem saepe suscipit qui est veritatis.\nAutem omnis dicta ad.", new DateTime(2021, 5, 17, 13, 53, 22, 284, DateTimeKind.Unspecified).AddTicks(1090), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Non sit perspiciatis ex cum quidem placeat saepe ut asperiores.\nAt voluptas aperiam.\nEos magni dolor praesentium accusamus deleniti laboriosam.", new DateTime(2021, 4, 3, 10, 20, 46, 341, DateTimeKind.Unspecified).AddTicks(3427), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Facere ea provident et.\nAut minus occaecati.\nQui rem quaerat.\nEst blanditiis et aspernatur earum asperiores illo.\nSunt doloremque incidunt magnam sint dignissimos accusamus fugiat dignissimos.\nVoluptas tempore provident eos et praesentium vel.", new DateTime(2021, 2, 6, 15, 19, 18, 560, DateTimeKind.Unspecified).AddTicks(1065), 2L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nihil sed quis temporibus aut minima repellat voluptates.", new DateTime(2021, 6, 5, 6, 45, 25, 705, DateTimeKind.Unspecified).AddTicks(2833), 3L, 74L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Doloribus excepturi similique eos est.\nSaepe et qui ab unde deserunt est quis.\nLabore facere dolor.", new DateTime(2022, 1, 15, 18, 52, 37, 713, DateTimeKind.Unspecified).AddTicks(9441), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Doloribus omnis dignissimos mollitia alias omnis vitae deleniti.\nNesciunt qui voluptatem amet odio ullam.", new DateTime(2021, 6, 20, 20, 32, 47, 556, DateTimeKind.Unspecified).AddTicks(3441), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 47L, "Nostrum tempore quo quibusdam.\nNesciunt tempore qui beatae omnis earum veniam.", new DateTime(2021, 11, 8, 19, 30, 2, 744, DateTimeKind.Unspecified).AddTicks(6567), 1L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Dolorem ut quasi aut qui laudantium quibusdam ab.\nDeleniti quod blanditiis ducimus molestiae.", new DateTime(2021, 3, 17, 21, 1, 51, 218, DateTimeKind.Unspecified).AddTicks(9854), 4L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "In id voluptate saepe velit eum aut aperiam enim.\nDolorem aut perspiciatis qui quibusdam voluptatem dolorem.\nModi magnam alias omnis.\nConsectetur nulla fuga voluptas sint nostrum et quia aliquam.\nEt incidunt eius natus dolor eligendi et.", new DateTime(2021, 5, 6, 23, 34, 5, 229, DateTimeKind.Unspecified).AddTicks(3940), 4L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 21L, "Voluptates repellat harum qui dolore molestias expedita deleniti.\nNulla possimus numquam ab temporibus illo commodi maxime assumenda.", new DateTime(2022, 1, 16, 8, 12, 55, 887, DateTimeKind.Unspecified).AddTicks(2289), 4L, 74L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Cumque doloribus dolores sequi libero labore est.\nDebitis quia quo.", new DateTime(2021, 11, 1, 6, 39, 5, 620, DateTimeKind.Unspecified).AddTicks(9235), 3L, 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Voluptatem cumque eum praesentium ut magni et.\nEius perferendis aut.\nEa eaque et omnis illo.\nQuaerat perferendis quas.", new DateTime(2021, 6, 7, 9, 32, 29, 109, DateTimeKind.Unspecified).AddTicks(2186), 1L, 46L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Architecto est deleniti sit sint minus enim culpa nisi.\nFugit ex eos officia eos ducimus tempora voluptas possimus.\nDolorem nulla omnis eum sed repellat.", new DateTime(2021, 12, 11, 20, 49, 24, 536, DateTimeKind.Unspecified).AddTicks(9357), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Aut quis eum nostrum quod eum quos et sunt.\nOccaecati earum itaque libero in nihil.", new DateTime(2021, 10, 12, 9, 43, 10, 483, DateTimeKind.Unspecified).AddTicks(3703), 2L, 31L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Tempore incidunt ipsum est est occaecati vitae eius consequatur.\nCupiditate enim ut sunt.\nPariatur nihil qui enim eos eum impedit quia laborum.\nAccusamus animi tempora minus nulla consequatur alias ut ratione laborum.\nSed sunt sit aut sed officiis sunt.\nEsse fuga voluptatem dolorem nam.", new DateTime(2022, 1, 19, 13, 53, 51, 173, DateTimeKind.Unspecified).AddTicks(3509), 5L, 54L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Delectus et natus possimus omnis et.\nAtque cupiditate reprehenderit cupiditate voluptate sed sapiente nesciunt qui.\nNon ullam id excepturi dolorum consequatur velit.\nUnde est error eius amet.\nDelectus qui libero est optio natus suscipit voluptate ab.", new DateTime(2021, 2, 28, 19, 5, 13, 864, DateTimeKind.Unspecified).AddTicks(172), 3L, 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Sed eos quas dolor.\nQui id nesciunt.\nNisi eveniet ea quos tempora ratione nostrum ut suscipit occaecati.\nUt provident ipsam laudantium ipsum minima et.\nEt quia illo beatae.\nQuae et voluptates veritatis iusto.", new DateTime(2021, 2, 7, 11, 22, 22, 847, DateTimeKind.Unspecified).AddTicks(7478), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 16L, "Quibusdam sed voluptas dolor ut.\nQuia incidunt ea suscipit hic qui.\nEaque laborum omnis molestiae corrupti ut voluptas.\nIllum illo dignissimos quibusdam ut.\nEum consectetur vel voluptas.", new DateTime(2021, 6, 3, 20, 57, 51, 343, DateTimeKind.Unspecified).AddTicks(7626), 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 10L, "Fuga ut non alias qui tempore.\nAspernatur pariatur commodi voluptatem qui eum numquam quod placeat et.\nReiciendis ratione qui.\nLibero neque nostrum eaque accusantium consequatur.\nPossimus sed quis facilis quia corporis qui nihil.\nRem qui vitae ut hic officiis quia consequatur consequatur.", new DateTime(2021, 2, 15, 1, 3, 50, 196, DateTimeKind.Unspecified).AddTicks(6476), 48L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 50L, "Qui ipsa et soluta consequatur impedit dolor est.", new DateTime(2021, 4, 6, 0, 15, 0, 666, DateTimeKind.Unspecified).AddTicks(3684), 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Inventore repudiandae animi quae.\nSed quo et.\nEt autem a.\nIncidunt eos nihil dolores temporibus.", new DateTime(2021, 10, 21, 20, 52, 38, 231, DateTimeKind.Unspecified).AddTicks(8015), 5L, 56L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Laboriosam consequuntur est dolores sed repudiandae.", new DateTime(2021, 4, 4, 18, 42, 21, 652, DateTimeKind.Unspecified).AddTicks(9924), 3L, 5L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Maiores corrupti itaque laudantium pariatur.\nDoloribus vel rerum velit nihil omnis temporibus ut exercitationem.\nExercitationem sapiente aliquid est vero.\nImpedit eveniet pariatur laboriosam.\nDolores in placeat in blanditiis voluptatum est iusto est at.", new DateTime(2021, 10, 18, 11, 35, 38, 665, DateTimeKind.Unspecified).AddTicks(3588), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Molestiae nihil eos impedit in dolorum omnis.\nMollitia deleniti reiciendis qui pariatur dolor eaque et molestias.", new DateTime(2021, 12, 14, 12, 15, 47, 755, DateTimeKind.Unspecified).AddTicks(9340), 2L, 70L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 30L, "Architecto dolor odit est ducimus tempora consequuntur minima atque laborum.", new DateTime(2021, 5, 19, 8, 26, 26, 321, DateTimeKind.Unspecified).AddTicks(5379), 1L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Sint voluptatem repellat aut aut.\nNumquam officia accusamus vel ducimus voluptas voluptatem.\nAut dignissimos sint minus et non.\nAut odit cupiditate totam velit dolores.", new DateTime(2021, 3, 30, 21, 30, 24, 45, DateTimeKind.Unspecified).AddTicks(3023), 1L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iusto laboriosam numquam eos quia asperiores sunt delectus sint omnis.\nOmnis et sit quae animi sed et praesentium.\nOdit eveniet perspiciatis sint voluptatum suscipit est consequatur.\nUllam accusamus ut ut qui dolorem.\nQuibusdam corporis impedit.\nQuos natus tenetur adipisci rem maxime libero sit.", new DateTime(2021, 12, 14, 6, 12, 27, 982, DateTimeKind.Unspecified).AddTicks(9982), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 35L, "Assumenda sed quibusdam exercitationem distinctio.\nEius similique sed numquam voluptates nam labore ut consectetur.\nAut vel sequi quisquam voluptatem perspiciatis rerum ut dignissimos minus.", new DateTime(2021, 11, 4, 1, 54, 34, 308, DateTimeKind.Unspecified).AddTicks(5223), 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Officia ad soluta nostrum ullam et facilis quo.", new DateTime(2021, 5, 8, 5, 13, 27, 480, DateTimeKind.Unspecified).AddTicks(7761), 1L, 76L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Molestias voluptatem asperiores et autem ex voluptatibus distinctio sed.\nDeserunt ducimus pariatur non.", new DateTime(2021, 10, 18, 17, 12, 20, 582, DateTimeKind.Unspecified).AddTicks(5471), 1L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Beatae sapiente nam ut.", new DateTime(2021, 10, 8, 19, 16, 13, 405, DateTimeKind.Unspecified).AddTicks(388), 1L, 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Occaecati quia veritatis quidem.\nUt mollitia inventore accusamus.", new DateTime(2021, 12, 6, 11, 53, 10, 114, DateTimeKind.Unspecified).AddTicks(9770), 5L, 62L });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 11, 30, 19, 42, 13, 232, DateTimeKind.Unspecified).AddTicks(5878), 1L, 833, true, 59L, null, 418 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 43L, new DateTime(2021, 5, 2, 19, 58, 43, 511, DateTimeKind.Unspecified).AddTicks(8277), 3L, 825, false, 44L, 242 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 4, 15, 7, 39, 39, 832, DateTimeKind.Unspecified).AddTicks(5548), 714, null, 45L, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 5, 14, 9, 14, 57, 321, DateTimeKind.Unspecified).AddTicks(4409), 5L, 890, 27L, null, 312 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 9, 6, 16, 36, 51, 263, DateTimeKind.Unspecified).AddTicks(3373), 827, 18L, 136 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 5, 18, 20, 30, 16, 105, DateTimeKind.Unspecified).AddTicks(3852), 5L, 745, 34L, 55 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 7, 1, 0, 21, 55, 515, DateTimeKind.Unspecified).AddTicks(3758), 3L, 858, 3L, 324 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 8, 27, 16, 6, 30, 905, DateTimeKind.Unspecified).AddTicks(750), 1L, 613, true, 40L, 337 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 3, 13, 14, 48, 23, 796, DateTimeKind.Unspecified).AddTicks(8809), 1L, 625, null, 48L, 177 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 5, 2, 21, 21, 42, 67, DateTimeKind.Unspecified).AddTicks(2039), 1L, 584, false, 75L, null, 374 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 6, 6, 12, 42, 30, 100, DateTimeKind.Unspecified).AddTicks(1705), 1L, 739, true, 35L, 424 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 8, 20, 4, 35, 10, 372, DateTimeKind.Unspecified).AddTicks(6151), 761, true, 56L, null, 475 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2022, 1, 26, 5, 34, 51, 586, DateTimeKind.Unspecified).AddTicks(4248), 1L, 933, 62L, 356 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 8, 8, 8, 25, 42, 279, DateTimeKind.Unspecified).AddTicks(490), 5L, 854, 47L, 30 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 7, 14, 8, 5, 34, 518, DateTimeKind.Unspecified).AddTicks(5505), 3L, 571, 36L, 85 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 5, 25, 13, 46, 27, 478, DateTimeKind.Unspecified).AddTicks(2316), 937, false, 16L, 223 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 8, 7, 5, 26, 46, 591, DateTimeKind.Unspecified).AddTicks(6302), 5L, 534, 43L, 445 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 21L, new DateTime(2021, 8, 15, 23, 39, 32, 443, DateTimeKind.Unspecified).AddTicks(3908), 4L, 628, true, 25L, 13 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 5, 19, 0, 7, 53, 342, DateTimeKind.Unspecified).AddTicks(3533), 1L, 544, 14L, 333 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 4, 24, 14, 20, 26, 871, DateTimeKind.Unspecified).AddTicks(7976), 1L, 596, null, 20L, 96 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 7, 17, 17, 9, 19, 650, DateTimeKind.Unspecified).AddTicks(7584), 5L, 799, 56L, null, 65 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 10, 17, 19, 10, 37, 695, DateTimeKind.Unspecified).AddTicks(4132), 776, 51L, 194 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2021, 9, 20, 1, 48, 49, 30, DateTimeKind.Unspecified).AddTicks(3708), 5L, 752, 16L, 21 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 8, 14, 4, 36, 46, 590, DateTimeKind.Unspecified).AddTicks(373), 675, true, null, 14L, 408 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2022, 1, 13, 20, 36, 45, 56, DateTimeKind.Unspecified).AddTicks(8062), 1L, 899, 11L, 193 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 12, 31, 5, 30, 24, 374, DateTimeKind.Unspecified).AddTicks(5166), 1L, 557, false, null, 46L, 19 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2022, 1, 5, 5, 21, 58, 235, DateTimeKind.Unspecified).AddTicks(368), 570, 62L, null, 134 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 9, 16, 21, 9, 19, 247, DateTimeKind.Unspecified).AddTicks(6961), 635, 75L, 190 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 31L, new DateTime(2021, 5, 1, 18, 56, 4, 448, DateTimeKind.Unspecified).AddTicks(4092), 1L, 647, null, 51L, 388 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2021, 5, 24, 0, 53, 24, 429, DateTimeKind.Unspecified).AddTicks(1303), 3L, 946, 59L, null, 12 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 11, 11, 4, 12, 22, 825, DateTimeKind.Unspecified).AddTicks(9786), 2L, 612, 26L, null, 293 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 3, 27, 12, 59, 9, 343, DateTimeKind.Unspecified).AddTicks(2725), 1L, 746, null, 34L, 164 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 11, 30, 8, 14, 8, 747, DateTimeKind.Unspecified).AddTicks(7873), 2L, 952, null, 27L, 403 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 5, 26, 0, 40, 43, 540, DateTimeKind.Unspecified).AddTicks(3180), 2L, 627, 56L, null, 89 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2022, 1, 2, 18, 0, 19, 199, DateTimeKind.Unspecified).AddTicks(9260), 5L, 620, null, 29L, 129 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 11, 13, 20, 56, 51, 280, DateTimeKind.Unspecified).AddTicks(2782), 5L, 735, true, 10L, 406 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 12, 12, 3, 59, 9, 521, DateTimeKind.Unspecified).AddTicks(4097), 5L, 550, false, 34L, null, 100 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 6, 24, 13, 36, 45, 269, DateTimeKind.Unspecified).AddTicks(5607), 4L, 949, true, 33L, 186 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 8, 5, 20, 21, 19, 50, DateTimeKind.Unspecified).AddTicks(2413), 5L, 553, null, 38L, 141 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 10, 14, 3, 59, 29, 854, DateTimeKind.Unspecified).AddTicks(7534), 5L, 599, true, null, 49L, 108 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 7, 10, 18, 13, 8, 141, DateTimeKind.Unspecified).AddTicks(3199), 4L, 679, false, 7L, 177 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 5, 16, 9, 48, 5, 496, DateTimeKind.Unspecified).AddTicks(9785), 1L, 817, null, 12L, 414 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2022, 1, 13, 14, 5, 28, 892, DateTimeKind.Unspecified).AddTicks(2382), 4L, 814, true, 58L, 239 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 7, 8, 1, 55, 38, 777, DateTimeKind.Unspecified).AddTicks(4142), 1L, 627, null, 5L, 208 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 4, 24, 14, 50, 10, 934, DateTimeKind.Unspecified).AddTicks(5417), 547, false, 37L, 177 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 6, 23, 6, 33, 47, 750, DateTimeKind.Unspecified).AddTicks(665), 4L, 686, null, 26L, 187 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 5, 28, 8, 2, 28, 245, DateTimeKind.Unspecified).AddTicks(9337), 1L, 930, 26L, null, 175 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 2, 7, 20, 36, 15, 421, DateTimeKind.Unspecified).AddTicks(8834), 1L, 986, false, 22L, 500 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 8, 1, 3, 10, 2, 338, DateTimeKind.Unspecified).AddTicks(4803), 1L, 882, 58L, null, 67 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 11, 27, 4, 11, 38, 205, DateTimeKind.Unspecified).AddTicks(9430), 1L, 776, true, 66L, 353 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 11, 14, 16, 30, 33, 958, DateTimeKind.Unspecified).AddTicks(6848), 2L, 967, 55L, null, 282 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 8, 17, 11, 15, 57, 251, DateTimeKind.Unspecified).AddTicks(6898), 5L, 659, true, null, 21L, 435 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 5, 2, 16, 19, 51, 806, DateTimeKind.Unspecified).AddTicks(7461), 5L, 884, 69L, 170 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 3, 22, 12, 26, 13, 437, DateTimeKind.Unspecified).AddTicks(4732), 1L, 832, false, 67L, 296 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 4, 11, 21, 15, 19, 985, DateTimeKind.Unspecified).AddTicks(4700), 500, false, 75L, 466 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 10, 13, 7, 0, 11, 813, DateTimeKind.Unspecified).AddTicks(5331), 1L, 525, true, 14L, 366 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 12, 12, 8, 1, 24, 416, DateTimeKind.Unspecified).AddTicks(6279), 549, null, 42L, 486 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 7, 16, 2, 55, 6, 99, DateTimeKind.Unspecified).AddTicks(2051), 4L, 779, 2L, 267 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 9, 15, 19, 49, 17, 43, DateTimeKind.Unspecified).AddTicks(2846), 764, true, 28L, 25 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 6, 20, 4, 37, 21, 162, DateTimeKind.Unspecified).AddTicks(5716), 4L, 563, null, 16L, 362 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2022, 1, 30, 22, 51, 28, 609, DateTimeKind.Unspecified).AddTicks(4640), 5L, 668, null, 41L, 469 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 8, 3, 4, 27, 9, 542, DateTimeKind.Unspecified).AddTicks(9558), 544, 16L, null, 46 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 5, 3, 17, 58, 21, 678, DateTimeKind.Unspecified).AddTicks(4552), 532, false, null, 31L, 289 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2022, 1, 9, 4, 9, 7, 299, DateTimeKind.Unspecified).AddTicks(4591), 745, 74L, null, 147 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 9, 17, 23, 41, 55, 303, DateTimeKind.Unspecified).AddTicks(5695), 1L, 673, false, 5L, null, 440 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 4, 22, 12, 53, 26, 301, DateTimeKind.Unspecified).AddTicks(3993), 4L, 621, false, 19L, 427 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2022, 1, 16, 17, 2, 10, 670, DateTimeKind.Unspecified).AddTicks(9486), 5L, 994, true, 16L, 426 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 6, 4, 22, 39, 8, 214, DateTimeKind.Unspecified).AddTicks(3648), 961, null, 3L, 329 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 43L, new DateTime(2021, 2, 11, 16, 37, 12, 617, DateTimeKind.Unspecified).AddTicks(336), 5L, 878, 18L, 484 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 11, 19, 17, 29, 32, 755, DateTimeKind.Unspecified).AddTicks(219), 5L, 843, false, null, 27L, 456 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 8, 4, 0, 22, 9, 736, DateTimeKind.Unspecified).AddTicks(4614), 4L, 659, 68L, 71 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 4, 17, 11, 35, 22, 258, DateTimeKind.Unspecified).AddTicks(6081), 3L, 711, 11L, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 7, 29, 2, 32, 0, 723, DateTimeKind.Unspecified).AddTicks(536), 4L, 928, 72L, null, 214 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 2, 9, 13, 58, 2, 175, DateTimeKind.Unspecified).AddTicks(9324), 2L, 532, false, 38L, null, 423 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 9L, new DateTime(2021, 4, 5, 21, 34, 28, 154, DateTimeKind.Unspecified).AddTicks(9419), 3L, 647, true, 39L, null, 24 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2022, 1, 23, 21, 59, 56, 59, DateTimeKind.Unspecified).AddTicks(1074), 2L, 655, true, null, 7L, 369 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 3, 3, 14, 43, 13, 110, DateTimeKind.Unspecified).AddTicks(3744), 797, 33L, 53 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 4, 11, 18, 16, 21, 69, DateTimeKind.Unspecified).AddTicks(6640), 642, 19L, 496 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 8, 27, 15, 18, 8, 939, DateTimeKind.Unspecified).AddTicks(5225), 3L, 596, null, 32L, 52 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 3, 26, 16, 33, 11, 514, DateTimeKind.Unspecified).AddTicks(7001), 1L, 519, true, null, 42L, 315 });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_OwnerId",
                table: "Projects",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
