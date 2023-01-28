using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class PersonelIstakipleri
    {
        public int IstakipId { get; set; }
        public int PersonelId { get; set; }
        public DateTime Tarih { get; set; }
        public string Isdetay { get; set; } = null!;
    }
}
