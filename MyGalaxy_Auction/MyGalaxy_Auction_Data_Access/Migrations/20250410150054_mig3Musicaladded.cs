using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class mig3Musicaladded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "MusicalInstruments",
                columns: new[] { "MusicalInstrumentId", "Brand", "Description", "EndTime", "Image", "IsActive", "Name", "Price", "SellerId", "StartTime" },
                values: new object[,]
                {
                    { 1, "Yamaha", "Great tone, excellent for beginners and professionals.", new DateTime(2025, 4, 17, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9828), "https://images.musicstore.de/images/1280/yamaha-fg800-natural_1_GIT0044595-000.jpg", true, "Yamaha Acoustic Guitar", 1200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9824) },
                    { 2, "Roland", "88 weighted keys, great for classical and modern styles.", new DateTime(2025, 4, 20, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9838), "https://static.roland.com/assets/images/products/gallery/fp-30x_black_top_gal.jpg", true, "Roland Digital Piano", 3500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9838) },
                    { 3, "Fender", "Classic Stratocaster style, great for rock and blues.", new DateTime(2025, 4, 15, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9841), "https://www.fmicassets.com/Damroot/Lg/10001/0144502500_gtr_frt_001_rr.jpg", true, "Fender Electric Guitar", 4200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9841) },
                    { 4, "Pearl", "Full drum kit for studio and live performance.", new DateTime(2025, 4, 24, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9844), "https://m.media-amazon.com/images/I/71ubtvvV2BL._AC_SL1500_.jpg", true, "Pearl Drum Set", 5800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9843) },
                    { 5, "Bose", "High quality, clear sound system for musicians.", new DateTime(2025, 4, 16, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9846), "https://www.bose.com/content/dam/Bose_DAM/Web/consumer_web/portable/portable_speakers/portable_speakers_front_0_0.jpg", true, "Bose Sound System", 2500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9846) },
                    { 6, "Casio", "Compact, versatile keyboard with built-in sounds.", new DateTime(2025, 4, 18, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9850), "https://images.casio.com/us/casio-keyboard/sa76.jpg", true, "Casio Keyboard", 550.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9849) },
                    { 7, "Ibanez", "Famous for its thin neck and high-speed playability.", new DateTime(2025, 4, 22, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9852), "https://www.ibanez.com/electric-guitars/rg/RG350DX_BKN_01.jpg", true, "Ibanez Electric Guitar", 1500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9851) },
                    { 8, "Korg", "Professional-grade synthesizer for music production.", new DateTime(2025, 4, 19, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9855), "https://www.korg.com/us/products/dj/sq1/images/sq1_photo_01.jpg", true, "Korg Synthesizer", 3000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9854) },
                    { 9, "Ludwig", "Vintage drum set with excellent sound quality.", new DateTime(2025, 4, 17, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9857), "https://m.media-amazon.com/images/I/81TcWrq8JrL._AC_SL1500_.jpg", true, "Ludwig Drum Kit", 4500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9857) },
                    { 10, "Shure", "High quality vocal microphone, great for studio recordings.", new DateTime(2025, 4, 16, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9860), "https://static.shure.com/fgf/7fc/07e/0c51c0cd8cfb61d75d.jpg", true, "Shure Microphone", 350.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9859) },
                    { 11, "Sennheiser", "Studio quality headphones with excellent noise cancellation.", new DateTime(2025, 4, 21, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9862), "https://www.sennheiser.com/media/global/hd660s-m0m.jpg", true, "Sennheiser Headphones", 250.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9862) },
                    { 12, "Mackie", "Professional studio monitors for accurate sound mixing.", new DateTime(2025, 4, 23, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9865), "https://www.mackie.com/sites/default/files/styles/product_gallery/public/2018-06/mr5mk3-front-grill_0.jpg", true, "Mackie Studio Monitors", 1800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9864) },
                    { 13, "Tama", "Full 5-piece drum kit for drummers of all levels.", new DateTime(2025, 4, 18, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9868), "https://www.tama.com/eu/wp-content/uploads/sites/2/2020/06/Starclassic.jpg", true, "Tama Drum Set", 4000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9867) },
                    { 14, "Roland", "Electronic drum pads with great sensitivity and response.", new DateTime(2025, 4, 22, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9870), "https://static.roland.com/assets/images/products/gallery/spd-sx-top-gallery.jpg", true, "Roland Drum Pads", 1200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9870) },
                    { 15, "Gretsch", "Known for its smooth tone, great for jazz and blues.", new DateTime(2025, 4, 19, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9872), "https://www.gretschguitars.com/uploads/media/default/0001/05/8e98d84bdfef0a25d5bcf95a59e682ee105580de.jpg", true, "Gretsch Electric Guitar", 2200.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9872) },
                    { 16, "Vox", "Classic British tone, perfect for rock guitarists.", new DateTime(2025, 4, 25, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9875), "https://www.voxamps.com/wp-content/uploads/2019/10/AC30_C1_3Q_copy.jpg", true, "Vox Amplifier", 1500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9874) },
                    { 17, "Martin", "Legendary acoustic guitars known for their excellent sound.", new DateTime(2025, 4, 24, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9877), "https://images.martinguitar.com/assets/guitars/000-15M.jpg", true, "Martin Acoustic Guitar", 3000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9877) },
                    { 18, "Peavey", "Great bass guitar for beginners and intermediate players.", new DateTime(2025, 4, 20, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9880), "https://www.peavey.com/media/wysiwyg/artist/Bass/Bass_Guitar.jpg", true, "Peavey Bass Guitar", 800.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9879) },
                    { 19, "Line 6", "Modern amp with tons of effects and high-quality sound.", new DateTime(2025, 4, 21, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9882), "https://line6.com/wp-content/uploads/2020/02/HelixLT_Studio_Guitar_Amplifier.jpg", true, "Line 6 Guitar Amp", 1300.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9882) },
                    { 20, "Pearl", "High-quality snare drum, great for any drum set.", new DateTime(2025, 4, 22, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9885), "https://images.pearldrum.com/wp-content/uploads/sites/2/2020/04/pearl-snare.jpg", true, "Pearl Snare Drum", 350.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 15, 0, 53, 881, DateTimeKind.Utc).AddTicks(9884) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Vehicles",
                columns: new[] { "VehicleId", "AdditionalInformation", "AuctionPrice", "BrandAndModel", "Color", "EndTime", "EngineCapacity", "Image", "IsActive", "ManufacturingYear", "Millage", "PlateNumber", "Price", "SellerId", "StartTime" },
                values: new object[,]
                {
                    { 1, "Excellent condition, single owner", 0.0, "Toyota Camry", "Silver", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8434), 2.5m, "https://i.gaw.to/content/photos/39/21/392165_2020_Toyota_Camry.jpg", true, 2020, 15000, "34AA21", 25000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8423) },
                    { 2, "Good condition, one previous owner", 0.0, "Honda Civic", "Blue", new DateTime(2025, 5, 4, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8444), 1.8m, "https://i.pinimg.com/originals/4f/b7/96/4fb796d99758f4889338c69efc74dbfe.jpg", false, 2019, 20000, "34AA21", 18000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8444) },
                    { 3, "Low mileage, well-maintained", 0.0, "Ford F-150", "Red", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8449), 5.0m, "https://www.autopartmax.com/images/cUpload/FORD%20Truck-F150%20Raptor.jpg", true, 2018, 25000, "34AA21", 28000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8448) },
                    { 4, "Great condition, low mileage", 0.0, "Nissan Altima", "Black", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8452), 2.5m, "https://www.jonathanmotorcars.com/imagetag/631/3/l/Used-2017-Nissan-Altima-25-SV-Premium.jpg", true, 2017, 30000, "34AA21", 16000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8452) },
                    { 5, "Well-maintained, single owner", 0.0, "Chevrolet Malibu", "Silver", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8455), 2.4m, "https://cdn.carbuzz.com/gallery-images/2016-chevrolet-malibu-carbuzz-489817-1600.jpg", true, 2017, 28000, "34AA21", 15500.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8455) },
                    { 6, "Like new, low mileage", 0.0, "Ferrari 488 GTB", "Red", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8459), 3.9m, "https://i.pinimg.com/originals/93/2e/fb/932efb625cc97155497cfabd53a57d71.jpg", true, 2022, 1000, "34AA21", 300000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8459) },
                    { 7, "Excellent condition, one owner", 0.0, "Lamborghini Huracan", "Yellow", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8462), 5.2m, "https://w.forfun.com/fetch/03/033f1bda44fe68f0aaa4db19f84a2e54.jpeg", true, 2021, 2000, "34AA21", 280000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8462) },
                    { 8, "Low mileage, well-maintained", 0.0, "Porsche 911", "White", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8466), 3.0m, "https://avatars.mds.yandex.net/get-autoru-vos/6209275/1ee5dfabd4030a68195d9ac37ebf08b2/1200x900", true, 2020, 5000, "34AA21", 180000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8465) },
                    { 9, "Excellent condition, low mileage", 0.0, "Aston Martin DB11", "Black", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8469), 5.2m, "https://images.hgmsites.net/hug/2018-aston-martin-db11_100630564_h.jpg", true, 2019, 6000, "34AA21", 250000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8468) },
                    { 10, "Like new, low mileage", 0.0, "McLaren 720S", "Orange", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8472), 4.0m, "https://www.mclarencf.com/imagetag/42/main/l/New-2020-McLaren-720S-Spider.jpg", true, 2021, 4000, "34AA21", 280000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8471) },
                    { 11, "Rare, collector's item", 0.0, "Bugatti Chiron", "Blue", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8475), 8.0m, "https://coolwallpapers.me/picsup/5650604-bugatti-chiron-wallpapers.jpg", true, 2018, 3000, "34AA21", 350000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8474) },
                    { 12, "High-performance masterpiece", 0.0, "Koenigsegg Jesko", "Silver", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8479), 5.0m, "https://wallpapercave.com/wp/wp5031567.jpg", true, 2022, 1500, "34AA21", 400000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8478) },
                    { 13, "Hybrid supercar, low mileage", 0.0, "Ferrari SF90 Stradale", "Red", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8482), 4.0m, "https://4kwallpapers.com/images/wallpapers/novitec-ferrari-sf90-stradale-2022-5k-8k-2880x1800-8481.jpeg", true, 2021, 2000, "34AA21", 275000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8481) },
                    { 14, "Exotic masterpiece, low mileage", 0.0, "Pagani Huayra", "Green", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8485), 6.0m, "https://www.motorionline.com/wp-content/gallery/pagani-huayra-nc/Pagani-Huayra-NC-1.jpg", true, 2020, 2500, "34AA21", 320000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8485) },
                    { 15, "Luxury sports coupe", 0.0, "Lexus LC 500", "Black", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8488), 5.0m, "https://wallpapercave.com/wp/wp6603188.jpg", true, 2019, 5000, "34AA21", 60000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8488) },
                    { 16, "High-performance electric car", 0.0, "Tesla Model S", "Blue", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8491), 0.0m, "https://i.pinimg.com/originals/8f/b4/3b/8fb43b750028af047cbb0308c0e46014.jpg", true, 2022, 1500, "34AA21", 90000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8491) },
                    { 17, "Luxury sports car, low mileage", 0.0, "Audi R8", "Silver", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8494), 5.2m, "https://wallpapercave.com/wp/wp8343229.jpg", true, 2021, 3000, "34AA21", 120000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8494) },
                    { 18, "High-performance luxury car", 0.0, "Mercedes-AMG GT", "Black", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8498), 4.0m, "https://images.hdqwalls.com/download/mercedes-benz-sls-amg-yellow-5k-hv-3840x2400.jpg", true, 2020, 4000, "34AA21", 110000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8498) },
                    { 19, "High-performance Japanese sports car", 0.0, "Nissan GT-R", "Blue", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8501), 3.8m, "https://i.pinimg.com/originals/e9/75/81/e97581a73660b583b1d982ef23607c24.jpg", true, 2021, 2500, "34AA21", 95000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8501) },
                    { 20, "High-performance American muscle car", 0.0, "Ford Mustang Shelby GT500", "Red", new DateTime(2025, 6, 21, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8504), 5.2m, "https://www.mustangspecs.com/wp-content/uploads/2022/09/carpixel.net-2022-shelby-gt500-mustang-heritage-edition-106565-hd.jpg", true, 2022, 1500, "34AA21", 75000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8504) },
                    { 21, "Sports car with exceptional handling", 0.0, "Porsche Cayman GT4", "Yellow", new DateTime(2025, 5, 28, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8507), 4.0m, "https://media.porsche.com/mediakit/718-cayman-gt4-rs/00-photos/media-drive/718-Cayman-GT4-RS-GT-silbermetallic-S-GO1306/image-thumb__47840__mk2-modal-item/porschecayman_estoril07005_high_1.jpg", true, 2021, 3500, "34AA21", 95000.00m, "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079", new DateTime(2025, 4, 10, 17, 44, 15, 666, DateTimeKind.Local).AddTicks(8507) }
                });
        }
    }
}
