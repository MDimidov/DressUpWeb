using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class UpdateDeleteBehaviourFavoritesProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Products_ProductId",
                table: "Favorites");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d029db1b-89a8-47ba-bded-6dd16225bf33", "AQAAAAEAACcQAAAAELE7Q8m3oABkHtbllLbImIC4alPwUkJy2QFUzmigV5JPZcxihTh6y9XrL/X6RRFTFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f6b67bf-a32d-4146-945d-b7d424cc623f", "AQAAAAEAACcQAAAAEGePCohkSrw2A4kzMqNUcnA4obXoskTuliFYBI5kW9T6hfuylqu3Jzlsfg9a/YKJ7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfd0b964-cd00-41bb-9d37-bfff54cdc5fa", "AQAAAAEAACcQAAAAEFHqrSydcUWJR+jYweO6PerMsDNiDS8BY3DhaRYezcwVYk3k/Q3+Mib37cLPL27NsQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 914, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 914, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 914, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 914, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 914, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 915, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 915, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 915, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 915, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 29, 24, 915, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Products_ProductId",
                table: "Favorites",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Products_ProductId",
                table: "Favorites");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0f53404-a18c-4fce-9bd3-7793276da058", "AQAAAAEAACcQAAAAECKBxRZsHAxRADy/R7ZyQ+GIT7PGxZVu4454n1ZB/Tqlv7k3bTOAEvk7WHM70TykkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88fda697-28a6-4933-b48d-07657500e3d8", "AQAAAAEAACcQAAAAECRAL0Mhmsn9mX8RWRkf4SHbACPwK2VnrK3o1Sx7qzcfYmnSkbmS1T729Ty7eLJCAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0796cb1-dd94-4631-8cd1-666ad7ae0def", "AQAAAAEAACcQAAAAEMgHKoZY2F4lXoPh1aAiEbrSkUBYGBR6a1iSA+KUvGTxjXDc7gYVPcL3YpeAqDGLPw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 4, 12, 12, 22, 53, 662, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Products_ProductId",
                table: "Favorites",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
