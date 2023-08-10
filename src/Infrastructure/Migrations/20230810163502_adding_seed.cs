using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adding_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HikerElements",
                columns: new[] { "Id", "Calories", "CreatedBy", "LastModified", "LastModifiedBy", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, 3, null, new DateTime(2023, 8, 10, 11, 35, 2, 531, DateTimeKind.Local).AddTicks(7462), null, "E1", 5 },
                    { 2, 5, null, new DateTime(2023, 8, 10, 11, 35, 2, 531, DateTimeKind.Local).AddTicks(7507), null, "E2", 3 },
                    { 3, 2, null, new DateTime(2023, 8, 10, 11, 35, 2, 531, DateTimeKind.Local).AddTicks(7523), null, "E3", 5 },
                    { 4, 8, null, new DateTime(2023, 8, 10, 11, 35, 2, 531, DateTimeKind.Local).AddTicks(7537), null, "E4", 1 },
                    { 5, 3, null, new DateTime(2023, 8, 10, 11, 35, 2, 531, DateTimeKind.Local).AddTicks(7552), null, "E5", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HikerElements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HikerElements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HikerElements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HikerElements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HikerElements",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
