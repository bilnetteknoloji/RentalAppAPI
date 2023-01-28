using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class UrunlerYatakodalari
    {
        public int UrunyatakodasiId { get; set; }
        public int UrunId { get; set; }
        public decimal Metrekare { get; set; }
        public int Kat { get; set; }
        public int CiftKisilik { get; set; }
        public int TekKisilik { get; set; }
        public int Ranza { get; set; }
        public int IlaveYatak { get; set; }
        public int Bebek { get; set; }
        public bool Klima { get; set; }
        public bool Tv { get; set; }
        public bool OzelBanyo { get; set; }
    }
}
