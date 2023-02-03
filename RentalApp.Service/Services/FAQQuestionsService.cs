using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl;

namespace RentalApp.Service.Services
{
    public class FAQQuestionsService : IFAQQuestionsService
    {
        private readonly IRepository<SssSorular> _sssSorularRepo;

        public FAQQuestionsService(IRepository<SssSorular> sssSorularRepo)
        {
            _sssSorularRepo = sssSorularRepo;
        }

        public bool DeleteSssSorular(SssSorular sssSorular)
        {
            try
            {
                var result = _sssSorularRepo.Delete(sssSorular);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public IList<SssSorular> GetAllSssSorular(int SoruId)
        {
            return _sssSorularRepo.GetAllByQ(x => x.SoruId.Equals(SoruId)).ToList();
        }
        public SssSorular GetSssSorularById(int SoruId)
        {
            var sorular = _sssSorularRepo.GetBy(x => x.SoruId.Equals(SoruId));
            return sorular;
        }
        public IList<SssSorular> GetAllSssSorulars()
        {
            return _sssSorularRepo.GetAll().ToList();
        }
        public bool InsertSssSorular(SssSorular sssSorular)
        {
            var res = _sssSorularRepo.Insert(sssSorular);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public SssSorular UpdateSssSorular(SssSorular sssSorular)
        {
            return _sssSorularRepo.Update(sssSorular);
        }


    }
}
