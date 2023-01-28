using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Kampanyalar
    {
        public int KampanyaId { get; set; }
        public int Oran { get; set; }
        public decimal Tutar { get; set; }
        public DateTime? RezTarihbaslangic { get; set; }
        public DateTime? RezTarihbitis { get; set; }
        public DateTime? Konaklamabaslangic { get; set; }
        public DateTime? Konaklamabitis { get; set; }
        public byte NetOran { get; set; }
        public string KampanyaAdi { get; set; } = null!;
        /// <summary>
        /// Sira  numarasına göre indirim uygulanır.
        /// </summary>
        public byte Sira { get; set; }
    }
}
