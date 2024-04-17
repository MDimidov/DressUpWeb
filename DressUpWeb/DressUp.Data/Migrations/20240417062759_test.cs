using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHp7Dsd/uUoIuWSVHGM+C+5ocPSRewIlLNsTxDvqlzPYoCyoOVVpFV0dsnhDYDLCzg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOGAFOUiqL1+I88YXTziOFxY6twwuoifN4zYZhOsmarmMBcwnn7Afq+rNzLNhWQ45A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEbVBiko7KxGQ+v6SjyGb+EjP6VkiKPQ4KCbDovH171TB8idYeRIX1CRXF+fB7YdZQ==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBr+zn0cd9cgzrN6J6q2D54vWZX63kxBQBzpCdvVO30XjzQqkvOOg83VOoTFPgDWUA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFVpa/YN1/wLtVbtkPaMJExKjKt55K1P11QPNswcIog7AOXbBbfKfQLUzETmx5zCkg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOuqXYDAGx4YduNY2KirSTTs9IBb1O6weVdT98YxIYvkOpOTgzbWJUGLPY7+6oaayw==");
        }
    }
}
