using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGalaxy_Auction_Data_Access.Domain;
using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Data_Access.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<PaymentHistory> PaymentHistories { get; set; }
        public DbSet<Electronic> Electronics { get; set; }
        public DbSet<Dress> Dresses { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<MusicalInstrument> MusicalInstruments { get; set; }
//        protected override void OnModelCreating(ModelBuilder builder)
//        {
//            base.OnModelCreating(builder);
//            builder.Entity<Electronic>().HasData(

//new Electronic { ElectronicId = 1, Brand = "Apple", Model = "iPhone 13", ManufacturingYear = 2021, Price = 999.99m, AuctionPrice = 0.0, AdditionalInformation = "Az kullanılmış, kutulu", IsActive = true, Image = "https://cdn1.ozone.ru/s3/multimedia-w/6381880868.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(10), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 2, Brand = "Samsung", Model = "Galaxy S22", ManufacturingYear = 2022, Price = 899.99m, AuctionPrice = 0.0, AdditionalInformation = "Garantili", IsActive = true, Image = "https://img.teknolojioku.com/rcman/Cw820h547q95gm/storage/files/images/2022/09/22/jj-rNA5.png", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 3, Brand = "Sony", Model = "PlayStation 5", ManufacturingYear = 2020, Price = 699.99m, AuctionPrice = 0.0, AdditionalInformation = "2 kol ile birlikte", IsActive = true, Image = "https://img.pttavm.com/pimages/592/187/469/6294c4825c11b.jpg?v=201910111530", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(14), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 4, Brand = "Microsoft", Model = "Xbox Series X", ManufacturingYear = 2020, Price = 649.99m, AuctionPrice = 0.0, AdditionalInformation = "Kutu dahil", IsActive = true, Image = "https://cdn.webshopapp.com/shops/105494/files/447854700/image.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(9), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 5, Brand = "Dell", Model = "XPS 13", ManufacturingYear = 2021, Price = 1200.00m, AuctionPrice = 0.0, AdditionalInformation = "Hafif çizik", IsActive = true, Image = "https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/media/image/2017/03/227210-imagenes-dell-xps-13-9360.jpg?tf=3840x", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 6, Brand = "HP", Model = "Spectre x360", ManufacturingYear = 2022, Price = 1300.00m, AuctionPrice = 0.0, AdditionalInformation = "Touch ekran", IsActive = true, Image = "https://www.01net.com/app/uploads/2022/03/1256x708-Recupere.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(8), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 7, Brand = "Apple", Model = "MacBook Air M1", ManufacturingYear = 2021, Price = 999.00m, AuctionPrice = 0.0, AdditionalInformation = "Pil döngüsü 50", IsActive = true, Image = "https://media.cnn.com/api/v1/images/stellar/prod/201116214440-9-macbook-air-review-silicon-underscoredjpg.jpg?q=x_0,y_41,h_1471,w_2615,c_crop", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(11), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 8, Brand = "Lenovo", Model = "ThinkPad X1 Carbon", ManufacturingYear = 2021, Price = 1100.00m, AuctionPrice = 0.0, AdditionalInformation = "İş için ideal", IsActive = true, Image = "https://m.media-amazon.com/images/I/51546BBLofL.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 9, Brand = "Canon", Model = "EOS R", ManufacturingYear = 2019, Price = 1500.00m, AuctionPrice = 0.0, AdditionalInformation = "Fotoğrafçılar için ideal", IsActive = true, Image = "https://technovybor.ru/wa-data/public/shop/products/50/51/5150/images/15431/15431.970.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(12), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 10, Brand = "DJI", Model = "Mavic Air 2", ManufacturingYear = 2020, Price = 800.00m, AuctionPrice = 0.0, AdditionalInformation = "Hobi için drone", IsActive = true, Image = "https://ir.ozone.ru/s3/multimedia-h/6747076745.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(10), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 11, Brand = "Samsung", Model = "Galaxy Tab S8", ManufacturingYear = 2022, Price = 600.00m, AuctionPrice = 0.0, AdditionalInformation = "Tablet, kalem dahil", IsActive = true, Image = "https://www.popsci.com/wp-content/uploads/2022/05/06/Best_Samsung_Tablets_Samsung_2.jpg?auto=webp", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 12, Brand = "Apple", Model = "iPad Pro", ManufacturingYear = 2021, Price = 1000.00m, AuctionPrice = 0.0, AdditionalInformation = "11 inch ekran", IsActive = true, Image = "https://i0.wp.com/www.smartprix.com/bytes/wp-content/uploads/2023/11/2024-iPad-Pro.jpg?ssl=1&quality=80&w=1200", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(4), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 13, Brand = "Bose", Model = "QuietComfort 45", ManufacturingYear = 2022, Price = 299.99m, AuctionPrice = 0.0, AdditionalInformation = "Gürültü engelleme", IsActive = true, Image = "https://cdn.ecoustics.com/db0/wblob/17BA35E873D594/2CD8/43823/rQ3KUloKebyvMFSklo9j8LjXtnwKqdN6s0ssjUoYrME/bose-quietcomfort-45-side-view.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(3), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 14, Brand = "Sony", Model = "WH-1000XM4", ManufacturingYear = 2021, Price = 279.99m, AuctionPrice = 0.0, AdditionalInformation = "Kulak üstü kulaklık", IsActive = true, Image = "https://sonyimages.blob.core.windows.net/productr/large/WH1000XM4W.CE7_0.png", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 15, Brand = "GoPro", Model = "Hero 10", ManufacturingYear = 2021, Price = 399.99m, AuctionPrice = 0.0, AdditionalInformation = "Aksiyon kamerası", IsActive = true, Image = "https://salebazar.ru/wa-data/public/shop/products/35/85/8535/images/23547/23547.970.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 16, Brand = "Asus", Model = "ROG Zephyrus G14", ManufacturingYear = 2022, Price = 1400.00m, AuctionPrice = 0.0, AdditionalInformation = "Oyun bilgisayarı", IsActive = true, Image = "https://cdn.mos.cms.futurecdn.net/R2hy5frkGhqdvj5DnLthJG-1200-80.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(9), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 17, Brand = "Apple", Model = "Apple Watch Series 7", ManufacturingYear = 2021, Price = 450.00m, AuctionPrice = 0.0, AdditionalInformation = "Akıllı saat", IsActive = true, Image = "https://usbs-uae.com/cdn/shop/files/S100689169_1.jpg?v=1710011028", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(8), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 18, Brand = "Garmin", Model = "Fenix 6", ManufacturingYear = 2020, Price = 500.00m, AuctionPrice = 0.0, AdditionalInformation = "Outdoor saat", IsActive = true, Image = "https://cdn.road.cc/sites/default/files/garmin-fenix-6-pro-solar-info-screen-1.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 19, Brand = "Razer", Model = "Blade 15", ManufacturingYear = 2022, Price = 1600.00m, AuctionPrice = 0.0, AdditionalInformation = "Gamer laptop", IsActive = true, Image = "https://m.media-amazon.com/images/I/71kBeFDgCkL._AC_UY654_QL65_.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(11), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Electronic { ElectronicId = 20, Brand = "LG", Model = "OLED CX", ManufacturingYear = 2020, Price = 1800.00m, AuctionPrice = 0.0, AdditionalInformation = "4K OLED TV", IsActive = true, Image = "https://www.techspot.com/images/products/2020/monitors/org/2020-10-11-product-7.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(13), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" }
//);



//            builder.Entity<Estate>().HasData(
//    new Estate { EstateId = 1, Title = "Deniz Manzaralı Daire", Description = "Mükemmel manzara", Address = "İstanbul, Beşiktaş", RoomCount = 3, SquareMeters = 120, Price = 3500000, AuctionPrice = 3550000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), IsActive = true, Image = "https://imaj.emlakjet.com/listing/13997410/09F58EA71BC6D024AA36F5216DABBE8113997410.jpeg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 2, Title = "Lüks Villa", Description = "Havuzlu, güvenlikli site içinde", Address = "İzmir, Urla", RoomCount = 5, SquareMeters = 300, Price = 8500000, AuctionPrice = 8550000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(10), IsActive = true, Image = "https://i.ytimg.com/vi/MzCMMzby_60/maxresdefault.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 3, Title = "Öğrenciye Uygun 1+1", Description = "Metroya yakın", Address = "Ankara, Çankaya", RoomCount = 1, SquareMeters = 45, Price = 750000, AuctionPrice = 760000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), IsActive = true, Image = "https://avatars.mds.yandex.net/get-altay/5236391/2a0000017c13f1889da289e513ae60d13ddc/XXL_height", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 4, Title = "Doğa İçinde Ev", Description = "Sessiz sakin ortam", Address = "Bolu, Merkez", RoomCount = 2, SquareMeters = 90, Price = 1200000, AuctionPrice = 1220000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), IsActive = true, Image = "https://i3.wp.com/cdn3.enuygun.com/media/lib/uploads/image/zumrut-dag-evi-bolu-genel-40931703.jpg?ssl=1", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 5, Title = "Bahçeli Köy Evi", Description = "Müstakil ve geniş bahçeli", Address = "Balıkesir, Edremit", RoomCount = 3, SquareMeters = 100, Price = 950000, AuctionPrice = 960000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(8), IsActive = true, Image = "https://imaj.emlakjet.com/listing/9566460/57B88BF66D3147EAE5B2DD0D4622D3DD9566460.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 6, Title = "Şehir Merkezinde Ofis", Description = "İşlek lokasyon", Address = "İstanbul, Şişli", RoomCount = 2, SquareMeters = 80, Price = 2400000, AuctionPrice = 2430000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(4), IsActive = true, Image = "https://avatars.mds.yandex.net/get-altay/876204/2a0000018760cb22676f08c1a7c0f9900474/XXXL", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 7, Title = "Satılık Loft Daire", Description = "Yüksek tavanlı modern tasarım", Address = "İstanbul, Kadıköy", RoomCount = 1, SquareMeters = 70, Price = 1700000, AuctionPrice = 1720000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), IsActive = true, Image = "https://i.pinimg.com/736x/76/3f/b2/763fb25f64a1373223c0529ed4216ac9.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 8, Title = "Kiralık Depo Alanı", Description = "Geniş ve yükseklik avantajlı", Address = "Gebze, Kocaeli", RoomCount = 1, SquareMeters = 200, Price = 800000, AuctionPrice = 810000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), IsActive = true, Image = "https://www.depokirala.com/images/depo/1110201716234761.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 9, Title = "Yatırım İçin Arsa", Description = "İmarlı tapulu", Address = "Antalya, Manavgat", RoomCount = 0, SquareMeters = 500, Price = 1300000, AuctionPrice = 1320000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(15), IsActive = true, Image = "https://imaj.emlakjet.com/listing/14990719/77FF708C308ED1AD0B4286E24607CD1614990719.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 10, Title = "Boğaz Manzaralı Dubleks", Description = "Eşsiz manzara ve konfor", Address = "İstanbul, Sarıyer", RoomCount = 4, SquareMeters = 180, Price = 6500000, AuctionPrice = 6550000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(10), IsActive = true, Image = "https://i.pinimg.com/736x/9d/a2/71/9da271228d6e4994f01831a5f681b92b.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 11, Title = "Uygun Fiyatlı Daire", Description = "Yeni yapılmış", Address = "Samsun, Atakum", RoomCount = 2, SquareMeters = 85, Price = 870000, AuctionPrice = 875000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), IsActive = true, Image = "https://www.hedefhalk.com/images/haberler/2024/03/atakum-ve-bafra-da-uygun-fiyatli-konut-firsati-100-metrekare-evler-sadece-600-bin-lira-4414.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 12, Title = "Merkezi Konumda Stüdyo", Description = "Yatırımlık eşyalı", Address = "Bursa, Osmangazi", RoomCount = 1, SquareMeters = 40, Price = 620000, AuctionPrice = 625000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(4), IsActive = true, Image = "https://grpstat.com/DealImages/K-k3ozabt3/z35018__4_600-400.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 13, Title = "Bahçeli Tripleks", Description = "Aile yaşamına uygun", Address = "Eskişehir, Tepebaşı", RoomCount = 5, SquareMeters = 250, Price = 2800000, AuctionPrice = 2820000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(9), IsActive = true, Image = "https://imaj.emlakjet.com/resize/600/375/listing/9085402/75FBB7F751DCBED3164815928CE302109085402.JPG", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 14, Title = "Yeni Projede 2+1", Description = "Site içerisinde sosyal alanlı", Address = "Konya, Selçuklu", RoomCount = 2, SquareMeters = 95, Price = 1000000, AuctionPrice = 1010000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), IsActive = true, Image = "https://www.yeniemlak.com/uploads/1/8/7/konya-selcukludaki-sosyal-konut-projesi-icin-dugmeye-basildi-projesi-187509-1589449370.jpeg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 15, Title = "Dağ Manzaralı Yazlık", Description = "Yaz-kış yaşam için ideal", Address = "Muğla, Fethiye", RoomCount = 3, SquareMeters = 110, Price = 1450000, AuctionPrice = 1465000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), IsActive = true, Image = "https://attaches.1001tur.ru/hotels/gallery/475219/13511501989112.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 16, Title = "Prestijli Ofis Katı", Description = "Kurumsal firmaya özel", Address = "Ankara, Kızılay", RoomCount = 4, SquareMeters = 150, Price = 3900000, AuctionPrice = 3930000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), IsActive = true, Image = "https://www.erdemavci.com/Images/LXEF4D4DB09FC5EF074DBF2E7B02D48D28.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 17, Title = "Denize Sıfır Villa", Description = "Kendine ait iskeleli", Address = "İzmir, Çeşme", RoomCount = 6, SquareMeters = 400, Price = 12000000, AuctionPrice = 12100000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(12), IsActive = true, Image = "https://imaj.emlakjet.com/listing/10839483/366F71936E9288DB84C17959B5AEC96910839483.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 18, Title = "Sakin Sokakta Daire", Description = "Aileye uygun", Address = "Trabzon, Ortahisar", RoomCount = 3, SquareMeters = 100, Price = 900000, AuctionPrice = 905000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), IsActive = true, Image = "https://cdn.domaza.biz/upload/properties/82/342/8082342/49043b828df4eab15ecf8eacd0d146b21e7ef1c3.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 19, Title = "Konut İmarlı Arsa", Description = "Yola cepheli", Address = "Tekirdağ, Süleymanpaşa", RoomCount = 0, SquareMeters = 600, Price = 1100000, AuctionPrice = 1120000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(14), IsActive = true, Image = "https://imaj.emlakjet.com/listing/12150201/B755205DF6D3DC20B496E4E62D58426B12150201.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Estate { EstateId = 20, Title = "Lüks Rezidans Dairesi", Description = "Site içi, 7/24 güvenlik", Address = "İstanbul, Ataşehir", RoomCount = 2, SquareMeters = 100, Price = 2200000, AuctionPrice = 2220000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), IsActive = true, Image = "https://www.arkanproje.com/uploads/projects/47/fb1e8ad2a369f61ec0a980e9f1e9ecc28-5U.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" }
//);


//            builder.Entity<Dress>().HasData(
//    new Dress
//    {
//        DressId = 1,
//        Brand = "Zara",
//        Type = "Elbise",
//        Size = "M",
//        Color = "Kırmızı",
//        Material = "Pamuk",
//        Price = 450.00m,
//        AdditionalInformation = "Yazlık kırmızı elbise.",
//        AuctionPrice = 0,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(7),
//        IsActive = true,
//        Image = "https://media-hosting.imagekit.io/02003bdc067d464b/images.jpg?Expires=1839145220&Key-Pair-Id=K2ZIVPTIP2VGHC&Signature=Z2rZ3zMya8xvwmIDM6hUtRZQq9E9KHrA7J8YCcKGFUCqtl5W5oATJoKRZWXGop-hGoT9pmVPHl~b4IWfoGE5ixZp0ZH7qNy3cbTzsukmtXgTb7G~h4mXsVVE4EWlRbZ9B39bsEesPvZCufADrZuDh0aLokcku7PgNgBMXidsGwC9NWlo2ln~BTVDP8ibGOnAkroV6jCIDZ~UAXwnJoYHTINxUEj5cv0UzaF0xCr-tIJaqdfMyDQBg~SBFbCb5nmLzGofEqyFdOthNCBZwU9SvqNTZaBdw4lB0cfLs7Q82Y46YfVhzxu6JcMaYqORw23age94-kYK8444d6NJKZOagA__",
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new Dress
//    {
//        DressId = 2,
//        Brand = "Mango",
//        Type = "Ceket",
//        Size = "L",
//        Color = "Siyah",
//        Material = "Polyester",
//        Price = 750.00m,
//        AdditionalInformation = "Şık siyah ceket.",
//        AuctionPrice = 0,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(5),
//        IsActive = true,
//        Image = "https://r.resimlink.com/n1quFS-z.jpg",
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new Dress
//    {
//        DressId = 3,
//        Brand = "LC Waikiki",
//        Type = "Pantolon",
//        Size = "S",
//        Color = "Mavi",
//        Material = "Denim",
//        Price = 300.00m,
//        AdditionalInformation = "Kot pantolon.",
//        AuctionPrice = 0,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(6),
//        IsActive = true,
//        Image = "https://r.resimlink.com/-Er8laF.jpg",
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },

