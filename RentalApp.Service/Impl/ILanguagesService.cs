using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface ILanguagesService
    {
        Diller GetDillerById(int DilId);
        IList<Diller> GetAllDiller(int DilId);
        bool DeleteDillerById(Diller diller);
        Diller UpdateDiller (Diller diller);
        bool InsertDiller (Diller diller);
        IList<Diller> GetAllDillers();


        #region Products Language
        UrunlerDil GetUrunlerDilById(int urundilid);
        IList<UrunlerDil> GetAllUrunlerDil(int urundilid);
        IList<UrunlerDil> GetAllUrunlerDils();
        bool DeleteUrunlerDil(UrunlerDil urunlerDil);
        UrunlerDil UpdateUrunlerDil(UrunlerDil urunlerDil);
        bool InsertUrunlerDil(UrunlerDil urunlerDil);

        #endregion

    }
}
