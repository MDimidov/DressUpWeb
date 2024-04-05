using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class AddSizeTypeToProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SizeType",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "SizeType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "SizeType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "SizeType",
                value: 1);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizeType",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "088090b5-7e13-4acd-8195-4bbd296bace6", "AQAAAAEAACcQAAAAEFlFmhl6ImHRtZZb36nGvHA8rwU5wAcLSIrlv8OCpLgjG2lHi35VdEXxZ+WX37AgkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba6922dc-029f-46bf-af69-68dd0104b65a", "AQAAAAEAACcQAAAAEGrutKnhps81ZNAXgxOrbqB9A61ul+3SxkJFwFc5HY8KyLV4vfTJf7JVYGMNQ9JWOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "059c5197-311f-4ef4-80be-b892460a7b46", "AQAAAAEAACcQAAAAEHcgXtPolXMFoxOzwUembxzgNhrRzW7oLNCB1LG5MOpyzYkb24zExRB0lDx2B7jasg==" });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 3, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 3, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
