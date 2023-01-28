using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl.Products;

namespace RentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyOwnerController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public PropertyOwnerController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        #region UrunlerKontrat

        [HttpGet("GetUrunlerKontratById")]
        public IActionResult GetUrunlerKontratById ([FromQuery] int kontratid)
        {
            var result = _productsService.GetUrunlerKontratById (kontratid);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerKontrat")]
        public IActionResult GetAllUrunlerKontrats()
        {
            return Ok(_productsService.GetAllUrunlerKontrats());
        }

        [HttpPut("InsertUrunlerKontrat")]
        public IActionResult InsertUrunlerKontrat ([FromBody] UrunlerKontrat urunlerKontrat)
        {

            return Ok(_productsService.InsertUrunlerKontrat (urunlerKontrat));
        }

        [HttpPost("UpdateUrunlerKontrat")]
        public IActionResult UpdateUrunlerKontrat([FromBody] UrunlerKontrat urunlerKontrat)
        {
            return Ok(_productsService.UpdateUrunlerKontrat (urunlerKontrat));
        }

        [HttpDelete("DeleteUrunlerKontratById")]
        public IActionResult DeleteUrunlerKontratById (int kontratid)
        {
            var kontrat = _productsService.GetUrunlerKontratById(kontratid);
            if (kontrat == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerKontratById(kontrat);
            return NoContent();
        }

        #endregion

    }
}
