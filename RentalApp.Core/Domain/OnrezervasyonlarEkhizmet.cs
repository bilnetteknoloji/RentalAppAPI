using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class OnrezervasyonlarEkhizmet
    {
        public int OnrezervasyonekhizmetId { get; set; }
        public int OnrezervasyonId { get; set; }
        public int EkhizmetId { get; set; }
        public int Miktar { get; set; }
        public decimal Fiyat { get; set; }
    }
}
