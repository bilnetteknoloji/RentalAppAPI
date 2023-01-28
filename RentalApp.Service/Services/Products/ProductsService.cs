using RentalApp.Core;
using RentalApp.Data.Repository;
using RentalApp.Service.Impl.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;


namespace RentalApp.Service.Services
{
    public class ProductsService : IProductsService
    {

        #region fields
        private readonly IRepository<Urunler> _urunlerRepo;
        private readonly IRepository<UrunlerFiyat> _urunlerFiyatRepo;
        private readonly IRepository<UrunlerResim> _urunlerResimRepo;
        private readonly IRepository<UrunlerVitrin> _urunlerVitrinRepo;
        private readonly IRepository<UrunlerKontrat> _urunlerKontratRepo;
        private readonly IRepository<UrunlerEkfiyat> _urunlerEkfiyatRepo;
        private readonly IRepository<UrunlerBanyolar> _urunlerBanyolarRepo;
        private readonly IRepository<UrunlerOzellikler> _urunlerOzelliklerRepo;
        private readonly IRepository<UrunlerIstatistik> _urunlerIstatistikRepo;
        private readonly IRepository<UrunlerOperatorler> _urunlerOperatorlerRepo;
        private readonly IRepository<UrunlerKategoriler> _urunlerKategorilerRepo;
        private readonly IRepository<UrunlerKampanyalar> _urunlerKampanyalarRepo;
        private readonly IRepository<UrunlerDegiskenler> _urunlerDegiskenlerRepo;
        private readonly IRepository<UrunlerYatakodalari> _urunlerYatakodalariRepo;

        #endregion

        #region ctor
        public ProductsService(IRepository<Urunler> UrunlerRepo, IRepository<UrunlerYorum> urunlerYorumRepo, IRepository<UrunlerResim> urunlerResimRepo,
            IRepository<UrunlerVitrin> urunlerVitrinRepo, IRepository<UrunlerKontrat> urunlerKontratRepo, IRepository<UrunlerEkfiyat> urunlerEkfiyatRepo, IRepository<UrunlerBanyolar> urunlerBanyolarRepo,
            IRepository<UrunlerOzellikler> urunlerOzelliklerRepo, IRepository<UrunlerIstatistik> urunlerIstatistikRepo, IRepository<UrunlerOperatorler> urunlerOperatorlerRepo, IRepository<UrunlerKategoriler> urunlerKategorilerRepo,
            IRepository<UrunlerKampanyalar> urunlerKampanyalarRepo, IRepository<UrunlerDegiskenler> urunlerDegiskenlerRepo, IRepository<UrunlerYatakodalari> urunlerYatakodalariRepo, IRepository<UrunlerFiyat> urunlerFiyat)
        {
            this._urunlerResimRepo = urunlerResimRepo;
            _urunlerBanyolarRepo = urunlerBanyolarRepo;
            _urunlerIstatistikRepo = urunlerIstatistikRepo;
            _urunlerOperatorlerRepo = urunlerOperatorlerRepo;
            _urunlerKampanyalarRepo = urunlerKampanyalarRepo;
            _urunlerDegiskenlerRepo = urunlerDegiskenlerRepo;
            _urunlerEkfiyatRepo = urunlerEkfiyatRepo;
            _urunlerFiyatRepo = urunlerFiyat;
            _urunlerKategorilerRepo = urunlerKategorilerRepo;
            _urunlerKontratRepo = urunlerKontratRepo;
            _urunlerOzelliklerRepo = urunlerOzelliklerRepo;
            _urunlerResimRepo = urunlerResimRepo;
            _urunlerVitrinRepo = urunlerVitrinRepo;
            _urunlerYatakodalariRepo = urunlerYatakodalariRepo;
            _urunlerRepo = UrunlerRepo;
        }

        #endregion

        #region Methods Tanımlamalar
        public IList<Urunler> GetUrunlerByurunId(int urunid)
        {
            var Urunler = _urunlerRepo.GetAllByQ(x => x.UrunId.Equals(urunid)).ToList();
            return Urunler;
        }

