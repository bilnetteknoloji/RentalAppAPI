using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class IllerDil
    {
        public int IldilId { get; set; }
        public int DilId { get; set; }
        public int IlId { get; set; }
        public string Aciklama { get; set; } = null!;
        public string Tagler { get; set; } = null!;
    }
}
