using MyGalaxy_Auction_Data_Access.Domain;
using MyGalaxy_Auction_Data_Access.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyGalaxy_Auction_Data_Access.Domain
{
    public class MusicalInstrument
    {
        [Key]
        public int MusicalInstrumentId { get; set; }

        public string? Name { get; set; }

        public string? Brand { get; set; }

        public string? Description { get; set; }
        public double AuctionPrice { get; set; }

        public decimal Price { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string? Image { get; set; }

        public bool IsActive { get; set; } 
        public string SellerId { get; set; }
        [JsonIgnore]
        [ForeignKey("SellerId")]
        public ApplicationUser Seller { get; set; }

        public virtual List<Bid> Bids { get; set; }

        public PaymentHistory? Payment { get; set; }
    }
}
