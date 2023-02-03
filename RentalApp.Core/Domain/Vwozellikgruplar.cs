using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwozellikgruplar
    {
        public int? OzellikgrupId { get; set; }
        public string? Ozellikgrup { get; set; }
        public bool? Durum { get; set; }
        public int? SinifId { get; set; }
        public int? DilId { get; set; }
        public int SiteId { get; set; }
    }
}
