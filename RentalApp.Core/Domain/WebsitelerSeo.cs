using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class WebsitelerSeo
    {
        public int WebsiteseoId { get; set; }
        public int WebsiteId { get; set; }
        public int DilId { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
        public string? Keyword { get; set; }
        public string Linkkural { get; set; } = null!;
        public string Facebooklink { get; set; } = null!;
        public string Twitterlink { get; set; } = null!;
        public string Linkedinlink { get; set; } = null!;
        public string Instagramlink { get; set; } = null!;
        public string Pinterestlink { get; set; } = null!;
        public string Girisyazisi { get; set; } = null!;
        public int BirimId { get; set; }
        public string Eposta { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string Gsm { get; set; } = null!;
        public string Adres { get; set; } = null!;
    }
}
