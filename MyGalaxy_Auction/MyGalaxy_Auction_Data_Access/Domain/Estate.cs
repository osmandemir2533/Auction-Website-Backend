using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyGalaxy_Auction_Data_Access.Domain
{
    public class Estate
    {
        [Key]
        public int EstateId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string Address { get; set; }
        public int RoomCount { get; set; }
        public int SquareMeters { get; set; }
        public decimal Price { get; set; }

        public double AuctionPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; }

        public string Image { get; set; }

        public string SellerId { get; set; }
        [JsonIgnore]
        [ForeignKey("SellerId")]
        public ApplicationUser Seller { get; set; }

        public virtual List<Bid> Bids { get; set; }

        public PaymentHistory? Payment { get; set; }
    }
}
