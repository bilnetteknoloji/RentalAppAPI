using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface ICategoriesService
    {
        Kategoriler GetKategorilerById(int KategoriId);
        IList<Kategoriler> GetAllKategoriler(int KategoriId);
        bool DeleteKategorilerById(Kategoriler kategoriler);
        Kategoriler UpdateKategoriler (Kategoriler kategoriler);
        bool InsertKategoriler (Kategoriler kategoriler);
        IList<Kategoriler> GetAllKategorilers();
    }
}
