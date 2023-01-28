using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl.Products;
using RentalApp.Service.Impl.Vw;
using RentalApp.Service.Services;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccupancyCalendarController : ControllerBase
    {
        private readonly IVwFullDaysService _vwFullDaysService;
        private readonly IOccupancyCalendarService _occupancyCalendarService;


        public OccupancyCalendarController(IOccupancyCalendarService occupancyCalendarService, IVwFullDaysService vwFullDaysService)
        {
            _occupancyCalendarService = occupancyCalendarService;
            _vwFullDaysService= vwFullDaysService;
        }

        #region Dolugunler

        [HttpGet("GetVwdolugunlerById")]
        public IActionResult GetVwdolugunlerById([FromQuery] int RezervasyonId)
        {
            var result = _vwFullDaysService.GetVwdolugunlerById(RezervasyonId);
            return Ok(result);
        }

        [HttpGet("GetAllVwdolugunler")]
        public IActionResult GetAllVwdolugunler()
        {
            return Ok(_vwFullDaysService.GetAllVwdolugunlers());
        }

        [HttpPut("InsertVwdolugunler")]
        public IActionResult InsertVwdolugunler ([FromBody] Vwdolugunler vwdolugunler)
        {

            return Ok(_vwFullDaysService.InsertVwdolugunler (vwdolugunler));
        }

        [HttpPost("UpdateVwdolugunler")]
        public IActionResult UpdateVwdolugunler([FromBody] Vwdolugunler vwdolugunler)
        {
            return Ok(_vwFullDaysService.UpdateVwdolugunler (vwdolugunler));
        }

        [HttpDelete("DeleteVwdolugunler")]
        public IActionResult DeleteVwdolugunler (int RezervasyonId)
        {
            var rezervasyon = _vwFullDaysService.GetVwdolugunlerById (RezervasyonId);
            if (rezervasyon == null)
            {
                return NotFound();
            }

            _vwFullDaysService.DeleteVwdolugunlerById (rezervasyon);
            return NoContent();
        }

        #endregion

        #region DolulukTakvimi

        [HttpGet("GetDolulukTakvimiById")]
        public IActionResult GetDolulukTakvimiById ([FromQuery] int DolulukId)
        {
            var result = _occupancyCalendarService.GetDolulukTakvimiById(DolulukId);
            return Ok(result);
        }

        [HttpGet("GetAllDolulukTakvimi")]
        public IActionResult GetAllDolulukTakvimi()
        {
            return Ok(_occupancyCalendarService.GetAllDolulukTakvimis());
        }

        [HttpPut("InsertDolulukTakvimi")]
        public IActionResult InsertDolulukTakvimi([FromBody] DolulukTakvimi dolulukTakvimi)
        {

            return Ok(_occupancyCalendarService.InsertDolulukTakvimi(dolulukTakvimi));
        }

        [HttpPost("UpdateDolulukTakvimi")]
        public IActionResult UpdateDolulukTakvimi ([FromBody] DolulukTakvimi dolulukTakvimi)
        {
            return Ok(_occupancyCalendarService.UpdateDolulukTakvimi (dolulukTakvimi));
        }

        [HttpDelete("DeleteDolulukTakvimi")]
        public IActionResult DeleteDolulukTakvimi (int DolulukId)
        {
            var doluluk = _occupancyCalendarService.GetDolulukTakvimiById(DolulukId);
            if (doluluk == null)
            {
                return NotFound();
            }

            _occupancyCalendarService.DeleteDolulukTakvimiById(doluluk);
            return NoContent();
        }

        #endregion

    }
}