//new Dress
//{
//    DressId = 4,
//    Brand = "H&M",
//    Type = "Elbise",
//    Size = "L",
//    Color = "Beyaz",
//    Material = "Keten",
//    Price = 520.00m,
//    AdditionalInformation = "Keten yazlık elbise.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(8),
//    IsActive = true,
//    Image = "https://r.resimlink.com/aEmBizZk4.jpg",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},

//new Dress
//{
//    DressId = 5,
//    Brand = "Pull&Bear",
//    Type = "Ceket",
//    Size = "XL",
//    Color = "Lacivert",
//    Material = "Yün",
//    Price = 980.00m,
//    AdditionalInformation = "Kışlık yün ceket.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(10),
//    IsActive = true,
//    Image = "https://i.pinimg.com/736x/7e/7a/cd/7e7acd312bc3ca9b5a8882229f4105a8.jpg",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},

//new Dress
//{
//    DressId = 6,
//    Brand = "Defacto",
//    Type = "Pantolon",
//    Size = "M",
//    Color = "Siyah",
//    Material = "Pamuk",
//    Price = 270.00m,
//    AdditionalInformation = "Günlük pantolon.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(7),
//    IsActive = true,
//    Image = "https://dfcdn.defacto.com.tr/7/L8123AZ_19HS_BK27_01_01.jpg",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},

