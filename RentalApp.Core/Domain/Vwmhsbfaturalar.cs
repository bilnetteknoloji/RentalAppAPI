using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwmhsbfaturalar
    {
        public string CariKodu { get; set; } = null!;
        public string? Adsoyad { get; set; }
        public string Soyad { get; set; } = null!;
        public string? Tcpasno { get; set; }
        public string? VergiDairesi { get; set; }
        public string Eposta { get; set; } = null!;
        public string Web { get; set; } = null!;
        public int Vade { get; set; }
        public decimal Try { get; set; }
        public DateTime? Giristarih { get; set; }
        public DateTime? Cikistarih { get; set; }
        public int? RezervasyonId { get; set; }
    }
}
