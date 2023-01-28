using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Sistemloglari
    {
        public int SistemlogId { get; set; }
        public string Ip { get; set; } = null!;
        public string Dosya { get; set; } = null!;
        public string Hatadetay { get; set; } = null!;
        public string Hatamesaj { get; set; } = null!;
        public string Hatamethod { get; set; } = null!;
        public string Metod { get; set; } = null!;
        public string Sinif { get; set; } = null!;
        public DateTime Tarihsaat { get; set; }
        public string Url { get; set; } = null!;
    }
}