//new Dress
//{
//    DressId = 7,
//    Brand = "Colins",
//    Type = "Kot Ceket",
//    Size = "L",
//    Color = "Açık Mavi",
//    Material = "Denim",
//    Price = 680.00m,
//    AdditionalInformation = "Şık kot ceket.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(9),
//    IsActive = true,
//    Image = "https://cms.brnstc.de/product_images/287x393_retina/cpro/media/images/product/22/8/100131925617000_0_1659510691217.jpg",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},

//new Dress
//{
//    DressId = 8,
//    Brand = "Stradivarius",
//    Type = "Etek",
//    Size = "S",
//    Color = "Pembe",
//    Material = "Polyester",
//    Price = 240.00m,
//    AdditionalInformation = "Kısa yazlık etek.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(4),
//    IsActive = true,
//    Image = "https://i.pinimg.com/originals/46/8b/bf/468bbf53fce1087636df99e6e5c8d91d.jpg",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},

//new Dress
//{
//    DressId = 9,
//    Brand = "Bershka",
//    Type = "Mont",
//    Size = "XL",
//    Color = "Gri",
//    Material = "Polyester",
//    Price = 1100.00m,
//    AdditionalInformation = "Kışlık mont.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(11),
//    IsActive = true,
//    Image = "https://static.glami.com.tr/img/228x298be/299370963.jpg",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},

