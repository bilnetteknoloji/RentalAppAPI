using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class DovizKuru
    {
        public int KurId { get; set; }
        public int BirimId { get; set; }
        public decimal DovizAlis { get; set; }
        public decimal DovizSatis { get; set; }
        public decimal EfektifAlis { get; set; }
        public decimal EfektifSatis { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Sabitkur { get; set; }
    }
}
