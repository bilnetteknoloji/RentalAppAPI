using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Smslistesi
    {
        public int TelnoId { get; set; }
        public string Adsoyad { get; set; } = null!;
        public string Telno { get; set; } = null!;
        public bool? Listede { get; set; }
        public DateTime Tarih { get; set; }
        public string? Notlar { get; set; }
    }
}
