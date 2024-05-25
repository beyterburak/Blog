using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class article_detail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9514cfed-2878-4708-9b51-10c7b6497519"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e00eb70a-8a5a-45a9-80f8-d572f1e33f3b"));

            migrationBuilder.AddColumn<string>(
                name: "Quote",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuoteAuthor",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoContent",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Quote", "QuoteAuthor", "Title", "UserId", "VideoContent", "VideoUrl", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("93ee9d48-57ed-403e-ae74-2bc568b4caca"), new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"), "Asp.NET Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 5, 23, 20, 12, 24, 86, DateTimeKind.Local).AddTicks(9385), null, null, new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"), null, null, null, null, "Asp.NET Core Deneme Makalesi 1", new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"), null, null, 15, false },
                    { new Guid("a0d36739-f327-488a-a621-1498b131a5f1"), new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 5, 23, 20, 12, 24, 86, DateTimeKind.Local).AddTicks(9391), null, null, new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"), null, null, null, null, "Visual Studio Deneme Makalesi 1", new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"), null, null, 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6792e989-6c0a-44c2-9a3a-c5d1699ed73f"),
                column: "ConcurrencyStamp",
                value: "084c52b7-8aeb-48bd-b396-19b5d8078f51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6afcd0c7-7fb7-4b34-a14a-e2a55141d71a"),
                column: "ConcurrencyStamp",
                value: "261b2cc2-eeff-4c19-94d3-fd474a14562a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d9ca0b7a-a37e-4d2e-b016-86f3ceb56397"),
                column: "ConcurrencyStamp",
                value: "ef26da7a-a0df-4b20-a7b4-095f295b852d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7350f01d-cc3b-48c9-9d9c-6e12d75e16b9", "AQAAAAEAACcQAAAAEKvJWXfYR4yz+VOIAf79/Waz9nebWi0cFESe5OCwURcEj43SPhfgch3iQy//ws5h4A==", "b83f5e56-7e74-4e2e-9a4c-e61acb5b00d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f904b342-16de-442c-8baa-f69d664017f2", "AQAAAAEAACcQAAAAEE1lGjtHouhsl0PdcmEnAepxmymAJDZSsT3R0jtMUa3Jdwpqhc1wpCv2zJWqqaXfRA==", "e6733917-0680-4371-8ae9-b623035eae42" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 20, 12, 24, 87, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 20, 12, 24, 87, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 20, 12, 24, 87, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 20, 12, 24, 87, DateTimeKind.Local).AddTicks(359));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("93ee9d48-57ed-403e-ae74-2bc568b4caca"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a0d36739-f327-488a-a621-1498b131a5f1"));

            migrationBuilder.DropColumn(
                name: "Quote",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "QuoteAuthor",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "VideoContent",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("9514cfed-2878-4708-9b51-10c7b6497519"), new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 4, 5, 14, 11, 33, 769, DateTimeKind.Local).AddTicks(302), null, null, new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"), null, null, "Visual Studio Deneme Makalesi 1", new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"), 15, false },
                    { new Guid("e00eb70a-8a5a-45a9-80f8-d572f1e33f3b"), new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"), "Asp.NET Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 4, 5, 14, 11, 33, 769, DateTimeKind.Local).AddTicks(290), null, null, new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"), null, null, "Asp.NET Core Deneme Makalesi 1", new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"), 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6792e989-6c0a-44c2-9a3a-c5d1699ed73f"),
                column: "ConcurrencyStamp",
                value: "106b15d8-4eb8-482d-b188-4219220f1f2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6afcd0c7-7fb7-4b34-a14a-e2a55141d71a"),
                column: "ConcurrencyStamp",
                value: "9a0f41f6-ef78-4747-971e-d5edaeb66962");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d9ca0b7a-a37e-4d2e-b016-86f3ceb56397"),
                column: "ConcurrencyStamp",
                value: "a63fbe98-0623-4538-8552-cc5eeaf524e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e798e8c0-54d9-46dd-b3cd-17b49a81d580", "AQAAAAEAACcQAAAAEOugKqY2BTG0J4YKCV6rQKIA4MhRpg6A1uxmsX9TQ5eXC18yYOFrJjED5BvNG78G4g==", "08b45864-6b89-48f6-8e5a-ea31e097adc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c13fed7-e2f0-44a1-91a8-287db2bf7416", "AQAAAAEAACcQAAAAEJF67CGzcUySZiLJ0vSI7fFzeIxzkUeAEhNnWBpbfubQRHqzyWHKtnn/0R+L7z2RLw==", "ee354c9b-c72d-4523-85bc-fb57b3ee70ad" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 14, 11, 33, 769, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 14, 11, 33, 769, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 14, 11, 33, 769, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 14, 11, 33, 769, DateTimeKind.Local).AddTicks(3207));
        }
    }
}
