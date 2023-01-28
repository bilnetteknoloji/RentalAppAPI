using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class DegiskengruplarDil
    {
        public int DegiskengrupDilId { get; set; }
        public int DilId { get; set; }
        public int DegiskengrupId { get; set; }
        public string Degiskengrup { get; set; } = null!;
    }
}
