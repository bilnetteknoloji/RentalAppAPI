﻿using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Vwurunler
    {
        public int UrunId { get; set; }
        public int SinifId { get; set; }
        public int CariId { get; set; }
        public string? UrunKodu { get; set; }
        public string UrunAdi { get; set; } = null!;
        public string? Adres { get; set; }
        public int BolgeId { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public string? Enlem { get; set; }
        public string? Boylam { get; set; }
        public int SemtId { get; set; }
        public bool Sadecebizde { get; set; }
        public bool Booking { get; set; }
        public bool Durum { get; set; }
        public string? VideoLink { get; set; }
        public string? VitrinResmi { get; set; }
        public byte Havuz { get; set; }
        public int TesisId { get; set; }
        public string? IcalLink { get; set; }
        public string? Adsoyad { get; set; }
        public string? Sinif { get; set; }
        public string? Bolge { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Semt { get; set; }
        public string TesisAdi { get; set; } = null!;
        public int? DilId { get; set; }
    }
}
