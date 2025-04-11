using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class mig5AddDataDress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "MusicalInstruments",
                columns: new[] { "MusicalInstrumentId", "AuctionPrice", "Brand", "Description", "EndTime", "Image", "IsActive", "Name", "Price", "SellerId", "StartTime" },
                values: new object[,]
                {
                    { 1, 0.0, "Yamaha", "Great tone, excellent for beginners and professionals.", new DateTime(2025, 4, 17, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5657), "https://images.musicstore.de/images/1280/yamaha-fg800-natural_1_GIT0044595-000.jpg", true, "Yamaha Acoustic Guitar", 1200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5654) },
                    { 2, 0.0, "Roland", "88 weighted keys, great for classical and modern styles.", new DateTime(2025, 4, 20, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5665), "https://static.roland.com/assets/images/products/gallery/fp-30x_black_top_gal.jpg", true, "Roland Digital Piano", 3500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5665) },
                    { 3, 0.0, "Fender", "Classic Stratocaster style, great for rock and blues.", new DateTime(2025, 4, 15, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5670), "https://www.fmicassets.com/Damroot/Lg/10001/0144502500_gtr_frt_001_rr.jpg", true, "Fender Electric Guitar", 4200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5670) },
                    { 4, 0.0, "Pearl", "Full drum kit for studio and live performance.", new DateTime(2025, 4, 24, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5673), "https://m.media-amazon.com/images/I/71ubtvvV2BL._AC_SL1500_.jpg", true, "Pearl Drum Set", 5800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5672) },
                    { 5, 0.0, "Bose", "High quality, clear sound system for musicians.", new DateTime(2025, 4, 16, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5675), "https://www.bose.com/content/dam/Bose_DAM/Web/consumer_web/portable/portable_speakers/portable_speakers_front_0_0.jpg", true, "Bose Sound System", 2500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5675) },
                    { 6, 0.0, "Casio", "Compact, versatile keyboard with built-in sounds.", new DateTime(2025, 4, 18, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5677), "https://images.casio.com/us/casio-keyboard/sa76.jpg", true, "Casio Keyboard", 550.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5677) },
                    { 7, 0.0, "Ibanez", "Famous for its thin neck and high-speed playability.", new DateTime(2025, 4, 22, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5679), "https://www.ibanez.com/electric-guitars/rg/RG350DX_BKN_01.jpg", true, "Ibanez Electric Guitar", 1500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5679) },
                    { 8, 0.0, "Korg", "Professional-grade synthesizer for music production.", new DateTime(2025, 4, 19, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5682), "https://www.korg.com/us/products/dj/sq1/images/sq1_photo_01.jpg", true, "Korg Synthesizer", 3000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5681) },
                    { 9, 0.0, "Ludwig", "Vintage drum set with excellent sound quality.", new DateTime(2025, 4, 17, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5684), "https://m.media-amazon.com/images/I/81TcWrq8JrL._AC_SL1500_.jpg", true, "Ludwig Drum Kit", 4500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5683) },
                    { 10, 0.0, "Shure", "High quality vocal microphone, great for studio recordings.", new DateTime(2025, 4, 16, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5686), "https://static.shure.com/fgf/7fc/07e/0c51c0cd8cfb61d75d.jpg", true, "Shure Microphone", 350.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5685) },
                    { 11, 0.0, "Sennheiser", "Studio quality headphones with excellent noise cancellation.", new DateTime(2025, 4, 21, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5688), "https://www.sennheiser.com/media/global/hd660s-m0m.jpg", true, "Sennheiser Headphones", 250.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5688) },
                    { 12, 0.0, "Mackie", "Professional studio monitors for accurate sound mixing.", new DateTime(2025, 4, 23, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5690), "https://www.mackie.com/sites/default/files/styles/product_gallery/public/2018-06/mr5mk3-front-grill_0.jpg", true, "Mackie Studio Monitors", 1800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5690) },
                    { 13, 0.0, "Tama", "Full 5-piece drum kit for drummers of all levels.", new DateTime(2025, 4, 18, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5692), "https://www.tama.com/eu/wp-content/uploads/sites/2/2020/06/Starclassic.jpg", true, "Tama Drum Set", 4000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5692) },
                    { 14, 0.0, "Roland", "Electronic drum pads with great sensitivity and response.", new DateTime(2025, 4, 22, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5695), "https://static.roland.com/assets/images/products/gallery/spd-sx-top-gallery.jpg", true, "Roland Drum Pads", 1200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5694) },
                    { 15, 0.0, "Gretsch", "Known for its smooth tone, great for jazz and blues.", new DateTime(2025, 4, 19, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5697), "https://www.gretschguitars.com/uploads/media/default/0001/05/8e98d84bdfef0a25d5bcf95a59e682ee105580de.jpg", true, "Gretsch Electric Guitar", 2200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5696) },
                    { 16, 0.0, "Vox", "Classic British tone, perfect for rock guitarists.", new DateTime(2025, 4, 25, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5699), "https://www.voxamps.com/wp-content/uploads/2019/10/AC30_C1_3Q_copy.jpg", true, "Vox Amplifier", 1500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5698) },
                    { 17, 0.0, "Martin", "Legendary acoustic guitars known for their excellent sound.", new DateTime(2025, 4, 24, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5701), "https://images.martinguitar.com/assets/guitars/000-15M.jpg", true, "Martin Acoustic Guitar", 3000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5700) },
                    { 18, 0.0, "Peavey", "Great bass guitar for beginners and intermediate players.", new DateTime(2025, 4, 20, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5703), "https://www.peavey.com/media/wysiwyg/artist/Bass/Bass_Guitar.jpg", true, "Peavey Bass Guitar", 800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5703) },
                    { 19, 0.0, "Line 6", "Modern amp with tons of effects and high-quality sound.", new DateTime(2025, 4, 21, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5705), "https://line6.com/wp-content/uploads/2020/02/HelixLT_Studio_Guitar_Amplifier.jpg", true, "Line 6 Guitar Amp", 1300.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5705) },
                    { 20, 0.0, "Pearl", "High-quality snare drum, great for any drum set.", new DateTime(2025, 4, 22, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5707), "https://images.pearldrum.com/wp-content/uploads/sites/2/2020/04/pearl-snare.jpg", true, "Pearl Snare Drum", 350.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 19, 51, 14, 571, DateTimeKind.Utc).AddTicks(5707) }
                });
        }
    }
}
