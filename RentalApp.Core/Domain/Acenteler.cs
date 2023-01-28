using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Acenteler
    {
        public int AcenteId { get; set; }
        public string Unvan { get; set; } = null!;
        public string? Aciklama { get; set; }
        public bool Durum { get; set; }
        public int CariId { get; set; }
    }
}
