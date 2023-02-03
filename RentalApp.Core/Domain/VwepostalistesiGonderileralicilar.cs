using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class VwepostalistesiGonderileralicilar
    {
        public int EpostagonderiId { get; set; }
        public int? EpostaaliciId { get; set; }
        public DateTime? Tarih { get; set; }
        public string Durum { get; set; } = null!;
        public string? Adsoyad { get; set; }
        public string? Eposta { get; set; }
    }
}
