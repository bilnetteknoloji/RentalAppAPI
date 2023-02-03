using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Urunler> _urunlerRepo;


        public ProductService(IRepository<Urunler> urunlerRepo)
        {
            _urunlerRepo = urunlerRepo;
        }

        public bool DeleteUrunlerById(Urunler urunler)
        {
            try
            {
                var result = _urunlerRepo.Delete(urunler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);
            }
        }

        public Urunler GetUrunlerByUrunKod(string UrunKodu)
        {
            var Urunler = _urunlerRepo.GetBy(x => x.UrunKodu.Equals(UrunKodu));
            return Urunler;
        }

        public IList<Urunler> GetAllUrunler(int urunid)
        {
            return _urunlerRepo.GetAllByQ(x => x.UrunId.Equals(urunid)).ToList();
        }

        public IList<Urunler> GetAllUrunlers()
        {
            return _urunlerRepo.GetAll().ToList();
        }

        public Urunler GetUrunlerById(int urunid)
        {
            var Urunler = _urunlerRepo.GetBy(x => x.UrunId.Equals(urunid));
            return Urunler;
        }

        public bool InsertUrunler(Urunler urunler)
        {
            var urun = _urunlerRepo.Insert(urunler);
            if (urun != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Urunler UpdateUrun(Urunler urunler)
        {
            return _urunlerRepo.Update(urunler);
        }
    }
}
