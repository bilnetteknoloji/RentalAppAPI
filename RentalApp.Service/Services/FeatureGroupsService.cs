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
    public class FeatureGroupsService : IFeatureGroupsService
    {
        private readonly IRepository<Ozellikgruplar> _ozelliklerGrupRepo;
        private readonly IRepository<OzellikgruplarDil> _ozelliklerGrupDilRepo;
        private readonly IRepository<OzelliklerDil> _ozelliklerDilRepo;
        private readonly IRepository<Ozellikler> _ozelliklerRepo;

        public FeatureGroupsService(IRepository<Ozellikgruplar> ozelliklerGrupRepo, IRepository<OzellikgruplarDil> ozelliklerGrupDilRepo, IRepository<OzelliklerDil> ozelliklerDilRepo, IRepository<Ozellikler> ozelliklerRepo)
        {
            _ozelliklerGrupRepo = ozelliklerGrupRepo;
            _ozelliklerGrupDilRepo = ozelliklerGrupDilRepo;
            _ozelliklerDilRepo = ozelliklerDilRepo;
            _ozelliklerRepo = ozelliklerRepo;
        }

        #region ÖzellikGruplar

        public Ozellikgruplar GetOzellikgruplarById(int OzellikgrupId)
        {
            var ozellikg = _ozelliklerGrupRepo.GetBy(x => x.OzellikgrupId.Equals(OzellikgrupId));
            return ozellikg;
        }
        public IList<Ozellikgruplar> GetAllOzellikgruplar(int OzellikgrupId)
        {
            return _ozelliklerGrupRepo.GetAllByQ(x => x.OzellikgrupId.Equals(OzellikgrupId)).ToList();
        }
        public bool DeleteOzellikgruplarById(Ozellikgruplar ozellikgruplar)
        {
            try
            {
                var result = _ozelliklerGrupRepo.Delete(ozellikgruplar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public Ozellikgruplar UpdateOzellikgruplar(Ozellikgruplar ozellikgruplar)
        {
            return _ozelliklerGrupRepo.Update(ozellikgruplar);
        }
        public bool InsertOzellikgruplar(Ozellikgruplar ozellikgruplar)
        {
            var res = _ozelliklerGrupRepo.Insert(ozellikgruplar);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IList<Ozellikgruplar> GetAllOzellikgruplars()
        {
            return _ozelliklerGrupRepo.GetAll().ToList();
        }

        #endregion

        #region ÖzellikGrupDiller
        public OzellikgruplarDil GetOzellikgruplarDilById(int OzellikgrupDilId)
        {
            var ozellikg = _ozelliklerGrupDilRepo.GetBy(x => x.OzellikgrupDilId.Equals(OzellikgrupDilId));
            return ozellikg;
        }
        public IList<OzellikgruplarDil> GetAllOzellikgruplarDil(int OzellikgrupDilId)
        {
            return _ozelliklerGrupDilRepo.GetAllByQ(x => x.OzellikgrupDilId.Equals(OzellikgrupDilId)).ToList();
        }
        public bool DeleteOzellikgruplarDilById(OzellikgruplarDil ozellikgruplarDil)
        {
            try
            {
                var result = _ozelliklerGrupDilRepo.Delete(ozellikgruplarDil);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }

        }
        public OzellikgruplarDil UpdateOzellikgruplarDil(OzellikgruplarDil ozellikgruplarDil)
        {
            return _ozelliklerGrupDilRepo.Update(ozellikgruplarDil);
        }
        public bool InsertOzellikgruplarDil(OzellikgruplarDil ozellikgruplarDil)
        {
            var res = _ozelliklerGrupDilRepo.Insert(ozellikgruplarDil);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IList<OzellikgruplarDil> GetAllOzellikgruplarDils()
        {
            return _ozelliklerGrupDilRepo.GetAll().ToList();
        }
        #endregion

        #region ÖzelliklerDil
        public OzelliklerDil GetOzelliklerDilById(int OzellikDilId)
        {
            var ozellikDil = _ozelliklerDilRepo.GetBy(x => x.OzellikDilId.Equals(OzellikDilId));
            return ozellikDil;
        }
        public IList<OzelliklerDil> GetAllOzelliklerDil(int OzellikDilId)
        {
            return _ozelliklerDilRepo.GetAllByQ(x => x.OzellikDilId.Equals(OzellikDilId)).ToList();
        }
        public bool DeleteOzelliklerDilById(OzelliklerDil ozelliklerDil)
        {
            try
            {
                var result = _ozelliklerDilRepo.Delete(ozelliklerDil);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public OzelliklerDil UpdateOzelliklerDil(OzelliklerDil ozelliklerDil)
        {
            return _ozelliklerDilRepo.Update(ozelliklerDil);
        }
        public bool InsertOzelliklerDil(OzelliklerDil ozelliklerDil)
        {
            var res = _ozelliklerDilRepo.Insert(ozelliklerDil);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IList<OzelliklerDil> GetAllOzelliklerDils()
        {
            return _ozelliklerDilRepo.GetAll().ToList();
        }
        #endregion

        #region Özellikler
        public Ozellikler GetOzelliklerById(int OzellikId)
        {
            var ozellik = _ozelliklerRepo.GetBy(x => x.OzellikId.Equals(OzellikId));
            return ozellik;
        }
        public IList<Ozellikler> GetAllOzellikler(int OzellikId)
        {
            return _ozelliklerRepo.GetAllByQ(x => x.OzellikId.Equals(OzellikId)).ToList();
        }
        public bool DeleteOzelliklerById(Ozellikler ozellikler)
        {
            try
            {
                var result = _ozelliklerRepo.Delete(ozellikler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public Ozellikler UpdateOzellikler(Ozellikler ozellikler)
        {
            return _ozelliklerRepo.Update(ozellikler);
        }
        public bool InsertOzellikler(Ozellikler ozellikler)
        {
            var res = _ozelliklerRepo.Insert(ozellikler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IList<Ozellikler> GetAllOzelliklers()
        {
            return _ozelliklerRepo.GetAll().ToList();
        }
        #endregion

    }
}
