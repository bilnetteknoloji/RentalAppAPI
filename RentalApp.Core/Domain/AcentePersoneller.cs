using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class AcentePersoneller
    {
        public int PersonelId { get; set; }
        public string Adsoyad { get; set; } = null!;
        public string Eposta { get; set; } = null!;
        public string Sifre { get; set; } = null!;
        public bool? Durum { get; set; }
        public string? Gsm { get; set; }
        /// <summary>
        /// 335 Kodlu
        /// </summary>
        public int AcenteId { get; set; }
    }
}
