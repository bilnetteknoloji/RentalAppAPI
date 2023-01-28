using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Kategoriler
    {
        public int KategoriId { get; set; }
        public int SinifId { get; set; }
        public string? Resim { get; set; }
        public string Link { get; set; } = null!;
        public bool? Durum { get; set; }
        public string Geneltanim { get; set; } = null!;
        public int Sira { get; set; }
    }
}
