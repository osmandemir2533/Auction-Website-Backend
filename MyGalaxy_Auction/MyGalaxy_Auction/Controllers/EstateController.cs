using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MyGalaxy_Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateController : ControllerBase
    {
        private readonly IEstateService _estateService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EstateController(IEstateService estateService, IWebHostEnvironment webHostEnvironment)
        {
            _estateService = estateService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("CreateEstate")]
        public async Task<IActionResult> AddEstate([FromForm] CreateEstateDTO model)
        {
            if (ModelState.IsValid)
            {
                if (model.File == null || model.File.Length == 0)
                {
                    return BadRequest("Resim dosyası gereklidir.");
                }

                string uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "Images");
                Directory.CreateDirectory(uploadsFolder); // klasör yoksa oluştur

                string fileName = $"{Guid.NewGuid()}{Path.GetExtension(model.File.FileName)}";
                string filePath = Path.Combine(uploadsFolder, fileName);

                model.Image = fileName;
                var result = await _estateService.CreateEstate(model);

                if (result.isSuccess)
                {
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.File.CopyToAsync(fileStream);
                    }
                    return Ok(result);
                }
            }
            return BadRequest();
        }

        [HttpGet("GetEstates")]
        public async Task<IActionResult> GetAllEstates()
        {
            var result = await _estateService.GetEstates();
            return Ok(result);
        }

        [HttpPut("UpdateEstate")]
        public async Task<IActionResult> UpdateEstate([FromForm] UpdateEstateDTO model, int estateId)
        {
            if (ModelState.IsValid)
            {
                var result = await _estateService.UpdateEstateResponse(estateId, model);
                if (result.isSuccess)
                {
                    return Ok(result);
                }
            }
            return BadRequest();
        }

        [HttpDelete("Remove/Estate/{estateId}")]
        public async Task<IActionResult> DeleteEstate([FromRoute] int estateId)
        {
            var result = await _estateService.DeleteEstate(estateId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("{estateId}")]
        public async Task<IActionResult> GetEstateById([FromRoute] int estateId)
        {
            var result = await _estateService.GetEstateById(estateId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{estateId}")]
        public async Task<IActionResult> ChangeStatus([FromRoute] int estateId)
        {
            var result = await _estateService.ChangeEstateStatus(estateId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
