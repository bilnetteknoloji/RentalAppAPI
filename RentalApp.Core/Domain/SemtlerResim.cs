using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class SemtlerResim
    {
        public int ResimId { get; set; }
        public int SemtId { get; set; }
        public string Resim { get; set; } = null!;
        public int Sira { get; set; }
    }
}
