using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwoperasyonlar
    {
        public int? RezervasyonId { get; set; }
        public int? RezervasyonurunId { get; set; }
        public string? UrunKodu { get; set; }
        public string? UrunAdi { get; set; }
        public int? CariId { get; set; }
        public string? Musteri { get; set; }
        public string? Gsm { get; set; }
        public int? SahipId { get; set; }
        public int? BolgeId { get; set; }
        public int? IlId { get; set; }
        public int? IlceId { get; set; }
        public int? SemtId { get; set; }
        public DateTime? Kullanimbaslangic { get; set; }
        public DateTime? Kullanimbitis { get; set; }
        public TimeSpan? Girissaat { get; set; }
        public TimeSpan? Cikissaat { get; set; }
        public bool? Girisyapti { get; set; }
        public bool? Cikisyapti { get; set; }
        public decimal? Depozito { get; set; }
        public int? DepozitobirimId { get; set; }
        public string? Aciklama { get; set; }
        public decimal? Kalanbakiye { get; set; }
    }
}
