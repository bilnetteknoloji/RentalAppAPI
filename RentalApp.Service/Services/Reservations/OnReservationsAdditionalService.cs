using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl.Reservations;


namespace RentalApp.Service.Services.Reservations
{
    public class OnReservationsAdditionalService : IOnReservationsAdditionalService
    {
        private readonly IRepository<OnrezervasyonlarEkhizmet> _onRezervasyonEkhizmetRepo;

        public OnReservationsAdditionalService(IRepository<OnrezervasyonlarEkhizmet> onRezervasyonEkhizmetRepo)
        {
            _onRezervasyonEkhizmetRepo = onRezervasyonEkhizmetRepo;
        }

        public bool DeleteOnrezervasyonlarEkhizmetById(OnrezervasyonlarEkhizmet onrezervasyonlarEkhizmet)
        {
            try
            {
                var result = _onRezervasyonEkhizmetRepo.Delete(onrezervasyonlarEkhizmet);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public IList<OnrezervasyonlarEkhizmet> GetAllOnrezervasyonlarEkhizmet(int OnrezervasyonekhizmetId)
        {
            return _onRezervasyonEkhizmetRepo.GetAllByQ(x => x.OnrezervasyonekhizmetId.Equals(OnrezervasyonekhizmetId)).ToList();
        }

        public IList<OnrezervasyonlarEkhizmet> GetAllOnrezervasyonlarEkhizmets()
        {
            return _onRezervasyonEkhizmetRepo.GetAll().ToList();
        }

        public OnrezervasyonlarEkhizmet GetOnrezervasyonlarEkhizmetById(int OnrezervasyonekhizmetId)
        {
            var UrunlerYorum = _onRezervasyonEkhizmetRepo.GetBy(x => x.OnrezervasyonekhizmetId.Equals(OnrezervasyonekhizmetId));
            return UrunlerYorum;
        }

        public bool InsertOnrezervasyonlarEkhizmet(OnrezervasyonlarEkhizmet onrezervasyonlarEkhizmet)
        {
            var res = _onRezervasyonEkhizmetRepo.Insert(onrezervasyonlarEkhizmet);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public OnrezervasyonlarEkhizmet UpdateOnrezervasyonlarEkhizmet(OnrezervasyonlarEkhizmet onrezervasyonlarEkhizmet)
        {
            return _onRezervasyonEkhizmetRepo.Update(onrezervasyonlarEkhizmet);
        }
    }
}
