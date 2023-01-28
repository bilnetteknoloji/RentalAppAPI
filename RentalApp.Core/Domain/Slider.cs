using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Slider
    {
        public int SliderId { get; set; }
        public int DilId { get; set; }
        public string? Baslik { get; set; }
        public string Gorsel { get; set; } = null!;
        public string Link { get; set; } = null!;
        public bool Yenisayfa { get; set; }
        public int Sira { get; set; }
    }
}
