using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class VwurunlerEkfiyatlar
    {
        public int UrunId { get; set; }
        public int EkhizmetId { get; set; }
        public int? SiteId { get; set; }
        public int? DilId { get; set; }
        public string? Ekhizmet { get; set; }
        public bool Ucretsiz { get; set; }
        public bool Ucretli { get; set; }
        public bool Saatlik { get; set; }
        public bool Gunluk { get; set; }
        public bool Haftalik { get; set; }
        public bool Kisibasi { get; set; }
        public bool Adet { get; set; }
        public decimal Fiyat { get; set; }
        public int BirimId { get; set; }
    }
}
