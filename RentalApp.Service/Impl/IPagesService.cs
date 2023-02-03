using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface IPagesService
    {
        Sayfalar GetSayfalarById(int SayfaId);
        IList<Sayfalar> GetAllSayfalar(int SayfaId);
        bool DeleteSayfalar(Sayfalar sayfalar);
        Sayfalar UpdateSayfalar (Sayfalar sayfalar);
        bool InsertSayfalar (Sayfalar sayfalar);
        IList<Sayfalar> GetAllSayfalars();
    }
}
