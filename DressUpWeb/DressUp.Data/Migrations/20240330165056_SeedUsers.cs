using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), 0, null, "088090b5-7e13-4acd-8195-4bbd296bace6", "admin@softuni.bg", true, "Admin", 0, "Adminov", false, null, "ADMIN@SOFTUNI.BG", "ADMIN@SOFTUNI.BG", "AQAAAAEAACcQAAAAEFlFmhl6ImHRtZZb36nGvHA8rwU5wAcLSIrlv8OCpLgjG2lHi35VdEXxZ+WX37AgkQ==", null, false, "078f1394-e303-4e74-9d19-0a9c539b7bd7", false, "admin@softuni.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), 0, null, "ba6922dc-029f-46bf-af69-68dd0104b65a", "user@softuni.bg", true, "User", 0, "Userov", false, null, "USER@SOFTUNI.BG", "USER@SOFTUNI.BG", "AQAAAAEAACcQAAAAEGrutKnhps81ZNAXgxOrbqB9A61ul+3SxkJFwFc5HY8KyLV4vfTJf7JVYGMNQ9JWOw==", null, false, "5ef1716d-6383-48af-b42e-cf0d4f3a1b31", false, "user@softuni.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), 0, null, "059c5197-311f-4ef4-80be-b892460a7b46", "moderator@softuni.bg", true, "Moderator", 1, "Moderatorov", false, null, "MODERATOR@SOFTUNI.BG", "MODERATOR@SOFTUNI.BG", "AQAAAAEAACcQAAAAEHcgXtPolXMFoxOzwUembxzgNhrRzW7oLNCB1LG5MOpyzYkb24zExRB0lDx2B7jasg==", null, false, "7c9e579e-36b4-464b-bf11-8f26f1d525d9", false, "moderator@softuni.bg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));
        }
    }
}
