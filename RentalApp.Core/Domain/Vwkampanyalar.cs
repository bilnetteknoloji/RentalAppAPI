using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwkampanyalar
    {
        public int UrunId { get; set; }
        public int SiteId { get; set; }
        public int UrunKampanyaId { get; set; }
        public int? KampanyaId { get; set; }
        public int? Oran { get; set; }
        public decimal? Tutar { get; set; }
        public DateTime? RezTarihbaslangic { get; set; }
        public DateTime? RezTarihbitis { get; set; }
        public DateTime? Konaklamabaslangic { get; set; }
        public DateTime? Konaklamabitis { get; set; }
        public byte? NetOran { get; set; }
        public string? KampanyaAdi { get; set; }
        public byte? Sira { get; set; }
    }
}
