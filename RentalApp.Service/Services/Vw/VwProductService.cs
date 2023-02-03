using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl.Vw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Services.Vw
{
    public class VwProductService : IVwProductService
    {
        private readonly IRepository<Vwurunler> _vwurunlerRepo;

        public VwProductService(IRepository<Vwurunler> vwurunlerRepo)
        {
            _vwurunlerRepo = vwurunlerRepo;
        }

        public bool DeleteVwUrunlerById(Vwurunler vwurunler)
        {
            try
            {
                var result = _vwurunlerRepo.Delete(vwurunler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public IList<Vwurunler> GetAllVwUrunler(int urunId)
        {

            return _vwurunlerRepo.GetAllByQ(x => x.UrunId.Equals(urunId)).ToList();
        }

        public IList<Vwurunler> GetAllVwUrunlers()
        {
            return _vwurunlerRepo.GetAll().ToList();
        }

        public Vwurunler GetVwUrunlerById(int urunid)
        {
            var Urunler = _vwurunlerRepo.GetBy(x => x.UrunId.Equals(urunid));
            return Urunler;
        }

        public bool InsertVwUrunler(Vwurunler vwurunler)
        {
            var res = _vwurunlerRepo.Insert(vwurunler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Vwurunler UpdateVwUrunler(Vwurunler vwurunler)
        {
            return _vwurunlerRepo.Update(vwurunler);
        }
    }
}
