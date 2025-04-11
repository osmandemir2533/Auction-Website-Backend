using Microsoft.AspNetCore.Mvc;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace MyGalaxy_Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicalInstrumentController : ControllerBase
    {
        private readonly IMusicalInstrumentService _musicalInstrumentService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MusicalInstrumentController(IMusicalInstrumentService musicalInstrumentService, IWebHostEnvironment webHostEnvironment)
        {
            _musicalInstrumentService = musicalInstrumentService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("CreateInstrument")]
        public async Task<IActionResult> AddInstrument([FromForm] CreateMusicalInstrumentDTO model)
        {
            if (ModelState.IsValid)
            {
                if (model.File == null || model.File.Length == 0)
                {
                    return BadRequest("Dosya yüklenmedi.");
                }

                string uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "Images");
                string fileName = $"{Guid.NewGuid()}{Path.GetExtension(model.File.FileName)}";
                string filePath = Path.Combine(uploadsFolder, fileName);

                model.Image = fileName;
                var result = await _musicalInstrumentService.CreateInstrument(model);

                if (result.isSuccess)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.File.CopyToAsync(stream);
                    }
                    return Ok(result);
                }
            }

            return BadRequest("Hatalı veri girdiniz.");
        }

        [HttpGet("GetInstruments")]
        public async Task<IActionResult> GetAllInstruments()
        {
            var instruments = await _musicalInstrumentService.GetInstruments();
            return Ok(instruments);
        }

        [HttpPut("UpdateInstrument")]
        public async Task<IActionResult> UpdateInstrument([FromForm] UpdateMusicalInstrumentDTO model, int instrumentId)
        {
            if (ModelState.IsValid)
            {
                var result = await _musicalInstrumentService.UpdateInstrumentResponse(instrumentId, model);
                if (result.isSuccess)
                {
                    return Ok(result);
                }
            }
            return BadRequest("Güncelleme başarısız.");
        }

        [HttpDelete("Remove/Instrument/{instrumentId}")]
        public async Task<IActionResult> DeleteInstrument([FromRoute] int instrumentId)
        {
            var result = await _musicalInstrumentService.DeleteInstrument(instrumentId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest("Silme işlemi başarısız.");
        }

        [HttpGet("{instrumentId}")]
        public async Task<IActionResult> GetInstrumentById([FromRoute] int instrumentId)
        {
            var result = await _musicalInstrumentService.GetInstrumentById(instrumentId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest("Enstrüman bulunamadı.");
        }

        [HttpPut("{instrumentId}")]
        public async Task<IActionResult> ChangeStatus([FromRoute] int instrumentId)
        {
            var result = await _musicalInstrumentService.ChangeInstrumentStatus(instrumentId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest("Durum değiştirme işlemi başarısız.");
        }
    }
}
