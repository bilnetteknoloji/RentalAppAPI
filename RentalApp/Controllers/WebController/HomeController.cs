using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;
using RentalApp.Core;
using RentalApp.Core.Dto;
using RentalApp.Service.Impl;
using RentalApp.Service.Impl.Products;

namespace RentalApp.Controllers.WebController
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IPagesService _pagesService;
        private readonly IProductsService _productsService;
        private readonly ICurrenciesService _currenciesService;
        private readonly IFAQQuestionsService _fAQQuestionsService;
        private readonly IProductCommentService _productCommentService;


        public HomeController(IFAQQuestionsService fAQQuestionsService,IProductsService productsService, IProductCommentService productCommentService, ICurrenciesService currenciesService, IPagesService pagesService)
        {
            _pagesService = pagesService;
            _productsService = productsService;
            _currenciesService = currenciesService;
            _fAQQuestionsService= fAQQuestionsService;
            _productCommentService = productCommentService;

        }

        #region UrunlerVitrin

        [HttpGet("GetVitrinUrunleriById")]
        public IActionResult GetUrunlerVitrinById([FromQuery] int VitrinId)
        {
            var result = _productsService.GetUrunlerVitrinById(VitrinId);
            return Ok(result);
        }

        [HttpGet("GetAllVitrinUrunleri")]
        public IActionResult GetAllVitrinUrunleri()
        {
            return Ok(_productsService.GetAllUrunlerVitrins());
        }

        [HttpPut("InsertVitrinUrunleri")]
        public IActionResult InsertUrunlerVitrin([FromBody] UrunlerVitrin urunlerVitrin)
        {

            return Ok(_productsService.InsertUrunlerVitrin(urunlerVitrin));
        }

        [HttpPost("UpdateVitrinUrunleri")]
        public IActionResult UpdateUrunlerVitrin([FromBody] UrunlerVitrin urunlerVitrin)
        {
            return Ok(_productsService.UpdateUrunVitrin(urunlerVitrin));
        }

        [HttpDelete("DeleteUrunlerVitrin")]
        public IActionResult DeleteUrunlerVitrin(int VitrinId)
        {
            var vitrin = _productsService.GetUrunlerVitrinById(VitrinId);
            if (vitrin == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerVitrinById(vitrin);
            return NoContent();
        }

        #endregion

        #region UrunlerBanyolar

        [HttpGet("GetUrunlerBanyolarById")]
        public IActionResult GetUrunlerBanyolarById ([FromQuery] int urunbanyoid)
        {
            var result = _productsService.GetUrunlerBanyolarById (urunbanyoid);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerBanyolar")]
        public IActionResult GetAllUrunlerBanyolar()
        {
            return Ok(_productsService.GetAllUrunlerBanyolars());
        }

        [HttpPut("InsertUrunlerBanyolar")]
        public IActionResult InsertUrunlerBanyolar ([FromBody] UrunlerBanyolar urunlerBanyolar)
        {

            return Ok(_productsService.InsertUrunlerBanyolar (urunlerBanyolar));
        }

        [HttpPost("UpdateUrunlerBanyolar")]
        public IActionResult UpdateUrunlerBanyolar ([FromBody] UrunlerBanyolar urunlerBanyolar)
        {
            return Ok(_productsService.UpdateUrunlerBanyolar (urunlerBanyolar));
        }

        [HttpDelete("DeleteUrunlerBanyolar")]
        public IActionResult DeleteUrunlerBanyolar (int urunlerBanyolarid)
        {
            var banyolar = _productsService.GetUrunlerBanyolarById(urunlerBanyolarid);
            if (banyolar == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerBanyolar(banyolar);
            return NoContent();
        }

        #endregion

        #region UrunlerYatakOdalari

        [HttpGet("GetUrunlerYatakOdalariById")]
        public IActionResult GetUrunlerYatakOdalariById([FromQuery] int urunyatakodasiid)
        {
            var result = _productsService.GetUrunlerYatakodalariById (urunyatakodasiid);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerYatakOdalari")]
        public IActionResult GetAllUrunlerYatakOdalari()
        {
            return Ok(_productsService.GetAllUrunlerYatakOdalaris());
        }

        [HttpPut("InsertUrunlerYatakOdalari")]
        public IActionResult InsertUrunlerYatakOdalari ([FromBody] UrunlerYatakodalari urunlerYatakodalari)
        {

            return Ok(_productsService.InsertUrunYatakodalari(urunlerYatakodalari));
        }

        [HttpPost("UpdateUrunlerYatakOdalari")]
        public IActionResult UpdateUrunlerYatakOdalari ([FromBody] UrunlerYatakodalari urunlerYatakodalari)
        {
            return Ok(_productsService.UpdateUrunYatakodalari (urunlerYatakodalari));
        }

        [HttpDelete("DeleteUrunlerYatakOdalari")]
        public IActionResult DeleteUrunYatakOdalari (int urunleryatakodalariid)
        {
            var yatak = _productsService.GetUrunlerYatakodalariById(urunleryatakodalariid);
            if (yatak == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunYatakodalari(yatak);
            return NoContent();
        }

        #endregion

        #region UrunlerIstatistik

        [HttpGet("GetUrunlerIstatistikById")]
        public IActionResult GetUrunlerIstatistikById ([FromQuery] int IstatistikId)
        {
            var result = _productsService.GetUrunlerIstatistikById (IstatistikId);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerIstatistik")]
        public IActionResult GetAllUrunlerIstatistik()
        {
            return Ok(_productsService.GetAllUrunlerIstatistiks());
        }

        [HttpPut("InsertUrunlerIstatistik")]
        public IActionResult InsertUrunlerIstatistik ([FromBody] UrunlerIstatistik urunlerIstatistik)
        {

            return Ok(_productsService.InsertUrunlerIstatistik (urunlerIstatistik));
        }

        [HttpPost("UpdateUrunlerIstatistik")]
        public IActionResult UpdateUrunlerIstatistik ([FromBody] UrunlerIstatistik urunlerIstatistik)
        {
            return Ok(_productsService.UpdateUrunlerIstatistik (urunlerIstatistik));
        }

        [HttpDelete("DeleteUrunlerIstatistik")]
        public IActionResult DeleteUrunlerIstatistik (int IstatistikId)
        {
            var istatistik = _productsService.GetUrunlerIstatistikById(IstatistikId);
            if (istatistik == null)
            {
                return NotFound();
            }

            _productsService.DeleteUrunlerIstatistik (istatistik);
            return NoContent();
        }

        #endregion

        #region UrunlerYorum

        [HttpGet("GetUrunlerYorum")]
        public IActionResult GetUrunlerYorumById([FromQuery] int YorumId)
        {
            var result = _productCommentService.GetUrunlerYorumById(YorumId);
            return Ok(result);
        }

        [HttpGet("GetAllUrunlerYorum")]
        public IActionResult GetAllUrunlerYorum()
        {
            return Ok(_productCommentService.GetAllYorums());
        }

        [HttpPut("InsertUrunlerYorum")]
        public IActionResult InsertUrunlerYorum([FromBody] UrunlerYorum urunlerYorum)
        {

            return Ok(_productCommentService.InsertUrunlerYorum(urunlerYorum));
        }

        [HttpPost("UpdateUrunlerYorum")]
        public IActionResult UpdateUrunlerYorum ([FromBody] UrunlerYorum urunlerYorum)
        {
            return Ok(_productCommentService.UpdateUrunlerYorum(urunlerYorum));
        }

        [HttpDelete("DeleteUrunlerYorum")]
        public IActionResult DeleteUrunlerYorum(int YorumId)
        {
            var vitrin = _productCommentService.GetUrunlerYorumById(YorumId);
            if (vitrin == null)
            {
                return NotFound();
            }

            _productCommentService.DeleteUrunlerYorumById(vitrin);
            return NoContent();
        }

        #endregion

        #region ParaBirimler

        [HttpGet("GetParaBirimlerById")]
        public IActionResult GetParaBirimlerById ([FromQuery] int BirimId)
        {
            var result = _currenciesService.GetParaBirimlerById(BirimId);
            return Ok(result);
        }

        [HttpGet("GetAllParaBirimler")]
        public IActionResult GetAllParaBirimler()
        {
            return Ok(_currenciesService.GetAllParaBirimlers());
        }

        [HttpPut("InsertParaBirimler")]
        public IActionResult InsertParaBirimler ([FromBody] ParaBirimler paraBirimler)
        {

            return Ok(_currenciesService.InsertParaBirimler (paraBirimler));
        }

        [HttpPost("UpdateParaBirimler")]
        public IActionResult UpdateParaBirimler ([FromBody] ParaBirimler paraBirimler)
        {
            return Ok(_currenciesService.UpdateParaBirimler (paraBirimler));
        }

        [HttpDelete("DeleteParaBirimler")]
        public IActionResult DeleteParaBirimler (int BirimId)
        {
            var birim = _currenciesService.GetParaBirimlerById (BirimId);
            if (birim == null)
            {
                return NotFound();
            }

            _currenciesService.DeleteParaBirimler (birim);
            return NoContent();
        }

        #endregion

        #region Sayfalar

        [HttpGet("GetSayfalarById")]
        public IActionResult GetSayfalarById ([FromQuery] int SayfaId)
        {
            var result = _pagesService.GetSayfalarById (SayfaId);
            return Ok(result);
        }

        [HttpGet("GetAllSayfalar")]
        public IActionResult GetAllSayfalar()
        {
            return Ok(_pagesService.GetAllSayfalars());
        }

        [HttpPut("InsertSayfalar")]
        public IActionResult InsertSayfalar ([FromBody] Sayfalar sayfalar)
        {

            return Ok(_pagesService.InsertSayfalar (sayfalar));
        }

        [HttpPost("UpdateSayfalar")]
        public IActionResult UpdateSayfalar ([FromBody] Sayfalar sayfalar)
        {
            return Ok(_pagesService.UpdateSayfalar (sayfalar));
        }

        [HttpDelete("DeleteSayfalar")]
        public IActionResult DeleteSayfalar (int SayfaId)
        {
            var sayfa = _pagesService.GetSayfalarById (SayfaId);
            if (sayfa == null)
            {
                return NotFound();
            }

            _pagesService.DeleteSayfalar (sayfa);
            return NoContent();
        }

        #endregion

        #region SSS

        [HttpGet("GetSssSorularById")]
        public IActionResult GetSssSorularById ([FromQuery] int SoruId)
        {
            var result = _fAQQuestionsService.GetSssSorularById (SoruId);
            return Ok(result);
        }

        [HttpGet("GetAllSssSorular")]
        public IActionResult GetAllSssSorular()
        {
            return Ok(_fAQQuestionsService.GetAllSssSorulars());
        }

        [HttpPut("InsertSssSorular")]
        public IActionResult InsertSssSorular ([FromBody] SssSorular sssSorular)
        {

            return Ok(_fAQQuestionsService.InsertSssSorular (sssSorular));
        }

        [HttpPost("UpdateSssSorular")]
        public IActionResult UpdateSssSorular ([FromBody] SssSorular sssSorular)
        {
            return Ok(_fAQQuestionsService.UpdateSssSorular (sssSorular));
        }

        [HttpDelete("DeleteSssSorular")]
        public IActionResult DeleteSssSorular (int SoruId)
        {
            var soru = _fAQQuestionsService.GetSssSorularById (SoruId);
            if (soru == null)
            {
                return NotFound();
            }

            _fAQQuestionsService.DeleteSssSorular (soru);
            return NoContent();
        }

        #endregion


    }
}
