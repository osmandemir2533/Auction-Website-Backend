using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class mig7AddedDatatoElectronic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Electronics",
                columns: new[] { "ElectronicId", "AdditionalInformation", "AuctionPrice", "Brand", "EndTime", "Image", "IsActive", "ManufacturingYear", "Model", "Price", "SellerId", "StartTime" },
                values: new object[,]
                {
                    { 1, "Az kullanılmış, kutulu", 0.0, "Apple", new DateTime(2025, 4, 20, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7626), "https://example.com/images/iphone13.jpg", true, 2021, "iPhone 13", 999.99m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7614) },
                    { 2, "Garantili", 0.0, "Samsung", new DateTime(2025, 4, 17, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7636), "https://example.com/images/s22.jpg", true, 2022, "Galaxy S22", 899.99m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7635) },
                    { 3, "2 kol ile birlikte", 0.0, "Sony", new DateTime(2025, 4, 24, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7639), "https://example.com/images/ps5.jpg", true, 2020, "PlayStation 5", 699.99m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7638) },
                    { 4, "Kutu dahil", 0.0, "Microsoft", new DateTime(2025, 4, 19, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7642), "https://example.com/images/xbox.jpg", true, 2020, "Xbox Series X", 649.99m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7641) },
                    { 5, "Hafif çizik", 0.0, "Dell", new DateTime(2025, 4, 15, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7645), "https://example.com/images/xps13.jpg", true, 2021, "XPS 13", 1200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7644) },
                    { 6, "Touch ekran", 0.0, "HP", new DateTime(2025, 4, 18, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7647), "https://example.com/images/spectre.jpg", true, 2022, "Spectre x360", 1300.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7647) },
                    { 7, "Pil döngüsü 50", 0.0, "Apple", new DateTime(2025, 4, 21, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7650), "https://example.com/images/macbook.jpg", true, 2021, "MacBook Air M1", 999.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7649) },
                    { 8, "İş için ideal", 0.0, "Lenovo", new DateTime(2025, 4, 16, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7653), "https://example.com/images/thinkpad.jpg", true, 2021, "ThinkPad X1 Carbon", 1100.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7652) },
                    { 9, "Fotoğrafçılar için ideal", 0.0, "Canon", new DateTime(2025, 4, 22, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7655), "https://example.com/images/eosr.jpg", true, 2019, "EOS R", 1500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7655) },
                    { 10, "Hobi için drone", 0.0, "DJI", new DateTime(2025, 4, 20, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7659), "https://example.com/images/mavic.jpg", true, 2020, "Mavic Air 2", 800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7657) },
                    { 11, "Tablet, kalem dahil", 0.0, "Samsung", new DateTime(2025, 4, 15, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7661), "https://example.com/images/tabs8.jpg", true, 2022, "Galaxy Tab S8", 600.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7661) },
                    { 12, "11 inch ekran", 0.0, "Apple", new DateTime(2025, 4, 14, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7664), "https://example.com/images/ipad.jpg", true, 2021, "iPad Pro", 1000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7664) },
                    { 13, "Gürültü engelleme", 0.0, "Bose", new DateTime(2025, 4, 13, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7667), "https://example.com/images/bose.jpg", true, 2022, "QuietComfort 45", 299.99m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7666) },
                    { 14, "Kulak üstü kulaklık", 0.0, "Sony", new DateTime(2025, 4, 17, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7669), "https://example.com/images/sony.jpg", true, 2021, "WH-1000XM4", 279.99m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7669) },
                    { 15, "Aksiyon kamerası", 0.0, "GoPro", new DateTime(2025, 4, 16, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7672), "https://example.com/images/gopro.jpg", true, 2021, "Hero 10", 399.99m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7671) },
                    { 16, "Oyun bilgisayarı", 0.0, "Asus", new DateTime(2025, 4, 19, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7675), "https://example.com/images/rog.jpg", true, 2022, "ROG Zephyrus G14", 1400.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7674) },
                    { 17, "Akıllı saat", 0.0, "Apple", new DateTime(2025, 4, 18, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7677), "https://example.com/images/watch.jpg", true, 2021, "Apple Watch Series 7", 450.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7677) },
                    { 18, "Outdoor saat", 0.0, "Garmin", new DateTime(2025, 4, 15, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7680), "https://example.com/images/fenix.jpg", true, 2020, "Fenix 6", 500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7679) },
                    { 19, "Gamer laptop", 0.0, "Razer", new DateTime(2025, 4, 21, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7682), "https://example.com/images/razer.jpg", true, 2022, "Blade 15", 1600.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7682) },
                    { 20, "4K OLED TV", 0.0, "LG", new DateTime(2025, 4, 23, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7685), "https://example.com/images/oled.jpg", true, 2020, "OLED CX", 1800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 23, 18, 37, 635, DateTimeKind.Local).AddTicks(7684) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "ElectronicId",
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
    }
}
