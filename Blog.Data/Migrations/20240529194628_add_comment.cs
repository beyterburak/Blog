using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class add_comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a6c2ef45-f5f2-4cbc-a0dc-3f0ef7edc706"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d548b2e9-12a4-4463-8de4-8b03d91471fd"));

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Quote", "QuoteAuthor", "Title", "UserId", "VideoContent", "VideoUrl", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("5c9468d8-f6f5-43d8-971b-c6d7f444cd73"), new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"), "Asp.NET Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 5, 29, 22, 46, 28, 24, DateTimeKind.Local).AddTicks(8290), null, null, new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"), null, null, null, null, "Asp.NET Core Deneme Makalesi 1", new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"), null, null, 15, false },
                    { new Guid("fe348889-ee5f-4b20-8c46-491b376f106e"), new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 5, 29, 22, 46, 28, 24, DateTimeKind.Local).AddTicks(8296), null, null, new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"), null, null, null, null, "Visual Studio Deneme Makalesi 1", new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"), null, null, 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6792e989-6c0a-44c2-9a3a-c5d1699ed73f"),
                column: "ConcurrencyStamp",
                value: "a6bbebab-6248-46ce-8595-7de2a3f3e899");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6afcd0c7-7fb7-4b34-a14a-e2a55141d71a"),
                column: "ConcurrencyStamp",
                value: "f62a999f-0836-4868-9eac-60d3a1560ab8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d9ca0b7a-a37e-4d2e-b016-86f3ceb56397"),
                column: "ConcurrencyStamp",
                value: "f198ff48-0df8-4acb-9cac-c1d2537d925a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7559589-6229-4705-9404-5aa345ef7f42", "AQAAAAEAACcQAAAAEArzuOHiNkCdfy37aFsyzedqhB0fhshC3FY4lYWyXiZhtG+ai7Dt4s2485DM5BLNiQ==", "98faa1a1-e0d1-4813-ba4b-3c9ad914801b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a48466f-3f83-4070-833e-55eefea62075", "AQAAAAEAACcQAAAAEM7f8MVaaDdViat4TmSzU/TzRzFMyI3Gs29mhIJd8GR06U6t27PMBFJOc+RasTyjKg==", "c0687892-9135-4218-9477-8d2e1422e5b4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 22, 46, 28, 24, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 22, 46, 28, 24, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 22, 46, 28, 24, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 22, 46, 28, 24, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5c9468d8-f6f5-43d8-971b-c6d7f444cd73"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fe348889-ee5f-4b20-8c46-491b376f106e"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Quote", "QuoteAuthor", "Title", "UserId", "VideoContent", "VideoUrl", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("a6c2ef45-f5f2-4cbc-a0dc-3f0ef7edc706"), new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"), "Asp.NET Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 5, 26, 14, 46, 33, 779, DateTimeKind.Local).AddTicks(1221), null, null, new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"), null, null, null, null, "Asp.NET Core Deneme Makalesi 1", new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"), null, null, 15, false },
                    { new Guid("d548b2e9-12a4-4463-8de4-8b03d91471fd"), new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 5, 26, 14, 46, 33, 779, DateTimeKind.Local).AddTicks(1229), null, null, new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"), null, null, null, null, "Visual Studio Deneme Makalesi 1", new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"), null, null, 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6792e989-6c0a-44c2-9a3a-c5d1699ed73f"),
                column: "ConcurrencyStamp",
                value: "8e9e4349-5b6e-415e-9ee2-68aea63ff2c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6afcd0c7-7fb7-4b34-a14a-e2a55141d71a"),
                column: "ConcurrencyStamp",
                value: "2a610f78-eccb-41ee-a24a-ef1da16e16cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d9ca0b7a-a37e-4d2e-b016-86f3ceb56397"),
                column: "ConcurrencyStamp",
                value: "4ad0a826-0cee-4aac-be40-f33dbacaa2f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9f8b201-8226-47c4-b9be-903ddd637681", "AQAAAAEAACcQAAAAEMkGwPBoxZfFWZCJVB4/Jz4L8G+JXSCSb6xe2mDuLK/m80Xrz31SMiWzaRjB4GeL1Q==", "68417df5-253f-4d5e-9957-c76cd43e3a1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64eef1ea-6993-4917-bfd7-32379b22957a", "AQAAAAEAACcQAAAAEOK1M7Y/26ttYDbsDq6mckU4t7uh8U8NcJjnLUOtrTR4YHoBHM9xmxXF/ZYF0ROZ7w==", "56334338-cd26-43a0-9c44-08f157fd1b1e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 14, 46, 33, 779, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 14, 46, 33, 779, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 14, 46, 33, 779, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 14, 46, 33, 779, DateTimeKind.Local).AddTicks(2258));
        }
    }
}
