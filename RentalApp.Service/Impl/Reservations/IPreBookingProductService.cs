using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl.Reservations
{
    public interface IPreBookingProductService
    {
        OnrezervasyonlarUrun GetOnrezervasyonlarUrunById(int OnrezervasyonurunId);
        IList<OnrezervasyonlarUrun> GetAllOnrezervasyonlarUrun(int OnrezervasyonurunId);
        bool DeleteOnrezervasyonlarUrunById(OnrezervasyonlarUrun onrezervasyonlarUrun);
        OnrezervasyonlarUrun UpdateOnrezervasyonlarUrun(OnrezervasyonlarUrun onrezervasyonlarUrun);
        bool InsertOnrezervasyonlarUrun(OnrezervasyonlarUrun onrezervasyonlarUrun);
        IList<OnrezervasyonlarUrun> GetAllOnrezervasyonlarUruns();
    }
}