//new Dress
//{
//    DressId = 10,
//    Brand = "Zara",
//    Type = "Elbise",
//    Size = "M",
//    Color = "Mor",
//    Material = "İpek",
//    Price = 1300.00m,
//    AdditionalInformation = "Gece elbisesi.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(12),
//    IsActive = true,
//    Image = "https://static.trendme.net/pictures/items/Gown_Dresses-beleev-full-34811-1521096.png",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},

//new Dress
//{
//    DressId = 11,
//    Brand = "H&M",
//    Type = "Ceket",
//    Size = "S",
//    Color = "Yeşil",
//    Material = "Pamuk",
//    Price = 620.00m,
//    AdditionalInformation = "Rahat ceket.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(6),
//    IsActive = true,
//    Image = "https://img.fruugo.com/product/4/38/184396384_max.jpg",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},

//new Dress
//{
//    DressId = 12,
//    Brand = "Koton",
//    Type = "Pantolon",
//    Size = "L",
//    Color = "Bej",
//    Material = "Pamuk",
//    Price = 340.00m,
//    AdditionalInformation = "Günlük kullanım için.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(8),
//    IsActive = true,
//    Image = "https://image.hm.com/assets/hm/d9/b0/d9b0ef8759858d08b00213d50b2cf3d07ad51a0b.jpg?imwidth=1260",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},

