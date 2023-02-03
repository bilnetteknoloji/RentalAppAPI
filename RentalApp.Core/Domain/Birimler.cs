
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalApp.Core
{
    [Table("Birimler")]
    public partial class Birimler
    {
        [Key]
        public int BirimId { get; set; }
        public string Birim { get; set; } = null!;
    }
}
