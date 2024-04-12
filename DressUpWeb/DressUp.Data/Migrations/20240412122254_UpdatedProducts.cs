using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class UpdatedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