//new Dress
//{
//    DressId = 13,
//    Brand = "Pull&Bear",
//    Type = "Gömlek",
//    Size = "M",
//    Color = "Krem",
//    Material = "Pamuk",
//    Price = 260.00m,
//    AdditionalInformation = "Klasik gömlek.",
//    AuctionPrice = 0,
//    StartTime = DateTime.UtcNow,
//    EndTime = DateTime.UtcNow.AddDays(7),
//    IsActive = true,
//    Image = "https://img.pttavm.com/pimages/592/109/017/619c1af6200cb.jpg?v=201910111530",
//    SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//},
//    new Dress { DressId = 14, Brand = "Zara", Type = "Etek", Size = "S", Color = "Siyah", Material = "İpek", Price = 500.00m, AdditionalInformation = "Klasik siyah etek.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(9), IsActive = true, Image = "https://i.pinimg.com/736x/96/0c/37/960c378179e9b29c5847a82c61b85597.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Dress { DressId = 15, Brand = "Defacto", Type = "Mont", Size = "XL", Color = "Kahverengi", Material = "Yün", Price = 950.00m, AdditionalInformation = "Sıcak tutar.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(13), IsActive = true, Image = "https://cdn-kaspi.kz/shop/medias/sys_master/images/images/h09/h44/12600490983454/defacto-m3916azkzka-odnotonnaa-koricnevaa-s-100253406-1.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Dress { DressId = 16, Brand = "Colins", Type = "Pantolon", Size = "M", Color = "Gri", Material = "Pamuk", Price = 380.00m, AdditionalInformation = "Ofis stili.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(10), IsActive = true, Image = "https://damat.akinoncdn.com/products/2020/05/20/92520/89474065-e82b-41c1-a813-ac6246e9c702.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },


//    new Dress { DressId = 17, Brand = "Mavi", Type = "Kot Ceket", Size = "L", Color = "Koyu Mavi", Material = "Denim", Price = 740.00m, AdditionalInformation = "Klasik model.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(8), IsActive = true, Image = "https://cdn1.ozone.ru/s3/multimedia-o/6402400572.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Dress { DressId = 18, Brand = "Koton", Type = "Elbise", Size = "M", Color = "Turuncu", Material = "Keten", Price = 430.00m, AdditionalInformation = "Yazlık mini elbise.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(6), IsActive = true, Image = "https://i.pinimg.com/736x/e7/5e/ad/e75ead373ee51b444de933ebdeb496b4.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 19, Brand = "LC Waikiki", Type = "Etek", Size = "S", Color = "Bordo", Material = "Pamuk", Price = 210.00m, AdditionalInformation = "Uygun fiyatlı.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(5), IsActive = true, Image = "https://i.pinimg.com/736x/f3/34/5e/f3345ecb108705185244ccf6da76971b.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },

