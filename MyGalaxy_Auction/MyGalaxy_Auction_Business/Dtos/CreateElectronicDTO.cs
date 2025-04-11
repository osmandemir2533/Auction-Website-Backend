using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyGalaxy_Auction_Business.Dtos
{
    public class CreateElectronicDTO
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ManufacturingYear { get; set; }
        public decimal Price { get; set; }
        public double AuctionPrice { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; }
        public string Image { get; set; }
        public string SellerId { get; set; }
        public IFormFile File { get; set; }
    }
}