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
    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Kategoriler> _kategorilerRepo;

        public CategoriesService(IRepository<Kategoriler> kategorilerRepo)
        {
            _kategorilerRepo = kategorilerRepo;
        }

        public bool DeleteKategorilerById(Kategoriler kategoriler)
        {
            try
            {
                var result = _kategorilerRepo.Delete(kategoriler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public IList<Kategoriler> GetAllKategoriler(int KategoriId)
        {
            return _kategorilerRepo.GetAllByQ(x => x.KategoriId.Equals(KategoriId)).ToList();
        }

        public IList<Kategoriler> GetAllKategorilers()
        {
            return _kategorilerRepo.GetAll().ToList();
        }

        public Kategoriler GetKategorilerById(int KategoriId)
        {
            var kategoriler = _kategorilerRepo.GetBy(x => x.KategoriId.Equals(KategoriId));
            return kategoriler;
        }

        public bool InsertKategoriler(Kategoriler kategoriler)
        {
            var res = _kategorilerRepo.Insert(kategoriler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Kategoriler UpdateKategoriler(Kategoriler kategoriler)
        {
            return _kategorilerRepo.Update(kategoriler);
        }
    }
}
