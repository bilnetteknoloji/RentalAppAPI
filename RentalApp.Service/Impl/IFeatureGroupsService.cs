using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface IFeatureGroupsService
    {

        #region ÖzellikGruplar

        Ozellikgruplar GetOzellikgruplarById(int OzellikgrupId);
        IList<Ozellikgruplar> GetAllOzellikgruplar(int OzellikgrupId);
        bool DeleteOzellikgruplarById(Ozellikgruplar ozellikgruplar);
        Ozellikgruplar UpdateOzellikgruplar (Ozellikgruplar ozellikgruplar);
        bool InsertOzellikgruplar(Ozellikgruplar ozellikgruplar);
        IList<Ozellikgruplar> GetAllOzellikgruplars();

        #endregion

        #region ÖzellikGrupDiller
        OzellikgruplarDil GetOzellikgruplarDilById(int OzellikgrupDilId);
        IList<OzellikgruplarDil> GetAllOzellikgruplarDil(int OzellikgrupDilId);
        bool DeleteOzellikgruplarDilById(OzellikgruplarDil ozellikgruplarDil);
        OzellikgruplarDil UpdateOzellikgruplarDil (OzellikgruplarDil ozellikgruplarDil);
        bool InsertOzellikgruplarDil (OzellikgruplarDil ozellikgruplarDil);
        IList<OzellikgruplarDil> GetAllOzellikgruplarDils();
        #endregion

        #region ÖzelliklerDil
        OzelliklerDil GetOzelliklerDilById(int OzellikDilId);
        IList<OzelliklerDil> GetAllOzelliklerDil(int OzellikDilId);
        bool DeleteOzelliklerDilById(OzelliklerDil ozelliklerDil);
        OzelliklerDil UpdateOzelliklerDil (OzelliklerDil ozelliklerDil);
        bool InsertOzelliklerDil (OzelliklerDil ozelliklerDil);
        IList<OzelliklerDil> GetAllOzelliklerDils();
        #endregion

        #region Özellikler
        Ozellikler GetOzelliklerById(int OzellikId);
        IList<Ozellikler> GetAllOzellikler(int OzellikId);
        bool DeleteOzelliklerById(Ozellikler ozellikler);
        Ozellikler UpdateOzellikler(Ozellikler ozellikler);
        bool InsertOzellikler(Ozellikler ozellikler);
        IList<Ozellikler> GetAllOzelliklers();
        #endregion

    }
}
