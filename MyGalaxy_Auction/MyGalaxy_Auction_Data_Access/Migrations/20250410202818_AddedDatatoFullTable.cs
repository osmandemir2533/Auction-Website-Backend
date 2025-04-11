using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class AddedDatatoFullTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dresses",
                columns: new[] { "DressId", "AdditionalInformation", "AuctionPrice", "Brand", "Color", "EndTime", "Image", "IsActive", "Material", "Price", "SellerId", "Size", "StartTime", "Type" },
                values: new object[,]
                {
                    { 1, "Yazlık kırmızı elbise.", 0.0, "Zara", "Kırmızı", new DateTime(2025, 4, 17, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(821), "https://example.com/images/dress1.jpg", true, "Pamuk", 450.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(820), "Elbise" },
                    { 2, "Şık siyah ceket.", 0.0, "Mango", "Siyah", new DateTime(2025, 4, 15, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(825), "https://example.com/images/dress2.jpg", true, "Polyester", 750.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(825), "Ceket" },
                    { 3, "Kot pantolon.", 0.0, "LC Waikiki", "Mavi", new DateTime(2025, 4, 16, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(828), "https://example.com/images/dress3.jpg", true, "Denim", 300.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(828), "Pantolon" },
                    { 4, "Keten yazlık elbise.", 0.0, "H&M", "Beyaz", new DateTime(2025, 4, 18, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(832), "https://example.com/images/dress4.jpg", true, "Keten", 520.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(831), "Elbise" },
                    { 5, "Kışlık yün ceket.", 0.0, "Pull&Bear", "Lacivert", new DateTime(2025, 4, 20, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(834), "https://example.com/images/dress5.jpg", true, "Yün", 980.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "XL", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(834), "Ceket" },
                    { 6, "Günlük pantolon.", 0.0, "Defacto", "Siyah", new DateTime(2025, 4, 17, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(837), "https://example.com/images/dress6.jpg", true, "Pamuk", 270.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(836), "Pantolon" },
                    { 7, "Şık kot ceket.", 0.0, "Colins", "Açık Mavi", new DateTime(2025, 4, 19, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(840), "https://example.com/images/dress7.jpg", true, "Denim", 680.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(840), "Kot Ceket" },
                    { 8, "Kısa yazlık etek.", 0.0, "Stradivarius", "Pembe", new DateTime(2025, 4, 14, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(843), "https://example.com/images/dress8.jpg", true, "Polyester", 240.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(842), "Etek" },
                    { 9, "Kışlık mont.", 0.0, "Bershka", "Gri", new DateTime(2025, 4, 21, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(846), "https://example.com/images/dress9.jpg", true, "Polyester", 1100.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "XL", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(845), "Mont" },
                    { 10, "Gece elbisesi.", 0.0, "Zara", "Mor", new DateTime(2025, 4, 22, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(848), "https://example.com/images/dress10.jpg", true, "İpek", 1300.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(848), "Elbise" },
                    { 11, "Rahat ceket.", 0.0, "H&M", "Yeşil", new DateTime(2025, 4, 16, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(851), "https://example.com/images/dress11.jpg", true, "Pamuk", 620.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(851), "Ceket" },
                    { 12, "Günlük kullanım için.", 0.0, "Koton", "Bej", new DateTime(2025, 4, 18, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(854), "https://example.com/images/dress12.jpg", true, "Pamuk", 340.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(853), "Pantolon" },
                    { 13, "Klasik gömlek.", 0.0, "Pull&Bear", "Krem", new DateTime(2025, 4, 17, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(856), "https://example.com/images/dress13.jpg", true, "Pamuk", 260.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(856), "Gömlek" },
                    { 14, "Klasik siyah etek.", 0.0, "Zara", "Siyah", new DateTime(2025, 4, 19, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(860), "https://example.com/images/dress14.jpg", true, "İpek", 500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(859), "Etek" },
                    { 15, "Sıcak tutar.", 0.0, "Defacto", "Kahverengi", new DateTime(2025, 4, 23, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(862), "https://example.com/images/dress15.jpg", true, "Yün", 950.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "XL", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(862), "Mont" },
                    { 16, "Ofis stili.", 0.0, "Colins", "Gri", new DateTime(2025, 4, 20, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(865), "https://example.com/images/dress16.jpg", true, "Pamuk", 380.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(864), "Pantolon" },
                    { 17, "Klasik model.", 0.0, "Mavi", "Koyu Mavi", new DateTime(2025, 4, 18, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(868), "https://example.com/images/dress17.jpg", true, "Denim", 740.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(867), "Kot Ceket" },
                    { 18, "Yazlık mini elbise.", 0.0, "Koton", "Turuncu", new DateTime(2025, 4, 16, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(871), "https://example.com/images/dress18.jpg", true, "Keten", 430.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(870), "Elbise" },
                    { 19, "Uygun fiyatlı.", 0.0, "LC Waikiki", "Bordo", new DateTime(2025, 4, 15, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(875), "https://example.com/images/dress19.jpg", true, "Pamuk", 210.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(873), "Etek" },
                    { 20, "Nefes alır kumaş.", 0.0, "H&M", "Beyaz", new DateTime(2025, 4, 22, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(878), "https://example.com/images/dress20.jpg", true, "Keten", 290.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(877), "Gömlek" }
                });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 20, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(455), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 17, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 24, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(467), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 19, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(470), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 15, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(473), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(476), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(479), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 16, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(482), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 22, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(485), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 20, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(487), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 15, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(490), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(493), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 13, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(495), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 17, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(498), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 16, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(501), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 19, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(504), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(507), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 15, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(509), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(512), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(514), new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.InsertData(
                table: "Estates",
                columns: new[] { "EstateId", "Address", "AuctionPrice", "Description", "EndTime", "Image", "IsActive", "Price", "RoomCount", "SellerId", "SquareMeters", "StartTime", "Title" },
                values: new object[,]
                {
                    { 1, "İstanbul, Beşiktaş", 3550000.0, "Mükemmel manzara", new DateTime(2025, 4, 17, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(711), "estate1.jpg", true, 3500000m, 3, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 120, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(710), "Deniz Manzaralı Daire" },
                    { 2, "İzmir, Urla", 8550000.0, "Havuzlu, güvenlikli site içinde", new DateTime(2025, 4, 20, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(715), "estate2.jpg", true, 8500000m, 5, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 300, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(714), "Lüks Villa" },
                    { 3, "Ankara, Çankaya", 760000.0, "Metroya yakın", new DateTime(2025, 4, 15, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(727), "estate3.jpg", true, 750000m, 1, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 45, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(726), "Öğrenciye Uygun 1+1" },
                    { 4, "Bolu, Merkez", 1220000.0, "Sessiz sakin ortam", new DateTime(2025, 4, 16, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(729), "estate4.jpg", true, 1200000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 90, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(729), "Doğa İçinde Ev" },
                    { 5, "Balıkesir, Edremit", 960000.0, "Müstakil ve geniş bahçeli", new DateTime(2025, 4, 18, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(732), "estate5.jpg", true, 950000m, 3, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 100, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(732), "Bahçeli Köy Evi" },
                    { 6, "İstanbul, Şişli", 2430000.0, "İşlek lokasyon", new DateTime(2025, 4, 14, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(735), "estate6.jpg", true, 2400000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 80, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(734), "Şehir Merkezinde Ofis" },
                    { 7, "İstanbul, Kadıköy", 1720000.0, "Yüksek tavanlı modern tasarım", new DateTime(2025, 4, 17, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(738), "estate7.jpg", true, 1700000m, 1, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 70, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(737), "Satılık Loft Daire" },
                    { 8, "Gebze, Kocaeli", 810000.0, "Geniş ve yükseklik avantajlı", new DateTime(2025, 4, 15, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(740), "estate8.jpg", true, 800000m, 1, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 200, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(740), "Kiralık Depo Alanı" },
                    { 9, "Antalya, Manavgat", 1320000.0, "İmarlı tapulu", new DateTime(2025, 4, 25, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(743), "estate9.jpg", true, 1300000m, 0, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 500, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(743), "Yatırım İçin Arsa" },
                    { 10, "İstanbul, Sarıyer", 6550000.0, "Eşsiz manzara ve konfor", new DateTime(2025, 4, 20, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(746), "estate10.jpg", true, 6500000m, 4, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 180, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(745), "Boğaz Manzaralı Dubleks" },
                    { 11, "Samsun, Atakum", 875000.0, "Yeni yapılmış", new DateTime(2025, 4, 16, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(748), "estate11.jpg", true, 870000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 85, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(748), "Uygun Fiyatlı Daire" },
                    { 12, "Bursa, Osmangazi", 625000.0, "Yatırımlık eşyalı", new DateTime(2025, 4, 14, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(752), "estate12.jpg", true, 620000m, 1, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 40, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(751), "Merkezi Konumda Stüdyo" },
                    { 13, "Eskişehir, Tepebaşı", 2820000.0, "Aile yaşamına uygun", new DateTime(2025, 4, 19, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(755), "estate13.jpg", true, 2800000m, 5, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 250, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(754), "Bahçeli Tripleks" },
                    { 14, "Konya, Selçuklu", 1010000.0, "Site içerisinde sosyal alanlı", new DateTime(2025, 4, 17, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(757), "estate14.jpg", true, 1000000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 95, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(757), "Yeni Projede 2+1" },
                    { 15, "Muğla, Fethiye", 1465000.0, "Yaz-kış yaşam için ideal", new DateTime(2025, 4, 16, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(760), "estate15.jpg", true, 1450000m, 3, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 110, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(760), "Dağ Manzaralı Yazlık" },
                    { 16, "Ankara, Kızılay", 3930000.0, "Kurumsal firmaya özel", new DateTime(2025, 4, 15, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(763), "estate16.jpg", true, 3900000m, 4, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 150, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(762), "Prestijli Ofis Katı" },
                    { 17, "İzmir, Çeşme", 12100000.0, "Kendine ait iskeleli", new DateTime(2025, 4, 22, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(766), "estate17.jpg", true, 12000000m, 6, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 400, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(765), "Denize Sıfır Villa" },
                    { 18, "Trabzon, Ortahisar", 905000.0, "Aileye uygun", new DateTime(2025, 4, 16, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(769), "estate18.jpg", true, 900000m, 3, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 100, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(768), "Sakin Sokakta Daire" },
                    { 19, "Tekirdağ, Süleymanpaşa", 1120000.0, "Yola cepheli", new DateTime(2025, 4, 24, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(771), "estate19.jpg", true, 1100000m, 0, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 600, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(771), "Konut İmarlı Arsa" },
                    { 20, "İstanbul, Ataşehir", 2220000.0, "Site içi, 7/24 güvenlik", new DateTime(2025, 4, 17, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(775), "estate20.jpg", true, 2200000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 100, new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(774), "Lüks Rezidans Dairesi" }
                });

            migrationBuilder.InsertData(
                table: "MusicalInstruments",
                columns: new[] { "MusicalInstrumentId", "AuctionPrice", "Brand", "Description", "EndTime", "Image", "IsActive", "Name", "Price", "SellerId", "StartTime" },
                values: new object[,]
                {
                    { 1, 0.0, "Yamaha", "Great tone, excellent for beginners and professionals.", new DateTime(2025, 4, 17, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(923), "https://images.musicstore.de/images/1280/yamaha-fg800-natural_1_GIT0044595-000.jpg", true, "Yamaha Acoustic Guitar", 1200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(922) },
                    { 2, 0.0, "Roland", "88 weighted keys, great for classical and modern styles.", new DateTime(2025, 4, 20, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(927), "https://static.roland.com/assets/images/products/gallery/fp-30x_black_top_gal.jpg", true, "Roland Digital Piano", 3500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(926) },
                    { 3, 0.0, "Fender", "Classic Stratocaster style, great for rock and blues.", new DateTime(2025, 4, 15, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(930), "https://www.fmicassets.com/Damroot/Lg/10001/0144502500_gtr_frt_001_rr.jpg", true, "Fender Electric Guitar", 4200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(929) },
                    { 4, 0.0, "Pearl", "Full drum kit for studio and live performance.", new DateTime(2025, 4, 24, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(932), "https://m.media-amazon.com/images/I/71ubtvvV2BL._AC_SL1500_.jpg", true, "Pearl Drum Set", 5800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(932) },
                    { 5, 0.0, "Bose", "High quality, clear sound system for musicians.", new DateTime(2025, 4, 16, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(935), "https://www.bose.com/content/dam/Bose_DAM/Web/consumer_web/portable/portable_speakers/portable_speakers_front_0_0.jpg", true, "Bose Sound System", 2500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(935) },
                    { 6, 0.0, "Casio", "Compact, versatile keyboard with built-in sounds.", new DateTime(2025, 4, 18, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(937), "https://images.casio.com/us/casio-keyboard/sa76.jpg", true, "Casio Keyboard", 550.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(937) },
                    { 7, 0.0, "Ibanez", "Famous for its thin neck and high-speed playability.", new DateTime(2025, 4, 22, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(947), "https://www.ibanez.com/electric-guitars/rg/RG350DX_BKN_01.jpg", true, "Ibanez Electric Guitar", 1500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(947) },
                    { 8, 0.0, "Korg", "Professional-grade synthesizer for music production.", new DateTime(2025, 4, 19, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(949), "https://www.korg.com/us/products/dj/sq1/images/sq1_photo_01.jpg", true, "Korg Synthesizer", 3000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(949) },
                    { 9, 0.0, "Ludwig", "Vintage drum set with excellent sound quality.", new DateTime(2025, 4, 17, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(952), "https://m.media-amazon.com/images/I/81TcWrq8JrL._AC_SL1500_.jpg", true, "Ludwig Drum Kit", 4500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(951) },
                    { 10, 0.0, "Shure", "High quality vocal microphone, great for studio recordings.", new DateTime(2025, 4, 16, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(955), "https://static.shure.com/fgf/7fc/07e/0c51c0cd8cfb61d75d.jpg", true, "Shure Microphone", 350.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(955) },
                    { 11, 0.0, "Sennheiser", "Studio quality headphones with excellent noise cancellation.", new DateTime(2025, 4, 21, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(957), "https://www.sennheiser.com/media/global/hd660s-m0m.jpg", true, "Sennheiser Headphones", 250.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(957) },
                    { 12, 0.0, "Mackie", "Professional studio monitors for accurate sound mixing.", new DateTime(2025, 4, 23, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(960), "https://www.mackie.com/sites/default/files/styles/product_gallery/public/2018-06/mr5mk3-front-grill_0.jpg", true, "Mackie Studio Monitors", 1800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(959) },
                    { 13, 0.0, "Tama", "Full 5-piece drum kit for drummers of all levels.", new DateTime(2025, 4, 18, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(962), "https://www.tama.com/eu/wp-content/uploads/sites/2/2020/06/Starclassic.jpg", true, "Tama Drum Set", 4000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(961) },
                    { 14, 0.0, "Roland", "Electronic drum pads with great sensitivity and response.", new DateTime(2025, 4, 22, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(964), "https://static.roland.com/assets/images/products/gallery/spd-sx-top-gallery.jpg", true, "Roland Drum Pads", 1200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(964) },
                    { 15, 0.0, "Gretsch", "Known for its smooth tone, great for jazz and blues.", new DateTime(2025, 4, 19, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(966), "https://www.gretschguitars.com/uploads/media/default/0001/05/8e98d84bdfef0a25d5bcf95a59e682ee105580de.jpg", true, "Gretsch Electric Guitar", 2200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(966) },
                    { 16, 0.0, "Vox", "Classic British tone, perfect for rock guitarists.", new DateTime(2025, 4, 25, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(970), "https://www.voxamps.com/wp-content/uploads/2019/10/AC30_C1_3Q_copy.jpg", true, "Vox Amplifier", 1500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(969) },
                    { 17, 0.0, "Martin", "Legendary acoustic guitars known for their excellent sound.", new DateTime(2025, 4, 24, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(972), "https://images.martinguitar.com/assets/guitars/000-15M.jpg", true, "Martin Acoustic Guitar", 3000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(972) },
                    { 18, 0.0, "Peavey", "Great bass guitar for beginners and intermediate players.", new DateTime(2025, 4, 20, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(976), "https://www.peavey.com/media/wysiwyg/artist/Bass/Bass_Guitar.jpg", true, "Peavey Bass Guitar", 800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(975) },
                    { 19, 0.0, "Line 6", "Modern amp with tons of effects and high-quality sound.", new DateTime(2025, 4, 21, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(978), "https://line6.com/wp-content/uploads/2020/02/HelixLT_Studio_Guitar_Amplifier.jpg", true, "Line 6 Guitar Amp", 1300.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(977) },
                    { 20, 0.0, "Pearl", "High-quality snare drum, great for any drum set.", new DateTime(2025, 4, 22, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(981), "https://images.pearldrum.com/wp-content/uploads/sites/2/2020/04/pearl-snare.jpg", true, "Pearl Snare Drum", 350.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 20, 28, 17, 680, DateTimeKind.Utc).AddTicks(981) }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "AdditionalInformation", "AuctionPrice", "BrandAndModel", "Color", "EndTime", "EngineCapacity", "Image", "IsActive", "ManufacturingYear", "Millage", "PlateNumber", "Price", "SellerId", "StartTime" },
                values: new object[,]
                {
                    { 1, "Excellent condition, single owner", 0.0, "Toyota Camry", "Silver", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1030), 2.5m, "https://i.gaw.to/content/photos/39/21/392165_2020_Toyota_Camry.jpg", true, 2020, 15000, "34AA21", 25000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1030) },
                    { 2, "Good condition, one previous owner", 0.0, "Honda Civic", "Blue", new DateTime(2025, 5, 4, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1038), 1.8m, "https://i.pinimg.com/originals/4f/b7/96/4fb796d99758f4889338c69efc74dbfe.jpg", false, 2019, 20000, "34AA21", 18000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1038) },
                    { 3, "Low mileage, well-maintained", 0.0, "Ford F-150", "Red", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1042), 5.0m, "https://www.autopartmax.com/images/cUpload/FORD%20Truck-F150%20Raptor.jpg", true, 2018, 25000, "34AA21", 28000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1042) },
                    { 4, "Great condition, low mileage", 0.0, "Nissan Altima", "Black", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1045), 2.5m, "https://www.jonathanmotorcars.com/imagetag/631/3/l/Used-2017-Nissan-Altima-25-SV-Premium.jpg", true, 2017, 30000, "34AA21", 16000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1045) },
                    { 5, "Well-maintained, single owner", 0.0, "Chevrolet Malibu", "Silver", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1049), 2.4m, "https://cdn.carbuzz.com/gallery-images/2016-chevrolet-malibu-carbuzz-489817-1600.jpg", true, 2017, 28000, "34AA21", 15500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1048) },
                    { 6, "Like new, low mileage", 0.0, "Ferrari 488 GTB", "Red", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1053), 3.9m, "https://i.pinimg.com/originals/93/2e/fb/932efb625cc97155497cfabd53a57d71.jpg", true, 2022, 1000, "34AA21", 300000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1053) },
                    { 7, "Excellent condition, one owner", 0.0, "Lamborghini Huracan", "Yellow", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1056), 5.2m, "https://w.forfun.com/fetch/03/033f1bda44fe68f0aaa4db19f84a2e54.jpeg", true, 2021, 2000, "34AA21", 280000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1056) },
                    { 8, "Low mileage, well-maintained", 0.0, "Porsche 911", "White", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1059), 3.0m, "https://avatars.mds.yandex.net/get-autoru-vos/6209275/1ee5dfabd4030a68195d9ac37ebf08b2/1200x900", true, 2020, 5000, "34AA21", 180000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1059) },
                    { 9, "Excellent condition, low mileage", 0.0, "Aston Martin DB11", "Black", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1063), 5.2m, "https://images.hgmsites.net/hug/2018-aston-martin-db11_100630564_h.jpg", true, 2019, 6000, "34AA21", 250000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1062) },
                    { 10, "Like new, low mileage", 0.0, "McLaren 720S", "Orange", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1066), 4.0m, "https://www.mclarencf.com/imagetag/42/main/l/New-2020-McLaren-720S-Spider.jpg", true, 2021, 4000, "34AA21", 280000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1065) },
                    { 11, "Rare, collector's item", 0.0, "Bugatti Chiron", "Blue", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1069), 8.0m, "https://coolwallpapers.me/picsup/5650604-bugatti-chiron-wallpapers.jpg", true, 2018, 3000, "34AA21", 350000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1068) },
                    { 12, "High-performance masterpiece", 0.0, "Koenigsegg Jesko", "Silver", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1073), 5.0m, "https://wallpapercave.com/wp/wp5031567.jpg", true, 2022, 1500, "34AA21", 400000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1071) },
                    { 13, "Hybrid supercar, low mileage", 0.0, "Ferrari SF90 Stradale", "Red", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1076), 4.0m, "https://4kwallpapers.com/images/wallpapers/novitec-ferrari-sf90-stradale-2022-5k-8k-2880x1800-8481.jpeg", true, 2021, 2000, "34AA21", 275000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1075) },
                    { 14, "Exotic masterpiece, low mileage", 0.0, "Pagani Huayra", "Green", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1079), 6.0m, "https://www.motorionline.com/wp-content/gallery/pagani-huayra-nc/Pagani-Huayra-NC-1.jpg", true, 2020, 2500, "34AA21", 320000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1079) },
                    { 15, "Luxury sports coupe", 0.0, "Lexus LC 500", "Black", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1083), 5.0m, "https://wallpapercave.com/wp/wp6603188.jpg", true, 2019, 5000, "34AA21", 60000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1082) },
                    { 16, "High-performance electric car", 0.0, "Tesla Model S", "Blue", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1086), 0.0m, "https://i.pinimg.com/originals/8f/b4/3b/8fb43b750028af047cbb0308c0e46014.jpg", true, 2022, 1500, "34AA21", 90000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1085) },
                    { 17, "Luxury sports car, low mileage", 0.0, "Audi R8", "Silver", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1089), 5.2m, "https://wallpapercave.com/wp/wp8343229.jpg", true, 2021, 3000, "34AA21", 120000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1088) },
                    { 18, "High-performance luxury car", 0.0, "Mercedes-AMG GT", "Black", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1092), 4.0m, "https://images.hdqwalls.com/download/mercedes-benz-sls-amg-yellow-5k-hv-3840x2400.jpg", true, 2020, 4000, "34AA21", 110000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1092) },
                    { 19, "High-performance Japanese sports car", 0.0, "Nissan GT-R", "Blue", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1096), 3.8m, "https://i.pinimg.com/originals/e9/75/81/e97581a73660b583b1d982ef23607c24.jpg", true, 2021, 2500, "34AA21", 95000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1096) },
                    { 20, "High-performance American muscle car", 0.0, "Ford Mustang Shelby GT500", "Red", new DateTime(2025, 6, 21, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1100), 5.2m, "https://www.mustangspecs.com/wp-content/uploads/2022/09/carpixel.net-2022-shelby-gt500-mustang-heritage-edition-106565-hd.jpg", true, 2022, 1500, "34AA21", 75000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1099) },
                    { 21, "Sports car with exceptional handling", 0.0, "Porsche Cayman GT4", "Yellow", new DateTime(2025, 5, 28, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1103), 4.0m, "https://media.porsche.com/mediakit/718-cayman-gt4-rs/00-photos/media-drive/718-Cayman-GT4-RS-GT-silbermetallic-S-GO1306/image-thumb__47840__mk2-modal-item/porschecayman_estoril07005_high_1.jpg", true, 2021, 3500, "34AA21", 95000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 28, 17, 680, DateTimeKind.Local).AddTicks(1103) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dresses",
                keyColumn: "DressId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MusicalInstruments",
                keyColumn: "MusicalInstrumentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 20, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7626), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 17, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7636), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 24, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7639), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 19, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7642), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 15, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7645), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7647), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7650), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 16, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7653), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 22, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7655), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 20, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7659), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 15, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7661), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7664), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 13, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7667), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 17, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7669), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 16, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7672), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 19, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7675), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7677), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 15, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7680), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7682), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7685), new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7684) });
        }
    }
}
