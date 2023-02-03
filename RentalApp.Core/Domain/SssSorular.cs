using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class SssSorular
    {
        public int SoruId { get; set; }
        public int DilId { get; set; }
        public string Soru { get; set; } = null!;
        public int Sira { get; set; }
        public string Cevap { get; set; } = null!;
        /// <summary>
        /// 0 : SSS; 1 : Ürün detay bilgisi
        /// </summary>
        public int Tip { get; set; }
    }
}
