﻿using System;
using System.Collections.Generic;

namespace RentalApp.Core
{
    public partial class Degiskenler
    {
        public int DegiskenId { get; set; }
        public int DegiskengrupId { get; set; }
        public string? Geneltanim { get; set; }
        public bool? Durum { get; set; }
        public bool Filtrede { get; set; }
    }
}
