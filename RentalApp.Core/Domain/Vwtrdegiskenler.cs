using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwtrdegiskenler
    {
        public int DegiskenId { get; set; }
        public string? Degisken { get; set; }
        public bool Durum { get; set; }
        public int DegiskengrupId { get; set; }
    }
}
