using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Mhsbfaturalar
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; } = null!;
        public int CariId { get; set; }
        /// <summary>
        /// 0:Satış Faturası, 1:Alış Faturası, 2:Satış İade, 3:Alış İade
        /// </summary>
        public int FaturaTur { get; set; }
        public string? Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Vergi { get; set; }
        public decimal Tutar { get; set; }
        public bool Yazdirildi { get; set; }
        public int RezervasyonId { get; set; }
    }
}
