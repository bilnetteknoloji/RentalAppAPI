using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Sayfalar
    {
        public int SayfaId { get; set; }
        public int SiteId { get; set; }
        public int DilId { get; set; }
        public string Link { get; set; } = null!;
        public string Baslik { get; set; } = null!;
        public string Icerik { get; set; } = null!;
        public string? Tanim { get; set; }
    }
}
