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
    public class OccupancyCalendarService : IOccupancyCalendarService
    {
        private readonly IRepository<DolulukTakvimi> _dolulukTakvimiRepo;

        public OccupancyCalendarService(IRepository<DolulukTakvimi> dolulukTakvimiRepo)
        {
            _dolulukTakvimiRepo = dolulukTakvimiRepo;
        }

        public bool DeleteDolulukTakvimiById(DolulukTakvimi dolulukTakvimi)
        {
            try
            {
                var result = _dolulukTakvimiRepo.Delete(dolulukTakvimi);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);
            }
        }

        public IList<DolulukTakvimi> GetAllDolulukTakvimi(int DolulukId)
        {
            return _dolulukTakvimiRepo.GetAllByQ(x => x.DolulukId.Equals(DolulukId)).ToList();
        }

        public IList<DolulukTakvimi> GetAllDolulukTakvimis()
        {
            return _dolulukTakvimiRepo.GetAll().ToList();
        }

        public DolulukTakvimi GetDolulukTakvimiById(int DolulukId)
        {
            var Dolugunler = _dolulukTakvimiRepo.GetBy(x => x.DolulukId.Equals(DolulukId));
            return Dolugunler;
        }

        public bool InsertDolulukTakvimi(DolulukTakvimi dolulukTakvimi)
        {
            var res = _dolulukTakvimiRepo.Insert(dolulukTakvimi);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DolulukTakvimi UpdateDolulukTakvimi(DolulukTakvimi dolulukTakvimi)
        {
            return _dolulukTakvimiRepo.Update(dolulukTakvimi);
        }
    }
}
