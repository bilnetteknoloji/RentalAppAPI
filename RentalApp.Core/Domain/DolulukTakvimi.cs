using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class DolulukTakvimi
    {
        public int DolulukId { get; set; }
        public int UrunId { get; set; }
        public DateTime Tarih { get; set; }
        public int RezervasyonId { get; set; }
        public decimal Maliyet { get; set; }
        public decimal Fiyat { get; set; }
        public short Durum { get; set; }
        public int BirimId { get; set; }
        public int Minimum { get; set; }
        public int GirisGunu { get; set; }
    }
}
