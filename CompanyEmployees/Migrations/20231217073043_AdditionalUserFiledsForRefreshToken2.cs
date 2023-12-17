using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class AdditionalUserFiledsForRefreshToken2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fe59c1d-98df-49e0-8c2d-8664e4ec0b2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5f4c434-4ad2-4df6-b789-ace89ec66281");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98c55dc8-ada5-4e57-949b-3bdaad0a3dc3", "ba63204b-4852-464a-872c-c9ab097601df", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc2f90be-a3bb-4ab9-b2ee-df319087a2af", "012f9e8b-2a31-4b8e-9806-d467c82bf8e9", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98c55dc8-ada5-4e57-949b-3bdaad0a3dc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc2f90be-a3bb-4ab9-b2ee-df319087a2af");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3fe59c1d-98df-49e0-8c2d-8664e4ec0b2d", "562419f5-eed1-473b-bcc1-9f2dbab182b4", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5f4c434-4ad2-4df6-b789-ace89ec66281", "4ac8240a-8498-4869-bc86-60e5dc982d27", "Manager", "MANAGER" });
        }
    }
}
