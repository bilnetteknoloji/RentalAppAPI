using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl.Products
{
    public interface IOccupancyCalendarService
    {
        DolulukTakvimi GetDolulukTakvimiById(int DolulukId);
        IList<DolulukTakvimi> GetAllDolulukTakvimi(int DolulukId);
        bool DeleteDolulukTakvimiById(DolulukTakvimi dolulukTakvimi);
        DolulukTakvimi UpdateDolulukTakvimi(DolulukTakvimi dolulukTakvimi);
        bool InsertDolulukTakvimi (DolulukTakvimi dolulukTakvimi);
        IList<DolulukTakvimi> GetAllDolulukTakvimis();
    }
}
