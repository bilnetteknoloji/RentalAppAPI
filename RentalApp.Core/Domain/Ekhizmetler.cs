using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Ekhizmetler
    {
        public int EkhizmetId { get; set; }
        public string Geneltanim { get; set; } = null!;
        public int SinifId { get; set; }
    }
}
