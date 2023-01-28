using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Siteler
    {
        public int SiteId { get; set; }
        public string Site { get; set; } = null!;
        public bool? Durum { get; set; }
    }
}
