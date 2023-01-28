using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class SitedilCeviriler
    {
        public int DilceviriId { get; set; }
        public int DilkelimeId { get; set; }
        public int DilId { get; set; }
        public string Ceviri { get; set; } = null!;
    }
}
