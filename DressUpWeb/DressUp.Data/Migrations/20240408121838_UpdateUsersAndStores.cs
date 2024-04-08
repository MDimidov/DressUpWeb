using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Data.Migrations
{
    public partial class UpdateUsersAndStores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed4abe96-6169-4217-92f3-170ef87ce5bb", "AQAAAAEAACcQAAAAEIOwHeLcrgoft6b/yy4k5ZtgS2mfMy8DSkfKg2Hjb7X+6hSdqerouTvnPPgYAHbuzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70d42bcc-1fac-41a2-b3d0-537fba3e9c7b", "AQAAAAEAACcQAAAAEL4lxvOoc4lqUt1h3N39iSAyCn9mFenGloZxkqWvAwXXymSNNzL9xhGoXYE/MTE7rQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ef00fba-5310-4b13-9485-e5a2d1bdf4d9", "AQAAAAEAACcQAAAAEBFux+JNamdsDEJAYveuTcT4JwGDaD0LBz9yoYgdtrEbdZoteKQuj9R2Cc/oqTBv4A==" });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2024, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
