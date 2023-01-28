using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class KbsTesisler
    {
        public int TesisId { get; set; }
        public string TesisAdi { get; set; } = null!;
        public string TesisKodu { get; set; } = null!;
        public string Parola { get; set; } = null!;
        public string YetkiliTcno { get; set; } = null!;
    }
}
