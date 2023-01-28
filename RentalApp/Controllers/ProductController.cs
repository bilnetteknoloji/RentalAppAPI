using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalApp.Core;
using RentalApp.Data;
using RentalApp.Service.Impl.Products;
using RentalApp.Service.Services.Products;


namespace RentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productsService;

        public ProductController(IProductService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("GetExample")]//bu şekilde yaparsnz queryden alır
        public IActionResult GetSample([FromQuery] int id) // Bu şekilde yaparsnz Body de get atmanz lazm ama ikisni aynı anda kullanmayn 
        {
            var result = _productsService.GetUrunlerById(id);

            return Ok(result);
        }

        [HttpGet("GetUrunKod")]
        public IActionResult Get(string UrunKod)
        {
            var urunler = _productsService.GetUrunlerByUrunKod(UrunKod);
            if (urunler == null)
            {
                return NotFound();
            }
            return Ok(urunler);
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
               