using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl;
using RentalApp.Service.Impl.Products;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IProductsService _productsService;
        private readonly ICategoriesService _categoriesService;


        public CategoriesController(IProductsService productsService, ICategoriesService categoriesService)
        {
            _productsService = productsService;
            _categoriesService = categoriesService;
        }

        #region UrunlerKategoriler

        [HttpGet("GetUrunlerKategorilerById")]
        public IActionResult GetUrunlerKategorilerById ([FromQuery] int urunlerkategoriid)
        {
            var result = _productsService.GetUrunlerKategorilerById (urunlerkategoriid);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerKategoriler")]
        public IActionResult GetAllUrunlerKategoriler()
        {
            return Ok(_productsService.GetAllUrunlerKategorilers());
        }

        [HttpPut("InsertUrunlerKategoriler")]
        public IActionResult InsertUrunlerKategoriler ([FromBody] UrunlerKategoriler urunlerKategoriler)
        {

            return Ok(_productsService.InsertUrunlerKategoriler (urunlerKategoriler));
        }

        [HttpPost("UpdateUrunlerKategoriler")]
        public IActionResult UpdateUrunlerKategoriler([FromBody] UrunlerKategoriler urunlerKategoriler)
        {
            return Ok(_productsService.UpdateUrunlerKategoriler(urunlerKategoriler));
        }

        [HttpDelete("DeleteUrunlerKategoriler")]
        public IActionResult DeleteUrunlerKategorilerById(int urunkategoriid)
        {
            var ukat = _productsService.GetUrunlerKategorilerById (urunkategoriid);
            if (ukat == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerKategorilerById(ukat);
            return NoContent();
        }

        #endregion

        #region Kategoriler

        [HttpGet("GetKategorilerById")]
        public IActionResult GetKategorilerById([FromQuery] int KategoriId)
        {
            var result = _categoriesService.GetKategorilerById(KategoriId);
            return Ok(result);
        }

        [HttpGet("GetAllKategoriler")]
        public IActionResult GetAllKategoriler()
        {
            return Ok(_categoriesService.GetAllKategorilers());
        }

        [HttpPut("InsertKategoriler")]
        public IActionResult InsertKategoriler([FromBody] Kategoriler kategoriler)
        {

            return Ok(_categoriesService.InsertKategoriler(kategoriler));
        }

        [HttpPost("UpdateKategoriler")]
        public IActionResult UpdateKategoriler([FromBody] Kategoriler kategoriler)
        {
            return Ok(_categoriesService.UpdateKategoriler (kategoriler));
        }

        [HttpDelete("DeleteKategoriler")]
        public IActionResult DeleteKategorilerById(int KategoriId)
        {
            var ukate = _categoriesService.GetKategorilerById(KategoriId);
            if (ukate == null)
            {
                return NotFound();
            }

            _categoriesService.DeleteKategorilerById(ukate);
            return NoContent();
        }

        #endregion
    }
}
