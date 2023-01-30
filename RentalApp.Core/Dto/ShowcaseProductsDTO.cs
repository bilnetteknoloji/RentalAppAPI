using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Core.Dto
{
    public class ShowcaseProductsDTO
    {
        public long? id { get; set; }

        public int? urun_id { get; set; }
        public int? dil_id { get; set; }
        public string link { get; set; } = null!;
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? urun_kodu { get; set; }
        public string UrunAdi { get; set; } = null!;
        public string? resim { get; set; }
        public string? fiyat { get; set; }
        public int Puan { get; set; }
    }
}
