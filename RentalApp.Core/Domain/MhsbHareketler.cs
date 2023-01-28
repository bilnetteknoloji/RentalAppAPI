using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class MhsbHareketler
    {
        public int MhsbhareketId { get; set; }
        public int IslemtipId { get; set; }
        public int CariId { get; set; }
        public int RezervasyonId { get; set; }
        public int PersonelId { get; set; }
        public int FaturaId { get; set; }
        public int BankaId { get; set; }
        public int KredikartiId { get; set; }
        public int ParabirimId { get; set; }
        public int UrunId { get; set; }
        public int OperatorId { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public bool? Kdvdahil { get; set; }
        public int Kdvoran { get; set; }
        public decimal Kdvtutar { get; set; }
        public string? Aciklama { get; set; }
        public bool? Durum { get; set; }
        public DateTime Islemtarihi { get; set; }
        public DateTime Tarih { get; set; }
        public int Donem { get; set; }
    }
}
