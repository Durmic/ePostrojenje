using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model
{
    public class Ocjene
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
