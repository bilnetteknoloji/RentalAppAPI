using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwrezervasyonlaruygunluk
    {
        public int RezervasyonurunId { get; set; }
        public int? RezervasyonId { get; set; }
        public int UrunId { get; set; }
        public string? UrunKodu { get; set; }
        public DateTime? Giristarih { get; set; }
        public DateTime? Cikistarih { get; set; }
        public int? Durum { get; set; }
        public string? Aciklama { get; set; }
        public int? OpsiyonSuresi { get; set; }
    }
}
