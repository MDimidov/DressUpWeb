using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class AddedOnPropertyOnProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "648a643c-7dad-4cdd-a3c1-e9d51c63fccf", "AQAAAAEAACcQAAAAEPEM89ceBfv/scsoVvBFC2X7Aj7MUvQbidp1qatAHEIN3HyxMGTbgXsD+eyF2+VGmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9311b1f-57b0-4994-8946-90761f64ac5d", "AQAAAAEAACcQAAAAEFPGAqCHZ0/LE8+dGd/0VjXju7mf3h9BnzRJtxJ2SUifYuESM6RNZWchJDr6WS9P7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1893de59-616a-4ec5-927d-23ca1195c60f", "AQAAAAEAACcQAAAAEKF/ZkhirdXwa1XSvS7mikwbYwixA6LBQA1yO0edJn3tKMnhB5Ag3/6Z81kGroh5Pg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 28, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 28, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 28, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 28, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 28, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 28, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 28, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 29, DateTimeKind.Utc).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 29, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 4, 11, 14, 17, 47, 29, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingTime", "ImageUrl", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "~/DressPics/Stores/FIola.jpg", new DateTime(2024, 4, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "ImageUrl", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "~/DressPics/Stores/Fiola2.webp", new DateTime(2024, 4, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "ImageUrl", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "~/DressPics/Stores/Fiola3.webp", new DateTime(2024, 4, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed6dbb7f-c8de-4ce6-8a9f-51e25c681868", "AQAAAAEAACcQAAAAEG53WJaF8fsk63JbHtTSlfWOSvBbcylc2dA1l7qbqvCsrL8a+4zwsLnBroBy+aZsfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15f2a6cd-3438-4c5a-bca3-cfdf4f0b9ce5", "AQAAAAEAACcQAAAAEPAVZOZyxHA+S5Udt7txG3+jaUQaEQMe+XkKzmMP1wPLwWv+QNly2CKfAmfViywVPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd4a31c8-5166-4287-ac2b-a4b4082047ee", "AQAAAAEAACcQAAAAEI4Hyi6RDRB0qtpT0jDgbXf4Fy0B5Ra64xF5afLmTPx6SQPG9/H5YkxksKfJrgH+3w==" });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingTime", "ImageUrl", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "https://scontent-fco2-1.xx.fbcdn.net/v/t39.30808-6/338903224_567616675470867_4795870235142378988_n.jpg?stp=cp6_dst-jpg&_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=zArpB4FixbYAX-Wsqw4&_nc_ht=scontent-fco2-1.xx&oh=00_AfDQhl4Hmv6cqASl6aw8mMy5P-Hujg1mMlSJIbRz2hpIKw&oe=660CB54A", new DateTime(2024, 4, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "ImageUrl", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "https://cdn.oink.bg/gallery/33810/994cc5d6-cbd1-43ed-847e-bd24ee336bbb_large.webp", new DateTime(2024, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "ImageUrl", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "https://cdn.oink.bg/gallery/33810/326c67ed-db57-47b4-9a0d-81e0f1c412bc_large.webp", new DateTime(2024, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
