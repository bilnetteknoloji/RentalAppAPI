using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class RaporSablonlari
    {
        public int RaporsablonId { get; set; }
        public int SablongrupId { get; set; }
        public string RaporsablonAd { get; set; } = null!;
        public string? Grup { get; set; }
        public string? Filtre { get; set; }
        public string? Kural { get; set; }
    }
}
