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
    public class LanguagesService : ILanguagesService
    {
        private readonly IRepository<Diller> _dillerRepo;
        private readonly IRepository<UrunlerDil> _urunlerDilRepo;

        public LanguagesService(IRepository<Diller> dillerRepo, IRepository<UrunlerDil> urunlerDilRepo)
        {
            _dillerRepo = dillerRepo;
            _urunlerDilRepo = urunlerDilRepo;
        }

        #region Diller
        bool ILanguagesService.DeleteDillerById(Diller diller)
        {
            try
            {
                var result = _dillerRepo.Delete(diller);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);
            }

        }

        IList<Diller> ILanguagesService.GetAllDiller(int DilId)
        {
            return _dillerRepo.GetAllByQ(x => x.DilId.Equals(DilId)).ToList();
        }

        IList<Diller> ILanguagesService.GetAllDillers()
        {
            return _dillerRepo.GetAll().ToList();
        }

        Diller ILanguagesService.GetDillerById(int DilId)
        {
            var Dil = _dillerRepo.GetBy(x => x.DilId.Equals(DilId));
            return Dil;
        }

        bool ILanguagesService.InsertDiller(Diller diller)
        {
            var res = _dillerRepo.Insert(diller);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Diller ILanguagesService.UpdateDiller(Diller diller)
        {
            return _dillerRepo.Update(diller);
        }
        #endregion

        #region UrunlerDil
        public IList<UrunlerDil> GetAllUrunlerDil(int urundilid)
        {
            var result = _urunlerDilRepo.GetAll().ToList();

            return result;
            //try catch içine konmalı patlarsa diye
        }

        public UrunlerDil GetUrunlerDilById(int urundilid)
        {
            var UrunlerDil = _urunlerDilRepo.GetBy(x => x.DilId.Equals(urundilid));
            return UrunlerDil;
        }

        public bool InsertUrunlerDil(UrunlerDil urunlerDil)
        {
            var res = _urunlerDilRepo.Insert(urunlerDil);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UrunlerDil UpdateUrunlerDil (UrunlerDil urunlerDil)
        {
            return _urunlerDilRepo.Update(urunlerDil);
        }


        public IList<UrunlerDil> GetUrunlerDilByUDilId(int urundilid)
        {
            var UrunlerDil = _urunlerDilRepo.GetAllByQ(x => x.UrunDilId.Equals(urundilid)).ToList();
            return UrunlerDil;
        }

        public bool DeleteUrunlerDil(UrunlerDil urunlerDil)
        {
            try
            {
                var result = _urunlerDilRepo.Delete(urunlerDil);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public IList<UrunlerDil> GetAllUrunlerDils()
        {
            return _urunlerDilRepo.GetAll().ToList();
        }
        #endregion


    }
}
