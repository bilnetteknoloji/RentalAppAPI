using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class DegiskenlerDil
    {
        public int DegiskenDilId { get; set; }
        public int DilId { get; set; }
        public int DegiskenId { get; set; }
        public string Degisken { get; set; } = null!;
    }
}
