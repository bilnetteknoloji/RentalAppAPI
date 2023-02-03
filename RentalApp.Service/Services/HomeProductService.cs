using RentalApp.Core.Dto;
using RentalApp.Data;
using RentalApp.Service.Impl;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Services
{
    public class HomeProductService : IHomeProductService
    {
        private readonly RentalAppContext _context;

        public HomeProductService(RentalAppContext context)
        {
            _context = context;
        }

        public async Task <IEnumerable<Product>> GetAllProducts()
        {
            {
                var products = (from u in _context.Urunlers
                                join f in _context.UrunlerFiyats on u.UrunId equals f.UrunId
                                join k in _context.UrunlerKampanyalars on u.UrunId equals k.UrunId
                                join r in _context.UrunlerResims on u.UrunId equals r.UrunId
                                join d in _context.UrunlerDils on u.UrunId equals d.UrunId
                                join y in _context.UrunlerYorums on u.UrunId equals y.UrunId

                                select new Product()
                                {
                                    UrunId = u.UrunId,
                                    SinifId = u.SinifId,
                                    UrunKodu = u.UrunKodu,
                                    Adres = u.Adres,
                                    BolgeId = u.BolgeId,
                                    IlId = u.IlId,
                                    IlceId = u.IlceId,
                                    UrunAdi = u.UrunAdi,
                                    Puan = y.Puan,
                                    Fiyat = f.Fiyat,
                                    Resim = r.Resim,
                                    DilId = d.DilId,
                                    Link = d.Link,
                                    KampanyaId = k.KampanyaId,
                                }).ToList();

                return products;
            }
        }
    }
}