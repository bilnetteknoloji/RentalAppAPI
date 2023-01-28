using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Semtler
    {
        public int SemtId { get; set; }
        public int IlceId { get; set; }
        public string Semt { get; set; } = null!;
        public string? Enlem { get; set; }
        public string? Boylam { get; set; }
        public int Sira { get; set; }
        public string PostaKodu { get; set; } = null!;
    }
}
