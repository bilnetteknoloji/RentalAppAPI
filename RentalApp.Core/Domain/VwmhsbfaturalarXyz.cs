using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class VwmhsbfaturalarXyz
    {
        public int FaturaId { get; set; }
        public int CariId { get; set; }
        public int RezervasyonId { get; set; }
        public string FaturaNo { get; set; } = null!;
        public int FaturaTurx { get; set; }
        public string FaturaTur { get; set; } = null!;
        public string? CariUnvan { get; set; }
        public string? Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Vergi { get; set; }
        public decimal Tutar { get; set; }
        public bool Yazdirildix { get; set; }
        public string Yazdirildi { get; set; } = null!;
        public string? VergiDairesi { get; set; }
        public string? Vergino { get; set; }
        public string Caribilgiler { get; set; } = null!;
    }
}
