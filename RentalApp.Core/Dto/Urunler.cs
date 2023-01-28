using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Core.Dto
{
    public class Urunler
    {
        public int? UrunId { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public UrunlerYorumlar UrunlerYorumlar { get; set; }
        public UrunlerFiyat UrunlerFiyat { get; set; }
        public Iller Iller { get; set; }
        public Ilceler Ilceler { get; set; }
        public UrunlerDil UrunlerDil { get; set; }
    }
}
