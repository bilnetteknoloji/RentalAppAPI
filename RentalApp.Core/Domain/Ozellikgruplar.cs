using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Ozellikgruplar
    {
        public int OzellikgrupId { get; set; }
        public int SinifId { get; set; }
        public string? Geneltanim { get; set; }
        public bool? Durum { get; set; }
    }
}
