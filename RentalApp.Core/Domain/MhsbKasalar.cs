using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class MhsbKasalar
    {
        public int KasaId { get; set; }
        public int BirimId { get; set; }
        public string KasaAd { get; set; } = null!;
        public bool Varsayilan { get; set; }
    }
}
