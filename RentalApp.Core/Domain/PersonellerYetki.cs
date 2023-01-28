using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class PersonellerYetki
    {
        public int YetkiId { get; set; }
        public int ModulId { get; set; }
        public int PersonelId { get; set; }
        public bool Goruntule { get; set; }
        public bool Ekle { get; set; }
        public bool Duzenle { get; set; }
        public bool Sil { get; set; }
    }
}
