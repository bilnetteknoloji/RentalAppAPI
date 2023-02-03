using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignsController : ControllerBase
    {
        private readonly ICampaignsService _campaignsService;

        public CampaignsController(ICampaignsService campaignsService)
        {
            _campaignsService = campaignsService;
        }

        #region UrunlerKampanyalar

        [HttpGet("GetUrunlerKampanyalarById")]
        public IActionResult GetUrunlerKampanyalarById ([FromQuery] int UrunKampanyaId)
        {
            var result = _campaignsService.GetUrunlerKampanyalarById (UrunKampanyaId);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerKampanyalar")]
        public IActionResult GetAllUrunlerKampanyalar()
        {
            return Ok(_campaignsService.GetAllUrunlerKampanyalars());
        }

        [HttpPut("InsertUrunlerKampanyalar")]
        public IActionResult InsertUrunlerKampanyalar ([FromBody] UrunlerKampanyalar urunlerKampanyalar)
        {

            return Ok(_campaignsService.InsertUrunlerKampanyalar (urunlerKampanyalar));
        }

        [HttpPost("UpdateUrunlerKampanyalar")]
        public IActionResult UpdateUrunlerKampanyalar ([FromBody] UrunlerKampanyalar urunlerKampanyalar)
        {
            return Ok(_campaignsService.UpdateUrunlerKampanyalar (urunlerKampanyalar));
        }

        [HttpDelete("DeleteUrunlerKampanyalar")]
        public IActionResult DeleteUrunlerKampanyalarById (int UrunKampanyaId)
        {
            var ukampanya = _campaignsService.GetUrunlerKampanyalarById(UrunKampanyaId);
            if (ukampanya == null)
            {
                return NotFound();
            }

            _campaignsService.DeleteUrunlerKampanyalarById(ukampanya);
            return NoContent();
        }

        #endregion

        #region Kampanyalar

        [HttpGet("GetKampanyalarById")]
        public IActionResult GetKampanyalarById([FromQuery] int KampanyaId)
        {
            var result = _campaignsService.GetKampanyalarById(KampanyaId);
            return Ok(result);
        }

        [HttpGet("GetAllKampanyalar")]
        public IActionResult GetAllKampanyalar()
        {
            return Ok(_campaignsService.GetAllKampanyalars());
        }

        [HttpPut("InsertKampanyalar")]
        public IActionResult InsertKampanyalar([FromBody] Kampanyalar Kampanyalar)
        {

            return Ok(_campaignsService.InsertKampanyalar(Kampanyalar));
        }

        [HttpPost("UpdateKampanyalar")]
        public IActionResult UpdateKampanyalar([FromBody] Kampanyalar kampanyalar)
        {
            return Ok(_campaignsService.UpdateKampanyalar(kampanyalar));
        }

        [HttpDelete("DeleteKampanyalar")]
        public IActionResult DeleteKampanyalarById(int KampanyaId)
        {
            var kampanya = _campaignsService.GetKampanyalarById(KampanyaId);
            if (kampanya == null)
            {
                return NotFound();
            }

            _campaignsService.DeleteKampanyalarById(kampanya);
            return NoContent();
        }

        #endregion

        #region VwKampanyalar

        [HttpGet("GetVwkampanyalarById")]
        public IActionResult GetVwkampanyalarById([FromQuery] int KampanyaId)
        {
            var result = _campaignsService.GetVwkampanyalarById(KampanyaId);
            return Ok(result);
        }

        [HttpGet("GetAllVwkampanyalar")]
        public IActionResult GetAllVwkampanyalar()
        {
            return Ok(_campaignsService.GetAllVwkampanyalars());
        }

        [HttpPut("InsertVwkampanyalar")]
        public IActionResult InsertVwkampanyalar ([FromBody] Vwkampanyalar vwkampanyalar)
        {

            return Ok(_campaignsService.InsertVwkampanyalar(vwkampanyalar));
        }

        [HttpPost("UpdateVwkampanyalar")]
        public IActionResult UpdateVwkampanyalar ([FromBody] Vwkampanyalar vwkampanyalar)
        {
            return Ok(_campaignsService.UpdateVwkampanyalar (vwkampanyalar));
        }

        [HttpDelete("DeleteVwkampanyalar")]
        public IActionResult DeleteVwkampanyalarById(int KampanyaId)
        {
            var wkampanya = _campaignsService.GetVwkampanyalarById(KampanyaId);
            if (wkampanya == null)
            {
                return NotFound();
            }

            _campaignsService.DeleteVwkampanyalarById(wkampanya);
            return NoContent();
        }

        #endregion

    }
}
