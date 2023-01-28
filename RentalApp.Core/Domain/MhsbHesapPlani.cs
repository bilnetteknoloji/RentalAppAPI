using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class MhsbHesapPlani
    {
        public int HesapId { get; set; }
        public string HesapKodu { get; set; } = null!;
        public string HesapAdi { get; set; } = null!;
        public int UsthesapId { get; set; }
        public string HesapGrubu { get; set; } = null!;
        public string? Aciklama { get; set; }
        public string AlthesapGrubu { get; set; } = null!;
        public short Carpan { get; set; }
        public byte Seviye { get; set; }
        public bool? Durum { get; set; }
    }
}
