using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalApp.Data.Migrations
{
    public partial class RentalApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "acente_personel_loglar",
                columns: table => new
                {
                    log_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logtip_id = table.Column<int>(type: "int", nullable: false),
                    modul_id = table.Column<int>(type: "int", nullable: false),
                    personel_id = table.Column<int>(type: "int", nullable: false),
                    kayit_id = table.Column<int>(type: "int", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__acente_p__5E2386D02B981976", x => new { x.log_id, x.logtip_id, x.modul_id, x.personel_id });
                });

            migrationBuilder.CreateTable(
                name: "acente_personeller",
                columns: table => new
                {
                    personel_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    acente_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "335 Kodlu"),
                    adsoyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    eposta = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    sifre = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    gsm = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, defaultValueSql: "('000 000 0000')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__acente_p__056F214F76215979", x => new { x.personel_id, x.acente_id });
                });

            migrationBuilder.CreateTable(
                name: "acenteler",
                columns: table => new
                {
                    acente_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    unvan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__acentele__DCA72D056033624C", x => new { x.acente_id, x.cari_id });
                });

            migrationBuilder.CreateTable(
                name: "acenteler_urunler",
                columns: table => new
                {
                    acente_urun_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    acente_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    komisyon_oran = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    izin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__acentele__AA9E6593B8EA21DF", x => new { x.acente_urun_id, x.acente_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "ayarlar",
                columns: table => new
                {
                    ayar_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anadil = table.Column<int>(type: "int", nullable: false),
                    fis_seri = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('A')"),
                    fis_sayac = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fatura_seri = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('A')"),
                    fatura_sayac = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ayarlar__3C32D2F8E9433D61", x => new { x.ayar_id, x.anadil });
                });

            migrationBuilder.CreateTable(
                name: "bankalar",
                columns: table => new
                {
                    banka_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    banka = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    sube = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    swift_kodu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    iban = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    unvan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    adres = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__bankalar__945CA812EE3D53FB", x => new { x.banka_id, x.birim_id });
                });

            migrationBuilder.CreateTable(
                name: "birimler",
                columns: table => new
                {
                    birim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birim = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__birimler__09A47847D6B51A2A", x => x.birim_id);
                });

            migrationBuilder.CreateTable(
                name: "birimler_dil",
                columns: table => new
                {
                    birimdil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birim_id = table.Column<int>(type: "int", nullable: false),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    sembol = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__birimler__5E2F496E32BF0773", x => new { x.birimdil_id, x.birim_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "bloglar",
                columns: table => new
                {
                    blog_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    site_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    baslik = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    etiketler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    link = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    ozet = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('-')"),
                    resim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('resimyok.jpg')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__bloglar__55B407D0C2C806D8", x => new { x.blog_id, x.dil_id, x.site_id });
                });

            migrationBuilder.CreateTable(
                name: "bolgeler",
                columns: table => new
                {
                    bolge_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolge = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__bolgeler__CECE8EB3CA410F1D", x => x.bolge_id);
                });

            migrationBuilder.CreateTable(
                name: "bolgeler_dil",
                columns: table => new
                {
                    bolgedil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    bolge_id = table.Column<int>(type: "int", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tagler = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__bolgeler__8923238245BD8684", x => new { x.bolgedil_id, x.dil_id, x.bolge_id });
                });

            migrationBuilder.CreateTable(
                name: "bolgeler_resim",
                columns: table => new
                {
                    resim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolge_id = table.Column<int>(type: "int", nullable: false),
                    resim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__bolgeler__DCE59829CA442049", x => new { x.resim_id, x.bolge_id });
                });

            migrationBuilder.CreateTable(
                name: "cariler",
                columns: table => new
                {
                    cari_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    cari_kodu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('CARIKODU')"),
                    tcpasno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    adsoyad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    gsm = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    eposta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    adres = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alici = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    satici = table.Column<bool>(type: "bit", nullable: false),
                    vergi_dairesi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "('-')"),
                    vergino = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "('111111111111')"),
                    fatura_unvan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('-')"),
                    fatura_adres = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "('-')"),
                    banka = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    iban = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    kullaniciadi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    parola = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    ekhizmet_satici = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__cariler__F35AFDDC2B0D5FF7", x => new { x.cari_id, x.hesap_id });
                });

            migrationBuilder.CreateTable(
                name: "degiskengruplar",
                columns: table => new
                {
                    degiskengrup_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sinif_id = table.Column<int>(type: "int", nullable: false),
                    geneltanim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    filtrede = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__degisken__E81C98294023A243", x => new { x.degiskengrup_id, x.sinif_id });
                });

            migrationBuilder.CreateTable(
                name: "degiskengruplar_dil",
                columns: table => new
                {
                    degiskengrup_dil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    degiskengrup_id = table.Column<int>(type: "int", nullable: false),
                    degiskengrup = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__degisken__72CFE975F78349BC", x => new { x.degiskengrup_dil_id, x.dil_id, x.degiskengrup_id });
                });

            migrationBuilder.CreateTable(
                name: "degiskenler",
                columns: table => new
                {
                    degisken_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    degiskengrup_id = table.Column<int>(type: "int", nullable: false),
                    geneltanim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    filtrede = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__degisken__C94C393FD4DF23AC", x => new { x.degisken_id, x.degiskengrup_id });
                });

            migrationBuilder.CreateTable(
                name: "degiskenler_dil",
                columns: table => new
                {
                    degisken_dil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    degisken_id = table.Column<int>(type: "int", nullable: false),
                    degisken = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__degisken__CC42A7F46C935BB5", x => new { x.degisken_dil_id, x.degisken_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "departmanlar",
                columns: table => new
                {
                    departman_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departman = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__departma__64F9A45CD6A6A1EB", x => x.departman_id);
                });

            migrationBuilder.CreateTable(
                name: "diller",
                columns: table => new
                {
                    dil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    dil_kod = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    dil_kisakod = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    dil_yon = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__diller__7738223A91DC5011", x => x.dil_id);
                });

            migrationBuilder.CreateTable(
                name: "doluluk_takvimi",
                columns: table => new
                {
                    doluluk_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    rezervasyon_id = table.Column<int>(type: "int", nullable: false),
                    birim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    tarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    maliyet = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    fiyat = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    durum = table.Column<short>(type: "smallint", nullable: false),
                    minimum = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))"),
                    giris_gunu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__doluluk___EE39D7115341F55C_copy1", x => new { x.doluluk_id, x.urun_id, x.rezervasyon_id, x.birim_id });
                });

            migrationBuilder.CreateTable(
                name: "doviz_kuru",
                columns: table => new
                {
                    kur_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birim_id = table.Column<int>(type: "int", nullable: false),
                    doviz_alis = table.Column<decimal>(type: "decimal(10,5)", nullable: false),
                    doviz_satis = table.Column<decimal>(type: "decimal(10,5)", nullable: false),
                    efektif_alis = table.Column<decimal>(type: "decimal(10,5)", nullable: false),
                    efektif_satis = table.Column<decimal>(type: "decimal(10,5)", nullable: false),
                    tarih = table.Column<DateTime>(type: "date", nullable: false),
                    sabitkur = table.Column<decimal>(type: "decimal(10,5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__doviz_ku__98F8FA37ED964922", x => new { x.kur_id, x.birim_id });
                });

            migrationBuilder.CreateTable(
                name: "ekhizmetler",
                columns: table => new
                {
                    ekhizmet_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sinif_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    geneltanim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ekhizmet__38BC2E98011FD12F", x => new { x.ekhizmet_id, x.sinif_id });
                });

            migrationBuilder.CreateTable(
                name: "ekhizmetler_dil",
                columns: table => new
                {
                    ekhizmetdil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ekhizmet_id = table.Column<int>(type: "int", nullable: false),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    ekhizmet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ekhizmet__09DEB4741C2CDFFC", x => new { x.ekhizmetdil_id, x.ekhizmet_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "ekhizmetler_fiyat",
                columns: table => new
                {
                    ekhizmetfiyat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ekhizmet_id = table.Column<int>(type: "int", nullable: false),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    semt_id = table.Column<int>(type: "int", nullable: false),
                    birim_id = table.Column<int>(type: "int", nullable: false),
                    maliyetbirim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    ucretli = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "1: Ücretsiz; 2: Ücretli"),
                    periyot = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "1: Saatlik; 2: Günlük; 3: Haftalık"),
                    istegebagli = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    fiyat = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    maliyet = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    baslangic = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(dateadd(year,datediff(year,(0),getdate()),(0)))"),
                    bitis = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(dateadd(year,datediff(year,(0),getdate())+(1),(-1)))"),
                    donem = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(datepart(year,getdate()))"),
                    kisibasi = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "1: Kişibaşı; 2: Adet(Toplam)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ekhizmet__9EF90231710DFDFE", x => new { x.ekhizmetfiyat_id, x.ekhizmet_id, x.cari_id, x.urun_id, x.semt_id, x.birim_id, x.maliyetbirim_id });
                });

            migrationBuilder.CreateTable(
                name: "epostalistesi",
                columns: table => new
                {
                    eposta_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adsoyad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    eposta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    listede = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    tarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    notlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ozel_kod = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__epostali__F19D2C42EE191E60", x => x.eposta_id);
                });

            migrationBuilder.CreateTable(
                name: "epostalistesi_alicilar",
                columns: table => new
                {
                    epostaalici_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    epostagonderi_id = table.Column<int>(type: "int", nullable: false),
                    eposta_id = table.Column<int>(type: "int", nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__epostali__7ACDF0F50CA1BC60", x => new { x.epostaalici_id, x.epostagonderi_id, x.eposta_id });
                });

            migrationBuilder.CreateTable(
                name: "epostalistesi_gonderiler",
                columns: table => new
                {
                    epostagonderi_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    konu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    icerik = table.Column<string>(type: "ntext", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__epostali__E04905E7A34E4DD8", x => x.epostagonderi_id);
                });

            migrationBuilder.CreateTable(
                name: "evsahibi_loglar",
                columns: table => new
                {
                    log_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logtip_id = table.Column<int>(type: "int", nullable: false),
                    modul_id = table.Column<int>(type: "int", nullable: false),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    kayit_id = table.Column<int>(type: "int", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__evsahibi__31D52189946EFBC6", x => new { x.log_id, x.logtip_id, x.modul_id, x.cari_id });
                });

            migrationBuilder.CreateTable(
                name: "ilceler",
                columns: table => new
                {
                    ilce_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    il_id = table.Column<int>(type: "int", nullable: false),
                    ilce = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ilceler__AED71F1B93F95323", x => new { x.ilce_id, x.il_id });
                });

            migrationBuilder.CreateTable(
                name: "ilceler_dil",
                columns: table => new
                {
                    ilcedil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    ilce_id = table.Column<int>(type: "int", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tagler = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ilceler___35B5C683971552E0", x => new { x.ilcedil_id, x.dil_id, x.ilce_id });
                });

            migrationBuilder.CreateTable(
                name: "ilceler_resim",
                columns: table => new
                {
                    resim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilce_id = table.Column<int>(type: "int", nullable: false),
                    resim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ilceler___6448A88AF21CC8FC", x => new { x.resim_id, x.ilce_id });
                });

            migrationBuilder.CreateTable(
                name: "iller",
                columns: table => new
                {
                    il_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolge_id = table.Column<int>(type: "int", nullable: false),
                    il = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__iller__804551D43C68A7C1", x => new { x.il_id, x.bolge_id });
                });

            migrationBuilder.CreateTable(
                name: "iller_dil",
                columns: table => new
                {
                    ildil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    il_id = table.Column<int>(type: "int", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tagler = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__iller_di__74D9480303A09542", x => new { x.ildil_id, x.dil_id, x.il_id });
                });

            migrationBuilder.CreateTable(
                name: "iller_resim",
                columns: table => new
                {
                    resim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    il_id = table.Column<int>(type: "int", nullable: false),
                    resim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__iller_re__1AC3EB518CD87B5A", x => new { x.resim_id, x.il_id });
                });

            migrationBuilder.CreateTable(
                name: "kampanyalar",
                columns: table => new
                {
                    kampanya_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    oran = table.Column<int>(type: "int", nullable: false),
                    tutar = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    rez_tarihbaslangic = table.Column<DateTime>(type: "date", nullable: true),
                    rez_tarihbitis = table.Column<DateTime>(type: "date", nullable: true),
                    konaklamabaslangic = table.Column<DateTime>(type: "date", nullable: true),
                    konaklamabitis = table.Column<DateTime>(type: "date", nullable: true),
                    net_oran = table.Column<byte>(type: "tinyint", nullable: false),
                    kampanya_adi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('ANCK10')"),
                    sira = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((1))", comment: "Sira  numarasına göre indirim uygulanır.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kampanya__C92ED1B0CDF7EBBB", x => x.kampanya_id);
                });

            migrationBuilder.CreateTable(
                name: "kategoriler",
                columns: table => new
                {
                    kategori_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sinif_id = table.Column<int>(type: "int", nullable: false),
                    resim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    geneltanim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kategori__27DF60AEA3CAEAC7", x => new { x.kategori_id, x.sinif_id });
                });

            migrationBuilder.CreateTable(
                name: "kategoriler_dil",
                columns: table => new
                {
                    kategori_dil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    kategori_id = table.Column<int>(type: "int", nullable: false),
                    kategori = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kategori__8448796034CEA9DD", x => new { x.kategori_dil_id, x.kategori_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "kbs_tesisler",
                columns: table => new
                {
                    tesis_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tesis_adi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tesis_kodu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    parola = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    yetkili_tcno = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false, defaultValueSql: "((11111111111.))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kbs_tesi__E8565F7D7CDAACE7", x => x.tesis_id);
                });

            migrationBuilder.CreateTable(
                name: "kiralama_resimler",
                columns: table => new
                {
                    talepresim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    talep_id = table.Column<int>(type: "int", nullable: false),
                    resim = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kiralama__72DC3BAA81D7894B", x => new { x.talepresim_id, x.talep_id });
                });

            migrationBuilder.CreateTable(
                name: "kiralama_talepleri",
                columns: table => new
                {
                    talep_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    adsoyad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    telefon = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    eposta = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    villaadresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    odasayi = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    banyosayi = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    yataksayi = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    mesaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    durum = table.Column<int>(type: "int", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kiralama__4DF5FD26566CD4DF", x => new { x.talep_id, x.site_id });
                });

            migrationBuilder.CreateTable(
                name: "kredikartlari",
                columns: table => new
                {
                    kredikarti_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    banka_id = table.Column<int>(type: "int", nullable: false),
                    kredikarti = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kredikar__6A5AB901F27D7463", x => new { x.kredikarti_id, x.banka_id });
                });

            migrationBuilder.CreateTable(
                name: "kullanici_istekleri",
                columns: table => new
                {
                    istek_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gonderen_id = table.Column<int>(type: "int", nullable: false),
                    modul_id = table.Column<int>(type: "int", nullable: false),
                    cozen_id = table.Column<int>(type: "int", nullable: false),
                    sorun = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('-')"),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())"),
                    cozum_tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: true),
                    durum = table.Column<int>(type: "int", nullable: false, comment: "-1:Çözülemedi, 0: Beklemede, 1: İşleme Alındı, 2: Çözüldü"),
                    eknot = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kullanic__55012E70B25D1D0C", x => new { x.istek_id, x.gonderen_id, x.modul_id, x.cozen_id });
                });

            migrationBuilder.CreateTable(
                name: "mesajlar",
                columns: table => new
                {
                    mesaj_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gonderici = table.Column<int>(type: "int", nullable: false),
                    alici = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    baslik = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    mesaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())"),
                    alici_sildi = table.Column<bool>(type: "bit", nullable: false),
                    gonderici_sildi = table.Column<bool>(type: "bit", nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__mesajlar__5CE4216BC7C2845C", x => new { x.mesaj_id, x.gonderici, x.alici });
                });

            migrationBuilder.CreateTable(
                name: "mhsb_hareketler",
                columns: table => new
                {
                    mhsbhareket_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    islemtip_id = table.Column<int>(type: "int", nullable: false),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    rezervasyon_id = table.Column<int>(type: "int", nullable: false),
                    personel_id = table.Column<int>(type: "int", nullable: false),
                    fatura_id = table.Column<int>(type: "int", nullable: false),
                    banka_id = table.Column<int>(type: "int", nullable: false),
                    kredikarti_id = table.Column<int>(type: "int", nullable: false),
                    parabirim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    operator_id = table.Column<int>(type: "int", nullable: false),
                    borc = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    alacak = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    kdvdahil = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    kdvoran = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((8))"),
                    kdvtutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    islemtarihi = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())"),
                    donem = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(datepart(year,getdate()))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__mhsb_har__15F98249DBCC6FE0", x => new { x.mhsbhareket_id, x.islemtip_id, x.cari_id, x.rezervasyon_id, x.personel_id, x.fatura_id, x.banka_id, x.kredikarti_id, x.parabirim_id, x.urun_id, x.operator_id });
                });

            migrationBuilder.CreateTable(
                name: "mhsb_hesap_plani",
                columns: table => new
                {
                    hesap_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hesap_kodu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    hesap_adi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    usthesap_id = table.Column<int>(type: "int", nullable: false),
                    hesap_grubu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "('-')"),
                    althesap_grubu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    carpan = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    seviye = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((1))"),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mhsb_hesap_plani", x => x.hesap_id);
                });

            migrationBuilder.CreateTable(
                name: "mhsb_kasalar",
                columns: table => new
                {
                    kasa_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birim_id = table.Column<int>(type: "int", nullable: false),
                    kasa_ad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    varsayilan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__mhsb_kas__FE7E7E4AEF046C13", x => new { x.kasa_id, x.birim_id });
                });

            migrationBuilder.CreateTable(
                name: "mhsbfaturalar",
                columns: table => new
                {
                    fatura_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cari_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    rezervasyon_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    fatura_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fatura_tur = table.Column<int>(type: "int", nullable: false, comment: "0:Satış Faturası, 1:Alış Faturası, 2:Satış İade, 3:Alış İade"),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    vergi = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    tutar = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    yazdirildi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__mhsbfatu__1C0CDBCAF93E1D1B", x => new { x.fatura_id, x.cari_id, x.rezervasyon_id });
                });

            migrationBuilder.CreateTable(
                name: "mhsbfaturalar_detay",
                columns: table => new
                {
                    faturadetay_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fatura_id = table.Column<int>(type: "int", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tutar = table.Column<decimal>(type: "decimal(11,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__mhsbfatu__0C4AF427B7FEBB28", x => new { x.faturadetay_id, x.fatura_id });
                });

            migrationBuilder.CreateTable(
                name: "mhsbislemtipleri",
                columns: table => new
                {
                    mhsbislemtip_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    odeme_kasa_id = table.Column<int>(type: "int", nullable: false),
                    tahsilat_kasa_id = table.Column<int>(type: "int", nullable: false),
                    islemkodu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    islemadi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gelirgider = table.Column<bool>(type: "bit", nullable: false),
                    iade_islemi = table.Column<bool>(type: "bit", nullable: false),
                    alici_islemi = table.Column<bool>(type: "bit", nullable: false),
                    personel_islemi = table.Column<bool>(type: "bit", nullable: false),
                    satici_islemi = table.Column<bool>(type: "bit", nullable: false),
                    sistem_islemi = table.Column<bool>(type: "bit", nullable: false),
                    acente_islemi = table.Column<bool>(type: "bit", nullable: false),
                    avans_hesabi = table.Column<bool>(type: "bit", nullable: false),
                    fatura = table.Column<bool>(type: "bit", nullable: false),
                    malzeme = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__mhsbisle__69B2032BFB267825", x => new { x.mhsbislemtip_id, x.odeme_kasa_id, x.tahsilat_kasa_id });
                });

            migrationBuilder.CreateTable(
                name: "moduller",
                columns: table => new
                {
                    modul_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modul = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__moduller__728997F42C0F24FF", x => x.modul_id);
                });

            migrationBuilder.CreateTable(
                name: "odemetipleri",
                columns: table => new
                {
                    odemetip_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    odemetipi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    bankadan = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))", comment: "0 : Banka Harici, 1 : Banka Üzerinden"),
                    kredikarti = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__odemetip__1B78C0D66919232F", x => x.odemetip_id);
                });

            migrationBuilder.CreateTable(
                name: "oneri_sablonlari",
                columns: table => new
                {
                    onerisablon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    sablon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__oneri_sa__8A4F12D9FA4E9358", x => new { x.onerisablon_id, x.site_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "onrezervasyonlar",
                columns: table => new
                {
                    onrezervasyon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    operator_id = table.Column<int>(type: "int", nullable: false),
                    gorusen_operator_id = table.Column<int>(type: "int", nullable: false),
                    rezervasyon_operator_id = table.Column<int>(type: "int", nullable: false),
                    onrezervasyoniptalneden_id = table.Column<int>(type: "int", nullable: false),
                    hatirlatildi = table.Column<int>(type: "int", nullable: false),
                    acente_id = table.Column<int>(type: "int", nullable: false),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    musteri = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    kisisayi = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    yetiskinsayi = table.Column<int>(type: "int", nullable: false),
                    bebeksayi = table.Column<int>(type: "int", nullable: false),
                    eposta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    telefon = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    giristarihi = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    cikistarihi = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    sonuc = table.Column<int>(type: "int", nullable: false, comment: "0 : Görüşülmedi, 1 : Kapandı (Olumlu), 2 : Kapandı (olumsuz)"),
                    nasilbuldu = table.Column<int>(type: "int", nullable: false),
                    diger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())"),
                    neden_id = table.Column<int>(type: "int", nullable: false, comment: "0: Bilgi Alma; 1: Rezervasyon"),
                    telefon2 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, defaultValueSql: "('-')"),
                    iptalneden = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__onrezerv__C4CE92FFAB93E9F8", x => new { x.onrezervasyon_id, x.operator_id, x.gorusen_operator_id, x.rezervasyon_operator_id, x.onrezervasyoniptalneden_id, x.hatirlatildi, x.acente_id, x.cari_id });
                });

            migrationBuilder.CreateTable(
                name: "onrezervasyonlar_ekhizmet",
                columns: table => new
                {
                    onrezervasyonekhizmet_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    onrezervasyon_id = table.Column<int>(type: "int", nullable: false),
                    ekhizmet_id = table.Column<int>(type: "int", nullable: false),
                    miktar = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__onrezerv__C8A438DD019A6D59", x => new { x.onrezervasyonekhizmet_id, x.onrezervasyon_id, x.ekhizmet_id });
                });

            migrationBuilder.CreateTable(
                name: "onrezervasyonlar_neden",
                columns: table => new
                {
                    onrezervasyoniptalneden_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    neden = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__onrezerv__4D83E525D3F243F2", x => x.onrezervasyoniptalneden_id);
                });

            migrationBuilder.CreateTable(
                name: "onrezervasyonlar_urun",
                columns: table => new
                {
                    onrezervasyonurun_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    onrezervasyon_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    tercihedildi = table.Column<bool>(type: "bit", nullable: false),
                    giris = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    cikis = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())"),
                    onodeme_oran = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((30))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__onrezerv__E0FE3C0B674B095B", x => new { x.onrezervasyonurun_id, x.onrezervasyon_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "operasyon_turleri",
                columns: table => new
                {
                    operasyontur_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    operasyon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__operasyo__C2DEE0D128B9FFDA", x => x.operasyontur_id);
                });

            migrationBuilder.CreateTable(
                name: "ozellikgruplar",
                columns: table => new
                {
                    ozellikgrup_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sinif_id = table.Column<int>(type: "int", nullable: false),
                    geneltanim = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ozellikg__7256EDBE912FB22B", x => new { x.ozellikgrup_id, x.sinif_id });
                });

            migrationBuilder.CreateTable(
                name: "ozellikgruplar_dil",
                columns: table => new
                {
                    ozellikgrup_dil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    ozellikgrup_id = table.Column<int>(type: "int", nullable: false),
                    ozellikgrup = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ozellikg__00AE930D3FAE6300", x => new { x.ozellikgrup_dil_id, x.dil_id, x.ozellikgrup_id });
                });

            migrationBuilder.CreateTable(
                name: "ozellikler",
                columns: table => new
                {
                    ozellik_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ozellikgrup_id = table.Column<int>(type: "int", nullable: false),
                    birim_id = table.Column<int>(type: "int", nullable: false),
                    geneltanim = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ozellikl__1223F39999F51A30", x => new { x.ozellik_id, x.ozellikgrup_id, x.birim_id });
                });

            migrationBuilder.CreateTable(
                name: "ozellikler_dil",
                columns: table => new
                {
                    ozellik_dil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    ozellik_id = table.Column<int>(type: "int", nullable: false),
                    ozellik = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ozellikl__BBDE22A24A37E44C", x => new { x.ozellik_dil_id, x.ozellik_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "para_birimler",
                columns: table => new
                {
                    birim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    sembol = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    birim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sagdan = table.Column<bool>(type: "bit", nullable: false),
                    bosluk = table.Column<bool>(type: "bit", nullable: false),
                    kur_sira = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    katsayi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__para_bir__D82E40FB63A3AFB7", x => new { x.birim_id, x.hesap_id });
                });

            migrationBuilder.CreateTable(
                name: "personel_istakipleri",
                columns: table => new
                {
                    istakip_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personel_id = table.Column<int>(type: "int", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())"),
                    isdetay = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__personel__A050771C75B5CF65", x => new { x.istakip_id, x.personel_id });
                });

            migrationBuilder.CreateTable(
                name: "personel_loglar",
                columns: table => new
                {
                    log_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logtip_id = table.Column<int>(type: "int", nullable: false),
                    modul_id = table.Column<int>(type: "int", nullable: false),
                    personel_id = table.Column<int>(type: "int", nullable: false),
                    kayit_id = table.Column<int>(type: "int", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__personel__5E2386D0AEDB778A", x => new { x.log_id, x.logtip_id, x.modul_id, x.personel_id });
                });

            migrationBuilder.CreateTable(
                name: "personel_logtipleri",
                columns: table => new
                {
                    logtip_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logtip = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__personel__C9612F21FCAB9E4E", x => x.logtip_id);
                });

            migrationBuilder.CreateTable(
                name: "personeller",
                columns: table => new
                {
                    personel_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "335 Kodlu"),
                    avanshesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "195 Kodlu"),
                    isvhissehesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "770 Kodlu"),
                    isvgiderihesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "770 Kodlu"),
                    gelirvergisihesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "360 Kodlu"),
                    damgavergisihesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "360 Kodlu"),
                    sskpayihesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "361 Kodlu"),
                    sskisvhissesihesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "361 Kodlu"),
                    sigortapersonelpayihesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "361 Kodlu"),
                    sigortaisvpayihesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "362 Kodlu"),
                    sirket_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    adsoyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    eposta = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    sifre = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    gsm = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, defaultValueSql: "('000 000 0000')"),
                    departman_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((4))"),
                    epostasifre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('Eposta Şifresinizi Giriniz')"),
                    personel_kodu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('335.001')"),
                    adminmi = table.Column<bool>(type: "bit", nullable: false),
                    dahili = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((111))"),
                    resim = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, defaultValueSql: "('0.png')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__personel__F100622825B98105", x => new { x.personel_id, x.hesap_id, x.avanshesap_id, x.isvhissehesap_id, x.isvgiderihesap_id, x.gelirvergisihesap_id, x.damgavergisihesap_id, x.sskpayihesap_id, x.sskisvhissesihesap_id, x.sigortapersonelpayihesap_id, x.sigortaisvpayihesap_id, x.sirket_id });
                });

            migrationBuilder.CreateTable(
                name: "personeller_yetki",
                columns: table => new
                {
                    yetki_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modul_id = table.Column<int>(type: "int", nullable: false),
                    personel_id = table.Column<int>(type: "int", nullable: false),
                    goruntule = table.Column<bool>(type: "bit", nullable: false),
                    ekle = table.Column<bool>(type: "bit", nullable: false),
                    duzenle = table.Column<bool>(type: "bit", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__personel__F42A1C3D892FC54E", x => new { x.yetki_id, x.modul_id, x.personel_id });
                });

            migrationBuilder.CreateTable(
                name: "rapor_sablongruplar",
                columns: table => new
                {
                    sablongrup_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sablongrup_ad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sqlkodu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rapor_sa__238B7589DFB093AB", x => x.sablongrup_id);
                });

            migrationBuilder.CreateTable(
                name: "rapor_sablonlari",
                columns: table => new
                {
                    raporsablon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sablongrup_id = table.Column<int>(type: "int", nullable: false),
                    raporsablon_ad = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    grup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filtre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kural = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rapor_sa__8592B44245AE0FC3", x => new { x.raporsablon_id, x.sablongrup_id });
                });

            migrationBuilder.CreateTable(
                name: "resimler_icin_anahtar_kelime",
                columns: table => new
                {
                    resimanahtarkelime_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anahtarkelime = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__resimler__E2260D3F02CCCA44", x => x.resimanahtarkelime_id);
                });

            migrationBuilder.CreateTable(
                name: "rezervasyonlar",
                columns: table => new
                {
                    rezervasyon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    islem_id = table.Column<int>(type: "int", nullable: false),
                    onrezervasyon_id = table.Column<int>(type: "int", nullable: false),
                    acente_id = table.Column<int>(type: "int", nullable: false),
                    giristarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    cikistarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    tutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())"),
                    durum = table.Column<int>(type: "int", nullable: false, comment: "-2 : Elle Kapatıldı, - 1 : Rezervasyon İptal Edildi, 0 : Onay Bekliyor, 1 : Ödeme Bekliyor, 2 :  Voucher Gönderilecek, 3 : Müşteri Onayı, 4 : Rezervasyon Tamamlandı."),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maliyet = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    odemealindi = table.Column<bool>(type: "bit", nullable: false),
                    opsiyon_suresi = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    kimlik_bildirilebilir = table.Column<bool>(type: "bit", nullable: false),
                    konfirmasyon_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rezervas__EC6FEE8488B01D4C", x => new { x.rezervasyon_id, x.cari_id, x.birim_id, x.site_id, x.islem_id, x.onrezervasyon_id, x.acente_id });
                });

            migrationBuilder.CreateTable(
                name: "rezervasyonlar_bilgi",
                columns: table => new
                {
                    rezervasyonbilgi_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rezervasyon_id = table.Column<int>(type: "int", nullable: false),
                    rezervasyonurun_id = table.Column<int>(type: "int", nullable: false),
                    tcpassno = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    telefon = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    eposta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    belge_turu = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('N')"),
                    soyad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ulke = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    ad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ekip_lideri = table.Column<bool>(type: "bit", nullable: false),
                    yorumhatirlatildi = table.Column<bool>(type: "bit", nullable: false),
                    kbs_giris = table.Column<bool>(type: "bit", nullable: false),
                    kbs_cikis = table.Column<bool>(type: "bit", nullable: false),
                    cinsiyet = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    medeni_hal = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    dogum_tarihi = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rezervas__E754B2F19114DC03", x => new { x.rezervasyonbilgi_id, x.rezervasyon_id, x.rezervasyonurun_id });
                });

            migrationBuilder.CreateTable(
                name: "rezervasyonlar_ekhizmet",
                columns: table => new
                {
                    rezervasyonekhizmet_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rezervasyon_id = table.Column<int>(type: "int", nullable: false),
                    ekhizmet_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    birim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fiyat = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    miktar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    tutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ucret = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    sure = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    adet = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maliyet = table.Column<decimal>(type: "decimal(11,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rezervas__288151742E9194FF", x => new { x.rezervasyonekhizmet_id, x.rezervasyon_id, x.ekhizmet_id, x.urun_id, x.birim_id });
                });

            migrationBuilder.CreateTable(
                name: "rezervasyonlar_urun",
                columns: table => new
                {
                    rezervasyonurun_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rezervasyon_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    birim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    indirim_id = table.Column<int>(type: "int", nullable: false),
                    depozitobirim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fiyat = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    kdvoran = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((18))"),
                    kdv = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    tutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kullanimbaslangic = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    kullanimbitis = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    indirimtutar = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    maliyet = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    girissaat = table.Column<TimeSpan>(type: "time(2)", nullable: false, defaultValueSql: "('14:00')"),
                    cikissaat = table.Column<TimeSpan>(type: "time(2)", nullable: false, defaultValueSql: "('10:00')"),
                    girisyapti = table.Column<bool>(type: "bit", nullable: false),
                    cikisyapti = table.Column<bool>(type: "bit", nullable: false),
                    depozito = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    onodeme_oran = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((30))"),
                    onodeme = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    alinacakdepozito = table.Column<decimal>(type: "decimal(11,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rezervas__0EB598B2E2BF96BE", x => new { x.rezervasyonurun_id, x.rezervasyon_id, x.urun_id, x.birim_id, x.indirim_id, x.depozitobirim_id });
                });

            migrationBuilder.CreateTable(
                name: "sayfalar",
                columns: table => new
                {
                    sayfa_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    link = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tanim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sayfalar__B55DA669B557C057", x => new { x.sayfa_id, x.site_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "semtler",
                columns: table => new
                {
                    semt_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilce_id = table.Column<int>(type: "int", nullable: false),
                    semt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    enlem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((36))"),
                    boylam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((29))"),
                    sira = table.Column<int>(type: "int", nullable: false),
                    posta_kodu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('48300')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__semtler__A11462657B3E2317", x => new { x.semt_id, x.ilce_id });
                });

            migrationBuilder.CreateTable(
                name: "semtler_dil",
                columns: table => new
                {
                    semtdil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    semt_id = table.Column<int>(type: "int", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tagler = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__semtler___EFE6EAE591FC02A1", x => new { x.semtdil_id, x.dil_id, x.semt_id });
                });

            migrationBuilder.CreateTable(
                name: "semtler_resim",
                columns: table => new
                {
                    resim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    semt_id = table.Column<int>(type: "int", nullable: false),
                    resim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__semtler___335C2B60C42DBBB8", x => new { x.resim_id, x.semt_id });
                });

            migrationBuilder.CreateTable(
                name: "siniflar",
                columns: table => new
                {
                    sinif_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    resim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    villa = table.Column<byte>(type: "tinyint", nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    geneltanim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siniflar__8699EDE9745E782B", x => x.sinif_id);
                });

            migrationBuilder.CreateTable(
                name: "siniflar_dil",
                columns: table => new
                {
                    sinif_dil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    sinif_id = table.Column<int>(type: "int", nullable: false),
                    sinif = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siniflar__8A747DF667CEB98E", x => new { x.sinif_dil_id, x.sinif_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "sirketler",
                columns: table => new
                {
                    sirket_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sirket = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    telefon = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    adres = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    websitesi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    gsm = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    epostasunucu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    epostaadres = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    epostasifre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    vouchersozlesme = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sirketle__B89C6E10DCB50826", x => x.sirket_id);
                });

            migrationBuilder.CreateTable(
                name: "sistemloglari",
                columns: table => new
                {
                    sistemlog_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ip = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    dosya = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    hatadetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hatamesaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hatamethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    metod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sinif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarihsaat = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())"),
                    url = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sistemlo__0F62BE4465C716E4", x => x.sistemlog_id);
                });

            migrationBuilder.CreateTable(
                name: "site_uyeler_favoriler",
                columns: table => new
                {
                    uyefavori_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    siteuye_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__site_uye__78E609E9390636F7", x => new { x.uyefavori_id, x.siteuye_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "site_uyeler_rezervasyonlar",
                columns: table => new
                {
                    uyerezervasyon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    siteuye_id = table.Column<int>(type: "int", nullable: false),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    rezervasyon_id = table.Column<int>(type: "int", nullable: false),
                    onrezervasyon_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__site_uye__5F7AF6E77ECD1A59", x => new { x.uyerezervasyon_id, x.siteuye_id, x.rezervasyon_id, x.cari_id, x.onrezervasyon_id });
                });

            migrationBuilder.CreateTable(
                name: "sitedil_ceviriler",
                columns: table => new
                {
                    dilceviri_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dilkelime_id = table.Column<int>(type: "int", nullable: false),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    ceviri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sitedil___6275D608BBDBC78C", x => new { x.dilceviri_id, x.dilkelime_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "sitedil_kelimeler",
                columns: table => new
                {
                    dilkelime_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kelime = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    genel_tanim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sitedil___ED77E76671D87F9D", x => x.dilkelime_id);
                });

            migrationBuilder.CreateTable(
                name: "siteler",
                columns: table => new
                {
                    site_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler__B22FDBCA97FB0858", x => x.site_id);
                });

            migrationBuilder.CreateTable(
                name: "siteler_degiskengruplar",
                columns: table => new
                {
                    site_degiskengrup_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    degiskengrup_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___4A5A202B6F9C0AB2", x => new { x.site_degiskengrup_id, x.site_id, x.degiskengrup_id });
                });

            migrationBuilder.CreateTable(
                name: "siteler_degiskenler",
                columns: table => new
                {
                    site_degisken_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    degisken_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___0C0DFC6EA4415A7E", x => new { x.site_degisken_id, x.site_id, x.degisken_id });
                });

            migrationBuilder.CreateTable(
                name: "siteler_diller",
                columns: table => new
                {
                    sitedil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    dil_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___D4312B1A444D501C", x => x.sitedil_id);
                });

            migrationBuilder.CreateTable(
                name: "siteler_ekhizmetler",
                columns: table => new
                {
                    site_ekhizmet_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    ekhizmet_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___392FD17923569849", x => new { x.site_ekhizmet_id, x.site_id, x.ekhizmet_id });
                });

            migrationBuilder.CreateTable(
                name: "siteler_kampanyalar",
                columns: table => new
                {
                    sitekampanya_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kampanya_id = table.Column<int>(type: "int", nullable: false),
                    site_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___46817ACB9F5D0C4B", x => new { x.sitekampanya_id, x.kampanya_id, x.site_id });
                });

            migrationBuilder.CreateTable(
                name: "siteler_kategoriler",
                columns: table => new
                {
                    site_kategori_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    kategori_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___C69BE62282463BFC", x => new { x.site_kategori_id, x.site_id, x.kategori_id });
                });

            migrationBuilder.CreateTable(
                name: "siteler_ozellikgruplar",
                columns: table => new
                {
                    site_ozellikgrup_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    ozellikgrup_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___831F8723460A9CBA", x => new { x.site_ozellikgrup_id, x.site_id, x.ozellikgrup_id });
                });

            migrationBuilder.CreateTable(
                name: "siteler_ozellikler",
                columns: table => new
                {
                    site_ozellik_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    ozellik_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___2CBE250C62F58E0A", x => new { x.site_ozellik_id, x.site_id, x.ozellik_id });
                });

            migrationBuilder.CreateTable(
                name: "siteler_parabirimleri",
                columns: table => new
                {
                    site_parabirimi_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    parabirimi_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___923E45FD9DB601BE", x => new { x.site_parabirimi_id, x.site_id, x.parabirimi_id });
                });

            migrationBuilder.CreateTable(
                name: "siteler_siniflar",
                columns: table => new
                {
                    site_sinif_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    sinif_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___D16EC3A714276728", x => new { x.site_sinif_id, x.site_id, x.sinif_id });
                });

            migrationBuilder.CreateTable(
                name: "siteler_urunler",
                columns: table => new
                {
                    site_urun_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siteler___E3E70C9A24F7EA5C", x => new { x.site_urun_id, x.site_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "slider",
                columns: table => new
                {
                    slider_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    baslik = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    gorsel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    link = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('#')"),
                    yenisayfa = table.Column<bool>(type: "bit", nullable: false),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__slider__5B89E395668CA842", x => new { x.slider_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "smslistesi",
                columns: table => new
                {
                    telno_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adsoyad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    telno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    listede = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    tarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    notlar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__smsliste__ABF11F10C3F061E8", x => x.telno_id);
                });

            migrationBuilder.CreateTable(
                name: "sss_sorular",
                columns: table => new
                {
                    soru_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    soru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sira = table.Column<int>(type: "int", nullable: false),
                    cevap = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('-')"),
                    tip = table.Column<int>(type: "int", nullable: false, comment: "0 : SSS; 1 : Ürün detay bilgisi")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sss_soru__A66057B3C5B48B0F", x => new { x.soru_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "ulkeler",
                columns: table => new
                {
                    ulke_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ulke = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ulkeler__F58BA951227C73A0", x => x.ulke_id);
                });

            migrationBuilder.CreateTable(
                name: "urunler",
                columns: table => new
                {
                    urun_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sinif_id = table.Column<int>(type: "int", nullable: false),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    bolge_id = table.Column<int>(type: "int", nullable: false),
                    il_id = table.Column<int>(type: "int", nullable: false),
                    ilce_id = table.Column<int>(type: "int", nullable: false),
                    semt_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    kdvhesap_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1122))", comment: "391 Hesapları"),
                    ozelresim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    tesis_id = table.Column<int>(type: "int", nullable: false),
                    urun_kodu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "('-')"),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enlem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((36.6190422))"),
                    boylam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((29.1346723))"),
                    sadecebizde = table.Column<bool>(type: "bit", nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    video_link = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    urun_adi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('-')"),
                    kdv_oran = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((18))"),
                    havuz = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((1))", comment: "1: Özel Havuzlu; 2: Müşterek Havuzlu; 3: Havuzsuz"),
                    booking = table.Column<bool>(type: "bit", nullable: false),
                    urun_kodu2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    vitrin_resmi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ical_link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler__2159EAAA63EBDF04", x => new { x.urun_id, x.sinif_id, x.cari_id, x.bolge_id, x.il_id, x.ilce_id, x.semt_id, x.kdvhesap_id, x.ozelresim_id, x.tesis_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_banyolar",
                columns: table => new
                {
                    urunbanyo_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    metrekare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    kat = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    wc = table.Column<bool>(type: "bit", nullable: false),
                    dus = table.Column<bool>(type: "bit", nullable: false),
                    kuvet = table.Column<bool>(type: "bit", nullable: false),
                    jakuzi = table.Column<bool>(type: "bit", nullable: false),
                    yatakodasi_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___D9EAF077C0529DC6", x => new { x.urunbanyo_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_degiskenler",
                columns: table => new
                {
                    urun_degisken_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    degisken_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___2FEE7BDF61F9AD3D", x => new { x.urun_degisken_id, x.urun_id, x.degisken_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_dil",
                columns: table => new
                {
                    urun_dil_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    site_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    tagler = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___EE3EF453C05E4A1B", x => new { x.urun_dil_id, x.urun_id, x.dil_id, x.site_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_ekfiyat",
                columns: table => new
                {
                    urun_ekfiyat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    ekhizmet_id = table.Column<int>(type: "int", nullable: false),
                    birim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    maliyetbirim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    ucretsiz = table.Column<bool>(type: "bit", nullable: false),
                    ucretli = table.Column<bool>(type: "bit", nullable: false),
                    adet = table.Column<bool>(type: "bit", nullable: false),
                    kisibasi = table.Column<bool>(type: "bit", nullable: false),
                    gunluk = table.Column<bool>(type: "bit", nullable: false),
                    haftalik = table.Column<bool>(type: "bit", nullable: false),
                    fiyat = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    saatlik = table.Column<bool>(type: "bit", nullable: false),
                    istegebagli = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    baslangic = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(dateadd(year,datediff(year,(0),getdate()),(0)))"),
                    bitis = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(dateadd(year,datediff(year,(0),getdate())+(1),(-1)))"),
                    maliyet = table.Column<decimal>(type: "decimal(11,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___AE4EF7F1FB24D5E3", x => new { x.urun_ekfiyat_id, x.urun_id, x.ekhizmet_id, x.birim_id, x.cari_id, x.maliyetbirim_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_fiyat",
                columns: table => new
                {
                    fiyat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    birim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    depozitobirim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    maliyetbirim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    fiyat = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    minimum_kiralama = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((7))"),
                    baslangic = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    bitis = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    maliyet = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    giris_gunu = table.Column<int>(type: "int", nullable: false),
                    depozito = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    onodeme_oran = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((30))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___45A6B5CF0B0D3E1A", x => new { x.fiyat_id, x.urun_id, x.birim_id, x.depozitobirim_id, x.maliyetbirim_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_istatistik",
                columns: table => new
                {
                    istatistik_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    site_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    ip = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('127.0.0.0')"),
                    tarih = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___B2C7C723BCB32D1A", x => new { x.istatistik_id, x.urun_id, x.site_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_kampanyalar",
                columns: table => new
                {
                    urun_kampanya_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kampanya_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___C8069864EEF9595F", x => new { x.urun_kampanya_id, x.urun_id, x.kampanya_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_kategoriler",
                columns: table => new
                {
                    urun_kategori_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategori_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___9041CAECDF004CA8", x => new { x.urun_kategori_id, x.kategori_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_kontrat",
                columns: table => new
                {
                    kontrat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    cari_id = table.Column<int>(type: "int", nullable: false),
                    kontrat_ad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "(' ')"),
                    gecerliliktarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    indirimtarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    indirimoran = table.Column<int>(type: "int", nullable: false),
                    indirimkabul = table.Column<bool>(type: "bit", nullable: false),
                    satiskabul = table.Column<bool>(type: "bit", nullable: false),
                    cezabedel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "(' ')"),
                    tarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    revizyon_no = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___D002F5EF203C1D64", x => new { x.kontrat_id, x.urun_id, x.cari_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_operatorler",
                columns: table => new
                {
                    urunoperator_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    personel_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___169E47C264F68B11", x => new { x.urunoperator_id, x.urun_id, x.personel_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_ozellikler",
                columns: table => new
                {
                    urun_ozellik_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    ozellik_id = table.Column<int>(type: "int", nullable: false),
                    birim_id = table.Column<int>(type: "int", nullable: false),
                    deger = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___7795CEEDFC0102DA", x => new { x.urun_ozellik_id, x.urun_id, x.ozellik_id, x.birim_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_resim",
                columns: table => new
                {
                    resim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    resim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sira = table.Column<int>(type: "int", nullable: false),
                    duzenlendi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___493AB2C278FEFEE6", x => new { x.resim_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_vitrin",
                columns: table => new
                {
                    vitrin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    sira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___1E40D2410B848ADD", x => new { x.vitrin_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_yatakodalari",
                columns: table => new
                {
                    urunyatakodasi_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    metrekare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    kat = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    cift_kisilik = table.Column<int>(type: "int", nullable: false),
                    tek_kisilik = table.Column<int>(type: "int", nullable: false),
                    ranza = table.Column<int>(type: "int", nullable: false),
                    ilave_yatak = table.Column<int>(type: "int", nullable: false),
                    bebek = table.Column<int>(type: "int", nullable: false),
                    klima = table.Column<bool>(type: "bit", nullable: false),
                    tv = table.Column<bool>(type: "bit", nullable: false),
                    ozel_banyo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___4EC38EA252DEDFED_copy1", x => new { x.urunyatakodasi_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "urunler_yorum",
                columns: table => new
                {
                    yorum_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    adsoyad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    baslik = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    yorum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    durum = table.Column<bool>(type: "bit", nullable: false),
                    eposta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    puan = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((5))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__urunler___09C99E85E42042D9", x => new { x.yorum_id, x.urun_id });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlceId = table.Column<int>(type: "int", nullable: false),
                    Creadet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "websiteler",
                columns: table => new
                {
                    website_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "Helal, Villa market ayrımı için kullanılmaktadır."),
                    dil_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))", comment: "Açılış ana dili için kullanılmaktadır."),
                    website = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    bingdogrulamakodu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    yandexdogrulamakodu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    googledogrulamakodu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    googleanalytics = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fbadmins = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fbappid = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    site_adi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    sira = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((999))"),
                    logo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "('assets/logolar/logo.png')"),
                    gtmkodu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, defaultValueSql: "('Tag Manager Kodu')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__websitel__739894717B2215AD", x => new { x.website_id, x.site_id, x.dil_id });
                });

            migrationBuilder.CreateTable(
                name: "websiteler_analitik",
                columns: table => new
                {
                    siteanalitik_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    oturum = table.Column<int>(type: "int", nullable: false),
                    kullanici = table.Column<int>(type: "int", nullable: false),
                    sayfa_goruntuleme = table.Column<int>(type: "int", nullable: false),
                    ortalama_sure = table.Column<TimeSpan>(type: "time", nullable: false),
                    hemen_cikma = table.Column<int>(type: "int", nullable: false),
                    yeni_oturum = table.Column<int>(type: "int", nullable: false),
                    organik_arama = table.Column<int>(type: "int", nullable: false),
                    tarih = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__websitel__9B2EF5BC9E466B66", x => new { x.siteanalitik_id, x.site_id, x.oturum, x.kullanici, x.sayfa_goruntuleme, x.ortalama_sure, x.yeni_oturum, x.hemen_cikma, x.organik_arama, x.tarih });
                });

            migrationBuilder.CreateTable(
                name: "websiteler_seo",
                columns: table => new
                {
                    websiteseo_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birim_id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    website_id = table.Column<int>(type: "int", nullable: false),
                    dil_id = table.Column<int>(type: "int", nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "('-')"),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "('-')"),
                    keyword = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "('-')"),
                    linkkural = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('{urun_kodu}-{link}')"),
                    facebooklink = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('#')"),
                    twitterlink = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('#')"),
                    linkedinlink = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('#')"),
                    instagramlink = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('#')"),
                    pinterestlink = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('#')"),
                    girisyazisi = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('giriş yazısı ekleyiniz')"),
                    eposta = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false, defaultValueSql: "('-')"),
                    telefon = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false, defaultValueSql: "('-')"),
                    gsm = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false, defaultValueSql: "('-')"),
                    adres = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('-')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__websitel__9A44475F5D87386A", x => new { x.websiteseo_id, x.birim_id });
                });

            migrationBuilder.CreateIndex(
                name: "eposta",
                table: "epostalistesi",
                column: "eposta",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "anahtarkelime",
                table: "resimler_icin_anahtar_kelime",
                column: "anahtarkelime",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "tekurun_kodu",
                table: "urunler",
                column: "urun_kodu",
                unique: true,
                filter: "[urun_kodu] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "acente_personel_loglar");

            migrationBuilder.DropTable(
                name: "acente_personeller");

            migrationBuilder.DropTable(
                name: "acenteler");

            migrationBuilder.DropTable(
                name: "acenteler_urunler");

            migrationBuilder.DropTable(
                name: "ayarlar");

            migrationBuilder.DropTable(
                name: "bankalar");

            migrationBuilder.DropTable(
                name: "birimler");

            migrationBuilder.DropTable(
                name: "birimler_dil");

            migrationBuilder.DropTable(
                name: "bloglar");

            migrationBuilder.DropTable(
                name: "bolgeler");

            migrationBuilder.DropTable(
                name: "bolgeler_dil");

            migrationBuilder.DropTable(
                name: "bolgeler_resim");

            migrationBuilder.DropTable(
                name: "cariler");

            migrationBuilder.DropTable(
                name: "degiskengruplar");

            migrationBuilder.DropTable(
                name: "degiskengruplar_dil");

            migrationBuilder.DropTable(
                name: "degiskenler");

            migrationBuilder.DropTable(
                name: "degiskenler_dil");

            migrationBuilder.DropTable(
                name: "departmanlar");

            migrationBuilder.DropTable(
                name: "diller");

            migrationBuilder.DropTable(
                name: "doluluk_takvimi");

            migrationBuilder.DropTable(
                name: "doviz_kuru");

            migrationBuilder.DropTable(
                name: "ekhizmetler");

            migrationBuilder.DropTable(
                name: "ekhizmetler_dil");

            migrationBuilder.DropTable(
                name: "ekhizmetler_fiyat");

            migrationBuilder.DropTable(
                name: "epostalistesi");

            migrationBuilder.DropTable(
                name: "epostalistesi_alicilar");

            migrationBuilder.DropTable(
                name: "epostalistesi_gonderiler");

            migrationBuilder.DropTable(
                name: "evsahibi_loglar");

            migrationBuilder.DropTable(
                name: "ilceler");

            migrationBuilder.DropTable(
                name: "ilceler_dil");

            migrationBuilder.DropTable(
                name: "ilceler_resim");

            migrationBuilder.DropTable(
                name: "iller");

            migrationBuilder.DropTable(
                name: "iller_dil");

            migrationBuilder.DropTable(
                name: "iller_resim");

            migrationBuilder.DropTable(
                name: "kampanyalar");

            migrationBuilder.DropTable(
                name: "kategoriler");

            migrationBuilder.DropTable(
                name: "kategoriler_dil");

            migrationBuilder.DropTable(
                name: "kbs_tesisler");

            migrationBuilder.DropTable(
                name: "kiralama_resimler");

            migrationBuilder.DropTable(
                name: "kiralama_talepleri");

            migrationBuilder.DropTable(
                name: "kredikartlari");

            migrationBuilder.DropTable(
                name: "kullanici_istekleri");

            migrationBuilder.DropTable(
                name: "mesajlar");

            migrationBuilder.DropTable(
                name: "mhsb_hareketler");

            migrationBuilder.DropTable(
                name: "mhsb_hesap_plani");

            migrationBuilder.DropTable(
                name: "mhsb_kasalar");

            migrationBuilder.DropTable(
                name: "mhsbfaturalar");

            migrationBuilder.DropTable(
                name: "mhsbfaturalar_detay");

            migrationBuilder.DropTable(
                name: "mhsbislemtipleri");

            migrationBuilder.DropTable(
                name: "moduller");

            migrationBuilder.DropTable(
                name: "odemetipleri");

            migrationBuilder.DropTable(
                name: "oneri_sablonlari");

            migrationBuilder.DropTable(
                name: "onrezervasyonlar");

            migrationBuilder.DropTable(
                name: "onrezervasyonlar_ekhizmet");

            migrationBuilder.DropTable(
                name: "onrezervasyonlar_neden");

            migrationBuilder.DropTable(
                name: "onrezervasyonlar_urun");

            migrationBuilder.DropTable(
                name: "operasyon_turleri");

            migrationBuilder.DropTable(
                name: "ozellikgruplar");

            migrationBuilder.DropTable(
                name: "ozellikgruplar_dil");

            migrationBuilder.DropTable(
                name: "ozellikler");

            migrationBuilder.DropTable(
                name: "ozellikler_dil");

            migrationBuilder.DropTable(
                name: "para_birimler");

            migrationBuilder.DropTable(
                name: "personel_istakipleri");

            migrationBuilder.DropTable(
                name: "personel_loglar");

            migrationBuilder.DropTable(
                name: "personel_logtipleri");

            migrationBuilder.DropTable(
                name: "personeller");

            migrationBuilder.DropTable(
                name: "personeller_yetki");

            migrationBuilder.DropTable(
                name: "rapor_sablongruplar");

            migrationBuilder.DropTable(
                name: "rapor_sablonlari");

            migrationBuilder.DropTable(
                name: "resimler_icin_anahtar_kelime");

            migrationBuilder.DropTable(
                name: "rezervasyonlar");

            migrationBuilder.DropTable(
                name: "rezervasyonlar_bilgi");

            migrationBuilder.DropTable(
                name: "rezervasyonlar_ekhizmet");

            migrationBuilder.DropTable(
                name: "rezervasyonlar_urun");

            migrationBuilder.DropTable(
                name: "sayfalar");

            migrationBuilder.DropTable(
                name: "semtler");

            migrationBuilder.DropTable(
                name: "semtler_dil");

            migrationBuilder.DropTable(
                name: "semtler_resim");

            migrationBuilder.DropTable(
                name: "siniflar");

            migrationBuilder.DropTable(
                name: "siniflar_dil");

            migrationBuilder.DropTable(
                name: "sirketler");

            migrationBuilder.DropTable(
                name: "sistemloglari");

            migrationBuilder.DropTable(
                name: "site_uyeler_favoriler");

            migrationBuilder.DropTable(
                name: "site_uyeler_rezervasyonlar");

            migrationBuilder.DropTable(
                name: "sitedil_ceviriler");

            migrationBuilder.DropTable(
                name: "sitedil_kelimeler");

            migrationBuilder.DropTable(
                name: "siteler");

            migrationBuilder.DropTable(
                name: "siteler_degiskengruplar");

            migrationBuilder.DropTable(
                name: "siteler_degiskenler");

            migrationBuilder.DropTable(
                name: "siteler_diller");

            migrationBuilder.DropTable(
                name: "siteler_ekhizmetler");

            migrationBuilder.DropTable(
                name: "siteler_kampanyalar");

            migrationBuilder.DropTable(
                name: "siteler_kategoriler");

            migrationBuilder.DropTable(
                name: "siteler_ozellikgruplar");

            migrationBuilder.DropTable(
                name: "siteler_ozellikler");

            migrationBuilder.DropTable(
                name: "siteler_parabirimleri");

            migrationBuilder.DropTable(
                name: "siteler_siniflar");

            migrationBuilder.DropTable(
                name: "siteler_urunler");

            migrationBuilder.DropTable(
                name: "slider");

            migrationBuilder.DropTable(
                name: "smslistesi");

            migrationBuilder.DropTable(
                name: "sss_sorular");

            migrationBuilder.DropTable(
                name: "ulkeler");

            migrationBuilder.DropTable(
                name: "urunler");

            migrationBuilder.DropTable(
                name: "urunler_banyolar");

            migrationBuilder.DropTable(
                name: "urunler_degiskenler");

            migrationBuilder.DropTable(
                name: "urunler_dil");

            migrationBuilder.DropTable(
                name: "urunler_ekfiyat");

            migrationBuilder.DropTable(
                name: "urunler_fiyat");

            migrationBuilder.DropTable(
                name: "urunler_istatistik");

            migrationBuilder.DropTable(
                name: "urunler_kampanyalar");

            migrationBuilder.DropTable(
                name: "urunler_kategoriler");

            migrationBuilder.DropTable(
                name: "urunler_kontrat");

            migrationBuilder.DropTable(
                name: "urunler_operatorler");

            migrationBuilder.DropTable(
                name: "urunler_ozellikler");

            migrationBuilder.DropTable(
                name: "urunler_resim");

            migrationBuilder.DropTable(
                name: "urunler_vitrin");

            migrationBuilder.DropTable(
                name: "urunler_yatakodalari");

            migrationBuilder.DropTable(
                name: "urunler_yorum");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "websiteler");

            migrationBuilder.DropTable(
                name: "websiteler_analitik");

            migrationBuilder.DropTable(
                name: "websiteler_seo");
        }
    }
}
