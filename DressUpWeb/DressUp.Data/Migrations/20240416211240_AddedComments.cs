using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class AddedComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "StoresProducts",
                comment: "Mapping table with Stores and Products");

            migrationBuilder.AlterTable(
                name: "Stores",
                comment: "Phisical shop/store");

            migrationBuilder.AlterTable(
                name: "ProductImage",
                comment: "Image link for Product");

            migrationBuilder.AlterTable(
                name: "Favorites",
                comment: "Favorite products mapping table");

            migrationBuilder.AlterTable(
                name: "Categories",
                comment: "Dress category");

            migrationBuilder.AlterTable(
                name: "Brands",
                comment: "Dress brand");

            migrationBuilder.AlterTable(
                name: "AspNetUsers",
                comment: "Extendet Identity user table");

            migrationBuilder.AlterTable(
                name: "Addresses",
                comment: "Address table");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OpeningTime",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                comment: "Time when store open",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ContactInfo",
                table: "Stores",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                comment: "Contact information with store",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosingTime",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                comment: "Time when store close",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "SizeType",
                table: "Products",
                type: "int",
                nullable: false,
                comment: "Dress gender type",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "ProductImage",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: false,
                comment: "Image link",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Address street",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38044def-7fe6-4cb0-bdda-8b73d37866e5", "AQAAAAEAACcQAAAAEMlL5DMvby6kdxqTJVrPbkJXU+Qp3sVGM5A63JWmy7KvsgFtH0n+GAt3tW7PJCqptg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b65afe3a-a50a-4c82-b68d-d2a5d07f3517", "AQAAAAEAACcQAAAAEOaFA/2KDnlkOUsYKj0Hb+f6RmDymgsOP5k06B1Rwjgt9MHjYPcvf10q0mZtXlRhSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32a05b0e-5a8a-4f36-be70-33715d92b1d3", "AQAAAAEAACcQAAAAEBfFsh+PEsso1SPo+xt3fuKgu8P9lXaXbRsI6L5EbIJhZ5G+AJvYfmuXKw9tZ7lG+g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 21, 12, 39, 352, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 17, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "StoresProducts",
                oldComment: "Mapping table with Stores and Products");

            migrationBuilder.AlterTable(
                name: "Stores",
                oldComment: "Phisical shop/store");

            migrationBuilder.AlterTable(
                name: "ProductImage",
                oldComment: "Image link for Product");

            migrationBuilder.AlterTable(
                name: "Favorites",
                oldComment: "Favorite products mapping table");

            migrationBuilder.AlterTable(
                name: "Categories",
                oldComment: "Dress category");

            migrationBuilder.AlterTable(
                name: "Brands",
                oldComment: "Dress brand");

            migrationBuilder.AlterTable(
                name: "AspNetUsers",
                oldComment: "Extendet Identity user table");

            migrationBuilder.AlterTable(
                name: "Addresses",
                oldComment: "Address table");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OpeningTime",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Time when store open");

            migrationBuilder.AlterColumn<string>(
                name: "ContactInfo",
                table: "Stores",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldComment: "Contact information with store");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosingTime",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Time when store close");

            migrationBuilder.AlterColumn<int>(
                name: "SizeType",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Dress gender type");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "ProductImage",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldComment: "Image link");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Address street");

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

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
