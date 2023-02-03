using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwozellikler
    {
        public int OzellikId { get; set; }
        public int OzellikgrupId { get; set; }
        public string? Ozellik { get; set; }
        public string? Birim { get; set; }
        public string? Link { get; set; }
        public bool Durum { get; set; }
        public int? DilId { get; set; }
        public int? SiteId { get; set; }
    }
}
