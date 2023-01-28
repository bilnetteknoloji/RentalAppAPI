using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class OnrezervasyonlarUrun
    {
        public int OnrezervasyonurunId { get; set; }
        public int OnrezervasyonId { get; set; }
        public int UrunId { get; set; }
        public bool Tercihedildi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public DateTime Tarih { get; set; }
        public int OnodemeOran { get; set; }
    }
}
