using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguagesService _languagesService;       

        public LanguagesController(ILanguagesService languagesService)
        {
            _languagesService = languagesService;
        }

        #region Diller

        [HttpGet("GetDillerById")]
        public IActionResult GetDillerById([FromQuery] int DilId)
        {
            var result = _languagesService.GetDillerById(DilId);
            return Ok(result);
        }

        [HttpGet("GetAllDiller")]
        public IActionResult GetAllDiller()
        {
            return Ok(_languagesService.GetAllDillers());
        }

        [HttpPut("InsertDiller")]
        public IActionResult InsertDiller([FromBody] Diller diller)
        {

            return Ok(_languagesService.InsertDiller(diller));
        }

        [HttpPost("UpdateDiller")]
        public IActionResult UpdateDiller([FromBody] Diller diller)
        {
            return Ok(_languagesService.UpdateDiller(diller));
        }

        [HttpDelete("DeleteDiller")]
        public IActionResult DeleteDiller(int DilId)
        {
            var Dil = _languagesService.GetDillerById(DilId);
            if (Dil == null)
            {
                return NotFound();
            }

            _languagesService.DeleteDillerById(Dil);
            return NoContent();
        }
        #endregion

        #region UrunlerDiller
        [HttpGet("GetUrunlerDillerById")]
        public IActionResult GetUrunlerDillerById([FromQuery] int urundilid)
        {
            var result = _languagesService.GetUrunlerDilById(urundilid);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerDiller")]
        public IActionResult GetAllUrunlerDiller()
        {
            return Ok(_languagesService.GetAllUrunlerDils());
        }

        [HttpPut("InsertUrunlerDiller")]
        public IActionResult InsertUrunlerDil([FromBody] UrunlerDil urunlerDil)
        {

            return Ok(_languagesService.InsertUrunlerDil(urunlerDil));
        }

        [HttpPost("UpdateUrunlerDiller")]
        public IActionResult UpdateUrunlerDil([FromBody] UrunlerDil urunlerDil)
        {
            return Ok(_languagesService.UpdateUrunlerDil(urunlerDil));
        }

        [HttpDelete("DeleteUrunlerDiller")]
        public IActionResult DeleteUrunlerDil(int urundilid)
        {
            var urunDil = _languagesService.GetUrunlerDilById(urundilid);
            if (urunDil == null)
            {
                return NotFound();
            }

            _languagesService.DeleteUrunlerDil(urunDil);
            return NoContent();
        }
        #endregion

    }
}