//    new Dress { DressId = 20, Brand = "H&M", Type = "Gömlek", Size = "M", Color = "Beyaz", Material = "Keten", Price = 290.00m, AdditionalInformation = "Nefes alır kumaş.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(12), IsActive = true, Image = "https://www.ilkkimbuldu.com/wp-content/uploads/2015/03/gomlek.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" }
//    );
//            builder.Entity<MusicalInstrument>().HasData(
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 1,
//        Name = "Yamaha Acoustic Guitar",
//        Brand = "Yamaha",
//        Description = "Great tone, excellent for beginners and professionals.",
//        Price = 1200.00m,
//        Image = "https://r.resimlink.com/f_NzYK.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(7),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 2,
//        Name = "Roland Digital Piano",
//        Brand = "Roland",
//        Description = "88 weighted keys, great for classical and modern styles.",
//        Price = 3500.00m,
//        Image = "https://r.resimlink.com/30ZcFE1CaKhd.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(10),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 3,
//        Name = "Fender Electric Guitar",
//        Brand = "Fender",
//        Description = "Classic Stratocaster style, great for rock and blues.",
//        Price = 4200.00m,
//        Image = "https://r.resimlink.com/t16JGe.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(5),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 4,
//        Name = "Pearl Drum Set",
//        Brand = "Pearl",
//        Description = "Full drum kit for studio and live performance.",
//        Price = 5800.00m,
//        Image = "https://r.resimlink.com/nM-Twj2uo.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(14),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 5,
//        Name = "Bose Sound System",
//        Brand = "Bose",
//        Description = "High quality, clear sound system for musicians.",
//        Price = 2500.00m,
//        Image = "https://r.resimlink.com/6KwcyBWiZ19.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(6),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 6,
//        Name = "Casio Keyboard",
//        Brand = "Casio",
//        Description = "Compact, versatile keyboard with built-in sounds.",
//        Price = 550.00m,
//        Image = "https://r.resimlink.com/R6rCZ1SI9EQ.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(8),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 7,
//        Name = "Ibanez Electric Guitar",
//        Brand = "Ibanez",
//        Description = "Famous for its thin neck and high-speed playability.",
//        Price = 1500.00m,
//        Image = "https://r.resimlink.com/x5-f3pc.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(12),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 8,
//        Name = "Korg Synthesizer",
//        Brand = "Korg",
//        Description = "Professional-grade synthesizer for music production.",
//        Price = 3000.00m,
//        Image = "https://r.resimlink.com/bihGxBw.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(9),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 9,
//        Name = "Ludwig Drum Kit",
//        Brand = "Ludwig",
//        Description = "Vintage drum set with excellent sound quality.",
//        Price = 4500.00m,
//        Image = "https://r.resimlink.com/k7LNxSrF9CEA.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(7),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 10,
//        Name = "Shure Microphone",
//        Brand = "Shure",
//        Description = "High quality vocal microphone, great for studio recordings.",
//        Price = 350.00m,
//        Image = "https://r.resimlink.com/PJrm27Svw.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(6),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 11,
//        Name = "Sennheiser Headphones",
//        Brand = "Sennheiser",
//        Description = "Studio quality headphones with excellent noise cancellation.",
//        Price = 250.00m,
//        Image = "https://r.resimlink.com/C8tPymW0XN.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(11),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 12,
//        Name = "Mackie Studio Monitors",
//        Brand = "Mackie",
//        Description = "Professional studio monitors for accurate sound mixing.",
//        Price = 1800.00m,
//        Image = "https://r.resimlink.com/-A1dUbm.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(13),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 13,
//        Name = "Tama Drum Set",
//        Brand = "Tama",
//        Description = "Full 5-piece drum kit for drummers of all levels.",
//        Price = 4000.00m,
//        Image = "https://r.resimlink.com/6lvyu.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(8),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 14,
//        Name = "Roland Drum Pads",
//        Brand = "Roland",
//        Description = "Electronic drum pads with great sensitivity and response.",
//        Price = 1200.00m,
//        Image = "https://r.resimlink.com/-oQeBiZ1lc.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(12),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 15,
//        Name = "Gretsch Electric Guitar",
//        Brand = "Gretsch",
//        Description = "Known for its smooth tone, great for jazz and blues.",
//        Price = 2200.00m,
//        Image = "https://r.resimlink.com/LXRdkC.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(9),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 16,
//        Name = "Vox Amplifier",
//        Brand = "Vox",
//        Description = "Classic British tone, perfect for rock guitarists.",
//        Price = 1500.00m,
//        Image = "https://r.resimlink.com/6iRCvrHE-7.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(15),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 17,
//        Name = "Martin Acoustic Guitar",
//        Brand = "Martin",
//        Description = "Legendary acoustic guitars known for their excellent sound.",
//        Price = 3000.00m,
//        Image = "https://r.resimlink.com/wn_rYdNmZ1.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(14),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 18,
//        Name = "Peavey Bass Guitar",
//        Brand = "Peavey",
//        Description = "Great bass guitar for beginners and intermediate players.",
//        Price = 800.00m,
//        Image = "https://r.resimlink.com/93XLlAhyr.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(10),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 19,
//        Name = "Line 6 Guitar Amp",
//        Brand = "Line 6",
//        Description = "Modern amp with tons of effects and high-quality sound.",
//        Price = 1300.00m,
//        Image = "https://r.resimlink.com/RgQaxI63jm.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(11),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 20,
//        Name = "Pearl Snare Drum",
//        Brand = "Pearl",
//        Description = "High-quality snare drum, great for any drum set.",
//        Price = 350.00m,
//        Image = "https://r.resimlink.com/BjpLO6kvUSq.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(12),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    }
//    );



