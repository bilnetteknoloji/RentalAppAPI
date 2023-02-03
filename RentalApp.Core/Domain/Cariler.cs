using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Cariler
    {
        public int CariId { get; set; }
        public string CariKodu { get; set; } = null!;
        public string? Tcpasno { get; set; }
        public string Adsoyad { get; set; } = null!;
        public string? Tel { get; set; }
        public string? Gsm { get; set; }
        public string? Eposta { get; set; }
        public string? Adres { get; set; }
        public string? Aciklama { get; set; }
        public bool? Alici { get; set; }
        public bool Satici { get; set; }
        public string? VergiDairesi { get; set; }
        public string? Vergino { get; set; }
        public string? FaturaUnvan { get; set; }
        public string? FaturaAdres { get; set; }
        public string? Banka { get; set; }
        public string? Iban { get; set; }
        public string? Kullaniciadi { get; set; }
        public string? Parola { get; set; }
        public int HesapId { get; set; }
        public bool EkhizmetSatici { get; set; }
    }
}
