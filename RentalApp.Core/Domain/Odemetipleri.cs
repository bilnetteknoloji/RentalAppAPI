using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Odemetipleri
    {
        public int OdemetipId { get; set; }
        public string Odemetipi { get; set; } = null!;
        /// <summary>
        /// 0 : Banka Harici, 1 : Banka Üzerinden
        /// </summary>
        public bool? Bankadan { get; set; }
        public bool Kredikarti { get; set; }
    }
}
