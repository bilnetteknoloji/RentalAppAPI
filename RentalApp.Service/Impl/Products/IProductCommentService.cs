using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl.Products
{
    public interface IProductCommentService
    {
        UrunlerYorum GetUrunlerYorumById(int yorumid);
        IList<UrunlerYorum> GetAllUrunlerYorum(int urunId);
        bool DeleteUrunlerYorumById(UrunlerYorum urunlerYorum);
        UrunlerYorum UpdateUrunlerYorum(UrunlerYorum urunlerYorum);
        bool InsertUrunlerYorum(UrunlerYorum urunlerYorum);
        IList<UrunlerYorum> GetAllYorums();
    }
}
