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

            migrationBuilder.DropTable(
                name: "InvitedUsers");

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
                keyValues: new object[] { 4L, 16L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 4L, 26L });

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
                keyValues: new object[] { 6L, 22L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 37L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 5L });

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
                keyValues: new object[] { 11L, 26L });

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
                keyValues: new object[] { 13L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 34L });

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
                keyValues: new object[] { 3L, 8L },
                column: "Id",
                value: 70L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 4L, 1L },
                column: "Id",
                value: 18L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 17L },
                column: "Id",
                value: 38L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 9L, 6L },
                column: "Id",
                value: 39L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 13L, 22L },
                column: "Id",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 15L, 10L },
                column: "Id",
                value: 77L);

            migrationBuilder.InsertData(
                table: "AppTags",
                columns: new[] { "AppId", "TagId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 2L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 12L, false },
                    { 2L, 25L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 26L, false },
                    { 2L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 55L, false },
                    { 2L, 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 34L, false },
                    { 5L, 25L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 62L, false },
                    { 6L, 3L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 78L, false },
                    { 6L, 11L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 66L, false },
                    { 6L, 32L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 15L, false },
                    { 6L, 33L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 63L, false },
                    { 7L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 27L, false },
                    { 7L, 9L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 28L, false },
                    { 8L, 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 79L, false },
                    { 8L, 7L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 65L, false },
                    { 8L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 68L, false },
                    { 8L, 13L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 24L, false },
                    { 8L, 15L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 5L, false },
                    { 8L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 57L, false },
                    { 8L, 18L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 40L, false },
                    { 8L, 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 76L, false },
                    { 9L, 13L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 51L, false },
                    { 9L, 18L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 20L, false },
                    { 11L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 46L, false },
                    { 11L, 32L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 22L, false },
                    { 11L, 35L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 74L, false },
                    { 11L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 49L, false },
                    { 12L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 71L, false },
                    { 12L, 31L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 75L, false },
                    { 13L, 2L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 47L, false },
                    { 13L, 13L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 36L, false },
                    { 14L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 50L, false },
                    { 14L, 35L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 21L, false },
                    { 15L, 4L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 33L, false },
                    { 15L, 25L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 2L, false },
                    { 16L, 11L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 8L, false },
                    { 16L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 31L, false },
                    { 16L, 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 69L, false }
                });

            migrationBuilder.InsertData(
                table: "AppTags",
                columns: new[] { "AppId", "TagId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 16L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 44L, false },
                    { 17L, 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 60L, false },
                    { 17L, 12L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 41L, false },
                    { 17L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 35L, false },
                    { 18L, 10L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 25L, false },
                    { 19L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 61L, false },
                    { 20L, 14L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 32L, false },
                    { 20L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 9L, false },
                    { 21L, 9L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 14L, false },
                    { 21L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 4L, false },
                    { 22L, 7L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 58L, false },
                    { 22L, 10L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 81L, false },
                    { 22L, 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 10L, false },
                    { 22L, 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 42L, false },
                    { 23L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 37L, false },
                    { 23L, 16L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 29L, false },
                    { 24L, 18L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 67L, false },
                    { 24L, 27L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 59L, false },
                    { 24L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 13L, false },
                    { 25L, 2L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 72L, false },
                    { 25L, 32L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 45L, false },
                    { 25L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 6L, false },
                    { 26L, 4L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 52L, false },
                    { 26L, 10L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 23L, false },
                    { 26L, 27L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L, false },
                    { 27L, 11L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 43L, false },
                    { 27L, 23L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 7L, false },
                    { 28L, 25L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 53L, false },
                    { 28L, 29L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 73L, false },
                    { 29L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 30L, false },
                    { 29L, 11L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 19L, false },
                    { 30L, 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 54L, false },
                    { 30L, 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 3L, false },
                    { 30L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 16L, false },
                    { 31L, 21L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 56L, false },
                    { 31L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 64L, false },
                    { 31L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 17L, false },
                    { 31L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 48L, false }
                });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c4c785c6-e6a9-fd0e-59a7-bb328037417c"), new DateTime(2021, 12, 6, 11, 53, 10, 114, DateTimeKind.Unspecified).AddTicks(9770), 5L, "Vel sequi quisquam voluptatem perspiciatis rerum ut dignissimos minus.\nOfficia iste dolore magni minus officia ad soluta.\nUllam et facilis quo occaecati.\nAccusantium quod quis aut molestias voluptatem asperiores et autem ex.\nDistinctio sed tempora deserunt ducimus pariatur non sed harum aut.\nDicta dolor beatae sapiente nam.", "Eius similique sed numquam voluptates nam labore ut consectetur.", 79L, "real-timeSouth Carolinamonitoring", 39L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("77f04c2e-c112-f632-b0e8-aec7a28d7866"), new DateTime(2021, 12, 11, 16, 15, 40, 198, DateTimeKind.Unspecified).AddTicks(7363), "Saepe nihil iure iure numquam nihil.\nEaque hic quam enim nihil voluptatem aut non sed.\nDistinctio blanditiis nobis ipsam nemo repellendus omnis tenetur voluptates.\nEligendi et quia et qui sunt totam voluptatem.", "Minus et aut qui perspiciatis et explicabo pariatur quasi amet.", 42L, "Uzbekistan SumpaymentPersonal Loan Account", 38L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("5cdc7e05-2269-3418-9c46-4779b03bcd9d"), new DateTime(2021, 5, 13, 18, 27, 59, 288, DateTimeKind.Unspecified).AddTicks(4078), 5L, "Ut laudantium laboriosam voluptatum quia enim.\nEarum magnam est sequi reprehenderit.", "Dolorum est suscipit nobis ut praesentium eveniet sit.", 21L, "InternalGroveBeauty", 51L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c6e98ccf-944a-506a-7c0c-c30b8c011442"), new DateTime(2021, 11, 5, 16, 17, 32, 176, DateTimeKind.Unspecified).AddTicks(6846), "Officiis modi commodi et.\nMolestiae ullam explicabo totam veniam voluptatem sed dolor.\nEt odio maxime enim et molestiae quia.\nAperiam facilis et eum voluptas accusamus sequi.", "Et neque aut vitae et non.", 14L, "analyzingNakfa", 35L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("7cc93ac6-320c-ae66-5a55-bed3220d008e"), new DateTime(2021, 9, 27, 21, 16, 24, 348, DateTimeKind.Unspecified).AddTicks(1063), 4L, "Nulla quibusdam voluptates esse sint.\nAlias fugit facere.\nFugit ullam quisquam et.", "Et dolore officia molestiae itaque similique similique voluptas.", 24L, "turn-keycapacityElectronics", 40L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("cad131cb-c98b-059a-f530-b32b5ecf7e16"), new DateTime(2021, 4, 13, 15, 4, 15, 213, DateTimeKind.Unspecified).AddTicks(6882), "Repellendus et voluptatem consequatur quos eligendi aut.", "Nesciunt et unde rerum id.", 101L, "PlazaInternational", 33L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("9f77ab6e-b6a8-47f3-7b2d-3ec949977b90"), new DateTime(2021, 4, 9, 14, 49, 47, 476, DateTimeKind.Unspecified).AddTicks(8133), 2L, "Non voluptate ut velit voluptatem earum quae.\nAliquam voluptatum voluptatem dolor dolorum quia consequatur dolores rerum optio.\nMolestias officiis necessitatibus placeat ut.\nVel consequuntur quaerat nostrum ad voluptatem saepe vel id.\nIncidunt blanditiis est dolorem mollitia nulla.", "Culpa adipisci adipisci quo et qui architecto harum deleniti.", 68L, "VermontManager", 18L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c049b115-7872-31ac-0235-542d533817a9"), new DateTime(2021, 11, 30, 13, 34, 1, 798, DateTimeKind.Unspecified).AddTicks(9928), 4L, "Laborum iure optio dicta.\nMaxime provident eveniet.\nSunt repellendus veniam eum dolor inventore molestiae aut fugiat.\nEt natus et id.\nRepudiandae voluptate quam dolorum saepe cumque velit et totam aspernatur.\nIn itaque saepe quis.", "Ad provident qui distinctio vel itaque praesentium et.", 98L, "Personal Loan AccountForkimplementRAM", 34L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("a27d502a-9e22-4868-8ea4-a02190f60164"), new DateTime(2021, 11, 6, 4, 49, 57, 563, DateTimeKind.Unspecified).AddTicks(6995), 2L, "Cumque totam sit molestias id sunt labore ut quam et.", "Corrupti beatae praesentium nam qui odio et ipsum.", 18L, "ubiquitousToolsForwardhard drive", 50L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("179ca5de-a60d-4149-c2da-a44e368bf846"), new DateTime(2021, 7, 2, 4, 18, 57, 767, DateTimeKind.Unspecified).AddTicks(2685), 1L, "Ex voluptas voluptatum eveniet voluptas.\nReiciendis ipsa id qui explicabo beatae est nulla.\nMinima rerum dolor eveniet enim reprehenderit.\nQuisquam sit aperiam et non reprehenderit.\nHarum nam ipsa aperiam error.\nIn atque atque repudiandae rerum et quisquam.", "Iure et cum unde enim sit.", 88L, "Buckinghamshirezero administrationprogramming", 37L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b84671c0-1654-2d1d-d18a-a08ea72d9821"), new DateTime(2021, 7, 21, 10, 37, 44, 742, DateTimeKind.Unspecified).AddTicks(6590), "Rerum ex laboriosam fuga sed laudantium voluptates reiciendis.\nSit nihil voluptas pariatur modi vel.\nVoluptatem accusamus quia et ut rerum similique.", "Voluptatum sunt tempora est maiores repellat eveniet aut provident est.", 81L, "ErgonomicSmall Steel GlovesTools, Computers & Computerssynthesize", 45L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c08938ee-0914-8e7b-ad06-3a40bfb4e8d0"), new DateTime(2021, 10, 20, 13, 27, 22, 914, DateTimeKind.Unspecified).AddTicks(8959), 4L, "Doloribus numquam ad voluptatem magni minima expedita aliquam fugit.\nPerspiciatis est sequi corrupti consequatur eum.\nSunt voluptate minima.\nQuia aut molestiae ut iste nihil eos perferendis.\nInventore voluptatibus accusamus.", "Nostrum impedit nam et non ea eligendi.", 6L, "RSSPNG", 28L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("46f59a4c-e0f0-61bb-a08f-1c1a4790cc6b"), new DateTime(2021, 12, 5, 20, 1, 37, 845, DateTimeKind.Unspecified).AddTicks(6639), 2L, "Sapiente accusamus praesentium aut voluptatem facilis sunt eum.\nQuia beatae esse velit alias ut deserunt ad.\nCommodi dolorum ut id libero consectetur doloribus in.", "Asperiores quis error at.", 46L, "Licensed Wooden Pizzafront-endsynthesizing", 34L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("75a0f507-f23e-90a7-ed25-4646fb781bb6"), new DateTime(2021, 7, 24, 7, 12, 3, 836, DateTimeKind.Unspecified).AddTicks(9094), 4L, "Eaque placeat soluta odit temporibus cupiditate et.\nEt est voluptatibus ullam accusantium sint eum.\nIllo aspernatur hic voluptatibus temporibus omnis qui repellendus.\nReiciendis et possimus eum veritatis aliquam molestias at.", "Minus modi velit ut sit facere et porro deleniti.", 2L, "open-sourcepartnershipsXML", 39L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("fc47587e-10a0-e46c-a87c-5bf64d484c10"), new DateTime(2021, 11, 30, 10, 43, 46, 979, DateTimeKind.Unspecified).AddTicks(5195), "Quis et architecto eum atque error fuga eaque maxime.\nBlanditiis similique quis voluptatem quidem reiciendis dolore voluptatem maxime.\nDicta et tempore sequi at quia.", "Quod dolor odio reprehenderit voluptatum dignissimos earum nobis.", 71L, "connectHumanStation", 2L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("4be364cd-23ea-4190-0143-fd8857c07932"), new DateTime(2022, 1, 11, 20, 57, 26, 280, DateTimeKind.Unspecified).AddTicks(3700), "Voluptas voluptatem in autem autem magni rerum harum cupiditate.", "Rerum sint non commodi.", 86L, "SoftBedfordshirePersonal Loan AccountQuality", 30L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("9ca2a5b2-fadb-55af-f0bc-9b62fc41df56"), new DateTime(2021, 2, 25, 22, 37, 2, 396, DateTimeKind.Unspecified).AddTicks(4191), "Sed quod ducimus in ad doloremque pariatur.\nOfficia possimus maiores.", "Voluptatum vel soluta quia sed aut.", 32L, "East Caribbean DollarCentralPractical", 33L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b8798048-2bb2-5776-55d9-11d30d83ebf1"), new DateTime(2021, 7, 7, 14, 14, 6, 876, DateTimeKind.Unspecified).AddTicks(7554), 2L, "Maiores quo praesentium non ipsa enim blanditiis.\nEt unde velit.\nDolorem amet eos non rem.", "Accusamus quia qui aut qui laudantium ea et fugit.", 41L, "SteelCornersMetalgenerate", 42L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("8a73ddb7-1ce8-64cd-44b7-2d5cad620f05"), new DateTime(2021, 2, 7, 22, 31, 37, 167, DateTimeKind.Unspecified).AddTicks(6861), 4L, "Architecto minima temporibus quaerat id cum necessitatibus.\nIusto consequatur officia ex beatae temporibus facilis.", "Sint deserunt sed non qui nam dignissimos placeat molestias ut.", 94L, "Licensed Concrete FishSQLWay", 20L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("248ae82d-b546-e978-c077-a704bcbea16e"), new DateTime(2021, 11, 26, 0, 12, 29, 662, DateTimeKind.Unspecified).AddTicks(2387), "Et nesciunt esse perferendis aut neque impedit voluptatem.\nIure aperiam incidunt autem inventore distinctio doloribus.\nAut quia in natus ullam.\nEius sit deserunt error architecto veritatis tempora.", "Unde alias dolor at autem sit.", 69L, "supply-chainsmiddlewareMichigan", 26L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c0079e8b-d227-16f5-e5ab-d8c5acbaf661"), new DateTime(2021, 12, 27, 9, 47, 39, 765, DateTimeKind.Unspecified).AddTicks(722), "Saepe velit occaecati vero libero.\nIpsa omnis fugiat possimus nobis explicabo ut laboriosam nobis asperiores.\nArchitecto minus debitis nobis molestias itaque quos temporibus assumenda sit.\nMolestiae iste assumenda beatae molestias laudantium laboriosam laboriosam tempore.\nQui ducimus qui asperiores sequi qui sed ab vitae.\nExcepturi quo et occaecati.", "Eum esse mollitia quidem.", 101L, "AgentCustomizableHome Loan Account", 19L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("7ead84a0-d0ae-e666-aa45-34be0347fa3a"), new DateTime(2021, 10, 2, 18, 22, 6, 898, DateTimeKind.Unspecified).AddTicks(4864), 2L, "A beatae facilis placeat et id at consequatur aut.\nRecusandae totam consequatur magnam.\nOccaecati in voluptatem et.", "Tenetur quod est recusandae et sunt inventore magnam dolor.", 28L, "object-orientedNew Israeli Sheqel", 35L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("11ff1838-1312-1343-c8f1-4df5339ca690"), new DateTime(2022, 1, 13, 0, 53, 58, 471, DateTimeKind.Unspecified).AddTicks(8746), 4L, "Quam impedit sapiente aut fugiat nam esse.\nNemo omnis non saepe voluptas quae non.\nRem mollitia unde.\nIllo illo non sunt ut delectus omnis facere accusamus.", "Beatae similique distinctio maiores natus architecto molestiae recusandae.", 20L, "FTPBordersClothing", 38L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("b7b48e2e-2975-cef4-5a6d-b2f85b9dee79"), new DateTime(2021, 6, 17, 12, 26, 32, 980, DateTimeKind.Unspecified).AddTicks(7588), 1L, "Modi voluptatum aut et minus sed corporis atque.\nOdit id deserunt sed dicta et.\nRepellendus labore itaque cumque autem deleniti ut.\nAt mollitia error dignissimos quo incidunt fuga optio.", "Accusamus quo et fugit.", 58L, "HighwayextendGuinea-Bissau", 14L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("f64aaeec-eb08-1034-10c6-795ef0189132"), new DateTime(2022, 1, 28, 14, 25, 11, 576, DateTimeKind.Unspecified).AddTicks(6305), 2L, "Doloremque expedita nisi.\nEt voluptas et odio.\nCommodi minima maxime beatae est dolorum veniam debitis praesentium dolor.", "Iure eos omnis eos assumenda dolorem.", 33L, "Functionalityfirewall", 48L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("1399410e-0bed-f3b6-3343-156d8eeefde4"), new DateTime(2021, 10, 1, 21, 22, 7, 929, DateTimeKind.Unspecified).AddTicks(9081), 5L, "Aliquam magnam quis iure et.", "Occaecati enim maiores nemo doloribus deleniti sint et.", 19L, "innovateHealth, Shoes & Home", 36L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("a95cdcf4-d88d-45a0-5abf-9f64c601dbdb"), new DateTime(2021, 3, 11, 7, 9, 12, 88, DateTimeKind.Unspecified).AddTicks(923), "Accusantium accusamus est nulla nemo aut beatae iste rem.\nDolorem sequi consectetur.\nMinus eum minus perferendis.", "Repellat ut tenetur est eius possimus dolorem voluptatem eius et.", 3L, "ChiefGorgeous Steel FishmaximizedSoft", 21L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("fd4893ed-eba1-4bd9-8e19-3fcaa60334bc"), new DateTime(2021, 10, 15, 20, 15, 36, 186, DateTimeKind.Unspecified).AddTicks(8021), 2L, "Quia quia maiores aliquam.\nNumquam aliquid corrupti distinctio.", "Voluptatem odio provident.", 16L, "auxiliaryturquoiseGroupmulti-byte", 43L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("539f6ff9-a14a-cb58-311b-d197543466a0"), new DateTime(2022, 1, 30, 18, 58, 24, 273, DateTimeKind.Unspecified).AddTicks(1186), "Reprehenderit sint non perferendis suscipit.\nLaudantium fugiat nobis.\nCumque dolorem adipisci aut eligendi ea.\nVoluptatem iure reiciendis consectetur voluptatem quaerat voluptates.", "Qui velit soluta.", 92L, "BridgeCustomersuperstructure", 25L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("2c05caa7-6520-7759-3534-e08bcffbd931"), new DateTime(2021, 7, 11, 19, 51, 47, 631, DateTimeKind.Unspecified).AddTicks(7658), 4L, "Et et soluta quos id unde possimus cupiditate debitis.", "Natus dolor nostrum est aut consequuntur aliquam dolorum.", 66L, "indexBedfordshire", 45L });

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
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 12, 29, 7, 40, 52, 112, DateTimeKind.Unspecified).AddTicks(5490), 2L, "Maiores et natus qui placeat unde.\nError est aut maiores qui dolores.\nQuo dolores beatae qui.", new DateTime(2023, 4, 27, 11, 41, 42, 405, DateTimeKind.Unspecified).AddTicks(6109), 40L, "Illum molestias enim facilis beatae.", 31L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 8, 26, 9, 55, 48, 462, DateTimeKind.Unspecified).AddTicks(3211), 5L, "Sunt nihil inventore provident laboriosam.\nBlanditiis corrupti ut.\nVoluptatum ut voluptatem rerum suscipit adipisci vitae voluptatibus aut ut.\nLaudantium aut expedita.\nVoluptatem repellendus impedit harum vitae autem eos.", new DateTime(2023, 9, 21, 0, 41, 30, 866, DateTimeKind.Unspecified).AddTicks(7159), 35L, "Laudantium dicta cumque.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 12, 12, 18, 33, 47, 851, DateTimeKind.Unspecified).AddTicks(5546), 1L, "Ea et eum aut eligendi cum non aut ut ea.\nConsectetur suscipit placeat vero blanditiis et et dicta repellendus rem.\nPossimus voluptate atque harum et sapiente.\nSit autem sunt autem ut corporis.", new DateTime(2023, 7, 4, 4, 30, 56, 122, DateTimeKind.Unspecified).AddTicks(6965), true, 18L, "Dolorum aspernatur beatae dolorum minima et.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 10, 31, 5, 17, 6, 9, DateTimeKind.Unspecified).AddTicks(1826), 3L, "Rerum dolorem aut dolorum veritatis veritatis.\nQuisquam quisquam accusantium at.\nEt dignissimos ratione facere ut ducimus rerum praesentium dolorem.\nEst cum dolor officia maxime porro.\nDolor quo cum iure corrupti ea perspiciatis est et.", new DateTime(2022, 4, 19, 21, 44, 43, 67, DateTimeKind.Unspecified).AddTicks(1973), 2L, "Aperiam minus nemo ipsa accusamus et fuga consequatur nam velit.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 10, 8, 12, 44, 35, 359, DateTimeKind.Unspecified).AddTicks(6803), 5L, "Dolore totam odio ullam odio voluptatum ipsam.\nA ut ipsam dolor molestiae rerum dicta.\nAccusantium optio nisi et vel qui modi.", new DateTime(2023, 7, 10, 2, 31, 4, 845, DateTimeKind.Unspecified).AddTicks(9879), false, 33L, "Est molestiae explicabo accusamus expedita numquam.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 8, 3, 8, 31, 20, 83, DateTimeKind.Unspecified).AddTicks(2921), 4L, "Omnis unde fuga porro eligendi optio veritatis nam.\nQuos voluptas sapiente officiis id.", new DateTime(2022, 5, 23, 13, 48, 15, 643, DateTimeKind.Unspecified).AddTicks(9697), 39L, "Dolores quia at et necessitatibus aut molestiae.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 2, 6, 3, 42, 19, 743, DateTimeKind.Unspecified).AddTicks(4625), 1L, "Aut fugiat sapiente molestias voluptatem aut fuga enim.\nDolores ab natus fuga animi nihil culpa est vel molestiae.\nMagni voluptas rerum natus eligendi debitis.", new DateTime(2023, 7, 13, 17, 55, 32, 436, DateTimeKind.Unspecified).AddTicks(8867), false, 14L, "Et veritatis voluptatem illum aut sunt nihil adipisci et animi.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 4, 12, 23, 32, 13, 126, DateTimeKind.Unspecified).AddTicks(1195), 1L, "Consequuntur amet sit est perferendis praesentium.\nQuis accusamus quia perspiciatis.\nCum accusantium culpa.\nConsectetur in vel ratione eum.", new DateTime(2022, 5, 12, 12, 2, 20, 570, DateTimeKind.Unspecified).AddTicks(2897), false, 6L, "Et voluptatem cumque minus.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 10, 25, 22, 54, 37, 468, DateTimeKind.Unspecified).AddTicks(3874), 4L, "Sit rerum placeat accusamus unde ut nobis.\nEt quo mollitia et similique.\nIn neque consequuntur corporis sint iste.\nDoloribus fugiat sit.", new DateTime(2023, 5, 4, 23, 23, 20, 431, DateTimeKind.Unspecified).AddTicks(6037), true, 26L, "Eum aut sint.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 12, 16, 5, 21, 40, 551, DateTimeKind.Unspecified).AddTicks(5680), 1L, "Occaecati sint labore.\nEt quidem necessitatibus itaque aliquam.\nRepellat quia sint laboriosam fugit similique et.", new DateTime(2022, 10, 10, 10, 9, 56, 631, DateTimeKind.Unspecified).AddTicks(5291), false, 31L, "Ducimus ratione optio harum officia quia pariatur culpa.", 40L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 7, 31, 21, 29, 18, 293, DateTimeKind.Unspecified).AddTicks(4561), 1L, "Voluptatibus rem ipsam.\nUt sapiente id quo suscipit incidunt expedita harum quia harum.", new DateTime(2022, 10, 20, 23, 21, 57, 767, DateTimeKind.Unspecified).AddTicks(751), 38L, "Quam facere earum in aut qui.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 3, 13, 17, 46, 23, 796, DateTimeKind.Unspecified).AddTicks(884), 5L, "Provident et quibusdam.\nEveniet vel quia quia maxime ut itaque suscipit.\nTemporibus qui nihil.\nQui rerum et deserunt accusantium dicta qui.", new DateTime(2023, 6, 6, 14, 2, 23, 314, DateTimeKind.Unspecified).AddTicks(9707), 50L, "Iure sint enim eos qui rerum rerum commodi qui magni.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 11, 26, 3, 53, 46, 118, DateTimeKind.Unspecified).AddTicks(2955), 4L, "Autem non corrupti reiciendis itaque voluptas aperiam.", new DateTime(2023, 1, 25, 11, 39, 24, 121, DateTimeKind.Unspecified).AddTicks(6697), false, 4L, "Ut exercitationem aspernatur quos quisquam qui dolor.", 19L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 4, 27, 21, 10, 12, 516, DateTimeKind.Unspecified).AddTicks(9304), 3L, "Velit commodi et.\nUt nihil sequi unde illum sit eius vel.\nEsse minus quisquam odit commodi quis neque.\nNisi molestiae eos.", new DateTime(2023, 4, 8, 7, 6, 28, 634, DateTimeKind.Unspecified).AddTicks(9052), true, 46L, "Dolor ea tenetur velit labore enim ut.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 2, 11, 15, 20, 45, 859, DateTimeKind.Unspecified).AddTicks(9750), "Officia illum et quia consequatur.\nNumquam eligendi sit.\nEius eligendi magni et eos est et et iusto itaque.\nConsectetur eum quo.\nNon est architecto autem incidunt pariatur neque possimus voluptas.", new DateTime(2023, 8, 22, 20, 51, 5, 766, DateTimeKind.Unspecified).AddTicks(6020), 46L, "Odio commodi similique sunt.", 27L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 12, 13, 6, 21, 32, 871, DateTimeKind.Unspecified).AddTicks(910), 2L, "Et qui et.", new DateTime(2023, 12, 20, 17, 22, 56, 403, DateTimeKind.Unspecified).AddTicks(2387), true, 17L, "Non suscipit modi architecto possimus nihil minima eum ullam et.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 2, 26, 22, 26, 10, 542, DateTimeKind.Unspecified).AddTicks(989), 3L, "Sit explicabo sed.\nQuia nam ab quos nihil.", new DateTime(2022, 6, 6, 14, 43, 13, 948, DateTimeKind.Unspecified).AddTicks(8330), 19L, "Inventore itaque consequatur magni.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 4, 25, 16, 51, 41, 205, DateTimeKind.Unspecified).AddTicks(1209), 2L, "Adipisci dolorem eos iure exercitationem ut qui.\nVoluptate animi id.\nQui eum ducimus.", new DateTime(2023, 6, 18, 21, 16, 7, 738, DateTimeKind.Unspecified).AddTicks(5404), true, 2L, "Occaecati eum sed similique quos provident natus molestias.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 4, 5, 15, 22, 37, 707, DateTimeKind.Unspecified).AddTicks(8496), 5L, "Est natus reiciendis dolor et dicta at.", new DateTime(2022, 9, 27, 20, 19, 31, 958, DateTimeKind.Unspecified).AddTicks(440), false, 42L, "Quia pariatur placeat.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 11, 5, 17, 15, 53, 191, DateTimeKind.Unspecified).AddTicks(2914), 4L, "Voluptate dolores recusandae ut perspiciatis omnis adipisci.\nNulla dolorum a velit facilis non.\nQuia corrupti odit.\nA quia at animi eius consequatur aspernatur.\nEsse rerum ullam quos et dolorem.", new DateTime(2023, 2, 20, 4, 18, 11, 98, DateTimeKind.Unspecified).AddTicks(4007), 23L, "Molestiae doloribus atque et id sed et voluptatem atque dolorem.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 6, 8, 1, 27, 58, 528, DateTimeKind.Unspecified).AddTicks(1206), 5L, "Est autem et pariatur ex omnis sed quo.\nDucimus quia omnis perspiciatis.\nMagni nisi officia quia beatae recusandae corrupti.\nSoluta laudantium sit dolorem.\nAutem amet exercitationem sunt et nihil quia non fugit.", new DateTime(2024, 1, 5, 9, 54, 28, 707, DateTimeKind.Unspecified).AddTicks(2115), true, 48L, "Eum sunt aut aperiam quasi consequatur non.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 10, 2, 1, 15, 7, 757, DateTimeKind.Unspecified).AddTicks(9296), 2L, "Eligendi consectetur sint non autem quod non.", new DateTime(2023, 11, 5, 14, 1, 50, 510, DateTimeKind.Unspecified).AddTicks(7230), 2L, "Qui pariatur quo perspiciatis cum est atque rerum magni inventore.", 2L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 7, 18, 23, 24, 20, 698, DateTimeKind.Unspecified).AddTicks(239), 1L, "Atque maiores numquam sed dolores consequatur quia aut.\nPerferendis alias nihil est praesentium.\nOdit repudiandae reprehenderit consectetur et est dolores quas.\nNam enim officiis recusandae hic dolor fuga.", new DateTime(2022, 10, 13, 23, 32, 43, 880, DateTimeKind.Unspecified).AddTicks(2074), 30L, "Laborum hic sit minima similique dolor.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 11, 29, 1, 18, 58, 654, DateTimeKind.Unspecified).AddTicks(8467), 3L, "Sit officia est voluptatem nemo.\nCommodi quia doloribus.\nDicta maiores atque.\nQui amet itaque enim neque qui iure et.\nIpsam molestiae aspernatur non nostrum ea.", new DateTime(2022, 5, 1, 8, 16, 14, 880, DateTimeKind.Unspecified).AddTicks(3158), false, 27L, "Et sequi ut.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 2, 25, 2, 4, 56, 809, DateTimeKind.Unspecified).AddTicks(286), 3L, "Rerum ipsum pariatur.", new DateTime(2022, 5, 7, 22, 14, 15, 952, DateTimeKind.Unspecified).AddTicks(5326), 20L, "Quisquam et officiis esse ducimus ea saepe consequatur.", 8L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 2, 2, 18, 3, 46, 9, DateTimeKind.Unspecified).AddTicks(237), 2L, "Velit deleniti nemo sit vel atque numquam rerum.\nDolorem itaque exercitationem perspiciatis hic.\nIpsa facilis sed molestias doloribus culpa.\nAut et eos et velit repellat nihil quia nisi.\nQuos voluptatem a error facere cumque autem consequatur.", new DateTime(2023, 11, 30, 19, 39, 38, 216, DateTimeKind.Unspecified).AddTicks(7317), 5L, "Quisquam quia unde architecto illum.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 6, 4, 20, 8, 0, 80, DateTimeKind.Unspecified).AddTicks(4848), 1L, "Perspiciatis vel et.\nBlanditiis quasi eius.\nDelectus dolorem nemo aut.\nAsperiores qui quis earum voluptas.\nBeatae laboriosam ut eos.", new DateTime(2022, 7, 29, 13, 39, 28, 326, DateTimeKind.Unspecified).AddTicks(4112), 14L, "Suscipit dolorem et tenetur enim.", 18L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 10, 8, 8, 31, 1, 719, DateTimeKind.Unspecified).AddTicks(4006), 2L, "Exercitationem optio voluptatem iste esse.\nEnim voluptas ut excepturi debitis sapiente fuga dolorem.\nImpedit velit sint qui reiciendis ratione alias omnis sapiente.\nIusto doloribus consectetur quasi qui quidem animi.", new DateTime(2022, 8, 26, 19, 58, 43, 767, DateTimeKind.Unspecified).AddTicks(8311), 41L, "Voluptatem laborum non velit amet est.", 19L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 10, 29, 21, 4, 41, 300, DateTimeKind.Unspecified).AddTicks(4609), 1L, "Quas non libero et nobis amet nostrum qui inventore.", new DateTime(2022, 2, 11, 3, 25, 57, 160, DateTimeKind.Unspecified).AddTicks(7811), false, 40L, "Quibusdam voluptatibus quisquam voluptatem eum blanditiis omnis.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 8, 13, 12, 2, 14, 193, DateTimeKind.Unspecified).AddTicks(6999), 4L, "Ut dolor dolorem.\nEa culpa dicta cum quo.\nError quis delectus id animi aut.", new DateTime(2023, 3, 16, 0, 11, 31, 986, DateTimeKind.Unspecified).AddTicks(2288), true, 44L, "Soluta harum voluptatem quam reprehenderit.", 30L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 3, 28, 9, 54, 32, 540, DateTimeKind.Unspecified).AddTicks(4637), 4L, "Animi quas voluptatem perferendis quod deleniti molestiae.\nEos cumque eligendi qui voluptates.\nVitae eum omnis sit magni harum deserunt.\nPraesentium ducimus quia magni rem enim.\nAlias maiores qui similique commodi dolores explicabo.", new DateTime(2023, 8, 27, 16, 37, 8, 715, DateTimeKind.Unspecified).AddTicks(2643), true, 10L, "A enim odit omnis consequuntur fugiat qui fugit.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 4, 22, 10, 56, 58, 105, DateTimeKind.Unspecified).AddTicks(5446), 2L, "Ullam architecto numquam voluptatibus ipsum aut amet quae.\nEligendi est consequatur et facere vero quo.\nDolorem unde ea maiores.", new DateTime(2022, 3, 7, 13, 58, 18, 713, DateTimeKind.Unspecified).AddTicks(2798), false, 23L, "Accusantium error commodi.", 18L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 7, 17, 12, 44, 10, 406, DateTimeKind.Unspecified).AddTicks(9288), 3L, "Totam in aliquid hic ab quia at saepe omnis.\nQuam eos nemo repellendus.\nVel neque impedit aliquam vero provident quidem iure.\nAssumenda id sequi recusandae quo aspernatur repellat.\nMolestiae earum est molestiae adipisci blanditiis itaque.", new DateTime(2023, 10, 6, 15, 57, 44, 214, DateTimeKind.Unspecified).AddTicks(7108), false, 2L, "Quam possimus assumenda et et dolore.", 13L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 10, 2, 20, 34, 39, 112, DateTimeKind.Unspecified).AddTicks(457), 4L, "Quasi labore fugiat aut voluptas dolor dignissimos illo et illo.\nUt repudiandae non commodi perferendis nemo dolorum impedit.\nEsse dolores quod quasi voluptas qui quos rem sint.\nAut ex sunt excepturi vero cumque earum quam molestiae minima.\nRepellendus odio id rerum enim sunt.", new DateTime(2022, 3, 25, 11, 33, 41, 920, DateTimeKind.Unspecified).AddTicks(4277), false, 3L, "Quidem voluptatem tenetur quod.", 7L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 11, 21, 14, 15, 54, 779, DateTimeKind.Unspecified).AddTicks(4492), 5L, "Ipsum quia ratione.\nEx distinctio architecto necessitatibus consectetur et.\nHarum inventore consequatur sit provident.", new DateTime(2023, 1, 26, 18, 56, 29, 573, DateTimeKind.Unspecified).AddTicks(1975), false, 29L, "Sunt et omnis ipsum sit est ut.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 3, 12, 18, 5, 50, 421, DateTimeKind.Unspecified).AddTicks(7064), 3L, "Neque est porro aut omnis dolorem qui.\nEos hic sint quos in rerum est.\nEnim facilis consequatur fuga alias.", new DateTime(2022, 6, 22, 23, 1, 1, 617, DateTimeKind.Unspecified).AddTicks(7826), true, 33L, "Non veniam sed dolor dolore dolore deserunt occaecati dolore et.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 6, 8, 12, 10, 44, 405, DateTimeKind.Unspecified).AddTicks(4569), 4L, "Ea quisquam sunt voluptatibus voluptas.\nAnimi est natus quia magnam id dolorum earum.", new DateTime(2023, 3, 20, 13, 32, 51, 346, DateTimeKind.Unspecified).AddTicks(9509), 34L, "Possimus eum et odio dolorum consequatur et nihil deserunt.", 9L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 9, 14, 19, 30, 9, 621, DateTimeKind.Unspecified).AddTicks(1030), 1L, "Enim necessitatibus error soluta corporis iusto eius minima aut corrupti.", new DateTime(2022, 9, 13, 2, 40, 15, 923, DateTimeKind.Unspecified).AddTicks(6670), 27L, "Voluptas odit error rerum.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 4, 9, 17, 23, 52, 22, DateTimeKind.Unspecified).AddTicks(7319), "Maiores esse aut expedita rerum laboriosam libero omnis sunt ullam.\nQuisquam veniam accusamus qui.", new DateTime(2022, 10, 7, 11, 35, 41, 150, DateTimeKind.Unspecified).AddTicks(8412), true, 14L, "Aut et illo qui culpa inventore itaque soluta amet.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 8, 11, 8, 13, 51, 527, DateTimeKind.Unspecified).AddTicks(4824), 5L, "Fugit quasi molestiae sunt et.", new DateTime(2023, 6, 21, 23, 20, 27, 788, DateTimeKind.Unspecified).AddTicks(1626), false, 43L, "Debitis omnis ut debitis nemo quas quod dolorum magnam.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 11, 14, 1, 33, 38, 359, DateTimeKind.Unspecified).AddTicks(7919), 2L, "Aut quod praesentium.\nAliquam eum soluta non nihil.\nFacere distinctio repudiandae vel quo laudantium aut dolores tempore nemo.\nOmnis magni aliquid.", new DateTime(2023, 1, 1, 23, 25, 33, 206, DateTimeKind.Unspecified).AddTicks(2205), false, 33L, "Non pariatur quisquam doloremque voluptatem doloremque iure impedit eum.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 5, 22, 18, 10, 57, 182, DateTimeKind.Unspecified).AddTicks(7865), "Quasi consequatur est consectetur aut numquam id similique veniam numquam.\nQuia tenetur voluptas est aut et rem sed.\nQuo beatae aliquid sit eius corrupti.\nEt ut placeat repellat similique molestias sequi nihil quia.", new DateTime(2023, 3, 30, 2, 24, 47, 171, DateTimeKind.Unspecified).AddTicks(6734), false, 34L, "Odio nihil maiores repudiandae incidunt aliquid dolores aut.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2022, 1, 26, 19, 2, 31, 61, DateTimeKind.Unspecified).AddTicks(4804), 1L, "Voluptatibus quam sit.\nPraesentium facere aut voluptatem iure et sit provident numquam qui.\nQuibusdam fuga quis sed quidem dolores et cum inventore.", new DateTime(2023, 7, 19, 17, 17, 37, 230, DateTimeKind.Unspecified).AddTicks(4777), 10L, "Voluptatem fugit rem distinctio corporis sed.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2022, 1, 26, 9, 55, 40, 37, DateTimeKind.Unspecified).AddTicks(6635), 1L, "Quo eos dolorem nostrum distinctio odit eveniet voluptatem vel sit.", new DateTime(2023, 11, 5, 9, 59, 17, 171, DateTimeKind.Unspecified).AddTicks(262), false, 31L, "Corporis aut officia.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 4, 26, 17, 31, 48, 402, DateTimeKind.Unspecified).AddTicks(8076), 5L, "Corporis eius incidunt et.\nEst eum voluptates nihil quo ut fugiat.", new DateTime(2023, 2, 17, 14, 38, 26, 894, DateTimeKind.Unspecified).AddTicks(5862), 8L, "Ex quod quia voluptatem molestias facere accusamus.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 6, 29, 13, 58, 50, 537, DateTimeKind.Unspecified).AddTicks(5691), 1L, "Nulla ducimus ex quasi nihil.\nRerum mollitia aut qui itaque.", new DateTime(2022, 9, 27, 11, 41, 59, 562, DateTimeKind.Unspecified).AddTicks(3877), 45L, "Dolores deleniti non quos dignissimos.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 6, 13, 11, 4, 49, 442, DateTimeKind.Unspecified).AddTicks(1957), 1L, "Est quod et voluptatem vel maiores laudantium et rerum.", new DateTime(2023, 12, 8, 8, 36, 53, 790, DateTimeKind.Unspecified).AddTicks(318), false, 18L, "Fugiat sapiente eum ut id harum quasi a.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 5, 6, 13, 28, 28, 857, DateTimeKind.Unspecified).AddTicks(7690), 4L, "Dolorum iusto aliquid.\nEt est velit voluptas eos consequatur.\nVero distinctio non incidunt.", new DateTime(2023, 3, 3, 16, 13, 45, 156, DateTimeKind.Unspecified).AddTicks(1496), 2L, "Tempora quas aut rerum expedita accusantium placeat ea iure.", 38L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 6, 29, 18, 1, 17, 224, DateTimeKind.Unspecified).AddTicks(9181), 4L, "Ducimus quia sunt architecto fugiat.\nTempora quos eligendi temporibus doloremque facilis.\nEx nihil corrupti provident sed.", new DateTime(2023, 4, 26, 21, 15, 44, 280, DateTimeKind.Unspecified).AddTicks(2488), true, 27L, "Voluptas blanditiis beatae itaque aperiam quo ab sint doloribus.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2022, 1, 14, 4, 37, 33, 175, DateTimeKind.Unspecified).AddTicks(7432), 2L, "Ut qui commodi.", new DateTime(2022, 10, 21, 12, 20, 56, 986, DateTimeKind.Unspecified).AddTicks(1217), 42L, "Fugiat vel magni sunt sunt quia sit exercitationem.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2022, 1, 27, 7, 10, 40, 759, DateTimeKind.Unspecified).AddTicks(1463), "Inventore consequuntur aut qui nulla ea id.\nQui ipsam ab ad in sint iure voluptas.\nVelit natus quas perspiciatis cumque.\nAsperiores magnam est et.", new DateTime(2023, 3, 24, 18, 44, 55, 439, DateTimeKind.Unspecified).AddTicks(21), false, 19L, "Qui est tempora occaecati quo autem consequatur minima.", 18L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 2, 5, 21, 1, 0, 638, DateTimeKind.Unspecified).AddTicks(2901), 2L, "Impedit magni accusamus sed.\nQuisquam tempora quasi ea maiores fugit sit.", new DateTime(2022, 3, 28, 12, 22, 12, 762, DateTimeKind.Unspecified).AddTicks(7777), 41L, "Sit aliquam omnis libero neque id ex maiores quos cum.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 6, 11, 21, 23, 5, 586, DateTimeKind.Unspecified).AddTicks(5658), 5L, "Earum error adipisci odio molestias.\nRepudiandae exercitationem quia nisi omnis doloremque qui dignissimos.\nNihil similique eaque repellat optio rerum iure.\nAut omnis quis quidem.", new DateTime(2022, 3, 30, 13, 52, 0, 434, DateTimeKind.Unspecified).AddTicks(8648), 18L, "Maiores id quis qui deleniti provident in ut consectetur quo.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 2, 28, 1, 28, 47, 739, DateTimeKind.Unspecified).AddTicks(4811), 4L, "Rerum illo laboriosam dignissimos eaque recusandae eligendi suscipit voluptatem.\nHic cum iste laboriosam sunt cum modi beatae.\nAut quibusdam laudantium voluptates est nisi ab vitae dignissimos.\nTempora est illum ut qui culpa ab quam voluptas animi.", new DateTime(2022, 5, 16, 22, 5, 19, 659, DateTimeKind.Unspecified).AddTicks(2031), false, 21L, "Excepturi voluptatem mollitia consequatur ad aut.", 6L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 10, 31, 17, 33, 36, 835, DateTimeKind.Unspecified).AddTicks(6936), "Aspernatur maiores at magnam commodi molestiae doloribus dolores.", new DateTime(2023, 8, 21, 8, 54, 19, 452, DateTimeKind.Unspecified).AddTicks(1538), false, 20L, "Ipsum ipsum et officia adipisci ipsa voluptas alias dolor.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 6, 18, 12, 21, 14, 37, DateTimeKind.Unspecified).AddTicks(5279), 2L, "Rerum provident est.\nCulpa ea et assumenda.", new DateTime(2023, 7, 29, 8, 7, 37, 85, DateTimeKind.Unspecified).AddTicks(9807), 42L, "Ut aut id voluptatibus ullam modi numquam voluptates.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 11, 28, 1, 12, 36, 869, DateTimeKind.Unspecified).AddTicks(4299), 5L, "Aliquid quam adipisci odio neque aliquid officiis est.\nReiciendis voluptatem quis praesentium ea quidem iure ex dolores atque.", new DateTime(2023, 5, 12, 11, 57, 15, 751, DateTimeKind.Unspecified).AddTicks(7860), true, 48L, "Ut accusamus velit magni nam.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 9, 27, 10, 59, 56, 442, DateTimeKind.Unspecified).AddTicks(8997), 5L, "Et illum nihil porro eum sapiente.", new DateTime(2023, 7, 28, 21, 40, 4, 34, DateTimeKind.Unspecified).AddTicks(1100), false, 22L, "Debitis ut dolores.", 14L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 2, 12, 12, 45, 20, 284, DateTimeKind.Unspecified).AddTicks(393), 5L, "Rerum qui perferendis quas quia nemo repellat molestiae dignissimos.\nItaque vero facilis itaque sint consequatur reprehenderit reprehenderit veritatis.\nDoloremque illo error officiis quam error ratione ipsum et.", new DateTime(2022, 12, 20, 20, 43, 54, 877, DateTimeKind.Unspecified).AddTicks(5690), true, 25L, "Deleniti eveniet impedit deleniti inventore asperiores sit.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 7, 18, 21, 48, 8, 237, DateTimeKind.Unspecified).AddTicks(763), 4L, "Quis distinctio fugiat sapiente temporibus voluptatum nam.\nSed aut illum saepe rerum qui dicta.\nNesciunt dolorem natus alias est id repellat.\nPraesentium et quidem recusandae est hic eveniet et.\nRepellat et possimus qui.", new DateTime(2022, 6, 18, 0, 51, 4, 509, DateTimeKind.Unspecified).AddTicks(1488), 6L, "Praesentium dolorum fugit officiis velit.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 11, 21, 9, 31, 46, 515, DateTimeKind.Unspecified).AddTicks(6456), 5L, "Quae pariatur et debitis harum nam neque et eos quo.", new DateTime(2023, 7, 19, 19, 32, 54, 181, DateTimeKind.Unspecified).AddTicks(4256), 39L, "Qui eum modi quis.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 10, 29, 0, 36, 50, 381, DateTimeKind.Unspecified).AddTicks(9768), 2L, "Debitis ut velit natus impedit doloribus pariatur.\nEt quia et explicabo error nobis et iste quae.\nVoluptates ratione tenetur voluptas et culpa quae ut.\nAnimi soluta cum qui reiciendis porro facilis fuga accusamus molestiae.\nQuia dolor inventore et.", new DateTime(2023, 2, 2, 7, 25, 34, 140, DateTimeKind.Unspecified).AddTicks(8631), 16L, "Voluptas eum aut dignissimos dolorem tempora ratione expedita.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 9, 29, 12, 41, 57, 723, DateTimeKind.Unspecified).AddTicks(5608), 5L, "Rem consequatur magnam dicta error reprehenderit necessitatibus.\nSint veritatis quis magni debitis officia.\nSunt cupiditate laboriosam id aut vel aut optio.\nEt et exercitationem ut sint vitae.\nAut mollitia et et ipsum aut nisi.", new DateTime(2023, 12, 16, 13, 20, 11, 482, DateTimeKind.Unspecified).AddTicks(3535), false, 13L, "Dolor iusto maxime quibusdam error aperiam assumenda.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 6, 8, 2, 32, 6, 301, DateTimeKind.Unspecified).AddTicks(8606), 1L, "Nihil et enim.", null, true, 24L, "Ullam pariatur perferendis impedit eaque optio.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 11, 17, 10, 59, 54, 182, DateTimeKind.Unspecified).AddTicks(9240), 2L, "Consequatur sint a et rem similique.", new DateTime(2023, 4, 4, 0, 4, 39, 394, DateTimeKind.Unspecified).AddTicks(992), true, 4L, "Ut provident modi itaque natus veniam.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 12L, new DateTime(2021, 12, 18, 14, 10, 11, 519, DateTimeKind.Unspecified).AddTicks(6331), 4L, "Quia accusamus ad ut in molestias facere natus tenetur architecto.\nQui molestiae vero nostrum nam odit placeat officiis quo minima.\nEt est et dolore temporibus in.\nA ad repellendus optio.\nVero sed explicabo nobis iste.", new DateTime(2022, 4, 30, 12, 29, 20, 924, DateTimeKind.Unspecified).AddTicks(9697), true, 28L, "Sunt hic voluptatem.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 5, 1, 16, 59, 8, 688, DateTimeKind.Unspecified).AddTicks(6324), 5L, "Et voluptatem quisquam dolor commodi asperiores et.", new DateTime(2022, 5, 5, 14, 49, 59, 917, DateTimeKind.Unspecified).AddTicks(194), 30L, "Consectetur animi voluptate totam sed minima voluptatem cum necessitatibus.", 18L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 3, 9, 19, 19, 12, 447, DateTimeKind.Unspecified).AddTicks(9624), 3L, "Nam laudantium animi.\nTemporibus quos quasi molestias cum est delectus non totam rerum.\nIn ut facilis quidem quia voluptate.\nSoluta consectetur nulla.", null, true, 22L, "Facere quia enim aut.", 5L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 8, 9, 347, DateTimeKind.Unspecified).AddTicks(4885), 5L, "Qui et beatae qui aperiam tempora aut.\nRepellendus aliquid culpa fuga dolorem esse impedit.\nDolor voluptate magni a ducimus inventore voluptatibus est.", new DateTime(2022, 7, 30, 1, 52, 49, 979, DateTimeKind.Unspecified).AddTicks(5367), 37L, "Molestias eos nobis quia velit." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2022, 1, 7, 21, 15, 3, 803, DateTimeKind.Unspecified).AddTicks(4214), 4L, "Et qui molestias tempora.\nVoluptatem dolor sint nulla.", new DateTime(2023, 9, 5, 15, 53, 31, 44, DateTimeKind.Unspecified).AddTicks(7703), 32L, "Architecto eos deserunt temporibus itaque.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 11, 11, 1, 24, 29, 247, DateTimeKind.Unspecified).AddTicks(7429), 3L, "Omnis doloremque dolorem et.", new DateTime(2023, 7, 3, 0, 0, 31, 220, DateTimeKind.Unspecified).AddTicks(4302), true, 49L, "Quidem corporis quia voluptatem sapiente qui autem et.", 35L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 12, 22, 19, 51, 8, 849, DateTimeKind.Unspecified).AddTicks(3167), 2L, "Et sequi quidem.\nConsequatur expedita officia.\nNeque aspernatur beatae tempora necessitatibus voluptatem officiis repellendus.", new DateTime(2022, 10, 18, 16, 53, 26, 114, DateTimeKind.Unspecified).AddTicks(9523), 44L, "Qui laudantium sapiente quam dolorem aliquam vel similique enim.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 5, 30, 7, 11, 43, 178, DateTimeKind.Unspecified).AddTicks(8038), "Assumenda quasi cupiditate et vero quidem modi libero quo autem.\nArchitecto qui exercitationem rem.\nOdit porro et ut beatae sit.\nVeniam qui fugit et dolor voluptates deserunt odit dolores.\nSed aut quo eum eius optio placeat necessitatibus quia aut.", new DateTime(2023, 1, 15, 13, 14, 12, 692, DateTimeKind.Unspecified).AddTicks(7082), true, 5L, "Maxime amet ut aut sed magnam quas ut explicabo.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 10, 8, 23, 51, 19, 83, DateTimeKind.Unspecified).AddTicks(9759), 1L, "Quod voluptatem quae possimus sed ut.\nMagni minima consectetur.", new DateTime(2023, 8, 10, 8, 3, 18, 98, DateTimeKind.Unspecified).AddTicks(2886), false, 6L, "Aliquam accusantium aut qui odio quis.", 38L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 7, 24, 21, 12, 4, 94, DateTimeKind.Unspecified).AddTicks(360), 5L, "Sed adipisci pariatur.\nUt exercitationem nam.\nOfficia autem tenetur qui voluptas quam.\nQuia voluptate voluptatibus et corrupti corporis neque excepturi labore impedit.\nSint modi voluptatibus rem quo est dicta non quidem et.", new DateTime(2022, 12, 4, 12, 40, 32, 13, DateTimeKind.Unspecified).AddTicks(8265), true, 18L, "Nemo est impedit ut.", 3L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "ProjectId", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 9, 4, 0, 39, 11, 259, DateTimeKind.Unspecified).AddTicks(9092), 4L, "Aspernatur commodi est odit.\nVel a nobis laborum qui beatae.\nDignissimos dignissimos fugit beatae sit facilis.", new DateTime(2023, 12, 1, 15, 41, 16, 860, DateTimeKind.Unspecified).AddTicks(9027), true, 42L, "Veritatis officia labore.", 37L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 9, 7, 23, 28, 42, 593, DateTimeKind.Unspecified).AddTicks(5257), "Quidem sed cum labore aut mollitia dicta id.\nSaepe molestiae perferendis.\nRerum quia nihil voluptatem enim hic voluptates modi corrupti voluptas.\nUt odio minima nihil hic ducimus natus aut sunt.\nConsequatur quibusdam odit quo voluptatibus illum minus.", new DateTime(2022, 8, 26, 14, 22, 7, 298, DateTimeKind.Unspecified).AddTicks(8128), 16L, "Ut sed esse quia sed et molestiae repellat aut odit.", 8L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 12, 25, 16, 53, 14, 305, DateTimeKind.Unspecified).AddTicks(2798), "Ad fugiat ut consequatur.\nDistinctio et quidem sit sint.\nEa earum non animi ipsam voluptas dolores quia itaque est.", new DateTime(2023, 8, 15, 13, 29, 37, 525, DateTimeKind.Unspecified).AddTicks(9944), 6L, "Est pariatur similique sequi beatae.", 10L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2022, 1, 24, 20, 9, 56, 697, DateTimeKind.Unspecified).AddTicks(5148), "Dolores quasi et et maxime enim deleniti.\nIncidunt et consequuntur provident labore voluptatem et quas sed molestias.\nAut tempora numquam error.\nEaque laboriosam veritatis voluptates quis vitae.\nVoluptas ducimus quo.", new DateTime(2023, 5, 14, 17, 15, 26, 437, DateTimeKind.Unspecified).AddTicks(8658), 21L, "Asperiores at perferendis architecto vero occaecati enim.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "ProjectId", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 7, 2, 20, 15, 3, 76, DateTimeKind.Unspecified).AddTicks(5411), 5L, "Odit similique quia perferendis sunt omnis reprehenderit minima molestias.\nSed ea quia sunt.\nVoluptatem autem quibusdam dicta non eum aut adipisci.\nCorrupti et quisquam sit.", new DateTime(2022, 10, 10, 9, 51, 42, 944, DateTimeKind.Unspecified).AddTicks(4413), 13L, "Officiis ullam aspernatur et.", 34L });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 15, 21, 38, 46, 495, DateTimeKind.Unspecified).AddTicks(8461), 3L, "Aliquam expedita tempora.\nInventore eveniet veniam provident.\nEt delectus numquam voluptas dignissimos ad incidunt.", true, true, 0, new Guid("76b04717-dadf-3faa-b184-5b6ab1e8a957"), "Laboriosam ut in quos et quam qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 22, 23, 46, 30, 637, DateTimeKind.Unspecified).AddTicks(591), 3L, "Ipsa aliquam dolores illum ex earum eum quo blanditiis.\nRepellat quisquam esse ipsum explicabo repudiandae soluta ea aliquid.\nTempora ex enim excepturi officiis.", new Guid("57a02ac0-52b9-5f9e-1ac6-e732e5d00877"), "Distinctio quas id necessitatibus aut consequatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 1, 17, 6, 30, 239, DateTimeKind.Unspecified).AddTicks(439), 4L, "Tempore dolore quidem.\nVoluptatibus dolorum rerum dolorem dolorum aspernatur vel molestiae.\nConsequatur placeat sed quia perspiciatis soluta est rerum numquam.\nArchitecto voluptas necessitatibus placeat ut quia.\nExplicabo voluptatem sit itaque sapiente est.", true, true, 1, new Guid("2754ffee-8819-814f-cb87-3fb33ee0a5cb"), "Harum ut debitis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 8, 4, 37, 2, 857, DateTimeKind.Unspecified).AddTicks(2193), 3L, "Ullam nesciunt reiciendis.\nNatus nihil cumque.\nCorporis est exercitationem aliquid nisi expedita asperiores alias.", 1, new Guid("d8d15c05-b92f-e0a1-9353-2ba674adb46a"), "Sint facere est id deserunt qui necessitatibus libero quas sunt." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 8, 22, 6, 5, 677, DateTimeKind.Unspecified).AddTicks(2194), 2L, "Consequuntur consequatur consequatur quaerat suscipit ut sed et ex.\nSit amet ut corporis non facilis commodi.", false, 0, new Guid("bad48bba-ff3e-5865-bf5d-e63744119149"), "Et rem quod autem iusto qui placeat expedita." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 26, 8, 1, 59, 536, DateTimeKind.Unspecified).AddTicks(4938), 1L, "Et nesciunt saepe omnis rem.\nEt voluptates provident.\nAliquid velit consectetur quo.\nSit tempore doloremque.", true, true, 0, new Guid("74dbcd25-7552-6bce-eae3-ac3059d9682f"), "Corporis aliquid et placeat assumenda quam dolorem tempore eius consequatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 13, 18, 47, 53, 909, DateTimeKind.Unspecified).AddTicks(5690), 1L, "Omnis nihil doloremque aliquam aut.", new Guid("67995f85-7f67-c027-2476-55619e32645c"), "Sed nam veniam amet ut ex nostrum iste." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 20, 6, 47, 38, 302, DateTimeKind.Unspecified).AddTicks(7134), "Rerum sit ipsum hic voluptatem asperiores et.\nAmet eligendi architecto animi nesciunt.\nEa a adipisci ratione adipisci voluptatum sed.", new Guid("6b89df96-0d96-45f7-c105-b7f00fd6a27a"), "Aut consequatur dolor eos autem reprehenderit exercitationem voluptate quae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 4, 11, 14, 55, 78, DateTimeKind.Unspecified).AddTicks(6213), 1L, "Rerum sint et sed doloribus inventore.", false, new Guid("78eaced1-3f6f-1da3-9d05-724a5210074c"), "Enim cumque consequatur animi asperiores ut nulla voluptate architecto debitis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 26, 3, 30, 19, 443, DateTimeKind.Unspecified).AddTicks(2854), 2L, "Natus quaerat alias et dolor ut.\nEt quos sit qui.\nMinima officiis eos quis saepe impedit voluptas.", true, new Guid("551e43cc-e76c-43ca-625e-939cc1587273"), "Ipsam sunt veniam vitae architecto." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 28, 14, 17, 2, 517, DateTimeKind.Unspecified).AddTicks(8466), 5L, "Rerum nemo similique ad itaque voluptatibus voluptas.\nRecusandae aut ipsum similique molestiae ad laborum et.", true, true, new Guid("a60877f4-bb27-261d-3716-9d54b950bba6"), "Dolores sit sequi saepe molestiae facere sed eveniet et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 23, 5, 3, 2, 562, DateTimeKind.Unspecified).AddTicks(2181), 3L, "Harum dolores accusantium.\nExercitationem nobis sit aliquid libero.\nQuisquam libero voluptas rem rerum velit fugiat voluptates.", true, 0, new Guid("ab8d7e92-61c3-0687-bcc8-7bda801a2458"), "Tenetur ut perspiciatis numquam ipsam architecto non ab vel." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 40, 2, 740, DateTimeKind.Unspecified).AddTicks(1386), 4L, "Rerum hic voluptatibus voluptatem reprehenderit iure quasi ipsa.\nMollitia ipsa ea eos tempore perspiciatis.", true, false, 0, new Guid("54851949-2f52-ff8d-f504-af24da870873"), "Numquam saepe dolorem nisi consequatur dicta." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 4, 15, 51, 49, 613, DateTimeKind.Unspecified).AddTicks(5763), 2L, "Consequatur ex reiciendis harum sed minus libero sed.\nImpedit iste natus quis.\nBlanditiis sit dolore dolorem nam delectus nobis deleniti magnam.", true, new Guid("d7e1f0e3-acaf-f1ba-7dab-e3f49ec337e1"), "Aut velit placeat omnis fugiat dolorem dolor velit voluptatibus voluptatem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 22, 3, 10, 41, 786, DateTimeKind.Unspecified).AddTicks(5061), 5L, "Consequuntur non in consequatur sit odit non aliquid tempore.\nIpsum ipsam cupiditate aut ipsam ad.\nBlanditiis fugiat ipsa vitae.\nSed non commodi laborum pariatur praesentium nisi labore nam.\nEa voluptates totam enim impedit vitae.", true, new Guid("376d79d8-ad33-2b00-1c85-caf43ad28ef8"), "Impedit mollitia et veniam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 16, 13, 15, 16, 796, DateTimeKind.Unspecified).AddTicks(5649), 1L, "Eligendi a laborum rerum consequatur similique fugit qui.\nNobis ad nihil fugit veritatis.\nUt iste consectetur cum consequatur.", true, 1, new Guid("d1074242-69b3-45aa-4b5e-9f1a0ba32f61"), "Et consequatur nisi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "Description", "IsGitImported", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 4, 18, 59, 24, 797, DateTimeKind.Unspecified).AddTicks(4735), "Minima suscipit et quis in velit esse excepturi.\nMolestias cum veritatis inventore quibusdam voluptatum.\nQuod rerum enim sed voluptates molestiae.", true, false, 1, new Guid("f5a079f1-3ab6-2d4e-3d72-55e880fdb2d4"), "Inventore odio suscipit quaerat rerum et molestiae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 2, 0, 14, 43, 578, DateTimeKind.Unspecified).AddTicks(2696), 4L, "Aliquid facere magni nihil reiciendis alias expedita exercitationem qui.\nOccaecati dolor et.\nAut velit et aut.\nModi omnis vitae asperiores eos et est beatae.\nEt aspernatur omnis sit delectus voluptas aliquam quo dolorem.", new Guid("db031281-7ddc-cb6e-2271-d8f1cd8d3e2d"), "Numquam ut voluptatum nesciunt aut iste est laudantium ullam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 25, 13, 39, 50, 993, DateTimeKind.Unspecified).AddTicks(2768), "Minus recusandae ullam aperiam.\nIpsam ipsa error itaque eligendi.", true, new Guid("8bdd9f3a-1e01-63ea-8d11-6b63ce47aecf"), "Omnis sed id enim qui tenetur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 5, 15, 29, 44, 604, DateTimeKind.Unspecified).AddTicks(6290), "In quia provident.", new Guid("108bf73f-61ea-24e7-88b9-2374eb01dfd8"), "Qui debitis consectetur rerum enim placeat doloribus hic saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 15, 18, 17, 3, 349, DateTimeKind.Unspecified).AddTicks(4588), 3L, "Tempore esse fuga commodi.\nUt quisquam est molestiae natus tempora suscipit qui mollitia.\nNemo quae dolorem autem molestiae.\nAtque et dolor in eveniet.", new Guid("27065d98-402e-a894-514e-d8cab43d1e2b"), "Quasi ducimus itaque voluptatibus rerum aliquid." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 19, 18, 27, 27, 54, DateTimeKind.Unspecified).AddTicks(222), 4L, "Repellendus consectetur quos ducimus temporibus debitis doloribus praesentium.\nRepudiandae aut beatae excepturi expedita veniam minus qui enim nesciunt.\nVoluptatem commodi ipsam eum quaerat tenetur perspiciatis labore et.", true, 1, new Guid("e859f76d-c311-c175-842b-686fb9d3ea7a"), "Qui autem enim provident." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 30, 14, 42, 35, 593, DateTimeKind.Unspecified).AddTicks(2172), 2L, "Officiis nam amet fugiat sit placeat.\nUt possimus eius rem reprehenderit est neque optio.", true, 0, new Guid("a7ca401b-8b4b-f95c-27c9-9f21618f2f63"), "Quia eaque minima." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "Description", "IsGitImported", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 15, 3, 37, 23, 136, DateTimeKind.Unspecified).AddTicks(7428), "Consequatur porro ab cum doloremque maiores aut sunt iusto.\nFugit consequatur sint assumenda.\nAtque ut qui exercitationem est voluptatem culpa et illo repudiandae.", true, true, 0, new Guid("68bcd0f1-e0c4-8969-d1a7-20d9aa3d2ef0"), "Veritatis placeat quam nulla pariatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 8, 14, 38, 20, 163, DateTimeKind.Unspecified).AddTicks(5827), 2L, "Asperiores voluptas nihil.\nTempore ut ut occaecati et labore aperiam quisquam vero.\nDolorum sed laborum quam ea quia sed culpa.\nEt necessitatibus ut repudiandae consequatur dolor.", new Guid("a29f185a-16d5-50bd-7a08-cfa285510d3d"), "Non similique aut ab magni et est quae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 1, 18, 33, 58, 261, DateTimeKind.Unspecified).AddTicks(3151), 4L, "Id corrupti voluptatum doloribus praesentium autem debitis distinctio consectetur cumque.\nMagni quidem aut aut enim odio veniam libero veniam.\nEsse incidunt autem id.", true, new Guid("0190ce51-e290-9b0e-308a-a49a57bc1d8b"), "Sapiente nisi voluptates mollitia ad corrupti perferendis similique velit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 6, 15, 27, 39, 456, DateTimeKind.Unspecified).AddTicks(1627), "Aperiam voluptatem autem quia aliquam aspernatur iure.\nTempore atque doloribus est tempore recusandae quis aut dolorem.", false, 0, new Guid("6cd49b84-fdcf-0829-28a2-57fe13e05471"), "Saepe voluptas non." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 46, 10, 532, DateTimeKind.Unspecified).AddTicks(4039), 5L, "Voluptatem et sit totam rem iure laudantium debitis.\nEt dicta molestias quis sunt ullam qui.\nNisi culpa magnam architecto mollitia quis.\nOdit molestiae a vero voluptatem quaerat et placeat itaque.\nAd facilis aliquam cupiditate.", false, true, 1, new Guid("327dc006-03e4-5edb-3256-71f1aaadb19a"), "Doloribus labore placeat vel exercitationem error ad." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 1, 0, 15, 57, 265, DateTimeKind.Unspecified).AddTicks(7396), 5L, "Dolorem eos exercitationem explicabo cupiditate odio alias autem qui alias.", new Guid("c072edfa-a431-eade-c886-b74d35039895"), "Accusamus ipsam laboriosam a reiciendis odio dolor nulla voluptates iste." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 19, 4, 44, 57, 205, DateTimeKind.Unspecified).AddTicks(8435), 5L, "Ratione sunt sapiente.\nQui soluta debitis quae dolores consectetur.\nSapiente iste aperiam et ut sunt.\nTempore consequatur molestias totam ab ut vero iste culpa distinctio.\nAutem sed dolorem tenetur doloribus.", false, false, new Guid("3e2e8790-2572-ee26-c88c-821fe5e86435"), "Et at aspernatur odit neque et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 53, 2, 258, DateTimeKind.Unspecified).AddTicks(5253), 5L, "Aut similique architecto non debitis.", new Guid("ded66d34-a99e-0974-20ff-080f6fa5dc0b"), "Quo rerum eaque omnis voluptas dolor assumenda ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 26, 2, 34, 57, 698, DateTimeKind.Unspecified).AddTicks(6377), 2L, "Velit adipisci aut voluptatem.\nAlias vero sed voluptatibus magnam accusantium aperiam necessitatibus eum.\nSunt harum eum ad molestiae ratione dolor temporibus qui.", false, 1, new Guid("93ec568d-18b4-f6a2-e278-416493bfe1e5"), "Dolores culpa cum temporibus enim facilis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 12, 6, 46, 52, 740, DateTimeKind.Unspecified).AddTicks(9810), 5L, "Voluptatem ea distinctio.\nUt magni similique voluptas voluptatum nesciunt.\nRepudiandae eum quibusdam.", false, false, new Guid("b74310b6-cd55-aaf4-6bbd-9c951b6f2b97"), "Sunt perferendis sed quas officia sed quo." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 4, 5, 44, 37, 925, DateTimeKind.Unspecified).AddTicks(5904), 1L, "Accusantium odit perferendis ut dolor enim est sed qui.\nEt aliquam facilis iste.\nVoluptas sit consequuntur blanditiis blanditiis voluptatem sed suscipit.\nUt tenetur natus quia et consequatur qui esse fugiat rerum.\nCumque consequatur sed.", false, 0, new Guid("fb9bc857-574e-398b-9a08-4e95e38e39ac"), "In assumenda possimus aut aut sit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 25, 0, 46, 46, 857, DateTimeKind.Unspecified).AddTicks(3980), 5L, "Atque non quia quibusdam et praesentium sequi consequatur consequuntur.\nInventore non debitis earum sint facere voluptatum dolorum necessitatibus ex.\nMagnam non eveniet.", true, false, 0, new Guid("079f8431-47d9-0c46-c7c1-13d3c510106c"), "Pariatur nemo architecto dolorum aut debitis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 15, 1, 35, 8, 553, DateTimeKind.Unspecified).AddTicks(3884), 5L, "Quia veritatis est.\nRepellat molestiae exercitationem fugiat.\nQuaerat deleniti delectus sed.", true, new Guid("47519ca1-bdf0-ba46-0d90-a44d01ba8d14"), "Voluptas quidem rerum ipsam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "Description", "IsGitImported", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 21, 17, 15, 2, 153, DateTimeKind.Unspecified).AddTicks(7891), "Dolores vero veritatis commodi.", false, false, new Guid("62df92a0-5e5f-c35c-ecf3-d455f925deeb"), "Recusandae expedita dolorem aperiam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 2, 22, 59, 49, 731, DateTimeKind.Unspecified).AddTicks(6305), 5L, "Facere beatae est cupiditate delectus aut qui qui veniam eius.\nEveniet molestiae possimus aliquam sed.\nIllum quibusdam ab incidunt recusandae.\nUt maiores vitae consequatur tempore deleniti aliquid.\nNulla consequatur aut et praesentium illum debitis.", true, 1, new Guid("b2007542-d12f-dd55-d56e-ad308c5bab65"), "Magnam sed molestias." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 31, 16, 57, 22, 902, DateTimeKind.Unspecified).AddTicks(8855), 2L, "Voluptatem quaerat quibusdam.\nMolestiae quis maxime suscipit autem voluptatem.\nRepellendus id id ipsam.", true, true, new Guid("6bcbc95c-29ae-82a2-ccc9-2722960378c6"), "Error dolore nisi dolores iusto." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 27, 21, 55, 29, 670, DateTimeKind.Unspecified).AddTicks(5703), 5L, "Voluptates voluptates est blanditiis et non officiis in accusamus.", 1, new Guid("e62384cf-b11a-c7f6-b526-eba5dcd50c11"), "Dignissimos soluta molestiae voluptatum laboriosam est rerum similique sint id." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 25, 3, 59, 37, 662, DateTimeKind.Unspecified).AddTicks(3554), 3L, "Est facere deserunt ea dolorem dolorem molestiae doloremque.", false, 0, new Guid("5bfdf677-97a9-b5f1-e8ca-f6c99e36b9fe"), "Cupiditate excepturi quo culpa quo beatae mollitia assumenda natus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 27, 21, 17, 9, 452, DateTimeKind.Unspecified).AddTicks(7098), 1L, "Aut sint totam qui sunt quod beatae ipsam et quaerat.", true, new Guid("744386d3-8a84-b3e7-934d-a78295d054ea"), "Eos consequuntur numquam quia sint." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 21, 12, 59, 54, 147, DateTimeKind.Unspecified).AddTicks(1735), 3L, "Doloribus commodi unde voluptates labore quasi.\nVoluptas temporibus unde exercitationem sit id sed.\nNisi dolore molestiae nam.", new Guid("8db9091a-b58e-50a3-4ee7-61357690e1ee"), "Iusto sed atque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 13, 5, 34, 13, 708, DateTimeKind.Unspecified).AddTicks(143), "Corrupti cumque iusto eum aliquid aut molestias aut.\nEt ducimus dolor fuga id doloremque tempore quis.", true, new Guid("bcc6ef95-e5e5-3c70-2cbd-b02974451f8b"), "Qui consectetur ut vero nisi voluptas libero veniam in ducimus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 31, 1, 51, 3, 39, DateTimeKind.Unspecified).AddTicks(3402), 3L, "Est id atque.\nSequi perferendis eveniet.\nNemo in neque omnis dignissimos.\nAdipisci voluptatibus dolore et earum sequi expedita commodi dolorem excepturi.\nMagnam est omnis incidunt exercitationem voluptas molestiae quibusdam aliquid.", false, false, new Guid("2d34b1f1-dcbf-459b-c165-48724da94fa4"), "Ipsum cupiditate hic vel placeat iusto possimus quo laudantium." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 4, 1, 16, 55, 208, DateTimeKind.Unspecified).AddTicks(8455), 3L, "Sunt repudiandae eius alias qui repellendus nesciunt quia et distinctio.\nAutem exercitationem molestiae et repudiandae enim enim suscipit.\nAlias molestiae in et consequatur ratione earum blanditiis nulla porro.\nAut maiores similique qui aut harum a neque.", true, new Guid("cd93175d-9eb5-eb6c-5682-ad87396f9280"), "Reiciendis placeat nihil sit porro provident qui rerum pariatur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 26, 9, 11, 26, 112, DateTimeKind.Unspecified).AddTicks(3671), 3L, "Optio eum veniam ipsam voluptatem consequuntur optio vel.\nDolorem quibusdam eum neque totam non.\nTenetur asperiores quis ut id error harum.\nSapiente corrupti commodi qui nostrum suscipit.\nId consequatur voluptatem omnis optio itaque ducimus unde et.", new Guid("2ed16af9-d4ee-5b8d-e6f4-c1900681fa99"), "Dolor maiores voluptatum cupiditate modi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 25, 2, 37, 23, 406, DateTimeKind.Unspecified).AddTicks(3970), 5L, "Est incidunt nobis molestias ducimus possimus sit voluptatem quibusdam sed.\nEt reiciendis maiores consequatur.\nAut consequatur sunt autem qui rerum quas.", true, 1, new Guid("2e12ec6d-8c97-baf6-20ef-178723f97803"), "Excepturi autem est nihil." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 16, 5, 36, 30, 299, DateTimeKind.Unspecified).AddTicks(9912), 3L, "Libero possimus ab qui omnis esse.\nUt dolore cupiditate explicabo est quo aspernatur.", true, true, new Guid("b8fb2e8a-b05a-53b5-2552-bec40b9ee2d7"), "Cumque rem nostrum cumque laborum nobis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "Description", "IsGitImported", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 25, 4, 25, 12, 540, DateTimeKind.Unspecified).AddTicks(4924), "In et molestiae quo.\nQuia rem aperiam itaque qui rerum.\nUt quo maxime ullam sunt.", true, false, new Guid("ac25c339-8e35-387b-3f41-e61d0ef10c6d"), "Dolorem in quae corporis et." });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 6, 29, 16, 43, 14, 471, DateTimeKind.Unspecified).AddTicks(3977), 2L, new DateTime(2022, 2, 1, 18, 8, 2, 692, DateTimeKind.Unspecified).AddTicks(411), 27L, new DateTime(2019, 5, 15, 2, 22, 44, 129, DateTimeKind.Unspecified).AddTicks(8140), new DateTime(2021, 10, 5, 4, 3, 26, 191, DateTimeKind.Unspecified).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 8, 2, 5, 56, 7, 43, DateTimeKind.Unspecified).AddTicks(7599), 4L, new DateTime(2022, 1, 20, 18, 1, 13, 944, DateTimeKind.Unspecified).AddTicks(7911), 46L, new DateTime(2019, 12, 23, 23, 56, 55, 917, DateTimeKind.Unspecified).AddTicks(1118), new DateTime(2021, 3, 1, 21, 56, 36, 121, DateTimeKind.Unspecified).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 17L, new DateTime(2021, 7, 24, 14, 3, 2, 4, DateTimeKind.Unspecified).AddTicks(7227), 1L, new DateTime(2022, 1, 8, 5, 4, 35, 682, DateTimeKind.Unspecified).AddTicks(4534), 31L, new DateTime(2019, 10, 15, 11, 1, 35, 124, DateTimeKind.Unspecified).AddTicks(6819), new DateTime(2021, 12, 24, 16, 44, 28, 812, DateTimeKind.Unspecified).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 4, 9, 6, 42, 42, 53, DateTimeKind.Unspecified).AddTicks(7468), new DateTime(2022, 1, 12, 21, 18, 58, 733, DateTimeKind.Unspecified).AddTicks(3885), 71L, new DateTime(2019, 10, 19, 20, 33, 28, 868, DateTimeKind.Unspecified).AddTicks(8539), new DateTime(2021, 1, 16, 19, 45, 29, 595, DateTimeKind.Unspecified).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 11, 19, 15, 0, 24, 613, DateTimeKind.Unspecified).AddTicks(480), 3L, new DateTime(2022, 1, 30, 16, 18, 56, 508, DateTimeKind.Unspecified).AddTicks(5145), 46L, new DateTime(2019, 2, 10, 22, 27, 1, 917, DateTimeKind.Unspecified).AddTicks(2780), new DateTime(2021, 10, 8, 17, 3, 36, 801, DateTimeKind.Unspecified).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 8, 18, 4, 41, 39, 816, DateTimeKind.Unspecified).AddTicks(6506), 5L, null, 52L, new DateTime(2020, 1, 24, 19, 6, 19, 454, DateTimeKind.Unspecified).AddTicks(860), new DateTime(2021, 3, 17, 21, 4, 45, 106, DateTimeKind.Unspecified).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2021, 9, 27, 23, 41, 26, 176, DateTimeKind.Unspecified).AddTicks(9924), 3L, new DateTime(2022, 1, 1, 22, 15, 23, 211, DateTimeKind.Unspecified).AddTicks(2304), 64L, new DateTime(2019, 6, 19, 21, 1, 21, 994, DateTimeKind.Unspecified).AddTicks(7223), new DateTime(2021, 10, 6, 21, 7, 8, 216, DateTimeKind.Unspecified).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 11, 7, 5, 25, 17, 623, DateTimeKind.Unspecified).AddTicks(7361), 2L, new DateTime(2022, 1, 31, 9, 23, 25, 561, DateTimeKind.Unspecified).AddTicks(5732), 35L, new DateTime(2019, 6, 24, 22, 32, 10, 661, DateTimeKind.Unspecified).AddTicks(68), new DateTime(2021, 6, 19, 19, 8, 32, 710, DateTimeKind.Unspecified).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 5, 8, 4, 48, 51, 687, DateTimeKind.Unspecified).AddTicks(5330), 4L, null, new DateTime(2019, 2, 26, 6, 20, 9, 708, DateTimeKind.Unspecified).AddTicks(1946), new DateTime(2021, 10, 19, 13, 30, 30, 486, DateTimeKind.Unspecified).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 16L, new DateTime(2021, 6, 6, 4, 10, 32, 715, DateTimeKind.Unspecified).AddTicks(5720), 4L, null, 13L, new DateTime(2019, 7, 5, 14, 4, 0, 553, DateTimeKind.Unspecified).AddTicks(9123), new DateTime(2021, 1, 8, 21, 9, 41, 616, DateTimeKind.Unspecified).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 44L, new DateTime(2021, 11, 23, 6, 24, 36, 20, DateTimeKind.Unspecified).AddTicks(9727), 3L, new DateTime(2022, 1, 11, 1, 32, 29, 739, DateTimeKind.Unspecified).AddTicks(7657), 21L, new DateTime(2019, 12, 14, 10, 35, 31, 742, DateTimeKind.Unspecified).AddTicks(6963), new DateTime(2021, 11, 29, 19, 5, 0, 994, DateTimeKind.Unspecified).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 6, 28, 2, 40, 51, 751, DateTimeKind.Unspecified).AddTicks(8372), new DateTime(2022, 1, 26, 2, 5, 37, 689, DateTimeKind.Unspecified).AddTicks(8369), 62L, new DateTime(2019, 10, 26, 15, 40, 12, 133, DateTimeKind.Unspecified).AddTicks(1105), new DateTime(2021, 7, 31, 12, 32, 29, 477, DateTimeKind.Unspecified).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 10, 17, 17, 52, 49, 347, DateTimeKind.Unspecified).AddTicks(9704), 5L, null, 71L, new DateTime(2019, 3, 27, 22, 49, 44, 710, DateTimeKind.Unspecified).AddTicks(9328), new DateTime(2021, 11, 6, 10, 15, 11, 705, DateTimeKind.Unspecified).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2021, 8, 16, 18, 52, 19, 61, DateTimeKind.Unspecified).AddTicks(6212), new DateTime(2022, 1, 14, 5, 44, 1, 751, DateTimeKind.Unspecified).AddTicks(5359), 34L, new DateTime(2020, 1, 10, 8, 23, 13, 396, DateTimeKind.Unspecified).AddTicks(1309), new DateTime(2021, 4, 16, 18, 40, 37, 65, DateTimeKind.Unspecified).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 7L, new DateTime(2021, 5, 24, 0, 31, 51, 112, DateTimeKind.Unspecified).AddTicks(8697), 2L, null, 72L, new DateTime(2019, 4, 13, 9, 58, 33, 486, DateTimeKind.Unspecified).AddTicks(7731), new DateTime(2021, 4, 16, 19, 47, 7, 402, DateTimeKind.Unspecified).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 4, 8, 19, 22, 52, 999, DateTimeKind.Unspecified).AddTicks(9748), 1L, null, 31L, new DateTime(2019, 9, 30, 6, 11, 7, 539, DateTimeKind.Unspecified).AddTicks(2582), new DateTime(2021, 1, 2, 9, 40, 24, 176, DateTimeKind.Unspecified).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 10, 25, 23, 52, 51, 625, DateTimeKind.Unspecified).AddTicks(552), 2L, new DateTime(2022, 1, 8, 18, 44, 49, 409, DateTimeKind.Unspecified).AddTicks(6644), new DateTime(2019, 4, 27, 3, 14, 33, 671, DateTimeKind.Unspecified).AddTicks(2272), new DateTime(2021, 10, 30, 5, 58, 12, 487, DateTimeKind.Unspecified).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 3, 23, 5, 8, 44, 700, DateTimeKind.Unspecified).AddTicks(527), 5L, new DateTime(2022, 1, 14, 5, 36, 4, 461, DateTimeKind.Unspecified).AddTicks(6683), 11L, new DateTime(2020, 1, 2, 12, 59, 28, 193, DateTimeKind.Unspecified).AddTicks(8240), new DateTime(2021, 1, 8, 12, 57, 51, 67, DateTimeKind.Unspecified).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 14L, new DateTime(2021, 2, 12, 4, 29, 7, 33, DateTimeKind.Unspecified).AddTicks(5276), 3L, new DateTime(2022, 1, 17, 22, 23, 25, 994, DateTimeKind.Unspecified).AddTicks(475), 18L, new DateTime(2019, 7, 27, 19, 17, 16, 380, DateTimeKind.Unspecified).AddTicks(5975), new DateTime(2021, 4, 27, 22, 30, 15, 836, DateTimeKind.Unspecified).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 5, 23, 20, 28, 36, 375, DateTimeKind.Unspecified).AddTicks(8919), 4L, new DateTime(2022, 1, 24, 7, 28, 28, 830, DateTimeKind.Unspecified).AddTicks(7223), 64L, new DateTime(2019, 8, 20, 16, 42, 54, 341, DateTimeKind.Unspecified).AddTicks(9957), new DateTime(2021, 5, 18, 13, 7, 29, 273, DateTimeKind.Unspecified).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 10L, new DateTime(2021, 11, 13, 23, 46, 18, 373, DateTimeKind.Unspecified).AddTicks(1948), new DateTime(2022, 1, 19, 5, 58, 37, 323, DateTimeKind.Unspecified).AddTicks(8944), 51L, new DateTime(2019, 12, 4, 22, 19, 49, 370, DateTimeKind.Unspecified).AddTicks(6800), new DateTime(2021, 8, 5, 19, 31, 57, 978, DateTimeKind.Unspecified).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 11, 12, 1, 26, 47, 260, DateTimeKind.Unspecified).AddTicks(5932), 5L, null, 69L, new DateTime(2020, 1, 10, 19, 41, 4, 190, DateTimeKind.Unspecified).AddTicks(8380), new DateTime(2021, 3, 27, 11, 58, 0, 288, DateTimeKind.Unspecified).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 43L, new DateTime(2021, 7, 13, 14, 8, 29, 853, DateTimeKind.Unspecified).AddTicks(1558), 3L, new DateTime(2022, 1, 18, 1, 46, 24, 34, DateTimeKind.Unspecified).AddTicks(9391), 66L, new DateTime(2019, 12, 4, 3, 14, 46, 434, DateTimeKind.Unspecified).AddTicks(3042), new DateTime(2021, 11, 28, 13, 52, 38, 288, DateTimeKind.Unspecified).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 44L, new DateTime(2021, 10, 12, 22, 22, 35, 864, DateTimeKind.Unspecified).AddTicks(840), new DateTime(2022, 2, 1, 13, 23, 12, 52, DateTimeKind.Unspecified).AddTicks(7280), 66L, new DateTime(2019, 10, 2, 2, 51, 25, 182, DateTimeKind.Unspecified).AddTicks(4391), new DateTime(2021, 4, 9, 22, 34, 8, 112, DateTimeKind.Unspecified).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 3, 11, 20, 53, 25, 978, DateTimeKind.Unspecified).AddTicks(9978), 4L, new DateTime(2022, 1, 13, 12, 28, 20, 702, DateTimeKind.Unspecified).AddTicks(1219), 27L, new DateTime(2019, 10, 25, 23, 55, 49, 6, DateTimeKind.Unspecified).AddTicks(3100), new DateTime(2021, 9, 19, 19, 6, 57, 266, DateTimeKind.Unspecified).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 14L, new DateTime(2021, 6, 23, 22, 45, 1, 126, DateTimeKind.Unspecified).AddTicks(8341), 3L, null, 34L, new DateTime(2019, 2, 27, 22, 52, 54, 861, DateTimeKind.Unspecified).AddTicks(6215), new DateTime(2021, 4, 24, 3, 9, 50, 492, DateTimeKind.Unspecified).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 14L, new DateTime(2021, 9, 25, 8, 56, 41, 333, DateTimeKind.Unspecified).AddTicks(982), 5L, new DateTime(2022, 1, 9, 9, 48, 46, 66, DateTimeKind.Unspecified).AddTicks(7846), 44L, new DateTime(2019, 8, 1, 16, 18, 3, 187, DateTimeKind.Unspecified).AddTicks(8622), new DateTime(2021, 7, 3, 22, 57, 16, 111, DateTimeKind.Unspecified).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 10, 30, 16, 28, 24, 268, DateTimeKind.Unspecified).AddTicks(9838), 2L, new DateTime(2022, 1, 7, 1, 19, 12, 312, DateTimeKind.Unspecified).AddTicks(4270), 57L, new DateTime(2020, 1, 22, 15, 51, 25, 238, DateTimeKind.Unspecified).AddTicks(8543), new DateTime(2021, 1, 5, 17, 49, 1, 828, DateTimeKind.Unspecified).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 3, 28, 17, 27, 56, 163, DateTimeKind.Unspecified).AddTicks(7936), 4L, new DateTime(2022, 1, 27, 2, 58, 37, 678, DateTimeKind.Unspecified).AddTicks(2628), 53L, new DateTime(2020, 1, 13, 7, 35, 41, 792, DateTimeKind.Unspecified).AddTicks(7676), new DateTime(2021, 8, 26, 0, 52, 23, 163, DateTimeKind.Unspecified).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 2, 26, 12, 9, 23, 340, DateTimeKind.Unspecified).AddTicks(6783), new DateTime(2022, 1, 10, 10, 40, 58, 704, DateTimeKind.Unspecified).AddTicks(9946), 45L, new DateTime(2019, 11, 19, 9, 35, 5, 523, DateTimeKind.Unspecified).AddTicks(3773), new DateTime(2021, 8, 21, 14, 52, 3, 877, DateTimeKind.Unspecified).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 5, 5, 18, 6, 14, 337, DateTimeKind.Unspecified).AddTicks(5694), 1L, new DateTime(2022, 1, 7, 2, 8, 26, 665, DateTimeKind.Unspecified).AddTicks(6655), 81L, new DateTime(2019, 4, 28, 13, 55, 43, 422, DateTimeKind.Unspecified).AddTicks(2693), new DateTime(2021, 5, 17, 21, 41, 31, 728, DateTimeKind.Unspecified).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 11, 9, 1, 39, 4, 592, DateTimeKind.Unspecified).AddTicks(1806), 2L, new DateTime(2022, 1, 7, 10, 51, 34, 679, DateTimeKind.Unspecified).AddTicks(3768), 67L, new DateTime(2019, 3, 25, 23, 42, 35, 497, DateTimeKind.Unspecified).AddTicks(1556), new DateTime(2021, 1, 14, 4, 12, 29, 966, DateTimeKind.Unspecified).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 3, 23, 23, 12, 57, 200, DateTimeKind.Unspecified).AddTicks(9866), new DateTime(2022, 1, 31, 21, 46, 25, 559, DateTimeKind.Unspecified).AddTicks(4195), 62L, new DateTime(2019, 2, 20, 4, 46, 35, 98, DateTimeKind.Unspecified).AddTicks(103), new DateTime(2021, 1, 1, 18, 33, 2, 933, DateTimeKind.Unspecified).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 8, 9, 21, 59, 4, 961, DateTimeKind.Unspecified).AddTicks(7784), 5L, new DateTime(2022, 2, 1, 7, 11, 25, 240, DateTimeKind.Unspecified).AddTicks(8604), 28L, new DateTime(2019, 4, 6, 8, 0, 48, 882, DateTimeKind.Unspecified).AddTicks(7229), new DateTime(2021, 5, 31, 15, 23, 34, 113, DateTimeKind.Unspecified).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2022, 1, 12, 12, 28, 35, 868, DateTimeKind.Unspecified).AddTicks(7264), 4L, new DateTime(2022, 1, 4, 23, 37, 39, 226, DateTimeKind.Unspecified).AddTicks(1010), 2L, new DateTime(2019, 5, 18, 7, 38, 19, 435, DateTimeKind.Unspecified).AddTicks(2439), new DateTime(2021, 4, 4, 13, 42, 49, 404, DateTimeKind.Unspecified).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 9, 12, 12, 13, 25, 959, DateTimeKind.Unspecified).AddTicks(9217), 4L, new DateTime(2022, 1, 29, 12, 51, 12, 847, DateTimeKind.Unspecified).AddTicks(839), 13L, new DateTime(2019, 7, 3, 9, 20, 31, 200, DateTimeKind.Unspecified).AddTicks(9417), new DateTime(2021, 1, 26, 17, 33, 42, 855, DateTimeKind.Unspecified).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2022, 1, 29, 14, 31, 30, 792, DateTimeKind.Unspecified).AddTicks(1558), 2L, new DateTime(2022, 1, 19, 10, 46, 0, 807, DateTimeKind.Unspecified).AddTicks(9227), 57L, new DateTime(2019, 9, 17, 9, 34, 51, 146, DateTimeKind.Unspecified).AddTicks(5090), new DateTime(2021, 1, 23, 19, 15, 14, 196, DateTimeKind.Unspecified).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 2L, new DateTime(2021, 7, 25, 13, 0, 7, 893, DateTimeKind.Unspecified).AddTicks(7495), 3L, new DateTime(2022, 1, 17, 22, 12, 40, 443, DateTimeKind.Unspecified).AddTicks(4147), 38L, new DateTime(2019, 11, 15, 16, 47, 8, 993, DateTimeKind.Unspecified).AddTicks(6422), new DateTime(2021, 4, 30, 10, 8, 1, 356, DateTimeKind.Unspecified).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 2, 21, 19, 23, 0, 763, DateTimeKind.Unspecified).AddTicks(8434), 4L, new DateTime(2022, 1, 27, 7, 42, 24, 907, DateTimeKind.Unspecified).AddTicks(5798), 81L, new DateTime(2019, 11, 11, 2, 18, 35, 402, DateTimeKind.Unspecified).AddTicks(5370), new DateTime(2021, 9, 20, 12, 21, 8, 648, DateTimeKind.Unspecified).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 5, 28, 17, 12, 47, 959, DateTimeKind.Unspecified).AddTicks(6266), 3L, new DateTime(2022, 1, 1, 16, 12, 28, 442, DateTimeKind.Unspecified).AddTicks(3432), 61L, new DateTime(2019, 10, 21, 14, 6, 50, 668, DateTimeKind.Unspecified).AddTicks(4191), new DateTime(2021, 11, 29, 1, 20, 1, 155, DateTimeKind.Unspecified).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2022, 1, 27, 1, 33, 54, 979, DateTimeKind.Unspecified).AddTicks(7782), 5L, new DateTime(2022, 1, 8, 7, 31, 42, 425, DateTimeKind.Unspecified).AddTicks(4880), 23L, new DateTime(2019, 5, 27, 2, 28, 46, 57, DateTimeKind.Unspecified).AddTicks(2818), new DateTime(2021, 8, 3, 12, 29, 19, 488, DateTimeKind.Unspecified).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 12, 17, 19, 0, 59, 670, DateTimeKind.Unspecified).AddTicks(9078), new DateTime(2022, 1, 2, 11, 34, 22, 795, DateTimeKind.Unspecified).AddTicks(6033), 49L, new DateTime(2019, 3, 6, 12, 17, 17, 614, DateTimeKind.Unspecified).AddTicks(4690), new DateTime(2021, 2, 12, 1, 16, 37, 589, DateTimeKind.Unspecified).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 9, 17, 5, 3, 38, 901, DateTimeKind.Unspecified).AddTicks(8319), 4L, new DateTime(2022, 1, 6, 23, 51, 26, 561, DateTimeKind.Unspecified).AddTicks(627), 70L, new DateTime(2019, 7, 14, 11, 45, 47, 79, DateTimeKind.Unspecified).AddTicks(7617), new DateTime(2021, 5, 15, 0, 36, 47, 555, DateTimeKind.Unspecified).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 8, 15, 0, 42, 1, 530, DateTimeKind.Unspecified).AddTicks(9632), 1L, new DateTime(2022, 1, 9, 8, 14, 59, 597, DateTimeKind.Unspecified).AddTicks(3606), 68L, new DateTime(2019, 10, 2, 11, 14, 35, 636, DateTimeKind.Unspecified).AddTicks(4817), new DateTime(2021, 8, 19, 5, 41, 36, 229, DateTimeKind.Unspecified).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 2, 15, 18, 50, 30, 407, DateTimeKind.Unspecified).AddTicks(7747), 4L, new DateTime(2022, 1, 15, 1, 31, 46, 987, DateTimeKind.Unspecified).AddTicks(2316), 29L, new DateTime(2019, 3, 8, 22, 6, 11, 116, DateTimeKind.Unspecified).AddTicks(2967), new DateTime(2021, 11, 5, 18, 33, 36, 767, DateTimeKind.Unspecified).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 5, 25, 15, 18, 36, 254, DateTimeKind.Unspecified).AddTicks(7234), 3L, new DateTime(2022, 1, 31, 15, 19, 9, 753, DateTimeKind.Unspecified).AddTicks(5158), 45L, new DateTime(2019, 4, 9, 20, 23, 31, 954, DateTimeKind.Unspecified).AddTicks(65), new DateTime(2021, 10, 22, 6, 58, 20, 331, DateTimeKind.Unspecified).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 4, 4, 21, 24, 11, 966, DateTimeKind.Unspecified).AddTicks(489), 2L, new DateTime(2022, 1, 31, 18, 53, 48, 832, DateTimeKind.Unspecified).AddTicks(54), 58L, new DateTime(2019, 3, 20, 5, 34, 22, 428, DateTimeKind.Unspecified).AddTicks(233), new DateTime(2021, 11, 23, 11, 53, 16, 591, DateTimeKind.Unspecified).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 2L, new DateTime(2022, 1, 2, 22, 0, 37, 847, DateTimeKind.Unspecified).AddTicks(9373), new DateTime(2022, 1, 27, 14, 59, 49, 450, DateTimeKind.Unspecified).AddTicks(3338), 20L, new DateTime(2019, 3, 15, 7, 24, 0, 912, DateTimeKind.Unspecified).AddTicks(7628), new DateTime(2021, 11, 7, 15, 10, 55, 942, DateTimeKind.Unspecified).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 11, 18, 11, 46, 15, 483, DateTimeKind.Unspecified).AddTicks(3896), 5L, new DateTime(2022, 1, 9, 18, 44, 45, 399, DateTimeKind.Unspecified).AddTicks(2657), 50L, new DateTime(2019, 2, 12, 19, 12, 43, 910, DateTimeKind.Unspecified).AddTicks(1380), new DateTime(2021, 7, 30, 22, 27, 17, 793, DateTimeKind.Unspecified).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 46L, new DateTime(2021, 4, 20, 12, 1, 21, 249, DateTimeKind.Unspecified).AddTicks(9114), 3L, new DateTime(2022, 1, 29, 22, 24, 27, 496, DateTimeKind.Unspecified).AddTicks(5102), 12L, new DateTime(2019, 6, 28, 7, 24, 7, 619, DateTimeKind.Unspecified).AddTicks(2241), new DateTime(2021, 3, 24, 3, 42, 53, 994, DateTimeKind.Unspecified).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 45L, new DateTime(2021, 11, 20, 2, 8, 41, 910, DateTimeKind.Unspecified).AddTicks(7649), 5L, new DateTime(2022, 1, 26, 12, 4, 39, 294, DateTimeKind.Unspecified).AddTicks(9447), 53L, new DateTime(2019, 12, 5, 9, 39, 46, 148, DateTimeKind.Unspecified).AddTicks(8117), new DateTime(2021, 7, 27, 19, 24, 37, 287, DateTimeKind.Unspecified).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 7, 3, 13, 11, 59, 276, DateTimeKind.Unspecified).AddTicks(4936), 5L, new DateTime(2022, 1, 18, 10, 40, 35, 241, DateTimeKind.Unspecified).AddTicks(3520), 53L, new DateTime(2019, 8, 9, 8, 26, 1, 548, DateTimeKind.Unspecified).AddTicks(2263), new DateTime(2021, 8, 11, 7, 21, 6, 39, DateTimeKind.Unspecified).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 10, 26, 20, 21, 4, 952, DateTimeKind.Unspecified).AddTicks(9932), new DateTime(2022, 1, 20, 7, 45, 54, 845, DateTimeKind.Unspecified).AddTicks(7291), 69L, new DateTime(2019, 8, 16, 14, 24, 26, 64, DateTimeKind.Unspecified).AddTicks(3044), new DateTime(2021, 11, 16, 9, 14, 49, 723, DateTimeKind.Unspecified).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 4, 30, 12, 40, 45, 265, DateTimeKind.Unspecified).AddTicks(521), 5L, new DateTime(2022, 1, 29, 17, 46, 38, 927, DateTimeKind.Unspecified).AddTicks(8913), 69L, new DateTime(2019, 2, 2, 17, 32, 32, 308, DateTimeKind.Unspecified).AddTicks(4637), new DateTime(2021, 10, 3, 15, 48, 49, 348, DateTimeKind.Unspecified).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 10, 7, 3, 19, 45, 258, DateTimeKind.Unspecified).AddTicks(1110), 2L, new DateTime(2022, 1, 31, 21, 15, 21, 806, DateTimeKind.Unspecified).AddTicks(999), 47L, new DateTime(2019, 8, 30, 6, 1, 53, 662, DateTimeKind.Unspecified).AddTicks(6404), new DateTime(2021, 1, 17, 4, 34, 58, 417, DateTimeKind.Unspecified).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 2, 17, 18, 7, 42, 92, DateTimeKind.Unspecified).AddTicks(2333), new DateTime(2022, 1, 5, 15, 47, 33, 184, DateTimeKind.Unspecified).AddTicks(7921), 43L, new DateTime(2019, 6, 3, 1, 48, 11, 725, DateTimeKind.Unspecified).AddTicks(5238), new DateTime(2021, 1, 27, 5, 57, 57, 246, DateTimeKind.Unspecified).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 10, 8, 6, 19, 8, 436, DateTimeKind.Unspecified).AddTicks(264), 3L, null, 5L, new DateTime(2019, 10, 27, 13, 0, 41, 624, DateTimeKind.Unspecified).AddTicks(4859), new DateTime(2021, 4, 27, 13, 47, 12, 908, DateTimeKind.Unspecified).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 6, 14, 14, 36, 26, 470, DateTimeKind.Unspecified).AddTicks(8177), 3L, new DateTime(2022, 1, 26, 0, 15, 34, 79, DateTimeKind.Unspecified).AddTicks(2228), 48L, new DateTime(2020, 1, 21, 22, 1, 54, 944, DateTimeKind.Unspecified).AddTicks(9643), new DateTime(2021, 7, 12, 17, 51, 40, 660, DateTimeKind.Unspecified).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 3, 9, 22, 37, 10, 427, DateTimeKind.Unspecified).AddTicks(7978), 1L, new DateTime(2022, 1, 31, 11, 23, 19, 377, DateTimeKind.Unspecified).AddTicks(4754), 43L, new DateTime(2019, 5, 30, 11, 33, 27, 962, DateTimeKind.Unspecified).AddTicks(644), new DateTime(2021, 10, 14, 12, 12, 27, 236, DateTimeKind.Unspecified).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 8, 10, 14, 36, 5, 721, DateTimeKind.Unspecified).AddTicks(6242), 2L, new DateTime(2022, 1, 23, 14, 57, 15, 872, DateTimeKind.Unspecified).AddTicks(8928), 81L, new DateTime(2019, 6, 6, 11, 3, 46, 59, DateTimeKind.Unspecified).AddTicks(6789), new DateTime(2021, 4, 13, 13, 9, 5, 217, DateTimeKind.Unspecified).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 9, 17, 3, 58, 29, 568, DateTimeKind.Unspecified).AddTicks(1764), 2L, new DateTime(2022, 1, 3, 3, 13, 46, 659, DateTimeKind.Unspecified).AddTicks(500), 74L, new DateTime(2020, 1, 9, 12, 58, 3, 932, DateTimeKind.Unspecified).AddTicks(4021), new DateTime(2021, 12, 10, 13, 54, 9, 863, DateTimeKind.Unspecified).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 41L, new DateTime(2021, 12, 30, 6, 44, 6, 289, DateTimeKind.Unspecified).AddTicks(574), 3L, new DateTime(2022, 1, 13, 22, 37, 25, 841, DateTimeKind.Unspecified).AddTicks(5947), 10L, new DateTime(2019, 7, 23, 10, 26, 10, 54, DateTimeKind.Unspecified).AddTicks(2521), new DateTime(2021, 8, 24, 13, 16, 15, 286, DateTimeKind.Unspecified).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 5, 6, 12, 43, 0, 558, DateTimeKind.Unspecified).AddTicks(1425), 2L, new DateTime(2022, 1, 28, 16, 30, 0, 191, DateTimeKind.Unspecified).AddTicks(6581), 19L, new DateTime(2019, 6, 3, 12, 26, 3, 680, DateTimeKind.Unspecified).AddTicks(6965), new DateTime(2021, 7, 5, 17, 44, 28, 109, DateTimeKind.Unspecified).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 19L, new DateTime(2022, 1, 20, 7, 34, 41, 703, DateTimeKind.Unspecified).AddTicks(110), new DateTime(2022, 1, 12, 16, 40, 46, 936, DateTimeKind.Unspecified).AddTicks(4103), 26L, new DateTime(2019, 12, 2, 1, 42, 56, 200, DateTimeKind.Unspecified).AddTicks(4196), new DateTime(2021, 2, 24, 9, 50, 49, 885, DateTimeKind.Unspecified).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 4, 26, 8, 1, 37, 654, DateTimeKind.Unspecified).AddTicks(5364), 5L, new DateTime(2022, 1, 2, 12, 1, 5, 836, DateTimeKind.Unspecified).AddTicks(9191), 76L, new DateTime(2019, 10, 8, 18, 32, 13, 832, DateTimeKind.Unspecified).AddTicks(7525), new DateTime(2021, 4, 20, 21, 18, 40, 62, DateTimeKind.Unspecified).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 7L, new DateTime(2021, 7, 14, 17, 30, 24, 823, DateTimeKind.Unspecified).AddTicks(3776), null, 21L, new DateTime(2019, 7, 17, 3, 39, 23, 105, DateTimeKind.Unspecified).AddTicks(320), new DateTime(2021, 7, 29, 18, 22, 38, 717, DateTimeKind.Unspecified).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 3, 30, 14, 53, 4, 395, DateTimeKind.Unspecified).AddTicks(2786), 5L, new DateTime(2022, 1, 18, 2, 36, 6, 506, DateTimeKind.Unspecified).AddTicks(3112), 76L, new DateTime(2019, 5, 19, 19, 10, 35, 947, DateTimeKind.Unspecified).AddTicks(9674), new DateTime(2021, 8, 13, 7, 48, 31, 714, DateTimeKind.Unspecified).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 11, 14, 10, 27, 45, 494, DateTimeKind.Unspecified).AddTicks(3701), 1L, new DateTime(2022, 1, 10, 21, 0, 32, 259, DateTimeKind.Unspecified).AddTicks(33), 81L, new DateTime(2019, 6, 5, 12, 11, 40, 422, DateTimeKind.Unspecified).AddTicks(914), new DateTime(2021, 4, 28, 21, 3, 17, 137, DateTimeKind.Unspecified).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 4L, new DateTime(2021, 5, 7, 17, 10, 0, 353, DateTimeKind.Unspecified).AddTicks(6959), 3L, new DateTime(2022, 1, 19, 20, 1, 50, 8, DateTimeKind.Unspecified).AddTicks(6637), 63L, new DateTime(2020, 1, 25, 10, 53, 15, 628, DateTimeKind.Unspecified).AddTicks(9399), new DateTime(2021, 5, 15, 22, 37, 53, 333, DateTimeKind.Unspecified).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 2, 28, 15, 46, 54, 355, DateTimeKind.Unspecified).AddTicks(8335), 4L, new DateTime(2022, 1, 24, 6, 10, 34, 864, DateTimeKind.Unspecified).AddTicks(3600), 21L, new DateTime(2019, 6, 2, 20, 42, 19, 954, DateTimeKind.Unspecified).AddTicks(41), new DateTime(2021, 2, 4, 3, 28, 51, 90, DateTimeKind.Unspecified).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 40L, new DateTime(2021, 9, 15, 3, 53, 35, 9, DateTimeKind.Unspecified).AddTicks(8866), 5L, new DateTime(2022, 1, 18, 2, 25, 52, 668, DateTimeKind.Unspecified).AddTicks(4012), 37L, new DateTime(2020, 1, 22, 14, 1, 49, 664, DateTimeKind.Unspecified).AddTicks(7811), new DateTime(2021, 10, 24, 3, 0, 35, 191, DateTimeKind.Unspecified).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 7, 15, 13, 12, 54, 270, DateTimeKind.Unspecified).AddTicks(8040), 2L, new DateTime(2022, 1, 5, 16, 27, 0, 526, DateTimeKind.Unspecified).AddTicks(9314), 17L, new DateTime(2019, 9, 14, 5, 25, 49, 951, DateTimeKind.Unspecified).AddTicks(7845), new DateTime(2021, 3, 15, 17, 43, 5, 347, DateTimeKind.Unspecified).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 2, 23, 5, 3, 53, 399, DateTimeKind.Unspecified).AddTicks(9227), 3L, new DateTime(2022, 1, 1, 8, 32, 18, 232, DateTimeKind.Unspecified).AddTicks(4839), 53L, new DateTime(2019, 7, 20, 4, 46, 41, 233, DateTimeKind.Unspecified).AddTicks(9657), new DateTime(2021, 9, 21, 23, 45, 48, 366, DateTimeKind.Unspecified).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 12L, new DateTime(2021, 9, 3, 23, 47, 18, 372, DateTimeKind.Unspecified).AddTicks(3464), 3L, null, 75L, new DateTime(2020, 1, 21, 12, 51, 44, 12, DateTimeKind.Unspecified).AddTicks(9579), new DateTime(2021, 10, 17, 20, 35, 37, 66, DateTimeKind.Unspecified).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 7, 4, 11, 15, 54, 6, DateTimeKind.Unspecified).AddTicks(4047), new DateTime(2022, 1, 20, 19, 27, 8, 733, DateTimeKind.Unspecified).AddTicks(8121), 26L, new DateTime(2019, 5, 23, 5, 34, 35, 0, DateTimeKind.Unspecified).AddTicks(9586), new DateTime(2021, 5, 20, 7, 9, 54, 810, DateTimeKind.Unspecified).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 8, 12, 2, 3, 12, 437, DateTimeKind.Unspecified).AddTicks(5971), 1L, new DateTime(2022, 1, 4, 0, 22, 59, 937, DateTimeKind.Unspecified).AddTicks(4363), 33L, new DateTime(2019, 8, 16, 3, 41, 51, 641, DateTimeKind.Unspecified).AddTicks(3417), new DateTime(2021, 3, 16, 23, 51, 59, 796, DateTimeKind.Unspecified).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 13L, new DateTime(2021, 9, 13, 9, 42, 59, 255, DateTimeKind.Unspecified).AddTicks(265), 2L, new DateTime(2022, 1, 15, 10, 34, 9, 909, DateTimeKind.Unspecified).AddTicks(5051), 72L, new DateTime(2019, 3, 24, 1, 31, 31, 930, DateTimeKind.Unspecified).AddTicks(7854), new DateTime(2021, 3, 5, 19, 54, 50, 692, DateTimeKind.Unspecified).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 48L, new DateTime(2021, 8, 17, 19, 53, 34, 420, DateTimeKind.Unspecified).AddTicks(18), new DateTime(2022, 1, 23, 6, 36, 44, 736, DateTimeKind.Unspecified).AddTicks(7952), 71L, new DateTime(2019, 10, 9, 23, 52, 22, 173, DateTimeKind.Unspecified).AddTicks(4748), new DateTime(2021, 8, 5, 6, 32, 48, 523, DateTimeKind.Unspecified).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 30L, new DateTime(2021, 11, 9, 14, 52, 22, 419, DateTimeKind.Unspecified).AddTicks(3244), 1L, new DateTime(2022, 1, 16, 14, 58, 47, 964, DateTimeKind.Unspecified).AddTicks(6484), 42L, new DateTime(2019, 6, 15, 2, 46, 52, 666, DateTimeKind.Unspecified).AddTicks(4357), new DateTime(2021, 9, 25, 10, 25, 22, 507, DateTimeKind.Unspecified).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 29L, new DateTime(2021, 6, 15, 9, 59, 38, 894, DateTimeKind.Unspecified).AddTicks(3443), 2L, new DateTime(2022, 1, 10, 1, 55, 33, 532, DateTimeKind.Unspecified).AddTicks(9848), 53L, new DateTime(2019, 10, 21, 17, 10, 27, 411, DateTimeKind.Unspecified).AddTicks(5254), new DateTime(2021, 6, 6, 12, 39, 21, 970, DateTimeKind.Unspecified).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 25L, new DateTime(2021, 4, 7, 22, 11, 13, 170, DateTimeKind.Unspecified).AddTicks(5829), 1L, null, 2L, new DateTime(2019, 6, 1, 20, 53, 26, 361, DateTimeKind.Unspecified).AddTicks(2528), new DateTime(2021, 1, 15, 22, 32, 24, 929, DateTimeKind.Unspecified).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 6, 28, 19, 24, 54, 385, DateTimeKind.Unspecified).AddTicks(738), 4L, new DateTime(2022, 1, 14, 6, 24, 25, 100, DateTimeKind.Unspecified).AddTicks(7745), 38L, new DateTime(2019, 12, 24, 6, 57, 37, 464, DateTimeKind.Unspecified).AddTicks(9838), new DateTime(2021, 3, 26, 8, 50, 44, 500, DateTimeKind.Unspecified).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 47L, new DateTime(2021, 9, 22, 22, 34, 30, 819, DateTimeKind.Unspecified).AddTicks(9730), 5L, new DateTime(2022, 1, 8, 1, 26, 23, 573, DateTimeKind.Unspecified).AddTicks(532), 72L, new DateTime(2020, 1, 21, 17, 35, 0, 438, DateTimeKind.Unspecified).AddTicks(3784), new DateTime(2021, 8, 20, 5, 30, 54, 331, DateTimeKind.Unspecified).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 5, 31, 16, 51, 47, 75, DateTimeKind.Unspecified).AddTicks(549), new DateTime(2022, 1, 9, 16, 50, 6, 828, DateTimeKind.Unspecified).AddTicks(3244), new DateTime(2020, 1, 2, 6, 47, 38, 994, DateTimeKind.Unspecified).AddTicks(9647), new DateTime(2021, 3, 22, 7, 55, 49, 199, DateTimeKind.Unspecified).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 6, 19, 10, 25, 41, 456, DateTimeKind.Unspecified).AddTicks(4591), 5L, new DateTime(2022, 1, 10, 23, 35, 47, 114, DateTimeKind.Unspecified).AddTicks(2971), 13L, new DateTime(2019, 10, 26, 13, 8, 4, 759, DateTimeKind.Unspecified).AddTicks(5599), new DateTime(2021, 1, 23, 11, 55, 1, 673, DateTimeKind.Unspecified).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 4, 6, 10, 6, 21, 528, DateTimeKind.Unspecified).AddTicks(4511), 4L, new DateTime(2022, 1, 5, 1, 56, 29, 51, DateTimeKind.Unspecified).AddTicks(9354), 19L, new DateTime(2019, 7, 14, 3, 35, 9, 134, DateTimeKind.Unspecified).AddTicks(95), new DateTime(2021, 9, 1, 3, 18, 9, 17, DateTimeKind.Unspecified).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 4, 21, 8, 11, 28, 380, DateTimeKind.Unspecified).AddTicks(1598), 4L, new DateTime(2022, 1, 14, 8, 51, 36, 22, DateTimeKind.Unspecified).AddTicks(9054), 36L, new DateTime(2019, 4, 27, 20, 11, 18, 137, DateTimeKind.Unspecified).AddTicks(7892), new DateTime(2021, 9, 8, 9, 7, 59, 995, DateTimeKind.Unspecified).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 38L, new DateTime(2021, 10, 21, 2, 51, 36, 167, DateTimeKind.Unspecified).AddTicks(1713), new DateTime(2022, 1, 31, 9, 12, 31, 391, DateTimeKind.Unspecified).AddTicks(3935), 31L, new DateTime(2019, 12, 13, 17, 11, 15, 393, DateTimeKind.Unspecified).AddTicks(9246), new DateTime(2021, 10, 24, 10, 42, 44, 982, DateTimeKind.Unspecified).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 3, 14, 4, 17, 26, 609, DateTimeKind.Unspecified).AddTicks(8470), 5L, new DateTime(2022, 1, 20, 3, 58, 53, 569, DateTimeKind.Unspecified).AddTicks(5348), 64L, new DateTime(2019, 9, 12, 19, 22, 26, 566, DateTimeKind.Unspecified).AddTicks(405), new DateTime(2021, 9, 28, 0, 41, 33, 380, DateTimeKind.Unspecified).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 3, 24, 7, 58, 21, 164, DateTimeKind.Unspecified).AddTicks(3931), 2L, new DateTime(2022, 1, 11, 13, 55, 56, 707, DateTimeKind.Unspecified).AddTicks(3311), 46L, new DateTime(2019, 6, 11, 1, 11, 13, 560, DateTimeKind.Unspecified).AddTicks(6884), new DateTime(2021, 8, 6, 23, 6, 6, 586, DateTimeKind.Unspecified).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 22L, new DateTime(2021, 4, 3, 19, 59, 7, 234, DateTimeKind.Unspecified).AddTicks(84), 2L, new DateTime(2022, 1, 2, 7, 0, 44, 594, DateTimeKind.Unspecified).AddTicks(2445), 76L, new DateTime(2019, 6, 27, 17, 1, 29, 974, DateTimeKind.Unspecified).AddTicks(7702), new DateTime(2021, 6, 12, 16, 7, 58, 164, DateTimeKind.Unspecified).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 11L, new DateTime(2021, 11, 25, 20, 2, 52, 760, DateTimeKind.Unspecified).AddTicks(3652), 5L, new DateTime(2022, 1, 24, 18, 5, 7, 844, DateTimeKind.Unspecified).AddTicks(3070), 60L, new DateTime(2019, 10, 2, 10, 4, 20, 397, DateTimeKind.Unspecified).AddTicks(6255), new DateTime(2021, 7, 12, 5, 5, 16, 402, DateTimeKind.Unspecified).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 33L, new DateTime(2021, 2, 6, 23, 40, 57, 291, DateTimeKind.Unspecified).AddTicks(497), 4L, new DateTime(2022, 1, 31, 11, 35, 39, 336, DateTimeKind.Unspecified).AddTicks(2866), 7L, new DateTime(2019, 8, 26, 19, 37, 5, 253, DateTimeKind.Unspecified).AddTicks(472), new DateTime(2021, 11, 4, 16, 0, 15, 40, DateTimeKind.Unspecified).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 7L, new DateTime(2021, 7, 6, 11, 32, 32, 979, DateTimeKind.Unspecified).AddTicks(3009), 1L, new DateTime(2022, 1, 9, 12, 36, 5, 383, DateTimeKind.Unspecified).AddTicks(7296), 40L, new DateTime(2019, 4, 22, 15, 52, 17, 37, DateTimeKind.Unspecified).AddTicks(6078), new DateTime(2021, 7, 12, 16, 6, 0, 621, DateTimeKind.Unspecified).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 8, 17, 19, 2, 42, 284, DateTimeKind.Unspecified).AddTicks(6744), 5L, new DateTime(2022, 1, 21, 21, 20, 52, 467, DateTimeKind.Unspecified).AddTicks(9959), 27L, new DateTime(2019, 7, 21, 1, 29, 31, 614, DateTimeKind.Unspecified).AddTicks(4795), new DateTime(2021, 2, 1, 21, 30, 34, 222, DateTimeKind.Unspecified).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 3L, new DateTime(2021, 3, 5, 18, 24, 52, 964, DateTimeKind.Unspecified).AddTicks(4536), 4L, new DateTime(2022, 1, 7, 20, 40, 30, 871, DateTimeKind.Unspecified).AddTicks(7150), 3L, new DateTime(2019, 8, 9, 2, 7, 39, 772, DateTimeKind.Unspecified).AddTicks(7394), new DateTime(2021, 10, 7, 10, 38, 59, 511, DateTimeKind.Unspecified).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 32L, new DateTime(2021, 7, 22, 21, 43, 32, 416, DateTimeKind.Unspecified).AddTicks(2830), new DateTime(2022, 1, 26, 19, 20, 19, 311, DateTimeKind.Unspecified).AddTicks(3696), 76L, new DateTime(2019, 5, 17, 12, 50, 59, 802, DateTimeKind.Unspecified).AddTicks(4956), new DateTime(2021, 2, 22, 12, 27, 52, 703, DateTimeKind.Unspecified).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 35L, new DateTime(2021, 3, 27, 19, 20, 52, 451, DateTimeKind.Unspecified).AddTicks(4031), 4L, new DateTime(2022, 1, 4, 23, 31, 45, 280, DateTimeKind.Unspecified).AddTicks(826), 36L, new DateTime(2019, 4, 29, 1, 43, 34, 213, DateTimeKind.Unspecified).AddTicks(478), new DateTime(2021, 1, 20, 17, 25, 3, 444, DateTimeKind.Unspecified).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 6L, new DateTime(2021, 12, 23, 0, 46, 46, 960, DateTimeKind.Unspecified).AddTicks(1132), 5L, new DateTime(2022, 1, 12, 0, 37, 23, 963, DateTimeKind.Unspecified).AddTicks(9713), 49L, new DateTime(2019, 8, 3, 12, 33, 52, 71, DateTimeKind.Unspecified).AddTicks(9602), new DateTime(2021, 3, 2, 10, 4, 49, 328, DateTimeKind.Unspecified).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 44L, new DateTime(2021, 5, 1, 0, 0, 30, 471, DateTimeKind.Unspecified).AddTicks(3294), 5L, new DateTime(2022, 1, 28, 13, 58, 30, 923, DateTimeKind.Unspecified).AddTicks(8755), 7L, new DateTime(2019, 2, 14, 21, 2, 44, 101, DateTimeKind.Unspecified).AddTicks(965), new DateTime(2021, 6, 29, 11, 47, 31, 589, DateTimeKind.Unspecified).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Natus harum perspiciatis rerum omnis rem alias.\nNon doloremque aut.\nVel aut non quisquam consequuntur dolorem voluptas.\nDolorum soluta veniam itaque suscipit excepturi aspernatur pariatur.\nCum temporibus sunt.", new DateTime(2021, 11, 28, 7, 27, 57, 166, DateTimeKind.Unspecified).AddTicks(5207), 1L, 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 46L, "Sit in et qui quidem.\nFacere soluta officia exercitationem quos.\nPerferendis aut et quia voluptates debitis ut.\nCorporis eaque autem sequi quae at et.", new DateTime(2021, 4, 22, 12, 53, 26, 301, DateTimeKind.Unspecified).AddTicks(3993), 4L, 40L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Pariatur maiores ut fuga.\nQuae aut amet expedita et aut ea laudantium nam vel.\nDelectus possimus ratione.", new DateTime(2021, 12, 12, 2, 21, 48, 187, DateTimeKind.Unspecified).AddTicks(3695), 5L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 30L, "Nobis dolor doloremque accusamus sed debitis excepturi qui voluptatem neque.\nQuibusdam et sit fugiat suscipit quam est sed sunt quibusdam.", new DateTime(2021, 3, 26, 11, 35, 37, 920, DateTimeKind.Unspecified).AddTicks(3216), 17L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Quidem sint voluptas debitis nulla et quo quia voluptatem reiciendis.\nQui quae exercitationem numquam ratione.\nEum tempora totam id enim dolores rem.\nAccusantium harum fugit odit deserunt.", new DateTime(2021, 3, 3, 14, 43, 13, 110, DateTimeKind.Unspecified).AddTicks(3744), 4L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Doloribus veniam qui minus repellendus vel sunt ex.\nAdipisci quasi minima.\nIusto est animi et eaque eius voluptas.\nVero omnis qui.\nMollitia aut libero autem corporis possimus.\nQuam officia sequi numquam.", new DateTime(2021, 3, 1, 4, 36, 46, 202, DateTimeKind.Unspecified).AddTicks(6727), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Consequatur dolores tenetur aliquid.\nTempore et alias eum expedita cumque unde.\nDolores minus quia ullam amet impedit et.\nQuibusdam iusto rerum vero doloribus minima rem sint dolores ex.\nOfficia debitis corrupti esse et.", new DateTime(2021, 4, 30, 4, 45, 59, 691, DateTimeKind.Unspecified).AddTicks(7247), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Aut molestiae officiis reiciendis sit deleniti ea adipisci dolores numquam.\nNesciunt similique optio aut dolores perspiciatis reprehenderit iusto dicta.\nUllam ea a minus.", new DateTime(2021, 11, 13, 21, 2, 13, 368, DateTimeKind.Unspecified).AddTicks(4529), 3L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Qui est debitis suscipit sint.", new DateTime(2021, 2, 5, 19, 47, 14, 271, DateTimeKind.Unspecified).AddTicks(8322), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Eos beatae possimus porro sint quisquam vero qui occaecati eaque.\nVeniam tempore et voluptatem repudiandae.\nQuis neque ut aut.\nItaque est omnis eligendi commodi.", new DateTime(2021, 12, 16, 0, 35, 55, 674, DateTimeKind.Unspecified).AddTicks(5286), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Nemo iusto voluptas sed sit minus mollitia.\nHarum id labore illum quia sed provident.\nQuasi assumenda necessitatibus dolorem et ut.", new DateTime(2021, 12, 4, 13, 12, 49, 653, DateTimeKind.Unspecified).AddTicks(2873), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Commodi architecto maiores et aut.\nConsequatur commodi optio quo modi rerum similique ullam laboriosam.", new DateTime(2021, 11, 10, 7, 53, 26, 136, DateTimeKind.Unspecified).AddTicks(5424), 5L, 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Alias odio voluptas et dolorum aut suscipit earum amet.\nVero molestias et labore.\nDolorum sit itaque sunt quo dolorem autem.", new DateTime(2021, 10, 30, 15, 51, 52, 4, DateTimeKind.Unspecified).AddTicks(6718), 2L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Minus dignissimos velit recusandae id cupiditate ea harum.\nNam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.", new DateTime(2021, 2, 26, 12, 1, 35, 855, DateTimeKind.Unspecified).AddTicks(3844), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 44L, "Nam quia dicta eius doloribus commodi non nihil.\nQuod recusandae et est.\nDebitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.", new DateTime(2021, 10, 28, 3, 37, 20, 886, DateTimeKind.Unspecified).AddTicks(3829), 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 44L, "Est sit at placeat optio.\nSapiente pariatur et et enim.\nAccusamus molestiae labore.", new DateTime(2021, 6, 2, 19, 19, 7, 873, DateTimeKind.Unspecified).AddTicks(6561), 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 3L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 1L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Earum voluptate voluptatem.\nSunt sunt est non deleniti tempore provident nihil et omnis.", new DateTime(2021, 5, 22, 23, 42, 34, 208, DateTimeKind.Unspecified).AddTicks(457), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 1L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Libero dicta temporibus atque earum.\nReprehenderit eos qui eum totam.\nId cum adipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 4L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 1L, 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 5L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 1L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 8L, "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 2L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 1L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 3L, 47L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 3L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 2L, 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 1L, 65L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 3L, 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 3L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 3L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 5L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 3L, 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 25L, "Ipsam minima vel totam vel deserunt ab.\nEnim dolorem aliquid aperiam quod tempore porro ad nemo sit.\nNisi quis dolore nihil.", new DateTime(2021, 3, 28, 17, 3, 2, 998, DateTimeKind.Unspecified).AddTicks(838), 81L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Non fugiat non porro vero reiciendis et.\nEnim facere autem molestiae.", new DateTime(2021, 4, 1, 7, 35, 59, 215, DateTimeKind.Unspecified).AddTicks(830), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Quo corporis voluptatem.\nQuia ut architecto adipisci quasi at aliquid voluptatum et.\nConsequatur voluptate dolor doloribus quam ipsam rerum optio.\nAperiam aperiam et.", new DateTime(2021, 12, 23, 16, 16, 38, 159, DateTimeKind.Unspecified).AddTicks(4359), 1L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Qui quam perferendis itaque dolore eligendi expedita.\nFacilis distinctio et omnis necessitatibus quibusdam rerum.\nEt qui ex itaque quam tempora quia eos.", new DateTime(2021, 5, 6, 9, 31, 38, 3, DateTimeKind.Unspecified).AddTicks(8430), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Illo a ex minus.\nDucimus qui officiis.\nDicta suscipit voluptas libero.\nTemporibus enim qui labore.", new DateTime(2021, 10, 9, 0, 43, 5, 480, DateTimeKind.Unspecified).AddTicks(7270), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Sed tempora non officiis est sit eveniet.\nArchitecto corrupti id rerum quam nesciunt assumenda odio ut maxime.\nUt animi in iste voluptatibus aliquid ut vitae.\nVelit exercitationem vero id sed quibusdam non.\nUt at ratione qui consectetur quam voluptas dolor dolorum.", new DateTime(2021, 8, 14, 13, 57, 37, 263, DateTimeKind.Unspecified).AddTicks(4946), 5L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Quo dolor harum et maxime.\nEt ut quia ab animi occaecati beatae.\nVel autem ea molestias.\nAspernatur sunt explicabo.\nCorporis vitae porro voluptas et magni alias sit quia quia.\nImpedit maiores unde possimus aspernatur enim ea et ut.", new DateTime(2021, 9, 6, 6, 15, 51, 816, DateTimeKind.Unspecified).AddTicks(508), 1L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 23L, "Cum illum sit corporis maiores laudantium ut.\nArchitecto aut expedita nihil et voluptatibus fugiat.\nQuisquam harum consequatur quasi ea voluptas hic dolorum.\nHarum laborum harum suscipit magnam aut.\nDolores amet tempore magni magni possimus odit quis et impedit.", new DateTime(2021, 6, 4, 11, 4, 16, 100, DateTimeKind.Unspecified).AddTicks(7149), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 34L, "Dolores ea assumenda alias.", new DateTime(2021, 3, 6, 4, 28, 7, 52, DateTimeKind.Unspecified).AddTicks(1993), 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Sint aliquid pariatur harum enim dolorem repellat.\nMolestiae aut nemo nihil qui sapiente non harum.\nEligendi voluptas nobis tempore.\nMolestias vel dolores aut deleniti aut minima accusamus.\nOmnis voluptatem similique.\nFacere occaecati incidunt iusto laborum ut eius id dolore.", new DateTime(2021, 4, 12, 22, 5, 28, 434, DateTimeKind.Unspecified).AddTicks(9752), 4L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Quam ducimus qui.\nRerum velit nulla rem.\nUllam nisi eveniet dignissimos.", new DateTime(2021, 8, 25, 1, 50, 58, 81, DateTimeKind.Unspecified).AddTicks(488), 3L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Omnis fugit aut.", new DateTime(2021, 8, 20, 8, 30, 53, 58, DateTimeKind.Unspecified).AddTicks(3331), 3L, 59L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 15L, "Qui et velit tempore et.\nQui animi dolor beatae soluta.\nEt ab explicabo eos enim consequatur omnis soluta.\nVel doloribus omnis est optio et.\nAmet et assumenda et numquam culpa.\nQuasi aspernatur tempore.", new DateTime(2021, 11, 8, 12, 17, 53, 802, DateTimeKind.Unspecified).AddTicks(2027), 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Suscipit deleniti accusamus et debitis.\nDucimus ab cum.\nPariatur architecto architecto odio maiores.", new DateTime(2021, 9, 4, 18, 46, 20, 745, DateTimeKind.Unspecified).AddTicks(6003), 1L, 30L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Dolore nihil voluptas doloremque accusantium.\nAnimi aspernatur mollitia.", new DateTime(2021, 6, 17, 15, 1, 38, 939, DateTimeKind.Unspecified).AddTicks(7420), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Eum voluptas similique quasi.\nPorro possimus repudiandae minus rerum repellat.\nNobis laboriosam qui id qui inventore illo sunt.", new DateTime(2021, 3, 27, 21, 21, 10, 234, DateTimeKind.Unspecified).AddTicks(231), 1L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 27L, "Hic vitae tempora tempore et dignissimos perferendis omnis aut.", new DateTime(2021, 3, 12, 22, 52, 25, 95, DateTimeKind.Unspecified).AddTicks(9008), 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 29L, "Excepturi mollitia vitae accusantium autem repudiandae.\nEst rem ex rerum sunt suscipit voluptatem veniam aut.\nMaiores similique assumenda tempore est inventore aut omnis.\nEt ut corporis dolorem deleniti dolorem laudantium mollitia.", new DateTime(2021, 4, 6, 19, 23, 18, 77, DateTimeKind.Unspecified).AddTicks(4489), 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Adipisci enim facere voluptatem sed accusamus soluta fuga qui porro.\nEx quia dolorem qui qui sed sed rem.\nConsequatur occaecati rem corporis officiis dolor aut id.\nSuscipit pariatur necessitatibus minima harum sunt ea.\nQuod omnis nobis sapiente veniam esse qui ducimus quia voluptas.", new DateTime(2021, 9, 4, 11, 28, 1, 107, DateTimeKind.Unspecified).AddTicks(3093), 4L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 3L, "Aut non tempore voluptas qui.\nLaboriosam omnis earum sit atque et.\nBeatae est magnam praesentium rerum quibusdam dignissimos temporibus voluptas.\nOdit rerum at facere itaque rem sapiente rerum.\nAspernatur ut corporis nihil ut occaecati atque exercitationem nihil molestiae.", new DateTime(2021, 5, 15, 6, 26, 4, 917, DateTimeKind.Unspecified).AddTicks(507), 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 10L, "Sequi reprehenderit ipsam.\nEt enim error quia quia error tenetur mollitia eligendi.\nNostrum voluptatibus magni natus assumenda quis.\nMaiores ut itaque ea et voluptatem et maxime praesentium.", new DateTime(2021, 5, 20, 9, 52, 1, 466, DateTimeKind.Unspecified).AddTicks(4088), 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Est ab nemo.\nAut aspernatur dolores suscipit similique necessitatibus id voluptatem quidem.\nDolores consequatur tenetur.\nAd dolorem ipsa autem et.\nNostrum cumque praesentium.", new DateTime(2021, 9, 22, 15, 38, 2, 296, DateTimeKind.Unspecified).AddTicks(2770), 4L, 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Non sit beatae aliquam reiciendis enim tempore.\nPerferendis quis excepturi eveniet repellat tempora.\nVoluptas aut numquam eveniet et et eaque enim.\nAdipisci et ad quidem placeat earum dolor.\nDolorum voluptate molestiae nihil illo fugit aut.\nAnimi soluta accusantium.", new DateTime(2021, 10, 18, 16, 4, 44, 926, DateTimeKind.Unspecified).AddTicks(6113), 2L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Nihil qui in laudantium iste repellat ipsum veritatis praesentium.\nDeleniti eaque eaque.\nQuasi deserunt maiores ad deserunt et alias enim.", new DateTime(2021, 4, 5, 3, 11, 52, 774, DateTimeKind.Unspecified).AddTicks(511), 5L, 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Ut cumque aut.\nAut aut voluptas ex.\nVeritatis et velit aliquam.\nDeserunt illo quos maiores natus earum a velit.\nEarum cumque libero facere voluptatem saepe suscipit qui est veritatis.\nAutem omnis dicta ad.", new DateTime(2021, 5, 17, 13, 53, 22, 284, DateTimeKind.Unspecified).AddTicks(1090), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Non sit perspiciatis ex cum quidem placeat saepe ut asperiores.\nAt voluptas aperiam.\nEos magni dolor praesentium accusamus deleniti laboriosam.", new DateTime(2021, 4, 3, 10, 20, 46, 341, DateTimeKind.Unspecified).AddTicks(3427), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 43L, "Facere ea provident et.\nAut minus occaecati.\nQui rem quaerat.\nEst blanditiis et aspernatur earum asperiores illo.\nSunt doloremque incidunt magnam sint dignissimos accusamus fugiat dignissimos.\nVoluptas tempore provident eos et praesentium vel.", new DateTime(2021, 2, 6, 15, 19, 18, 560, DateTimeKind.Unspecified).AddTicks(1065), 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 44L, "Nihil sed quis temporibus aut minima repellat voluptates.", new DateTime(2021, 6, 5, 6, 45, 25, 705, DateTimeKind.Unspecified).AddTicks(2833), 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Doloribus excepturi similique eos est.\nSaepe et qui ab unde deserunt est quis.\nLabore facere dolor.", new DateTime(2022, 1, 15, 18, 52, 37, 713, DateTimeKind.Unspecified).AddTicks(9441), 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 18L, "Doloribus omnis dignissimos mollitia alias omnis vitae deleniti.\nNesciunt qui voluptatem amet odio ullam.", new DateTime(2021, 6, 20, 20, 32, 47, 556, DateTimeKind.Unspecified).AddTicks(3441), 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 47L, "Nostrum tempore quo quibusdam.\nNesciunt tempore qui beatae omnis earum veniam.", new DateTime(2021, 11, 8, 19, 30, 2, 744, DateTimeKind.Unspecified).AddTicks(6567), 1L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Dolorem ut quasi aut qui laudantium quibusdam ab.\nDeleniti quod blanditiis ducimus molestiae.", new DateTime(2021, 3, 17, 21, 1, 51, 218, DateTimeKind.Unspecified).AddTicks(9854), 4L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 31L, "In id voluptate saepe velit eum aut aperiam enim.\nDolorem aut perspiciatis qui quibusdam voluptatem dolorem.\nModi magnam alias omnis.\nConsectetur nulla fuga voluptas sint nostrum et quia aliquam.\nEt incidunt eius natus dolor eligendi et.", new DateTime(2021, 5, 6, 23, 34, 5, 229, DateTimeKind.Unspecified).AddTicks(3940), 4L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 21L, "Voluptates repellat harum qui dolore molestias expedita deleniti.\nNulla possimus numquam ab temporibus illo commodi maxime assumenda.", new DateTime(2022, 1, 16, 8, 12, 55, 887, DateTimeKind.Unspecified).AddTicks(2289), 4L, 74L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Cumque doloribus dolores sequi libero labore est.\nDebitis quia quo.", new DateTime(2021, 11, 1, 6, 39, 5, 620, DateTimeKind.Unspecified).AddTicks(9235), 3L, 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 42L, "Voluptatem cumque eum praesentium ut magni et.\nEius perferendis aut.\nEa eaque et omnis illo.\nQuaerat perferendis quas.", new DateTime(2021, 6, 7, 9, 32, 29, 109, DateTimeKind.Unspecified).AddTicks(2186), 46L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Architecto est deleniti sit sint minus enim culpa nisi.\nFugit ex eos officia eos ducimus tempora voluptas possimus.\nDolorem nulla omnis eum sed repellat.", new DateTime(2021, 12, 11, 20, 49, 24, 536, DateTimeKind.Unspecified).AddTicks(9357), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Aut quis eum nostrum quod eum quos et sunt.\nOccaecati earum itaque libero in nihil.", new DateTime(2021, 10, 12, 9, 43, 10, 483, DateTimeKind.Unspecified).AddTicks(3703), 2L, 31L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 27L, "Tempore incidunt ipsum est est occaecati vitae eius consequatur.\nCupiditate enim ut sunt.\nPariatur nihil qui enim eos eum impedit quia laborum.\nAccusamus animi tempora minus nulla consequatur alias ut ratione laborum.\nSed sunt sit aut sed officiis sunt.\nEsse fuga voluptatem dolorem nam.", new DateTime(2022, 1, 19, 13, 53, 51, 173, DateTimeKind.Unspecified).AddTicks(3509), 54L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 36L, "Delectus et natus possimus omnis et.\nAtque cupiditate reprehenderit cupiditate voluptate sed sapiente nesciunt qui.\nNon ullam id excepturi dolorum consequatur velit.\nUnde est error eius amet.\nDelectus qui libero est optio natus suscipit voluptate ab.", new DateTime(2021, 2, 28, 19, 5, 13, 864, DateTimeKind.Unspecified).AddTicks(172), 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Sed eos quas dolor.\nQui id nesciunt.\nNisi eveniet ea quos tempora ratione nostrum ut suscipit occaecati.\nUt provident ipsam laudantium ipsum minima et.\nEt quia illo beatae.\nQuae et voluptates veritatis iusto.", new DateTime(2021, 2, 7, 11, 22, 22, 847, DateTimeKind.Unspecified).AddTicks(7478), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 16L, "Quibusdam sed voluptas dolor ut.\nQuia incidunt ea suscipit hic qui.\nEaque laborum omnis molestiae corrupti ut voluptas.\nIllum illo dignissimos quibusdam ut.\nEum consectetur vel voluptas.", new DateTime(2021, 6, 3, 20, 57, 51, 343, DateTimeKind.Unspecified).AddTicks(7626), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Fuga ut non alias qui tempore.\nAspernatur pariatur commodi voluptatem qui eum numquam quod placeat et.\nReiciendis ratione qui.\nLibero neque nostrum eaque accusantium consequatur.\nPossimus sed quis facilis quia corporis qui nihil.\nRem qui vitae ut hic officiis quia consequatur consequatur.", new DateTime(2021, 2, 15, 1, 3, 50, 196, DateTimeKind.Unspecified).AddTicks(6476), 3L, 48L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 50L, "Qui ipsa et soluta consequatur impedit dolor est.", new DateTime(2021, 4, 6, 0, 15, 0, 666, DateTimeKind.Unspecified).AddTicks(3684), 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Inventore repudiandae animi quae.\nSed quo et.\nEt autem a.\nIncidunt eos nihil dolores temporibus.", new DateTime(2021, 10, 21, 20, 52, 38, 231, DateTimeKind.Unspecified).AddTicks(8015), 5L, 56L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 44L, "Laboriosam consequuntur est dolores sed repudiandae.", new DateTime(2021, 4, 4, 18, 42, 21, 652, DateTimeKind.Unspecified).AddTicks(9924), 5L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Maiores corrupti itaque laudantium pariatur.\nDoloribus vel rerum velit nihil omnis temporibus ut exercitationem.\nExercitationem sapiente aliquid est vero.\nImpedit eveniet pariatur laboriosam.\nDolores in placeat in blanditiis voluptatum est iusto est at.", new DateTime(2021, 10, 18, 11, 35, 38, 665, DateTimeKind.Unspecified).AddTicks(3588), 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Molestiae nihil eos impedit in dolorum omnis.\nMollitia deleniti reiciendis qui pariatur dolor eaque et molestias.", new DateTime(2021, 12, 14, 12, 15, 47, 755, DateTimeKind.Unspecified).AddTicks(9340), 2L, 70L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 30L, "Architecto dolor odit est ducimus tempora consequuntur minima atque laborum.", new DateTime(2021, 5, 19, 8, 26, 26, 321, DateTimeKind.Unspecified).AddTicks(5379), 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Sint voluptatem repellat aut aut.\nNumquam officia accusamus vel ducimus voluptas voluptatem.\nAut dignissimos sint minus et non.\nAut odit cupiditate totam velit dolores.", new DateTime(2021, 3, 30, 21, 30, 24, 45, DateTimeKind.Unspecified).AddTicks(3023), 1L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iusto laboriosam numquam eos quia asperiores sunt delectus sint omnis.\nOmnis et sit quae animi sed et praesentium.\nOdit eveniet perspiciatis sint voluptatum suscipit est consequatur.\nUllam accusamus ut ut qui dolorem.\nQuibusdam corporis impedit.\nQuos natus tenetur adipisci rem maxime libero sit.", new DateTime(2021, 12, 14, 6, 12, 27, 982, DateTimeKind.Unspecified).AddTicks(9982), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 12, 23, 12, 29, 59, 629, DateTimeKind.Unspecified).AddTicks(8895), 677, true, 32L, 415 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 2, 2, 2, 56, 24, 927, DateTimeKind.Unspecified).AddTicks(9066), 1L, 560, 4L, 425 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 6, 30, 1, 7, 18, 614, DateTimeKind.Unspecified).AddTicks(1453), 681, true, null, 8L, 20 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 9, 15, 18, 21, 1, 436, DateTimeKind.Unspecified).AddTicks(7212), 1L, 847, null, 37L, 143 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 4, 28, 12, 23, 19, 593, DateTimeKind.Unspecified).AddTicks(5558), 2L, 683, 33L, null, 54 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 7, 4, 0, 5, 4, 262, DateTimeKind.Unspecified).AddTicks(7232), 1L, 868, true, null, 50L, 99 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2022, 1, 5, 23, 30, 53, 570, DateTimeKind.Unspecified).AddTicks(8881), 5L, 905, false, 20L, null, 347 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 3, 28, 2, 57, 57, 951, DateTimeKind.Unspecified).AddTicks(8237), 1L, 993, 25L, 261 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 43L, new DateTime(2021, 8, 7, 6, 45, 54, 32, DateTimeKind.Unspecified).AddTicks(9912), 5L, 915, 15L, 222 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 3, 20, 11, 38, 43, 966, DateTimeKind.Unspecified).AddTicks(4660), 2L, 865, false, 58L, null, 94 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 11, 26, 16, 47, 53, 456, DateTimeKind.Unspecified).AddTicks(4064), 993, true, 3L, 391 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 11, 23, 12, 7, 23, 787, DateTimeKind.Unspecified).AddTicks(9170), 907, 29L, null, 143 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2022, 1, 4, 6, 12, 11, 100, DateTimeKind.Unspecified).AddTicks(883), 895, false, 18L, null, 98 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 12, 13, 8, 2, 2, 688, DateTimeKind.Unspecified).AddTicks(3174), 2L, 774, true, 34L, 41 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 10, 21, 4, 49, 27, 128, DateTimeKind.Unspecified).AddTicks(2179), 3L, 987, true, null, 14L, 460 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 9, 12, 21, 26, 8, 515, DateTimeKind.Unspecified).AddTicks(5274), 4L, 567, false, 81L, null, 37 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 4, 3, 5, 57, 55, 489, DateTimeKind.Unspecified).AddTicks(8425), 2L, 665, false, 58L, 250 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 7, 19, 23, 51, 44, 535, DateTimeKind.Unspecified).AddTicks(1354), 5L, 610, null, 9L, 486 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2022, 1, 12, 19, 21, 57, 392, DateTimeKind.Unspecified).AddTicks(4309), 5L, 569, null, 47L, 459 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 16L, new DateTime(2021, 3, 18, 11, 37, 17, 99, DateTimeKind.Unspecified).AddTicks(4658), 628, true, 36L, 442 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 9, 28, 14, 25, 29, 692, DateTimeKind.Unspecified).AddTicks(3641), 657, false, 8L, null, 183 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 3, 14, 2, 1, 35, 971, DateTimeKind.Unspecified).AddTicks(2927), 1L, 749, true, 44L, 344 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2022, 1, 8, 12, 53, 58, 468, DateTimeKind.Unspecified).AddTicks(7163), 5L, 701, true, 37L, 251 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2022, 1, 30, 16, 19, 9, 915, DateTimeKind.Unspecified).AddTicks(7643), 4L, 918, false, 9L, 207 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 7, 9, 18, 39, 35, 627, DateTimeKind.Unspecified).AddTicks(572), 5L, 742, 30L, 360 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 5, 19, 8, 16, 42, 251, DateTimeKind.Unspecified).AddTicks(2798), 5L, 667, true, 51L, 424 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 2, 24, 6, 23, 49, 480, DateTimeKind.Unspecified).AddTicks(6498), 4L, 812, 16L, 438 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 11, 24, 6, 21, 30, 21, DateTimeKind.Unspecified).AddTicks(9011), 635, 56L, null, 157 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 4, 9, 11, 10, 22, 891, DateTimeKind.Unspecified).AddTicks(8054), 2L, 554, true, 48L, 163 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 7, 31, 18, 3, 42, 447, DateTimeKind.Unspecified).AddTicks(635), 4L, 824, false, null, 37L, 325 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2022, 1, 16, 0, 1, 27, 42, DateTimeKind.Unspecified).AddTicks(9397), 2L, 836, true, 64L, null, 17 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 11, 21, 21, 25, 54, 904, DateTimeKind.Unspecified).AddTicks(2554), 5L, 676, true, 34L, 381 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 11, 29, 15, 59, 38, 135, DateTimeKind.Unspecified).AddTicks(5172), 2L, 874, true, 4L, 465 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "StartPosition" },
                values: new object[] { 2L, new DateTime(2022, 1, 1, 5, 17, 25, 464, DateTimeKind.Unspecified).AddTicks(7600), 2L, 924, 457 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 9, 26, 23, 22, 50, 885, DateTimeKind.Unspecified).AddTicks(7973), 5L, 975, 24L, 340 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 12, 6, 12, 11, 19, 969, DateTimeKind.Unspecified).AddTicks(2552), 3L, 856, 38L, 338 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 3, 29, 12, 44, 27, 346, DateTimeKind.Unspecified).AddTicks(4869), 2L, 529, 70L, null, 378 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 9, 1, 5, 58, 11, 85, DateTimeKind.Unspecified).AddTicks(3322), 584, true, 35L, 460 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 3, 16, 8, 6, 1, 244, DateTimeKind.Unspecified).AddTicks(4164), 4L, 723, 30L, 348 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 3, 22, 15, 28, 44, 743, DateTimeKind.Unspecified).AddTicks(7990), 2L, 945, 62L, 147 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 4, 27, 19, 24, 27, 117, DateTimeKind.Unspecified).AddTicks(262), 2L, 512, 68L, 415 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2022, 1, 5, 19, 48, 51, 781, DateTimeKind.Unspecified).AddTicks(9451), 2L, 832, true, 14L, 231 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2022, 1, 13, 18, 8, 35, 361, DateTimeKind.Unspecified).AddTicks(5078), 2L, 595, true, null, 45L, 79 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 2, 9, 9, 42, 50, 145, DateTimeKind.Unspecified).AddTicks(5205), 564, false, 4L, 184 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 9, 12, 16, 2, 33, 29, DateTimeKind.Unspecified).AddTicks(1975), 1L, 694, false, 76L, 340 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 3, 11, 21, 33, 10, 853, DateTimeKind.Unspecified).AddTicks(75), 520, false, 19L, 491 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { new DateTime(2021, 9, 20, 8, 44, 39, 475, DateTimeKind.Unspecified).AddTicks(6172), 4L, 908, 64L, 90 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2022, 1, 27, 7, 42, 55, 123, DateTimeKind.Unspecified).AddTicks(8312), 1L, 693, 40L, null, 125 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 43L, new DateTime(2021, 12, 3, 9, 51, 39, 575, DateTimeKind.Unspecified).AddTicks(3990), 3L, 518, 63L, null, 60 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 4, 28, 10, 55, 57, 528, DateTimeKind.Unspecified).AddTicks(8464), 3L, 633, 39L, null, 449 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { new DateTime(2021, 8, 30, 23, 9, 3, 258, DateTimeKind.Unspecified).AddTicks(9845), 4L, 690, true, 26L, 380 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2022, 1, 17, 11, 56, 50, 19, DateTimeKind.Unspecified).AddTicks(4774), 3L, 888, true, 50L, 459 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 7, 16, 13, 52, 33, 331, DateTimeKind.Unspecified).AddTicks(8499), 4L, 511, false, 2L, 495 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 22L, new DateTime(2021, 11, 11, 0, 36, 31, 879, DateTimeKind.Unspecified).AddTicks(7235), 2L, 793, 40L, null, 363 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2021, 12, 31, 23, 18, 45, 516, DateTimeKind.Unspecified).AddTicks(2973), 4L, 664, true, null, 36L, 155 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 10, 11, 12, 3, 34, 732, DateTimeKind.Unspecified).AddTicks(2693), 5L, 903, false, 70L, null, 329 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 10, 9, 6, 53, 1, 912, DateTimeKind.Unspecified).AddTicks(7466), 5L, 588, true, null, 12L, 255 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 2, 12, 12, 16, 5, 576, DateTimeKind.Unspecified).AddTicks(7989), 628, true, 57L, null, 342 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 2, 14, 6, 42, 31, 486, DateTimeKind.Unspecified).AddTicks(6345), 3L, 906, true, 74L, 275 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 2, 20, 16, 46, 9, 804, DateTimeKind.Unspecified).AddTicks(1020), 4L, 599, 35L, null, 85 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 5, 22, 9, 49, 26, 646, DateTimeKind.Unspecified).AddTicks(1260), 5L, 685, false, null, 51L, 206 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 4, 12, 13, 0, 45, 582, DateTimeKind.Unspecified).AddTicks(6620), 5L, 641, true, 56L, null, 319 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 3, 6, 18, 55, 38, 589, DateTimeKind.Unspecified).AddTicks(4467), 5L, 607, 45L, null, 361 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 5, 17, 4, 5, 0, 315, DateTimeKind.Unspecified).AddTicks(8459), 677, null, 38L, 479 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 43L, new DateTime(2022, 1, 21, 14, 31, 37, 88, DateTimeKind.Unspecified).AddTicks(782), 1L, 913, false, null, 44L, 58 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 5, 11, 0, 25, 51, 4, DateTimeKind.Unspecified).AddTicks(201), 5L, 739, 30L, 101 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2022, 1, 3, 7, 21, 40, 357, DateTimeKind.Unspecified).AddTicks(5806), 707, null, 27L, 353 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2021, 2, 26, 6, 37, 7, 987, DateTimeKind.Unspecified).AddTicks(3229), 2L, 677, true, null, 48L, 34 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 6, 4, 21, 5, 24, 425, DateTimeKind.Unspecified).AddTicks(3125), 1L, 686, 36L, 359 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2022, 1, 20, 10, 16, 41, 3, DateTimeKind.Unspecified).AddTicks(3452), 2L, 674, 13L, 249 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 12, 15, 0, 49, 27, 890, DateTimeKind.Unspecified).AddTicks(792), 3L, 1000, false, null, 3L, 151 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 12, 28, 9, 33, 21, 996, DateTimeKind.Unspecified).AddTicks(3589), 5L, 566, 15L, 127 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "StartPosition" },
                values: new object[] { 26L, new DateTime(2022, 1, 21, 12, 43, 51, 784, DateTimeKind.Unspecified).AddTicks(3785), 2L, 853, false, 351 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 22L, new DateTime(2021, 11, 18, 0, 44, 15, 636, DateTimeKind.Unspecified).AddTicks(6531), 2L, 782, false, 4L, 401 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 2, 11, 4, 38, 32, 950, DateTimeKind.Unspecified).AddTicks(6755), 5L, 935, 48L, 335 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 3, 13, 0, 52, 22, 407, DateTimeKind.Unspecified).AddTicks(4992), 670, false, 22L, 195 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 11, 22, 4, 20, 48, 665, DateTimeKind.Unspecified).AddTicks(376), 3L, 796, null, 15L, 422 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 7, 4, 9, 45, 38, 907, DateTimeKind.Unspecified).AddTicks(2284), 2L, 966, 4L, 408 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 12, 4, 12, 16, 49, 380, DateTimeKind.Unspecified).AddTicks(6249), 4L, 866, 60L, null, 458 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 12, 12, 21, 57, 11, 311, DateTimeKind.Unspecified).AddTicks(8215), 986, true, 74L, 122 });

            migrationBuilder.InsertData(
                table: "UserProjects",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted", "SubmissionId" },
                values: new object[,]
                {
                    { 33L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9L, false, null },
                    { 5L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3L, false, null },
                    { 13L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39L, false, null },
                    { 33L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49L, false, null },
                    { 9L, 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12L, false, null },
                    { 17L, 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6L, false, null },
                    { 41L, 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38L, false, null },
                    { 24L, 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48L, false, null },
                    { 45L, 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10L, false, null },
                    { 30L, 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30L, false, null },
                    { 45L, 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50L, false, null },
                    { 51L, 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36L, false, null },
                    { 2L, 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28L, false, null },
                    { 47L, 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43L, false, null },
                    { 36L, 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25L, false, null },
                    { 25L, 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13L, false, null },
                    { 20L, 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31L, false, null },
                    { 22L, 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2L, false, null },
                    { 23L, 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16L, false, null },
                    { 6L, 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5L, false, null }
                });

            migrationBuilder.InsertData(
                table: "UserProjects",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted", "SubmissionId" },
                values: new object[,]
                {
                    { 5L, 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8L, false, null },
                    { 12L, 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29L, false, null },
                    { 27L, 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45L, false, null },
                    { 33L, 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23L, false, null },
                    { 35L, 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4L, false, null },
                    { 4L, 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18L, false, null },
                    { 44L, 30L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22L, false, null },
                    { 35L, 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46L, false, null },
                    { 32L, 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11L, false, null },
                    { 36L, 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17L, false, null },
                    { 8L, 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44L, false, null },
                    { 14L, 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7L, false, null },
                    { 35L, 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40L, false, null },
                    { 2L, 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24L, false, null },
                    { 33L, 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33L, false, null },
                    { 50L, 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34L, false, null },
                    { 23L, 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35L, false, null },
                    { 9L, 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14L, false, null },
                    { 49L, 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32L, false, null },
                    { 21L, 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20L, false, null },
                    { 26L, 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27L, false, null },
                    { 39L, 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41L, false, null },
                    { 42L, 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21L, false, null },
                    { 37L, 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37L, false, null },
                    { 3L, 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19L, false, null },
                    { 27L, 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15L, false, null },
                    { 12L, 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42L, false, null },
                    { 13L, 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47L, false, null },
                    { 36L, 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51L, false, null }
                });

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
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 2L, 25L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 2L, 28L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 2L, 34L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 5L, 25L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 3L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 11L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 32L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 33L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 7L, 9L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 6L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 7L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 13L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 15L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 18L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 8L, 22L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 9L, 13L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 9L, 18L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 19L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 32L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 35L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 11L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 12L, 19L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 12L, 31L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 13L, 2L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 13L, 13L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 28L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 14L, 35L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 15L, 4L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 15L, 25L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 11L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 22L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 16L, 30L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 17L, 6L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 17L, 12L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 17L, 17L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 18L, 10L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 19L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 20L, 14L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 20L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 21L, 9L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 21L, 30L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 7L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 10L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 22L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 22L, 34L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 23L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 23L, 16L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 18L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 27L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 24L, 28L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 25L, 2L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 25L, 32L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 25L, 37L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 26L, 4L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 26L, 10L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 26L, 27L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 27L, 11L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 27L, 23L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 28L, 25L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 28L, 29L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 29L, 8L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 29L, 11L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 30L, 1L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 30L, 6L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 30L, 26L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 31L, 21L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 31L, 26L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 31L, 36L });

            migrationBuilder.DeleteData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 31L, 37L });

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

            migrationBuilder.CreateTable(
                name: "InvitedUsers",
                columns: table => new
                {
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvitedUsers", x => new { x.ProjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_InvitedUsers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvitedUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 3L, 8L },
                column: "Id",
                value: 55L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 4L, 1L },
                column: "Id",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 6L, 17L },
                column: "Id",
                value: 81L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 9L, 6L },
                column: "Id",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 13L, 22L },
                column: "Id",
                value: 67L);

            migrationBuilder.UpdateData(
                table: "AppTags",
                keyColumns: new[] { "AppId", "TagId" },
                keyValues: new object[] { 15L, 10L },
                column: "Id",
                value: 15L);

            migrationBuilder.InsertData(
                table: "AppTags",
                columns: new[] { "AppId", "TagId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 31L, false },
                    { 2L, 20L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 74L, false },
                    { 2L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 57L, false },
                    { 3L, 13L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 68L, false },
                    { 3L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 66L, false },
                    { 3L, 33L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 49L, false },
                    { 3L, 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 80L, false },
                    { 3L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 24L, false },
                    { 4L, 16L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 65L, false },
                    { 4L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 75L, false },
                    { 4L, 33L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 29L, false },
                    { 6L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 16L, false },
                    { 6L, 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 37L, false },
                    { 6L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 56L, false },
                    { 6L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 72L, false },
                    { 7L, 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 38L, false },
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
                    { 10L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 20L, false },
                    { 10L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 43L, false },
                    { 10L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 58L, false },
                    { 11L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 18L, false },
                    { 11L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 64L, false },
                    { 11L, 31L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 28L, false },
                    { 12L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 9L, false },
                    { 12L, 21L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L, false },
                    { 12L, 24L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 73L, false },
                    { 12L, 27L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 13L, false }
                });

            migrationBuilder.InsertData(
                table: "AppTags",
                columns: new[] { "AppId", "TagId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 13L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 69L, false },
                    { 14L, 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 6L, false },
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
                values: new object[] { new Guid("a2c7aee8-788d-d666-2585-1826c429d843"), new DateTime(2021, 5, 6, 19, 14, 46, 34, DateTimeKind.Unspecified).AddTicks(1588), 3L, "Ipsam nemo repellendus omnis tenetur voluptates soluta eligendi.\nQuia et qui sunt totam voluptatem.\nNemo laudantium iusto consequatur dolor pariatur delectus enim.", "Voluptatem aut non sed quibusdam distinctio.", 4L, "aggregateBolivar FuerteTasty Cotton Gloves", 9L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("9dcd3bb0-17e1-ac0c-1745-2a89b5977974"), new DateTime(2021, 2, 28, 3, 46, 29, 999, DateTimeKind.Unspecified).AddTicks(4377), "Enim sit earum magnam.\nSequi reprehenderit at aut quia cum eum.\nAperiam magni voluptatibus dolorum ipsam modi.", "Modi ducimus ut laudantium laboriosam.", 99L, "arrayOuguiyaTurnpike", 6L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("e494dd10-0fe6-bdfa-39a0-fd8b73885d31"), new DateTime(2021, 3, 7, 8, 15, 13, 353, DateTimeKind.Unspecified).AddTicks(5926), 4L, "Et odio maxime enim et molestiae quia.\nAperiam facilis et eum voluptas accusamus sequi.\nQuo iure harum totam maxime quia non sit aliquid similique.\nSunt illum autem non magni nam.\nEt sed suscipit.", "Ullam explicabo totam veniam voluptatem sed.", 33L, "SynergizedHorizontalTHX", 44L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("d3be555a-0d22-8e00-8ce4-8be825b0a4bb"), new DateTime(2021, 3, 8, 17, 28, 31, 376, DateTimeKind.Unspecified).AddTicks(347), "Rem ducimus dignissimos.", "Quisquam et et dolorum natus.", 73L, "SeniorShoesCross-group", 15L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("937fe4ae-1c8c-def3-da30-a9867cf7f71c"), new DateTime(2021, 11, 29, 0, 18, 48, 588, DateTimeKind.Unspecified).AddTicks(7291), 1L, "Aspernatur sint vel et consequatur sapiente quas sit ut.\nAutem est sit asperiores quidem ea aut ipsam.\nSaepe doloribus quia voluptas culpa adipisci adipisci.", "Consequatur quos eligendi aut accusamus.", 27L, "CommunicationsGranitetransmit", 25L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("9f77ab6e-b6a8-47f3-7b2d-3ec949977b90"), new DateTime(2021, 4, 9, 14, 49, 47, 476, DateTimeKind.Unspecified).AddTicks(8133), "Ad voluptatem saepe vel id.\nIncidunt blanditiis est dolorem mollitia nulla.", "Officiis necessitatibus placeat ut officiis vel consequuntur.", 68L, "viralFreshLempira", 18L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c049b115-7872-31ac-0235-542d533817a9"), new DateTime(2021, 11, 30, 13, 34, 1, 798, DateTimeKind.Unspecified).AddTicks(9928), 4L, "Laborum iure optio dicta.\nMaxime provident eveniet.\nSunt repellendus veniam eum dolor inventore molestiae aut fugiat.\nEt natus et id.\nRepudiandae voluptate quam dolorum saepe cumque velit et totam aspernatur.\nIn itaque saepe quis.", "Ad provident qui distinctio vel itaque praesentium et.", 98L, "Personal Loan AccountForkimplementRAM", 34L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("a27d502a-9e22-4868-8ea4-a02190f60164"), new DateTime(2021, 11, 6, 4, 49, 57, 563, DateTimeKind.Unspecified).AddTicks(6995), 2L, "Cumque totam sit molestias id sunt labore ut quam et.", "Corrupti beatae praesentium nam qui odio et ipsum.", 18L, "ubiquitousToolsForwardhard drive", 50L });

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
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("c08938ee-0914-8e7b-ad06-3a40bfb4e8d0"), new DateTime(2021, 10, 20, 13, 27, 22, 914, DateTimeKind.Unspecified).AddTicks(8959), "Doloribus numquam ad voluptatem magni minima expedita aliquam fugit.\nPerspiciatis est sequi corrupti consequatur eum.\nSunt voluptate minima.\nQuia aut molestiae ut iste nihil eos perferendis.\nInventore voluptatibus accusamus.", "Nostrum impedit nam et non ea eligendi.", 6L, "RSSPNG", 28L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("46f59a4c-e0f0-61bb-a08f-1c1a4790cc6b"), new DateTime(2021, 12, 5, 20, 1, 37, 845, DateTimeKind.Unspecified).AddTicks(6639), 2L, "Sapiente accusamus praesentium aut voluptatem facilis sunt eum.\nQuia beatae esse velit alias ut deserunt ad.\nCommodi dolorum ut id libero consectetur doloribus in.", "Asperiores quis error at.", 46L, "Licensed Wooden Pizzafront-endsynthesizing", 34L });

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
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("8a73ddb7-1ce8-64cd-44b7-2d5cad620f05"), new DateTime(2021, 2, 7, 22, 31, 37, 167, DateTimeKind.Unspecified).AddTicks(6861), 4L, "Architecto minima temporibus quaerat id cum necessitatibus.\nIusto consequatur officia ex beatae temporibus facilis.", "Sint deserunt sed non qui nam dignissimos placeat molestias ut.", 94L, "Licensed Concrete FishSQLWay", 20L });

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
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("7ead84a0-d0ae-e666-aa45-34be0347fa3a"), new DateTime(2021, 10, 2, 18, 22, 6, 898, DateTimeKind.Unspecified).AddTicks(4864), "A beatae facilis placeat et id at consequatur aut.\nRecusandae totam consequatur magnam.\nOccaecati in voluptatem et.", "Tenetur quod est recusandae et sunt inventore magnam dolor.", 28L, "object-orientedNew Israeli Sheqel", 35L });

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
                columns: new[] { "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("a95cdcf4-d88d-45a0-5abf-9f64c601dbdb"), new DateTime(2021, 3, 11, 7, 9, 12, 88, DateTimeKind.Unspecified).AddTicks(923), 2L, "Accusantium accusamus est nulla nemo aut beatae iste rem.\nDolorem sequi consectetur.\nMinus eum minus perferendis.", "Repellat ut tenetur est eius possimus dolorem voluptatem eius et.", 3L, "ChiefGorgeous Steel FishmaximizedSoft", 21L });

            migrationBuilder.UpdateData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("fd4893ed-eba1-4bd9-8e19-3fcaa60334bc"), new DateTime(2021, 10, 15, 20, 15, 36, 186, DateTimeKind.Unspecified).AddTicks(8021), "Quia quia maiores aliquam.\nNumquam aliquid corrupti distinctio.", "Voluptatem odio provident.", 16L, "auxiliaryturquoiseGroupmulti-byte", 43L });

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
                columns: new[] { "AppDocumentId", "CreatedAt", "Description", "DisplayName", "ImageId", "Name", "OwnerId" },
                values: new object[] { new Guid("2c05caa7-6520-7759-3534-e08bcffbd931"), new DateTime(2021, 7, 11, 19, 51, 47, 631, DateTimeKind.Unspecified).AddTicks(7658), "Et et soluta quos id unde possimus cupiditate debitis.", "Natus dolor nostrum est aut consequuntur aliquam dolorum.", 66L, "indexBedfordshire", 45L });

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

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 10L, new DateTime(2021, 7, 19, 23, 51, 44, 535, DateTimeKind.Unspecified).AddTicks(1354), 5L, 88L, false },
                    { 3L, 10L, new DateTime(2022, 1, 28, 16, 21, 11, 209, DateTimeKind.Unspecified).AddTicks(9767), 3L, 14L, false },
                    { 3L, 39L, new DateTime(2021, 4, 10, 20, 15, 15, 233, DateTimeKind.Unspecified).AddTicks(231), 2L, 75L, false },
                    { 4L, 41L, new DateTime(2021, 9, 22, 22, 19, 30, 418, DateTimeKind.Unspecified).AddTicks(973), 1L, 57L, false },
                    { 5L, 37L, new DateTime(2021, 9, 28, 14, 25, 29, 692, DateTimeKind.Unspecified).AddTicks(3641), 2L, 94L, false },
                    { 6L, 10L, new DateTime(2021, 8, 9, 14, 7, 39, 693, DateTimeKind.Unspecified).AddTicks(1381), 4L, 101L, false },
                    { 6L, 16L, new DateTime(2021, 8, 4, 1, 12, 59, 140, DateTimeKind.Unspecified).AddTicks(3612), 4L, 95L, false },
                    { 7L, 19L, new DateTime(2021, 7, 1, 21, 32, 7, 601, DateTimeKind.Unspecified).AddTicks(3288), 1L, 50L, false },
                    { 7L, 22L, new DateTime(2022, 1, 12, 19, 21, 57, 392, DateTimeKind.Unspecified).AddTicks(4309), 5L, 90L, false },
                    { 7L, 35L, new DateTime(2022, 1, 30, 16, 19, 9, 915, DateTimeKind.Unspecified).AddTicks(7643), 4L, 100L, false },
                    { 7L, 44L, new DateTime(2021, 8, 6, 12, 12, 28, 410, DateTimeKind.Unspecified).AddTicks(8072), 5L, 51L, false },
                    { 7L, 49L, new DateTime(2021, 9, 15, 18, 21, 1, 436, DateTimeKind.Unspecified).AddTicks(7212), 1L, 60L, false },
                    { 8L, 29L, new DateTime(2021, 9, 12, 21, 26, 8, 515, DateTimeKind.Unspecified).AddTicks(5274), 4L, 84L, false },
                    { 8L, 43L, new DateTime(2021, 5, 24, 14, 53, 17, 769, DateTimeKind.Unspecified).AddTicks(5774), 2L, 59L, false },
                    { 9L, 33L, new DateTime(2021, 12, 13, 4, 26, 50, 584, DateTimeKind.Unspecified).AddTicks(1368), 5L, 89L, false },
                    { 10L, 12L, new DateTime(2021, 10, 21, 4, 49, 27, 128, DateTimeKind.Unspecified).AddTicks(2179), 3L, 82L, false },
                    { 11L, 46L, new DateTime(2021, 3, 31, 7, 59, 44, 959, DateTimeKind.Unspecified).AddTicks(1911), 3L, 37L, false },
                    { 12L, 2L, new DateTime(2021, 7, 17, 6, 39, 47, 767, DateTimeKind.Unspecified).AddTicks(1041), 1L, 79L, false },
                    { 12L, 12L, new DateTime(2021, 3, 14, 2, 1, 35, 971, DateTimeKind.Unspecified).AddTicks(2927), 1L, 96L, false },
                    { 12L, 17L, new DateTime(2021, 12, 13, 8, 2, 2, 688, DateTimeKind.Unspecified).AddTicks(3174), 2L, 80L, false },
                    { 13L, 6L, new DateTime(2021, 8, 29, 11, 20, 38, 29, DateTimeKind.Unspecified).AddTicks(3261), 2L, 11L, false },
                    { 13L, 26L, new DateTime(2021, 8, 3, 2, 57, 1, 110, DateTimeKind.Unspecified).AddTicks(8123), 3L, 10L, false },
                    { 13L, 27L, new DateTime(2022, 1, 4, 6, 12, 11, 100, DateTimeKind.Unspecified).AddTicks(883), 3L, 78L, false },
                    { 14L, 18L, new DateTime(2021, 7, 12, 5, 38, 42, 414, DateTimeKind.Unspecified).AddTicks(6237), 4L, 32L, false },
                    { 14L, 23L, new DateTime(2021, 11, 26, 16, 47, 53, 456, DateTimeKind.Unspecified).AddTicks(4064), 3L, 74L, false },
                    { 14L, 47L, new DateTime(2021, 12, 14, 14, 19, 6, 620, DateTimeKind.Unspecified).AddTicks(4526), 1L, 83L, false },
                    { 14L, 49L, new DateTime(2021, 9, 20, 7, 32, 16, 373, DateTimeKind.Unspecified).AddTicks(6443), 4L, 28L, false },
                    { 15L, 28L, new DateTime(2021, 2, 2, 2, 56, 24, 927, DateTimeKind.Unspecified).AddTicks(9066), 1L, 56L, false },
                    { 15L, 38L, new DateTime(2021, 5, 11, 20, 25, 25, 794, DateTimeKind.Unspecified).AddTicks(1052), 1L, 71L, false },
                    { 16L, 9L, new DateTime(2021, 3, 18, 11, 37, 17, 99, DateTimeKind.Unspecified).AddTicks(4658), 3L, 92L, false },
                    { 16L, 13L, new DateTime(2021, 5, 7, 23, 18, 26, 619, DateTimeKind.Unspecified).AddTicks(2362), 2L, 29L, false },
                    { 16L, 34L, new DateTime(2021, 10, 6, 18, 50, 18, 292, DateTimeKind.Unspecified).AddTicks(9340), 2L, 42L, false },
                    { 17L, 4L, new DateTime(2021, 4, 28, 12, 23, 19, 593, DateTimeKind.Unspecified).AddTicks(5558), 2L, 62L, false },
                    { 18L, 41L, new DateTime(2021, 11, 23, 12, 7, 23, 787, DateTimeKind.Unspecified).AddTicks(9170), 1L, 76L, false },
                    { 19L, 8L, new DateTime(2021, 11, 12, 22, 49, 17, 830, DateTimeKind.Unspecified).AddTicks(5716), 1L, 24L, false },
                    { 19L, 13L, new DateTime(2021, 4, 20, 2, 40, 53, 103, DateTimeKind.Unspecified).AddTicks(3889), 1L, 77L, false },
                    { 19L, 49L, new DateTime(2022, 1, 7, 19, 17, 57, 558, DateTimeKind.Unspecified).AddTicks(4872), 4L, 38L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 20L, 47L, new DateTime(2021, 11, 13, 16, 4, 10, 800, DateTimeKind.Unspecified).AddTicks(3832), 1L, 19L, false },
                    { 21L, 10L, new DateTime(2021, 5, 9, 4, 28, 15, 777, DateTimeKind.Unspecified).AddTicks(6398), 1L, 63L, false },
                    { 21L, 15L, new DateTime(2021, 6, 30, 17, 27, 11, 476, DateTimeKind.Unspecified).AddTicks(1261), 2L, 7L, false },
                    { 24L, 2L, new DateTime(2021, 4, 2, 22, 0, 56, 429, DateTimeKind.Unspecified).AddTicks(73), 3L, 99L, false },
                    { 24L, 16L, new DateTime(2021, 6, 13, 7, 0, 35, 98, DateTimeKind.Unspecified).AddTicks(4199), 3L, 12L, false },
                    { 25L, 8L, new DateTime(2021, 11, 30, 4, 5, 9, 307, DateTimeKind.Unspecified).AddTicks(5895), 5L, 5L, false },
                    { 25L, 10L, new DateTime(2021, 5, 10, 13, 34, 37, 492, DateTimeKind.Unspecified).AddTicks(3418), 4L, 9L, false },
                    { 25L, 29L, new DateTime(2021, 4, 5, 8, 8, 54, 898, DateTimeKind.Unspecified).AddTicks(2724), 3L, 69L, false },
                    { 25L, 45L, new DateTime(2021, 4, 28, 13, 21, 0, 488, DateTimeKind.Unspecified).AddTicks(4848), 3L, 43L, false },
                    { 26L, 42L, new DateTime(2022, 1, 5, 23, 30, 53, 570, DateTimeKind.Unspecified).AddTicks(8881), 5L, 66L, false },
                    { 28L, 13L, new DateTime(2022, 1, 13, 6, 34, 56, 555, DateTimeKind.Unspecified).AddTicks(8490), 4L, 47L, false },
                    { 28L, 21L, new DateTime(2021, 9, 7, 20, 59, 28, 181, DateTimeKind.Unspecified).AddTicks(165), 3L, 97L, false },
                    { 29L, 24L, new DateTime(2021, 3, 19, 7, 23, 21, 830, DateTimeKind.Unspecified).AddTicks(3757), 2L, 6L, false },
                    { 29L, 31L, new DateTime(2021, 4, 22, 20, 30, 20, 846, DateTimeKind.Unspecified).AddTicks(7395), 1L, 30L, false },
                    { 29L, 39L, new DateTime(2021, 4, 3, 5, 57, 55, 489, DateTimeKind.Unspecified).AddTicks(8425), 2L, 86L, false },
                    { 30L, 3L, new DateTime(2022, 1, 1, 2, 29, 25, 777, DateTimeKind.Unspecified).AddTicks(5250), 3L, 41L, false },
                    { 30L, 12L, new DateTime(2022, 1, 8, 12, 53, 58, 468, DateTimeKind.Unspecified).AddTicks(7163), 5L, 98L, false },
                    { 31L, 24L, new DateTime(2021, 11, 19, 0, 8, 0, 203, DateTimeKind.Unspecified).AddTicks(7927), 3L, 3L, false },
                    { 31L, 35L, new DateTime(2021, 6, 15, 18, 29, 5, 668, DateTimeKind.Unspecified).AddTicks(6151), 1L, 17L, false },
                    { 32L, 12L, new DateTime(2022, 1, 24, 15, 51, 46, 566, DateTimeKind.Unspecified).AddTicks(2784), 1L, 44L, false },
                    { 32L, 50L, new DateTime(2021, 12, 19, 19, 46, 29, 120, DateTimeKind.Unspecified).AddTicks(6387), 5L, 55L, false },
                    { 33L, 18L, new DateTime(2022, 1, 18, 1, 27, 35, 70, DateTimeKind.Unspecified).AddTicks(704), 4L, 13L, false },
                    { 33L, 51L, new DateTime(2021, 6, 3, 20, 41, 50, 982, DateTimeKind.Unspecified).AddTicks(6465), 3L, 23L, false },
                    { 34L, 46L, new DateTime(2021, 2, 11, 12, 35, 40, 308, DateTimeKind.Unspecified).AddTicks(5890), 5L, 81L, false },
                    { 35L, 44L, new DateTime(2022, 1, 10, 12, 4, 58, 326, DateTimeKind.Unspecified).AddTicks(5856), 2L, 21L, false },
                    { 36L, 27L, new DateTime(2021, 10, 10, 11, 21, 25, 692, DateTimeKind.Unspecified).AddTicks(3547), 2L, 93L, false },
                    { 37L, 5L, new DateTime(2021, 2, 7, 2, 41, 48, 621, DateTimeKind.Unspecified).AddTicks(2531), 4L, 73L, false },
                    { 37L, 16L, new DateTime(2021, 11, 13, 18, 29, 38, 709, DateTimeKind.Unspecified).AddTicks(9969), 5L, 87L, false },
                    { 37L, 35L, new DateTime(2021, 9, 21, 14, 21, 39, 927, DateTimeKind.Unspecified).AddTicks(7281), 1L, 61L, false },
                    { 38L, 32L, new DateTime(2021, 10, 12, 13, 54, 18, 814, DateTimeKind.Unspecified).AddTicks(6413), 3L, 2L, false },
                    { 39L, 49L, new DateTime(2021, 9, 25, 23, 50, 58, 127, DateTimeKind.Unspecified).AddTicks(3807), 5L, 53L, false },
                    { 41L, 38L, new DateTime(2021, 4, 11, 13, 17, 15, 17, DateTimeKind.Unspecified).AddTicks(9314), 1L, 27L, false },
                    { 42L, 15L, new DateTime(2021, 4, 7, 4, 6, 1, 297, DateTimeKind.Unspecified).AddTicks(8125), 3L, 20L, false },
                    { 43L, 10L, new DateTime(2021, 11, 9, 15, 9, 15, 499, DateTimeKind.Unspecified).AddTicks(9293), 1L, 15L, false },
                    { 43L, 14L, new DateTime(2021, 7, 24, 18, 54, 43, 597, DateTimeKind.Unspecified).AddTicks(3893), 2L, 35L, false },
                    { 43L, 15L, new DateTime(2021, 8, 9, 14, 43, 27, 946, DateTimeKind.Unspecified).AddTicks(2224), 1L, 40L, false },
                    { 43L, 32L, new DateTime(2021, 5, 27, 14, 52, 0, 4, DateTimeKind.Unspecified).AddTicks(3182), 4L, 25L, false },
                    { 44L, 6L, new DateTime(2021, 9, 10, 2, 52, 5, 118, DateTimeKind.Unspecified).AddTicks(6136), 4L, 4L, false },
                    { 44L, 38L, new DateTime(2021, 12, 3, 13, 55, 10, 671, DateTimeKind.Unspecified).AddTicks(5719), 3L, 49L, false },
                    { 44L, 45L, new DateTime(2022, 1, 9, 21, 5, 17, 314, DateTimeKind.Unspecified).AddTicks(7898), 5L, 52L, false },
                    { 45L, 7L, new DateTime(2021, 6, 30, 1, 7, 18, 614, DateTimeKind.Unspecified).AddTicks(1453), 4L, 58L, false },
                    { 45L, 8L, new DateTime(2021, 8, 28, 2, 23, 40, 31, DateTimeKind.Unspecified).AddTicks(3415), 4L, 48L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 45L, 15L, new DateTime(2021, 8, 23, 7, 52, 1, 835, DateTimeKind.Unspecified).AddTicks(9736), 4L, 33L, false },
                    { 45L, 22L, new DateTime(2021, 8, 19, 7, 4, 5, 883, DateTimeKind.Unspecified).AddTicks(743), 4L, 16L, false },
                    { 46L, 13L, new DateTime(2021, 3, 15, 12, 41, 57, 981, DateTimeKind.Unspecified).AddTicks(931), 5L, 18L, false },
                    { 46L, 17L, new DateTime(2021, 12, 12, 13, 17, 33, 828, DateTimeKind.Unspecified).AddTicks(5314), 4L, 22L, false },
                    { 46L, 39L, new DateTime(2021, 5, 10, 6, 46, 20, 596, DateTimeKind.Unspecified).AddTicks(2348), 1L, 36L, false },
                    { 46L, 47L, new DateTime(2021, 6, 29, 0, 53, 53, 413, DateTimeKind.Unspecified).AddTicks(4028), 4L, 31L, false },
                    { 47L, 4L, new DateTime(2021, 2, 28, 0, 19, 44, 281, DateTimeKind.Unspecified).AddTicks(3661), 3L, 34L, false },
                    { 47L, 22L, new DateTime(2021, 8, 26, 17, 8, 57, 525, DateTimeKind.Unspecified).AddTicks(5515), 3L, 26L, false },
                    { 47L, 36L, new DateTime(2021, 12, 11, 11, 32, 7, 296, DateTimeKind.Unspecified).AddTicks(6399), 4L, 45L, false },
                    { 47L, 42L, new DateTime(2021, 2, 28, 0, 19, 22, 606, DateTimeKind.Unspecified).AddTicks(1668), 4L, 46L, false },
                    { 47L, 47L, new DateTime(2021, 10, 31, 10, 56, 40, 608, DateTimeKind.Unspecified).AddTicks(3955), 5L, 91L, false },
                    { 49L, 14L, new DateTime(2021, 7, 4, 0, 5, 4, 262, DateTimeKind.Unspecified).AddTicks(7232), 1L, 64L, false },
                    { 49L, 35L, new DateTime(2021, 3, 20, 11, 38, 43, 966, DateTimeKind.Unspecified).AddTicks(4660), 2L, 72L, false },
                    { 50L, 7L, new DateTime(2021, 12, 23, 12, 29, 59, 629, DateTimeKind.Unspecified).AddTicks(8895), 4L, 54L, false },
                    { 50L, 47L, new DateTime(2021, 4, 12, 9, 36, 41, 283, DateTimeKind.Unspecified).AddTicks(1477), 4L, 65L, false },
                    { 51L, 11L, new DateTime(2021, 10, 4, 6, 33, 5, 653, DateTimeKind.Unspecified).AddTicks(2922), 3L, 85L, false },
                    { 51L, 35L, new DateTime(2021, 3, 28, 2, 57, 57, 951, DateTimeKind.Unspecified).AddTicks(8237), 1L, 68L, false },
                    { 51L, 36L, new DateTime(2021, 3, 22, 8, 16, 57, 256, DateTimeKind.Unspecified).AddTicks(2678), 5L, 8L, false }
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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 12L, new DateTime(2021, 12, 14, 9, 1, 41, 712, DateTimeKind.Unspecified).AddTicks(4789), 3L, "Debitis assumenda eaque.\nAliquid omnis aut eos adipisci vel id rerum doloremque qui.\nQuia tempora iusto nobis numquam in.\nEt quam et.\nVel est impedit est incidunt delectus.", new DateTime(2023, 10, 2, 8, 52, 28, 942, DateTimeKind.Unspecified).AddTicks(309), "Harum expedita aliquam quia quam sunt in nisi dignissimos et.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2022, 1, 5, 16, 11, 51, 668, DateTimeKind.Unspecified).AddTicks(8955), 3L, "Consequatur vel est.\nEst ut et laboriosam ut in quos.\nQuam qui est illo et qui.", new DateTime(2022, 3, 13, 5, 2, 40, 545, DateTimeKind.Unspecified).AddTicks(1177), true, "Laborum sit debitis optio illum sint quis sunt ut id.", 37L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 5, 4, 13, 45, 37, 279, DateTimeKind.Unspecified).AddTicks(6304), 5L, "Doloremque eum voluptas rerum.\nDolorem quidem velit nulla.\nTempore dolore quidem.\nVoluptatibus dolorum rerum dolorem dolorum aspernatur vel molestiae.\nConsequatur placeat sed quia perspiciatis soluta est rerum numquam.", new DateTime(2022, 12, 14, 13, 3, 24, 6, DateTimeKind.Unspecified).AddTicks(7877), true, "Ut debitis nulla unde ut doloremque omnis dolores.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 10, 17, 4, 26, 11, 227, DateTimeKind.Unspecified).AddTicks(2391), 4L, "Labore neque error laborum dicta itaque sint facere.\nId deserunt qui necessitatibus libero quas sunt sint velit.\nBlanditiis illum natus ea explicabo officiis.\nEt sed consequatur fugit et at voluptate accusantium.\nNesciunt reiciendis quasi natus nihil.", new DateTime(2023, 6, 27, 10, 15, 44, 129, DateTimeKind.Unspecified).AddTicks(5438), "Et explicabo voluptatem sit itaque.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 4, 16, 10, 45, 47, 335, DateTimeKind.Unspecified).AddTicks(1734), 4L, "Et soluta et rem quod autem iusto.\nPlaceat expedita ea quod doloribus et.\nNisi aut dignissimos quidem porro.", new DateTime(2023, 8, 8, 13, 12, 30, 977, DateTimeKind.Unspecified).AddTicks(5085), "Expedita asperiores alias maxime maiores.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 12L, new DateTime(2021, 5, 5, 6, 12, 5, 214, DateTimeKind.Unspecified).AddTicks(7048), 5L, "Sed et ex molestias sit amet ut corporis non facilis.\nIste ea voluptatum quis et.", new DateTime(2023, 11, 12, 18, 54, 19, 670, DateTimeKind.Unspecified).AddTicks(598), true, "Voluptas consequuntur consequatur consequatur quaerat.", 32L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 11, 26, 2, 15, 53, 505, DateTimeKind.Unspecified).AddTicks(43), 2L, "Aut ea sunt placeat facere.\nId fugit ducimus ducimus blanditiis non laborum enim et nesciunt.\nOmnis rem fugit et voluptates provident sequi aliquid velit consectetur.\nAut sit tempore doloremque sit ex voluptatem voluptatem enim.", new DateTime(2023, 7, 19, 4, 56, 19, 281, DateTimeKind.Unspecified).AddTicks(16), false, "Dolorem tempore eius consequatur mollitia enim.", 38L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 9, 10, 6, 1, 31, 998, DateTimeKind.Unspecified).AddTicks(4248), "Ipsa et et.", new DateTime(2022, 7, 12, 10, 18, 56, 157, DateTimeKind.Unspecified).AddTicks(4704), "Nostrum iste aut saepe molestiae.", 24L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 2, 4, 5, 5, 58, 590, DateTimeKind.Unspecified).AddTicks(705), 1L, "Sit aut eum aut.\nDolor eos autem.\nExercitationem voluptate quae quasi et incidunt.\nEos quasi minima suscipit sit voluptatibus accusamus.\nDolor quidem culpa et non unde rerum.", new DateTime(2022, 10, 3, 1, 16, 2, 682, DateTimeKind.Unspecified).AddTicks(5160), false, "Assumenda consequatur voluptatem omnis nihil doloremque aliquam aut explicabo.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 6, 25, 14, 54, 19, 404, DateTimeKind.Unspecified).AddTicks(1657), 1L, "A adipisci ratione adipisci voluptatum.\nItaque illum iste.\nAperiam recusandae enim cumque consequatur animi asperiores ut nulla.", new DateTime(2022, 11, 27, 19, 17, 59, 489, DateTimeKind.Unspecified).AddTicks(3558), "Amet eligendi architecto animi nesciunt.", 11L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 10, 8, 8, 9, 34, 791, DateTimeKind.Unspecified).AddTicks(1560), 4L, "Tempore ab molestiae rerum sint et.\nDoloribus inventore corrupti.\nIllum sunt beatae suscipit ipsam sunt veniam vitae.", new DateTime(2022, 3, 27, 5, 4, 8, 306, DateTimeKind.Unspecified).AddTicks(5407), false, "Et rerum qui voluptatem qui dolorem quis nesciunt modi.", 4L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 2L, new DateTime(2021, 11, 29, 11, 22, 40, 703, DateTimeKind.Unspecified).AddTicks(120), 4L, "Molestiae dolorem quia numquam esse laudantium.", new DateTime(2023, 3, 17, 10, 27, 38, 409, DateTimeKind.Unspecified).AddTicks(4759), true, "Nostrum aspernatur non error.", 12L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 4, 22, 0, 7, 36, 83, DateTimeKind.Unspecified).AddTicks(1027), 5L, "Officiis eos quis saepe impedit.\nAut saepe veniam quia sit.\nDolores sit sequi saepe molestiae facere sed eveniet et.", new DateTime(2023, 7, 16, 12, 38, 30, 855, DateTimeKind.Unspecified).AddTicks(8435), "Et quos sit qui.", 20L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 6, 13, 13, 27, 42, 12, DateTimeKind.Unspecified).AddTicks(8813), 4L, "Saepe dolorem nisi consequatur.\nQuis provident rerum.\nIn repudiandae repellendus vitae ea blanditiis numquam labore reprehenderit porro.", new DateTime(2022, 6, 2, 10, 15, 30, 472, DateTimeKind.Unspecified).AddTicks(8084), true, "Voluptatem deserunt optio.", 39L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2021, 9, 22, 3, 10, 41, 786, DateTimeKind.Unspecified).AddTicks(5061), 5L, "Consequatur sit odit non aliquid tempore autem.\nIpsam cupiditate aut ipsam.\nVelit blanditiis fugiat ipsa vitae.\nSed non commodi laborum pariatur praesentium nisi labore nam.\nEa voluptates totam enim impedit vitae.", new DateTime(2022, 3, 15, 8, 53, 30, 414, DateTimeKind.Unspecified).AddTicks(7211), "Eos quibusdam consequuntur.", 5L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 8, 30, 22, 48, 0, 825, DateTimeKind.Unspecified).AddTicks(4773), 5L, "Qui est rerum quisquam quaerat.\nAut iusto quo eligendi a laborum.\nConsequatur similique fugit qui ipsam nobis ad nihil.\nVeritatis ea ut.", new DateTime(2023, 3, 16, 6, 19, 47, 91, DateTimeKind.Unspecified).AddTicks(974), "Consequatur nisi nostrum enim nam molestiae labore amet illum.", 13L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2022, 2, 1, 9, 37, 5, 467, DateTimeKind.Unspecified).AddTicks(6876), 5L, "Voluptas officia quidem dolor.\nSit delectus esse officiis optio aut sint temporibus aliquid.", new DateTime(2023, 8, 6, 18, 5, 46, 770, DateTimeKind.Unspecified).AddTicks(3884), false, "Voluptatum nesciunt aut iste est laudantium ullam sunt est quidem.", 28L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 10, 16, 1, 23, 7, 244, DateTimeKind.Unspecified).AddTicks(2448), 3L, "Dolorem eum quibusdam harum expedita quo reprehenderit omnis.\nId enim qui.", new DateTime(2023, 12, 31, 6, 22, 35, 266, DateTimeKind.Unspecified).AddTicks(51), true, "Est beatae autem et aspernatur omnis sit delectus voluptas.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 4, 21, 17, 39, 26, 742, DateTimeKind.Unspecified).AddTicks(3053), 2L, "Et eos dolores ex quaerat.\nNon minus recusandae ullam aperiam.\nIpsam ipsa error itaque eligendi.\nQuod velit exercitationem recusandae voluptas qui.\nConsectetur rerum enim placeat doloribus hic saepe deleniti nihil impedit.", new DateTime(2023, 9, 5, 23, 19, 34, 423, DateTimeKind.Unspecified).AddTicks(6562), true, "Ut omnis enim.", 17L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 12, 6, 11, 32, 58, 756, DateTimeKind.Unspecified).AddTicks(2281), 2L, "Omnis ratione qui autem enim provident est.\nAut perspiciatis est asperiores dolorem sunt sint dolorum ex.\nPraesentium officiis ex.\nPerspiciatis cumque repellendus consectetur quos ducimus temporibus debitis doloribus.\nRecusandae repudiandae aut beatae excepturi expedita.", new DateTime(2022, 8, 28, 3, 30, 41, 573, DateTimeKind.Unspecified).AddTicks(8031), false, "Et dolor in eveniet ea voluptatem.", 35L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 4, 13, 7, 3, 35, 773, DateTimeKind.Unspecified).AddTicks(6420), 4L, "Ut possimus eius rem reprehenderit est neque optio.\nVeniam accusantium ad quia corporis.\nPlaceat quam nulla.\nEa architecto tempore quasi adipisci saepe quod deserunt magnam.", new DateTime(2022, 11, 1, 18, 34, 19, 372, DateTimeKind.Unspecified).AddTicks(8883), "Quam officiis nam amet fugiat sit.", 21L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 7, 4, 21, 29, 44, 604, DateTimeKind.Unspecified).AddTicks(8805), 1L, "Neque ipsam praesentium et autem.\nVoluptas temporibus veritatis asperiores voluptas nihil est tempore ut.\nOccaecati et labore aperiam quisquam vero nobis dolorum sed laborum.", new DateTime(2022, 12, 5, 15, 19, 31, 468, DateTimeKind.Unspecified).AddTicks(1435), true, "Quae nobis ut dolorum blanditiis sed voluptatum odio.", 20L });

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
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 4L, new DateTime(2021, 11, 9, 6, 57, 3, 393, DateTimeKind.Unspecified).AddTicks(3521), "Quo rerum cumque et sapiente.\nCorrupti voluptatum doloribus praesentium autem debitis distinctio consectetur.\nDolorem magni quidem aut aut enim odio veniam.", new DateTime(2023, 6, 4, 2, 30, 15, 420, DateTimeKind.Unspecified).AddTicks(641), true, "Iure odio nam rerum.", 17L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 2, 26, 20, 29, 59, 219, DateTimeKind.Unspecified).AddTicks(4177), 4L, "Minima vitae est iusto ratione excepturi facere.\nQuia atque natus nemo.\nNulla in voluptatem.\nId aperiam voluptatem autem quia aliquam.\nIure et tempore.", new DateTime(2023, 1, 20, 5, 32, 24, 706, DateTimeKind.Unspecified).AddTicks(7950), "Deserunt sed qui libero quas accusantium saepe.", 13L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 8, 14, 12, 54, 0, 489, DateTimeKind.Unspecified).AddTicks(9888), 1L, "Quo enim amet corrupti consequatur.", null, "Odit nihil vero eligendi id tenetur dolorem fuga.", 20L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 17L, new DateTime(2021, 3, 25, 16, 31, 29, 597, DateTimeKind.Unspecified).AddTicks(8117), 5L, "Ullam qui corrupti.\nCulpa magnam architecto mollitia quis.", new DateTime(2023, 10, 30, 19, 0, 21, 113, DateTimeKind.Unspecified).AddTicks(3218), "Laudantium debitis dolorum et dicta molestias.", 14L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 6, 18, 6, 8, 39, 990, DateTimeKind.Unspecified).AddTicks(3904), 1L, "Qui alias debitis debitis deleniti tenetur voluptas vel et.", new DateTime(2023, 10, 17, 7, 21, 42, 701, DateTimeKind.Unspecified).AddTicks(4021), "Qui sapiente dolorem eos exercitationem explicabo cupiditate odio.", 13L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 7, 26, 3, 37, 40, 168, DateTimeKind.Unspecified).AddTicks(8371), 4L, "Sunt earum tempore consequatur molestias totam ab.\nVero iste culpa distinctio ad.\nSed dolorem tenetur doloribus sapiente deserunt nam eos fuga.\nQuo rerum eaque omnis voluptas dolor assumenda ut.\nEos voluptatum voluptatem.", new DateTime(2023, 9, 1, 2, 29, 31, 175, DateTimeKind.Unspecified).AddTicks(9669), "Debitis quae dolores consectetur rem sapiente iste aperiam.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 5, 30, 12, 49, 5, 83, DateTimeKind.Unspecified).AddTicks(5041), "Architecto non debitis impedit voluptatem non aut.", new DateTime(2023, 4, 30, 16, 13, 55, 482, DateTimeKind.Unspecified).AddTicks(9494), true, "Quia aut eius assumenda cumque architecto corporis.", 33L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 12, 20, 19, 51, 9, 35, DateTimeKind.Unspecified).AddTicks(5559), 1L, "Veniam et ab nostrum qui rerum.\nFugit laboriosam deleniti laudantium ipsum velit adipisci.\nVoluptatem voluptas alias vero sed voluptatibus magnam accusantium aperiam.\nEum temporibus sunt harum eum ad molestiae ratione dolor temporibus.\nDolorem quam accusamus nostrum.", new DateTime(2022, 10, 17, 18, 50, 4, 602, DateTimeKind.Unspecified).AddTicks(7246), "Facilis eos ipsam quibusdam vel.", 22L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 11, 19, 13, 46, 55, 178, DateTimeKind.Unspecified).AddTicks(5038), 3L, "Sit et odio nemo voluptatem eos consequatur culpa deleniti.", new DateTime(2023, 3, 20, 5, 5, 26, 150, DateTimeKind.Unspecified).AddTicks(5764), true, "Libero id possimus fugiat voluptatum ea in assumenda possimus.", 28L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 14L, new DateTime(2021, 11, 19, 15, 43, 42, 171, DateTimeKind.Unspecified).AddTicks(2793), "Dolores et aliquam facilis iste et voluptas sit.", new DateTime(2022, 5, 4, 7, 59, 53, 262, DateTimeKind.Unspecified).AddTicks(1837), true, "Voluptatibus recusandae officiis accusantium odit perferendis ut dolor enim est.", 15L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 15L, new DateTime(2021, 4, 13, 10, 30, 42, 417, DateTimeKind.Unspecified).AddTicks(9730), 4L, "Consequatur sed quaerat repellat ullam sit beatae ducimus.", new DateTime(2023, 10, 15, 3, 3, 39, 878, DateTimeKind.Unspecified).AddTicks(6757), "Ut tenetur natus quia et consequatur qui esse fugiat rerum.", 37L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 6L, new DateTime(2021, 3, 18, 3, 37, 13, 520, DateTimeKind.Unspecified).AddTicks(4200), 1L, "Eveniet cupiditate nesciunt voluptas.", new DateTime(2023, 5, 12, 23, 59, 0, 9, DateTimeKind.Unspecified).AddTicks(7802), true, "Necessitatibus ex aperiam magnam non eveniet quas.", 24L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 18L, new DateTime(2021, 2, 3, 6, 59, 24, 644, DateTimeKind.Unspecified).AddTicks(3663), 2L, "Consequatur necessitatibus id dignissimos inventore.", new DateTime(2022, 9, 24, 13, 0, 19, 475, DateTimeKind.Unspecified).AddTicks(7829), false, "Delectus et quia nulla cumque rerum ab.", 19L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 13L, new DateTime(2021, 11, 2, 3, 36, 25, 623, DateTimeKind.Unspecified).AddTicks(3553), 4L, "Aut consequuntur dolore dolores vero veritatis commodi minus voluptas et.\nRepellendus consequatur magnam.\nMolestias ea dolores accusantium sed cum hic.", new DateTime(2023, 4, 1, 12, 48, 49, 85, DateTimeKind.Unspecified).AddTicks(9244), "Qui nobis iusto aut temporibus quo nihil ipsam qui.", 29L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 8, 3, 18, 29, 27, 737, DateTimeKind.Unspecified).AddTicks(1737), 1L, "Est cupiditate delectus.\nQui qui veniam eius suscipit eveniet molestiae possimus aliquam sed.\nIllum quibusdam ab incidunt recusandae.\nUt maiores vitae consequatur tempore deleniti aliquid.", new DateTime(2023, 2, 20, 1, 27, 32, 474, DateTimeKind.Unspecified).AddTicks(3894), "Velit odit eius reiciendis eveniet.", 20L });

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
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2022, 1, 8, 22, 19, 37, 131, DateTimeKind.Unspecified).AddTicks(5591), 3L, "Ipsam labore et et labore nihil aut dignissimos.\nMolestiae voluptatum laboriosam est rerum similique sint id.\nArchitecto sequi accusantium labore rerum nam soluta repellat.\nDeserunt nostrum iste ut iste et ratione pariatur.", new DateTime(2023, 11, 28, 6, 17, 50, 812, DateTimeKind.Unspecified).AddTicks(1465), false, "Eum molestiae quis maxime suscipit autem voluptatem sit repellendus.", 10L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 8, 20, 21, 36, 53, 739, DateTimeKind.Unspecified).AddTicks(5878), 3L, "Iste esse dolorem perferendis delectus aut sint totam.\nSunt quod beatae ipsam et quaerat nisi totam.\nAlias nobis accusantium iusto sed atque voluptas ipsa eius alias.\nQuia iste perspiciatis eos officia debitis ea corrupti.", new DateTime(2022, 5, 4, 2, 33, 33, 302, DateTimeKind.Unspecified).AddTicks(7969), "Aliquam rem exercitationem.", 41L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "Title" },
                values: new object[] { new DateTime(2021, 3, 17, 21, 0, 7, 821, DateTimeKind.Unspecified).AddTicks(2360), 3L, "Fuga id doloremque tempore quis voluptate reprehenderit quia sint.\nAut ipsum cupiditate hic vel placeat.\nPossimus quo laudantium sed repellat quibusdam.", null, "Iusto eum aliquid aut molestias aut expedita et." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2021, 6, 7, 13, 4, 23, 713, DateTimeKind.Unspecified).AddTicks(5650), 1L, "Vitae est id atque odit sequi perferendis eveniet voluptatem nemo.\nNeque omnis dignissimos eveniet adipisci voluptatibus.", new DateTime(2022, 7, 31, 23, 3, 19, 87, DateTimeKind.Unspecified).AddTicks(8477), "Repellendus ipsa itaque tempora fuga.", 16L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 19L, new DateTime(2022, 2, 1, 15, 36, 28, 649, DateTimeKind.Unspecified).AddTicks(681), 2L, "Maiores reiciendis voluptatibus molestiae nulla.\nReiciendis placeat nihil sit porro provident qui rerum pariatur.\nVoluptatibus asperiores dignissimos quibusdam molestiae velit voluptates aut minima ut.\nDolores aperiam aut architecto minus.", new DateTime(2024, 1, 6, 20, 27, 57, 243, DateTimeKind.Unspecified).AddTicks(4950), false, "Excepturi eum magnam est omnis incidunt exercitationem voluptas molestiae.", 34L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 10L, new DateTime(2021, 2, 15, 4, 41, 52, 442, DateTimeKind.Unspecified).AddTicks(3314), 4L, "Enim suscipit voluptatibus alias molestiae.\nEt consequatur ratione earum blanditiis nulla porro.\nAut maiores similique qui aut harum a neque.\nQuis dolorum cupiditate placeat.\nDolor maiores voluptatum cupiditate modi.", new DateTime(2023, 8, 11, 18, 58, 55, 430, DateTimeKind.Unspecified).AddTicks(206), "Nesciunt quia et distinctio rerum autem exercitationem molestiae et.", 8L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 21L, new DateTime(2021, 8, 15, 14, 6, 4, 856, DateTimeKind.Unspecified).AddTicks(1148), "Delectus provident consequatur est.\nEum veniam ipsam voluptatem consequuntur optio vel in.", new DateTime(2023, 9, 27, 5, 32, 54, 895, DateTimeKind.Unspecified).AddTicks(3257), false, "Voluptatem asperiores tempore nulla cumque.", 39L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { new DateTime(2021, 12, 20, 20, 8, 38, 21, DateTimeKind.Unspecified).AddTicks(2165), 3L, "Corrupti commodi qui nostrum suscipit repellendus id consequatur voluptatem omnis.\nItaque ducimus unde et ab qui voluptas excepturi.\nNeque excepturi autem est nihil.", new DateTime(2022, 7, 21, 13, 49, 35, 888, DateTimeKind.Unspecified).AddTicks(8372), true, "Tenetur asperiores quis ut id error harum.", 7L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 5L, new DateTime(2021, 5, 27, 17, 5, 43, 455, DateTimeKind.Unspecified).AddTicks(2703), 2L, "Et ipsa veritatis.", new DateTime(2023, 1, 5, 2, 9, 54, 327, DateTimeKind.Unspecified).AddTicks(5115), false, "Et aliquid distinctio omnis.", 22L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsPublished", "Title", "UnitId" },
                values: new object[] { 11L, new DateTime(2021, 11, 9, 17, 6, 30, 174, DateTimeKind.Unspecified).AddTicks(1076), 5L, "Maiores consequatur qui aut consequatur sunt autem qui rerum quas.\nExplicabo rerum at itaque.\nCumque rem nostrum cumque laborum nobis.\nVoluptatem quisquam non voluptate reprehenderit aspernatur laboriosam.\nCum omnis nobis.", new DateTime(2023, 8, 20, 14, 58, 10, 942, DateTimeKind.Unspecified).AddTicks(5599), false, "Possimus sit voluptatem quibusdam sed consequuntur.", 21L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 16L, new DateTime(2021, 6, 16, 0, 16, 26, 622, DateTimeKind.Unspecified).AddTicks(3698), "Est quo aspernatur.\nUllam enim error vel veniam.\nIn quae corporis et.", new DateTime(2023, 1, 3, 20, 6, 19, 720, DateTimeKind.Unspecified).AddTicks(2969), "Possimus ab qui omnis esse natus ut dolore.", 41L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 20L, new DateTime(2021, 3, 18, 11, 52, 35, 373, DateTimeKind.Unspecified).AddTicks(1015), "Ratione in et molestiae quo qui quia.\nAperiam itaque qui rerum quia ut.\nMaxime ullam sunt officiis ea qui laborum cupiditate.\nVoluptate eaque et molestias nam.\nExplicabo architecto ipsam distinctio aliquam rem.", null, "Et et aperiam vero quidem vel rem nemo.", 26L });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CourseId", "CreatedAt", "Description", "DueDate", "Title", "UnitId" },
                values: new object[] { 7L, new DateTime(2022, 1, 28, 0, 42, 13, 607, DateTimeKind.Unspecified).AddTicks(6629), "Iusto est est provident ab rerum.\nEt iure vel.\nSunt voluptas molestias harum nam perferendis labore nobis exercitationem.", new DateTime(2023, 1, 9, 8, 1, 53, 529, DateTimeKind.Unspecified).AddTicks(832), "Veritatis sequi exercitationem voluptatum voluptas ratione saepe.", 20L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 29, 16, 47, 24, 402, DateTimeKind.Unspecified).AddTicks(6916), 2L, "Quaerat voluptas debitis.\nSoluta harum voluptatem quam reprehenderit.\nEt ut dolor dolorem minima ea.\nDicta cum quo vel error quis delectus.", false, false, 1, 29L, new Guid("783eb20f-a38c-9c37-d8d6-466fbb77b46c"), "Vel voluptatem temporibus ducimus iste quibusdam voluptatibus quisquam voluptatem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 46, 6, 739, DateTimeKind.Unspecified).AddTicks(6664), 1L, "Ut vitae eum omnis sit magni harum deserunt velit praesentium.\nQuia magni rem enim unde alias.", 20L, new Guid("b55b2d2d-16f8-ef5d-ff48-ccd1261d6a17"), "Rem vero quisquam quisquam a enim odit omnis consequuntur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 25, 16, 24, 30, 74, DateTimeKind.Unspecified).AddTicks(359), 2L, "Quo et dolorem unde ea maiores quae numquam soluta.\nDolor nihil esse odio quam.\nAssumenda et et dolore non est totam in aliquid.\nAb quia at saepe omnis ut quam eos nemo repellendus.", false, false, 0, 37L, new Guid("451040fc-cd2a-c29d-c2b5-d76ec36a50cb"), "Perspiciatis et repellendus pariatur ipsum asperiores voluptatem accusantium error." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 29, 3, 34, 59, 392, DateTimeKind.Unspecified).AddTicks(2398), 5L, "Dolores quidem voluptatem tenetur quod.", 0, 14L, new Guid("f8d51488-914f-4cfa-0fe8-45c0385d8f47"), "Quidem iure officia assumenda id sequi recusandae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 24, 8, 32, 39, 852, DateTimeKind.Unspecified).AddTicks(810), 5L, "Sunt excepturi vero cumque earum.\nMolestiae minima quos repellendus odio id.\nEnim sunt quasi assumenda fuga quo suscipit aperiam eos culpa.\nEt omnis ipsum sit est ut sed.\nIpsum quia ratione.", true, 1, 5L, new Guid("7ad58ade-ad47-35b7-c510-42bd994a70c5"), "Dolor dignissimos illo et illo soluta ut repudiandae non." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 12, 2, 28, 27, 532, DateTimeKind.Unspecified).AddTicks(6588), 2L, "Error error neque est porro aut.\nDolorem qui id eos hic sint quos.", false, false, 1, 15L, new Guid("bd9a6d8a-532d-7f44-b7bd-93cb29ab5f93"), "Ad harum inventore consequatur sit provident." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 29, 0, 36, 20, 253, DateTimeKind.Unspecified).AddTicks(7556), 2L, "Animi est natus quia magnam id dolorum earum.\nUt eius facilis et expedita amet sed.\nOdit error rerum illo a enim necessitatibus error soluta.\nIusto eius minima aut corrupti.", 3L, new Guid("eee2d290-f822-3c2e-2699-3ad0727092c8"), "Fuga alias adipisci rem quasi blanditiis saepe rerum earum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 11, 8, 13, 51, 527, DateTimeKind.Unspecified).AddTicks(4824), "Accusamus qui laboriosam et commodi.\nIllum dolore animi repellendus.\nOmnis ut debitis nemo quas quod dolorum magnam perferendis quia.\nQuasi molestiae sunt.", 39L, new Guid("e2861ab3-762d-e8bc-d25a-a25671fa4c75"), "Dolor aut et illo qui culpa inventore." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 5, 6, 35, 30, 245, DateTimeKind.Unspecified).AddTicks(648), 5L, "Quo laudantium aut dolores tempore nemo ab omnis magni.\nBlanditiis repellendus impedit corporis eius.\nLaborum minus odio nihil maiores repudiandae incidunt aliquid.\nAut quibusdam eveniet quasi consequatur est.\nAut numquam id similique.", true, 18L, new Guid("e34fb4a6-c2dc-6783-162e-706e13c72f13"), "Omnis est non pariatur quisquam doloremque voluptatem doloremque iure." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 4, 2, 56, 45, 840, DateTimeKind.Unspecified).AddTicks(6477), 1L, "Cumque et ut in voluptatem fugit.\nDistinctio corporis sed ducimus accusantium voluptatibus.\nSit asperiores praesentium facere aut voluptatem.\nEt sit provident numquam qui illum.\nFuga quis sed quidem dolores et cum inventore qui.", false, 2L, new Guid("eebb27ff-af79-d946-0935-368554860d41"), "Aut et rem sed vel quo beatae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 14, 8, 58, 42, 645, DateTimeKind.Unspecified).AddTicks(8581), 2L, "Consequatur non ex quod quia voluptatem molestias.", false, false, 12L, new Guid("60776431-af43-7786-7195-16009e225b1f"), "Corporis aut officia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 27, 21, 56, 3, 597, DateTimeKind.Unspecified).AddTicks(7248), 2L, "Ut ut nulla ducimus ex quasi.\nEa rerum mollitia aut qui itaque.\nIn voluptas consequuntur mollitia officiis.", false, 1, 50L, new Guid("e8333073-b30a-e840-df9f-cf766750108b"), "Et omnis est eum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 13, 11, 9, 32, 689, DateTimeKind.Unspecified).AddTicks(4625), 5L, "Expedita accusantium placeat ea iure praesentium aspernatur dolorum iusto aliquid.", false, true, 1, 22L, new Guid("e2a7f090-4b55-9931-56f0-7ba337182376"), "Harum quasi a dicta qui est quod et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 28, 2, 37, 53, 924, DateTimeKind.Unspecified).AddTicks(4371), 4L, "Doloribus cupiditate commodi ducimus quia sunt architecto fugiat esse tempora.", false, 3L, new Guid("0da5a201-21cf-633d-ad73-5e372556ff2c"), "Velit vero distinctio." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 18, 10, 1, 5, 38, DateTimeKind.Unspecified).AddTicks(5160), 4L, "Qui commodi ea sint cupiditate non ab consequatur consequatur qui.", false, 27L, new Guid("e74728cb-8bd5-e86d-d1f8-d1c83faa71a2"), "Nihil corrupti provident sed et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 4, 15, 37, 19, 982, DateTimeKind.Unspecified).AddTicks(6461), 4L, "Magnam est et similique vel fugiat occaecati perferendis aliquid velit.", false, 0, 40L, new Guid("83802a81-166b-9d49-2a57-393943ec6636"), "Minima minus laborum inventore consequuntur aut qui nulla ea." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "Description", "IsGitImported", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 29, 16, 58, 42, 466, DateTimeKind.Unspecified).AddTicks(5658), "Molestiae maiores id.\nQui deleniti provident in ut.\nQuo est voluptatem earum.\nAdipisci odio molestias porro repudiandae exercitationem quia.", false, true, 0, 9L, new Guid("9940a288-2beb-f1a2-c731-7d0c75635dba"), "Ex maiores quos cum enim non impedit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 12, 19, 20, 5, 251, DateTimeKind.Unspecified).AddTicks(3774), 5L, "Et rerum illo laboriosam dignissimos eaque recusandae eligendi.\nVoluptatem porro hic cum iste.\nSunt cum modi beatae quo.\nQuibusdam laudantium voluptates est nisi ab vitae dignissimos ut tempora.\nIllum ut qui culpa ab quam voluptas animi.", 38L, new Guid("19b0004a-1806-d891-cce9-bbf8aecc3235"), "Similique eaque repellat optio rerum iure modi aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 6, 12, 31, 2, 564, DateTimeKind.Unspecified).AddTicks(3299), "Ut omnis ipsa aliquam vel deleniti eligendi ut aut.", false, 13L, new Guid("49600880-e682-d923-bf84-f11fc2f25087"), "Quo ipsum ipsum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 18, 7, 15, 34, 974, DateTimeKind.Unspecified).AddTicks(2072), "Quo aliquid quam adipisci.\nNeque aliquid officiis est earum reiciendis.\nQuis praesentium ea quidem iure.\nDolores atque quidem accusamus ea.", 4L, new Guid("72c35ee9-5b5d-4725-8929-9af7a6ff8715"), "Quae rerum provident est eos." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 12, 9, 23, 35, 24, DateTimeKind.Unspecified).AddTicks(42), 5L, "Sit sunt nulla rerum qui perferendis quas quia nemo repellat.", 48L, new Guid("35ce22ba-607d-e41c-baac-c096e06654f3"), "Dolores qui vel et illum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 24, 10, 3, 20, 209, DateTimeKind.Unspecified).AddTicks(5391), 2L, "Et similique quis distinctio fugiat sapiente.\nVoluptatum nam id sed aut illum saepe rerum qui.\nIste nesciunt dolorem.\nAlias est id repellat tempore praesentium et.\nRecusandae est hic eveniet et ratione repellat et.", false, 0, 21L, new Guid("484f173a-bf87-0037-2747-0be5f4de2f04"), "Sint consequatur reprehenderit reprehenderit veritatis assumenda doloremque illo error officiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 27, 12, 11, 6, 306, DateTimeKind.Unspecified).AddTicks(8871), 5L, "Rerum facilis voluptas eum aut dignissimos dolorem tempora.", false, 1, 27L, new Guid("751df6f9-d1fe-92b0-9dc6-dc6b859139b2"), "Vitae illo sequi qui eum modi quis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "Description", "IsGitImported", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 20, 8, 2, 38, 26, DateTimeKind.Unspecified).AddTicks(8101), "Animi soluta cum qui reiciendis porro facilis fuga accusamus molestiae.\nQuia dolor inventore et.", false, false, 1, 13L, new Guid("5fa7175d-46f7-af66-864b-6dd9303e0ade"), "Natus impedit doloribus pariatur assumenda et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 49, 33, 816, DateTimeKind.Unspecified).AddTicks(6883), 5L, "Debitis officia minus sunt.\nLaboriosam id aut vel aut optio in.", 13L, new Guid("103dc1e0-65a3-a3d4-5413-cec4e9625d9f"), "Laborum dolor iusto maxime." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 6, 12, 16, 48, 303, DateTimeKind.Unspecified).AddTicks(1011), 5L, "Enim pariatur sit et aspernatur et blanditiis.\nRem ut provident modi itaque natus veniam sit ea.\nSint a et rem similique.\nVelit ducimus modi non quae saepe quasi.", false, 45L, new Guid("d98e9ad8-b87c-9139-2d29-d9ee08b33112"), "Aut mollitia et et ipsum aut nisi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 27, 9, 14, 7, 597, DateTimeKind.Unspecified).AddTicks(5907), "A ad repellendus optio.\nVero sed explicabo nobis iste.\nPorro aut harum.", true, 1, 41L, new Guid("035b23c6-0feb-86fb-b9ad-70c421d489e5"), "Ad ut in molestias facere natus tenetur architecto repudiandae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 9, 19, 19, 39, 125, DateTimeKind.Unspecified).AddTicks(1864), 4L, "Quia enim aut quod sed nam laudantium animi reiciendis.", true, false, 0, 27L, new Guid("52c79a61-1978-790a-25a6-ac1b437862a8"), "Totam sed minima voluptatem cum necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 25, 35, 560, DateTimeKind.Unspecified).AddTicks(131), 4L, "Et qui et beatae qui aperiam tempora.\nSed repellendus aliquid.", 22L, new Guid("eb9836ab-50fc-360e-e822-baed6a4b1a6f"), "Non totam rerum ea in ut facilis quidem quia voluptate." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 9, 0, 52, 25, 652, DateTimeKind.Unspecified).AddTicks(7441), 4L, "Voluptatem dolor sint nulla.\nQuos et quo quasi et illo tempore quidem corporis.", true, true, 9L, new Guid("7f53833c-e822-a238-5f16-d80e489c8846"), "Voluptate magni a ducimus inventore voluptatibus est et aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 2, 6, 55, 37, 146, DateTimeKind.Unspecified).AddTicks(1433), 3L, "Enim blanditiis vitae et sequi quidem accusantium.\nExpedita officia porro.\nAspernatur beatae tempora necessitatibus.\nOfficiis repellendus ex.\nIste iure fugit voluptas dolorem pariatur.", 50L, new Guid("f2f8cde8-2e29-f80d-b2ef-14f15c97feda"), "Et omnis doloremque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 16, 16, 22, 48, 162, DateTimeKind.Unspecified).AddTicks(3376), 1L, "Sit repellendus veniam.\nFugit et dolor voluptates deserunt odit dolores earum sed.\nQuo eum eius.\nPlaceat necessitatibus quia aut voluptatum molestias aut qui.\nVeritatis autem in aliquam accusantium aut qui odio.", true, 0, 39L, new Guid("6874a4f7-6d0e-1e5a-bbdb-46593e50e882"), "Ut explicabo rerum ut assumenda quasi cupiditate." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 13, 10, 12, 50, 407, DateTimeKind.Unspecified).AddTicks(1708), 4L, "Nihil officia autem tenetur qui voluptas quam asperiores.\nVoluptate voluptatibus et corrupti.", true, true, 13L, new Guid("54fb2225-bb77-7a06-6dfa-33c489feeb5e"), "Sed ut aut magni minima consectetur omnis et necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 17, 11, 49, 45, 67, DateTimeKind.Unspecified).AddTicks(7286), 5L, "A nobis laborum qui beatae vel dignissimos dignissimos fugit.\nSit facilis repudiandae.\nArchitecto temporibus velit illum rerum sapiente ut sed esse.", true, 1, 23L, new Guid("d56afe14-562b-f814-9064-906bbcbed9f6"), "Modi voluptatibus rem quo est dicta non quidem et quam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 22, 4, 48, 56, 350, DateTimeKind.Unspecified).AddTicks(5936), 4L, "Voluptates modi corrupti voluptas voluptas ut odio minima nihil hic.\nNatus aut sunt sint consequatur quibusdam.", false, true, 1, 42L, new Guid("385f6ef6-a33a-924e-953e-b9f3d14d0166"), "Maiores nam quidem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 17, 11, 2, 30, 530, DateTimeKind.Unspecified).AddTicks(5371), 1L, "Ipsam voluptas dolores quia itaque est voluptas.\nEt qui odit aspernatur modi animi asperiores at.\nArchitecto vero occaecati.", false, 26L, new Guid("ea4d49f3-844e-e0ca-e742-095c4f872257"), "Architecto consectetur ea exercitationem ipsum voluptas est pariatur similique sequi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "Description", "IsGitImported", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 11, 15, 38, 23, 957, DateTimeKind.Unspecified).AddTicks(728), "Veritatis voluptates quis vitae consequatur.", true, true, 33L, new Guid("942d2556-0b4e-1ebb-5ac6-97bf34347e45"), "Maxime enim deleniti recusandae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 30, 19, 56, 33, 808, DateTimeKind.Unspecified).AddTicks(4072), 4L, "Sunt est voluptatem autem.\nDicta non eum aut adipisci ipsum corrupti et quisquam.\nNisi ut voluptas.", false, 0, 42L, new Guid("bf9fd043-8246-d269-703a-6154e4993625"), "Voluptatem vel eum quia officiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 5, 3, 8, 32, 646, DateTimeKind.Unspecified).AddTicks(7519), 4L, "Illum aut assumenda molestiae.\nEt natus in sed voluptatem quia.\nConsequatur accusamus et.\nPraesentium dolorum voluptas doloremque asperiores ea dolor et ut est.\nHic rerum hic nihil ex labore.", false, false, 4L, new Guid("b3132ac4-c6a9-e5b5-fa6f-4142dc00055e"), "Labore nobis quia ea mollitia aut neque et quia vel." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 18, 6, 46, 29, 421, DateTimeKind.Unspecified).AddTicks(4535), 1L, "Pariatur architecto quasi et et eum exercitationem veritatis nostrum.\nLaboriosam ex ea veritatis laudantium aut.\nQuas eaque odit aut qui.", 0, 40L, new Guid("52704dcf-fe36-e661-6198-b4e865b255f9"), "Quod culpa voluptatem molestiae explicabo quis ratione expedita." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 10, 19, 41, 4, 190, DateTimeKind.Unspecified).AddTicks(8380), 2L, "Non quos aut qui autem.\nMolestiae sunt omnis placeat optio neque deserunt sunt.", true, 1, 21L, new Guid("7f4531c6-bb3a-78f7-a9c6-eb188382dd8e"), "Consequuntur qui assumenda eum et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 29, 21, 55, 21, 335, DateTimeKind.Unspecified).AddTicks(2705), 2L, "Enim porro reprehenderit incidunt unde.", false, 48L, new Guid("5fa8dabb-92a2-cb75-5b69-1ddf4106e2ef"), "A dicta totam voluptas." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 28, 13, 55, 43, 422, DateTimeKind.Unspecified).AddTicks(2693), 5L, "Est illum placeat.\nRerum cum pariatur sed quidem exercitationem.", 17L, new Guid("e7886e74-eecf-4359-cfa2-bede5629d3ae"), "Aliquam ea quas." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 0, 7, 893, DateTimeKind.Unspecified).AddTicks(7495), "Reiciendis id incidunt sit consequatur atque.\nAliquam consequuntur quaerat quas consequatur porro illo qui.\nSaepe esse odio.\nEst reprehenderit autem veritatis.\nPerspiciatis culpa optio ut aut numquam voluptas.", false, 24L, new Guid("05273f7a-f63f-2fed-4e54-97ecaecc737b"), "Consectetur ex ut repellat veritatis maxime." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 31, 22, 56, 41, 375, DateTimeKind.Unspecified).AddTicks(9431), 4L, "Sit voluptates fugit quae dolor voluptatum deserunt eaque consequuntur iste.\nAmet quisquam voluptatem vero cumque.", true, true, 15L, new Guid("07faf390-7f04-8d25-b0b0-6010a1c46aa1"), "Quisquam qui accusamus est." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 8, 11, 10, 651, DateTimeKind.Unspecified).AddTicks(5494), 5L, "Pariatur fugiat consequuntur consequatur incidunt nisi vitae ut in ad.\nVoluptatem id eveniet quia animi tempora et sint.\nConsequuntur nihil temporibus nesciunt similique quibusdam dolor et est voluptates.\nAtque est perspiciatis vel.\nRerum a qui laudantium officiis id autem.", false, 15L, new Guid("6f1628b3-8e86-8fd4-66f0-ea83fe805e6a"), "Ratione totam et nulla odio et incidunt ut assumenda." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 13, 21, 8, 7, 182, DateTimeKind.Unspecified).AddTicks(238), 5L, "Voluptatem doloremque non dolor aut placeat in.", 41L, new Guid("2f74e91f-c6a6-d8c3-20a4-e6dff9659c89"), "Suscipit quibusdam nulla non omnis molestiae quae delectus iusto iusto." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 5, 17, 41, 40, 824, DateTimeKind.Unspecified).AddTicks(162), 2L, "Explicabo libero molestias et ad error eius.", false, 0, 9L, new Guid("bb4be29d-2595-253c-7659-f0efe0b7e50e"), "Cupiditate voluptatem ut distinctio minima impedit sed optio." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsGitImported", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 23, 11, 23, 2, 409, DateTimeKind.Unspecified).AddTicks(3518), 5L, "Magni recusandae repudiandae nulla.\nQuia nemo est ut asperiores aperiam eius voluptatem.\nOfficia deleniti inventore voluptas qui.", false, false, 38L, new Guid("9affecc1-b76c-3522-29e6-2fb74c54acfb"), "Enim fuga aperiam voluptatem ullam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "Description", "IsGitImported", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 15, 16, 50, 5, 189, DateTimeKind.Unspecified).AddTicks(9104), "Et rerum dolores earum doloremque autem sint eaque.", false, true, 22L, new Guid("5b4e453e-4457-9174-77d3-ba511bb48635"), "Fuga molestiae doloremque vel." });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 9L, new DateTime(2021, 5, 22, 14, 15, 9, 915, DateTimeKind.Unspecified).AddTicks(3191), new DateTime(2022, 1, 8, 18, 0, 43, 155, DateTimeKind.Unspecified).AddTicks(9820), 42L, new DateTime(2019, 12, 11, 13, 36, 36, 444, DateTimeKind.Unspecified).AddTicks(201), new DateTime(2021, 12, 27, 20, 17, 40, 256, DateTimeKind.Unspecified).AddTicks(5375) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 28L, new DateTime(2021, 5, 4, 23, 3, 39, 632, DateTimeKind.Unspecified).AddTicks(5361), 5L, new DateTime(2022, 1, 30, 7, 34, 17, 768, DateTimeKind.Unspecified).AddTicks(7614), new DateTime(2019, 9, 14, 17, 12, 51, 224, DateTimeKind.Unspecified).AddTicks(4248), new DateTime(2021, 11, 19, 3, 3, 10, 385, DateTimeKind.Unspecified).AddTicks(8161) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 31L, new DateTime(2021, 7, 27, 15, 9, 33, 82, DateTimeKind.Unspecified).AddTicks(6140), new DateTime(2022, 1, 11, 6, 55, 11, 280, DateTimeKind.Unspecified).AddTicks(1400), 38L, new DateTime(2019, 6, 15, 11, 31, 56, 202, DateTimeKind.Unspecified).AddTicks(8759), new DateTime(2021, 8, 4, 2, 33, 58, 145, DateTimeKind.Unspecified).AddTicks(6314) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 8L, new DateTime(2021, 9, 1, 19, 49, 20, 960, DateTimeKind.Unspecified).AddTicks(9057), 5L, null, new DateTime(2019, 9, 29, 18, 55, 1, 684, DateTimeKind.Unspecified).AddTicks(2355), new DateTime(2021, 11, 10, 17, 55, 28, 503, DateTimeKind.Unspecified).AddTicks(5344) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 3, 3, 15, 58, 13, 151, DateTimeKind.Unspecified).AddTicks(9508), new DateTime(2022, 1, 17, 5, 28, 49, 683, DateTimeKind.Unspecified).AddTicks(8614), 78L, new DateTime(2020, 1, 24, 22, 35, 0, 817, DateTimeKind.Unspecified).AddTicks(2757), new DateTime(2021, 1, 29, 9, 34, 43, 266, DateTimeKind.Unspecified).AddTicks(1655) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 48L, new DateTime(2021, 4, 20, 9, 38, 12, 466, DateTimeKind.Unspecified).AddTicks(8816), new DateTime(2022, 1, 24, 19, 7, 28, 138, DateTimeKind.Unspecified).AddTicks(23), 28L, new DateTime(2019, 12, 19, 9, 52, 14, 122, DateTimeKind.Unspecified).AddTicks(7071), new DateTime(2021, 2, 15, 9, 26, 54, 733, DateTimeKind.Unspecified).AddTicks(8444) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 10, 26, 16, 24, 25, 788, DateTimeKind.Unspecified).AddTicks(4023), new DateTime(2022, 1, 25, 23, 35, 2, 926, DateTimeKind.Unspecified).AddTicks(6872), 35L, new DateTime(2019, 8, 27, 18, 37, 3, 897, DateTimeKind.Unspecified).AddTicks(5241), new DateTime(2021, 7, 5, 11, 29, 42, 763, DateTimeKind.Unspecified).AddTicks(2858) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 20L, new DateTime(2022, 1, 12, 2, 41, 4, 945, DateTimeKind.Unspecified).AddTicks(8513), new DateTime(2022, 1, 24, 1, 30, 5, 461, DateTimeKind.Unspecified).AddTicks(471), 31L, new DateTime(2019, 9, 2, 17, 4, 2, 533, DateTimeKind.Unspecified).AddTicks(254), new DateTime(2021, 9, 26, 5, 36, 2, 466, DateTimeKind.Unspecified).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 37L, new DateTime(2021, 4, 27, 21, 10, 12, 516, DateTimeKind.Unspecified).AddTicks(9304), 3L, new DateTime(2022, 1, 28, 14, 28, 7, 626, DateTimeKind.Unspecified).AddTicks(8525), 27L, new DateTime(2019, 9, 29, 21, 24, 17, 991, DateTimeKind.Unspecified).AddTicks(1218), new DateTime(2021, 12, 5, 11, 22, 47, 958, DateTimeKind.Unspecified).AddTicks(119) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 18L, new DateTime(2021, 5, 1, 15, 7, 55, 913, DateTimeKind.Unspecified).AddTicks(9195), 1L, new DateTime(2022, 1, 29, 16, 5, 34, 571, DateTimeKind.Unspecified).AddTicks(3230), 19L, new DateTime(2019, 3, 10, 12, 18, 53, 532, DateTimeKind.Unspecified).AddTicks(1543), new DateTime(2021, 8, 25, 8, 55, 55, 48, DateTimeKind.Unspecified).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 27L, new DateTime(2021, 11, 5, 7, 28, 9, 139, DateTimeKind.Unspecified).AddTicks(9419), new DateTime(2022, 1, 27, 13, 25, 43, 197, DateTimeKind.Unspecified).AddTicks(7944), 12L, new DateTime(2019, 8, 31, 10, 7, 51, 714, DateTimeKind.Unspecified).AddTicks(8861), new DateTime(2021, 4, 12, 22, 19, 44, 430, DateTimeKind.Unspecified).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 10, 8, 18, 16, 8, 845, DateTimeKind.Unspecified).AddTicks(8317), 1L, new DateTime(2022, 1, 31, 2, 28, 17, 595, DateTimeKind.Unspecified).AddTicks(7584), 29L, new DateTime(2019, 9, 11, 0, 23, 9, 64, DateTimeKind.Unspecified).AddTicks(8059), new DateTime(2021, 6, 7, 23, 1, 26, 5, DateTimeKind.Unspecified).AddTicks(3389) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 42L, new DateTime(2021, 2, 5, 16, 4, 38, 692, DateTimeKind.Unspecified).AddTicks(4870), new DateTime(2022, 1, 27, 12, 11, 49, 461, DateTimeKind.Unspecified).AddTicks(2296), 77L, new DateTime(2019, 4, 22, 13, 5, 45, 108, DateTimeKind.Unspecified).AddTicks(4967), new DateTime(2021, 12, 21, 0, 43, 26, 931, DateTimeKind.Unspecified).AddTicks(230) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 49L, new DateTime(2021, 7, 24, 13, 21, 8, 78, DateTimeKind.Unspecified).AddTicks(1037), new DateTime(2022, 1, 28, 1, 54, 12, 182, DateTimeKind.Unspecified).AddTicks(9533), 34L, new DateTime(2019, 11, 23, 12, 56, 47, 313, DateTimeKind.Unspecified).AddTicks(3850), new DateTime(2021, 6, 6, 21, 40, 0, 37, DateTimeKind.Unspecified).AddTicks(1492) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 11, 5, 17, 15, 53, 191, DateTimeKind.Unspecified).AddTicks(2914), 4L, new DateTime(2022, 1, 27, 8, 20, 40, 427, DateTimeKind.Unspecified).AddTicks(4574), 17L, new DateTime(2019, 8, 5, 22, 28, 42, 729, DateTimeKind.Unspecified).AddTicks(9680), new DateTime(2021, 8, 13, 8, 21, 6, 80, DateTimeKind.Unspecified).AddTicks(239) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 23L, new DateTime(2021, 12, 21, 12, 4, 53, 977, DateTimeKind.Unspecified).AddTicks(1825), 3L, new DateTime(2022, 1, 3, 21, 46, 37, 211, DateTimeKind.Unspecified).AddTicks(964), 18L, new DateTime(2019, 11, 26, 9, 56, 29, 854, DateTimeKind.Unspecified).AddTicks(97), new DateTime(2021, 4, 18, 15, 39, 35, 901, DateTimeKind.Unspecified).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 34L, new DateTime(2021, 2, 11, 10, 0, 28, 901, DateTimeKind.Unspecified).AddTicks(4358), new DateTime(2022, 1, 6, 11, 34, 51, 804, DateTimeKind.Unspecified).AddTicks(8203), 75L, new DateTime(2019, 2, 15, 19, 2, 45, 646, DateTimeKind.Unspecified).AddTicks(3942), new DateTime(2021, 12, 23, 3, 2, 31, 138, DateTimeKind.Unspecified).AddTicks(4732) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 51L, new DateTime(2021, 8, 5, 8, 39, 18, 983, DateTimeKind.Unspecified).AddTicks(5714), 1L, new DateTime(2022, 1, 24, 12, 17, 7, 280, DateTimeKind.Unspecified).AddTicks(9905), 19L, new DateTime(2019, 11, 28, 19, 20, 47, 518, DateTimeKind.Unspecified).AddTicks(5391), new DateTime(2021, 9, 16, 13, 52, 48, 45, DateTimeKind.Unspecified).AddTicks(3891) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 24L, new DateTime(2021, 7, 6, 23, 26, 24, 435, DateTimeKind.Unspecified).AddTicks(9970), new DateTime(2022, 1, 12, 3, 12, 7, 183, DateTimeKind.Unspecified).AddTicks(7899), 4L, new DateTime(2019, 4, 22, 23, 58, 41, 210, DateTimeKind.Unspecified).AddTicks(2443), new DateTime(2021, 8, 17, 5, 5, 19, 673, DateTimeKind.Unspecified).AddTicks(2830) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 36L, new DateTime(2021, 2, 24, 14, 12, 35, 19, DateTimeKind.Unspecified).AddTicks(5187), new DateTime(2022, 2, 1, 14, 34, 2, 288, DateTimeKind.Unspecified).AddTicks(8598), 38L, new DateTime(2019, 12, 30, 1, 2, 12, 196, DateTimeKind.Unspecified).AddTicks(1331), new DateTime(2021, 2, 2, 1, 57, 50, 771, DateTimeKind.Unspecified).AddTicks(3875) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "StartedDate", "SubmittedDate" },
                values: new object[] { 5L, new DateTime(2021, 6, 16, 21, 40, 27, 153, DateTimeKind.Unspecified).AddTicks(2362), new DateTime(2022, 1, 7, 14, 33, 23, 815, DateTimeKind.Unspecified).AddTicks(9644), new DateTime(2019, 10, 18, 19, 25, 1, 709, DateTimeKind.Unspecified).AddTicks(9587), new DateTime(2021, 9, 21, 11, 48, 43, 345, DateTimeKind.Unspecified).AddTicks(6735) });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 39L, new DateTime(2021, 9, 21, 11, 32, 19, 354, DateTimeKind.Unspecified).AddTicks(9934), 4L, new DateTime(2022, 1, 31, 14, 6, 10, 441, DateTimeKind.Unspecified).AddTicks(7614), 58L, new DateTime(2019, 8, 7, 3, 18, 34, 788, DateTimeKind.Unspecified).AddTicks(8492), new DateTime(2021, 4, 6, 18, 33, 43, 407, DateTimeKind.Unspecified).AddTicks(2415) });

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
                columns: new[] { "AuthorId", "CreatedAt", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[] { 15L, new DateTime(2021, 7, 29, 9, 42, 35, 666, DateTimeKind.Unspecified).AddTicks(2186), new DateTime(2022, 1, 14, 5, 46, 11, 723, DateTimeKind.Unspecified).AddTicks(2309), 28L, new DateTime(2020, 1, 25, 11, 8, 12, 741, DateTimeKind.Unspecified).AddTicks(3546), new DateTime(2021, 7, 23, 5, 11, 32, 733, DateTimeKind.Unspecified).AddTicks(8225) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Numquam nobis quos soluta.\nId qui consequatur dolores tenetur aliquid sed tempore et alias.\nExpedita cumque unde est dolores minus.\nUllam amet impedit et voluptatibus.", new DateTime(2021, 3, 25, 22, 57, 29, 915, DateTimeKind.Unspecified).AddTicks(3701), 5L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Rem sint dolores ex exercitationem.\nDebitis corrupti esse et vitae veritatis et.\nQuis et aut molestiae officiis reiciendis sit deleniti ea.\nDolores numquam fugiat nesciunt.\nOptio aut dolores perspiciatis reprehenderit iusto dicta.\nUllam ea a minus.", new DateTime(2021, 11, 13, 21, 2, 13, 368, DateTimeKind.Unspecified).AddTicks(4529), 3L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Qui est debitis suscipit sint.", new DateTime(2021, 2, 5, 19, 47, 14, 271, DateTimeKind.Unspecified).AddTicks(8322), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 26L, "Eos beatae possimus porro sint quisquam vero qui occaecati eaque.\nVeniam tempore et voluptatem repudiandae.\nQuis neque ut aut.\nItaque est omnis eligendi commodi.", new DateTime(2021, 12, 16, 0, 35, 55, 674, DateTimeKind.Unspecified).AddTicks(5286), 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Nemo iusto voluptas sed sit minus mollitia.\nHarum id labore illum quia sed provident.\nQuasi assumenda necessitatibus dolorem et ut.", new DateTime(2021, 12, 4, 13, 12, 49, 653, DateTimeKind.Unspecified).AddTicks(2873), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Commodi architecto maiores et aut.\nConsequatur commodi optio quo modi rerum similique ullam laboriosam.", new DateTime(2021, 11, 10, 7, 53, 26, 136, DateTimeKind.Unspecified).AddTicks(5424), 5L, 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 19L, "Alias odio voluptas et dolorum aut suscipit earum amet.\nVero molestias et labore.\nDolorum sit itaque sunt quo dolorem autem.", new DateTime(2021, 10, 30, 15, 51, 52, 4, DateTimeKind.Unspecified).AddTicks(6718), 2L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Minus dignissimos velit recusandae id cupiditate ea harum.\nNam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.", new DateTime(2021, 2, 26, 12, 1, 35, 855, DateTimeKind.Unspecified).AddTicks(3844), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nam quia dicta eius doloribus commodi non nihil.\nQuod recusandae et est.\nDebitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.", new DateTime(2021, 10, 28, 3, 37, 20, 886, DateTimeKind.Unspecified).AddTicks(3829), 1L, 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Est sit at placeat optio.\nSapiente pariatur et et enim.\nAccusamus molestiae labore.", new DateTime(2021, 6, 2, 19, 19, 7, 873, DateTimeKind.Unspecified).AddTicks(6561), 4L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 3L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 1L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Earum voluptate voluptatem.\nSunt sunt est non deleniti tempore provident nihil et omnis.", new DateTime(2021, 5, 22, 23, 42, 34, 208, DateTimeKind.Unspecified).AddTicks(457), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Libero dicta temporibus atque earum.\nReprehenderit eos qui eum totam.\nId cum adipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 4L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 3L, 42L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, 61L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 1L, 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 5L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 1L, 27L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 4L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 3L, 55L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 2L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 1L, 51L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 47L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 60L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 2L, 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 1L, 65L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 3L, 29L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 8L, "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 3L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 3L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, 50L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 5L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 3L, 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 25L, "Ipsam minima vel totam vel deserunt ab.\nEnim dolorem aliquid aperiam quod tempore porro ad nemo sit.\nNisi quis dolore nihil.", new DateTime(2021, 3, 28, 17, 3, 2, 998, DateTimeKind.Unspecified).AddTicks(838), 3L, 81L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 13L, "Non fugiat non porro vero reiciendis et.\nEnim facere autem molestiae.", new DateTime(2021, 4, 1, 7, 35, 59, 215, DateTimeKind.Unspecified).AddTicks(830), 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Quo corporis voluptatem.\nQuia ut architecto adipisci quasi at aliquid voluptatum et.\nConsequatur voluptate dolor doloribus quam ipsam rerum optio.\nAperiam aperiam et.", new DateTime(2021, 12, 23, 16, 16, 38, 159, DateTimeKind.Unspecified).AddTicks(4359), 1L, 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Qui quam perferendis itaque dolore eligendi expedita.\nFacilis distinctio et omnis necessitatibus quibusdam rerum.\nEt qui ex itaque quam tempora quia eos.", new DateTime(2021, 5, 6, 9, 31, 38, 3, DateTimeKind.Unspecified).AddTicks(8430), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Illo a ex minus.\nDucimus qui officiis.\nDicta suscipit voluptas libero.\nTemporibus enim qui labore.", new DateTime(2021, 10, 9, 0, 43, 5, 480, DateTimeKind.Unspecified).AddTicks(7270), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Sed tempora non officiis est sit eveniet.\nArchitecto corrupti id rerum quam nesciunt assumenda odio ut maxime.\nUt animi in iste voluptatibus aliquid ut vitae.\nVelit exercitationem vero id sed quibusdam non.\nUt at ratione qui consectetur quam voluptas dolor dolorum.", new DateTime(2021, 8, 14, 13, 57, 37, 263, DateTimeKind.Unspecified).AddTicks(4946), 5L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 20L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 14L, "Quo dolor harum et maxime.\nEt ut quia ab animi occaecati beatae.\nVel autem ea molestias.\nAspernatur sunt explicabo.\nCorporis vitae porro voluptas et magni alias sit quia quia.\nImpedit maiores unde possimus aspernatur enim ea et ut.", new DateTime(2021, 9, 6, 6, 15, 51, 816, DateTimeKind.Unspecified).AddTicks(508), 1L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 4L, 41L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 23L, "Cum illum sit corporis maiores laudantium ut.\nArchitecto aut expedita nihil et voluptatibus fugiat.\nQuisquam harum consequatur quasi ea voluptas hic dolorum.\nHarum laborum harum suscipit magnam aut.\nDolores amet tempore magni magni possimus odit quis et impedit.", new DateTime(2021, 6, 4, 11, 4, 16, 100, DateTimeKind.Unspecified).AddTicks(7149), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Dolores ea assumenda alias.", new DateTime(2021, 3, 6, 4, 28, 7, 52, DateTimeKind.Unspecified).AddTicks(1993), 1L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Sint aliquid pariatur harum enim dolorem repellat.\nMolestiae aut nemo nihil qui sapiente non harum.\nEligendi voluptas nobis tempore.\nMolestias vel dolores aut deleniti aut minima accusamus.\nOmnis voluptatem similique.\nFacere occaecati incidunt iusto laborum ut eius id dolore.", new DateTime(2021, 4, 12, 22, 5, 28, 434, DateTimeKind.Unspecified).AddTicks(9752), 4L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 4L, "Quam ducimus qui.\nRerum velit nulla rem.\nUllam nisi eveniet dignissimos.", new DateTime(2021, 8, 25, 1, 50, 58, 81, DateTimeKind.Unspecified).AddTicks(488), 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Omnis fugit aut.", new DateTime(2021, 8, 20, 8, 30, 53, 58, DateTimeKind.Unspecified).AddTicks(3331), 3L, 59L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 15L, "Qui et velit tempore et.\nQui animi dolor beatae soluta.\nEt ab explicabo eos enim consequatur omnis soluta.\nVel doloribus omnis est optio et.\nAmet et assumenda et numquam culpa.\nQuasi aspernatur tempore.", new DateTime(2021, 11, 8, 12, 17, 53, 802, DateTimeKind.Unspecified).AddTicks(2027), 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Suscipit deleniti accusamus et debitis.\nDucimus ab cum.\nPariatur architecto architecto odio maiores.", new DateTime(2021, 9, 4, 18, 46, 20, 745, DateTimeKind.Unspecified).AddTicks(6003), 1L, 30L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Dolore nihil voluptas doloremque accusantium.\nAnimi aspernatur mollitia.", new DateTime(2021, 6, 17, 15, 1, 38, 939, DateTimeKind.Unspecified).AddTicks(7420), 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 4L, "Eum voluptas similique quasi.\nPorro possimus repudiandae minus rerum repellat.\nNobis laboriosam qui id qui inventore illo sunt.", new DateTime(2021, 3, 27, 21, 21, 10, 234, DateTimeKind.Unspecified).AddTicks(231), 1L, 45L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Hic vitae tempora tempore et dignissimos perferendis omnis aut.", new DateTime(2021, 3, 12, 22, 52, 25, 95, DateTimeKind.Unspecified).AddTicks(9008), 2L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Excepturi mollitia vitae accusantium autem repudiandae.\nEst rem ex rerum sunt suscipit voluptatem veniam aut.\nMaiores similique assumenda tempore est inventore aut omnis.\nEt ut corporis dolorem deleniti dolorem laudantium mollitia.", new DateTime(2021, 4, 6, 19, 23, 18, 77, DateTimeKind.Unspecified).AddTicks(4489), 5L, 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 34L, "Adipisci enim facere voluptatem sed accusamus soluta fuga qui porro.\nEx quia dolorem qui qui sed sed rem.\nConsequatur occaecati rem corporis officiis dolor aut id.\nSuscipit pariatur necessitatibus minima harum sunt ea.\nQuod omnis nobis sapiente veniam esse qui ducimus quia voluptas.", new DateTime(2021, 9, 4, 11, 28, 1, 107, DateTimeKind.Unspecified).AddTicks(3093), 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 3L, "Aut non tempore voluptas qui.\nLaboriosam omnis earum sit atque et.\nBeatae est magnam praesentium rerum quibusdam dignissimos temporibus voluptas.\nOdit rerum at facere itaque rem sapiente rerum.\nAspernatur ut corporis nihil ut occaecati atque exercitationem nihil molestiae.", new DateTime(2021, 5, 15, 6, 26, 4, 917, DateTimeKind.Unspecified).AddTicks(507), 5L, 23L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Sequi reprehenderit ipsam.\nEt enim error quia quia error tenetur mollitia eligendi.\nNostrum voluptatibus magni natus assumenda quis.\nMaiores ut itaque ea et voluptatem et maxime praesentium.", new DateTime(2021, 5, 20, 9, 52, 1, 466, DateTimeKind.Unspecified).AddTicks(4088), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Est ab nemo.\nAut aspernatur dolores suscipit similique necessitatibus id voluptatem quidem.\nDolores consequatur tenetur.\nAd dolorem ipsa autem et.\nNostrum cumque praesentium.", new DateTime(2021, 9, 22, 15, 38, 2, 296, DateTimeKind.Unspecified).AddTicks(2770), 4L, 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 2L, "Non sit beatae aliquam reiciendis enim tempore.\nPerferendis quis excepturi eveniet repellat tempora.\nVoluptas aut numquam eveniet et et eaque enim.\nAdipisci et ad quidem placeat earum dolor.\nDolorum voluptate molestiae nihil illo fugit aut.\nAnimi soluta accusantium.", new DateTime(2021, 10, 18, 16, 4, 44, 926, DateTimeKind.Unspecified).AddTicks(6113), 75L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 36L, "Nihil qui in laudantium iste repellat ipsum veritatis praesentium.\nDeleniti eaque eaque.\nQuasi deserunt maiores ad deserunt et alias enim.", new DateTime(2021, 4, 5, 3, 11, 52, 774, DateTimeKind.Unspecified).AddTicks(511), 21L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Ut cumque aut.\nAut aut voluptas ex.\nVeritatis et velit aliquam.\nDeserunt illo quos maiores natus earum a velit.\nEarum cumque libero facere voluptatem saepe suscipit qui est veritatis.\nAutem omnis dicta ad.", new DateTime(2021, 5, 17, 13, 53, 22, 284, DateTimeKind.Unspecified).AddTicks(1090), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 19L, "Non sit perspiciatis ex cum quidem placeat saepe ut asperiores.\nAt voluptas aperiam.\nEos magni dolor praesentium accusamus deleniti laboriosam.", new DateTime(2021, 4, 3, 10, 20, 46, 341, DateTimeKind.Unspecified).AddTicks(3427), 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 43L, "Facere ea provident et.\nAut minus occaecati.\nQui rem quaerat.\nEst blanditiis et aspernatur earum asperiores illo.\nSunt doloremque incidunt magnam sint dignissimos accusamus fugiat dignissimos.\nVoluptas tempore provident eos et praesentium vel.", new DateTime(2021, 2, 6, 15, 19, 18, 560, DateTimeKind.Unspecified).AddTicks(1065), 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Nihil sed quis temporibus aut minima repellat voluptates.", new DateTime(2021, 6, 5, 6, 45, 25, 705, DateTimeKind.Unspecified).AddTicks(2833), 3L, 74L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Doloribus excepturi similique eos est.\nSaepe et qui ab unde deserunt est quis.\nLabore facere dolor.", new DateTime(2022, 1, 15, 18, 52, 37, 713, DateTimeKind.Unspecified).AddTicks(9441), 3L, 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Doloribus omnis dignissimos mollitia alias omnis vitae deleniti.\nNesciunt qui voluptatem amet odio ullam.", new DateTime(2021, 6, 20, 20, 32, 47, 556, DateTimeKind.Unspecified).AddTicks(3441), 1L, 69L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 47L, "Nostrum tempore quo quibusdam.\nNesciunt tempore qui beatae omnis earum veniam.", new DateTime(2021, 11, 8, 19, 30, 2, 744, DateTimeKind.Unspecified).AddTicks(6567), 1L, 71L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 51L, "Dolorem ut quasi aut qui laudantium quibusdam ab.\nDeleniti quod blanditiis ducimus molestiae.", new DateTime(2021, 3, 17, 21, 1, 51, 218, DateTimeKind.Unspecified).AddTicks(9854), 4L, 35L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 31L, "In id voluptate saepe velit eum aut aperiam enim.\nDolorem aut perspiciatis qui quibusdam voluptatem dolorem.\nModi magnam alias omnis.\nConsectetur nulla fuga voluptas sint nostrum et quia aliquam.\nEt incidunt eius natus dolor eligendi et.", new DateTime(2021, 5, 6, 23, 34, 5, 229, DateTimeKind.Unspecified).AddTicks(3940), 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 21L, "Voluptates repellat harum qui dolore molestias expedita deleniti.\nNulla possimus numquam ab temporibus illo commodi maxime assumenda.", new DateTime(2022, 1, 16, 8, 12, 55, 887, DateTimeKind.Unspecified).AddTicks(2289), 4L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 18L, "Cumque doloribus dolores sequi libero labore est.\nDebitis quia quo.", new DateTime(2021, 11, 1, 6, 39, 5, 620, DateTimeKind.Unspecified).AddTicks(9235), 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 42L, "Voluptatem cumque eum praesentium ut magni et.\nEius perferendis aut.\nEa eaque et omnis illo.\nQuaerat perferendis quas.", new DateTime(2021, 6, 7, 9, 32, 29, 109, DateTimeKind.Unspecified).AddTicks(2186), 46L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Architecto est deleniti sit sint minus enim culpa nisi.\nFugit ex eos officia eos ducimus tempora voluptas possimus.\nDolorem nulla omnis eum sed repellat.", new DateTime(2021, 12, 11, 20, 49, 24, 536, DateTimeKind.Unspecified).AddTicks(9357), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 20L, "Aut quis eum nostrum quod eum quos et sunt.\nOccaecati earum itaque libero in nihil.", new DateTime(2021, 10, 12, 9, 43, 10, 483, DateTimeKind.Unspecified).AddTicks(3703), 2L, 31L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Tempore incidunt ipsum est est occaecati vitae eius consequatur.\nCupiditate enim ut sunt.\nPariatur nihil qui enim eos eum impedit quia laborum.\nAccusamus animi tempora minus nulla consequatur alias ut ratione laborum.\nSed sunt sit aut sed officiis sunt.\nEsse fuga voluptatem dolorem nam.", new DateTime(2022, 1, 19, 13, 53, 51, 173, DateTimeKind.Unspecified).AddTicks(3509), 5L, 54L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 36L, "Delectus et natus possimus omnis et.\nAtque cupiditate reprehenderit cupiditate voluptate sed sapiente nesciunt qui.\nNon ullam id excepturi dolorum consequatur velit.\nUnde est error eius amet.\nDelectus qui libero est optio natus suscipit voluptate ab.", new DateTime(2021, 2, 28, 19, 5, 13, 864, DateTimeKind.Unspecified).AddTicks(172), 3L, 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 9L, "Sed eos quas dolor.\nQui id nesciunt.\nNisi eveniet ea quos tempora ratione nostrum ut suscipit occaecati.\nUt provident ipsam laudantium ipsum minima et.\nEt quia illo beatae.\nQuae et voluptates veritatis iusto.", new DateTime(2021, 2, 7, 11, 22, 22, 847, DateTimeKind.Unspecified).AddTicks(7478), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 16L, "Quibusdam sed voluptas dolor ut.\nQuia incidunt ea suscipit hic qui.\nEaque laborum omnis molestiae corrupti ut voluptas.\nIllum illo dignissimos quibusdam ut.\nEum consectetur vel voluptas.", new DateTime(2021, 6, 3, 20, 57, 51, 343, DateTimeKind.Unspecified).AddTicks(7626), 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Fuga ut non alias qui tempore.\nAspernatur pariatur commodi voluptatem qui eum numquam quod placeat et.\nReiciendis ratione qui.\nLibero neque nostrum eaque accusantium consequatur.\nPossimus sed quis facilis quia corporis qui nihil.\nRem qui vitae ut hic officiis quia consequatur consequatur.", new DateTime(2021, 2, 15, 1, 3, 50, 196, DateTimeKind.Unspecified).AddTicks(6476), 3L, 48L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 50L, "Qui ipsa et soluta consequatur impedit dolor est.", new DateTime(2021, 4, 6, 0, 15, 0, 666, DateTimeKind.Unspecified).AddTicks(3684), 1L, 36L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Inventore repudiandae animi quae.\nSed quo et.\nEt autem a.\nIncidunt eos nihil dolores temporibus.", new DateTime(2021, 10, 21, 20, 52, 38, 231, DateTimeKind.Unspecified).AddTicks(8015), 56L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 44L, "Laboriosam consequuntur est dolores sed repudiandae.", new DateTime(2021, 4, 4, 18, 42, 21, 652, DateTimeKind.Unspecified).AddTicks(9924), 5L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Maiores corrupti itaque laudantium pariatur.\nDoloribus vel rerum velit nihil omnis temporibus ut exercitationem.\nExercitationem sapiente aliquid est vero.\nImpedit eveniet pariatur laboriosam.\nDolores in placeat in blanditiis voluptatum est iusto est at.", new DateTime(2021, 10, 18, 11, 35, 38, 665, DateTimeKind.Unspecified).AddTicks(3588), 1L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 42L, "Molestiae nihil eos impedit in dolorum omnis.\nMollitia deleniti reiciendis qui pariatur dolor eaque et molestias.", new DateTime(2021, 12, 14, 12, 15, 47, 755, DateTimeKind.Unspecified).AddTicks(9340), 2L, 70L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 30L, "Architecto dolor odit est ducimus tempora consequuntur minima atque laborum.", new DateTime(2021, 5, 19, 8, 26, 26, 321, DateTimeKind.Unspecified).AddTicks(5379), 1L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Sint voluptatem repellat aut aut.\nNumquam officia accusamus vel ducimus voluptas voluptatem.\nAut dignissimos sint minus et non.\nAut odit cupiditate totam velit dolores.", new DateTime(2021, 3, 30, 21, 30, 24, 45, DateTimeKind.Unspecified).AddTicks(3023), 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iusto laboriosam numquam eos quia asperiores sunt delectus sint omnis.\nOmnis et sit quae animi sed et praesentium.\nOdit eveniet perspiciatis sint voluptatum suscipit est consequatur.\nUllam accusamus ut ut qui dolorem.\nQuibusdam corporis impedit.\nQuos natus tenetur adipisci rem maxime libero sit.", new DateTime(2021, 12, 14, 6, 12, 27, 982, DateTimeKind.Unspecified).AddTicks(9982), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Assumenda sed quibusdam exercitationem distinctio.\nEius similique sed numquam voluptates nam labore ut consectetur.\nAut vel sequi quisquam voluptatem perspiciatis rerum ut dignissimos minus.", new DateTime(2021, 11, 4, 1, 54, 34, 308, DateTimeKind.Unspecified).AddTicks(5223), 49L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 27L, "Officia ad soluta nostrum ullam et facilis quo.", new DateTime(2021, 5, 8, 5, 13, 27, 480, DateTimeKind.Unspecified).AddTicks(7761), 76L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Molestias voluptatem asperiores et autem ex voluptatibus distinctio sed.\nDeserunt ducimus pariatur non.", new DateTime(2021, 10, 18, 17, 12, 20, 582, DateTimeKind.Unspecified).AddTicks(5471), 1L, 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 34L, "Beatae sapiente nam ut.", new DateTime(2021, 10, 8, 19, 16, 13, 405, DateTimeKind.Unspecified).AddTicks(388), 26L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 40L, "Occaecati quia veritatis quidem.\nUt mollitia inventore accusamus.", new DateTime(2021, 12, 6, 11, 53, 10, 114, DateTimeKind.Unspecified).AddTicks(9770), 5L, 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "At est quo quidem necessitatibus sint minus et.\nQui perspiciatis et.\nPariatur quasi amet.", new DateTime(2021, 5, 20, 6, 19, 16, 242, DateTimeKind.Unspecified).AddTicks(5421), 5L, 38L });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 7, 8, 9, 17, 56, 725, DateTimeKind.Unspecified).AddTicks(4166), 782, false, 18L, 326 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 2, 4, 8, 8, 46, 387, DateTimeKind.Unspecified).AddTicks(7573), 5L, 747, 33L, 215 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 10, 16, 10, 20, 24, 653, DateTimeKind.Unspecified).AddTicks(5907), 563, false, 23L, null, 390 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 5, 29, 10, 56, 12, 345, DateTimeKind.Unspecified).AddTicks(203), 3L, 778, 10L, null, 327 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 2, 26, 12, 23, 24, 561, DateTimeKind.Unspecified).AddTicks(6238), 4L, 813, null, 34L, 246 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 5, 20, 16, 28, 45, 901, DateTimeKind.Unspecified).AddTicks(5762), 3L, 818, false, 55L, null, 358 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 4, 23, 14, 53, 27, 139, DateTimeKind.Unspecified).AddTicks(7539), 3L, 527, true, null, 19L, 114 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 6, 7, 8, 51, 5, 727, DateTimeKind.Unspecified).AddTicks(5959), 5L, 776, 39L, 126 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2022, 1, 12, 8, 25, 30, 148, DateTimeKind.Unspecified).AddTicks(3966), 4L, 872, 44L, 85 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 4, 14, 1, 55, 2, 894, DateTimeKind.Unspecified).AddTicks(2856), 4L, 506, true, null, 49L, 239 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 10, 23, 5, 29, 18, 864, DateTimeKind.Unspecified).AddTicks(8337), 503, false, 37L, 262 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 9L, new DateTime(2021, 8, 21, 3, 34, 49, 764, DateTimeKind.Unspecified).AddTicks(9333), 944, null, 4L, 433 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 3, 25, 22, 21, 38, 460, DateTimeKind.Unspecified).AddTicks(9353), 946, true, null, 10L, 354 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 5, 31, 23, 35, 16, 906, DateTimeKind.Unspecified).AddTicks(9373), 3L, 690, false, 24L, 72 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 7, 6, 3, 41, 54, 717, DateTimeKind.Unspecified).AddTicks(6477), 4L, 983, false, 73L, null, 437 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 5, 2, 7, 32, 55, 209, DateTimeKind.Unspecified).AddTicks(7644), 3L, 754, true, null, 3L, 35 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 4, 4, 10, 19, 17, 440, DateTimeKind.Unspecified).AddTicks(1149), 3L, 582, true, 55L, 129 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 5L, new DateTime(2021, 11, 1, 6, 37, 22, 120, DateTimeKind.Unspecified).AddTicks(3784), 4L, 898, 17L, null, 45 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 3, 20, 21, 11, 5, 235, DateTimeKind.Unspecified).AddTicks(8559), 4L, 560, 12L, null, 97 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2022, 1, 13, 22, 56, 43, 565, DateTimeKind.Unspecified).AddTicks(683), 725, false, 21L, 299 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 21L, new DateTime(2021, 2, 28, 20, 47, 9, 779, DateTimeKind.Unspecified).AddTicks(9518), 772, true, null, 4L, 276 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 11, 14, 3, 55, 49, 415, DateTimeKind.Unspecified).AddTicks(7157), 2L, 505, false, 67L, 253 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 4, 24, 21, 51, 16, 433, DateTimeKind.Unspecified).AddTicks(8025), 3L, 560, false, 32L, 176 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 8, 10, 1, 13, 44, 325, DateTimeKind.Unspecified).AddTicks(7126), 1L, 625, true, 4L, 400 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 4, 28, 9, 12, 3, 941, DateTimeKind.Unspecified).AddTicks(2507), 1L, 911, 15L, 58 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 8, 14, 3, 25, 12, 800, DateTimeKind.Unspecified).AddTicks(6113), 1L, 621, false, 20L, 71 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 10, 11, 12, 39, 55, 556, DateTimeKind.Unspecified).AddTicks(8928), 2L, 983, 40L, 136 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 2, 14, 22, 54, 8, 873, DateTimeKind.Unspecified).AddTicks(5315), 890, null, 3L, 148 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2022, 1, 28, 0, 19, 20, 213, DateTimeKind.Unspecified).AddTicks(5828), 4L, 880, false, 31L, 446 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 8, 9, 13, 48, 47, 354, DateTimeKind.Unspecified).AddTicks(8820), 2L, 704, true, 28L, null, 113 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 5, 24, 17, 31, 30, 640, DateTimeKind.Unspecified).AddTicks(4416), 5L, 895, false, null, 42L, 246 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 3, 27, 4, 4, 34, 703, DateTimeKind.Unspecified).AddTicks(5125), 1L, 874, false, 10L, 452 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 11, 17, 5, 29, 29, 173, DateTimeKind.Unspecified).AddTicks(3676), 4L, 763, false, 14L, 128 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 5, 26, 8, 43, 31, 518, DateTimeKind.Unspecified).AddTicks(9952), 1L, 521, 120 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 3, 10, 3, 0, 23, 336, DateTimeKind.Unspecified).AddTicks(3098), 2L, 632, 17L, 235 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 9, 3, 22, 50, 33, 736, DateTimeKind.Unspecified).AddTicks(139), 1L, 988, 31L, 51 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 2, 4, 19, 25, 7, 955, DateTimeKind.Unspecified).AddTicks(8311), 4L, 525, null, 16L, 449 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 5, 27, 7, 54, 45, 854, DateTimeKind.Unspecified).AddTicks(340), 744, false, 12L, 54 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 7, 18, 15, 15, 34, 711, DateTimeKind.Unspecified).AddTicks(4312), 2L, 530, 19L, 100 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 5, 9, 19, 57, 58, 136, DateTimeKind.Unspecified).AddTicks(5357), 3L, 838, 68L, 179 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 3, 29, 4, 53, 20, 889, DateTimeKind.Unspecified).AddTicks(4525), 4L, 915, 40L, 317 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 9, 23, 21, 16, 2, 502, DateTimeKind.Unspecified).AddTicks(369), 1L, 634, false, 22L, 314 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 8, 3, 9, 6, 23, 884, DateTimeKind.Unspecified).AddTicks(5957), 3L, 715, false, 30L, null, 127 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 3, 2, 6, 53, 41, 178, DateTimeKind.Unspecified).AddTicks(9590), 810, true, 20L, 48 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 5, 25, 21, 36, 49, 747, DateTimeKind.Unspecified).AddTicks(8171), 4L, 510, true, 29L, 187 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 11, 11, 17, 48, 11, 960, DateTimeKind.Unspecified).AddTicks(8206), 682, true, 81L, 430 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { new DateTime(2022, 1, 20, 18, 5, 27, 438, DateTimeKind.Unspecified).AddTicks(48), 5L, 901, 12L, 486 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 10, 27, 3, 28, 48, 271, DateTimeKind.Unspecified).AddTicks(4604), 3L, 860, null, 37L, 382 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2022, 1, 17, 23, 45, 41, 327, DateTimeKind.Unspecified).AddTicks(5297), 1L, 744, null, 30L, 277 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2022, 1, 21, 7, 38, 6, 107, DateTimeKind.Unspecified).AddTicks(1730), 2L, 701, null, 45L, 467 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { new DateTime(2021, 7, 4, 11, 19, 39, 965, DateTimeKind.Unspecified).AddTicks(9517), 3L, 672, false, 29L, 160 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 9, 8, 22, 31, 13, 287, DateTimeKind.Unspecified).AddTicks(4696), 4L, 521, false, 31L, 385 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 10, 26, 19, 51, 21, 844, DateTimeKind.Unspecified).AddTicks(7804), 5L, 789, true, 48L, 332 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 31L, new DateTime(2022, 1, 16, 8, 53, 22, 922, DateTimeKind.Unspecified).AddTicks(1445), 5L, 949, null, 38L, 1 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 5, 13, 0, 14, 47, 932, DateTimeKind.Unspecified).AddTicks(6214), 2L, 533, false, 79L, null, 25 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 3, 7, 10, 57, 8, 879, DateTimeKind.Unspecified).AddTicks(8575), 1L, 509, true, null, 28L, 50 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 8, 13, 7, 16, 15, 850, DateTimeKind.Unspecified).AddTicks(4289), 3L, 816, false, 5L, null, 280 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 4, 13, 21, 9, 32, 555, DateTimeKind.Unspecified).AddTicks(4895), 515, false, null, 38L, 264 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 5, 29, 21, 4, 14, 480, DateTimeKind.Unspecified).AddTicks(8920), 4L, 584, false, 76L, 64 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 5, 31, 8, 41, 16, 75, DateTimeKind.Unspecified).AddTicks(3524), 1L, 756, null, 6L, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 10, 23, 22, 58, 31, 925, DateTimeKind.Unspecified).AddTicks(9370), 3L, 834, true, 48L, null, 45 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 5, 30, 5, 41, 30, 267, DateTimeKind.Unspecified).AddTicks(7065), 4L, 865, false, null, 16L, 33 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 12, 19, 16, 1, 13, 782, DateTimeKind.Unspecified).AddTicks(1520), 1L, 770, null, 45L, 246 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 12, 7, 18, 57, 33, 791, DateTimeKind.Unspecified).AddTicks(9198), 804, 70L, null, 174 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 9, 27, 20, 15, 7, 890, DateTimeKind.Unspecified).AddTicks(6771), 4L, 942, true, 70L, null, 122 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2022, 1, 29, 3, 8, 7, 262, DateTimeKind.Unspecified).AddTicks(5806), 1L, 633, 54L, 494 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 4, 10, 12, 21, 16, 872, DateTimeKind.Unspecified).AddTicks(2741), 903, 79L, null, 461 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 12, 12, 2, 21, 48, 187, DateTimeKind.Unspecified).AddTicks(3695), 5L, 572, false, 74L, null, 379 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 3, 19, 7, 17, 58, 185, DateTimeKind.Unspecified).AddTicks(5810), 2L, 892, 9L, 343 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2022, 1, 25, 23, 38, 53, 453, DateTimeKind.Unspecified).AddTicks(169), 3L, 581, 18L, 160 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 7, 5, 12, 14, 28, 416, DateTimeKind.Unspecified).AddTicks(1511), 4L, 823, true, 36L, null, 211 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 10, 5, 6, 19, 15, 595, DateTimeKind.Unspecified).AddTicks(3519), 3L, 754, 44L, 429 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 10, 9, 2, 57, 59, 405, DateTimeKind.Unspecified).AddTicks(4469), 5L, 856, true, 33 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 11, 10, 23, 6, 39, 821, DateTimeKind.Unspecified).AddTicks(4602), 5L, 608, true, 60L, 147 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 6, 16, 19, 21, 39, 353, DateTimeKind.Unspecified).AddTicks(7035), 1L, 749, 10L, 156 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 3, 20, 1, 40, 51, 41, DateTimeKind.Unspecified).AddTicks(7341), 802, true, 51L, 298 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2021, 7, 7, 22, 49, 31, 144, DateTimeKind.Unspecified).AddTicks(9633), 5L, 571, 10L, null, 143 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 5, 26, 23, 20, 49, 402, DateTimeKind.Unspecified).AddTicks(6903), 3L, 535, 33L, 97 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 7, 16, 2, 45, 23, 658, DateTimeKind.Unspecified).AddTicks(9925), 5L, 610, null, 23L, 20 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 5, 1, 10, 15, 25, 273, DateTimeKind.Unspecified).AddTicks(378), 551, false, 35L, 299 });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvitedUsers_UserId",
                table: "InvitedUsers",
                column: "UserId");

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
