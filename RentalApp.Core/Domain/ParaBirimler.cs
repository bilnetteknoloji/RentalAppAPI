using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class ParaBirimler
    {
        public int BirimId { get; set; }
        public string? Sembol { get; set; }
        public string Birim { get; set; } = null!;
        public bool Sagdan { get; set; }
        public bool Bosluk { get; set; }
        public string KurSira { get; set; } = null!;
        public int Katsayi { get; set; }
        public int HesapId { get; set; }
    }
}
