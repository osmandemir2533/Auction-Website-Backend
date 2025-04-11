using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class mig4AddedAuctionpricetomusic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AuctionPrice",
                table: "MusicalInstruments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 1,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 17, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5657), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 2,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 20, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5665), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 3,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 15, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5670), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 4,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 24, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5673), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 5,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 16, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5675), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 6,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 18, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5677), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 7,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 22, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5679), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 8,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 19, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5682), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 9,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 17, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5684), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 10,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 16, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5686), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 11,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 21, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5688), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 12,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 23, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5690), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 13,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 18, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5692), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 14,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 22, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5695), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 15,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 19, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5697), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 16,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 25, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5699), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 17,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 24, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5701), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 18,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 20, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5703), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 19,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 21, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5705), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 20,
                columns: new[] { "AuctionPrice", "EndTime", "StartTime" },
                values: new object[] { 0.0, new DateTime(2025, 4, 22, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5707), new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5707) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuctionPrice",
                table: "MusicalInstruments");

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 17, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9828), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 20, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9838), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 15, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9841), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 24, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9844), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 16, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9846), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 18, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9850), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 22, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9852), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 19, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9855), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 17, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9857), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 16, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9860), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 21, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9862), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9865), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 18, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9868), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 22, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9870), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 19, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9872), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 25, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9875), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 24, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9877), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 20, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9880), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 21, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9882), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 22, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9885), new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9884) });
        }
    }
}
