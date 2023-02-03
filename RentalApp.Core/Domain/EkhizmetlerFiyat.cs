using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class EkhizmetlerFiyat
    {
        public int EkhizmetfiyatId { get; set; }
        public int EkhizmetId { get; set; }
        public int CariId { get; set; }
        public int UrunId { get; set; }
        public int SemtId { get; set; }
        public int BirimId { get; set; }
        /// <summary>
        /// 1: Ücretsiz; 2: Ücretli
        /// </summary>
        public int Ucretli { get; set; }
        /// <summary>
        /// 1: Saatlik; 2: Günlük; 3: Haftalık
        /// </summary>
        public int Periyot { get; set; }
        public bool? Istegebagli { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Maliyet { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public int Donem { get; set; }
        /// <summary>
        /// 1: Kişibaşı; 2: Adet(Toplam)
        /// </summary>
        public int Kisibasi { get; set; }
        public int MaliyetbirimId { get; set; }
    }
}
