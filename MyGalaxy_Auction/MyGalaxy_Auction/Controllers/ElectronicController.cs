using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MyGalaxy_Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectronicController : ControllerBase
    {
        private readonly IElectronicService _electronicService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ElectronicController(IElectronicService electronicService, IWebHostEnvironment webHostEnvironment)
        {
            _electronicService = electronicService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("CreateElectronic")]
        public async Task<IActionResult> AddElectronic([FromForm] CreateElectronicDTO model)
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
                var result = await _electronicService.CreateElectronic(model);

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

        [HttpGet("GetElectronics")]
        public async Task<IActionResult> GetAllElectronics()
        {
            var electronics = await _electronicService.GetElectronics();
            return Ok(electronics);
        }

        [HttpPut("UpdateElectronic")]
        public async Task<IActionResult> UpdateElectronic(int electronicId, [FromForm] UpdateElectronicDTO model)
        {
            if (ModelState.IsValid)
            {
                var result = await _electronicService.UpdateElectronicResponse(electronicId, model);
                if (result.isSuccess)
                {
                    return Ok(result);
                }
            }
            return BadRequest();
        }

        [HttpDelete("Remove/Electronic/{electronicId}")]
        public async Task<IActionResult> DeleteElectronic([FromRoute] int electronicId)
        {
            var result = await _electronicService.DeleteElectronic(electronicId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("{electronicId}")]
        public async Task<IActionResult> GetElectronicById([FromRoute] int electronicId)
        {
            var result = await _electronicService.GetElectronicById(electronicId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{electronicId}")]
        public async Task<IActionResult> ChangeStatus([FromRoute] int electronicId)
        {
            var result = await _electronicService.ChangeElectronicStatus(electronicId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}