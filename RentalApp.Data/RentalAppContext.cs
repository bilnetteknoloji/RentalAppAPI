using Microsoft.EntityFrameworkCore;
using RentalApp.Core;
using RentalApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Data
{
    public class RentalAppContext : DbContext
    {
        public RentalAppContext()
        {

        }

        public RentalAppContext(DbContextOptions<RentalAppContext> options)
             : base(options)
        {
        }


        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<AcentePersonelLoglar> AcentePersonelLoglars { get; set; } = null!;
        public virtual DbSet<AcentePersoneller> AcentePersonellers { get; set; } = null!;
        public virtual DbSet<Acenteler> Acentelers { get; set; } = null!;
        public virtual DbSet<AcentelerUrunler> AcentelerUrunlers { get; set; } = null!;
        public virtual DbSet<Ayarlar> Ayarlars { get; set; } = null!;
        public virtual DbSet<Bankalar> Bankalars { get; set; } = null!;
        public virtual DbSet<Birimler> Birimlers { get; set; } = null!;
        public virtual DbSet<BirimlerDil> BirimlerDils { get; set; } = null!;
        public virtual DbSet<Bloglar> Bloglars { get; set; } = null!;
        public virtual DbSet<Bolgeler> Bolgelers { get; set; } = null!;
        public virtual DbSet<BolgelerDil> BolgelerDils { get; set; } = null!;
        public virtual DbSet<BolgelerResim> BolgelerResims { get; set; } = null!;
        public virtual DbSet<Cariler> Carilers { get; set; } = null!;
        public virtual DbSet<Degiskengruplar> Degiskengruplars { get; set; } = null!;
        public virtual DbSet<DegiskengruplarDil> DegiskengruplarDils { get; set; } = null!;
        public virtual DbSet<Degiskenler> Degiskenlers { get; set; } = null!;
        public virtual DbSet<DegiskenlerDil> DegiskenlerDils { get; set; } = null!;
        public virtual DbSet<Departmanlar> Departmanlars { get; set; } = null!;
        public virtual DbSet<Diller> Dillers { get; set; } = null!;
        public virtual DbSet<DolulukTakvimi> DolulukTakvimis { get; set; } = null!;
        public virtual DbSet<DovizKuru> DovizKurus { get; set; } = null!;
        public virtual DbSet<Ekhizmetler> Ekhizmetlers { get; set; } = null!;
        public virtual DbSet<EkhizmetlerDil> EkhizmetlerDils { get; set; } = null!;
        public virtual DbSet<EkhizmetlerFiyat> EkhizmetlerFiyats { get; set; } = null!;
        public virtual DbSet<Epostalistesi> Epostalistesis { get; set; } = null!;
        public virtual DbSet<EpostalistesiAlicilar> EpostalistesiAlicilars { get; set; } = null!;
        public virtual DbSet<EpostalistesiGonderiler> EpostalistesiGonderilers { get; set; } = null!;
        public virtual DbSet<EvsahibiLoglar> EvsahibiLoglars { get; set; } = null!;
        public virtual DbSet<Ilceler> Ilcelers { get; set; } = null!;
        public virtual DbSet<IlcelerDil> IlcelerDils { get; set; } = null!;
        public virtual DbSet<IlcelerResim> IlcelerResims { get; set; } = null!;
        public virtual DbSet<Iller> Illers { get; set; } = null!;
        public virtual DbSet<IllerDil> IllerDils { get; set; } = null!;
        public virtual DbSet<IllerResim> IllerResims { get; set; } = null!;
        public virtual DbSet<Kampanyalar> Kampanyalars { get; set; } = null!;
        public virtual DbSet<Kategoriler> Kategorilers { get; set; } = null!;
        public virtual DbSet<KategorilerDil> KategorilerDils { get; set; } = null!;
        public virtual DbSet<KbsTesisler> KbsTesislers { get; set; } = null!;
        public virtual DbSet<KiralamaResimler> KiralamaResimlers { get; set; } = null!;
        public virtual DbSet<KiralamaTalepleri> KiralamaTalepleris { get; set; } = null!;
        public virtual DbSet<Kredikartlari> Kredikartlaris { get; set; } = null!;
        public virtual DbSet<KullaniciIstekleri> KullaniciIstekleris { get; set; } = null!;
        public virtual DbSet<Mesajlar> Mesajlars { get; set; } = null!;
        public virtual DbSet<MhsbHareketler> MhsbHareketlers { get; set; } = null!;
        public virtual DbSet<MhsbHesapPlani> MhsbHesapPlanis { get; set; } = null!;
        public virtual DbSet<MhsbKasalar> MhsbKasalars { get; set; } = null!;
        public virtual DbSet<Mhsbfaturalar> Mhsbfaturalars { get; set; } = null!;
        public virtual DbSet<MhsbfaturalarDetay> MhsbfaturalarDetays { get; set; } = null!;
        public virtual DbSet<Mhsbislemtipleri> Mhsbislemtipleris { get; set; } = null!;
        public virtual DbSet<Moduller> Modullers { get; set; } = null!;
        public virtual DbSet<Odemetipleri> Odemetipleris { get; set; } = null!;
        public virtual DbSet<OneriSablonlari> OneriSablonlaris { get; set; } = null!;
        public virtual DbSet<Onrezervasyonlar> Onrezervasyonlars { get; set; } = null!;
        public virtual DbSet<OnrezervasyonlarEkhizmet> OnrezervasyonlarEkhizmets { get; set; } = null!;
        public virtual DbSet<OnrezervasyonlarNeden> OnrezervasyonlarNedens { get; set; } = null!;
        public virtual DbSet<OnrezervasyonlarUrun> OnrezervasyonlarUruns { get; set; } = null!;
        public virtual DbSet<OperasyonTurleri> OperasyonTurleris { get; set; } = null!;
        public virtual DbSet<Ozellikgruplar> Ozellikgruplars { get; set; } = null!;
        public virtual DbSet<OzellikgruplarDil> OzellikgruplarDils { get; set; } = null!;
        public virtual DbSet<Ozellikler> Ozelliklers { get; set; } = null!;
        public virtual DbSet<OzelliklerDil> OzelliklerDils { get; set; } = null!;
        public virtual DbSet<ParaBirimler> ParaBirimlers { get; set; } = null!;
        public virtual DbSet<PersonelIstakipleri> PersonelIstakipleris { get; set; } = null!;
        public virtual DbSet<PersonelLoglar> PersonelLoglars { get; set; } = null!;
        public virtual DbSet<PersonelLogtipleri> PersonelLogtipleris { get; set; } = null!;
        public virtual DbSet<Personeller> Personellers { get; set; } = null!;
        public virtual DbSet<PersonellerYetki> PersonellerYetkis { get; set; } = null!;
        public virtual DbSet<RaporSablongruplar> RaporSablongruplars { get; set; } = null!;
        public virtual DbSet<RaporSablonlari> RaporSablonlaris { get; set; } = null!;
        public virtual DbSet<ResimlerIcinAnahtarKelime> ResimlerIcinAnahtarKelimes { get; set; } = null!;
        public virtual DbSet<Rezervasyonlar> Rezervasyonlars { get; set; } = null!;
        public virtual DbSet<RezervasyonlarBilgi> RezervasyonlarBilgis { get; set; } = null!;
        public virtual DbSet<RezervasyonlarEkhizmet> RezervasyonlarEkhizmets { get; set; } = null!;
        public virtual DbSet<RezervasyonlarUrun> RezervasyonlarUruns { get; set; } = null!;
        public virtual DbSet<Sayfalar> Sayfalars { get; set; } = null!;
        public virtual DbSet<Semtler> Semtlers { get; set; } = null!;
        public virtual DbSet<SemtlerDil> SemtlerDils { get; set; } = null!;
        public virtual DbSet<SemtlerResim> SemtlerResims { get; set; } = null!;
        public virtual DbSet<Siniflar> Siniflars { get; set; } = null!;
        public virtual DbSet<SiniflarDil> SiniflarDils { get; set; } = null!;
        public virtual DbSet<Sirketler> Sirketlers { get; set; } = null!;
        public virtual DbSet<Sistemloglari> Sistemloglaris { get; set; } = null!;
        public virtual DbSet<SiteUyelerFavoriler> SiteUyelerFavorilers { get; set; } = null!;
        public virtual DbSet<SiteUyelerRezervasyonlar> SiteUyelerRezervasyonlars { get; set; } = null!;
        public virtual DbSet<SitedilCeviriler> SitedilCevirilers { get; set; } = null!;
        public virtual DbSet<SitedilKelimeler> SitedilKelimelers { get; set; } = null!;
        public virtual DbSet<Siteler> Sitelers { get; set; } = null!;
        public virtual DbSet<SitelerDegiskengruplar> SitelerDegiskengruplars { get; set; } = null!;
        public virtual DbSet<SitelerDegiskenler> SitelerDegiskenlers { get; set; } = null!;
        public virtual DbSet<SitelerDiller> SitelerDillers { get; set; } = null!;
        public virtual DbSet<SitelerEkhizmetler> SitelerEkhizmetlers { get; set; } = null!;
        public virtual DbSet<SitelerKampanyalar> SitelerKampanyalars { get; set; } = null!;
        public virtual DbSet<SitelerKategoriler> SitelerKategorilers { get; set; } = null!;
        public virtual DbSet<SitelerOzellikgruplar> SitelerOzellikgruplars { get; set; } = null!;
        public virtual DbSet<SitelerOzellikler> SitelerOzelliklers { get; set; } = null!;
        public virtual DbSet<SitelerParabirimleri> SitelerParabirimleris { get; set; } = null!;
        public virtual DbSet<SitelerSiniflar> SitelerSiniflars { get; set; } = null!;
        public virtual DbSet<SitelerUrunler> SitelerUrunlers { get; set; } = null!;
        public virtual DbSet<Slider> Sliders { get; set; } = null!;
        public virtual DbSet<Smslistesi> Smslistesis { get; set; } = null!;
        public virtual DbSet<SssSorular> SssSorulars { get; set; } = null!;
        public virtual DbSet<Ulkeler> Ulkelers { get; set; } = null!;
        public virtual DbSet<Urunler> Urunlers { get; set; } = null!;
        public virtual DbSet<UrunlerBanyolar> UrunlerBanyolars { get; set; } = null!;
        public virtual DbSet<UrunlerDegiskenler> UrunlerDegiskenlers { get; set; } = null!;
        public virtual DbSet<UrunlerDil> UrunlerDils { get; set; } = null!;
        public virtual DbSet<UrunlerEkfiyat> UrunlerEkfiyats { get; set; } = null!;
        public virtual DbSet<UrunlerFiyat> UrunlerFiyats { get; set; } = null!;
        public virtual DbSet<UrunlerIstatistik> UrunlerIstatistiks { get; set; } = null!;
        public virtual DbSet<UrunlerKampanyalar> UrunlerKampanyalars { get; set; } = null!;
        public virtual DbSet<UrunlerKategoriler> UrunlerKategorilers { get; set; } = null!;
        public virtual DbSet<UrunlerKontrat> UrunlerKontrats { get; set; } = null!;
        public virtual DbSet<UrunlerOperatorler> UrunlerOperatorlers { get; set; } = null!;
        public virtual DbSet<UrunlerOzellikler> UrunlerOzelliklers { get; set; } = null!;
        public virtual DbSet<UrunlerResim> UrunlerResims { get; set; } = null!;
        public virtual DbSet<UrunlerVitrin> UrunlerVitrins { get; set; } = null!;
        public virtual DbSet<UrunlerYatakodalari> UrunlerYatakodalaris { get; set; } = null!;
        public virtual DbSet<UrunlerYorum> UrunlerYorums { get; set; } = null!;
        public virtual DbSet<Vwdolugunler> Vwdolugunlers { get; set; } = null!;
        public virtual DbSet<VwepostalistesiGonderileralicilar> VwepostalistesiGonderileralicilars { get; set; } = null!;
        public virtual DbSet<Vwfaturaurunbilgi> Vwfaturaurunbilgis { get; set; } = null!;
        public virtual DbSet<Vwfiltreurunler> Vwfiltreurunlers { get; set; } = null!;
        public virtual DbSet<Vwkampanyalar> Vwkampanyalars { get; set; } = null!;
        public virtual DbSet<Vwmhsbfaturalar> Vwmhsbfaturalars { get; set; } = null!;
        public virtual DbSet<VwmhsbfaturalarXyz> VwmhsbfaturalarXyzs { get; set; } = null!;
        public virtual DbSet<Vwoperasyonlar> Vwoperasyonlars { get; set; } = null!;
        public virtual DbSet<Vwozellikgruplar> Vwozellikgruplars { get; set; } = null!;
        public virtual DbSet<Vwozellikler> Vwozelliklers { get; set; } = null!;
        public virtual DbSet<Vwrezervasyonlaruygunluk> Vwrezervasyonlaruygunluks { get; set; } = null!;
        public virtual DbSet<Vwtrdegiskengruplar> Vwtrdegiskengruplars { get; set; } = null!;
        public virtual DbSet<Vwtrdegiskenler> Vwtrdegiskenlers { get; set; } = null!;
        public virtual DbSet<Vwtrekhizmetler> Vwtrekhizmetlers { get; set; } = null!;
        public virtual DbSet<Vwtrkategoriler> Vwtrkategorilers { get; set; } = null!;
        public virtual DbSet<Vwtrozellikgruplar> Vwtrozellikgruplars { get; set; } = null!;
        public virtual DbSet<Vwtrozellikler> Vwtrozelliklers { get; set; } = null!;
        public virtual DbSet<Vwtrsiniflar> Vwtrsiniflars { get; set; } = null!;
        public virtual DbSet<Vwurunler> Vwurunlers { get; set; } = null!;
        public virtual DbSet<VwurunlerEkfiyatlar> VwurunlerEkfiyatlars { get; set; } = null!;
        public virtual DbSet<VwurunlerEkhizmetler> VwurunlerEkhizmetlers { get; set; } = null!;
        public virtual DbSet<VwurunlerFiyat> VwurunlerFiyats { get; set; } = null!;
        public virtual DbSet<VwurunlerKontrat> VwurunlerKontrats { get; set; } = null!;
        public virtual DbSet<VwurunlerKontratfiyat> VwurunlerKontratfiyats { get; set; } = null!;
        public virtual DbSet<VwurunlerOzellikdeger> VwurunlerOzellikdegers { get; set; } = null!;
        public virtual DbSet<VwurunlerOzellikdegerleri> VwurunlerOzellikdegerleris { get; set; } = null!;
        public virtual DbSet<Websiteler> Websitelers { get; set; } = null!;
        public virtual DbSet<WebsitelerAnalitik> WebsitelerAnalitiks { get; set; } = null!;
        public virtual DbSet<WebsitelerSeo> WebsitelerSeos { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcentePersonelLoglar>(entity =>
            {
                entity.HasKey(e => new { e.LogId, e.LogtipId, e.ModulId, e.PersonelId })
                    .HasName("PK__acente_p__5E2386D02B981976");

                entity.ToTable("acente_personel_loglar");

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("log_id");

                entity.Property(e => e.LogtipId).HasColumnName("logtip_id");

                entity.Property(e => e.ModulId).HasColumnName("modul_id");

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.Property(e => e.KayitId).HasColumnName("kayit_id");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AcentePersoneller>(entity =>
            {
                entity.HasKey(e => new { e.PersonelId, e.AcenteId })
                    .HasName("PK__acente_p__056F214F76215979");

                entity.ToTable("acente_personeller");

                entity.Property(e => e.PersonelId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("personel_id");

                entity.Property(e => e.AcenteId)
                    .HasColumnName("acente_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("335 Kodlu");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(100)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(128)
                    .HasColumnName("eposta");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(64)
                    .HasColumnName("gsm")
                    .HasDefaultValueSql("('000 000 0000')");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(64)
                    .HasColumnName("sifre");
            });

            modelBuilder.Entity<Acenteler>(entity =>
            {
                entity.HasKey(e => new { e.AcenteId, e.CariId })
                    .HasName("PK__acentele__DCA72D056033624C");

                entity.ToTable("acenteler");

                entity.Property(e => e.AcenteId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("acente_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Unvan)
                    .HasMaxLength(500)
                    .HasColumnName("unvan");
            });

            modelBuilder.Entity<AcentelerUrunler>(entity =>
            {
                entity.HasKey(e => new { e.AcenteUrunId, e.AcenteId, e.UrunId })
                    .HasName("PK__acentele__AA9E6593B8EA21DF");

                entity.ToTable("acenteler_urunler");

                entity.Property(e => e.AcenteUrunId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("acente_urun_id");

                entity.Property(e => e.AcenteId).HasColumnName("acente_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Izin).HasColumnName("izin");

                entity.Property(e => e.KomisyonOran)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("komisyon_oran");
            });

            modelBuilder.Entity<Ayarlar>(entity =>
            {
                entity.HasKey(e => new { e.AyarId, e.Anadil })
                    .HasName("PK__ayarlar__3C32D2F8E9433D61");

                entity.ToTable("ayarlar");

                entity.Property(e => e.AyarId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ayar_id");

                entity.Property(e => e.Anadil).HasColumnName("anadil");

                entity.Property(e => e.FaturaSayac)
                    .HasColumnName("fatura_sayac")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FaturaSeri)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fatura_seri")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.FisSayac)
                    .HasColumnName("fis_sayac")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FisSeri)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fis_seri")
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<Bankalar>(entity =>
            {
                entity.HasKey(e => new { e.BankaId, e.BirimId })
                    .HasName("PK__bankalar__945CA812EE3D53FB");

                entity.ToTable("bankalar");

                entity.Property(e => e.BankaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("banka_id");

                entity.Property(e => e.BirimId)
                    .HasColumnName("birim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Adres)
                    .HasMaxLength(255)
                    .HasColumnName("adres");

                entity.Property(e => e.Banka)
                    .HasMaxLength(255)
                    .HasColumnName("banka");

                entity.Property(e => e.Iban)
                    .HasMaxLength(255)
                    .HasColumnName("iban");

                entity.Property(e => e.Sube)
                    .HasMaxLength(255)
                    .HasColumnName("sube");

                entity.Property(e => e.SwiftKodu)
                    .HasMaxLength(255)
                    .HasColumnName("swift_kodu");

                entity.Property(e => e.Unvan)
                    .HasMaxLength(255)
                    .HasColumnName("unvan")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<Birimler>(entity =>
            {
                entity.HasKey(e => e.BirimId)
                    .HasName("PK__birimler__09A47847D6B51A2A");

                entity.ToTable("birimler");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.Birim)
                    .HasMaxLength(128)
                    .HasColumnName("birim");
            });

            modelBuilder.Entity<BirimlerDil>(entity =>
            {
                entity.HasKey(e => new { e.BirimdilId, e.BirimId, e.DilId })
                    .HasName("PK__birimler__5E2F496E32BF0773");

                entity.ToTable("birimler_dil");

                entity.Property(e => e.BirimdilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("birimdil_id");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Sembol)
                    .HasMaxLength(255)
                    .HasColumnName("sembol");
            });

            modelBuilder.Entity<Bloglar>(entity =>
            {
                entity.HasKey(e => new { e.BlogId, e.DilId, e.SiteId })
                    .HasName("PK__bloglar__55B407D0C2C806D8");

                entity.ToTable("bloglar");

                entity.Property(e => e.BlogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("blog_id");

                entity.Property(e => e.DilId)
                    .HasColumnName("dil_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SiteId)
                    .HasColumnName("site_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(500)
                    .HasColumnName("baslik");

                entity.Property(e => e.Etiketler).HasColumnName("etiketler");

                entity.Property(e => e.Icerik).HasColumnName("icerik");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Ozet)
                    .HasColumnName("ozet")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim")
                    .HasDefaultValueSql("('resimyok.jpg')");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Bolgeler>(entity =>
            {
                entity.HasKey(e => e.BolgeId)
                    .HasName("PK__bolgeler__CECE8EB3CA410F1D");

                entity.ToTable("bolgeler");

                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");

                entity.Property(e => e.Bolge)
                    .HasMaxLength(255)
                    .HasColumnName("bolge");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<BolgelerDil>(entity =>
            {
                entity.HasKey(e => new { e.BolgedilId, e.DilId, e.BolgeId })
                    .HasName("PK__bolgeler__8923238245BD8684");

                entity.ToTable("bolgeler_dil");

                entity.Property(e => e.BolgedilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("bolgedil_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Tagler)
                    .HasColumnName("tagler")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<BolgelerResim>(entity =>
            {
                entity.HasKey(e => new { e.ResimId, e.BolgeId })
                    .HasName("PK__bolgeler__DCE59829CA442049");

                entity.ToTable("bolgeler_resim");

                entity.Property(e => e.ResimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("resim_id");

                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<Cariler>(entity =>
            {
                entity.HasKey(e => new { e.CariId, e.HesapId })
                    .HasName("PK__cariler__F35AFDDC2B0D5FF7");

                entity.ToTable("cariler");

                entity.Property(e => e.CariId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cari_id");

                entity.Property(e => e.HesapId)
                    .HasColumnName("hesap_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Adres)
                    .HasMaxLength(255)
                    .HasColumnName("adres");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Alici)
                    .IsRequired()
                    .HasColumnName("alici")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Banka)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("banka");

                entity.Property(e => e.CariKodu)
                    .HasMaxLength(255)
                    .HasColumnName("cari_kodu")
                    .HasDefaultValueSql("('CARIKODU')");

                entity.Property(e => e.EkhizmetSatici).HasColumnName("ekhizmet_satici");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(255)
                    .HasColumnName("eposta");

                entity.Property(e => e.FaturaAdres)
                    .HasColumnName("fatura_adres")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.FaturaUnvan)
                    .HasMaxLength(500)
                    .HasColumnName("fatura_unvan")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(255)
                    .HasColumnName("gsm");

                entity.Property(e => e.Iban)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("iban");

                entity.Property(e => e.Kullaniciadi)
                    .HasMaxLength(255)
                    .HasColumnName("kullaniciadi");

                entity.Property(e => e.Parola)
                    .HasMaxLength(24)
                    .HasColumnName("parola");

                entity.Property(e => e.Satici).HasColumnName("satici");

                entity.Property(e => e.Tcpasno)
                    .HasMaxLength(255)
                    .HasColumnName("tcpasno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tel)
                    .HasMaxLength(255)
                    .HasColumnName("tel");

                entity.Property(e => e.VergiDairesi)
                    .HasMaxLength(255)
                    .HasColumnName("vergi_dairesi")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Vergino)
                    .HasMaxLength(255)
                    .HasColumnName("vergino")
                    .HasDefaultValueSql("('111111111111')");
            });

            modelBuilder.Entity<Degiskengruplar>(entity =>
            {
                entity.HasKey(e => new { e.DegiskengrupId, e.SinifId })
                    .HasName("PK__degisken__E81C98294023A243");

                entity.ToTable("degiskengruplar");

                entity.Property(e => e.DegiskengrupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("degiskengrup_id");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Filtrede).HasColumnName("filtrede");

                entity.Property(e => e.Geneltanim)
                    .HasMaxLength(255)
                    .HasColumnName("geneltanim");
            });

            modelBuilder.Entity<DegiskengruplarDil>(entity =>
            {
                entity.HasKey(e => new { e.DegiskengrupDilId, e.DilId, e.DegiskengrupId })
                    .HasName("PK__degisken__72CFE975F78349BC");

                entity.ToTable("degiskengruplar_dil");

                entity.Property(e => e.DegiskengrupDilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("degiskengrup_dil_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.DegiskengrupId).HasColumnName("degiskengrup_id");

                entity.Property(e => e.Degiskengrup)
                    .HasMaxLength(255)
                    .HasColumnName("degiskengrup")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Degiskenler>(entity =>
            {
                entity.HasKey(e => new { e.DegiskenId, e.DegiskengrupId })
                    .HasName("PK__degisken__C94C393FD4DF23AC");

                entity.ToTable("degiskenler");

                entity.Property(e => e.DegiskenId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("degisken_id");

                entity.Property(e => e.DegiskengrupId).HasColumnName("degiskengrup_id");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Filtrede).HasColumnName("filtrede");

                entity.Property(e => e.Geneltanim)
                    .HasMaxLength(255)
                    .HasColumnName("geneltanim");
            });

            modelBuilder.Entity<DegiskenlerDil>(entity =>
            {
                entity.HasKey(e => new { e.DegiskenDilId, e.DegiskenId, e.DilId })
                    .HasName("PK__degisken__CC42A7F46C935BB5");

                entity.ToTable("degiskenler_dil");

                entity.Property(e => e.DegiskenDilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("degisken_dil_id");

                entity.Property(e => e.DegiskenId).HasColumnName("degisken_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Degisken)
                    .HasMaxLength(255)
                    .HasColumnName("degisken");
            });

            modelBuilder.Entity<Departmanlar>(entity =>
            {
                entity.HasKey(e => e.DepartmanId)
                    .HasName("PK__departma__64F9A45CD6A6A1EB");

                entity.ToTable("departmanlar");

                entity.Property(e => e.DepartmanId).HasColumnName("departman_id");

                entity.Property(e => e.Departman)
                    .HasMaxLength(255)
                    .HasColumnName("departman");
            });

            modelBuilder.Entity<Diller>(entity =>
            {
                entity.HasKey(e => e.DilId)
                    .HasName("PK__diller__7738223A91DC5011");

                entity.ToTable("diller");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Dil)
                    .HasMaxLength(255)
                    .HasColumnName("dil");

                entity.Property(e => e.DilKisakod)
                    .HasMaxLength(255)
                    .HasColumnName("dil_kisakod");

                entity.Property(e => e.DilKod)
                    .HasMaxLength(255)
                    .HasColumnName("dil_kod");

                entity.Property(e => e.DilYon)
                    .HasMaxLength(5)
                    .HasColumnName("dil_yon");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DolulukTakvimi>(entity =>
            {
                entity.HasKey(e => new { e.DolulukId, e.UrunId, e.RezervasyonId, e.BirimId })
                    .HasName("PK__doluluk___EE39D7115341F55C_copy1");

                entity.ToTable("doluluk_takvimi");

                entity.Property(e => e.DolulukId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("doluluk_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.BirimId)
                    .HasColumnName("birim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.GirisGunu).HasColumnName("giris_gunu");

                entity.Property(e => e.Maliyet)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("maliyet");

                entity.Property(e => e.Minimum)
                    .HasColumnName("minimum")
                    .HasDefaultValueSql("((7))");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DovizKuru>(entity =>
            {
                entity.HasKey(e => new { e.KurId, e.BirimId })
                    .HasName("PK__doviz_ku__98F8FA37ED964922");

                entity.ToTable("doviz_kuru");

                entity.Property(e => e.KurId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("kur_id");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.DovizAlis)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("doviz_alis");

                entity.Property(e => e.DovizSatis)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("doviz_satis");

                entity.Property(e => e.EfektifAlis)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("efektif_alis");

                entity.Property(e => e.EfektifSatis)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("efektif_satis");

                entity.Property(e => e.Sabitkur)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("sabitkur");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<Ekhizmetler>(entity =>
            {
                entity.HasKey(e => new { e.EkhizmetId, e.SinifId })
                    .HasName("PK__ekhizmet__38BC2E98011FD12F");

                entity.ToTable("ekhizmetler");

                entity.Property(e => e.EkhizmetId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ekhizmet_id");

                entity.Property(e => e.SinifId)
                    .HasColumnName("sinif_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Geneltanim)
                    .HasMaxLength(255)
                    .HasColumnName("geneltanim");
            });

            modelBuilder.Entity<EkhizmetlerDil>(entity =>
            {
                entity.HasKey(e => new { e.EkhizmetdilId, e.EkhizmetId, e.DilId })
                    .HasName("PK__ekhizmet__09DEB4741C2CDFFC");

                entity.ToTable("ekhizmetler_dil");

                entity.Property(e => e.EkhizmetdilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ekhizmetdil_id");

                entity.Property(e => e.EkhizmetId).HasColumnName("ekhizmet_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Ekhizmet)
                    .HasMaxLength(255)
                    .HasColumnName("ekhizmet");
            });

            modelBuilder.Entity<EkhizmetlerFiyat>(entity =>
            {
                entity.HasKey(e => new { e.EkhizmetfiyatId, e.EkhizmetId, e.CariId, e.UrunId, e.SemtId, e.BirimId, e.MaliyetbirimId })
                    .HasName("PK__ekhizmet__9EF90231710DFDFE");

                entity.ToTable("ekhizmetler_fiyat");

                entity.Property(e => e.EkhizmetfiyatId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ekhizmetfiyat_id");

                entity.Property(e => e.EkhizmetId).HasColumnName("ekhizmet_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.SemtId).HasColumnName("semt_id");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.MaliyetbirimId)
                    .HasColumnName("maliyetbirim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Baslangic)
                    .HasColumnType("date")
                    .HasColumnName("baslangic")
                    .HasDefaultValueSql("(dateadd(year,datediff(year,(0),getdate()),(0)))");

                entity.Property(e => e.Bitis)
                    .HasColumnType("date")
                    .HasColumnName("bitis")
                    .HasDefaultValueSql("(dateadd(year,datediff(year,(0),getdate())+(1),(-1)))");

                entity.Property(e => e.Donem)
                    .HasColumnName("donem")
                    .HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.Istegebagli)
                    .IsRequired()
                    .HasColumnName("istegebagli")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kisibasi)
                    .HasColumnName("kisibasi")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Kişibaşı; 2: Adet(Toplam)");

                entity.Property(e => e.Maliyet)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("maliyet");

                entity.Property(e => e.Periyot)
                    .HasColumnName("periyot")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Saatlik; 2: Günlük; 3: Haftalık");

                entity.Property(e => e.Ucretli)
                    .HasColumnName("ucretli")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Ücretsiz; 2: Ücretli");
            });

            modelBuilder.Entity<Epostalistesi>(entity =>
            {
                entity.HasKey(e => e.EpostaId)
                    .HasName("PK__epostali__F19D2C42EE191E60");

                entity.ToTable("epostalistesi");

                entity.HasIndex(e => e.Eposta, "eposta")
                    .IsUnique();

                entity.Property(e => e.EpostaId).HasColumnName("eposta_id");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(255)
                    .HasColumnName("eposta");

                entity.Property(e => e.Listede)
                    .IsRequired()
                    .HasColumnName("listede")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notlar).HasColumnName("notlar");

                entity.Property(e => e.OzelKod)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("ozel_kod")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EpostalistesiAlicilar>(entity =>
            {
                entity.HasKey(e => new { e.EpostaaliciId, e.EpostagonderiId, e.EpostaId })
                    .HasName("PK__epostali__7ACDF0F50CA1BC60");

                entity.ToTable("epostalistesi_alicilar");

                entity.Property(e => e.EpostaaliciId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("epostaalici_id");

                entity.Property(e => e.EpostagonderiId).HasColumnName("epostagonderi_id");

                entity.Property(e => e.EpostaId).HasColumnName("eposta_id");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EpostalistesiGonderiler>(entity =>
            {
                entity.HasKey(e => e.EpostagonderiId)
                    .HasName("PK__epostali__E04905E7A34E4DD8");

                entity.ToTable("epostalistesi_gonderiler");

                entity.Property(e => e.EpostagonderiId).HasColumnName("epostagonderi_id");

                entity.Property(e => e.Icerik)
                    .HasColumnType("ntext")
                    .HasColumnName("icerik");

                entity.Property(e => e.Konu)
                    .HasMaxLength(255)
                    .HasColumnName("konu");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EvsahibiLoglar>(entity =>
            {
                entity.HasKey(e => new { e.LogId, e.LogtipId, e.ModulId, e.CariId })
                    .HasName("PK__evsahibi__31D52189946EFBC6");

                entity.ToTable("evsahibi_loglar");

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("log_id");

                entity.Property(e => e.LogtipId).HasColumnName("logtip_id");

                entity.Property(e => e.ModulId).HasColumnName("modul_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.KayitId).HasColumnName("kayit_id");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ilceler>(entity =>
            {
                entity.HasKey(e => new { e.IlceId, e.IlId })
                    .HasName("PK__ilceler__AED71F1B93F95323");

                entity.ToTable("ilceler");

                entity.Property(e => e.IlceId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ilce_id");

                entity.Property(e => e.IlId).HasColumnName("il_id");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(255)
                    .HasColumnName("ilce");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<IlcelerDil>(entity =>
            {
                entity.HasKey(e => new { e.IlcedilId, e.DilId, e.IlceId })
                    .HasName("PK__ilceler___35B5C683971552E0");

                entity.ToTable("ilceler_dil");

                entity.Property(e => e.IlcedilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ilcedil_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.IlceId).HasColumnName("ilce_id");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Tagler)
                    .HasColumnName("tagler")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<IlcelerResim>(entity =>
            {
                entity.HasKey(e => new { e.ResimId, e.IlceId })
                    .HasName("PK__ilceler___6448A88AF21CC8FC");

                entity.ToTable("ilceler_resim");

                entity.Property(e => e.ResimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("resim_id");

                entity.Property(e => e.IlceId).HasColumnName("ilce_id");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<Iller>(entity =>
            {
                entity.HasKey(e => new { e.IlId, e.BolgeId })
                    .HasName("PK__iller__804551D43C68A7C1");

                entity.ToTable("iller");

                entity.Property(e => e.IlId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("il_id");

                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");

                entity.Property(e => e.Il)
                    .HasMaxLength(255)
                    .HasColumnName("il");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<IllerDil>(entity =>
            {
                entity.HasKey(e => new { e.IldilId, e.DilId, e.IlId })
                    .HasName("PK__iller_di__74D9480303A09542");

                entity.ToTable("iller_dil");

                entity.Property(e => e.IldilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ildil_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.IlId).HasColumnName("il_id");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Tagler)
                    .HasColumnName("tagler")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<IllerResim>(entity =>
            {
                entity.HasKey(e => new { e.ResimId, e.IlId })
                    .HasName("PK__iller_re__1AC3EB518CD87B5A");

                entity.ToTable("iller_resim");

                entity.Property(e => e.ResimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("resim_id");

                entity.Property(e => e.IlId).HasColumnName("il_id");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<Kampanyalar>(entity =>
            {
                entity.HasKey(e => e.KampanyaId)
                    .HasName("PK__kampanya__C92ED1B0CDF7EBBB");

                entity.ToTable("kampanyalar");

                entity.Property(e => e.KampanyaId).HasColumnName("kampanya_id");

                entity.Property(e => e.KampanyaAdi)
                    .HasMaxLength(255)
                    .HasColumnName("kampanya_adi")
                    .HasDefaultValueSql("('ANCK10')");

                entity.Property(e => e.Konaklamabaslangic)
                    .HasColumnType("date")
                    .HasColumnName("konaklamabaslangic");

                entity.Property(e => e.Konaklamabitis)
                    .HasColumnType("date")
                    .HasColumnName("konaklamabitis");

                entity.Property(e => e.NetOran).HasColumnName("net_oran");

                entity.Property(e => e.Oran).HasColumnName("oran");

                entity.Property(e => e.RezTarihbaslangic)
                    .HasColumnType("date")
                    .HasColumnName("rez_tarihbaslangic");

                entity.Property(e => e.RezTarihbitis)
                    .HasColumnType("date")
                    .HasColumnName("rez_tarihbitis");

                entity.Property(e => e.Sira)
                    .HasColumnName("sira")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Sira  numarasına göre indirim uygulanır.");

                entity.Property(e => e.Tutar)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("tutar");
            });

            modelBuilder.Entity<Kategoriler>(entity =>
            {
                entity.HasKey(e => new { e.KategoriId, e.SinifId })
                    .HasName("PK__kategori__27DF60AEA3CAEAC7");

                entity.ToTable("kategoriler");

                entity.Property(e => e.KategoriId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("kategori_id");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Geneltanim)
                    .HasMaxLength(255)
                    .HasColumnName("geneltanim")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<KategorilerDil>(entity =>
            {
                entity.HasKey(e => new { e.KategoriDilId, e.KategoriId, e.DilId })
                    .HasName("PK__kategori__8448796034CEA9DD");

                entity.ToTable("kategoriler_dil");

                entity.Property(e => e.KategoriDilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("kategori_dil_id");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Kategori)
                    .HasMaxLength(255)
                    .HasColumnName("kategori");
            });

            modelBuilder.Entity<KbsTesisler>(entity =>
            {
                entity.HasKey(e => e.TesisId)
                    .HasName("PK__kbs_tesi__E8565F7D7CDAACE7");

                entity.ToTable("kbs_tesisler");

                entity.Property(e => e.TesisId).HasColumnName("tesis_id");

                entity.Property(e => e.Parola)
                    .HasMaxLength(255)
                    .HasColumnName("parola");

                entity.Property(e => e.TesisAdi)
                    .HasMaxLength(255)
                    .HasColumnName("tesis_adi");

                entity.Property(e => e.TesisKodu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tesis_kodu");

                entity.Property(e => e.YetkiliTcno)
                    .HasMaxLength(11)
                    .HasColumnName("yetkili_tcno")
                    .HasDefaultValueSql("((11111111111.))");
            });

            modelBuilder.Entity<KiralamaResimler>(entity =>
            {
                entity.HasKey(e => new { e.TalepresimId, e.TalepId })
                    .HasName("PK__kiralama__72DC3BAA81D7894B");

                entity.ToTable("kiralama_resimler");

                entity.Property(e => e.TalepresimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("talepresim_id");

                entity.Property(e => e.TalepId).HasColumnName("talep_id");

                entity.Property(e => e.Resim)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("resim");
            });

            modelBuilder.Entity<KiralamaTalepleri>(entity =>
            {
                entity.HasKey(e => new { e.TalepId, e.SiteId })
                    .HasName("PK__kiralama__4DF5FD26566CD4DF");

                entity.ToTable("kiralama_talepleri");

                entity.Property(e => e.TalepId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("talep_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Banyosayi)
                    .HasColumnName("banyosayi")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eposta")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Mesaj).HasColumnName("mesaj");

                entity.Property(e => e.Odasayi)
                    .HasColumnName("odasayi")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefon")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Villaadresi).HasColumnName("villaadresi");

                entity.Property(e => e.Yataksayi)
                    .HasColumnName("yataksayi")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Kredikartlari>(entity =>
            {
                entity.HasKey(e => new { e.KredikartiId, e.BankaId })
                    .HasName("PK__kredikar__6A5AB901F27D7463");

                entity.ToTable("kredikartlari");

                entity.Property(e => e.KredikartiId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("kredikarti_id");

                entity.Property(e => e.BankaId).HasColumnName("banka_id");

                entity.Property(e => e.Kredikarti)
                    .HasMaxLength(255)
                    .HasColumnName("kredikarti");
            });

            modelBuilder.Entity<KullaniciIstekleri>(entity =>
            {
                entity.HasKey(e => new { e.IstekId, e.GonderenId, e.ModulId, e.CozenId })
                    .HasName("PK__kullanic__55012E70B25D1D0C");

                entity.ToTable("kullanici_istekleri");

                entity.Property(e => e.IstekId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("istek_id");

                entity.Property(e => e.GonderenId).HasColumnName("gonderen_id");

                entity.Property(e => e.ModulId).HasColumnName("modul_id");

                entity.Property(e => e.CozenId).HasColumnName("cozen_id");

                entity.Property(e => e.CozumTarih)
                    .HasPrecision(3)
                    .HasColumnName("cozum_tarih");

                entity.Property(e => e.Durum)
                    .HasColumnName("durum")
                    .HasComment("-1:Çözülemedi, 0: Beklemede, 1: İşleme Alındı, 2: Çözüldü");

                entity.Property(e => e.Eknot).HasColumnName("eknot");

                entity.Property(e => e.Sorun)
                    .HasColumnName("sorun")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Mesajlar>(entity =>
            {
                entity.HasKey(e => new { e.MesajId, e.Gonderici, e.Alici })
                    .HasName("PK__mesajlar__5CE4216BC7C2845C");

                entity.ToTable("mesajlar");

                entity.Property(e => e.MesajId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("mesaj_id");

                entity.Property(e => e.Gonderici).HasColumnName("gonderici");

                entity.Property(e => e.Alici)
                    .HasColumnName("alici")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AliciSildi).HasColumnName("alici_sildi");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(255)
                    .HasColumnName("baslik");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.GondericiSildi).HasColumnName("gonderici_sildi");

                entity.Property(e => e.Mesaj).HasColumnName("mesaj");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MhsbHareketler>(entity =>
            {
                entity.HasKey(e => new { e.MhsbhareketId, e.IslemtipId, e.CariId, e.RezervasyonId, e.PersonelId, e.FaturaId, e.BankaId, e.KredikartiId, e.ParabirimId, e.UrunId, e.OperatorId })
                    .HasName("PK__mhsb_har__15F98249DBCC6FE0");

                entity.ToTable("mhsb_hareketler");

                entity.Property(e => e.MhsbhareketId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("mhsbhareket_id");

                entity.Property(e => e.IslemtipId).HasColumnName("islemtip_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.Property(e => e.FaturaId).HasColumnName("fatura_id");

                entity.Property(e => e.BankaId).HasColumnName("banka_id");

                entity.Property(e => e.KredikartiId).HasColumnName("kredikarti_id");

                entity.Property(e => e.ParabirimId)
                    .HasColumnName("parabirim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.OperatorId).HasColumnName("operator_id");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Alacak)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("alacak");

                entity.Property(e => e.Borc)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("borc");

                entity.Property(e => e.Donem)
                    .HasColumnName("donem")
                    .HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Islemtarihi)
                    .HasColumnType("date")
                    .HasColumnName("islemtarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Kdvdahil)
                    .IsRequired()
                    .HasColumnName("kdvdahil")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kdvoran)
                    .HasColumnName("kdvoran")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Kdvtutar)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("kdvtutar");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MhsbHesapPlani>(entity =>
            {
                entity.HasKey(e => e.HesapId);

                entity.ToTable("mhsb_hesap_plani");

                entity.Property(e => e.HesapId).HasColumnName("hesap_id");

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.AlthesapGrubu)
                    .HasMaxLength(255)
                    .HasColumnName("althesap_grubu")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Carpan)
                    .HasColumnName("carpan")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HesapAdi)
                    .HasMaxLength(255)
                    .HasColumnName("hesap_adi");

                entity.Property(e => e.HesapGrubu)
                    .HasMaxLength(255)
                    .HasColumnName("hesap_grubu")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.HesapKodu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hesap_kodu");

                entity.Property(e => e.Seviye)
                    .HasColumnName("seviye")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsthesapId).HasColumnName("usthesap_id");
            });

            modelBuilder.Entity<MhsbKasalar>(entity =>
            {
                entity.HasKey(e => new { e.KasaId, e.BirimId })
                    .HasName("PK__mhsb_kas__FE7E7E4AEF046C13");

                entity.ToTable("mhsb_kasalar");

                entity.Property(e => e.KasaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("kasa_id");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.KasaAd)
                    .HasMaxLength(255)
                    .HasColumnName("kasa_ad");

                entity.Property(e => e.Varsayilan).HasColumnName("varsayilan");
            });

            modelBuilder.Entity<Mhsbfaturalar>(entity =>
            {
                entity.HasKey(e => new { e.FaturaId, e.CariId, e.RezervasyonId })
                    .HasName("PK__mhsbfatu__1C0CDBCAF93E1D1B");

                entity.ToTable("mhsbfaturalar");

                entity.Property(e => e.FaturaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fatura_id");

                entity.Property(e => e.CariId)
                    .HasColumnName("cari_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.RezervasyonId)
                    .HasColumnName("rezervasyon_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.FaturaNo)
                    .HasMaxLength(255)
                    .HasColumnName("fatura_no");

                entity.Property(e => e.FaturaTur)
                    .HasColumnName("fatura_tur")
                    .HasComment("0:Satış Faturası, 1:Alış Faturası, 2:Satış İade, 3:Alış İade");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tutar)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("tutar");

                entity.Property(e => e.Vergi)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("vergi");

                entity.Property(e => e.Yazdirildi).HasColumnName("yazdirildi");
            });

            modelBuilder.Entity<MhsbfaturalarDetay>(entity =>
            {
                entity.HasKey(e => new { e.FaturadetayId, e.FaturaId })
                    .HasName("PK__mhsbfatu__0C4AF427B7FEBB28");

                entity.ToTable("mhsbfaturalar_detay");

                entity.Property(e => e.FaturadetayId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("faturadetay_id");

                entity.Property(e => e.FaturaId).HasColumnName("fatura_id");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Tutar)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("tutar");
            });

            modelBuilder.Entity<Mhsbislemtipleri>(entity =>
            {
                entity.HasKey(e => new { e.MhsbislemtipId, e.OdemeKasaId, e.TahsilatKasaId })
                    .HasName("PK__mhsbisle__69B2032BFB267825");

                entity.ToTable("mhsbislemtipleri");

                entity.Property(e => e.MhsbislemtipId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("mhsbislemtip_id");

                entity.Property(e => e.OdemeKasaId).HasColumnName("odeme_kasa_id");

                entity.Property(e => e.TahsilatKasaId).HasColumnName("tahsilat_kasa_id");

                entity.Property(e => e.AcenteIslemi).HasColumnName("acente_islemi");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.AliciIslemi).HasColumnName("alici_islemi");

                entity.Property(e => e.AvansHesabi).HasColumnName("avans_hesabi");

                entity.Property(e => e.Fatura).HasColumnName("fatura");

                entity.Property(e => e.Gelirgider).HasColumnName("gelirgider");

                entity.Property(e => e.IadeIslemi).HasColumnName("iade_islemi");

                entity.Property(e => e.Islemadi)
                    .HasMaxLength(255)
                    .HasColumnName("islemadi");

                entity.Property(e => e.Islemkodu)
                    .HasMaxLength(255)
                    .HasColumnName("islemkodu");

                entity.Property(e => e.Malzeme).HasColumnName("malzeme");

                entity.Property(e => e.PersonelIslemi).HasColumnName("personel_islemi");

                entity.Property(e => e.SaticiIslemi).HasColumnName("satici_islemi");

                entity.Property(e => e.SistemIslemi).HasColumnName("sistem_islemi");
            });

            modelBuilder.Entity<Moduller>(entity =>
            {
                entity.HasKey(e => e.ModulId)
                    .HasName("PK__moduller__728997F42C0F24FF");

                entity.ToTable("moduller");

                entity.Property(e => e.ModulId).HasColumnName("modul_id");

                entity.Property(e => e.Modul)
                    .HasMaxLength(255)
                    .HasColumnName("modul");
            });

            modelBuilder.Entity<Odemetipleri>(entity =>
            {
                entity.HasKey(e => e.OdemetipId)
                    .HasName("PK__odemetip__1B78C0D66919232F");

                entity.ToTable("odemetipleri");

                entity.Property(e => e.OdemetipId).HasColumnName("odemetip_id");

                entity.Property(e => e.Bankadan)
                    .IsRequired()
                    .HasColumnName("bankadan")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 : Banka Harici, 1 : Banka Üzerinden");

                entity.Property(e => e.Kredikarti).HasColumnName("kredikarti");

                entity.Property(e => e.Odemetipi)
                    .HasMaxLength(255)
                    .HasColumnName("odemetipi");
            });

            modelBuilder.Entity<OneriSablonlari>(entity =>
            {
                entity.HasKey(e => new { e.OnerisablonId, e.SiteId, e.DilId })
                    .HasName("PK__oneri_sa__8A4F12D9FA4E9358");

                entity.ToTable("oneri_sablonlari");

                entity.Property(e => e.OnerisablonId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("onerisablon_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Sablon).HasColumnName("sablon");
            });

            modelBuilder.Entity<Onrezervasyonlar>(entity =>
            {
                entity.HasKey(e => new { e.OnrezervasyonId, e.OperatorId, e.GorusenOperatorId, e.RezervasyonOperatorId, e.OnrezervasyoniptalnedenId, e.Hatirlatildi, e.AcenteId, e.CariId })
                    .HasName("PK__onrezerv__C4CE92FFAB93E9F8");

                entity.ToTable("onrezervasyonlar");

                entity.Property(e => e.OnrezervasyonId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("onrezervasyon_id");

                entity.Property(e => e.OperatorId).HasColumnName("operator_id");

                entity.Property(e => e.GorusenOperatorId).HasColumnName("gorusen_operator_id");

                entity.Property(e => e.RezervasyonOperatorId).HasColumnName("rezervasyon_operator_id");

                entity.Property(e => e.OnrezervasyoniptalnedenId).HasColumnName("onrezervasyoniptalneden_id");

                entity.Property(e => e.Hatirlatildi).HasColumnName("hatirlatildi");

                entity.Property(e => e.AcenteId).HasColumnName("acente_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.Bebeksayi).HasColumnName("bebeksayi");

                entity.Property(e => e.Cikistarihi)
                    .HasColumnType("date")
                    .HasColumnName("cikistarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Diger).HasColumnName("diger");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(255)
                    .HasColumnName("eposta");

                entity.Property(e => e.Giristarihi)
                    .HasColumnType("date")
                    .HasColumnName("giristarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iptalneden)
                    .HasColumnName("iptalneden")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Kisisayi)
                    .HasColumnName("kisisayi")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Musteri)
                    .HasMaxLength(255)
                    .HasColumnName("musteri");

                entity.Property(e => e.Nasilbuldu).HasColumnName("nasilbuldu");

                entity.Property(e => e.NedenId)
                    .HasColumnName("neden_id")
                    .HasComment("0: Bilgi Alma; 1: Rezervasyon");

                entity.Property(e => e.Notlar).HasColumnName("notlar");

                entity.Property(e => e.Sonuc)
                    .HasColumnName("sonuc")
                    .HasComment("0 : Görüşülmedi, 1 : Kapandı (Olumlu), 2 : Kapandı (olumsuz)");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(255)
                    .HasColumnName("telefon");

                entity.Property(e => e.Telefon2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefon2")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Yetiskinsayi).HasColumnName("yetiskinsayi");
            });

            modelBuilder.Entity<OnrezervasyonlarEkhizmet>(entity =>
            {
                entity.HasKey(e => new { e.OnrezervasyonekhizmetId, e.OnrezervasyonId, e.EkhizmetId })
                    .HasName("PK__onrezerv__C8A438DD019A6D59");

                entity.ToTable("onrezervasyonlar_ekhizmet");

                entity.Property(e => e.OnrezervasyonekhizmetId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("onrezervasyonekhizmet_id");

                entity.Property(e => e.OnrezervasyonId).HasColumnName("onrezervasyon_id");

                entity.Property(e => e.EkhizmetId).HasColumnName("ekhizmet_id");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.Miktar)
                    .HasColumnName("miktar")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OnrezervasyonlarNeden>(entity =>
            {
                entity.HasKey(e => e.OnrezervasyoniptalnedenId)
                    .HasName("PK__onrezerv__4D83E525D3F243F2");

                entity.ToTable("onrezervasyonlar_neden");

                entity.Property(e => e.OnrezervasyoniptalnedenId).HasColumnName("onrezervasyoniptalneden_id");

                entity.Property(e => e.Neden).HasColumnName("neden");
            });

            modelBuilder.Entity<OnrezervasyonlarUrun>(entity =>
            {
                entity.HasKey(e => new { e.OnrezervasyonurunId, e.OnrezervasyonId, e.UrunId })
                    .HasName("PK__onrezerv__E0FE3C0B674B095B");

                entity.ToTable("onrezervasyonlar_urun");

                entity.Property(e => e.OnrezervasyonurunId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("onrezervasyonurun_id");

                entity.Property(e => e.OnrezervasyonId).HasColumnName("onrezervasyon_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Cikis)
                    .HasColumnType("date")
                    .HasColumnName("cikis")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Giris)
                    .HasColumnType("date")
                    .HasColumnName("giris")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OnodemeOran)
                    .HasColumnName("onodeme_oran")
                    .HasDefaultValueSql("((30))");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tercihedildi).HasColumnName("tercihedildi");
            });

            modelBuilder.Entity<OperasyonTurleri>(entity =>
            {
                entity.HasKey(e => e.OperasyonturId)
                    .HasName("PK__operasyo__C2DEE0D128B9FFDA");

                entity.ToTable("operasyon_turleri");

                entity.Property(e => e.OperasyonturId).HasColumnName("operasyontur_id");

                entity.Property(e => e.Operasyon).HasColumnName("operasyon");
            });

            modelBuilder.Entity<Ozellikgruplar>(entity =>
            {
                entity.HasKey(e => new { e.OzellikgrupId, e.SinifId })
                    .HasName("PK__ozellikg__7256EDBE912FB22B");

                entity.ToTable("ozellikgruplar");

                entity.Property(e => e.OzellikgrupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ozellikgrup_id");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Geneltanim)
                    .HasMaxLength(500)
                    .HasColumnName("geneltanim");
            });

            modelBuilder.Entity<OzellikgruplarDil>(entity =>
            {
                entity.HasKey(e => new { e.OzellikgrupDilId, e.DilId, e.OzellikgrupId })
                    .HasName("PK__ozellikg__00AE930D3FAE6300");

                entity.ToTable("ozellikgruplar_dil");

                entity.Property(e => e.OzellikgrupDilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ozellikgrup_dil_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.OzellikgrupId).HasColumnName("ozellikgrup_id");

                entity.Property(e => e.Ozellikgrup)
                    .HasMaxLength(255)
                    .HasColumnName("ozellikgrup");
            });

            modelBuilder.Entity<Ozellikler>(entity =>
            {
                entity.HasKey(e => new { e.OzellikId, e.OzellikgrupId, e.BirimId })
                    .HasName("PK__ozellikl__1223F39999F51A30");

                entity.ToTable("ozellikler");

                entity.Property(e => e.OzellikId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ozellik_id");

                entity.Property(e => e.OzellikgrupId).HasColumnName("ozellikgrup_id");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Geneltanim)
                    .HasMaxLength(500)
                    .HasColumnName("geneltanim");
            });

            modelBuilder.Entity<OzelliklerDil>(entity =>
            {
                entity.HasKey(e => new { e.OzellikDilId, e.OzellikId, e.DilId })
                    .HasName("PK__ozellikl__BBDE22A24A37E44C");

                entity.ToTable("ozellikler_dil");

                entity.Property(e => e.OzellikDilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ozellik_dil_id");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Ozellik)
                    .HasMaxLength(255)
                    .HasColumnName("ozellik");
            });

            modelBuilder.Entity<ParaBirimler>(entity =>
            {
                entity.HasKey(e => new { e.BirimId, e.HesapId })
                    .HasName("PK__para_bir__D82E40FB63A3AFB7");

                entity.ToTable("para_birimler");

                entity.Property(e => e.BirimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("birim_id");

                entity.Property(e => e.HesapId)
                    .HasColumnName("hesap_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Birim)
                    .HasMaxLength(255)
                    .HasColumnName("birim");

                entity.Property(e => e.Bosluk).HasColumnName("bosluk");

                entity.Property(e => e.Katsayi).HasColumnName("katsayi");

                entity.Property(e => e.KurSira)
                    .HasMaxLength(255)
                    .HasColumnName("kur_sira");

                entity.Property(e => e.Sagdan).HasColumnName("sagdan");

                entity.Property(e => e.Sembol)
                    .HasMaxLength(255)
                    .HasColumnName("sembol");
            });

            modelBuilder.Entity<PersonelIstakipleri>(entity =>
            {
                entity.HasKey(e => new { e.IstakipId, e.PersonelId })
                    .HasName("PK__personel__A050771C75B5CF65");

                entity.ToTable("personel_istakipleri");

                entity.Property(e => e.IstakipId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("istakip_id");

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.Property(e => e.Isdetay).HasColumnName("isdetay");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PersonelLoglar>(entity =>
            {
                entity.HasKey(e => new { e.LogId, e.LogtipId, e.ModulId, e.PersonelId })
                    .HasName("PK__personel__5E2386D0AEDB778A");

                entity.ToTable("personel_loglar");

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("log_id");

                entity.Property(e => e.LogtipId).HasColumnName("logtip_id");

                entity.Property(e => e.ModulId).HasColumnName("modul_id");

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.Property(e => e.KayitId).HasColumnName("kayit_id");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PersonelLogtipleri>(entity =>
            {
                entity.HasKey(e => e.LogtipId)
                    .HasName("PK__personel__C9612F21FCAB9E4E");

                entity.ToTable("personel_logtipleri");

                entity.Property(e => e.LogtipId).HasColumnName("logtip_id");

                entity.Property(e => e.Logtip).HasColumnName("logtip");
            });

            modelBuilder.Entity<Personeller>(entity =>
            {
                entity.HasKey(e => new { e.PersonelId, e.HesapId, e.AvanshesapId, e.IsvhissehesapId, e.IsvgiderihesapId, e.GelirvergisihesapId, e.DamgavergisihesapId, e.SskpayihesapId, e.SskisvhissesihesapId, e.SigortapersonelpayihesapId, e.SigortaisvpayihesapId, e.SirketId })
                    .HasName("PK__personel__F100622825B98105");

                entity.ToTable("personeller");

                entity.Property(e => e.PersonelId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("personel_id");

                entity.Property(e => e.HesapId)
                    .HasColumnName("hesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("335 Kodlu");

                entity.Property(e => e.AvanshesapId)
                    .HasColumnName("avanshesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("195 Kodlu");

                entity.Property(e => e.IsvhissehesapId)
                    .HasColumnName("isvhissehesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("770 Kodlu");

                entity.Property(e => e.IsvgiderihesapId)
                    .HasColumnName("isvgiderihesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("770 Kodlu");

                entity.Property(e => e.GelirvergisihesapId)
                    .HasColumnName("gelirvergisihesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("360 Kodlu");

                entity.Property(e => e.DamgavergisihesapId)
                    .HasColumnName("damgavergisihesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("360 Kodlu");

                entity.Property(e => e.SskpayihesapId)
                    .HasColumnName("sskpayihesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("361 Kodlu");

                entity.Property(e => e.SskisvhissesihesapId)
                    .HasColumnName("sskisvhissesihesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("361 Kodlu");

                entity.Property(e => e.SigortapersonelpayihesapId)
                    .HasColumnName("sigortapersonelpayihesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("361 Kodlu");

                entity.Property(e => e.SigortaisvpayihesapId)
                    .HasColumnName("sigortaisvpayihesap_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("362 Kodlu");

                entity.Property(e => e.SirketId)
                    .HasColumnName("sirket_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Adminmi).HasColumnName("adminmi");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(100)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Dahili)
                    .HasColumnName("dahili")
                    .HasDefaultValueSql("((111))");

                entity.Property(e => e.DepartmanId)
                    .HasColumnName("departman_id")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(128)
                    .HasColumnName("eposta");

                entity.Property(e => e.Epostasifre)
                    .HasMaxLength(255)
                    .HasColumnName("epostasifre")
                    .HasDefaultValueSql("('Eposta Şifresinizi Giriniz')");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(64)
                    .HasColumnName("gsm")
                    .HasDefaultValueSql("('000 000 0000')");

                entity.Property(e => e.PersonelKodu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("personel_kodu")
                    .HasDefaultValueSql("('335.001')");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("resim")
                    .HasDefaultValueSql("('0.png')");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(64)
                    .HasColumnName("sifre");
            });

            modelBuilder.Entity<PersonellerYetki>(entity =>
            {
                entity.HasKey(e => new { e.YetkiId, e.ModulId, e.PersonelId })
                    .HasName("PK__personel__F42A1C3D892FC54E");

                entity.ToTable("personeller_yetki");

                entity.Property(e => e.YetkiId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("yetki_id");

                entity.Property(e => e.ModulId).HasColumnName("modul_id");

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.Property(e => e.Duzenle).HasColumnName("duzenle");

                entity.Property(e => e.Ekle).HasColumnName("ekle");

                entity.Property(e => e.Goruntule).HasColumnName("goruntule");

                entity.Property(e => e.Sil).HasColumnName("sil");
            });

            modelBuilder.Entity<RaporSablongruplar>(entity =>
            {
                entity.HasKey(e => e.SablongrupId)
                    .HasName("PK__rapor_sa__238B7589DFB093AB");

                entity.ToTable("rapor_sablongruplar");

                entity.Property(e => e.SablongrupId).HasColumnName("sablongrup_id");

                entity.Property(e => e.SablongrupAd)
                    .HasMaxLength(255)
                    .HasColumnName("sablongrup_ad");

                entity.Property(e => e.Sqlkodu).HasColumnName("sqlkodu");
            });

            modelBuilder.Entity<RaporSablonlari>(entity =>
            {
                entity.HasKey(e => new { e.RaporsablonId, e.SablongrupId })
                    .HasName("PK__rapor_sa__8592B44245AE0FC3");

                entity.ToTable("rapor_sablonlari");

                entity.Property(e => e.RaporsablonId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("raporsablon_id");

                entity.Property(e => e.SablongrupId).HasColumnName("sablongrup_id");

                entity.Property(e => e.Filtre).HasColumnName("filtre");

                entity.Property(e => e.Grup).HasColumnName("grup");

                entity.Property(e => e.Kural).HasColumnName("kural");

                entity.Property(e => e.RaporsablonAd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("raporsablon_ad");
            });

            modelBuilder.Entity<ResimlerIcinAnahtarKelime>(entity =>
            {
                entity.HasKey(e => e.ResimanahtarkelimeId)
                    .HasName("PK__resimler__E2260D3F02CCCA44");

                entity.ToTable("resimler_icin_anahtar_kelime");

                entity.HasIndex(e => e.Anahtarkelime, "anahtarkelime")
                    .IsUnique();

                entity.Property(e => e.ResimanahtarkelimeId).HasColumnName("resimanahtarkelime_id");

                entity.Property(e => e.Anahtarkelime)
                    .HasMaxLength(255)
                    .HasColumnName("anahtarkelime");
            });

            modelBuilder.Entity<Rezervasyonlar>(entity =>
            {
                entity.HasKey(e => new { e.RezervasyonId, e.CariId, e.BirimId, e.SiteId, e.IslemId, e.OnrezervasyonId, e.AcenteId })
                    .HasName("PK__rezervas__EC6FEE8488B01D4C");

                entity.ToTable("rezervasyonlar");

                entity.Property(e => e.RezervasyonId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rezervasyon_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.BirimId)
                    .HasColumnName("birim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.IslemId).HasColumnName("islem_id");

                entity.Property(e => e.OnrezervasyonId).HasColumnName("onrezervasyon_id");

                entity.Property(e => e.AcenteId).HasColumnName("acente_id");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Cikistarih)
                    .HasColumnType("date")
                    .HasColumnName("cikistarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Durum)
                    .HasColumnName("durum")
                    .HasComment("-2 : Elle Kapatıldı, - 1 : Rezervasyon İptal Edildi, 0 : Onay Bekliyor, 1 : Ödeme Bekliyor, 2 :  Voucher Gönderilecek, 3 : Müşteri Onayı, 4 : Rezervasyon Tamamlandı.");

                entity.Property(e => e.Giristarih)
                    .HasColumnType("date")
                    .HasColumnName("giristarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KimlikBildirilebilir).HasColumnName("kimlik_bildirilebilir");

                entity.Property(e => e.KonfirmasyonNo)
                    .HasMaxLength(255)
                    .HasColumnName("konfirmasyon_no")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Maliyet)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("maliyet");

                entity.Property(e => e.Odemealindi).HasColumnName("odemealindi");

                entity.Property(e => e.OpsiyonSuresi)
                    .HasColumnName("opsiyon_suresi")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tutar)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("tutar");
            });

            modelBuilder.Entity<RezervasyonlarBilgi>(entity =>
            {
                entity.HasKey(e => new { e.RezervasyonbilgiId, e.RezervasyonId, e.RezervasyonurunId })
                    .HasName("PK__rezervas__E754B2F19114DC03");

                entity.ToTable("rezervasyonlar_bilgi");

                entity.Property(e => e.RezervasyonbilgiId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rezervasyonbilgi_id");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.RezervasyonurunId).HasColumnName("rezervasyonurun_id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .HasColumnName("ad");

                entity.Property(e => e.BelgeTuru)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("belge_turu")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cinsiyet");

                entity.Property(e => e.DogumTarihi)
                    .HasColumnType("date")
                    .HasColumnName("dogum_tarihi");

                entity.Property(e => e.EkipLideri).HasColumnName("ekip_lideri");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(255)
                    .HasColumnName("eposta");

                entity.Property(e => e.KbsCikis).HasColumnName("kbs_cikis");

                entity.Property(e => e.KbsGiris).HasColumnName("kbs_giris");

                entity.Property(e => e.MedeniHal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("medeni_hal");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(255)
                    .HasColumnName("soyad");

                entity.Property(e => e.Tcpassno)
                    .HasMaxLength(64)
                    .HasColumnName("tcpassno");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(128)
                    .HasColumnName("telefon");

                entity.Property(e => e.Ulke)
                    .HasColumnName("ulke")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Yorumhatirlatildi).HasColumnName("yorumhatirlatildi");
            });

            modelBuilder.Entity<RezervasyonlarEkhizmet>(entity =>
            {
                entity.HasKey(e => new { e.RezervasyonekhizmetId, e.RezervasyonId, e.EkhizmetId, e.UrunId, e.BirimId })
                    .HasName("PK__rezervas__288151742E9194FF");

                entity.ToTable("rezervasyonlar_ekhizmet");

                entity.Property(e => e.RezervasyonekhizmetId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rezervasyonekhizmet_id");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.EkhizmetId).HasColumnName("ekhizmet_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.BirimId)
                    .HasColumnName("birim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Adet)
                    .HasColumnName("adet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.Maliyet)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("maliyet");

                entity.Property(e => e.Miktar)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("miktar");

                entity.Property(e => e.Sure)
                    .HasColumnName("sure")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tutar)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("tutar");

                entity.Property(e => e.Ucret)
                    .HasColumnName("ucret")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RezervasyonlarUrun>(entity =>
            {
                entity.HasKey(e => new { e.RezervasyonurunId, e.RezervasyonId, e.UrunId, e.BirimId, e.IndirimId, e.DepozitobirimId })
                    .HasName("PK__rezervas__0EB598B2E2BF96BE");

                entity.ToTable("rezervasyonlar_urun");

                entity.Property(e => e.RezervasyonurunId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rezervasyonurun_id");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.BirimId)
                    .HasColumnName("birim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IndirimId).HasColumnName("indirim_id");

                entity.Property(e => e.DepozitobirimId)
                    .HasColumnName("depozitobirim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Alinacakdepozito)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("alinacakdepozito");

                entity.Property(e => e.Cikissaat)
                    .HasColumnType("time(2)")
                    .HasColumnName("cikissaat")
                    .HasDefaultValueSql("('10:00')");

                entity.Property(e => e.Cikisyapti).HasColumnName("cikisyapti");

                entity.Property(e => e.Depozito)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("depozito");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.Girissaat)
                    .HasColumnType("time(2)")
                    .HasColumnName("girissaat")
                    .HasDefaultValueSql("('14:00')");

                entity.Property(e => e.Girisyapti).HasColumnName("girisyapti");

                entity.Property(e => e.Indirimtutar)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("indirimtutar");

                entity.Property(e => e.Kdv)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("kdv");

                entity.Property(e => e.Kdvoran)
                    .HasColumnName("kdvoran")
                    .HasDefaultValueSql("((18))");

                entity.Property(e => e.Kullanimbaslangic)
                    .HasColumnType("date")
                    .HasColumnName("kullanimbaslangic")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Kullanimbitis)
                    .HasColumnType("date")
                    .HasColumnName("kullanimbitis")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Maliyet)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("maliyet");

                entity.Property(e => e.Onodeme)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("onodeme");

                entity.Property(e => e.OnodemeOran)
                    .HasColumnName("onodeme_oran")
                    .HasDefaultValueSql("((30))");

                entity.Property(e => e.Tutar)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("tutar");
            });

            modelBuilder.Entity<Sayfalar>(entity =>
            {
                entity.HasKey(e => new { e.SayfaId, e.SiteId, e.DilId })
                    .HasName("PK__sayfalar__B55DA669B557C057");

                entity.ToTable("sayfalar");

                entity.Property(e => e.SayfaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sayfa_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(255)
                    .HasColumnName("baslik");

                entity.Property(e => e.Icerik).HasColumnName("icerik");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Tanim)
                    .HasMaxLength(255)
                    .HasColumnName("tanim");
            });

            modelBuilder.Entity<Semtler>(entity =>
            {
                entity.HasKey(e => new { e.SemtId, e.IlceId })
                    .HasName("PK__semtler__A11462657B3E2317");

                entity.ToTable("semtler");

                entity.Property(e => e.SemtId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("semt_id");

                entity.Property(e => e.IlceId).HasColumnName("ilce_id");

                entity.Property(e => e.Boylam)
                    .HasMaxLength(255)
                    .HasColumnName("boylam")
                    .HasDefaultValueSql("((29))");

                entity.Property(e => e.Enlem)
                    .HasMaxLength(255)
                    .HasColumnName("enlem")
                    .HasDefaultValueSql("((36))");

                entity.Property(e => e.PostaKodu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("posta_kodu")
                    .HasDefaultValueSql("('48300')");

                entity.Property(e => e.Semt)
                    .HasMaxLength(255)
                    .HasColumnName("semt");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<SemtlerDil>(entity =>
            {
                entity.HasKey(e => new { e.SemtdilId, e.DilId, e.SemtId })
                    .HasName("PK__semtler___EFE6EAE591FC02A1");

                entity.ToTable("semtler_dil");

                entity.Property(e => e.SemtdilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("semtdil_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.SemtId).HasColumnName("semt_id");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Tagler)
                    .HasColumnName("tagler")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<SemtlerResim>(entity =>
            {
                entity.HasKey(e => new { e.ResimId, e.SemtId })
                    .HasName("PK__semtler___335C2B60C42DBBB8");

                entity.ToTable("semtler_resim");

                entity.Property(e => e.ResimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("resim_id");

                entity.Property(e => e.SemtId).HasColumnName("semt_id");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<Siniflar>(entity =>
            {
                entity.HasKey(e => e.SinifId)
                    .HasName("PK__siniflar__8699EDE9745E782B");

                entity.ToTable("siniflar");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Geneltanim)
                    .HasMaxLength(255)
                    .HasColumnName("geneltanim")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.Villa).HasColumnName("villa");
            });

            modelBuilder.Entity<SiniflarDil>(entity =>
            {
                entity.HasKey(e => new { e.SinifDilId, e.SinifId, e.DilId })
                    .HasName("PK__siniflar__8A747DF667CEB98E");

                entity.ToTable("siniflar_dil");

                entity.Property(e => e.SinifDilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sinif_dil_id");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Sinif)
                    .HasMaxLength(255)
                    .HasColumnName("sinif");
            });

            modelBuilder.Entity<Sirketler>(entity =>
            {
                entity.HasKey(e => e.SirketId)
                    .HasName("PK__sirketle__B89C6E10DCB50826");

                entity.ToTable("sirketler");

                entity.Property(e => e.SirketId).HasColumnName("sirket_id");

                entity.Property(e => e.Adres)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adres");

                entity.Property(e => e.Epostaadres)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("epostaadres")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Epostasifre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("epostasifre")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Epostasunucu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("epostasunucu")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gsm")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Sirket)
                    .HasMaxLength(255)
                    .HasColumnName("sirket");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefon");

                entity.Property(e => e.Vouchersozlesme)
                    .HasColumnName("vouchersozlesme")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Websitesi)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("websitesi");
            });

            modelBuilder.Entity<Sistemloglari>(entity =>
            {
                entity.HasKey(e => e.SistemlogId)
                    .HasName("PK__sistemlo__0F62BE4465C716E4");

                entity.ToTable("sistemloglari");

                entity.Property(e => e.SistemlogId).HasColumnName("sistemlog_id");

                entity.Property(e => e.Dosya)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dosya");

                entity.Property(e => e.Hatadetay).HasColumnName("hatadetay");

                entity.Property(e => e.Hatamesaj).HasColumnName("hatamesaj");

                entity.Property(e => e.Hatamethod).HasColumnName("hatamethod");

                entity.Property(e => e.Ip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.Metod).HasColumnName("metod");

                entity.Property(e => e.Sinif).HasColumnName("sinif");

                entity.Property(e => e.Tarihsaat)
                    .HasPrecision(3)
                    .HasColumnName("tarihsaat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<SiteUyelerFavoriler>(entity =>
            {
                entity.HasKey(e => new { e.UyefavoriId, e.SiteuyeId, e.UrunId })
                    .HasName("PK__site_uye__78E609E9390636F7");

                entity.ToTable("site_uyeler_favoriler");

                entity.Property(e => e.UyefavoriId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("uyefavori_id");

                entity.Property(e => e.SiteuyeId).HasColumnName("siteuye_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SiteUyelerRezervasyonlar>(entity =>
            {
                entity.HasKey(e => new { e.UyerezervasyonId, e.SiteuyeId, e.RezervasyonId, e.CariId, e.OnrezervasyonId })
                    .HasName("PK__site_uye__5F7AF6E77ECD1A59");

                entity.ToTable("site_uyeler_rezervasyonlar");

                entity.Property(e => e.UyerezervasyonId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("uyerezervasyon_id");

                entity.Property(e => e.SiteuyeId).HasColumnName("siteuye_id");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.OnrezervasyonId).HasColumnName("onrezervasyon_id");
            });

            modelBuilder.Entity<SitedilCeviriler>(entity =>
            {
                entity.HasKey(e => new { e.DilceviriId, e.DilkelimeId, e.DilId })
                    .HasName("PK__sitedil___6275D608BBDBC78C");

                entity.ToTable("sitedil_ceviriler");

                entity.Property(e => e.DilceviriId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("dilceviri_id");

                entity.Property(e => e.DilkelimeId).HasColumnName("dilkelime_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Ceviri).HasColumnName("ceviri");
            });

            modelBuilder.Entity<SitedilKelimeler>(entity =>
            {
                entity.HasKey(e => e.DilkelimeId)
                    .HasName("PK__sitedil___ED77E76671D87F9D");

                entity.ToTable("sitedil_kelimeler");

                entity.Property(e => e.DilkelimeId).HasColumnName("dilkelime_id");

                entity.Property(e => e.GenelTanim)
                    .HasMaxLength(255)
                    .HasColumnName("genel_tanim");

                entity.Property(e => e.Kelime)
                    .HasMaxLength(255)
                    .HasColumnName("kelime");
            });

            modelBuilder.Entity<Siteler>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .HasName("PK__siteler__B22FDBCA97FB0858");

                entity.ToTable("siteler");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Site)
                    .HasMaxLength(255)
                    .HasColumnName("site");
            });

            modelBuilder.Entity<SitelerDegiskengruplar>(entity =>
            {
                entity.HasKey(e => new { e.SiteDegiskengrupId, e.SiteId, e.DegiskengrupId })
                    .HasName("PK__siteler___4A5A202B6F9C0AB2");

                entity.ToTable("siteler_degiskengruplar");

                entity.Property(e => e.SiteDegiskengrupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("site_degiskengrup_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.DegiskengrupId).HasColumnName("degiskengrup_id");
            });

            modelBuilder.Entity<SitelerDegiskenler>(entity =>
            {
                entity.HasKey(e => new { e.SiteDegiskenId, e.SiteId, e.DegiskenId })
                    .HasName("PK__siteler___0C0DFC6EA4415A7E");

                entity.ToTable("siteler_degiskenler");

                entity.Property(e => e.SiteDegiskenId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("site_degisken_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.DegiskenId).HasColumnName("degisken_id");
            });

            modelBuilder.Entity<SitelerDiller>(entity =>
            {
                entity.HasKey(e => e.SitedilId)
                    .HasName("PK__siteler___D4312B1A444D501C");

                entity.ToTable("siteler_diller");

                entity.Property(e => e.SitedilId).HasColumnName("sitedil_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");
            });

            modelBuilder.Entity<SitelerEkhizmetler>(entity =>
            {
                entity.HasKey(e => new { e.SiteEkhizmetId, e.SiteId, e.EkhizmetId })
                    .HasName("PK__siteler___392FD17923569849");

                entity.ToTable("siteler_ekhizmetler");

                entity.Property(e => e.SiteEkhizmetId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("site_ekhizmet_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.EkhizmetId).HasColumnName("ekhizmet_id");
            });

            modelBuilder.Entity<SitelerKampanyalar>(entity =>
            {
                entity.HasKey(e => new { e.SitekampanyaId, e.KampanyaId, e.SiteId })
                    .HasName("PK__siteler___46817ACB9F5D0C4B");

                entity.ToTable("siteler_kampanyalar");

                entity.Property(e => e.SitekampanyaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sitekampanya_id");

                entity.Property(e => e.KampanyaId).HasColumnName("kampanya_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");
            });

            modelBuilder.Entity<SitelerKategoriler>(entity =>
            {
                entity.HasKey(e => new { e.SiteKategoriId, e.SiteId, e.KategoriId })
                    .HasName("PK__siteler___C69BE62282463BFC");

                entity.ToTable("siteler_kategoriler");

                entity.Property(e => e.SiteKategoriId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("site_kategori_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");
            });

            modelBuilder.Entity<SitelerOzellikgruplar>(entity =>
            {
                entity.HasKey(e => new { e.SiteOzellikgrupId, e.SiteId, e.OzellikgrupId })
                    .HasName("PK__siteler___831F8723460A9CBA");

                entity.ToTable("siteler_ozellikgruplar");

                entity.Property(e => e.SiteOzellikgrupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("site_ozellikgrup_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.OzellikgrupId).HasColumnName("ozellikgrup_id");
            });

            modelBuilder.Entity<SitelerOzellikler>(entity =>
            {
                entity.HasKey(e => new { e.SiteOzellikId, e.SiteId, e.OzellikId })
                    .HasName("PK__siteler___2CBE250C62F58E0A");

                entity.ToTable("siteler_ozellikler");

                entity.Property(e => e.SiteOzellikId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("site_ozellik_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");
            });

            modelBuilder.Entity<SitelerParabirimleri>(entity =>
            {
                entity.HasKey(e => new { e.SiteParabirimiId, e.SiteId, e.ParabirimiId })
                    .HasName("PK__siteler___923E45FD9DB601BE");

                entity.ToTable("siteler_parabirimleri");

                entity.Property(e => e.SiteParabirimiId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("site_parabirimi_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.ParabirimiId).HasColumnName("parabirimi_id");
            });

            modelBuilder.Entity<SitelerSiniflar>(entity =>
            {
                entity.HasKey(e => new { e.SiteSinifId, e.SiteId, e.SinifId })
                    .HasName("PK__siteler___D16EC3A714276728");

                entity.ToTable("siteler_siniflar");

                entity.Property(e => e.SiteSinifId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("site_sinif_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");
            });

            modelBuilder.Entity<SitelerUrunler>(entity =>
            {
                entity.HasKey(e => new { e.SiteUrunId, e.SiteId, e.UrunId })
                    .HasName("PK__siteler___E3E70C9A24F7EA5C");

                entity.ToTable("siteler_urunler");

                entity.Property(e => e.SiteUrunId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("site_urun_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.HasKey(e => new { e.SliderId, e.DilId })
                    .HasName("PK__slider__5B89E395668CA842");

                entity.ToTable("slider");

                entity.Property(e => e.SliderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("slider_id");

                entity.Property(e => e.DilId)
                    .HasColumnName("dil_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(255)
                    .HasColumnName("baslik");

                entity.Property(e => e.Gorsel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gorsel")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("link")
                    .HasDefaultValueSql("('#')");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Yenisayfa).HasColumnName("yenisayfa");
            });

            modelBuilder.Entity<Smslistesi>(entity =>
            {
                entity.HasKey(e => e.TelnoId)
                    .HasName("PK__smsliste__ABF11F10C3F061E8");

                entity.ToTable("smslistesi");

                entity.Property(e => e.TelnoId).HasColumnName("telno_id");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Listede)
                    .IsRequired()
                    .HasColumnName("listede")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notlar).HasColumnName("notlar");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Telno)
                    .HasMaxLength(255)
                    .HasColumnName("telno");
            });

            modelBuilder.Entity<SssSorular>(entity =>
            {
                entity.HasKey(e => new { e.SoruId, e.DilId })
                    .HasName("PK__sss_soru__A66057B3C5B48B0F");

                entity.ToTable("sss_sorular");

                entity.Property(e => e.SoruId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("soru_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Cevap)
                    .HasColumnName("cevap")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.Soru).HasColumnName("soru");

                entity.Property(e => e.Tip)
                    .HasColumnName("tip")
                    .HasComment("0 : SSS; 1 : Ürün detay bilgisi");
            });

            modelBuilder.Entity<Ulkeler>(entity =>
            {
                entity.HasKey(e => e.UlkeId)
                    .HasName("PK__ulkeler__F58BA951227C73A0");

                entity.ToTable("ulkeler");

                entity.Property(e => e.UlkeId).HasColumnName("ulke_id");

                entity.Property(e => e.Ulke)
                    .HasMaxLength(255)
                    .HasColumnName("ulke");
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => new { e.UrunId, e.SinifId, e.CariId, e.BolgeId, e.IlId, e.IlceId, e.SemtId, e.KdvhesapId, e.OzelresimId, e.TesisId })
                    .HasName("PK__urunler__2159EAAA63EBDF04");

                entity.ToTable("urunler");

                entity.HasIndex(e => e.UrunKodu, "tekurun_kodu")
                    .IsUnique();

                entity.Property(e => e.UrunId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urun_id");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");

                entity.Property(e => e.IlId).HasColumnName("il_id");

                entity.Property(e => e.IlceId).HasColumnName("ilce_id");

                entity.Property(e => e.SemtId)
                    .HasColumnName("semt_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KdvhesapId)
                    .HasColumnName("kdvhesap_id")
                    .HasDefaultValueSql("((1122))")
                    .HasComment("391 Hesapları");

                entity.Property(e => e.OzelresimId)
                    .HasColumnName("ozelresim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TesisId).HasColumnName("tesis_id");

                entity.Property(e => e.Adres).HasColumnName("adres");

                entity.Property(e => e.Booking).HasColumnName("booking");

                entity.Property(e => e.Boylam)
                    .HasMaxLength(255)
                    .HasColumnName("boylam")
                    .HasDefaultValueSql("((29.1346723))");

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasColumnName("durum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Enlem)
                    .HasMaxLength(255)
                    .HasColumnName("enlem")
                    .HasDefaultValueSql("((36.6190422))");

                entity.Property(e => e.Havuz)
                    .HasColumnName("havuz")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Özel Havuzlu; 2: Müşterek Havuzlu; 3: Havuzsuz");

                entity.Property(e => e.IcalLink)
                    .HasMaxLength(255)
                    .HasColumnName("ical_link");

                entity.Property(e => e.KdvOran)
                    .HasColumnName("kdv_oran")
                    .HasDefaultValueSql("((18))");

                entity.Property(e => e.Sadecebizde).HasColumnName("sadecebizde");

                entity.Property(e => e.UrunAdi)
                    .HasMaxLength(255)
                    .HasColumnName("urun_adi")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.UrunKodu)
                    .HasMaxLength(255)
                    .HasColumnName("urun_kodu")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.UrunKodu2)
                    .HasMaxLength(255)
                    .HasColumnName("urun_kodu2");

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("video_link");

                entity.Property(e => e.VitrinResmi)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vitrin_resmi");
            });

            modelBuilder.Entity<UrunlerBanyolar>(entity =>
            {
                entity.HasKey(e => new { e.UrunbanyoId, e.UrunId })
                    .HasName("PK__urunler___D9EAF077C0529DC6");

                entity.ToTable("urunler_banyolar");

                entity.Property(e => e.UrunbanyoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunbanyo_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Dus).HasColumnName("dus");

                entity.Property(e => e.Jakuzi).HasColumnName("jakuzi");

                entity.Property(e => e.Kat)
                    .HasColumnName("kat")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kuvet).HasColumnName("kuvet");

                entity.Property(e => e.Metrekare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("metrekare");

                entity.Property(e => e.Wc).HasColumnName("wc");

                entity.Property(e => e.YatakodasiId).HasColumnName("yatakodasi_id");
            });

            modelBuilder.Entity<UrunlerDegiskenler>(entity =>
            {
                entity.HasKey(e => new { e.UrunDegiskenId, e.UrunId, e.DegiskenId })
                    .HasName("PK__urunler___2FEE7BDF61F9AD3D");

                entity.ToTable("urunler_degiskenler");

                entity.Property(e => e.UrunDegiskenId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urun_degisken_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.DegiskenId).HasColumnName("degisken_id");
            });

            modelBuilder.Entity<UrunlerDil>(entity =>
            {
                entity.HasKey(e => new { e.UrunDilId, e.UrunId, e.DilId, e.SiteId })
                    .HasName("PK__urunler___EE3EF453C05E4A1B");

                entity.ToTable("urunler_dil");

                entity.Property(e => e.UrunDilId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urun_dil_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.SiteId)
                    .HasColumnName("site_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Baslik).HasColumnName("baslik");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Tagler).HasColumnName("tagler");
            });

            modelBuilder.Entity<UrunlerEkfiyat>(entity =>
            {
                entity.HasKey(e => new { e.UrunEkfiyatId, e.UrunId, e.EkhizmetId, e.BirimId, e.CariId, e.MaliyetbirimId })
                    .HasName("PK__urunler___AE4EF7F1FB24D5E3");

                entity.ToTable("urunler_ekfiyat");

                entity.Property(e => e.UrunEkfiyatId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urun_ekfiyat_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.EkhizmetId).HasColumnName("ekhizmet_id");

                entity.Property(e => e.BirimId)
                    .HasColumnName("birim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.MaliyetbirimId)
                    .HasColumnName("maliyetbirim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Baslangic)
                    .HasColumnType("date")
                    .HasColumnName("baslangic")
                    .HasDefaultValueSql("(dateadd(year,datediff(year,(0),getdate()),(0)))");

                entity.Property(e => e.Bitis)
                    .HasColumnType("date")
                    .HasColumnName("bitis")
                    .HasDefaultValueSql("(dateadd(year,datediff(year,(0),getdate())+(1),(-1)))");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.Gunluk).HasColumnName("gunluk");

                entity.Property(e => e.Haftalik).HasColumnName("haftalik");

                entity.Property(e => e.Istegebagli)
                    .IsRequired()
                    .HasColumnName("istegebagli")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kisibasi).HasColumnName("kisibasi");

                entity.Property(e => e.Maliyet)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("maliyet");

                entity.Property(e => e.Saatlik).HasColumnName("saatlik");

                entity.Property(e => e.Ucretli).HasColumnName("ucretli");

                entity.Property(e => e.Ucretsiz).HasColumnName("ucretsiz");
            });

            modelBuilder.Entity<UrunlerFiyat>(entity =>
            {
                entity.HasKey(e => new { e.FiyatId, e.UrunId, e.BirimId, e.DepozitobirimId, e.MaliyetbirimId })
                    .HasName("PK__urunler___45A6B5CF0B0D3E1A");

                entity.ToTable("urunler_fiyat");

                entity.Property(e => e.FiyatId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fiyat_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.BirimId)
                    .HasColumnName("birim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DepozitobirimId)
                    .HasColumnName("depozitobirim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaliyetbirimId)
                    .HasColumnName("maliyetbirim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Baslangic)
                    .HasColumnType("date")
                    .HasColumnName("baslangic")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Bitis)
                    .HasColumnType("date")
                    .HasColumnName("bitis")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Depozito)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("depozito");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.GirisGunu).HasColumnName("giris_gunu");

                entity.Property(e => e.Maliyet)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("maliyet");

                entity.Property(e => e.MinimumKiralama)
                    .HasColumnName("minimum_kiralama")
                    .HasDefaultValueSql("((7))");

                entity.Property(e => e.OnodemeOran)
                    .HasColumnName("onodeme_oran")
                    .HasDefaultValueSql("((30))");
            });

            modelBuilder.Entity<UrunlerIstatistik>(entity =>
            {
                entity.HasKey(e => new { e.IstatistikId, e.UrunId, e.SiteId })
                    .HasName("PK__urunler___B2C7C723BCB32D1A");

                entity.ToTable("urunler_istatistik");

                entity.Property(e => e.IstatistikId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("istatistik_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.SiteId)
                    .HasColumnName("site_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ip")
                    .HasDefaultValueSql("('127.0.0.0')");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UrunlerKampanyalar>(entity =>
            {
                entity.HasKey(e => new { e.UrunKampanyaId, e.UrunId, e.KampanyaId })
                    .HasName("PK__urunler___C8069864EEF9595F");

                entity.ToTable("urunler_kampanyalar");

                entity.Property(e => e.UrunKampanyaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urun_kampanya_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.KampanyaId).HasColumnName("kampanya_id");
            });

            modelBuilder.Entity<UrunlerKategoriler>(entity =>
            {
                entity.HasKey(e => new { e.UrunKategoriId, e.KategoriId, e.UrunId })
                    .HasName("PK__urunler___9041CAECDF004CA8");

                entity.ToTable("urunler_kategoriler");

                entity.Property(e => e.UrunKategoriId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urun_kategori_id");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<UrunlerKontrat>(entity =>
            {
                entity.HasKey(e => new { e.KontratId, e.UrunId, e.CariId })
                    .HasName("PK__urunler___D002F5EF203C1D64");

                entity.ToTable("urunler_kontrat");

                entity.Property(e => e.KontratId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("kontrat_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.Cezabedel)
                    .HasMaxLength(255)
                    .HasColumnName("cezabedel")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Gecerliliktarih)
                    .HasColumnType("date")
                    .HasColumnName("gecerliliktarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Indirimkabul).HasColumnName("indirimkabul");

                entity.Property(e => e.Indirimoran).HasColumnName("indirimoran");

                entity.Property(e => e.Indirimtarih)
                    .HasColumnType("date")
                    .HasColumnName("indirimtarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KontratAd)
                    .HasMaxLength(255)
                    .HasColumnName("kontrat_ad")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RevizyonNo).HasColumnName("revizyon_no");

                entity.Property(e => e.Satiskabul).HasColumnName("satiskabul");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UrunlerOperatorler>(entity =>
            {
                entity.HasKey(e => new { e.UrunoperatorId, e.UrunId, e.PersonelId })
                    .HasName("PK__urunler___169E47C264F68B11");

                entity.ToTable("urunler_operatorler");

                entity.Property(e => e.UrunoperatorId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunoperator_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");
            });

            modelBuilder.Entity<UrunlerOzellikler>(entity =>
            {
                entity.HasKey(e => new { e.UrunOzellikId, e.UrunId, e.OzellikId, e.BirimId })
                    .HasName("PK__urunler___7795CEEDFC0102DA");

                entity.ToTable("urunler_ozellikler");

                entity.Property(e => e.UrunOzellikId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urun_ozellik_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.Deger)
                    .HasMaxLength(255)
                    .HasColumnName("deger");
            });

            modelBuilder.Entity<UrunlerResim>(entity =>
            {
                entity.HasKey(e => new { e.ResimId, e.UrunId })
                    .HasName("PK__urunler___493AB2C278FEFEE6");

                entity.ToTable("urunler_resim");

                entity.Property(e => e.ResimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("resim_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Duzenlendi).HasColumnName("duzenlendi");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<UrunlerVitrin>(entity =>
            {
                entity.HasKey(e => new { e.VitrinId, e.UrunId })
                    .HasName("PK__urunler___1E40D2410B848ADD");

                entity.ToTable("urunler_vitrin");

                entity.Property(e => e.VitrinId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("vitrin_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<UrunlerYatakodalari>(entity =>
            {
                entity.HasKey(e => new { e.UrunyatakodasiId, e.UrunId })
                    .HasName("PK__urunler___4EC38EA252DEDFED_copy1");

                entity.ToTable("urunler_yatakodalari");

                entity.Property(e => e.UrunyatakodasiId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("urunyatakodasi_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Bebek).HasColumnName("bebek");

                entity.Property(e => e.CiftKisilik).HasColumnName("cift_kisilik");

                entity.Property(e => e.IlaveYatak).HasColumnName("ilave_yatak");

                entity.Property(e => e.Kat)
                    .HasColumnName("kat")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Klima).HasColumnName("klima");

                entity.Property(e => e.Metrekare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("metrekare");

                entity.Property(e => e.OzelBanyo).HasColumnName("ozel_banyo");

                entity.Property(e => e.Ranza).HasColumnName("ranza");

                entity.Property(e => e.TekKisilik).HasColumnName("tek_kisilik");

                entity.Property(e => e.Tv).HasColumnName("tv");
            });

            modelBuilder.Entity<UrunlerYorum>(entity =>
            {
                entity.HasKey(e => new { e.YorumId, e.UrunId })
                    .HasName("PK__urunler___09C99E85E42042D9");

                entity.ToTable("urunler_yorum");

                entity.Property(e => e.YorumId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("yorum_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(255)
                    .HasColumnName("baslik");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(255)
                    .HasColumnName("eposta");

                entity.Property(e => e.Puan)
                    .HasColumnName("puan")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Yorum).HasColumnName("yorum");
            });

            modelBuilder.Entity<Vwdolugunler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwdolugunler");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Kullanimbaslangic)
                    .HasColumnType("date")
                    .HasColumnName("kullanimbaslangic");

                entity.Property(e => e.Kullanimbitis)
                    .HasColumnType("date")
                    .HasColumnName("kullanimbitis");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.RezervasyonurunId).HasColumnName("rezervasyonurun_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<VwepostalistesiGonderileralicilar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwepostalistesi_gonderileralicilar");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Durum)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("durum");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(255)
                    .HasColumnName("eposta");

                entity.Property(e => e.EpostaaliciId).HasColumnName("epostaalici_id");

                entity.Property(e => e.EpostagonderiId).HasColumnName("epostagonderi_id");

                entity.Property(e => e.Tarih)
                    .HasPrecision(3)
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<Vwfaturaurunbilgi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwfaturaurunbilgi");

                entity.Property(e => e.Kullanim)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("kullanim");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.Tip).HasColumnName("tip");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.UrunKodu)
                    .HasMaxLength(255)
                    .HasColumnName("urun_kodu");
            });

            modelBuilder.Entity<Vwfiltreurunler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwfiltreurunler");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Adres).HasColumnName("adres");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Banyo).HasColumnName("banyo");

                entity.Property(e => e.Baslik).HasColumnName("baslik");

                entity.Property(e => e.Bolge)
                    .HasMaxLength(255)
                    .HasColumnName("bolge");

                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");

                entity.Property(e => e.Booking).HasColumnName("booking");

                entity.Property(e => e.Boylam)
                    .HasMaxLength(255)
                    .HasColumnName("boylam");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Endusuk)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("endusuk");

                entity.Property(e => e.Enlem)
                    .HasMaxLength(255)
                    .HasColumnName("enlem");

                entity.Property(e => e.Havuz).HasColumnName("havuz");

                entity.Property(e => e.IcalLink)
                    .HasMaxLength(255)
                    .HasColumnName("ical_link");

                entity.Property(e => e.Il)
                    .HasMaxLength(255)
                    .HasColumnName("il");

                entity.Property(e => e.IlId).HasColumnName("il_id");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(255)
                    .HasColumnName("ilce");

                entity.Property(e => e.IlceId).HasColumnName("ilce_id");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Minimumkiralama).HasColumnName("minimumkiralama");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.Sadecebizde).HasColumnName("sadecebizde");

                entity.Property(e => e.Semt)
                    .HasMaxLength(255)
                    .HasColumnName("semt");

                entity.Property(e => e.SemtId).HasColumnName("semt_id");

                entity.Property(e => e.Sinif)
                    .HasMaxLength(255)
                    .HasColumnName("sinif");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.TesisAdi)
                    .HasMaxLength(255)
                    .HasColumnName("tesis_adi");

                entity.Property(e => e.TesisId).HasColumnName("tesis_id");

                entity.Property(e => e.UrunAdi)
                    .HasMaxLength(255)
                    .HasColumnName("urun_adi");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.UrunKodu)
                    .HasMaxLength(255)
                    .HasColumnName("urun_kodu");

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("video_link");

                entity.Property(e => e.VitrinResmi)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vitrin_resmi");

                entity.Property(e => e.Yatak).HasColumnName("yatak");

                entity.Property(e => e.Yatakodasi).HasColumnName("yatakodasi");

                entity.Property(e => e.Yorumsayisi).HasColumnName("yorumsayisi");
            });

            modelBuilder.Entity<Vwkampanyalar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwkampanyalar");

                entity.Property(e => e.KampanyaAdi)
                    .HasMaxLength(255)
                    .HasColumnName("kampanya_adi");

                entity.Property(e => e.KampanyaId).HasColumnName("kampanya_id");

                entity.Property(e => e.Konaklamabaslangic)
                    .HasColumnType("date")
                    .HasColumnName("konaklamabaslangic");

                entity.Property(e => e.Konaklamabitis)
                    .HasColumnType("date")
                    .HasColumnName("konaklamabitis");

                entity.Property(e => e.NetOran).HasColumnName("net_oran");

                entity.Property(e => e.Oran).HasColumnName("oran");

                entity.Property(e => e.RezTarihbaslangic)
                    .HasColumnType("date")
                    .HasColumnName("rez_tarihbaslangic");

                entity.Property(e => e.RezTarihbitis)
                    .HasColumnType("date")
                    .HasColumnName("rez_tarihbitis");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.Tutar)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("tutar");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.UrunKampanyaId).HasColumnName("urun_kampanya_id");
            });

            modelBuilder.Entity<Vwmhsbfaturalar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwmhsbfaturalar");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.CariKodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cari_kodu");

                entity.Property(e => e.Cikistarih)
                    .HasColumnType("date")
                    .HasColumnName("cikistarih");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("eposta");

                entity.Property(e => e.Giristarih)
                    .HasColumnType("date")
                    .HasColumnName("giristarih");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("soyad");

                entity.Property(e => e.Tcpasno)
                    .HasMaxLength(255)
                    .HasColumnName("tcpasno");

                entity.Property(e => e.Try)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("TRY");

                entity.Property(e => e.Vade).HasColumnName("vade");

                entity.Property(e => e.VergiDairesi)
                    .HasMaxLength(255)
                    .HasColumnName("vergi_dairesi");

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("web");
            });

            modelBuilder.Entity<VwmhsbfaturalarXyz>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwmhsbfaturalar_xyz");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.CariUnvan)
                    .HasMaxLength(500)
                    .HasColumnName("cari_unvan");

                entity.Property(e => e.Caribilgiler).HasColumnName("caribilgiler");

                entity.Property(e => e.FaturaId).HasColumnName("fatura_id");

                entity.Property(e => e.FaturaNo)
                    .HasMaxLength(255)
                    .HasColumnName("fatura_no");

                entity.Property(e => e.FaturaTur)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("fatura_tur");

                entity.Property(e => e.FaturaTurx).HasColumnName("fatura_turx");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih");

                entity.Property(e => e.Tutar)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("tutar");

                entity.Property(e => e.Vergi)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("vergi");

                entity.Property(e => e.VergiDairesi)
                    .HasMaxLength(255)
                    .HasColumnName("vergi_dairesi");

                entity.Property(e => e.Vergino)
                    .HasMaxLength(255)
                    .HasColumnName("vergino");

                entity.Property(e => e.Yazdirildi)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("yazdirildi");

                entity.Property(e => e.Yazdirildix).HasColumnName("yazdirildix");
            });

            modelBuilder.Entity<Vwoperasyonlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwoperasyonlar");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.Cikissaat).HasColumnName("cikissaat");

                entity.Property(e => e.Cikisyapti).HasColumnName("cikisyapti");

                entity.Property(e => e.Depozito)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("depozito");

                entity.Property(e => e.DepozitobirimId).HasColumnName("depozitobirim_id");

                entity.Property(e => e.Girissaat).HasColumnName("girissaat");

                entity.Property(e => e.Girisyapti).HasColumnName("girisyapti");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(255)
                    .HasColumnName("gsm");

                entity.Property(e => e.IlId).HasColumnName("il_id");

                entity.Property(e => e.IlceId).HasColumnName("ilce_id");

                entity.Property(e => e.Kalanbakiye)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("kalanbakiye");

                entity.Property(e => e.Kullanimbaslangic)
                    .HasColumnType("date")
                    .HasColumnName("kullanimbaslangic");

                entity.Property(e => e.Kullanimbitis)
                    .HasColumnType("date")
                    .HasColumnName("kullanimbitis");

                entity.Property(e => e.Musteri)
                    .HasMaxLength(255)
                    .HasColumnName("musteri");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.RezervasyonurunId).HasColumnName("rezervasyonurun_id");

                entity.Property(e => e.SahipId).HasColumnName("sahip_id");

                entity.Property(e => e.SemtId).HasColumnName("semt_id");

                entity.Property(e => e.UrunAdi)
                    .HasMaxLength(255)
                    .HasColumnName("urun_adi");

                entity.Property(e => e.UrunKodu)
                    .HasMaxLength(255)
                    .HasColumnName("urun_kodu");
            });

            modelBuilder.Entity<Vwozellikgruplar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwozellikgruplar");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Ozellikgrup)
                    .HasMaxLength(255)
                    .HasColumnName("ozellikgrup");

                entity.Property(e => e.OzellikgrupId).HasColumnName("ozellikgrup_id");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");
            });

            modelBuilder.Entity<Vwozellikler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwozellikler");

                entity.Property(e => e.Birim)
                    .HasMaxLength(255)
                    .HasColumnName("birim");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Link)
                    .HasMaxLength(500)
                    .HasColumnName("link");

                entity.Property(e => e.Ozellik)
                    .HasMaxLength(255)
                    .HasColumnName("ozellik");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.OzellikgrupId).HasColumnName("ozellikgrup_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");
            });

            modelBuilder.Entity<Vwrezervasyonlaruygunluk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwrezervasyonlaruygunluk");

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.Cikistarih)
                    .HasColumnType("date")
                    .HasColumnName("cikistarih");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Giristarih)
                    .HasColumnType("date")
                    .HasColumnName("giristarih");

                entity.Property(e => e.OpsiyonSuresi).HasColumnName("opsiyon_suresi");

                entity.Property(e => e.RezervasyonId).HasColumnName("rezervasyon_id");

                entity.Property(e => e.RezervasyonurunId).HasColumnName("rezervasyonurun_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.UrunKodu)
                    .HasMaxLength(255)
                    .HasColumnName("urun_kodu");
            });

            modelBuilder.Entity<Vwtrdegiskengruplar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwtrdegiskengruplar");

                entity.Property(e => e.Degiskengrup)
                    .HasMaxLength(255)
                    .HasColumnName("degiskengrup");

                entity.Property(e => e.DegiskengrupId).HasColumnName("degiskengrup_id");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");
            });

            modelBuilder.Entity<Vwtrdegiskenler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwtrdegiskenler");

                entity.Property(e => e.Degisken)
                    .HasMaxLength(255)
                    .HasColumnName("degisken");

                entity.Property(e => e.DegiskenId).HasColumnName("degisken_id");

                entity.Property(e => e.DegiskengrupId).HasColumnName("degiskengrup_id");

                entity.Property(e => e.Durum).HasColumnName("durum");
            });

            modelBuilder.Entity<Vwtrekhizmetler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwtrekhizmetler");

                entity.Property(e => e.Ekhizmet)
                    .HasMaxLength(255)
                    .HasColumnName("ekhizmet");

                entity.Property(e => e.EkhizmetId).HasColumnName("ekhizmet_id");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");
            });

            modelBuilder.Entity<Vwtrkategoriler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwtrkategoriler");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Geneltanim)
                    .HasMaxLength(255)
                    .HasColumnName("geneltanim");

                entity.Property(e => e.Kategori)
                    .HasMaxLength(255)
                    .HasColumnName("kategori");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.Sira).HasColumnName("sira");
            });

            modelBuilder.Entity<Vwtrozellikgruplar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwtrozellikgruplar");

                entity.Property(e => e.Ozellikgrup)
                    .HasMaxLength(255)
                    .HasColumnName("ozellikgrup");

                entity.Property(e => e.OzellikgrupId).HasColumnName("ozellikgrup_id");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");
            });

            modelBuilder.Entity<Vwtrozellikler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwtrozellikler");

                entity.Property(e => e.Birim)
                    .HasMaxLength(128)
                    .HasColumnName("birim");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.Ozellik)
                    .HasMaxLength(255)
                    .HasColumnName("ozellik");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.OzellikgrupId).HasColumnName("ozellikgrup_id");
            });

            modelBuilder.Entity<Vwtrsiniflar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwtrsiniflar");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Geneltanim)
                    .HasMaxLength(255)
                    .HasColumnName("geneltanim");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Resim)
                    .HasMaxLength(255)
                    .HasColumnName("resim");

                entity.Property(e => e.Sinif)
                    .HasMaxLength(255)
                    .HasColumnName("sinif");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.Villa).HasColumnName("villa");
            });

            modelBuilder.Entity<Vwurunler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwurunler");

                entity.Property(e => e.Adres).HasColumnName("adres");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Bolge)
                    .HasMaxLength(255)
                    .HasColumnName("bolge");

                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");

                entity.Property(e => e.Booking).HasColumnName("booking");

                entity.Property(e => e.Boylam)
                    .HasMaxLength(255)
                    .HasColumnName("boylam");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Enlem)
                    .HasMaxLength(255)
                    .HasColumnName("enlem");

                entity.Property(e => e.Havuz).HasColumnName("havuz");

                entity.Property(e => e.IcalLink)
                    .HasMaxLength(255)
                    .HasColumnName("ical_link");

                entity.Property(e => e.Il)
                    .HasMaxLength(255)
                    .HasColumnName("il");

                entity.Property(e => e.IlId).HasColumnName("il_id");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(255)
                    .HasColumnName("ilce");

                entity.Property(e => e.IlceId).HasColumnName("ilce_id");

                entity.Property(e => e.Sadecebizde).HasColumnName("sadecebizde");

                entity.Property(e => e.Semt)
                    .HasMaxLength(255)
                    .HasColumnName("semt");

                entity.Property(e => e.SemtId).HasColumnName("semt_id");

                entity.Property(e => e.Sinif)
                    .HasMaxLength(255)
                    .HasColumnName("sinif");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.TesisAdi)
                    .HasMaxLength(255)
                    .HasColumnName("tesis_adi");

                entity.Property(e => e.TesisId).HasColumnName("tesis_id");

                entity.Property(e => e.UrunAdi)
                    .HasMaxLength(255)
                    .HasColumnName("urun_adi");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.UrunKodu)
                    .HasMaxLength(255)
                    .HasColumnName("urun_kodu");

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("video_link");

                entity.Property(e => e.VitrinResmi)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vitrin_resmi");
            });

            modelBuilder.Entity<VwurunlerEkfiyatlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwurunler_ekfiyatlar");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Ekhizmet)
                    .HasMaxLength(255)
                    .HasColumnName("ekhizmet");

                entity.Property(e => e.EkhizmetId).HasColumnName("ekhizmet_id");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.Gunluk).HasColumnName("gunluk");

                entity.Property(e => e.Haftalik).HasColumnName("haftalik");

                entity.Property(e => e.Kisibasi).HasColumnName("kisibasi");

                entity.Property(e => e.Saatlik).HasColumnName("saatlik");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.Ucretli).HasColumnName("ucretli");

                entity.Property(e => e.Ucretsiz).HasColumnName("ucretsiz");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<VwurunlerEkhizmetler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwurunler_ekhizmetler");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.Ekhizmet)
                    .HasMaxLength(255)
                    .HasColumnName("ekhizmet");

                entity.Property(e => e.EkhizmetId).HasColumnName("ekhizmet_id");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.Gunluk).HasColumnName("gunluk");

                entity.Property(e => e.Haftalik).HasColumnName("haftalik");

                entity.Property(e => e.Kisibasi).HasColumnName("kisibasi");

                entity.Property(e => e.Saatlik).HasColumnName("saatlik");

                entity.Property(e => e.SinifId).HasColumnName("sinif_id");

                entity.Property(e => e.Ucretli).HasColumnName("ucretli");

                entity.Property(e => e.Ucretsiz).HasColumnName("ucretsiz");

                entity.Property(e => e.UrunEkfiyatId).HasColumnName("urun_ekfiyat_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<VwurunlerFiyat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwurunler_fiyat");

                entity.Property(e => e.Baslangic)
                    .HasColumnType("date")
                    .HasColumnName("baslangic");

                entity.Property(e => e.Birim)
                    .HasMaxLength(255)
                    .HasColumnName("birim");

                entity.Property(e => e.BirimId).HasColumnName("birim_id");

                entity.Property(e => e.Bitis)
                    .HasColumnType("date")
                    .HasColumnName("bitis");

                entity.Property(e => e.Depozito)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("depozito");

                entity.Property(e => e.Depozitobirim)
                    .HasMaxLength(255)
                    .HasColumnName("depozitobirim");

                entity.Property(e => e.DepozitobirimId).HasColumnName("depozitobirim_id");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("fiyat");

                entity.Property(e => e.FiyatId).HasColumnName("fiyat_id");

                entity.Property(e => e.GirisGunu).HasColumnName("giris_gunu");

                entity.Property(e => e.MinimumKiralama).HasColumnName("minimum_kiralama");

                entity.Property(e => e.OnodemeOran).HasColumnName("onodeme_oran");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<VwurunlerKontrat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwurunler_kontrat");

                entity.Property(e => e.Adres).HasColumnName("adres");

                entity.Property(e => e.Adsoyad)
                    .HasMaxLength(255)
                    .HasColumnName("adsoyad");

                entity.Property(e => e.Banka)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("banka");

                entity.Property(e => e.CariId).HasColumnName("cari_id");

                entity.Property(e => e.Cezabedel)
                    .HasMaxLength(255)
                    .HasColumnName("cezabedel");

                entity.Property(e => e.FaturaUnvan)
                    .HasMaxLength(500)
                    .HasColumnName("fatura_unvan");

                entity.Property(e => e.Gecerliliktarih)
                    .HasColumnType("date")
                    .HasColumnName("gecerliliktarih");

                entity.Property(e => e.Iban)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("iban");

                entity.Property(e => e.Indirimkabul).HasColumnName("indirimkabul");

                entity.Property(e => e.Indirimoran).HasColumnName("indirimoran");

                entity.Property(e => e.Indirimtarih)
                    .HasColumnType("date")
                    .HasColumnName("indirimtarih");

                entity.Property(e => e.KontratAd)
                    .HasMaxLength(255)
                    .HasColumnName("kontrat_ad");

                entity.Property(e => e.KontratId).HasColumnName("kontrat_id");

                entity.Property(e => e.RevizyonNo).HasColumnName("revizyon_no");

                entity.Property(e => e.Satiskabul).HasColumnName("satiskabul");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.UrunKodu)
                    .HasMaxLength(255)
                    .HasColumnName("urun_kodu");
            });

            modelBuilder.Entity<VwurunlerKontratfiyat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwurunler_kontratfiyat");

                entity.Property(e => e.Baslangic)
                    .HasColumnType("date")
                    .HasColumnName("baslangic");

                entity.Property(e => e.Bitis)
                    .HasColumnType("date")
                    .HasColumnName("bitis");

                entity.Property(e => e.Maliyet)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("maliyet");

                entity.Property(e => e.MinimumKiralama).HasColumnName("minimum_kiralama");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<VwurunlerOzellikdeger>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwurunler_ozellikdeger");

                entity.Property(e => e.Birim)
                    .HasMaxLength(128)
                    .HasColumnName("birim");

                entity.Property(e => e.Deger)
                    .HasMaxLength(255)
                    .HasColumnName("deger");

                entity.Property(e => e.Ozellik)
                    .HasMaxLength(255)
                    .HasColumnName("ozellik");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.OzellikgrupId).HasColumnName("ozellikgrup_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<VwurunlerOzellikdegerleri>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwurunler_ozellikdegerleri");

                entity.Property(e => e.Birim)
                    .HasMaxLength(255)
                    .HasColumnName("birim");

                entity.Property(e => e.Deger)
                    .HasMaxLength(255)
                    .HasColumnName("deger");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Ozellik)
                    .HasMaxLength(255)
                    .HasColumnName("ozellik");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.OzellikgrupId).HasColumnName("ozellikgrup_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<Websiteler>(entity =>
            {
                entity.HasKey(e => new { e.WebsiteId, e.SiteId, e.DilId })
                    .HasName("PK__websitel__739894717B2215AD");

                entity.ToTable("websiteler");

                entity.Property(e => e.WebsiteId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("website_id");

                entity.Property(e => e.SiteId)
                    .HasColumnName("site_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Helal, Villa market ayrımı için kullanılmaktadır.");

                entity.Property(e => e.DilId)
                    .HasColumnName("dil_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Açılış ana dili için kullanılmaktadır.");

                entity.Property(e => e.Bingdogrulamakodu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bingdogrulamakodu");

                entity.Property(e => e.Fbadmins)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fbadmins");

                entity.Property(e => e.Fbappid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fbappid");

                entity.Property(e => e.Googleanalytics)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("googleanalytics");

                entity.Property(e => e.Googledogrulamakodu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("googledogrulamakodu");

                entity.Property(e => e.Gtmkodu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gtmkodu")
                    .HasDefaultValueSql("('Tag Manager Kodu')");

                entity.Property(e => e.Logo)
                    .HasMaxLength(255)
                    .HasColumnName("logo")
                    .HasDefaultValueSql("('assets/logolar/logo.png')");

                entity.Property(e => e.Sira)
                    .HasColumnName("sira")
                    .HasDefaultValueSql("((999))");

                entity.Property(e => e.SiteAdi)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("site_adi");

                entity.Property(e => e.Website)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("website");

                entity.Property(e => e.Yandexdogrulamakodu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("yandexdogrulamakodu");
            });

            modelBuilder.Entity<WebsitelerAnalitik>(entity =>
            {
                entity.HasKey(e => new { e.SiteanalitikId, e.SiteId, e.Oturum, e.Kullanici, e.SayfaGoruntuleme, e.OrtalamaSure, e.YeniOturum, e.HemenCikma, e.OrganikArama, e.Tarih })
                    .HasName("PK__websitel__9B2EF5BC9E466B66");

                entity.ToTable("websiteler_analitik");

                entity.Property(e => e.SiteanalitikId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("siteanalitik_id");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.Oturum).HasColumnName("oturum");

                entity.Property(e => e.Kullanici).HasColumnName("kullanici");

                entity.Property(e => e.SayfaGoruntuleme).HasColumnName("sayfa_goruntuleme");

                entity.Property(e => e.OrtalamaSure).HasColumnName("ortalama_sure");

                entity.Property(e => e.YeniOturum).HasColumnName("yeni_oturum");

                entity.Property(e => e.HemenCikma).HasColumnName("hemen_cikma");

                entity.Property(e => e.OrganikArama).HasColumnName("organik_arama");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WebsitelerSeo>(entity =>
            {
                entity.HasKey(e => new { e.WebsiteseoId, e.BirimId })
                    .HasName("PK__websitel__9A44475F5D87386A");

                entity.ToTable("websiteler_seo");

                entity.Property(e => e.WebsiteseoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("websiteseo_id");

                entity.Property(e => e.BirimId)
                    .HasColumnName("birim_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Adres)
                    .HasMaxLength(255)
                    .HasColumnName("adres")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Baslik)
                    .HasColumnName("baslik")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.DilId).HasColumnName("dil_id");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("eposta")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Facebooklink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("facebooklink")
                    .HasDefaultValueSql("('#')");

                entity.Property(e => e.Girisyazisi)
                    .HasColumnName("girisyazisi")
                    .HasDefaultValueSql("('giriş yazısı ekleyiniz')");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("gsm")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Instagramlink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("instagramlink")
                    .HasDefaultValueSql("('#')");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Linkedinlink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("linkedinlink")
                    .HasDefaultValueSql("('#')");

                entity.Property(e => e.Linkkural)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("linkkural")
                    .HasDefaultValueSql("('{urun_kodu}-{link}')");

                entity.Property(e => e.Pinterestlink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pinterestlink")
                    .HasDefaultValueSql("('#')");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("telefon")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Twitterlink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("twitterlink")
                    .HasDefaultValueSql("('#')");

                entity.Property(e => e.WebsiteId).HasColumnName("website_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        public void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

        }
    }



}
