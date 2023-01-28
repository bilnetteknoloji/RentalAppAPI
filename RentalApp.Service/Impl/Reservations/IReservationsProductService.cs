using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl.Reservations
{
    public interface IReservationsProductService
    {
        RezervasyonlarUrun GetRezervasyonlarUrunById(int RezervasyonurunId);
        IList<RezervasyonlarUrun> GetAllRezervasyonlarUrun (int RezervasyonurunId);
        bool DeleteRezervasyonlarUrun (RezervasyonlarUrun rezervasyonlarUrun);
        RezervasyonlarUrun UpdateRezervasyonlarUrun (RezervasyonlarUrun rezervasyonlarUrun);
        bool InsertRezervasyonlarUrun (RezervasyonlarUrun rezervasyonlarUrun);
        IList<RezervasyonlarUrun> GetAllRezervasyonlarUruns();
    }
}
