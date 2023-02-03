using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class VwurunlerFiyat
    {
        public int? UrunId { get; set; }
        public int FiyatId { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public decimal Fiyat { get; set; }
        public int MinimumKiralama { get; set; }
        public int GirisGunu { get; set; }
        public int BirimId { get; set; }
        public string Birim { get; set; } = null!;
        public decimal Depozito { get; set; }
        public int OnodemeOran { get; set; }
        public int DepozitobirimId { get; set; }
        public string Depozitobirim { get; set; } = null!;
    }
}
