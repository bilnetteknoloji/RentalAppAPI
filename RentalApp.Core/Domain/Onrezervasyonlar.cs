using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Onrezervasyonlar
    {
        public int OnrezervasyonId { get; set; }
        public int OperatorId { get; set; }
        public string Musteri { get; set; } = null!;
        public int Kisisayi { get; set; }
        public int Yetiskinsayi { get; set; }
        public int Bebeksayi { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }
        public DateTime Giristarihi { get; set; }
        public DateTime Cikistarihi { get; set; }
        /// <summary>
        /// 0 : Görüşülmedi, 1 : Kapandı (Olumlu), 2 : Kapandı (olumsuz)
        /// </summary>
        public int Sonuc { get; set; }
        public int Nasilbuldu { get; set; }
        public string? Diger { get; set; }
        public string? Notlar { get; set; }
        public DateTime Tarih { get; set; }
        public int GorusenOperatorId { get; set; }
        /// <summary>
        /// 0: Bilgi Alma; 1: Rezervasyon
        /// </summary>
        public int NedenId { get; set; }
        public string? Telefon2 { get; set; }
        public int RezervasyonOperatorId { get; set; }
        public int OnrezervasyoniptalnedenId { get; set; }
        public string Iptalneden { get; set; } = null!;
        public int Hatirlatildi { get; set; }
        public int AcenteId { get; set; }
        public int CariId { get; set; }
    }
}
