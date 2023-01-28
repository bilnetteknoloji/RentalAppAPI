using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl.Vw
{
    public interface IVwProductService
    {
        Vwurunler GetVwUrunlerById(int urunid);
        IList<Vwurunler> GetAllVwUrunler(int urunId);
        bool DeleteVwUrunlerById(Vwurunler vwurunler);
        Vwurunler UpdateVwUrunler(Vwurunler vwurunler);
        bool InsertVwUrunler(Vwurunler vwurunler);
        IList<Vwurunler> GetAllVwUrunlers();
    }
}
