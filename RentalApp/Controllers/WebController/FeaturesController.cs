using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl;
using RentalApp.Service.Impl.Products;
using RentalApp.Service.Services;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IProductsService _productsService;
        private readonly IFeatureGroupsService _featureGroupsService;

        public FeaturesController(IProductsService productsService, IFeatureGroupsService featureGroupsService)
        {
            _productsService = productsService;
            _featureGroupsService = featureGroupsService;
        }

        #region UrunlerOzellikler
        [HttpGet("GetUrunlerOzelliklerById")]
        public IActionResult GetUrunlerOzelliklerById ([FromQuery] int UrunOzellikId)
        {
            var result = _productsService.GetUrunlerOzelliklerById (UrunOzellikId);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerOzellikler")]
        public IActionResult GetAllUrunlerOzellikler()
        {
            return Ok(_productsService.GetAllUrunlerOzelliklers());
        }

        [HttpPut("InsertUrunlerOzellikler")]
        public IActionResult InsertUrunlerOzellikler ([FromBody] UrunlerOzellikler urunlerOzellikler)
        {

            return Ok(_productsService.InsertUrunOzellikler (urunlerOzellikler));
        }

        [HttpPost("UpdateUrunOzellikler")]
        public IActionResult UpdateUrunOzellikler ([FromBody] UrunlerOzellikler urunlerOzellikler)
        {
            return Ok(_productsService.UpdateUrunOzellikler (urunlerOzellikler));
        }

        [HttpDelete("DeleteUrunlerOzellikler")]
        public IActionResult DeleteUrunlerOzellikler(int UrunOzellikId)
        {
            var ozellikler = _productsService.GetUrunlerOzelliklerById(UrunOzellikId);
            if (ozellikler == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerOzelliklerById(ozellikler);
            return NoContent();
        }
        #endregion

        #region ÖzellikGruplar

        [HttpGet("GetOzellikgruplarById")]
        public IActionResult GetOzellikgruplarById ([FromQuery] int OzellikgrupId)
        {
            var result = _featureGroupsService.GetOzellikgruplarById(OzellikgrupId);
            return Ok(result);
        }

        [HttpGet("GetAllOzellikgruplar")]
        public IActionResult GetAllOzellikgruplar()
        {
            return Ok(_featureGroupsService.GetAllOzellikgruplars());
        }

        [HttpPut("InsertOzellikgruplar")]
        public IActionResult InsertOzellikgruplar ([FromBody] Ozellikgruplar ozellikgruplar)
        {

            return Ok(_featureGroupsService.InsertOzellikgruplar(ozellikgruplar));
        }

        [HttpPost("UpdateOzellikgruplar")]
        public IActionResult UpdateOzellikgruplar ([FromBody] Ozellikgruplar ozellikgruplar)
        {
            return Ok(_featureGroupsService.UpdateOzellikgruplar(ozellikgruplar));
        }

        [HttpDelete("DeleteOzellikgruplarById")]
        public IActionResult DeleteOzellikgruplarById (int OzellikgrupId)
        {
            var ozelliklerg = _featureGroupsService.GetOzellikgruplarById(OzellikgrupId);
            if (ozelliklerg == null)
            {
                return NotFound();
            }

            _featureGroupsService.DeleteOzellikgruplarById(ozelliklerg);
            return NoContent();
        }
        #endregion

        #region ÖzellikGrupDiller

        [HttpGet("GetOzellikgrupDilById")]
        public IActionResult GetOzellikgrupDilById([FromQuery] int OzellikgrupDilId)
        {
            var result = _featureGroupsService.GetOzellikgruplarDilById (OzellikgrupDilId);
            return Ok(result);
        }

        [HttpGet("GetAllOzellikgruplarDil")]
        public IActionResult GetAllOzellikgruplarDil()
        {
            return Ok(_featureGroupsService.GetAllOzellikgruplarDils());
        }

        [HttpPut("InsertOzellikgruplarDil")]
        public IActionResult InsertOzellikgruplarDil ([FromBody] OzellikgruplarDil ozellikgruplarDil)
        {

            return Ok(_featureGroupsService.InsertOzellikgruplarDil(ozellikgruplarDil));
        }

        [HttpPost("UpdateOzellikgruplarDil")]
        public IActionResult UpdateOzellikgruplarDil ([FromBody] OzellikgruplarDil ozellikgruplarDil)
        {
            return Ok(_featureGroupsService.UpdateOzellikgruplarDil (ozellikgruplarDil));
        }

        [HttpDelete("DeleteOzellikgruplarDil")]
        public IActionResult DeleteOzellikgruplarDilById (int OzellikgrupDilId)
        {
            var ozelliklerd = _featureGroupsService.GetOzellikgruplarDilById (OzellikgrupDilId);
            if (ozelliklerd == null)
            {
                return NotFound();
            }

            _featureGroupsService.DeleteOzellikgruplarDilById (ozelliklerd);
            return NoContent();
        }
        #endregion

        #region ÖzellikDiller

        [HttpGet("GetOzelliklerDilById")]
        public IActionResult GetOzelliklerDilById([FromQuery] int OzellikDilId)
        {
            var result = _featureGroupsService.GetOzelliklerDilById (OzellikDilId);
            return Ok(result);
        }

        [HttpGet("GetAllOzelliklerDil")]
        public IActionResult GetAllOzelliklerDil()
        {
            return Ok(_featureGroupsService.GetAllOzelliklerDils());
        }

        [HttpPut("InsertOzelliklerDil")]
        public IActionResult InsertOzelliklerDil([FromBody] OzelliklerDil ozelliklerDil)
        {

            return Ok(_featureGroupsService.InsertOzelliklerDil(ozelliklerDil));
        }

        [HttpPost("UpdateOzelliklerDil")]
        public IActionResult UpdateOzelliklerDil([FromBody] OzelliklerDil ozelliklerDil)
        {
            return Ok(_featureGroupsService.UpdateOzelliklerDil(ozelliklerDil));
        }

        [HttpDelete("DeleteOzelliklerDil")]
        public IActionResult DeleteOzelliklerDilById(int OzelliklerDilId)
        {
            var ozel = _featureGroupsService.GetOzelliklerDilById(OzelliklerDilId);
            if (ozel == null)
            {
                return NotFound();
            }

            _featureGroupsService.DeleteOzelliklerDilById (ozel);
            return NoContent();
        }
        #endregion

        #region Özellikler

        [HttpGet("GetOzelliklerById")]
        public IActionResult GetOzelliklerById([FromQuery] int OzellikId)
        {
            var result = _featureGroupsService.GetOzelliklerById(OzellikId);
            return Ok(result);
        }

        [HttpGet("GetAllOzellikler")]
        public IActionResult GetAllOzellikler()
        {
            return Ok(_featureGroupsService.GetAllOzelliklers());
        }

        [HttpPut("InsertOzellikler")]
        public IActionResult InsertOzellikler([FromBody] Ozellikler ozellikler)
        {

            return Ok(_featureGroupsService.InsertOzellikler (ozellikler));
        }

        [HttpPost("UpdateOzellikler")]
        public IActionResult UpdateOzellikler ([FromBody] Ozellikler ozellikler)
        {
            return Ok(_featureGroupsService.UpdateOzellikler (ozellikler));
        }

        [HttpDelete("DeleteOzellikler")]
        public IActionResult DeleteOzelliklerById(int OzelliklerId)
        {
            var ozelik = _featureGroupsService.GetOzelliklerById(OzelliklerId);
            if (ozelik == null)
            {
                return NotFound();
            }

            _featureGroupsService.DeleteOzelliklerById(ozelik);
            return NoContent();
        }
        #endregion

    }
}
