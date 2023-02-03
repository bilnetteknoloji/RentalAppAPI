using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerIstatistik
    {
        public int IstatistikId { get; set; }
        public int UrunId { get; set; }
        public int SiteId { get; set; }
        public string Ip { get; set; } = null!;
        public DateTime Tarih { get; set; }
    }
}
