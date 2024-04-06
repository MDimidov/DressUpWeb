using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class AddProductPicAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed4abe96-6169-4217-92f3-170ef87ce5bb", "AQAAAAEAACcQAAAAEIOwHeLcrgoft6b/yy4k5ZtgS2mfMy8DSkfKg2Hjb7X+6hSdqerouTvnPPgYAHbuzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70d42bcc-1fac-41a2-b3d0-537fba3e9c7b", "AQAAAAEAACcQAAAAEL4lxvOoc4lqUt1h3N39iSAyCn9mFenGloZxkqWvAwXXymSNNzL9xhGoXYE/MTE7rQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ef00fba-5310-4b13-9485-e5a2d1bdf4d9", "AQAAAAEAACcQAAAAEBFux+JNamdsDEJAYveuTcT4JwGDaD0LBz9yoYgdtrEbdZoteKQuj9R2Cc/oqTBv4A==" });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "Id", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { new Guid("0fc8b972-77b5-4ef4-8eb1-23d96a4d6d84"), "~/DressPics/Women/Dress1.webp", 8 },
                    { new Guid("1a1a865e-5313-42c6-af4a-dc40e0e63fa4"), "~/DressPics/Women/Dress2.webp", 8 },
                    { new Guid("2a5abf8f-96e2-4c7e-8a7d-c9b9dc5d6e4b"), "~/DressPics/Men/T-Shirt1.webp", 1 },
                    { new Guid("2e36a7a7-40b1-4ef6-8ee2-1df526f5fbad"), "~/DressPics/Men/Shorts2.webp", 7 },
                    { new Guid("3b4e89c6-77a0-4929-a94b-0d2f60d24e22"), "~/DressPics/Men/DressShirt1.webp", 3 },
                    { new Guid("47c43f51-4784-41d4-b524-c2bf2f4c70d4"), "~/DressPics/Women/Skirt2.webp", 4 },
                    { new Guid("4f4bfb79-27b1-4c98-ba8c-4f413aa6dc3e"), "~/DressPics/Men/Jacket2.webp", 5 },
                    { new Guid("59aa0191-12e4-4e47-bb80-22891cd8e52e"), "~/DressPics/Men/DressShirt2.webp", 3 },
                    { new Guid("60ab5a1e-0294-4ba7-a1bc-2f0a67617453"), "~/DressPics/Men/Sweater1.webp", 6 },
                    { new Guid("727d7f6f-8c50-4c77-8660-9b6e8e8aae9f"), "~/DressPics/Men/Jacket1.webp", 5 },
                    { new Guid("72d4b89a-290a-4f3e-8e06-1bde60a8a929"), "~/DressPics/Women/Blouse2.webp", 9 },
                    { new Guid("7ac4482c-3685-4b80-8373-79e24be5a39d"), "~/DressPics/Men/Shorts1.webp", 7 },
                    { new Guid("87642b02-5a77-4462-a01d-27f445c067a6"), "~/DressPics/Men/Coat2.webp", 10 },
                    { new Guid("aafbe7a9-b291-4b88-aa0c-1bb496b56f7d"), "~/DressPics/Men/Jeans2.webp", 2 },
                    { new Guid("ab5b3b6f-cdc8-4b44-a183-6956a5fa99e5"), "~/DressPics/Women/Blouse1.webp", 9 },
                    { new Guid("be86c2f8-8e12-4c29-b17c-2e3126e2e1ff"), "~/DressPics/Women/Skirt1.webp", 4 },
                    { new Guid("cd0a6f0f-ea28-4c0c-88b5-259ba5a90bb4"), "~/DressPics/Men/T-Shirt2.webp", 1 },
                    { new Guid("e2f4d405-4b1a-4876-8a0a-40ef482e5e62"), "~/DressPics/Men/Jeans1.webp", 2 },
                    { new Guid("e7b94c53-0558-4aa2-8f1e-2c70ac10d69e"), "~/DressPics/Men/Sweater2.webp", 6 },
                    { new Guid("f6517416-05e0-4e2e-bc9e-f45c8d498b06"), "~/DressPics/Men/Coat1.webp", 10 }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f987ed0d-2e30-49e4-8a18-a4f11661915f", "AQAAAAEAACcQAAAAEOHxlpG7WP3sHnDsg+AlVWi8IlMlU2xdZqjWc+nW6r3C2wRxEfeBDb8pD9twbTt5Sg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d7de568-1bcc-47a5-b446-0566bef53fad", "AQAAAAEAACcQAAAAEHl8Qc2xSMSh5b6KEqOhklJxcdQzh/HrC552Dtp5WCf7YW6FuioVK6U0khzo5v5Tyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bd6eb36-69a9-4920-8545-152df430ad92", "AQAAAAEAACcQAAAAEPJKdaHi3Jb62oK2kOCNqmuKpAYXiiCIejaLDIdN61s+ZDN2ABvOXQrQN1spQwwodQ==" });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
