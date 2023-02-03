using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerEkfiyat
    {
        public int UrunEkfiyatId { get; set; }
        public int UrunId { get; set; }
        public int EkhizmetId { get; set; }
        public bool Ucretsiz { get; set; }
        public bool Ucretli { get; set; }
        public bool Adet { get; set; }
        public bool Kisibasi { get; set; }
        public bool Gunluk { get; set; }
        public bool Haftalik { get; set; }
        public decimal Fiyat { get; set; }
        public int BirimId { get; set; }
        public bool Saatlik { get; set; }
        public bool? Istegebagli { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public decimal Maliyet { get; set; }
        public int CariId { get; set; }
        public int MaliyetbirimId { get; set; }
    }
}
