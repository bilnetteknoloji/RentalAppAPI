using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Core.Dto
{

    public class Product
    {
        [Key]
        public int UrunId { get; set; }
        public int SinifId { get; set; }
        public string? UrunKodu { get; set; }
        public string? Adres { get; set; }
        public int BolgeId { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public string UrunAdi { get; set; } = null!;
        public int Puan { get; set; }
        public decimal Fiyat { get; set; }
        public string Resim { get; set; } = null!;
        public int DilId { get; set; }
        public string? Link { get; set; }
        public string UrunKampanyaId { get; set; } = null!;
        public int KampanyaId { get; set; }

    }
}
