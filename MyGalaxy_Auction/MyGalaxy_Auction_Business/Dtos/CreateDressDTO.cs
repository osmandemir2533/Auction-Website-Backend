using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyGalaxy_Auction_Business.Dtos
{
    public class CreateDressDTO
    {
        public string Brand { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string Material { get; set; }

        public decimal Price { get; set; }

        public string AdditionalInformation { get; set; }

        public double AuctionPrice { get; set; }

        public DateTime StartTime { get; set; } = DateTime.UtcNow;
        public DateTime EndTime { get; set; }

        public bool IsActive { get; set; } = true;

        public IFormFile File { get; set; } // Fotoğraf dosyası

        public string SellerId { get; set; }

        public string Image { get; set; } // Bu değer controller içinde atanacak
    }
}
