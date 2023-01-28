using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl;
using RentalApp.Service.Impl.Products;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly IProductsService _productsService;
        private readonly ICampaignsService _campaignsService;
        private readonly ICurrenciesService _currenciesService;


        public PriceController(IProductsService productsService, ICampaignsService campaignsService, ICurrenciesService currenciesService)
        {
            _productsService = productsService;
            _campaignsService = campaignsService;
            _currenciesService = currenciesService;
        }

        #region UrunlerFiyat
        [HttpGet("GetUrunlerfiyatById")]
        public IActionResult GetUrunlerfiyatById([FromQuery] int FiyatId)
        {
            var result = _productsService.GetAllUrunlerFiyat(FiyatId);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerFiyat")]
        public IActionResult GetAllUrunlerFiyat()
        {
            return Ok(_productsService.GetAllUrunlerFiyats());
        }

        [HttpPut("InsertUrunlerFiyat")]
        public IActionResult InsertUrunlerFiyat([FromBody] UrunlerFiyat urunlerFiyat)
        {

            return Ok(_productsService.InsertUrunlerFiyat(urunlerFiyat));
        }

        [HttpPost("UpdateUrunlerFiyat")]
        public IActionResult UpdateUrunlerFiyat([FromBody] UrunlerFiyat urunlerFiyat)
        {
            return Ok(_productsService.UpdateUrunlerFiyat(urunlerFiyat));
        }

        [HttpDelete("DeleteUrunlerFiyat")]
        public IActionResult DeleteUrunlerFiyat(int FiyatId)
        {
            var fiyat = _productsService.GetUrunlerFiyatById(FiyatId);
            if (fiyat == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerFiyat(fiyat);
            return NoContent();
        }
        #endregion

        #region UrunlerEkFiyat
        [HttpGet("GetUrunlerEkFiyatById")]
        public IActionResult GetUrunlerEkFiyatById([FromQuery] int UrunEkfiyatId)
        {
            var result = _productsService.GetAllUrunlerFiyat(UrunEkfiyatId);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerEkFiyat")]
        public IActionResult GetAllUrunlerEkFiyat()
        {
            return Ok(_productsService.GetAllUrunlerEkFiyats());
        }

        [HttpPut("InsertUrunlerEkFiyat")]
        public IActionResult InsertUrunlerEkFiyat([FromBody] UrunlerEkfiyat urunlerEkfiyat)
        {

            return Ok(_productsService.InsertUrunlerEkfiyat(urunlerEkfiyat));
        }

        [HttpPost("UpdateUrunlerEkFiyat")]
        public IActionResult UpdateUrunlerEkFiyat([FromBody] UrunlerEkfiyat urunlerEkfiyat)
        {
            return Ok(_productsService.UpdateUrunlerEkfiyat(urunlerEkfiyat));
        }

        [HttpDelete("DeleteUrunlerEkFiyat")]
        public IActionResult DeleteUrunlerEkFiyat(int UrunEkfiyatId)
        {
            var fiyatek = _productsService.GetUrunlerEkfiyatById(UrunEkfiyatId);
            if (fiyatek == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerEkfiyat(fiyatek);
            return NoContent();
        }
        #endregion

        #region ParaBirimler
        [HttpGet("GetParaBirimlerById")]
        public IActionResult GetParaBirimlerById([FromQuery] int BirimId)
        {
            var result = _currenciesService.GetParaBirimlerById(BirimId);
            return Ok(result);
        }

        [HttpGet("GetAllParaBirimlers")]
        public IActionResult GetAllParaBirimler()
        {
            return Ok(_currenciesService.GetAllParaBirimlers());
        }

        [HttpPut("InsertParaBirimler")]
        public IActionResult InsertParaBirimler([FromBody] ParaBirimler paraBirimler)
        {
            return Ok(_currenciesService.InsertParaBirimler(paraBirimler));
        }

        [HttpPost("UpdateParaBirimler")]
        public IActionResult UpdateParaBirimler([FromBody] ParaBirimler paraBirimler)
        {
            return Ok(_currenciesService.UpdateParaBirimler(paraBirimler));
        }

        [HttpDelete("DeleteParaBirimler")]
        public IActionResult DeleteParaBirimler(int BirimId)
        {
            var parabirim = _currenciesService.GetParaBirimlerById(BirimId);
            if (parabirim == null)
            {
                return NotFound();
            }

            _currenciesService.DeleteParaBirimler(parabirim);
            return NoContent();
        }
        #endregion

    }
}
