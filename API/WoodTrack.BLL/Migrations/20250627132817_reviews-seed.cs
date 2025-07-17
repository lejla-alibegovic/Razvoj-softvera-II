using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WoodTrack.BLL.Migrations
{
    /// <inheritdoc />
    public partial class reviewsseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ClientId", "Comment", "DateCreated", "DateUpdated", "IsDeleted", "ProductId", "Rating" },
                values: new object[,]
                {
                    { 1, 3, "Odlično!", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 1, 5 },
                    { 2, 3, "Vrlo korisno.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 2, 4 },
                    { 3, 3, "Nije po mom ukusu.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 3, 2 },
                    { 4, 3, "Lijep dizajn.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 4, 4 },
                    { 5, 4, "Solidno.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 2, 3 },
                    { 6, 4, "Preporučujem.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 3, 4 },
                    { 7, 4, "Savršeno!", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 4, 5 },
                    { 8, 4, "Očekivao sam više.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 5, 2 },
                    { 9, 5, "Jako korisno.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 1, 4 },
                    { 10, 5, "Izvrsno!", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 5, 5 },
                    { 11, 5, "Nije baš kvalitetno.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 6, 2 },
                    { 12, 5, "Ok.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 10, 3 },
                    { 13, 2, "Nisam zadovoljan.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 1, 2 },
                    { 14, 2, "Može proći.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 3, 4 },
                    { 15, 2, "Odlična izrada!", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 6, 5 },
                    { 16, 1, "Koristan proizvod.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 7, 4 },
                    { 17, 1, "Toplo preporučujem.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 8, 5 },
                    { 18, 1, "Nisam oduševljen.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 9, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
