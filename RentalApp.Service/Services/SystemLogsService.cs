using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Services
{
    public class SystemLogsService : ISystemLogsService
    {
        private readonly IRepository<Sistemloglari> _sistemLoglariRepo;

        public SystemLogsService(IRepository<Sistemloglari> sistemLoglariRepo)
        {
            _sistemLoglariRepo = sistemLoglariRepo;
        }
        public bool DeleteSistemloglari(Sistemloglari sistemloglari)
        {
            try
            {
                var result = _sistemLoglariRepo.Delete(sistemloglari);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public IList<Sistemloglari> GetAllSistemloglari(int SistemlogId)
        {
            return _sistemLoglariRepo.GetAllByQ(x => x.SistemlogId.Equals(SistemlogId)).ToList();
        }
        public IList<Sistemloglari> GetAllSistemloglaris()
        {
            return _sistemLoglariRepo.GetAll().ToList();
        }
        public Sistemloglari GetSistemloglariById(int SistemlogId)
        {
            var sistemlog = _sistemLoglariRepo.GetBy(x => x.SistemlogId.Equals(SistemlogId));
            return sistemlog;
        }
        public bool InsertSistemloglari(Sistemloglari sistemloglari)
        {
            var res = _sistemLoglariRepo.Insert(sistemloglari);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Sistemloglari UpdateSistemloglari(Sistemloglari sistemloglari)
        {
            return _sistemLoglariRepo.Update(sistemloglari);
        }


    }
}
