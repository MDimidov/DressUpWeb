using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class AddConcurrencyStampToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dca95dad-ca99-4dd4-b5b1-73b83c6d780e", "AQAAAAEAACcQAAAAEBr+zn0cd9cgzrN6J6q2D54vWZX63kxBQBzpCdvVO30XjzQqkvOOg83VOoTFPgDWUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a78b333c-6b34-4f45-802d-7c06420f49c9", "AQAAAAEAACcQAAAAEFVpa/YN1/wLtVbtkPaMJExKjKt55K1P11QPNswcIog7AOXbBbfKfQLUzETmx5zCkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dcf30a7f-8abb-4fda-955c-29daf3afc592", "AQAAAAEAACcQAAAAEOuqXYDAGx4YduNY2KirSTTs9IBb1O6weVdT98YxIYvkOpOTgzbWJUGLPY7+6oaayw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
