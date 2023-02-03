using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class RezervasyonlarEkhizmet
    {
        public int RezervasyonekhizmetId { get; set; }
        public int RezervasyonId { get; set; }
        public int EkhizmetId { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Miktar { get; set; }
        public decimal Tutar { get; set; }
        public int Ucret { get; set; }
        public int Sure { get; set; }
        public int Adet { get; set; }
        public string? Aciklama { get; set; }
        public int UrunId { get; set; }
        public decimal Maliyet { get; set; }
        public int BirimId { get; set; }
    }
}
