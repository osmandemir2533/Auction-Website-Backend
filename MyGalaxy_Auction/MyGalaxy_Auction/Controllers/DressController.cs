using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Domain;

namespace MyGalaxy_Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DressController : ControllerBase
    {
        private readonly IDressService _dressService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DressController(IDressService dressService, IWebHostEnvironment webHostEnvironment)
        {
            _dressService = dressService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("CreateDress")]
        public async Task<IActionResult> AddDress([FromForm] CreateDressDTO model)
        {
            if (ModelState.IsValid)
            {
                if (model.File == null || model.File.Length == 0)
                {
                    return BadRequest();
                }

                string uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "Images");
                string fileName = $"{Guid.NewGuid()}{Path.GetExtension(model.File.FileName)}";
                string filePath = Path.Combine(uploadsFolder, fileName);

                model.Image = fileName;
                var result = await _dressService.CreateDress(model);
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

        [HttpGet("GetDresses")]
        public async Task<IActionResult> GetAllDresses()
        {
            var dresses = await _dressService.GetDresses();
            return Ok(dresses);
        }

        [HttpPut("UpdateDress")]
        public async Task<IActionResult> UpdateDress([FromForm] UpdateDressDTO model, int dressId)
        {
            if (ModelState.IsValid)
            {
                var result = await _dressService.UpdateDressResponse(dressId, model);
                if (result.isSuccess)
                {
                    return Ok(result);
                }
            }
            return BadRequest();
        }

        [HttpDelete("Remove/Dress/{dressId}")]
        public async Task<IActionResult> DeleteDress([FromRoute] int dressId)
        {
            var result = await _dressService.DeleteDress(dressId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("{dressId}")]
        public async Task<IActionResult> GetDressById([FromRoute] int dressId)
        {
            var result = await _dressService.GetDressById(dressId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{dressId}")]
        public async Task<IActionResult> ChangeStatus([FromRoute] int dressId)
        {
            var result = await _dressService.ChangeDressStatus(dressId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
