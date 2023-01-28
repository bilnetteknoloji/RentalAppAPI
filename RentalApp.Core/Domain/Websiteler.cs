using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Websiteler
    {
        public int WebsiteId { get; set; }
        public string Website { get; set; } = null!;
        public string? Bingdogrulamakodu { get; set; }
        public string? Yandexdogrulamakodu { get; set; }
        public string? Googledogrulamakodu { get; set; }
        public string? Googleanalytics { get; set; }
        public string? Fbadmins { get; set; }
        public string? Fbappid { get; set; }
        public string? SiteAdi { get; set; }
        public int Sira { get; set; }
        /// <summary>
        /// Helal, Villa market ayrımı için kullanılmaktadır.
        /// </summary>
        public int SiteId { get; set; }
        /// <summary>
        /// Açılış ana dili için kullanılmaktadır.
        /// </summary>
        public int DilId { get; set; }
        public string? Logo { get; set; }
        public string? Gtmkodu { get; set; }
    }
}
