using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class BolgelerResim
    {
        public int ResimId { get; set; }
        public int BolgeId { get; set; }
        public string Resim { get; set; } = null!;
        public int Sira { get; set; }
    }
}
