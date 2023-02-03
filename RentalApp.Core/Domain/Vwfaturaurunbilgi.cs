using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwfaturaurunbilgi
    {
        public int? RezervasyonId { get; set; }
        public string? UrunKodu { get; set; }
        public int? UrunId { get; set; }
        public string? Kullanim { get; set; }
        public int Tip { get; set; }
    }
}
