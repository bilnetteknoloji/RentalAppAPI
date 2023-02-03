using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl.Reservations;


namespace RentalApp.Service.Services.Reservations
{
    public class PreBookingsService : IPreBookingsService
    {
        private readonly IRepository<Onrezervasyonlar> _onRezervasyonlarRepo;

        public PreBookingsService(IRepository<Onrezervasyonlar> onRezervasyonlarRepo)
        {
            _onRezervasyonlarRepo = onRezervasyonlarRepo;
        }

        public bool DeleteOnrezervasyonlarById(Onrezervasyonlar onrezervasyonlar)
        {
            try
            {
                var result = _onRezervasyonlarRepo.Delete(onrezervasyonlar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public IList<Onrezervasyonlar> GetAllOnrezervasyonlar(int OnrezervasyonId)
        {
            return _onRezervasyonlarRepo.GetAllByQ(x => x.OnrezervasyonId.Equals(OnrezervasyonId)).ToList();
        }

        public IList<Onrezervasyonlar> GetAllOnrezervasyonlars()
        {
            return _onRezervasyonlarRepo.GetAll().ToList();
        }

        public Onrezervasyonlar GetOnrezervasyonlarById(int OnrezervasyonId)
        {
            var onrezervasyon = _onRezervasyonlarRepo.GetBy(x => x.OnrezervasyonId.Equals(OnrezervasyonId));
            return onrezervasyon;
        }

        public bool InsertOnrezervasyonlar(Onrezervasyonlar onrezervasyonlar)
        {
            var res = _onRezervasyonlarRepo.Insert(onrezervasyonlar);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Onrezervasyonlar UpdateOnrezervasyonlar(Onrezervasyonlar onrezervasyonlar)
        {
            return _onRezervasyonlarRepo.Update(onrezervasyonlar);
        }
    }
}
