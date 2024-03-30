using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nike" },
                    { 2, "Adidas" },
                    { 3, "Puma" },
                    { 4, "Reebok" },
                    { 5, "Under Armour" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "T-Shirts" },
                    { 2, "Jeans" },
                    { 3, "Dresses" },
                    { 4, "Jackets" },
                    { 5, "Skirts" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sofia" },
                    { 2, "Plovdiv" },
                    { 3, "Varna" },
                    { 4, "Burgas" },
                    { 5, "Ruse" },
                    { 6, "Stara Zagora" },
                    { 7, "Pleven" },
                    { 8, "Sliven" },
                    { 9, "Dobrich" },
                    { 10, "Shumen" },
                    { 11, "Pernik" },
                    { 12, "Yambol" },
                    { 13, "Haskovo" },
                    { 14, "Pazardzhik" },
                    { 15, "Blagoevgrad" },
                    { 16, "Veliko Tarnovo" },
                    { 17, "Vratsa" },
                    { 18, "Gabrovo" },
                    { 19, "Asenovgrad" },
                    { 20, "Kardzhali" },
                    { 21, "Kyustendil" },
                    { 22, "Razgrad" },
                    { 23, "Petrich" },
                    { 24, "Belogradchik" },
                    { 25, "Sandanski" },
                    { 26, "Gorna Oryahovitsa" },
                    { 27, "Lovech" },
                    { 28, "Targovishte" },
                    { 29, "Svilengrad" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bulgaria" },
                    { 2, "United States" },
                    { 3, "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "United Kingdom" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Russia" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityId", "CountryId", "Street" },
                values: new object[,]
                {
                    { new Guid("36d433c7-1c34-4a02-b0a5-6b7b4a1b6b7e"), 3, 1, "Asparuhovo Blvd. Narodni Buditeli 2 fl. 2" },
                    { new Guid("8a0d518b-9d8a-4e80-a68b-5b2f89b14812"), 4, 1, "j.k. Izgrev 147" },
                    { new Guid("fbd8adbb-9de2-4e63-b8fc-32a01b6ed348"), 3, 1, "Varna, j.k. Vladislavovo Blvd. 3-ti Mart 4" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "Cotton t-shirt with logo print", "T-Shirt", 15.99m, 100 },
                    { 2, 2, 2, "Slim fit denim jeans", "Jeans", 29.99m, 50 },
                    { 3, 3, 1, "Formal dress shirt with button-down collar", "Dress Shirt", 24.99m, 75 },
                    { 4, 4, 3, "A-line skirt with floral pattern", "Skirt", 19.99m, 60 },
                    { 5, 5, 4, "Waterproof jacket with hood", "Jacket", 49.99m, 30 },
                    { 6, 1, 1, "Knitted sweater with crew neckline", "Sweater", 34.99m, 80 },
                    { 7, 2, 2, "Casual shorts with drawstring waist", "Shorts", 22.99m, 45 },
                    { 8, 3, 3, "Maxi dress with spaghetti straps", "Dress", 39.99m, 65 },
                    { 9, 4, 1, "Chiffon blouse with ruffle detail", "Blouse", 29.99m, 70 },
                    { 10, 5, 4, "Wool blend coat with belt", "Coat", 79.99m, 25 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressId", "ClosingTime", "ContactInfo", "ImageUrl", "Name", "OpeningTime" },
                values: new object[] { 1, new Guid("36d433c7-1c34-4a02-b0a5-6b7b4a1b6b7e"), new DateTime(2024, 3, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "123-456-7890", "https://scontent-fco2-1.xx.fbcdn.net/v/t39.30808-6/338903224_567616675470867_4795870235142378988_n.jpg?stp=cp6_dst-jpg&_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=zArpB4FixbYAX-Wsqw4&_nc_ht=scontent-fco2-1.xx&oh=00_AfDQhl4Hmv6cqASl6aw8mMy5P-Hujg1mMlSJIbRz2hpIKw&oe=660CB54A", "Fiolla Asparuhovo", new DateTime(2024, 3, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressId", "ClosingTime", "ContactInfo", "ImageUrl", "Name", "OpeningTime" },
                values: new object[] { 2, new Guid("8a0d518b-9d8a-4e80-a68b-5b2f89b14812"), new DateTime(2024, 3, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), "987-654-3210", "https://cdn.oink.bg/gallery/33810/994cc5d6-cbd1-43ed-847e-bd24ee336bbb_large.webp", "Fiolla Izgrev", new DateTime(2024, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressId", "ClosingTime", "ContactInfo", "ImageUrl", "Name", "OpeningTime" },
                values: new object[] { 3, new Guid("fbd8adbb-9de2-4e63-b8fc-32a01b6ed348"), new DateTime(2024, 3, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), "555-123-4567", "https://cdn.oink.bg/gallery/33810/326c67ed-db57-47b4-9a0d-81e0f1c412bc_large.webp", "Fiolla Vladislavovo", new DateTime(2024, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("36d433c7-1c34-4a02-b0a5-6b7b4a1b6b7e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8a0d518b-9d8a-4e80-a68b-5b2f89b14812"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fbd8adbb-9de2-4e63-b8fc-32a01b6ed348"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
