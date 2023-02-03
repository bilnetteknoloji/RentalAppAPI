using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class OneriSablonlari
    {
        public int OnerisablonId { get; set; }
        public int SiteId { get; set; }
        public int DilId { get; set; }
        public string Sablon { get; set; } = null!;
    }
}
