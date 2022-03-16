using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    public partial class AddApplications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 19L });

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
                keyValues: new object[] { 20L, 17L });

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
                keyValues: new object[] { 30L, 42L });

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
                keyValues: new object[] { 44L, 38L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 44L });

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

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectDocumentId",
                table: "Projects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.InsertData(
                table: "Apps",
                columns: new[] { "Id", "AppDocumentId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "ImageId", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 2L, new Guid("d298334c-8ab2-bb37-dd5e-6535808f6eab"), new DateTime(2021, 7, 7, 4, 21, 30, 533, DateTimeKind.Unspecified).AddTicks(2877), 1L, "Voluptatem dolor dolorum quia consequatur dolores.\nOptio voluptas molestias officiis necessitatibus placeat ut officiis vel consequuntur.", "Culpa non voluptate ut velit voluptatem earum quae molestiae.", 30L, false, "protocolInvestment Account", 23L },
                    { 3L, new Guid("b7045377-936b-41e9-9f3f-4c2c53e6cfe5"), new DateTime(2021, 11, 29, 22, 53, 14, 696, DateTimeKind.Unspecified).AddTicks(7583), 5L, "Sit eos eos soluta ad.\nQui distinctio vel itaque praesentium et vero.", "Libero voluptas suscipit illum repellendus quidem voluptatibus blanditiis.", 44L, false, "HDDlavenderGorgeous Metal Tuna", 50L },
                    { 4L, new Guid("c049b115-7872-31ac-0235-542d533817a9"), new DateTime(2021, 11, 30, 13, 34, 1, 798, DateTimeKind.Unspecified).AddTicks(9928), 4L, "In itaque saepe quis.", "Dolorum saepe cumque velit et totam.", 98L, false, "North CarolinacircuitRegional", 34L },
                    { 5L, new Guid("a27d502a-9e22-4868-8ea4-a02190f60164"), new DateTime(2021, 11, 6, 4, 49, 57, 563, DateTimeKind.Unspecified).AddTicks(6995), 2L, "Cumque totam sit molestias id sunt labore ut quam et.", "Corrupti beatae praesentium nam qui odio et ipsum.", 18L, false, "ubiquitousToolsForwardhard drive", 50L },
                    { 6L, new Guid("179ca5de-a60d-4149-c2da-a44e368bf846"), new DateTime(2021, 7, 2, 4, 18, 57, 767, DateTimeKind.Unspecified).AddTicks(2685), 1L, "Ex voluptas voluptatum eveniet voluptas.\nReiciendis ipsa id qui explicabo beatae est nulla.\nMinima rerum dolor eveniet enim reprehenderit.\nQuisquam sit aperiam et non reprehenderit.\nHarum nam ipsa aperiam error.\nIn atque atque repudiandae rerum et quisquam.", "Iure et cum unde enim sit.", 88L, false, "Buckinghamshirezero administrationprogramming", 37L },
                    { 7L, new Guid("b84671c0-1654-2d1d-d18a-a08ea72d9821"), new DateTime(2021, 7, 21, 10, 37, 44, 742, DateTimeKind.Unspecified).AddTicks(6590), 4L, "Rerum ex laboriosam fuga sed laudantium voluptates reiciendis.\nSit nihil voluptas pariatur modi vel.\nVoluptatem accusamus quia et ut rerum similique.", "Voluptatum sunt tempora est maiores repellat eveniet aut provident est.", 81L, false, "ErgonomicSmall Steel GlovesTools, Computers & Computerssynthesize", 45L },
                    { 8L, new Guid("c08938ee-0914-8e7b-ad06-3a40bfb4e8d0"), new DateTime(2021, 10, 20, 13, 27, 22, 914, DateTimeKind.Unspecified).AddTicks(8959), 4L, "Doloribus numquam ad voluptatem magni minima expedita aliquam fugit.\nPerspiciatis est sequi corrupti consequatur eum.\nSunt voluptate minima.\nQuia aut molestiae ut iste nihil eos perferendis.\nInventore voluptatibus accusamus.", "Nostrum impedit nam et non ea eligendi.", 6L, false, "RSSPNG", 28L },
                    { 9L, new Guid("46f59a4c-e0f0-61bb-a08f-1c1a4790cc6b"), new DateTime(2021, 12, 5, 20, 1, 37, 845, DateTimeKind.Unspecified).AddTicks(6639), 2L, "Sapiente accusamus praesentium aut voluptatem facilis sunt eum.\nQuia beatae esse velit alias ut deserunt ad.\nCommodi dolorum ut id libero consectetur doloribus in.", "Asperiores quis error at.", 46L, false, "Licensed Wooden Pizzafront-endsynthesizing", 34L },
                    { 10L, new Guid("75a0f507-f23e-90a7-ed25-4646fb781bb6"), new DateTime(2021, 7, 24, 7, 12, 3, 836, DateTimeKind.Unspecified).AddTicks(9094), 4L, "Eaque placeat soluta odit temporibus cupiditate et.\nEt est voluptatibus ullam accusantium sint eum.\nIllo aspernatur hic voluptatibus temporibus omnis qui repellendus.\nReiciendis et possimus eum veritatis aliquam molestias at.", "Minus modi velit ut sit facere et porro deleniti.", 2L, false, "open-sourcepartnershipsXML", 39L },
                    { 11L, new Guid("fc47587e-10a0-e46c-a87c-5bf64d484c10"), new DateTime(2021, 11, 30, 10, 43, 46, 979, DateTimeKind.Unspecified).AddTicks(5195), 2L, "Quis et architecto eum atque error fuga eaque maxime.\nBlanditiis similique quis voluptatem quidem reiciendis dolore voluptatem maxime.\nDicta et tempore sequi at quia.", "Quod dolor odio reprehenderit voluptatum dignissimos earum nobis.", 71L, false, "connectHumanStation", 2L },
                    { 12L, new Guid("4be364cd-23ea-4190-0143-fd8857c07932"), new DateTime(2022, 1, 11, 20, 57, 26, 280, DateTimeKind.Unspecified).AddTicks(3700), 2L, "Voluptas voluptatem in autem autem magni rerum harum cupiditate.", "Rerum sint non commodi.", 86L, false, "SoftBedfordshirePersonal Loan AccountQuality", 30L },
                    { 13L, new Guid("9ca2a5b2-fadb-55af-f0bc-9b62fc41df56"), new DateTime(2021, 2, 25, 22, 37, 2, 396, DateTimeKind.Unspecified).AddTicks(4191), 2L, "Sed quod ducimus in ad doloremque pariatur.\nOfficia possimus maiores.", "Voluptatum vel soluta quia sed aut.", 32L, false, "East Caribbean DollarCentralPractical", 33L },
                    { 14L, new Guid("b8798048-2bb2-5776-55d9-11d30d83ebf1"), new DateTime(2021, 7, 7, 14, 14, 6, 876, DateTimeKind.Unspecified).AddTicks(7554), 2L, "Maiores quo praesentium non ipsa enim blanditiis.\nEt unde velit.\nDolorem amet eos non rem.", "Accusamus quia qui aut qui laudantium ea et fugit.", 41L, false, "SteelCornersMetalgenerate", 42L },
                    { 15L, new Guid("8a73ddb7-1ce8-64cd-44b7-2d5cad620f05"), new DateTime(2021, 2, 7, 22, 31, 37, 167, DateTimeKind.Unspecified).AddTicks(6861), 4L, "Architecto minima temporibus quaerat id cum necessitatibus.\nIusto consequatur officia ex beatae temporibus facilis.", "Sint deserunt sed non qui nam dignissimos placeat molestias ut.", 94L, false, "Licensed Concrete FishSQLWay", 20L },
                    { 16L, new Guid("248ae82d-b546-e978-c077-a704bcbea16e"), new DateTime(2021, 11, 26, 0, 12, 29, 662, DateTimeKind.Unspecified).AddTicks(2387), 2L, "Et nesciunt esse perferendis aut neque impedit voluptatem.\nIure aperiam incidunt autem inventore distinctio doloribus.\nAut quia in natus ullam.\nEius sit deserunt error architecto veritatis tempora.", "Unde alias dolor at autem sit.", 69L, false, "supply-chainsmiddlewareMichigan", 26L },
                    { 17L, new Guid("c0079e8b-d227-16f5-e5ab-d8c5acbaf661"), new DateTime(2021, 12, 27, 9, 47, 39, 765, DateTimeKind.Unspecified).AddTicks(722), 2L, "Saepe velit occaecati vero libero.\nIpsa omnis fugiat possimus nobis explicabo ut laboriosam nobis asperiores.\nArchitecto minus debitis nobis molestias itaque quos temporibus assumenda sit.\nMolestiae iste assumenda beatae molestias laudantium laboriosam laboriosam tempore.\nQui ducimus qui asperiores sequi qui sed ab vitae.\nExcepturi quo et occaecati.", "Eum esse mollitia quidem.", 101L, false, "AgentCustomizableHome Loan Account", 19L },
                    { 18L, new Guid("7ead84a0-d0ae-e666-aa45-34be0347fa3a"), new DateTime(2021, 10, 2, 18, 22, 6, 898, DateTimeKind.Unspecified).AddTicks(4864), 2L, "A beatae facilis placeat et id at consequatur aut.\nRecusandae totam consequatur magnam.\nOccaecati in voluptatem et.", "Tenetur quod est recusandae et sunt inventore magnam dolor.", 28L, false, "object-orientedNew Israeli Sheqel", 35L },
                    { 19L, new Guid("11ff1838-1312-1343-c8f1-4df5339ca690"), new DateTime(2022, 1, 13, 0, 53, 58, 471, DateTimeKind.Unspecified).AddTicks(8746), 4L, "Quam impedit sapiente aut fugiat nam esse.\nNemo omnis non saepe voluptas quae non.\nRem mollitia unde.\nIllo illo non sunt ut delectus omnis facere accusamus.", "Beatae similique distinctio maiores natus architecto molestiae recusandae.", 20L, false, "FTPBordersClothing", 38L },
                    { 20L, new Guid("b7b48e2e-2975-cef4-5a6d-b2f85b9dee79"), new DateTime(2021, 6, 17, 12, 26, 32, 980, DateTimeKind.Unspecified).AddTicks(7588), 1L, "Modi voluptatum aut et minus sed corporis atque.\nOdit id deserunt sed dicta et.\nRepellendus labore itaque cumque autem deleniti ut.\nAt mollitia error dignissimos quo incidunt fuga optio.", "Accusamus quo et fugit.", 58L, false, "HighwayextendGuinea-Bissau", 14L },
                    { 21L, new Guid("f64aaeec-eb08-1034-10c6-795ef0189132"), new DateTime(2022, 1, 28, 14, 25, 11, 576, DateTimeKind.Unspecified).AddTicks(6305), 2L, "Doloremque expedita nisi.\nEt voluptas et odio.\nCommodi minima maxime beatae est dolorum veniam debitis praesentium dolor.", "Iure eos omnis eos assumenda dolorem.", 33L, false, "Functionalityfirewall", 48L },
                    { 22L, new Guid("1399410e-0bed-f3b6-3343-156d8eeefde4"), new DateTime(2021, 10, 1, 21, 22, 7, 929, DateTimeKind.Unspecified).AddTicks(9081), 5L, "Aliquam magnam quis iure et.", "Occaecati enim maiores nemo doloribus deleniti sint et.", 19L, false, "innovateHealth, Shoes & Home", 36L },
                    { 23L, new Guid("a95cdcf4-d88d-45a0-5abf-9f64c601dbdb"), new DateTime(2021, 3, 11, 7, 9, 12, 88, DateTimeKind.Unspecified).AddTicks(923), 2L, "Accusantium accusamus est nulla nemo aut beatae iste rem.\nDolorem sequi consectetur.\nMinus eum minus perferendis.", "Repellat ut tenetur est eius possimus dolorem voluptatem eius et.", 3L, false, "ChiefGorgeous Steel FishmaximizedSoft", 21L },
                    { 24L, new Guid("fd4893ed-eba1-4bd9-8e19-3fcaa60334bc"), new DateTime(2021, 10, 15, 20, 15, 36, 186, DateTimeKind.Unspecified).AddTicks(8021), 2L, "Quia quia maiores aliquam.\nNumquam aliquid corrupti distinctio.", "Voluptatem odio provident.", 16L, false, "auxiliaryturquoiseGroupmulti-byte", 43L },
                    { 25L, new Guid("539f6ff9-a14a-cb58-311b-d197543466a0"), new DateTime(2022, 1, 30, 18, 58, 24, 273, DateTimeKind.Unspecified).AddTicks(1186), 4L, "Reprehenderit sint non perferendis suscipit.\nLaudantium fugiat nobis.\nCumque dolorem adipisci aut eligendi ea.\nVoluptatem iure reiciendis consectetur voluptatem quaerat voluptates.", "Qui velit soluta.", 92L, false, "BridgeCustomersuperstructure", 25L },
                    { 26L, new Guid("2c05caa7-6520-7759-3534-e08bcffbd931"), new DateTime(2021, 7, 11, 19, 51, 47, 631, DateTimeKind.Unspecified).AddTicks(7658), 4L, "Et et soluta quos id unde possimus cupiditate debitis.", "Natus dolor nostrum est aut consequuntur aliquam dolorum.", 66L, false, "indexBedfordshire", 45L },
                    { 27L, new Guid("be81d2b8-2eb3-2131-d150-60100fca6f60"), new DateTime(2021, 11, 9, 8, 20, 27, 133, DateTimeKind.Unspecified).AddTicks(6651), 2L, "Quod facere distinctio.", "Et est rem veniam et ut libero sunt eum in.", 87L, false, "WoninvoiceHandcrafted Soft Bikeusers", 43L },
                    { 28L, new Guid("b99e6d5e-e27e-3c4d-fb86-7d69b4bde758"), new DateTime(2021, 10, 28, 6, 56, 3, 787, DateTimeKind.Unspecified).AddTicks(9220), 4L, "Alias ut non.\nQuis ut quisquam consectetur neque dignissimos.\nSequi quia rem occaecati.", "Voluptates non corrupti iusto harum commodi.", 98L, false, "IllinoisElectronics, Electronics & GamesReactive", 22L },
                    { 29L, new Guid("d4291e06-6072-937b-591d-54a872b7e01e"), new DateTime(2021, 4, 18, 21, 1, 56, 521, DateTimeKind.Unspecified).AddTicks(5517), 1L, "Ratione officia velit fugit tempore dolores accusamus.\nNobis velit amet eos veniam quod totam quia consectetur corrupti.\nAperiam velit laboriosam quos omnis illo aut.\nUllam non ut vel eius qui blanditiis voluptatem voluptatem.\nNumquam ratione sapiente.", "Alias accusantium minus aut omnis sed odio est dolor possimus.", 11L, false, "primarySMTP", 23L },
                    { 30L, new Guid("4519f096-d750-a686-9109-1f99823b9997"), new DateTime(2021, 4, 23, 10, 19, 55, 269, DateTimeKind.Unspecified).AddTicks(1996), 2L, "Blanditiis amet tenetur similique optio nulla consequuntur quae saepe ratione.\nAb facilis voluptatem ex mollitia iusto.\nNon esse accusamus eaque et sit esse sunt.\nUt omnis expedita repellendus minus voluptate atque.\nId velit alias ex corrupti voluptatem et.", "Deleniti voluptatem qui aut laboriosam dolorum doloremque cupiditate architecto.", 17L, false, "Arizona24/365Designer", 32L },
                    { 31L, new Guid("31129157-56a9-b0b0-4f6b-e5a982d52731"), new DateTime(2021, 5, 22, 4, 41, 45, 309, DateTimeKind.Unspecified).AddTicks(1173), 4L, "Mollitia cumque ea cupiditate.\nNecessitatibus deserunt dolores.", "Enim dignissimos sequi hic autem consectetur.", 86L, false, "HorizontalalarmAwesome Soft Mouse", 10L }
                });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 27L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 3, 11, 21, 33, 10, 853, DateTimeKind.Unspecified).AddTicks(75), 96L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 16L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 8, 4, 1, 12, 59, 140, DateTimeKind.Unspecified).AddTicks(3612), 4L, 47L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 26L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 12, 2, 2, 51, 21, 624, DateTimeKind.Unspecified).AddTicks(1402), 79L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 37L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 3, 29, 12, 44, 27, 346, DateTimeKind.Unspecified).AddTicks(4869), 2L, 78L });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 10L, new DateTime(2021, 7, 19, 23, 51, 44, 535, DateTimeKind.Unspecified).AddTicks(1354), 5L, 40L, false },
                    { 2L, 25L, new DateTime(2022, 1, 1, 5, 17, 25, 464, DateTimeKind.Unspecified).AddTicks(7600), 2L, 72L, false },
                    { 2L, 28L, new DateTime(2021, 9, 26, 23, 22, 50, 885, DateTimeKind.Unspecified).AddTicks(7973), 5L, 74L, false },
                    { 3L, 39L, new DateTime(2021, 4, 10, 20, 15, 15, 233, DateTimeKind.Unspecified).AddTicks(231), 2L, 27L, false },
                    { 4L, 13L, new DateTime(2022, 1, 16, 0, 1, 27, 42, DateTimeKind.Unspecified).AddTicks(9397), 2L, 66L, false },
                    { 4L, 29L, new DateTime(2021, 9, 13, 13, 56, 49, 988, DateTimeKind.Unspecified).AddTicks(7560), 4L, 93L, false },
                    { 4L, 39L, new DateTime(2021, 3, 29, 21, 34, 43, 381, DateTimeKind.Unspecified).AddTicks(7352), 5L, 71L, false },
                    { 4L, 41L, new DateTime(2021, 9, 22, 22, 19, 30, 418, DateTimeKind.Unspecified).AddTicks(973), 1L, 9L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 5L, 37L, new DateTime(2021, 9, 28, 14, 25, 29, 692, DateTimeKind.Unspecified).AddTicks(3641), 2L, 46L, false },
                    { 6L, 10L, new DateTime(2021, 8, 9, 14, 7, 39, 693, DateTimeKind.Unspecified).AddTicks(1381), 4L, 53L, false },
                    { 7L, 19L, new DateTime(2021, 7, 1, 21, 32, 7, 601, DateTimeKind.Unspecified).AddTicks(3288), 1L, 2L, false },
                    { 7L, 22L, new DateTime(2022, 1, 12, 19, 21, 57, 392, DateTimeKind.Unspecified).AddTicks(4309), 5L, 42L, false },
                    { 7L, 35L, new DateTime(2022, 1, 30, 16, 19, 9, 915, DateTimeKind.Unspecified).AddTicks(7643), 4L, 52L, false },
                    { 7L, 44L, new DateTime(2021, 8, 6, 12, 12, 28, 410, DateTimeKind.Unspecified).AddTicks(8072), 5L, 3L, false },
                    { 7L, 49L, new DateTime(2021, 9, 15, 18, 21, 1, 436, DateTimeKind.Unspecified).AddTicks(7212), 1L, 12L, false },
                    { 8L, 11L, new DateTime(2022, 1, 13, 18, 8, 35, 361, DateTimeKind.Unspecified).AddTicks(5078), 2L, 90L, false },
                    { 8L, 19L, new DateTime(2021, 9, 20, 8, 44, 39, 475, DateTimeKind.Unspecified).AddTicks(6172), 4L, 98L, false },
                    { 8L, 29L, new DateTime(2021, 9, 12, 21, 26, 8, 515, DateTimeKind.Unspecified).AddTicks(5274), 4L, 36L, false },
                    { 8L, 40L, new DateTime(2021, 2, 24, 6, 23, 49, 480, DateTimeKind.Unspecified).AddTicks(6498), 4L, 58L, false },
                    { 8L, 43L, new DateTime(2021, 5, 24, 14, 53, 17, 769, DateTimeKind.Unspecified).AddTicks(5774), 2L, 11L, false },
                    { 9L, 33L, new DateTime(2021, 12, 13, 4, 26, 50, 584, DateTimeKind.Unspecified).AddTicks(1368), 5L, 41L, false },
                    { 10L, 12L, new DateTime(2021, 10, 21, 4, 49, 27, 128, DateTimeKind.Unspecified).AddTicks(2179), 3L, 34L, false },
                    { 10L, 14L, new DateTime(2021, 4, 27, 19, 24, 27, 117, DateTimeKind.Unspecified).AddTicks(262), 2L, 86L, false },
                    { 12L, 2L, new DateTime(2021, 7, 17, 6, 39, 47, 767, DateTimeKind.Unspecified).AddTicks(1041), 1L, 31L, false },
                    { 12L, 12L, new DateTime(2021, 3, 14, 2, 1, 35, 971, DateTimeKind.Unspecified).AddTicks(2927), 1L, 48L, false },
                    { 12L, 17L, new DateTime(2021, 12, 13, 8, 2, 2, 688, DateTimeKind.Unspecified).AddTicks(3174), 2L, 32L, false },
                    { 12L, 20L, new DateTime(2021, 4, 10, 16, 24, 32, 842, DateTimeKind.Unspecified).AddTicks(7998), 1L, 97L, false },
                    { 13L, 6L, new DateTime(2021, 2, 7, 14, 37, 14, 811, DateTimeKind.Unspecified).AddTicks(4929), 3L, 19L, false },
                    { 13L, 27L, new DateTime(2022, 1, 4, 6, 12, 11, 100, DateTimeKind.Unspecified).AddTicks(883), 3L, 30L, false },
                    { 14L, 23L, new DateTime(2021, 11, 26, 16, 47, 53, 456, DateTimeKind.Unspecified).AddTicks(4064), 3L, 26L, false },
                    { 14L, 37L, new DateTime(2021, 11, 24, 11, 12, 2, 418, DateTimeKind.Unspecified).AddTicks(4030), 1L, 89L, false },
                    { 14L, 41L, new DateTime(2022, 1, 27, 7, 42, 55, 123, DateTimeKind.Unspecified).AddTicks(8312), 1L, 100L, false },
                    { 14L, 47L, new DateTime(2021, 12, 14, 14, 19, 6, 620, DateTimeKind.Unspecified).AddTicks(4526), 1L, 35L, false },
                    { 15L, 24L, new DateTime(2021, 5, 18, 9, 20, 11, 488, DateTimeKind.Unspecified).AddTicks(9987), 4L, 75L, false },
                    { 15L, 28L, new DateTime(2021, 2, 2, 2, 56, 24, 927, DateTimeKind.Unspecified).AddTicks(9066), 1L, 8L, false },
                    { 15L, 38L, new DateTime(2021, 5, 11, 20, 25, 25, 794, DateTimeKind.Unspecified).AddTicks(1052), 1L, 23L, false },
                    { 16L, 9L, new DateTime(2021, 3, 18, 11, 37, 17, 99, DateTimeKind.Unspecified).AddTicks(4658), 3L, 44L, false },
                    { 16L, 38L, new DateTime(2021, 10, 25, 23, 25, 40, 301, DateTimeKind.Unspecified).AddTicks(9776), 2L, 59L, false },
                    { 17L, 4L, new DateTime(2021, 4, 28, 12, 23, 19, 593, DateTimeKind.Unspecified).AddTicks(5558), 2L, 14L, false },
                    { 18L, 41L, new DateTime(2021, 11, 23, 12, 7, 23, 787, DateTimeKind.Unspecified).AddTicks(9170), 1L, 28L, false },
                    { 19L, 13L, new DateTime(2021, 4, 20, 2, 40, 53, 103, DateTimeKind.Unspecified).AddTicks(3889), 1L, 29L, false },
                    { 20L, 9L, new DateTime(2021, 9, 1, 5, 58, 11, 85, DateTimeKind.Unspecified).AddTicks(3322), 3L, 80L, false },
                    { 21L, 10L, new DateTime(2021, 5, 9, 4, 28, 15, 777, DateTimeKind.Unspecified).AddTicks(6398), 1L, 15L, false },
                    { 24L, 2L, new DateTime(2021, 4, 2, 22, 0, 56, 429, DateTimeKind.Unspecified).AddTicks(73), 3L, 51L, false },
                    { 24L, 31L, new DateTime(2021, 2, 9, 9, 42, 50, 145, DateTimeKind.Unspecified).AddTicks(5205), 4L, 92L, false },
                    { 25L, 29L, new DateTime(2021, 4, 5, 8, 8, 54, 898, DateTimeKind.Unspecified).AddTicks(2724), 3L, 21L, false },
                    { 26L, 4L, new DateTime(2022, 1, 19, 17, 20, 10, 678, DateTimeKind.Unspecified).AddTicks(5290), 1L, 101L, false },
                    { 26L, 23L, new DateTime(2021, 5, 19, 8, 16, 42, 251, DateTimeKind.Unspecified).AddTicks(2798), 5L, 56L, false },
                    { 26L, 42L, new DateTime(2022, 1, 5, 23, 30, 53, 570, DateTimeKind.Unspecified).AddTicks(8881), 5L, 18L, false },
                    { 27L, 5L, new DateTime(2021, 3, 22, 15, 28, 44, 743, DateTimeKind.Unspecified).AddTicks(7990), 2L, 84L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 28L, 21L, new DateTime(2021, 9, 7, 20, 59, 28, 181, DateTimeKind.Unspecified).AddTicks(165), 3L, 49L, false },
                    { 29L, 14L, new DateTime(2021, 11, 21, 21, 25, 54, 904, DateTimeKind.Unspecified).AddTicks(2554), 5L, 68L, false },
                    { 29L, 29L, new DateTime(2021, 9, 12, 16, 2, 33, 29, DateTimeKind.Unspecified).AddTicks(1975), 1L, 94L, false },
                    { 29L, 34L, new DateTime(2021, 11, 24, 6, 21, 30, 21, DateTimeKind.Unspecified).AddTicks(9011), 4L, 60L, false },
                    { 29L, 39L, new DateTime(2021, 4, 3, 5, 57, 55, 489, DateTimeKind.Unspecified).AddTicks(8425), 2L, 38L, false },
                    { 30L, 12L, new DateTime(2022, 1, 8, 12, 53, 58, 468, DateTimeKind.Unspecified).AddTicks(7163), 5L, 50L, false },
                    { 30L, 34L, new DateTime(2021, 7, 9, 18, 39, 35, 627, DateTimeKind.Unspecified).AddTicks(572), 5L, 54L, false },
                    { 30L, 36L, new DateTime(2021, 3, 14, 10, 18, 53, 131, DateTimeKind.Unspecified).AddTicks(3351), 2L, 83L, false },
                    { 30L, 39L, new DateTime(2021, 10, 2, 19, 41, 36, 866, DateTimeKind.Unspecified).AddTicks(7822), 5L, 55L, false },
                    { 32L, 50L, new DateTime(2021, 12, 19, 19, 46, 29, 120, DateTimeKind.Unspecified).AddTicks(6387), 5L, 7L, false },
                    { 33L, 26L, new DateTime(2021, 4, 9, 11, 10, 22, 891, DateTimeKind.Unspecified).AddTicks(8054), 2L, 62L, false },
                    { 33L, 37L, new DateTime(2021, 7, 31, 18, 3, 42, 447, DateTimeKind.Unspecified).AddTicks(635), 4L, 64L, false },
                    { 34L, 46L, new DateTime(2021, 2, 11, 12, 35, 40, 308, DateTimeKind.Unspecified).AddTicks(5890), 5L, 33L, false },
                    { 35L, 29L, new DateTime(2021, 8, 23, 6, 16, 36, 440, DateTimeKind.Unspecified).AddTicks(7534), 4L, 81L, false },
                    { 36L, 22L, new DateTime(2021, 12, 24, 4, 42, 4, 110, DateTimeKind.Unspecified).AddTicks(7856), 2L, 61L, false },
                    { 36L, 27L, new DateTime(2021, 10, 10, 11, 21, 25, 692, DateTimeKind.Unspecified).AddTicks(3547), 2L, 45L, false },
                    { 37L, 5L, new DateTime(2021, 2, 7, 2, 41, 48, 621, DateTimeKind.Unspecified).AddTicks(2531), 4L, 25L, false },
                    { 37L, 16L, new DateTime(2021, 11, 13, 18, 29, 38, 709, DateTimeKind.Unspecified).AddTicks(9969), 5L, 39L, false },
                    { 37L, 31L, new DateTime(2021, 6, 1, 11, 47, 10, 376, DateTimeKind.Unspecified).AddTicks(711), 1L, 65L, false },
                    { 37L, 35L, new DateTime(2021, 9, 21, 14, 21, 39, 927, DateTimeKind.Unspecified).AddTicks(7281), 1L, 13L, false },
                    { 39L, 10L, new DateTime(2021, 11, 29, 15, 59, 38, 135, DateTimeKind.Unspecified).AddTicks(5172), 2L, 70L, false },
                    { 39L, 26L, new DateTime(2022, 1, 23, 15, 5, 11, 755, DateTimeKind.Unspecified).AddTicks(5260), 5L, 85L, false },
                    { 39L, 49L, new DateTime(2021, 9, 25, 23, 50, 58, 127, DateTimeKind.Unspecified).AddTicks(3807), 5L, 5L, false },
                    { 40L, 23L, new DateTime(2021, 9, 26, 4, 54, 6, 997, DateTimeKind.Unspecified).AddTicks(1486), 4L, 67L, false },
                    { 40L, 25L, new DateTime(2021, 9, 14, 7, 40, 8, 103, DateTimeKind.Unspecified).AddTicks(6145), 2L, 99L, false },
                    { 41L, 6L, new DateTime(2022, 1, 5, 19, 48, 51, 781, DateTimeKind.Unspecified).AddTicks(9451), 2L, 88L, false },
                    { 42L, 34L, new DateTime(2021, 2, 20, 19, 22, 16, 750, DateTimeKind.Unspecified).AddTicks(2820), 4L, 73L, false },
                    { 43L, 10L, new DateTime(2021, 8, 7, 6, 45, 54, 32, DateTimeKind.Unspecified).AddTicks(9912), 5L, 22L, false },
                    { 43L, 25L, new DateTime(2021, 6, 4, 9, 49, 53, 550, DateTimeKind.Unspecified).AddTicks(1845), 3L, 87L, false },
                    { 44L, 45L, new DateTime(2022, 1, 9, 21, 5, 17, 314, DateTimeKind.Unspecified).AddTicks(7898), 5L, 4L, false },
                    { 45L, 7L, new DateTime(2021, 6, 30, 1, 7, 18, 614, DateTimeKind.Unspecified).AddTicks(1453), 4L, 10L, false },
                    { 45L, 40L, new DateTime(2021, 12, 16, 21, 10, 51, 535, DateTimeKind.Unspecified).AddTicks(5882), 2L, 91L, false },
                    { 46L, 45L, new DateTime(2021, 12, 6, 12, 11, 19, 969, DateTimeKind.Unspecified).AddTicks(2552), 3L, 76L, false },
                    { 47L, 47L, new DateTime(2021, 10, 31, 10, 56, 40, 608, DateTimeKind.Unspecified).AddTicks(3955), 5L, 43L, false },
                    { 48L, 16L, new DateTime(2022, 1, 17, 22, 55, 53, 909, DateTimeKind.Unspecified).AddTicks(4132), 5L, 95L, false },
                    { 48L, 37L, new DateTime(2021, 6, 10, 20, 5, 30, 277, DateTimeKind.Unspecified).AddTicks(1533), 4L, 63L, false },
                    { 49L, 14L, new DateTime(2021, 7, 4, 0, 5, 4, 262, DateTimeKind.Unspecified).AddTicks(7232), 1L, 16L, false },
                    { 49L, 35L, new DateTime(2021, 3, 20, 11, 38, 43, 966, DateTimeKind.Unspecified).AddTicks(4660), 2L, 24L, false },
                    { 50L, 7L, new DateTime(2021, 12, 23, 12, 29, 59, 629, DateTimeKind.Unspecified).AddTicks(8895), 4L, 6L, false },
                    { 50L, 45L, new DateTime(2021, 3, 16, 8, 6, 1, 244, DateTimeKind.Unspecified).AddTicks(4164), 4L, 82L, false },
                    { 50L, 47L, new DateTime(2021, 4, 12, 9, 36, 41, 283, DateTimeKind.Unspecified).AddTicks(1477), 4L, 17L, false },
                    { 51L, 11L, new DateTime(2021, 10, 4, 6, 33, 5, 653, DateTimeKind.Unspecified).AddTicks(2922), 3L, 37L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 51L, 35L, new DateTime(2021, 3, 28, 2, 57, 57, 951, DateTimeKind.Unspecified).AddTicks(8237), 1L, 20L, false },
                    { 51L, 42L, new DateTime(2021, 6, 19, 16, 14, 31, 284, DateTimeKind.Unspecified).AddTicks(4048), 5L, 57L, false }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId" },
                values: new object[] { new DateTime(2021, 7, 13, 11, 54, 14, 6, DateTimeKind.Unspecified).AddTicks(8856), "Quaerat voluptas debitis.\nSoluta harum voluptatem quam reprehenderit.\nEt ut dolor dolorem minima ea.\nDicta cum quo vel error quis delectus.", false, 31L, new Guid("783eb20f-a38c-9c37-d8d6-466fbb77b46c") });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 23, 16, 36, 41, 14, DateTimeKind.Unspecified).AddTicks(4289), 1L, "Molestiae ullam eos cumque eligendi qui.\nUt vitae eum omnis sit magni harum deserunt velit praesentium.\nQuia magni rem enim unde alias.\nQui similique commodi dolores explicabo repellendus perspiciatis et repellendus pariatur.", 51L, new Guid("9434d6f2-db2e-2d8d-2d5b-b5f8165defff"), "Voluptatem omnis rem vero." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 7, 17, 12, 1, 270, DateTimeKind.Unspecified).AddTicks(8434), 4L, "Numquam soluta ut.\nNihil esse odio quam possimus assumenda et et dolore.\nEst totam in aliquid hic ab quia at saepe omnis.\nQuam eos nemo repellendus.\nVel neque impedit aliquam vero provident quidem iure.", false, 40L, new Guid("d7b5c2c2-c36e-506a-cb6c-21173a897210"), "Commodi similique eligendi ullam architecto numquam voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 6, 21, 38, 45, 196, DateTimeKind.Unspecified).AddTicks(1549), 3L, "Aut voluptas dolor dignissimos illo et illo soluta ut.\nNon commodi perferendis nemo dolorum impedit assumenda esse dolores quod.", 44L, new Guid("5d38c045-478f-fd15-8e3c-6e570b01fb64"), "Quo aspernatur repellat quas molestiae earum est molestiae adipisci blanditiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 13, 2, 0, 11, 397, DateTimeKind.Unspecified).AddTicks(5007), 4L, "Aperiam eos culpa sunt et.\nIpsum sit est ut sed aut ipsum quia ratione.\nEx distinctio architecto necessitatibus consectetur et.\nHarum inventore consequatur sit provident.", 23L, new Guid("995a2feb-577e-6147-e89a-342d332cafb2"), "Sint repudiandae aut ex sunt excepturi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 24, 8, 18, 25, 688, DateTimeKind.Unspecified).AddTicks(9807), 4L, "Id eos hic sint.\nIn rerum est ut enim facilis.\nFuga alias adipisci rem quasi blanditiis saepe rerum earum.\nPossimus eum et odio dolorum consequatur et nihil deserunt.\nQuis ea quisquam sunt voluptatibus.", 37L, new Guid("29cb93bd-5fab-7393-5e08-e2e74d460183"), "Unde quia tenetur non." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 10, 13, 28, 14, 777, DateTimeKind.Unspecified).AddTicks(4189), "Eius minima aut corrupti nemo placeat.\nDoloremque eum sint quas dolor.", true, 26L, new Guid("1fe51e20-904a-1b42-0cf2-4fbb2c0b637f"), "Quia magnam id dolorum earum error ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 30, 21, 31, 52, 591, DateTimeKind.Unspecified).AddTicks(9956), 3L, "Illum dolore animi repellendus.\nOmnis ut debitis nemo quas quod dolorum magnam perferendis quia.", true, 5L, new Guid("5ad2e8bc-56a2-fa71-4c75-fd37ecbbd2eb"), "Inventore itaque soluta amet sed a maiores." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 5, 58, 423, DateTimeKind.Unspecified).AddTicks(9965), 1L, "Non nihil sapiente facere distinctio repudiandae vel quo.\nAut dolores tempore nemo ab omnis.\nAliquid blanditiis repellendus impedit.\nEius et laborum minus odio.\nMaiores repudiandae incidunt aliquid dolores aut.", 46L, new Guid("c8356020-8048-a640-b44f-e3dcc2836716"), "Eligendi quo facere non deleniti eum omnis est." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 20, 11, 38, 2, 770, DateTimeKind.Unspecified).AddTicks(3507), 2L, "Repellat similique molestias sequi nihil quia in ut reiciendis.\nCumque et ut in voluptatem fugit.", 34L, new Guid("85174054-f0d8-dd2b-e86a-ff27bbee79af"), "Consectetur aut numquam id similique veniam numquam quo quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 3, 12, 33, 23, 701, DateTimeKind.Unspecified).AddTicks(4442), 1L, "Inventore qui hic repellat aut sit ipsum et.\nCorporis aut officia.\nUt quo eos.\nNostrum distinctio odit eveniet voluptatem vel sit debitis ullam.", 3L, new Guid("89d891c9-d5b8-5f5c-1aff-cfeb91779791"), "Accusantium voluptatibus quam sit asperiores praesentium." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 1, 20, 13, 23, 542, DateTimeKind.Unspecified).AddTicks(1383), 5L, "Sed et nisi dolores deleniti non quos dignissimos ut.\nNulla ducimus ex quasi nihil.\nRerum mollitia aut qui itaque.\nIn voluptas consequuntur mollitia officiis.\nEligendi fugiat sapiente eum ut id.", 5L, new Guid("da28211a-e898-6ace-7330-33e80ab340e8"), "Non ex quod quia voluptatem molestias facere accusamus ullam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 4, 25, 16, 15, 10, 600, DateTimeKind.Unspecified).AddTicks(2246), 1L, "Aspernatur dolorum iusto aliquid ea et.\nVelit voluptas eos consequatur velit vero distinctio non incidunt.", 12L, new Guid("f0569931-a37b-1837-2376-a5b99deb6e32"), "Est quod et voluptatem vel maiores laudantium et rerum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 30, 5, 10, 29, 103, DateTimeKind.Unspecified).AddTicks(7110), 3L, "Ut ex nihil corrupti provident sed et porro.", true, 37L, new Guid("235d142c-579e-f05f-fdd6-c3b0ab7e52f2"), "Perferendis et voluptas voluptas blanditiis beatae itaque aperiam." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 2, 19, 55, 38, 732, DateTimeKind.Unspecified).AddTicks(7856), 5L, "Consequatur minima minus laborum inventore.\nAut qui nulla ea.\nOptio qui ipsam ab ad in sint.\nVoluptas aliquam velit natus quas perspiciatis.", false, 8L, new Guid("0b37a7b2-9271-5be4-819e-09489e03e7b2"), "Est fugiat vel magni sunt sunt quia sit exercitationem vitae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 9, 1, 27, 44, 232, DateTimeKind.Unspecified).AddTicks(8451), 4L, "Tempora quasi ea maiores fugit sit architecto blanditiis.\nVoluptatem doloribus autem.\nMolestiae maiores id.\nQui deleniti provident in ut.", 37L, new Guid("b8a9b5ed-d95e-1d56-86dd-88ba4988a240"), "Et similique vel fugiat occaecati perferendis aliquid velit voluptates." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 19, 46, 272, DateTimeKind.Unspecified).AddTicks(3397), "Quia debitis facilis laboriosam quibusdam.", true, 27L, new Guid("ac2c8425-76e8-62f9-dab4-fc1a2c4a00b0"), "Error adipisci odio molestias porro repudiandae exercitationem quia nisi omnis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 29, 5, 27, 17, 373, DateTimeKind.Unspecified).AddTicks(2777), 1L, "Est nisi ab vitae dignissimos ut tempora est illum ut.\nCulpa ab quam voluptas animi qui et.\nQui non reprehenderit sed quo ipsum ipsum et officia adipisci.", true, 40L, new Guid("179cfcd3-20b5-c592-f99b-4b2ad5244f46"), "Ad aut quod et rerum illo laboriosam dignissimos eaque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 8, 18, 3, 38, 56, 41, DateTimeKind.Unspecified).AddTicks(6503), 2L, "Modi numquam voluptates enim quae.\nProvident est eos culpa ea et assumenda quod.\nNostrum vel fuga et itaque aliquam ut.\nVelit magni nam non quo aliquid quam adipisci odio.\nAliquid officiis est earum.", 17L, new Guid("8750f2c2-b0b4-77f5-fe19-4887df46cafa"), "Est aspernatur maiores at." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 12, 9, 23, 35, 24, DateTimeKind.Unspecified).AddTicks(42), "Sapiente quod quam accusamus quo aliquid.\nNemo sint deleniti eveniet impedit deleniti.\nAsperiores sit sunt.\nRerum qui perferendis quas quia nemo repellat molestiae dignissimos.", false, 48L, new Guid("feba2bea-d041-b6f8-9c7b-2d12c1fdf4ba"), "Quidem iure ex dolores atque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 13, 57, 103, DateTimeKind.Unspecified).AddTicks(623), 1L, "Et similique quis distinctio fugiat sapiente.\nVoluptatum nam id sed aut illum saepe rerum qui.\nIste nesciunt dolorem.\nAlias est id repellat tempore praesentium et.\nRecusandae est hic eveniet et ratione repellat et.", false, 38L, new Guid("484f173a-bf87-0037-2747-0be5f4de2f04"), "Sint consequatur reprehenderit reprehenderit veritatis assumenda doloremque illo error officiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 8, 4, 40, 46, 524, DateTimeKind.Unspecified).AddTicks(8857), 1L, "Et velit maxime rerum.\nVoluptas eum aut dignissimos dolorem tempora ratione expedita.\nSint debitis ut velit natus impedit doloribus pariatur assumenda et.\nEt explicabo error.\nEt iste quae impedit voluptates ratione tenetur voluptas.", true, 31L, new Guid("f9c19bfa-1df6-fe75-d1b0-929dc6dc6b85"), "Omnis perspiciatis vitae illo sequi qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 10, 17, 7, 14, 22, 941, DateTimeKind.Unspecified).AddTicks(5663), "Aperiam assumenda eum sint rem consequatur magnam.\nError reprehenderit necessitatibus.\nSint veritatis quis magni debitis officia.\nSunt cupiditate laboriosam id aut vel aut optio.", true, 5L, new Guid("7beefe42-a720-785e-3cda-57f33a9ab236"), "Animi soluta cum qui reiciendis porro facilis fuga accusamus molestiae." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 8, 2, 32, 6, 301, DateTimeKind.Unspecified).AddTicks(8606), 1L, "Eaque optio doloremque voluptatem nihil et enim pariatur.", 5L, new Guid("4b29dc19-0d26-9ad8-8ed9-7cb839912d29"), "Sint vitae officia aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 18, 14, 10, 11, 519, DateTimeKind.Unspecified).AddTicks(6331), 4L, "Sunt hic voluptatem.\nA quia accusamus ad ut in molestias facere natus.\nArchitecto repudiandae qui molestiae vero nostrum nam odit placeat officiis.\nMinima iusto et est et dolore temporibus in velit.\nAd repellendus optio voluptas vero sed explicabo nobis iste sed.", false, 2L, new Guid("b0accb12-0245-68c7-98b6-08eebc1e7538"), "Fugiat rem ut provident modi itaque." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 13, 22, 14, 37, 54, DateTimeKind.Unspecified).AddTicks(4097), 3L, "Sunt nihil consectetur facere quia enim aut quod sed.\nLaudantium animi reiciendis temporibus quos quasi molestias cum.\nDelectus non totam rerum ea in ut facilis.\nQuia voluptate sit soluta consectetur nulla fugiat quae.\nCupiditate ut voluptate.", true, 15L, new Guid("23153fb3-9a61-52c7-7819-0a7925a6ac1b"), "Assumenda dolor consectetur animi voluptate totam sed." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 8, 20, 16, 29, 638, DateTimeKind.Unspecified).AddTicks(8155), 3L, "Voluptatibus est et.\nUt sapiente maxime quisquam minima laboriosam architecto eos deserunt temporibus.\nIncidunt nesciunt et qui molestias tempora ipsum voluptatem dolor sint.", 41L, new Guid("09744f50-eb74-430b-dd48-e4d10071cb95"), "Quia velit sunt et qui et beatae qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 6, 17, 17, 47, 306, DateTimeKind.Unspecified).AddTicks(9871), "Qui laudantium sapiente quam dolorem aliquam vel similique enim.\nVitae et sequi quidem accusantium consequatur.\nOfficia porro neque aspernatur beatae tempora necessitatibus voluptatem.\nRepellendus ex praesentium iste iure fugit voluptas dolorem pariatur.\nAmet ut aut sed magnam quas ut explicabo.", false, 47L, new Guid("f5b5f012-23c9-3b0b-e8cd-f8f2292e0df8"), "Quasi et illo tempore quidem corporis quia voluptatem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2022, 1, 24, 19, 44, 52, 150, DateTimeKind.Unspecified).AddTicks(8569), "Voluptates deserunt odit dolores.\nSed aut quo eum eius optio placeat necessitatibus quia aut.\nMolestias aut qui cum veritatis autem.\nAliquam accusantium aut qui odio quis.", true, 23L, new Guid("46dbbb1e-3e59-e850-8244-13132c4f780e"), "Et vero quidem modi libero quo autem." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 8, 15, 35, 48, 868, DateTimeKind.Unspecified).AddTicks(7970), 1L, "Sed adipisci pariatur.\nUt exercitationem nam.\nOfficia autem tenetur qui voluptas quam.\nQuia voluptate voluptatibus et corrupti corporis neque excepturi labore impedit.\nSint modi voluptatibus rem quo est dicta non quidem et.", true, new Guid("3f285d00-53d8-2572-22fb-5477bb067a6d"), "Possimus sed ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 16, 7, 30, 58, 45, DateTimeKind.Unspecified).AddTicks(2017), 5L, "Facilis repudiandae dolor architecto.", false, 22L, new Guid("d9bebc6b-8ef6-c689-a73a-da5b1c439517"), "Suscipit ipsa explicabo veritatis officia labore corrupti." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 27, 22, 0, 5, 859, DateTimeKind.Unspecified).AddTicks(8992), 1L, "Voluptatem enim hic voluptates modi corrupti voluptas voluptas.\nOdio minima nihil hic ducimus.", false, 2L, new Guid("f6443229-5f6e-3a38-a34e-92953eb9f3d1"), "Ut sed esse quia sed et molestiae repellat aut odit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 12, 3, 9, 31, 281, DateTimeKind.Unspecified).AddTicks(4771), 5L, "Ad fugiat ut consequatur.\nDistinctio et quidem sit sint.\nEa earum non animi ipsam voluptas dolores quia itaque est.", false, 34L, new Guid("befff852-e804-1468-d8ae-520e542b9df3"), "Quibusdam odit quo." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 9, 14, 19, 45, 14, 531, DateTimeKind.Unspecified).AddTicks(3028), 2L, "Et consequuntur provident labore.\nEt quas sed.\nSit aut tempora numquam error molestiae eaque.\nVeritatis voluptates quis vitae consequatur.\nDucimus quo rerum aut enim.", 3L, new Guid("883e510d-362c-20d1-8818-187bfb8b188c"), "Aspernatur modi animi." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 21, 17, 12, 11, 567, DateTimeKind.Unspecified).AddTicks(2269), 1L, "Autem quibusdam dicta non.\nAut adipisci ipsum corrupti et quisquam.\nNisi ut voluptas.\nOfficia incidunt et quisquam omnis asperiores labore nobis quia ea.", 7L, new Guid("698246bf-70d2-613a-54e4-9936253d1a42"), "Officiis ullam aspernatur et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 8, 4, 48, 51, 687, DateTimeKind.Unspecified).AddTicks(5330), "Molestiae reprehenderit et natus in sed voluptatem quia dicta.\nAccusamus et et.\nDolorum voluptas doloremque asperiores ea dolor.\nUt est laudantium hic rerum hic.\nEx labore recusandae quibusdam velit ipsa.", 18L, new Guid("b5c6a9b3-fae5-416f-42dc-00055ec0eeae"), "Vel natus quisquam quas." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 21, 4, 44, 20, 278, DateTimeKind.Unspecified).AddTicks(6650), 5L, "Architecto quasi et et eum exercitationem veritatis nostrum esse.\nEx ea veritatis laudantium aut.\nQuas eaque odit aut qui.\nNisi alias est ab perspiciatis consequatur consequuntur qui.\nEum et odio quasi officia incidunt enim vitae voluptatem.", 29L, new Guid("3652704d-61fe-61e6-98b4-e865b255f96c"), "Voluptatem molestiae explicabo quis ratione expedita distinctio." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 7, 10, 7, 21, 711, DateTimeKind.Unspecified).AddTicks(3876), 1L, "A dicta totam voluptas.", 13L, new Guid("8f622a84-902f-b9eb-9bfd-27fb366bda91"), "Et occaecati voluptatem non voluptatem aliquam non quos aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 24, 22, 26, 33, 936, DateTimeKind.Unspecified).AddTicks(3796), 1L, "Aliquam ea quas.\nQuas quas voluptatem sit et cupiditate eos.", true, 3L, new Guid("efe20641-2a0b-be0b-0ec9-c31d4d1602fd"), "Modi quo aut error iste suscipit enim." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 25, 16, 28, 14, 280, DateTimeKind.Unspecified).AddTicks(4642), 5L, "Vero aperiam sed provident consequuntur vel quaerat incidunt.", 2L, new Guid("8b128a16-788f-f422-d333-58cd985a083b"), "Quidem optio ea quaerat illo est illum placeat qui rerum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 2, 2, 4, 31, 12, 244, DateTimeKind.Unspecified).AddTicks(6771), 4L, "Est reprehenderit autem veritatis.\nPerspiciatis culpa optio ut aut numquam voluptas.\nConsequuntur sit praesentium sint cupiditate tempora quisquam.", false, 45L, new Guid("adaccbca-aaea-5cfe-3b54-4c936d893ec2"), "Possimus nesciunt eos dolorem velit reiciendis id." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 6, 2, 8, 3, 46, 720, DateTimeKind.Unspecified).AddTicks(605), 2L, "Consequatur amet quisquam voluptatem vero cumque autem.", true, 33L, new Guid("c4a11060-a16a-50de-0424-72021f6ba014"), "Rerum veniam voluptates voluptatem sint et maxime nihil." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 6, 23, 44, 30, 481, DateTimeKind.Unspecified).AddTicks(1628), 4L, "Eum rerum pariatur fugiat consequuntur.\nIncidunt nisi vitae.\nIn ad et voluptatem id eveniet quia animi tempora et.\nEveniet consequuntur nihil temporibus nesciunt similique quibusdam.", false, 45L, new Guid("28b30d7d-6f16-8e86-d48f-66f0ea83fe80"), "Eum ratione totam et nulla odio et incidunt." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 5, 4, 11, 39, 26, 423, DateTimeKind.Unspecified).AddTicks(2867), 1L, "Non omnis molestiae quae delectus iusto iusto error numquam.\nLibero quasi ratione perspiciatis inventore.\nEligendi a ut voluptatem ab accusantium cupiditate.\nExcepturi voluptatem doloremque.", false, 41L, new Guid("2f9c9a7f-aa7a-3612-21ab-61ba6b5f7c04"), "Atque est perspiciatis vel." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 7, 7, 5, 37, 21, 282, DateTimeKind.Unspecified).AddTicks(4948), 3L, "Vel provident facilis ea.\nDolor odit sunt explicabo libero molestias et ad error eius.\nMaxime ipsum voluptatem consequatur et.\nEnim fuga aperiam voluptatem ullam.\nConsequatur molestias molestiae.", false, 40L, new Guid("c15a9de6-069e-e57b-9de2-4bbb95253c25"), "Ea quidem cum repellendus tenetur rem cum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 1, 9, 32, 15, 531, DateTimeKind.Unspecified).AddTicks(7827), 2L, "Quod libero explicabo est doloribus minima dolore.\nMolestiae doloremque vel sed qui omnis odio.\nEum iure sed ratione amet et consectetur incidunt omnis ut.\nAut placeat et rerum dolores earum doloremque autem.", 3L, new Guid("752f5085-e02c-9c1b-6daf-f4d3561b49ac"), "Doloremque sed et quia omnis impedit et sed amet magni." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 30, 21, 17, 30, 312, DateTimeKind.Unspecified).AddTicks(6248), "Ipsam deserunt optio voluptatibus et accusamus.\nPraesentium quidem minus corrupti.", 30L, new Guid("d7fe77a5-1ad5-388d-7975-c1853e2b27f0"), "Esse optio eum dolorum qui praesentium nemo." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 27, 4, 652, DateTimeKind.Unspecified).AddTicks(5226), 3L, "Distinctio mollitia doloremque harum eius rerum.\nRerum ut commodi vitae eius enim consequatur deserunt dolorem voluptas.\nEnim veritatis enim aut eligendi qui maiores fuga.\nNam consequuntur nisi dicta modi dolorum dolorem.", false, 36L, new Guid("b71a8d2d-76ff-c76a-4da3-147132a23998"), "Veniam molestiae veniam ducimus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 11, 25, 20, 2, 52, 760, DateTimeKind.Unspecified).AddTicks(3652), 5L, "Natus ad eos animi dignissimos ipsa et voluptate non.\nFugiat suscipit non quod aut.", 38L, new Guid("5b88072c-14ed-1ce9-75f9-0d10ad51382a"), "Iusto est repellendus eos vel hic." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "ProjectDocumentId", "Title" },
                values: new object[] { new DateTime(2021, 12, 3, 13, 55, 10, 671, DateTimeKind.Unspecified).AddTicks(5719), 3L, "Voluptas numquam et eaque voluptatem optio.\nQuo qui aut sint est non labore provident voluptas illo.\nDebitis distinctio et.", 44L, new Guid("ef37f685-9efc-5926-c3ba-b3142d904c8d"), "Voluptas tenetur ut fuga quasi soluta." });

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
                    { 16L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "asp.net" },
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
                    { 32L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "xml" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 33L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "asp.net-mvc" },
                    { 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "vba" },
                    { 35L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "spring" },
                    { 36L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "laravel" },
                    { 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, false, "database" }
                });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Sunt quo dolorem autem ex perspiciatis magnam quaerat aliquid et.\nDignissimos velit recusandae id cupiditate ea harum modi.", new DateTime(2022, 1, 21, 11, 34, 1, 348, DateTimeKind.Unspecified).AddTicks(6466), 5L, 22L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Culpa consequatur magni quia veritatis omnis qui.\nRecusandae distinctio et nam quia.\nEius doloribus commodi.", new DateTime(2021, 5, 7, 2, 47, 58, 643, DateTimeKind.Unspecified).AddTicks(6679), 2L, 58L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 34L, "Est porro debitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.\nOfficia beatae ut ad vitae eos sequi unde alias.\nEveniet nisi voluptas non assumenda est dignissimos ea.\nSit at placeat optio aliquam sapiente pariatur.\nEt enim quae accusamus molestiae labore at fuga nam libero.", new DateTime(2021, 5, 14, 3, 58, 33, 518, DateTimeKind.Unspecified).AddTicks(1449), 5L, 57L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 25L, "Doloribus omnis aliquid deleniti provident excepturi.\nQui omnis voluptas odit.\nQuo vel aut ipsam ut earum incidunt labore a aut.", new DateTime(2021, 7, 2, 2, 43, 36, 160, DateTimeKind.Unspecified).AddTicks(8026), 3L, 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 21L, "Quibusdam libero facere praesentium rem ea impedit voluptatum est consequatur.", new DateTime(2021, 10, 9, 14, 57, 28, 795, DateTimeKind.Unspecified).AddTicks(5344), 1L, 34L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 16L, "Magni at repellendus.", new DateTime(2021, 8, 19, 20, 32, 22, 12, DateTimeKind.Unspecified).AddTicks(1254), 2L, 54L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 26L, "Commodi libero dicta temporibus atque earum ut.\nEos qui eum totam debitis id.\nAdipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 12L });

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
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 4L, 75L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, 61L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 4L, 78L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 4L, 68L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 3L, 12L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 1L, 68L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 3L, 47L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 2L, 72L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 10L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 5L, 18L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 3L, 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 13L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 13L, "Non fugiat non porro vero reiciendis et.\nEnim facere autem molestiae.", new DateTime(2021, 4, 1, 7, 35, 59, 215, DateTimeKind.Unspecified).AddTicks(830), 5L, 12L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 44L, "Sed tempora non officiis est sit eveniet.\nArchitecto corrupti id rerum quam nesciunt assumenda odio ut maxime.\nUt animi in iste voluptatibus aliquid ut vitae.\nVelit exercitationem vero id sed quibusdam non.\nUt at ratione qui consectetur quam voluptas dolor dolorum.", new DateTime(2021, 8, 14, 13, 57, 37, 263, DateTimeKind.Unspecified).AddTicks(4946), 5L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 3L, 20L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 41L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 5L, "Dolore nihil voluptas doloremque accusantium.\nAnimi aspernatur mollitia.", new DateTime(2021, 6, 17, 15, 1, 38, 939, DateTimeKind.Unspecified).AddTicks(7420), 1L, 16L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 27L, "Hic vitae tempora tempore et dignissimos perferendis omnis aut.", new DateTime(2021, 3, 12, 22, 52, 25, 95, DateTimeKind.Unspecified).AddTicks(9008), 2L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 29L, "Excepturi mollitia vitae accusantium autem repudiandae.\nEst rem ex rerum sunt suscipit voluptatem veniam aut.\nMaiores similique assumenda tempore est inventore aut omnis.\nEt ut corporis dolorem deleniti dolorem laudantium mollitia.", new DateTime(2021, 4, 6, 19, 23, 18, 77, DateTimeKind.Unspecified).AddTicks(4489), 77L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 10L, "Sequi reprehenderit ipsam.\nEt enim error quia quia error tenetur mollitia eligendi.\nNostrum voluptatibus magni natus assumenda quis.\nMaiores ut itaque ea et voluptatem et maxime praesentium.", new DateTime(2021, 5, 20, 9, 52, 1, 466, DateTimeKind.Unspecified).AddTicks(4088), 15L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Est ab nemo.\nAut aspernatur dolores suscipit similique necessitatibus id voluptatem quidem.\nDolores consequatur tenetur.\nAd dolorem ipsa autem et.\nNostrum cumque praesentium.", new DateTime(2021, 9, 22, 15, 38, 2, 296, DateTimeKind.Unspecified).AddTicks(2770), 4L, 33L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 2L, "Non sit beatae aliquam reiciendis enim tempore.\nPerferendis quis excepturi eveniet repellat tempora.\nVoluptas aut numquam eveniet et et eaque enim.\nAdipisci et ad quidem placeat earum dolor.\nDolorum voluptate molestiae nihil illo fugit aut.\nAnimi soluta accusantium.", new DateTime(2021, 10, 18, 16, 4, 44, 926, DateTimeKind.Unspecified).AddTicks(6113), 75L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Doloribus excepturi similique eos est.\nSaepe et qui ab unde deserunt est quis.\nLabore facere dolor.", new DateTime(2022, 1, 15, 18, 52, 37, 713, DateTimeKind.Unspecified).AddTicks(9441), 25L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 18L, "Doloribus omnis dignissimos mollitia alias omnis vitae deleniti.\nNesciunt qui voluptatem amet odio ullam.", new DateTime(2021, 6, 20, 20, 32, 47, 556, DateTimeKind.Unspecified).AddTicks(3441), 69L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 20L, "Aut quis eum nostrum quod eum quos et sunt.\nOccaecati earum itaque libero in nihil.", new DateTime(2021, 10, 12, 9, 43, 10, 483, DateTimeKind.Unspecified).AddTicks(3703), 31L });

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
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Maiores corrupti itaque laudantium pariatur.\nDoloribus vel rerum velit nihil omnis temporibus ut exercitationem.\nExercitationem sapiente aliquid est vero.\nImpedit eveniet pariatur laboriosam.\nDolores in placeat in blanditiis voluptatum est iusto est at.", new DateTime(2021, 10, 18, 11, 35, 38, 665, DateTimeKind.Unspecified).AddTicks(3588), 1L, 68L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 30L, "Architecto dolor odit est ducimus tempora consequuntur minima atque laborum.", new DateTime(2021, 5, 19, 8, 26, 26, 321, DateTimeKind.Unspecified).AddTicks(5379), 64L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iusto laboriosam numquam eos quia asperiores sunt delectus sint omnis.\nOmnis et sit quae animi sed et praesentium.\nOdit eveniet perspiciatis sint voluptatum suscipit est consequatur.\nUllam accusamus ut ut qui dolorem.\nQuibusdam corporis impedit.\nQuos natus tenetur adipisci rem maxime libero sit.", new DateTime(2021, 12, 14, 6, 12, 27, 982, DateTimeKind.Unspecified).AddTicks(9982), 1L, 16L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Officia ad soluta nostrum ullam et facilis quo.", new DateTime(2021, 5, 8, 5, 13, 27, 480, DateTimeKind.Unspecified).AddTicks(7761), 1L, 76L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 12L, "Molestias voluptatem asperiores et autem ex voluptatibus distinctio sed.\nDeserunt ducimus pariatur non.", new DateTime(2021, 10, 18, 17, 12, 20, 582, DateTimeKind.Unspecified).AddTicks(5471), 52L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 34L, "Beatae sapiente nam ut.", new DateTime(2021, 10, 8, 19, 16, 13, 405, DateTimeKind.Unspecified).AddTicks(388), 26L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Ut saepe adipisci voluptatibus asperiores est amet.\nArchitecto soluta dolore dignissimos et.\nAut vitae et non.\nTempora officiis modi commodi et harum molestiae.\nExplicabo totam veniam voluptatem sed.", new DateTime(2021, 8, 25, 23, 33, 24, 472, DateTimeKind.Unspecified).AddTicks(9464), 5L, 49L });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 4, 28, 9, 12, 3, 941, DateTimeKind.Unspecified).AddTicks(2507), 1L, 911, false, 15L, 58 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 8, 14, 3, 25, 12, 800, DateTimeKind.Unspecified).AddTicks(6113), 1L, 621, null, 20L, 71 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 39, 55, 556, DateTimeKind.Unspecified).AddTicks(8928), 2L, 983, 40L, 136 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 4L, new DateTime(2021, 2, 14, 22, 54, 8, 873, DateTimeKind.Unspecified).AddTicks(5315), 4L, 890, null, 3L, 148 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2022, 1, 28, 0, 19, 20, 213, DateTimeKind.Unspecified).AddTicks(5828), 4L, 880, 31L, 446 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 8, 9, 13, 48, 47, 354, DateTimeKind.Unspecified).AddTicks(8820), 2L, 704, true, 28L, null, 113 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 5, 24, 17, 31, 30, 640, DateTimeKind.Unspecified).AddTicks(4416), 895, null, 42L, 246 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 3, 27, 4, 4, 34, 703, DateTimeKind.Unspecified).AddTicks(5125), 1L, 874, false, 10L, 452 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 17L, new DateTime(2021, 11, 17, 5, 29, 29, 173, DateTimeKind.Unspecified).AddTicks(3676), 4L, 763, false, 14L, 128 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 5, 26, 8, 43, 31, 518, DateTimeKind.Unspecified).AddTicks(9952), 1L, 521, 42L, 120 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 3, 10, 3, 0, 23, 336, DateTimeKind.Unspecified).AddTicks(3098), 2L, 632, false, 17L, 235 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 9, 3, 22, 50, 33, 736, DateTimeKind.Unspecified).AddTicks(139), 1L, 988, 31L, null, 51 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 2, 4, 19, 25, 7, 955, DateTimeKind.Unspecified).AddTicks(8311), 4L, 525, false, null, 16L, 449 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 5, 27, 7, 54, 45, 854, DateTimeKind.Unspecified).AddTicks(340), 744, false, null, 12L, 54 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 7, 18, 15, 15, 34, 711, DateTimeKind.Unspecified).AddTicks(4312), 2L, 530, false, null, 19L, 100 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 5, 9, 19, 57, 58, 136, DateTimeKind.Unspecified).AddTicks(5357), 838, true, 68L, 179 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 3, 29, 4, 53, 20, 889, DateTimeKind.Unspecified).AddTicks(4525), 4L, 915, true, 40L, null, 317 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 9, 23, 21, 16, 2, 502, DateTimeKind.Unspecified).AddTicks(369), 1L, 634, false, 22L, 314 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 8, 3, 9, 6, 23, 884, DateTimeKind.Unspecified).AddTicks(5957), 715, 30L, null, 127 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 3, 2, 6, 53, 41, 178, DateTimeKind.Unspecified).AddTicks(9590), 4L, 810, true, null, 20L, 48 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 5, 25, 21, 36, 49, 747, DateTimeKind.Unspecified).AddTicks(8171), 4L, 510, true, 29L, null, 187 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 11, 11, 17, 48, 11, 960, DateTimeKind.Unspecified).AddTicks(8206), 682, true, 81L, null, 430 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2022, 1, 20, 18, 5, 27, 438, DateTimeKind.Unspecified).AddTicks(48), 901, 12L, 486 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 10, 27, 3, 28, 48, 271, DateTimeKind.Unspecified).AddTicks(4604), 3L, 860, false, 37L, 382 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2022, 1, 17, 23, 45, 41, 327, DateTimeKind.Unspecified).AddTicks(5297), 1L, 744, null, 30L, 277 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2022, 1, 21, 7, 38, 6, 107, DateTimeKind.Unspecified).AddTicks(1730), 701, 45L, 467 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 7, 4, 11, 19, 39, 965, DateTimeKind.Unspecified).AddTicks(9517), 3L, 672, false, 29L, 160 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 9, 8, 22, 31, 13, 287, DateTimeKind.Unspecified).AddTicks(4696), 4L, 521, false, 31L, 385 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 10, 26, 19, 51, 21, 844, DateTimeKind.Unspecified).AddTicks(7804), 789, true, null, 48L, 332 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 31L, new DateTime(2022, 1, 16, 8, 53, 22, 922, DateTimeKind.Unspecified).AddTicks(1445), 5L, 949, true, null, 38L, 1 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 5, 13, 0, 14, 47, 932, DateTimeKind.Unspecified).AddTicks(6214), 2L, 533, 79L, 25 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 3, 7, 10, 57, 8, 879, DateTimeKind.Unspecified).AddTicks(8575), 509, 28L, 50 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 8, 13, 7, 16, 15, 850, DateTimeKind.Unspecified).AddTicks(4289), 3L, 816, 5L, 280 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 4, 13, 21, 9, 32, 555, DateTimeKind.Unspecified).AddTicks(4895), 2L, 515, 38L, 264 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 5, 29, 21, 4, 14, 480, DateTimeKind.Unspecified).AddTicks(8920), 4L, 584, 76L, null, 64 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 44L, new DateTime(2021, 5, 31, 8, 41, 16, 75, DateTimeKind.Unspecified).AddTicks(3524), 1L, 756, true, 6L, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 10, 23, 22, 58, 31, 925, DateTimeKind.Unspecified).AddTicks(9370), 3L, 834, true, 48L, null, 45 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 5, 30, 5, 41, 30, 267, DateTimeKind.Unspecified).AddTicks(7065), 4L, 865, null, 16L, 33 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 50L, new DateTime(2021, 12, 19, 16, 1, 13, 782, DateTimeKind.Unspecified).AddTicks(1520), 770, 45L, 246 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 12, 7, 18, 57, 33, 791, DateTimeKind.Unspecified).AddTicks(9198), 2L, 804, 70L, null, 174 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 9, 27, 20, 15, 7, 890, DateTimeKind.Unspecified).AddTicks(6771), 942, true, 70L, 122 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2022, 1, 29, 3, 8, 7, 262, DateTimeKind.Unspecified).AddTicks(5806), 1L, 633, 54L, 494 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 4, 10, 12, 21, 16, 872, DateTimeKind.Unspecified).AddTicks(2741), 903, true, 79L, 461 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 12, 12, 2, 21, 48, 187, DateTimeKind.Unspecified).AddTicks(3695), 5L, 572, false, 74L, 379 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 3, 19, 7, 17, 58, 185, DateTimeKind.Unspecified).AddTicks(5810), 2L, 892, 9L, 343 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2022, 1, 25, 23, 38, 53, 453, DateTimeKind.Unspecified).AddTicks(169), 581, null, 18L, 160 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 7, 5, 12, 14, 28, 416, DateTimeKind.Unspecified).AddTicks(1511), 4L, 823, 36L, null, 211 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 10, 5, 6, 19, 15, 595, DateTimeKind.Unspecified).AddTicks(3519), 754, false, 44L, 429 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 10, 9, 2, 57, 59, 405, DateTimeKind.Unspecified).AddTicks(4469), 5L, 856, true, 5L, 33 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 11, 10, 23, 6, 39, 821, DateTimeKind.Unspecified).AddTicks(4602), 5L, 608, true, 60L, null, 147 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 6, 16, 19, 21, 39, 353, DateTimeKind.Unspecified).AddTicks(7035), 1L, 749, 10L, 156 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 3, 20, 1, 40, 51, 41, DateTimeKind.Unspecified).AddTicks(7341), 5L, 802, true, 51L, 298 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 41L, new DateTime(2021, 7, 7, 22, 49, 31, 144, DateTimeKind.Unspecified).AddTicks(9633), 5L, 571, 10L, null, 143 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 5, 26, 23, 20, 49, 402, DateTimeKind.Unspecified).AddTicks(6903), 3L, 535, true, 33L, 97 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 7, 16, 2, 45, 23, 658, DateTimeKind.Unspecified).AddTicks(9925), 5L, 610, null, 23L, 20 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 5, 1, 10, 15, 25, 273, DateTimeKind.Unspecified).AddTicks(378), 2L, 551, false, 35L, 299 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 5, 28, 21, 17, 30, 28, DateTimeKind.Unspecified).AddTicks(8605), 3L, 577, true, 38L, 295 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 7, 21, 19, 38, 49, 697, DateTimeKind.Unspecified).AddTicks(5420), 2L, 684, true, null, 47L, 71 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 6, 24, 6, 27, 43, 518, DateTimeKind.Unspecified).AddTicks(45), 3L, 692, false, 60L, 2 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 2, 9, 0, 27, 39, 872, DateTimeKind.Unspecified).AddTicks(5505), 5L, 650, null, 23L, 162 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 3, 4, 18, 9, 23, 997, DateTimeKind.Unspecified).AddTicks(7357), 3L, 929, 30L, 473 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 3, 23, 0, 27, 15, 211, DateTimeKind.Unspecified).AddTicks(4894), 795, false, 7L, 148 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 48L, new DateTime(2021, 8, 29, 17, 1, 28, 388, DateTimeKind.Unspecified).AddTicks(9409), 1L, 881, null, 50L, 216 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 11, 15, 2, 48, 21, 251, DateTimeKind.Unspecified).AddTicks(5115), 741, null, 10L, 10 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 9, 11, 21, 48, 1, 933, DateTimeKind.Unspecified).AddTicks(3487), 3L, 849, 8L, null, 286 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 49L, new DateTime(2021, 6, 10, 6, 46, 9, 977, DateTimeKind.Unspecified).AddTicks(8253), 4L, 650, 38L, null, 125 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 9L, new DateTime(2021, 3, 18, 19, 28, 56, 54, DateTimeKind.Unspecified).AddTicks(6141), 4L, 562, 43L, null, 110 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 2, 22, 22, 29, 42, 174, DateTimeKind.Unspecified).AddTicks(3448), 3L, 506, 5L, 493 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 37L, new DateTime(2021, 7, 3, 10, 47, 27, 977, DateTimeKind.Unspecified).AddTicks(9186), 5L, 858, false, 3L, 379 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 3, 5, 0, 18, 6, 79, DateTimeKind.Unspecified).AddTicks(1226), 1L, 642, false, 31L, null, 164 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 5, 26, 18, 43, 53, 482, DateTimeKind.Unspecified).AddTicks(7499), 5L, 952, null, 36L, 83 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 8, 23, 9, 52, 34, 406, DateTimeKind.Unspecified).AddTicks(4836), 747, 17L, 182 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 6, 28, 18, 28, 4, 741, DateTimeKind.Unspecified).AddTicks(1242), 663, null, 33L, 219 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 7, 22, 18, 12, 34, 496, DateTimeKind.Unspecified).AddTicks(4008), 2L, 620, false, 7L, 304 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 8, 5, 15, 40, 56, 731, DateTimeKind.Unspecified).AddTicks(2995), 5L, 946, 7L, null, 385 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 2, 6, 12, 41, 43, 312, DateTimeKind.Unspecified).AddTicks(4540), 1L, 612, true, 46L, 82 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 11, 11, 22, 33, 53, 900, DateTimeKind.Unspecified).AddTicks(8412), 4L, 684, null, 30L, 377 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 11, 10, 7, 53, 26, 136, DateTimeKind.Unspecified).AddTicks(5424), 5L, 669, 68L, null, 151 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 3, 17, 20, 40, 20, 560, DateTimeKind.Unspecified).AddTicks(7269), 4L, 720, false, 77L, null, 1 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 11, 6, 15, 46, 19, 227, DateTimeKind.Unspecified).AddTicks(3980), 2L, 566, null, 32L, 93 });

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
                    { 4L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 59L, false },
                    { 5L, 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L, false },
                    { 5L, 19L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 7L, false },
                    { 6L, 6L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 19L, false },
                    { 6L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 79L, false },
                    { 6L, 37L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 50L, false },
                    { 7L, 5L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 24L, false },
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
                    { 11L, 26L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 55L, false },
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
                    { 14L, 34L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 68L, false },
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppTags");

            migrationBuilder.DropTable(
                name: "Apps");

            migrationBuilder.DropTable(
                name: "Tags");

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
                keyValues: new object[] { 7L, 19L });

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
                keyValues: new object[] { 8L, 19L });

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
                keyValues: new object[] { 10L, 12L });

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
                keyValues: new object[] { 12L, 20L });

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
                keyValues: new object[] { 14L, 41L });

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
                keyValues: new object[] { 15L, 28L });

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
                keyValues: new object[] { 26L, 4L });

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
                keyValues: new object[] { 40L, 25L });

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
                keyValues: new object[] { 44L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 7L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 45L, 40L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 45L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 47L, 47L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 48L, 16L });

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
                keyValues: new object[] { 50L, 7L });

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
                name: "ProjectDocumentId",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2L, 27L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 12, 25, 7, 11, 56, 794, DateTimeKind.Unspecified).AddTicks(9842), 32L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 6L, 16L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 5, 3, 9, 52, 26, 332, DateTimeKind.Unspecified).AddTicks(6590), 1L, 58L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 44L, 26L },
                columns: new[] { "CreatedAt", "Id" },
                values: new object[] { new DateTime(2021, 10, 27, 3, 21, 7, 394, DateTimeKind.Unspecified).AddTicks(4589), 29L });

            migrationBuilder.UpdateData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 46L, 37L },
                columns: new[] { "CreatedAt", "CreatedBy", "Id" },
                values: new object[] { new DateTime(2021, 11, 13, 8, 17, 42, 111, DateTimeKind.Unspecified).AddTicks(9087), 5L, 8L });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 19L, new DateTime(2022, 1, 14, 1, 18, 38, 482, DateTimeKind.Unspecified).AddTicks(734), 4L, 98L, false },
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
                    { 11L, 6L, new DateTime(2021, 3, 5, 4, 9, 21, 569, DateTimeKind.Unspecified).AddTicks(5487), 4L, 18L, false },
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
                    { 20L, 17L, new DateTime(2021, 7, 24, 14, 3, 2, 4, DateTimeKind.Unspecified).AddTicks(7227), 1L, 73L, false },
                    { 20L, 29L, new DateTime(2021, 4, 8, 19, 22, 52, 999, DateTimeKind.Unspecified).AddTicks(9748), 1L, 99L, false },
                    { 21L, 21L, new DateTime(2021, 3, 20, 12, 53, 34, 227, DateTimeKind.Unspecified).AddTicks(7695), 2L, 57L, false },
                    { 21L, 28L, new DateTime(2021, 11, 22, 19, 7, 1, 835, DateTimeKind.Unspecified).AddTicks(1074), 5L, 64L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
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
                    { 30L, 42L, new DateTime(2021, 11, 19, 15, 0, 24, 613, DateTimeKind.Unspecified).AddTicks(480), 3L, 77L, false },
                    { 31L, 5L, new DateTime(2021, 8, 8, 2, 19, 59, 370, DateTimeKind.Unspecified).AddTicks(4984), 2L, 13L, false },
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
                    { 44L, 38L, new DateTime(2021, 12, 7, 1, 10, 52, 552, DateTimeKind.Unspecified).AddTicks(8361), 3L, 36L, false },
                    { 44L, 44L, new DateTime(2022, 1, 7, 8, 40, 38, 688, DateTimeKind.Unspecified).AddTicks(8322), 1L, 92L, false },
                    { 44L, 51L, new DateTime(2022, 1, 6, 8, 33, 45, 580, DateTimeKind.Unspecified).AddTicks(1091), 1L, 45L, false },
                    { 45L, 13L, new DateTime(2021, 4, 9, 6, 42, 42, 53, DateTimeKind.Unspecified).AddTicks(7468), 2L, 75L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 45L, 16L, new DateTime(2021, 11, 24, 18, 42, 58, 427, DateTimeKind.Unspecified).AddTicks(1643), 1L, 34L, false },
                    { 45L, 23L, new DateTime(2021, 10, 17, 17, 52, 49, 347, DateTimeKind.Unspecified).AddTicks(9704), 5L, 93L, false },
                    { 46L, 7L, new DateTime(2021, 5, 24, 0, 31, 51, 112, DateTimeKind.Unspecified).AddTicks(8697), 2L, 97L, false },
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
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId" },
                values: new object[] { new DateTime(2021, 10, 24, 18, 52, 9, 721, DateTimeKind.Unspecified).AddTicks(3781), "Omnis voluptatem vel quas non libero.\nNobis amet nostrum qui inventore perferendis reiciendis cumque beatae.", true, 40L });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 14, 2, 57, 22, 932, DateTimeKind.Unspecified).AddTicks(6614), 2L, "Ea culpa dicta cum quo.", 30L, "Harum voluptatem quam reprehenderit velit et ut dolor." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 13, 4, 32, 10, 317, DateTimeKind.Unspecified).AddTicks(236), 1L, "A enim odit omnis consequuntur fugiat qui fugit.\nId animi quas voluptatem perferendis quod deleniti molestiae ullam.\nCumque eligendi qui voluptates ut vitae eum omnis sit.\nHarum deserunt velit praesentium.", true, 18L, "Animi aut iste labore voluptatem omnis rem vero." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 7, 23, 28, 49, 544, DateTimeKind.Unspecified).AddTicks(1619), 2L, "Explicabo repellendus perspiciatis et.\nPariatur ipsum asperiores voluptatem accusantium error commodi similique eligendi.", 5L, "Unde alias maiores qui similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 13, 12, 0, 24, 212, DateTimeKind.Unspecified).AddTicks(4416), 5L, "Consequatur et facere vero quo et dolorem.\nEa maiores quae numquam soluta ut dolor.\nEsse odio quam possimus assumenda et.\nDolore non est totam in aliquid hic.", 12L, "Aut amet quae in." });

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
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 6, 5, 9, 25, 836, DateTimeKind.Unspecified).AddTicks(3816), "Dolores quidem voluptatem tenetur quod.", false, 51L, "Itaque quo ea temporibus similique unde." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 3, 15, 44, 47, 482, DateTimeKind.Unspecified).AddTicks(6129), 3L, "Quia tenetur non veniam sed dolor dolore.", 31L, "Inventore consequatur sit provident quos quam cumque saepe." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 8, 22, 14, 373, DateTimeKind.Unspecified).AddTicks(7594), 5L, "Qui id eos hic sint quos in rerum est.\nEnim facilis consequatur fuga alias.\nRem quasi blanditiis saepe.", 49L, "Error error neque est porro aut." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 28, 21, 43, 18, 248, DateTimeKind.Unspecified).AddTicks(9890), 5L, "Corporis iusto eius minima aut corrupti nemo placeat.\nDoloremque eum sint quas dolor.\nEt illo qui.", 4L, "A enim necessitatibus." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 7, 13, 46, 50, 192, DateTimeKind.Unspecified).AddTicks(5321), 2L, "Corporis eius et laborum minus odio nihil maiores.\nIncidunt aliquid dolores aut quibusdam eveniet quasi consequatur est consectetur.\nNumquam id similique veniam numquam quo quia tenetur voluptas.\nAut et rem sed vel quo beatae.", 2L, "Ab omnis magni aliquid blanditiis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 13, 6, 55, 38, 674, DateTimeKind.Unspecified).AddTicks(1978), "Reiciendis quos cumque et ut.\nVoluptatem fugit rem distinctio corporis sed.\nAccusantium voluptatibus quam sit asperiores praesentium.", false, 50L, "Et ut placeat repellat similique molestias sequi nihil quia." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 1, 5, 802, DateTimeKind.Unspecified).AddTicks(9842), 1L, "Quod quia voluptatem molestias facere.\nUllam eius corporis eius incidunt et omnis est eum.\nNihil quo ut fugiat occaecati dolor quod sint assumenda sed.", 19L, "Voluptatem vel sit debitis ullam tempore aperiam sit qui consequatur." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 17, 11, 9, 18, 472, DateTimeKind.Unspecified).AddTicks(3600), 3L, "Ut qui commodi.", 27L, "Fugiat vel magni sunt sunt quia sit exercitationem." });

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
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 10, 1, 0, 59, 15, 148, DateTimeKind.Unspecified).AddTicks(2098), "Voluptatem earum error adipisci odio molestias porro repudiandae.\nQuia nisi omnis doloremque qui.\nMollitia nihil similique eaque repellat optio.\nIure modi aut omnis quis quidem beatae voluptatem.", true, 45L, "Quis qui deleniti provident in ut consectetur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedAt", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 4, 9, 17, 20, 29, 794, DateTimeKind.Unspecified).AddTicks(2974), "Laboriosam dignissimos eaque.\nEligendi suscipit voluptatem porro hic cum iste laboriosam sunt cum.\nBeatae quo aut quibusdam.\nVoluptates est nisi ab vitae dignissimos.", false, 13L, "Reprehenderit excepturi voluptatem mollitia consequatur ad aut quod et." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "Title" },
                values: new object[] { new DateTime(2021, 11, 12, 2, 15, 53, 75, DateTimeKind.Unspecified).AddTicks(8374), 2L, "Sed quo ipsum ipsum et officia.\nIpsa voluptas alias dolor.\nEst aspernatur maiores at.\nCommodi molestiae doloribus dolores.\nUt omnis ipsa aliquam vel deleniti eligendi ut aut.", false, "Qui culpa ab quam voluptas animi qui et doloribus qui." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 3, 19, 15, 6, 14, 985, DateTimeKind.Unspecified).AddTicks(7202), 2L, "Eos culpa ea et assumenda quod laborum nostrum vel.\nEt itaque aliquam ut accusamus velit magni nam.\nQuo aliquid quam adipisci.", true, 10L, "Voluptates enim quae rerum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 9, 28, 21, 11, 0, 808, DateTimeKind.Unspecified).AddTicks(4408), 5L, "Quidem accusamus ea delectus dolor recusandae.", true, 4L, "Earum reiciendis voluptatem quis praesentium ea quidem iure ex." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 12, 12, 45, 20, 284, DateTimeKind.Unspecified).AddTicks(393), 5L, "Assumenda doloremque illo.\nOfficiis quam error ratione ipsum et odio.", 11L, "Molestiae dignissimos quo itaque vero facilis itaque sint consequatur reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 14, 18, 29, 32, 451, DateTimeKind.Unspecified).AddTicks(8937), 4L, "Similique quis distinctio fugiat sapiente temporibus voluptatum nam id sed.\nIllum saepe rerum qui dicta iste nesciunt dolorem natus.\nEst id repellat.", 24L, "Ut consequatur praesentium dolorum fugit officiis." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 11, 8, 4, 40, 46, 524, DateTimeKind.Unspecified).AddTicks(8857), 1L, "Et velit maxime rerum.\nVoluptas eum aut dignissimos dolorem tempora ratione expedita.\nSint debitis ut velit natus impedit doloribus pariatur assumenda et.\nEt explicabo error.\nEt iste quae impedit voluptates ratione tenetur voluptas.", 31L, "Et eos quo qui." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 6, 8, 11, 52, 38, 75, DateTimeKind.Unspecified).AddTicks(6014), 3L, "Error aperiam assumenda eum sint rem consequatur magnam dicta.\nReprehenderit necessitatibus autem sint veritatis quis magni.\nOfficia minus sunt cupiditate laboriosam id aut vel aut optio.\nEt et exercitationem ut sint vitae.", false, 7L, "Quis sed laborum dolor iusto." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 34, 20, 696, DateTimeKind.Unspecified).AddTicks(4680), 3L, "Sint a et rem similique.\nVelit ducimus modi non quae saepe quasi.\nHic voluptatem eos a quia accusamus ad.", true, 21L, "Itaque natus veniam sit." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 2, 1, 48, 37, 773, DateTimeKind.Unspecified).AddTicks(5419), 1L, "Cum necessitatibus consequatur.\nEt voluptatem quisquam dolor commodi asperiores et.", true, 39L, "Assumenda dolor consectetur animi voluptate totam sed." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "IsPublic", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 2, 15, 12, 47, 25, 481, DateTimeKind.Unspecified).AddTicks(4693), 2L, "Et beatae qui aperiam tempora aut sed repellendus.\nCulpa fuga dolorem esse impedit.\nDolor voluptate magni a ducimus inventore voluptatibus est.", true, 46L, "Nobis quia velit sunt." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 5, 18, 1, 53, 31, 265, DateTimeKind.Unspecified).AddTicks(2110), 5L, "Et qui molestias tempora.\nVoluptatem dolor sint nulla.", 26L, "Quisquam minima laboriosam architecto eos deserunt temporibus itaque." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "OwnerId", "Title" },
                values: new object[] { new DateTime(2021, 12, 21, 15, 46, 47, 190, DateTimeKind.Unspecified).AddTicks(304), 5L, "Magni minima consectetur.\nEt necessitatibus sit voluptatem vitae et eius nemo est.", 50L, "Quae possimus sed." });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Quia debitis distinctio.\nQui at et dolorem nisi aut.\nOfficia vero aut.\nQuos eos vero at veritatis rerum possimus eum ex aut.\nCum aut ut est pariatur quia non ad velit repellat.", new DateTime(2021, 9, 22, 22, 19, 30, 418, DateTimeKind.Unspecified).AddTicks(973), 1L, 6L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 43L, "Dolores unde dolores.\nIure sit asperiores et sit maxime unde ex.", new DateTime(2021, 2, 12, 9, 57, 38, 101, DateTimeKind.Unspecified).AddTicks(4368), 4L, 24L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 30L, "Sequi minima non debitis et.\nCommodi ipsam porro et reprehenderit ut nostrum dicta.\nEt sed quia aut necessitatibus eum provident et.\nEius error ut et alias dignissimos.\nQuo nam aut cum consequatur quia.\nPorro atque est.", new DateTime(2021, 5, 2, 19, 58, 43, 511, DateTimeKind.Unspecified).AddTicks(8277), 67L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 37L, "Suscipit molestiae quos at impedit et asperiores officiis fuga.\nConsequuntur distinctio itaque quisquam ullam enim enim et iste.\nConsectetur voluptate soluta voluptas aut quos fuga labore.\nImpedit recusandae est est porro quidem rerum molestias deserunt.", new DateTime(2021, 11, 11, 11, 16, 51, 772, DateTimeKind.Unspecified).AddTicks(5368), 4L });

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
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Expedita non placeat dolorem maxime eius quia facere inventore repudiandae.\nVoluptatum perferendis modi dicta distinctio aut soluta hic cupiditate.", new DateTime(2021, 8, 20, 4, 35, 10, 372, DateTimeKind.Unspecified).AddTicks(6151), 2L, 79L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 11L, "Corrupti possimus eum accusantium aliquam dolorem vel assumenda laudantium.\nPraesentium nam sunt quibusdam quia architecto impedit aliquam sequi.", new DateTime(2021, 10, 21, 2, 56, 8, 619, DateTimeKind.Unspecified).AddTicks(7270), 17L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 41L, "Exercitationem molestiae voluptatibus ipsa quas aut.", new DateTime(2021, 11, 14, 3, 55, 49, 415, DateTimeKind.Unspecified).AddTicks(7157), 2L, 73L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 3L, "Aliquid quia tempore consequatur rem omnis magnam eum quibusdam.\nIpsum perferendis illo atque sed.", new DateTime(2021, 7, 26, 3, 2, 24, 986, DateTimeKind.Unspecified).AddTicks(5854), 11L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 29L, "Quis eveniet ab aut cumque est.\nQuidem veniam odit corrupti pariatur consequatur quos est quisquam numquam.\nVeritatis voluptas voluptates corporis.", new DateTime(2021, 9, 24, 8, 6, 8, 95, DateTimeKind.Unspecified).AddTicks(1537), 2L, 78L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 11L, "Non quisquam consequuntur dolorem voluptas est dolorum soluta veniam.\nSuscipit excepturi aspernatur pariatur consequatur cum temporibus sunt sunt libero.\nDolor et ad.", new DateTime(2021, 5, 11, 22, 5, 44, 98, DateTimeKind.Unspecified).AddTicks(2176), 48L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 4L, 18L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 62L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 36L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 1L, 50L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 4L, 75L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 61L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 3L, 55L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 2L, 64L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 1L, 51L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy" },
                values: new object[] { 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 3L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 68L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 72L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 58L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 5L, 78L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 77L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 10L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 39L, "Similique ut ea quaerat quae tempore consectetur dolores.\nNihil exercitationem voluptates illo.", new DateTime(2021, 8, 11, 2, 59, 32, 664, DateTimeKind.Unspecified).AddTicks(9692), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 28L, "Facere consectetur sunt fugiat excepturi sit.", new DateTime(2021, 7, 9, 22, 20, 8, 306, DateTimeKind.Unspecified).AddTicks(8477), 13L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 35L, "Omnis expedita corrupti a fuga.", new DateTime(2021, 4, 7, 15, 1, 58, 657, DateTimeKind.Unspecified).AddTicks(6797), 3L, 20L });

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
                columns: new[] { "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { "Exercitationem accusamus perferendis vel quo dolore dolorum autem sit.\nAccusantium dolor est voluptas sed porro ad ipsam tempora.\nDolorem eum id voluptate quod id.\nAdipisci qui aliquid hic enim veritatis sunt.\nMagni ipsam excepturi consequatur id sunt consectetur numquam ut.", new DateTime(2021, 6, 6, 23, 49, 29, 96, DateTimeKind.Unspecified).AddTicks(9643), 4L, 41L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "CreatedBy", "ThreadId" },
                values: new object[] { 48L, "Sint aliquid pariatur harum enim dolorem repellat.\nMolestiae aut nemo nihil qui sapiente non harum.\nEligendi voluptas nobis tempore.\nMolestias vel dolores aut deleniti aut minima accusamus.\nOmnis voluptatem similique.\nFacere occaecati incidunt iusto laborum ut eius id dolore.", new DateTime(2021, 4, 12, 22, 5, 28, 434, DateTimeKind.Unspecified).AddTicks(9752), 4L, 36L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 14L, "Omnis fugit aut.", new DateTime(2021, 8, 20, 8, 30, 53, 58, DateTimeKind.Unspecified).AddTicks(3331), 59L });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 48L, "Suscipit deleniti accusamus et debitis.\nDucimus ab cum.\nPariatur architecto architecto odio maiores.", new DateTime(2021, 9, 4, 18, 46, 20, 745, DateTimeKind.Unspecified).AddTicks(6003), 30L });

            migrationBuilder.UpdateData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "ThreadId" },
                values: new object[] { 5L, "Dolore nihil voluptas doloremque accusantium.\nAnimi aspernatur mollitia.", new DateTime(2021, 6, 17, 15, 1, 38, 939, DateTimeKind.Unspecified).AddTicks(7420), 16L });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 11, 16, 13, 6, 3, 818, DateTimeKind.Unspecified).AddTicks(714), 2L, 660, 79L, null, 260 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 4, 24, 14, 36, 52, 329, DateTimeKind.Unspecified).AddTicks(7400), 1L, 688, 36L, 227 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 6, 19, 22, 23, 50, 401, DateTimeKind.Unspecified).AddTicks(5997), 1L, 797, 19L, null, 81 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 6L, new DateTime(2021, 3, 31, 17, 57, 53, 215, DateTimeKind.Unspecified).AddTicks(1616), 3L, 617, 13L, 31 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { new DateTime(2021, 4, 13, 13, 23, 8, 37, DateTimeKind.Unspecified).AddTicks(5818), 5L, 955, false, null, 29L, 83 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 36L, new DateTime(2021, 4, 15, 3, 12, 39, 921, DateTimeKind.Unspecified).AddTicks(8542), 635, 26L, null, 169 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 10, 10, 9, 46, 50, 270, DateTimeKind.Unspecified).AddTicks(5106), 3L, 859, true, 46L, 136 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 2L, new DateTime(2021, 9, 7, 14, 42, 1, 841, DateTimeKind.Unspecified).AddTicks(7608), 2L, 655, true, 32L, 465 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 11L, new DateTime(2021, 7, 25, 5, 49, 34, 668, DateTimeKind.Unspecified).AddTicks(7406), 2L, 752, 19L, 253 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 5, 23, 21, 13, 50, 269, DateTimeKind.Unspecified).AddTicks(4408), 4L, 506, true, 22L, 15 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 6, 12, 17, 5, 5, 986, DateTimeKind.Unspecified).AddTicks(8756), 3L, 825, null, 44L, 27 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 7, 17, 17, 52, 20, 277, DateTimeKind.Unspecified).AddTicks(759), 3L, 819, true, 76L, null, 103 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 2, 2, 19, 7, 5, 924, DateTimeKind.Unspecified).AddTicks(411), 687, true, 61L, null, 383 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 28L, new DateTime(2021, 4, 10, 21, 21, 39, 563, DateTimeKind.Unspecified).AddTicks(4556), 1L, 518, true, 20L, null, 429 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2021, 5, 1, 23, 24, 12, 630, DateTimeKind.Unspecified).AddTicks(1136), 501, false, 71L, 476 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2021, 10, 3, 10, 42, 27, 603, DateTimeKind.Unspecified).AddTicks(4061), 2L, 706, false, null, 26L, 414 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2022, 1, 31, 9, 23, 34, 334, DateTimeKind.Unspecified).AddTicks(1669), 3L, 628, true, 4L, 356 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 22L, new DateTime(2021, 12, 11, 14, 48, 0, 923, DateTimeKind.Unspecified).AddTicks(963), 535, null, 21L, 293 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 5, 24, 6, 4, 24, 455, DateTimeKind.Unspecified).AddTicks(4657), 3L, 531, false, 2L, null, 189 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 8L, new DateTime(2021, 8, 18, 14, 19, 31, 530, DateTimeKind.Unspecified).AddTicks(338), 1L, 663, false, null, 28L, 108 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 2, 2, 4, 31, 12, 244, DateTimeKind.Unspecified).AddTicks(6771), 860, false, null, 49L, 114 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 5, 5, 16, 5, 7, 462, DateTimeKind.Unspecified).AddTicks(6790), 955, 56L, 142 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 10, 28, 7, 28, 4, 994, DateTimeKind.Unspecified).AddTicks(7622), 4L, 794, true, 2L, 344 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 10L, new DateTime(2021, 6, 30, 22, 48, 14, 413, DateTimeKind.Unspecified).AddTicks(6957), 3L, 557, 12L, null, 456 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 3, 26, 5, 4, 34, 91, DateTimeKind.Unspecified).AddTicks(2329), 683, 20L, 278 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 35L, new DateTime(2021, 4, 5, 14, 16, 39, 766, DateTimeKind.Unspecified).AddTicks(5317), 4L, 816, true, 39L, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 9, 27, 23, 59, 31, 596, DateTimeKind.Unspecified).AddTicks(3721), 2L, 923, true, 50L, 453 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 30L, new DateTime(2021, 7, 16, 23, 13, 14, 386, DateTimeKind.Unspecified).AddTicks(5703), 903, false, 57L, null, 409 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 26L, new DateTime(2021, 5, 21, 19, 57, 29, 205, DateTimeKind.Unspecified).AddTicks(5319), 3L, 948, false, 68L, null, 437 });

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
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 33L, new DateTime(2021, 6, 26, 9, 13, 17, 475, DateTimeKind.Unspecified).AddTicks(301), 789, 12L, 486 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 27L, new DateTime(2021, 12, 17, 18, 43, 15, 647, DateTimeKind.Unspecified).AddTicks(7107), 5L, 612, 65L, 300 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 40L, new DateTime(2021, 6, 10, 15, 52, 58, 652, DateTimeKind.Unspecified).AddTicks(271), 5L, 785, 12L, 81 });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 20L, new DateTime(2021, 4, 1, 3, 20, 37, 712, DateTimeKind.Unspecified).AddTicks(7852), 2L, 938, false, 15L, 233 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 18L, new DateTime(2021, 3, 29, 17, 49, 35, 77, DateTimeKind.Unspecified).AddTicks(4086), 4L, 878, false, null, 40L, 499 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 23L, new DateTime(2021, 7, 11, 15, 47, 15, 636, DateTimeKind.Unspecified).AddTicks(5066), 3L, 522, 27L, null, 214 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 7, 28, 2, 56, 26, 586, DateTimeKind.Unspecified).AddTicks(8394), 536, 49L, 335 });

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
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 7L, new DateTime(2021, 7, 6, 19, 4, 5, 436, DateTimeKind.Unspecified).AddTicks(4664), 764, false, 52L, 16 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 7, 26, 0, 17, 41, 66, DateTimeKind.Unspecified).AddTicks(3434), 4L, 893, 74L, 340 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 12L, new DateTime(2021, 2, 3, 14, 27, 13, 241, DateTimeKind.Unspecified).AddTicks(9533), 640, false, 40L, 330 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 3, 8, 3, 31, 50, 307, DateTimeKind.Unspecified).AddTicks(5280), 4L, 971, true, 32L, 33 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 12, 25, 17, 33, 21, 236, DateTimeKind.Unspecified).AddTicks(3013), 4L, 823, 6L, 266 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 15L, new DateTime(2021, 11, 13, 22, 4, 59, 537, DateTimeKind.Unspecified).AddTicks(1235), 754, 61L, null, 334 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 10, 10, 23, 58, 24, 559, DateTimeKind.Unspecified).AddTicks(8819), 2L, 574, null, 3L, 85 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 2, 28, 19, 16, 3, 327, DateTimeKind.Unspecified).AddTicks(6), 650, true, 40L, 160 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 11, 5, 9, 56, 1, 844, DateTimeKind.Unspecified).AddTicks(5861), 1L, 787, false, 46L, 274 });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "StartPosition" },
                values: new object[] { 34L, new DateTime(2021, 2, 3, 14, 26, 28, 834, DateTimeKind.Unspecified).AddTicks(2280), 3L, 661, 19L, 331 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 25L, new DateTime(2021, 4, 28, 14, 6, 42, 548, DateTimeKind.Unspecified).AddTicks(447), 1L, 685, false, 39L, 11 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 51L, new DateTime(2021, 11, 3, 12, 24, 22, 49, DateTimeKind.Unspecified).AddTicks(7450), 2L, 546, null, 48L, 335 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 8, 25, 23, 37, 21, 622, DateTimeKind.Unspecified).AddTicks(5353), 4L, 906, false, 21L, 15 });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 39L, new DateTime(2021, 6, 13, 4, 18, 50, 409, DateTimeKind.Unspecified).AddTicks(7546), 4L, 862, true, 77L, 270 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2021, 3, 1, 9, 32, 15, 531, DateTimeKind.Unspecified).AddTicks(7827), 2L, 897, false, 22L, 16 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 38L, new DateTime(2021, 10, 12, 13, 54, 18, 814, DateTimeKind.Unspecified).AddTicks(6413), 3L, 691, false, 48L, null, 349 });

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
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 13L, new DateTime(2021, 8, 3, 2, 57, 1, 110, DateTimeKind.Unspecified).AddTicks(8123), 867, true, 20L, 318 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 24L, new DateTime(2021, 6, 13, 7, 0, 35, 98, DateTimeKind.Unspecified).AddTicks(4199), 3L, 714, 52L, null, 142 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 3L, new DateTime(2022, 1, 28, 16, 21, 11, 209, DateTimeKind.Unspecified).AddTicks(9767), 520, 67L, null, 336 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 45L, new DateTime(2021, 8, 19, 7, 4, 5, 883, DateTimeKind.Unspecified).AddTicks(743), 4L, 615, null, 31L, 55 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 3, 15, 12, 41, 57, 981, DateTimeKind.Unspecified).AddTicks(931), 5L, 817, null, 20L, 16 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 42L, new DateTime(2021, 4, 7, 4, 6, 1, 297, DateTimeKind.Unspecified).AddTicks(8125), 3L, 610, null, 35L, 43 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 12, 12, 13, 17, 33, 828, DateTimeKind.Unspecified).AddTicks(5314), 4L, 530, 33L, 135 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2021, 11, 12, 22, 49, 17, 830, DateTimeKind.Unspecified).AddTicks(5716), 1L, 833, true, 43L, 278 });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 9, 20, 7, 32, 16, 373, DateTimeKind.Unspecified).AddTicks(6443), 4L, 906, 24L, null, 69 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "ProjectId", "StartPosition" },
                values: new object[] { 29L, new DateTime(2021, 4, 22, 20, 30, 20, 846, DateTimeKind.Unspecified).AddTicks(7395), 870, 46L, 195 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AuthorId", "CreatedAt", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 14L, new DateTime(2021, 7, 12, 5, 38, 42, 414, DateTimeKind.Unspecified).AddTicks(6237), 799, 70L, null, 324 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 2, 28, 0, 19, 44, 281, DateTimeKind.Unspecified).AddTicks(3661), 3L, 723, true, 68L, 301 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 46L, new DateTime(2021, 5, 10, 6, 46, 20, 596, DateTimeKind.Unspecified).AddTicks(2348), 1L, 763, null, 11L, 168 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "ProjectId", "StartPosition" },
                values: new object[] { 19L, new DateTime(2022, 1, 7, 19, 17, 57, 558, DateTimeKind.Unspecified).AddTicks(4872), 4L, 922, false, 51L, 219 });

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
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 32L, new DateTime(2022, 1, 24, 15, 51, 46, 566, DateTimeKind.Unspecified).AddTicks(2784), 1L, 883, true, null, 47L, 243 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "LessonId", "ProjectId", "StartPosition" },
                values: new object[] { 47L, new DateTime(2021, 2, 28, 0, 19, 22, 606, DateTimeKind.Unspecified).AddTicks(1668), 4L, 572, 44L, null, 357 });
        }
    }
}
