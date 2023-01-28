using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl;

namespace RentalApp.Service.Services
{
    public class RentalRequestsService : IRentalRequestsService
    {
        private readonly IRepository<KiralamaTalepleri> _kiralamaTalepleri;

        public RentalRequestsService(IRepository<KiralamaTalepleri> kiralamaTalepleri)
        {
            _kiralamaTalepleri = kiralamaTalepleri;
        }

        public bool DeleteKiralamaTalepleriById(KiralamaTalepleri kiralamaTalepleri)
        {
            try
            {
                var result = _kiralamaTalepleri.Delete(kiralamaTalepleri);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public IList<KiralamaTalepleri> GetAllKiralamaTalepleri(int TalepId)
        {
            return _kiralamaTalepleri.GetAllByQ(x => x.TalepId.Equals(TalepId)).ToList();
        }

        public IList<KiralamaTalepleri> GetAllKiralamaTalepleris()
        {
            return _kiralamaTalepleri.GetAll().ToList();
        }

        public KiralamaTalepleri GetKiralamaTalepleriById(int TalepId)
        {
            var talepleri = _kiralamaTalepleri.GetBy(x => x.TalepId.Equals(TalepId));
            return talepleri;
        }

        public bool InsertKiralamaTalepleri(KiralamaTalepleri kiralamaTalepleri)
        {
            var res = _kiralamaTalepleri.Insert(kiralamaTalepleri);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public KiralamaTalepleri UpdateKiralamaTalepleri(KiralamaTalepleri kiralamaTalepleri)
        {
            return _kiralamaTalepleri.Update(kiralamaTalepleri);
        }
    }
}
