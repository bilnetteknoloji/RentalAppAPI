using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Epostalistesi
    {
        public int EpostaId { get; set; }
        public string Adsoyad { get; set; } = null!;
        public string Eposta { get; set; } = null!;
        public bool? Listede { get; set; }
        public DateTime Tarih { get; set; }
        public string? Notlar { get; set; }
        public string OzelKod { get; set; } = null!;
    }
}
