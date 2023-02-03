using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface ICampaignsService
    {
        
        #region UrunlerKampanyalar
        UrunlerKampanyalar GetUrunlerKampanyalarById(int KampanyaId);
        IList<UrunlerKampanyalar> GetAllUrunlerKampanyalar(int KampanyaId);
        bool DeleteUrunlerKampanyalarById(UrunlerKampanyalar urunlerKampanyalar);
        UrunlerKampanyalar UpdateUrunlerKampanyalar(UrunlerKampanyalar urunlerKampanyalar);
        bool InsertUrunlerKampanyalar (UrunlerKampanyalar urunlerKampanyalar);
        IList<UrunlerKampanyalar> GetAllUrunlerKampanyalars();
        #endregion

        #region Kampanyalar
        Kampanyalar GetKampanyalarById(int KampanyaId);
        IList<Kampanyalar> GetAllKampanyalar (int KampanyaId);
        bool DeleteKampanyalarById(Kampanyalar kampanyalar);
        Kampanyalar UpdateKampanyalar(Kampanyalar kampanyalar);
        bool InsertKampanyalar(Kampanyalar kampanyalar);
        IList<Kampanyalar> GetAllKampanyalars();

        #endregion

        #region VwKampanyalar
        Vwkampanyalar GetVwkampanyalarById(int KampanyaId);
        IList<Vwkampanyalar> GetAllVwkampanyalar(int KampanyaId);
        bool DeleteVwkampanyalarById(Vwkampanyalar vwkampanyalar);
        Vwkampanyalar UpdateVwkampanyalar(Vwkampanyalar vwkampanyalar);
        bool InsertVwkampanyalar(Vwkampanyalar vwkampanyalar);
        IList<Vwkampanyalar> GetAllVwkampanyalars();
        #endregion


    }
}
