using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl.Vw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Services.Vw
{
    public class VwFullDaysService : IVwFullDaysService
    {
        private readonly IRepository<Vwdolugunler> _vwdolugunlerRepo;

        public VwFullDaysService(IRepository<Vwdolugunler> vwdolugunlerRepo)
        {
            _vwdolugunlerRepo = vwdolugunlerRepo;
        }

        public bool DeleteVwdolugunlerById(Vwdolugunler vwdolugunler)
        {
            try
            {
                var result = _vwdolugunlerRepo.Delete(vwdolugunler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);
            }
        }

        public IList<Vwdolugunler> GetAllVwdolugunler(int RezervasyonId)
        {
            return _vwdolugunlerRepo.GetAllByQ(x => x.RezervasyonId.Equals(RezervasyonId)).ToList();
        }

        public IList<Vwdolugunler> GetAllVwdolugunlers()
        {
            return _vwdolugunlerRepo.GetAll().ToList();
        }

        public Vwdolugunler GetVwdolugunlerById(int RezervasyonId)
        {
            var Dolugunler = _vwdolugunlerRepo.GetBy(x => x.RezervasyonId.Equals(RezervasyonId));
            return Dolugunler;
        }

        public bool InsertVwdolugunler(Vwdolugunler vwdolugunler)
        {
            var res = _vwdolugunlerRepo.Insert(vwdolugunler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Vwdolugunler UpdateVwdolugunler(Vwdolugunler vwdolugunler)
        {
            return _vwdolugunlerRepo.Update(vwdolugunler);
        }
    }
}
