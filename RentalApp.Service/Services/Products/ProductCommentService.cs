using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Services.Products
{
    public class ProductCommentService : IProductCommentService
    {
        #region fields
        private readonly IRepository<UrunlerYorum> _urunlerYorumRepo;
        #endregion

        #region ctor
        public ProductCommentService(IRepository<UrunlerYorum> urunlerYorumRepo)
        {
            this._urunlerYorumRepo = urunlerYorumRepo;
        }

        #endregion

        #region methods
        public bool DeleteUrunlerYorumById(UrunlerYorum urunlerYorum)
        {
            try
            {
                var result = _urunlerYorumRepo.Delete(urunlerYorum);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }
        public IList<UrunlerYorum> GetAllUrunlerYorum(int urunId)
        {
            return _urunlerYorumRepo.GetAllByQ(x => x.UrunId.Equals(urunId)).ToList();
        }

        public IList<UrunlerYorum> GetAllYorums()
        {
            return _urunlerYorumRepo.GetAll().ToList();
        }

        public UrunlerYorum GetUrunlerYorumById(int yorumid)
        {
            var UrunlerYorum = _urunlerYorumRepo.GetBy(x => x.YorumId.Equals(yorumid));
            return UrunlerYorum;
        }

        public bool InsertUrunlerYorum(UrunlerYorum urunlerYorum)
        {
            var res = _urunlerYorumRepo.Insert(urunlerYorum);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UrunlerYorum UpdateUrunlerYorum(UrunlerYorum urunlerYorum)
        {
             return _urunlerYorumRepo.Update(urunlerYorum);
        }


        #endregion

    }
}
