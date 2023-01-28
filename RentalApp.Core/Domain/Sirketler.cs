using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Sirketler
    {
        public int SirketId { get; set; }
        public string Sirket { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string Adres { get; set; } = null!;
        public string Websitesi { get; set; } = null!;
        public string Gsm { get; set; } = null!;
        public string Epostasunucu { get; set; } = null!;
        public string Epostaadres { get; set; } = null!;
        public string Epostasifre { get; set; } = null!;
        public string Vouchersozlesme { get; set; } = null!;
    }
}