        public IList<UrunlerBanyolar> GetUrunlerBanyolarByUBanyoId(int urunbanyoid)
        {
            var UrunlerBanyolar = _urunlerBanyolarRepo.GetAllByQ(x => x.UrunbanyoId.Equals(urunbanyoid)).ToList();
            return UrunlerBanyolar;
        }

        public IList<UrunlerYatakodalari> GetUrunlerYatakodalariByUYatakOdaId(int urunyatakodasi_id)
        {
            var UrunlerYatakodalari = _urunlerYatakodalariRepo.GetAllByQ(x => x.UrunyatakodasiId.Equals(urunyatakodasi_id)).ToList();
            return UrunlerYatakodalari;
        }

        public IList<UrunlerDegiskenler> GetUrunlerDegiskenlerByUDegisenId(int urundegiskenid)
        {
            var UrunlerDegiskenler = _urunlerDegiskenlerRepo.GetAllByQ(x => x.UrunDegiskenId.Equals(urundegiskenid)).ToList();
            return UrunlerDegiskenler;
        }

        public IList<UrunlerFiyat> GetUrunlerFiyatByUFiyatId(int fiyatid)
        {
            var UrunlerFiyat = _urunlerFiyatRepo.GetAllByQ(x => x.FiyatId.Equals(fiyatid)).ToList();
            return UrunlerFiyat;
        }

        public IList<UrunlerEkfiyat> GetUrunlerEkfiyatByUEkFiyatId(int urunekfiyatid)
        {
            var UrunlerEkfiyatlar = _urunlerEkfiyatRepo.GetAllByQ(x => x.UrunEkfiyatId.Equals(urunekfiyatid)).ToList();
            return UrunlerEkfiyatlar;
        }

        public IList<UrunlerKampanyalar> GetUrunlerKampanyalarByUKampanyaId(int urunkampanyaid)
        {
            var UrunlerKampanya = _urunlerKampanyalarRepo.GetAllByQ(x => x.UrunKampanyaId.Equals(urunkampanyaid)).ToList();
            return UrunlerKampanya;
        }

        public IList<UrunlerIstatistik> GetUrunlerIstatistikByUistatistikId(int istatistikid)
        {
            var UrunlerIstatistik = _urunlerIstatistikRepo.GetAllByQ(x => x.IstatistikId.Equals(istatistikid)).ToList();
            return UrunlerIstatistik;
        }

        public IList<UrunlerKategoriler> GetUrunlerKategorilerByUKategorilerId(int urunkategoriid)
        {
            var UrunlerKategoriler = _urunlerKategorilerRepo.GetAllByQ(x => x.UrunKategoriId.Equals(urunkategoriid)).ToList();
            return UrunlerKategoriler;
        }

        public IList<UrunlerKontrat> GetUrunlerKontratByUKontratId(int kontratid)
        {
            var UrunlerKontart = _urunlerKontratRepo.GetAllByQ(x => x.KontratId.Equals(kontratid)).ToList();
            return UrunlerKontart;
        }

        public IList<UrunlerOperatorler> GetUrunlerOperatorlerByUOperatorlerId(int urunoperatorid)
        {
            var UrunlerOperatorler = _urunlerOperatorlerRepo.GetAllByQ(x => x.UrunoperatorId.Equals(urunoperatorid)).ToList();
            return UrunlerOperatorler;
        }

        public IList<UrunlerOzellikler> GetUrunlerOzelliklerByUOzellillerId(int urunozellikid)
        {
            var UrunlerOzellikler = _urunlerOzelliklerRepo.GetAllByQ(x => x.UrunOzellikId.Equals(urunozellikid)).ToList();
            return UrunlerOzellikler;

        }

        public IList<UrunlerResim> GetUrunlerResimByUResimId(int resimid)
        {
            var UrunlerResim = _urunlerResimRepo.GetAllByQ(x => x.ResimId.Equals(resimid)).ToList();
            return UrunlerResim;
        }

