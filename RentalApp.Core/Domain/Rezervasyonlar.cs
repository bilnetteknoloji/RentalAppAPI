using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Rezervasyonlar
    {
        public int RezervasyonId { get; set; }
        public DateTime Giristarih { get; set; }
        public DateTime Cikistarih { get; set; }
        public decimal Tutar { get; set; }
        public int BirimId { get; set; }
        public DateTime Tarih { get; set; }
        public int CariId { get; set; }
        public int SiteId { get; set; }
        /// <summary>
        /// -2 : Elle Kapatıldı, - 1 : Rezervasyon İptal Edildi, 0 : Onay Bekliyor, 1 : Ödeme Bekliyor, 2 :  Voucher Gönderilecek, 3 : Müşteri Onayı, 4 : Rezervasyon Tamamlandı.
        /// </summary>
        public int Durum { get; set; }
        public string? Aciklama { get; set; }
        public int IslemId { get; set; }
        public int OnrezervasyonId { get; set; }
        public decimal Maliyet { get; set; }
        public bool Odemealindi { get; set; }
        public int OpsiyonSuresi { get; set; }
        public bool KimlikBildirilebilir { get; set; }
        public string? KonfirmasyonNo { get; set; }
        public int AcenteId { get; set; }
    }
}
