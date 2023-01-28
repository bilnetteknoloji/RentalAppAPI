using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl.Products
{
    public interface IProductService
    {
        Urunler GetUrunlerByUrunKod(string UrunKodu);
        Urunler GetUrunlerById(int urunid);
        IList<Urunler> GetAllUrunler(int urunid);
        IList<Urunler> GetAllUrunlers();
        bool DeleteUrunlerById(Urunler urunler);
        Urunler UpdateUrun(Urunler urunler);
        bool InsertUrunler(Urunler urunler);
    }
}
