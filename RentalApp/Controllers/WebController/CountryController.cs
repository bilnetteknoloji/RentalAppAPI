using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        #region Ulke
        [HttpGet("GetUlkelerById")]
        public IActionResult GetUlkelerById([FromQuery] int UlkeId)
        {
            var result = _countryService.GetUlkeById(UlkeId);
            return Ok(result);
        }

        [HttpGet("GetAllUlkeler")]
        public IActionResult GetAllUlker()
        {
            return Ok(_countryService.GetAllUlkes());
        }

        [HttpPut("InsertUlkeler")]
        public IActionResult InsertUlkerler([FromBody] Ulkeler ulkeler)
        {
            return Ok(_countryService.InsertUlke(ulkeler));
        }

        [HttpPost("UpdateUlkeler")]
        public IActionResult UpdateUlkeler([FromBody] Ulkeler ulkeler)
        {
            return Ok(_countryService.UpdateUlke(ulkeler));
        }

        [HttpDelete("DeleteUlkeler")]
        public IActionResult DeleteUlkeler(int UlkeId)
        {
            var ulke = _countryService.GetUlkeById(UlkeId);
            if (ulke == null)
            {
                return NotFound();
            }

            _countryService.DeleteUlke(ulke);
            return NoContent();
        }
        #endregion

        #region Bolge
        [HttpGet("GetBolgelerById")]
        public IActionResult GetBolgelerById([FromQuery] int BolgeId)
        {
            var result = _countryService.GetBolgelerById(BolgeId);
            return Ok(result);
        }

        [HttpGet("GetAllBolgeler")]
        public IActionResult GetAllBolgeler()
        {
            return Ok(_countryService.GetAllBolgelers());
        }

        [HttpPut("InsertBolgeler")]
        public IActionResult InsertBolgeler([FromBody] Bolgeler bolgeler)
        {
            return Ok(_countryService.InsertBolgeler(bolgeler));
        }

        [HttpPost("UpdateBolgeler")]
        public IActionResult UpdateBolgeler([FromBody] Bolgeler bolgeler)
        {
            return Ok(_countryService.UpdateBolgeler(bolgeler));
        }

        [HttpDelete("DeleteBolgeler")]
        public IActionResult DeleteBolgeler(int BolgeId)
        {
            var bolge = _countryService.GetBolgelerById(BolgeId);
            if (bolge == null)
            {
                return NotFound();
            }

            _countryService.DeleteBolgeler(bolge);
            return NoContent();
        }
        #endregion

        #region Iller
        [HttpGet("GetIller")]
        public IActionResult GetIllerById([FromQuery] int IlId)
        {
            var result = _countryService.GetIllerById(IlId);
            return Ok(result);
        }

        [HttpGet("GetAllIller")]
        public IActionResult GetAllIller()
        {
            return Ok(_countryService.GetAllIllers());
        }

        [HttpPut("InsertIller")]
        public IActionResult InsertIller([FromBody] Iller ıller)
        {
            return Ok(_countryService.InsertIller(ıller));
        }

        [HttpPost("UpdateIller")]
        public IActionResult UpdateIller([FromBody] Iller ıller)
        {
            return Ok(_countryService.UpdateIller(ıller));
        }

        [HttpDelete("DeleteIller")]
        public IActionResult DeleteIlller(int IlId)
        {
            var ıl = _countryService.GetIllerById(IlId);
            if (ıl == null)
            {
                return NotFound();
            }

            _countryService.DeleteIller(ıl);
            return NoContent();
        }
        #endregion

        #region Ilce
        [HttpGet("GetIlcelerById")]
        public IActionResult GetIlcelerById([FromQuery] int IlceId)
        {
            var result = _countryService.GetIlcelerById(IlceId);
            return Ok(result);
        }

        [HttpGet("GetAllIlceler")]
        public IActionResult GetAllIlceler()
        {
            return Ok(_countryService.GetAllIlcelers());
        }

        [HttpPut("InsertIlceler")]
        public IActionResult InsertIlceler([FromBody] Ilceler ılceler)
        {
            return Ok(_countryService.InsertIlceler(ılceler));
        }

        [HttpPost("UpdateIlceler")]
        public IActionResult UpdateIlceler([FromBody] Ilceler ılceler)
        {
            return Ok(_countryService.UpdateIlceler(ılceler));
        }

        [HttpDelete("DeleteIlceler")]
        public IActionResult DeleteIlceler(int IlceId)
        {
            var ılce = _countryService.GetIlcelerById(IlceId);
            if (ılce == null)
            {
                return NotFound();
            }

            _countryService.DeleteIlceler(ılce);
            return NoContent();
        }
        #endregion

    }
}
