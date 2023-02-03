using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class SiteUyelerFavoriler
    {
        public int UyefavoriId { get; set; }
        public int SiteuyeId { get; set; }
        public int UrunId { get; set; }
        public DateTime Tarih { get; set; }
    }
}
