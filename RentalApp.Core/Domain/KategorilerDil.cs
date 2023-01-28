using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class KategorilerDil
    {
        public int KategoriDilId { get; set; }
        public int DilId { get; set; }
        public int KategoriId { get; set; }
        public string Kategori { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
