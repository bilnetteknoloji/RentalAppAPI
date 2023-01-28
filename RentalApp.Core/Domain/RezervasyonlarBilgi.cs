using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class RezervasyonlarBilgi
    {
        public int RezervasyonbilgiId { get; set; }
        public int RezervasyonId { get; set; }
        public string? Tcpassno { get; set; }
        public string? Telefon { get; set; }
        public string? Eposta { get; set; }
        public string BelgeTuru { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int Ulke { get; set; }
        public string Ad { get; set; } = null!;
        public bool EkipLideri { get; set; }
        public bool Yorumhatirlatildi { get; set; }
        public int RezervasyonurunId { get; set; }
        public bool KbsGiris { get; set; }
        public bool KbsCikis { get; set; }
        public string? Cinsiyet { get; set; }
        public string? MedeniHal { get; set; }
        public DateTime? DogumTarihi { get; set; }
    }
}
