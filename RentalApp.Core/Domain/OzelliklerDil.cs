using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class OzelliklerDil
    {
        public int OzellikDilId { get; set; }
        public int DilId { get; set; }
        public int OzellikId { get; set; }
        public string Ozellik { get; set; } = null!;
    }
}
