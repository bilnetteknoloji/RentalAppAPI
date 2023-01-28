using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Bolgeler
    {
        public int BolgeId { get; set; }
        public string Bolge { get; set; } = null!;
        public int Sira { get; set; }
    }
}
