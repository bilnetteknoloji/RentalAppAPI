using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class IlcelerResim
    {
        public int ResimId { get; set; }
        public int IlceId { get; set; }
        public string Resim { get; set; } = null!;
        public int Sira { get; set; }
    }
}
