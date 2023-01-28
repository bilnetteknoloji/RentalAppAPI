using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl;
using RentalApp.Service.Impl.Products;

namespace RentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly IProductsService _productsService;
        private readonly IRentalPicturesService _rentalPicturesService;
        public PicturesController(IProductsService productsService, IRentalPicturesService rentalPicturesService)
        {
            _productsService = productsService;
            _rentalPicturesService = rentalPicturesService;
        }

        #region KiralamaResimler

        [HttpGet("GetKiralamaResimlerById")]
        public IActionResult GetKiralamaResimlerById([FromQuery] int TalepresimId)
        {
            var result = _rentalPicturesService.GetKiralamaResimlerById(TalepresimId);
            return Ok(result);
        }

        [HttpGet("GetAllKiralamaResim")]
        public IActionResult GetAllKiralamaResims()
        {
            return Ok(_rentalPicturesService.GetAllKiralamaResims());
        }

        [HttpPut("InsertKiralamaResimler")]
        public IActionResult InsertKiralamaResimler ([FromBody] KiralamaResimler kiralamaResimler)
        {

            return Ok(_rentalPicturesService.InsertKiralamaResimler (kiralamaResimler));
        }

        [HttpPost("UpdateKiralamaResimler")]
        public IActionResult UpdateKiralamaResimler ([FromBody] KiralamaResimler kiralamaResimler)
        {
            return Ok(_rentalPicturesService.UpdateKiralamaResimler (kiralamaResimler));
        }

        [HttpDelete("DeleteKiralamaResimler")]
        public IActionResult DeleteKiralamaResimlerById (int TalepresimId)
        {
            var kiralama = _rentalPicturesService.GetKiralamaResimlerById(TalepresimId);
            if (kiralama == null)
            {
                return NotFound();
            }

            _rentalPicturesService.DeleteKiralamaResimlerById (kiralama);
            return NoContent();
        }

        #endregion

        #region UrunlerResimler

        [HttpGet("GetUrunlerResimById")]
        public IActionResult GetUrunlerResimById([FromQuery] int resimid)
        {
            var result = _productsService.GetUrunlerResimById (resimid);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerResims")]
        public IActionResult GetAllUrunlerResims()
        {
            return Ok(_productsService.GetAllUrunlerResims());
        }

        [HttpPut("InsertUrunlerResim")]
        public IActionResult InsertUrunlerResim ([FromBody] UrunlerResim urunlerResim)
        {
            return Ok(_productsService.InsertUrunlerResim (urunlerResim));
        }

        [HttpPost("UpdateUrunResim")]
        public IActionResult UpdateUrunResim ([FromBody] UrunlerResim urunlerResim)
        {
            return Ok(_productsService.UpdateUrunResim (urunlerResim));
        }

        [HttpDelete("DeleteUrunlerResim")]
        public IActionResult DeleteUrunlerResimById (int resimid)
        {
            var resim = _productsService.GetUrunlerResimById(resimid);
            if (resim == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerResimById (resim);
            return NoContent();
        }

        #endregion
    }
}
