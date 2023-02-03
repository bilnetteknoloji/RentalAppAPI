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
    public class RentalPicturesService : IRentalPicturesService
    {
        private readonly IRepository<KiralamaResimler> _kiralamaResimlerRepo;

        public RentalPicturesService(IRepository<KiralamaResimler> kiralamaResimlerRepo)
        {
            _kiralamaResimlerRepo = kiralamaResimlerRepo;
        }

        public bool DeleteKiralamaResimlerById(KiralamaResimler kiralamaResimler)
        {
            try
            {
                var result = _kiralamaResimlerRepo.Delete(kiralamaResimler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public IList<KiralamaResimler> GetAllKiralamaResimler(int TalepresimId)
        {
            return _kiralamaResimlerRepo.GetAllByQ(x => x.TalepresimId.Equals(TalepresimId)).ToList();
        }

        public IList<KiralamaResimler> GetAllKiralamaResims()
        {
            return _kiralamaResimlerRepo.GetAll().ToList();
        }

        public KiralamaResimler GetKiralamaResimlerById(int TalepresimId)
        {
            var UrunlerYorum = _kiralamaResimlerRepo.GetBy(x => x.TalepresimId.Equals(TalepresimId));
            return UrunlerYorum;
        }

        public bool InsertKiralamaResimler(KiralamaResimler kiralamaResimler)
        {
            var res = _kiralamaResimlerRepo.Insert(kiralamaResimler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public KiralamaResimler UpdateKiralamaResimler(KiralamaResimler kiralamaResimler)
        {
            return _kiralamaResimlerRepo.Update(kiralamaResimler);
        }
    }
}
