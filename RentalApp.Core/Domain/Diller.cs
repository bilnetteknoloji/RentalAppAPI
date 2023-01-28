using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Diller
    {
        public int DilId { get; set; }
        public string Dil { get; set; } = null!;
        public string DilKod { get; set; } = null!;
        public string DilKisakod { get; set; } = null!;
        public string DilYon { get; set; } = null!;
        public bool? Durum { get; set; }
    }
}
