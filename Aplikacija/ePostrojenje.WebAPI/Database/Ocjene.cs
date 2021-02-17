using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public DateTime? Datum { get; set; }
        public int Ocjena { get; set; }
        public int? OsobljeId { get; set; }
        public int? ReklamacijaId { get; set; }

        public Osoblje Osoblje { get; set; }
        public Reklamacije Reklamacija { get; set; }
    }
}
