using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerOzellikler
    {
        public int UrunOzellikId { get; set; }
        public int UrunId { get; set; }
        public int OzellikId { get; set; }
        public string Deger { get; set; } = null!;
        public int BirimId { get; set; }
    }
}
