using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class RezervasyonlarUrun
    {
        public int RezervasyonurunId { get; set; }
        public int RezervasyonId { get; set; }
        public int UrunId { get; set; }
        public decimal Fiyat { get; set; }
        public byte Kdvoran { get; set; }
        public decimal Kdv { get; set; }
        public int BirimId { get; set; }
        public decimal Tutar { get; set; }
        public string? Aciklama { get; set; }
        public DateTime Kullanimbaslangic { get; set; }
        public DateTime Kullanimbitis { get; set; }
        public int IndirimId { get; set; }
        public decimal Indirimtutar { get; set; }
        public decimal Maliyet { get; set; }
        public TimeSpan Girissaat { get; set; }
        public TimeSpan Cikissaat { get; set; }
        public bool Girisyapti { get; set; }
        public bool Cikisyapti { get; set; }
        public decimal Depozito { get; set; }
        public int DepozitobirimId { get; set; }
        public int OnodemeOran { get; set; }
        public decimal Onodeme { get; set; }
        public decimal Alinacakdepozito { get; set; }
    }
}
