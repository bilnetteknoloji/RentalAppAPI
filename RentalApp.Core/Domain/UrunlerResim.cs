using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerResim
    {
        public int ResimId { get; set; }
        public int UrunId { get; set; }
        public string Resim { get; set; } = null!;
        public int Sira { get; set; }
        public bool Duzenlendi { get; set; }
    }
}
