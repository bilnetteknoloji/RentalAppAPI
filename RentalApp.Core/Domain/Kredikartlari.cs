using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Kredikartlari
    {
        public int KredikartiId { get; set; }
        public int BankaId { get; set; }
        public string Kredikarti { get; set; } = null!;
    }
}
