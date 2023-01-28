using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class EpostalistesiGonderiler
    {
        public int EpostagonderiId { get; set; }
        public string Konu { get; set; } = null!;
        public string Icerik { get; set; } = null!;
        public DateTime Tarih { get; set; }
    }
}
