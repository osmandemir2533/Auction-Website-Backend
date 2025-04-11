using Microsoft.AspNetCore.Http;
using System;

namespace MyGalaxy_Auction_Business.Dtos
{
    public class UpdateEstateDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int RoomCount { get; set; }
        public int SquareMeters { get; set; }
        public decimal Price { get; set; }
        public double AuctionPrice { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; } = true;
        public IFormFile File { get; set; } // Fotoğraf dosyası
        public DateTime StartTime { get; set; } = DateTime.UtcNow;
        public DateTime EndTime { get; set; }
    }
}