//            builder.Entity<Vehicle>().HasData(
//                                        new Vehicle
//                                        {
//                                            VehicleId = 1,
//                                            BrandAndModel = "Toyota Camry",
//                                            ManufacturingYear = 2020,
//                                            Color = "Silver",
//                                            EngineCapacity = 2.5m,
//                                            Price = 25000.00m,
//                                            Millage = 15000,
//                                            PlateNumber = "34AA21",
//                                            AuctionPrice = 0.0,
//                                            AdditionalInformation = "Excellent condition, single owner",
//                                            StartTime = DateTime.Now,
//                                            EndTime = DateTime.Now.AddDays(48),
//                                            IsActive = true,
//                                            Image = "https://i.gaw.to/content/photos/39/21/392165_2020_Toyota_Camry.jpg",
//                                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                                        },
//                    new Vehicle
//                    {
//                        VehicleId = 2,

//                        BrandAndModel = "Honda Civic",
//                        ManufacturingYear = 2019,
//                        Color = "Blue",
//                        EngineCapacity = 1.8m,
//                        Price = 18000.00m,
//                        Millage = 20000,
//                        PlateNumber = "34AA21",
//                        AuctionPrice = 0.0,
//                        AdditionalInformation = "Good condition, one previous owner",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(24),
//                        IsActive = false,
//                        Image = "https://i.pinimg.com/originals/4f/b7/96/4fb796d99758f4889338c69efc74dbfe.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//                    },
//                    new Vehicle
//                    {
//                        VehicleId = 3,

//                        BrandAndModel = "Ford F-150",
//                        ManufacturingYear = 2018,
//                        Color = "Red",
//                        EngineCapacity = 5.0m,
//                        Price = 28000.00m,
//                        Millage = 25000,
//                        PlateNumber = "34AA21",
//                        AuctionPrice = 0.0,
//                        AdditionalInformation = "Low mileage, well-maintained",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(72),
//                        IsActive = true,
//                        Image = "https://www.autopartmax.com/images/cUpload/FORD%20Truck-F150%20Raptor.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                    },
//                    new Vehicle
//                    {
//                        VehicleId = 4,

//                        BrandAndModel = "Nissan Altima",
//                        ManufacturingYear = 2017,
//                        Color = "Black",
//                        EngineCapacity = 2.5m,
//                        Price = 16000.00m,
//                        Millage = 30000,
//                        PlateNumber = "34AA21",
//                        AuctionPrice = 0.0,
//                        AdditionalInformation = "Great condition, low mileage",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(48),
//                        IsActive = true,
//                        Image = "https://www.jonathanmotorcars.com/imagetag/631/3/l/Used-2017-Nissan-Altima-25-SV-Premium.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                    },
//                    new Vehicle
//                    {
//                        VehicleId = 5,

//                        BrandAndModel = "Chevrolet Malibu",
//                        ManufacturingYear = 2017,
//                        Color = "Silver",
//                        EngineCapacity = 2.4m,
//                        Price = 15500.00m,
//                        Millage = 28000,
//                        AuctionPrice = 0.0,
//                        PlateNumber = "34AA21",
//                        AdditionalInformation = "Well-maintained, single owner",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(72),
//                        IsActive = true,
//                        Image = "https://www.carscoops.com/wp-content/uploads/2023/01/2021-Chevrolet-Malibu.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                    },
//                    new Vehicle
//                    {
//                        VehicleId = 6,

//                        BrandAndModel = "Ferrari 488 GTB",
//                        ManufacturingYear = 2022,
//                        Color = "Red",
//                        EngineCapacity = 3.9m,
//                        Price = 300000.00m,
//                        PlateNumber = "34AA21",
//                        Millage = 1000,
//                        AuctionPrice = 0.0,
//                        AdditionalInformation = "Like new, low mileage",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(48),
//                        IsActive = true,
//                        Image = "https://i.pinimg.com/originals/93/2e/fb/932efb625cc97155497cfabd53a57d71.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                    },
//                        new Vehicle
//                        {
//                            VehicleId = 7,

