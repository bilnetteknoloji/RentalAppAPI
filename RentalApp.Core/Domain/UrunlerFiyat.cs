using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerFiyat
    {
        public int FiyatId { get; set; }
        public int UrunId { get; set; }
        public decimal Fiyat { get; set; }
        public int BirimId { get; set; }
        public int MinimumKiralama { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public decimal Maliyet { get; set; }
        public int GirisGunu { get; set; }
        public decimal Depozito { get; set; }
        public int DepozitobirimId { get; set; }
        public int OnodemeOran { get; set; }
        public int MaliyetbirimId { get; set; }
    }
}
