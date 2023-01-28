using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class IllerResim
    {
        public int ResimId { get; set; }
        public int IlId { get; set; }
        public string Resim { get; set; } = null!;
        public int Sira { get; set; }
    }
}
