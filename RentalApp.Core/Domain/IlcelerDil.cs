using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class IlcelerDil
    {
        public int IlcedilId { get; set; }
        public int DilId { get; set; }
        public int IlceId { get; set; }
        public string Aciklama { get; set; } = null!;
        public string Tagler { get; set; } = null!;
    }
}
