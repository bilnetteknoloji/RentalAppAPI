using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class OzellikgruplarDil
    {
        public int OzellikgrupDilId { get; set; }
        public int DilId { get; set; }
        public int OzellikgrupId { get; set; }
        public string Ozellikgrup { get; set; } = null!;
    }
}
