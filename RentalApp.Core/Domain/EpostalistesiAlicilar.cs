using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class EpostalistesiAlicilar
    {
        public int EpostaaliciId { get; set; }
        public int EpostagonderiId { get; set; }
        public int EpostaId { get; set; }
        public bool Durum { get; set; }
        public DateTime Tarih { get; set; }
    }
}
