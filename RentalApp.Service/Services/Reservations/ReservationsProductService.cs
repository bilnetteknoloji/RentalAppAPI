using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Services.Reservations
{
    public class ReservationsProductService : IReservationsProductService
    {
        private readonly IRepository<RezervasyonlarUrun> _rezervasyonlarUrunRepo;

        public ReservationsProductService(IRepository<RezervasyonlarUrun> rezervasyonlarUrunRepo)
        {
            _rezervasyonlarUrunRepo = rezervasyonlarUrunRepo;
        }
        public bool DeleteRezervasyonlarUrun(RezervasyonlarUrun rezervasyonlarUrun)
        {
            try
            {
                var result = _rezervasyonlarUrunRepo.Delete(rezervasyonlarUrun);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public RezervasyonlarUrun GetRezervasyonlarUrunById(int RezervasyonurunId)
        {
            var rezUrun = _rezervasyonlarUrunRepo.GetBy(x => x.RezervasyonurunId.Equals(RezervasyonurunId));
            return rezUrun;
        }
        public IList<RezervasyonlarUrun> GetAllRezervasyonlarUrun(int RezervasyonurunId)
        {
            return _rezervasyonlarUrunRepo.GetAllByQ(x => x.RezervasyonurunId.Equals(RezervasyonurunId)).ToList();
        }
        public IList<RezervasyonlarUrun> GetAllRezervasyonlarUruns()
        {
            return _rezervasyonlarUrunRepo.GetAll().ToList();
        }
        public bool InsertRezervasyonlarUrun(RezervasyonlarUrun rezervasyonlarUrun)
        {
            var res = _rezervasyonlarUrunRepo.Insert(rezervasyonlarUrun);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public RezervasyonlarUrun UpdateRezervasyonlarUrun(RezervasyonlarUrun rezervasyonlarUrun)
        {
            return _rezervasyonlarUrunRepo.Update(rezervasyonlarUrun);
        }


    }
}
