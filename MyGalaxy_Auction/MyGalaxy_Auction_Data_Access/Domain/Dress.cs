using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyGalaxy_Auction_Data_Access.Domain
{
    public class Dress
    {
        [Key]
        public int DressId { get; set; }

        public string Brand { get; set; }              // Marka
        public string Type { get; set; }               // Örnek: Elbise, Ceket, Pantolon vb.
        public string Size { get; set; }               // Beden: S, M, L, XL
        public string Color { get; set; }              // Renk
        public string Material { get; set; }           // Kumaş türü: Pamuk, Polyester vb.
        public decimal Price { get; set; }             // Başlangıç fiyatı
        public string AdditionalInformation { get; set; }

        public double AuctionPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool IsActive { get; set; }

        public string Image { get; set; }              // Görsel dosya adı

        public string SellerId { get; set; }
        [JsonIgnore]
        [ForeignKey("SellerId")]
        public ApplicationUser Seller { get; set; }

    }
}
