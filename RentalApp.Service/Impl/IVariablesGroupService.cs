using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface IVariablesGroupService
    {
        #region DeğişkenlerGrup
        Degiskengruplar GetDegiskengruplarById(int DegiskengrupId);
        IList<Degiskengruplar> GetAllDegiskengruplar(int DegiskengrupId);
        bool DeleteDegiskengruplar(Degiskengruplar degiskengruplar);
        Degiskengruplar UpdateDegiskengruplar (Degiskengruplar degiskengruplar);
        bool InsertDegiskengruplar (Degiskengruplar degiskengruplar);
        IList<Degiskengruplar> GetAllDegiskengruplars();
        #endregion

        #region DeğişkenlerGrupDil
        DegiskengruplarDil GetDegiskengruplarDilById(int DegiskengrupDilId);
        IList<DegiskengruplarDil> GetAllDegiskengruplarDil(int DegiskengrupDilId);
        bool DeleteDegiskengruplarDil(DegiskengruplarDil degiskengruplarDil);
        DegiskengruplarDil UpdateDegiskengruplarDil(DegiskengruplarDil degiskengruplarDil);
        bool InsertDegiskengruplarDil(DegiskengruplarDil degiskengruplarDil);
        IList<DegiskengruplarDil> GetAllDegiskengruplarDils();
        #endregion


        #region DeğişkenlerDil
        DegiskenlerDil GetDegiskenlerDilById(int DegiskenDilId);
        IList<DegiskenlerDil> GetAllDegiskenlerDil(int DegiskenDilId);
        bool DeleteDegiskenlerDil(DegiskenlerDil degiskenlerDil);
        DegiskenlerDil UpdateDegiskenlerDil(DegiskenlerDil degiskenlerDil);
        bool InsertDegiskenlerDil(DegiskenlerDil degiskenlerDil);
        IList<DegiskenlerDil> GetAllDegiskenlerDils();
        #endregion

        #region Değişkenler
        Degiskenler GetDegiskenlerById(int DegiskenId);
        IList<Degiskenler> GetAllDegiskenler(int DegiskenId);
        bool DeleteDegiskenler(Degiskenler degiskenler);
        Degiskenler UpdateDegiskenler(Degiskenler degiskenler);
        bool InsertDegiskenler(Degiskenler degiskenler);
        IList<Degiskenler> GetAllDegiskenlers();
        #endregion

    }
}
