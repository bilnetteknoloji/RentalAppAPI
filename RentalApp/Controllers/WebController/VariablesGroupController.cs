using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl;
using RentalApp.Service.Impl.Products;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariablesGroupController : ControllerBase
    {
        private readonly IProductsService _productsService;
        private readonly IVariablesGroupService _variablesGroupService;

        public VariablesGroupController(IVariablesGroupService variablesGroupService, IProductsService productsService)
        {
            _productsService = productsService;
            _variablesGroupService = variablesGroupService;
        }

        #region DeğişkenlerGrup
        [HttpGet("GetDegiskengruplarById")]
        public IActionResult GetDegiskengruplarById(int DegiskengrupId)
        {
            var result = _variablesGroupService.GetDegiskengruplarById(DegiskengrupId);
            return Ok(result);
        }

        [HttpGet("GetAllDegiskengruplar")]
        public IActionResult GetAllDegiskengruplar() 
        {
            return Ok(_variablesGroupService.GetAllDegiskengruplars()); 
        }

        [HttpPut("InsertDegiskengruplar")]
        public IActionResult InsertDegiskengruplar ([FromBody] Degiskengruplar degiskengruplar)
        {

            return Ok(_variablesGroupService.InsertDegiskengruplar(degiskengruplar));
        }

        [HttpPost("UpdateDegiskengruplar")]
        public IActionResult UpdateDegiskengruplar ([FromBody] Degiskengruplar degiskengruplar)
        {
            return Ok(_variablesGroupService.UpdateDegiskengruplar (degiskengruplar));
        }

        [HttpDelete("DeleteDegiskengruplar")]
        public IActionResult DeleteDegiskengruplar (int DegiskengrupId)
        {
            var degiskeng = _variablesGroupService.GetDegiskengruplarById(DegiskengrupId);
            if (degiskeng == null)
            {
                return NotFound();
            }

            _variablesGroupService.DeleteDegiskengruplar(degiskeng);
            return NoContent();
        }

        #endregion

        #region DeğişkenlerGrupDil

        [HttpGet("GetDegiskengruplarDilById")]
        public IActionResult GetDegiskengruplarDilById (int DegiskengrupDilId)
        {
            var result = _variablesGroupService.GetDegiskengruplarDilById(DegiskengrupDilId);
            return Ok(result);
        }

        [HttpGet("GetAllDegiskengruplarDil")]
        public IActionResult GetAllDegiskengruplarDil ()
        {
            return Ok(_variablesGroupService.GetAllDegiskengruplarDils());
        }

        [HttpPut("InsertDegiskengruplarDil")]
        public IActionResult InsertDegiskengruplarDil([FromBody] DegiskengruplarDil degiskengruplarDil)
        {

            return Ok(_variablesGroupService.InsertDegiskengruplarDil(degiskengruplarDil));
        }

        [HttpPost("UpdateDegiskengruplarDil")]
        public IActionResult UpdateDegiskengruplarDil([FromBody] DegiskengruplarDil degiskengruplarDil)
        {
            return Ok(_variablesGroupService.UpdateDegiskengruplarDil(degiskengruplarDil));
        }

        [HttpDelete("DeleteDegiskengruplarDil")]
        public IActionResult DeleteDegiskengruplarDil (int DegiskengrupDilId)
        {
            var degiskengDil = _variablesGroupService.GetDegiskengruplarDilById (DegiskengrupDilId);
            if (degiskengDil == null)
            {
                return NotFound();
            }

            _variablesGroupService.DeleteDegiskengruplarDil (degiskengDil);
            return NoContent();
        }

        #endregion

        #region DeğişkenlerDil

        [HttpGet("GetDegiskenlerDilById")]
        public IActionResult GetDegiskenlerDilById(int DegiskenlerDilId)
        {
            var result = _variablesGroupService.GetDegiskenlerDilById(DegiskenlerDilId);
            return Ok(result);
        }

        [HttpGet("GetAllDegiskenlerDil")]
        public IActionResult GetAllDegiskenlerDil()
        {
            return Ok(_variablesGroupService.GetAllDegiskenlerDils());
        }

        [HttpPut("InsertDegiskenlerDil")]
        public IActionResult InsertDegiskenlerDil([FromBody] DegiskenlerDil degiskenlerDil)
        {

            return Ok(_variablesGroupService.InsertDegiskenlerDil(degiskenlerDil));
        }

        [HttpPost("UpdateDegiskenlerDil")]
        public IActionResult UpdateDegiskenlerDil([FromBody] DegiskenlerDil degiskenlerDil)
        {
            return Ok(_variablesGroupService.UpdateDegiskenlerDil(degiskenlerDil));
        }

        [HttpDelete("DeleteDegiskenlerDil")]
        public IActionResult DeleteDegiskenlerDil(int DegiskenlerDilId)
        {
            var degiskenDil = _variablesGroupService.GetDegiskenlerDilById(DegiskenlerDilId);
            if (degiskenDil == null)
            {
                return NotFound();
            }

            _variablesGroupService.DeleteDegiskenlerDil(degiskenDil);
            return NoContent();
        }

        #endregion

        #region Değişkenler

        [HttpGet("GetDegiskenlerById")]
        public IActionResult GetDegiskenlerById(int DegiskenlerId)
        {
            var result = _variablesGroupService.GetDegiskenlerById(DegiskenlerId);
            return Ok(result);
        }

        [HttpGet("GetAllDegiskenler")]
        public IActionResult GetAllDegiskenler()
        {
            return Ok(_variablesGroupService.GetAllDegiskenlers());
        }

        [HttpPut("InsertDegiskenler")]
        public IActionResult InsertDegiskenler([FromBody] Degiskenler degiskenler)
        {

            return Ok(_variablesGroupService.InsertDegiskenler(degiskenler));
        }

        [HttpPost("UpdateDegiskenler")]
        public IActionResult UpdateDegiskenler([FromBody] Degiskenler degiskenler)
        {
            return Ok(_variablesGroupService.UpdateDegiskenler(degiskenler));
        }

        [HttpDelete("DeleteDegiskenler")]
        public IActionResult DeleteDegiskenler (int DegiskenlerId)
        {
            var degisken = _variablesGroupService.GetDegiskenlerById(DegiskenlerId);
            if (degisken == null)
            {
                return NotFound();
            }

            _variablesGroupService.DeleteDegiskenler(degisken);
            return NoContent();
        }

        #endregion

        #region Urunler Değişkenler

        [HttpGet("GetUrunlerDegiskenlerById")]
        public IActionResult GetUrunlerDegiskenlerById (int urundegiskenid)
        {
            var result = _productsService.GetUrunlerDegiskenlerById (urundegiskenid);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerDegiskenler")]
        public IActionResult GetAllUrunlerDegiskenler()
        {
            return Ok(_productsService.GetAllUrunlerDegiskenlers());
        }

        [HttpPut("InsertUrunlerDegiskenler")]
        public IActionResult InsertUrunlerDegiskenler ([FromBody] UrunlerDegiskenler urunlerDegiskenler)
        {

            return Ok(_productsService.InsertUrunlerDegiskenler(urunlerDegiskenler));
        }

        [HttpPost("UpdateUrunlerDegiskenler(")]
        public IActionResult UpdateUrunlerDegiskenler ([FromBody] UrunlerDegiskenler urunlerDegiskenler )
        {
            return Ok(_productsService.UpdateUrunlerDegiskenler (urunlerDegiskenler));
        }

        [HttpDelete("DeleteUrunlerDegiskenler")]
        public IActionResult DeleteUrunlerDegiskenler (int urundegiskenlerid)
        {
            var udegisken = _productsService.GetUrunlerDegiskenlerById (urundegiskenlerid);
            if (udegisken == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerDegiskenler(udegisken);
            return NoContent();
        }

        #endregion


    }
}
