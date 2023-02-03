using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Personeller
    {
        public int PersonelId { get; set; }
        public string Adsoyad { get; set; } = null!;
        public string Eposta { get; set; } = null!;
        public string Sifre { get; set; } = null!;
        public bool? Durum { get; set; }
        public string? Gsm { get; set; }
        public int DepartmanId { get; set; }
        public string Epostasifre { get; set; } = null!;
        /// <summary>
        /// 335 Kodlu
        /// </summary>
        public int HesapId { get; set; }
        public string PersonelKodu { get; set; } = null!;
        /// <summary>
        /// 195 Kodlu
        /// </summary>
        public int AvanshesapId { get; set; }
        /// <summary>
        /// 770 Kodlu
        /// </summary>
        public int IsvhissehesapId { get; set; }
        /// <summary>
        /// 770 Kodlu
        /// </summary>
        public int IsvgiderihesapId { get; set; }
        /// <summary>
        /// 360 Kodlu
        /// </summary>
        public int GelirvergisihesapId { get; set; }
        /// <summary>
        /// 360 Kodlu
        /// </summary>
        public int DamgavergisihesapId { get; set; }
        /// <summary>
        /// 361 Kodlu
        /// </summary>
        public int SskpayihesapId { get; set; }
        /// <summary>
        /// 361 Kodlu
        /// </summary>
        public int SskisvhissesihesapId { get; set; }
        /// <summary>
        /// 361 Kodlu
        /// </summary>
        public int SigortapersonelpayihesapId { get; set; }
        /// <summary>
        /// 362 Kodlu
        /// </summary>
        public int SigortaisvpayihesapId { get; set; }
        public bool Adminmi { get; set; }
        public int SirketId { get; set; }
        public int Dahili { get; set; }
        public string? Resim { get; set; }
    }
}