//                            BrandAndModel = "Lamborghini Huracan",
//                            ManufacturingYear = 2021,
//                            Color = "Yellow",
//                            EngineCapacity = 5.2m,
//                            PlateNumber = "34AA21",
//                            Price = 280000.00m,
//                            Millage = 2000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Excellent condition, one owner",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://i.pinimg.com/originals/8c/bf/63/8cbf631f6c9cf107cde59ee72c4e79f6.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 8,
//                            BrandAndModel = "Porsche 911",
//                            ManufacturingYear = 2020,
//                            Color = "White",
//                            EngineCapacity = 3.0m,
//                            Price = 180000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 5000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Low mileage, well-maintained",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://avatars.mds.yandex.net/get-autoru-vos/6209275/1ee5dfabd4030a68195d9ac37ebf08b2/1200x900",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 9,
//                            BrandAndModel = "Aston Martin DB11",
//                            ManufacturingYear = 2019,
//                            Color = "Black",
//                            EngineCapacity = 5.2m,
//                            Price = 250000.00m,
//                            Millage = 6000,
//                            AuctionPrice = 0.0,
//                            PlateNumber = "34AA21",
//                            AdditionalInformation = "Excellent condition, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://images.hgmsites.net/hug/2018-aston-martin-db11_100630564_h.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 10,
//                            BrandAndModel = "McLaren 720S",
//                            ManufacturingYear = 2021,
//                            Color = "Orange",
//                            EngineCapacity = 4.0m,
//                            Price = 280000.00m,
//                            Millage = 4000,
//                            PlateNumber = "34AA21",
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Like new, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://www.mclarencf.com/imagetag/42/main/l/New-2020-McLaren-720S-Spider.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 11,
//                            BrandAndModel = "Bugatti Chiron",
//                            ManufacturingYear = 2018,
//                            Color = "Blue",
//                            EngineCapacity = 8.0m,
//                            Price = 350000.00m,
//                            Millage = 3000,
//                            PlateNumber = "34AA21",
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Rare, collector's item",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://coolwallpapers.me/picsup/5650604-bugatti-chiron-wallpapers.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 12,
//                            BrandAndModel = "Koenigsegg Jesko",
//                            ManufacturingYear = 2022,
//                            Color = "Silver",
//                            EngineCapacity = 5.0m,
//                            Price = 400000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 1500,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance masterpiece",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://wallpapercave.com/wp/wp5031567.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 13,
//                            BrandAndModel = "Ferrari SF90 Stradale",
//                            ManufacturingYear = 2021,
//                            Color = "Red",
//                            EngineCapacity = 4.0m,
//                            PlateNumber = "34AA21",
//                            Price = 275000.00m,
//                            Millage = 2000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Hybrid supercar, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://icdn.ensonhaber.com/crop/1200x675/resimler/diger/kok/2022/08/10/ferrari_1720.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 14,
//                            BrandAndModel = "Pagani Huayra",
//                            ManufacturingYear = 2020,
//                            Color = "Green",
//                            EngineCapacity = 6.0m,
//                            Price = 320000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 2500,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Exotic masterpiece, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://www.motorionline.com/wp-content/gallery/pagani-huayra-nc/Pagani-Huayra-NC-1.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 15,
//                            BrandAndModel = "Lexus LC 500",
//                            ManufacturingYear = 2019,
//                            Color = "Black",
//                            EngineCapacity = 5.0m,
//                            Price = 60000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 5000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Luxury sports coupe",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://wallpapercave.com/wp/wp6603188.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 16,
//                            BrandAndModel = "Tesla Model S",
//                            ManufacturingYear = 2022,
//                            Color = "Blue",
//                            EngineCapacity = 0.0m,  // Elektrikli araç, motor kapasitesi yok
//                            Price = 90000.00m,
//                            Millage = 1500,
//                            PlateNumber = "34AA21",
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance electric car",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://i.pinimg.com/originals/8f/b4/3b/8fb43b750028af047cbb0308c0e46014.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 17,
//                            BrandAndModel = "Audi R8",
//                            ManufacturingYear = 2021,
//                            Color = "Silver",
//                            EngineCapacity = 5.2m,
//                            Price = 120000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 3000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Luxury sports car, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://wallpapercave.com/wp/wp8343229.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 18,
//                            BrandAndModel = "Mercedes-AMG GT",
//                            ManufacturingYear = 2020,
//                            Color = "Black",
//                            EngineCapacity = 4.0m,
//                            Price = 110000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 4000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance luxury car",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://images.hdqwalls.com/download/mercedes-benz-sls-amg-yellow-5k-hv-3840x2400.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 19,
//                            BrandAndModel = "Nissan GT-R",
//                            ManufacturingYear = 2021,
//                            Color = "Blue",
//                            EngineCapacity = 3.8m,
//                            PlateNumber = "34AA21",
//                            Price = 95000.00m,
//                            Millage = 2500,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance Japanese sports car",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://i.pinimg.com/originals/e9/75/81/e97581a73660b583b1d982ef23607c24.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {

//                            VehicleId = 20,
//                            BrandAndModel = "Ford Mustang Shelby GT500",
//                            ManufacturingYear = 2022,
//                            Color = "Red",
//                            EngineCapacity = 5.2m,
//                            Price = 75000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 1500,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance American muscle car",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://www.mustangspecs.com/wp-content/uploads/2022/09/carpixel.net-2022-shelby-gt500-mustang-heritage-edition-106565-hd.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 21,
//                            BrandAndModel = "Porsche Cayman GT4",
//                            ManufacturingYear = 2021,
//                            Color = "Yellow",
//                            EngineCapacity = 4.0m,
//                            Price = 95000.00m,
//                            Millage = 3500,
//                            PlateNumber = "34AA21",
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Sports car with exceptional handling",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://www.topgear.com/sites/default/files/2022/03/1-Porsche-Cayman-GT4-RS.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//                        }
//        );

//        }
    }
}
