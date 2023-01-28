﻿using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerKontrat
    {
        public int KontratId { get; set; }
        public int UrunId { get; set; }
        public int CariId { get; set; }
        public string KontratAd { get; set; } = null!;
        public DateTime Gecerliliktarih { get; set; }
        public DateTime Indirimtarih { get; set; }
        public int Indirimoran { get; set; }
        public bool Indirimkabul { get; set; }
        public bool Satiskabul { get; set; }
        public string Cezabedel { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public int RevizyonNo { get; set; }
    }
}
