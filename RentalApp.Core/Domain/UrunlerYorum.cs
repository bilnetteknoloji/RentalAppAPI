using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerYorum
    {
        public int YorumId { get; set; }
        public int UrunId { get; set; }
        public string? Adsoyad { get; set; }
        public string Baslik { get; set; } = null!;
        public string Yorum { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public bool Durum { get; set; }
        public string? Eposta { get; set; }
        public int Puan { get; set; }
    }
}
