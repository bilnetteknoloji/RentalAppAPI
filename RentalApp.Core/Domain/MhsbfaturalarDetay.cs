using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class MhsbfaturalarDetay
    {
        public int FaturadetayId { get; set; }
        public int FaturaId { get; set; }
        public string? Aciklama { get; set; }
        public decimal Tutar { get; set; }
    }
}
