using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class VwurunlerOzellikdegerleri
    {
        public int OzellikId { get; set; }
        public int OzellikgrupId { get; set; }
        public int? SiteId { get; set; }
        public int? DilId { get; set; }
        public int UrunId { get; set; }
        public string? Ozellik { get; set; }
        public string Deger { get; set; } = null!;
        public string? Birim { get; set; }
    }
}
