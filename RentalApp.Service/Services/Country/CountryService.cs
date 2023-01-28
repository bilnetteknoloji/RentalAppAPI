using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl;

namespace RentalApp.Service.Services
{
    public class CountryService : ICountryService
    {
        private readonly IRepository<Ulkeler> _ulkelerRepo;
        private readonly IRepository<Iller> _illerRepo;
        private readonly IRepository<Ilceler> _ilceRepo;
        private readonly IRepository<Bolgeler> _bolgeRepo;

        public CountryService(IRepository<Ulkeler> ulkelerRepo, IRepository<Iller> illerRepo, IRepository<Ilceler> ilceRepo, IRepository<Bolgeler> bolgeRepo)
        {
            this._ulkelerRepo = ulkelerRepo;
            _illerRepo = illerRepo;
            _ilceRepo = ilceRepo;
            _bolgeRepo = bolgeRepo;
        }

        #region Ulkeler
        public bool DeleteUlke(Ulkeler Ulke)
        {
            try
            {
                var result = _ulkelerRepo.Delete(Ulke);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public Ulkeler GetUlkeById(int ulkeId)
        {
            var ulke = _ulkelerRepo.GetBy(x => x.UlkeId.Equals(ulkeId));

            return ulke;
        }
        public IList<Ulkeler> GetAllUlke(int ulkeId)
        {
            return _ulkelerRepo.GetAllByQ(x => x.UlkeId.Equals(ulkeId)).ToList();
        }
        public IList<Ulkeler> GetAllUlkes()
        {
            var result = _ulkelerRepo.GetAll().ToList();

            return result;
        }
        public bool InsertUlke(Ulkeler ulke)
        {
            var res = _ulkelerRepo.Insert(ulke);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Ulkeler UpdateUlke(Ulkeler Ulke)
        {
            return _ulkelerRepo.Update(Ulke);
        }
        #endregion

        #region Bolgeler
        public bool DeleteBolgeler(Bolgeler bolgeler)
        {
            try
            {
                var result = _bolgeRepo.Delete(bolgeler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public Bolgeler GetBolgelerById(int BolgeId)
        {
            var bolge = _bolgeRepo.GetBy(x => x.BolgeId.Equals(BolgeId));
            return bolge;
        }

        public IList<Bolgeler> GetAllBolgeler(int BolgeId)
        {
            return _bolgeRepo.GetAllByQ(x => x.BolgeId.Equals(BolgeId)).ToList();
        }

        public bool InsertBolgeler(Bolgeler bolgeler)
        {
            var res = _bolgeRepo.Insert(bolgeler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Bolgeler UpdateBolgeler(Bolgeler bolgeler)
        {
            return _bolgeRepo.Update(bolgeler);
        }
        public IList<Bolgeler> GetAllBolgelers()
        {
            return _bolgeRepo.GetAll().ToList();
        }
        #endregion

        #region Iller
        public bool DeleteIller(Iller ıller)
        {
            try
            {
                var result = _illerRepo.Delete(ıller);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public IList<Iller> GetAllIller(int IlId)
        {
            return _illerRepo.GetAllByQ(x => x.IlId.Equals(IlId)).ToList();
        }
        public Iller GetIllerById(int IlId)
        {
            var ıller = _illerRepo.GetBy(x => x.IlId.Equals(IlId));
            return ıller;
        }
        public bool InsertIller(Iller ıller)
        {
            var res = _illerRepo.Insert(ıller);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Iller UpdateIller(Iller ıller)
        {
            return _illerRepo.Update(ıller);
        }
        public IList<Iller> GetAllIllers()
        {
            return _illerRepo.GetAll().ToList();
        }
        #endregion

        #region ILceler
        public bool DeleteIlceler(Ilceler ılceler)
        {
            try
            {
                var result = _ilceRepo.Delete(ılceler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public IList<Ilceler> GetAllIlceler(int IlceId)
        {
            return _ilceRepo.GetAllByQ(x => x.IlceId.Equals(IlceId)).ToList();
        }
        public IList<Ilceler> GetAllIlcelers()
        {
            return _ilceRepo.GetAll().ToList();
        }
        public Ilceler GetIlcelerById(int IlceId)
        {
            var ılce = _ilceRepo.GetBy(x => x.IlId.Equals(IlceId));
            return ılce;
        }

        public Ilceler UpdateIlceler(Ilceler ılceler)
        {
            return _ilceRepo.Update(ılceler);
        }
        public bool InsertIlceler(Ilceler ılceler)
        {
            var res = _ilceRepo.Insert(ılceler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        public IList<Ilceler> GetAllIlceByBolge(int bolgeId)
        {
            var iller = _illerRepo.GetAllByQ(x => x.BolgeId.Equals(bolgeId)).Select(y => y.IlId).ToList();//parametre olarak alınan bolgenin içindeki illerin sadece ID lerini çektim

            return _ilceRepo.GetAllByQ(x => iller.Contains(x.IlId)).ToList();
        }

        public IList<Iller> GetIlByBolgeId(int bolgeId)
        {

            var iller = _illerRepo.GetAllByQ(x => x.BolgeId.Equals(bolgeId)).ToList();
            return iller;
        }

        Iller ICountryService.UpdateIlceler(Ilceler ılceler)
        {
            throw new NotImplementedException();
        }
    }
}