using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using RentalApp.Core;
using RentalApp.Core.Dto;
using RentalApp.Data;
using RentalApp.Service.Impl.Products;
using RentalApp.Service.Services;
using RentalApp.Service.Services.Products;
using System.Reflection.Metadata;

namespace RentalApp_v2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IProductsService _productsService;
        private readonly IProductCommentService _productCommentService;

        public ValuesController(IProductsService productsService,
            IProductCommentService productCommentService)
        {
            _productsService = productsService;
            _productCommentService = productCommentService;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parametre"></param>
        /// <returns></returns>
        /// HttpGette m�mk�n old�nca sadece veri d�nd�rmeyi kullan�n
        /// postta ise at�� serbest . yani full post bi sistem yazabilrsnz 
        [HttpPost("MethodAdi")]
        public IActionResult MethodAdi([FromBody] SampleApiRequest parametre)
        {
            /// burada servis d��� i�lemler yapabilrsnz �rnek olarak parametreye 
            /// text'i _productCommentService'e insert edip 
            /// product'a yeni bir kay�t ataca��m
            /// En Sonda b�t�n productlar� d�nece�im

            if (_productCommentService.InsertUrunlerYorum(new UrunlerYorum { Adsoyad = $"{parametre.Name} {parametre.Surname}", Durum = false, Baslik = parametre.Text, Eposta = parametre.Email }))
            {
                _productsService.InsertUrunler(new Urunler { /*buran�n dolmas� lazm*/});
            }

            return Ok(_productsService.GetAllUrunler());
        }

        [HttpGet("GetExample")]//bu �ekilde yaparsnz queryden al�r
        public IActionResult GetSample([FromQuery] int id) // Bu �ekilde yaparsnz Body de get atmanz lazm ama ikisni ayn� anda kullanmayn 
        {
            var result = _productCommentService.GetUrunlerYorumById(id);

            return Ok(result);
        }

        [HttpPut("InsertLanguage")]
        public IActionResult InsertLanguage([FromBody] UrunlerYorum urunlerYorum)
        {
           
            return Ok(_productCommentService.InsertUrunlerYorum(urunlerYorum));
        }

        [HttpPost("UpdateYorum")]
        public IActionResult UpdateYorum([FromBody] UrunlerYorum urunlerYorum)
        {
            return Ok(_productCommentService.UpdateUrunlerYorum(urunlerYorum));
        }

        [HttpGet("GetYorum")]
        public IActionResult GetYorum([FromQuery] int yorumId)
        {
            var result = _productCommentService.GetUrunlerYorumById(yorumId);
            return Ok(result);
        }
        [HttpGet("GetYorumByUrunId")]
        public IActionResult GetYorumByUrunId([FromQuery] int urunId)
        {
            var result = _productCommentService.GetAllUrunlerYorum(urunId);
            return Ok(result);
        }

        [HttpGet("GetAllLanguage")]
        public IActionResult GetAllLanguage()
        {
            return Ok(_productCommentService.GetAllYorums());
        }




    }
}
