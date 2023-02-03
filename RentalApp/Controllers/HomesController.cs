using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalApp.Core.Dto;
using RentalApp.Data;
using RentalApp.Service.Impl;

namespace RentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomesController : ControllerBase
    {
        private readonly RentalAppContext _context;


        public HomesController(RentalAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = (from u in _context.Urunlers
                            join f in _context.UrunlerFiyats on u.UrunId equals f.UrunId
                            join k in _context.UrunlerKampanyalars on u.UrunId equals k.UrunId
                            join r in _context.UrunlerResims on u.UrunId equals r.UrunId
                            join d in _context.UrunlerDils on u.UrunId equals d.UrunId
                            join y in _context.UrunlerYorums on u.UrunId equals y.UrunId
                            group new { u, f, r, d, y,k } by u.UrunId into grouped
                            select new Product
                            {
                                UrunId = grouped.Key,
                                SinifId = grouped.FirstOrDefault().u.SinifId,
                                UrunKodu = grouped.FirstOrDefault().u.UrunKodu,
                                Adres = grouped.FirstOrDefault().u.Adres,
                                BolgeId = grouped.FirstOrDefault().u.BolgeId,
                                IlId = grouped.FirstOrDefault().u.IlId,
                                IlceId = grouped.FirstOrDefault().u.IlceId,
                                UrunAdi = grouped.FirstOrDefault().u.UrunAdi,
                                Puan = grouped.FirstOrDefault().y.Puan,
                                Fiyat = grouped.FirstOrDefault().f.Fiyat,
                                Resim = grouped.FirstOrDefault().r.Resim,
                                DilId = grouped.FirstOrDefault().d.DilId,
                                Link = grouped.FirstOrDefault().d.Link,
                                KampanyaId = grouped.FirstOrDefault().k.KampanyaId,
                            });
            return await products.ToListAsync();
        }
    }

}
