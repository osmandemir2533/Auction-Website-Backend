using Microsoft.AspNetCore.Http;
using System;

namespace MyGalaxy_Auction_Business.Dtos
{
    public class UpdateDressDTO
    {
        public string Brand { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string Material { get; set; }

        public decimal? Price { get; set; }

        public string AdditionalInformation { get; set; }

        public double? AuctionPrice { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public bool? IsActive { get; set; }

        public IFormFile? File { get; set; }

        public string? Image { get; set; } // Opsiyonel olarak güncellenebilir
    }
}
