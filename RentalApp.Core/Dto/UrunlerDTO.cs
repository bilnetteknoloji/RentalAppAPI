using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Core.Dto
{
    public class UrunlerDTO
    {
        public int? UrunId { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public int? Puan { get; set; }
        public decimal? Fiyat { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Link { get; set; }
    }
}
