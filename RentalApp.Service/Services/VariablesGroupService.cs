using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Services
{
    public class VariablesGroupService : IVariablesGroupService
    {
        private readonly IRepository<Degiskengruplar> _degiskenGrupRepo;
        private readonly IRepository<DegiskengruplarDil> _degiskenGrupDilRepo;
        private readonly IRepository<DegiskenlerDil> _degiskenDilRepo;
        private readonly IRepository<Degiskenler> _degiskenRepo;

        public VariablesGroupService(IRepository<Degiskengruplar> degiskenGrupRepo, IRepository<DegiskengruplarDil> degiskenGrupDilRepo, IRepository<DegiskenlerDil> degiskenDilRepo, IRepository<Degiskenler> degiskenRepo)
        {
            _degiskenGrupRepo = degiskenGrupRepo;
            _degiskenGrupDilRepo = degiskenGrupDilRepo;
            _degiskenDilRepo = degiskenDilRepo;
            _degiskenRepo = degiskenRepo;
        }

        #region DeğişkenlerGrup
        public bool DeleteDegiskengruplar(Degiskengruplar degiskengruplar)
        {
            try
            {
                var result = _degiskenGrupRepo.Delete(  degiskengruplar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public IList<Degiskengruplar> GetAllDegiskengruplar(int DegiskengrupId)
        {
            return _degiskenGrupRepo.GetAllByQ(x => x.DegiskengrupId.Equals(DegiskengrupId)).ToList();
        }

        public IList<Degiskengruplar> GetAllDegiskengruplars()
        {
            return _degiskenGrupRepo.GetAll().ToList();
        }

        public Degiskengruplar GetDegiskengruplarById(int DegiskengrupId)
        {
            var degiskengrup = _degiskenGrupRepo.GetBy(x => x.DegiskengrupId.Equals(DegiskengrupId));
            return degiskengrup;
        }

        public bool InsertDegiskengruplar(Degiskengruplar degiskengruplar)
        {
            var res = _degiskenGrupRepo.Insert(degiskengruplar);
            if(res!= null)
            {
                return true;
            }
            else { return false; }
        }

        public Degiskengruplar UpdateDegiskengruplar(Degiskengruplar degiskengruplar)
        {
            return _degiskenGrupRepo.Update(degiskengruplar);
        }

        #endregion

        #region DeğişkenlerGrupDil
        public IList<DegiskengruplarDil> GetAllDegiskengruplarDil(int DegiskengrupDilId)
        {
            return _degiskenGrupDilRepo.GetAllByQ(x => x.DegiskengrupDilId.Equals(DegiskengrupDilId)).ToList();
        }

        public bool DeleteDegiskengruplarDil(DegiskengruplarDil degiskengruplarDil)
        {
            try
            {
                var result =_degiskenGrupDilRepo.Delete(degiskengruplarDil);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);
            }
        }

        public DegiskengruplarDil GetDegiskengruplarDilById(int DegiskengrupDilId)
        {
            var degiskengdil = _degiskenGrupDilRepo.GetBy(x => x.DegiskengrupDilId.Equals(DegiskengrupDilId));
            return degiskengdil;
        }

        public bool InsertDegiskengruplarDil(DegiskengruplarDil degiskengruplarDil)
        {
            var res = _degiskenGrupDilRepo.Insert(degiskengruplarDil);
            if (res != null)
            {
                return true;
            }
            else { return false; }
        }

        public DegiskengruplarDil UpdateDegiskengruplarDil(DegiskengruplarDil degiskengruplarDil)
        {
            return _degiskenGrupDilRepo.Update(degiskengruplarDil);
        }
        public IList<DegiskengruplarDil> GetAllDegiskengruplarDils()
        {
            return _degiskenGrupDilRepo.GetAll().ToList();
        }

        #endregion

        #region DeğişkenlerDil
        public DegiskenlerDil GetDegiskenlerDilById(int DegiskenDilId)
        {
            var degiskendil = _degiskenDilRepo.GetBy(x => x.DegiskenDilId.Equals(DegiskenDilId));
            return degiskendil;

        }

        public IList<DegiskenlerDil> GetAllDegiskenlerDil(int DegiskenDilId)
        {
            return _degiskenDilRepo.GetAllByQ(x => x.DegiskenDilId.Equals(DegiskenDilId)).ToList();
        }

        public bool DeleteDegiskenlerDil(DegiskenlerDil degiskenlerDil)
        {
            try
            {
                var result = _degiskenDilRepo.Delete(degiskenlerDil);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);
            }
        }

        public DegiskenlerDil UpdateDegiskenlerDil(DegiskenlerDil degiskenlerDil)
        {
            return _degiskenDilRepo.Update(degiskenlerDil);
        }

        public bool InsertDegiskenlerDil(DegiskenlerDil degiskenlerDil)
        {
            var res = _degiskenDilRepo.Insert(degiskenlerDil);
            if (res != null)
            {
                return true;
            }
            else { return false; }
        }

        public IList<DegiskenlerDil> GetAllDegiskenlerDils()
        {
            return _degiskenDilRepo.GetAll().ToList();
        }

        #endregion

        #region Değişkenler
        public Degiskenler GetDegiskenlerById(int DegiskenId)
        {
            var degisken = _degiskenRepo.GetBy(x => x.DegiskenId.Equals(DegiskenId));
            return degisken;
        }

        public IList<Degiskenler> GetAllDegiskenler(int DegiskenId)
        {
            return _degiskenRepo.GetAllByQ(x => x.DegiskenId.Equals(DegiskenId)).ToList();
        }

        public bool DeleteDegiskenler(Degiskenler degiskenler)
        {
            try
            {
                var result = _degiskenRepo.Delete(degiskenler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);
            }
        }

        public Degiskenler UpdateDegiskenler(Degiskenler degiskenler)
        {
            return _degiskenRepo.Update(degiskenler);
        }

        public bool InsertDegiskenler(Degiskenler degiskenler)
        {
            var res = _degiskenRepo.Insert(degiskenler);
            if (res != null)
            {
                return true;
            }
            else { return false; }
        }

        public IList<Degiskenler> GetAllDegiskenlers()
        {
            return _degiskenRepo.GetAll().ToList();
        }
        #endregion

    }
}
