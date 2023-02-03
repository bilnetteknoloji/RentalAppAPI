using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class SiniflarDil
    {
        public int SinifDilId { get; set; }
        public int DilId { get; set; }
        public int SinifId { get; set; }
        public string Sinif { get; set; } = null!;
    }
}
