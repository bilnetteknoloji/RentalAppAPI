using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class AcentePersonelLoglar
    {
        public int LogId { get; set; }
        public int LogtipId { get; set; }
        public int ModulId { get; set; }
        public int? KayitId { get; set; }
        public DateTime Tarih { get; set; }
        public int PersonelId { get; set; }
    }
}
