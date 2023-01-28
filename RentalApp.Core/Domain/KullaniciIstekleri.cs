using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class KullaniciIstekleri
    {
        public int IstekId { get; set; }
        public int GonderenId { get; set; }
        public int ModulId { get; set; }
        public string Sorun { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public int CozenId { get; set; }
        public DateTime? CozumTarih { get; set; }
        /// <summary>
        /// -1:Çözülemedi, 0: Beklemede, 1: İşleme Alındı, 2: Çözüldü
        /// </summary>
        public int Durum { get; set; }
        public string? Eknot { get; set; }
    }
}
