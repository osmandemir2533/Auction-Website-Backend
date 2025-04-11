using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Dtos
{
    public class UpdateElectronicDTO
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ManufacturingYear { get; set; }
        public decimal Price { get; set; }
        public double AuctionPrice { get; set; }
        public string AdditionalInformation { get; set; }
        public bool IsActive { get; set; }
        public string Image { get; set; }
        public IFormFile File { get; set; }
    }
}
