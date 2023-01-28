using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl.Reservations;


namespace RentalApp.Service.Services.Reservations
{
    public class PreBookingProductService : IPreBookingProductService
    {
        private readonly IRepository<OnrezervasyonlarUrun> _onRezervasyonUrunRepo;

        public PreBookingProductService(IRepository<OnrezervasyonlarUrun> onRezervasyonUrunRepo)
        {
            _onRezervasyonUrunRepo = onRezervasyonUrunRepo;
        }

        public bool DeleteOnrezervasyonlarUrunById(OnrezervasyonlarUrun onrezervasyonlarUrun)
        {
            try
            {
                var result = _onRezervasyonUrunRepo.Delete(onrezervasyonlarUrun);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);
            }
        }

        public IList<OnrezervasyonlarUrun> GetAllOnrezervasyonlarUrun(int OnrezervasyonurunId)
        {
            return _onRezervasyonUrunRepo.GetAllByQ(x => x.OnrezervasyonurunId.Equals(OnrezervasyonurunId)).ToList();
        }

        public IList<OnrezervasyonlarUrun> GetAllOnrezervasyonlarUruns()
        {
            return _onRezervasyonUrunRepo.GetAll().ToList();
        }

        public OnrezervasyonlarUrun GetOnrezervasyonlarUrunById(int OnrezervasyonurunId)
        {
            var onRezervasyonUrun = _onRezervasyonUrunRepo.GetBy(x => x.OnrezervasyonurunId.Equals(OnrezervasyonurunId));
            return onRezervasyonUrun;
        }

        public bool InsertOnrezervasyonlarUrun(OnrezervasyonlarUrun onrezervasyonlarUrun)
        {
            var res = _onRezervasyonUrunRepo.Insert(onrezervasyonlarUrun);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public OnrezervasyonlarUrun UpdateOnrezervasyonlarUrun(OnrezervasyonlarUrun onrezervasyonlarUrun)
        {
            return _onRezervasyonUrunRepo.Update(onrezervasyonlarUrun);
        }
    }
}
