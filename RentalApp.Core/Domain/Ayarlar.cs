using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Ayarlar
    {
        public int AyarId { get; set; }
        public int Anadil { get; set; }
        public string FisSeri { get; set; } = null!;
        public int FisSayac { get; set; }
        public string FaturaSeri { get; set; } = null!;
        public int FaturaSayac { get; set; }
    }
}
