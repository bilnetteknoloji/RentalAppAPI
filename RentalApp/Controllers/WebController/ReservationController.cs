using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalApp.Core;
using RentalApp.Service.Impl;
using RentalApp.Service.Impl.Reservations;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    { 
        private readonly IPreBookingsService _preBookingsService;
        private readonly IReservationsProductService _reservationsProductService; 
        private readonly IRentalPicturesService _rentalPicturesService;
        private readonly IRentalRequestsService _rentalRequestsService;
        private readonly IPreBookingProductService _preBookingProductService;
        private readonly IOnReservationsAdditionalService _onReservationsAdditionalService;


        public ReservationController(IRentalPicturesService rentalPicturesService, IRentalRequestsService rentalRequestsService, IOnReservationsAdditionalService onReservationsAdditionalService, IPreBookingProductService preBookingProductService, IPreBookingsService preBookingsService, IReservationsProductService reservationsProductService)
        {
            _preBookingsService = preBookingsService;
            _reservationsProductService = reservationsProductService;
            _rentalPicturesService = rentalPicturesService;
            _rentalRequestsService = rentalRequestsService;
            _preBookingProductService = preBookingProductService;
            _onReservationsAdditionalService = onReservationsAdditionalService;
        }

        #region KiralamaResimler

        [HttpGet("GetKiralamaResimler")]
        public IActionResult GetKiralamaResimlerById (int TalepresimId)
        {
            var result = _rentalPicturesService.GetKiralamaResimlerById(TalepresimId);
            return Ok(result);
        }

        [HttpGet("GetAllKiralamaResimler")]
        public IActionResult GetAllKiralamaResimler()
        {
            return Ok(_rentalPicturesService.GetAllKiralamaResims());
        }

        [HttpPut("InsertKiralamaResimler")]
        public IActionResult InsertKiralamaResimler([FromBody] KiralamaResimler kiralamaResimler)
        {
            return Ok (_rentalPicturesService.InsertKiralamaResimler(kiralamaResimler));
        }

        [HttpPost("UpdateKiralamaResimler")]
        public IActionResult UpdateKiralamaResimler([FromBody] KiralamaResimler kiralamaResimler)
        {
            return Ok (_rentalPicturesService.UpdateKiralamaResimler(kiralamaResimler));
        }

        [HttpDelete("DeleteKiralamaResimler")]
        public IActionResult DeleteKiralamaResimler(int TalepresimId)
        {
            var kiralamares = _rentalPicturesService.GetKiralamaResimlerById(TalepresimId);
            if(kiralamares == null)
            {
                return NotFound();
            }
            _rentalPicturesService.DeleteKiralamaResimlerById(kiralamares);
            return NoContent();
        }
        #endregion

        #region RezervasyonlarUrun

        [HttpGet("GetRezervasyonlarUrunById")]
        public IActionResult GetRezervasyonlarUrunById (int RezervasyonurunId)
        {
            var result = _reservationsProductService.GetRezervasyonlarUrunById(RezervasyonurunId);
            return Ok(result);
        }

        [HttpGet("GetAllRezervasyonlarUrun")]
        public IActionResult GetAllRezervasyonlarUrun()
        {
            return Ok(_reservationsProductService.GetAllRezervasyonlarUruns());
        }

        [HttpPut("InsertRezervasyonlarUrun")]
        public IActionResult InsertRezervasyonlarUrun([FromBody] RezervasyonlarUrun rezervasyonlarUrun)
        {
            return Ok(_reservationsProductService.InsertRezervasyonlarUrun(rezervasyonlarUrun));
        }

        [HttpPost("UpdateRezervasyonlarUrun")]
        public IActionResult UpdateRezervasyonUrun([FromBody] RezervasyonlarUrun rezervasyonlarUrun)
        {
            return Ok(_reservationsProductService.UpdateRezervasyonlarUrun(rezervasyonlarUrun));
        }

        [HttpDelete("DeleteRezervasyonlarUrun")]
        public IActionResult DeleteRezervasyonUrun(int RezervasyonurunId)
        {
            var kiralamauru = _reservationsProductService.GetRezervasyonlarUrunById(RezervasyonurunId);
            if (kiralamauru == null)
            {
                return NotFound();
            }
            _reservationsProductService.DeleteRezervasyonlarUrun(kiralamauru);
            return NoContent();
        }
        #endregion

        #region KiralamaTalepleri

        [HttpGet("GetKiralamaTalepleriById")]
        public IActionResult GetKiralamaTalepleriById(int TalepId)
        {
            var result = _rentalRequestsService.GetKiralamaTalepleriById(TalepId);
            return Ok(result);
        }

        [HttpGet("GetAllKiralamaTalepleri")]
        public IActionResult GetAllKiralamaTalepleri()
        {
            return Ok(_rentalRequestsService.GetAllKiralamaTalepleris());
        }

        [HttpPut("InsertKiralamaTalepleri")]
        public IActionResult InsertKiralamaTalepleri([FromBody] KiralamaTalepleri kiralamaTalepleri)
        {
            return Ok(_rentalRequestsService.InsertKiralamaTalepleri(kiralamaTalepleri));
        }

        [HttpPost("UpdateKiralamaTalepleri")]
        public IActionResult UpdateKiralamaTalepleri([FromBody] KiralamaTalepleri kiralamaTalepleri)
        {
            return Ok(_rentalRequestsService.UpdateKiralamaTalepleri(kiralamaTalepleri));
        }

        [HttpDelete("DeleteKiralamaTalepleri")]
        public IActionResult DeleteKiralamaTalepleri(int TalepId)
        {
            var kiralamaTal = _rentalRequestsService.GetKiralamaTalepleriById(TalepId);
            if (kiralamaTal == null)
            {
                return NotFound();
            }
            _rentalRequestsService.DeleteKiralamaTalepleriById(kiralamaTal);
            return NoContent();
        }

        #endregion

        #region Onrezervasyonlar

        [HttpGet("GetOnrezervasyonlarById")]
        public IActionResult GetOnrezervasyonlarById(int OnrezervasyonId)
        {
            var result = _preBookingsService.GetOnrezervasyonlarById(OnrezervasyonId);
            return Ok(result);
        }

        [HttpGet("GetAllOnrezervasyonlar")]
        public IActionResult GetAllOnrezervasyonlar()
        {
            return Ok(_preBookingsService.GetAllOnrezervasyonlars());
        }

        [HttpPut("InsertOnrezervasyonlar")]
        public IActionResult InsertOnrezervasyonlar([FromBody] Onrezervasyonlar onrezervasyonlar)
        {
            return Ok(_preBookingsService.InsertOnrezervasyonlar(onrezervasyonlar));
        }

        [HttpPost("UpdateOnrezervasyonlar")]
        public IActionResult UpdateOnrezervasyonlar([FromBody] Onrezervasyonlar onrezervasyonlar)
        {
            return Ok(_preBookingsService.UpdateOnrezervasyonlar(onrezervasyonlar));
        }

        [HttpDelete("DeleteOnrezervasyonlar")]
        public IActionResult DeleteOnrezervasyonlar(int OnrezervasyonId)
        {
            var Onrez = _preBookingsService.GetOnrezervasyonlarById(OnrezervasyonId);
            if (Onrez == null)
            {
                return NotFound();
            }
            _preBookingsService.DeleteOnrezervasyonlarById(Onrez);
            return NoContent();
        }

        #endregion

        #region OnrezervasyonlarUrun

        [HttpGet("GetOnrezervasyonlarUrun")]
        public IActionResult GetOnrezervasyonlarUrunById(int OnrezervasyonlarUrunId)
        {
            var result = _preBookingProductService.GetOnrezervasyonlarUrunById(OnrezervasyonlarUrunId);
            return Ok(result);
        }

        [HttpGet("GetAllOnrezervasyonlarUrun")]
        public IActionResult GetAllOnrezervasyonlarUrun()
        {
            return Ok(GetAllOnrezervasyonlarUrun());
        }

        [HttpPut("InsertOnrezervasyonlarUrun")]
        public IActionResult InsertOnrezervasyonlarUrun([FromBody] OnrezervasyonlarUrun onrezervasyonlarUrun)
        {
            return Ok(_preBookingProductService.InsertOnrezervasyonlarUrun(onrezervasyonlarUrun));
        }

        [HttpPost("UpdateOnrezervasyonlarUrun")]
        public IActionResult UpdateOnrezervasyonlarUrun([FromBody] OnrezervasyonlarUrun onrezervasyonlarUrun)
        {
            return Ok(_preBookingProductService.UpdateOnrezervasyonlarUrun(onrezervasyonlarUrun));
        }

        [HttpDelete("DeleteOnrezervasyonlarUrun")]
        public IActionResult DeleteOnrezervasyonlarUrun(int OnrezervasyonUrunId)
        {
            var OnrezUrun = _preBookingProductService.GetOnrezervasyonlarUrunById(OnrezervasyonUrunId);
            if (OnrezUrun == null)
            {
                return NotFound();
            }
            _preBookingProductService.DeleteOnrezervasyonlarUrunById(OnrezUrun);
            return NoContent();
        }
        #endregion

        #region OnrezervasyonlarEkhizmet

        [HttpGet("GetOnrezervasyonlarEkhizmetById")]
        public IActionResult GetOnrezervasyonlarEkhizmetById(int OnrezervasyonekhizmetId)
        {
            var result = _onReservationsAdditionalService.GetOnrezervasyonlarEkhizmetById(OnrezervasyonekhizmetId);
            return Ok(result);
        }

        [HttpGet("GetAllOnrezervasyonlarEkhizmet")]
        public IActionResult GetAllOnrezervasyonlarEkhizmet()
        {
            return Ok(_onReservationsAdditionalService.GetAllOnrezervasyonlarEkhizmets());
        }

        [HttpPut("InsertOnrezervasyonlarEkhizmet")]
        public IActionResult InsertOnrezervasyonlarEkhizmet([FromBody] OnrezervasyonlarEkhizmet onrezervasyonlarEkhizmet)
        {
            return Ok(_onReservationsAdditionalService.InsertOnrezervasyonlarEkhizmet(onrezervasyonlarEkhizmet));
        }

        [HttpPost("UpdateOnrezervasyonlarEkhizmet")]
        public IActionResult UpdateOnrezervasyonlarEkhizmet([FromBody] OnrezervasyonlarEkhizmet onrezervasyonlarEkhizmet)
        {
            return Ok(_onReservationsAdditionalService.UpdateOnrezervasyonlarEkhizmet(onrezervasyonlarEkhizmet));
        }

        [HttpDelete("DeleteOnrezervasyonlarEkhizmet")]
        public IActionResult DeleteOnrezervasyonlarEkhizmet(int OnrezervasyonekhizmetId)
        {
            var OnrezEk = _onReservationsAdditionalService.GetOnrezervasyonlarEkhizmetById(OnrezervasyonekhizmetId);
            if (OnrezEk == null)
            {
                return NotFound();
            }
            _onReservationsAdditionalService.DeleteOnrezervasyonlarEkhizmetById(OnrezEk);
            return NoContent();
        }
        #endregion

    }
}
