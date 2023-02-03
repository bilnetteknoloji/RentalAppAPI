using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Mesajlar
    {
        public int MesajId { get; set; }
        public int Gonderici { get; set; }
        public string Baslik { get; set; } = null!;
        public string Mesaj { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public int Alici { get; set; }
        public bool AliciSildi { get; set; }
        public bool GondericiSildi { get; set; }
        public bool Durum { get; set; }
    }
}
