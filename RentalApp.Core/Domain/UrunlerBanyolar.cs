using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerBanyolar
    {
        public int UrunbanyoId { get; set; }
        public decimal Metrekare { get; set; }
        public int Kat { get; set; }
        public bool Wc { get; set; }
        public bool Dus { get; set; }
        public bool Kuvet { get; set; }
        public bool Jakuzi { get; set; }
        public int YatakodasiId { get; set; }
        public int UrunId { get; set; }
    }
}
