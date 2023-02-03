using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface IRentalPicturesService
    {
        KiralamaResimler GetKiralamaResimlerById(int TalepresimId);
        IList<KiralamaResimler> GetAllKiralamaResimler(int TalepresimId);
        bool DeleteKiralamaResimlerById(KiralamaResimler kiralamaResimler);
        KiralamaResimler UpdateKiralamaResimler(KiralamaResimler kiralamaResimler);
        bool InsertKiralamaResimler(KiralamaResimler kiralamaResimler);
        IList<KiralamaResimler> GetAllKiralamaResims();
    }
}
