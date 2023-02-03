using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerDil
    {
        public int UrunDilId { get; set; }
        public int DilId { get; set; }
        public int UrunId { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
        public string? Link { get; set; }
        public int SiteId { get; set; }
        public string? Tagler { get; set; }
    }
}
