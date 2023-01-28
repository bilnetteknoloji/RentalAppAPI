using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwtrsiniflar
    {
        public int SinifId { get; set; }
        public string Link { get; set; } = null!;
        public string Geneltanim { get; set; } = null!;
        public string? Resim { get; set; }
        public byte Villa { get; set; }
        public bool Durum { get; set; }
        public string? Sinif { get; set; }
    }
}
