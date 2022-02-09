using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    public partial class AddTestDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseRoles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, false, "admin" },
                    { 2L, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, false, "member" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "URL" },
                values: new object[,]
                {
                    { 2L, new DateTime(2021, 12, 18, 4, 27, 35, 223, DateTimeKind.Unspecified).AddTicks(8062), 1L, false, "https://picsum.photos/640/480/?image=724" },
                    { 3L, new DateTime(2021, 10, 29, 3, 41, 17, 392, DateTimeKind.Unspecified).AddTicks(1611), 1L, false, "https://picsum.photos/640/480/?image=567" },
                    { 4L, new DateTime(2021, 11, 30, 14, 48, 56, 686, DateTimeKind.Unspecified).AddTicks(1011), 3L, false, "https://picsum.photos/640/480/?image=785" },
                    { 5L, new DateTime(2021, 10, 31, 1, 51, 52, 396, DateTimeKind.Unspecified).AddTicks(228), 2L, false, "https://picsum.photos/640/480/?image=825" },
                    { 6L, new DateTime(2021, 9, 15, 22, 42, 22, 268, DateTimeKind.Unspecified).AddTicks(5929), 2L, false, "https://picsum.photos/640/480/?image=548" },
                    { 7L, new DateTime(2022, 1, 20, 2, 36, 25, 771, DateTimeKind.Unspecified).AddTicks(5054), 3L, false, "https://picsum.photos/640/480/?image=282" },
                    { 8L, new DateTime(2021, 9, 9, 22, 9, 29, 870, DateTimeKind.Unspecified).AddTicks(1977), 3L, false, "https://picsum.photos/640/480/?image=883" },
                    { 9L, new DateTime(2021, 5, 20, 14, 52, 2, 425, DateTimeKind.Unspecified).AddTicks(7093), 1L, false, "https://picsum.photos/640/480/?image=165" },
                    { 10L, new DateTime(2022, 1, 16, 21, 16, 15, 854, DateTimeKind.Unspecified).AddTicks(8110), 3L, false, "https://picsum.photos/640/480/?image=885" },
                    { 11L, new DateTime(2021, 3, 8, 5, 34, 34, 412, DateTimeKind.Unspecified).AddTicks(4282), 1L, false, "https://picsum.photos/640/480/?image=771" },
                    { 12L, new DateTime(2021, 11, 25, 23, 19, 29, 2, DateTimeKind.Unspecified).AddTicks(9655), 3L, false, "https://picsum.photos/640/480/?image=751" },
                    { 13L, new DateTime(2021, 7, 4, 3, 30, 57, 202, DateTimeKind.Unspecified).AddTicks(5656), 2L, false, "https://picsum.photos/640/480/?image=45" },
                    { 14L, new DateTime(2021, 7, 21, 11, 4, 30, 352, DateTimeKind.Unspecified).AddTicks(1363), 1L, false, "https://picsum.photos/640/480/?image=890" },
                    { 15L, new DateTime(2021, 9, 14, 15, 8, 4, 58, DateTimeKind.Unspecified).AddTicks(4338), 4L, false, "https://picsum.photos/640/480/?image=873" },
                    { 16L, new DateTime(2022, 1, 14, 9, 9, 39, 887, DateTimeKind.Unspecified).AddTicks(4353), 1L, false, "https://picsum.photos/640/480/?image=161" },
                    { 17L, new DateTime(2021, 12, 21, 23, 3, 17, 953, DateTimeKind.Unspecified).AddTicks(319), 4L, false, "https://picsum.photos/640/480/?image=848" },
                    { 18L, new DateTime(2021, 10, 19, 7, 2, 43, 774, DateTimeKind.Unspecified).AddTicks(2056), 4L, false, "https://picsum.photos/640/480/?image=271" },
                    { 19L, new DateTime(2022, 1, 16, 18, 11, 39, 813, DateTimeKind.Unspecified).AddTicks(2936), 1L, false, "https://picsum.photos/640/480/?image=703" },
                    { 20L, new DateTime(2022, 1, 14, 11, 2, 18, 716, DateTimeKind.Unspecified).AddTicks(8011), 3L, false, "https://picsum.photos/640/480/?image=655" },
                    { 21L, new DateTime(2021, 6, 17, 14, 39, 30, 584, DateTimeKind.Unspecified).AddTicks(8463), 4L, false, "https://picsum.photos/640/480/?image=456" },
                    { 22L, new DateTime(2021, 9, 21, 17, 11, 6, 139, DateTimeKind.Unspecified).AddTicks(5391), 1L, false, "https://picsum.photos/640/480/?image=237" },
                    { 23L, new DateTime(2021, 5, 15, 20, 47, 21, 264, DateTimeKind.Unspecified).AddTicks(8222), 1L, false, "https://picsum.photos/640/480/?image=290" },
                    { 24L, new DateTime(2022, 1, 28, 14, 35, 10, 772, DateTimeKind.Unspecified).AddTicks(5358), 3L, false, "https://picsum.photos/640/480/?image=76" },
                    { 25L, new DateTime(2021, 7, 29, 13, 46, 22, 607, DateTimeKind.Unspecified).AddTicks(6083), 3L, false, "https://picsum.photos/640/480/?image=865" },
                    { 26L, new DateTime(2021, 4, 5, 11, 22, 47, 137, DateTimeKind.Unspecified).AddTicks(7388), 1L, false, "https://picsum.photos/640/480/?image=542" },
                    { 27L, new DateTime(2022, 1, 9, 17, 20, 51, 641, DateTimeKind.Unspecified).AddTicks(2921), 1L, false, "https://picsum.photos/640/480/?image=13" },
                    { 28L, new DateTime(2021, 3, 5, 13, 36, 56, 259, DateTimeKind.Unspecified).AddTicks(3220), 1L, false, "https://picsum.photos/640/480/?image=709" },
                    { 29L, new DateTime(2021, 9, 18, 0, 5, 0, 342, DateTimeKind.Unspecified).AddTicks(9295), 3L, false, "https://picsum.photos/640/480/?image=1007" },
                    { 30L, new DateTime(2021, 9, 18, 22, 33, 32, 657, DateTimeKind.Unspecified).AddTicks(6653), 1L, false, "https://picsum.photos/640/480/?image=669" },
                    { 31L, new DateTime(2021, 4, 18, 19, 34, 19, 962, DateTimeKind.Unspecified).AddTicks(6541), 3L, false, "https://picsum.photos/640/480/?image=153" },
                    { 32L, new DateTime(2021, 10, 16, 11, 0, 59, 750, DateTimeKind.Unspecified).AddTicks(6231), 3L, false, "https://picsum.photos/640/480/?image=577" },
                    { 33L, new DateTime(2021, 5, 9, 16, 28, 43, 922, DateTimeKind.Unspecified).AddTicks(7899), 3L, false, "https://picsum.photos/640/480/?image=984" },
                    { 34L, new DateTime(2021, 2, 17, 10, 44, 5, 197, DateTimeKind.Unspecified).AddTicks(1636), 5L, false, "https://picsum.photos/640/480/?image=21" },
                    { 35L, new DateTime(2021, 12, 4, 17, 42, 6, 546, DateTimeKind.Unspecified).AddTicks(5482), 4L, false, "https://picsum.photos/640/480/?image=361" },
                    { 36L, new DateTime(2021, 10, 3, 8, 44, 24, 541, DateTimeKind.Unspecified).AddTicks(8418), 3L, false, "https://picsum.photos/640/480/?image=111" },
                    { 37L, new DateTime(2021, 12, 14, 20, 5, 3, 399, DateTimeKind.Unspecified).AddTicks(2463), 1L, false, "https://picsum.photos/640/480/?image=842" },
                    { 38L, new DateTime(2021, 7, 29, 19, 31, 37, 401, DateTimeKind.Unspecified).AddTicks(7173), 3L, false, "https://picsum.photos/640/480/?image=233" },
                    { 39L, new DateTime(2021, 6, 1, 16, 54, 2, 708, DateTimeKind.Unspecified).AddTicks(9200), 4L, false, "https://picsum.photos/640/480/?image=1070" },
                    { 40L, new DateTime(2021, 7, 15, 11, 57, 15, 416, DateTimeKind.Unspecified).AddTicks(5233), 2L, false, "https://picsum.photos/640/480/?image=775" },
                    { 41L, new DateTime(2022, 1, 24, 3, 51, 32, 48, DateTimeKind.Unspecified).AddTicks(8959), 4L, false, "https://picsum.photos/640/480/?image=1073" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "URL" },
                values: new object[,]
                {
                    { 42L, new DateTime(2022, 1, 23, 2, 13, 41, 636, DateTimeKind.Unspecified).AddTicks(353), 5L, false, "https://picsum.photos/640/480/?image=374" },
                    { 43L, new DateTime(2022, 1, 18, 22, 54, 39, 252, DateTimeKind.Unspecified).AddTicks(7270), 2L, false, "https://picsum.photos/640/480/?image=238" },
                    { 44L, new DateTime(2021, 8, 31, 21, 24, 19, 935, DateTimeKind.Unspecified).AddTicks(3076), 3L, false, "https://picsum.photos/640/480/?image=234" },
                    { 45L, new DateTime(2021, 12, 19, 16, 35, 39, 387, DateTimeKind.Unspecified).AddTicks(5251), 5L, false, "https://picsum.photos/640/480/?image=101" },
                    { 46L, new DateTime(2021, 10, 6, 19, 10, 11, 456, DateTimeKind.Unspecified).AddTicks(8510), 2L, false, "https://picsum.photos/640/480/?image=115" },
                    { 47L, new DateTime(2022, 1, 29, 16, 47, 23, 281, DateTimeKind.Unspecified).AddTicks(320), 5L, false, "https://picsum.photos/640/480/?image=814" },
                    { 48L, new DateTime(2021, 3, 11, 23, 57, 44, 589, DateTimeKind.Unspecified).AddTicks(3081), 5L, false, "https://picsum.photos/640/480/?image=45" },
                    { 49L, new DateTime(2021, 3, 30, 11, 16, 30, 671, DateTimeKind.Unspecified).AddTicks(3436), 5L, false, "https://picsum.photos/640/480/?image=258" },
                    { 50L, new DateTime(2021, 6, 15, 9, 59, 26, 309, DateTimeKind.Unspecified).AddTicks(2185), 3L, false, "https://picsum.photos/640/480/?image=303" },
                    { 51L, new DateTime(2021, 10, 16, 11, 57, 57, 486, DateTimeKind.Unspecified).AddTicks(598), 1L, false, "https://picsum.photos/640/480/?image=678" },
                    { 52L, new DateTime(2021, 11, 9, 17, 46, 7, 44, DateTimeKind.Unspecified).AddTicks(7409), 1L, false, "https://picsum.photos/640/480/?image=198" },
                    { 53L, new DateTime(2021, 4, 22, 16, 51, 31, 388, DateTimeKind.Unspecified).AddTicks(4773), 5L, false, "https://picsum.photos/640/480/?image=1012" },
                    { 54L, new DateTime(2021, 11, 25, 20, 26, 23, 674, DateTimeKind.Unspecified).AddTicks(8615), 5L, false, "https://picsum.photos/640/480/?image=146" },
                    { 55L, new DateTime(2021, 7, 13, 23, 35, 39, 592, DateTimeKind.Unspecified).AddTicks(9538), 3L, false, "https://picsum.photos/640/480/?image=319" },
                    { 56L, new DateTime(2021, 6, 28, 15, 57, 44, 715, DateTimeKind.Unspecified).AddTicks(6134), 1L, false, "https://picsum.photos/640/480/?image=773" },
                    { 57L, new DateTime(2021, 8, 23, 14, 33, 6, 344, DateTimeKind.Unspecified).AddTicks(1622), 5L, false, "https://picsum.photos/640/480/?image=424" },
                    { 58L, new DateTime(2021, 8, 16, 18, 27, 12, 914, DateTimeKind.Unspecified).AddTicks(2880), 5L, false, "https://picsum.photos/640/480/?image=377" },
                    { 59L, new DateTime(2021, 4, 12, 5, 27, 2, 163, DateTimeKind.Unspecified).AddTicks(8249), 5L, false, "https://picsum.photos/640/480/?image=589" },
                    { 60L, new DateTime(2022, 1, 31, 23, 5, 37, 689, DateTimeKind.Unspecified).AddTicks(2686), 1L, false, "https://picsum.photos/640/480/?image=139" },
                    { 61L, new DateTime(2021, 5, 15, 3, 55, 35, 170, DateTimeKind.Unspecified).AddTicks(74), 5L, false, "https://picsum.photos/640/480/?image=197" },
                    { 62L, new DateTime(2021, 9, 8, 23, 44, 30, 210, DateTimeKind.Unspecified).AddTicks(3134), 3L, false, "https://picsum.photos/640/480/?image=438" },
                    { 63L, new DateTime(2021, 2, 15, 4, 13, 35, 770, DateTimeKind.Unspecified).AddTicks(5840), 5L, false, "https://picsum.photos/640/480/?image=135" },
                    { 64L, new DateTime(2021, 10, 3, 3, 11, 33, 900, DateTimeKind.Unspecified).AddTicks(2046), 1L, false, "https://picsum.photos/640/480/?image=966" },
                    { 65L, new DateTime(2021, 2, 23, 0, 17, 34, 350, DateTimeKind.Unspecified).AddTicks(6687), 4L, false, "https://picsum.photos/640/480/?image=588" },
                    { 66L, new DateTime(2021, 10, 22, 14, 44, 31, 162, DateTimeKind.Unspecified).AddTicks(131), 4L, false, "https://picsum.photos/640/480/?image=892" },
                    { 67L, new DateTime(2021, 4, 14, 10, 24, 7, 53, DateTimeKind.Unspecified).AddTicks(5110), 3L, false, "https://picsum.photos/640/480/?image=368" },
                    { 68L, new DateTime(2021, 6, 4, 11, 42, 30, 778, DateTimeKind.Unspecified).AddTicks(8750), 5L, false, "https://picsum.photos/640/480/?image=268" },
                    { 69L, new DateTime(2021, 11, 10, 14, 14, 40, 829, DateTimeKind.Unspecified).AddTicks(154), 2L, false, "https://picsum.photos/640/480/?image=205" },
                    { 70L, new DateTime(2022, 1, 3, 3, 5, 22, 126, DateTimeKind.Unspecified).AddTicks(7633), 4L, false, "https://picsum.photos/640/480/?image=904" },
                    { 71L, new DateTime(2021, 3, 17, 18, 23, 10, 666, DateTimeKind.Unspecified).AddTicks(7183), 5L, false, "https://picsum.photos/640/480/?image=456" },
                    { 72L, new DateTime(2021, 2, 22, 18, 29, 8, 121, DateTimeKind.Unspecified).AddTicks(6696), 5L, false, "https://picsum.photos/640/480/?image=844" },
                    { 73L, new DateTime(2021, 2, 13, 5, 52, 32, 494, DateTimeKind.Unspecified).AddTicks(3301), 5L, false, "https://picsum.photos/640/480/?image=506" },
                    { 74L, new DateTime(2021, 11, 16, 21, 32, 14, 751, DateTimeKind.Unspecified).AddTicks(9237), 3L, false, "https://picsum.photos/640/480/?image=169" },
                    { 75L, new DateTime(2021, 5, 19, 11, 20, 27, 335, DateTimeKind.Unspecified).AddTicks(5197), 3L, false, "https://picsum.photos/640/480/?image=688" },
                    { 76L, new DateTime(2021, 9, 28, 0, 41, 19, 810, DateTimeKind.Unspecified).AddTicks(4894), 5L, false, "https://picsum.photos/640/480/?image=120" },
                    { 77L, new DateTime(2021, 11, 20, 20, 14, 39, 483, DateTimeKind.Unspecified).AddTicks(5490), 4L, false, "https://picsum.photos/640/480/?image=565" },
                    { 78L, new DateTime(2021, 7, 4, 15, 57, 33, 554, DateTimeKind.Unspecified).AddTicks(2577), 4L, false, "https://picsum.photos/640/480/?image=574" },
                    { 79L, new DateTime(2022, 1, 13, 21, 51, 23, 702, DateTimeKind.Unspecified).AddTicks(2000), 5L, false, "https://picsum.photos/640/480/?image=215" },
                    { 80L, new DateTime(2021, 10, 10, 12, 15, 20, 25, DateTimeKind.Unspecified).AddTicks(6479), 2L, false, "https://picsum.photos/640/480/?image=60" },
                    { 81L, new DateTime(2021, 10, 26, 5, 0, 58, 337, DateTimeKind.Unspecified).AddTicks(9070), 2L, false, "https://picsum.photos/640/480/?image=186" },
                    { 82L, new DateTime(2021, 9, 20, 20, 45, 27, 607, DateTimeKind.Unspecified).AddTicks(1807), 3L, false, "https://picsum.photos/640/480/?image=957" },
                    { 83L, new DateTime(2021, 6, 5, 3, 55, 10, 856, DateTimeKind.Unspecified).AddTicks(4398), 4L, false, "https://picsum.photos/640/480/?image=492" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "URL" },
                values: new object[,]
                {
                    { 84L, new DateTime(2021, 3, 26, 8, 36, 18, 166, DateTimeKind.Unspecified).AddTicks(3666), 2L, false, "https://picsum.photos/640/480/?image=1084" },
                    { 85L, new DateTime(2021, 2, 24, 14, 33, 24, 779, DateTimeKind.Unspecified).AddTicks(7894), 1L, false, "https://picsum.photos/640/480/?image=337" },
                    { 86L, new DateTime(2021, 9, 13, 17, 0, 18, 875, DateTimeKind.Unspecified).AddTicks(3368), 4L, false, "https://picsum.photos/640/480/?image=643" },
                    { 87L, new DateTime(2021, 8, 14, 0, 57, 54, 605, DateTimeKind.Unspecified).AddTicks(9389), 1L, false, "https://picsum.photos/640/480/?image=1037" },
                    { 88L, new DateTime(2021, 3, 3, 10, 32, 43, 841, DateTimeKind.Unspecified).AddTicks(4545), 2L, false, "https://picsum.photos/640/480/?image=955" },
                    { 89L, new DateTime(2022, 1, 26, 23, 27, 3, 225, DateTimeKind.Unspecified).AddTicks(4466), 5L, false, "https://picsum.photos/640/480/?image=956" },
                    { 90L, new DateTime(2022, 1, 26, 4, 52, 48, 936, DateTimeKind.Unspecified).AddTicks(8598), 3L, false, "https://picsum.photos/640/480/?image=323" },
                    { 91L, new DateTime(2021, 5, 31, 3, 25, 39, 367, DateTimeKind.Unspecified).AddTicks(1540), 3L, false, "https://picsum.photos/640/480/?image=966" },
                    { 92L, new DateTime(2021, 10, 16, 21, 18, 43, 137, DateTimeKind.Unspecified).AddTicks(2147), 5L, false, "https://picsum.photos/640/480/?image=711" },
                    { 93L, new DateTime(2022, 1, 21, 17, 35, 58, 209, DateTimeKind.Unspecified).AddTicks(5397), 4L, false, "https://picsum.photos/640/480/?image=1020" },
                    { 94L, new DateTime(2022, 1, 17, 10, 52, 24, 814, DateTimeKind.Unspecified).AddTicks(5304), 4L, false, "https://picsum.photos/640/480/?image=369" },
                    { 95L, new DateTime(2021, 9, 21, 18, 58, 41, 428, DateTimeKind.Unspecified).AddTicks(44), 3L, false, "https://picsum.photos/640/480/?image=743" },
                    { 96L, new DateTime(2021, 6, 26, 3, 0, 46, 849, DateTimeKind.Unspecified).AddTicks(5196), 2L, false, "https://picsum.photos/640/480/?image=373" },
                    { 97L, new DateTime(2021, 10, 7, 12, 3, 47, 998, DateTimeKind.Unspecified).AddTicks(2605), 4L, false, "https://picsum.photos/640/480/?image=698" },
                    { 98L, new DateTime(2021, 12, 14, 9, 24, 5, 457, DateTimeKind.Unspecified).AddTicks(3536), 1L, false, "https://picsum.photos/640/480/?image=721" },
                    { 99L, new DateTime(2021, 2, 9, 16, 34, 31, 869, DateTimeKind.Unspecified).AddTicks(3236), 2L, false, "https://picsum.photos/640/480/?image=914" },
                    { 100L, new DateTime(2021, 7, 5, 12, 53, 53, 582, DateTimeKind.Unspecified).AddTicks(7641), 1L, false, "https://picsum.photos/640/480/?image=381" },
                    { 101L, new DateTime(2021, 11, 27, 3, 28, 23, 305, DateTimeKind.Unspecified).AddTicks(7137), 1L, false, "https://picsum.photos/640/480/?image=380" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "IsDeleted", "LastName", "UserName" },
                values: new object[,]
                {
                    { 2L, 20L, "Ex et quam molestiae adipisci temporibus iste sed tempore.\nExpedita aut optio tempora enim ut.\nEligendi ipsam officia facere qui doloribus et vero ipsa.\nQuam neque error voluptate alias tenetur.", new DateTime(2021, 8, 16, 23, 5, 9, 674, DateTimeKind.Unspecified).AddTicks(5744), 4L, "Elsa.Kuhic9@yahoo.com", "Cloyd", false, "Nitzsche", "Luigi.Brekke65" },
                    { 3L, 92L, "Voluptas quas quia veritatis aut et fuga sint.\nSequi autem dolores autem aut consequatur et.\nUt sint dolorem.\nIn mollitia magni autem quis perspiciatis ab alias et.", new DateTime(2021, 3, 14, 5, 11, 28, 476, DateTimeKind.Unspecified).AddTicks(5936), 4L, "Justice_Schaefer@gmail.com", "Ulises", false, "Tillman", "Syble.Weimann" },
                    { 4L, 33L, "Quibusdam recusandae pariatur.\nQuo delectus aut vel.\nEt adipisci enim qui ea in.\nSint inventore nulla ut pariatur iure aut aut magni aut.", new DateTime(2021, 11, 21, 6, 52, 43, 759, DateTimeKind.Unspecified).AddTicks(5158), 1L, "Vivianne_Bartell@yahoo.com", "Trudie", false, "Schroeder", "Felton_Jakubowski84" },
                    { 5L, 30L, "Ad asperiores deleniti dolorum provident ipsa veniam debitis.\nAut delectus ipsam labore voluptate eum officiis illo eum blanditiis.\nRepellendus necessitatibus magnam debitis qui dolorum laborum praesentium voluptas.\nCum veniam consequatur eos fugit aut.\nExcepturi aliquid totam nobis sequi et.", new DateTime(2021, 7, 14, 21, 50, 39, 161, DateTimeKind.Unspecified).AddTicks(1421), 3L, "Fernando.Schultz28@hotmail.com", "Georgianna", false, "Maggio", "Neal46" },
                    { 6L, 5L, "Dolorem aut rem sed soluta hic.\nExercitationem quisquam vel.\nVoluptatum maiores sequi et voluptatem voluptatum cupiditate.\nDistinctio ad quia atque quae.\nIpsum modi numquam.", new DateTime(2022, 1, 17, 11, 52, 12, 1, DateTimeKind.Unspecified).AddTicks(2709), 5L, "Freda44@hotmail.com", "Lee", false, "Kreiger", "Bernie.Conroy74" },
                    { 7L, 23L, "Beatae consequuntur doloribus exercitationem quia enim beatae voluptatem dolore.\nEst et molestiae beatae.\nEst rerum similique ex corrupti molestias aperiam.\nNostrum officia aut et at praesentium et incidunt laborum culpa.\nQuae quae ut sint.", new DateTime(2021, 5, 13, 5, 16, 30, 72, DateTimeKind.Unspecified).AddTicks(2220), 3L, "Austin.Schulist88@yahoo.com", "Althea", false, "Maggio", "Cara_Marquardt86" },
                    { 8L, 64L, "Ipsa dolor optio impedit perferendis.\nTempora est ducimus et eaque.\nMagnam aperiam praesentium.", new DateTime(2022, 1, 9, 19, 23, 23, 381, DateTimeKind.Unspecified).AddTicks(3429), 5L, "Viviane67@yahoo.com", "Jarrod", false, "Durgan", "Jennifer97" },
                    { 9L, 82L, "Ea dolorem illum consequatur accusamus sed quia officia qui.\nAdipisci maxime sapiente quia quis rem blanditiis.\nEt aut excepturi rerum quod id velit fugit.\nUt harum tenetur sed quis fuga dolorem.\nAut iusto accusantium deserunt hic omnis autem provident.", new DateTime(2021, 2, 18, 5, 13, 33, 566, DateTimeKind.Unspecified).AddTicks(9632), 5L, "Hilbert90@gmail.com", "Maryse", false, "Hamill", "Arjun.DAmore" },
                    { 10L, 33L, "Sint libero a omnis illo qui sed autem ut.\nEaque et aut nihil dolore eos.\nEt enim aspernatur aut quo id.\nRepellat perspiciatis impedit consequatur molestiae quia blanditiis ea.\nFugiat aperiam sunt quam.", new DateTime(2021, 7, 25, 15, 47, 38, 181, DateTimeKind.Unspecified).AddTicks(4256), 5L, "Alfonso.Mohr36@hotmail.com", "Hermann", false, "Blick", "Yazmin.Ondricka45" },
                    { 11L, 69L, "Maxime sed recusandae ut dolor molestias aut enim.\nCommodi aperiam cum numquam ad libero sequi quisquam nam.\nCumque sed cumque aliquid nihil pariatur rem.\nPlaceat labore qui dolores soluta deserunt molestias sunt.", new DateTime(2021, 2, 2, 19, 47, 39, 758, DateTimeKind.Unspecified).AddTicks(1554), 3L, "Carmine_Denesik49@hotmail.com", "Allen", false, "Rutherford", "Shane.Willms" },
                    { 12L, 101L, "Sequi veritatis deserunt quae at molestias.\nEnim voluptas ea quasi quae incidunt.", new DateTime(2021, 5, 24, 6, 50, 23, 843, DateTimeKind.Unspecified).AddTicks(4370), 3L, "Arthur84@yahoo.com", "Efrain", false, "Jerde", "Doyle60" },
                    { 13L, 16L, "Veritatis praesentium eum iusto.\nNon non repudiandae ipsa reiciendis et et distinctio nobis.\nAnimi in assumenda molestiae.\nId esse qui.", new DateTime(2021, 8, 4, 1, 10, 59, 207, DateTimeKind.Unspecified).AddTicks(1955), 4L, "Roxane85@yahoo.com", "Ferne", false, "Corkery", "Aubree.DuBuque" },
                    { 14L, 9L, "Dolorem iste autem qui eos nisi.\nAperiam voluptate quasi nulla at officia modi perspiciatis.\nFacilis aut velit qui architecto laudantium libero.\nMagnam deleniti nostrum quasi excepturi ut ut ea autem.", new DateTime(2021, 6, 11, 6, 51, 20, 760, DateTimeKind.Unspecified).AddTicks(8108), 1L, "Aylin.Lynch58@gmail.com", "Stephany", false, "Flatley", "Forest78" },
                    { 15L, 54L, "Eos saepe fugiat accusantium qui ea rerum.", new DateTime(2021, 4, 3, 4, 28, 30, 393, DateTimeKind.Unspecified).AddTicks(4125), 3L, "Sincere66@gmail.com", "Tanner", false, "Collins", "Madyson93" },
                    { 16L, 80L, "Laboriosam totam et aut aut totam.\nSimilique sequi aut et voluptas.", new DateTime(2021, 11, 19, 19, 53, 36, 284, DateTimeKind.Unspecified).AddTicks(834), 2L, "Julien_Runte67@yahoo.com", "Wyatt", false, "Rohan", "Jed12" },
                    { 17L, 60L, "Aut sed voluptas voluptas totam quos natus.\nIste alias natus culpa illum eveniet dolor id id quos.\nNostrum qui iure ipsam delectus doloribus eius voluptatem aut enim.\nNon et et rerum qui soluta beatae alias.\nAperiam non recusandae sit libero modi quibusdam iure quia.", new DateTime(2021, 6, 19, 2, 34, 53, 649, DateTimeKind.Unspecified).AddTicks(4945), 2L, "Jordyn_Johnson@hotmail.com", "Velda", false, "Schulist", "Aimee15" },
                    { 18L, 78L, "Et voluptatem accusamus.\nAspernatur cupiditate id et molestiae vitae laudantium quia facilis.\nConsectetur fugiat velit suscipit autem ut totam et.\nQuisquam occaecati autem quia modi fuga vero distinctio ad.\nMollitia ipsam est sint commodi.", new DateTime(2021, 11, 5, 22, 31, 34, 921, DateTimeKind.Unspecified).AddTicks(7921), 3L, "Yoshiko_Parisian50@yahoo.com", "Katarina", false, "O'Kon", "Sheridan.Swift17" },
                    { 19L, 29L, "Odit nemo ratione labore corporis voluptatem excepturi.\nEt quam amet molestiae ab et perspiciatis ipsam fugiat omnis.\nOmnis fuga accusamus suscipit a aspernatur omnis architecto quidem.\nAut qui esse est.", new DateTime(2021, 12, 2, 22, 26, 27, 126, DateTimeKind.Unspecified).AddTicks(4789), 4L, "Constantin.Hayes@hotmail.com", "Cory", false, "Stoltenberg", "Braulio_McGlynn" },
                    { 20L, 2L, "Aut qui qui.\nSed voluptatibus labore.\nConsectetur eos facere et debitis temporibus sit ut est voluptatem.\nTempora quia hic.", new DateTime(2021, 9, 15, 18, 21, 57, 915, DateTimeKind.Unspecified).AddTicks(5941), 2L, "Jennifer_Cole@hotmail.com", "Jerad", false, "Dicki", "Rosetta57" },
                    { 21L, 69L, "Quos consequatur ut consequatur dolor.", new DateTime(2021, 4, 14, 8, 14, 8, 960, DateTimeKind.Unspecified).AddTicks(171), 1L, "Josiah6@hotmail.com", "Bennett", false, "Ritchie", "Lenny_Hettinger" },
                    { 22L, 58L, "Qui quia incidunt quisquam consequatur provident iure et minima soluta.\nUt quam dolorem illo quaerat quo.\nPorro ut nihil explicabo porro sit eos in iusto.\nEt possimus tenetur corporis.\nMolestiae omnis et.", new DateTime(2021, 9, 16, 16, 39, 11, 676, DateTimeKind.Unspecified).AddTicks(1746), 1L, "Lydia.Hilpert@hotmail.com", "Candace", false, "Kertzmann", "Chad_Cole" },
                    { 23L, 67L, "Porro doloribus eius quidem quos eveniet.\nIncidunt aspernatur nesciunt a cupiditate qui qui.\nDoloribus et magnam occaecati consectetur qui voluptatem voluptas ratione vitae.\nAspernatur asperiores consectetur dicta voluptatem.\nPossimus similique qui ab quia consequuntur enim voluptas.", new DateTime(2021, 11, 15, 20, 5, 12, 289, DateTimeKind.Unspecified).AddTicks(4818), 1L, "Brooklyn_Hessel48@gmail.com", "Aric", false, "Emard", "Darrel.Considine" },
                    { 24L, 78L, "Omnis sequi et.", new DateTime(2021, 7, 12, 9, 36, 45, 577, DateTimeKind.Unspecified).AddTicks(9544), 1L, "Aliza26@yahoo.com", "Wyatt", false, "Koch", "Gordon_Goyette81" },
                    { 25L, 66L, "Perspiciatis mollitia nobis consequatur dolor autem consequatur voluptas repellat.\nQui consequuntur et dolores sunt sequi eaque deleniti aspernatur aliquid.\nLaboriosam quisquam quos non suscipit et laboriosam rerum perferendis est.\nIste ad non tenetur totam quibusdam consequatur dolore.\nSoluta voluptatem illum in.", new DateTime(2021, 12, 6, 17, 20, 43, 778, DateTimeKind.Unspecified).AddTicks(8524), 4L, "Waylon_Oberbrunner@yahoo.com", "Bonnie", false, "Gerhold", "Shad_Sauer67" },
                    { 26L, 59L, "Totam odio voluptatibus quaerat.\nSimilique et id et est labore tempore at voluptatem.\nArchitecto et sint explicabo commodi.", new DateTime(2021, 9, 19, 15, 58, 2, 648, DateTimeKind.Unspecified).AddTicks(8897), 1L, "Warren.Bradtke@hotmail.com", "Clay", false, "Kris", "Katelyn87" },
                    { 27L, 43L, "Veniam iste quisquam et.\nIpsa placeat aspernatur in ut.\nQui dolorum magni ut ad.\nVitae non dolores laboriosam est numquam.", new DateTime(2021, 10, 12, 7, 15, 57, 780, DateTimeKind.Unspecified).AddTicks(9232), 5L, "Keith53@gmail.com", "Frank", false, "Bergstrom", "Enrique31" },
                    { 28L, 32L, "Molestiae modi alias.\nBeatae enim laborum placeat consectetur fugit alias recusandae veniam vero.", new DateTime(2021, 4, 30, 18, 51, 42, 478, DateTimeKind.Unspecified).AddTicks(6774), 1L, "Stefan.Pacocha@gmail.com", "Fabiola", false, "Dietrich", "Pamela79" },
                    { 29L, 18L, "Dolorum beatae sequi veritatis veniam.\nLaboriosam quidem eos aut hic.\nSunt nihil voluptate doloribus accusantium non dolor.", new DateTime(2021, 10, 10, 3, 3, 59, 177, DateTimeKind.Unspecified).AddTicks(9072), 1L, "Birdie_Abbott92@gmail.com", "Jose", false, "Wuckert", "Cristina_Pfeffer" },
                    { 30L, 2L, "Eius sunt delectus natus eaque quia molestiae ex culpa.\nAutem minima corrupti quidem qui et et modi.\nQuia incidunt dolores sed voluptatem voluptatem qui.\nQuaerat voluptatem suscipit labore recusandae corrupti non consequatur.\nNon qui vitae autem voluptas.", new DateTime(2021, 12, 3, 2, 45, 51, 373, DateTimeKind.Unspecified).AddTicks(3865), 4L, "Federico3@yahoo.com", "Rowland", false, "Kuhn", "Jermey_Johns17" },
                    { 31L, 24L, "Nihil sed saepe corrupti ipsum eaque.", new DateTime(2021, 3, 29, 15, 49, 38, 852, DateTimeKind.Unspecified).AddTicks(5072), 3L, "Hipolito.Stokes82@gmail.com", "Lawrence", false, "Lockman", "Richard_Robel" },
                    { 32L, 67L, "Earum sunt corrupti deserunt.\nVeritatis rerum nam quisquam et molestias quae.\nNemo nesciunt provident odit.\nEa dolore qui.\nEarum labore saepe corrupti quae id aut ullam fugiat expedita.", new DateTime(2021, 4, 17, 2, 40, 37, 265, DateTimeKind.Unspecified).AddTicks(8566), 5L, "Noelia54@yahoo.com", "Lila", false, "Bayer", "Brook_Shanahan78" },
                    { 33L, 64L, "Quo dolores cum omnis est quod ea.\nVoluptatem dolore cumque quia sit veniam repellendus nihil quasi at.\nMolestiae voluptas beatae voluptatibus blanditiis dolore.\nNisi sed pariatur dolorum nesciunt sunt sed.\nVoluptas placeat dolorum veniam ut consequatur ex.", new DateTime(2021, 5, 28, 20, 11, 9, 545, DateTimeKind.Unspecified).AddTicks(9227), 5L, "Tierra_Gusikowski77@yahoo.com", "Armand", false, "Schmitt", "Stewart31" },
                    { 34L, 51L, "Nemo consequuntur in quis.", new DateTime(2022, 1, 20, 6, 51, 8, 284, DateTimeKind.Unspecified).AddTicks(8777), 3L, "Justice_Borer@gmail.com", "Nicklaus", false, "Rosenbaum", "Delmer52" },
                    { 35L, 17L, "Perspiciatis dolor quisquam nostrum dolorem quis non.\nAut est aut mollitia in aut voluptas velit quasi.\nQui non nisi fugit quis odit.\nAut praesentium nisi fuga blanditiis unde id totam quisquam.", new DateTime(2021, 7, 7, 4, 41, 23, 241, DateTimeKind.Unspecified).AddTicks(9668), 5L, "Ezequiel_Padberg15@hotmail.com", "Constance", false, "Cremin", "Pinkie_Schamberger7" },
                    { 36L, 24L, "Repellendus possimus rem.\nMolestiae quos et dolores.", new DateTime(2021, 12, 16, 15, 43, 10, 866, DateTimeKind.Unspecified).AddTicks(9229), 3L, "Taurean55@gmail.com", "Raul", false, "Baumbach", "Mikel.Lakin" },
                    { 37L, 8L, "Cupiditate ut sunt.\nEx atque facilis corporis ex blanditiis voluptas.", new DateTime(2021, 5, 26, 16, 17, 45, 659, DateTimeKind.Unspecified).AddTicks(496), 3L, "Zella_Maggio@hotmail.com", "Arch", false, "King", "Mariane_Effertz" },
                    { 38L, 59L, "Id unde provident molestiae laboriosam occaecati quam harum.\nEt sit qui et enim veniam aut aspernatur praesentium natus.", new DateTime(2021, 2, 3, 9, 57, 31, 853, DateTimeKind.Unspecified).AddTicks(9551), 4L, "Bertrand_Thiel@gmail.com", "Jeremie", false, "Bradtke", "Declan.Marquardt" },
                    { 39L, 54L, "Facere qui provident.\nVoluptas in non ducimus non ipsa.\nNecessitatibus ut quis vero et.\nUt quia laborum.", new DateTime(2021, 4, 25, 17, 43, 36, 148, DateTimeKind.Unspecified).AddTicks(5969), 5L, "Suzanne_Stiedemann@hotmail.com", "Jessie", false, "Beahan", "Jayden.Stoltenberg" },
                    { 40L, 82L, "Similique aperiam incidunt iste sit et quo harum modi officiis.\nAdipisci consequatur mollitia.\nA officiis ratione.", new DateTime(2021, 12, 6, 22, 53, 54, 113, DateTimeKind.Unspecified).AddTicks(2011), 4L, "Rose84@gmail.com", "Ally", false, "Feeney", "Frederik.Sporer" },
                    { 41L, 91L, "Ex repellat nemo et molestiae exercitationem adipisci modi consequuntur.\nEt quod assumenda assumenda et natus eius saepe.\nNobis voluptatem eum amet molestiae sint accusantium aliquid et aut.\nAccusantium veniam odio dolores et quae est quaerat quisquam voluptatem.", new DateTime(2021, 10, 11, 6, 46, 31, 102, DateTimeKind.Unspecified).AddTicks(9974), 2L, "Naomi30@yahoo.com", "Rosalyn", false, "Robel", "Arlo.Boehm" },
                    { 42L, 25L, "Consequatur aut optio in earum error fugit dolorem soluta numquam.\nHarum cupiditate facere repudiandae a.\nEveniet aperiam minima voluptas.\nQuia voluptatem rerum.\nNisi ratione repudiandae.", new DateTime(2021, 7, 12, 5, 52, 38, 84, DateTimeKind.Unspecified).AddTicks(6036), 4L, "Jaiden27@gmail.com", "Ressie", false, "Bernhard", "Ebba94" },
                    { 43L, 78L, "Facere repellendus non ab dicta est molestiae.", new DateTime(2021, 11, 13, 11, 28, 17, 365, DateTimeKind.Unspecified).AddTicks(5193), 5L, "Kiana_Nitzsche67@gmail.com", "Sim", false, "Koepp", "Emilio62" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "Bio", "CreatedAt", "CreatedBy", "Email", "FirstName", "IsDeleted", "LastName", "UserName" },
                values: new object[,]
                {
                    { 44L, 2L, "Qui in vero illum rerum est iusto.\nDoloremque molestiae rerum magnam illum explicabo eum.", new DateTime(2021, 7, 14, 3, 28, 30, 37, DateTimeKind.Unspecified).AddTicks(2000), 5L, "Kacey_Harvey47@gmail.com", "Tommie", false, "Heller", "Vito_Fritsch" },
                    { 45L, 49L, "Sed perferendis voluptates est repudiandae odit.\nEt quia dolor.\nDolore debitis et ea officiis quam ullam eius.\nQuidem et ipsa dolores excepturi corporis facilis.", new DateTime(2021, 4, 14, 17, 3, 32, 731, DateTimeKind.Unspecified).AddTicks(145), 4L, "Yazmin_Schinner76@gmail.com", "Rylee", false, "Hayes", "Chad_Streich" },
                    { 46L, 81L, "Ad rerum cum occaecati laudantium.\nEius natus sed et voluptas sint ut est quia.\nLaudantium aut recusandae velit qui ipsa deleniti.", new DateTime(2021, 3, 29, 6, 33, 32, 453, DateTimeKind.Unspecified).AddTicks(1066), 2L, "Tracy.Mills90@yahoo.com", "Dejah", false, "Schamberger", "Ciara.Conroy" },
                    { 47L, 73L, "Neque similique cumque quo quibusdam fugiat velit.\nOmnis sapiente ut vero sit nulla ut neque minima officia.", new DateTime(2021, 5, 11, 11, 32, 41, 57, DateTimeKind.Unspecified).AddTicks(5914), 5L, "Beatrice.Weimann@hotmail.com", "Bradford", false, "Mosciski", "Claire_Roberts62" },
                    { 48L, 11L, "Quis rem omnis nobis eos assumenda enim enim magni.\nSed doloribus ipsum eveniet fuga impedit ut sed possimus.\nQuidem excepturi dolore.\nQuibusdam et id et nam temporibus fuga voluptas consequuntur sit.", new DateTime(2021, 6, 17, 5, 38, 31, 577, DateTimeKind.Unspecified).AddTicks(4264), 5L, "Noemi.Hoppe@yahoo.com", "Eulah", false, "Huels", "Daphnee98" },
                    { 49L, 10L, "Rerum et quidem harum velit omnis tempora.\nNecessitatibus quasi dolorem est facilis nisi non minima et.", new DateTime(2021, 10, 27, 23, 57, 47, 255, DateTimeKind.Unspecified).AddTicks(3568), 4L, "Ethyl75@hotmail.com", "Keegan", false, "Hartmann", "Jovanny_Kuhn" },
                    { 50L, 33L, "Voluptatem qui sed.\nMaiores dolor sed deserunt cumque vel.", new DateTime(2021, 7, 8, 7, 55, 1, 386, DateTimeKind.Unspecified).AddTicks(761), 1L, "Andre27@hotmail.com", "Joesph", false, "Glover", "Adalberto.Yundt86" },
                    { 51L, 75L, "Temporibus totam ea voluptatem.\nEveniet error similique adipisci iure architecto quis.", new DateTime(2022, 1, 25, 2, 40, 42, 581, DateTimeKind.Unspecified).AddTicks(4182), 2L, "Kaylah.Harber70@gmail.com", "Michale", false, "Wiza", "Zetta88" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 2L, 58L, new DateTime(2021, 9, 17, 0, 4, 59, 621, DateTimeKind.Unspecified).AddTicks(264), 3L, "Consectetur cum illum.\nDolores esse maiores.\nEt est sunt dignissimos aspernatur provident eum consequatur ut neque.\nReiciendis doloribus suscipit numquam.\nFuga dolor omnis non veniam nulla magnam sed.", "Incidunt quia quibusdam.", false, "Avonsolid stateregionalopen-source", 15L },
                    { 3L, 70L, new DateTime(2021, 10, 11, 16, 11, 5, 577, DateTimeKind.Unspecified).AddTicks(2928), 4L, "Consectetur in quo expedita inventore est.\nOdio consequatur debitis fugiat asperiores qui.\nOccaecati ducimus error.\nIn molestias aut voluptatem.\nExplicabo atque quos sit pariatur quis in unde amet.", "Nobis ad iusto aspernatur asperiores sapiente et perferendis architecto.", false, "Swedish KronaStreamStreamCotton", 47L },
                    { 4L, 56L, new DateTime(2021, 10, 4, 13, 22, 38, 500, DateTimeKind.Unspecified).AddTicks(7072), 4L, "Cum ut ea non id et ipsum similique nihil.", "Repellat hic pariatur veniam maiores voluptatibus rem sint.", false, "AccountsAdministrator", 9L },
                    { 5L, 54L, new DateTime(2021, 11, 19, 16, 38, 36, 889, DateTimeKind.Unspecified).AddTicks(6805), 4L, "Velit autem est excepturi eligendi excepturi suscipit.\nEst nihil eum dolor adipisci iste officiis.", "Quam dicta nihil voluptatem nulla et.", false, "internet solutioneyeballsPlain", 12L },
                    { 6L, 24L, new DateTime(2022, 1, 15, 5, 18, 51, 713, DateTimeKind.Unspecified).AddTicks(6183), 2L, "Reiciendis rerum molestias veritatis eum adipisci eos non et inventore.", "Nam omnis quis delectus et modi quia vel veniam quidem.", false, "ParkwayactuatingLodgedemand-driven", 4L },
                    { 7L, 54L, new DateTime(2021, 12, 14, 10, 38, 57, 25, DateTimeKind.Unspecified).AddTicks(6304), 4L, "Possimus consequatur dolorum ut reprehenderit illo doloremque id sed sit.\nSit deserunt inventore tempore modi voluptate debitis et.\nSed error ab perferendis veritatis.", "Perferendis illum magni suscipit cumque qui et maiores et asperiores.", false, "MetalIntelligent Concrete CarChecking Account", 27L },
                    { 8L, 31L, new DateTime(2021, 8, 23, 17, 38, 32, 138, DateTimeKind.Unspecified).AddTicks(7792), 3L, "Voluptate nobis dicta fugit quod facilis totam.\nIn consectetur dicta sed reprehenderit consectetur tenetur est.\nEt perspiciatis ut rem.", "Cumque iusto sapiente et sit.", false, "EngineerRiver", 19L },
                    { 9L, 3L, new DateTime(2022, 2, 1, 4, 6, 17, 35, DateTimeKind.Unspecified).AddTicks(4057), 3L, "Possimus repellat rem voluptatem doloremque aut voluptas animi tempore.\nEarum quos repudiandae magni quia adipisci aliquid ea aperiam.\nSoluta aliquam vitae cum aut aperiam harum.\nSit asperiores in provident tempora a eligendi.", "Repellendus et exercitationem iusto nam repellendus nesciunt qui enim dolorem.", false, "RandonlineShoes, Books & Gamescultivate", 22L },
                    { 10L, 28L, new DateTime(2021, 9, 6, 2, 42, 47, 251, DateTimeKind.Unspecified).AddTicks(9148), 2L, "Sint autem ut repellat voluptatum facere.", "Provident laborum sapiente aspernatur tenetur magni nesciunt.", false, "Incredible Plastic SausagesForward", 35L },
                    { 11L, 80L, new DateTime(2021, 11, 20, 22, 23, 19, 540, DateTimeKind.Unspecified).AddTicks(4514), 1L, "Ea et consequatur consectetur aspernatur dolorum aut.\nSunt veniam veritatis.\nExpedita sint sed similique explicabo blanditiis sit.\nMollitia qui est quibusdam.\nAssumenda eaque quia corrupti autem autem ut.", "Unde aliquid reiciendis voluptatem facere ipsum excepturi aspernatur sapiente consequatur.", false, "DivisionLicensed Fresh Pants", 34L },
                    { 12L, 82L, new DateTime(2021, 9, 19, 23, 44, 59, 297, DateTimeKind.Unspecified).AddTicks(7838), 3L, "Quas amet optio.\nQuaerat praesentium aut.\nSit qui molestiae occaecati velit quos nesciunt vel.\nExcepturi suscipit nihil.\nIn accusantium qui dolore est ut molestias eos ad.", "Nostrum vel dolores labore quidem.", false, "BalancedLicensed Plastic Shirt", 29L },
                    { 13L, 32L, new DateTime(2021, 12, 23, 0, 13, 32, 386, DateTimeKind.Unspecified).AddTicks(5414), 3L, "Quos qui corporis occaecati sequi odit nesciunt.", "Dolores sunt est sunt officiis fugiat eius est.", false, "Burundi FrancCredit Card Account", 40L },
                    { 14L, 23L, new DateTime(2022, 1, 18, 10, 30, 11, 469, DateTimeKind.Unspecified).AddTicks(361), 4L, "Ad cum qui occaecati esse.\nSunt vel in dolor architecto labore accusantium.\nSit iste temporibus pariatur.", "Ducimus est quis assumenda.", false, "AzerbaijannavigateAssistant", 33L },
                    { 15L, 3L, new DateTime(2021, 7, 26, 2, 11, 36, 772, DateTimeKind.Unspecified).AddTicks(1782), 5L, "Consequuntur a minima nihil ratione hic laborum.", "Sed sapiente impedit incidunt debitis et nihil omnis commodi.", false, "onlineAIRapid", 46L },
                    { 16L, 44L, new DateTime(2021, 4, 13, 14, 56, 19, 387, DateTimeKind.Unspecified).AddTicks(2607), 4L, "Placeat pariatur aut corrupti sit.\nMolestias vitae eum.\nNisi voluptates omnis.\nAutem ut mollitia ea maxime sunt facilis.", "Fugit repellat eligendi id distinctio fugit provident.", false, "BrandingAdvanceddeposit", 4L },
                    { 17L, 43L, new DateTime(2021, 8, 14, 4, 41, 54, 110, DateTimeKind.Unspecified).AddTicks(5984), 4L, "Fugiat veritatis quo repellendus tempora eligendi sit aut voluptatem soluta.\nUnde architecto vero voluptas quos.\nPossimus et veniam facere aut natus doloremque officiis.", "Eaque quis officiis voluptatem sequi fuga sunt nobis est laboriosam.", false, "MichiganPolarisedPlainsGorgeous Concrete Chair", 26L },
                    { 18L, 23L, new DateTime(2021, 4, 5, 5, 3, 27, 840, DateTimeKind.Unspecified).AddTicks(7372), 5L, "Beatae a saepe quo neque ratione vero quas soluta.\nAut quia sed suscipit velit occaecati cumque blanditiis unde totam.", "Eum molestiae qui itaque ut nam ex aspernatur quia architecto.", false, "Awesome Wooden Hatmesh", 32L },
                    { 19L, 54L, new DateTime(2021, 8, 15, 8, 43, 44, 14, DateTimeKind.Unspecified).AddTicks(1195), 4L, "Ea eveniet totam fugiat qui accusamus.", "Reprehenderit aut voluptatem id recusandae vel provident illo sed et.", false, "sexyconceptInfrastructuremission-critical", 43L },
                    { 20L, 13L, new DateTime(2021, 5, 3, 10, 28, 4, 12, DateTimeKind.Unspecified).AddTicks(4753), 5L, "Itaque nesciunt velit reiciendis.\nSed earum dolorum voluptas consequatur ut soluta illum.\nNostrum et quae sed vel.", "Ea laudantium perferendis mollitia rerum explicabo aliquam delectus.", false, "Unbranded Soft TunaIowa", 39L },
                    { 21L, 97L, new DateTime(2021, 9, 2, 8, 24, 55, 991, DateTimeKind.Unspecified).AddTicks(2292), 5L, "Officiis aut impedit recusandae quia soluta.\nExpedita nemo voluptatem ab illo voluptatem ea esse.", "Molestiae aliquid ea saepe corrupti illo vitae.", false, "North CarolinaengineerIdentity", 22L }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "IsPublic", "OwnerId", "Title" },
                values: new object[,]
                {
                    { 2L, new DateTime(2021, 7, 26, 19, 4, 4, 734, DateTimeKind.Unspecified).AddTicks(1970), 5L, "Dolor molestiae rerum dicta id.\nOptio nisi et.\nQui modi porro et est reiciendis.", false, true, 33L, "Ullam odio voluptatum ipsam provident a." },
                    { 3L, new DateTime(2021, 5, 13, 15, 24, 20, 34, DateTimeKind.Unspecified).AddTicks(1504), 2L, "Omnis unde fuga porro eligendi optio veritatis nam.\nQuos voluptas sapiente officiis id.", false, true, 34L, "Quia at et necessitatibus aut molestiae." },
                    { 4L, new DateTime(2021, 5, 22, 1, 6, 33, 968, DateTimeKind.Unspecified).AddTicks(5617), 4L, "Nihil adipisci et animi atque quo aut.\nSapiente molestias voluptatem aut fuga enim voluptatibus dolores ab.\nFuga animi nihil culpa est vel molestiae.\nMagni voluptas rerum natus eligendi debitis.\nCorrupti a qui doloribus et voluptatum nesciunt et.", false, true, 36L, "Facere et repellat et veritatis voluptatem illum." },
                    { 5L, new DateTime(2021, 11, 24, 5, 1, 34, 472, DateTimeKind.Unspecified).AddTicks(1709), 2L, "Accusamus quia perspiciatis quia cum.", false, true, 31L, "Consequuntur amet sit est perferendis praesentium." },
                    { 6L, new DateTime(2021, 7, 16, 22, 3, 49, 356, DateTimeKind.Unspecified).AddTicks(517), 5L, "Dicta totam aut eum aut sint cum non sit.", false, false, 39L, "Vel ratione eum dolores ex quo." },
                    { 7L, new DateTime(2021, 7, 27, 15, 9, 33, 82, DateTimeKind.Unspecified).AddTicks(6140), 1L, "Similique ducimus in neque consequuntur corporis sint iste perferendis.\nFugiat sit fuga quia autem est enim corrupti labore et.\nRatione optio harum officia quia pariatur.", false, false, 25L, "Nobis aliquid et quo." },
                    { 8L, new DateTime(2021, 5, 8, 20, 12, 17, 373, DateTimeKind.Unspecified).AddTicks(7584), 5L, "Quia sint laboriosam fugit similique et nisi eos sapiente beatae.\nMollitia delectus quam quam.\nEarum in aut qui laboriosam explicabo voluptatibus rem ipsam.", false, false, 19L, "Labore minima et quidem necessitatibus itaque aliquam." },
                    { 9L, new DateTime(2021, 9, 22, 17, 9, 34, 301, DateTimeKind.Unspecified).AddTicks(2925), 5L, "Quisquam et tenetur iure sint enim eos.", false, false, 46L, "Suscipit incidunt expedita harum quia harum ea occaecati voluptatem." },
                    { 10L, new DateTime(2021, 12, 28, 8, 57, 2, 919, DateTimeKind.Unspecified).AddTicks(2616), 2L, "Vel quia quia maxime ut itaque suscipit explicabo temporibus qui.\nOmnis qui rerum et deserunt accusantium.\nQui libero atque.\nAt necessitatibus aut dolor.", false, false, 50L, "Magni distinctio accusantium provident et quibusdam." },
                    { 11L, new DateTime(2021, 4, 26, 8, 16, 50, 656, DateTimeKind.Unspecified).AddTicks(2232), 2L, "Reiciendis itaque voluptas aperiam corrupti occaecati.\nQuisquam amet quae et molestias dolor ea tenetur velit.", false, true, 15L, "Quisquam qui dolor consequuntur animi autem." },
                    { 12L, new DateTime(2021, 9, 20, 6, 3, 32, 131, DateTimeKind.Unspecified).AddTicks(1468), 1L, "Nihil sequi unde illum sit eius vel mollitia esse minus.\nOdit commodi quis neque inventore nisi molestiae eos.\nQuo voluptatem dignissimos assumenda necessitatibus sit qui.\nCommodi similique sunt delectus nisi officia.", false, false, 34L, "Velit commodi et." },
                    { 13L, new DateTime(2022, 1, 22, 21, 9, 33, 438, DateTimeKind.Unspecified).AddTicks(4862), 1L, "Eligendi magni et eos.\nEt et iusto itaque aut consectetur eum.\nDolor non est architecto autem incidunt pariatur neque.\nVoluptas omnis omnis molestias aut aut ut est eveniet.\nSuscipit modi architecto possimus nihil minima eum.", false, true, 27L, "Numquam eligendi sit." },
                    { 14L, new DateTime(2021, 2, 26, 22, 26, 10, 542, DateTimeKind.Unspecified).AddTicks(989), 3L, "Eos voluptatem hic eos inventore.\nConsequatur magni enim aut sit explicabo sed nostrum quia nam.\nQuos nihil ipsum.", false, true, 41L, "Qui et earum reprehenderit." },
                    { 15L, new DateTime(2021, 9, 30, 1, 44, 30, 757, DateTimeKind.Unspecified).AddTicks(5812), 1L, "Provident natus molestias in culpa adipisci.\nEos iure exercitationem ut.\nSed voluptate animi id eaque qui eum ducimus.", false, false, 15L, "Accusantium qui occaecati eum sed." },
                    { 16L, new DateTime(2021, 11, 23, 12, 56, 47, 313, DateTimeKind.Unspecified).AddTicks(3850), 4L, "Dolor et dicta at voluptas error dolor ut eum illum.\nItaque molestiae doloribus atque et id sed et voluptatem.\nDolorem aut natus voluptate dolores recusandae.", false, false, 29L, "Sit temporibus doloremque quia pariatur placeat consectetur sed est." },
                    { 17L, new DateTime(2021, 6, 27, 16, 0, 12, 944, DateTimeKind.Unspecified).AddTicks(6223), 5L, "Corrupti odit excepturi.", false, false, 12L, "Nulla dolorum a velit facilis non." },
                    { 18L, new DateTime(2021, 2, 26, 3, 24, 35, 267, DateTimeKind.Unspecified).AddTicks(6425), 1L, "Quos et dolorem cupiditate ducimus.\nHarum et nihil ab.\nEum sunt aut aperiam quasi consequatur non.\nSoluta est autem et pariatur ex omnis sed quo quia.\nQuia omnis perspiciatis unde magni nisi.", false, false, 8L, "Consequatur aspernatur qui esse." },
                    { 19L, new DateTime(2021, 11, 24, 16, 12, 4, 758, DateTimeKind.Unspecified).AddTicks(1023), 4L, "Exercitationem sunt et nihil.\nNon fugit sapiente aut.\nEveniet expedita et et.\nQui pariatur quo perspiciatis cum est atque rerum magni inventore.", false, true, 28L, "Dolore soluta laudantium sit dolorem omnis." },
                    { 20L, new DateTime(2021, 11, 15, 5, 19, 2, 173, DateTimeKind.Unspecified).AddTicks(9116), 5L, "Sit perferendis vel laborum hic.\nMinima similique dolor impedit.", false, false, 26L, "Non autem quod non debitis ea vitae." },
                    { 21L, new DateTime(2021, 9, 12, 3, 37, 53, 732, DateTimeKind.Unspecified).AddTicks(3926), 5L, "Perferendis alias nihil est praesentium.", false, false, 7L, "Dolores consequatur quia." },
                    { 22L, new DateTime(2021, 10, 13, 1, 33, 4, 245, DateTimeKind.Unspecified).AddTicks(704), 1L, "Enim officiis recusandae hic dolor fuga ut maiores.\nDoloremque perspiciatis in fuga aperiam et.\nUt doloribus quia sit.", false, false, 32L, "Et est dolores quas." },
                    { 23L, new DateTime(2021, 10, 26, 5, 20, 47, 257, DateTimeKind.Unspecified).AddTicks(8317), 5L, "Maiores atque est.", false, true, 11L, "Commodi quia doloribus." }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "IsPublic", "OwnerId", "Title" },
                values: new object[,]
                {
                    { 24L, new DateTime(2021, 3, 13, 3, 6, 43, 745, DateTimeKind.Unspecified).AddTicks(9947), 2L, "Aspernatur non nostrum ea quia laudantium.\nMolestias dolor molestias architecto cumque quisquam et officiis.", false, true, 24L, "Qui iure et iusto." },
                    { 25L, new DateTime(2021, 9, 4, 19, 54, 23, 304, DateTimeKind.Unspecified).AddTicks(6290), 4L, "Consequatur voluptate itaque consequatur sequi nostrum quisquam quia unde architecto.", false, false, 45L, "Ipsa inventore rerum ipsum pariatur." },
                    { 26L, new DateTime(2021, 12, 12, 22, 50, 5, 891, DateTimeKind.Unspecified).AddTicks(4657), 2L, "Itaque exercitationem perspiciatis hic.\nIpsa facilis sed molestias doloribus culpa.", false, false, 7L, "Nemo sit vel atque numquam rerum." },
                    { 27L, new DateTime(2021, 10, 12, 3, 19, 37, 413, DateTimeKind.Unspecified).AddTicks(2531), 5L, "Autem consequatur repudiandae labore occaecati labore repellat architecto.\nLaboriosam suscipit dolorem et tenetur enim debitis.\nPerspiciatis vel et.\nBlanditiis quasi eius.", false, true, 50L, "Velit repellat nihil quia nisi et quos voluptatem a error." },
                    { 28L, new DateTime(2021, 9, 3, 23, 26, 12, 531, DateTimeKind.Unspecified).AddTicks(8974), 3L, "Et et enim quasi nam quaerat quam iure voluptatem.\nNon velit amet est distinctio suscipit exercitationem.", false, false, 3L, "Veniam asperiores qui quis earum voluptas qui beatae laboriosam." },
                    { 29L, new DateTime(2021, 4, 11, 9, 2, 14, 794, DateTimeKind.Unspecified).AddTicks(3353), 1L, "Velit sint qui reiciendis ratione alias omnis sapiente.\nIusto doloribus consectetur quasi qui quidem animi.\nAsperiores pariatur vel voluptatem temporibus.\nIste quibusdam voluptatibus quisquam voluptatem eum.", false, true, 40L, "Enim voluptas ut excepturi debitis sapiente fuga dolorem." },
                    { 30L, new DateTime(2021, 10, 24, 18, 52, 9, 721, DateTimeKind.Unspecified).AddTicks(3781), 5L, "Reiciendis cumque beatae.", false, true, 40L, "Non libero et nobis amet nostrum qui." },
                    { 31L, new DateTime(2021, 2, 14, 2, 57, 22, 932, DateTimeKind.Unspecified).AddTicks(6614), 2L, "Ea culpa dicta cum quo.", false, true, 30L, "Harum voluptatem quam reprehenderit velit et ut dolor." },
                    { 32L, new DateTime(2021, 8, 13, 4, 32, 10, 317, DateTimeKind.Unspecified).AddTicks(236), 1L, "A enim odit omnis consequuntur fugiat qui fugit.\nId animi quas voluptatem perferendis quod deleniti molestiae ullam.\nCumque eligendi qui voluptates ut vitae eum omnis sit.\nHarum deserunt velit praesentium.", false, true, 18L, "Animi aut iste labore voluptatem omnis rem vero." },
                    { 33L, new DateTime(2021, 2, 7, 23, 28, 49, 544, DateTimeKind.Unspecified).AddTicks(1619), 2L, "Explicabo repellendus perspiciatis et.\nPariatur ipsum asperiores voluptatem accusantium error commodi similique eligendi.", false, true, 5L, "Unde alias maiores qui similique." },
                    { 34L, new DateTime(2021, 3, 13, 12, 0, 24, 212, DateTimeKind.Unspecified).AddTicks(4416), 5L, "Consequatur et facere vero quo et dolorem.\nEa maiores quae numquam soluta ut dolor.\nEsse odio quam possimus assumenda et.\nDolore non est totam in aliquid hic.", false, true, 12L, "Aut amet quae in." },
                    { 35L, new DateTime(2021, 11, 23, 0, 59, 37, 299, DateTimeKind.Unspecified).AddTicks(5280), 3L, "Provident quidem iure officia assumenda id sequi recusandae quo.\nRepellat quas molestiae.", false, false, 40L, "Ut quam eos nemo repellendus id vel neque impedit." },
                    { 36L, new DateTime(2021, 11, 6, 5, 9, 25, 836, DateTimeKind.Unspecified).AddTicks(3816), 1L, "Dolores quidem voluptatem tenetur quod.", false, false, 51L, "Itaque quo ea temporibus similique unde." },
                    { 37L, new DateTime(2021, 12, 2, 0, 30, 15, 21, DateTimeKind.Unspecified).AddTicks(955), 4L, "Commodi perferendis nemo dolorum.\nAssumenda esse dolores quod quasi voluptas qui quos.\nSint repudiandae aut ex sunt excepturi.\nCumque earum quam molestiae minima quos repellendus odio id.\nEnim sunt quasi assumenda fuga quo suscipit aperiam eos culpa.", false, false, 26L, "Aut voluptas dolor dignissimos illo et illo soluta ut." },
                    { 38L, new DateTime(2021, 10, 23, 22, 17, 2, 787, DateTimeKind.Unspecified).AddTicks(7573), 3L, "Ratione in ex distinctio architecto.", false, false, 11L, "Est ut sed aut." },
                    { 39L, new DateTime(2021, 11, 3, 15, 44, 47, 482, DateTimeKind.Unspecified).AddTicks(6129), 3L, "Quia tenetur non veniam sed dolor dolore.", false, true, 31L, "Inventore consequatur sit provident quos quam cumque saepe." },
                    { 40L, new DateTime(2021, 5, 2, 8, 22, 14, 373, DateTimeKind.Unspecified).AddTicks(7594), 5L, "Qui id eos hic sint quos in rerum est.\nEnim facilis consequatur fuga alias.\nRem quasi blanditiis saepe.", false, false, 49L, "Error error neque est porro aut." },
                    { 41L, new DateTime(2021, 3, 15, 7, 3, 22, 371, DateTimeKind.Unspecified).AddTicks(9042), 3L, "Quis ea quisquam sunt voluptatibus.\nImpedit animi est natus quia magnam id dolorum earum.\nUt eius facilis et expedita amet sed.", false, false, 7L, "Et odio dolorum consequatur et nihil." },
                    { 42L, new DateTime(2021, 5, 28, 21, 43, 18, 248, DateTimeKind.Unspecified).AddTicks(9890), 5L, "Corporis iusto eius minima aut corrupti nemo placeat.\nDoloremque eum sint quas dolor.\nEt illo qui.", false, false, 4L, "A enim necessitatibus." },
                    { 43L, new DateTime(2021, 5, 2, 21, 51, 40, 110, DateTimeKind.Unspecified).AddTicks(1577), 4L, "Rerum laboriosam libero omnis sunt ullam sit quisquam.\nAccusamus qui laboriosam et commodi.\nIllum dolore animi repellendus.\nOmnis ut debitis nemo quas quod dolorum magnam perferendis quia.\nQuasi molestiae sunt.", false, false, 36L, "Sed a maiores esse." },
                    { 44L, new DateTime(2021, 6, 2, 3, 10, 51, 408, DateTimeKind.Unspecified).AddTicks(2202), 3L, "Eum harum alias aut quod praesentium commodi aliquam.\nSoluta non nihil sapiente facere distinctio repudiandae vel quo.", false, true, 7L, "Deleniti eum omnis est non pariatur quisquam doloremque voluptatem doloremque." },
                    { 45L, new DateTime(2021, 8, 7, 13, 46, 50, 192, DateTimeKind.Unspecified).AddTicks(5321), 2L, "Corporis eius et laborum minus odio nihil maiores.\nIncidunt aliquid dolores aut quibusdam eveniet quasi consequatur est consectetur.\nNumquam id similique veniam numquam quo quia tenetur voluptas.\nAut et rem sed vel quo beatae.", false, true, 2L, "Ab omnis magni aliquid blanditiis." },
                    { 46L, new DateTime(2021, 9, 13, 6, 55, 38, 674, DateTimeKind.Unspecified).AddTicks(1978), 2L, "Reiciendis quos cumque et ut.\nVoluptatem fugit rem distinctio corporis sed.\nAccusantium voluptatibus quam sit asperiores praesentium.", false, false, 50L, "Et ut placeat repellat similique molestias sequi nihil quia." },
                    { 47L, new DateTime(2021, 12, 25, 13, 20, 39, 493, DateTimeKind.Unspecified).AddTicks(1451), 4L, "Et cum inventore qui hic repellat.\nSit ipsum et.\nCorporis aut officia.\nUt quo eos.", false, false, 16L, "Sit provident numquam qui illum quibusdam fuga quis sed." },
                    { 48L, new DateTime(2021, 8, 10, 17, 1, 5, 802, DateTimeKind.Unspecified).AddTicks(9842), 1L, "Quod quia voluptatem molestias facere.\nUllam eius corporis eius incidunt et omnis est eum.\nNihil quo ut fugiat occaecati dolor quod sint assumenda sed.", false, false, 19L, "Voluptatem vel sit debitis ullam tempore aperiam sit qui consequatur." },
                    { 49L, new DateTime(2021, 12, 18, 10, 13, 19, 725, DateTimeKind.Unspecified).AddTicks(8611), 5L, "Ea rerum mollitia aut qui itaque.", false, true, 30L, "Quos dignissimos ut ut nulla ducimus ex." },
                    { 50L, new DateTime(2021, 9, 4, 8, 0, 56, 372, DateTimeKind.Unspecified).AddTicks(405), 4L, "Quasi a dicta qui est quod et voluptatem.\nMaiores laudantium et rerum molestiae voluptatum.\nAmet rerum suscipit fugiat autem tempora quas aut.\nExpedita accusantium placeat ea iure praesentium aspernatur dolorum iusto aliquid.", false, true, 42L, "Officiis laudantium eligendi fugiat sapiente eum ut." },
                    { 51L, new DateTime(2021, 2, 5, 23, 23, 12, 898, DateTimeKind.Unspecified).AddTicks(3916), 5L, "Maxime perferendis et voluptas voluptas blanditiis beatae itaque aperiam.", false, false, 4L, "Eos consequatur velit vero distinctio non incidunt ut eius." }
                });

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
                    { 14L, 14L, 2L, new DateTime(2021, 10, 5, 6, 37, 43, 438, DateTimeKind.Unspecified).AddTicks(8707), 4L, 5L, false },
                    { 13L, 16L, 1L, new DateTime(2021, 4, 15, 8, 17, 47, 623, DateTimeKind.Unspecified).AddTicks(4057), 3L, 63L, false },
                    { 18L, 16L, 1L, new DateTime(2021, 8, 10, 18, 38, 50, 251, DateTimeKind.Unspecified).AddTicks(3629), 2L, 28L, false },
                    { 4L, 17L, 2L, new DateTime(2021, 7, 20, 4, 47, 34, 790, DateTimeKind.Unspecified).AddTicks(5049), 3L, 23L, false },
                    { 4L, 18L, 1L, new DateTime(2022, 1, 24, 19, 46, 48, 339, DateTimeKind.Unspecified).AddTicks(3235), 3L, 6L, false },
                    { 9L, 18L, 1L, new DateTime(2021, 4, 21, 4, 0, 25, 555, DateTimeKind.Unspecified).AddTicks(7992), 1L, 56L, false },
                    { 12L, 19L, 2L, new DateTime(2021, 12, 23, 11, 37, 43, 862, DateTimeKind.Unspecified).AddTicks(9497), 5L, 47L, false },
                    { 11L, 22L, 2L, new DateTime(2021, 11, 16, 10, 27, 40, 65, DateTimeKind.Unspecified).AddTicks(5522), 4L, 15L, false },
                    { 18L, 22L, 2L, new DateTime(2021, 5, 21, 14, 57, 58, 56, DateTimeKind.Unspecified).AddTicks(9730), 1L, 9L, false },
                    { 17L, 23L, 1L, new DateTime(2021, 10, 6, 20, 38, 10, 263, DateTimeKind.Unspecified).AddTicks(6665), 5L, 16L, false },
                    { 3L, 24L, 1L, new DateTime(2021, 7, 5, 22, 20, 13, 980, DateTimeKind.Unspecified).AddTicks(6451), 5L, 65L, false },
                    { 11L, 26L, 2L, new DateTime(2021, 7, 23, 8, 21, 33, 182, DateTimeKind.Unspecified).AddTicks(5122), 5L, 48L, false },
                    { 5L, 28L, 2L, new DateTime(2021, 3, 15, 9, 44, 53, 476, DateTimeKind.Unspecified).AddTicks(8572), 4L, 22L, false },
                    { 8L, 29L, 2L, new DateTime(2021, 8, 21, 8, 49, 40, 229, DateTimeKind.Unspecified).AddTicks(7695), 5L, 8L, false },
                    { 6L, 30L, 1L, new DateTime(2021, 8, 26, 17, 35, 57, 100, DateTimeKind.Unspecified).AddTicks(5535), 3L, 50L, false },
                    { 16L, 31L, 1L, new DateTime(2021, 4, 27, 6, 41, 20, 182, DateTimeKind.Unspecified).AddTicks(2938), 3L, 68L, false },
                    { 20L, 31L, 2L, new DateTime(2021, 11, 4, 12, 39, 38, 211, DateTimeKind.Unspecified).AddTicks(605), 1L, 34L, false },
                    { 15L, 35L, 2L, new DateTime(2021, 7, 1, 3, 38, 49, 336, DateTimeKind.Unspecified).AddTicks(339), 4L, 62L, false },
                    { 18L, 35L, 2L, new DateTime(2021, 7, 20, 4, 45, 21, 302, DateTimeKind.Unspecified).AddTicks(9971), 2L, 52L, false },
                    { 20L, 35L, 1L, new DateTime(2021, 6, 10, 22, 44, 31, 652, DateTimeKind.Unspecified).AddTicks(8842), 2L, 59L, false },
                    { 11L, 36L, 1L, new DateTime(2021, 10, 31, 2, 12, 31, 597, DateTimeKind.Unspecified).AddTicks(7107), 2L, 54L, false },
                    { 4L, 38L, 2L, new DateTime(2021, 6, 17, 9, 25, 1, 251, DateTimeKind.Unspecified).AddTicks(8608), 1L, 4L, false },
                    { 16L, 38L, 1L, new DateTime(2021, 8, 28, 7, 0, 26, 993, DateTimeKind.Unspecified).AddTicks(3744), 2L, 57L, false },
                    { 4L, 40L, 1L, new DateTime(2021, 5, 3, 21, 31, 43, 585, DateTimeKind.Unspecified).AddTicks(6876), 2L, 14L, false }
                });

            migrationBuilder.InsertData(
                table: "CourseUsers",
                columns: new[] { "CourseId", "UserId", "CourseRoleId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
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
                    { 21L, 49L, 2L, new DateTime(2022, 1, 22, 23, 47, 7, 731, DateTimeKind.Unspecified).AddTicks(6075), 5L, 2L, false },
                    { 3L, 50L, 1L, new DateTime(2021, 5, 22, 22, 4, 21, 314, DateTimeKind.Unspecified).AddTicks(6392), 5L, 24L, false },
                    { 4L, 50L, 1L, new DateTime(2021, 7, 10, 22, 4, 43, 412, DateTimeKind.Unspecified).AddTicks(5680), 1L, 29L, false },
                    { 21L, 50L, 2L, new DateTime(2021, 10, 22, 7, 17, 49, 587, DateTimeKind.Unspecified).AddTicks(1967), 5L, 42L, false },
                    { 3L, 51L, 2L, new DateTime(2021, 8, 10, 16, 21, 41, 370, DateTimeKind.Unspecified).AddTicks(6258), 4L, 46L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 2L, 24L, new DateTime(2021, 12, 19, 14, 38, 25, 212, DateTimeKind.Unspecified).AddTicks(6400), 3L, 88L, false },
                    { 3L, 6L, new DateTime(2021, 12, 11, 11, 42, 43, 866, DateTimeKind.Unspecified).AddTicks(1104), 5L, 11L, false },
                    { 3L, 24L, new DateTime(2021, 5, 25, 3, 45, 16, 466, DateTimeKind.Unspecified).AddTicks(2618), 5L, 48L, false },
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
                    { 9L, 10L, new DateTime(2021, 12, 27, 17, 22, 8, 61, DateTimeKind.Unspecified).AddTicks(5576), 4L, 61L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 9L, 18L, new DateTime(2021, 2, 20, 5, 39, 9, 896, DateTimeKind.Unspecified).AddTicks(8323), 4L, 49L, false },
                    { 9L, 24L, new DateTime(2021, 3, 25, 23, 49, 18, 970, DateTimeKind.Unspecified).AddTicks(1232), 1L, 95L, false },
                    { 9L, 30L, new DateTime(2021, 3, 22, 14, 5, 25, 599, DateTimeKind.Unspecified).AddTicks(9205), 1L, 94L, false },
                    { 10L, 10L, new DateTime(2021, 7, 2, 7, 45, 20, 253, DateTimeKind.Unspecified).AddTicks(5208), 5L, 59L, false },
                    { 12L, 6L, new DateTime(2021, 10, 16, 23, 5, 22, 666, DateTimeKind.Unspecified).AddTicks(3768), 2L, 10L, false },
                    { 12L, 13L, new DateTime(2021, 10, 25, 15, 40, 30, 663, DateTimeKind.Unspecified).AddTicks(3661), 5L, 67L, false },
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
                    { 19L, 24L, new DateTime(2021, 9, 13, 0, 31, 39, 244, DateTimeKind.Unspecified).AddTicks(3362), 4L, 77L, false },
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
                    { 31L, 20L, new DateTime(2021, 7, 23, 9, 5, 22, 78, DateTimeKind.Unspecified).AddTicks(7350), 3L, 34L, false }
                });

            migrationBuilder.InsertData(
                table: "InvitedUsers",
                columns: new[] { "ProjectId", "UserId", "CreatedAt", "CreatedBy", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 31L, 38L, new DateTime(2021, 11, 11, 11, 58, 57, 329, DateTimeKind.Unspecified).AddTicks(7505), 4L, 14L, false },
                    { 32L, 20L, new DateTime(2021, 4, 7, 14, 52, 44, 779, DateTimeKind.Unspecified).AddTicks(9756), 4L, 18L, false },
                    { 33L, 4L, new DateTime(2021, 4, 25, 19, 9, 2, 861, DateTimeKind.Unspecified).AddTicks(8901), 3L, 68L, false },
                    { 33L, 9L, new DateTime(2021, 5, 12, 13, 48, 31, 243, DateTimeKind.Unspecified).AddTicks(2413), 5L, 57L, false },
                    { 33L, 20L, new DateTime(2021, 2, 24, 16, 3, 53, 110, DateTimeKind.Unspecified).AddTicks(2357), 5L, 71L, false },
                    { 33L, 24L, new DateTime(2021, 3, 20, 20, 59, 16, 459, DateTimeKind.Unspecified).AddTicks(7765), 1L, 97L, false },
                    { 34L, 3L, new DateTime(2021, 9, 25, 6, 45, 29, 520, DateTimeKind.Unspecified).AddTicks(4306), 2L, 5L, false },
                    { 34L, 42L, new DateTime(2021, 9, 30, 18, 8, 31, 268, DateTimeKind.Unspecified).AddTicks(9933), 1L, 47L, false },
                    { 34L, 45L, new DateTime(2021, 4, 17, 7, 39, 16, 282, DateTimeKind.Unspecified).AddTicks(3305), 2L, 44L, false },
                    { 35L, 8L, new DateTime(2021, 5, 17, 11, 30, 37, 569, DateTimeKind.Unspecified).AddTicks(9490), 2L, 73L, false },
                    { 35L, 25L, new DateTime(2021, 12, 20, 21, 35, 51, 495, DateTimeKind.Unspecified).AddTicks(1457), 4L, 100L, false },
                    { 35L, 40L, new DateTime(2021, 6, 26, 14, 40, 30, 344, DateTimeKind.Unspecified).AddTicks(8118), 1L, 26L, false },
                    { 36L, 51L, new DateTime(2021, 9, 14, 6, 2, 4, 638, DateTimeKind.Unspecified).AddTicks(386), 4L, 41L, false },
                    { 37L, 27L, new DateTime(2021, 4, 12, 22, 2, 20, 25, DateTimeKind.Unspecified).AddTicks(2145), 2L, 15L, false },
                    { 37L, 31L, new DateTime(2022, 1, 19, 12, 10, 3, 797, DateTimeKind.Unspecified).AddTicks(5500), 3L, 40L, false },
                    { 37L, 32L, new DateTime(2021, 5, 16, 23, 32, 14, 600, DateTimeKind.Unspecified).AddTicks(5432), 1L, 7L, false },
                    { 38L, 16L, new DateTime(2022, 1, 11, 10, 34, 7, 119, DateTimeKind.Unspecified).AddTicks(958), 4L, 16L, false },
                    { 38L, 42L, new DateTime(2021, 10, 15, 6, 34, 59, 33, DateTimeKind.Unspecified).AddTicks(2043), 5L, 66L, false },
                    { 39L, 40L, new DateTime(2021, 10, 18, 23, 43, 7, 24, DateTimeKind.Unspecified).AddTicks(4841), 4L, 70L, false },
                    { 39L, 50L, new DateTime(2021, 10, 31, 17, 33, 36, 835, DateTimeKind.Unspecified).AddTicks(6936), 1L, 64L, false },
                    { 41L, 50L, new DateTime(2021, 3, 7, 6, 46, 46, 659, DateTimeKind.Unspecified).AddTicks(7829), 3L, 52L, false },
                    { 42L, 23L, new DateTime(2021, 5, 15, 16, 34, 48, 200, DateTimeKind.Unspecified).AddTicks(5567), 3L, 82L, false },
                    { 42L, 42L, new DateTime(2021, 3, 16, 4, 8, 58, 289, DateTimeKind.Unspecified).AddTicks(9726), 5L, 101L, false },
                    { 43L, 35L, new DateTime(2021, 4, 19, 23, 12, 35, 280, DateTimeKind.Unspecified).AddTicks(4054), 5L, 99L, false },
                    { 43L, 45L, new DateTime(2021, 9, 8, 9, 20, 27, 744, DateTimeKind.Unspecified).AddTicks(7544), 2L, 84L, false },
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

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsDeleted", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[,]
                {
                    { 3L, 24L, new DateTime(2021, 6, 14, 18, 29, 32, 451, DateTimeKind.Unspecified).AddTicks(8937), 4L, 1000, false, false, null, 40L, 369 },
                    { 4L, 9L, new DateTime(2021, 8, 3, 4, 27, 11, 745, DateTimeKind.Unspecified).AddTicks(7199), 5L, 949, false, false, null, 38L, 474 },
                    { 8L, 47L, new DateTime(2021, 5, 6, 6, 58, 49, 512, DateTimeKind.Unspecified).AddTicks(282), 1L, 916, false, true, null, 34L, 365 }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsDeleted", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[,]
                {
                    { 10L, 15L, new DateTime(2021, 7, 12, 6, 30, 27, 386, DateTimeKind.Unspecified).AddTicks(9206), 3L, 759, false, false, null, 51L, 473 },
                    { 11L, 8L, new DateTime(2021, 12, 29, 9, 9, 5, 46, DateTimeKind.Unspecified).AddTicks(4253), 5L, 884, false, true, null, 36L, 426 },
                    { 12L, 37L, new DateTime(2021, 12, 10, 18, 51, 30, 372, DateTimeKind.Unspecified).AddTicks(2051), 5L, 778, false, true, null, 43L, 122 },
                    { 13L, 13L, new DateTime(2021, 6, 27, 13, 24, 58, 306, DateTimeKind.Unspecified).AddTicks(7484), 5L, 791, false, true, null, 35L, 250 },
                    { 15L, 23L, new DateTime(2021, 4, 29, 18, 43, 39, 630, DateTimeKind.Unspecified).AddTicks(4412), 3L, 589, false, true, null, 13L, 62 },
                    { 16L, 32L, new DateTime(2021, 8, 26, 23, 16, 4, 80, DateTimeKind.Unspecified).AddTicks(3995), 1L, 643, false, true, null, 41L, 132 },
                    { 20L, 36L, new DateTime(2022, 1, 8, 3, 23, 10, 141, DateTimeKind.Unspecified).AddTicks(2887), 2L, 906, false, false, null, 16L, 403 },
                    { 21L, 31L, new DateTime(2021, 6, 29, 5, 1, 19, 676, DateTimeKind.Unspecified).AddTicks(6768), 1L, 960, false, true, null, 34L, 117 },
                    { 22L, 48L, new DateTime(2021, 3, 14, 21, 10, 47, 585, DateTimeKind.Unspecified).AddTicks(565), 2L, 904, false, true, null, 19L, 86 },
                    { 23L, 17L, new DateTime(2022, 1, 28, 12, 29, 50, 770, DateTimeKind.Unspecified).AddTicks(6738), 5L, 915, false, true, null, 3L, 114 },
                    { 24L, 37L, new DateTime(2021, 10, 11, 22, 47, 33, 344, DateTimeKind.Unspecified).AddTicks(8780), 3L, 515, false, true, null, 2L, 349 },
                    { 29L, 15L, new DateTime(2021, 9, 9, 8, 35, 3, 427, DateTimeKind.Unspecified).AddTicks(1220), 2L, 662, false, false, null, 39L, 479 },
                    { 30L, 47L, new DateTime(2021, 8, 30, 5, 36, 12, 623, DateTimeKind.Unspecified).AddTicks(5230), 3L, 977, false, true, null, 16L, 281 },
                    { 32L, 41L, new DateTime(2021, 11, 22, 1, 0, 54, 746, DateTimeKind.Unspecified).AddTicks(3822), 3L, 716, false, true, null, 15L, 326 },
                    { 33L, 44L, new DateTime(2021, 12, 30, 6, 31, 47, 599, DateTimeKind.Unspecified).AddTicks(4407), 3L, 850, false, true, null, 29L, 394 },
                    { 34L, 33L, new DateTime(2021, 7, 22, 8, 9, 25, 122, DateTimeKind.Unspecified).AddTicks(5704), 1L, 859, false, true, null, 41L, 60 },
                    { 37L, 39L, new DateTime(2021, 2, 2, 1, 48, 37, 773, DateTimeKind.Unspecified).AddTicks(5419), 1L, 901, false, true, null, 30L, 497 },
                    { 38L, 8L, new DateTime(2021, 4, 14, 10, 50, 14, 746, DateTimeKind.Unspecified).AddTicks(747), 2L, 595, false, false, null, 7L, 211 },
                    { 41L, 18L, new DateTime(2022, 1, 26, 18, 45, 51, 417, DateTimeKind.Unspecified).AddTicks(7369), 3L, 823, false, false, null, 11L, 270 },
                    { 43L, 36L, new DateTime(2021, 11, 20, 20, 26, 47, 629, DateTimeKind.Unspecified).AddTicks(2679), 1L, 753, false, true, null, 27L, 132 },
                    { 45L, 33L, new DateTime(2021, 9, 2, 14, 9, 27, 214, DateTimeKind.Unspecified).AddTicks(6632), 1L, 676, false, false, null, 34L, 393 },
                    { 46L, 49L, new DateTime(2022, 1, 11, 16, 47, 28, 760, DateTimeKind.Unspecified).AddTicks(6241), 3L, 704, false, true, null, 40L, 392 },
                    { 49L, 10L, new DateTime(2021, 4, 22, 22, 50, 1, 204, DateTimeKind.Unspecified).AddTicks(2250), 2L, 754, false, true, null, 44L, 365 },
                    { 51L, 9L, new DateTime(2021, 12, 12, 14, 31, 53, 412, DateTimeKind.Unspecified).AddTicks(6728), 5L, 652, false, true, null, 5L, 318 },
                    { 52L, 3L, new DateTime(2021, 3, 2, 5, 55, 2, 703, DateTimeKind.Unspecified).AddTicks(7750), 5L, 621, false, false, null, 29L, 37 },
                    { 55L, 33L, new DateTime(2022, 1, 30, 7, 20, 40, 755, DateTimeKind.Unspecified).AddTicks(473), 1L, 961, false, true, null, 31L, 42 },
                    { 57L, 29L, new DateTime(2021, 12, 22, 19, 51, 8, 849, DateTimeKind.Unspecified).AddTicks(3167), 2L, 677, false, true, null, 43L, 393 },
                    { 59L, 47L, new DateTime(2022, 1, 6, 17, 17, 47, 306, DateTimeKind.Unspecified).AddTicks(9871), 4L, 547, false, false, null, 14L, 486 },
                    { 62L, 16L, new DateTime(2021, 12, 22, 0, 2, 9, 424, DateTimeKind.Unspecified).AddTicks(5244), 5L, 665, false, false, null, 11L, 40 },
                    { 73L, 51L, new DateTime(2021, 5, 17, 3, 47, 5, 14, DateTimeKind.Unspecified).AddTicks(4962), 3L, 959, false, true, null, 6L, 446 },
                    { 74L, 22L, new DateTime(2021, 12, 4, 17, 57, 16, 97, DateTimeKind.Unspecified).AddTicks(2378), 5L, 818, false, false, null, 28L, 465 },
                    { 76L, 7L, new DateTime(2021, 4, 11, 21, 11, 45, 348, DateTimeKind.Unspecified).AddTicks(1308), 3L, 682, false, false, null, 36L, 51 },
                    { 80L, 7L, new DateTime(2021, 6, 3, 20, 56, 11, 117, DateTimeKind.Unspecified).AddTicks(9935), 5L, 999, false, false, null, 7L, 215 }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 2L, 11L, new DateTime(2021, 12, 23, 11, 26, 13, 957, DateTimeKind.Unspecified).AddTicks(2165), 4L, false, "Ipsum dolores nam." },
                    { 3L, 18L, new DateTime(2021, 11, 4, 18, 26, 2, 495, DateTimeKind.Unspecified).AddTicks(360), 3L, false, "Blanditiis laudantium et et delectus." },
                    { 4L, 8L, new DateTime(2021, 10, 24, 8, 55, 46, 551, DateTimeKind.Unspecified).AddTicks(9429), 3L, false, "Enim qui dolore debitis aut impedit et recusandae." },
                    { 5L, 4L, new DateTime(2021, 9, 26, 13, 29, 0, 514, DateTimeKind.Unspecified).AddTicks(7689), 1L, false, "Rerum itaque vitae aspernatur distinctio ullam numquam quod ut labore." },
                    { 6L, 6L, new DateTime(2021, 12, 6, 12, 14, 17, 556, DateTimeKind.Unspecified).AddTicks(1013), 4L, false, "Consectetur quas sequi dicta." },
                    { 7L, 5L, new DateTime(2021, 4, 3, 2, 30, 27, 405, DateTimeKind.Unspecified).AddTicks(2736), 2L, false, "Nobis officia impedit ut ipsa praesentium harum minus." },
                    { 8L, 6L, new DateTime(2021, 9, 11, 10, 8, 13, 533, DateTimeKind.Unspecified).AddTicks(2349), 3L, false, "Molestias non quisquam assumenda corporis unde." },
                    { 9L, 18L, new DateTime(2021, 2, 3, 22, 26, 35, 27, DateTimeKind.Unspecified).AddTicks(2206), 3L, false, "Cum voluptatem non." },
                    { 10L, 7L, new DateTime(2021, 12, 25, 8, 34, 28, 94, DateTimeKind.Unspecified).AddTicks(8252), 4L, false, "Ut ipsam omnis temporibus ut aliquam quos iure quia." }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 11L, 9L, new DateTime(2021, 6, 6, 11, 36, 54, 289, DateTimeKind.Unspecified).AddTicks(2898), 4L, false, "Dicta officiis voluptatem ut nobis nam repellendus." },
                    { 12L, 20L, new DateTime(2021, 2, 19, 10, 33, 36, 944, DateTimeKind.Unspecified).AddTicks(1236), 4L, false, "Et veniam est voluptates natus perferendis tempora." },
                    { 13L, 9L, new DateTime(2021, 2, 20, 10, 40, 8, 774, DateTimeKind.Unspecified).AddTicks(1450), 4L, false, "Hic veniam deserunt et enim tempora vel dolor nostrum praesentium." },
                    { 14L, 4L, new DateTime(2021, 6, 26, 4, 38, 29, 153, DateTimeKind.Unspecified).AddTicks(8745), 5L, false, "Necessitatibus iste magni at non reprehenderit qui expedita ipsa." },
                    { 15L, 20L, new DateTime(2021, 9, 16, 20, 43, 41, 644, DateTimeKind.Unspecified).AddTicks(8908), 5L, false, "Eum aut doloremque consequatur totam nam dolorem." },
                    { 16L, 7L, new DateTime(2021, 5, 22, 11, 5, 22, 593, DateTimeKind.Unspecified).AddTicks(8566), 3L, false, "Reprehenderit iste consequatur id consequatur ab." },
                    { 17L, 3L, new DateTime(2021, 7, 13, 0, 22, 29, 979, DateTimeKind.Unspecified).AddTicks(9243), 3L, false, "Libero blanditiis explicabo." },
                    { 18L, 13L, new DateTime(2021, 10, 29, 19, 57, 0, 284, DateTimeKind.Unspecified).AddTicks(4656), 1L, false, "Exercitationem labore blanditiis aliquam libero facilis." },
                    { 19L, 15L, new DateTime(2021, 3, 30, 0, 8, 6, 926, DateTimeKind.Unspecified).AddTicks(8703), 2L, false, "Recusandae fugit dolor debitis voluptates dolor est laudantium." },
                    { 20L, 5L, new DateTime(2021, 2, 25, 18, 1, 10, 929, DateTimeKind.Unspecified).AddTicks(3578), 4L, false, "Asperiores aut deleniti et deleniti." },
                    { 21L, 20L, new DateTime(2021, 7, 22, 8, 24, 49, 5, DateTimeKind.Unspecified).AddTicks(9120), 3L, false, "Eaque aut cumque harum id molestiae amet est." },
                    { 22L, 20L, new DateTime(2021, 4, 30, 18, 11, 39, 101, DateTimeKind.Unspecified).AddTicks(4488), 2L, false, "In quia reprehenderit." },
                    { 23L, 2L, new DateTime(2021, 7, 8, 10, 42, 58, 973, DateTimeKind.Unspecified).AddTicks(3426), 2L, false, "Ea fuga est ipsum dolorum." },
                    { 24L, 6L, new DateTime(2021, 11, 1, 10, 21, 36, 515, DateTimeKind.Unspecified).AddTicks(7236), 1L, false, "Omnis neque qui quam voluptas non saepe aut vitae." },
                    { 25L, 3L, new DateTime(2021, 11, 2, 13, 12, 24, 731, DateTimeKind.Unspecified).AddTicks(4350), 5L, false, "Quod maxime itaque ipsam sit mollitia natus." },
                    { 26L, 14L, new DateTime(2021, 9, 26, 5, 41, 54, 129, DateTimeKind.Unspecified).AddTicks(6572), 3L, false, "Quis non aspernatur ut recusandae beatae." },
                    { 27L, 10L, new DateTime(2021, 4, 3, 2, 9, 44, 356, DateTimeKind.Unspecified).AddTicks(911), 2L, false, "Sapiente placeat inventore fugit dolor totam." },
                    { 28L, 15L, new DateTime(2021, 3, 5, 9, 45, 56, 863, DateTimeKind.Unspecified).AddTicks(7594), 4L, false, "Officia accusantium ut rerum doloremque ut nemo qui est aut." },
                    { 29L, 17L, new DateTime(2021, 3, 17, 19, 43, 0, 459, DateTimeKind.Unspecified).AddTicks(8915), 5L, false, "Ab quibusdam fugiat et beatae alias dolorum cum ut aspernatur." },
                    { 30L, 5L, new DateTime(2021, 4, 12, 3, 2, 27, 326, DateTimeKind.Unspecified).AddTicks(1422), 2L, false, "In magni magni impedit." },
                    { 31L, 18L, new DateTime(2021, 9, 30, 2, 59, 16, 951, DateTimeKind.Unspecified).AddTicks(1136), 5L, false, "Et non labore cumque est." },
                    { 32L, 18L, new DateTime(2021, 3, 6, 23, 12, 35, 177, DateTimeKind.Unspecified).AddTicks(7305), 2L, false, "Amet fugiat inventore et maiores quidem et corporis." },
                    { 33L, 4L, new DateTime(2021, 7, 27, 16, 18, 5, 613, DateTimeKind.Unspecified).AddTicks(9203), 3L, false, "Et odit aperiam aliquid." },
                    { 34L, 18L, new DateTime(2021, 7, 13, 1, 40, 25, 434, DateTimeKind.Unspecified).AddTicks(9528), 5L, false, "Reiciendis fuga facilis amet nihil dolorem dolorum reprehenderit autem incidunt." },
                    { 35L, 8L, new DateTime(2021, 10, 8, 9, 2, 45, 583, DateTimeKind.Unspecified).AddTicks(1444), 3L, false, "Deserunt neque qui dolores velit quos." },
                    { 36L, 16L, new DateTime(2021, 11, 25, 3, 25, 51, 16, DateTimeKind.Unspecified).AddTicks(6181), 3L, false, "Ut eius dolorem odit sed ut nam vel voluptas laudantium." },
                    { 37L, 10L, new DateTime(2021, 3, 21, 4, 16, 40, 456, DateTimeKind.Unspecified).AddTicks(2450), 3L, false, "Commodi qui sit velit molestiae animi unde beatae similique." },
                    { 38L, 7L, new DateTime(2021, 10, 1, 6, 21, 38, 31, DateTimeKind.Unspecified).AddTicks(4332), 3L, false, "Aut aut accusantium unde sunt corporis id." },
                    { 39L, 2L, new DateTime(2021, 2, 21, 12, 47, 33, 557, DateTimeKind.Unspecified).AddTicks(5873), 5L, false, "Amet doloremque similique iusto quas explicabo rerum." },
                    { 40L, 13L, new DateTime(2021, 4, 10, 20, 40, 12, 158, DateTimeKind.Unspecified).AddTicks(1171), 2L, false, "Deserunt rem et deleniti porro ea qui et ea." },
                    { 41L, 11L, new DateTime(2021, 11, 12, 10, 3, 33, 221, DateTimeKind.Unspecified).AddTicks(9811), 3L, false, "Quis corporis sint dolorem quaerat qui officia debitis." }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsDeleted", "IsPublished", "Title", "UnitId" },
                values: new object[,]
                {
                    { 2L, 9L, new DateTime(2021, 5, 4, 21, 1, 16, 850, DateTimeKind.Unspecified).AddTicks(3929), 5L, "Explicabo qui vel laudantium eum itaque sint.\nNumquam debitis veritatis sed dolor voluptatum est cupiditate ea.\nAut ut optio culpa nobis dolore dolore sit dolorum fugit.", new DateTime(2022, 12, 17, 12, 30, 48, 32, DateTimeKind.Unspecified).AddTicks(6445), false, true, "Aperiam fugit in rem repellendus deleniti eveniet officia sed esse.", 13L },
                    { 3L, 4L, new DateTime(2021, 10, 12, 18, 16, 19, 957, DateTimeKind.Unspecified).AddTicks(971), 2L, "Officia quis nobis nesciunt ab autem exercitationem.", new DateTime(2022, 9, 15, 17, 35, 2, 636, DateTimeKind.Unspecified).AddTicks(1537), false, true, "Tempore quasi consequuntur.", 14L },
                    { 4L, 17L, new DateTime(2021, 2, 18, 15, 24, 17, 238, DateTimeKind.Unspecified).AddTicks(8728), 4L, "Maiores iure odit qui rerum ea.\nQui ut nulla.\nVel voluptas eveniet non adipisci accusamus rerum.\nEa veritatis repellat sit et.\nConsequatur iste est recusandae.", new DateTime(2023, 11, 26, 2, 5, 15, 878, DateTimeKind.Unspecified).AddTicks(2070), false, true, "Molestiae excepturi ut dolores eius est voluptatem.", 29L },
                    { 5L, 20L, new DateTime(2021, 8, 22, 19, 19, 31, 764, DateTimeKind.Unspecified).AddTicks(4136), 2L, "Et quis earum ut omnis aut in.\nDoloribus quia blanditiis nostrum sint.", new DateTime(2023, 10, 13, 3, 53, 21, 594, DateTimeKind.Unspecified).AddTicks(3086), false, false, "Rerum et velit et id et asperiores praesentium id.", 15L },
                    { 6L, 14L, new DateTime(2021, 10, 20, 14, 55, 43, 543, DateTimeKind.Unspecified).AddTicks(7617), 2L, "Alias quisquam repudiandae a.\nEarum in asperiores natus quidem eius eum animi impedit.\nCorrupti harum saepe inventore ad ea libero.\nQui laborum modi.", new DateTime(2022, 12, 3, 16, 53, 48, 103, DateTimeKind.Unspecified).AddTicks(849), false, false, "Quis velit omnis magnam rerum voluptatum ea.", 26L },
                    { 7L, 5L, new DateTime(2022, 1, 2, 1, 24, 18, 355, DateTimeKind.Unspecified).AddTicks(2652), 5L, "Assumenda consequatur quia non est quos adipisci.\nIpsam qui ut occaecati quod suscipit nihil occaecati ut.\nCupiditate temporibus corporis nesciunt aliquid et repellendus.\nEst beatae hic ullam ratione voluptatem.\nDebitis ut sed ad in.", new DateTime(2022, 12, 28, 20, 52, 58, 832, DateTimeKind.Unspecified).AddTicks(1324), false, true, "Non maiores atque ut sit placeat et.", 30L },
                    { 8L, 18L, new DateTime(2021, 5, 6, 21, 4, 26, 13, DateTimeKind.Unspecified).AddTicks(7604), 2L, "Eum qui modi est.\nMolestias nihil eum assumenda sed vel.\nIusto adipisci quia.\nIusto et dolore rerum explicabo mollitia quis autem architecto.\nEx nihil sint architecto ullam molestiae ipsam earum.", new DateTime(2023, 8, 16, 17, 40, 13, 846, DateTimeKind.Unspecified).AddTicks(932), false, false, "Beatae rem est dolor voluptatem.", 32L },
                    { 9L, 13L, new DateTime(2021, 8, 11, 3, 55, 56, 228, DateTimeKind.Unspecified).AddTicks(1913), 4L, "Ipsa aut temporibus assumenda pariatur provident vel voluptatem porro.\nEligendi qui rerum cumque quos molestiae.", new DateTime(2024, 1, 10, 14, 36, 47, 666, DateTimeKind.Unspecified).AddTicks(8403), false, true, "Quasi nesciunt ullam fugit quasi ut veritatis ut est numquam.", 40L },
                    { 10L, 18L, new DateTime(2021, 4, 12, 14, 25, 8, 63, DateTimeKind.Unspecified).AddTicks(3524), 3L, "Nostrum aut enim eos sit voluptatem.", new DateTime(2022, 8, 19, 14, 50, 45, 923, DateTimeKind.Unspecified).AddTicks(1268), false, false, "Iusto architecto quaerat.", 32L },
                    { 11L, 3L, new DateTime(2021, 9, 10, 4, 52, 45, 31, DateTimeKind.Unspecified).AddTicks(6708), 3L, "Occaecati exercitationem architecto.\nAliquid optio officia.\nEt vero repudiandae sequi fugiat et minus.", new DateTime(2022, 12, 12, 3, 7, 31, 318, DateTimeKind.Unspecified).AddTicks(9413), false, true, "Et quaerat id totam voluptatum incidunt consequatur est quidem recusandae.", 17L },
                    { 12L, 7L, new DateTime(2021, 12, 25, 14, 52, 32, 541, DateTimeKind.Unspecified).AddTicks(9008), 2L, "Temporibus et vero velit placeat harum quod eius ut dolores.\nNisi ducimus quidem cum dolores earum fugit adipisci in.\nEligendi est et.\nNam vel aspernatur natus necessitatibus.\nSed quae dolore quae corporis debitis incidunt voluptates vel.", new DateTime(2023, 9, 3, 20, 14, 30, 284, DateTimeKind.Unspecified).AddTicks(8863), false, true, "Eos impedit quam ut mollitia doloremque quidem est et.", 16L },
                    { 13L, 13L, new DateTime(2021, 9, 30, 1, 54, 36, 400, DateTimeKind.Unspecified).AddTicks(2430), 3L, "Dicta magnam rerum expedita nisi tempore omnis ullam sed.\nAutem et impedit sed vel est eum.\nEx voluptas repellat eligendi quae dolor accusantium.", new DateTime(2022, 6, 24, 18, 37, 33, 353, DateTimeKind.Unspecified).AddTicks(3289), false, false, "Suscipit et provident optio dolores praesentium totam ut explicabo consequatur.", 40L },
                    { 14L, 10L, new DateTime(2021, 10, 15, 1, 34, 56, 869, DateTimeKind.Unspecified).AddTicks(7262), 5L, "Omnis et assumenda maxime unde sint maiores nostrum.\nEos architecto unde.\nExplicabo quo reprehenderit quia laudantium harum.\nUt consequatur quisquam eos.\nAut neque ipsam vel illum blanditiis enim maxime.", new DateTime(2023, 6, 27, 4, 57, 7, 866, DateTimeKind.Unspecified).AddTicks(6967), false, false, "Blanditiis qui dolorem natus voluptatem occaecati.", 27L },
                    { 15L, 3L, new DateTime(2022, 1, 30, 14, 35, 13, 170, DateTimeKind.Unspecified).AddTicks(8732), 1L, "Ea eaque ea natus et.\nNobis necessitatibus expedita enim maxime.\nEt aut nam facere tempore.\nVoluptatem ea voluptas et facere voluptatem et totam et fugiat.", new DateTime(2023, 2, 16, 8, 13, 33, 156, DateTimeKind.Unspecified).AddTicks(9121), false, true, "Non aperiam nam.", 25L },
                    { 16L, 13L, new DateTime(2021, 3, 4, 1, 41, 47, 512, DateTimeKind.Unspecified).AddTicks(6408), 5L, "Quam dicta iure doloremque officia sit velit delectus ea.\nQuia in enim et animi veniam eaque.\nSapiente ducimus pariatur consequatur quisquam repellat animi laboriosam.", new DateTime(2022, 9, 17, 23, 7, 5, 262, DateTimeKind.Unspecified).AddTicks(1994), false, false, "Nulla aut facere rerum.", 40L },
                    { 17L, 8L, new DateTime(2021, 3, 3, 8, 13, 58, 420, DateTimeKind.Unspecified).AddTicks(9071), 1L, "Consectetur maxime optio explicabo quidem natus.", new DateTime(2023, 8, 15, 1, 38, 14, 682, DateTimeKind.Unspecified).AddTicks(4533), false, false, "Harum nisi porro consequatur quis voluptatem qui impedit accusamus.", 4L },
                    { 18L, 11L, new DateTime(2021, 5, 7, 7, 8, 41, 118, DateTimeKind.Unspecified).AddTicks(732), 3L, "Dolorum sequi animi cum sequi rerum.", new DateTime(2023, 12, 4, 8, 25, 37, 91, DateTimeKind.Unspecified).AddTicks(5494), false, true, "Iure et dolore nihil sit.", 41L },
                    { 19L, 2L, new DateTime(2022, 1, 26, 13, 13, 26, 988, DateTimeKind.Unspecified).AddTicks(9931), 1L, "Voluptatem sit illum voluptatibus.\nQuo nostrum aliquid reiciendis at quasi maxime autem est.", new DateTime(2023, 8, 6, 5, 27, 33, 552, DateTimeKind.Unspecified).AddTicks(2284), false, true, "Voluptatem consequatur at facilis.", 39L },
                    { 20L, 5L, new DateTime(2021, 10, 23, 17, 29, 32, 545, DateTimeKind.Unspecified).AddTicks(1658), 2L, "Corrupti aspernatur aut tempora et ipsum vel.\nEt provident itaque saepe ut voluptas consequatur aliquam qui ut.\nQuo fuga veniam atque dolorum dolorem illo excepturi sint.", new DateTime(2023, 8, 21, 21, 39, 8, 609, DateTimeKind.Unspecified).AddTicks(8280), false, true, "Rerum perferendis voluptas rem enim itaque nulla quae culpa.", 20L },
                    { 21L, 11L, new DateTime(2021, 3, 22, 23, 5, 26, 307, DateTimeKind.Unspecified).AddTicks(5158), 5L, "Architecto eius cumque.\nDolores nihil et.", new DateTime(2023, 6, 16, 21, 26, 18, 839, DateTimeKind.Unspecified).AddTicks(3902), false, false, "Ad nulla non reiciendis et.", 41L },
                    { 22L, 5L, new DateTime(2021, 7, 2, 23, 37, 38, 531, DateTimeKind.Unspecified).AddTicks(2345), 4L, "Amet quam tempora ut et.\nMolestias sunt voluptate molestiae natus voluptates eum sunt quia.\nEt quae iste aut est.\nAb et deserunt.", new DateTime(2022, 11, 29, 11, 11, 47, 524, DateTimeKind.Unspecified).AddTicks(6999), false, true, "Et quaerat inventore placeat.", 20L },
                    { 23L, 18L, new DateTime(2021, 4, 19, 4, 27, 46, 257, DateTimeKind.Unspecified).AddTicks(9850), 4L, "Quas optio velit illum.\nRem rerum eveniet atque voluptate.\nAliquid laboriosam aut adipisci at est aspernatur consequatur nihil rerum.\nVoluptatem qui molestiae qui.\nSit nihil aliquid nihil iste enim.", new DateTime(2023, 8, 10, 15, 57, 26, 709, DateTimeKind.Unspecified).AddTicks(2334), false, false, "Sed doloremque et et.", 34L },
                    { 24L, 9L, new DateTime(2021, 10, 3, 13, 46, 15, 184, DateTimeKind.Unspecified).AddTicks(1120), 3L, "Ut laboriosam assumenda.\nSimilique numquam exercitationem vel placeat.\nBlanditiis sit laborum adipisci magni nihil.", new DateTime(2022, 12, 20, 16, 20, 56, 536, DateTimeKind.Unspecified).AddTicks(6706), false, false, "Vero optio non architecto inventore nemo dolore.", 11L },
                    { 25L, 14L, new DateTime(2021, 9, 19, 7, 0, 8, 71, DateTimeKind.Unspecified).AddTicks(5699), 4L, "Perferendis itaque enim nihil perspiciatis.\nAtque vero ea ea.", new DateTime(2023, 3, 19, 19, 13, 53, 187, DateTimeKind.Unspecified).AddTicks(9759), false, false, "Veniam temporibus similique magnam minima et reprehenderit quia sunt doloribus.", 26L },
                    { 26L, 10L, new DateTime(2021, 4, 25, 1, 15, 57, 754, DateTimeKind.Unspecified).AddTicks(4397), 5L, "Dolores repellat delectus sit dolores ex.\nAut accusantium voluptatem quo sed.\nIpsum autem aperiam numquam pariatur reprehenderit dolores molestiae modi.", new DateTime(2022, 9, 27, 20, 21, 33, 785, DateTimeKind.Unspecified).AddTicks(5868), false, true, "Libero repellat nihil aspernatur.", 37L },
                    { 27L, 4L, new DateTime(2021, 7, 17, 14, 38, 25, 188, DateTimeKind.Unspecified).AddTicks(7013), 3L, "Deleniti sed et nam.\nId ducimus pariatur quidem dolor at impedit rerum.\nAd tempore eius ut voluptatem culpa consequatur.", null, false, false, "Asperiores officia aliquam sunt qui est nihil in incidunt ut.", 14L },
                    { 28L, 3L, new DateTime(2021, 12, 21, 21, 58, 41, 323, DateTimeKind.Unspecified).AddTicks(814), 3L, "Ea beatae et voluptatem voluptas quae enim numquam.\nUnde et saepe et aperiam ea est vitae.\nEst quas et consectetur vitae dolores exercitationem ab sit dolor.", new DateTime(2023, 9, 3, 13, 55, 22, 545, DateTimeKind.Unspecified).AddTicks(541), false, false, "Libero blanditiis maiores quas necessitatibus ex.", 25L },
                    { 29L, 10L, new DateTime(2021, 11, 15, 22, 59, 21, 336, DateTimeKind.Unspecified).AddTicks(2102), 1L, "Repellat aperiam sint quam eveniet quidem aspernatur ullam nihil.\nQui earum consectetur numquam repellat libero ut minima et sunt.\nEum qui eaque omnis sint voluptas.\nTenetur vitae tempore qui.", new DateTime(2023, 9, 7, 14, 3, 12, 741, DateTimeKind.Unspecified).AddTicks(7395), false, true, "Qui id alias magnam voluptatem.", 37L },
                    { 30L, 8L, new DateTime(2021, 5, 19, 0, 53, 43, 126, DateTimeKind.Unspecified).AddTicks(2729), 3L, "Quia qui illo.\nQuasi doloremque aut blanditiis.\nIn laborum nemo aut rerum voluptatibus accusamus.\nUt nisi nostrum dolores qui excepturi voluptatem rerum qui explicabo.\nIpsam aut molestiae blanditiis.", null, false, false, "Unde vitae dolores molestiae.", 4L },
                    { 31L, 13L, new DateTime(2021, 3, 25, 22, 46, 29, 556, DateTimeKind.Unspecified).AddTicks(468), 1L, "Voluptatem qui natus et.\nAut aperiam velit.\nRecusandae nulla qui est voluptatum sequi et.\nAperiam praesentium neque consequatur laudantium nostrum deserunt qui sapiente.", new DateTime(2022, 7, 22, 16, 6, 20, 849, DateTimeKind.Unspecified).AddTicks(8891), false, true, "Ab cumque asperiores sit minima culpa maxime suscipit ut dolorem.", 40L },
                    { 32L, 11L, new DateTime(2021, 8, 28, 0, 47, 40, 552, DateTimeKind.Unspecified).AddTicks(172), 2L, "Fugit at at sunt et.\nEnim corrupti sed nihil sint iure.\nExercitationem ut est quasi est deserunt asperiores dolores.\nRerum et quibusdam.\nVeniam sed tempore laudantium qui atque itaque velit.", new DateTime(2022, 6, 9, 3, 43, 47, 362, DateTimeKind.Unspecified).AddTicks(7418), false, true, "Consequatur omnis accusamus enim ipsum sunt rerum cum.", 2L },
                    { 33L, 18L, new DateTime(2021, 12, 14, 9, 1, 41, 712, DateTimeKind.Unspecified).AddTicks(4789), 3L, "Debitis assumenda eaque.\nAliquid omnis aut eos adipisci vel id rerum doloremque qui.\nQuia tempora iusto nobis numquam in.\nEt quam et.\nVel est impedit est incidunt delectus.", new DateTime(2023, 10, 2, 8, 52, 28, 942, DateTimeKind.Unspecified).AddTicks(309), false, true, "Harum expedita aliquam quia quam sunt in nisi dignissimos et.", 32L },
                    { 34L, 10L, new DateTime(2022, 1, 5, 16, 11, 51, 668, DateTimeKind.Unspecified).AddTicks(8955), 3L, "Consequatur vel est.\nEst ut et laboriosam ut in quos.\nQuam qui est illo et qui.", new DateTime(2022, 3, 13, 5, 2, 40, 545, DateTimeKind.Unspecified).AddTicks(1177), false, true, "Laborum sit debitis optio illum sint quis sunt ut id.", 37L },
                    { 35L, 20L, new DateTime(2021, 2, 6, 11, 19, 27, 975, DateTimeKind.Unspecified).AddTicks(3106), 4L, "Voluptatem inventore eveniet veniam.\nOccaecati et delectus numquam voluptas dignissimos ad.\nRatione voluptatem praesentium sunt.\nTotam distinctio quas id necessitatibus aut consequatur.", new DateTime(2023, 10, 16, 6, 44, 40, 594, DateTimeKind.Unspecified).AddTicks(6448), false, true, "Voluptate ab et quaerat nostrum velit consequatur aliquam.", 21L },
                    { 36L, 11L, new DateTime(2022, 1, 22, 23, 46, 30, 637, DateTimeKind.Unspecified).AddTicks(591), 3L, "Cupiditate totam accusantium.\nEos ipsa aliquam dolores illum ex earum.\nQuo blanditiis temporibus repellat quisquam esse ipsum explicabo repudiandae.\nEa aliquid veniam tempora ex enim excepturi officiis.", new DateTime(2023, 2, 23, 10, 51, 14, 647, DateTimeKind.Unspecified).AddTicks(3792), false, false, "Omnis ea dolorum asperiores.", 2L },
                    { 37L, 9L, new DateTime(2021, 5, 4, 13, 45, 37, 279, DateTimeKind.Unspecified).AddTicks(6304), 5L, "Doloremque eum voluptas rerum.\nDolorem quidem velit nulla.\nTempore dolore quidem.\nVoluptatibus dolorum rerum dolorem dolorum aspernatur vel molestiae.\nConsequatur placeat sed quia perspiciatis soluta est rerum numquam.", new DateTime(2022, 12, 14, 13, 3, 24, 6, DateTimeKind.Unspecified).AddTicks(7877), false, true, "Ut debitis nulla unde ut doloremque omnis dolores.", 11L },
                    { 38L, 7L, new DateTime(2021, 10, 17, 4, 26, 11, 227, DateTimeKind.Unspecified).AddTicks(2391), 4L, "Labore neque error laborum dicta itaque sint facere.\nId deserunt qui necessitatibus libero quas sunt sint velit.\nBlanditiis illum natus ea explicabo officiis.\nEt sed consequatur fugit et at voluptate accusantium.\nNesciunt reiciendis quasi natus nihil.", new DateTime(2023, 6, 27, 10, 15, 44, 129, DateTimeKind.Unspecified).AddTicks(5438), false, true, "Et explicabo voluptatem sit itaque.", 16L },
                    { 39L, 20L, new DateTime(2021, 4, 16, 10, 45, 47, 335, DateTimeKind.Unspecified).AddTicks(1734), 4L, "Et soluta et rem quod autem iusto.\nPlaceat expedita ea quod doloribus et.\nNisi aut dignissimos quidem porro.", new DateTime(2023, 8, 8, 13, 12, 30, 977, DateTimeKind.Unspecified).AddTicks(5085), false, true, "Expedita asperiores alias maxime maiores.", 22L },
                    { 40L, 18L, new DateTime(2021, 5, 5, 6, 12, 5, 214, DateTimeKind.Unspecified).AddTicks(7048), 5L, "Sed et ex molestias sit amet ut corporis non facilis.\nIste ea voluptatum quis et.", new DateTime(2023, 11, 12, 18, 54, 19, 670, DateTimeKind.Unspecified).AddTicks(598), false, true, "Voluptas consequuntur consequatur consequatur quaerat.", 32L },
                    { 41L, 7L, new DateTime(2021, 11, 26, 2, 15, 53, 505, DateTimeKind.Unspecified).AddTicks(43), 2L, "Aut ea sunt placeat facere.\nId fugit ducimus ducimus blanditiis non laborum enim et nesciunt.\nOmnis rem fugit et voluptates provident sequi aliquid velit consectetur.\nAut sit tempore doloremque sit ex voluptatem voluptatem enim.", new DateTime(2023, 7, 19, 4, 56, 19, 281, DateTimeKind.Unspecified).AddTicks(16), false, false, "Dolorem tempore eius consequatur mollitia enim.", 38L },
                    { 42L, 6L, new DateTime(2021, 9, 10, 6, 1, 31, 998, DateTimeKind.Unspecified).AddTicks(4248), 5L, "Ipsa et et.", new DateTime(2022, 7, 12, 10, 18, 56, 157, DateTimeKind.Unspecified).AddTicks(4704), false, false, "Nostrum iste aut saepe molestiae.", 24L },
                    { 43L, 4L, new DateTime(2021, 2, 4, 5, 5, 58, 590, DateTimeKind.Unspecified).AddTicks(705), 1L, "Sit aut eum aut.\nDolor eos autem.\nExercitationem voluptate quae quasi et incidunt.\nEos quasi minima suscipit sit voluptatibus accusamus.\nDolor quidem culpa et non unde rerum.", new DateTime(2022, 10, 3, 1, 16, 2, 682, DateTimeKind.Unspecified).AddTicks(5160), false, false, "Assumenda consequatur voluptatem omnis nihil doloremque aliquam aut explicabo.", 33L }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "Description", "DueDate", "IsDeleted", "IsPublished", "Title", "UnitId" },
                values: new object[,]
                {
                    { 44L, 9L, new DateTime(2021, 6, 25, 14, 54, 19, 404, DateTimeKind.Unspecified).AddTicks(1657), 1L, "A adipisci ratione adipisci voluptatum.\nItaque illum iste.\nAperiam recusandae enim cumque consequatur animi asperiores ut nulla.", new DateTime(2022, 11, 27, 19, 17, 59, 489, DateTimeKind.Unspecified).AddTicks(3558), false, false, "Amet eligendi architecto animi nesciunt.", 11L },
                    { 45L, 8L, new DateTime(2021, 10, 8, 8, 9, 34, 791, DateTimeKind.Unspecified).AddTicks(1560), 4L, "Tempore ab molestiae rerum sint et.\nDoloribus inventore corrupti.\nIllum sunt beatae suscipit ipsam sunt veniam vitae.", new DateTime(2022, 3, 27, 5, 4, 8, 306, DateTimeKind.Unspecified).AddTicks(5407), false, false, "Et rerum qui voluptatem qui dolorem quis nesciunt modi.", 4L },
                    { 46L, 20L, new DateTime(2021, 11, 29, 11, 22, 40, 703, DateTimeKind.Unspecified).AddTicks(120), 4L, "Molestiae dolorem quia numquam esse laudantium.", new DateTime(2023, 3, 17, 10, 27, 38, 409, DateTimeKind.Unspecified).AddTicks(4759), false, true, "Nostrum aspernatur non error.", 12L },
                    { 47L, 5L, new DateTime(2021, 4, 22, 0, 7, 36, 83, DateTimeKind.Unspecified).AddTicks(1027), 5L, "Officiis eos quis saepe impedit.\nAut saepe veniam quia sit.\nDolores sit sequi saepe molestiae facere sed eveniet et.", new DateTime(2023, 7, 16, 12, 38, 30, 855, DateTimeKind.Unspecified).AddTicks(8435), false, true, "Et quos sit qui.", 20L },
                    { 48L, 3L, new DateTime(2021, 11, 8, 21, 41, 8, 389, DateTimeKind.Unspecified).AddTicks(5847), 1L, "Veniam nisi iste enim laborum.\nNemo similique ad itaque voluptatibus voluptas soluta recusandae aut ipsum.\nMolestiae ad laborum et ratione ipsam ullam.\nMolestiae accusamus tenetur ut perspiciatis numquam ipsam architecto non ab.", new DateTime(2023, 9, 17, 19, 53, 40, 204, DateTimeKind.Unspecified).AddTicks(8427), false, false, "Doloribus quod aut nihil.", 25L },
                    { 49L, 5L, new DateTime(2021, 6, 15, 23, 3, 45, 61, DateTimeKind.Unspecified).AddTicks(2333), 1L, "Cupiditate ratione illum.", new DateTime(2022, 6, 7, 20, 54, 12, 809, DateTimeKind.Unspecified).AddTicks(5223), false, true, "Ducimus rerum dicta.", 7L },
                    { 50L, 9L, new DateTime(2021, 3, 6, 9, 39, 26, 81, DateTimeKind.Unspecified).AddTicks(469), 5L, "Libero minus quisquam libero voluptas.", new DateTime(2023, 1, 12, 13, 40, 41, 40, DateTimeKind.Unspecified).AddTicks(1991), false, true, "Aliquam exercitationem nobis.", 13L },
                    { 51L, 2L, new DateTime(2021, 6, 13, 13, 27, 42, 12, DateTimeKind.Unspecified).AddTicks(8813), 4L, "Saepe dolorem nisi consequatur.\nQuis provident rerum.\nIn repudiandae repellendus vitae ea blanditiis numquam labore reprehenderit porro.", new DateTime(2022, 6, 2, 10, 15, 30, 472, DateTimeKind.Unspecified).AddTicks(8084), false, true, "Voluptatem deserunt optio.", 39L },
                    { 52L, 2L, new DateTime(2021, 6, 3, 9, 45, 43, 915, DateTimeKind.Unspecified).AddTicks(9319), 4L, "Culpa ea amet dolor omnis saepe aut.\nPlaceat omnis fugiat dolorem dolor velit.\nVoluptatem quibusdam in adipisci nihil vero aut aut qui et.\nSed voluptatum consectetur ipsa tenetur deserunt perspiciatis eligendi consequatur ex.", new DateTime(2024, 1, 16, 3, 53, 14, 546, DateTimeKind.Unspecified).AddTicks(8714), false, false, "Voluptatem reprehenderit iure quasi ipsa iusto mollitia ipsa ea eos.", 23L },
                    { 53L, 17L, new DateTime(2021, 6, 18, 5, 15, 50, 506, DateTimeKind.Unspecified).AddTicks(4740), 5L, "Sit dolore dolorem nam delectus nobis.\nMagnam quae veniam et ea dolores.\nImpedit mollitia et veniam.\nIure fuga quis.\nEaque laudantium eaque quia.", new DateTime(2023, 10, 29, 5, 27, 18, 505, DateTimeKind.Unspecified).AddTicks(1163), false, false, "Impedit iste natus quis.", 29L },
                    { 54L, 4L, new DateTime(2021, 9, 22, 3, 10, 41, 786, DateTimeKind.Unspecified).AddTicks(5061), 5L, "Consequatur sit odit non aliquid tempore autem.\nIpsam cupiditate aut ipsam.\nVelit blanditiis fugiat ipsa vitae.\nSed non commodi laborum pariatur praesentium nisi labore nam.\nEa voluptates totam enim impedit vitae.", new DateTime(2022, 3, 15, 8, 53, 30, 414, DateTimeKind.Unspecified).AddTicks(7211), false, true, "Eos quibusdam consequuntur.", 5L },
                    { 55L, 9L, new DateTime(2021, 8, 30, 22, 48, 0, 825, DateTimeKind.Unspecified).AddTicks(4773), 5L, "Qui est rerum quisquam quaerat.\nAut iusto quo eligendi a laborum.\nConsequatur similique fugit qui ipsam nobis ad nihil.\nVeritatis ea ut.", new DateTime(2023, 3, 16, 6, 19, 47, 91, DateTimeKind.Unspecified).AddTicks(974), false, false, "Consequatur nisi nostrum enim nam molestiae labore amet illum.", 13L },
                    { 56L, 7L, new DateTime(2021, 4, 30, 22, 13, 55, 230, DateTimeKind.Unspecified).AddTicks(2149), 3L, "Molestiae autem quia ab qui est voluptatem aspernatur enim.\nAccusamus magni odio repudiandae laborum qui veniam qui cumque.\nSuscipit et quis in velit.\nExcepturi quam molestias cum veritatis inventore.\nVoluptatum et quod rerum enim sed voluptates molestiae culpa.", new DateTime(2023, 1, 30, 12, 45, 8, 358, DateTimeKind.Unspecified).AddTicks(7771), false, true, "Velit magni qui inventore odio suscipit quaerat.", 10L },
                    { 57L, 15L, new DateTime(2022, 2, 1, 9, 37, 5, 467, DateTimeKind.Unspecified).AddTicks(6876), 5L, "Voluptas officia quidem dolor.\nSit delectus esse officiis optio aut sint temporibus aliquid.", new DateTime(2023, 8, 6, 18, 5, 46, 770, DateTimeKind.Unspecified).AddTicks(3884), false, false, "Voluptatum nesciunt aut iste est laudantium ullam sunt est quidem.", 28L },
                    { 58L, 16L, new DateTime(2021, 2, 4, 22, 13, 41, 315, DateTimeKind.Unspecified).AddTicks(9874), 1L, "Velit et aut.", new DateTime(2023, 6, 9, 13, 21, 42, 585, DateTimeKind.Unspecified).AddTicks(8626), false, false, "Qui aperiam occaecati dolor et.", 36L },
                    { 59L, 17L, new DateTime(2021, 10, 16, 1, 23, 7, 244, DateTimeKind.Unspecified).AddTicks(2448), 3L, "Dolorem eum quibusdam harum expedita quo reprehenderit omnis.\nId enim qui.", new DateTime(2023, 12, 31, 6, 22, 35, 266, DateTimeKind.Unspecified).AddTicks(51), false, true, "Est beatae autem et aspernatur omnis sit delectus voluptas.", 29L },
                    { 60L, 3L, new DateTime(2021, 4, 21, 17, 39, 26, 742, DateTimeKind.Unspecified).AddTicks(3053), 2L, "Et eos dolores ex quaerat.\nNon minus recusandae ullam aperiam.\nIpsam ipsa error itaque eligendi.\nQuod velit exercitationem recusandae voluptas qui.\nConsectetur rerum enim placeat doloribus hic saepe deleniti nihil impedit.", new DateTime(2023, 9, 5, 23, 19, 34, 423, DateTimeKind.Unspecified).AddTicks(6562), false, true, "Ut omnis enim.", 17L },
                    { 61L, 2L, new DateTime(2021, 2, 8, 0, 14, 16, 243, DateTimeKind.Unspecified).AddTicks(1131), 5L, "Quia provident nihil architecto maiores voluptatem repudiandae.", new DateTime(2023, 1, 15, 9, 38, 33, 714, DateTimeKind.Unspecified).AddTicks(8050), false, true, "Non expedita sit tenetur enim quaerat magni.", 39L },
                    { 62L, 7L, new DateTime(2021, 2, 28, 11, 30, 15, 742, DateTimeKind.Unspecified).AddTicks(1052), 2L, "Qui a aut porro est sit in molestiae.\nEt qui tempore esse fuga commodi omnis ut quisquam est.\nNatus tempora suscipit qui mollitia ut.", null, false, true, "Eos repellendus saepe sit assumenda.", 16L },
                    { 63L, 8L, new DateTime(2021, 12, 6, 11, 32, 58, 756, DateTimeKind.Unspecified).AddTicks(2281), 2L, "Omnis ratione qui autem enim provident est.\nAut perspiciatis est asperiores dolorem sunt sint dolorum ex.\nPraesentium officiis ex.\nPerspiciatis cumque repellendus consectetur quos ducimus temporibus debitis doloribus.\nRecusandae repudiandae aut beatae excepturi expedita.", new DateTime(2022, 8, 28, 3, 30, 41, 573, DateTimeKind.Unspecified).AddTicks(8031), false, false, "Et dolor in eveniet ea voluptatem.", 35L },
                    { 64L, 5L, new DateTime(2021, 6, 28, 0, 46, 39, 290, DateTimeKind.Unspecified).AddTicks(3097), 1L, "Et delectus nesciunt autem.\nQuia aut quia eaque minima maiores magni.\nRatione veritatis magnam vitae voluptas odit optio.", new DateTime(2023, 10, 6, 3, 5, 32, 595, DateTimeKind.Unspecified).AddTicks(1434), false, true, "Commodi ipsam eum quaerat tenetur.", 30L },
                    { 65L, 20L, new DateTime(2021, 4, 13, 7, 3, 35, 773, DateTimeKind.Unspecified).AddTicks(6420), 4L, "Ut possimus eius rem reprehenderit est neque optio.\nVeniam accusantium ad quia corporis.\nPlaceat quam nulla.\nEa architecto tempore quasi adipisci saepe quod deserunt magnam.", new DateTime(2022, 11, 1, 18, 34, 19, 372, DateTimeKind.Unspecified).AddTicks(8883), false, true, "Quam officiis nam amet fugiat sit.", 21L },
                    { 66L, 4L, new DateTime(2021, 12, 16, 9, 0, 54, 989, DateTimeKind.Unspecified).AddTicks(1757), 1L, "Cum doloremque maiores.\nSunt iusto quia fugit consequatur sint assumenda doloribus atque.\nQui exercitationem est voluptatem culpa.\nIllo repudiandae quia non magni tempora totam nobis.", new DateTime(2022, 7, 6, 6, 57, 2, 673, DateTimeKind.Unspecified).AddTicks(4606), false, false, "Quos et consequatur.", 33L },
                    { 67L, 5L, new DateTime(2021, 7, 4, 21, 29, 44, 604, DateTimeKind.Unspecified).AddTicks(8805), 1L, "Neque ipsam praesentium et autem.\nVoluptas temporibus veritatis asperiores voluptas nihil est tempore ut.\nOccaecati et labore aperiam quisquam vero nobis dolorum sed laborum.", new DateTime(2022, 12, 5, 15, 19, 31, 468, DateTimeKind.Unspecified).AddTicks(1435), false, true, "Quae nobis ut dolorum blanditiis sed voluptatum odio.", 20L },
                    { 68L, 7L, new DateTime(2021, 4, 1, 18, 58, 51, 127, DateTimeKind.Unspecified).AddTicks(6501), 4L, "Sapiente nisi voluptates mollitia ad corrupti perferendis similique velit.", new DateTime(2022, 12, 8, 22, 13, 19, 490, DateTimeKind.Unspecified).AddTicks(7588), false, true, "Necessitatibus ut repudiandae consequatur dolor esse voluptas ipsa quaerat.", 16L },
                    { 69L, 3L, new DateTime(2021, 11, 9, 6, 57, 3, 393, DateTimeKind.Unspecified).AddTicks(3521), 3L, "Quo rerum cumque et sapiente.\nCorrupti voluptatum doloribus praesentium autem debitis distinctio consectetur.\nDolorem magni quidem aut aut enim odio veniam.", new DateTime(2023, 6, 4, 2, 30, 15, 420, DateTimeKind.Unspecified).AddTicks(641), false, true, "Iure odio nam rerum.", 17L },
                    { 70L, 9L, new DateTime(2021, 2, 26, 20, 29, 59, 219, DateTimeKind.Unspecified).AddTicks(4177), 4L, "Minima vitae est iusto ratione excepturi facere.\nQuia atque natus nemo.\nNulla in voluptatem.\nId aperiam voluptatem autem quia aliquam.\nIure et tempore.", new DateTime(2023, 1, 20, 5, 32, 24, 706, DateTimeKind.Unspecified).AddTicks(7950), false, false, "Deserunt sed qui libero quas accusantium saepe.", 13L },
                    { 71L, 11L, new DateTime(2021, 10, 24, 10, 54, 26, 326, DateTimeKind.Unspecified).AddTicks(2431), 3L, "Nesciunt provident doloribus labore.", new DateTime(2023, 8, 1, 18, 56, 17, 776, DateTimeKind.Unspecified).AddTicks(8825), false, true, "Dolorem non unde.", 41L },
                    { 72L, 5L, new DateTime(2021, 8, 14, 12, 54, 0, 489, DateTimeKind.Unspecified).AddTicks(9888), 1L, "Quo enim amet corrupti consequatur.", null, false, false, "Odit nihil vero eligendi id tenetur dolorem fuga.", 20L },
                    { 73L, 4L, new DateTime(2021, 3, 25, 16, 31, 29, 597, DateTimeKind.Unspecified).AddTicks(8117), 5L, "Ullam qui corrupti.\nCulpa magnam architecto mollitia quis.", new DateTime(2023, 10, 30, 19, 0, 21, 113, DateTimeKind.Unspecified).AddTicks(3218), false, false, "Laudantium debitis dolorum et dicta molestias.", 14L },
                    { 74L, 18L, new DateTime(2021, 12, 27, 9, 39, 11, 866, DateTimeKind.Unspecified).AddTicks(3985), 3L, "Cupiditate quia quisquam a voluptatibus.\nRecusandae accusamus ipsam.\nA reiciendis odio dolor nulla.\nIste iste nihil unde voluptatem commodi unde et id natus.", null, false, true, "Et placeat itaque amet ad.", 34L },
                    { 75L, 9L, new DateTime(2021, 6, 18, 6, 8, 39, 990, DateTimeKind.Unspecified).AddTicks(3904), 1L, "Qui alias debitis debitis deleniti tenetur voluptas vel et.", new DateTime(2023, 10, 17, 7, 21, 42, 701, DateTimeKind.Unspecified).AddTicks(4021), false, true, "Qui sapiente dolorem eos exercitationem explicabo cupiditate odio.", 13L },
                    { 76L, 18L, new DateTime(2021, 8, 29, 17, 45, 49, 19, DateTimeKind.Unspecified).AddTicks(6526), 5L, "Quia ullam illum soluta.\nVoluptatem praesentium eveniet.", new DateTime(2022, 4, 21, 10, 42, 15, 250, DateTimeKind.Unspecified).AddTicks(231), false, false, "Quam porro recusandae provident maxime.", 31L },
                    { 77L, 14L, new DateTime(2021, 7, 26, 3, 37, 40, 168, DateTimeKind.Unspecified).AddTicks(8371), 4L, "Sunt earum tempore consequatur molestias totam ab.\nVero iste culpa distinctio ad.\nSed dolorem tenetur doloribus sapiente deserunt nam eos fuga.\nQuo rerum eaque omnis voluptas dolor assumenda ut.\nEos voluptatum voluptatem.", new DateTime(2023, 9, 1, 2, 29, 31, 175, DateTimeKind.Unspecified).AddTicks(9669), false, false, "Debitis quae dolores consectetur rem sapiente iste aperiam.", 26L },
                    { 78L, 4L, new DateTime(2021, 5, 30, 12, 49, 5, 83, DateTimeKind.Unspecified).AddTicks(5041), 3L, "Architecto non debitis impedit voluptatem non aut.", new DateTime(2023, 4, 30, 16, 13, 55, 482, DateTimeKind.Unspecified).AddTicks(9494), false, true, "Quia aut eius assumenda cumque architecto corporis.", 33L },
                    { 79L, 20L, new DateTime(2021, 12, 20, 19, 51, 9, 35, DateTimeKind.Unspecified).AddTicks(5559), 1L, "Veniam et ab nostrum qui rerum.\nFugit laboriosam deleniti laudantium ipsum velit adipisci.\nVoluptatem voluptas alias vero sed voluptatibus magnam accusantium aperiam.\nEum temporibus sunt harum eum ad molestiae ratione dolor temporibus.\nDolorem quam accusamus nostrum.", new DateTime(2022, 10, 17, 18, 50, 4, 602, DateTimeKind.Unspecified).AddTicks(7246), false, true, "Facilis eos ipsam quibusdam vel.", 22L },
                    { 80L, 3L, new DateTime(2021, 3, 5, 9, 17, 31, 145, DateTimeKind.Unspecified).AddTicks(9938), 1L, "Eaque sit in.\nPariatur quae atque.\nQuia sed accusantium voluptatem ea distinctio iusto ut magni similique.", new DateTime(2023, 8, 14, 2, 31, 49, 731, DateTimeKind.Unspecified).AddTicks(8841), false, true, "Sed quo officiis omnis quibusdam occaecati maxime.", 17L },
                    { 81L, 15L, new DateTime(2021, 11, 19, 13, 46, 55, 178, DateTimeKind.Unspecified).AddTicks(5038), 3L, "Sit et odio nemo voluptatem eos consequatur culpa deleniti.", new DateTime(2023, 3, 20, 5, 5, 26, 150, DateTimeKind.Unspecified).AddTicks(5764), false, true, "Libero id possimus fugiat voluptatum ea in assumenda possimus.", 28L }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 4L, 28L, "Et maxime enim deleniti recusandae incidunt et consequuntur.", new DateTime(2021, 3, 8, 9, 48, 26, 952, DateTimeKind.Unspecified).AddTicks(4244), 1L, false, 21L },
                    { 6L, 38L, "Similique quia perferendis.\nOmnis reprehenderit minima.\nSed sed ea quia sunt est voluptatem.\nQuibusdam dicta non eum aut adipisci ipsum corrupti et.\nSit nisi ut voluptas aut officia incidunt et.", new DateTime(2021, 11, 7, 4, 56, 54, 182, DateTimeKind.Unspecified).AddTicks(1601), 5L, false, 62L },
                    { 8L, 24L, "Accusamus et et.", new DateTime(2022, 1, 22, 10, 8, 14, 621, DateTimeKind.Unspecified).AddTicks(9033), 4L, false, 51L },
                    { 9L, 14L, "Dolor et ut est laudantium.\nRerum hic nihil ex labore recusandae quibusdam velit ipsa harum.\nCumque quod culpa voluptatem molestiae.\nQuis ratione expedita.\nDolores repudiandae ipsam voluptatum voluptas labore blanditiis adipisci.\nCulpa repellendus suscipit laborum omnis.", new DateTime(2021, 3, 29, 13, 44, 48, 294, DateTimeKind.Unspecified).AddTicks(2594), 5L, false, 49L }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 11L, 5L, "Ea veritatis laudantium aut nostrum.\nEaque odit aut qui optio nisi alias.\nAb perspiciatis consequatur consequuntur qui assumenda eum et odio.", new DateTime(2021, 10, 25, 23, 52, 51, 625, DateTimeKind.Unspecified).AddTicks(552), 2L, false, 49L },
                    { 15L, 11L, "Enim maiores optio vero et.\nNemo enim porro reprehenderit.\nUnde ipsam nihil eveniet.\nEnim quaerat sit aliquam ea quas laborum quas quas voluptatem.", new DateTime(2021, 3, 25, 5, 10, 27, 236, DateTimeKind.Unspecified).AddTicks(486), 3L, false, 21L },
                    { 16L, 17L, "Perferendis consectetur necessitatibus.\nOptio ea quaerat illo est illum placeat qui.\nCum pariatur sed quidem exercitationem non perspiciatis perspiciatis.", new DateTime(2021, 9, 18, 2, 18, 28, 271, DateTimeKind.Unspecified).AddTicks(7368), 4L, false, 76L },
                    { 17L, 42L, "Ut repellat veritatis maxime vero.\nSed provident consequuntur.", new DateTime(2021, 2, 20, 4, 46, 35, 98, DateTimeKind.Unspecified).AddTicks(103), 2L, false, 22L },
                    { 19L, 21L, "Quaerat quas consequatur.\nIllo qui quasi saepe esse odio qui est.", new DateTime(2021, 7, 6, 13, 41, 24, 534, DateTimeKind.Unspecified).AddTicks(6323), 1L, false, 32L },
                    { 20L, 36L, "Optio ut aut numquam voluptas non consequuntur.\nPraesentium sint cupiditate.\nQuisquam qui accusamus est.\nEst rerum veniam voluptates voluptatem sint et maxime nihil nobis.", new DateTime(2021, 12, 2, 18, 40, 58, 468, DateTimeKind.Unspecified).AddTicks(6116), 2L, false, 49L },
                    { 21L, 23L, "Ut sit voluptates fugit quae.\nVoluptatum deserunt eaque consequuntur.\nConsequatur amet quisquam voluptatem vero cumque autem.\nHarum quaerat libero tempore eum.\nTotam et nulla odio.", new DateTime(2021, 4, 27, 15, 59, 4, 824, DateTimeKind.Unspecified).AddTicks(9757), 2L, false, 20L },
                    { 22L, 34L, "Aut a sunt tenetur unde rem eligendi officiis saepe.\nDolores natus cumque commodi eum rerum pariatur fugiat consequuntur consequatur.\nNisi vitae ut in.\nEt voluptatem id eveniet quia.\nTempora et sint eveniet consequuntur nihil temporibus.\nSimilique quibusdam dolor et.", new DateTime(2021, 8, 9, 8, 26, 1, 548, DateTimeKind.Unspecified).AddTicks(2263), 2L, false, 74L },
                    { 23L, 27L, "Vel sint rerum a qui laudantium officiis.\nAutem ad voluptas ut ut repellat possimus.\nSuscipit quibusdam nulla non omnis molestiae quae delectus iusto iusto.\nNumquam quia libero quasi ratione perspiciatis inventore.", new DateTime(2021, 10, 27, 13, 0, 41, 624, DateTimeKind.Unspecified).AddTicks(4859), 5L, false, 57L },
                    { 24L, 22L, "Accusantium cupiditate ab.\nVoluptatem doloremque non dolor aut placeat in.", new DateTime(2021, 4, 21, 11, 47, 32, 763, DateTimeKind.Unspecified).AddTicks(2762), 4L, false, 52L },
                    { 25L, 33L, "Cum cupiditate voluptatem ut distinctio minima.\nSed optio asperiores non deleniti et earum et.\nQuibusdam et labore vel provident facilis.\nEt dolor odit sunt explicabo libero.\nEt ad error eius minima maxime ipsum.\nConsequatur et nisi enim.", new DateTime(2021, 10, 15, 2, 41, 19, 937, DateTimeKind.Unspecified).AddTicks(2405), 2L, false, 4L },
                    { 26L, 14L, "Molestias molestiae voluptas est unde in earum doloremque sed.", new DateTime(2021, 5, 19, 19, 10, 35, 947, DateTimeKind.Unspecified).AddTicks(9674), 3L, false, 11L },
                    { 28L, 9L, "Fuga molestiae doloremque vel.\nQui omnis odio et eum iure sed.", new DateTime(2021, 11, 23, 18, 39, 7, 516, DateTimeKind.Unspecified).AddTicks(4070), 4L, false, 16L },
                    { 31L, 35L, "Corrupti ut sunt et sunt incidunt veniam molestiae.\nDucimus unde rerum quia harum.\nIpsa quia aperiam rem aut dolor qui aut.\nEsse accusamus laborum blanditiis.", new DateTime(2021, 6, 15, 18, 29, 5, 668, DateTimeKind.Unspecified).AddTicks(6151), 1L, false, 49L },
                    { 32L, 29L, "Voluptates rerum ut commodi vitae eius enim consequatur deserunt dolorem.\nCum enim veritatis enim aut eligendi qui maiores fuga.", new DateTime(2021, 9, 30, 2, 37, 37, 261, DateTimeKind.Unspecified).AddTicks(5220), 1L, false, 55L },
                    { 34L, 46L, "Eos vel hic aliquam quod consequatur incidunt veniam reprehenderit.\nAnimi omnis ratione dolor et necessitatibus facilis mollitia.\nEt possimus natus ad eos.\nDignissimos ipsa et voluptate non aliquam fugiat.\nNon quod aut consectetur minus.", new DateTime(2021, 3, 31, 7, 59, 44, 959, DateTimeKind.Unspecified).AddTicks(1911), 3L, false, 16L },
                    { 38L, 5L, "Quis eligendi hic.\nEt vel cum.\nOdit consequatur ab nemo quia voluptas quia iure.\nId aliquam a inventore.\nRepudiandae delectus eligendi consequatur qui quos rerum.", new DateTime(2021, 7, 26, 18, 42, 24, 222, DateTimeKind.Unspecified).AddTicks(2402), 2L, false, 8L },
                    { 39L, 12L, "Voluptatibus nesciunt at ut totam dignissimos eum dolorem.\nHic corrupti qui enim amet qui cum earum laboriosam.\nEt cumque dolor maiores nihil aliquam natus sit possimus.\nVeniam vel temporibus.\nSunt adipisci incidunt ut adipisci.\nSint incidunt esse beatae perferendis sed vitae unde nemo.", new DateTime(2021, 3, 11, 20, 31, 48, 815, DateTimeKind.Unspecified).AddTicks(2425), 1L, false, 33L },
                    { 40L, 47L, "Aut sed quia molestiae veniam et quaerat architecto dolores unde.\nCumque iure sit asperiores.\nSit maxime unde ex fugiat quis.\nUt eius quia perferendis debitis ut quidem ratione.", new DateTime(2021, 12, 21, 18, 31, 26, 176, DateTimeKind.Unspecified).AddTicks(808), 3L, false, 13L },
                    { 41L, 6L, "Sint voluptates rerum.\nSequi minima non debitis et.\nCommodi ipsam porro et reprehenderit ut nostrum dicta.\nEt sed quia aut necessitatibus eum provident et.\nEius error ut et alias dignissimos.\nQuo nam aut cum consequatur quia.", new DateTime(2021, 6, 9, 15, 14, 31, 650, DateTimeKind.Unspecified).AddTicks(7392), 3L, false, 59L },
                    { 43L, 25L, "Quidem rerum molestias deserunt nihil aperiam tempore tempora.\nTempora quae iusto.\nOmnis aliquid magnam omnis repudiandae velit necessitatibus expedita non.\nDolorem maxime eius quia facere inventore repudiandae nulla.", new DateTime(2022, 1, 1, 5, 17, 25, 464, DateTimeKind.Unspecified).AddTicks(7600), 2L, false, 3L },
                    { 45L, 21L, "Exercitationem necessitatibus quasi molestias enim et corrupti.\nEum accusantium aliquam dolorem vel assumenda laudantium fugiat praesentium.\nSunt quibusdam quia architecto impedit aliquam sequi consectetur.\nQuia veniam illo omnis.\nConsequatur magni mollitia qui dolor reiciendis perspiciatis ab soluta.", new DateTime(2021, 12, 4, 1, 6, 57, 745, DateTimeKind.Unspecified).AddTicks(8618), 3L, false, 46L },
                    { 48L, 39L, "Unde voluptas architecto rem.", new DateTime(2021, 2, 14, 21, 17, 59, 540, DateTimeKind.Unspecified).AddTicks(5089), 2L, false, 32L },
                    { 50L, 49L, "Aut et placeat officiis enim quia at molestias.\nAliquam non officiis ipsam.\nNon nobis aliquam labore ipsa velit ut vitae.\nUnde consequatur totam voluptatem omnis delectus eius ut.\nVelit aut aut facilis.", new DateTime(2021, 9, 5, 4, 2, 2, 474, DateTimeKind.Unspecified).AddTicks(424), 3L, false, 13L },
                    { 51L, 38L, "Ab aut cumque est asperiores quidem veniam odit corrupti pariatur.\nQuos est quisquam numquam velit veritatis voluptas voluptates corporis.\nA ex ea cum numquam quo error.", new DateTime(2021, 6, 15, 19, 56, 21, 286, DateTimeKind.Unspecified).AddTicks(5681), 5L, false, 11L },
                    { 52L, 26L, "Doloremque porro pariatur.\nVoluptatum et enim eos.\nIllo ea nihil esse aliquam et placeat vitae.\nEt et ex explicabo dolorum nisi recusandae.\nEt porro quis quis voluptatem quia nam laborum est.", new DateTime(2021, 9, 22, 1, 11, 23, 140, DateTimeKind.Unspecified).AddTicks(7612), 5L, false, 29L },
                    { 55L, 38L, "Omnis neque nemo.", new DateTime(2021, 12, 27, 20, 46, 28, 118, DateTimeKind.Unspecified).AddTicks(1782), 5L, false, 21L },
                    { 56L, 29L, "Eos qui voluptates consequatur provident.", new DateTime(2021, 6, 13, 19, 20, 51, 517, DateTimeKind.Unspecified).AddTicks(3506), 3L, false, 52L },
                    { 57L, 6L, "Alias ab non doloremque aut error.\nAut non quisquam consequuntur dolorem voluptas.\nDolorum soluta veniam itaque suscipit excepturi aspernatur pariatur.\nCum temporibus sunt.", new DateTime(2021, 11, 28, 7, 27, 57, 166, DateTimeKind.Unspecified).AddTicks(5207), 1L, false, 55L },
                    { 59L, 43L, "Pariatur maiores ut fuga.\nQuae aut amet expedita et aut ea laudantium nam vel.\nDelectus possimus ratione.", new DateTime(2021, 12, 12, 2, 21, 48, 187, DateTimeKind.Unspecified).AddTicks(3695), 5L, false, 73L },
                    { 62L, 36L, "Doloribus veniam qui minus repellendus vel sunt ex.\nAdipisci quasi minima.\nIusto est animi et eaque eius voluptas.\nVero omnis qui.\nMollitia aut libero autem corporis possimus.\nQuam officia sequi numquam.", new DateTime(2021, 3, 1, 4, 36, 46, 202, DateTimeKind.Unspecified).AddTicks(6727), 4L, false, 41L },
                    { 67L, 26L, "Nemo iusto voluptas sed sit minus mollitia.\nHarum id labore illum quia sed provident.\nQuasi assumenda necessitatibus dolorem et ut.", new DateTime(2021, 12, 4, 13, 12, 49, 653, DateTimeKind.Unspecified).AddTicks(2873), 1L, false, 13L },
                    { 68L, 40L, "Commodi architecto maiores et aut.\nConsequatur commodi optio quo modi rerum similique ullam laboriosam.", new DateTime(2021, 11, 10, 7, 53, 26, 136, DateTimeKind.Unspecified).AddTicks(5424), 5L, false, 57L },
                    { 69L, 19L, "Alias odio voluptas et dolorum aut suscipit earum amet.\nVero molestias et labore.\nDolorum sit itaque sunt quo dolorem autem.", new DateTime(2021, 10, 30, 15, 51, 52, 4, DateTimeKind.Unspecified).AddTicks(6718), 2L, false, 45L },
                    { 70L, 40L, "Minus dignissimos velit recusandae id cupiditate ea harum.\nNam quaerat officiis doloremque.\nExcepturi culpa consequatur magni quia veritatis.", new DateTime(2021, 2, 26, 12, 1, 35, 855, DateTimeKind.Unspecified).AddTicks(3844), 2L, false, 13L },
                    { 71L, 44L, "Nam quia dicta eius doloribus commodi non nihil.\nQuod recusandae et est.\nDebitis molestiae qui nam cum optio aut maxime.\nEst quia sed recusandae nostrum.", new DateTime(2021, 10, 28, 3, 37, 20, 886, DateTimeKind.Unspecified).AddTicks(3829), 1L, false, 49L },
                    { 73L, 44L, "Est sit at placeat optio.\nSapiente pariatur et et enim.\nAccusamus molestiae labore.", new DateTime(2021, 6, 2, 19, 19, 7, 873, DateTimeKind.Unspecified).AddTicks(6561), 4L, false, 51L },
                    { 74L, 35L, "Vero quisquam vel reprehenderit doloribus omnis aliquid deleniti.\nExcepturi consequuntur qui omnis voluptas odit repellat.\nVel aut ipsam ut earum incidunt labore a aut.\nOdit rem officia odit reiciendis quibusdam.", new DateTime(2021, 8, 13, 6, 42, 6, 75, DateTimeKind.Unspecified).AddTicks(5875), 3L, false, 62L },
                    { 79L, 42L, "Fuga rem ullam et dolores eaque tempora aspernatur ut.\nQuam sed repudiandae eos autem.", new DateTime(2021, 8, 17, 2, 3, 25, 915, DateTimeKind.Unspecified).AddTicks(4962), 4L, false, 12L },
                    { 80L, 13L, "Dicta aliquam pariatur et provident.\nAut est aut quidem quis rerum quidem magnam voluptatem.\nHic quam odit eos et provident.\nEa illum nisi perspiciatis quae est sequi facere placeat.\nUt ut eius qui dolor id.", new DateTime(2021, 3, 22, 13, 48, 54, 546, DateTimeKind.Unspecified).AddTicks(9572), 2L, false, 11L },
                    { 87L, 6L, "Modi delectus tempora quam deserunt suscipit vel dolore exercitationem.\nQuidem deserunt sit nobis odit dolor ipsam praesentium.", new DateTime(2022, 1, 16, 3, 48, 0, 652, DateTimeKind.Unspecified).AddTicks(9794), 5L, false, 3L },
                    { 91L, 2L, "Sit vero occaecati distinctio.\nA debitis animi itaque porro omnis blanditiis est officia amet.", new DateTime(2021, 12, 28, 21, 40, 32, 674, DateTimeKind.Unspecified).AddTicks(6306), 3L, false, 12L }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 94L, 24L, "Quibusdam minus aut reiciendis itaque itaque numquam deserunt magni.\nDucimus enim voluptates.\nFacere optio atque et ab soluta.", new DateTime(2021, 6, 12, 16, 22, 28, 283, DateTimeKind.Unspecified).AddTicks(9904), 3L, false, 55L },
                    { 95L, 8L, "Quis voluptas ab aperiam quos assumenda quas voluptas.\nRem at neque est quia eum dolor provident non eveniet.\nNesciunt qui alias ea ut.\nAliquid repellendus voluptas.", new DateTime(2021, 8, 18, 13, 51, 14, 358, DateTimeKind.Unspecified).AddTicks(9932), 3L, false, 15L },
                    { 96L, 15L, "Autem ut aspernatur omnis cum voluptas quasi sint.\nNulla voluptatem praesentium voluptas pariatur.", new DateTime(2021, 5, 6, 4, 34, 37, 818, DateTimeKind.Unspecified).AddTicks(542), 2L, false, 13L },
                    { 98L, 24L, "Iste blanditiis quidem iusto expedita.\nMollitia dicta debitis porro.\nAccusantium harum molestias recusandae ab maiores illum.\nCorporis est possimus sed saepe voluptate voluptatem quaerat.\nIste quod voluptatibus.", new DateTime(2021, 10, 20, 16, 39, 1, 740, DateTimeKind.Unspecified).AddTicks(2800), 1L, false, 51L },
                    { 99L, 28L, "Nihil optio cupiditate natus esse perferendis sed sunt.\nEst repudiandae temporibus laudantium temporibus atque distinctio ea.\nEt sint maxime accusantium molestias sapiente omnis.", new DateTime(2021, 12, 27, 8, 23, 18, 3, DateTimeKind.Unspecified).AddTicks(9514), 4L, false, 13L },
                    { 103L, 41L, "Rerum quo dignissimos.\nQui nobis inventore suscipit tenetur dolor perspiciatis ut.\nDolorem molestiae minus sit totam quia.", new DateTime(2021, 10, 21, 7, 52, 12, 576, DateTimeKind.Unspecified).AddTicks(2896), 5L, false, 3L },
                    { 107L, 39L, "Vero laudantium quia qui laborum dolorem blanditiis.\nIncidunt minus rem rerum velit.\nLaudantium non aliquam et.\nExcepturi enim porro quam molestiae consectetur aut.\nOmnis fugiat reprehenderit repellendus quidem ducimus optio eos ipsam.\nDignissimos est vitae facere qui sit est.", new DateTime(2021, 4, 17, 11, 26, 32, 214, DateTimeKind.Unspecified).AddTicks(8122), 5L, false, 12L },
                    { 109L, 32L, "Velit blanditiis possimus qui provident vel cum illo incidunt.\nNihil eum omnis.\nAut reiciendis ex porro ad minus.\nModi placeat architecto doloremque nisi distinctio.\nQuidem dolorem ducimus sed facere qui sed quasi quo occaecati.", new DateTime(2021, 3, 11, 22, 8, 16, 225, DateTimeKind.Unspecified).AddTicks(6162), 1L, false, 20L },
                    { 111L, 5L, "Veritatis officia eius harum earum dolor.\nUt fugiat odit.\nFuga mollitia tenetur.\nVel repellat voluptatem explicabo consectetur sed.\nIllum sit temporibus quas tempora commodi doloremque minus quam.", new DateTime(2021, 11, 18, 20, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(887), 3L, false, 29L },
                    { 115L, 31L, "Et doloremque molestiae ut quos pariatur et praesentium quidem.\nConsectetur molestiae officia et quod optio.\nQuo id maiores totam possimus dolorem ab est.\nEarum voluptatem facilis sint natus et.\nPorro laudantium ipsum consequatur vitae sunt.", new DateTime(2021, 5, 3, 14, 55, 18, 241, DateTimeKind.Unspecified).AddTicks(1429), 1L, false, 10L },
                    { 117L, 7L, "Vel culpa ab et animi vel quisquam eum ut.\nOfficiis id similique voluptas qui eos.\nRerum qui consequatur nesciunt.\nEt praesentium recusandae nulla voluptatem rerum assumenda.\nCum eum mollitia enim doloribus quas.\nNobis quas velit doloremque dolor sint eum.", new DateTime(2021, 12, 3, 14, 2, 40, 799, DateTimeKind.Unspecified).AddTicks(843), 5L, false, 34L }
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "IsDeleted", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[,]
                {
                    { 2L, 40L, new DateTime(2021, 9, 24, 8, 33, 0, 415, DateTimeKind.Unspecified).AddTicks(7192), 3L, false, new DateTime(2022, 1, 5, 22, 15, 48, 575, DateTimeKind.Unspecified).AddTicks(6472), 62L, new DateTime(2020, 1, 30, 1, 31, 50, 280, DateTimeKind.Unspecified).AddTicks(9574), new DateTime(2021, 12, 12, 15, 15, 31, 178, DateTimeKind.Unspecified).AddTicks(8412) },
                    { 3L, 43L, new DateTime(2021, 8, 27, 17, 34, 16, 686, DateTimeKind.Unspecified).AddTicks(2118), 2L, false, null, 69L, new DateTime(2019, 4, 7, 10, 4, 46, 826, DateTimeKind.Unspecified).AddTicks(6111), new DateTime(2021, 10, 28, 18, 16, 40, 334, DateTimeKind.Unspecified).AddTicks(5364) },
                    { 4L, 12L, new DateTime(2021, 5, 16, 12, 12, 8, 188, DateTimeKind.Unspecified).AddTicks(9897), 5L, false, new DateTime(2022, 1, 5, 11, 0, 5, 718, DateTimeKind.Unspecified).AddTicks(6490), 27L, new DateTime(2019, 4, 25, 3, 59, 37, 662, DateTimeKind.Unspecified).AddTicks(3554), new DateTime(2021, 4, 25, 0, 35, 53, 321, DateTimeKind.Unspecified).AddTicks(1316) },
                    { 5L, 8L, new DateTime(2021, 10, 31, 22, 1, 37, 689, DateTimeKind.Unspecified).AddTicks(5359), 1L, false, new DateTime(2022, 2, 1, 14, 34, 43, 378, DateTimeKind.Unspecified).AddTicks(1561), 67L, new DateTime(2019, 8, 19, 17, 44, 46, 658, DateTimeKind.Unspecified).AddTicks(918), new DateTime(2021, 4, 16, 18, 25, 11, 992, DateTimeKind.Unspecified).AddTicks(7954) },
                    { 6L, 29L, new DateTime(2022, 1, 27, 16, 47, 33, 923, DateTimeKind.Unspecified).AddTicks(583), 5L, false, new DateTime(2022, 1, 23, 12, 31, 35, 639, DateTimeKind.Unspecified).AddTicks(4674), 35L, new DateTime(2019, 8, 13, 6, 6, 28, 880, DateTimeKind.Unspecified).AddTicks(3793), new DateTime(2021, 4, 18, 17, 26, 31, 11, DateTimeKind.Unspecified).AddTicks(1273) },
                    { 7L, 38L, new DateTime(2022, 1, 5, 3, 27, 29, 296, DateTimeKind.Unspecified).AddTicks(8334), 4L, false, new DateTime(2022, 1, 30, 10, 16, 45, 196, DateTimeKind.Unspecified).AddTicks(5632), 9L, new DateTime(2019, 2, 13, 19, 51, 19, 928, DateTimeKind.Unspecified).AddTicks(738), new DateTime(2021, 11, 18, 16, 32, 53, 683, DateTimeKind.Unspecified).AddTicks(2538) },
                    { 8L, 25L, new DateTime(2021, 5, 27, 21, 17, 9, 452, DateTimeKind.Unspecified).AddTicks(7098), 1L, false, new DateTime(2022, 1, 9, 8, 13, 34, 718, DateTimeKind.Unspecified).AddTicks(9636), 76L, new DateTime(2019, 10, 9, 20, 17, 22, 390, DateTimeKind.Unspecified).AddTicks(885), new DateTime(2021, 1, 25, 16, 38, 22, 53, DateTimeKind.Unspecified).AddTicks(7924) },
                    { 9L, 40L, new DateTime(2022, 1, 31, 21, 26, 51, 827, DateTimeKind.Unspecified).AddTicks(8252), 2L, false, new DateTime(2022, 1, 7, 12, 42, 8, 83, DateTimeKind.Unspecified).AddTicks(1103), 5L, new DateTime(2020, 1, 22, 18, 37, 0, 498, DateTimeKind.Unspecified).AddTicks(1863), new DateTime(2021, 6, 9, 17, 8, 42, 879, DateTimeKind.Unspecified).AddTicks(9660) },
                    { 10L, 9L, new DateTime(2021, 9, 24, 8, 2, 52, 357, DateTimeKind.Unspecified).AddTicks(5310), 5L, false, new DateTime(2022, 1, 18, 20, 26, 49, 817, DateTimeKind.Unspecified).AddTicks(5079), 48L, new DateTime(2019, 5, 17, 8, 55, 4, 105, DateTimeKind.Unspecified).AddTicks(7840), new DateTime(2021, 3, 5, 5, 24, 18, 513, DateTimeKind.Unspecified).AddTicks(8173) },
                    { 11L, 22L, new DateTime(2021, 9, 22, 4, 17, 16, 234, DateTimeKind.Unspecified).AddTicks(9686), 5L, false, new DateTime(2022, 1, 6, 1, 58, 44, 374, DateTimeKind.Unspecified).AddTicks(3557), 38L, new DateTime(2019, 8, 8, 3, 43, 38, 530, DateTimeKind.Unspecified).AddTicks(1605), new DateTime(2021, 2, 15, 13, 16, 46, 651, DateTimeKind.Unspecified).AddTicks(3984) },
                    { 12L, 29L, new DateTime(2021, 7, 17, 0, 36, 1, 898, DateTimeKind.Unspecified).AddTicks(7555), 4L, false, null, 63L, new DateTime(2019, 7, 16, 15, 58, 47, 536, DateTimeKind.Unspecified).AddTicks(3952), new DateTime(2021, 11, 29, 15, 59, 47, 828, DateTimeKind.Unspecified).AddTicks(9267) },
                    { 13L, 12L, new DateTime(2021, 2, 28, 15, 8, 40, 294, DateTimeKind.Unspecified).AddTicks(4473), 2L, false, new DateTime(2022, 1, 20, 9, 21, 30, 917, DateTimeKind.Unspecified).AddTicks(9382), 29L, new DateTime(2019, 10, 17, 18, 38, 44, 154, DateTimeKind.Unspecified).AddTicks(1922), new DateTime(2021, 1, 7, 18, 40, 1, 590, DateTimeKind.Unspecified).AddTicks(3845) },
                    { 14L, 28L, new DateTime(2021, 5, 12, 1, 58, 30, 518, DateTimeKind.Unspecified).AddTicks(7479), 5L, false, new DateTime(2022, 1, 25, 1, 57, 52, 396, DateTimeKind.Unspecified).AddTicks(4843), 17L, new DateTime(2019, 6, 4, 23, 6, 42, 783, DateTimeKind.Unspecified).AddTicks(9467), new DateTime(2021, 12, 1, 13, 26, 42, 351, DateTimeKind.Unspecified).AddTicks(1248) },
                    { 15L, 40L, new DateTime(2021, 7, 6, 21, 0, 6, 758, DateTimeKind.Unspecified).AddTicks(5984), 2L, false, new DateTime(2022, 1, 28, 10, 45, 44, 644, DateTimeKind.Unspecified).AddTicks(2203), 55L, new DateTime(2019, 11, 23, 22, 58, 16, 285, DateTimeKind.Unspecified).AddTicks(2252), new DateTime(2021, 11, 26, 11, 52, 45, 245, DateTimeKind.Unspecified).AddTicks(7094) },
                    { 16L, 42L, new DateTime(2021, 2, 20, 13, 49, 55, 978, DateTimeKind.Unspecified).AddTicks(1268), 3L, false, new DateTime(2022, 1, 30, 21, 7, 54, 588, DateTimeKind.Unspecified).AddTicks(6904), 13L, new DateTime(2019, 8, 22, 2, 20, 20, 432, DateTimeKind.Unspecified).AddTicks(2228), new DateTime(2021, 11, 3, 15, 40, 22, 182, DateTimeKind.Unspecified).AddTicks(9454) },
                    { 17L, 51L, new DateTime(2021, 12, 11, 4, 14, 52, 140, DateTimeKind.Unspecified).AddTicks(5983), 1L, false, new DateTime(2022, 1, 8, 22, 57, 6, 439, DateTimeKind.Unspecified).AddTicks(9392), 62L, new DateTime(2019, 9, 14, 10, 30, 10, 103, DateTimeKind.Unspecified).AddTicks(4), new DateTime(2021, 1, 4, 15, 34, 33, 879, DateTimeKind.Unspecified).AddTicks(7047) },
                    { 18L, 36L, new DateTime(2021, 9, 27, 2, 58, 53, 389, DateTimeKind.Unspecified).AddTicks(2217), 5L, false, new DateTime(2022, 1, 22, 10, 57, 50, 839, DateTimeKind.Unspecified).AddTicks(8392), 36L, new DateTime(2019, 3, 18, 20, 21, 44, 216, DateTimeKind.Unspecified).AddTicks(8720), new DateTime(2021, 3, 26, 14, 28, 2, 689, DateTimeKind.Unspecified).AddTicks(4422) },
                    { 19L, 47L, new DateTime(2021, 6, 18, 12, 2, 7, 836, DateTimeKind.Unspecified).AddTicks(5426), 4L, false, new DateTime(2022, 1, 29, 3, 57, 21, 82, DateTimeKind.Unspecified).AddTicks(6094), 37L, new DateTime(2019, 2, 10, 21, 25, 44, 799, DateTimeKind.Unspecified).AddTicks(196), new DateTime(2021, 7, 5, 14, 12, 48, 87, DateTimeKind.Unspecified).AddTicks(8043) },
                    { 20L, 22L, new DateTime(2021, 7, 28, 7, 37, 18, 187, DateTimeKind.Unspecified).AddTicks(8593), 1L, false, new DateTime(2022, 1, 22, 11, 30, 28, 385, DateTimeKind.Unspecified).AddTicks(9312), 33L, new DateTime(2019, 5, 9, 4, 17, 20, 308, DateTimeKind.Unspecified).AddTicks(4529), new DateTime(2021, 1, 12, 0, 59, 53, 791, DateTimeKind.Unspecified).AddTicks(3315) },
                    { 21L, 49L, new DateTime(2021, 8, 26, 16, 54, 32, 529, DateTimeKind.Unspecified).AddTicks(4382), 4L, false, new DateTime(2022, 1, 6, 10, 13, 40, 172, DateTimeKind.Unspecified).AddTicks(990), 67L, new DateTime(2019, 8, 13, 5, 34, 13, 708, DateTimeKind.Unspecified).AddTicks(143), new DateTime(2021, 10, 21, 6, 14, 25, 500, DateTimeKind.Unspecified).AddTicks(5262) },
                    { 22L, 51L, new DateTime(2022, 1, 27, 10, 54, 53, 759, DateTimeKind.Unspecified).AddTicks(4075), 5L, false, new DateTime(2022, 1, 15, 21, 5, 52, 329, DateTimeKind.Unspecified).AddTicks(5667), 65L, new DateTime(2019, 5, 1, 11, 24, 13, 649, DateTimeKind.Unspecified).AddTicks(5609), new DateTime(2021, 9, 18, 6, 15, 23, 238, DateTimeKind.Unspecified).AddTicks(7364) },
                    { 23L, 15L, new DateTime(2021, 2, 24, 5, 37, 31, 677, DateTimeKind.Unspecified).AddTicks(5702), 1L, false, new DateTime(2022, 1, 29, 3, 40, 55, 204, DateTimeKind.Unspecified).AddTicks(7136), 64L, new DateTime(2020, 1, 29, 8, 28, 23, 986, DateTimeKind.Unspecified).AddTicks(1583), new DateTime(2021, 8, 1, 22, 45, 59, 166, DateTimeKind.Unspecified).AddTicks(4711) },
                    { 24L, 6L, new DateTime(2021, 8, 9, 0, 26, 7, 705, DateTimeKind.Unspecified).AddTicks(3980), 4L, false, new DateTime(2022, 1, 13, 8, 2, 34, 20, DateTimeKind.Unspecified).AddTicks(2335), 63L, new DateTime(2019, 11, 10, 12, 39, 13, 598, DateTimeKind.Unspecified).AddTicks(1584), new DateTime(2021, 8, 16, 6, 4, 45, 667, DateTimeKind.Unspecified).AddTicks(988) },
                    { 25L, 15L, new DateTime(2021, 12, 4, 22, 24, 20, 942, DateTimeKind.Unspecified).AddTicks(1301), 3L, false, new DateTime(2022, 1, 1, 10, 9, 34, 685, DateTimeKind.Unspecified).AddTicks(3999), 26L, new DateTime(2019, 12, 24, 11, 20, 14, 218, DateTimeKind.Unspecified).AddTicks(7934), new DateTime(2021, 2, 26, 1, 25, 52, 454, DateTimeKind.Unspecified).AddTicks(7750) },
                    { 26L, 51L, new DateTime(2021, 2, 23, 12, 55, 55, 909, DateTimeKind.Unspecified).AddTicks(9623), 4L, false, new DateTime(2022, 1, 29, 18, 46, 1, 250, DateTimeKind.Unspecified).AddTicks(7956), 21L, new DateTime(2019, 4, 30, 6, 7, 20, 297, DateTimeKind.Unspecified).AddTicks(5215), new DateTime(2021, 6, 11, 23, 1, 49, 877, DateTimeKind.Unspecified).AddTicks(9513) },
                    { 27L, 27L, new DateTime(2021, 5, 27, 4, 55, 42, 899, DateTimeKind.Unspecified).AddTicks(8270), 2L, false, new DateTime(2022, 1, 12, 14, 34, 21, 637, DateTimeKind.Unspecified).AddTicks(2964), 68L, new DateTime(2019, 12, 7, 16, 1, 22, 712, DateTimeKind.Unspecified).AddTicks(573), new DateTime(2021, 8, 28, 10, 55, 36, 286, DateTimeKind.Unspecified).AddTicks(4350) },
                    { 28L, 23L, new DateTime(2021, 2, 7, 9, 41, 25, 980, DateTimeKind.Unspecified).AddTicks(5776), 2L, false, new DateTime(2022, 1, 10, 10, 35, 56, 38, DateTimeKind.Unspecified).AddTicks(5211), 65L, new DateTime(2019, 4, 30, 1, 1, 17, 747, DateTimeKind.Unspecified).AddTicks(1425), new DateTime(2021, 3, 26, 3, 2, 11, 765, DateTimeKind.Unspecified).AddTicks(5748) },
                    { 29L, 41L, new DateTime(2021, 5, 21, 4, 37, 46, 439, DateTimeKind.Unspecified).AddTicks(388), 4L, false, new DateTime(2022, 1, 14, 15, 32, 35, 476, DateTimeKind.Unspecified).AddTicks(4040), 80L, new DateTime(2019, 2, 10, 8, 45, 36, 787, DateTimeKind.Unspecified).AddTicks(4769), new DateTime(2021, 12, 24, 17, 34, 58, 964, DateTimeKind.Unspecified).AddTicks(5180) },
                    { 30L, 46L, new DateTime(2021, 2, 8, 12, 10, 53, 142, DateTimeKind.Unspecified).AddTicks(822), 5L, false, new DateTime(2022, 1, 18, 2, 12, 36, 603, DateTimeKind.Unspecified).AddTicks(3564), 69L, new DateTime(2019, 11, 27, 5, 17, 39, 422, DateTimeKind.Unspecified).AddTicks(369), new DateTime(2021, 9, 20, 1, 24, 13, 120, DateTimeKind.Unspecified).AddTicks(8941) },
                    { 31L, 22L, new DateTime(2021, 10, 22, 20, 18, 16, 417, DateTimeKind.Unspecified).AddTicks(5162), 5L, false, new DateTime(2022, 1, 26, 11, 39, 25, 590, DateTimeKind.Unspecified).AddTicks(5010), 74L, new DateTime(2019, 2, 4, 6, 18, 17, 80, DateTimeKind.Unspecified).AddTicks(9238), new DateTime(2021, 6, 12, 5, 40, 12, 703, DateTimeKind.Unspecified).AddTicks(2509) },
                    { 32L, 2L, new DateTime(2021, 2, 15, 1, 46, 1, 378, DateTimeKind.Unspecified).AddTicks(2525), 4L, false, null, 7L, new DateTime(2019, 3, 9, 12, 33, 31, 301, DateTimeKind.Unspecified).AddTicks(9662), new DateTime(2021, 4, 30, 0, 48, 42, 905, DateTimeKind.Unspecified).AddTicks(1693) },
                    { 33L, 43L, new DateTime(2021, 11, 30, 5, 18, 27, 977, DateTimeKind.Unspecified).AddTicks(9595), 1L, false, null, 64L, new DateTime(2019, 12, 30, 14, 8, 3, 875, DateTimeKind.Unspecified).AddTicks(4250), new DateTime(2021, 11, 30, 16, 45, 6, 497, DateTimeKind.Unspecified).AddTicks(4648) },
                    { 34L, 16L, new DateTime(2021, 3, 5, 11, 38, 3, 459, DateTimeKind.Unspecified).AddTicks(3432), 5L, false, new DateTime(2022, 1, 21, 13, 20, 56, 818, DateTimeKind.Unspecified).AddTicks(7401), 36L, new DateTime(2019, 3, 8, 14, 59, 36, 714, DateTimeKind.Unspecified).AddTicks(9774), new DateTime(2021, 8, 29, 14, 5, 56, 989, DateTimeKind.Unspecified).AddTicks(4505) },
                    { 35L, 2L, new DateTime(2022, 1, 8, 17, 48, 28, 146, DateTimeKind.Unspecified).AddTicks(9730), 3L, false, new DateTime(2022, 1, 11, 16, 6, 13, 430, DateTimeKind.Unspecified).AddTicks(138), 75L, new DateTime(2019, 10, 25, 13, 21, 46, 241, DateTimeKind.Unspecified).AddTicks(4051), new DateTime(2021, 4, 25, 4, 49, 30, 456, DateTimeKind.Unspecified).AddTicks(4637) },
                    { 36L, 44L, new DateTime(2021, 12, 23, 22, 28, 35, 655, DateTimeKind.Unspecified).AddTicks(3735), 4L, false, new DateTime(2022, 1, 31, 2, 38, 54, 94, DateTimeKind.Unspecified).AddTicks(2576), 59L, new DateTime(2020, 1, 30, 4, 54, 22, 20, DateTimeKind.Unspecified).AddTicks(3220), new DateTime(2021, 2, 23, 12, 20, 38, 570, DateTimeKind.Unspecified).AddTicks(2489) },
                    { 37L, 33L, new DateTime(2021, 11, 17, 20, 32, 22, 868, DateTimeKind.Unspecified).AddTicks(2865), 1L, false, new DateTime(2022, 1, 24, 9, 13, 36, 179, DateTimeKind.Unspecified).AddTicks(9779), 78L, new DateTime(2019, 2, 7, 15, 57, 6, 587, DateTimeKind.Unspecified).AddTicks(1539), new DateTime(2021, 7, 28, 0, 43, 36, 385, DateTimeKind.Unspecified).AddTicks(2868) },
                    { 38L, 15L, new DateTime(2021, 8, 12, 23, 11, 26, 881, DateTimeKind.Unspecified).AddTicks(2592), 5L, false, new DateTime(2022, 1, 17, 17, 42, 32, 253, DateTimeKind.Unspecified).AddTicks(8720), 16L, new DateTime(2019, 10, 20, 16, 38, 15, 790, DateTimeKind.Unspecified).AddTicks(6197), new DateTime(2021, 8, 15, 22, 1, 17, 994, DateTimeKind.Unspecified).AddTicks(6115) },
                    { 39L, 38L, new DateTime(2021, 12, 2, 20, 18, 0, 198, DateTimeKind.Unspecified).AddTicks(508), 5L, false, new DateTime(2022, 1, 25, 8, 43, 21, 5, DateTimeKind.Unspecified).AddTicks(1516), 61L, new DateTime(2019, 7, 25, 1, 57, 45, 520, DateTimeKind.Unspecified).AddTicks(783), new DateTime(2021, 3, 22, 16, 23, 32, 443, DateTimeKind.Unspecified).AddTicks(9723) },
                    { 40L, 44L, new DateTime(2021, 11, 25, 8, 47, 8, 242, DateTimeKind.Unspecified).AddTicks(7846), 2L, false, new DateTime(2022, 2, 1, 18, 51, 12, 733, DateTimeKind.Unspecified).AddTicks(9181), 58L, new DateTime(2019, 10, 1, 8, 44, 25, 741, DateTimeKind.Unspecified).AddTicks(3525), new DateTime(2021, 2, 24, 23, 13, 2, 469, DateTimeKind.Unspecified).AddTicks(9180) },
                    { 41L, 36L, new DateTime(2021, 10, 9, 21, 22, 12, 897, DateTimeKind.Unspecified).AddTicks(4531), 2L, false, new DateTime(2022, 1, 26, 22, 4, 55, 432, DateTimeKind.Unspecified).AddTicks(4184), 68L, new DateTime(2019, 2, 14, 1, 45, 31, 433, DateTimeKind.Unspecified).AddTicks(116), new DateTime(2021, 7, 14, 9, 44, 23, 744, DateTimeKind.Unspecified).AddTicks(1277) },
                    { 42L, 22L, new DateTime(2021, 4, 5, 3, 43, 24, 816, DateTimeKind.Unspecified).AddTicks(2940), 4L, false, new DateTime(2022, 1, 23, 8, 7, 39, 610, DateTimeKind.Unspecified).AddTicks(9318), 67L, new DateTime(2019, 12, 8, 23, 30, 19, 10, DateTimeKind.Unspecified).AddTicks(2629), new DateTime(2021, 2, 15, 13, 43, 22, 304, DateTimeKind.Unspecified).AddTicks(3818) },
                    { 43L, 49L, new DateTime(2021, 11, 8, 6, 44, 19, 648, DateTimeKind.Unspecified).AddTicks(6309), 2L, false, new DateTime(2022, 1, 30, 18, 30, 45, 760, DateTimeKind.Unspecified).AddTicks(9710), 81L, new DateTime(2019, 12, 5, 5, 20, 37, 820, DateTimeKind.Unspecified).AddTicks(5463), new DateTime(2021, 6, 20, 9, 53, 55, 143, DateTimeKind.Unspecified).AddTicks(8852) }
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "IsDeleted", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[,]
                {
                    { 44L, 50L, new DateTime(2021, 7, 4, 2, 59, 51, 593, DateTimeKind.Unspecified).AddTicks(4926), 2L, false, new DateTime(2022, 1, 21, 6, 46, 32, 584, DateTimeKind.Unspecified).AddTicks(6631), 41L, new DateTime(2019, 6, 25, 18, 34, 31, 172, DateTimeKind.Unspecified).AddTicks(3818), new DateTime(2021, 7, 25, 13, 47, 32, 250, DateTimeKind.Unspecified).AddTicks(9240) },
                    { 45L, 20L, new DateTime(2021, 5, 23, 5, 11, 31, 767, DateTimeKind.Unspecified).AddTicks(8652), 4L, false, new DateTime(2022, 1, 26, 1, 49, 1, 696, DateTimeKind.Unspecified).AddTicks(3652), 22L, new DateTime(2019, 10, 18, 12, 8, 37, 746, DateTimeKind.Unspecified).AddTicks(1560), new DateTime(2021, 5, 3, 6, 46, 42, 388, DateTimeKind.Unspecified).AddTicks(5125) },
                    { 46L, 4L, new DateTime(2021, 7, 29, 11, 30, 53, 189, DateTimeKind.Unspecified).AddTicks(153), 4L, false, new DateTime(2022, 1, 18, 12, 39, 48, 488, DateTimeKind.Unspecified).AddTicks(919), 48L, new DateTime(2019, 2, 24, 14, 46, 12, 707, DateTimeKind.Unspecified).AddTicks(4290), new DateTime(2021, 6, 12, 18, 51, 40, 612, DateTimeKind.Unspecified).AddTicks(4634) },
                    { 47L, 40L, new DateTime(2021, 2, 11, 18, 55, 45, 173, DateTimeKind.Unspecified).AddTicks(4383), 2L, false, new DateTime(2022, 1, 17, 9, 30, 40, 582, DateTimeKind.Unspecified).AddTicks(2675), 58L, new DateTime(2019, 9, 26, 9, 11, 26, 112, DateTimeKind.Unspecified).AddTicks(3671), new DateTime(2021, 3, 1, 17, 1, 18, 187, DateTimeKind.Unspecified).AddTicks(5478) },
                    { 48L, 11L, new DateTime(2021, 6, 5, 8, 41, 29, 656, DateTimeKind.Unspecified).AddTicks(472), 2L, false, new DateTime(2022, 1, 4, 18, 48, 53, 214, DateTimeKind.Unspecified).AddTicks(5783), 66L, new DateTime(2019, 12, 4, 15, 47, 3, 803, DateTimeKind.Unspecified).AddTicks(2576), new DateTime(2021, 7, 29, 22, 21, 44, 424, DateTimeKind.Unspecified).AddTicks(6527) },
                    { 49L, 4L, new DateTime(2021, 3, 10, 13, 45, 3, 404, DateTimeKind.Unspecified).AddTicks(9399), 3L, false, null, 7L, new DateTime(2019, 4, 30, 10, 12, 37, 302, DateTimeKind.Unspecified).AddTicks(5949), new DateTime(2021, 2, 11, 22, 12, 14, 30, DateTimeKind.Unspecified).AddTicks(6833) },
                    { 50L, 24L, new DateTime(2022, 1, 25, 8, 58, 5, 660, DateTimeKind.Unspecified).AddTicks(5829), 1L, false, new DateTime(2022, 1, 22, 22, 37, 57, 834, DateTimeKind.Unspecified).AddTicks(585), 62L, new DateTime(2019, 5, 25, 21, 46, 14, 448, DateTimeKind.Unspecified).AddTicks(4357), new DateTime(2021, 3, 26, 19, 6, 9, 978, DateTimeKind.Unspecified).AddTicks(9412) },
                    { 51L, 50L, new DateTime(2021, 7, 3, 6, 10, 29, 649, DateTimeKind.Unspecified).AddTicks(6227), 5L, false, new DateTime(2022, 1, 5, 2, 7, 10, 468, DateTimeKind.Unspecified).AddTicks(5330), 80L, new DateTime(2019, 4, 17, 5, 44, 5, 374, DateTimeKind.Unspecified).AddTicks(1274), new DateTime(2021, 2, 13, 19, 48, 1, 107, DateTimeKind.Unspecified).AddTicks(8284) },
                    { 52L, 9L, new DateTime(2021, 12, 14, 15, 56, 48, 939, DateTimeKind.Unspecified).AddTicks(4926), 3L, false, new DateTime(2022, 1, 19, 8, 5, 40, 456, DateTimeKind.Unspecified).AddTicks(3175), 53L, new DateTime(2019, 12, 26, 12, 8, 5, 555, DateTimeKind.Unspecified).AddTicks(9061), new DateTime(2021, 10, 23, 19, 24, 21, 397, DateTimeKind.Unspecified).AddTicks(6044) },
                    { 53L, 26L, new DateTime(2021, 10, 19, 5, 33, 15, 168, DateTimeKind.Unspecified).AddTicks(381), 3L, false, new DateTime(2022, 1, 28, 8, 10, 27, 6, DateTimeKind.Unspecified).AddTicks(7248), 58L, new DateTime(2019, 12, 29, 13, 3, 33, 205, DateTimeKind.Unspecified).AddTicks(2894), new DateTime(2021, 11, 20, 6, 53, 3, 348, DateTimeKind.Unspecified).AddTicks(3454) },
                    { 54L, 3L, new DateTime(2021, 9, 6, 7, 1, 56, 857, DateTimeKind.Unspecified).AddTicks(7834), 3L, false, new DateTime(2022, 1, 22, 23, 22, 38, 845, DateTimeKind.Unspecified).AddTicks(3074), 59L, new DateTime(2019, 5, 21, 20, 3, 38, 976, DateTimeKind.Unspecified).AddTicks(2079), new DateTime(2021, 8, 12, 14, 14, 20, 46, DateTimeKind.Unspecified).AddTicks(4285) },
                    { 55L, 35L, new DateTime(2021, 4, 25, 16, 30, 54, 528, DateTimeKind.Unspecified).AddTicks(7200), 4L, false, null, 46L, new DateTime(2019, 9, 11, 23, 19, 5, 302, DateTimeKind.Unspecified).AddTicks(4301), new DateTime(2021, 2, 5, 12, 49, 27, 639, DateTimeKind.Unspecified).AddTicks(3664) },
                    { 56L, 26L, new DateTime(2022, 1, 15, 2, 5, 32, 765, DateTimeKind.Unspecified).AddTicks(2609), 4L, false, new DateTime(2022, 1, 31, 19, 43, 42, 934, DateTimeKind.Unspecified).AddTicks(2940), 55L, new DateTime(2019, 10, 14, 2, 20, 56, 784, DateTimeKind.Unspecified).AddTicks(273), new DateTime(2021, 7, 2, 23, 13, 40, 465, DateTimeKind.Unspecified).AddTicks(2460) },
                    { 57L, 47L, new DateTime(2021, 12, 28, 23, 52, 3, 210, DateTimeKind.Unspecified).AddTicks(7935), 3L, false, new DateTime(2022, 1, 14, 6, 59, 30, 95, DateTimeKind.Unspecified).AddTicks(8354), 21L, new DateTime(2019, 5, 12, 4, 45, 39, 924, DateTimeKind.Unspecified).AddTicks(2198), new DateTime(2021, 7, 20, 22, 51, 5, 484, DateTimeKind.Unspecified).AddTicks(2223) },
                    { 58L, 17L, new DateTime(2021, 9, 16, 5, 36, 30, 299, DateTimeKind.Unspecified).AddTicks(9912), 3L, false, new DateTime(2022, 1, 4, 3, 33, 1, 946, DateTimeKind.Unspecified).AddTicks(1659), 23L, new DateTime(2019, 6, 10, 14, 23, 14, 479, DateTimeKind.Unspecified).AddTicks(6595), new DateTime(2021, 11, 2, 20, 43, 50, 199, DateTimeKind.Unspecified).AddTicks(7428) },
                    { 59L, 17L, new DateTime(2021, 7, 18, 19, 17, 31, 925, DateTimeKind.Unspecified).AddTicks(7958), 3L, false, null, 36L, new DateTime(2019, 10, 21, 14, 41, 13, 380, DateTimeKind.Unspecified).AddTicks(8287), new DateTime(2021, 3, 2, 10, 51, 40, 187, DateTimeKind.Unspecified).AddTicks(6551) },
                    { 60L, 38L, new DateTime(2022, 1, 21, 0, 18, 42, 544, DateTimeKind.Unspecified).AddTicks(6662), 5L, false, new DateTime(2022, 1, 21, 6, 1, 31, 35, DateTimeKind.Unspecified).AddTicks(8470), 21L, new DateTime(2019, 11, 20, 23, 43, 32, 991, DateTimeKind.Unspecified).AddTicks(3117), new DateTime(2021, 1, 30, 13, 0, 6, 324, DateTimeKind.Unspecified).AddTicks(1744) },
                    { 61L, 17L, new DateTime(2021, 12, 10, 23, 37, 18, 435, DateTimeKind.Unspecified).AddTicks(9100), 3L, false, new DateTime(2022, 1, 26, 23, 21, 6, 852, DateTimeKind.Unspecified).AddTicks(5655), 79L, new DateTime(2019, 3, 26, 15, 27, 32, 943, DateTimeKind.Unspecified).AddTicks(216), new DateTime(2021, 8, 21, 17, 29, 29, 594, DateTimeKind.Unspecified).AddTicks(5482) },
                    { 62L, 24L, new DateTime(2022, 1, 21, 1, 33, 19, 985, DateTimeKind.Unspecified).AddTicks(8823), 3L, false, new DateTime(2022, 1, 14, 15, 19, 23, 765, DateTimeKind.Unspecified).AddTicks(5500), 27L, new DateTime(2019, 7, 7, 4, 52, 3, 27, DateTimeKind.Unspecified).AddTicks(4729), new DateTime(2021, 3, 30, 8, 56, 59, 860, DateTimeKind.Unspecified).AddTicks(4168) },
                    { 63L, 15L, new DateTime(2021, 10, 16, 5, 28, 52, 606, DateTimeKind.Unspecified).AddTicks(2354), 4L, false, new DateTime(2022, 1, 31, 7, 48, 34, 692, DateTimeKind.Unspecified).AddTicks(961), 58L, new DateTime(2019, 2, 25, 7, 28, 14, 526, DateTimeKind.Unspecified).AddTicks(3943), new DateTime(2021, 8, 1, 19, 8, 15, 644, DateTimeKind.Unspecified).AddTicks(2826) },
                    { 64L, 32L, new DateTime(2021, 9, 6, 17, 41, 0, 241, DateTimeKind.Unspecified).AddTicks(2550), 2L, false, new DateTime(2022, 1, 12, 12, 40, 28, 466, DateTimeKind.Unspecified).AddTicks(686), 44L, new DateTime(2019, 12, 30, 23, 12, 4, 375, DateTimeKind.Unspecified).AddTicks(9261), new DateTime(2021, 11, 15, 9, 47, 28, 331, DateTimeKind.Unspecified).AddTicks(4187) },
                    { 65L, 24L, new DateTime(2021, 10, 9, 12, 41, 11, 459, DateTimeKind.Unspecified).AddTicks(4785), 1L, false, new DateTime(2022, 1, 17, 6, 7, 47, 454, DateTimeKind.Unspecified).AddTicks(3245), 9L, new DateTime(2020, 1, 19, 5, 10, 48, 906, DateTimeKind.Unspecified).AddTicks(4199), new DateTime(2021, 1, 24, 22, 3, 36, 618, DateTimeKind.Unspecified).AddTicks(1204) },
                    { 66L, 2L, new DateTime(2021, 3, 18, 11, 52, 35, 373, DateTimeKind.Unspecified).AddTicks(1015), 1L, false, null, 51L, new DateTime(2019, 6, 6, 11, 20, 41, 695, DateTimeKind.Unspecified).AddTicks(4901), new DateTime(2021, 4, 4, 7, 46, 17, 333, DateTimeKind.Unspecified).AddTicks(6377) },
                    { 67L, 16L, new DateTime(2021, 12, 11, 5, 25, 49, 966, DateTimeKind.Unspecified).AddTicks(2282), 4L, false, new DateTime(2022, 1, 2, 22, 46, 47, 472, DateTimeKind.Unspecified).AddTicks(5458), 40L, new DateTime(2019, 6, 25, 3, 34, 38, 750, DateTimeKind.Unspecified).AddTicks(2677), new DateTime(2021, 8, 8, 1, 16, 53, 363, DateTimeKind.Unspecified).AddTicks(5125) },
                    { 68L, 32L, new DateTime(2022, 1, 15, 0, 26, 50, 486, DateTimeKind.Unspecified).AddTicks(9805), 3L, false, new DateTime(2022, 1, 13, 3, 22, 23, 715, DateTimeKind.Unspecified).AddTicks(1071), 56L, new DateTime(2019, 3, 13, 9, 10, 35, 972, DateTimeKind.Unspecified).AddTicks(9891), new DateTime(2021, 7, 7, 11, 35, 20, 143, DateTimeKind.Unspecified).AddTicks(3108) },
                    { 69L, 42L, new DateTime(2021, 4, 1, 1, 53, 39, 643, DateTimeKind.Unspecified).AddTicks(5200), 3L, false, new DateTime(2022, 1, 26, 13, 54, 48, 320, DateTimeKind.Unspecified).AddTicks(6169), 66L, new DateTime(2019, 3, 16, 10, 34, 44, 436, DateTimeKind.Unspecified).AddTicks(4150), new DateTime(2021, 1, 8, 7, 12, 51, 942, DateTimeKind.Unspecified).AddTicks(599) },
                    { 70L, 14L, new DateTime(2021, 8, 15, 7, 59, 3, 235, DateTimeKind.Unspecified).AddTicks(4584), 2L, false, null, 56L, new DateTime(2019, 7, 30, 20, 16, 45, 717, DateTimeKind.Unspecified).AddTicks(2638), new DateTime(2021, 8, 19, 10, 15, 54, 666, DateTimeKind.Unspecified).AddTicks(1996) },
                    { 71L, 25L, new DateTime(2021, 7, 12, 1, 25, 2, 474, DateTimeKind.Unspecified).AddTicks(4385), 1L, false, null, 18L, new DateTime(2019, 4, 22, 10, 25, 55, 95, DateTimeKind.Unspecified).AddTicks(7333), new DateTime(2021, 6, 25, 23, 41, 45, 64, DateTimeKind.Unspecified).AddTicks(1964) },
                    { 72L, 37L, new DateTime(2021, 2, 12, 3, 47, 28, 643, DateTimeKind.Unspecified).AddTicks(7384), 4L, false, new DateTime(2022, 1, 25, 15, 49, 57, 415, DateTimeKind.Unspecified).AddTicks(9149), 53L, new DateTime(2019, 10, 15, 5, 31, 36, 166, DateTimeKind.Unspecified).AddTicks(4829), new DateTime(2021, 5, 13, 15, 20, 56, 867, DateTimeKind.Unspecified).AddTicks(1171) },
                    { 73L, 43L, new DateTime(2021, 4, 16, 22, 44, 33, 22, DateTimeKind.Unspecified).AddTicks(4201), 1L, false, new DateTime(2022, 1, 6, 16, 29, 33, 259, DateTimeKind.Unspecified).AddTicks(6778), 58L, new DateTime(2019, 5, 13, 16, 1, 44, 474, DateTimeKind.Unspecified).AddTicks(6027), new DateTime(2021, 6, 3, 21, 2, 29, 480, DateTimeKind.Unspecified).AddTicks(6970) },
                    { 74L, 42L, new DateTime(2021, 11, 18, 1, 33, 19, 733, DateTimeKind.Unspecified).AddTicks(7412), 5L, false, new DateTime(2022, 1, 21, 14, 58, 9, 978, DateTimeKind.Unspecified).AddTicks(3326), 62L, new DateTime(2020, 1, 23, 4, 3, 50, 985, DateTimeKind.Unspecified).AddTicks(8256), new DateTime(2021, 3, 22, 7, 28, 37, 377, DateTimeKind.Unspecified).AddTicks(2460) },
                    { 75L, 25L, new DateTime(2021, 5, 29, 20, 38, 31, 885, DateTimeKind.Unspecified).AddTicks(1546), 3L, false, new DateTime(2022, 1, 21, 21, 5, 42, 145, DateTimeKind.Unspecified).AddTicks(9969), 43L, new DateTime(2019, 11, 13, 19, 44, 26, 269, DateTimeKind.Unspecified).AddTicks(2431), new DateTime(2021, 11, 29, 19, 27, 37, 485, DateTimeKind.Unspecified).AddTicks(8992) },
                    { 76L, 3L, new DateTime(2021, 3, 20, 18, 30, 47, 71, DateTimeKind.Unspecified).AddTicks(7666), 1L, false, new DateTime(2022, 1, 3, 18, 37, 33, 80, DateTimeKind.Unspecified).AddTicks(1459), 52L, new DateTime(2019, 3, 7, 17, 23, 5, 261, DateTimeKind.Unspecified).AddTicks(8107), new DateTime(2021, 3, 28, 19, 52, 2, 381, DateTimeKind.Unspecified).AddTicks(4746) },
                    { 77L, 27L, new DateTime(2022, 1, 3, 20, 13, 50, 493, DateTimeKind.Unspecified).AddTicks(9535), 4L, false, new DateTime(2022, 1, 10, 5, 18, 49, 145, DateTimeKind.Unspecified).AddTicks(1350), 26L, new DateTime(2019, 3, 2, 14, 52, 5, 486, DateTimeKind.Unspecified).AddTicks(7669), new DateTime(2021, 9, 10, 20, 48, 35, 877, DateTimeKind.Unspecified).AddTicks(3726) },
                    { 78L, 29L, new DateTime(2021, 7, 16, 20, 47, 1, 613, DateTimeKind.Unspecified).AddTicks(9933), 4L, false, new DateTime(2022, 2, 1, 13, 46, 26, 619, DateTimeKind.Unspecified).AddTicks(4554), 37L, new DateTime(2019, 9, 2, 10, 11, 44, 81, DateTimeKind.Unspecified).AddTicks(8013), new DateTime(2021, 6, 1, 8, 4, 46, 707, DateTimeKind.Unspecified).AddTicks(5847) },
                    { 79L, 51L, new DateTime(2021, 11, 18, 16, 31, 59, 890, DateTimeKind.Unspecified).AddTicks(5060), 3L, false, new DateTime(2022, 1, 24, 5, 41, 55, 225, DateTimeKind.Unspecified).AddTicks(4871), 48L, new DateTime(2019, 8, 18, 9, 50, 35, 137, DateTimeKind.Unspecified).AddTicks(1647), new DateTime(2021, 7, 25, 8, 8, 46, 509, DateTimeKind.Unspecified).AddTicks(200) },
                    { 80L, 32L, new DateTime(2021, 9, 9, 3, 53, 59, 813, DateTimeKind.Unspecified).AddTicks(6949), 4L, false, new DateTime(2022, 1, 3, 10, 41, 0, 870, DateTimeKind.Unspecified).AddTicks(2213), 51L, new DateTime(2019, 4, 2, 12, 30, 50, 306, DateTimeKind.Unspecified).AddTicks(5408), new DateTime(2021, 7, 1, 17, 30, 38, 128, DateTimeKind.Unspecified).AddTicks(3547) },
                    { 81L, 25L, new DateTime(2021, 3, 6, 23, 5, 43, 642, DateTimeKind.Unspecified).AddTicks(6460), 4L, false, new DateTime(2022, 1, 24, 17, 0, 51, 802, DateTimeKind.Unspecified).AddTicks(7785), 8L, new DateTime(2019, 12, 29, 7, 40, 52, 112, DateTimeKind.Unspecified).AddTicks(5490), new DateTime(2021, 10, 10, 0, 15, 29, 637, DateTimeKind.Unspecified).AddTicks(1226) },
                    { 82L, 28L, new DateTime(2021, 8, 18, 22, 31, 54, 577, DateTimeKind.Unspecified).AddTicks(63), 1L, false, null, 29L, new DateTime(2019, 10, 27, 6, 13, 20, 326, DateTimeKind.Unspecified).AddTicks(1462), new DateTime(2021, 7, 28, 23, 50, 45, 596, DateTimeKind.Unspecified).AddTicks(7304) },
                    { 83L, 47L, new DateTime(2021, 10, 2, 5, 31, 2, 316, DateTimeKind.Unspecified).AddTicks(3748), 5L, false, new DateTime(2022, 2, 1, 17, 24, 2, 301, DateTimeKind.Unspecified).AddTicks(4530), 27L, new DateTime(2019, 8, 7, 23, 29, 48, 809, DateTimeKind.Unspecified).AddTicks(7024), new DateTime(2021, 7, 16, 12, 44, 5, 809, DateTimeKind.Unspecified).AddTicks(4080) },
                    { 84L, 13L, new DateTime(2021, 4, 14, 9, 12, 14, 614, DateTimeKind.Unspecified).AddTicks(152), 3L, false, null, 6L, new DateTime(2019, 11, 22, 16, 17, 22, 215, DateTimeKind.Unspecified).AddTicks(8052), new DateTime(2021, 1, 30, 20, 53, 31, 702, DateTimeKind.Unspecified).AddTicks(2015) },
                    { 85L, 37L, new DateTime(2021, 9, 18, 14, 41, 58, 592, DateTimeKind.Unspecified).AddTicks(6535), 1L, false, new DateTime(2022, 1, 5, 18, 52, 1, 48, DateTimeKind.Unspecified).AddTicks(6430), 52L, new DateTime(2019, 6, 7, 4, 36, 12, 773, DateTimeKind.Unspecified).AddTicks(1216), new DateTime(2021, 8, 3, 7, 15, 37, 191, DateTimeKind.Unspecified).AddTicks(8576) }
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "IsDeleted", "LastReviewed", "LessonId", "StartedDate", "SubmittedDate" },
                values: new object[,]
                {
                    { 86L, 45L, new DateTime(2021, 8, 4, 15, 32, 57, 745, DateTimeKind.Unspecified).AddTicks(2432), 4L, false, new DateTime(2022, 1, 18, 3, 51, 14, 297, DateTimeKind.Unspecified).AddTicks(5940), 36L, new DateTime(2019, 3, 24, 18, 47, 16, 239, DateTimeKind.Unspecified).AddTicks(6868), new DateTime(2021, 10, 26, 0, 20, 45, 433, DateTimeKind.Unspecified).AddTicks(3579) },
                    { 87L, 33L, new DateTime(2021, 4, 25, 11, 21, 8, 221, DateTimeKind.Unspecified).AddTicks(5583), 3L, false, null, 24L, new DateTime(2019, 9, 17, 5, 31, 45, 103, DateTimeKind.Unspecified).AddTicks(1071), new DateTime(2021, 8, 14, 19, 53, 28, 877, DateTimeKind.Unspecified).AddTicks(9679) },
                    { 88L, 7L, new DateTime(2021, 11, 17, 13, 26, 21, 567, DateTimeKind.Unspecified).AddTicks(1699), 4L, false, new DateTime(2022, 1, 30, 12, 58, 14, 809, DateTimeKind.Unspecified).AddTicks(6716), 57L, new DateTime(2019, 3, 15, 10, 36, 37, 39, DateTimeKind.Unspecified).AddTicks(3850), new DateTime(2021, 5, 28, 15, 50, 15, 691, DateTimeKind.Unspecified).AddTicks(8165) },
                    { 89L, 11L, new DateTime(2021, 3, 26, 12, 27, 9, 543, DateTimeKind.Unspecified).AddTicks(8677), 4L, false, new DateTime(2022, 1, 13, 21, 37, 21, 475, DateTimeKind.Unspecified).AddTicks(3859), 28L, new DateTime(2019, 12, 24, 10, 4, 32, 706, DateTimeKind.Unspecified).AddTicks(5106), new DateTime(2021, 11, 26, 5, 53, 2, 19, DateTimeKind.Unspecified).AddTicks(1750) },
                    { 90L, 41L, new DateTime(2021, 5, 1, 6, 21, 33, 753, DateTimeKind.Unspecified).AddTicks(4841), 3L, false, null, 39L, new DateTime(2019, 8, 20, 3, 34, 58, 940, DateTimeKind.Unspecified).AddTicks(7838), new DateTime(2021, 8, 14, 11, 25, 32, 343, DateTimeKind.Unspecified).AddTicks(6020) },
                    { 91L, 50L, new DateTime(2021, 9, 17, 12, 51, 31, 265, DateTimeKind.Unspecified).AddTicks(9741), 1L, false, new DateTime(2022, 1, 21, 4, 36, 19, 23, DateTimeKind.Unspecified).AddTicks(9829), 32L, new DateTime(2019, 9, 6, 13, 25, 50, 369, DateTimeKind.Unspecified).AddTicks(5519), new DateTime(2021, 6, 27, 0, 23, 56, 600, DateTimeKind.Unspecified).AddTicks(5770) },
                    { 92L, 37L, new DateTime(2021, 12, 2, 19, 43, 19, 599, DateTimeKind.Unspecified).AddTicks(1963), 2L, false, new DateTime(2022, 1, 29, 19, 26, 2, 720, DateTimeKind.Unspecified).AddTicks(9334), 58L, new DateTime(2019, 12, 31, 14, 15, 15, 957, DateTimeKind.Unspecified).AddTicks(2900), new DateTime(2021, 5, 18, 1, 33, 12, 682, DateTimeKind.Unspecified).AddTicks(6429) },
                    { 93L, 3L, new DateTime(2022, 1, 17, 0, 30, 33, 88, DateTimeKind.Unspecified).AddTicks(3079), 2L, false, new DateTime(2022, 1, 10, 17, 58, 52, 349, DateTimeKind.Unspecified).AddTicks(5019), 60L, new DateTime(2019, 12, 12, 18, 33, 47, 851, DateTimeKind.Unspecified).AddTicks(5546), new DateTime(2021, 4, 30, 7, 8, 55, 274, DateTimeKind.Unspecified).AddTicks(1019) },
                    { 94L, 35L, new DateTime(2021, 9, 4, 2, 42, 23, 60, DateTimeKind.Unspecified).AddTicks(8974), 5L, false, null, 35L, new DateTime(2019, 3, 21, 10, 45, 0, 605, DateTimeKind.Unspecified).AddTicks(2719), new DateTime(2021, 3, 30, 6, 24, 54, 924, DateTimeKind.Unspecified).AddTicks(5918) },
                    { 95L, 5L, new DateTime(2021, 5, 14, 14, 53, 5, 616, DateTimeKind.Unspecified).AddTicks(3543), 2L, false, new DateTime(2022, 2, 1, 5, 21, 51, 544, DateTimeKind.Unspecified).AddTicks(3871), 6L, new DateTime(2019, 2, 21, 8, 40, 32, 567, DateTimeKind.Unspecified).AddTicks(3606), new DateTime(2021, 3, 2, 5, 3, 26, 426, DateTimeKind.Unspecified).AddTicks(3011) },
                    { 96L, 23L, new DateTime(2021, 5, 3, 5, 53, 41, 757, DateTimeKind.Unspecified).AddTicks(3622), 1L, false, new DateTime(2022, 1, 28, 8, 50, 41, 911, DateTimeKind.Unspecified).AddTicks(5110), 37L, new DateTime(2019, 5, 15, 6, 37, 46, 585, DateTimeKind.Unspecified).AddTicks(5444), new DateTime(2021, 1, 10, 16, 29, 30, 594, DateTimeKind.Unspecified).AddTicks(5947) },
                    { 97L, 10L, new DateTime(2021, 5, 31, 9, 52, 11, 595, DateTimeKind.Unspecified).AddTicks(4225), 4L, false, new DateTime(2022, 1, 31, 5, 17, 12, 500, DateTimeKind.Unspecified).AddTicks(1954), 40L, new DateTime(2019, 9, 28, 1, 52, 4, 463, DateTimeKind.Unspecified).AddTicks(5896), new DateTime(2021, 6, 13, 18, 56, 16, 826, DateTimeKind.Unspecified).AddTicks(7368) },
                    { 98L, 40L, new DateTime(2021, 5, 31, 13, 31, 47, 502, DateTimeKind.Unspecified).AddTicks(6381), 4L, false, new DateTime(2022, 1, 24, 20, 2, 31, 215, DateTimeKind.Unspecified).AddTicks(3202), 16L, new DateTime(2019, 11, 28, 19, 13, 2, 676, DateTimeKind.Unspecified).AddTicks(5621), new DateTime(2021, 8, 3, 8, 2, 17, 580, DateTimeKind.Unspecified).AddTicks(6124) },
                    { 99L, 38L, new DateTime(2022, 1, 4, 3, 22, 6, 941, DateTimeKind.Unspecified).AddTicks(9935), 1L, false, new DateTime(2022, 1, 12, 10, 33, 24, 849, DateTimeKind.Unspecified).AddTicks(5604), 54L, new DateTime(2019, 9, 14, 1, 7, 56, 693, DateTimeKind.Unspecified).AddTicks(7215), new DateTime(2021, 6, 27, 17, 22, 35, 346, DateTimeKind.Unspecified).AddTicks(5434) },
                    { 100L, 45L, new DateTime(2021, 8, 30, 14, 24, 9, 840, DateTimeKind.Unspecified).AddTicks(5743), 4L, false, null, 41L, new DateTime(2020, 1, 4, 14, 9, 27, 298, DateTimeKind.Unspecified).AddTicks(4286), new DateTime(2021, 8, 1, 19, 43, 58, 977, DateTimeKind.Unspecified).AddTicks(8602) },
                    { 101L, 25L, new DateTime(2021, 8, 15, 21, 6, 13, 421, DateTimeKind.Unspecified).AddTicks(2648), 2L, false, new DateTime(2022, 1, 22, 0, 20, 54, 479, DateTimeKind.Unspecified).AddTicks(140), 44L, new DateTime(2019, 12, 29, 14, 52, 27, 470, DateTimeKind.Unspecified).AddTicks(1922), new DateTime(2021, 11, 14, 14, 35, 26, 91, DateTimeKind.Unspecified).AddTicks(5435) }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsDeleted", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[,]
                {
                    { 2L, 9L, new DateTime(2021, 7, 12, 4, 24, 41, 598, DateTimeKind.Unspecified).AddTicks(330), 5L, 542, false, false, 57L, null, 72 },
                    { 5L, 40L, new DateTime(2022, 1, 3, 7, 18, 47, 381, DateTimeKind.Unspecified).AddTicks(8541), 3L, 691, false, true, 14L, null, 94 },
                    { 6L, 20L, new DateTime(2021, 2, 17, 19, 34, 43, 641, DateTimeKind.Unspecified).AddTicks(8659), 1L, 692, false, true, 69L, null, 293 },
                    { 7L, 35L, new DateTime(2021, 8, 3, 6, 48, 25, 426, DateTimeKind.Unspecified).AddTicks(9800), 1L, 939, false, false, 69L, null, 452 },
                    { 9L, 24L, new DateTime(2021, 11, 11, 17, 50, 18, 516, DateTimeKind.Unspecified).AddTicks(9638), 1L, 914, false, false, 54L, null, 164 },
                    { 14L, 34L, new DateTime(2021, 3, 21, 0, 12, 11, 309, DateTimeKind.Unspecified).AddTicks(8941), 4L, 990, false, false, 15L, null, 366 },
                    { 17L, 43L, new DateTime(2021, 8, 13, 8, 16, 35, 138, DateTimeKind.Unspecified).AddTicks(7857), 3L, 517, false, false, 21L, null, 282 },
                    { 18L, 46L, new DateTime(2021, 3, 3, 11, 54, 52, 658, DateTimeKind.Unspecified).AddTicks(4160), 2L, 783, false, true, 31L, null, 44 },
                    { 19L, 38L, new DateTime(2021, 7, 25, 11, 33, 47, 315, DateTimeKind.Unspecified).AddTicks(5302), 1L, 939, false, false, 60L, null, 65 },
                    { 25L, 24L, new DateTime(2021, 8, 13, 23, 22, 21, 985, DateTimeKind.Unspecified).AddTicks(6523), 5L, 548, false, false, 44L, null, 33 },
                    { 26L, 16L, new DateTime(2021, 9, 7, 8, 34, 37, 650, DateTimeKind.Unspecified).AddTicks(1144), 1L, 968, false, false, 75L, null, 113 },
                    { 27L, 30L, new DateTime(2021, 11, 20, 23, 49, 57, 256, DateTimeKind.Unspecified).AddTicks(1759), 3L, 814, false, true, 19L, null, 479 },
                    { 28L, 5L, new DateTime(2021, 2, 20, 3, 40, 33, 500, DateTimeKind.Unspecified).AddTicks(1038), 3L, 523, false, false, 70L, null, 105 },
                    { 31L, 45L, new DateTime(2021, 10, 22, 19, 42, 10, 380, DateTimeKind.Unspecified).AddTicks(7827), 5L, 553, false, false, 71L, null, 333 },
                    { 35L, 25L, new DateTime(2021, 10, 23, 17, 26, 3, 76, DateTimeKind.Unspecified).AddTicks(9798), 2L, 801, false, true, 56L, null, 96 },
                    { 36L, 42L, new DateTime(2021, 5, 15, 8, 14, 28, 255, DateTimeKind.Unspecified).AddTicks(1448), 1L, 502, false, false, 31L, null, 445 },
                    { 39L, 50L, new DateTime(2021, 8, 6, 6, 8, 22, 247, DateTimeKind.Unspecified).AddTicks(6582), 4L, 732, false, false, 42L, null, 332 },
                    { 40L, 28L, new DateTime(2021, 3, 16, 9, 22, 46, 401, DateTimeKind.Unspecified).AddTicks(8982), 3L, 825, false, false, 34L, null, 338 },
                    { 42L, 2L, new DateTime(2021, 3, 9, 19, 19, 12, 447, DateTimeKind.Unspecified).AddTicks(9624), 3L, 917, false, true, 8L, null, 423 },
                    { 44L, 24L, new DateTime(2021, 11, 11, 3, 13, 40, 885, DateTimeKind.Unspecified).AddTicks(1123), 1L, 809, false, true, 45L, null, 365 },
                    { 47L, 50L, new DateTime(2021, 5, 15, 14, 13, 18, 145, DateTimeKind.Unspecified).AddTicks(4164), 4L, 941, false, true, 29L, null, 122 },
                    { 48L, 41L, new DateTime(2021, 11, 9, 7, 40, 17, 926, DateTimeKind.Unspecified).AddTicks(4540), 5L, 568, false, false, 51L, null, 37 },
                    { 50L, 37L, new DateTime(2021, 6, 22, 5, 15, 20, 396, DateTimeKind.Unspecified).AddTicks(6795), 1L, 745, false, false, 55L, null, 398 },
                    { 53L, 49L, new DateTime(2021, 4, 11, 21, 59, 47, 297, DateTimeKind.Unspecified).AddTicks(8996), 5L, 757, false, true, 39L, null, 126 },
                    { 54L, 14L, new DateTime(2021, 7, 9, 21, 21, 1, 709, DateTimeKind.Unspecified).AddTicks(7080), 5L, 710, false, true, 38L, null, 482 },
                    { 56L, 5L, new DateTime(2021, 3, 14, 10, 35, 45, 947, DateTimeKind.Unspecified).AddTicks(6082), 2L, 581, false, true, 71L, null, 358 }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "CreatedBy", "EndPosition", "IsDeleted", "IsResolved", "LessonId", "ProjectId", "StartPosition" },
                values: new object[,]
                {
                    { 58L, 29L, new DateTime(2021, 7, 21, 12, 3, 13, 541, DateTimeKind.Unspecified).AddTicks(2356), 5L, 872, false, true, 42L, null, 426 },
                    { 60L, 35L, new DateTime(2021, 9, 18, 0, 34, 29, 382, DateTimeKind.Unspecified).AddTicks(8220), 4L, 819, false, true, 7L, null, 429 },
                    { 61L, 25L, new DateTime(2021, 5, 16, 17, 32, 22, 93, DateTimeKind.Unspecified).AddTicks(292), 1L, 647, false, true, 79L, null, 199 },
                    { 63L, 8L, new DateTime(2021, 12, 20, 11, 19, 10, 813, DateTimeKind.Unspecified).AddTicks(9070), 5L, 797, false, true, 58L, null, 456 },
                    { 64L, 39L, new DateTime(2021, 11, 30, 9, 33, 42, 681, DateTimeKind.Unspecified).AddTicks(586), 5L, 609, false, false, 40L, null, 415 },
                    { 65L, 35L, new DateTime(2021, 4, 19, 4, 32, 5, 582, DateTimeKind.Unspecified).AddTicks(663), 1L, 556, false, true, 22L, null, 255 },
                    { 66L, 23L, new DateTime(2021, 11, 5, 7, 33, 54, 768, DateTimeKind.Unspecified).AddTicks(3229), 2L, 988, false, false, 61L, null, 14 },
                    { 67L, 7L, new DateTime(2021, 12, 27, 3, 36, 51, 391, DateTimeKind.Unspecified).AddTicks(8738), 2L, 522, false, false, 24L, null, 12 },
                    { 68L, 46L, new DateTime(2021, 10, 8, 23, 51, 19, 83, DateTimeKind.Unspecified).AddTicks(9759), 1L, 880, false, false, 74L, null, 96 },
                    { 69L, 37L, new DateTime(2021, 2, 24, 22, 44, 14, 165, DateTimeKind.Unspecified).AddTicks(2301), 5L, 653, false, false, 11L, null, 110 },
                    { 70L, 50L, new DateTime(2021, 6, 4, 9, 46, 58, 254, DateTimeKind.Unspecified).AddTicks(2130), 2L, 926, false, true, 48L, null, 98 },
                    { 71L, 44L, new DateTime(2021, 2, 3, 21, 2, 48, 378, DateTimeKind.Unspecified).AddTicks(1604), 3L, 978, false, false, 34L, null, 398 },
                    { 72L, 17L, new DateTime(2021, 7, 30, 15, 56, 46, 975, DateTimeKind.Unspecified).AddTicks(696), 1L, 933, false, true, 58L, null, 491 },
                    { 75L, 5L, new DateTime(2021, 11, 6, 13, 11, 56, 824, DateTimeKind.Unspecified).AddTicks(4047), 3L, 521, false, true, 19L, null, 168 },
                    { 77L, 20L, new DateTime(2021, 8, 24, 11, 46, 43, 668, DateTimeKind.Unspecified).AddTicks(9941), 3L, 698, false, true, 8L, null, 307 },
                    { 78L, 41L, new DateTime(2021, 4, 20, 4, 20, 8, 599, DateTimeKind.Unspecified).AddTicks(3527), 1L, 822, false, false, 67L, null, 93 },
                    { 79L, 7L, new DateTime(2021, 11, 30, 5, 12, 29, 602, DateTimeKind.Unspecified).AddTicks(9166), 3L, 981, false, false, 54L, null, 443 },
                    { 81L, 31L, new DateTime(2021, 6, 27, 2, 42, 1, 694, DateTimeKind.Unspecified).AddTicks(6081), 1L, 618, false, false, 73L, null, 339 }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 2L, 50L, "Debitis rerum quia.\nVoluptatem enim hic voluptates modi corrupti voluptas voluptas.\nOdio minima nihil hic ducimus.\nAut sunt sint consequatur quibusdam odit quo.\nIllum minus veniam debitis architecto consectetur ea exercitationem ipsum voluptas.\nPariatur similique sequi beatae dignissimos ratione ad fugiat.", new DateTime(2021, 6, 5, 13, 3, 57, 833, DateTimeKind.Unspecified).AddTicks(7617), 2L, false, 31L },
                    { 3L, 15L, "Sit sint et ea earum non animi ipsam.\nDolores quia itaque est voluptas.\nEt qui odit aspernatur modi animi asperiores at.\nArchitecto vero occaecati.", new DateTime(2021, 8, 5, 4, 58, 11, 558, DateTimeKind.Unspecified).AddTicks(8477), 4L, false, 71L },
                    { 5L, 16L, "Molestias sit aut tempora numquam error molestiae.\nLaboriosam veritatis voluptates.\nVitae consequatur voluptas ducimus quo.\nAut enim consequatur voluptatem vel eum quia officiis.", new DateTime(2021, 5, 3, 9, 52, 26, 332, DateTimeKind.Unspecified).AddTicks(6590), 1L, false, 9L },
                    { 7L, 22L, "Ea mollitia aut neque et.\nVel natus quisquam quas.\nVoluptatibus tempora qui corporis quis.\nNon quis ipsa quis.\nLabore officiis incidunt illum aut assumenda molestiae reprehenderit et natus.", new DateTime(2021, 11, 18, 2, 55, 14, 893, DateTimeKind.Unspecified).AddTicks(5650), 1L, false, 18L },
                    { 10L, 16L, "Et et eum.", new DateTime(2021, 9, 3, 23, 50, 55, 21, DateTimeKind.Unspecified).AddTicks(5435), 2L, false, 6L },
                    { 12L, 7L, "Velit omnis dolorem.", new DateTime(2021, 7, 27, 19, 17, 16, 380, DateTimeKind.Unspecified).AddTicks(5975), 5L, false, 69L },
                    { 13L, 28L, "Voluptatem aliquam non quos aut qui autem.\nMolestiae sunt omnis placeat optio neque deserunt sunt.", new DateTime(2021, 9, 12, 2, 36, 49, 302, DateTimeKind.Unspecified).AddTicks(557), 4L, false, 14L },
                    { 14L, 13L, "Ut a dicta.\nVoluptas officiis modi neque voluptates provident.", new DateTime(2021, 7, 10, 12, 36, 36, 782, DateTimeKind.Unspecified).AddTicks(7144), 5L, false, 68L },
                    { 18L, 18L, "Id officia possimus nesciunt eos dolorem velit reiciendis id incidunt.", new DateTime(2021, 5, 18, 7, 38, 19, 435, DateTimeKind.Unspecified).AddTicks(2439), 3L, false, 66L },
                    { 27L, 35L, "Amet magni recusandae repudiandae nulla distinctio quia.\nEst ut asperiores aperiam eius.\nQuis officia deleniti.\nVoluptas qui quod.", new DateTime(2021, 2, 5, 11, 43, 14, 453, DateTimeKind.Unspecified).AddTicks(6733), 4L, false, 9L },
                    { 29L, 32L, "Ut est aut placeat et rerum dolores.\nDoloremque autem sint eaque quia molestiae similique esse optio eum.", new DateTime(2021, 10, 12, 13, 54, 18, 814, DateTimeKind.Unspecified).AddTicks(6413), 3L, false, 60L },
                    { 30L, 48L, "Laudantium quia explicabo vero dolorum qui quia.\nEos quia qui iste ut debitis.\nIure ipsam deserunt optio voluptatibus.", new DateTime(2021, 8, 17, 19, 53, 34, 420, DateTimeKind.Unspecified).AddTicks(18), 1L, false, 71L },
                    { 33L, 22L, "Dolorum dolorem assumenda nobis.", new DateTime(2021, 8, 26, 17, 8, 57, 525, DateTimeKind.Unspecified).AddTicks(5515), 3L, false, 75L },
                    { 35L, 38L, "Fuga quasi soluta maiores dolor.\nUt qui odit atque accusantium in sed.\nEt exercitationem voluptas.\nDebitis praesentium atque voluptas numquam.\nEaque voluptatem optio repudiandae quo qui aut.\nEst non labore provident voluptas illo quia debitis distinctio et.", new DateTime(2021, 12, 3, 13, 55, 10, 671, DateTimeKind.Unspecified).AddTicks(5719), 3L, false, 70L },
                    { 36L, 7L, "Vitae officia vero.\nDelectus quos eos.\nAt veritatis rerum possimus eum ex aut sapiente cum.", new DateTime(2021, 3, 29, 8, 0, 14, 721, DateTimeKind.Unspecified).AddTicks(2103), 4L, false, 79L },
                    { 37L, 7L, "Ad velit repellat quibusdam ab eaque commodi.", new DateTime(2021, 6, 30, 1, 7, 18, 614, DateTimeKind.Unspecified).AddTicks(1453), 4L, false, 71L },
                    { 42L, 42L, "Similique facere sunt pariatur suscipit molestiae quos at impedit.\nAsperiores officiis fuga dolor consequuntur distinctio itaque quisquam ullam.\nEnim et iste soluta consectetur.\nSoluta voluptas aut quos fuga labore.", new DateTime(2021, 6, 10, 1, 0, 44, 669, DateTimeKind.Unspecified).AddTicks(1888), 5L, false, 58L },
                    { 44L, 45L, "Soluta hic cupiditate consequatur delectus aliquid blanditiis minima cum.\nEt rerum similique nesciunt sit qui possimus inventore.\nNecessitatibus laboriosam pariatur corrupti vero sint ipsum qui.\nSimilique quam iste tempore eligendi ducimus.", new DateTime(2021, 3, 16, 8, 6, 1, 244, DateTimeKind.Unspecified).AddTicks(4164), 4L, false, 79L },
                    { 46L, 2L, "Molestiae voluptatibus ipsa quas aut.\nEveniet quis eius dolor vel aliquid quia tempore consequatur.\nOmnis magnam eum quibusdam magnam ipsum.", new DateTime(2021, 12, 20, 16, 40, 33, 899, DateTimeKind.Unspecified).AddTicks(4261), 3L, false, 6L },
                    { 47L, 6L, "Qui cupiditate dolorem.", new DateTime(2021, 10, 27, 16, 54, 10, 646, DateTimeKind.Unspecified).AddTicks(4750), 5L, false, 63L },
                    { 49L, 41L, "Vel enim sint omnis exercitationem omnis.\nIpsa possimus delectus doloribus voluptatem saepe omnis.\nUnde optio perferendis est qui modi voluptate tempora tempora.\nAtque enim voluptas quos.", new DateTime(2021, 3, 27, 12, 59, 9, 343, DateTimeKind.Unspecified).AddTicks(2725), 1L, false, 61L },
                    { 53L, 48L, "Nobis tempora ullam.\nUt et praesentium dolores maiores aperiam aliquam dolores voluptas quisquam.", new DateTime(2021, 10, 27, 3, 28, 48, 271, DateTimeKind.Unspecified).AddTicks(4604), 3L, false, 9L },
                    { 54L, 42L, "Omnis corrupti ea doloremque sit ipsa et error.\nIn modi quia eius doloremque libero accusamus voluptatem nisi sapiente.\nPraesentium culpa iure laboriosam assumenda ipsa eveniet saepe facere in.\nDeserunt nam culpa deleniti adipisci et ut illum non.\nEveniet sed qui.", new DateTime(2021, 5, 10, 21, 43, 1, 407, DateTimeKind.Unspecified).AddTicks(2377), 5L, false, 5L },
                    { 58L, 46L, "Sit in et qui quidem.\nFacere soluta officia exercitationem quos.\nPerferendis aut et quia voluptates debitis ut.\nCorporis eaque autem sequi quae at et.", new DateTime(2021, 4, 22, 12, 53, 26, 301, DateTimeKind.Unspecified).AddTicks(3993), 4L, false, 40L },
                    { 60L, 30L, "Nobis dolor doloremque accusamus sed debitis excepturi qui voluptatem neque.\nQuibusdam et sit fugiat suscipit quam est sed sunt quibusdam.", new DateTime(2021, 3, 26, 11, 35, 37, 920, DateTimeKind.Unspecified).AddTicks(3216), 3L, false, 17L },
                    { 61L, 32L, "Quidem sint voluptas debitis nulla et quo quia voluptatem reiciendis.\nQui quae exercitationem numquam ratione.\nEum tempora totam id enim dolores rem.\nAccusantium harum fugit odit deserunt.", new DateTime(2021, 3, 3, 14, 43, 13, 110, DateTimeKind.Unspecified).AddTicks(3744), 4L, false, 2L },
                    { 63L, 6L, "Consequatur dolores tenetur aliquid.\nTempore et alias eum expedita cumque unde.\nDolores minus quia ullam amet impedit et.\nQuibusdam iusto rerum vero doloribus minima rem sint dolores ex.\nOfficia debitis corrupti esse et.", new DateTime(2021, 4, 30, 4, 45, 59, 691, DateTimeKind.Unspecified).AddTicks(7247), 3L, false, 7L },
                    { 64L, 34L, "Aut molestiae officiis reiciendis sit deleniti ea adipisci dolores numquam.\nNesciunt similique optio aut dolores perspiciatis reprehenderit iusto dicta.\nUllam ea a minus.", new DateTime(2021, 11, 13, 21, 2, 13, 368, DateTimeKind.Unspecified).AddTicks(4529), 3L, false, 27L },
                    { 65L, 51L, "Qui est debitis suscipit sint.", new DateTime(2021, 2, 5, 19, 47, 14, 271, DateTimeKind.Unspecified).AddTicks(8322), 2L, false, 2L },
                    { 66L, 26L, "Eos beatae possimus porro sint quisquam vero qui occaecati eaque.\nVeniam tempore et voluptatem repudiandae.\nQuis neque ut aut.\nItaque est omnis eligendi commodi.", new DateTime(2021, 12, 16, 0, 35, 55, 674, DateTimeKind.Unspecified).AddTicks(5286), 3L, false, 42L },
                    { 72L, 18L, "Eos sequi unde.\nCum eveniet nisi.", new DateTime(2021, 6, 10, 19, 45, 53, 208, DateTimeKind.Unspecified).AddTicks(997), 4L, false, 18L },
                    { 75L, 9L, "Voluptatum est consequatur iure velit sit ipsam odit.\nMagni at repellendus.\nDistinctio suscipit blanditiis repudiandae quos.", new DateTime(2021, 10, 12, 7, 34, 38, 444, DateTimeKind.Unspecified).AddTicks(5294), 1L, false, 36L },
                    { 76L, 43L, "Earum voluptate voluptatem.\nSunt sunt est non deleniti tempore provident nihil et omnis.", new DateTime(2021, 5, 22, 23, 42, 34, 208, DateTimeKind.Unspecified).AddTicks(457), 4L, false, 6L },
                    { 77L, 17L, "Et aut qui voluptatem laudantium numquam quo ut sit molestiae.\nDolorem commodi ea dignissimos alias aperiam eum.\nNon atque voluptas.", new DateTime(2021, 6, 16, 21, 27, 26, 493, DateTimeKind.Unspecified).AddTicks(6199), 1L, false, 50L },
                    { 78L, 26L, "Libero dicta temporibus atque earum.\nReprehenderit eos qui eum totam.\nId cum adipisci iste ratione commodi laboriosam quas aut qui.\nQuaerat soluta quo.", new DateTime(2021, 11, 16, 12, 40, 4, 378, DateTimeKind.Unspecified).AddTicks(5308), 3L, false, 25L },
                    { 81L, 2L, "Error minima rerum.\nMolestiae sit voluptas ex fuga ab omnis.\nDucimus magnam consectetur quaerat inventore vitae.\nRerum fuga non explicabo quo ipsa molestiae est illum accusamus.", new DateTime(2021, 12, 13, 16, 12, 11, 763, DateTimeKind.Unspecified).AddTicks(1740), 4L, false, 75L },
                    { 82L, 26L, "Et expedita sint quaerat ut.\nQui et quos maiores assumenda consequatur.\nVelit reiciendis et et sint dolor nihil ex sit ipsum.", new DateTime(2021, 7, 30, 6, 22, 31, 852, DateTimeKind.Unspecified).AddTicks(1431), 3L, false, 42L },
                    { 83L, 35L, "Dolores rerum enim sunt repellat consequuntur id.\nQui reiciendis laudantium tempora voluptate id qui.\nEt nulla ea saepe hic.", new DateTime(2021, 2, 26, 16, 38, 36, 562, DateTimeKind.Unspecified).AddTicks(6656), 2L, false, 61L },
                    { 84L, 49L, "Atque doloremque possimus iste voluptates voluptates consectetur ea aut praesentium.\nNon quis autem cupiditate nihil itaque ipsam adipisci rerum culpa.\nNumquam qui similique odit deserunt distinctio.\nEos tenetur nesciunt aspernatur et sed.\nEt quam omnis voluptatem numquam et et.\nConsequatur repudiandae fugit occaecati molestiae dolore consequatur ipsa id.", new DateTime(2021, 4, 9, 15, 45, 38, 982, DateTimeKind.Unspecified).AddTicks(4744), 1L, false, 26L },
                    { 85L, 45L, "Aut voluptatem provident saepe sapiente quas facere eum quae aliquam.\nEx sint voluptas.", new DateTime(2021, 4, 10, 15, 20, 24, 246, DateTimeKind.Unspecified).AddTicks(6945), 2L, false, 60L },
                    { 86L, 15L, "Et doloribus quasi ut eius voluptas voluptates.\nRatione earum beatae eligendi eveniet et.\nRepellat nobis ut nam enim aliquam vitae quasi.", new DateTime(2021, 10, 18, 8, 54, 51, 263, DateTimeKind.Unspecified).AddTicks(2466), 5L, false, 35L },
                    { 88L, 32L, "Sunt quia similique et.\nIllum voluptas aperiam harum error molestiae aut pariatur ad.\nExplicabo recusandae facere iure tempore.\nPorro molestiae in.\nDicta aspernatur et quia voluptatem voluptatibus quia reiciendis beatae sit.\nAssumenda saepe odio voluptatum aliquid.", new DateTime(2021, 4, 30, 1, 45, 54, 355, DateTimeKind.Unspecified).AddTicks(2369), 4L, false, 78L }
                });

            migrationBuilder.InsertData(
                table: "ThreadComments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "CreatedBy", "IsDeleted", "ThreadId" },
                values: new object[,]
                {
                    { 89L, 34L, "Ipsa nesciunt asperiores vitae consequuntur.", new DateTime(2021, 9, 19, 7, 11, 13, 409, DateTimeKind.Unspecified).AddTicks(1402), 1L, false, 27L },
                    { 90L, 33L, "Tenetur quisquam porro eveniet.\nQuis culpa placeat repellat est rerum doloremque voluptas ipsa.\nVoluptates voluptatem nihil possimus sequi.", new DateTime(2022, 1, 11, 10, 48, 33, 143, DateTimeKind.Unspecified).AddTicks(1656), 4L, false, 68L },
                    { 92L, 8L, "Eaque vel maxime repellat optio et et provident.", new DateTime(2021, 6, 18, 20, 21, 27, 998, DateTimeKind.Unspecified).AddTicks(9354), 4L, false, 78L },
                    { 93L, 6L, "Est incidunt suscipit qui.\nSequi qui aut mollitia voluptatem et et dolorem ut fuga.\nQuia sapiente qui unde qui quae est nam.\nNisi quidem et illum possimus.", new DateTime(2021, 9, 9, 10, 54, 34, 371, DateTimeKind.Unspecified).AddTicks(4620), 1L, false, 68L },
                    { 97L, 27L, "Necessitatibus quo est est ea quam quisquam.", new DateTime(2021, 9, 14, 16, 40, 7, 709, DateTimeKind.Unspecified).AddTicks(8276), 2L, false, 64L },
                    { 100L, 12L, "Modi ut voluptate veniam quia velit quod.\nMaxime esse aut maxime vel.\nAliquam sunt tenetur dolores quibusdam.", new DateTime(2021, 8, 12, 19, 39, 12, 437, DateTimeKind.Unspecified).AddTicks(3503), 3L, false, 47L },
                    { 101L, 33L, "Amet error aut rerum officiis eum doloribus aliquam.\nEligendi dolore illo quas ea.\nDistinctio sed illo quas itaque minima.\nEt exercitationem odio sit.\nCorporis adipisci recusandae id.\nExcepturi id itaque.", new DateTime(2021, 3, 21, 6, 49, 40, 64, DateTimeKind.Unspecified).AddTicks(6762), 3L, false, 60L },
                    { 102L, 20L, "Quos odit expedita aut aperiam ducimus eos suscipit omnis.", new DateTime(2021, 2, 17, 13, 53, 56, 219, DateTimeKind.Unspecified).AddTicks(2700), 5L, false, 36L },
                    { 104L, 27L, "Aut delectus rerum similique corporis explicabo omnis sed.\nEst voluptatem accusantium dolor saepe magni et est cumque fugiat.\nUnde quo excepturi et harum dolore.", new DateTime(2022, 1, 20, 14, 34, 50, 47, DateTimeKind.Unspecified).AddTicks(8846), 4L, false, 68L },
                    { 105L, 27L, "Ipsa tenetur eaque quisquam esse assumenda.\nDicta doloribus cumque perspiciatis dolores et nihil consequatur.\nAsperiores ex magnam voluptatem qui repudiandae consectetur.\nBlanditiis perferendis recusandae inventore officia quisquam.\nNulla nihil deserunt maiores tempora at voluptate.\nAlias ab placeat.", new DateTime(2021, 9, 17, 20, 38, 10, 366, DateTimeKind.Unspecified).AddTicks(1806), 1L, false, 69L },
                    { 106L, 35L, "Et non quo quaerat repellendus est reiciendis consequuntur voluptas est.\nEa quo deserunt dolores enim.\nOptio et enim.\nOmnis quisquam qui laboriosam dolore non nihil velit.\nModi beatae nostrum consequatur illum.", new DateTime(2022, 1, 10, 5, 56, 3, 366, DateTimeKind.Unspecified).AddTicks(3709), 2L, false, 72L },
                    { 108L, 26L, "Et ea cupiditate rem nisi qui.\nDolor tenetur et.\nSoluta quam voluptas hic quo.", new DateTime(2021, 12, 9, 19, 31, 57, 683, DateTimeKind.Unspecified).AddTicks(8040), 2L, false, 58L },
                    { 110L, 36L, "Quaerat aperiam beatae similique est.\nEx et officiis delectus ipsam reiciendis impedit.", new DateTime(2021, 12, 8, 20, 3, 58, 315, DateTimeKind.Unspecified).AddTicks(5921), 1L, false, 65L },
                    { 112L, 8L, "Ea dolores iure.\nMagnam cupiditate cupiditate eum laboriosam porro accusantium quaerat.\nAutem molestiae inventore similique corporis magnam assumenda necessitatibus voluptas.\nHic cum ut aspernatur nobis delectus.\nQuia maxime quod omnis deserunt.", new DateTime(2021, 3, 23, 5, 35, 24, 670, DateTimeKind.Unspecified).AddTicks(4538), 3L, false, 58L },
                    { 113L, 10L, "Et ducimus temporibus sed odit.\nEarum dolores voluptatem omnis.", new DateTime(2021, 12, 9, 21, 9, 27, 623, DateTimeKind.Unspecified).AddTicks(3095), 5L, false, 78L },
                    { 114L, 11L, "Iusto aut sit nihil quo eos veritatis mollitia.\nSint explicabo sed quibusdam aliquid.\nIusto delectus rem.\nQui est placeat sunt architecto nesciunt.", new DateTime(2021, 2, 21, 17, 20, 20, 506, DateTimeKind.Unspecified).AddTicks(4379), 3L, false, 77L },
                    { 116L, 41L, "Dolorem voluptatibus consequatur quam dolores ad.", new DateTime(2021, 10, 3, 6, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(7871), 5L, false, 18L },
                    { 118L, 38L, "Inventore et aut eos nihil repellendus porro deserunt.\nFacere nam beatae inventore aspernatur omnis corrupti consequatur quaerat laboriosam.\nEt totam eum.\nAut reiciendis cum deleniti ut.\nAsperiores maiores tenetur sed eum possimus quas.", new DateTime(2021, 4, 20, 13, 48, 35, 758, DateTimeKind.Unspecified).AddTicks(9682), 2L, false, 50L },
                    { 119L, 45L, "Placeat sed tenetur quia illum dolorum dolorum qui.\nDolorem id eaque deserunt ut et rerum.\nOdit labore et odio omnis soluta consequuntur earum.\nConsequatur maiores ad est dolores exercitationem nobis facere.\nPorro voluptatem vero vero vero qui dolores in.\nUt beatae autem numquam.", new DateTime(2021, 12, 28, 16, 22, 55, 886, DateTimeKind.Unspecified).AddTicks(4156), 5L, false, 69L },
                    { 120L, 28L, "Ad doloribus at eum dolor odit et quidem.\nRerum eligendi enim.\nVoluptas et voluptates et accusamus.\nVel sint nemo commodi.", new DateTime(2021, 3, 3, 2, 17, 33, 487, DateTimeKind.Unspecified).AddTicks(2019), 5L, false, 64L },
                    { 121L, 11L, "Molestiae assumenda eaque.\nAlias deleniti facilis et adipisci cum facere et.\nAut blanditiis totam.\nQui tenetur enim.\nVoluptatibus perferendis nulla ipsum dolorem ut fuga sit ab voluptatem.", new DateTime(2021, 5, 24, 14, 55, 58, 248, DateTimeKind.Unspecified).AddTicks(2886), 3L, false, 67L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { 14L, 14L });

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
                keyValues: new object[] { 17L, 23L });

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
                keyValues: new object[] { 18L, 35L });

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
                keyValues: new object[] { 21L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseUsers",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, 50L });

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
                table: "Images",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100L);

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
                keyValues: new object[] { 3L, 24L });

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
                keyValues: new object[] { 12L, 13L });

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
                keyValues: new object[] { 34L, 45L });

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
                keyValues: new object[] { 37L, 31L });

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
                keyValues: new object[] { 39L, 50L });

            migrationBuilder.DeleteData(
                table: "InvitedUsers",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 41L, 50L });

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
                keyValues: new object[] { 43L, 45L });

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

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "ThreadComments",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "CourseRoles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CourseRoles",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101L);
        }
    }
}
