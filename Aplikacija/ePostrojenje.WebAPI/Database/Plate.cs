using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Plate
    {
        public int OsobljeId { get; set; }
        public DateTime OdDatuma { get; set; }
        public DateTime DoDatuma { get; set; }
        public decimal Iznos { get; set; }

        public Osoblje Osoblje { get; set; }
    }
}
