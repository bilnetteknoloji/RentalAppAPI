using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class AcentelerUrunler
    {
        public int AcenteUrunId { get; set; }
        public int AcenteId { get; set; }
        public int UrunId { get; set; }
        public decimal KomisyonOran { get; set; }
        public bool Izin { get; set; }
    }
}
