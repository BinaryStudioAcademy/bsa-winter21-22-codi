using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirebaseId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AvatarId = table.Column<long>(type: "bigint", nullable: true),
                    AccessToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Images_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Apps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AppDocumentId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 24, nullable: false),
                    ImageId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apps_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Apps_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    ProjectDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppTags",
                columns: table => new
                {
                    AppId = table.Column<long>(type: "bigint", nullable: false),
                    TagId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTags", x => new { x.AppId, x.TagId });
                    table.ForeignKey(
                        name: "FK_AppTags_Apps_AppId",
                        column: x => x.AppId,
                        principalTable: "Apps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AvatarId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    OrganizationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Images_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Images",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvitedUsers",
                columns: table => new
                {
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "CourseUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    CourseRole = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseUsers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastReviewed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false),
                    LessonId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Submissions_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Submissions_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Threads",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartPosition = table.Column<int>(type: "int", nullable: false),
                    EndPosition = table.Column<int>(type: "int", nullable: false),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectId = table.Column<long>(type: "bigint", nullable: true),
                    LessonId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Threads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Threads_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Threads_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Threads_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThreadComments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false),
                    ThreadId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThreadComments_Threads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Threads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThreadComments_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "URL" },
                values: new object[,]
                {
                    { 2L, new DateTime(2021, 7, 26, 4, 35, 5, 791, DateTimeKind.Unspecified).AddTicks(2680), 1L, false, "https://loremflickr.com/320/240?lock=1791115679" },
                    { 3L, new DateTime(2021, 7, 29, 18, 47, 46, 846, DateTimeKind.Unspecified).AddTicks(789), 4L, false, "https://loremflickr.com/320/240?lock=892886952" },
                    { 4L, new DateTime(2021, 10, 31, 1, 51, 52, 396, DateTimeKind.Unspecified).AddTicks(228), 2L, false, "https://loremflickr.com/320/240?lock=887285299" },
                    { 5L, new DateTime(2021, 10, 30, 0, 15, 25, 188, DateTimeKind.Unspecified).AddTicks(9069), 2L, false, "https://loremflickr.com/320/240?lock=1616629496" },
                    { 6L, new DateTime(2021, 7, 6, 7, 45, 20, 13, DateTimeKind.Unspecified).AddTicks(2083), 5L, false, "https://loremflickr.com/320/240?lock=1629350711" },
                    { 7L, new DateTime(2021, 5, 20, 14, 52, 2, 425, DateTimeKind.Unspecified).AddTicks(7093), 1L, false, "https://loremflickr.com/320/240?lock=1500522538" },
                    { 8L, new DateTime(2021, 5, 18, 10, 17, 8, 857, DateTimeKind.Unspecified).AddTicks(3080), 1L, false, "https://loremflickr.com/320/240?lock=1950110519" },
                    { 9L, new DateTime(2021, 7, 28, 12, 12, 57, 113, DateTimeKind.Unspecified).AddTicks(8500), 4L, false, "https://loremflickr.com/320/240?lock=915084372" },
                    { 10L, new DateTime(2021, 7, 4, 3, 30, 57, 202, DateTimeKind.Unspecified).AddTicks(5656), 2L, false, "https://loremflickr.com/320/240?lock=873619480" },
                    { 11L, new DateTime(2021, 4, 14, 2, 35, 2, 658, DateTimeKind.Unspecified).AddTicks(9809), 3L, false, "https://loremflickr.com/320/240?lock=1955353817" },
                    { 12L, new DateTime(2022, 1, 23, 9, 15, 57, 80, DateTimeKind.Unspecified).AddTicks(4006), 1L, false, "https://loremflickr.com/320/240?lock=270197544" },
                    { 13L, new DateTime(2021, 12, 21, 23, 3, 17, 953, DateTimeKind.Unspecified).AddTicks(319), 4L, false, "https://loremflickr.com/320/240?lock=1128512330" },
                    { 14L, new DateTime(2021, 6, 10, 10, 14, 30, 664, DateTimeKind.Unspecified).AddTicks(4021), 2L, false, "https://loremflickr.com/320/240?lock=1342135219" },
                    { 15L, new DateTime(2021, 7, 28, 16, 35, 55, 469, DateTimeKind.Unspecified).AddTicks(4335), 4L, false, "https://loremflickr.com/320/240?lock=919502585" },
                    { 16L, new DateTime(2021, 6, 17, 14, 39, 30, 584, DateTimeKind.Unspecified).AddTicks(8463), 4L, false, "https://loremflickr.com/320/240?lock=1128282204" },
                    { 17L, new DateTime(2021, 10, 27, 9, 14, 22, 273, DateTimeKind.Unspecified).AddTicks(6728), 2L, false, "https://loremflickr.com/320/240?lock=1308295933" },
                    { 18L, new DateTime(2021, 8, 16, 14, 32, 24, 915, DateTimeKind.Unspecified).AddTicks(8614), 1L, false, "https://loremflickr.com/320/240?lock=1147465834" },
                    { 19L, new DateTime(2021, 7, 29, 13, 46, 22, 607, DateTimeKind.Unspecified).AddTicks(6083), 3L, false, "https://loremflickr.com/320/240?lock=1086662722" },
                    { 20L, new DateTime(2022, 1, 28, 7, 1, 25, 811, DateTimeKind.Unspecified).AddTicks(7639), 5L, false, "https://loremflickr.com/320/240?lock=537303847" },
                    { 21L, new DateTime(2022, 1, 20, 9, 26, 17, 48, DateTimeKind.Unspecified).AddTicks(7139), 4L, false, "https://loremflickr.com/320/240?lock=1077042515" },
                    { 22L, new DateTime(2021, 9, 18, 0, 5, 0, 342, DateTimeKind.Unspecified).AddTicks(9295), 3L, false, "https://loremflickr.com/320/240?lock=92863422" },
                    { 23L, new DateTime(2021, 12, 12, 5, 7, 49, 189, DateTimeKind.Unspecified).AddTicks(6718), 2L, false, "https://loremflickr.com/320/240?lock=1735817561" },
                    { 24L, new DateTime(2021, 9, 8, 17, 52, 36, 569, DateTimeKind.Unspecified).AddTicks(415), 3L, false, "https://loremflickr.com/320/240?lock=604569600" },
                    { 25L, new DateTime(2021, 5, 9, 16, 28, 43, 922, DateTimeKind.Unspecified).AddTicks(7899), 3L, false, "https://loremflickr.com/320/240?lock=754440496" },
                    { 26L, new DateTime(2021, 10, 3, 12, 22, 18, 622, DateTimeKind.Unspecified).AddTicks(6131), 5L, false, "https://loremflickr.com/320/240?lock=1094585478" },
                    { 27L, new DateTime(2021, 8, 20, 23, 9, 10, 255, DateTimeKind.Unspecified).AddTicks(1243), 1L, false, "https://loremflickr.com/320/240?lock=1836850111" },
                    { 28L, new DateTime(2021, 12, 14, 20, 5, 3, 399, DateTimeKind.Unspecified).AddTicks(2463), 1L, false, "https://loremflickr.com/320/240?lock=715918605" },
                    { 29L, new DateTime(2021, 2, 6, 17, 41, 27, 75, DateTimeKind.Unspecified).AddTicks(5090), 3L, false, "https://loremflickr.com/320/240?lock=1305305447" },
                    { 30L, new DateTime(2021, 10, 19, 8, 12, 3, 635, DateTimeKind.Unspecified).AddTicks(5710), 4L, false, "https://loremflickr.com/320/240?lock=251016100" },
                    { 31L, new DateTime(2022, 1, 24, 3, 51, 32, 48, DateTimeKind.Unspecified).AddTicks(8959), 4L, false, "https://loremflickr.com/320/240?lock=480971897" },
                    { 32L, new DateTime(2021, 11, 13, 19, 0, 50, 809, DateTimeKind.Unspecified).AddTicks(8817), 1L, false, "https://loremflickr.com/320/240?lock=1444620319" },
                    { 33L, new DateTime(2021, 6, 30, 19, 6, 55, 652, DateTimeKind.Unspecified).AddTicks(791), 2L, false, "https://loremflickr.com/320/240?lock=788723790" },
                    { 34L, new DateTime(2021, 12, 19, 16, 35, 39, 387, DateTimeKind.Unspecified).AddTicks(5251), 5L, false, "https://loremflickr.com/320/240?lock=1527090632" },
                    { 35L, new DateTime(2021, 5, 3, 19, 54, 49, 712, DateTimeKind.Unspecified).AddTicks(7739), 2L, false, "https://loremflickr.com/320/240?lock=959823810" },
                    { 36L, new DateTime(2021, 4, 1, 5, 15, 29, 471, DateTimeKind.Unspecified).AddTicks(6253), 1L, false, "https://loremflickr.com/320/240?lock=187015846" },
                    { 37L, new DateTime(2021, 3, 30, 11, 16, 30, 671, DateTimeKind.Unspecified).AddTicks(3436), 5L, false, "https://loremflickr.com/320/240?lock=111782209" },
                    { 38L, new DateTime(2021, 6, 18, 18, 6, 57, 41, DateTimeKind.Unspecified).AddTicks(7031), 4L, false, "https://loremflickr.com/320/240?lock=773687999" },
                    { 39L, new DateTime(2022, 1, 22, 4, 50, 52, 122, DateTimeKind.Unspecified).AddTicks(2851), 1L, false, "https://loremflickr.com/320/240?lock=867251677" },
                    { 40L, new DateTime(2021, 4, 22, 16, 51, 31, 388, DateTimeKind.Unspecified).AddTicks(4773), 5L, false, "https://loremflickr.com/320/240?lock=825870316" },
                    { 41L, new DateTime(2021, 10, 17, 9, 49, 45, 289, DateTimeKind.Unspecified).AddTicks(1148), 1L, false, "https://loremflickr.com/320/240?lock=928550550" },
                    { 42L, new DateTime(2021, 12, 19, 11, 54, 49, 460, DateTimeKind.Unspecified).AddTicks(6060), 4L, false, "https://loremflickr.com/320/240?lock=1675023002" },
                    { 43L, new DateTime(2021, 8, 23, 14, 33, 6, 344, DateTimeKind.Unspecified).AddTicks(1622), 5L, false, "https://loremflickr.com/320/240?lock=1716030352" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "URL" },
                values: new object[,]
                {
                    { 44L, new DateTime(2021, 7, 18, 19, 9, 52, 135, DateTimeKind.Unspecified).AddTicks(4913), 3L, false, "https://loremflickr.com/320/240?lock=1447623274" },
                    { 45L, new DateTime(2021, 12, 24, 19, 45, 19, 348, DateTimeKind.Unspecified).AddTicks(7379), 1L, false, "https://loremflickr.com/320/240?lock=2091374713" },
                    { 46L, new DateTime(2021, 5, 15, 3, 55, 35, 170, DateTimeKind.Unspecified).AddTicks(74), 5L, false, "https://loremflickr.com/320/240?lock=1076794657" },
                    { 47L, new DateTime(2021, 12, 18, 9, 26, 22, 449, DateTimeKind.Unspecified).AddTicks(2479), 3L, false, "https://loremflickr.com/320/240?lock=639945255" },
                    { 48L, new DateTime(2021, 11, 30, 23, 44, 13, 295, DateTimeKind.Unspecified).AddTicks(8607), 5L, false, "https://loremflickr.com/320/240?lock=2051585227" },
                    { 49L, new DateTime(2021, 2, 23, 0, 17, 34, 350, DateTimeKind.Unspecified).AddTicks(6687), 4L, false, "https://loremflickr.com/320/240?lock=1432245005" },
                    { 50L, new DateTime(2021, 10, 1, 0, 22, 4, 996, DateTimeKind.Unspecified).AddTicks(3543), 2L, false, "https://loremflickr.com/320/240?lock=190766891" },
                    { 51L, new DateTime(2021, 3, 14, 21, 6, 44, 546, DateTimeKind.Unspecified).AddTicks(7448), 2L, false, "https://loremflickr.com/320/240?lock=1638094146" },
                    { 52L, new DateTime(2021, 11, 10, 14, 14, 40, 829, DateTimeKind.Unspecified).AddTicks(154), 2L, false, "https://loremflickr.com/320/240?lock=1787153965" },
                    { 53L, new DateTime(2021, 9, 1, 12, 19, 4, 880, DateTimeKind.Unspecified).AddTicks(9160), 1L, false, "https://loremflickr.com/320/240?lock=178652054" },
                    { 54L, new DateTime(2021, 2, 19, 0, 31, 13, 945, DateTimeKind.Unspecified).AddTicks(8212), 4L, false, "https://loremflickr.com/320/240?lock=209230037" },
                    { 55L, new DateTime(2021, 2, 13, 5, 52, 32, 494, DateTimeKind.Unspecified).AddTicks(3301), 5L, false, "https://loremflickr.com/320/240?lock=2086382640" },
                    { 56L, new DateTime(2021, 6, 15, 11, 44, 8, 945, DateTimeKind.Unspecified).AddTicks(294), 2L, false, "https://loremflickr.com/320/240?lock=906043527" },
                    { 57L, new DateTime(2021, 4, 13, 19, 25, 11, 183, DateTimeKind.Unspecified).AddTicks(6953), 1L, false, "https://loremflickr.com/320/240?lock=1611580190" },
                    { 58L, new DateTime(2021, 11, 20, 20, 14, 39, 483, DateTimeKind.Unspecified).AddTicks(5490), 4L, false, "https://loremflickr.com/320/240?lock=1447260710" },
                    { 59L, new DateTime(2021, 11, 21, 12, 41, 30, 635, DateTimeKind.Unspecified).AddTicks(7576), 3L, false, "https://loremflickr.com/320/240?lock=504843572" },
                    { 60L, new DateTime(2021, 11, 15, 17, 28, 52, 978, DateTimeKind.Unspecified).AddTicks(4522), 1L, false, "https://loremflickr.com/320/240?lock=2077415830" },
                    { 61L, new DateTime(2021, 10, 26, 5, 0, 58, 337, DateTimeKind.Unspecified).AddTicks(9070), 2L, false, "https://loremflickr.com/320/240?lock=736941809" },
                    { 62L, new DateTime(2021, 8, 20, 8, 48, 23, 233, DateTimeKind.Unspecified).AddTicks(4863), 2L, false, "https://loremflickr.com/320/240?lock=126634992" },
                    { 63L, new DateTime(2021, 9, 25, 3, 50, 11, 101, DateTimeKind.Unspecified).AddTicks(3164), 5L, false, "https://loremflickr.com/320/240?lock=1893444886" },
                    { 64L, new DateTime(2021, 2, 24, 14, 33, 24, 779, DateTimeKind.Unspecified).AddTicks(7894), 1L, false, "https://loremflickr.com/320/240?lock=154026186" },
                    { 65L, new DateTime(2021, 2, 18, 0, 22, 3, 443, DateTimeKind.Unspecified).AddTicks(3553), 2L, false, "https://loremflickr.com/320/240?lock=436957093" },
                    { 66L, new DateTime(2021, 10, 10, 23, 21, 6, 8, DateTimeKind.Unspecified).AddTicks(1525), 5L, false, "https://loremflickr.com/320/240?lock=1158062442" },
                    { 67L, new DateTime(2022, 1, 26, 23, 27, 3, 225, DateTimeKind.Unspecified).AddTicks(4466), 5L, false, "https://loremflickr.com/320/240?lock=2060880055" },
                    { 68L, new DateTime(2021, 3, 13, 20, 37, 44, 419, DateTimeKind.Unspecified).AddTicks(4695), 1L, false, "https://loremflickr.com/320/240?lock=753387638" },
                    { 69L, new DateTime(2021, 2, 7, 14, 21, 20, 1, DateTimeKind.Unspecified).AddTicks(3425), 4L, false, "https://loremflickr.com/320/240?lock=1514969356" },
                    { 70L, new DateTime(2022, 1, 21, 17, 35, 58, 209, DateTimeKind.Unspecified).AddTicks(5397), 4L, false, "https://loremflickr.com/320/240?lock=755702435" },
                    { 71L, new DateTime(2021, 5, 27, 20, 46, 8, 954, DateTimeKind.Unspecified).AddTicks(496), 1L, false, "https://loremflickr.com/320/240?lock=1439674109" },
                    { 72L, new DateTime(2021, 11, 14, 5, 50, 32, 334, DateTimeKind.Unspecified).AddTicks(1289), 2L, false, "https://loremflickr.com/320/240?lock=1634103482" },
                    { 73L, new DateTime(2021, 10, 7, 12, 3, 47, 998, DateTimeKind.Unspecified).AddTicks(2605), 4L, false, "https://loremflickr.com/320/240?lock=1723501120" },
                    { 74L, new DateTime(2021, 3, 31, 11, 17, 25, 419, DateTimeKind.Unspecified).AddTicks(7089), 1L, false, "https://loremflickr.com/320/240?lock=359489171" },
                    { 75L, new DateTime(2022, 2, 1, 18, 17, 31, 0, DateTimeKind.Unspecified).AddTicks(6064), 2L, false, "https://loremflickr.com/320/240?lock=761417932" },
                    { 76L, new DateTime(2021, 11, 27, 3, 28, 23, 305, DateTimeKind.Unspecified).AddTicks(7137), 1L, false, "https://loremflickr.com/320/240?lock=1695813632" },
                    { 77L, new DateTime(2021, 11, 28, 5, 10, 38, 799, DateTimeKind.Unspecified).AddTicks(2126), 5L, false, "https://loremflickr.com/320/240?lock=382310853" },
                    { 78L, new DateTime(2021, 6, 8, 20, 20, 35, 887, DateTimeKind.Unspecified).AddTicks(5705), 4L, false, "https://loremflickr.com/320/240?lock=1777895072" },
                    { 79L, new DateTime(2021, 9, 1, 5, 31, 38, 310, DateTimeKind.Unspecified).AddTicks(6274), 4L, false, "https://loremflickr.com/320/240?lock=149659293" },
                    { 80L, new DateTime(2021, 7, 14, 15, 34, 2, 413, DateTimeKind.Unspecified).AddTicks(4501), 4L, false, "https://loremflickr.com/320/240?lock=1533870641" },
                    { 81L, new DateTime(2021, 6, 8, 1, 1, 28, 337, DateTimeKind.Unspecified).AddTicks(9924), 3L, false, "https://loremflickr.com/320/240?lock=496569547" },
                    { 82L, new DateTime(2021, 10, 11, 8, 26, 43, 165, DateTimeKind.Unspecified).AddTicks(9447), 2L, false, "https://loremflickr.com/320/240?lock=2120364832" },
                    { 83L, new DateTime(2021, 10, 9, 4, 44, 11, 267, DateTimeKind.Unspecified).AddTicks(8911), 4L, false, "https://loremflickr.com/320/240?lock=1654000475" },
                    { 84L, new DateTime(2021, 2, 5, 17, 16, 35, 346, DateTimeKind.Unspecified).AddTicks(6049), 3L, false, "https://loremflickr.com/320/240?lock=441024810" },
                    { 85L, new DateTime(2021, 9, 4, 3, 10, 30, 525, DateTimeKind.Unspecified).AddTicks(907), 1L, false, "https://loremflickr.com/320/240?lock=1612552693" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "URL" },
                values: new object[,]
                {
                    { 86L, new DateTime(2021, 9, 6, 16, 51, 11, 237, DateTimeKind.Unspecified).AddTicks(1483), 3L, false, "https://loremflickr.com/320/240?lock=622603232" },
                    { 87L, new DateTime(2021, 10, 12, 5, 26, 44, 161, DateTimeKind.Unspecified).AddTicks(660), 3L, false, "https://loremflickr.com/320/240?lock=1075683686" },
                    { 88L, new DateTime(2021, 12, 29, 3, 9, 16, 298, DateTimeKind.Unspecified).AddTicks(2955), 3L, false, "https://loremflickr.com/320/240?lock=1593689547" },
                    { 89L, new DateTime(2021, 3, 7, 21, 7, 52, 37, DateTimeKind.Unspecified).AddTicks(7889), 3L, false, "https://loremflickr.com/320/240?lock=1276039529" },
                    { 90L, new DateTime(2021, 2, 21, 6, 13, 20, 980, DateTimeKind.Unspecified).AddTicks(9807), 2L, false, "https://loremflickr.com/320/240?lock=2082658459" },
                    { 91L, new DateTime(2021, 3, 31, 8, 54, 59, 150, DateTimeKind.Unspecified).AddTicks(274), 4L, false, "https://loremflickr.com/320/240?lock=125686703" },
                    { 92L, new DateTime(2021, 12, 24, 4, 40, 17, 408, DateTimeKind.Unspecified).AddTicks(8899), 1L, false, "https://loremflickr.com/320/240?lock=531446498" },
                    { 93L, new DateTime(2021, 7, 9, 6, 41, 28, 282, DateTimeKind.Unspecified).AddTicks(5919), 5L, false, "https://loremflickr.com/320/240?lock=2045171195" },
                    { 94L, new DateTime(2021, 9, 18, 12, 44, 38, 808, DateTimeKind.Unspecified).AddTicks(623), 1L, false, "https://loremflickr.com/320/240?lock=1239086180" },
                    { 95L, new DateTime(2022, 1, 25, 1, 45, 42, 282, DateTimeKind.Unspecified).AddTicks(6811), 4L, false, "https://loremflickr.com/320/240?lock=956215013" },
                    { 96L, new DateTime(2021, 4, 6, 14, 9, 6, 763, DateTimeKind.Unspecified).AddTicks(743), 5L, false, "https://loremflickr.com/320/240?lock=820962877" },
                    { 97L, new DateTime(2021, 4, 18, 19, 8, 49, 834, DateTimeKind.Unspecified).AddTicks(5619), 1L, false, "https://loremflickr.com/320/240?lock=1502119343" },
                    { 98L, new DateTime(2022, 2, 1, 14, 49, 5, 306, DateTimeKind.Unspecified).AddTicks(4124), 1L, false, "https://loremflickr.com/320/240?lock=764026232" },
                    { 99L, new DateTime(2021, 4, 20, 20, 20, 30, 618, DateTimeKind.Unspecified).AddTicks(7598), 3L, false, "https://loremflickr.com/320/240?lock=374727688" },
                    { 100L, new DateTime(2021, 5, 30, 19, 38, 56, 757, DateTimeKind.Unspecified).AddTicks(2101), 5L, false, "https://loremflickr.com/320/240?lock=511291151" },
                    { 101L, new DateTime(2021, 3, 25, 13, 33, 28, 864, DateTimeKind.Unspecified).AddTicks(3495), 3L, false, "https://loremflickr.com/320/240?lock=118306644" }
                });

            migrationBuilder.InsertData(
                table: "Samples",
                columns: new[] { "Id", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 2L, "Eligendi quisquam ullam iure praesentium numquam sapiente distinctio ad. Tempore voluptatibus ad et adipisci hic amet. Corporis soluta cupiditate soluta. Provident rerum nemo dolores debitis dicta voluptatem labore dolores adipisci. Adipisci illo quidem sit dolores. Ea dolor animi quod laborum quia perspiciatis sunt tempora.", new DateTime(2020, 7, 1, 1, 14, 20, 556, DateTimeKind.Unspecified).AddTicks(7372), 5L, false, "hic" },
                    { 3L, "Incidunt perferendis omnis. Quas voluptatem beatae vitae sunt a ut sed repellendus. Accusamus eos enim consequatur et praesentium ad ut beatae eius. Omnis voluptas error et velit autem ipsa atque consequuntur vitae. Nostrum accusamus soluta nisi.", new DateTime(2020, 11, 26, 1, 10, 54, 982, DateTimeKind.Unspecified).AddTicks(9175), 4L, false, "velit" },
                    { 4L, "Architecto laboriosam culpa cumque dicta in. Perspiciatis amet autem rerum recusandae perspiciatis pariatur. Eum sint molestiae quis neque tempora ab distinctio. Nobis nulla dignissimos voluptas nemo cumque tenetur quod et placeat. Nihil sit eos similique fuga enim dolores ullam suscipit.", new DateTime(2021, 1, 18, 12, 14, 38, 642, DateTimeKind.Unspecified).AddTicks(7703), 1L, false, "est" },
                    { 5L, "Sapiente et saepe ut atque dolore accusantium soluta cumque perferendis. Magni adipisci labore corrupti. Ratione et quibusdam consequatur voluptatem velit expedita eos maxime.", new DateTime(2020, 2, 2, 15, 3, 56, 551, DateTimeKind.Unspecified).AddTicks(1864), 5L, false, "placeat" },
                    { 6L, "Iusto aspernatur nihil iure ut blanditiis veritatis quas. Et illum quod atque nulla voluptas quos beatae quaerat consequatur. Ab placeat tenetur perferendis et omnis. Doloremque corrupti deserunt sint enim ex sit.", new DateTime(2021, 4, 7, 16, 50, 6, 239, DateTimeKind.Unspecified).AddTicks(5929), 3L, false, "facere" },
                    { 7L, "Doloremque omnis facilis unde exercitationem consectetur culpa porro consequatur sed. Vel rem rerum eum harum. Ratione voluptate est officia accusamus doloremque perferendis ea. Unde iure laudantium ut amet repellendus enim consequatur dolor porro. Sed expedita dolorem aperiam ipsa omnis. Ut omnis ipsa quia cupiditate iure.", new DateTime(2019, 7, 23, 7, 33, 40, 245, DateTimeKind.Unspecified).AddTicks(9313), 5L, false, "impedit" },
                    { 8L, "Nesciunt placeat et consectetur enim. Consectetur magnam perspiciatis ut rem perspiciatis odit dolorem. Modi corrupti corrupti.", new DateTime(2020, 1, 27, 9, 1, 30, 801, DateTimeKind.Unspecified).AddTicks(8159), 3L, false, "corporis" },
                    { 9L, "Omnis culpa earum modi eos beatae autem. Deleniti labore veritatis dolorum. Omnis perferendis ut sit nulla autem ut voluptatem voluptas ut.", new DateTime(2021, 3, 25, 21, 11, 5, 602, DateTimeKind.Unspecified).AddTicks(6614), 5L, false, "perspiciatis" },
                    { 10L, "Molestias porro exercitationem omnis et eius. Est consequatur esse sit quia dolorem sequi doloribus corporis. Perspiciatis qui dignissimos.", new DateTime(2021, 4, 7, 22, 46, 32, 439, DateTimeKind.Unspecified).AddTicks(5958), 3L, false, "esse" },
                    { 11L, "Eos eum perferendis nisi alias et ducimus repudiandae ut. Voluptas rerum ullam omnis placeat non ea voluptatibus. Sint et et asperiores omnis recusandae saepe laborum enim. Non consequatur voluptatem in aut quia quo quo. Commodi aliquid aut quaerat adipisci. Modi ea maxime doloribus qui sint.", new DateTime(2021, 3, 24, 14, 25, 37, 776, DateTimeKind.Unspecified).AddTicks(56), 1L, false, "in" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "javascript" },
                    { 2L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "python" },
                    { 3L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "java" },
                    { 4L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "c#" },
                    { 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "php" },
                    { 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "android" },
                    { 7L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "html" },
                    { 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "jquery" },
                    { 9L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "css" },
                    { 10L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "ios" },
                    { 11L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "mysql" },
                    { 12L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "sql" },
                    { 13L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "node.js" },
                    { 14L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "arrays" },
                    { 15L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "c" },
                    { 16L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "asp.net" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "reactjs" },
                    { 18L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "json" },
                    { 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, ".net" },
                    { 20L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "swift" },
                    { 21L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "python" },
                    { 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "django" },
                    { 23L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "angular" },
                    { 24L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "excel" },
                    { 25L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "regex" },
                    { 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "pandas" },
                    { 27L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "ruby" },
                    { 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "wordpress" },
                    { 29L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "iphone" },
                    { 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "ajax" },
                    { 31L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "linux" },
                    { 32L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "xml" },
                    { 33L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "asp.net-mvc" },
                    { 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "vba" },
                    { 35L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "spring" },
                    { 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "laravel" },
                    { 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "database" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessToken", "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "IsDeleted", "LastName", "UserName" },
                values: new object[,]
                {
                    { 2L, null, 21L, "Ut pariatur iure aut aut magni aut excepturi ut.", new DateTime(2021, 12, 21, 19, 7, 24, 473, DateTimeKind.Unspecified).AddTicks(7695), 4L, "Kaya12@gmail.com", "f47d291c-a53b-0576-aeae-88467b256d47", "Terrill", false, "VonRueden", "Cletus.Goldner57" },
                    { 3L, null, 16L, "Blanditiis quo repellendus necessitatibus magnam debitis qui dolorum laborum.", new DateTime(2021, 12, 24, 1, 51, 19, 245, DateTimeKind.Unspecified).AddTicks(6092), 1L, "Nova.Kling36@yahoo.com", "34bf40e6-b98b-8be9-124a-d4488b7a2afb", "Rickey", false, "Swaniawski", "Violet40" },
                    { 4L, null, 5L, "Dolorem aut rem sed soluta hic.\nExercitationem quisquam vel.\nVoluptatum maiores sequi et voluptatem voluptatum cupiditate.\nDistinctio ad quia atque quae.\nIpsum modi numquam.", new DateTime(2022, 1, 17, 11, 52, 12, 1, DateTimeKind.Unspecified).AddTicks(2709), 5L, "Freda44@hotmail.com", "a6db37af-cb43-7709-90ef-e5c49df914e6", "Lee", false, "Kreiger", "Bernie.Conroy74" },
                    { 5L, null, 87L, "Est rerum similique ex corrupti molestias aperiam.", new DateTime(2021, 4, 15, 22, 24, 58, 888, DateTimeKind.Unspecified).AddTicks(518), 3L, "Eino90@hotmail.com", "ec2e3e9d-1fc8-bbc7-1fe9-2a75c5815b41", "Litzy", false, "Keebler", "Camille64" },
                    { 6L, null, 98L, "Ea ipsa dolor optio impedit perferendis.\nTempora est ducimus et eaque.", new DateTime(2021, 10, 29, 20, 25, 36, 678, DateTimeKind.Unspecified).AddTicks(2948), 5L, "Dena.Bartoletti@gmail.com", "8a06b6e1-29f3-c781-c2bf-0c7b0d9fe20f", "Westley", false, "Kreiger", "Mohammad14" },
                    { 7L, null, 63L, "Sapiente quia quis rem blanditiis cumque et aut.", new DateTime(2021, 6, 16, 6, 19, 58, 539, DateTimeKind.Unspecified).AddTicks(8786), 3L, "Ubaldo.Robel11@yahoo.com", "ef5348e2-f9b3-3cb7-d185-ad23aa3a2e6b", "Moriah", false, "McGlynn", "Sarah58" },
                    { 8L, null, 43L, "Et blanditiis nihil beatae consequatur possimus sint libero a.\nIllo qui sed autem ut corrupti eaque et aut.\nDolore eos esse et enim aspernatur aut quo.\nQuisquam repellat perspiciatis impedit consequatur molestiae quia blanditiis.", new DateTime(2022, 1, 20, 4, 13, 13, 344, DateTimeKind.Unspecified).AddTicks(5137), 4L, "Cynthia9@yahoo.com", "fac87d00-907e-09bb-ff57-e9bccb7a251a", "Vergie", false, "Zboncak", "Bailee_Brakus90" },
                    { 9L, null, 61L, "Commodi aperiam cum numquam ad libero sequi quisquam nam.\nCumque sed cumque aliquid nihil pariatur rem.", new DateTime(2021, 12, 31, 10, 38, 42, 350, DateTimeKind.Unspecified).AddTicks(8358), 3L, "Nelson.Fisher68@yahoo.com", "f57184b4-7b82-b34c-c188-b2058b23f126", "Joesph", false, "Brown", "Conner78" },
                    { 10L, null, 45L, "Enim voluptas ea quasi quae incidunt.\nVitae impedit amet voluptas asperiores.\nOptio sunt quia ducimus aliquam ex ratione.", new DateTime(2021, 7, 24, 9, 7, 6, 638, DateTimeKind.Unspecified).AddTicks(9404), 4L, "Carolyne_Berge@yahoo.com", "b4b61125-e88b-6ad8-d490-d09c46cc498e", "Alvis", false, "Stehr", "Garth59" },
                    { 11L, null, 53L, "Ea qui ratione dolor ut et.\nRem dolorem iste autem qui eos nisi.\nAperiam voluptate quasi nulla at officia modi perspiciatis.\nFacilis aut velit qui architecto laudantium libero.", new DateTime(2021, 11, 8, 8, 13, 58, 593, DateTimeKind.Unspecified).AddTicks(1049), 5L, "Demarcus7@hotmail.com", "0072a4e9-e30e-645f-f461-2aa57deec228", "Ryan", false, "Corkery", "Israel_Johnson6" },
                    { 12L, null, 31L, "Ea rerum accusantium saepe eum illo.", new DateTime(2021, 2, 6, 23, 26, 0, 956, DateTimeKind.Unspecified).AddTicks(9451), 1L, "Judy.Labadie5@yahoo.com", "9ffe22d6-8df5-2d7c-fc97-fb681dc4481b", "Sim", false, "Sipes", "Bridie.Dibbert" },
                    { 13L, null, 83L, "Blanditiis quia sequi.\nVel aut dolorum aut sed voluptas voluptas totam quos natus.", new DateTime(2021, 4, 23, 2, 25, 11, 193, DateTimeKind.Unspecified).AddTicks(7519), 5L, "Kaylee_Abernathy@hotmail.com", "d4e14702-0980-4672-962b-17ffd4ebb231", "Oswaldo", false, "Homenick", "Julien_Runte67" },
                    { 14L, null, 81L, "Non recusandae sit.\nModi quibusdam iure quia tempore sint esse praesentium.\nOfficia tempora fuga rerum officiis omnis magnam quia unde.\nEt architecto et voluptatem accusamus possimus aspernatur cupiditate.\nEt molestiae vitae laudantium quia facilis maxime consectetur.", new DateTime(2021, 5, 14, 12, 41, 24, 521, DateTimeKind.Unspecified).AddTicks(6085), 5L, "Clotilde.Hauck46@hotmail.com", "932a123d-575f-9118-4e02-4f1a8b37cf84", "Arjun", false, "Abbott", "Madaline.Keeling68" },
                    { 15L, null, 53L, "Esse reiciendis non eos libero id odit.", new DateTime(2022, 1, 8, 21, 19, 23, 731, DateTimeKind.Unspecified).AddTicks(9252), 5L, "Caleb32@gmail.com", "565d25c3-688f-61de-4a4c-ae9f390910d3", "Heath", false, "Flatley", "Marilyne_Spinka76" },
                    { 16L, null, 20L, "Doloribus quia laboriosam consequatur consequuntur enim libero.\nPariatur eos dicta in.\nConsectetur optio ipsa aut qui qui.", new DateTime(2021, 5, 3, 18, 31, 2, 300, DateTimeKind.Unspecified).AddTicks(888), 1L, "Beulah97@gmail.com", "30c233bd-2b30-9907-51ce-3e47de6120bf", "Shanny", false, "Klein", "Kavon.Blanda" },
                    { 17L, null, 97L, "Id alias ex.\nConsequatur ut consequatur dolor doloribus occaecati.\nNostrum veritatis cum fugit aut quia.", new DateTime(2021, 5, 11, 7, 58, 50, 764, DateTimeKind.Unspecified).AddTicks(716), 5L, "Janis43@gmail.com", "b63a4447-9060-befa-4307-043a335e7703", "Francesco", false, "Hoeger", "Addie_Funk" },
                    { 18L, null, 47L, "Iusto incidunt et possimus tenetur corporis ipsa.", new DateTime(2021, 7, 12, 10, 26, 7, 693, DateTimeKind.Unspecified).AddTicks(6533), 1L, "Noemy_Schmitt37@yahoo.com", "3eb62f8f-ad6d-863b-7405-34de74df38fc", "Michale", false, "Harber", "Odell_Raynor9" },
                    { 19L, null, 8L, "Non doloribus et magnam.\nConsectetur qui voluptatem voluptas ratione vitae suscipit.\nAsperiores consectetur dicta.\nEligendi possimus similique qui.", new DateTime(2021, 9, 23, 8, 44, 50, 716, DateTimeKind.Unspecified).AddTicks(7149), 1L, "Cordia83@gmail.com", "687094fc-d2da-9545-3143-8d085dd694f1", "Vernie", false, "Ledner", "Krista15" },
                    { 20L, null, 17L, "Nesciunt natus debitis dolor earum earum soluta quia aliquam.\nAccusamus perspiciatis mollitia nobis consequatur dolor autem consequatur voluptas repellat.", new DateTime(2021, 8, 10, 18, 47, 18, 898, DateTimeKind.Unspecified).AddTicks(9764), 1L, "Kristopher.Cassin57@hotmail.com", "8905eff1-62c7-171c-b538-88d7cda716dd", "Addison", false, "Abshire", "Carey.Schmitt" },
                    { 21L, null, 27L, "Voluptatem illum in iusto aut est consequatur repellendus.\nRerum nesciunt unde et quia officiis adipisci deleniti.", new DateTime(2021, 7, 9, 7, 32, 38, 891, DateTimeKind.Unspecified).AddTicks(7680), 5L, "Chelsea_Koss@yahoo.com", "9a19fcb1-a56c-82ec-213f-e1c642f9dc37", "Rafael", false, "Franecki", "Junius_Will" },
                    { 22L, null, 76L, "Ad voluptatem commodi.\nMinus labore veniam.", new DateTime(2021, 9, 8, 13, 56, 7, 698, DateTimeKind.Unspecified).AddTicks(7017), 1L, "Minnie.Streich@yahoo.com", "3b1bee47-39a6-76fc-54b5-a80f1321d36c", "Addison", false, "Hilpert", "Barbara57" },
                    { 23L, null, 17L, "Quae autem ut adipisci tempora sit.\nModi alias aut beatae enim laborum placeat consectetur fugit alias.\nVeniam vero labore eveniet tempore nisi odio corporis dicta omnis.\nEst voluptatum distinctio sint.", new DateTime(2021, 10, 21, 3, 29, 53, 855, DateTimeKind.Unspecified).AddTicks(7758), 1L, "Kirk.Heaney@hotmail.com", "017e303b-dd08-0627-5832-a09591c5883c", "Theresia", false, "Hagenes", "Dessie.Grady" },
                    { 24L, null, 28L, "Facere harum quia pariatur quos et.\nEius sunt delectus natus eaque quia molestiae ex culpa.\nAutem minima corrupti quidem qui et et modi.", new DateTime(2021, 12, 12, 9, 17, 21, 686, DateTimeKind.Unspecified).AddTicks(170), 1L, "Enoch11@yahoo.com", "348005ea-d2ec-f486-332e-a157d225bfd0", "Addison", false, "Haley", "Abby_Roob16" },
                    { 25L, null, 45L, "Quod et accusamus animi perspiciatis dicta blanditiis nihil sed.", new DateTime(2021, 4, 19, 8, 43, 36, 352, DateTimeKind.Unspecified).AddTicks(1615), 5L, "Jeanette24@hotmail.com", "e9ea31c2-1489-4b93-e114-37c4a7d24a40", "Adalberto", false, "Sauer", "Federico3" },
                    { 26L, null, 10L, "Molestias quae amet nemo nesciunt provident odit et ea dolore.\nTenetur earum labore saepe corrupti quae id aut.\nFugiat expedita omnis omnis perspiciatis.\nUnde et qui.", new DateTime(2021, 2, 19, 4, 4, 32, 681, DateTimeKind.Unspecified).AddTicks(732), 5L, "Stewart31@hotmail.com", "24fae679-17be-f688-81d2-344573f01985", "Sherman", false, "O'Reilly", "Jeffery.Medhurst" },
                    { 27L, null, 81L, "Dolore natus nisi sed pariatur dolorum.\nSunt sed non voluptas.\nDolorum veniam ut consequatur ex iste molestiae ullam.\nCumque dolor dolorum eum soluta dolore tempora nemo non facere.\nVoluptatem modi nemo consequuntur in quis eos non sunt.", new DateTime(2021, 3, 16, 9, 6, 59, 81, DateTimeKind.Unspecified).AddTicks(1459), 4L, "Krystina.Kulas@yahoo.com", "edfc472b-0da3-83b0-57d3-f5744718d7a3", "Norberto", false, "Block", "Helga.Bernier42" },
                    { 28L, null, 47L, "Qui non nisi fugit quis odit.", new DateTime(2021, 6, 26, 15, 31, 13, 580, DateTimeKind.Unspecified).AddTicks(9720), 3L, "Sharon_Koch@hotmail.com", "56fe128a-72bf-87a8-be8b-841d1a3001e4", "Roma", false, "Jerde", "Adele_Metz" },
                    { 29L, null, 69L, "Quos et dolores veniam repudiandae qui.", new DateTime(2021, 8, 5, 9, 46, 8, 219, DateTimeKind.Unspecified).AddTicks(9240), 2L, "Kaya.Fahey@gmail.com", "b2810914-4d1c-ee90-1b7e-7324504ac911", "Niko", false, "Kozey", "Alta78" },
                    { 30L, null, 59L, "Et sunt distinctio voluptatem quos aut nemo est.\nUnde provident molestiae laboriosam occaecati quam harum.\nEt sit qui et enim veniam aut aspernatur praesentium natus.", new DateTime(2021, 2, 3, 9, 57, 31, 853, DateTimeKind.Unspecified).AddTicks(9551), 4L, "Bertrand_Thiel@gmail.com", "495db87e-d017-1de8-0947-ee849b1ab31b", "Royal", false, "Beier", "Roscoe.Zieme" },
                    { 31L, null, 86L, "Aperiam ut quia laborum est et vero ut in cupiditate.\nEst consequatur nulla occaecati explicabo ipsa incidunt provident maiores similique.\nIncidunt iste sit.\nQuo harum modi officiis accusantium adipisci.\nMollitia quae a.", new DateTime(2021, 6, 13, 20, 10, 48, 54, DateTimeKind.Unspecified).AddTicks(9108), 5L, "Caitlyn_Haley18@hotmail.com", "b2b6780e-2bcc-f358-aaa9-5f69641093d1", "Walton", false, "Grant", "Tod_Baumbach" },
                    { 32L, null, 30L, "Eius saepe sint nobis voluptatem eum amet.\nSint accusantium aliquid et aut a.\nVeniam odio dolores.\nQuae est quaerat quisquam.\nEt quod inventore.", new DateTime(2022, 1, 16, 17, 18, 12, 999, DateTimeKind.Unspecified).AddTicks(8673), 5L, "Elnora.Tremblay@gmail.com", "cecf24ba-611b-c455-e775-99eede8fcd16", "Octavia", false, "Runte", "Damien.Cassin74" },
                    { 33L, null, 39L, "Voluptas quae quia voluptatem rerum.", new DateTime(2021, 10, 24, 17, 48, 18, 820, DateTimeKind.Unspecified).AddTicks(8116), 2L, "Ewell.Corkery46@gmail.com", "84c2f2ec-b5b5-f0e9-9077-1aa589174f32", "Charles", false, "Tremblay", "Lorena_Leffler95" },
                    { 34L, null, 90L, "Omnis et eius delectus magnam animi facere non.\nMagnam sint qui in vero.\nRerum est iusto qui doloremque molestiae rerum magnam illum.\nEum corporis provident.", new DateTime(2021, 11, 30, 18, 47, 35, 681, DateTimeKind.Unspecified).AddTicks(620), 3L, "Merle.Nader@yahoo.com", "f0e69094-9967-b61a-d0ab-8ba88bf5fe50", "Lucio", false, "Ruecker", "Ollie57" },
                    { 35L, null, 48L, "Ullam eius mollitia quidem et ipsa.\nExcepturi corporis facilis beatae.\nQuibusdam est est assumenda deleniti porro aut amet qui iure.\nEt temporibus molestiae ullam ad rerum.\nOccaecati laudantium temporibus eius natus sed et voluptas.", new DateTime(2021, 2, 26, 18, 46, 3, 943, DateTimeKind.Unspecified).AddTicks(361), 1L, "Wanda61@hotmail.com", "1b89673c-4f90-7504-42e3-3cf452bd586e", "Macey", false, "Jakubowski", "Charlie87" },
                    { 36L, null, 25L, "Cumque quo quibusdam fugiat velit ut omnis.", new DateTime(2021, 10, 23, 14, 58, 32, 767, DateTimeKind.Unspecified).AddTicks(1046), 1L, "Darrell84@hotmail.com", "c7b27e2f-a014-ae0c-52d4-e1f23d238c38", "Cole", false, "Mayer", "Savanna61" },
                    { 37L, null, 57L, "Enim magni fugiat sed doloribus.\nEveniet fuga impedit ut.\nPossimus aspernatur quidem excepturi dolore maiores quibusdam.\nId et nam.", new DateTime(2021, 9, 14, 13, 59, 0, 189, DateTimeKind.Unspecified).AddTicks(1362), 4L, "Lincoln18@hotmail.com", "15fa9cae-59fc-01a4-ecdc-416b86de74bf", "Marques", false, "Conn", "Robb_Green" },
                    { 38L, null, 100L, "Facilis nisi non minima et maiores suscipit et voluptas.", new DateTime(2021, 9, 13, 2, 36, 51, 81, DateTimeKind.Unspecified).AddTicks(2857), 4L, "Ashlee0@hotmail.com", "e0aec8d3-5b43-34fa-12dc-1d87c9b07a41", "Sigurd", false, "Bernier", "Lorenza.Donnelly79" },
                    { 39L, null, 82L, "Molestiae ut rerum porro aut consequatur consectetur temporibus totam ea.\nError eveniet error.\nAdipisci iure architecto quis alias iste voluptas.", new DateTime(2022, 1, 7, 21, 28, 37, 783, DateTimeKind.Unspecified).AddTicks(5169), 3L, "Ana.Quigley2@hotmail.com", "cc24f1ee-fc4b-cc29-4d21-8e7b47c4b000", "Emmet", false, "Berge", "Andre27" },
                    { 40L, null, 58L, "Provident eum consequatur.\nNeque ipsum reiciendis doloribus.\nNumquam fuga fuga dolor omnis.", new DateTime(2021, 7, 19, 18, 9, 56, 962, DateTimeKind.Unspecified).AddTicks(3930), 2L, "Easton20@hotmail.com", "9f386a3b-4eea-0f4a-a906-75d73ba48978", "Mary", false, "Marquardt", "Jeremy_Johns24" },
                    { 41L, null, 54L, "Quo expedita inventore est in odio.", new DateTime(2021, 7, 11, 12, 50, 7, 372, DateTimeKind.Unspecified).AddTicks(8866), 3L, "Shane.Skiles11@yahoo.com", "600b6099-0fe3-d54f-9b18-ee52acde55d5", "Ryan", false, "Koepp", "Vidal7" },
                    { 42L, null, 53L, "Cum repellat hic pariatur veniam maiores.\nRem sint et vero cum ut ea non id et.\nSimilique nihil unde sequi.\nSit est enim provident esse non ducimus laborum reprehenderit.\nDicta nihil voluptatem nulla et sed.", new DateTime(2021, 7, 14, 2, 11, 6, 948, DateTimeKind.Unspecified).AddTicks(1195), 2L, "Colby_Hirthe69@yahoo.com", "4924558a-61a3-db07-cbf1-b0e24a50d6a5", "Valentine", false, "Runolfsdottir", "Terence0" },
                    { 43L, null, 9L, "Delectus et modi quia vel.\nQuidem dolores reiciendis reiciendis rerum.\nVeritatis eum adipisci eos non et inventore.\nIpsa ut ab harum.", new DateTime(2021, 12, 24, 21, 22, 59, 332, DateTimeKind.Unspecified).AddTicks(8480), 4L, "Meggie25@gmail.com", "a7d81e67-6d51-0e1b-1805-9fa10abf5f9d", "Tre", false, "O'Reilly", "Izaiah26" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessToken", "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirebaseId", "FirstName", "IsDeleted", "LastName", "UserName" },
                values: new object[,]
                {
                    { 44L, null, 99L, "Sit deserunt inventore tempore modi voluptate debitis et.\nSed error ab perferendis veritatis.", new DateTime(2021, 7, 8, 7, 50, 5, 275, DateTimeKind.Unspecified).AddTicks(8333), 2L, "Johan23@yahoo.com", "1b7e11e8-1f25-e5d6-372a-786e25344d78", "Lelia", false, "Lind", "Domenick3" },
                    { 45L, null, 90L, "Est quia et perspiciatis ut rem ullam ex corrupti dignissimos.", new DateTime(2022, 1, 20, 16, 50, 26, 485, DateTimeKind.Unspecified).AddTicks(9527), 4L, "Maxwell.Wiza1@hotmail.com", "7632744a-20c7-1441-0a3d-a33b9e4dcc1d", "Blanche", false, "Huel", "Maximus8" },
                    { 46L, null, 65L, "Tempore at earum quos repudiandae magni quia.\nAliquid ea aperiam officia.", new DateTime(2021, 10, 4, 8, 56, 23, 467, DateTimeKind.Unspecified).AddTicks(6550), 3L, "Deshawn_Bode3@hotmail.com", "34869b04-fb8e-0fe3-fbee-aba8d18124bf", "Alexandrea", false, "Brekke", "Nicole.Zulauf" },
                    { 47L, null, 47L, "Nesciunt voluptatem et sint.\nUt repellat voluptatum facere ut cum ad voluptate ut.\nOdio sequi omnis ut ex doloribus unde aliquid reiciendis voluptatem.\nIpsum excepturi aspernatur sapiente consequatur saepe fuga ea et.\nConsectetur aspernatur dolorum aut consequatur sunt veniam veritatis animi.", new DateTime(2021, 11, 22, 2, 55, 48, 531, DateTimeKind.Unspecified).AddTicks(7652), 1L, "Jordyn.Lesch@yahoo.com", "615dbb89-a20c-9d36-5dc8-203523c9cd0d", "Vidal", false, "Bradtke", "Priscilla_Ledner" },
                    { 48L, null, 41L, "Nostrum vel dolores labore quidem.\nConsequatur quas amet optio accusantium quaerat praesentium aut tempore sit.\nMolestiae occaecati velit quos nesciunt vel alias.", new DateTime(2021, 5, 12, 17, 43, 58, 729, DateTimeKind.Unspecified).AddTicks(8866), 2L, "Estevan.Kassulke2@yahoo.com", "8374c3ea-5f07-f810-d1e7-3e6b1543c587", "Presley", false, "Heller", "Burley15" },
                    { 49L, null, 61L, "Qui corporis occaecati sequi odit nesciunt.\nOmnis provident aut quas provident.\nDolor eum aut.", new DateTime(2021, 10, 24, 2, 22, 15, 695, DateTimeKind.Unspecified).AddTicks(6894), 2L, "Colleen.King76@hotmail.com", "f69c6354-822f-6c5a-9854-7b6cbc4c5311", "Omari", false, "Christiansen", "Mitchel_Marvin21" },
                    { 50L, null, 87L, "Vero reprehenderit sunt nobis quo sed.\nImpedit incidunt debitis et nihil omnis commodi accusantium ut consequuntur.\nMinima nihil ratione hic laborum sit necessitatibus itaque cupiditate iste.\nExpedita ut aut distinctio doloremque iste fugit repellat eligendi id.", new DateTime(2021, 8, 8, 12, 39, 12, 747, DateTimeKind.Unspecified).AddTicks(3483), 1L, "Bethany.Lehner75@yahoo.com", "27add938-120a-02c3-1108-9b08c385745e", "Aliya", false, "O'Reilly", "Ross_Ebert" },
                    { 51L, null, 73L, "Modi dolorum deserunt et voluptatem minima.\nEaque non eaque quis officiis.\nSequi fuga sunt nobis.", new DateTime(2021, 11, 11, 13, 26, 9, 658, DateTimeKind.Unspecified).AddTicks(2423), 4L, "Eudora_Kilback6@yahoo.com", "cbeb93d2-86d0-04ad-ba3a-bd4a3372ca6d", "Rachelle", false, "Vandervort", "Ludie74" }
                });

            migrationBuilder.InsertData(
                table: "Apps",
                columns: new[] { "Id", "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 2L, new Guid("77f04c2e-c112-f632-b0e8-aec7a28d7866"), new DateTime(2021, 12, 11, 16, 15, 40, 198, DateTimeKind.Unspecified).AddTicks(7363), 5L, "Saepe nihil iure iure numquam nihil.\nEaque hic quam enim nihil voluptatem aut non sed.\nDistinctio blanditiis nobis ipsam nemo repellendus omnis tenetur voluptates.\nEligendi et quia et qui sunt totam voluptatem.", "Minus et aut qui perspiciatis et explicabo pariatur quasi amet.", 42L, false, "Uzbekistan SumpaymentPersonal Loan Account", 38L },
                    { 3L, new Guid("5cdc7e05-2269-3418-9c46-4779b03bcd9d"), new DateTime(2021, 5, 13, 18, 27, 59, 288, DateTimeKind.Unspecified).AddTicks(4078), 5L, "Ut laudantium laboriosam voluptatum quia enim.\nEarum magnam est sequi reprehenderit.", "Dolorum est suscipit nobis ut praesentium eveniet sit.", 21L, false, "InternalGroveBeauty", 51L },
                    { 4L, new Guid("c6e98ccf-944a-506a-7c0c-c30b8c011442"), new DateTime(2021, 11, 5, 16, 17, 32, 176, DateTimeKind.Unspecified).AddTicks(6846), 1L, "Officiis modi commodi et.\nMolestiae ullam explicabo totam veniam voluptatem sed dolor.\nEt odio maxime enim et molestiae quia.\nAperiam facilis et eum voluptas accusamus sequi.", "Et neque aut vitae et non.", 14L, false, "analyzingNakfa", 35L },
                    { 5L, new Guid("7cc93ac6-320c-ae66-5a55-bed3220d008e"), new DateTime(2021, 9, 27, 21, 16, 24, 348, DateTimeKind.Unspecified).AddTicks(1063), 4L, "Nulla quibusdam voluptates esse sint.\nAlias fugit facere.\nFugit ullam quisquam et.", "Et dolore officia molestiae itaque similique similique voluptas.", 24L, false, "turn-keycapacityElectronics", 40L },
                    { 6L, new Guid("cad131cb-c98b-059a-f530-b32b5ecf7e16"), new DateTime(2021, 4, 13, 15, 4, 15, 213, DateTimeKind.Unspecified).AddTicks(6882), 2L, "Repellendus et voluptatem consequatur quos eligendi aut.", "Nesciunt et unde rerum id.", 101L, false, "PlazaInternational", 33L },
                    { 7L, new Guid("9f77ab6e-b6a8-47f3-7b2d-3ec949977b90"), new DateTime(2021, 4, 9, 14, 49, 47, 476, DateTimeKind.Unspecified).AddTicks(8133), 2L, "Non voluptate ut velit voluptatem earum quae.\nAliquam voluptatum voluptatem dolor dolorum quia consequatur dolores rerum optio.\nMolestias officiis necessitatibus placeat ut.\nVel consequuntur quaerat nostrum ad voluptatem saepe vel id.\nIncidunt blanditiis est dolorem mollitia nulla.", "Culpa adipisci adipisci quo et qui architecto harum deleniti.", 68L, false, "VermontManager", 18L },
                    { 8L, new Guid("c049b115-7872-31ac-0235-542d533817a9"), new DateTime(2021, 11, 30, 13, 34, 1, 798, DateTimeKind.Unspecified).AddTicks(9928), 4L, "Laborum iure optio dicta.\nMaxime provident eveniet.\nSunt repellendus veniam eum dolor inventore molestiae aut fugiat.\nEt natus et id.\nRepudiandae voluptate quam dolorum saepe cumque velit et totam aspernatur.\nIn itaque saepe quis.", "Ad provident qui distinctio vel itaque praesentium et.", 98L, false, "Personal Loan AccountForkimplementRAM", 34L },
                    { 9L, new Guid("a27d502a-9e22-4868-8ea4-a02190f60164"), new DateTime(2021, 11, 6, 4, 49, 57, 563, DateTimeKind.Unspecified).AddTicks(6995), 2L, "Cumque totam sit molestias id sunt labore ut quam et.", "Corrupti beatae praesentium nam qui odio et ipsum.", 18L, false, "ubiquitousToolsForwardhard drive", 50L },
                    { 10L, new Guid("179ca5de-a60d-4149-c2da-a44e368bf846"), new DateTime(2021, 7, 2, 4, 18, 57, 767, DateTimeKind.Unspecified).AddTicks(2685), 1L, "Ex voluptas voluptatum eveniet voluptas.\nReiciendis ipsa id qui explicabo beatae est nulla.\nMinima rerum dolor eveniet enim reprehenderit.\nQuisquam sit aperiam et non reprehenderit.\nHarum nam ipsa aperiam error.\nIn atque atque repudiandae rerum et quisquam.", "Iure et cum unde enim sit.", 88L, false, "Buckinghamshirezero administrationprogramming", 37L },
                    { 11L, new Guid("b84671c0-1654-2d1d-d18a-a08ea72d9821"), new DateTime(2021, 7, 21, 10, 37, 44, 742, DateTimeKind.Unspecified).AddTicks(6590), 4L, "Rerum ex laboriosam fuga sed laudantium voluptates reiciendis.\nSit nihil voluptas pariatur modi vel.\nVoluptatem accusamus quia et ut rerum similique.", "Voluptatum sunt tempora est maiores repellat eveniet aut provident est.", 81L, false, "ErgonomicSmall Steel GlovesTools, Computers & Computerssynthesize", 45L },
                    { 12L, new Guid("c08938ee-0914-8e7b-ad06-3a40bfb4e8d0"), new DateTime(2021, 10, 20, 13, 27, 22, 914, DateTimeKind.Unspecified).AddTicks(8959), 4L, "Doloribus numquam ad voluptatem magni minima expedita aliquam fugit.\nPerspiciatis est sequi corrupti consequatur eum.\nSunt voluptate minima.\nQuia aut molestiae ut iste nihil eos perferendis.\nInventore voluptatibus accusamus.", "Nostrum impedit nam et non ea eligendi.", 6L, false, "RSSPNG", 28L },
                    { 13L, new Guid("46f59a4c-e0f0-61bb-a08f-1c1a4790cc6b"), new DateTime(2021, 12, 5, 20, 1, 37, 845, DateTimeKind.Unspecified).AddTicks(6639), 2L, "Sapiente accusamus praesentium aut voluptatem facilis sunt eum.\nQuia beatae esse velit alias ut deserunt ad.\nCommodi dolorum ut id libero consectetur doloribus in.", "Asperiores quis error at.", 46L, false, "Licensed Wooden Pizzafront-endsynthesizing", 34L },
                    { 14L, new Guid("75a0f507-f23e-90a7-ed25-4646fb781bb6"), new DateTime(2021, 7, 24, 7, 12, 3, 836, DateTimeKind.Unspecified).AddTicks(9094), 4L, "Eaque placeat soluta odit temporibus cupiditate et.\nEt est voluptatibus ullam accusantium sint eum.\nIllo aspernatur hic voluptatibus temporibus omnis qui repellendus.\nReiciendis et possimus eum veritatis aliquam molestias at.", "Minus modi velit ut sit facere et porro deleniti.", 2L, false, "open-sourcepartnershipsXML", 39L },
                    { 15L, new Guid("fc47587e-10a0-e46c-a87c-5bf64d484c10"), new DateTime(2021, 11, 30, 10, 43, 46, 979, DateTimeKind.Unspecified).AddTicks(5195), 2L, "Quis et architecto eum atque error fuga eaque maxime.\nBlanditiis similique quis voluptatem quidem reiciendis dolore voluptatem maxime.\nDicta et tempore sequi at quia.", "Quod dolor odio reprehenderit voluptatum dignissimos earum nobis.", 71L, false, "connectHumanStation", 2L },
                    { 16L, new Guid("4be364cd-23ea-4190-0143-fd8857c07932"), new DateTime(2022, 1, 11, 20, 57, 26, 280, DateTimeKind.Unspecified).AddTicks(3700), 2L, "Voluptas voluptatem in autem autem magni rerum harum cupiditate.", "Rerum sint non commodi.", 86L, false, "SoftBedfordshirePersonal Loan AccountQuality", 30L },
                    { 17L, new Guid("9ca2a5b2-fadb-55af-f0bc-9b62fc41df56"), new DateTime(2021, 2, 25, 22, 37, 2, 396, DateTimeKind.Unspecified).AddTicks(4191), 2L, "Sed quod ducimus in ad doloremque pariatur.\nOfficia possimus maiores.", "Voluptatum vel soluta quia sed aut.", 32L, false, "East Caribbean DollarCentralPractical", 33L },
                    { 18L, new Guid("b8798048-2bb2-5776-55d9-11d30d83ebf1"), new DateTime(2021, 7, 7, 14, 14, 6, 876, DateTimeKind.Unspecified).AddTicks(7554), 2L, "Maiores quo praesentium non ipsa enim blanditiis.\nEt unde velit.\nDolorem amet eos non rem.", "Accusamus quia qui aut qui laudantium ea et fugit.", 41L, false, "SteelCornersMetalgenerate", 42L },
                    { 19L, new Guid("8a73ddb7-1ce8-64cd-44b7-2d5cad620f05"), new DateTime(2021, 2, 7, 22, 31, 37, 167, DateTimeKind.Unspecified).AddTicks(6861), 4L, "Architecto minima temporibus quaerat id cum necessitatibus.\nIusto consequatur officia ex beatae temporibus facilis.", "Sint deserunt sed non qui nam dignissimos placeat molestias ut.", 94L, false, "Licensed Concrete FishSQLWay", 20L },
                    { 20L, new Guid("248ae82d-b546-e978-c077-a704bcbea16e"), new DateTime(2021, 11, 26, 0, 12, 29, 662, DateTimeKind.Unspecified).AddTicks(2387), 2L, "Et nesciunt esse perferendis aut neque impedit voluptatem.\nIure aperiam incidunt autem inventore distinctio doloribus.\nAut quia in natus ullam.\nEius sit deserunt error architecto veritatis tempora.", "Unde alias dolor at autem sit.", 69L, false, "supply-chainsmiddlewareMichigan", 26L },
                    { 21L, new Guid("c0079e8b-d227-16f5-e5ab-d8c5acbaf661"), new DateTime(2021, 12, 27, 9, 47, 39, 765, DateTimeKind.Unspecified).AddTicks(722), 2L, "Saepe velit occaecati vero libero.\nIpsa omnis fugiat possimus nobis explicabo ut laboriosam nobis asperiores.\nArchitecto minus debitis nobis molestias itaque quos temporibus assumenda sit.\nMolestiae iste assumenda beatae molestias laudantium laboriosam laboriosam tempore.\nQui ducimus qui asperiores sequi qui sed ab vitae.\nExcepturi quo et occaecati.", "Eum esse mollitia quidem.", 101L, false, "AgentCustomizableHome Loan Account", 19L },
                    { 22L, new Guid("7ead84a0-d0ae-e666-aa45-34be0347fa3a"), new DateTime(2021, 10, 2, 18, 22, 6, 898, DateTimeKind.Unspecified).AddTicks(4864), 2L, "A beatae facilis placeat et id at consequatur aut.\nRecusandae totam consequatur magnam.\nOccaecati in voluptatem et.", "Tenetur quod est recusandae et sunt inventore magnam dolor.", 28L, false, "object-orientedNew Israeli Sheqel", 35L },
                    { 23L, new Guid("11ff1838-1312-1343-c8f1-4df5339ca690"), new DateTime(2022, 1, 13, 0, 53, 58, 471, DateTimeKind.Unspecified).AddTicks(8746), 4L, "Quam impedit sapiente aut fugiat nam esse.\nNemo omnis non saepe voluptas quae non.\nRem mollitia unde.\nIllo illo non sunt ut delectus omnis facere accusamus.", "Beatae similique distinctio maiores natus architecto molestiae recusandae.", 20L, false, "FTPBordersClothing", 38L },
                    { 24L, new Guid("b7b48e2e-2975-cef4-5a6d-b2f85b9dee79"), new DateTime(2021, 6, 17, 12, 26, 32, 980, DateTimeKind.Unspecified).AddTicks(7588), 1L, "Modi voluptatum aut et minus sed corporis atque.\nOdit id deserunt sed dicta et.\nRepellendus labore itaque cumque autem deleniti ut.\nAt mollitia error dignissimos quo incidunt fuga optio.", "Accusamus quo et fugit.", 58L, false, "HighwayextendGuinea-Bissau", 14L },
                    { 25L, new Guid("f64aaeec-eb08-1034-10c6-795ef0189132"), new DateTime(2022, 1, 28, 14, 25, 11, 576, DateTimeKind.Unspecified).AddTicks(6305), 2L, "Doloremque expedita nisi.\nEt voluptas et odio.\nCommodi minima maxime beatae est dolorum veniam debitis praesentium dolor.", "Iure eos omnis eos assumenda dolorem.", 33L, false, "Functionalityfirewall", 48L },
                    { 26L, new Guid("1399410e-0bed-f3b6-3343-156d8eeefde4"), new DateTime(2021, 10, 1, 21, 22, 7, 929, DateTimeKind.Unspecified).AddTicks(9081), 5L, "Aliquam magnam quis iure et.", "Occaecati enim maiores nemo doloribus deleniti sint et.", 19L, false, "innovateHealth, Shoes & Home", 36L },
                    { 27L, new Guid("a95cdcf4-d88d-45a0-5abf-9f64c601dbdb"), new DateTime(2021, 3, 11, 7, 9, 12, 88, DateTimeKind.Unspecified).AddTicks(923), 2L, "Accusantium accusamus est nulla nemo aut beatae iste rem.\nDolorem sequi consectetur.\nMinus eum minus perferendis.", "Repellat ut tenetur est eius possimus dolorem voluptatem eius et.", 3L, false, "ChiefGorgeous Steel FishmaximizedSoft", 21L },
                    { 28L, new Guid("fd4893ed-eba1-4bd9-8e19-3fcaa60334bc"), new DateTime(2021, 10, 15, 20, 15, 36, 186, DateTimeKind.Unspecified).AddTicks(8021), 2L, "Quia quia maiores aliquam.\nNumquam aliquid corrupti distinctio.", "Voluptatem odio provident.", 16L, false, "auxiliaryturquoiseGroupmulti-byte", 43L },
                    { 29L, new Guid("539f6ff9-a14a-cb58-311b-d197543466a0"), new DateTime(2022, 1, 30, 18, 58, 24, 273, DateTimeKind.Unspecified).AddTicks(1186), 4L, "Reprehenderit sint non perferendis suscipit.\nLaudantium fugiat nobis.\nCumque dolorem adipisci aut eligendi ea.\nVoluptatem iure reiciendis consectetur voluptatem quaerat voluptates.", "Qui velit soluta.", 92L, false, "BridgeCustomersuperstructure", 25L },
                    { 30L, new Guid("2c05caa7-6520-7759-3534-e08bcffbd931"), new DateTime(2021, 7, 11, 19, 51, 47, 631, DateTimeKind.Unspecified).AddTicks(7658), 4L, "Et et soluta quos id unde possimus cupiditate debitis.", "Natus dolor nostrum est aut consequuntur aliquam dolorum.", 66L, false, "indexBedfordshire", 45L },
                    { 31L, new Guid("be81d2b8-2eb3-2131-d150-60100fca6f60"), new DateTime(2021, 11, 9, 8, 20, 27, 133, DateTimeKind.Unspecified).AddTicks(6651), 2L, "Quod facere distinctio.", "Et est rem veniam et ut libero sunt eum in.", 87L, false, "WoninvoiceHandcrafted Soft Bikeusers", 43L }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 2L, new DateTime(2021, 5, 11, 18, 20, 16, 57, DateTimeKind.Unspecified).AddTicks(1242), 3L, false, "Sit aut voluptatem soluta ad unde architecto vero.", 40L },
                    { 3L, new DateTime(2022, 1, 10, 13, 51, 59, 266, DateTimeKind.Unspecified).AddTicks(6152), 3L, false, "Et veniam facere aut natus doloremque officiis quam corrupti.", 41L },
                    { 4L, new DateTime(2021, 4, 4, 16, 36, 42, 824, DateTimeKind.Unspecified).AddTicks(8395), 5L, false, "Sunt explicabo non reprehenderit.", 29L },
                    { 5L, new DateTime(2021, 3, 13, 3, 44, 1, 343, DateTimeKind.Unspecified).AddTicks(1931), 5L, false, "Qui itaque ut nam ex aspernatur quia architecto ullam vero.", 6L },
                    { 6L, new DateTime(2021, 7, 26, 11, 25, 58, 261, DateTimeKind.Unspecified).AddTicks(2647), 2L, false, "Neque ratione vero quas soluta voluptates aut quia sed.", 18L },
                    { 7L, new DateTime(2021, 10, 12, 13, 36, 59, 124, DateTimeKind.Unspecified).AddTicks(6455), 3L, false, "Blanditiis unde totam non laborum eveniet eum repudiandae.", 19L },
                    { 8L, new DateTime(2021, 12, 25, 22, 34, 0, 538, DateTimeKind.Unspecified).AddTicks(3831), 2L, false, "Recusandae unde nisi consectetur.", 48L },
                    { 9L, new DateTime(2021, 12, 20, 6, 12, 33, 503, DateTimeKind.Unspecified).AddTicks(9097), 5L, false, "Id recusandae vel provident illo.", 12L },
                    { 10L, new DateTime(2021, 6, 10, 20, 28, 15, 315, DateTimeKind.Unspecified).AddTicks(4147), 5L, false, "Ea eveniet totam fugiat qui accusamus.", 28L },
                    { 11L, new DateTime(2021, 9, 23, 6, 29, 35, 43, DateTimeKind.Unspecified).AddTicks(3703), 4L, false, "Inventore veritatis et vel et omnis.", 16L },
                    { 12L, new DateTime(2021, 2, 25, 8, 25, 28, 958, DateTimeKind.Unspecified).AddTicks(7833), 1L, false, "Perferendis mollitia rerum explicabo aliquam delectus.", 28L },
                    { 13L, new DateTime(2021, 3, 31, 15, 59, 55, 366, DateTimeKind.Unspecified).AddTicks(8058), 4L, false, "Velit reiciendis impedit sed.", 49L }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 14L, new DateTime(2021, 11, 20, 7, 52, 20, 253, DateTimeKind.Unspecified).AddTicks(1741), 1L, false, "Ut soluta illum ea nostrum.", 48L },
                    { 15L, new DateTime(2021, 7, 5, 23, 30, 27, 897, DateTimeKind.Unspecified).AddTicks(8429), 2L, false, "Sed placeat voluptatibus facere blanditiis natus expedita commodi consequatur.", 49L },
                    { 16L, new DateTime(2021, 3, 20, 0, 24, 54, 315, DateTimeKind.Unspecified).AddTicks(6935), 2L, false, "Aliquid ea saepe corrupti illo vitae.", 19L },
                    { 17L, new DateTime(2021, 6, 7, 14, 50, 19, 143, DateTimeKind.Unspecified).AddTicks(3887), 4L, false, "Impedit recusandae quia.", 36L },
                    { 18L, new DateTime(2021, 9, 6, 9, 48, 46, 878, DateTimeKind.Unspecified).AddTicks(9307), 5L, false, "Voluptatem ab illo voluptatem ea.", 22L },
                    { 19L, new DateTime(2021, 3, 22, 10, 57, 36, 96, DateTimeKind.Unspecified).AddTicks(9700), 5L, false, "Quam illo ipsum dolores nam rem temporibus aut sit blanditiis.", 25L },
                    { 20L, new DateTime(2021, 10, 8, 6, 24, 22, 535, DateTimeKind.Unspecified).AddTicks(5098), 5L, false, "Pariatur molestiae et quod enim qui dolore debitis aut impedit.", 26L },
                    { 21L, new DateTime(2021, 5, 7, 21, 57, 25, 148, DateTimeKind.Unspecified).AddTicks(1174), 2L, false, "Ad rerum rerum itaque vitae aspernatur distinctio.", 17L },
                    { 22L, new DateTime(2021, 12, 7, 15, 31, 15, 432, DateTimeKind.Unspecified).AddTicks(1791), 3L, false, "Labore qui aspernatur aliquid adipisci.", 11L },
                    { 23L, new DateTime(2021, 7, 2, 18, 54, 43, 736, DateTimeKind.Unspecified).AddTicks(9580), 4L, false, "Quia est nesciunt.", 35L },
                    { 24L, new DateTime(2021, 7, 24, 16, 35, 49, 277, DateTimeKind.Unspecified).AddTicks(6747), 3L, false, "Ut ipsa praesentium harum minus voluptatem ut fugiat.", 21L },
                    { 25L, new DateTime(2021, 4, 10, 2, 36, 34, 34, DateTimeKind.Unspecified).AddTicks(9891), 3L, false, "Assumenda corporis unde numquam quas reprehenderit aperiam cum.", 9L },
                    { 26L, new DateTime(2021, 9, 13, 8, 57, 5, 814, DateTimeKind.Unspecified).AddTicks(5184), 3L, false, "Asperiores omnis ut ipsam omnis temporibus ut.", 14L },
                    { 27L, new DateTime(2021, 3, 19, 12, 5, 45, 756, DateTimeKind.Unspecified).AddTicks(5838), 1L, false, "Quaerat facere odit.", 32L },
                    { 28L, new DateTime(2021, 7, 31, 3, 40, 22, 142, DateTimeKind.Unspecified).AddTicks(4105), 4L, false, "Ut nobis nam repellendus eum.", 41L },
                    { 29L, new DateTime(2021, 2, 20, 0, 57, 35, 253, DateTimeKind.Unspecified).AddTicks(8009), 5L, false, "Veniam est voluptates natus perferendis tempora earum rerum.", 49L },
                    { 30L, new DateTime(2021, 8, 17, 19, 45, 54, 291, DateTimeKind.Unspecified).AddTicks(9401), 2L, false, "Deserunt et enim tempora vel.", 10L },
                    { 31L, new DateTime(2021, 9, 11, 10, 11, 6, 964, DateTimeKind.Unspecified).AddTicks(1993), 2L, false, "Omnis hic et necessitatibus iste magni.", 44L }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[,]
                {
                    { 2L, new DateTime(2021, 11, 7, 2, 32, 39, 477, DateTimeKind.Unspecified).AddTicks(7418), 3L, "Quaerat voluptas debitis.\nSoluta harum voluptatem quam reprehenderit.\nEt ut dolor dolorem minima ea.\nDicta cum quo vel error quis delectus.", false, false, 1, 42L, new Guid("783eb20f-a38c-9c37-d8d6-466fbb77b46c"), "Vel voluptatem temporibus ducimus iste quibusdam voluptatibus quisquam voluptatem." },
                    { 3L, new DateTime(2022, 1, 6, 3, 44, 48, 680, DateTimeKind.Unspecified).AddTicks(7758), 2L, "Eos cumque eligendi qui voluptates.\nVitae eum omnis sit magni harum deserunt.\nPraesentium ducimus quia magni rem enim.\nAlias maiores qui similique commodi dolores explicabo.\nPerspiciatis et repellendus pariatur ipsum asperiores voluptatem accusantium error.", false, true, 1, 36L, new Guid("db2e9434-2d8d-5b2d-b5f8-165defff48cc"), "Omnis rem vero quisquam quisquam." },
                    { 4L, new DateTime(2021, 2, 26, 9, 16, 46, 237, DateTimeKind.Unspecified).AddTicks(3257), 1L, "Dolor nihil esse odio quam.\nAssumenda et et dolore non est totam in aliquid.\nAb quia at saepe omnis ut quam eos nemo repellendus.\nVel neque impedit aliquam vero provident quidem iure.", false, false, 1, 32L, new Guid("6ac36ed7-cb50-216c-173a-8972101ccdbc"), "Voluptatibus ipsum aut amet." },
                    { 5L, new DateTime(2021, 8, 13, 14, 27, 55, 275, DateTimeKind.Unspecified).AddTicks(8433), 3L, "Aut voluptas dolor dignissimos illo et illo soluta ut.\nNon commodi perferendis nemo dolorum impedit assumenda esse dolores quod.", false, true, 1, 31L, new Guid("5d38c045-478f-fd15-8e3c-6e570b01fb64"), "Aspernatur repellat quas molestiae earum est molestiae adipisci blanditiis." },
                    { 6L, new DateTime(2021, 7, 21, 4, 28, 38, 930, DateTimeKind.Unspecified).AddTicks(1596), 5L, "Culpa sunt et omnis.", false, true, 0, 36L, new Guid("577e995a-6147-9ae8-342d-332cafb298dd"), "Repudiandae aut ex sunt excepturi vero cumque." },
                    { 7L, new DateTime(2021, 6, 19, 12, 56, 48, 635, DateTimeKind.Unspecified).AddTicks(8079), 5L, "Unde quia tenetur non.\nSed dolor dolore dolore deserunt.\nDolore et error error neque est porro.\nOmnis dolorem qui.\nEos hic sint quos in rerum est.", false, true, 0, 34L, new Guid("2faee5e5-fc3b-66f0-554d-2bdb158a6d9a"), "Ipsum quia ratione." },
                    { 8L, new DateTime(2021, 3, 15, 7, 3, 22, 371, DateTimeKind.Unspecified).AddTicks(9042), 3L, "Sunt voluptatibus voluptas impedit animi est natus quia.\nId dolorum earum error ut.\nFacilis et expedita amet.", false, true, 1, 7L, new Guid("5012631b-d290-eee2-22f8-2e3c26993ad0"), "Adipisci rem quasi." },
                    { 9L, new DateTime(2021, 9, 2, 20, 4, 26, 181, DateTimeKind.Unspecified).AddTicks(8260), 5L, "Illo qui culpa inventore itaque soluta.", false, true, 0, 49L, new Guid("8cf67f63-9dcc-6434-4cf9-4d44eebb589f"), "A enim necessitatibus." },
                    { 10L, new DateTime(2021, 5, 20, 1, 56, 1, 410, DateTimeKind.Unspecified).AddTicks(2828), 5L, "Magnam perferendis quia fugit quasi molestiae sunt.\nEligendi quo facere non deleniti eum omnis est.\nPariatur quisquam doloremque voluptatem doloremque iure impedit.\nHarum alias aut quod praesentium commodi.", false, true, 1, 36L, new Guid("ebd2bbec-06d2-87a1-c26c-05f6971eef5b"), "Expedita rerum laboriosam libero omnis sunt ullam sit quisquam veniam." },
                    { 11L, new DateTime(2021, 12, 23, 9, 52, 15, 483, DateTimeKind.Unspecified).AddTicks(699), 4L, "Dolores aut quibusdam eveniet quasi.\nEst consectetur aut numquam id similique veniam numquam quo.", false, true, 1, 18L, new Guid("feab9b8e-258e-9303-86a9-c80858804a2f"), "Facere distinctio repudiandae vel quo laudantium aut dolores tempore nemo." },
                    { 12L, new DateTime(2021, 2, 11, 18, 7, 46, 821, DateTimeKind.Unspecified).AddTicks(5176), 4L, "Fugit rem distinctio.\nSed ducimus accusantium voluptatibus quam.", false, true, 1, 24L, new Guid("09d946af-3635-5485-860d-415e002a6a73"), "Rem sed vel quo beatae aliquid sit eius corrupti eum." },
                    { 13L, new DateTime(2021, 6, 6, 5, 10, 57, 833, DateTimeKind.Unspecified).AddTicks(9112), 2L, "Fugit corporis aut officia sunt ut.", false, false, 1, 43L, new Guid("ebcfff1a-7791-9197-2ab2-7ef69f6d99c3"), "Iure et sit provident numquam." },
                    { 14L, new DateTime(2021, 4, 26, 17, 31, 48, 402, DateTimeKind.Unspecified).AddTicks(8076), 5L, "Corporis eius incidunt et.\nEst eum voluptates nihil quo ut fugiat.", false, false, 1, 39L, new Guid("5b229e00-871f-bf21-b1d9-52a2e6855bf8"), "Eveniet voluptatem vel." },
                    { 15L, new DateTime(2021, 9, 8, 3, 47, 5, 853, DateTimeKind.Unspecified).AddTicks(2364), 4L, "In voluptas consequuntur mollitia officiis.\nEligendi fugiat sapiente eum ut id.\nQuasi a dicta qui est quod et voluptatem.\nMaiores laudantium et rerum molestiae voluptatum.\nAmet rerum suscipit fugiat autem tempora quas aut.", false, false, 1, 3L, new Guid("15c28b10-de58-91c2-dbe8-b6715c506d3c"), "Et nisi dolores." },
                    { 16L, new DateTime(2021, 7, 8, 15, 44, 36, 222, DateTimeKind.Unspecified).AddTicks(8067), 2L, "Voluptas voluptas blanditiis beatae itaque aperiam quo ab sint doloribus.", false, false, 0, 24L, new Guid("24d03f92-26e5-4863-c801-a2a50dcf213d"), "Praesentium aspernatur dolorum iusto aliquid ea." },
                    { 17L, new DateTime(2021, 11, 11, 11, 58, 57, 329, DateTimeKind.Unspecified).AddTicks(7505), 4L, "Est fugiat vel magni sunt sunt quia sit exercitationem vitae.\nUt qui commodi.\nSint cupiditate non ab consequatur.", false, false, 1, 31L, new Guid("c0f2527e-dc2d-fbb8-4561-63aacb2847e7"), "Fugiat esse tempora." },
                    { 18L, new DateTime(2021, 9, 25, 13, 56, 39, 281, DateTimeKind.Unspecified).AddTicks(9543), 4L, "Quas perspiciatis cumque eos asperiores magnam est.\nSimilique vel fugiat occaecati perferendis aliquid velit voluptates sit aliquam.", false, false, 1, 10L, new Guid("d9c7564a-8186-802a-836b-16499d2a5739"), "Quo autem consequatur minima minus laborum inventore." },
                    { 19L, new DateTime(2021, 9, 29, 8, 52, 58, 892, DateTimeKind.Unspecified).AddTicks(6229), 1L, "Deleniti provident in ut consectetur quo est.\nEarum error adipisci odio molestias.", false, false, 1, 16L, new Guid("c7f1a22b-7d31-750c-635d-baab298b9f1d"), "Quos cum enim non impedit magni accusamus sed est quisquam." },
                    { 20L, new DateTime(2021, 9, 30, 23, 44, 52, 98, DateTimeKind.Unspecified).AddTicks(3862), 3L, "Voluptatem mollitia consequatur ad aut quod et.\nIllo laboriosam dignissimos eaque recusandae eligendi suscipit voluptatem.", false, false, 1, 35L, new Guid("fcb4da62-2c1a-004a-b019-061891d8cce9"), "Doloremque qui dignissimos mollitia nihil similique eaque." },
                    { 21L, new DateTime(2021, 11, 29, 5, 27, 17, 373, DateTimeKind.Unspecified).AddTicks(2777), 1L, "Quam voluptas animi.\nEt doloribus qui non.\nSed quo ipsum ipsum et officia.", false, true, 0, 40L, new Guid("75464f24-58b5-719a-b43a-a9c62d6ce1cf"), "Cum modi beatae." },
                    { 22L, new DateTime(2021, 9, 23, 17, 9, 37, 240, DateTimeKind.Unspecified).AddTicks(6448), 3L, "Modi numquam voluptates enim quae.\nProvident est eos culpa ea et assumenda quod.\nNostrum vel fuga et itaque aliquam ut.\nVelit magni nam non quo aliquid quam adipisci odio.\nAliquid officiis est earum.", false, false, 0, 16L, new Guid("8750f2c2-b0b4-77f5-fe19-4887df46cafa"), "Est aspernatur maiores at." },
                    { 23L, new DateTime(2021, 2, 25, 3, 44, 29, 677, DateTimeKind.Unspecified).AddTicks(4590), 4L, "Quo aliquid ea nemo sint deleniti eveniet impedit deleniti.\nAsperiores sit sunt.\nRerum qui perferendis quas quia nemo repellat molestiae dignissimos.", false, false, 1, 44L, new Guid("b6f8d041-7b9c-122d-c1fd-f4ba22ce357d"), "Iure ex dolores atque quidem accusamus ea delectus." },
                    { 24L, new DateTime(2021, 2, 26, 1, 21, 9, 442, DateTimeKind.Unspecified).AddTicks(3892), 4L, "Similique quis distinctio fugiat sapiente temporibus voluptatum nam id sed.\nIllum saepe rerum qui dicta iste nesciunt dolorem natus.\nEst id repellat.", false, false, 0, 34L, new Guid("87484f17-37bf-2700-470b-e5f4de2f0478"), "Consequatur reprehenderit reprehenderit veritatis assumenda doloremque illo error officiis quam." },
                    { 25L, new DateTime(2021, 4, 1, 10, 11, 44, 838, DateTimeKind.Unspecified).AddTicks(5061), 5L, "Nam neque et eos quo qui fugiat ipsum.\nVelit maxime rerum facilis voluptas eum aut dignissimos dolorem tempora.\nExpedita rerum sint debitis.\nVelit natus impedit doloribus pariatur.\nEt quia et explicabo error nobis et iste quae.", false, false, 1, 9L, new Guid("1834d222-2085-5ce2-fa9b-c1f9f61d75fe"), "Hic eveniet et ratione repellat et possimus qui amet." }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "IsPublic", "Language", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[,]
                {
                    { 26L, new DateTime(2021, 3, 14, 19, 21, 26, 123, DateTimeKind.Unspecified).AddTicks(3589), 2L, "Quis sed laborum dolor iusto.\nQuibusdam error aperiam assumenda eum sint rem consequatur.", false, true, 0, 30L, new Guid("442d98b5-5801-bd8c-42fe-ee7b20a75e78"), "Culpa quae ut maiores animi soluta." },
                    { 27L, new DateTime(2021, 8, 3, 4, 12, 38, 995, DateTimeKind.Unspecified).AddTicks(8768), 4L, "Mollitia et et.\nAut nisi recusandae quis.\nVero nisi tempora eum atque ullam pariatur perferendis impedit eaque.", false, false, 0, 3L, new Guid("89b9f25d-91df-e4a1-50f0-9a1be6f76340"), "Sint veritatis quis magni debitis officia." },
                    { 28L, new DateTime(2021, 8, 30, 5, 36, 12, 623, DateTimeKind.Unspecified).AddTicks(5230), 3L, "Velit ducimus modi non quae saepe quasi.\nHic voluptatem eos a quia accusamus ad.\nIn molestias facere natus.", false, false, 0, 47L, new Guid("3d831dfe-908f-125e-cbac-b04502c76898"), "Pariatur sit et aspernatur et." },
                    { 29L, new DateTime(2022, 1, 24, 9, 7, 41, 313, DateTimeKind.Unspecified).AddTicks(9484), 2L, "Aut harum quia provident assumenda dolor consectetur animi.", false, true, 0, 12L, new Guid("e589d421-f21b-7787-2419-08178a8966ec"), "Nostrum nam odit placeat officiis quo minima iusto et." },
                    { 30L, new DateTime(2021, 12, 13, 22, 14, 37, 54, DateTimeKind.Unspecified).AddTicks(4097), 3L, "Animi reiciendis temporibus quos quasi molestias.\nEst delectus non totam rerum ea in ut.\nQuidem quia voluptate sit soluta consectetur nulla fugiat.\nPerferendis cupiditate ut.", false, true, 0, 15L, new Guid("aca62579-431b-6278-a80f-7c56f3697330"), "Necessitatibus consequatur fuga et voluptatem quisquam dolor commodi." },
                    { 31L, new DateTime(2021, 5, 18, 1, 53, 31, 265, DateTimeKind.Unspecified).AddTicks(2110), 5L, "Voluptatibus est et.\nUt sapiente maxime quisquam minima laboriosam architecto eos deserunt temporibus.\nIncidunt nesciunt et qui molestias tempora ipsum voluptatem dolor sint.", false, false, 1, 26L, new Guid("09744f50-eb74-430b-dd48-e4d10071cb95"), "Quia velit sunt et qui et beatae qui." },
                    { 32L, new DateTime(2022, 1, 23, 17, 32, 0, 682, DateTimeKind.Unspecified).AddTicks(8054), 4L, "Tempora earum eum consequatur qui laudantium sapiente.\nDolorem aliquam vel similique enim blanditiis.", false, true, 1, 9L, new Guid("1658e0f9-f012-f5b5-c923-0b3be8cdf8f2"), "Et illo tempore." },
                    { 33L, new DateTime(2021, 10, 4, 12, 41, 16, 264, DateTimeKind.Unspecified).AddTicks(5219), 1L, "Ut aut sed magnam.\nUt explicabo rerum ut assumenda quasi cupiditate.\nVero quidem modi libero.\nAutem ut architecto qui exercitationem rem praesentium odit.", false, false, 0, 50L, new Guid("d3ba82a4-bca1-80b7-27d4-68d4b2cc09cb"), "Expedita officia porro." },
                    { 34L, new DateTime(2021, 12, 21, 6, 6, 11, 370, DateTimeKind.Unspecified).AddTicks(7177), 4L, "In aliquam accusantium aut qui odio quis et nihil.", false, false, 0, 4L, new Guid("8007b35d-ddea-5fc3-49be-9c7148fea0ab"), "Veniam qui fugit et dolor voluptates deserunt odit dolores." },
                    { 35L, new DateTime(2021, 8, 8, 0, 12, 40, 830, DateTimeKind.Unspecified).AddTicks(5547), 5L, "Exercitationem nam nihil officia autem tenetur qui voluptas quam asperiores.", false, true, 0, 51L, new Guid("22257253-54fb-bb77-067a-6dfa33c489fe"), "Aut magni minima consectetur omnis." },
                    { 36L, new DateTime(2021, 5, 12, 16, 56, 24, 241, DateTimeKind.Unspecified).AddTicks(2443), 2L, "Veritatis officia labore.", false, true, 0, 7L, new Guid("e61726a0-2803-7fd3-3506-7314fe6ad52b"), "Neque excepturi labore impedit saepe." },
                    { 37L, new DateTime(2021, 2, 20, 8, 55, 35, 874, DateTimeKind.Unspecified).AddTicks(5516), 3L, "Sapiente ut sed esse quia sed et molestiae repellat aut.\nMaiores nam quidem.\nCum labore aut.\nDicta id vitae saepe molestiae perferendis debitis.\nQuia nihil voluptatem enim hic voluptates modi corrupti voluptas voluptas.", false, true, 0, 15L, new Guid("5bda3aa7-431c-1795-5b04-be168e058b33"), "Ducimus vel a." },
                    { 38L, new DateTime(2021, 6, 5, 13, 3, 57, 833, DateTimeKind.Unspecified).AddTicks(7617), 2L, "Dignissimos ratione ad.", false, false, 1, 20L, new Guid("f852a520-beff-e804-6814-d8ae520e542b"), "Natus aut sunt sint consequatur quibusdam." },
                    { 39L, new DateTime(2021, 6, 17, 11, 2, 30, 530, DateTimeKind.Unspecified).AddTicks(5371), 1L, "Vero occaecati enim.", false, false, 1, 26L, new Guid("3792ddc0-f22a-b723-c596-ac69fd330d51"), "Quidem sit sint et ea earum non animi." },
                    { 40L, new DateTime(2021, 12, 26, 14, 9, 57, 587, DateTimeKind.Unspecified).AddTicks(4617), 4L, "Veritatis voluptates quis vitae consequatur.", false, true, 0, 37L, new Guid("942d2556-0b4e-1ebb-5ac6-97bf34347e45"), "Maxime enim deleniti recusandae." },
                    { 41L, new DateTime(2021, 5, 15, 7, 31, 40, 404, DateTimeKind.Unspecified).AddTicks(8593), 5L, "Quia sunt est voluptatem autem quibusdam.\nNon eum aut.", false, true, 0, 26L, new Guid("9fd04355-46bf-6982-d270-3a6154e49936"), "Consequatur voluptatem vel eum quia." },
                    { 42L, new DateTime(2021, 2, 20, 8, 23, 25, 313, DateTimeKind.Unspecified).AddTicks(3062), 3L, "Quisquam quas ullam voluptatibus tempora qui corporis.\nVoluptatem non quis ipsa quis.\nLabore officiis incidunt illum aut assumenda molestiae reprehenderit et natus.\nSed voluptatem quia dicta consequatur accusamus.\nEt praesentium dolorum voluptas doloremque asperiores ea dolor.", false, true, 0, 32L, new Guid("c7b78e36-5830-d685-3d00-958579d25a85"), "Nisi ut voluptas." },
                    { 43L, new DateTime(2022, 1, 14, 1, 18, 38, 482, DateTimeKind.Unspecified).AddTicks(734), 4L, "Blanditiis adipisci enim culpa.\nSuscipit laborum omnis magnam animi at pariatur architecto quasi.\nEt eum exercitationem veritatis nostrum esse.\nEx ea veritatis laudantium aut.\nQuas eaque odit aut qui.", false, false, 0, 2L, new Guid("6c6958d9-cdf2-ceb9-04de-6dcf4d705236"), "Hic nihil ex labore recusandae quibusdam velit ipsa." },
                    { 44L, new DateTime(2021, 11, 13, 23, 46, 18, 373, DateTimeKind.Unspecified).AddTicks(1948), 2L, "Quos aut qui autem.\nMolestiae sunt omnis placeat optio neque deserunt sunt.", false, false, 0, 33L, new Guid("3a7f4531-f7bb-a978-c6eb-188382dd8eee"), "Consequatur consequuntur qui assumenda eum et odio." },
                    { 45L, new DateTime(2021, 6, 14, 9, 7, 56, 122, DateTimeKind.Unspecified).AddTicks(4781), 2L, "Dolor nemo enim porro reprehenderit incidunt unde ipsam nihil.\nNon enim quaerat sit aliquam ea quas laborum quas quas.\nSit et cupiditate eos ex.\nPerferendis consectetur necessitatibus.\nOptio ea quaerat illo est illum placeat qui.", false, false, 1, 44L, new Guid("dabb0f78-5fa8-92a2-75cb-5b691ddf4106"), "Ut a dicta." },
                    { 46L, new DateTime(2021, 7, 23, 22, 39, 11, 192, DateTimeKind.Unspecified).AddTicks(3007), 2L, "Delectus id officia.\nNesciunt eos dolorem velit reiciendis id incidunt sit consequatur.\nQuo aliquam consequuntur quaerat quas consequatur.\nIllo qui quasi saepe esse odio qui est.\nAutem veritatis in perspiciatis culpa optio.", false, true, 0, 12L, new Guid("5a98cd58-3b08-b13c-7a3f-27053ff6ed2f"), "Non perspiciatis perspiciatis corporis recusandae." },
                    { 47L, new DateTime(2021, 8, 28, 7, 52, 18, 941, DateTimeKind.Unspecified).AddTicks(911), 3L, "Tempora dolorem possimus voluptatem ut sit voluptates.\nQuae dolor voluptatum.\nEaque consequuntur iste consequatur amet quisquam voluptatem.\nCumque autem suscipit harum quaerat libero tempore eum ratione.", false, true, 1, 44L, new Guid("941a7992-90f8-faf3-0704-7f258db0b060"), "Sit praesentium sint cupiditate." },
                    { 48L, new DateTime(2021, 6, 26, 14, 10, 40, 40, DateTimeKind.Unspecified).AddTicks(9027), 5L, "Consequuntur consequatur incidunt nisi vitae ut in ad et.\nId eveniet quia animi.\nEt sint eveniet consequuntur.\nTemporibus nesciunt similique quibusdam dolor et.\nVoluptates sed atque est perspiciatis vel sint rerum.", false, false, 1, 25L, new Guid("8e866f16-8fd4-f066-ea83-fe805e6a597e"), "Ut assumenda sapiente illum." },
                    { 49L, new DateTime(2021, 10, 8, 6, 19, 8, 436, DateTimeKind.Unspecified).AddTicks(264), 3L, "Inventore sint eligendi a ut voluptatem ab.", false, true, 1, 4L, new Guid("8a35047c-e212-6638-d3b6-921fe9742fa6"), "Ad voluptas ut ut repellat possimus." },
                    { 50L, new DateTime(2022, 1, 15, 21, 9, 59, 47, DateTimeKind.Unspecified).AddTicks(6412), 2L, "Non deleniti et earum et deleniti quibusdam et labore vel.\nFacilis ea et dolor odit sunt explicabo.\nMolestias et ad error eius minima maxime ipsum.\nConsequatur et nisi enim.", false, false, 0, 17L, new Guid("92d72482-7b2e-1925-c6e6-9d5ac19e067b"), "Non dolor aut." },
                    { 51L, new DateTime(2022, 1, 21, 12, 51, 44, 12, DateTimeKind.Unspecified).AddTicks(9579), 5L, "Eius voluptatem quis.\nDeleniti inventore voluptas qui quod libero explicabo.\nDoloribus minima dolore fuga molestiae doloremque vel sed.\nOmnis odio et eum iure sed ratione amet.\nConsectetur incidunt omnis ut est aut placeat.", false, false, 1, 26L, new Guid("ac544cb7-acfb-09b2-8550-2f752ce01b9c"), "Molestias molestiae voluptas est unde in earum doloremque sed." }
                });

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
                    { 4L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 75L, false },
                    { 4L, 33L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 29L, false },
                    { 6L, 8L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 16L, false },
                    { 6L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 81L, false },
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
                    { 9L, 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 54L, false },
                    { 10L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 20L, false },
                    { 10L, 28L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 43L, false },
                    { 10L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 58L, false },
                    { 11L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 18L, false },
                    { 11L, 30L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 64L, false },
                    { 11L, 31L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 28L, false },
                    { 12L, 17L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 9L, false },
                    { 12L, 21L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L, false },
                    { 12L, 24L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 73L, false },
                    { 12L, 27L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 13L, false },
                    { 13L, 22L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 67L, false },
                    { 13L, 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 69L, false }
                });

            migrationBuilder.InsertData(
                table: "AppTags",
                columns: new[] { "AppId", "TagId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 14L, 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 6L, false },
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

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "IsDeleted", "Name", "OrganizationId", "OwnerId" },
                values: new object[,]
                {
                    { 2L, 57L, new DateTime(2021, 2, 26, 18, 16, 3, 183, DateTimeKind.Unspecified).AddTicks(3398), 4L, "Iste consequatur id consequatur ab aliquam.\nCumque odit libero blanditiis explicabo dicta molestiae.\nTotam exercitationem labore blanditiis aliquam libero facilis.", "Aut doloremque consequatur totam nam dolorem molestiae reiciendis vel.", false, "depositFrozenPassage", 9L, 5L },
                    { 3L, 91L, new DateTime(2021, 12, 1, 4, 26, 2, 917, DateTimeKind.Unspecified).AddTicks(6885), 2L, "Nesciunt et recusandae quisquam eaque aut.\nHarum id molestiae amet est repudiandae qui provident.\nIn quia reprehenderit.\nTempora omnis minima ea fuga est ipsum dolorum consequatur et.\nOmnis omnis neque qui quam voluptas non.", "Laudantium expedita iure nulla quis asperiores aut deleniti.", false, "programCorporate", 4L, 2L },
                    { 4L, 48L, new DateTime(2021, 2, 8, 16, 17, 36, 847, DateTimeKind.Unspecified).AddTicks(9528), 5L, "Quis non aspernatur ut recusandae beatae.\nDolores aliquid voluptate sapiente placeat inventore fugit dolor.", "Sit mollitia natus sunt maiores.", false, "Rwandacapacitor", 13L, 23L },
                    { 5L, 41L, new DateTime(2021, 12, 8, 15, 10, 52, 856, DateTimeKind.Unspecified).AddTicks(3516), 4L, "Cum ut aspernatur omnis asperiores aut velit.", "Omnis repudiandae repellat ab quibusdam fugiat et beatae.", false, "Outdoors, Books & Computerssecured linedeposit", 5L, 8L },
                    { 6L, 53L, new DateTime(2021, 6, 11, 12, 51, 8, 980, DateTimeKind.Unspecified).AddTicks(2773), 4L, "Amet fugiat inventore et maiores quidem et corporis.\nCommodi voluptates consequuntur et odit aperiam aliquid odit nihil.", "Cumque est aut nulla.", false, "cross-platformSavings Account", 31L, 45L }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "IsDeleted", "Name", "OrganizationId", "OwnerId" },
                values: new object[,]
                {
                    { 7L, 84L, new DateTime(2021, 6, 4, 15, 7, 42, 761, DateTimeKind.Unspecified).AddTicks(9893), 2L, "Dolores velit quos sit voluptate voluptatem et ut eius.", "Incidunt vel eum natus vel deserunt.", false, "Yuan RenminbiInvestment Account", 8L, 7L },
                    { 8L, 52L, new DateTime(2021, 2, 11, 16, 20, 18, 684, DateTimeKind.Unspecified).AddTicks(6932), 1L, "Similique nihil excepturi.\nProvident aut aut accusantium unde sunt corporis id quis.\nLaboriosam excepturi amet doloremque similique iusto.", "Qui sit velit molestiae animi.", false, "web-enabledhard drivecyan", 21L, 6L },
                    { 9L, 24L, new DateTime(2021, 7, 6, 14, 29, 31, 213, DateTimeKind.Unspecified).AddTicks(15), 1L, "Qui officia debitis deleniti quas.", "Ea mollitia suscipit vel est quis corporis sint.", false, "quantifyCambridgeshireBuckinghamshirerevolutionize", 3L, 46L },
                    { 10L, 72L, new DateTime(2021, 10, 14, 3, 15, 47, 596, DateTimeKind.Unspecified).AddTicks(1934), 2L, "Numquam debitis veritatis sed dolor voluptatum est cupiditate ea.\nAut ut optio culpa nobis dolore dolore sit dolorum fugit.\nTempora corrupti tenetur placeat exercitationem quasi.\nQuasi consequuntur quae perspiciatis officia quis nobis nesciunt.\nAutem exercitationem nemo.", "Fuga explicabo qui vel laudantium eum itaque.", false, "connectCustomermaroon", 8L, 20L },
                    { 11L, 18L, new DateTime(2021, 2, 25, 15, 32, 36, 19, DateTimeKind.Unspecified).AddTicks(7524), 4L, "Ea aut qui ut nulla similique vel voluptas eveniet non.\nAccusamus rerum enim ea.\nRepellat sit et.", "Aut esse maiores iure odit.", false, "GlobalDirectProfit-focused", 18L, 20L },
                    { 12L, 86L, new DateTime(2021, 8, 22, 19, 19, 31, 764, DateTimeKind.Unspecified).AddTicks(4136), 2L, "Et quis earum ut omnis aut in.\nDoloribus quia blanditiis nostrum sint.", "Et id et asperiores praesentium id.", false, "communitiesparseLilangeniFactors", 17L, 18L },
                    { 13L, 76L, new DateTime(2021, 4, 27, 23, 33, 33, 473, DateTimeKind.Unspecified).AddTicks(9034), 3L, "Earum in asperiores natus quidem eius eum animi impedit.\nCorrupti harum saepe inventore ad ea libero.\nQui laborum modi.\nLaborum eligendi in quis id animi.\nMaiores atque ut sit.", "Ea quibusdam qui alias quisquam repudiandae.", false, "IsleivoryUser-centric", 29L, 47L },
                    { 14L, 36L, new DateTime(2021, 10, 25, 0, 39, 56, 770, DateTimeKind.Unspecified).AddTicks(5455), 2L, "Cupiditate temporibus corporis nesciunt aliquid et repellendus.\nEst beatae hic ullam ratione voluptatem.", "Occaecati quod suscipit nihil occaecati.", false, "Concreteconnectivoryleverage", 29L, 45L },
                    { 15L, 78L, new DateTime(2021, 5, 6, 21, 4, 26, 13, DateTimeKind.Unspecified).AddTicks(7604), 2L, "Eum qui modi est.\nMolestias nihil eum assumenda sed vel.\nIusto adipisci quia.\nIusto et dolore rerum explicabo mollitia quis autem architecto.\nEx nihil sint architecto ullam molestiae ipsam earum.", "Beatae rem est dolor voluptatem.", false, "ViaexperiencesHandcrafted", 21L, 12L },
                    { 16L, 33L, new DateTime(2021, 10, 25, 16, 34, 37, 38, DateTimeKind.Unspecified).AddTicks(4366), 1L, "Pariatur provident vel voluptatem porro laudantium eligendi qui rerum.\nQuos molestiae ut quia qui possimus deleniti ut.\nIusto architecto quaerat.\nVel nostrum aut.", "Minima est ipsa aut.", false, "AssociateIncredible Wooden CaractuatingInvestor", 2L, 45L },
                    { 17L, 44L, new DateTime(2021, 9, 10, 4, 52, 45, 31, DateTimeKind.Unspecified).AddTicks(6708), 3L, "Occaecati exercitationem architecto.\nAliquid optio officia.\nEt vero repudiandae sequi fugiat et minus.", "Voluptatum incidunt consequatur est quidem recusandae.", false, "Administrator1080pCommunicationsmethodical", 15L, 34L },
                    { 18L, 81L, new DateTime(2021, 12, 25, 14, 52, 32, 541, DateTimeKind.Unspecified).AddTicks(9008), 2L, "Temporibus et vero velit placeat harum quod eius ut dolores.\nNisi ducimus quidem cum dolores earum fugit adipisci in.\nEligendi est et.\nNam vel aspernatur natus necessitatibus.\nSed quae dolore quae corporis debitis incidunt voluptates vel.", "Quidem est et.", false, "transmittingRielPlanner", 6L, 10L },
                    { 19L, 31L, new DateTime(2021, 6, 21, 17, 45, 0, 559, DateTimeKind.Unspecified).AddTicks(3642), 2L, "Rerum expedita nisi tempore omnis.", "Totam ut explicabo consequatur nihil fugiat.", false, "DirectorGlobalLibyan Dinar", 19L, 12L },
                    { 20L, 66L, new DateTime(2021, 9, 16, 19, 3, 11, 210, DateTimeKind.Unspecified).AddTicks(8905), 2L, "Blanditiis qui dolorem natus voluptatem occaecati.\nExpedita omnis et assumenda maxime unde sint maiores nostrum.\nEos architecto unde.\nExplicabo quo reprehenderit quia laudantium harum.\nUt consequatur quisquam eos.", "Quae dolor accusantium adipisci voluptas maxime in nisi.", false, "greyAuto Loan AccountLouisianarich", 6L, 46L },
                    { 21L, 93L, new DateTime(2021, 4, 14, 22, 37, 50, 440, DateTimeKind.Unspecified).AddTicks(5762), 4L, "Et ex nobis necessitatibus expedita enim maxime.\nEt aut nam facere tempore.", "Aut non aperiam nam porro ut ea eaque.", false, "GrovesfeedrebootProduct", 14L, 15L }
                });

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
                    { 7L, 19L, new DateTime(2021, 5, 30, 23, 3, 23, 216, DateTimeKind.Unspecified).AddTicks(5318), 5L, 56L, false },
                    { 7L, 20L, new DateTime(2021, 5, 30, 10, 13, 21, 780, DateTimeKind.Unspecified).AddTicks(3259), 5L, 60L, false },
                    { 8L, 4L, new DateTime(2021, 6, 5, 6, 3, 53, 189, DateTimeKind.Unspecified).AddTicks(5319), 5L, 50L, false },
                    { 8L, 21L, new DateTime(2021, 3, 24, 1, 31, 31, 930, DateTimeKind.Unspecified).AddTicks(7854), 3L, 7L, false },
                    { 8L, 35L, new DateTime(2022, 1, 1, 10, 46, 47, 416, DateTimeKind.Unspecified).AddTicks(5212), 2L, 26L, false },
                    { 9L, 14L, new DateTime(2021, 7, 23, 16, 40, 14, 370, DateTimeKind.Unspecified).AddTicks(6646), 2L, 94L, false },
                    { 10L, 2L, new DateTime(2021, 12, 24, 6, 57, 37, 464, DateTimeKind.Unspecified).AddTicks(9838), 5L, 17L, false },
                    { 10L, 4L, new DateTime(2021, 8, 13, 2, 35, 42, 312, DateTimeKind.Unspecified).AddTicks(751), 1L, 16L, false },
                    { 10L, 12L, new DateTime(2021, 3, 18, 15, 31, 50, 368, DateTimeKind.Unspecified).AddTicks(7428), 1L, 90L, false },
                    { 10L, 40L, new DateTime(2021, 11, 22, 0, 46, 9, 411, DateTimeKind.Unspecified).AddTicks(4132), 2L, 65L, false },
                    { 10L, 43L, new DateTime(2021, 2, 20, 1, 22, 8, 653, DateTimeKind.Unspecified).AddTicks(3736), 5L, 72L, false },
                    { 10L, 45L, new DateTime(2021, 6, 15, 2, 46, 52, 666, DateTimeKind.Unspecified).AddTicks(4357), 3L, 11L, false },
                    { 11L, 21L, new DateTime(2021, 8, 3, 12, 3, 25, 187, DateTimeKind.Unspecified).AddTicks(4810), 5L, 87L, false },
                    { 12L, 22L, new DateTime(2021, 2, 12, 23, 39, 8, 723, DateTimeKind.Unspecified).AddTicks(4631), 3L, 100L, false },
                    { 12L, 26L, new DateTime(2021, 12, 24, 5, 47, 41, 390, DateTimeKind.Unspecified).AddTicks(1757), 2L, 98L, false },
                    { 12L, 40L, new DateTime(2022, 1, 18, 19, 2, 37, 195, DateTimeKind.Unspecified).AddTicks(8667), 4L, 46L, false },
                    { 12L, 50L, new DateTime(2021, 8, 29, 16, 0, 33, 959, DateTimeKind.Unspecified).AddTicks(1533), 1L, 84L, false },
                    { 13L, 11L, new DateTime(2021, 11, 22, 18, 16, 48, 350, DateTimeKind.Unspecified).AddTicks(9483), 2L, 79L, false },
                    { 13L, 20L, new DateTime(2021, 9, 12, 19, 22, 26, 566, DateTimeKind.Unspecified).AddTicks(405), 2L, 31L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 13L, 33L, new DateTime(2021, 3, 7, 7, 59, 0, 965, DateTimeKind.Unspecified).AddTicks(3842), 5L, 20L, false },
                    { 13L, 48L, new DateTime(2021, 4, 29, 1, 43, 34, 213, DateTimeKind.Unspecified).AddTicks(478), 3L, 49L, false },
                    { 14L, 38L, new DateTime(2022, 1, 11, 8, 44, 55, 804, DateTimeKind.Unspecified).AddTicks(7984), 5L, 66L, false },
                    { 14L, 48L, new DateTime(2021, 10, 2, 10, 4, 20, 397, DateTimeKind.Unspecified).AddTicks(6255), 5L, 37L, false },
                    { 15L, 13L, new DateTime(2021, 6, 30, 21, 6, 27, 440, DateTimeKind.Unspecified).AddTicks(9836), 5L, 22L, false },
                    { 15L, 28L, new DateTime(2021, 12, 25, 9, 33, 57, 468, DateTimeKind.Unspecified).AddTicks(5463), 5L, 42L, false },
                    { 15L, 30L, new DateTime(2021, 6, 27, 17, 1, 29, 974, DateTimeKind.Unspecified).AddTicks(7702), 5L, 35L, false },
                    { 15L, 45L, new DateTime(2021, 10, 9, 23, 52, 22, 173, DateTimeKind.Unspecified).AddTicks(4748), 2L, 9L, false },
                    { 16L, 19L, new DateTime(2021, 5, 27, 3, 15, 22, 260, DateTimeKind.Unspecified).AddTicks(7846), 1L, 97L, false },
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
                    { 36L, 31L, new DateTime(2021, 3, 2, 20, 6, 34, 114, DateTimeKind.Unspecified).AddTicks(8678), 5L, 10L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 37L, 17L, new DateTime(2021, 9, 11, 20, 33, 45, 36, DateTimeKind.Unspecified).AddTicks(5796), 1L, 96L, false },
                    { 38L, 23L, new DateTime(2021, 12, 13, 17, 11, 15, 393, DateTimeKind.Unspecified).AddTicks(9246), 4L, 29L, false },
                    { 38L, 26L, new DateTime(2021, 11, 26, 2, 2, 1, 183, DateTimeKind.Unspecified).AddTicks(2259), 2L, 73L, false },
                    { 39L, 11L, new DateTime(2021, 10, 21, 0, 34, 31, 236, DateTimeKind.Unspecified).AddTicks(7246), 1L, 77L, false },
                    { 39L, 18L, new DateTime(2021, 9, 24, 17, 49, 25, 421, DateTimeKind.Unspecified).AddTicks(1343), 3L, 88L, false },
                    { 39L, 28L, new DateTime(2021, 11, 24, 2, 49, 46, 886, DateTimeKind.Unspecified).AddTicks(6133), 5L, 38L, false },
                    { 41L, 42L, new DateTime(2021, 12, 31, 7, 7, 6, 484, DateTimeKind.Unspecified).AddTicks(6698), 2L, 78L, false },
                    { 41L, 51L, new DateTime(2022, 1, 19, 2, 55, 50, 723, DateTimeKind.Unspecified).AddTicks(227), 1L, 59L, false },
                    { 42L, 9L, new DateTime(2021, 6, 24, 22, 23, 31, 719, DateTimeKind.Unspecified).AddTicks(1422), 5L, 48L, false },
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
                    { 50L, 7L, new DateTime(2021, 3, 29, 8, 0, 14, 721, DateTimeKind.Unspecified).AddTicks(2103), 4L, 57L, false },
                    { 51L, 9L, new DateTime(2021, 7, 14, 3, 35, 9, 134, DateTimeKind.Unspecified).AddTicks(95), 4L, 25L, false }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsDeleted", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[,]
                {
                    { 3L, 43L, new DateTime(2021, 5, 2, 19, 58, 43, 511, DateTimeKind.Unspecified).AddTicks(8277), 3L, 825, false, false, null, 44L, 242 },
                    { 4L, 44L, new DateTime(2021, 4, 15, 7, 39, 39, 832, DateTimeKind.Unspecified).AddTicks(5548), 4L, 714, false, true, null, 45L, 168 },
                    { 6L, 36L, new DateTime(2021, 9, 6, 16, 36, 51, 263, DateTimeKind.Unspecified).AddTicks(3373), 1L, 827, false, false, null, 18L, 136 },
                    { 7L, 13L, new DateTime(2021, 5, 18, 20, 30, 16, 105, DateTimeKind.Unspecified).AddTicks(3852), 5L, 745, false, false, null, 34L, 55 },
                    { 8L, 33L, new DateTime(2021, 7, 1, 0, 21, 55, 515, DateTimeKind.Unspecified).AddTicks(3758), 3L, 858, false, false, null, 3L, 324 },
                    { 9L, 13L, new DateTime(2021, 8, 27, 16, 6, 30, 905, DateTimeKind.Unspecified).AddTicks(750), 1L, 613, false, true, null, 40L, 337 },
                    { 10L, 47L, new DateTime(2021, 3, 13, 14, 48, 23, 796, DateTimeKind.Unspecified).AddTicks(8809), 1L, 625, false, false, null, 48L, 177 },
                    { 12L, 13L, new DateTime(2021, 6, 6, 12, 42, 30, 100, DateTimeKind.Unspecified).AddTicks(1705), 1L, 739, false, true, null, 35L, 424 },
                    { 15L, 18L, new DateTime(2021, 8, 8, 8, 25, 42, 279, DateTimeKind.Unspecified).AddTicks(490), 5L, 854, false, false, null, 47L, 30 },
                    { 16L, 30L, new DateTime(2021, 7, 14, 8, 5, 34, 518, DateTimeKind.Unspecified).AddTicks(5505), 3L, 571, false, true, null, 36L, 85 },
                    { 17L, 35L, new DateTime(2021, 5, 25, 13, 46, 27, 478, DateTimeKind.Unspecified).AddTicks(2316), 5L, 937, false, false, null, 16L, 223 },
                    { 18L, 17L, new DateTime(2021, 8, 7, 5, 26, 46, 591, DateTimeKind.Unspecified).AddTicks(6302), 5L, 534, false, false, null, 43L, 445 },
                    { 19L, 21L, new DateTime(2021, 8, 15, 23, 39, 32, 443, DateTimeKind.Unspecified).AddTicks(3908), 4L, 628, false, true, null, 25L, 13 },
                    { 21L, 16L, new DateTime(2021, 4, 24, 14, 20, 26, 871, DateTimeKind.Unspecified).AddTicks(7976), 1L, 596, false, true, null, 20L, 96 }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsDeleted", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[,]
                {
                    { 23L, 10L, new DateTime(2021, 10, 17, 19, 10, 37, 695, DateTimeKind.Unspecified).AddTicks(4132), 2L, 776, false, false, null, 51L, 194 },
                    { 25L, 35L, new DateTime(2021, 8, 14, 4, 36, 46, 590, DateTimeKind.Unspecified).AddTicks(373), 2L, 675, false, true, null, 14L, 408 },
                    { 27L, 28L, new DateTime(2021, 12, 31, 5, 30, 24, 374, DateTimeKind.Unspecified).AddTicks(5166), 1L, 557, false, false, null, 46L, 19 },
                    { 30L, 31L, new DateTime(2021, 5, 1, 18, 56, 4, 448, DateTimeKind.Unspecified).AddTicks(4092), 1L, 647, false, false, null, 51L, 388 },
                    { 33L, 39L, new DateTime(2021, 3, 27, 12, 59, 9, 343, DateTimeKind.Unspecified).AddTicks(2725), 1L, 746, false, false, null, 34L, 164 },
                    { 34L, 45L, new DateTime(2021, 11, 30, 8, 14, 8, 747, DateTimeKind.Unspecified).AddTicks(7873), 2L, 952, false, false, null, 27L, 403 },
                    { 36L, 12L, new DateTime(2022, 1, 2, 18, 0, 19, 199, DateTimeKind.Unspecified).AddTicks(9260), 5L, 620, false, true, null, 29L, 129 },
                    { 37L, 29L, new DateTime(2021, 11, 13, 20, 56, 51, 280, DateTimeKind.Unspecified).AddTicks(2782), 5L, 735, false, true, null, 10L, 406 },
                    { 39L, 50L, new DateTime(2021, 6, 24, 13, 36, 45, 269, DateTimeKind.Unspecified).AddTicks(5607), 4L, 949, false, true, null, 33L, 186 },
                    { 40L, 44L, new DateTime(2021, 8, 5, 20, 21, 19, 50, DateTimeKind.Unspecified).AddTicks(2413), 5L, 553, false, true, null, 38L, 141 },
                    { 41L, 44L, new DateTime(2021, 10, 14, 3, 59, 29, 854, DateTimeKind.Unspecified).AddTicks(7534), 5L, 599, false, true, null, 49L, 108 },
                    { 42L, 12L, new DateTime(2021, 7, 10, 18, 13, 8, 141, DateTimeKind.Unspecified).AddTicks(3199), 4L, 679, false, false, null, 7L, 177 },
                    { 43L, 5L, new DateTime(2021, 5, 16, 9, 48, 5, 496, DateTimeKind.Unspecified).AddTicks(9785), 1L, 817, false, false, null, 12L, 414 },
                    { 45L, 39L, new DateTime(2021, 7, 8, 1, 55, 38, 777, DateTimeKind.Unspecified).AddTicks(4142), 1L, 627, false, true, null, 5L, 208 },
                    { 46L, 19L, new DateTime(2021, 4, 24, 14, 50, 10, 934, DateTimeKind.Unspecified).AddTicks(5417), 5L, 547, false, false, null, 37L, 177 },
                    { 47L, 10L, new DateTime(2021, 6, 23, 6, 33, 47, 750, DateTimeKind.Unspecified).AddTicks(665), 4L, 686, false, true, null, 26L, 187 },
                    { 53L, 50L, new DateTime(2021, 8, 17, 11, 15, 57, 251, DateTimeKind.Unspecified).AddTicks(6898), 5L, 659, false, true, null, 21L, 435 },
                    { 57L, 40L, new DateTime(2021, 10, 13, 7, 0, 11, 813, DateTimeKind.Unspecified).AddTicks(5331), 1L, 525, false, true, null, 14L, 366 },
                    { 58L, 15L, new DateTime(2021, 12, 12, 8, 1, 24, 416, DateTimeKind.Unspecified).AddTicks(6279), 1L, 549, false, true, null, 42L, 486 },
                    { 60L, 50L, new DateTime(2021, 9, 15, 19, 49, 17, 43, DateTimeKind.Unspecified).AddTicks(2846), 3L, 764, false, true, null, 28L, 25 },
                    { 61L, 44L, new DateTime(2021, 6, 20, 4, 37, 21, 162, DateTimeKind.Unspecified).AddTicks(5716), 4L, 563, false, true, null, 16L, 362 },
                    { 62L, 6L, new DateTime(2022, 1, 30, 22, 51, 28, 609, DateTimeKind.Unspecified).AddTicks(4640), 5L, 668, false, false, null, 41L, 469 },
                    { 64L, 33L, new DateTime(2021, 5, 3, 17, 58, 21, 678, DateTimeKind.Unspecified).AddTicks(4552), 2L, 532, false, false, null, 31L, 289 },
                    { 69L, 19L, new DateTime(2021, 6, 4, 22, 39, 8, 214, DateTimeKind.Unspecified).AddTicks(3648), 3L, 961, false, false, null, 3L, 329 },
                    { 71L, 3L, new DateTime(2021, 11, 19, 17, 29, 32, 755, DateTimeKind.Unspecified).AddTicks(219), 5L, 843, false, false, null, 27L, 456 },
                    { 73L, 7L, new DateTime(2021, 4, 17, 11, 35, 22, 258, DateTimeKind.Unspecified).AddTicks(6081), 3L, 711, false, false, null, 11L, 168 },
                    { 77L, 25L, new DateTime(2022, 1, 23, 21, 59, 56, 59, DateTimeKind.Unspecified).AddTicks(1074), 2L, 655, false, true, null, 7L, 369 },
                    { 78L, 2L, new DateTime(2021, 3, 3, 14, 43, 13, 110, DateTimeKind.Unspecified).AddTicks(3744), 4L, 797, false, false, null, 33L, 53 },
                    { 79L, 38L, new DateTime(2021, 4, 11, 18, 16, 21, 69, DateTimeKind.Unspecified).AddTicks(6640), 4L, 642, false, true, null, 19L, 496 },
                    { 80L, 15L, new DateTime(2021, 8, 27, 15, 18, 8, 939, DateTimeKind.Unspecified).AddTicks(5225), 3L, 596, false, true, null, 32L, 52 },
                    { 81L, 18L, new DateTime(2021, 3, 26, 16, 33, 11, 514, DateTimeKind.Unspecified).AddTicks(7001), 1L, 519, false, true, null, 42L, 315 }
                });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "Id", "CourseId", "CourseRole", "CreatedAt", "CreatedBy", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { 2L, 4L, 0, new DateTime(2021, 3, 2, 14, 52, 5, 486, DateTimeKind.Unspecified).AddTicks(7669), 5L, false, 33L },
                    { 3L, 7L, 0, new DateTime(2021, 8, 1, 4, 29, 22, 482, DateTimeKind.Unspecified).AddTicks(4480), 5L, false, 36L },
                    { 4L, 14L, 0, new DateTime(2021, 9, 2, 10, 11, 44, 81, DateTimeKind.Unspecified).AddTicks(8013), 1L, false, 17L },
                    { 5L, 21L, 0, new DateTime(2021, 7, 12, 19, 40, 55, 116, DateTimeKind.Unspecified).AddTicks(6164), 2L, false, 22L },
                    { 6L, 17L, 0, new DateTime(2021, 8, 18, 9, 50, 35, 137, DateTimeKind.Unspecified).AddTicks(1647), 3L, false, 24L },
                    { 7L, 16L, 0, new DateTime(2021, 2, 7, 5, 22, 53, 748, DateTimeKind.Unspecified).AddTicks(2742), 5L, false, 30L },
                    { 8L, 11L, 0, new DateTime(2021, 4, 2, 12, 30, 50, 306, DateTimeKind.Unspecified).AddTicks(5408), 2L, false, 31L },
                    { 9L, 3L, 0, new DateTime(2021, 6, 22, 6, 9, 8, 797, DateTimeKind.Unspecified).AddTicks(1945), 3L, false, 26L },
                    { 10L, 17L, 0, new DateTime(2021, 12, 29, 7, 40, 52, 112, DateTimeKind.Unspecified).AddTicks(5490), 2L, false, 32L },
                    { 11L, 16L, 0, new DateTime(2021, 8, 16, 13, 6, 6, 364, DateTimeKind.Unspecified).AddTicks(1851), 1L, false, 40L },
                    { 12L, 16L, 0, new DateTime(2021, 10, 27, 6, 13, 20, 326, DateTimeKind.Unspecified).AddTicks(1462), 5L, false, 6L },
                    { 14L, 4L, 0, new DateTime(2021, 8, 7, 23, 29, 48, 809, DateTimeKind.Unspecified).AddTicks(7024), 3L, false, 19L },
                    { 15L, 21L, 0, new DateTime(2021, 3, 10, 1, 24, 52, 962, DateTimeKind.Unspecified).AddTicks(8426), 3L, false, 28L },
                    { 16L, 19L, 0, new DateTime(2021, 11, 22, 16, 17, 22, 215, DateTimeKind.Unspecified).AddTicks(8052), 2L, false, 18L },
                    { 17L, 21L, 0, new DateTime(2021, 11, 8, 18, 0, 16, 927, DateTimeKind.Unspecified).AddTicks(5586), 1L, false, 6L },
                    { 18L, 11L, 0, new DateTime(2021, 6, 7, 4, 36, 12, 773, DateTimeKind.Unspecified).AddTicks(1216), 5L, false, 4L },
                    { 19L, 4L, 0, new DateTime(2021, 5, 19, 5, 10, 24, 60, DateTimeKind.Unspecified).AddTicks(2461), 4L, false, 31L },
                    { 20L, 3L, 0, new DateTime(2021, 3, 24, 18, 47, 16, 239, DateTimeKind.Unspecified).AddTicks(6868), 2L, false, 33L },
                    { 21L, 12L, 0, new DateTime(2021, 3, 18, 6, 1, 50, 575, DateTimeKind.Unspecified).AddTicks(5520), 3L, false, 42L },
                    { 22L, 15L, 0, new DateTime(2021, 9, 17, 5, 31, 45, 103, DateTimeKind.Unspecified).AddTicks(1071), 3L, false, 23L },
                    { 23L, 3L, 0, new DateTime(2021, 6, 19, 21, 43, 3, 218, DateTimeKind.Unspecified).AddTicks(7346), 1L, false, 32L },
                    { 24L, 11L, 0, new DateTime(2021, 3, 15, 10, 36, 37, 39, DateTimeKind.Unspecified).AddTicks(3850), 4L, false, 16L },
                    { 25L, 20L, 0, new DateTime(2021, 12, 26, 3, 59, 35, 399, DateTimeKind.Unspecified).AddTicks(8451), 2L, false, 22L },
                    { 26L, 15L, 0, new DateTime(2021, 12, 24, 10, 4, 32, 706, DateTimeKind.Unspecified).AddTicks(5106), 2L, false, 36L },
                    { 27L, 10L, 0, new DateTime(2021, 11, 24, 11, 9, 57, 22, DateTimeKind.Unspecified).AddTicks(3823), 5L, false, 47L },
                    { 28L, 16L, 0, new DateTime(2021, 8, 20, 3, 34, 58, 940, DateTimeKind.Unspecified).AddTicks(7838), 5L, false, 18L },
                    { 29L, 14L, 0, new DateTime(2021, 4, 21, 14, 2, 17, 597, DateTimeKind.Unspecified).AddTicks(9227), 1L, false, 32L },
                    { 30L, 11L, 0, new DateTime(2021, 9, 6, 13, 25, 50, 369, DateTimeKind.Unspecified).AddTicks(5519), 4L, false, 25L },
                    { 31L, 14L, 0, new DateTime(2021, 2, 16, 10, 44, 44, 139, DateTimeKind.Unspecified).AddTicks(7004), 4L, false, 26L },
                    { 32L, 5L, 0, new DateTime(2021, 12, 31, 14, 15, 15, 957, DateTimeKind.Unspecified).AddTicks(2900), 2L, false, 21L },
                    { 33L, 20L, 0, new DateTime(2021, 5, 19, 9, 44, 31, 938, DateTimeKind.Unspecified).AddTicks(6517), 2L, false, 20L },
                    { 34L, 7L, 0, new DateTime(2021, 12, 12, 18, 33, 47, 851, DateTimeKind.Unspecified).AddTicks(5546), 1L, false, 37L },
                    { 35L, 8L, 0, new DateTime(2022, 1, 20, 13, 33, 47, 790, DateTimeKind.Unspecified).AddTicks(9417), 5L, false, 18L },
                    { 36L, 8L, 0, new DateTime(2021, 3, 21, 10, 45, 0, 605, DateTimeKind.Unspecified).AddTicks(2719), 1L, false, 38L },
                    { 37L, 14L, 0, new DateTime(2021, 6, 4, 14, 57, 38, 734, DateTimeKind.Unspecified).AddTicks(6879), 1L, false, 14L },
                    { 39L, 21L, 0, new DateTime(2022, 1, 10, 6, 35, 41, 132, DateTimeKind.Unspecified).AddTicks(7949), 4L, false, 10L },
                    { 40L, 6L, 0, new DateTime(2021, 5, 15, 6, 37, 46, 585, DateTimeKind.Unspecified).AddTicks(5444), 4L, false, 5L },
                    { 41L, 19L, 0, new DateTime(2021, 8, 27, 19, 41, 24, 300, DateTimeKind.Unspecified).AddTicks(4452), 5L, false, 3L },
                    { 42L, 4L, 0, new DateTime(2021, 9, 28, 1, 52, 4, 463, DateTimeKind.Unspecified).AddTicks(5896), 4L, false, 24L },
                    { 43L, 20L, 0, new DateTime(2021, 12, 2, 12, 45, 7, 339, DateTimeKind.Unspecified).AddTicks(9936), 3L, false, 24L },
                    { 44L, 16L, 0, new DateTime(2021, 11, 28, 19, 13, 2, 676, DateTimeKind.Unspecified).AddTicks(5621), 4L, false, 26L },
                    { 45L, 16L, 0, new DateTime(2021, 4, 29, 3, 53, 11, 424, DateTimeKind.Unspecified).AddTicks(3376), 4L, false, 31L }
                });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "Id", "CourseId", "CourseRole", "CreatedAt", "CreatedBy", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { 46L, 16L, 0, new DateTime(2021, 9, 14, 1, 7, 56, 693, DateTimeKind.Unspecified).AddTicks(7215), 4L, false, 10L },
                    { 47L, 9L, 0, new DateTime(2021, 5, 13, 1, 7, 29, 486, DateTimeKind.Unspecified).AddTicks(5868), 3L, false, 26L },
                    { 48L, 4L, 0, new DateTime(2022, 1, 4, 14, 9, 27, 298, DateTimeKind.Unspecified).AddTicks(4286), 1L, false, 34L },
                    { 49L, 7L, 0, new DateTime(2021, 3, 19, 7, 41, 55, 577, DateTimeKind.Unspecified).AddTicks(3024), 1L, false, 31L },
                    { 51L, 15L, 0, new DateTime(2021, 8, 14, 17, 31, 37, 910, DateTimeKind.Unspecified).AddTicks(59), 2L, false, 45L },
                    { 52L, 6L, 0, new DateTime(2021, 8, 25, 2, 8, 47, 611, DateTimeKind.Unspecified).AddTicks(1564), 3L, false, 28L },
                    { 53L, 10L, 0, new DateTime(2021, 10, 9, 12, 2, 55, 709, DateTimeKind.Unspecified).AddTicks(3065), 3L, false, 17L },
                    { 55L, 10L, 0, new DateTime(2022, 1, 1, 8, 0, 43, 579, DateTimeKind.Unspecified).AddTicks(9957), 5L, false, 11L },
                    { 56L, 2L, 0, new DateTime(2021, 9, 29, 15, 56, 4, 706, DateTimeKind.Unspecified).AddTicks(8619), 4L, false, 32L },
                    { 57L, 9L, 0, new DateTime(2021, 11, 12, 6, 17, 13, 136, DateTimeKind.Unspecified).AddTicks(9133), 3L, false, 45L },
                    { 58L, 17L, 0, new DateTime(2021, 2, 10, 11, 8, 33, 631, DateTimeKind.Unspecified).AddTicks(5249), 4L, false, 37L },
                    { 60L, 6L, 0, new DateTime(2021, 11, 5, 16, 40, 8, 932, DateTimeKind.Unspecified).AddTicks(5529), 5L, false, 26L },
                    { 61L, 4L, 0, new DateTime(2021, 11, 16, 21, 8, 21, 868, DateTimeKind.Unspecified).AddTicks(5263), 3L, false, 46L },
                    { 62L, 17L, 0, new DateTime(2021, 6, 18, 17, 16, 6, 830, DateTimeKind.Unspecified).AddTicks(1231), 3L, false, 33L },
                    { 63L, 15L, 0, new DateTime(2022, 1, 10, 4, 4, 38, 6, DateTimeKind.Unspecified).AddTicks(5322), 4L, false, 37L },
                    { 64L, 8L, 0, new DateTime(2021, 3, 31, 4, 38, 21, 637, DateTimeKind.Unspecified).AddTicks(6812), 3L, false, 35L },
                    { 65L, 19L, 0, new DateTime(2021, 12, 8, 17, 5, 52, 178, DateTimeKind.Unspecified).AddTicks(152), 4L, false, 50L },
                    { 66L, 6L, 0, new DateTime(2021, 8, 3, 8, 31, 20, 83, DateTimeKind.Unspecified).AddTicks(2921), 4L, false, 34L },
                    { 67L, 11L, 0, new DateTime(2021, 3, 8, 7, 14, 46, 769, DateTimeKind.Unspecified).AddTicks(774), 5L, false, 39L },
                    { 68L, 2L, 0, new DateTime(2021, 2, 11, 10, 19, 46, 101, DateTimeKind.Unspecified).AddTicks(5568), 5L, false, 5L },
                    { 70L, 11L, 0, new DateTime(2021, 12, 26, 12, 30, 32, 369, DateTimeKind.Unspecified).AddTicks(9654), 4L, false, 32L },
                    { 71L, 21L, 0, new DateTime(2022, 1, 24, 14, 17, 46, 65, DateTimeKind.Unspecified).AddTicks(5887), 3L, false, 43L }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 4L, 50L, "Omnis quis et aut molestiae officiis.", new DateTime(2021, 9, 23, 8, 35, 30, 685, DateTimeKind.Unspecified).AddTicks(9563), 3L, false, 3L },
                    { 5L, 22L, "Numquam fugiat nesciunt similique optio aut.\nPerspiciatis reprehenderit iusto dicta dolore ullam.", new DateTime(2021, 6, 10, 6, 46, 9, 977, DateTimeKind.Unspecified).AddTicks(8253), 4L, false, 78L },
                    { 6L, 29L, "Eius consequuntur minima qui est debitis.\nSint maiores perferendis quaerat doloribus.", new DateTime(2022, 1, 4, 10, 16, 30, 348, DateTimeKind.Unspecified).AddTicks(6856), 5L, false, 77L },
                    { 8L, 5L, "Provident quos quasi assumenda.\nDolorem et ut dolores qui quasi neque modi ex commodi.", new DateTime(2021, 3, 17, 13, 13, 36, 606, DateTimeKind.Unspecified).AddTicks(9252), 5L, false, 81L },
                    { 9L, 19L, "Commodi optio quo modi rerum.\nUllam laboriosam omnis optio accusamus incidunt corrupti.\nAlias odio voluptas et dolorum aut suscipit earum amet.\nVero molestias et labore.\nDolorum sit itaque sunt quo dolorem autem.", new DateTime(2021, 10, 30, 15, 51, 52, 4, DateTimeKind.Unspecified).AddTicks(6718), 2L, false, 45L },
                    { 12L, 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 4L, false, 18L },
                    { 14L, 35L, "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 3L, false, 62L },
                    { 15L, 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 1L, false, 36L },
                    { 16L, 43L, "Earum voluptate voluptatem.\nSunt sunt est non deleniti tempore provident nihil et omnis.", new DateTime(2021, 5, 22, 23, 42, 34, 208, DateTimeKind.Unspecified).AddTicks(457), 4L, false, 6L },
                    { 18L, 26L, "Libero dicta temporibus atque earum.\nReprehenderit eos qui eum totam.\nId cum adipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 3L, false, 25L },
                    { 19L, 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 4L, false, 12L },
                    { 22L, 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 3L, false, 42L },
                    { 23L, 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, false, 61L },
                    { 25L, 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, false, 60L },
                    { 27L, 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, false, 3L },
                    { 28L, 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 4L, false, 78L },
                    { 29L, 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 1L, false, 27L },
                    { 31L, 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 3L, false, 12L },
                    { 32L, 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 4L, false, 78L },
                    { 35L, 8L, "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 3L, false, 15L }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 37L, 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 2L, false, 64L },
                    { 40L, 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 3L, false, 47L },
                    { 41L, 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 3L, false, 60L },
                    { 42L, 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L, false, 36L },
                    { 43L, 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 5L, false, 3L },
                    { 45L, 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 1L, false, 69L },
                    { 47L, 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 5L, false, 12L },
                    { 48L, 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, false, 58L },
                    { 52L, 8L, "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 3L, false, 58L },
                    { 53L, 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 5L, false, 78L },
                    { 54L, 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 3L, false, 77L },
                    { 55L, 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 1L, false, 10L },
                    { 56L, 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 5L, false, 18L },
                    { 57L, 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, false, 34L },
                    { 59L, 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 5L, false, 69L },
                    { 60L, 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 5L, false, 64L },
                    { 62L, 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 5L, false, 12L },
                    { 64L, 25L, "Ipsam minima vel totam vel deserunt ab.\nEnim dolorem aliquid aperiam quod tempore porro ad nemo sit.\nNisi quis dolore nihil.", new DateTime(2021, 3, 28, 17, 3, 2, 998, DateTimeKind.Unspecified).AddTicks(838), 3L, false, 81L },
                    { 65L, 13L, "Non fugiat non porro vero reiciendis et.\nEnim facere autem molestiae.", new DateTime(2021, 4, 1, 7, 35, 59, 215, DateTimeKind.Unspecified).AddTicks(830), 5L, false, 12L },
                    { 68L, 29L, "Illo a ex minus.\nDucimus qui officiis.\nDicta suscipit voluptas libero.\nTemporibus enim qui labore.", new DateTime(2021, 10, 9, 0, 43, 5, 480, DateTimeKind.Unspecified).AddTicks(7270), 2L, false, 18L },
                    { 69L, 44L, "Sed tempora non officiis est sit eveniet.\nArchitecto corrupti id rerum quam nesciunt assumenda odio ut maxime.\nUt animi in iste voluptatibus aliquid ut vitae.\nVelit exercitationem vero id sed quibusdam non.\nUt at ratione qui consectetur quam voluptas dolor dolorum.", new DateTime(2021, 8, 14, 13, 57, 37, 263, DateTimeKind.Unspecified).AddTicks(4946), 5L, false, 73L },
                    { 71L, 14L, "Quo dolor harum et maxime.\nEt ut quia ab animi occaecati beatae.\nVel autem ea molestias.\nAspernatur sunt explicabo.\nCorporis vitae porro voluptas et magni alias sit quia quia.\nImpedit maiores unde possimus aspernatur enim ea et ut.", new DateTime(2021, 9, 6, 6, 15, 51, 816, DateTimeKind.Unspecified).AddTicks(508), 1L, false, 78L },
                    { 72L, 5L, "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 4L, false, 41L },
                    { 73L, 23L, "Cum illum sit corporis maiores laudantium ut.\nArchitecto aut expedita nihil et voluptatibus fugiat.\nQuisquam harum consequatur quasi ea voluptas hic dolorum.\nHarum laborum harum suscipit magnam aut.\nDolores amet tempore magni magni possimus odit quis et impedit.", new DateTime(2021, 6, 4, 11, 4, 16, 100, DateTimeKind.Unspecified).AddTicks(7149), 5L, false, 23L },
                    { 75L, 48L, "Sint aliquid pariatur harum enim dolorem repellat.\nMolestiae aut nemo nihil qui sapiente non harum.\nEligendi voluptas nobis tempore.\nMolestias vel dolores aut deleniti aut minima accusamus.\nOmnis voluptatem similique.\nFacere occaecati incidunt iusto laborum ut eius id dolore.", new DateTime(2021, 4, 12, 22, 5, 28, 434, DateTimeKind.Unspecified).AddTicks(9752), 4L, false, 36L },
                    { 78L, 15L, "Qui et velit tempore et.\nQui animi dolor beatae soluta.\nEt ab explicabo eos enim consequatur omnis soluta.\nVel doloribus omnis est optio et.\nAmet et assumenda et numquam culpa.\nQuasi aspernatur tempore.", new DateTime(2021, 11, 8, 12, 17, 53, 802, DateTimeKind.Unspecified).AddTicks(2027), 4L, false, 16L },
                    { 79L, 48L, "Suscipit deleniti accusamus et debitis.\nDucimus ab cum.\nPariatur architecto architecto odio maiores.", new DateTime(2021, 9, 4, 18, 46, 20, 745, DateTimeKind.Unspecified).AddTicks(6003), 1L, false, 30L },
                    { 80L, 5L, "Dolore nihil voluptas doloremque accusantium.\nAnimi aspernatur mollitia.", new DateTime(2021, 6, 17, 15, 1, 38, 939, DateTimeKind.Unspecified).AddTicks(7420), 1L, false, 16L },
                    { 81L, 4L, "Eum voluptas similique quasi.\nPorro possimus repudiandae minus rerum repellat.\nNobis laboriosam qui id qui inventore illo sunt.", new DateTime(2021, 3, 27, 21, 21, 10, 234, DateTimeKind.Unspecified).AddTicks(231), 1L, false, 45L },
                    { 82L, 27L, "Hic vitae tempora tempore et dignissimos perferendis omnis aut.", new DateTime(2021, 3, 12, 22, 52, 25, 95, DateTimeKind.Unspecified).AddTicks(9008), 2L, false, 36L },
                    { 83L, 29L, "Excepturi mollitia vitae accusantium autem repudiandae.\nEst rem ex rerum sunt suscipit voluptatem veniam aut.\nMaiores similique assumenda tempore est inventore aut omnis.\nEt ut corporis dolorem deleniti dolorem laudantium mollitia.", new DateTime(2021, 4, 6, 19, 23, 18, 77, DateTimeKind.Unspecified).AddTicks(4489), 5L, false, 77L },
                    { 84L, 34L, "Adipisci enim facere voluptatem sed accusamus soluta fuga qui porro.\nEx quia dolorem qui qui sed sed rem.\nConsequatur occaecati rem corporis officiis dolor aut id.\nSuscipit pariatur necessitatibus minima harum sunt ea.\nQuod omnis nobis sapiente veniam esse qui ducimus quia voluptas.", new DateTime(2021, 9, 4, 11, 28, 1, 107, DateTimeKind.Unspecified).AddTicks(3093), 4L, false, 64L },
                    { 85L, 3L, "Aut non tempore voluptas qui.\nLaboriosam omnis earum sit atque et.\nBeatae est magnam praesentium rerum quibusdam dignissimos temporibus voluptas.\nOdit rerum at facere itaque rem sapiente rerum.\nAspernatur ut corporis nihil ut occaecati atque exercitationem nihil molestiae.", new DateTime(2021, 5, 15, 6, 26, 4, 917, DateTimeKind.Unspecified).AddTicks(507), 5L, false, 23L },
                    { 86L, 10L, "Sequi reprehenderit ipsam.\nEt enim error quia quia error tenetur mollitia eligendi.\nNostrum voluptatibus magni natus assumenda quis.\nMaiores ut itaque ea et voluptatem et maxime praesentium.", new DateTime(2021, 5, 20, 9, 52, 1, 466, DateTimeKind.Unspecified).AddTicks(4088), 2L, false, 15L },
                    { 87L, 39L, "Est ab nemo.\nAut aspernatur dolores suscipit similique necessitatibus id voluptatem quidem.\nDolores consequatur tenetur.\nAd dolorem ipsa autem et.\nNostrum cumque praesentium.", new DateTime(2021, 9, 22, 15, 38, 2, 296, DateTimeKind.Unspecified).AddTicks(2770), 4L, false, 33L },
                    { 89L, 36L, "Nihil qui in laudantium iste repellat ipsum veritatis praesentium.\nDeleniti eaque eaque.\nQuasi deserunt maiores ad deserunt et alias enim.", new DateTime(2021, 4, 5, 3, 11, 52, 774, DateTimeKind.Unspecified).AddTicks(511), 5L, false, 21L },
                    { 91L, 19L, "Non sit perspiciatis ex cum quidem placeat saepe ut asperiores.\nAt voluptas aperiam.\nEos magni dolor praesentium accusamus deleniti laboriosam.", new DateTime(2021, 4, 3, 10, 20, 46, 341, DateTimeKind.Unspecified).AddTicks(3427), 5L, false, 10L },
                    { 92L, 43L, "Facere ea provident et.\nAut minus occaecati.\nQui rem quaerat.\nEst blanditiis et aspernatur earum asperiores illo.\nSunt doloremque incidunt magnam sint dignissimos accusamus fugiat dignissimos.\nVoluptas tempore provident eos et praesentium vel.", new DateTime(2021, 2, 6, 15, 19, 18, 560, DateTimeKind.Unspecified).AddTicks(1065), 2L, false, 62L },
                    { 94L, 5L, "Doloribus excepturi similique eos est.\nSaepe et qui ab unde deserunt est quis.\nLabore facere dolor.", new DateTime(2022, 1, 15, 18, 52, 37, 713, DateTimeKind.Unspecified).AddTicks(9441), 3L, false, 25L },
                    { 95L, 18L, "Doloribus omnis dignissimos mollitia alias omnis vitae deleniti.\nNesciunt qui voluptatem amet odio ullam.", new DateTime(2021, 6, 20, 20, 32, 47, 556, DateTimeKind.Unspecified).AddTicks(3441), 1L, false, 69L },
                    { 96L, 47L, "Nostrum tempore quo quibusdam.\nNesciunt tempore qui beatae omnis earum veniam.", new DateTime(2021, 11, 8, 19, 30, 2, 744, DateTimeKind.Unspecified).AddTicks(6567), 1L, false, 71L },
                    { 98L, 31L, "In id voluptate saepe velit eum aut aperiam enim.\nDolorem aut perspiciatis qui quibusdam voluptatem dolorem.\nModi magnam alias omnis.\nConsectetur nulla fuga voluptas sint nostrum et quia aliquam.\nEt incidunt eius natus dolor eligendi et.", new DateTime(2021, 5, 6, 23, 34, 5, 229, DateTimeKind.Unspecified).AddTicks(3940), 4L, false, 62L }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 101L, 42L, "Voluptatem cumque eum praesentium ut magni et.\nEius perferendis aut.\nEa eaque et omnis illo.\nQuaerat perferendis quas.", new DateTime(2021, 6, 7, 9, 32, 29, 109, DateTimeKind.Unspecified).AddTicks(2186), 1L, false, 46L },
                    { 102L, 34L, "Architecto est deleniti sit sint minus enim culpa nisi.\nFugit ex eos officia eos ducimus tempora voluptas possimus.\nDolorem nulla omnis eum sed repellat.", new DateTime(2021, 12, 11, 20, 49, 24, 536, DateTimeKind.Unspecified).AddTicks(9357), 2L, false, 9L },
                    { 105L, 36L, "Delectus et natus possimus omnis et.\nAtque cupiditate reprehenderit cupiditate voluptate sed sapiente nesciunt qui.\nNon ullam id excepturi dolorum consequatur velit.\nUnde est error eius amet.\nDelectus qui libero est optio natus suscipit voluptate ab.", new DateTime(2021, 2, 28, 19, 5, 13, 864, DateTimeKind.Unspecified).AddTicks(172), 3L, false, 33L },
                    { 109L, 50L, "Qui ipsa et soluta consequatur impedit dolor est.", new DateTime(2021, 4, 6, 0, 15, 0, 666, DateTimeKind.Unspecified).AddTicks(3684), 1L, false, 36L },
                    { 114L, 30L, "Architecto dolor odit est ducimus tempora consequuntur minima atque laborum.", new DateTime(2021, 5, 19, 8, 26, 26, 321, DateTimeKind.Unspecified).AddTicks(5379), 1L, false, 64L },
                    { 115L, 41L, "Sint voluptatem repellat aut aut.\nNumquam officia accusamus vel ducimus voluptas voluptatem.\nAut dignissimos sint minus et non.\nAut odit cupiditate totam velit dolores.", new DateTime(2021, 3, 30, 21, 30, 24, 45, DateTimeKind.Unspecified).AddTicks(3023), 1L, false, 25L },
                    { 116L, 24L, "Iusto laboriosam numquam eos quia asperiores sunt delectus sint omnis.\nOmnis et sit quae animi sed et praesentium.\nOdit eveniet perspiciatis sint voluptatum suscipit est consequatur.\nUllam accusamus ut ut qui dolorem.\nQuibusdam corporis impedit.\nQuos natus tenetur adipisci rem maxime libero sit.", new DateTime(2021, 12, 14, 6, 12, 27, 982, DateTimeKind.Unspecified).AddTicks(9982), 1L, false, 16L },
                    { 121L, 40L, "Occaecati quia veritatis quidem.\nUt mollitia inventore accusamus.", new DateTime(2021, 12, 6, 11, 53, 10, 114, DateTimeKind.Unspecified).AddTicks(9770), 5L, false, 62L }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 2L, 2L, new DateTime(2021, 11, 7, 19, 20, 21, 51, DateTimeKind.Unspecified).AddTicks(504), 3L, false, "Voluptatem et totam et fugiat occaecati itaque enim ratione." },
                    { 3L, 13L, new DateTime(2021, 11, 21, 15, 9, 23, 648, DateTimeKind.Unspecified).AddTicks(7887), 1L, false, "Aut facere rerum laudantium assumenda quam dicta iure doloremque." },
                    { 4L, 21L, new DateTime(2021, 3, 28, 8, 59, 37, 146, DateTimeKind.Unspecified).AddTicks(5482), 3L, false, "Ea sed quia in enim et animi veniam eaque et." },
                    { 5L, 19L, new DateTime(2021, 2, 20, 12, 58, 2, 738, DateTimeKind.Unspecified).AddTicks(1217), 5L, false, "Quisquam repellat animi laboriosam enim." },
                    { 6L, 19L, new DateTime(2021, 9, 8, 22, 44, 12, 23, DateTimeKind.Unspecified).AddTicks(3386), 1L, false, "Delectus et harum nisi porro consequatur quis voluptatem qui impedit." },
                    { 7L, 13L, new DateTime(2021, 12, 27, 10, 18, 1, 612, DateTimeKind.Unspecified).AddTicks(5640), 4L, false, "Maxime optio explicabo quidem." },
                    { 8L, 10L, new DateTime(2021, 12, 7, 14, 39, 14, 365, DateTimeKind.Unspecified).AddTicks(187), 4L, false, "Perferendis sint illo commodi iure et dolore nihil sit qui." },
                    { 9L, 16L, new DateTime(2021, 11, 18, 16, 55, 58, 427, DateTimeKind.Unspecified).AddTicks(6647), 5L, false, "Cum sequi rerum sint placeat suscipit excepturi." },
                    { 10L, 7L, new DateTime(2021, 4, 9, 15, 23, 45, 900, DateTimeKind.Unspecified).AddTicks(768), 1L, false, "Consequatur at facilis eius incidunt." },
                    { 11L, 17L, new DateTime(2022, 1, 19, 20, 16, 59, 880, DateTimeKind.Unspecified).AddTicks(8965), 4L, false, "Repellendus quo nostrum aliquid reiciendis at quasi maxime autem est." },
                    { 12L, 2L, new DateTime(2021, 8, 13, 18, 4, 22, 185, DateTimeKind.Unspecified).AddTicks(8944), 4L, false, "Sit itaque placeat rerum." },
                    { 13L, 14L, new DateTime(2021, 12, 27, 17, 55, 10, 431, DateTimeKind.Unspecified).AddTicks(8159), 3L, false, "Itaque nulla quae culpa in." },
                    { 14L, 17L, new DateTime(2021, 11, 1, 6, 32, 53, 45, DateTimeKind.Unspecified).AddTicks(3944), 2L, false, "Tempora et ipsum vel sapiente et provident itaque saepe ut." },
                    { 15L, 14L, new DateTime(2022, 1, 13, 11, 55, 51, 269, DateTimeKind.Unspecified).AddTicks(7658), 1L, false, "Ut est quo fuga veniam atque." },
                    { 16L, 7L, new DateTime(2021, 3, 30, 8, 20, 32, 866, DateTimeKind.Unspecified).AddTicks(8064), 2L, false, "Sint omnis dignissimos nemo in minima laudantium." },
                    { 17L, 4L, new DateTime(2021, 5, 20, 7, 40, 56, 673, DateTimeKind.Unspecified).AddTicks(2163), 3L, false, "Reiciendis et voluptas illo architecto eius cumque." },
                    { 18L, 16L, new DateTime(2021, 10, 15, 20, 20, 13, 323, DateTimeKind.Unspecified).AddTicks(9029), 4L, false, "Nobis qui quas aut et voluptatibus quia et quaerat inventore." },
                    { 19L, 18L, new DateTime(2021, 12, 31, 13, 23, 53, 570, DateTimeKind.Unspecified).AddTicks(6682), 3L, false, "Quam tempora ut et." },
                    { 20L, 7L, new DateTime(2022, 1, 15, 16, 3, 40, 270, DateTimeKind.Unspecified).AddTicks(2330), 5L, false, "Molestiae natus voluptates eum sunt quia." },
                    { 21L, 11L, new DateTime(2021, 6, 6, 7, 57, 25, 386, DateTimeKind.Unspecified).AddTicks(8642), 1L, false, "Aut est sunt ab et deserunt velit." },
                    { 22L, 5L, new DateTime(2021, 5, 24, 1, 45, 58, 258, DateTimeKind.Unspecified).AddTicks(7361), 3L, false, "Rem incidunt sed doloremque et et doloribus." },
                    { 23L, 19L, new DateTime(2021, 9, 5, 17, 30, 5, 283, DateTimeKind.Unspecified).AddTicks(7129), 3L, false, "Illum ad rem rerum." },
                    { 24L, 6L, new DateTime(2021, 8, 21, 2, 26, 38, 732, DateTimeKind.Unspecified).AddTicks(6052), 2L, false, "Aliquid laboriosam aut adipisci at est aspernatur consequatur nihil rerum." },
                    { 25L, 13L, new DateTime(2021, 4, 30, 16, 1, 16, 645, DateTimeKind.Unspecified).AddTicks(3833), 2L, false, "Qui qui sit nihil aliquid nihil." },
                    { 26L, 20L, new DateTime(2022, 1, 11, 14, 30, 6, 354, DateTimeKind.Unspecified).AddTicks(9151), 1L, false, "Eos id autem vel culpa vero optio." },
                    { 27L, 17L, new DateTime(2021, 7, 10, 0, 18, 57, 905, DateTimeKind.Unspecified).AddTicks(4760), 2L, false, "Dolore laudantium eaque ut laboriosam." },
                    { 28L, 11L, new DateTime(2021, 6, 22, 21, 26, 43, 862, DateTimeKind.Unspecified).AddTicks(1070), 1L, false, "Exercitationem vel placeat iure." },
                    { 29L, 13L, new DateTime(2021, 10, 3, 13, 46, 15, 184, DateTimeKind.Unspecified).AddTicks(1120), 3L, false, "Magni nihil odio vitae." },
                    { 30L, 6L, new DateTime(2021, 11, 5, 12, 32, 43, 227, DateTimeKind.Unspecified).AddTicks(3124), 2L, false, "Eveniet veniam temporibus similique." },
                    { 31L, 20L, new DateTime(2021, 5, 20, 12, 10, 4, 432, DateTimeKind.Unspecified).AddTicks(3484), 2L, false, "Quia sunt doloribus exercitationem ex perferendis." },
                    { 32L, 12L, new DateTime(2021, 9, 19, 7, 0, 8, 71, DateTimeKind.Unspecified).AddTicks(5699), 4L, false, "Dolore atque vero ea ea error et." },
                    { 33L, 11L, new DateTime(2021, 2, 14, 7, 38, 48, 794, DateTimeKind.Unspecified).AddTicks(64), 5L, false, "Tempora libero repellat nihil aspernatur odio atque." },
                    { 34L, 19L, new DateTime(2021, 10, 7, 23, 39, 54, 168, DateTimeKind.Unspecified).AddTicks(8413), 1L, false, "Dolores ex voluptatem." },
                    { 35L, 20L, new DateTime(2021, 10, 6, 1, 49, 13, 107, DateTimeKind.Unspecified).AddTicks(2066), 2L, false, "Sed voluptas ipsum autem aperiam numquam pariatur reprehenderit dolores." }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 36L, 13L, new DateTime(2021, 4, 26, 2, 9, 35, 686, DateTimeKind.Unspecified).AddTicks(8160), 3L, false, "Deleniti accusamus omnis eveniet et asperiores officia aliquam." },
                    { 37L, 15L, new DateTime(2021, 6, 25, 19, 18, 54, 431, DateTimeKind.Unspecified).AddTicks(7253), 4L, false, "In incidunt ut quas eos deleniti sed et." },
                    { 38L, 13L, new DateTime(2021, 6, 1, 8, 28, 50, 618, DateTimeKind.Unspecified).AddTicks(2407), 2L, false, "Pariatur quidem dolor at impedit rerum." },
                    { 39L, 21L, new DateTime(2021, 5, 10, 21, 7, 42, 568, DateTimeKind.Unspecified).AddTicks(3975), 1L, false, "Ut voluptatem culpa consequatur." },
                    { 40L, 19L, new DateTime(2021, 8, 23, 18, 16, 19, 678, DateTimeKind.Unspecified).AddTicks(8850), 2L, false, "Unde enim in libero blanditiis maiores quas." },
                    { 41L, 16L, new DateTime(2021, 6, 18, 3, 45, 1, 778, DateTimeKind.Unspecified).AddTicks(4316), 3L, false, "Ea beatae et voluptatem voluptas quae enim numquam." }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsDeleted", "IsPublished", "Title", "UnitId" },
                values: new object[,]
                {
                    { 2L, 13L, new DateTime(2021, 12, 21, 21, 58, 41, 323, DateTimeKind.Unspecified).AddTicks(814), 3L, "Exercitationem ab sit dolor.", new DateTime(2023, 9, 3, 13, 55, 22, 545, DateTimeKind.Unspecified).AddTicks(541), false, false, "Et aperiam ea est vitae molestiae est quas et consectetur.", 25L },
                    { 3L, 15L, new DateTime(2021, 11, 15, 22, 59, 21, 336, DateTimeKind.Unspecified).AddTicks(2102), 1L, "Repellat aperiam sint quam eveniet quidem aspernatur ullam nihil.\nQui earum consectetur numquam repellat libero ut minima et sunt.\nEum qui eaque omnis sint voluptas.\nTenetur vitae tempore qui.", new DateTime(2023, 9, 7, 14, 3, 12, 741, DateTimeKind.Unspecified).AddTicks(7395), false, true, "Qui id alias magnam voluptatem.", 37L },
                    { 4L, 21L, new DateTime(2021, 5, 19, 0, 53, 43, 126, DateTimeKind.Unspecified).AddTicks(2729), 3L, "Quia qui illo.\nQuasi doloremque aut blanditiis.\nIn laborum nemo aut rerum voluptatibus accusamus.\nUt nisi nostrum dolores qui excepturi voluptatem rerum qui explicabo.\nIpsam aut molestiae blanditiis.", null, false, false, "Unde vitae dolores molestiae.", 4L },
                    { 5L, 19L, new DateTime(2021, 3, 25, 22, 46, 29, 556, DateTimeKind.Unspecified).AddTicks(468), 1L, "Voluptatem qui natus et.\nAut aperiam velit.\nRecusandae nulla qui est voluptatum sequi et.\nAperiam praesentium neque consequatur laudantium nostrum deserunt qui sapiente.", new DateTime(2022, 7, 22, 16, 6, 20, 849, DateTimeKind.Unspecified).AddTicks(8891), false, true, "Ab cumque asperiores sit minima culpa maxime suscipit ut dolorem.", 40L },
                    { 6L, 2L, new DateTime(2021, 8, 28, 0, 47, 40, 552, DateTimeKind.Unspecified).AddTicks(172), 2L, "Fugit at at sunt et.\nEnim corrupti sed nihil sint iure.\nExercitationem ut est quasi est deserunt asperiores dolores.\nRerum et quibusdam.\nVeniam sed tempore laudantium qui atque itaque velit.", new DateTime(2022, 6, 9, 3, 43, 47, 362, DateTimeKind.Unspecified).AddTicks(7418), false, true, "Consequatur omnis accusamus enim ipsum sunt rerum cum.", 2L },
                    { 7L, 12L, new DateTime(2021, 12, 14, 9, 1, 41, 712, DateTimeKind.Unspecified).AddTicks(4789), 3L, "Debitis assumenda eaque.\nAliquid omnis aut eos adipisci vel id rerum doloremque qui.\nQuia tempora iusto nobis numquam in.\nEt quam et.\nVel est impedit est incidunt delectus.", new DateTime(2023, 10, 2, 8, 52, 28, 942, DateTimeKind.Unspecified).AddTicks(309), false, true, "Harum expedita aliquam quia quam sunt in nisi dignissimos et.", 32L },
                    { 8L, 15L, new DateTime(2022, 1, 5, 16, 11, 51, 668, DateTimeKind.Unspecified).AddTicks(8955), 3L, "Consequatur vel est.\nEst ut et laboriosam ut in quos.\nQuam qui est illo et qui.", new DateTime(2022, 3, 13, 5, 2, 40, 545, DateTimeKind.Unspecified).AddTicks(1177), false, true, "Laborum sit debitis optio illum sint quis sunt ut id.", 37L },
                    { 9L, 11L, new DateTime(2021, 2, 6, 11, 19, 27, 975, DateTimeKind.Unspecified).AddTicks(3106), 4L, "Voluptatem inventore eveniet veniam.\nOccaecati et delectus numquam voluptas dignissimos ad.\nRatione voluptatem praesentium sunt.\nTotam distinctio quas id necessitatibus aut consequatur.", new DateTime(2023, 10, 16, 6, 44, 40, 594, DateTimeKind.Unspecified).AddTicks(6448), false, true, "Voluptate ab et quaerat nostrum velit consequatur aliquam.", 21L },
                    { 10L, 2L, new DateTime(2022, 1, 22, 23, 46, 30, 637, DateTimeKind.Unspecified).AddTicks(591), 3L, "Cupiditate totam accusantium.\nEos ipsa aliquam dolores illum ex earum.\nQuo blanditiis temporibus repellat quisquam esse ipsum explicabo repudiandae.\nEa aliquid veniam tempora ex enim excepturi officiis.", new DateTime(2023, 2, 23, 10, 51, 14, 647, DateTimeKind.Unspecified).AddTicks(3792), false, false, "Omnis ea dolorum asperiores.", 2L },
                    { 11L, 17L, new DateTime(2021, 5, 4, 13, 45, 37, 279, DateTimeKind.Unspecified).AddTicks(6304), 5L, "Doloremque eum voluptas rerum.\nDolorem quidem velit nulla.\nTempore dolore quidem.\nVoluptatibus dolorum rerum dolorem dolorum aspernatur vel molestiae.\nConsequatur placeat sed quia perspiciatis soluta est rerum numquam.", new DateTime(2022, 12, 14, 13, 3, 24, 6, DateTimeKind.Unspecified).AddTicks(7877), false, true, "Ut debitis nulla unde ut doloremque omnis dolores.", 11L },
                    { 12L, 7L, new DateTime(2021, 10, 17, 4, 26, 11, 227, DateTimeKind.Unspecified).AddTicks(2391), 4L, "Labore neque error laborum dicta itaque sint facere.\nId deserunt qui necessitatibus libero quas sunt sint velit.\nBlanditiis illum natus ea explicabo officiis.\nEt sed consequatur fugit et at voluptate accusantium.\nNesciunt reiciendis quasi natus nihil.", new DateTime(2023, 6, 27, 10, 15, 44, 129, DateTimeKind.Unspecified).AddTicks(5438), false, true, "Et explicabo voluptatem sit itaque.", 16L },
                    { 13L, 5L, new DateTime(2021, 4, 16, 10, 45, 47, 335, DateTimeKind.Unspecified).AddTicks(1734), 4L, "Et soluta et rem quod autem iusto.\nPlaceat expedita ea quod doloribus et.\nNisi aut dignissimos quidem porro.", new DateTime(2023, 8, 8, 13, 12, 30, 977, DateTimeKind.Unspecified).AddTicks(5085), false, true, "Expedita asperiores alias maxime maiores.", 22L },
                    { 14L, 12L, new DateTime(2021, 5, 5, 6, 12, 5, 214, DateTimeKind.Unspecified).AddTicks(7048), 5L, "Sed et ex molestias sit amet ut corporis non facilis.\nIste ea voluptatum quis et.", new DateTime(2023, 11, 12, 18, 54, 19, 670, DateTimeKind.Unspecified).AddTicks(598), false, true, "Voluptas consequuntur consequatur consequatur quaerat.", 32L },
                    { 15L, 13L, new DateTime(2021, 11, 26, 2, 15, 53, 505, DateTimeKind.Unspecified).AddTicks(43), 2L, "Aut ea sunt placeat facere.\nId fugit ducimus ducimus blanditiis non laborum enim et nesciunt.\nOmnis rem fugit et voluptates provident sequi aliquid velit consectetur.\nAut sit tempore doloremque sit ex voluptatem voluptatem enim.", new DateTime(2023, 7, 19, 4, 56, 19, 281, DateTimeKind.Unspecified).AddTicks(16), false, false, "Dolorem tempore eius consequatur mollitia enim.", 38L },
                    { 16L, 6L, new DateTime(2021, 9, 10, 6, 1, 31, 998, DateTimeKind.Unspecified).AddTicks(4248), 5L, "Ipsa et et.", new DateTime(2022, 7, 12, 10, 18, 56, 157, DateTimeKind.Unspecified).AddTicks(4704), false, false, "Nostrum iste aut saepe molestiae.", 24L },
                    { 17L, 11L, new DateTime(2021, 2, 4, 5, 5, 58, 590, DateTimeKind.Unspecified).AddTicks(705), 1L, "Sit aut eum aut.\nDolor eos autem.\nExercitationem voluptate quae quasi et incidunt.\nEos quasi minima suscipit sit voluptatibus accusamus.\nDolor quidem culpa et non unde rerum.", new DateTime(2022, 10, 3, 1, 16, 2, 682, DateTimeKind.Unspecified).AddTicks(5160), false, false, "Assumenda consequatur voluptatem omnis nihil doloremque aliquam aut explicabo.", 33L },
                    { 18L, 17L, new DateTime(2021, 6, 25, 14, 54, 19, 404, DateTimeKind.Unspecified).AddTicks(1657), 1L, "A adipisci ratione adipisci voluptatum.\nItaque illum iste.\nAperiam recusandae enim cumque consequatur animi asperiores ut nulla.", new DateTime(2022, 11, 27, 19, 17, 59, 489, DateTimeKind.Unspecified).AddTicks(3558), false, false, "Amet eligendi architecto animi nesciunt.", 11L },
                    { 19L, 21L, new DateTime(2021, 10, 8, 8, 9, 34, 791, DateTimeKind.Unspecified).AddTicks(1560), 4L, "Tempore ab molestiae rerum sint et.\nDoloribus inventore corrupti.\nIllum sunt beatae suscipit ipsam sunt veniam vitae.", new DateTime(2022, 3, 27, 5, 4, 8, 306, DateTimeKind.Unspecified).AddTicks(5407), false, false, "Et rerum qui voluptatem qui dolorem quis nesciunt modi.", 4L },
                    { 20L, 2L, new DateTime(2021, 11, 29, 11, 22, 40, 703, DateTimeKind.Unspecified).AddTicks(120), 4L, "Molestiae dolorem quia numquam esse laudantium.", new DateTime(2023, 3, 17, 10, 27, 38, 409, DateTimeKind.Unspecified).AddTicks(4759), false, true, "Nostrum aspernatur non error.", 12L },
                    { 21L, 7L, new DateTime(2021, 4, 22, 0, 7, 36, 83, DateTimeKind.Unspecified).AddTicks(1027), 5L, "Officiis eos quis saepe impedit.\nAut saepe veniam quia sit.\nDolores sit sequi saepe molestiae facere sed eveniet et.", new DateTime(2023, 7, 16, 12, 38, 30, 855, DateTimeKind.Unspecified).AddTicks(8435), false, true, "Et quos sit qui.", 20L },
                    { 22L, 13L, new DateTime(2021, 11, 8, 21, 41, 8, 389, DateTimeKind.Unspecified).AddTicks(5847), 1L, "Veniam nisi iste enim laborum.\nNemo similique ad itaque voluptatibus voluptas soluta recusandae aut ipsum.\nMolestiae ad laborum et ratione ipsam ullam.\nMolestiae accusamus tenetur ut perspiciatis numquam ipsam architecto non ab.", new DateTime(2023, 9, 17, 19, 53, 40, 204, DateTimeKind.Unspecified).AddTicks(8427), false, false, "Doloribus quod aut nihil.", 25L },
                    { 23L, 13L, new DateTime(2021, 6, 15, 23, 3, 45, 61, DateTimeKind.Unspecified).AddTicks(2333), 1L, "Cupiditate ratione illum.", new DateTime(2022, 6, 7, 20, 54, 12, 809, DateTimeKind.Unspecified).AddTicks(5223), false, true, "Ducimus rerum dicta.", 7L },
                    { 24L, 14L, new DateTime(2021, 3, 6, 9, 39, 26, 81, DateTimeKind.Unspecified).AddTicks(469), 5L, "Libero minus quisquam libero voluptas.", new DateTime(2023, 1, 12, 13, 40, 41, 40, DateTimeKind.Unspecified).AddTicks(1991), false, true, "Aliquam exercitationem nobis.", 13L },
                    { 25L, 21L, new DateTime(2021, 6, 13, 13, 27, 42, 12, DateTimeKind.Unspecified).AddTicks(8813), 4L, "Saepe dolorem nisi consequatur.\nQuis provident rerum.\nIn repudiandae repellendus vitae ea blanditiis numquam labore reprehenderit porro.", new DateTime(2022, 6, 2, 10, 15, 30, 472, DateTimeKind.Unspecified).AddTicks(8084), false, true, "Voluptatem deserunt optio.", 39L },
                    { 26L, 19L, new DateTime(2021, 6, 3, 9, 45, 43, 915, DateTimeKind.Unspecified).AddTicks(9319), 4L, "Culpa ea amet dolor omnis saepe aut.\nPlaceat omnis fugiat dolorem dolor velit.\nVoluptatem quibusdam in adipisci nihil vero aut aut qui et.\nSed voluptatum consectetur ipsa tenetur deserunt perspiciatis eligendi consequatur ex.", new DateTime(2024, 1, 16, 3, 53, 14, 546, DateTimeKind.Unspecified).AddTicks(8714), false, false, "Voluptatem reprehenderit iure quasi ipsa iusto mollitia ipsa ea eos.", 23L },
                    { 27L, 13L, new DateTime(2021, 6, 18, 5, 15, 50, 506, DateTimeKind.Unspecified).AddTicks(4740), 5L, "Sit dolore dolorem nam delectus nobis.\nMagnam quae veniam et ea dolores.\nImpedit mollitia et veniam.\nIure fuga quis.\nEaque laudantium eaque quia.", new DateTime(2023, 10, 29, 5, 27, 18, 505, DateTimeKind.Unspecified).AddTicks(1163), false, false, "Impedit iste natus quis.", 29L },
                    { 28L, 19L, new DateTime(2021, 9, 22, 3, 10, 41, 786, DateTimeKind.Unspecified).AddTicks(5061), 5L, "Consequatur sit odit non aliquid tempore autem.\nIpsam cupiditate aut ipsam.\nVelit blanditiis fugiat ipsa vitae.\nSed non commodi laborum pariatur praesentium nisi labore nam.\nEa voluptates totam enim impedit vitae.", new DateTime(2022, 3, 15, 8, 53, 30, 414, DateTimeKind.Unspecified).AddTicks(7211), false, true, "Eos quibusdam consequuntur.", 5L },
                    { 29L, 14L, new DateTime(2021, 8, 30, 22, 48, 0, 825, DateTimeKind.Unspecified).AddTicks(4773), 5L, "Qui est rerum quisquam quaerat.\nAut iusto quo eligendi a laborum.\nConsequatur similique fugit qui ipsam nobis ad nihil.\nVeritatis ea ut.", new DateTime(2023, 3, 16, 6, 19, 47, 91, DateTimeKind.Unspecified).AddTicks(974), false, false, "Consequatur nisi nostrum enim nam molestiae labore amet illum.", 13L },
                    { 30L, 7L, new DateTime(2021, 4, 30, 22, 13, 55, 230, DateTimeKind.Unspecified).AddTicks(2149), 3L, "Molestiae autem quia ab qui est voluptatem aspernatur enim.\nAccusamus magni odio repudiandae laborum qui veniam qui cumque.\nSuscipit et quis in velit.\nExcepturi quam molestias cum veritatis inventore.\nVoluptatum et quod rerum enim sed voluptates molestiae culpa.", new DateTime(2023, 1, 30, 12, 45, 8, 358, DateTimeKind.Unspecified).AddTicks(7771), false, true, "Velit magni qui inventore odio suscipit quaerat.", 10L },
                    { 31L, 11L, new DateTime(2022, 2, 1, 9, 37, 5, 467, DateTimeKind.Unspecified).AddTicks(6876), 5L, "Voluptas officia quidem dolor.\nSit delectus esse officiis optio aut sint temporibus aliquid.", new DateTime(2023, 8, 6, 18, 5, 46, 770, DateTimeKind.Unspecified).AddTicks(3884), false, false, "Voluptatum nesciunt aut iste est laudantium ullam sunt est quidem.", 28L },
                    { 32L, 13L, new DateTime(2021, 2, 4, 22, 13, 41, 315, DateTimeKind.Unspecified).AddTicks(9874), 1L, "Velit et aut.", new DateTime(2023, 6, 9, 13, 21, 42, 585, DateTimeKind.Unspecified).AddTicks(8626), false, false, "Qui aperiam occaecati dolor et.", 36L },
                    { 33L, 13L, new DateTime(2021, 10, 16, 1, 23, 7, 244, DateTimeKind.Unspecified).AddTicks(2448), 3L, "Dolorem eum quibusdam harum expedita quo reprehenderit omnis.\nId enim qui.", new DateTime(2023, 12, 31, 6, 22, 35, 266, DateTimeKind.Unspecified).AddTicks(51), false, true, "Est beatae autem et aspernatur omnis sit delectus voluptas.", 29L },
                    { 34L, 4L, new DateTime(2021, 4, 21, 17, 39, 26, 742, DateTimeKind.Unspecified).AddTicks(3053), 2L, "Et eos dolores ex quaerat.\nNon minus recusandae ullam aperiam.\nIpsam ipsa error itaque eligendi.\nQuod velit exercitationem recusandae voluptas qui.\nConsectetur rerum enim placeat doloribus hic saepe deleniti nihil impedit.", new DateTime(2023, 9, 5, 23, 19, 34, 423, DateTimeKind.Unspecified).AddTicks(6562), false, true, "Ut omnis enim.", 17L },
                    { 35L, 21L, new DateTime(2021, 2, 8, 0, 14, 16, 243, DateTimeKind.Unspecified).AddTicks(1131), 5L, "Quia provident nihil architecto maiores voluptatem repudiandae.", new DateTime(2023, 1, 15, 9, 38, 33, 714, DateTimeKind.Unspecified).AddTicks(8050), false, true, "Non expedita sit tenetur enim quaerat magni.", 39L },
                    { 36L, 7L, new DateTime(2021, 2, 28, 11, 30, 15, 742, DateTimeKind.Unspecified).AddTicks(1052), 2L, "Qui a aut porro est sit in molestiae.\nEt qui tempore esse fuga commodi omnis ut quisquam est.\nNatus tempora suscipit qui mollitia ut.", null, false, true, "Eos repellendus saepe sit assumenda.", 16L },
                    { 37L, 20L, new DateTime(2021, 12, 6, 11, 32, 58, 756, DateTimeKind.Unspecified).AddTicks(2281), 2L, "Omnis ratione qui autem enim provident est.\nAut perspiciatis est asperiores dolorem sunt sint dolorum ex.\nPraesentium officiis ex.\nPerspiciatis cumque repellendus consectetur quos ducimus temporibus debitis doloribus.\nRecusandae repudiandae aut beatae excepturi expedita.", new DateTime(2022, 8, 28, 3, 30, 41, 573, DateTimeKind.Unspecified).AddTicks(8031), false, false, "Et dolor in eveniet ea voluptatem.", 35L },
                    { 38L, 6L, new DateTime(2021, 6, 28, 0, 46, 39, 290, DateTimeKind.Unspecified).AddTicks(3097), 1L, "Et delectus nesciunt autem.\nQuia aut quia eaque minima maiores magni.\nRatione veritatis magnam vitae voluptas odit optio.", new DateTime(2023, 10, 6, 3, 5, 32, 595, DateTimeKind.Unspecified).AddTicks(1434), false, true, "Commodi ipsam eum quaerat tenetur.", 30L },
                    { 39L, 11L, new DateTime(2021, 4, 13, 7, 3, 35, 773, DateTimeKind.Unspecified).AddTicks(6420), 4L, "Ut possimus eius rem reprehenderit est neque optio.\nVeniam accusantium ad quia corporis.\nPlaceat quam nulla.\nEa architecto tempore quasi adipisci saepe quod deserunt magnam.", new DateTime(2022, 11, 1, 18, 34, 19, 372, DateTimeKind.Unspecified).AddTicks(8883), false, true, "Quam officiis nam amet fugiat sit.", 21L },
                    { 40L, 11L, new DateTime(2021, 12, 16, 9, 0, 54, 989, DateTimeKind.Unspecified).AddTicks(1757), 1L, "Cum doloremque maiores.\nSunt iusto quia fugit consequatur sint assumenda doloribus atque.\nQui exercitationem est voluptatem culpa.\nIllo repudiandae quia non magni tempora totam nobis.", new DateTime(2022, 7, 6, 6, 57, 2, 673, DateTimeKind.Unspecified).AddTicks(4606), false, false, "Quos et consequatur.", 33L },
                    { 41L, 7L, new DateTime(2021, 7, 4, 21, 29, 44, 604, DateTimeKind.Unspecified).AddTicks(8805), 1L, "Neque ipsam praesentium et autem.\nVoluptas temporibus veritatis asperiores voluptas nihil est tempore ut.\nOccaecati et labore aperiam quisquam vero nobis dolorum sed laborum.", new DateTime(2022, 12, 5, 15, 19, 31, 468, DateTimeKind.Unspecified).AddTicks(1435), false, true, "Quae nobis ut dolorum blanditiis sed voluptatum odio.", 20L },
                    { 42L, 7L, new DateTime(2021, 4, 1, 18, 58, 51, 127, DateTimeKind.Unspecified).AddTicks(6501), 4L, "Sapiente nisi voluptates mollitia ad corrupti perferendis similique velit.", new DateTime(2022, 12, 8, 22, 13, 19, 490, DateTimeKind.Unspecified).AddTicks(7588), false, true, "Necessitatibus ut repudiandae consequatur dolor esse voluptas ipsa quaerat.", 16L },
                    { 43L, 4L, new DateTime(2021, 11, 9, 6, 57, 3, 393, DateTimeKind.Unspecified).AddTicks(3521), 3L, "Quo rerum cumque et sapiente.\nCorrupti voluptatum doloribus praesentium autem debitis distinctio consectetur.\nDolorem magni quidem aut aut enim odio veniam.", new DateTime(2023, 6, 4, 2, 30, 15, 420, DateTimeKind.Unspecified).AddTicks(641), false, true, "Iure odio nam rerum.", 17L }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsDeleted", "IsPublished", "Title", "UnitId" },
                values: new object[,]
                {
                    { 44L, 14L, new DateTime(2021, 2, 26, 20, 29, 59, 219, DateTimeKind.Unspecified).AddTicks(4177), 4L, "Minima vitae est iusto ratione excepturi facere.\nQuia atque natus nemo.\nNulla in voluptatem.\nId aperiam voluptatem autem quia aliquam.\nIure et tempore.", new DateTime(2023, 1, 20, 5, 32, 24, 706, DateTimeKind.Unspecified).AddTicks(7950), false, false, "Deserunt sed qui libero quas accusantium saepe.", 13L },
                    { 45L, 16L, new DateTime(2021, 10, 24, 10, 54, 26, 326, DateTimeKind.Unspecified).AddTicks(2431), 3L, "Nesciunt provident doloribus labore.", new DateTime(2023, 8, 1, 18, 56, 17, 776, DateTimeKind.Unspecified).AddTicks(8825), false, true, "Dolorem non unde.", 41L },
                    { 46L, 7L, new DateTime(2021, 8, 14, 12, 54, 0, 489, DateTimeKind.Unspecified).AddTicks(9888), 1L, "Quo enim amet corrupti consequatur.", null, false, false, "Odit nihil vero eligendi id tenetur dolorem fuga.", 20L },
                    { 47L, 17L, new DateTime(2021, 3, 25, 16, 31, 29, 597, DateTimeKind.Unspecified).AddTicks(8117), 5L, "Ullam qui corrupti.\nCulpa magnam architecto mollitia quis.", new DateTime(2023, 10, 30, 19, 0, 21, 113, DateTimeKind.Unspecified).AddTicks(3218), false, false, "Laudantium debitis dolorum et dicta molestias.", 14L },
                    { 48L, 19L, new DateTime(2021, 12, 27, 9, 39, 11, 866, DateTimeKind.Unspecified).AddTicks(3985), 3L, "Cupiditate quia quisquam a voluptatibus.\nRecusandae accusamus ipsam.\nA reiciendis odio dolor nulla.\nIste iste nihil unde voluptatem commodi unde et id natus.", null, false, true, "Et placeat itaque amet ad.", 34L },
                    { 49L, 14L, new DateTime(2021, 6, 18, 6, 8, 39, 990, DateTimeKind.Unspecified).AddTicks(3904), 1L, "Qui alias debitis debitis deleniti tenetur voluptas vel et.", new DateTime(2023, 10, 17, 7, 21, 42, 701, DateTimeKind.Unspecified).AddTicks(4021), false, true, "Qui sapiente dolorem eos exercitationem explicabo cupiditate odio.", 13L },
                    { 50L, 20L, new DateTime(2021, 8, 29, 17, 45, 49, 19, DateTimeKind.Unspecified).AddTicks(6526), 5L, "Quia ullam illum soluta.\nVoluptatem praesentium eveniet.", new DateTime(2022, 4, 21, 10, 42, 15, 250, DateTimeKind.Unspecified).AddTicks(231), false, false, "Quam porro recusandae provident maxime.", 31L },
                    { 51L, 20L, new DateTime(2021, 7, 26, 3, 37, 40, 168, DateTimeKind.Unspecified).AddTicks(8371), 4L, "Sunt earum tempore consequatur molestias totam ab.\nVero iste culpa distinctio ad.\nSed dolorem tenetur doloribus sapiente deserunt nam eos fuga.\nQuo rerum eaque omnis voluptas dolor assumenda ut.\nEos voluptatum voluptatem.", new DateTime(2023, 9, 1, 2, 29, 31, 175, DateTimeKind.Unspecified).AddTicks(9669), false, false, "Debitis quae dolores consectetur rem sapiente iste aperiam.", 26L },
                    { 52L, 11L, new DateTime(2021, 5, 30, 12, 49, 5, 83, DateTimeKind.Unspecified).AddTicks(5041), 3L, "Architecto non debitis impedit voluptatem non aut.", new DateTime(2023, 4, 30, 16, 13, 55, 482, DateTimeKind.Unspecified).AddTicks(9494), false, true, "Quia aut eius assumenda cumque architecto corporis.", 33L },
                    { 53L, 5L, new DateTime(2021, 12, 20, 19, 51, 9, 35, DateTimeKind.Unspecified).AddTicks(5559), 1L, "Veniam et ab nostrum qui rerum.\nFugit laboriosam deleniti laudantium ipsum velit adipisci.\nVoluptatem voluptas alias vero sed voluptatibus magnam accusantium aperiam.\nEum temporibus sunt harum eum ad molestiae ratione dolor temporibus.\nDolorem quam accusamus nostrum.", new DateTime(2022, 10, 17, 18, 50, 4, 602, DateTimeKind.Unspecified).AddTicks(7246), false, true, "Facilis eos ipsam quibusdam vel.", 22L },
                    { 54L, 4L, new DateTime(2021, 3, 5, 9, 17, 31, 145, DateTimeKind.Unspecified).AddTicks(9938), 1L, "Eaque sit in.\nPariatur quae atque.\nQuia sed accusantium voluptatem ea distinctio iusto ut magni similique.", new DateTime(2023, 8, 14, 2, 31, 49, 731, DateTimeKind.Unspecified).AddTicks(8841), false, true, "Sed quo officiis omnis quibusdam occaecati maxime.", 17L },
                    { 55L, 11L, new DateTime(2021, 11, 19, 13, 46, 55, 178, DateTimeKind.Unspecified).AddTicks(5038), 3L, "Sit et odio nemo voluptatem eos consequatur culpa deleniti.", new DateTime(2023, 3, 20, 5, 5, 26, 150, DateTimeKind.Unspecified).AddTicks(5764), false, true, "Libero id possimus fugiat voluptatum ea in assumenda possimus.", 28L },
                    { 56L, 14L, new DateTime(2021, 11, 19, 15, 43, 42, 171, DateTimeKind.Unspecified).AddTicks(2793), 1L, "Dolores et aliquam facilis iste et voluptas sit.", new DateTime(2022, 5, 4, 7, 59, 53, 262, DateTimeKind.Unspecified).AddTicks(1837), false, true, "Voluptatibus recusandae officiis accusantium odit perferendis ut dolor enim est.", 15L },
                    { 57L, 15L, new DateTime(2021, 4, 13, 10, 30, 42, 417, DateTimeKind.Unspecified).AddTicks(9730), 4L, "Consequatur sed quaerat repellat ullam sit beatae ducimus.", new DateTime(2023, 10, 15, 3, 3, 39, 878, DateTimeKind.Unspecified).AddTicks(6757), false, true, "Ut tenetur natus quia et consequatur qui esse fugiat rerum.", 37L },
                    { 58L, 7L, new DateTime(2021, 5, 2, 20, 10, 53, 507, DateTimeKind.Unspecified).AddTicks(8685), 3L, "Aperiam tempora placeat.\nQuos et soluta non quam omnis.\nNon quia quibusdam et praesentium sequi.\nConsequuntur rerum inventore.", new DateTime(2023, 12, 11, 6, 8, 50, 739, DateTimeKind.Unspecified).AddTicks(3967), false, false, "Eum cupiditate voluptatum pariatur dolorem.", 20L },
                    { 59L, 6L, new DateTime(2021, 3, 18, 3, 37, 13, 520, DateTimeKind.Unspecified).AddTicks(4200), 1L, "Eveniet cupiditate nesciunt voluptas.", new DateTime(2023, 5, 12, 23, 59, 0, 9, DateTimeKind.Unspecified).AddTicks(7802), false, true, "Necessitatibus ex aperiam magnam non eveniet quas.", 24L },
                    { 60L, 18L, new DateTime(2021, 2, 3, 6, 59, 24, 644, DateTimeKind.Unspecified).AddTicks(3663), 2L, "Consequatur necessitatibus id dignissimos inventore.", new DateTime(2022, 9, 24, 13, 0, 19, 475, DateTimeKind.Unspecified).AddTicks(7829), false, false, "Delectus et quia nulla cumque rerum ab.", 19L },
                    { 61L, 13L, new DateTime(2021, 7, 14, 22, 35, 39, 632, DateTimeKind.Unspecified).AddTicks(5147), 1L, "Ipsa error aut quidem sed recusandae.", new DateTime(2023, 5, 28, 1, 20, 22, 471, DateTimeKind.Unspecified).AddTicks(5315), false, true, "Fugiat non quaerat deleniti delectus.", 3L },
                    { 62L, 13L, new DateTime(2021, 11, 2, 3, 36, 25, 623, DateTimeKind.Unspecified).AddTicks(3553), 4L, "Aut consequuntur dolore dolores vero veritatis commodi minus voluptas et.\nRepellendus consequatur magnam.\nMolestias ea dolores accusantium sed cum hic.", new DateTime(2023, 4, 1, 12, 48, 49, 85, DateTimeKind.Unspecified).AddTicks(9244), false, true, "Qui nobis iusto aut temporibus quo nihil ipsam qui.", 29L },
                    { 63L, 7L, new DateTime(2021, 8, 3, 18, 29, 27, 737, DateTimeKind.Unspecified).AddTicks(1737), 1L, "Est cupiditate delectus.\nQui qui veniam eius suscipit eveniet molestiae possimus aliquam sed.\nIllum quibusdam ab incidunt recusandae.\nUt maiores vitae consequatur tempore deleniti aliquid.", new DateTime(2023, 2, 20, 1, 27, 32, 474, DateTimeKind.Unspecified).AddTicks(3894), false, false, "Velit odit eius reiciendis eveniet.", 20L },
                    { 64L, 2L, new DateTime(2021, 10, 8, 20, 54, 59, 986, DateTimeKind.Unspecified).AddTicks(518), 1L, "Iusto ab aut quis nihil molestiae.\nQui provident nisi ut rerum dolorem ratione laboriosam.", new DateTime(2023, 12, 12, 16, 23, 13, 397, DateTimeKind.Unspecified).AddTicks(7670), false, true, "Debitis provident illo porro at libero commodi error dolore.", 12L },
                    { 65L, 7L, new DateTime(2022, 1, 8, 22, 19, 37, 131, DateTimeKind.Unspecified).AddTicks(5591), 3L, "Ipsam labore et et labore nihil aut dignissimos.\nMolestiae voluptatum laboriosam est rerum similique sint id.\nArchitecto sequi accusantium labore rerum nam soluta repellat.\nDeserunt nostrum iste ut iste et ratione pariatur.", new DateTime(2023, 11, 28, 6, 17, 50, 812, DateTimeKind.Unspecified).AddTicks(1465), false, false, "Eum molestiae quis maxime suscipit autem voluptatem sit repellendus.", 10L },
                    { 66L, 7L, new DateTime(2021, 6, 30, 12, 45, 44, 454, DateTimeKind.Unspecified).AddTicks(6586), 4L, "Culpa quo beatae mollitia assumenda natus labore maxime.\nSequi quia culpa et sed.\nAperiam expedita id ab numquam aut rerum.", new DateTime(2022, 5, 25, 9, 53, 9, 381, DateTimeKind.Unspecified).AddTicks(9528), false, false, "In accusamus voluptates sunt rerum vero assumenda eos cupiditate.", 16L },
                    { 67L, 19L, new DateTime(2021, 12, 13, 0, 12, 36, 882, DateTimeKind.Unspecified).AddTicks(9197), 3L, "Numquam quia sint porro.", new DateTime(2022, 12, 31, 12, 30, 26, 683, DateTimeKind.Unspecified).AddTicks(8164), false, false, "Dolorem molestiae doloremque quo nulla modi et est enim.", 34L },
                    { 68L, 16L, new DateTime(2021, 8, 20, 21, 36, 53, 739, DateTimeKind.Unspecified).AddTicks(5878), 3L, "Iste esse dolorem perferendis delectus aut sint totam.\nSunt quod beatae ipsam et quaerat nisi totam.\nAlias nobis accusantium iusto sed atque voluptas ipsa eius alias.\nQuia iste perspiciatis eos officia debitis ea corrupti.", new DateTime(2022, 5, 4, 2, 33, 33, 302, DateTimeKind.Unspecified).AddTicks(7969), false, true, "Aliquam rem exercitationem.", 41L },
                    { 69L, 11L, new DateTime(2021, 6, 2, 6, 11, 25, 733, DateTimeKind.Unspecified).AddTicks(843), 2L, "Unde exercitationem sit id sed numquam nisi dolore molestiae.\nSint facere iste provident velit itaque qui consectetur.\nVero nisi voluptas libero veniam in ducimus voluptas recusandae vero.\nRatione dignissimos hic eum aut dolore quia voluptatibus possimus.", new DateTime(2022, 5, 18, 22, 33, 57, 790, DateTimeKind.Unspecified).AddTicks(5404), false, false, "Unde voluptates labore quasi natus.", 21L },
                    { 70L, 14L, new DateTime(2021, 3, 17, 21, 0, 7, 821, DateTimeKind.Unspecified).AddTicks(2360), 3L, "Fuga id doloremque tempore quis voluptate reprehenderit quia sint.\nAut ipsum cupiditate hic vel placeat.\nPossimus quo laudantium sed repellat quibusdam.", null, false, true, "Iusto eum aliquid aut molestias aut expedita et.", 13L },
                    { 71L, 7L, new DateTime(2021, 6, 7, 13, 4, 23, 713, DateTimeKind.Unspecified).AddTicks(5650), 1L, "Vitae est id atque odit sequi perferendis eveniet voluptatem nemo.\nNeque omnis dignissimos eveniet adipisci voluptatibus.", new DateTime(2022, 7, 31, 23, 3, 19, 87, DateTimeKind.Unspecified).AddTicks(8477), false, false, "Repellendus ipsa itaque tempora fuga.", 16L },
                    { 72L, 19L, new DateTime(2022, 2, 1, 15, 36, 28, 649, DateTimeKind.Unspecified).AddTicks(681), 2L, "Maiores reiciendis voluptatibus molestiae nulla.\nReiciendis placeat nihil sit porro provident qui rerum pariatur.\nVoluptatibus asperiores dignissimos quibusdam molestiae velit voluptates aut minima ut.\nDolores aperiam aut architecto minus.", new DateTime(2024, 1, 6, 20, 27, 57, 243, DateTimeKind.Unspecified).AddTicks(4950), false, false, "Excepturi eum magnam est omnis incidunt exercitationem voluptas molestiae.", 34L },
                    { 73L, 10L, new DateTime(2021, 2, 15, 4, 41, 52, 442, DateTimeKind.Unspecified).AddTicks(3314), 4L, "Enim suscipit voluptatibus alias molestiae.\nEt consequatur ratione earum blanditiis nulla porro.\nAut maiores similique qui aut harum a neque.\nQuis dolorum cupiditate placeat.\nDolor maiores voluptatum cupiditate modi.", new DateTime(2023, 8, 11, 18, 58, 55, 430, DateTimeKind.Unspecified).AddTicks(206), false, false, "Nesciunt quia et distinctio rerum autem exercitationem molestiae et.", 8L },
                    { 74L, 21L, new DateTime(2021, 8, 15, 14, 6, 4, 856, DateTimeKind.Unspecified).AddTicks(1148), 1L, "Delectus provident consequatur est.\nEum veniam ipsam voluptatem consequuntur optio vel in.", new DateTime(2023, 9, 27, 5, 32, 54, 895, DateTimeKind.Unspecified).AddTicks(3257), false, false, "Voluptatem asperiores tempore nulla cumque.", 39L },
                    { 75L, 13L, new DateTime(2021, 12, 20, 20, 8, 38, 21, DateTimeKind.Unspecified).AddTicks(2165), 3L, "Corrupti commodi qui nostrum suscipit repellendus id consequatur voluptatem omnis.\nItaque ducimus unde et ab qui voluptas excepturi.\nNeque excepturi autem est nihil.", new DateTime(2022, 7, 21, 13, 49, 35, 888, DateTimeKind.Unspecified).AddTicks(8372), false, true, "Tenetur asperiores quis ut id error harum.", 7L },
                    { 76L, 5L, new DateTime(2021, 5, 27, 17, 5, 43, 455, DateTimeKind.Unspecified).AddTicks(2703), 2L, "Et ipsa veritatis.", new DateTime(2023, 1, 5, 2, 9, 54, 327, DateTimeKind.Unspecified).AddTicks(5115), false, false, "Et aliquid distinctio omnis.", 22L },
                    { 77L, 11L, new DateTime(2021, 11, 9, 17, 6, 30, 174, DateTimeKind.Unspecified).AddTicks(1076), 5L, "Maiores consequatur qui aut consequatur sunt autem qui rerum quas.\nExplicabo rerum at itaque.\nCumque rem nostrum cumque laborum nobis.\nVoluptatem quisquam non voluptate reprehenderit aspernatur laboriosam.\nCum omnis nobis.", new DateTime(2023, 8, 20, 14, 58, 10, 942, DateTimeKind.Unspecified).AddTicks(5599), false, false, "Possimus sit voluptatem quibusdam sed consequuntur.", 21L },
                    { 78L, 16L, new DateTime(2021, 6, 16, 0, 16, 26, 622, DateTimeKind.Unspecified).AddTicks(3698), 1L, "Est quo aspernatur.\nUllam enim error vel veniam.\nIn quae corporis et.", new DateTime(2023, 1, 3, 20, 6, 19, 720, DateTimeKind.Unspecified).AddTicks(2969), false, true, "Possimus ab qui omnis esse natus ut dolore.", 41L },
                    { 79L, 20L, new DateTime(2021, 3, 18, 11, 52, 35, 373, DateTimeKind.Unspecified).AddTicks(1015), 1L, "Ratione in et molestiae quo qui quia.\nAperiam itaque qui rerum quia ut.\nMaxime ullam sunt officiis ea qui laborum cupiditate.\nVoluptate eaque et molestias nam.\nExplicabo architecto ipsam distinctio aliquam rem.", null, false, false, "Et et aperiam vero quidem vel rem nemo.", 26L },
                    { 80L, 7L, new DateTime(2022, 1, 28, 0, 42, 13, 607, DateTimeKind.Unspecified).AddTicks(6629), 2L, "Iusto est est provident ab rerum.\nEt iure vel.\nSunt voluptas molestias harum nam perferendis labore nobis exercitationem.", new DateTime(2023, 1, 9, 8, 1, 53, 529, DateTimeKind.Unspecified).AddTicks(832), false, true, "Veritatis sequi exercitationem voluptatum voluptas ratione saepe.", 20L },
                    { 81L, 13L, new DateTime(2021, 8, 21, 13, 7, 1, 386, DateTimeKind.Unspecified).AddTicks(2162), 1L, "Porro quidem impedit aut est quam dolor maiores dolorem cumque.\nQuibusdam accusantium eius.\nDistinctio vel facere et quia eius repudiandae et.\nVoluptatum sint qui.", new DateTime(2023, 6, 13, 6, 42, 56, 229, DateTimeKind.Unspecified).AddTicks(6908), false, true, "Aut natus ullam commodi.", 3L }
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "IsDeleted", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[,]
                {
                    { 2L, 8L, new DateTime(2021, 6, 18, 18, 2, 6, 115, DateTimeKind.Unspecified).AddTicks(2987), 3L, false, new DateTime(2022, 1, 11, 0, 16, 21, 524, DateTimeKind.Unspecified).AddTicks(1073), 6L, new DateTime(2019, 12, 26, 0, 48, 16, 135, DateTimeKind.Unspecified).AddTicks(67), new DateTime(2021, 8, 17, 0, 31, 26, 347, DateTimeKind.Unspecified).AddTicks(8058) },
                    { 3L, 20L, new DateTime(2021, 12, 15, 19, 0, 14, 671, DateTimeKind.Unspecified).AddTicks(1117), 3L, false, new DateTime(2022, 1, 19, 15, 11, 36, 370, DateTimeKind.Unspecified).AddTicks(162), 76L, new DateTime(2019, 6, 27, 6, 18, 15, 285, DateTimeKind.Unspecified).AddTicks(2787), new DateTime(2021, 9, 14, 16, 5, 33, 235, DateTimeKind.Unspecified).AddTicks(9047) },
                    { 4L, 45L, new DateTime(2021, 2, 16, 19, 21, 18, 426, DateTimeKind.Unspecified).AddTicks(4382), 3L, false, new DateTime(2022, 1, 18, 23, 16, 37, 27, DateTimeKind.Unspecified).AddTicks(5956), 59L, new DateTime(2019, 4, 28, 16, 0, 50, 883, DateTimeKind.Unspecified).AddTicks(607), new DateTime(2021, 8, 23, 2, 37, 17, 833, DateTimeKind.Unspecified).AddTicks(8262) },
                    { 5L, 9L, new DateTime(2021, 5, 22, 14, 15, 9, 915, DateTimeKind.Unspecified).AddTicks(3191), 2L, false, new DateTime(2022, 1, 8, 18, 0, 43, 155, DateTimeKind.Unspecified).AddTicks(9820), 42L, new DateTime(2019, 12, 11, 13, 36, 36, 444, DateTimeKind.Unspecified).AddTicks(201), new DateTime(2021, 12, 27, 20, 17, 40, 256, DateTimeKind.Unspecified).AddTicks(5375) },
                    { 6L, 11L, new DateTime(2022, 1, 28, 2, 41, 0, 797, DateTimeKind.Unspecified).AddTicks(9358), 4L, false, new DateTime(2022, 1, 13, 16, 25, 9, 352, DateTimeKind.Unspecified).AddTicks(4791), 3L, new DateTime(2019, 5, 10, 9, 31, 42, 404, DateTimeKind.Unspecified).AddTicks(203), new DateTime(2021, 9, 13, 22, 53, 26, 31, DateTimeKind.Unspecified).AddTicks(4383) },
                    { 7L, 8L, new DateTime(2021, 5, 31, 8, 25, 45, 583, DateTimeKind.Unspecified).AddTicks(7182), 1L, false, new DateTime(2022, 1, 12, 21, 48, 21, 627, DateTimeKind.Unspecified).AddTicks(660), 45L, new DateTime(2019, 8, 18, 1, 52, 19, 111, DateTimeKind.Unspecified).AddTicks(7500), new DateTime(2021, 3, 11, 20, 25, 26, 211, DateTimeKind.Unspecified).AddTicks(412) },
                    { 8L, 21L, new DateTime(2021, 9, 15, 9, 46, 2, 353, DateTimeKind.Unspecified).AddTicks(4500), 1L, false, new DateTime(2022, 1, 11, 19, 6, 46, 6, DateTimeKind.Unspecified).AddTicks(6275), 67L, new DateTime(2020, 1, 23, 6, 53, 47, 199, DateTimeKind.Unspecified).AddTicks(2844), new DateTime(2021, 8, 1, 1, 33, 49, 717, DateTimeKind.Unspecified).AddTicks(2438) },
                    { 9L, 42L, new DateTime(2021, 12, 27, 5, 6, 53, 347, DateTimeKind.Unspecified).AddTicks(8906), 3L, false, new DateTime(2022, 1, 27, 18, 23, 22, 945, DateTimeKind.Unspecified).AddTicks(3079), 8L, new DateTime(2019, 12, 14, 5, 58, 49, 714, DateTimeKind.Unspecified).AddTicks(8551), new DateTime(2021, 5, 9, 23, 57, 53, 935, DateTimeKind.Unspecified).AddTicks(7873) },
                    { 10L, 28L, new DateTime(2021, 5, 4, 23, 3, 39, 632, DateTimeKind.Unspecified).AddTicks(5361), 5L, false, new DateTime(2022, 1, 30, 7, 34, 17, 768, DateTimeKind.Unspecified).AddTicks(7614), 28L, new DateTime(2019, 9, 14, 17, 12, 51, 224, DateTimeKind.Unspecified).AddTicks(4248), new DateTime(2021, 11, 19, 3, 3, 10, 385, DateTimeKind.Unspecified).AddTicks(8161) },
                    { 11L, 19L, new DateTime(2021, 6, 28, 21, 14, 40, 106, DateTimeKind.Unspecified).AddTicks(5473), 5L, false, new DateTime(2022, 1, 8, 11, 44, 2, 619, DateTimeKind.Unspecified).AddTicks(528), 51L, new DateTime(2019, 3, 21, 13, 27, 18, 761, DateTimeKind.Unspecified).AddTicks(2673), new DateTime(2021, 7, 20, 1, 56, 10, 643, DateTimeKind.Unspecified).AddTicks(9483) },
                    { 12L, 10L, new DateTime(2021, 3, 3, 20, 1, 13, 761, DateTimeKind.Unspecified).AddTicks(8678), 2L, false, new DateTime(2022, 1, 15, 8, 30, 42, 917, DateTimeKind.Unspecified).AddTicks(2092), 12L, new DateTime(2019, 3, 23, 1, 41, 41, 976, DateTimeKind.Unspecified).AddTicks(6419), new DateTime(2021, 7, 26, 18, 7, 42, 831, DateTimeKind.Unspecified).AddTicks(6378) },
                    { 13L, 11L, new DateTime(2021, 9, 18, 7, 49, 58, 629, DateTimeKind.Unspecified).AddTicks(9631), 2L, false, new DateTime(2022, 2, 1, 17, 40, 23, 513, DateTimeKind.Unspecified).AddTicks(5926), 52L, new DateTime(2019, 7, 14, 9, 38, 49, 510, DateTimeKind.Unspecified).AddTicks(1328), new DateTime(2021, 1, 6, 2, 2, 58, 405, DateTimeKind.Unspecified).AddTicks(1646) },
                    { 14L, 33L, new DateTime(2021, 5, 23, 21, 31, 27, 8, DateTimeKind.Unspecified).AddTicks(8312), 1L, false, new DateTime(2022, 1, 16, 13, 42, 7, 686, DateTimeKind.Unspecified).AddTicks(780), 37L, new DateTime(2019, 5, 13, 10, 3, 53, 574, DateTimeKind.Unspecified).AddTicks(3551), new DateTime(2021, 4, 10, 1, 5, 22, 531, DateTimeKind.Unspecified).AddTicks(6126) },
                    { 15L, 31L, new DateTime(2021, 7, 27, 15, 9, 33, 82, DateTimeKind.Unspecified).AddTicks(6140), 1L, false, new DateTime(2022, 1, 11, 6, 55, 11, 280, DateTimeKind.Unspecified).AddTicks(1400), 38L, new DateTime(2019, 6, 15, 11, 31, 56, 202, DateTimeKind.Unspecified).AddTicks(8759), new DateTime(2021, 8, 4, 2, 33, 58, 145, DateTimeKind.Unspecified).AddTicks(6314) },
                    { 16L, 33L, new DateTime(2021, 10, 31, 7, 32, 50, 156, DateTimeKind.Unspecified).AddTicks(9252), 5L, false, new DateTime(2022, 1, 9, 23, 9, 7, 143, DateTimeKind.Unspecified).AddTicks(5339), 73L, new DateTime(2019, 7, 28, 13, 52, 38, 822, DateTimeKind.Unspecified).AddTicks(7073), new DateTime(2021, 3, 29, 4, 30, 7, 451, DateTimeKind.Unspecified).AddTicks(4658) },
                    { 17L, 18L, new DateTime(2021, 11, 5, 1, 8, 58, 977, DateTimeKind.Unspecified).AddTicks(691), 3L, false, new DateTime(2022, 1, 4, 21, 45, 54, 652, DateTimeKind.Unspecified).AddTicks(8481), 11L, new DateTime(2019, 7, 4, 21, 9, 49, 32, DateTimeKind.Unspecified).AddTicks(6080), new DateTime(2021, 12, 31, 5, 8, 2, 686, DateTimeKind.Unspecified).AddTicks(8024) },
                    { 18L, 8L, new DateTime(2021, 9, 1, 19, 49, 20, 960, DateTimeKind.Unspecified).AddTicks(9057), 5L, false, null, 49L, new DateTime(2019, 9, 29, 18, 55, 1, 684, DateTimeKind.Unspecified).AddTicks(2355), new DateTime(2021, 11, 10, 17, 55, 28, 503, DateTimeKind.Unspecified).AddTicks(5344) },
                    { 19L, 42L, new DateTime(2021, 12, 29, 13, 26, 32, 869, DateTimeKind.Unspecified).AddTicks(9048), 2L, false, new DateTime(2022, 1, 31, 4, 38, 30, 188, DateTimeKind.Unspecified).AddTicks(2685), 38L, new DateTime(2019, 9, 1, 19, 38, 0, 938, DateTimeKind.Unspecified).AddTicks(2410), new DateTime(2021, 10, 2, 15, 6, 47, 783, DateTimeKind.Unspecified).AddTicks(2490) },
                    { 20L, 19L, new DateTime(2021, 4, 2, 18, 38, 28, 977, DateTimeKind.Unspecified).AddTicks(6903), 4L, false, new DateTime(2022, 1, 11, 2, 28, 55, 828, DateTimeKind.Unspecified).AddTicks(6631), 79L, new DateTime(2019, 2, 8, 23, 11, 42, 206, DateTimeKind.Unspecified).AddTicks(6639), new DateTime(2021, 6, 22, 14, 59, 38, 784, DateTimeKind.Unspecified).AddTicks(5297) },
                    { 21L, 18L, new DateTime(2021, 7, 27, 8, 41, 36, 650, DateTimeKind.Unspecified).AddTicks(145), 2L, false, new DateTime(2022, 1, 22, 1, 46, 3, 832, DateTimeKind.Unspecified).AddTicks(2726), 52L, new DateTime(2019, 10, 2, 22, 29, 24, 570, DateTimeKind.Unspecified).AddTicks(9802), new DateTime(2021, 3, 25, 22, 5, 14, 76, DateTimeKind.Unspecified).AddTicks(2521) },
                    { 22L, 27L, new DateTime(2021, 3, 3, 15, 58, 13, 151, DateTimeKind.Unspecified).AddTicks(9508), 2L, false, new DateTime(2022, 1, 17, 5, 28, 49, 683, DateTimeKind.Unspecified).AddTicks(8614), 78L, new DateTime(2020, 1, 24, 22, 35, 0, 817, DateTimeKind.Unspecified).AddTicks(2757), new DateTime(2021, 1, 29, 9, 34, 43, 266, DateTimeKind.Unspecified).AddTicks(1655) },
                    { 23L, 49L, new DateTime(2021, 12, 16, 13, 47, 8, 428, DateTimeKind.Unspecified).AddTicks(7237), 3L, false, new DateTime(2022, 1, 27, 7, 24, 19, 505, DateTimeKind.Unspecified).AddTicks(1383), 30L, new DateTime(2019, 10, 25, 23, 43, 57, 704, DateTimeKind.Unspecified).AddTicks(3943), new DateTime(2021, 11, 11, 1, 53, 59, 316, DateTimeKind.Unspecified).AddTicks(8392) },
                    { 24L, 41L, new DateTime(2021, 9, 16, 9, 26, 9, 970, DateTimeKind.Unspecified).AddTicks(1765), 5L, false, new DateTime(2022, 1, 18, 2, 12, 34, 800, DateTimeKind.Unspecified).AddTicks(9120), 52L, new DateTime(2019, 6, 5, 22, 26, 42, 67, DateTimeKind.Unspecified).AddTicks(537), new DateTime(2021, 1, 11, 2, 57, 5, 628, DateTimeKind.Unspecified).AddTicks(9532) },
                    { 25L, 48L, new DateTime(2021, 4, 20, 9, 38, 12, 466, DateTimeKind.Unspecified).AddTicks(8816), 1L, false, new DateTime(2022, 1, 24, 19, 7, 28, 138, DateTimeKind.Unspecified).AddTicks(23), 28L, new DateTime(2019, 12, 19, 9, 52, 14, 122, DateTimeKind.Unspecified).AddTicks(7071), new DateTime(2021, 2, 15, 9, 26, 54, 733, DateTimeKind.Unspecified).AddTicks(8444) },
                    { 26L, 49L, new DateTime(2022, 1, 23, 12, 32, 28, 315, DateTimeKind.Unspecified).AddTicks(3837), 3L, false, new DateTime(2022, 1, 18, 16, 16, 9, 838, DateTimeKind.Unspecified).AddTicks(5675), 51L, new DateTime(2019, 9, 10, 20, 34, 11, 100, DateTimeKind.Unspecified).AddTicks(2885), new DateTime(2021, 6, 4, 18, 8, 17, 234, DateTimeKind.Unspecified).AddTicks(9516) },
                    { 27L, 9L, new DateTime(2021, 2, 12, 5, 19, 50, 269, DateTimeKind.Unspecified).AddTicks(6878), 5L, false, new DateTime(2022, 1, 22, 11, 4, 12, 857, DateTimeKind.Unspecified).AddTicks(6426), 70L, new DateTime(2020, 1, 1, 23, 12, 28, 684, DateTimeKind.Unspecified).AddTicks(4243), new DateTime(2021, 5, 25, 21, 46, 57, 447, DateTimeKind.Unspecified).AddTicks(6393) },
                    { 28L, 6L, new DateTime(2021, 9, 10, 4, 26, 45, 827, DateTimeKind.Unspecified).AddTicks(916), 4L, false, new DateTime(2022, 2, 1, 2, 14, 34, 4, DateTimeKind.Unspecified).AddTicks(8521), 41L, new DateTime(2019, 4, 23, 12, 27, 41, 123, DateTimeKind.Unspecified).AddTicks(4188), new DateTime(2021, 7, 12, 22, 41, 55, 890, DateTimeKind.Unspecified).AddTicks(5827) },
                    { 29L, 12L, new DateTime(2021, 2, 25, 10, 34, 50, 809, DateTimeKind.Unspecified).AddTicks(4643), 5L, false, new DateTime(2022, 1, 20, 4, 7, 44, 403, DateTimeKind.Unspecified).AddTicks(5900), 40L, new DateTime(2019, 11, 28, 7, 39, 15, 896, DateTimeKind.Unspecified).AddTicks(8970), new DateTime(2021, 2, 16, 11, 56, 51, 676, DateTimeKind.Unspecified).AddTicks(7204) },
                    { 30L, 42L, new DateTime(2022, 1, 16, 19, 32, 53, 840, DateTimeKind.Unspecified).AddTicks(1681), 1L, false, new DateTime(2022, 1, 16, 16, 5, 40, 345, DateTimeKind.Unspecified).AddTicks(595), 59L, new DateTime(2019, 4, 28, 21, 39, 33, 497, DateTimeKind.Unspecified).AddTicks(396), new DateTime(2021, 1, 13, 11, 36, 17, 447, DateTimeKind.Unspecified).AddTicks(3653) },
                    { 31L, 49L, new DateTime(2021, 10, 26, 16, 24, 25, 788, DateTimeKind.Unspecified).AddTicks(4023), 2L, false, new DateTime(2022, 1, 25, 23, 35, 2, 926, DateTimeKind.Unspecified).AddTicks(6872), 35L, new DateTime(2019, 8, 27, 18, 37, 3, 897, DateTimeKind.Unspecified).AddTicks(5241), new DateTime(2021, 7, 5, 11, 29, 42, 763, DateTimeKind.Unspecified).AddTicks(2858) },
                    { 32L, 20L, new DateTime(2021, 3, 9, 8, 27, 14, 660, DateTimeKind.Unspecified).AddTicks(7246), 4L, false, new DateTime(2022, 1, 4, 21, 22, 15, 583, DateTimeKind.Unspecified).AddTicks(1758), 65L, new DateTime(2019, 11, 8, 20, 46, 41, 470, DateTimeKind.Unspecified).AddTicks(672), new DateTime(2021, 10, 9, 15, 43, 9, 343, DateTimeKind.Unspecified).AddTicks(7768) },
                    { 33L, 2L, new DateTime(2021, 6, 28, 16, 51, 30, 781, DateTimeKind.Unspecified).AddTicks(1984), 5L, false, new DateTime(2022, 1, 18, 13, 10, 14, 993, DateTimeKind.Unspecified).AddTicks(8968), 19L, new DateTime(2019, 5, 21, 5, 49, 9, 963, DateTimeKind.Unspecified).AddTicks(5839), new DateTime(2021, 2, 26, 19, 46, 8, 48, DateTimeKind.Unspecified).AddTicks(2525) },
                    { 34L, 20L, new DateTime(2022, 1, 12, 2, 41, 4, 945, DateTimeKind.Unspecified).AddTicks(8513), 1L, false, new DateTime(2022, 1, 24, 1, 30, 5, 461, DateTimeKind.Unspecified).AddTicks(471), 31L, new DateTime(2019, 9, 2, 17, 4, 2, 533, DateTimeKind.Unspecified).AddTicks(254), new DateTime(2021, 9, 26, 5, 36, 2, 466, DateTimeKind.Unspecified).AddTicks(9497) },
                    { 35L, 37L, new DateTime(2021, 4, 27, 21, 10, 12, 516, DateTimeKind.Unspecified).AddTicks(9304), 3L, false, new DateTime(2022, 1, 28, 14, 28, 7, 626, DateTimeKind.Unspecified).AddTicks(8525), 27L, new DateTime(2019, 9, 29, 21, 24, 17, 991, DateTimeKind.Unspecified).AddTicks(1218), new DateTime(2021, 12, 5, 11, 22, 47, 958, DateTimeKind.Unspecified).AddTicks(119) },
                    { 36L, 20L, new DateTime(2021, 2, 14, 19, 33, 5, 714, DateTimeKind.Unspecified).AddTicks(6561), 3L, false, new DateTime(2022, 1, 5, 13, 26, 29, 640, DateTimeKind.Unspecified).AddTicks(7532), 47L, new DateTime(2019, 3, 14, 14, 3, 55, 47, DateTimeKind.Unspecified).AddTicks(6456), new DateTime(2021, 5, 1, 8, 45, 12, 891, DateTimeKind.Unspecified).AddTicks(8511) },
                    { 37L, 10L, new DateTime(2021, 11, 15, 12, 38, 50, 554, DateTimeKind.Unspecified).AddTicks(2279), 1L, false, new DateTime(2022, 1, 27, 3, 58, 21, 593, DateTimeKind.Unspecified).AddTicks(1643), 31L, new DateTime(2019, 9, 29, 11, 42, 33, 5, DateTimeKind.Unspecified).AddTicks(146), new DateTime(2021, 8, 3, 2, 16, 56, 721, DateTimeKind.Unspecified).AddTicks(5594) },
                    { 38L, 36L, new DateTime(2021, 3, 23, 22, 0, 40, 90, DateTimeKind.Unspecified).AddTicks(5322), 5L, false, new DateTime(2022, 2, 1, 12, 18, 27, 396, DateTimeKind.Unspecified).AddTicks(1062), 12L, new DateTime(2019, 5, 24, 21, 0, 21, 886, DateTimeKind.Unspecified).AddTicks(6998), new DateTime(2021, 3, 8, 15, 51, 54, 788, DateTimeKind.Unspecified).AddTicks(7243) },
                    { 39L, 48L, new DateTime(2021, 9, 14, 12, 12, 38, 458, DateTimeKind.Unspecified).AddTicks(3085), 1L, false, new DateTime(2022, 1, 3, 3, 53, 28, 895, DateTimeKind.Unspecified).AddTicks(8180), 10L, new DateTime(2019, 6, 24, 11, 25, 56, 908, DateTimeKind.Unspecified).AddTicks(9887), new DateTime(2021, 1, 24, 11, 41, 51, 441, DateTimeKind.Unspecified).AddTicks(4501) },
                    { 40L, 5L, new DateTime(2021, 3, 29, 13, 26, 11, 536, DateTimeKind.Unspecified).AddTicks(8884), 2L, false, new DateTime(2022, 1, 30, 16, 36, 42, 394, DateTimeKind.Unspecified).AddTicks(3449), 32L, new DateTime(2019, 5, 17, 12, 56, 32, 772, DateTimeKind.Unspecified).AddTicks(3252), new DateTime(2021, 10, 13, 1, 8, 59, 791, DateTimeKind.Unspecified).AddTicks(659) },
                    { 41L, 29L, new DateTime(2021, 2, 11, 15, 20, 45, 859, DateTimeKind.Unspecified).AddTicks(9750), 5L, false, new DateTime(2022, 1, 25, 10, 3, 7, 78, DateTimeKind.Unspecified).AddTicks(4094), 42L, new DateTime(2019, 12, 4, 12, 48, 7, 736, DateTimeKind.Unspecified).AddTicks(3598), new DateTime(2021, 10, 3, 20, 55, 41, 754, DateTimeKind.Unspecified).AddTicks(7249) },
                    { 42L, 18L, new DateTime(2021, 5, 1, 15, 7, 55, 913, DateTimeKind.Unspecified).AddTicks(9195), 1L, false, new DateTime(2022, 1, 29, 16, 5, 34, 571, DateTimeKind.Unspecified).AddTicks(3230), 19L, new DateTime(2019, 3, 10, 12, 18, 53, 532, DateTimeKind.Unspecified).AddTicks(1543), new DateTime(2021, 8, 25, 8, 55, 55, 48, DateTimeKind.Unspecified).AddTicks(143) },
                    { 43L, 27L, new DateTime(2021, 11, 5, 7, 28, 9, 139, DateTimeKind.Unspecified).AddTicks(9419), 1L, false, new DateTime(2022, 1, 27, 13, 25, 43, 197, DateTimeKind.Unspecified).AddTicks(7944), 12L, new DateTime(2019, 8, 31, 10, 7, 51, 714, DateTimeKind.Unspecified).AddTicks(8861), new DateTime(2021, 4, 12, 22, 19, 44, 430, DateTimeKind.Unspecified).AddTicks(3729) }
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "IsDeleted", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[,]
                {
                    { 44L, 24L, new DateTime(2021, 10, 8, 18, 16, 8, 845, DateTimeKind.Unspecified).AddTicks(8317), 1L, false, new DateTime(2022, 1, 31, 2, 28, 17, 595, DateTimeKind.Unspecified).AddTicks(7584), 29L, new DateTime(2019, 9, 11, 0, 23, 9, 64, DateTimeKind.Unspecified).AddTicks(8059), new DateTime(2021, 6, 7, 23, 1, 26, 5, DateTimeKind.Unspecified).AddTicks(3389) },
                    { 45L, 20L, new DateTime(2021, 12, 26, 18, 50, 7, 732, DateTimeKind.Unspecified).AddTicks(4602), 2L, false, new DateTime(2022, 1, 2, 19, 39, 50, 892, DateTimeKind.Unspecified).AddTicks(8649), 12L, new DateTime(2019, 2, 20, 6, 38, 18, 828, DateTimeKind.Unspecified).AddTicks(9020), new DateTime(2021, 2, 20, 0, 4, 12, 773, DateTimeKind.Unspecified).AddTicks(7246) },
                    { 46L, 12L, new DateTime(2021, 8, 6, 16, 24, 42, 707, DateTimeKind.Unspecified).AddTicks(5220), 1L, false, new DateTime(2022, 1, 18, 4, 3, 1, 879, DateTimeKind.Unspecified).AddTicks(3529), 55L, new DateTime(2019, 11, 27, 23, 22, 27, 64, DateTimeKind.Unspecified).AddTicks(4016), new DateTime(2021, 2, 4, 7, 13, 54, 827, DateTimeKind.Unspecified).AddTicks(8986) },
                    { 47L, 29L, new DateTime(2022, 1, 22, 23, 34, 6, 910, DateTimeKind.Unspecified).AddTicks(4551), 2L, false, new DateTime(2022, 1, 9, 10, 31, 56, 361, DateTimeKind.Unspecified).AddTicks(39), 76L, new DateTime(2019, 5, 20, 13, 32, 27, 112, DateTimeKind.Unspecified).AddTicks(391), new DateTime(2021, 3, 4, 7, 21, 36, 974, DateTimeKind.Unspecified).AddTicks(4165) },
                    { 48L, 30L, new DateTime(2021, 7, 12, 16, 0, 23, 244, DateTimeKind.Unspecified).AddTicks(5061), 3L, false, new DateTime(2022, 1, 13, 5, 25, 8, 773, DateTimeKind.Unspecified).AddTicks(5327), 41L, new DateTime(2019, 5, 12, 5, 54, 44, 806, DateTimeKind.Unspecified).AddTicks(7889), new DateTime(2021, 7, 9, 20, 7, 28, 3, DateTimeKind.Unspecified).AddTicks(487) },
                    { 49L, 10L, new DateTime(2021, 10, 17, 18, 35, 23, 438, DateTimeKind.Unspecified).AddTicks(3224), 2L, false, new DateTime(2022, 1, 19, 12, 17, 13, 958, DateTimeKind.Unspecified).AddTicks(8461), 13L, new DateTime(2019, 7, 31, 8, 42, 32, 80, DateTimeKind.Unspecified).AddTicks(8947), new DateTime(2021, 7, 30, 18, 49, 45, 49, DateTimeKind.Unspecified).AddTicks(9841) },
                    { 50L, 31L, new DateTime(2021, 5, 11, 6, 2, 30, 86, DateTimeKind.Unspecified).AddTicks(9852), 1L, false, new DateTime(2022, 1, 4, 20, 15, 27, 668, DateTimeKind.Unspecified).AddTicks(9645), 61L, new DateTime(2019, 2, 13, 13, 14, 24, 405, DateTimeKind.Unspecified).AddTicks(6602), new DateTime(2021, 9, 23, 17, 30, 22, 332, DateTimeKind.Unspecified).AddTicks(3028) },
                    { 51L, 5L, new DateTime(2022, 1, 26, 8, 12, 8, 286, DateTimeKind.Unspecified).AddTicks(8031), 4L, false, new DateTime(2022, 1, 23, 0, 0, 42, 421, DateTimeKind.Unspecified).AddTicks(4155), 29L, new DateTime(2019, 9, 15, 17, 0, 28, 278, DateTimeKind.Unspecified).AddTicks(4643), new DateTime(2021, 6, 14, 1, 6, 10, 909, DateTimeKind.Unspecified).AddTicks(1414) },
                    { 52L, 39L, new DateTime(2021, 5, 26, 1, 21, 8, 813, DateTimeKind.Unspecified).AddTicks(223), 3L, false, new DateTime(2022, 1, 7, 15, 39, 36, 428, DateTimeKind.Unspecified).AddTicks(135), 17L, new DateTime(2019, 4, 19, 6, 0, 35, 653, DateTimeKind.Unspecified).AddTicks(4478), new DateTime(2021, 1, 11, 17, 36, 45, 532, DateTimeKind.Unspecified).AddTicks(1959) },
                    { 53L, 6L, new DateTime(2021, 7, 10, 13, 1, 15, 189, DateTimeKind.Unspecified).AddTicks(9043), 2L, false, new DateTime(2022, 1, 25, 23, 47, 33, 458, DateTimeKind.Unspecified).AddTicks(1226), 70L, new DateTime(2019, 7, 11, 23, 42, 32, 503, DateTimeKind.Unspecified).AddTicks(7701), new DateTime(2021, 12, 23, 11, 57, 27, 805, DateTimeKind.Unspecified).AddTicks(8747) },
                    { 54L, 42L, new DateTime(2021, 2, 5, 16, 4, 38, 692, DateTimeKind.Unspecified).AddTicks(4870), 3L, false, new DateTime(2022, 1, 27, 12, 11, 49, 461, DateTimeKind.Unspecified).AddTicks(2296), 77L, new DateTime(2019, 4, 22, 13, 5, 45, 108, DateTimeKind.Unspecified).AddTicks(4967), new DateTime(2021, 12, 21, 0, 43, 26, 931, DateTimeKind.Unspecified).AddTicks(230) },
                    { 55L, 42L, new DateTime(2021, 12, 3, 6, 58, 1, 323, DateTimeKind.Unspecified).AddTicks(3135), 3L, false, new DateTime(2022, 1, 24, 14, 44, 32, 74, DateTimeKind.Unspecified).AddTicks(2190), 22L, new DateTime(2019, 8, 10, 1, 12, 22, 926, DateTimeKind.Unspecified).AddTicks(2345), new DateTime(2021, 8, 26, 16, 51, 12, 35, DateTimeKind.Unspecified).AddTicks(921) },
                    { 56L, 48L, new DateTime(2021, 4, 24, 9, 24, 48, 173, DateTimeKind.Unspecified).AddTicks(5974), 3L, false, new DateTime(2022, 1, 13, 23, 33, 25, 272, DateTimeKind.Unspecified).AddTicks(3385), 45L, new DateTime(2019, 4, 14, 12, 18, 33, 744, DateTimeKind.Unspecified).AddTicks(8949), new DateTime(2021, 7, 24, 11, 51, 11, 879, DateTimeKind.Unspecified).AddTicks(8911) },
                    { 57L, 49L, new DateTime(2021, 7, 24, 13, 21, 8, 78, DateTimeKind.Unspecified).AddTicks(1037), 4L, false, new DateTime(2022, 1, 28, 1, 54, 12, 182, DateTimeKind.Unspecified).AddTicks(9533), 34L, new DateTime(2019, 11, 23, 12, 56, 47, 313, DateTimeKind.Unspecified).AddTicks(3850), new DateTime(2021, 6, 6, 21, 40, 0, 37, DateTimeKind.Unspecified).AddTicks(1492) },
                    { 58L, 27L, new DateTime(2021, 3, 27, 14, 50, 18, 872, DateTimeKind.Unspecified).AddTicks(5795), 2L, false, new DateTime(2022, 1, 16, 15, 11, 4, 323, DateTimeKind.Unspecified).AddTicks(7205), 78L, new DateTime(2019, 12, 18, 21, 3, 35, 69, DateTimeKind.Unspecified).AddTicks(8806), new DateTime(2021, 2, 14, 11, 39, 19, 59, DateTimeKind.Unspecified).AddTicks(1745) },
                    { 59L, 24L, new DateTime(2021, 10, 15, 12, 17, 50, 1, DateTimeKind.Unspecified).AddTicks(4991), 5L, false, null, 35L, new DateTime(2019, 6, 27, 16, 0, 12, 944, DateTimeKind.Unspecified).AddTicks(6223), new DateTime(2021, 3, 21, 13, 12, 2, 324, DateTimeKind.Unspecified).AddTicks(5157) },
                    { 60L, 24L, new DateTime(2021, 11, 5, 17, 15, 53, 191, DateTimeKind.Unspecified).AddTicks(2914), 4L, false, new DateTime(2022, 1, 27, 8, 20, 40, 427, DateTimeKind.Unspecified).AddTicks(4574), 17L, new DateTime(2019, 8, 5, 22, 28, 42, 729, DateTimeKind.Unspecified).AddTicks(9680), new DateTime(2021, 8, 13, 8, 21, 6, 80, DateTimeKind.Unspecified).AddTicks(239) },
                    { 61L, 6L, new DateTime(2022, 1, 6, 22, 9, 58, 974, DateTimeKind.Unspecified).AddTicks(7270), 1L, false, new DateTime(2022, 1, 20, 23, 12, 49, 739, DateTimeKind.Unspecified).AddTicks(4298), 66L, new DateTime(2019, 8, 31, 7, 2, 19, 855, DateTimeKind.Unspecified).AddTicks(3251), new DateTime(2021, 1, 19, 18, 2, 10, 465, DateTimeKind.Unspecified).AddTicks(7478) },
                    { 62L, 40L, new DateTime(2021, 3, 29, 14, 21, 42, 512, DateTimeKind.Unspecified).AddTicks(7875), 4L, false, new DateTime(2022, 2, 1, 19, 19, 27, 717, DateTimeKind.Unspecified).AddTicks(9258), 32L, new DateTime(2020, 1, 30, 23, 6, 0, 448, DateTimeKind.Unspecified).AddTicks(8313), new DateTime(2021, 3, 18, 21, 45, 21, 424, DateTimeKind.Unspecified).AddTicks(6638) },
                    { 63L, 10L, new DateTime(2021, 4, 24, 21, 47, 25, 246, DateTimeKind.Unspecified).AddTicks(3620), 2L, false, new DateTime(2022, 1, 18, 2, 59, 11, 888, DateTimeKind.Unspecified).AddTicks(2965), 37L, new DateTime(2019, 9, 25, 22, 41, 41, 599, DateTimeKind.Unspecified).AddTicks(5317), new DateTime(2021, 7, 21, 16, 32, 9, 10, DateTimeKind.Unspecified).AddTicks(1910) },
                    { 64L, 31L, new DateTime(2021, 2, 26, 3, 24, 35, 267, DateTimeKind.Unspecified).AddTicks(6425), 1L, false, new DateTime(2022, 1, 5, 3, 0, 37, 0, DateTimeKind.Unspecified).AddTicks(4883), 11L, new DateTime(2019, 7, 18, 21, 38, 13, 270, DateTimeKind.Unspecified).AddTicks(4782), new DateTime(2021, 7, 19, 9, 15, 27, 713, DateTimeKind.Unspecified).AddTicks(3098) },
                    { 65L, 18L, new DateTime(2021, 4, 17, 22, 45, 44, 614, DateTimeKind.Unspecified).AddTicks(5886), 4L, false, new DateTime(2022, 1, 22, 20, 15, 45, 897, DateTimeKind.Unspecified).AddTicks(5521), 67L, new DateTime(2019, 8, 7, 20, 58, 1, 305, DateTimeKind.Unspecified).AddTicks(845), new DateTime(2021, 4, 1, 0, 42, 48, 133, DateTimeKind.Unspecified).AddTicks(7279) },
                    { 66L, 23L, new DateTime(2021, 12, 21, 12, 4, 53, 977, DateTimeKind.Unspecified).AddTicks(1825), 3L, false, new DateTime(2022, 1, 3, 21, 46, 37, 211, DateTimeKind.Unspecified).AddTicks(964), 18L, new DateTime(2019, 11, 26, 9, 56, 29, 854, DateTimeKind.Unspecified).AddTicks(97), new DateTime(2021, 4, 18, 15, 39, 35, 901, DateTimeKind.Unspecified).AddTicks(801) },
                    { 67L, 34L, new DateTime(2021, 2, 11, 10, 0, 28, 901, DateTimeKind.Unspecified).AddTicks(4358), 1L, false, new DateTime(2022, 1, 6, 11, 34, 51, 804, DateTimeKind.Unspecified).AddTicks(8203), 75L, new DateTime(2019, 2, 15, 19, 2, 45, 646, DateTimeKind.Unspecified).AddTicks(3942), new DateTime(2021, 12, 23, 3, 2, 31, 138, DateTimeKind.Unspecified).AddTicks(4732) },
                    { 68L, 35L, new DateTime(2021, 3, 16, 0, 54, 7, 383, DateTimeKind.Unspecified).AddTicks(5543), 3L, false, new DateTime(2022, 1, 27, 20, 18, 54, 594, DateTimeKind.Unspecified).AddTicks(3762), 57L, new DateTime(2019, 5, 12, 8, 46, 50, 939, DateTimeKind.Unspecified).AddTicks(2775), new DateTime(2021, 11, 6, 15, 49, 22, 586, DateTimeKind.Unspecified).AddTicks(7334) },
                    { 69L, 36L, new DateTime(2021, 7, 24, 1, 39, 36, 882, DateTimeKind.Unspecified).AddTicks(3294), 3L, false, new DateTime(2022, 1, 7, 4, 23, 49, 928, DateTimeKind.Unspecified).AddTicks(7900), 17L, new DateTime(2019, 12, 15, 18, 14, 40, 835, DateTimeKind.Unspecified).AddTicks(2046), new DateTime(2021, 1, 22, 22, 4, 42, 50, DateTimeKind.Unspecified).AddTicks(2338) },
                    { 70L, 19L, new DateTime(2021, 10, 2, 1, 15, 7, 757, DateTimeKind.Unspecified).AddTicks(9296), 2L, false, new DateTime(2022, 1, 17, 22, 0, 50, 584, DateTimeKind.Unspecified).AddTicks(1386), 8L, new DateTime(2019, 4, 19, 4, 45, 26, 609, DateTimeKind.Unspecified).AddTicks(9086), new DateTime(2021, 9, 28, 6, 34, 43, 340, DateTimeKind.Unspecified).AddTicks(4711) },
                    { 71L, 49L, new DateTime(2021, 7, 9, 16, 25, 59, 548, DateTimeKind.Unspecified).AddTicks(226), 2L, false, new DateTime(2022, 1, 13, 4, 4, 28, 159, DateTimeKind.Unspecified).AddTicks(5930), 16L, new DateTime(2020, 1, 25, 21, 18, 19, 729, DateTimeKind.Unspecified).AddTicks(8985), new DateTime(2021, 1, 5, 13, 25, 3, 514, DateTimeKind.Unspecified).AddTicks(24) },
                    { 72L, 51L, new DateTime(2021, 8, 5, 8, 39, 18, 983, DateTimeKind.Unspecified).AddTicks(5714), 1L, false, new DateTime(2022, 1, 24, 12, 17, 7, 280, DateTimeKind.Unspecified).AddTicks(9905), 19L, new DateTime(2019, 11, 28, 19, 20, 47, 518, DateTimeKind.Unspecified).AddTicks(5391), new DateTime(2021, 9, 16, 13, 52, 48, 45, DateTimeKind.Unspecified).AddTicks(3891) },
                    { 73L, 2L, new DateTime(2021, 4, 26, 2, 50, 40, 888, DateTimeKind.Unspecified).AddTicks(2919), 3L, false, new DateTime(2022, 1, 4, 12, 53, 18, 231, DateTimeKind.Unspecified).AddTicks(8394), 2L, new DateTime(2019, 4, 12, 1, 53, 37, 701, DateTimeKind.Unspecified).AddTicks(3861), new DateTime(2021, 3, 17, 4, 47, 45, 572, DateTimeKind.Unspecified).AddTicks(6230) },
                    { 74L, 21L, new DateTime(2021, 6, 10, 21, 35, 3, 347, DateTimeKind.Unspecified).AddTicks(5895), 4L, false, new DateTime(2022, 1, 4, 8, 33, 30, 61, DateTimeKind.Unspecified).AddTicks(3037), 17L, new DateTime(2019, 8, 17, 22, 34, 34, 921, DateTimeKind.Unspecified).AddTicks(2182), new DateTime(2021, 8, 23, 14, 30, 24, 31, DateTimeKind.Unspecified).AddTicks(614) },
                    { 75L, 17L, new DateTime(2021, 2, 20, 8, 8, 2, 443, DateTimeKind.Unspecified).AddTicks(2360), 5L, false, new DateTime(2022, 1, 17, 19, 58, 54, 29, DateTimeKind.Unspecified).AddTicks(4935), 71L, new DateTime(2019, 8, 4, 20, 12, 41, 16, DateTimeKind.Unspecified).AddTicks(5190), new DateTime(2021, 7, 3, 6, 28, 19, 225, DateTimeKind.Unspecified).AddTicks(327) },
                    { 76L, 24L, new DateTime(2021, 7, 6, 23, 26, 24, 435, DateTimeKind.Unspecified).AddTicks(9970), 3L, false, new DateTime(2022, 1, 12, 3, 12, 7, 183, DateTimeKind.Unspecified).AddTicks(7899), 4L, new DateTime(2019, 4, 22, 23, 58, 41, 210, DateTimeKind.Unspecified).AddTicks(2443), new DateTime(2021, 8, 17, 5, 5, 19, 673, DateTimeKind.Unspecified).AddTicks(2830) },
                    { 77L, 50L, new DateTime(2022, 1, 25, 23, 26, 32, 751, DateTimeKind.Unspecified).AddTicks(5423), 2L, false, new DateTime(2022, 1, 3, 4, 19, 54, 341, DateTimeKind.Unspecified).AddTicks(4135), 81L, new DateTime(2019, 6, 19, 13, 14, 9, 911, DateTimeKind.Unspecified).AddTicks(7939), new DateTime(2021, 1, 13, 7, 45, 10, 958, DateTimeKind.Unspecified).AddTicks(9021) },
                    { 78L, 5L, new DateTime(2021, 2, 5, 20, 23, 27, 915, DateTimeKind.Unspecified).AddTicks(4446), 1L, false, new DateTime(2022, 1, 5, 20, 3, 37, 530, DateTimeKind.Unspecified).AddTicks(3497), 31L, new DateTime(2019, 7, 1, 12, 46, 10, 405, DateTimeKind.Unspecified).AddTicks(5538), new DateTime(2021, 8, 10, 22, 19, 9, 583, DateTimeKind.Unspecified).AddTicks(6498) },
                    { 79L, 36L, new DateTime(2021, 2, 24, 14, 12, 35, 19, DateTimeKind.Unspecified).AddTicks(5187), 1L, false, new DateTime(2022, 2, 1, 14, 34, 2, 288, DateTimeKind.Unspecified).AddTicks(8598), 38L, new DateTime(2019, 12, 30, 1, 2, 12, 196, DateTimeKind.Unspecified).AddTicks(1331), new DateTime(2021, 2, 2, 1, 57, 50, 771, DateTimeKind.Unspecified).AddTicks(3875) },
                    { 80L, 34L, new DateTime(2021, 8, 29, 7, 59, 52, 140, DateTimeKind.Unspecified).AddTicks(1218), 2L, false, new DateTime(2022, 1, 19, 15, 28, 49, 999, DateTimeKind.Unspecified).AddTicks(8155), 36L, new DateTime(2019, 10, 26, 5, 20, 47, 257, DateTimeKind.Unspecified).AddTicks(8317), new DateTime(2021, 2, 28, 16, 23, 32, 275, DateTimeKind.Unspecified).AddTicks(1541) },
                    { 81L, 8L, new DateTime(2021, 7, 31, 16, 8, 55, 519, DateTimeKind.Unspecified).AddTicks(6195), 4L, false, new DateTime(2022, 1, 10, 7, 29, 26, 622, DateTimeKind.Unspecified).AddTicks(9657), 39L, new DateTime(2019, 12, 27, 10, 5, 15, 270, DateTimeKind.Unspecified).AddTicks(9147), new DateTime(2021, 7, 13, 6, 18, 31, 697, DateTimeKind.Unspecified).AddTicks(7425) },
                    { 82L, 38L, new DateTime(2021, 9, 3, 6, 4, 46, 339, DateTimeKind.Unspecified).AddTicks(3140), 5L, false, new DateTime(2022, 1, 3, 9, 13, 46, 435, DateTimeKind.Unspecified).AddTicks(420), 52L, new DateTime(2019, 11, 29, 1, 18, 58, 654, DateTimeKind.Unspecified).AddTicks(8467), new DateTime(2021, 7, 4, 23, 21, 30, 275, DateTimeKind.Unspecified).AddTicks(4520) },
                    { 83L, 4L, new DateTime(2021, 12, 1, 17, 2, 44, 544, DateTimeKind.Unspecified).AddTicks(9149), 5L, false, new DateTime(2022, 1, 29, 13, 40, 0, 767, DateTimeKind.Unspecified).AddTicks(4744), 6L, new DateTime(2019, 8, 22, 6, 6, 34, 511, DateTimeKind.Unspecified).AddTicks(870), new DateTime(2021, 5, 11, 20, 9, 49, 855, DateTimeKind.Unspecified).AddTicks(5483) },
                    { 84L, 22L, new DateTime(2021, 12, 7, 19, 6, 20, 267, DateTimeKind.Unspecified).AddTicks(2379), 2L, false, new DateTime(2022, 1, 29, 5, 29, 25, 702, DateTimeKind.Unspecified).AddTicks(3343), 76L, new DateTime(2019, 3, 29, 4, 21, 9, 623, DateTimeKind.Unspecified).AddTicks(3226), new DateTime(2021, 2, 17, 11, 7, 7, 976, DateTimeKind.Unspecified).AddTicks(2663) },
                    { 85L, 5L, new DateTime(2021, 6, 16, 21, 40, 27, 153, DateTimeKind.Unspecified).AddTicks(2362), 5L, false, new DateTime(2022, 1, 7, 14, 33, 23, 815, DateTimeKind.Unspecified).AddTicks(9644), 67L, new DateTime(2019, 10, 18, 19, 25, 1, 709, DateTimeKind.Unspecified).AddTicks(9587), new DateTime(2021, 9, 21, 11, 48, 43, 345, DateTimeKind.Unspecified).AddTicks(6735) }
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "IsDeleted", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[,]
                {
                    { 86L, 20L, new DateTime(2021, 6, 12, 17, 2, 24, 333, DateTimeKind.Unspecified).AddTicks(3569), 2L, false, new DateTime(2022, 1, 10, 19, 0, 38, 202, DateTimeKind.Unspecified).AddTicks(3459), 40L, new DateTime(2019, 9, 4, 19, 54, 23, 304, DateTimeKind.Unspecified).AddTicks(6290), new DateTime(2021, 6, 25, 4, 33, 25, 376, DateTimeKind.Unspecified).AddTicks(9263) },
                    { 87L, 29L, new DateTime(2022, 1, 17, 19, 24, 29, 982, DateTimeKind.Unspecified).AddTicks(2289), 2L, false, new DateTime(2022, 1, 31, 1, 0, 23, 381, DateTimeKind.Unspecified).AddTicks(9174), 77L, new DateTime(2019, 10, 19, 16, 27, 10, 935, DateTimeKind.Unspecified).AddTicks(3240), new DateTime(2021, 3, 2, 22, 9, 16, 649, DateTimeKind.Unspecified).AddTicks(7101) },
                    { 88L, 31L, new DateTime(2021, 11, 5, 23, 14, 1, 845, DateTimeKind.Unspecified).AddTicks(8181), 1L, false, new DateTime(2022, 1, 17, 6, 44, 52, 377, DateTimeKind.Unspecified).AddTicks(6024), 71L, new DateTime(2019, 6, 11, 23, 29, 3, 564, DateTimeKind.Unspecified).AddTicks(818), new DateTime(2021, 2, 13, 22, 14, 12, 588, DateTimeKind.Unspecified).AddTicks(1171) },
                    { 89L, 23L, new DateTime(2021, 6, 17, 4, 41, 33, 386, DateTimeKind.Unspecified).AddTicks(7518), 2L, false, new DateTime(2022, 1, 14, 3, 38, 45, 484, DateTimeKind.Unspecified).AddTicks(7573), 27L, new DateTime(2019, 12, 12, 22, 50, 5, 891, DateTimeKind.Unspecified).AddTicks(4657), new DateTime(2021, 12, 2, 23, 52, 49, 291, DateTimeKind.Unspecified).AddTicks(9357) },
                    { 90L, 39L, new DateTime(2021, 9, 21, 11, 32, 19, 354, DateTimeKind.Unspecified).AddTicks(9934), 4L, false, new DateTime(2022, 1, 31, 14, 6, 10, 441, DateTimeKind.Unspecified).AddTicks(7614), 58L, new DateTime(2019, 8, 7, 3, 18, 34, 788, DateTimeKind.Unspecified).AddTicks(8492), new DateTime(2021, 4, 6, 18, 33, 43, 407, DateTimeKind.Unspecified).AddTicks(2415) },
                    { 91L, 51L, new DateTime(2021, 9, 30, 11, 41, 55, 956, DateTimeKind.Unspecified).AddTicks(8551), 4L, false, new DateTime(2022, 1, 17, 16, 11, 4, 656, DateTimeKind.Unspecified).AddTicks(3563), 7L, new DateTime(2019, 3, 5, 14, 10, 10, 891, DateTimeKind.Unspecified).AddTicks(6341), new DateTime(2021, 3, 29, 16, 39, 56, 875, DateTimeKind.Unspecified).AddTicks(6076) },
                    { 92L, 17L, new DateTime(2021, 7, 18, 5, 37, 27, 79, DateTimeKind.Unspecified).AddTicks(4057), 1L, false, new DateTime(2022, 1, 29, 22, 22, 24, 106, DateTimeKind.Unspecified).AddTicks(3123), 72L, new DateTime(2019, 10, 2, 7, 10, 37, 152, DateTimeKind.Unspecified).AddTicks(6078), new DateTime(2021, 3, 2, 3, 56, 41, 8, DateTimeKind.Unspecified).AddTicks(731) },
                    { 93L, 5L, new DateTime(2021, 2, 15, 0, 35, 11, 497, DateTimeKind.Unspecified).AddTicks(2586), 2L, false, new DateTime(2022, 1, 2, 9, 9, 39, 806, DateTimeKind.Unspecified).AddTicks(5265), 19L, new DateTime(2019, 9, 16, 23, 25, 54, 910, DateTimeKind.Unspecified).AddTicks(7497), new DateTime(2021, 1, 24, 15, 49, 25, 91, DateTimeKind.Unspecified).AddTicks(3265) },
                    { 94L, 51L, new DateTime(2021, 2, 23, 9, 52, 8, 799, DateTimeKind.Unspecified).AddTicks(1794), 2L, false, new DateTime(2022, 1, 26, 17, 20, 16, 308, DateTimeKind.Unspecified).AddTicks(1504), 67L, new DateTime(2019, 4, 6, 18, 51, 19, 925, DateTimeKind.Unspecified).AddTicks(1083), new DateTime(2021, 4, 23, 20, 40, 22, 586, DateTimeKind.Unspecified).AddTicks(7469) },
                    { 95L, 19L, new DateTime(2022, 1, 8, 14, 49, 40, 832, DateTimeKind.Unspecified).AddTicks(3915), 2L, false, new DateTime(2022, 1, 3, 11, 32, 42, 332, DateTimeKind.Unspecified).AddTicks(5392), 71L, new DateTime(2019, 10, 5, 9, 40, 57, 258, DateTimeKind.Unspecified).AddTicks(5447), new DateTime(2021, 2, 22, 4, 30, 24, 287, DateTimeKind.Unspecified).AddTicks(213) },
                    { 96L, 23L, new DateTime(2021, 6, 23, 9, 45, 59, 969, DateTimeKind.Unspecified).AddTicks(3552), 2L, false, new DateTime(2022, 1, 22, 5, 32, 0, 650, DateTimeKind.Unspecified).AddTicks(4780), 33L, new DateTime(2019, 10, 11, 19, 33, 56, 833, DateTimeKind.Unspecified).AddTicks(1477), new DateTime(2021, 1, 26, 12, 2, 8, 517, DateTimeKind.Unspecified).AddTicks(3678) },
                    { 97L, 34L, new DateTime(2021, 5, 23, 18, 46, 6, 992, DateTimeKind.Unspecified).AddTicks(6273), 2L, false, new DateTime(2022, 1, 6, 22, 22, 5, 755, DateTimeKind.Unspecified).AddTicks(2149), 28L, new DateTime(2019, 11, 16, 10, 45, 7, 24, DateTimeKind.Unspecified).AddTicks(6698), new DateTime(2021, 5, 31, 2, 59, 7, 430, DateTimeKind.Unspecified).AddTicks(7468) },
                    { 98L, 15L, new DateTime(2021, 7, 29, 9, 42, 35, 666, DateTimeKind.Unspecified).AddTicks(2186), 2L, false, new DateTime(2022, 1, 14, 5, 46, 11, 723, DateTimeKind.Unspecified).AddTicks(2309), 28L, new DateTime(2020, 1, 25, 11, 8, 12, 741, DateTimeKind.Unspecified).AddTicks(3546), new DateTime(2021, 7, 23, 5, 11, 32, 733, DateTimeKind.Unspecified).AddTicks(8225) },
                    { 99L, 41L, new DateTime(2021, 7, 28, 21, 42, 47, 655, DateTimeKind.Unspecified).AddTicks(4314), 1L, false, new DateTime(2022, 1, 21, 0, 49, 12, 921, DateTimeKind.Unspecified).AddTicks(998), 58L, new DateTime(2019, 3, 19, 7, 54, 57, 543, DateTimeKind.Unspecified).AddTicks(8921), new DateTime(2021, 12, 18, 10, 3, 55, 11, DateTimeKind.Unspecified).AddTicks(8046) },
                    { 100L, 29L, new DateTime(2021, 8, 26, 9, 11, 32, 2, DateTimeKind.Unspecified).AddTicks(1763), 3L, false, null, 78L, new DateTime(2019, 4, 8, 3, 0, 19, 71, DateTimeKind.Unspecified).AddTicks(8791), new DateTime(2021, 12, 23, 9, 4, 16, 750, DateTimeKind.Unspecified).AddTicks(5840) },
                    { 101L, 33L, new DateTime(2021, 2, 4, 18, 26, 50, 788, DateTimeKind.Unspecified).AddTicks(7190), 2L, false, new DateTime(2022, 1, 3, 4, 44, 46, 880, DateTimeKind.Unspecified).AddTicks(94), 50L, new DateTime(2019, 2, 5, 17, 1, 10, 82, DateTimeKind.Unspecified).AddTicks(8644), new DateTime(2021, 3, 11, 19, 16, 35, 984, DateTimeKind.Unspecified).AddTicks(1962) }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsDeleted", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[,]
                {
                    { 2L, 35L, new DateTime(2021, 11, 30, 19, 42, 13, 232, DateTimeKind.Unspecified).AddTicks(5878), 1L, 833, false, true, 59L, null, 418 },
                    { 5L, 34L, new DateTime(2021, 5, 14, 9, 14, 57, 321, DateTimeKind.Unspecified).AddTicks(4409), 5L, 890, false, true, 27L, null, 312 },
                    { 11L, 12L, new DateTime(2021, 5, 2, 21, 21, 42, 67, DateTimeKind.Unspecified).AddTicks(2039), 1L, 584, false, false, 75L, null, 374 },
                    { 13L, 50L, new DateTime(2021, 8, 20, 4, 35, 10, 372, DateTimeKind.Unspecified).AddTicks(6151), 2L, 761, false, true, 56L, null, 475 },
                    { 14L, 30L, new DateTime(2022, 1, 26, 5, 34, 51, 586, DateTimeKind.Unspecified).AddTicks(4248), 1L, 933, false, false, 62L, null, 356 },
                    { 20L, 12L, new DateTime(2021, 5, 19, 0, 7, 53, 342, DateTimeKind.Unspecified).AddTicks(3533), 1L, 544, false, false, 14L, null, 333 },
                    { 22L, 40L, new DateTime(2021, 7, 17, 17, 9, 19, 650, DateTimeKind.Unspecified).AddTicks(7584), 5L, 799, false, true, 56L, null, 65 },
                    { 24L, 41L, new DateTime(2021, 9, 20, 1, 48, 49, 30, DateTimeKind.Unspecified).AddTicks(3708), 5L, 752, false, true, 16L, null, 21 },
                    { 26L, 10L, new DateTime(2022, 1, 13, 20, 36, 45, 56, DateTimeKind.Unspecified).AddTicks(8062), 1L, 899, false, true, 11L, null, 193 },
                    { 28L, 29L, new DateTime(2022, 1, 5, 5, 21, 58, 235, DateTimeKind.Unspecified).AddTicks(368), 4L, 570, false, true, 62L, null, 134 },
                    { 29L, 33L, new DateTime(2021, 9, 16, 21, 9, 19, 247, DateTimeKind.Unspecified).AddTicks(6961), 3L, 635, false, false, 75L, null, 190 },
                    { 31L, 41L, new DateTime(2021, 5, 24, 0, 53, 24, 429, DateTimeKind.Unspecified).AddTicks(1303), 3L, 946, false, false, 59L, null, 12 },
                    { 32L, 13L, new DateTime(2021, 11, 11, 4, 12, 22, 825, DateTimeKind.Unspecified).AddTicks(9786), 2L, 612, false, true, 26L, null, 293 },
                    { 35L, 45L, new DateTime(2021, 5, 26, 0, 40, 43, 540, DateTimeKind.Unspecified).AddTicks(3180), 2L, 627, false, false, 56L, null, 89 },
                    { 38L, 34L, new DateTime(2021, 12, 12, 3, 59, 9, 521, DateTimeKind.Unspecified).AddTicks(4097), 5L, 550, false, false, 34L, null, 100 },
                    { 44L, 44L, new DateTime(2022, 1, 13, 14, 5, 28, 892, DateTimeKind.Unspecified).AddTicks(2382), 4L, 814, false, true, 58L, null, 239 },
                    { 48L, 16L, new DateTime(2021, 5, 28, 8, 2, 28, 245, DateTimeKind.Unspecified).AddTicks(9337), 1L, 930, false, true, 26L, null, 175 },
                    { 49L, 25L, new DateTime(2021, 2, 7, 20, 36, 15, 421, DateTimeKind.Unspecified).AddTicks(8834), 1L, 986, false, false, 22L, null, 500 },
                    { 50L, 48L, new DateTime(2021, 8, 1, 3, 10, 2, 338, DateTimeKind.Unspecified).AddTicks(4803), 1L, 882, false, false, 58L, null, 67 },
                    { 51L, 19L, new DateTime(2021, 11, 27, 4, 11, 38, 205, DateTimeKind.Unspecified).AddTicks(9430), 1L, 776, false, true, 66L, null, 353 },
                    { 52L, 13L, new DateTime(2021, 11, 14, 16, 30, 33, 958, DateTimeKind.Unspecified).AddTicks(6848), 2L, 967, false, true, 55L, null, 282 },
                    { 54L, 46L, new DateTime(2021, 5, 2, 16, 19, 51, 806, DateTimeKind.Unspecified).AddTicks(7461), 5L, 884, false, true, 69L, null, 170 },
                    { 55L, 26L, new DateTime(2021, 3, 22, 12, 26, 13, 437, DateTimeKind.Unspecified).AddTicks(4732), 1L, 832, false, false, 67L, null, 296 },
                    { 56L, 12L, new DateTime(2021, 4, 11, 21, 15, 19, 985, DateTimeKind.Unspecified).AddTicks(4700), 3L, 500, false, false, 75L, null, 466 },
                    { 59L, 29L, new DateTime(2021, 7, 16, 2, 55, 6, 99, DateTimeKind.Unspecified).AddTicks(2051), 4L, 779, false, false, 2L, null, 267 },
                    { 63L, 3L, new DateTime(2021, 8, 3, 4, 27, 9, 542, DateTimeKind.Unspecified).AddTicks(9558), 1L, 544, false, false, 16L, null, 46 }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsDeleted", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[,]
                {
                    { 65L, 2L, new DateTime(2022, 1, 9, 4, 9, 7, 299, DateTimeKind.Unspecified).AddTicks(4591), 5L, 745, false, false, 74L, null, 147 },
                    { 66L, 17L, new DateTime(2021, 9, 17, 23, 41, 55, 303, DateTimeKind.Unspecified).AddTicks(5695), 1L, 673, false, false, 5L, null, 440 },
                    { 67L, 25L, new DateTime(2021, 4, 22, 12, 53, 26, 301, DateTimeKind.Unspecified).AddTicks(3993), 4L, 621, false, false, 19L, null, 427 },
                    { 68L, 33L, new DateTime(2022, 1, 16, 17, 2, 10, 670, DateTimeKind.Unspecified).AddTicks(9486), 5L, 994, false, true, 16L, null, 426 },
                    { 70L, 43L, new DateTime(2021, 2, 11, 16, 37, 12, 617, DateTimeKind.Unspecified).AddTicks(336), 5L, 878, false, true, 18L, null, 484 },
                    { 72L, 51L, new DateTime(2021, 8, 4, 0, 22, 9, 736, DateTimeKind.Unspecified).AddTicks(4614), 4L, 659, false, true, 68L, null, 71 },
                    { 74L, 49L, new DateTime(2021, 7, 29, 2, 32, 0, 723, DateTimeKind.Unspecified).AddTicks(536), 4L, 928, false, false, 72L, null, 214 },
                    { 75L, 12L, new DateTime(2021, 2, 9, 13, 58, 2, 175, DateTimeKind.Unspecified).AddTicks(9324), 2L, 532, false, false, 38L, null, 423 },
                    { 76L, 9L, new DateTime(2021, 4, 5, 21, 34, 28, 154, DateTimeKind.Unspecified).AddTicks(9419), 3L, 647, false, true, 39L, null, 24 }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 2L, 28L, "Aut libero autem corporis possimus consequuntur quam.\nSequi numquam nobis quos soluta molestiae id.\nConsequatur dolores tenetur aliquid.", new DateTime(2022, 1, 31, 19, 58, 26, 44, DateTimeKind.Unspecified).AddTicks(4913), 5L, false, 55L },
                    { 3L, 26L, "Cumque unde est dolores minus quia ullam amet.\nEt voluptatibus quibusdam iusto rerum vero doloribus minima.\nSint dolores ex exercitationem officia debitis.", new DateTime(2022, 1, 3, 12, 41, 2, 819, DateTimeKind.Unspecified).AddTicks(7346), 5L, false, 35L },
                    { 7L, 33L, "Sint quisquam vero qui occaecati eaque voluptas veniam.\nEt voluptatem repudiandae et quis neque ut aut.\nItaque est omnis eligendi commodi.\nExcepturi provident magni dignissimos provident nemo.\nVoluptas sed sit minus mollitia animi.", new DateTime(2021, 4, 9, 9, 57, 57, 117, DateTimeKind.Unspecified).AddTicks(1454), 2L, false, 50L },
                    { 10L, 40L, "Minus dignissimos velit recusandae id cupiditate ea harum.\nNam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.", new DateTime(2021, 2, 26, 12, 1, 35, 855, DateTimeKind.Unspecified).AddTicks(3844), 2L, false, 13L },
                    { 11L, 44L, "Nam quia dicta eius doloribus commodi non nihil.\nQuod recusandae et est.\nDebitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.", new DateTime(2021, 10, 28, 3, 37, 20, 886, DateTimeKind.Unspecified).AddTicks(3829), 1L, false, 49L },
                    { 13L, 44L, "Est sit at placeat optio.\nSapiente pariatur et et enim.\nAccusamus molestiae labore.", new DateTime(2021, 6, 2, 19, 19, 7, 873, DateTimeKind.Unspecified).AddTicks(6561), 4L, false, 51L },
                    { 17L, 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 1L, false, 50L },
                    { 20L, 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 2L, false, 11L },
                    { 21L, 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 4L, false, 75L },
                    { 24L, 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 1L, false, 26L },
                    { 26L, 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 5L, false, 35L },
                    { 30L, 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 4L, false, 68L },
                    { 33L, 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 1L, false, 68L },
                    { 34L, 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 3L, false, 55L },
                    { 36L, 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, false, 13L },
                    { 38L, 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 1L, false, 51L },
                    { 39L, 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 4L, false, 13L },
                    { 44L, 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, false, 68L },
                    { 46L, 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 2L, false, 72L },
                    { 49L, 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 1L, false, 20L },
                    { 50L, 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 1L, false, 65L },
                    { 51L, 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 3L, false, 29L },
                    { 58L, 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, false, 50L },
                    { 61L, 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 3L, false, 67L },
                    { 63L, 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 2L, false, 13L },
                    { 66L, 44L, "Quo corporis voluptatem.\nQuia ut architecto adipisci quasi at aliquid voluptatum et.\nConsequatur voluptate dolor doloribus quam ipsam rerum optio.\nAperiam aperiam et.", new DateTime(2021, 12, 23, 16, 16, 38, 159, DateTimeKind.Unspecified).AddTicks(4359), 1L, false, 75L },
                    { 67L, 12L, "Qui quam perferendis itaque dolore eligendi expedita.\nFacilis distinctio et omnis necessitatibus quibusdam rerum.\nEt qui ex itaque quam tempora quia eos.", new DateTime(2021, 5, 6, 9, 31, 38, 3, DateTimeKind.Unspecified).AddTicks(8430), 4L, false, 20L },
                    { 70L, 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 3L, false, 20L },
                    { 74L, 34L, "Dolores ea assumenda alias.", new DateTime(2021, 3, 6, 4, 28, 7, 52, DateTimeKind.Unspecified).AddTicks(1993), 1L, false, 52L },
                    { 76L, 4L, "Quam ducimus qui.\nRerum velit nulla rem.\nUllam nisi eveniet dignissimos.", new DateTime(2021, 8, 25, 1, 50, 58, 81, DateTimeKind.Unspecified).AddTicks(488), 3L, false, 68L },
                    { 77L, 14L, "Omnis fugit aut.", new DateTime(2021, 8, 20, 8, 30, 53, 58, DateTimeKind.Unspecified).AddTicks(3331), 3L, false, 59L },
                    { 88L, 2L, "Non sit beatae aliquam reiciendis enim tempore.\nPerferendis quis excepturi eveniet repellat tempora.\nVoluptas aut numquam eveniet et et eaque enim.\nAdipisci et ad quidem placeat earum dolor.\nDolorum voluptate molestiae nihil illo fugit aut.\nAnimi soluta accusantium.", new DateTime(2021, 10, 18, 16, 4, 44, 926, DateTimeKind.Unspecified).AddTicks(6113), 2L, false, 75L },
                    { 90L, 13L, "Ut cumque aut.\nAut aut voluptas ex.\nVeritatis et velit aliquam.\nDeserunt illo quos maiores natus earum a velit.\nEarum cumque libero facere voluptatem saepe suscipit qui est veritatis.\nAutem omnis dicta ad.", new DateTime(2021, 5, 17, 13, 53, 22, 284, DateTimeKind.Unspecified).AddTicks(1090), 3L, false, 14L },
                    { 93L, 44L, "Nihil sed quis temporibus aut minima repellat voluptates.", new DateTime(2021, 6, 5, 6, 45, 25, 705, DateTimeKind.Unspecified).AddTicks(2833), 3L, false, 74L },
                    { 97L, 51L, "Dolorem ut quasi aut qui laudantium quibusdam ab.\nDeleniti quod blanditiis ducimus molestiae.", new DateTime(2021, 3, 17, 21, 1, 51, 218, DateTimeKind.Unspecified).AddTicks(9854), 4L, false, 35L },
                    { 99L, 21L, "Voluptates repellat harum qui dolore molestias expedita deleniti.\nNulla possimus numquam ab temporibus illo commodi maxime assumenda.", new DateTime(2022, 1, 16, 8, 12, 55, 887, DateTimeKind.Unspecified).AddTicks(2289), 4L, false, 74L },
                    { 100L, 18L, "Cumque doloribus dolores sequi libero labore est.\nDebitis quia quo.", new DateTime(2021, 11, 1, 6, 39, 5, 620, DateTimeKind.Unspecified).AddTicks(9235), 3L, false, 72L },
                    { 103L, 20L, "Aut quis eum nostrum quod eum quos et sunt.\nOccaecati earum itaque libero in nihil.", new DateTime(2021, 10, 12, 9, 43, 10, 483, DateTimeKind.Unspecified).AddTicks(3703), 2L, false, 31L },
                    { 104L, 27L, "Tempore incidunt ipsum est est occaecati vitae eius consequatur.\nCupiditate enim ut sunt.\nPariatur nihil qui enim eos eum impedit quia laborum.\nAccusamus animi tempora minus nulla consequatur alias ut ratione laborum.\nSed sunt sit aut sed officiis sunt.\nEsse fuga voluptatem dolorem nam.", new DateTime(2022, 1, 19, 13, 53, 51, 173, DateTimeKind.Unspecified).AddTicks(3509), 5L, false, 54L },
                    { 106L, 9L, "Sed eos quas dolor.\nQui id nesciunt.\nNisi eveniet ea quos tempora ratione nostrum ut suscipit occaecati.\nUt provident ipsam laudantium ipsum minima et.\nEt quia illo beatae.\nQuae et voluptates veritatis iusto.", new DateTime(2021, 2, 7, 11, 22, 22, 847, DateTimeKind.Unspecified).AddTicks(7478), 2L, false, 13L },
                    { 107L, 16L, "Quibusdam sed voluptas dolor ut.\nQuia incidunt ea suscipit hic qui.\nEaque laborum omnis molestiae corrupti ut voluptas.\nIllum illo dignissimos quibusdam ut.\nEum consectetur vel voluptas.", new DateTime(2021, 6, 3, 20, 57, 51, 343, DateTimeKind.Unspecified).AddTicks(7626), 1L, false, 68L },
                    { 108L, 10L, "Fuga ut non alias qui tempore.\nAspernatur pariatur commodi voluptatem qui eum numquam quod placeat et.\nReiciendis ratione qui.\nLibero neque nostrum eaque accusantium consequatur.\nPossimus sed quis facilis quia corporis qui nihil.\nRem qui vitae ut hic officiis quia consequatur consequatur.", new DateTime(2021, 2, 15, 1, 3, 50, 196, DateTimeKind.Unspecified).AddTicks(6476), 3L, false, 48L }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 110L, 28L, "Inventore repudiandae animi quae.\nSed quo et.\nEt autem a.\nIncidunt eos nihil dolores temporibus.", new DateTime(2021, 10, 21, 20, 52, 38, 231, DateTimeKind.Unspecified).AddTicks(8015), 5L, false, 56L },
                    { 111L, 44L, "Laboriosam consequuntur est dolores sed repudiandae.", new DateTime(2021, 4, 4, 18, 42, 21, 652, DateTimeKind.Unspecified).AddTicks(9924), 3L, false, 5L },
                    { 112L, 5L, "Maiores corrupti itaque laudantium pariatur.\nDoloribus vel rerum velit nihil omnis temporibus ut exercitationem.\nExercitationem sapiente aliquid est vero.\nImpedit eveniet pariatur laboriosam.\nDolores in placeat in blanditiis voluptatum est iusto est at.", new DateTime(2021, 10, 18, 11, 35, 38, 665, DateTimeKind.Unspecified).AddTicks(3588), 1L, false, 68L },
                    { 113L, 42L, "Molestiae nihil eos impedit in dolorum omnis.\nMollitia deleniti reiciendis qui pariatur dolor eaque et molestias.", new DateTime(2021, 12, 14, 12, 15, 47, 755, DateTimeKind.Unspecified).AddTicks(9340), 2L, false, 70L },
                    { 117L, 35L, "Assumenda sed quibusdam exercitationem distinctio.\nEius similique sed numquam voluptates nam labore ut consectetur.\nAut vel sequi quisquam voluptatem perspiciatis rerum ut dignissimos minus.", new DateTime(2021, 11, 4, 1, 54, 34, 308, DateTimeKind.Unspecified).AddTicks(5223), 3L, false, 49L },
                    { 118L, 27L, "Officia ad soluta nostrum ullam et facilis quo.", new DateTime(2021, 5, 8, 5, 13, 27, 480, DateTimeKind.Unspecified).AddTicks(7761), 1L, false, 76L },
                    { 119L, 12L, "Molestias voluptatem asperiores et autem ex voluptatibus distinctio sed.\nDeserunt ducimus pariatur non.", new DateTime(2021, 10, 18, 17, 12, 20, 582, DateTimeKind.Unspecified).AddTicks(5471), 1L, false, 52L },
                    { 120L, 34L, "Beatae sapiente nam ut.", new DateTime(2021, 10, 8, 19, 16, 13, 405, DateTimeKind.Unspecified).AddTicks(388), 1L, false, 26L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apps_ImageId",
                table: "Apps",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Apps_OwnerId",
                table: "Apps",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AppTags_TagId",
                table: "AppTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AvatarId",
                table: "Courses",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_OrganizationId",
                table: "Courses",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_OwnerId",
                table: "Courses",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUsers_CourseId",
                table: "CourseUsers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUsers_UserId",
                table: "CourseUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InvitedUsers_UserId",
                table: "InvitedUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_UnitId",
                table: "Lessons",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_OwnerId",
                table: "Organizations",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_AuthorId",
                table: "Submissions",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_LessonId",
                table: "Submissions",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadComments_AuthorId",
                table: "ThreadComments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadComments_ThreadId",
                table: "ThreadComments",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_AuthorId",
                table: "Threads",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_LessonId",
                table: "Threads",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_ProjectId",
                table: "Threads",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_CourseId",
                table: "Units",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AvatarId",
                table: "Users",
                column: "AvatarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppTags");

            migrationBuilder.DropTable(
                name: "CourseUsers");

            migrationBuilder.DropTable(
                name: "InvitedUsers");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "Submissions");

            migrationBuilder.DropTable(
                name: "ThreadComments");

            migrationBuilder.DropTable(
                name: "Apps");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Threads");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
