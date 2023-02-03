using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Mhsbislemtipleri
    {
        public int MhsbislemtipId { get; set; }
        public string? Islemkodu { get; set; }
        public string Islemadi { get; set; } = null!;
        public string? Aciklama { get; set; }
        public int OdemeKasaId { get; set; }
        public int TahsilatKasaId { get; set; }
        public bool Gelirgider { get; set; }
        public bool IadeIslemi { get; set; }
        public bool AliciIslemi { get; set; }
        public bool PersonelIslemi { get; set; }
        public bool SaticiIslemi { get; set; }
        public bool SistemIslemi { get; set; }
        public bool AcenteIslemi { get; set; }
        public bool AvansHesabi { get; set; }
        public bool Fatura { get; set; }
        public bool Malzeme { get; set; }
    }
}
