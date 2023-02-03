using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class WebsitelerAnalitik
    {
        public int SiteanalitikId { get; set; }
        public int SiteId { get; set; }
        public int Oturum { get; set; }
        public int Kullanici { get; set; }
        public int SayfaGoruntuleme { get; set; }
        public TimeSpan OrtalamaSure { get; set; }
        public int HemenCikma { get; set; }
        public int YeniOturum { get; set; }
        public int OrganikArama { get; set; }
        public DateTime Tarih { get; set; }
    }
}
