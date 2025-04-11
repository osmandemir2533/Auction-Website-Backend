using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class mig6addDatatoEstateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Estates",
                columns: new[] { "EstateId", "Address", "AuctionPrice", "Description", "EndTime", "Image", "IsActive", "Price", "RoomCount", "SellerId", "SquareMeters", "StartTime", "Title" },
                values: new object[,]
                {
                    { 1, "İstanbul, Beşiktaş", 3550000.0, "Mükemmel manzara", new DateTime(2025, 4, 17, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1958), "estate1.jpg", true, 3500000m, 3, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 120, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1946), "Deniz Manzaralı Daire" },
                    { 2, "İzmir, Urla", 8550000.0, "Havuzlu, güvenlikli site içinde", new DateTime(2025, 4, 20, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1970), "estate2.jpg", true, 8500000m, 5, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 300, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1969), "Lüks Villa" },
                    { 3, "Ankara, Çankaya", 760000.0, "Metroya yakın", new DateTime(2025, 4, 15, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1976), "estate3.jpg", true, 750000m, 1, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 45, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1974), "Öğrenciye Uygun 1+1" },
                    { 4, "Bolu, Merkez", 1220000.0, "Sessiz sakin ortam", new DateTime(2025, 4, 16, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1980), "estate4.jpg", true, 1200000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 90, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1979), "Doğa İçinde Ev" },
                    { 5, "Balıkesir, Edremit", 960000.0, "Müstakil ve geniş bahçeli", new DateTime(2025, 4, 18, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1982), "estate5.jpg", true, 950000m, 3, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 100, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1982), "Bahçeli Köy Evi" },
                    { 6, "İstanbul, Şişli", 2430000.0, "İşlek lokasyon", new DateTime(2025, 4, 14, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1989), "estate6.jpg", true, 2400000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 80, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1988), "Şehir Merkezinde Ofis" },
                    { 7, "İstanbul, Kadıköy", 1720000.0, "Yüksek tavanlı modern tasarım", new DateTime(2025, 4, 17, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1992), "estate7.jpg", true, 1700000m, 1, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 70, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1991), "Satılık Loft Daire" },
                    { 8, "Gebze, Kocaeli", 810000.0, "Geniş ve yükseklik avantajlı", new DateTime(2025, 4, 15, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1995), "estate8.jpg", true, 800000m, 1, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 200, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1994), "Kiralık Depo Alanı" },
                    { 9, "Antalya, Manavgat", 1320000.0, "İmarlı tapulu", new DateTime(2025, 4, 25, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1998), "estate9.jpg", true, 1300000m, 0, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 500, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(1997), "Yatırım İçin Arsa" },
                    { 10, "İstanbul, Sarıyer", 6550000.0, "Eşsiz manzara ve konfor", new DateTime(2025, 4, 20, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2001), "estate10.jpg", true, 6500000m, 4, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 180, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2000), "Boğaz Manzaralı Dubleks" },
                    { 11, "Samsun, Atakum", 875000.0, "Yeni yapılmış", new DateTime(2025, 4, 16, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2004), "estate11.jpg", true, 870000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 85, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2003), "Uygun Fiyatlı Daire" },
                    { 12, "Bursa, Osmangazi", 625000.0, "Yatırımlık eşyalı", new DateTime(2025, 4, 14, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2008), "estate12.jpg", true, 620000m, 1, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 40, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2007), "Merkezi Konumda Stüdyo" },
                    { 13, "Eskişehir, Tepebaşı", 2820000.0, "Aile yaşamına uygun", new DateTime(2025, 4, 19, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2011), "estate13.jpg", true, 2800000m, 5, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 250, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2011), "Bahçeli Tripleks" },
                    { 14, "Konya, Selçuklu", 1010000.0, "Site içerisinde sosyal alanlı", new DateTime(2025, 4, 17, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2015), "estate14.jpg", true, 1000000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 95, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2014), "Yeni Projede 2+1" },
                    { 15, "Muğla, Fethiye", 1465000.0, "Yaz-kış yaşam için ideal", new DateTime(2025, 4, 16, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2018), "estate15.jpg", true, 1450000m, 3, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 110, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2017), "Dağ Manzaralı Yazlık" },
                    { 16, "Ankara, Kızılay", 3930000.0, "Kurumsal firmaya özel", new DateTime(2025, 4, 15, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2023), "estate16.jpg", true, 3900000m, 4, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 150, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2022), "Prestijli Ofis Katı" },
                    { 17, "İzmir, Çeşme", 12100000.0, "Kendine ait iskeleli", new DateTime(2025, 4, 22, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2025), "estate17.jpg", true, 12000000m, 6, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 400, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2025), "Denize Sıfır Villa" },
                    { 18, "Trabzon, Ortahisar", 905000.0, "Aileye uygun", new DateTime(2025, 4, 16, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2029), "estate18.jpg", true, 900000m, 3, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 100, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2028), "Sakin Sokakta Daire" },
                    { 19, "Tekirdağ, Süleymanpaşa", 1120000.0, "Yola cepheli", new DateTime(2025, 4, 24, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2031), "estate19.jpg", true, 1100000m, 0, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 600, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2031), "Konut İmarlı Arsa" },
                    { 20, "İstanbul, Ataşehir", 2220000.0, "Site içi, 7/24 güvenlik", new DateTime(2025, 4, 17, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2034), "estate20.jpg", true, 2200000m, 2, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", 100, new DateTime(2025, 4, 10, 23, 8, 36, 651, DateTimeKind.Local).AddTicks(2034), "Lüks Rezidans Dairesi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Dresses",
                columns: new[] { "DressId", "AdditionalInformation", "AuctionPrice", "Brand", "Color", "EndTime", "Image", "IsActive", "Material", "Price", "SellerId", "Size", "StartTime", "Type" },
                values: new object[,]
                {
                    { 1, "Yazlık kırmızı elbise.", 0.0, "Zara", "Kırmızı", new DateTime(2025, 4, 17, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3319), "https://example.com/images/dress1.jpg", true, "Pamuk", 450.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3314), "Elbise" },
                    { 2, "Şık siyah ceket.", 0.0, "Mango", "Siyah", new DateTime(2025, 4, 15, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3331), "https://example.com/images/dress2.jpg", true, "Polyester", 750.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3331), "Ceket" },
                    { 3, "Kot pantolon.", 0.0, "LC Waikiki", "Mavi", new DateTime(2025, 4, 16, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3335), "https://example.com/images/dress3.jpg", true, "Denim", 300.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3334), "Pantolon" },
                    { 4, "Keten yazlık elbise.", 0.0, "H&M", "Beyaz", new DateTime(2025, 4, 18, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3337), "https://example.com/images/dress4.jpg", true, "Keten", 520.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3337), "Elbise" },
                    { 5, "Kışlık yün ceket.", 0.0, "Pull&Bear", "Lacivert", new DateTime(2025, 4, 20, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3341), "https://example.com/images/dress5.jpg", true, "Yün", 980.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "XL", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3340), "Ceket" },
                    { 6, "Günlük pantolon.", 0.0, "Defacto", "Siyah", new DateTime(2025, 4, 17, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3343), "https://example.com/images/dress6.jpg", true, "Pamuk", 270.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3343), "Pantolon" },
                    { 7, "Şık kot ceket.", 0.0, "Colins", "Açık Mavi", new DateTime(2025, 4, 19, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3346), "https://example.com/images/dress7.jpg", true, "Denim", 680.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3346), "Kot Ceket" },
                    { 8, "Kısa yazlık etek.", 0.0, "Stradivarius", "Pembe", new DateTime(2025, 4, 14, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3349), "https://example.com/images/dress8.jpg", true, "Polyester", 240.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3348), "Etek" },
                    { 9, "Kışlık mont.", 0.0, "Bershka", "Gri", new DateTime(2025, 4, 21, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3352), "https://example.com/images/dress9.jpg", true, "Polyester", 1100.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "XL", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3351), "Mont" },
                    { 10, "Gece elbisesi.", 0.0, "Zara", "Mor", new DateTime(2025, 4, 22, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3355), "https://example.com/images/dress10.jpg", true, "İpek", 1300.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3354), "Elbise" },
                    { 11, "Rahat ceket.", 0.0, "H&M", "Yeşil", new DateTime(2025, 4, 16, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3358), "https://example.com/images/dress11.jpg", true, "Pamuk", 620.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3357), "Ceket" },
                    { 12, "Günlük kullanım için.", 0.0, "Koton", "Bej", new DateTime(2025, 4, 18, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3360), "https://example.com/images/dress12.jpg", true, "Pamuk", 340.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3360), "Pantolon" },
                    { 13, "Klasik gömlek.", 0.0, "Pull&Bear", "Krem", new DateTime(2025, 4, 17, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3363), "https://example.com/images/dress13.jpg", true, "Pamuk", 260.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3363), "Gömlek" },
                    { 14, "Klasik siyah etek.", 0.0, "Zara", "Siyah", new DateTime(2025, 4, 19, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3366), "https://example.com/images/dress14.jpg", true, "İpek", 500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3365), "Etek" },
                    { 15, "Sıcak tutar.", 0.0, "Defacto", "Kahverengi", new DateTime(2025, 4, 23, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3368), "https://example.com/images/dress15.jpg", true, "Yün", 950.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "XL", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3368), "Mont" },
                    { 16, "Ofis stili.", 0.0, "Colins", "Gri", new DateTime(2025, 4, 20, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3371), "https://example.com/images/dress16.jpg", true, "Pamuk", 380.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3371), "Pantolon" },
                    { 17, "Klasik model.", 0.0, "Mavi", "Koyu Mavi", new DateTime(2025, 4, 18, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3375), "https://example.com/images/dress17.jpg", true, "Denim", 740.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "L", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3375), "Kot Ceket" },
                    { 18, "Yazlık mini elbise.", 0.0, "Koton", "Turuncu", new DateTime(2025, 4, 16, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3378), "https://example.com/images/dress18.jpg", true, "Keten", 430.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3378), "Elbise" },
                    { 19, "Uygun fiyatlı.", 0.0, "LC Waikiki", "Bordo", new DateTime(2025, 4, 15, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3381), "https://example.com/images/dress19.jpg", true, "Pamuk", 210.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "S", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3380), "Etek" },
                    { 20, "Nefes alır kumaş.", 0.0, "H&M", "Beyaz", new DateTime(2025, 4, 22, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3383), "https://example.com/images/dress20.jpg", true, "Keten", 290.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", "M", new DateTime(2025, 4, 10, 20, 2, 25, 288, DateTimeKind.Utc).AddTicks(3383), "Gömlek" }
                });
        }
    }
}
