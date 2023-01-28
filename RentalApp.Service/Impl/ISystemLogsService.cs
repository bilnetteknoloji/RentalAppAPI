using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface ISystemLogsService
    {
        Sistemloglari GetSistemloglariById (int SistemlogId);
        IList<Sistemloglari> GetAllSistemloglari (int SistemlogId);
        bool DeleteSistemloglari (Sistemloglari sistemloglari);
        Sistemloglari UpdateSistemloglari (Sistemloglari sistemloglari);
        bool InsertSistemloglari (Sistemloglari sistemloglari);
        IList<Sistemloglari> GetAllSistemloglaris();
    }
}
