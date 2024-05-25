using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class images_connection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("37635150-291f-44a5-8cc0-19a301b78453"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("facce066-1eb4-4da8-bf3a-286ccf8b037d"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("34ef89da-2445-48bc-aa89-8e1eb90d556f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("36a7d77e-a01d-48df-aae5-daa71da49a65"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("37635150-291f-44a5-8cc0-19a301b78453"), new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 2, 25, 23, 10, 8, 778, DateTimeKind.Local).AddTicks(1026), null, null, new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"), null, null, "Visual Studio Deneme Makalesi 1", new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"), 15, false },
                    { new Guid("facce066-1eb4-4da8-bf3a-286ccf8b037d"), new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"), "Asp.NET Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Admin Test", new DateTime(2024, 2, 25, 23, 10, 8, 778, DateTimeKind.Local).AddTicks(1020), null, null, new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"), null, null, "Asp.NET Core Deneme Makalesi 1", new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"), 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6792e989-6c0a-44c2-9a3a-c5d1699ed73f"),
                column: "ConcurrencyStamp",
                value: "1cb21526-da91-458c-bb19-5a5aaddf9cb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6afcd0c7-7fb7-4b34-a14a-e2a55141d71a"),
                column: "ConcurrencyStamp",
                value: "27318cb2-cde7-4537-9c8d-14856d6fb0e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d9ca0b7a-a37e-4d2e-b016-86f3ceb56397"),
                column: "ConcurrencyStamp",
                value: "82e7f376-902d-428a-8f80-708c797e2edb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a129d7cd-d69b-491c-bb10-0e199f1366e7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "055dfced-30c2-4b76-bd2f-cb8f5259906f", "AQAAAAEAACcQAAAAEHXl80VYjpl+PPgu9U0XG2J1gM/7+PlhALJuIPCxHMdbaCDx1p1+X/7kq3VaQlIqSQ==", "dece0fb8-1f6d-42c6-9126-c099cd4dd7e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b31eb5cc-ff98-4979-b273-db39087c6ae8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23fd0111-dd5f-4ee1-831f-3d2378fa6b81", "AQAAAAEAACcQAAAAEIgWUnhWx41pZrjOwz5b33eFBIxx3MTwCm1PknukQ9mqdJRo5L9BfUhRdSG9+Y/nCg==", "e971ff36-74fd-413b-8eb5-541a61d87afe" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46d6d928-e1f3-4a16-9557-53e5941ce64a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 25, 23, 10, 8, 778, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea8e620c-9d28-4b4a-962e-104ef111ace4"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 25, 23, 10, 8, 778, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0ad8eaca-f38a-447b-b21c-89ac3ea4c72a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 25, 23, 10, 8, 778, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ab93efd7-1144-4343-b7a9-ed3de38a597d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 25, 23, 10, 8, 778, DateTimeKind.Local).AddTicks(1214));
        }
    }
}
