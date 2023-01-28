using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class SitedilKelimeler
    {
        public int DilkelimeId { get; set; }
        public string Kelime { get; set; } = null!;
        public string GenelTanim { get; set; } = null!;
    }
}
