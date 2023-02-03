using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class BirimlerDil
    {
        public int BirimdilId { get; set; }
        public int BirimId { get; set; }
        public int DilId { get; set; }
        public string Sembol { get; set; } = null!;
    }
}
