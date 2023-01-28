using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl.Reservations
{
    public interface IPreBookingsService
    {
        Onrezervasyonlar GetOnrezervasyonlarById(int OnrezervasyonId);
        IList<Onrezervasyonlar> GetAllOnrezervasyonlar(int OnrezervasyonId);
        bool DeleteOnrezervasyonlarById(Onrezervasyonlar onrezervasyonlar);
        Onrezervasyonlar UpdateOnrezervasyonlar(Onrezervasyonlar onrezervasyonlar);
        bool InsertOnrezervasyonlar(Onrezervasyonlar onrezervasyonlar);
        IList<Onrezervasyonlar> GetAllOnrezervasyonlars();
    }
}