        public IList<UrunlerVitrin> GetUrunlerVitrinByUVitrinId(int vitrinid)
        {
            var UrunlerVitrin = _urunlerVitrinRepo.GetAllByQ(x => x.VitrinId.Equals(vitrinid)).ToList();
            return UrunlerVitrin;
        }

    

        #endregion

        #region Delete

        public bool DeleteUrunler(Urunler urunler)
        {
            try
            {
                var result = _urunlerRepo.Delete(urunler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerBanyolar(UrunlerBanyolar urunlerBanyolar)
        {
            try
            {
                var result = _urunlerBanyolarRepo.Delete(urunlerBanyolar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerDegiskenler(UrunlerDegiskenler urunlerDegiskenler)
        {
            try
            {
                var result = _urunlerDegiskenlerRepo.Delete(urunlerDegiskenler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerEkfiyat(UrunlerEkfiyat urunlerEkfiyat)
        {
            try
            {
                var result = _urunlerEkfiyatRepo.Delete(urunlerEkfiyat);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerFiyat(UrunlerFiyat urunlerFiyat)
        {
            try
            {
                var result = _urunlerFiyatRepo.Delete(urunlerFiyat);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerIstatistik(UrunlerIstatistik urunlerIstatistik)
        {
            try
            {
                var result = _urunlerIstatistikRepo.Delete(urunlerIstatistik);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerKampanyalar(UrunlerKampanyalar urunlerKampanyalar)
        {
            try
            {
                var result = _urunlerKampanyalarRepo.Delete(urunlerKampanyalar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerKategorilerById(UrunlerKategoriler urunlerKategoriler)
        {
            try
            {
                var result = _urunlerKategorilerRepo.Delete(urunlerKategoriler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerKontratById(UrunlerKontrat urunlerKontrat)
        {
            try
            {
                var result = _urunlerKontratRepo.Delete(urunlerKontrat);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerOperatorlerById(UrunlerOperatorler urunlerOperatorler)
        {
            try
            {
                var result = _urunlerOperatorlerRepo.Delete(urunlerOperatorler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerOzelliklerById(UrunlerOzellikler urunlerOzellikler)
        {
            try
            {
                var result = _urunlerOzelliklerRepo.Delete(urunlerOzellikler);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerResimById(UrunlerResim urunlerResim)
        {
            try
            {
                var result = _urunlerResimRepo.Delete(urunlerResim);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        public bool DeleteUrunlerVitrinById(UrunlerVitrin urunlerVitrin)
        {
            try
            {
                var result = _urunlerVitrinRepo.Delete(urunlerVitrin);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

      

        public bool DeleteUrunYatakodalari(UrunlerYatakodalari urunlerYatakodalari)
        {
            try
            {
                var result = _urunlerYatakodalariRepo.Delete(urunlerYatakodalari);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new ArgumentException(ex.Message, ex);// system log
            }
        }

        #endregion

        #region IList

        public IList<Urunler> GetAllUrunler()//bütün ürünleri çetkiğiniz methodda id parametre olmaz
        {
            return _urunlerRepo.GetAll().ToList();
        }

        public IList<UrunlerOperatorler> GetAllUrunlerOperatorler()
        {
            return _urunlerOperatorlerRepo.GetAll().ToList();
        }

        public IList<UrunlerResim> GetAllUrunlerResims()
        {
            return _urunlerResimRepo.GetAll().ToList();
        }

        public IList<UrunlerBanyolar> GetAllUrunlerBanyolars()
        {
            return _urunlerBanyolarRepo.GetAll().ToList();
        }

        public IList<UrunlerYatakodalari> GetAllUrunlerYatakOdalaris()
        {
            return _urunlerYatakodalariRepo.GetAll().ToList();
        }

        public IList<UrunlerIstatistik> GetAllUrunlerIstatistiks()
        {
            return _urunlerIstatistikRepo.GetAll().ToList();
        }

        public IList<UrunlerKontrat> GetAllUrunlerKontrats()
        {
            return _urunlerKontratRepo.GetAll().ToList();
        }

        public IList<UrunlerKampanyalar> GetAllUrunlerKampanyalars()
        {
            return _urunlerKampanyalarRepo.GetAll().ToList();
        }

        public IList<UrunlerDegiskenler> GetAllUrunlerDegiskenlers()
        {
            return _urunlerDegiskenlerRepo.GetAll().ToList();
        }

        public IList<UrunlerKategoriler> GetAllUrunlerKategorilers()
        {
            return _urunlerKategorilerRepo.GetAll().ToList();
        }

        public IList<UrunlerOzellikler> GetAllUrunlerOzelliklers()
        {
            return _urunlerOzelliklerRepo.GetAll().ToList();
        }
        public IList<UrunlerFiyat> GetAllUrunlerFiyats()
        {
            return _urunlerFiyatRepo.GetAll().ToList();
        }
        public IList<UrunlerEkfiyat> GetAllUrunlerEkFiyats()
        {
            return _urunlerEkfiyatRepo.GetAll().ToList();
        }

        public IList<UrunlerVitrin> GetAllUrunlerVitrins()
        {
            return _urunlerVitrinRepo.GetAll().ToList() ;
        }

        // buraya urunIdleirni gönderrsnz ve detayları alır
        public IList<Urunler> GetUrunlerByIds(IList<int> urunIds)
        {
            var result = _urunlerRepo.GetAllBy(x => urunIds.Contains(x.UrunId));
            return result;
        }
        public IList<UrunlerBanyolar> GetAllUrunlerBanyolar(int urunbanyoid)
        {
            var UrunlerBanyolar = _urunlerBanyolarRepo.GetAllByQ(x => x.UrunbanyoId.Equals(urunbanyoid)).Select(y => y.UrunId).ToList();
            return _urunlerBanyolarRepo.GetAllByQ(x => UrunlerBanyolar.Contains(x.UrunbanyoId)).ToList();
        }

        public IList<UrunlerYatakodalari> GetAllUrunYatakodalari(int urunyatakodasiid)
        {
            var UrunlerYatakodalari = _urunlerYatakodalariRepo.GetAllByQ(x => x.UrunyatakodasiId.Equals(urunyatakodasiid)).Select(y => y.UrunId);
            return _urunlerYatakodalariRepo.GetAllByQ(x => UrunlerYatakodalari.Contains(x.UrunyatakodasiId)).ToList();

        }

        public IList<UrunlerDegiskenler> GetAllUrunlerDegiskenler(int urundegiskenid)
        {
            var urunlerDegiskenler = _urunlerDegiskenlerRepo.GetAllByQ(x => x.UrunDegiskenId.Equals(urundegiskenid)).Select(y => y.DegiskenId);
            return _urunlerDegiskenlerRepo.GetAllByQ(x => urunlerDegiskenler.Contains(x.UrunDegiskenId)).ToList();
        }

        public IList<UrunlerFiyat> GetAllUrunlerFiyat(int fiyatid)
        {
            var urunlerFiyat = _urunlerFiyatRepo.GetAllByQ(x => x.FiyatId.Equals(fiyatid)).Select(y => y.UrunId);
            return _urunlerFiyatRepo.GetAllByQ(x => urunlerFiyat.Contains(x.FiyatId)).ToList();
        }

        public IList<UrunlerEkfiyat> GetAllUrunlerEkfiyat(int urunekfiyatid)
        {
            var urunlerEkfiyat = _urunlerEkfiyatRepo.GetAllByQ(x => x.UrunEkfiyatId.Equals(urunekfiyatid)).Select(y => y.UrunId).ToList();
            return _urunlerEkfiyatRepo.GetAllByQ(x => urunlerEkfiyat.Contains(x.UrunEkfiyatId)).ToList();
        }

        public IList<UrunlerKampanyalar> GetAllUrunlerKampanyalar(int urunkampanyaid)
        {
            var urunlerKampanya = _urunlerKampanyalarRepo.GetAllByQ(x => x.UrunKampanyaId.Equals(urunkampanyaid)).Select(y => y.KampanyaId).ToList();
            return _urunlerKampanyalarRepo.GetAllByQ(x => urunlerKampanya.Contains(x.UrunKampanyaId)).ToList();
        }

        public IList<UrunlerIstatistik> GetAllUrunlerIstatistik(int IstatistikId)
        {
            var urunlerIstatistik = _urunlerIstatistikRepo.GetAllByQ(x => x.IstatistikId.Equals(IstatistikId)).Select(y => y.UrunId).ToList();
            return _urunlerIstatistikRepo.GetAllBy(x => urunlerIstatistik.Contains(IstatistikId)).ToList();
        }

        public IList<UrunlerKategoriler> GetAllUrunlerKategoriler(int urunkategoriid)
        {
            var urunlerKategoriler = _urunlerKategorilerRepo.GetAllByQ(x => x.UrunKategoriId.Equals(urunkategoriid)).Select(y => y.UrunId).ToList();
            return _urunlerKategorilerRepo.GetAllByQ(x => urunlerKategoriler.Contains(urunkategoriid)).ToList();
        }

        public IList<UrunlerKontrat> GetAllUrunlerKontrat(int kontratid)
        {
            var urunlerKontrat = _urunlerKontratRepo.GetAllByQ(x => x.KontratId.Equals(kontratid)).Select(y => y.UrunId).ToList();
            return _urunlerKontratRepo.GetAllByQ(x => urunlerKontrat.Contains(kontratid)).ToList();
        }

        public IList<UrunlerOperatorler> GetAllUrunlerOperatorler(int urunoperatorid)
        {
            var urunlerOperatorler = _urunlerOperatorlerRepo.GetAllByQ(x => x.UrunoperatorId.Equals(urunoperatorid)).Select(y => y.UrunId).ToList();
            return _urunlerOperatorlerRepo.GetAllByQ(x => urunlerOperatorler.Contains(urunoperatorid)).ToList();
        }

        public IList<UrunlerOzellikler> GetAllUrunlerOzellikler(int urunozellikid)
        {
            var urunlerOzellikler = _urunlerOzelliklerRepo.GetAllByQ(x => x.UrunOzellikId.Equals(urunozellikid)).Select(y => y.UrunId).ToList();
            return _urunlerOzelliklerRepo.GetAllByQ(x => urunlerOzellikler.Contains(urunozellikid)).ToList();
        }

        public IList<UrunlerResim> GetAllUrunlerResim(int resimid)
        {
            var urunlerResim = _urunlerResimRepo.GetAllByQ(x => x.ResimId.Equals(resimid)).Select(y => y.UrunId).ToList();
            return _urunlerResimRepo.GetAllByQ(x => urunlerResim.Contains(resimid)).ToList();
        }

        public IList<UrunlerVitrin> GetAllUrunlerVitrin(int vitrinid)
        {
            var urunlerVitrin = _urunlerVitrinRepo.GetAllByQ(x => x.VitrinId.Equals(vitrinid)).Select(y => y.UrunId).ToList();
            return _urunlerVitrinRepo.GetAllByQ(x => urunlerVitrin.Contains(vitrinid)).ToList();
        }

    

        #endregion

        #region Get Methods

        public UrunlerBanyolar GetUrunlerBanyolarById(int urunbanyoid)
        {
            var UrunlerBanyolar = _urunlerBanyolarRepo.GetBy(x => x.UrunbanyoId.Equals(urunbanyoid));
            return UrunlerBanyolar;
        }

        public Urunler GetUrunlerById(int urunid)
        {
            var Urunler = _urunlerRepo.GetBy(x => x.UrunId.Equals(urunid));
            return Urunler;
        }

        public UrunlerDegiskenler GetUrunlerDegiskenlerById(int urundegiskenid)
        {
            var UrunlerDegiskenler = _urunlerDegiskenlerRepo.GetBy(x => x.DegiskenId.Equals(urundegiskenid));
            return UrunlerDegiskenler;
        }



        public UrunlerEkfiyat GetUrunlerEkfiyatById(int urunekfiyatid)
        {
            var UrunlerEkfiyatlar = _urunlerEkfiyatRepo.GetBy(x => x.UrunEkfiyatId.Equals(urunekfiyatid));
            return UrunlerEkfiyatlar;
        }

        public UrunlerFiyat GetUrunlerFiyatById(int fiyatid)
        {
            var UrunlerFiyat = _urunlerFiyatRepo.GetBy(x => x.FiyatId.Equals(fiyatid));
            return UrunlerFiyat;
        }

        public UrunlerIstatistik GetUrunlerIstatistikById(int istatistikid)
        {
            var UrunlerIstatistik = _urunlerIstatistikRepo.GetBy(x => x.IstatistikId.Equals(istatistikid));
            return UrunlerIstatistik;
        }

        public UrunlerKampanyalar GetUrunlerKampanyalarById(int urunkampanyaid)
        {
            var UrunlerKampanya = _urunlerKampanyalarRepo.GetBy(x => x.UrunKampanyaId.Equals(urunkampanyaid));
            return UrunlerKampanya;
        }

        public UrunlerKategoriler GetUrunlerKategorilerById(int urunkategoriid)
        {
            var UrunlerKategoriler = _urunlerKategorilerRepo.GetBy(x => x.UrunKategoriId.Equals(urunkategoriid));
            return UrunlerKategoriler;
        }

        public UrunlerKontrat GetUrunlerKontratById(int kontratid)
        {
            var UrunlerKontart = _urunlerKontratRepo.GetBy(x => x.KontratId.Equals(kontratid));
            return UrunlerKontart;
        }

        public UrunlerOperatorler GetUrunlerOperatorlerById(int urunoperatorid)
        {
            var UrunlerOperatorler = _urunlerOperatorlerRepo.GetBy(x => x.UrunoperatorId.Equals(urunoperatorid));
            return UrunlerOperatorler;
        }

        public UrunlerOzellikler GetUrunlerOzelliklerById(int urunozellikid)
        {
            var UrunlerOzellikler = _urunlerOzelliklerRepo.GetBy(x => x.UrunOzellikId.Equals(urunozellikid));
            return UrunlerOzellikler;
        }

        public UrunlerResim GetUrunlerResimById(int resimid)
        {
            var UrunlerResim = _urunlerResimRepo.GetBy(x => x.ResimId.Equals(resimid));
            return UrunlerResim;
        }

        public UrunlerVitrin GetUrunlerVitrinById(int vitrinid)
        {
            var UrunlerVitrin = _urunlerVitrinRepo.GetBy(x => x.VitrinId.Equals(vitrinid));
            return UrunlerVitrin;
        }

        public UrunlerYatakodalari GetUrunlerYatakodalariById(int urunyatakodasiid)
        {
            var UrunlerYatakodalari = _urunlerYatakodalariRepo.GetBy(x => x.UrunyatakodasiId.Equals(urunyatakodasiid));
            return UrunlerYatakodalari;
        }

       


        #endregion

        #region Insert

        public bool InsertUrunler(Urunler urunler)
        {
            var res = _urunlerRepo.Insert(urunler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunlerBanyolar(UrunlerBanyolar urunlerBanyolar)
        {
            var res = _urunlerBanyolarRepo.Insert(urunlerBanyolar);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunlerDegiskenler(UrunlerDegiskenler urunlerDegiskenler)
        {
            var res = _urunlerDegiskenlerRepo.Insert(urunlerDegiskenler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunlerEkfiyat(UrunlerEkfiyat urunlerEkfiyat)
        {
            var res = _urunlerEkfiyatRepo.Insert(urunlerEkfiyat);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunlerFiyat(UrunlerFiyat urunlerFiyat)
        {
            var res = _urunlerFiyatRepo.Insert(urunlerFiyat);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool InsertUrunlerIstatistik(UrunlerIstatistik urunlerIstatistik)
        {
            var res = _urunlerIstatistikRepo.Insert(urunlerIstatistik);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunlerKampanyalar(UrunlerKampanyalar urunlerKampanyalar)
        {
            var res = _urunlerKampanyalarRepo.Insert(urunlerKampanyalar);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool InsertUrunlerKategoriler(UrunlerKategoriler urunlerKategoriler)
        {
            var res = _urunlerKategorilerRepo.Insert(urunlerKategoriler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunlerKontrat(UrunlerKontrat urunlerKontrat)
        {
            var res = _urunlerKontratRepo.Insert(urunlerKontrat);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunlerOperatorler(UrunlerOperatorler urunlerOperatorler)
        {
            var res = _urunlerOperatorlerRepo.Insert(urunlerOperatorler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunlerResim(UrunlerResim urunlerResim)
        {
            var res = _urunlerResimRepo.Insert(urunlerResim);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunlerVitrin(UrunlerVitrin urunlerVitrin)
        {
            var res = _urunlerVitrinRepo.Insert(urunlerVitrin);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        public bool InsertUrunOzellikler(UrunlerOzellikler urunlerOzellikler)
        {
            var res = _urunlerOzelliklerRepo.Insert(urunlerOzellikler);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUrunYatakodalari(UrunlerYatakodalari urunlerYatakodalari)
        {
            var res = _urunlerYatakodalariRepo.Insert(urunlerYatakodalari);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Update

        public Urunler UpdateUrunler(Urunler urunler)
        {
            return _urunlerRepo.Update(urunler);
        }

        public UrunlerBanyolar UpdateUrunlerBanyolar(UrunlerBanyolar urunlerBanyolar)
        {
            return _urunlerBanyolarRepo.Update(urunlerBanyolar);
        }

        public UrunlerDegiskenler UpdateUrunlerDegiskenler(UrunlerDegiskenler urunlerDegiskenler)
        {
            return _urunlerDegiskenlerRepo.Update(urunlerDegiskenler);
        }


        public UrunlerEkfiyat UpdateUrunlerEkfiyat(UrunlerEkfiyat urunlerEkfiyat)
        {
            return _urunlerEkfiyatRepo.Update(urunlerEkfiyat);
        }

        public UrunlerFiyat UpdateUrunlerFiyat(UrunlerFiyat urunlerFiyat)
        {
            return _urunlerFiyatRepo.Update(urunlerFiyat);
        }

        public UrunlerIstatistik UpdateUrunlerIstatistik(UrunlerIstatistik urunlerIstatistik)
        {
            return _urunlerIstatistikRepo.Update(urunlerIstatistik);
        }

        public UrunlerKampanyalar UpdateUrunlerKampanyalar(UrunlerKampanyalar urunlerKampanyalar)
        {
            return _urunlerKampanyalarRepo.Update(urunlerKampanyalar);
        }

        public UrunlerKategoriler UpdateUrunlerKategoriler(UrunlerKategoriler urunlerKategoriler)
        {
            return _urunlerKategorilerRepo.Update(urunlerKategoriler);
        }

        public UrunlerKontrat UpdateUrunlerKontrat(UrunlerKontrat urunlerKontrat)
        {
            return _urunlerKontratRepo.Update(urunlerKontrat);
        }

        public UrunlerOperatorler UpdateUrunlerOperatorler(UrunlerOperatorler urunlerOperatorler)
        {
            return _urunlerOperatorlerRepo.Update(urunlerOperatorler);
        }

     

        public UrunlerOzellikler UpdateUrunOzellikler(UrunlerOzellikler urunlerOzellikler)
        {
            return _urunlerOzelliklerRepo.Update(urunlerOzellikler);
        }

        public UrunlerResim UpdateUrunResim(UrunlerResim urunlerResim)
        {
            return _urunlerResimRepo.Update(urunlerResim);
        }

        public UrunlerVitrin UpdateUrunVitrin(UrunlerVitrin urunlerVitrin)
        {
            return _urunlerVitrinRepo.Update(urunlerVitrin);
        }

        public UrunlerYatakodalari UpdateUrunYatakodalari(UrunlerYatakodalari urunlerYatakodalari)
        {
            return _urunlerYatakodalariRepo.Update(urunlerYatakodalari);
        }




        #endregion



    }
}
