using Microsoft.AspNetCore.Http;

namespace MyGalaxy_Auction_Business.Dtos
{
    public class UpdateMusicalInstrumentDTO
    {
        public string? Name { get; set; }

        public string? Brand { get; set; }

        public string? Description { get; set; }
        public string Image { get; set; }
        public DateTime StartTime { get; set; } = DateTime.UtcNow;
        public DateTime EndTime { get; set; }
        public decimal? Price { get; set; }

        public double AuctionPrice { get; set; }
        public bool IsActive { get; set; } = true;
        public IFormFile? File { get; set; }
    }
}
