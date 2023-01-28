using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl.Vw
{
    public interface IVwFullDaysService
    {
        Vwdolugunler GetVwdolugunlerById (int RezervasyonId);
        IList<Vwdolugunler> GetAllVwdolugunler(int RezervasyonId);
        bool DeleteVwdolugunlerById(Vwdolugunler vwdolugunler);
        Vwdolugunler UpdateVwdolugunler (Vwdolugunler vwdolugunler);
        bool InsertVwdolugunler (Vwdolugunler vwdolugunler);
        IList<Vwdolugunler> GetAllVwdolugunlers();
    }
}
