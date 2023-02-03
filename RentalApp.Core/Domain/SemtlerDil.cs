using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class SemtlerDil
    {
        public int SemtdilId { get; set; }
        public int DilId { get; set; }
        public int SemtId { get; set; }
        public string Aciklama { get; set; } = null!;
        public string Tagler { get; set; } = null!;
    }
}
