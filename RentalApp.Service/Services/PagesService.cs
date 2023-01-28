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
    public class PagesService : IPagesService
    {
        private readonly IRepository<Sayfalar> _sayfalarRepo;

        public PagesService(IRepository<Sayfalar> sayfalarRepo)
        {
            _sayfalarRepo = sayfalarRepo;
        }

        public bool DeleteSayfalar(Sayfalar sayfalar)
        {
            try
            {
                var result = _sayfalarRepo.Delete(sayfalar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public IList<Sayfalar> GetAllSayfalar(int SayfaId)
        {
            return _sayfalarRepo.GetAllByQ(x => x.SayfaId.Equals(SayfaId)).ToList();
        }
        public IList<Sayfalar> GetAllSayfalars()
        {
            return _sayfalarRepo.GetAll().ToList();
        }
        public Sayfalar GetSayfalarById(int SayfaId)
        {
            var Sayfa = _sayfalarRepo.GetBy(x => x.SayfaId.Equals(SayfaId));
            return Sayfa;
        }
        public bool InsertSayfalar(Sayfalar sayfalar)
        {
            var res = _sayfalarRepo.Insert(sayfalar);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Sayfalar UpdateSayfalar(Sayfalar sayfalar)
        {
            return _sayfalarRepo.Update(sayfalar);
        }


    }
}
