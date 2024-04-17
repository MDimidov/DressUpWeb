using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class ChangeProductAddedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4773499f-bf1e-426c-9395-f566b7bffedb", "AQAAAAEAACcQAAAAEOQFSUfYTYR7OiqhhD7aKY6sx6yTzE517lmvOp6TECTmEg8bFmaFwwUNy+748ACJ4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61df3c55-b703-4cd1-90c3-15bbeb301316", "AQAAAAEAACcQAAAAEKCDNW/COA6XiqfQAE9HE/nogZ5VhVhOxVufXzDTU4YjGvNqJLGAsORFf0S0mfPZcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e01a07e8-eeb4-43a9-b0e1-a6b92c820263", "AQAAAAEAACcQAAAAEIKjqmyYy5TUS4yFd9MRcpa+hPyT21114izKz21IN4oNAjcII/St+B7uSrvbFYFiLA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 4, 15, 10, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 4, 16, 11, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 4, 17, 9, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 4, 18, 14, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 4, 19, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 4, 20, 13, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 4, 21, 16, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 4, 22, 17, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 4, 23, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 4, 24, 10, 45, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
