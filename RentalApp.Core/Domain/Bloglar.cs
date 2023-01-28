using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Bloglar
    {
        public int BlogId { get; set; }
        public string? Baslik { get; set; }
        public string Icerik { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public string? Etiketler { get; set; }
        public int DilId { get; set; }
        public int SiteId { get; set; }
        public string Link { get; set; } = null!;
        public string Ozet { get; set; } = null!;
        public string Resim { get; set; } = null!;
    }
}
