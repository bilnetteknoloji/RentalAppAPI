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
    public class CurrenciesService : ICurrenciesService
    {
        private readonly IRepository<ParaBirimler> _paraBirimlerRepo;

        public CurrenciesService(IRepository<ParaBirimler> paraBirimlerRepo)
        {
            _paraBirimlerRepo = paraBirimlerRepo;
        }

        public bool DeleteParaBirimler(ParaBirimler paraBirimler)
        {
            try
            {
                var result = _paraBirimlerRepo.Delete(paraBirimler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public IList<ParaBirimler> GetAllParaBirimler(int BirimId)
        {
            return _paraBirimlerRepo.GetAllByQ(x => x.BirimId.Equals(BirimId)).ToList();
        }
        public ParaBirimler GetParaBirimlerById(int BirimId)
        {
            var parabirim = _paraBirimlerRepo.GetBy(x => x.BirimId.Equals(BirimId));
            return parabirim;
        }
        public IList<ParaBirimler> GetAllParaBirimlers()
        {
            return _paraBirimlerRepo.GetAll().ToList();
        }
        public bool InsertParaBirimler(ParaBirimler paraBirimler)
        {
            var res = _paraBirimlerRepo.Insert(paraBirimler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ParaBirimler UpdateParaBirimler(ParaBirimler paraBirimler)
        {
            return _paraBirimlerRepo.Update(paraBirimler);
        }


    }
}
