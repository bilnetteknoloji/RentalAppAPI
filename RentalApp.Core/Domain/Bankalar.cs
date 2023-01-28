using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Bankalar
    {
        public int BankaId { get; set; }
        public string? Banka { get; set; }
        public string? Sube { get; set; }
        public string? SwiftKodu { get; set; }
        public string? Iban { get; set; }
        public string Unvan { get; set; } = null!;
        public int BirimId { get; set; }
        public string? Adres { get; set; }
    }
}
