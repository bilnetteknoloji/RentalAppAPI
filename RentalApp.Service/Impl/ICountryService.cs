using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface ICountryService
    {
        IList<Iller> GetIlByBolgeId(int bolgeId);
        IList<Ilceler> GetAllIlceByBolge(int bolgeId);

        // İhtiyacım olan methodların Tanımlamalarını yapıorm

        Ulkeler GetUlkeById(int ulkeId);
        IList<Ulkeler> GetAllUlke(int ulkeId);
        IList<Ulkeler> GetAllUlkes();
        bool DeleteUlke(Ulkeler Ulke);
        Ulkeler UpdateUlke(Ulkeler Ulke);
        bool InsertUlke(Ulkeler ulke);

        #region Bolgeler
        Bolgeler GetBolgelerById(int BolgeId);
        IList<Bolgeler> GetAllBolgeler(int BolgeId);
        IList<Bolgeler> GetAllBolgelers();
        bool DeleteBolgeler(Bolgeler bolgeler);
        Bolgeler UpdateBolgeler(Bolgeler bolgeler);
        bool InsertBolgeler(Bolgeler bolgeler);
        #endregion

        #region Iller
        Iller GetIllerById(int IlId);
        IList<Iller> GetAllIller(int IlId);
        IList<Iller> GetAllIllers();
        bool DeleteIller(Iller ıller);
        Iller UpdateIller(Iller ıller);
        bool InsertIller(Iller ıller);
        #endregion

        #region Ilceler
        Ilceler GetIlcelerById(int IlceId);
        IList<Ilceler> GetAllIlceler(int IlceId);
        IList<Ilceler> GetAllIlcelers();
        bool DeleteIlceler(Ilceler ılceler);
        Iller UpdateIlceler(Ilceler ılceler);
        bool InsertIlceler(Ilceler ılceler);
        #endregion

    }
}