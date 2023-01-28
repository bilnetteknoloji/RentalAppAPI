using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class BolgelerDil
    {
        public int BolgedilId { get; set; }
        public int DilId { get; set; }
        public int BolgeId { get; set; }
        public string Aciklama { get; set; } = null!;
        public string Tagler { get; set; } = null!;
    }
}
