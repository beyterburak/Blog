using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class Visitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("34ef89da-2445-48bc-aa89-8e1eb90d556f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("36a7d77e-a01d-48df-aae5-daa71da49a65"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9514cfed-2878-4708-9b51-10c7b6497519"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e00eb70a-8a5a-45a9-80f8-d572f1e33f3b"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("34ef89da-2445-48bc-aa89-8e1eb90d556f"), new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 3, 21, 7, 10, 29, 807, DateTimeKind.Local).AddTicks(1644), null, null, new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"), null, null, "Visual Studio Deneme Makalesi 1", new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"), 15, false },
                    { new Guid("36a7d77e-a01d-48df-aae5-daa71da49a65"), new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"), "Asp.NET Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 3, 21, 7, 10, 29, 807, DateTimeKind.Local).AddTicks(1629), null, null, new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"), null, null, "Asp.NET Core Deneme Makalesi 1", new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"), 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6792e989-6c0a-44c2-9a3a-c5d1699ed73f"),
                column: "ConcurrencyStamp",
                value: "9577279f-012d-4aac-9a46-023d1ca2acf1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6afcd0c7-7fb7-4b34-a14a-e2a55141d71a"),
                column: "ConcurrencyStamp",
                value: "07085508-376d-4370-b7ab-d59abe6a28ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d9ca0b7a-a37e-4d2e-b016-86f3ceb56397"),
                column: "ConcurrencyStamp",
                value: "0de0f374-9e66-45c3-841d-c1d7879c8a66");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b9ac43-6656-4ba7-86f0-0541baa7a2c5", "AQAAAAEAACcQAAAAEGcl+vvvL1n0hi9PmN5kzr3I7IIQFdonhCqpe1+tKvXw/ozSGm+llepg/H9We9BLww==", "84d90d13-c265-45df-bb69-1cd8ff4363c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49a435a2-0734-4799-b2cd-66a203bbbf09", "AQAAAAEAACcQAAAAEHAU/9r+OiJ+e9gFukU2uiivmW+9oloSCjLDKrMwYzPUu6JUsC4TzpyHMF4JfAtWTA==", "2a695fae-1dc8-4d05-ba41-fbad0a943b53" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 7, 10, 29, 807, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 7, 10, 29, 807, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 7, 10, 29, 807, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 7, 10, 29, 807, DateTimeKind.Local).AddTicks(1865));
        }
    }
}
