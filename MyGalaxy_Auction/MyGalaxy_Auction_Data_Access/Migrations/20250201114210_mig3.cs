using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "PaymentHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "PaymentHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1856), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1867), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1871), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1915), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1918), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1921), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1925), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1927), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1930), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1933), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1936), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1939), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1943), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1945), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1948), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1953), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1957), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1962), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1966), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1969), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 21, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1973), new DateTime(2025, 2, 1, 14, 42, 9, 903, DateTimeKind.Local).AddTicks(1973) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "PaymentHistory");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "PaymentHistory");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9706), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9717), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9720), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9723), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9726), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9730), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9735), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9740), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9743), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9746), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9749), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9753), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9756), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9759), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9762), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9765), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9768), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9771), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9774), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9777), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9780), new DateTime(2025, 1, 29, 15, 26, 33, 614, DateTimeKind.Local).AddTicks(9779) });
        }
    }
}
