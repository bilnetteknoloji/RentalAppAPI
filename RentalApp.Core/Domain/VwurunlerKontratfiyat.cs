using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class VwurunlerKontratfiyat
    {
        public int UrunId { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public decimal Maliyet { get; set; }
        public int MinimumKiralama { get; set; }
    }
}
