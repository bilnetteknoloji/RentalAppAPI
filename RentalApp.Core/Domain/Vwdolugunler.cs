using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwdolugunler
    {
        public int RezervasyonId { get; set; }
        public int? RezervasyonurunId { get; set; }
        public int? UrunId { get; set; }
        public DateTime? Kullanimbaslangic { get; set; }
        public DateTime? Kullanimbitis { get; set; }
        public int Durum { get; set; }
    }
}
