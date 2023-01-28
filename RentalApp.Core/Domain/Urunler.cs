using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Urunler
    {
        public int UrunId { get; set; }
        public int SinifId { get; set; }
        public int CariId { get; set; }
        public string? UrunKodu { get; set; }
        public string? Adres { get; set; }
        public int BolgeId { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public string? Enlem { get; set; }
        public string? Boylam { get; set; }
        public int SemtId { get; set; }
        public bool Sadecebizde { get; set; }
        public bool? Durum { get; set; }
        public string? VideoLink { get; set; }
        public string UrunAdi { get; set; } = null!;
        public int KdvOran { get; set; }
        /// <summary>
        /// 391 Hesapları
        /// </summary>
        public int KdvhesapId { get; set; }
        public int OzelresimId { get; set; }
        /// <summary>
        /// 1: Özel Havuzlu; 2: Müşterek Havuzlu; 3: Havuzsuz
        /// </summary>
        public byte Havuz { get; set; }
        public int TesisId { get; set; }
        public bool Booking { get; set; }
        public string? UrunKodu2 { get; set; }
        public string? VitrinResmi { get; set; }
        public string? IcalLink { get; set; }
    }
}
