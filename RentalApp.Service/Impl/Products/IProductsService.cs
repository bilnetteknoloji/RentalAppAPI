using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl.Products
{
    public interface IProductsService
    {
        #region methods
        IList<Urunler> GetUrunlerByurunId(int urunid);
        IList<UrunlerBanyolar> GetUrunlerBanyolarByUBanyoId(int urunbanyoid);
        IList<UrunlerYatakodalari> GetUrunlerYatakodalariByUYatakOdaId(int urunyatakodasi_id);
        IList<UrunlerDegiskenler> GetUrunlerDegiskenlerByUDegisenId(int urundegiskenid);
        IList<UrunlerFiyat> GetUrunlerFiyatByUFiyatId(int fiyatid);
        IList<UrunlerEkfiyat> GetUrunlerEkfiyatByUEkFiyatId(int urunekfiyatid);
        IList<UrunlerKampanyalar> GetUrunlerKampanyalarByUKampanyaId(int urunkampanyaid);
        IList<UrunlerIstatistik> GetUrunlerIstatistikByUistatistikId(int istatistikid);
        IList<UrunlerKategoriler> GetUrunlerKategorilerByUKategorilerId(int urunkategoriid);
        IList<UrunlerKontrat> GetUrunlerKontratByUKontratId(int kontratid);
        IList<UrunlerOperatorler> GetUrunlerOperatorlerByUOperatorlerId(int urunoperatorid);
        IList<UrunlerOzellikler> GetUrunlerOzelliklerByUOzellillerId(int urunozellikid);
        IList<UrunlerResim> GetUrunlerResimByUResimId(int resimid);
        IList<UrunlerVitrin> GetUrunlerVitrinByUVitrinId(int vitrinid);

        #endregion

        #region Product

        Urunler GetUrunlerById(int urunid);
        IList<Urunler> GetAllUrunler();
        IList<Urunler> GetUrunlerByIds(IList<int> urunIds);
        bool DeleteUrunler(Urunler urunler);
        Urunler UpdateUrunler(Urunler urunler);
        bool InsertUrunler(Urunler urunler);

        #endregion

        #region Product Bathroom

        UrunlerBanyolar GetUrunlerBanyolarById(int urunbanyoid);
        IList<UrunlerBanyolar> GetAllUrunlerBanyolar(int urunbanyoid);
        IList<UrunlerBanyolar> GetAllUrunlerBanyolars();
        bool DeleteUrunlerBanyolar(UrunlerBanyolar urunlerBanyolar);
        UrunlerBanyolar UpdateUrunlerBanyolar(UrunlerBanyolar urunlerBanyolar);
        bool InsertUrunlerBanyolar(UrunlerBanyolar urunlerBanyolar);

        #endregion

        #region Products Bedrooms
        UrunlerYatakodalari GetUrunlerYatakodalariById(int urunyatakodasiid);
        IList<UrunlerYatakodalari> GetAllUrunYatakodalari(int urunyatakodasiid);
        IList<UrunlerYatakodalari> GetAllUrunlerYatakOdalaris();
        bool DeleteUrunYatakodalari(UrunlerYatakodalari urunlerYatakodalari);
        UrunlerYatakodalari UpdateUrunYatakodalari(UrunlerYatakodalari urunlerYatakodalari);
        bool InsertUrunYatakodalari(UrunlerYatakodalari urunlerYatakodalari);

        #endregion

        #region Products Variables
        UrunlerDegiskenler GetUrunlerDegiskenlerById(int urundegiskenid);
        IList<UrunlerDegiskenler> GetAllUrunlerDegiskenler(int urundegiskenid);
        IList<UrunlerDegiskenler> GetAllUrunlerDegiskenlers();
        bool DeleteUrunlerDegiskenler(UrunlerDegiskenler urunlerDegiskenler);
        UrunlerDegiskenler UpdateUrunlerDegiskenler(UrunlerDegiskenler urunlerDegiskenler);
        bool InsertUrunlerDegiskenler(UrunlerDegiskenler urunlerDegiskenler);
        #endregion

        #region Products price
        UrunlerFiyat GetUrunlerFiyatById(int fiyatid);
        IList<UrunlerFiyat> GetAllUrunlerFiyat(int fiyatid);
        IList<UrunlerFiyat> GetAllUrunlerFiyats();
        bool DeleteUrunlerFiyat(UrunlerFiyat urunlerFiyat);
        UrunlerFiyat UpdateUrunlerFiyat(UrunlerFiyat urunlerFiyat);
        bool InsertUrunlerFiyat(UrunlerFiyat urunlerFiyat);

        #endregion

        #region Products additional price
        UrunlerEkfiyat GetUrunlerEkfiyatById(int urunekfiyatid);
        IList<UrunlerEkfiyat> GetAllUrunlerEkfiyat(int urunekfiyatid);
        IList<UrunlerEkfiyat> GetAllUrunlerEkFiyats();
        bool DeleteUrunlerEkfiyat(UrunlerEkfiyat urunlerEkfiyat);
        UrunlerEkfiyat UpdateUrunlerEkfiyat(UrunlerEkfiyat urunlerEkfiyat);
        bool InsertUrunlerEkfiyat(UrunlerEkfiyat urunlerEkfiyat);

        #endregion

        #region Products Campaigns
        UrunlerKampanyalar GetUrunlerKampanyalarById(int urunkampanyaid);
        IList<UrunlerKampanyalar> GetAllUrunlerKampanyalar(int urunkampanyaid);
        IList<UrunlerKampanyalar> GetAllUrunlerKampanyalars();
        bool DeleteUrunlerKampanyalar(UrunlerKampanyalar urunlerKampanyalar);
        UrunlerKampanyalar UpdateUrunlerKampanyalar(UrunlerKampanyalar urunlerKampanyalar);
        bool InsertUrunlerKampanyalar(UrunlerKampanyalar urunlerKampanyalar);

        #endregion

        #region Products Statistics
        UrunlerIstatistik GetUrunlerIstatistikById(int IstatistikId);
        IList<UrunlerIstatistik> GetAllUrunlerIstatistik(int istatistikid);
        IList<UrunlerIstatistik> GetAllUrunlerIstatistiks();
        bool DeleteUrunlerIstatistik(UrunlerIstatistik urunlerIstatistik);
        UrunlerIstatistik UpdateUrunlerIstatistik(UrunlerIstatistik urunlerIstatistik);
        bool InsertUrunlerIstatistik(UrunlerIstatistik urunlerIstatistik);
        #endregion

        #region Products Categories
        UrunlerKategoriler GetUrunlerKategorilerById(int urunkategoriid);
        IList<UrunlerKategoriler> GetAllUrunlerKategoriler(int urunkategoriid);
        IList<UrunlerKategoriler> GetAllUrunlerKategorilers();
        bool DeleteUrunlerKategorilerById(UrunlerKategoriler urunlerKategoriler);
        UrunlerKategoriler UpdateUrunlerKategoriler(UrunlerKategoriler urunlerKategoriler);
        bool InsertUrunlerKategoriler(UrunlerKategoriler urunlerKategoriler);

        #endregion

        #region Products Contract
        UrunlerKontrat GetUrunlerKontratById(int kontratid);
        IList<UrunlerKontrat> GetAllUrunlerKontrat(int kontratid);
        IList<UrunlerKontrat> GetAllUrunlerKontrats();
        bool DeleteUrunlerKontratById(UrunlerKontrat urunlerKontrat);
        UrunlerKontrat UpdateUrunlerKontrat(UrunlerKontrat urunlerKontrat);
        bool InsertUrunlerKontrat(UrunlerKontrat urunlerKontrat);
        #endregion

        #region Products Operators
        UrunlerOperatorler GetUrunlerOperatorlerById(int urunoperatorid);
        IList<UrunlerOperatorler> GetAllUrunlerOperatorler(int urunoperatorid);
        IList<UrunlerOperatorler> GetAllUrunlerOperatorler();
        bool DeleteUrunlerOperatorlerById(UrunlerOperatorler urunlerOperatorler);
        UrunlerOperatorler UpdateUrunlerOperatorler(UrunlerOperatorler urunlerOperatorler);
        bool InsertUrunlerOperatorler(UrunlerOperatorler urunlerOperatorler);

        #endregion

        #region Products Features
        UrunlerOzellikler GetUrunlerOzelliklerById (int urunozellikid);
        IList<UrunlerOzellikler> GetAllUrunlerOzellikler(int urunozellikid);
        IList<UrunlerOzellikler> GetAllUrunlerOzelliklers();
        bool DeleteUrunlerOzelliklerById(UrunlerOzellikler urunlerOzellikler);
        UrunlerOzellikler UpdateUrunOzellikler(UrunlerOzellikler urunlerOzellikler);
        bool InsertUrunOzellikler(UrunlerOzellikler urunlerOzellikler);

        #endregion

        #region Products Picture
        UrunlerResim GetUrunlerResimById(int resimid);
        IList<UrunlerResim> GetAllUrunlerResim(int resimid);
        IList<UrunlerResim> GetAllUrunlerResims();
        bool DeleteUrunlerResimById(UrunlerResim urunlerResim);
        UrunlerResim UpdateUrunResim(UrunlerResim urunlerResim);
        bool InsertUrunlerResim(UrunlerResim urunlerResim);

        #endregion

        #region Products Showcase
        UrunlerVitrin GetUrunlerVitrinById(int vitrinid);
        IList<UrunlerVitrin> GetAllUrunlerVitrin(int vitrinid);
        IList<UrunlerVitrin> GetAllUrunlerVitrins();
        bool DeleteUrunlerVitrinById(UrunlerVitrin urunlerVitrin);
        UrunlerVitrin UpdateUrunVitrin(UrunlerVitrin urunlerVitrin);
        bool InsertUrunlerVitrin(UrunlerVitrin urunlerVitrin);

        #endregion

    }
}
