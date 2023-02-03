using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class RaporSablongruplar
    {
        public int SablongrupId { get; set; }
        public string SablongrupAd { get; set; } = null!;
        public string Sqlkodu { get; set; } = null!;
    }
}
