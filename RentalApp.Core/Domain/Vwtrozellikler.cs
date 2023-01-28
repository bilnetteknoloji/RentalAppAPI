using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwtrozellikler
    {
        public int OzellikgrupId { get; set; }
        public int OzellikId { get; set; }
        public string? Ozellik { get; set; }
        public string Birim { get; set; } = null!;
        public int BirimId { get; set; }
    }
}
