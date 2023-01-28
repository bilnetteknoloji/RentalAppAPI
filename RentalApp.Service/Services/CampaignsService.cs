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
    public class CampaignsService : ICampaignsService
    {
        private readonly IRepository<Kampanyalar> _kampanyalarRepo;
        private readonly IRepository<UrunlerKampanyalar> _urunlerKampanyaRepo;
        private readonly IRepository<Vwkampanyalar> _vwkampanyaRepo;

        public CampaignsService(IRepository<Kampanyalar> kampanyalarRepo, IRepository<UrunlerKampanyalar> urunlerKampanyaRepo, IRepository<Vwkampanyalar> vwkampanyaRepo)
        {
            _kampanyalarRepo = kampanyalarRepo;
            _urunlerKampanyaRepo = urunlerKampanyaRepo;
            _vwkampanyaRepo = vwkampanyaRepo;
        }

        #region UrunlerKampanyalar

        public UrunlerKampanyalar GetUrunlerKampanyalarById(int KampanyaId)
        {
            var Urunlerkampanya = _urunlerKampanyaRepo.GetBy(x => x.UrunKampanyaId.Equals(KampanyaId));
            return Urunlerkampanya;
        }

        public IList<UrunlerKampanyalar> GetAllUrunlerKampanyalar(int KampanyaId)
        {
            return _urunlerKampanyaRepo.GetAllByQ(x => x.KampanyaId.Equals(KampanyaId)).ToList();
        }

        public IList<UrunlerKampanyalar> GetAllUrunlerKampanyalars()
        {
            return _urunlerKampanyaRepo.GetAll().ToList();
        }

        public bool DeleteUrunlerKampanyalarById(UrunlerKampanyalar urunlerKampanyalar)
        {
            try
            {
                var result = _urunlerKampanyaRepo.Delete(urunlerKampanyalar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool InsertUrunlerKampanyalar(UrunlerKampanyalar urunlerKampanyalar)
        {
            var res = _urunlerKampanyaRepo.Insert(urunlerKampanyalar);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UrunlerKampanyalar UpdateUrunlerKampanyalar(UrunlerKampanyalar urunlerKampanyalar)
        {
            return _urunlerKampanyaRepo.Update(urunlerKampanyalar);
        }
        #endregion

        #region Kampanyalar
        public bool DeleteKampanyalarById(Kampanyalar kampanyalar)
        {
            try
            {
                var result = _kampanyalarRepo.Delete(kampanyalar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);
            }
        }

        public IList<Kampanyalar> GetAllKampanyalar(int KampanyaId)
        {
            return _kampanyalarRepo.GetAllByQ(x => x.KampanyaId.Equals(KampanyaId)).ToList();
        }

        public IList<Kampanyalar> GetAllKampanyalars()
        {
            return _kampanyalarRepo.GetAll().ToList();
        }

        public Kampanyalar GetKampanyalarById(int KampanyaId)
        {
            var kampanya = _kampanyalarRepo.GetBy(x => x.KampanyaId.Equals(KampanyaId));
            return kampanya;
        }

        public bool InsertKampanyalar(Kampanyalar kampanyalar)
        {
            var res = _kampanyalarRepo.Insert(kampanyalar);
            if (res != null)
            {
                return true;
            }
            else { return false; }
        }

        public Kampanyalar UpdateKampanyalar(Kampanyalar kampanyalar)
        {
            return _kampanyalarRepo.Update(kampanyalar);
        }

        #endregion

        #region VwKampanyalar
        public Vwkampanyalar GetVwkampanyalarById(int KampanyaId)
        {
            var Urunlerkamp = _vwkampanyaRepo.GetBy(x => x.KampanyaId.Equals(KampanyaId));
            return Urunlerkamp;
        }

        public IList<Vwkampanyalar> GetAllVwkampanyalar(int KampanyaId)
        {
            return _vwkampanyaRepo.GetAllByQ(x => x.KampanyaId.Equals(KampanyaId)).ToList();
        }

        public bool DeleteVwkampanyalarById(Vwkampanyalar vwkampanyalar)
        {
            try
            {
                var result = _vwkampanyaRepo.Delete(vwkampanyalar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public Vwkampanyalar UpdateVwkampanyalar(Vwkampanyalar vwkampanyalar)
        {
            return _vwkampanyaRepo.Update(vwkampanyalar);
        }

        public bool InsertVwkampanyalar(Vwkampanyalar vwkampanyalar)
        {
            var res = _vwkampanyaRepo.Insert(vwkampanyalar);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IList<Vwkampanyalar> GetAllVwkampanyalars()
        {
            return _vwkampanyaRepo.GetAll().ToList();
        }
        #endregion

    }
}
