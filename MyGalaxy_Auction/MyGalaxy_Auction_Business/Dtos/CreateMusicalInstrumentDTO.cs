using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MyGalaxy_Auction_Business.Dtos
{
    public class CreateMusicalInstrumentDTO
    {
        public string Name { get; set; }

        public string? Brand { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }
        public double AuctionPrice { get; set; }
        public string Image { get; set; }
        public bool? IsActive { get; set; }
        public DateTime StartTime { get; set; } = DateTime.UtcNow;
        public DateTime EndTime { get; set; }
        public IFormFile File { get; set; }

        public int SellerId { get; set; }  // Kullanıcı eklerken sellerId girilecek
    }
}
