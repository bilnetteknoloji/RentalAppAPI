using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalApp.Core;
using RentalApp.Core.Dto;
using RentalApp.Data;
using RentalApp.Service.Impl;
using RentalApp.Service.Impl.Products;
using RentalApp.Service.Services.Products;


namespace RentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productsService;
        private readonly IHomeProductService _homeProductService;


        public ProductController(IProductService productsService,IHomeProductService homeProductService)
        {
            this._productsService = productsService;
            this._homeProductService = homeProductService;
        }

        [HttpGet("GetUrunKod")]
        public IActionResult Get(string UrunKod)
        {
            var products = _productsService.GetUrunlerByUrunKod(UrunKod);
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("GetAllUrunler")]
        public IActionResult GetAllUrunler()
        {
            return Ok(_productsService.GetAllUrunlers());
        }


        [HttpGet("GetAllUrunById")]
        public IActionResult Get(int urunid)
        {
            var urunler = _productsService.GetUrunlerById(urunid);
            if (urunler == null)
            {
                return NotFound();
            }

            return Ok(urunler);
        }


        [HttpPut("InsertLanguage")]
        public IActionResult InsertLanguage([FromBody] Urunler urunler)
        {

            return Ok(_productsService.InsertUrunler(urunler));
        }


        [HttpPost("UpdateUrunler")]
        public IActionResult UpdateUrunler([FromBody] Urunler urunler)
        {
            return Ok(_productsService.UpdateUrun(urunler));
        }

        [HttpDelete]
        public IActionResult Delete(int urunid)
        {
            var urun = _productsService.GetUrunlerById(urunid);
            if (urun == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerById(urun);
            return NoContent();
        }



    }
}
