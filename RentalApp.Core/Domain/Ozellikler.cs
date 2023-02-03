using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Ozellikler
    {
        public int OzellikId { get; set; }
        public int OzellikgrupId { get; set; }
        public string? Geneltanim { get; set; }
        public int BirimId { get; set; }
        public bool? Durum { get; set; }
    }
}
