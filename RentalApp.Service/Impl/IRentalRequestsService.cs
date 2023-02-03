using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface IRentalRequestsService
    {
        KiralamaTalepleri GetKiralamaTalepleriById(int TalepId);
        IList<KiralamaTalepleri> GetAllKiralamaTalepleri(int TalepId);
        bool DeleteKiralamaTalepleriById(KiralamaTalepleri kiralamaTalepleri);
        KiralamaTalepleri UpdateKiralamaTalepleri(KiralamaTalepleri kiralamaTalepleri);
        bool InsertKiralamaTalepleri (KiralamaTalepleri kiralamaTalepleri);
        IList<KiralamaTalepleri> GetAllKiralamaTalepleris();
    }
}
