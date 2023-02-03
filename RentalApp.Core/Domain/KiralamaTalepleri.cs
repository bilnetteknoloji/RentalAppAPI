using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class KiralamaTalepleri
    {
        public int TalepId { get; set; }
        public int SiteId { get; set; }
        public string Adsoyad { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string Eposta { get; set; } = null!;
        public string Villaadresi { get; set; } = null!;
        public int Odasayi { get; set; }
        public int Banyosayi { get; set; }
        public int Yataksayi { get; set; }
        public string Mesaj { get; set; } = null!;
        public int Durum { get; set; }
        public DateTime Tarih { get; set; }
    }
}
