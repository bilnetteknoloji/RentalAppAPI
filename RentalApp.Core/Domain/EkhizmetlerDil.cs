using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class EkhizmetlerDil
    {
        public int EkhizmetdilId { get; set; }
        public int EkhizmetId { get; set; }
        public int DilId { get; set; }
        public string Ekhizmet { get; set; } = null!;
    }
}
