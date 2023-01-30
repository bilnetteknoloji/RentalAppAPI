using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Core.Dto
{
    public partial class UrunlerDil
    {
        public int UrunDilId { get; set; }
        public int DilId { get; set; }
        public int UrunId { get; set; }
        public string? Link { get; set; }
    }
}
