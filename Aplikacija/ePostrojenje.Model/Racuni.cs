using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model
{
    public class Racuni
    {
        public int RacunId { get; set; }
        public string Referenca { get; set; }
        public DateTime DatumRacuna { get; set; }
        public DateTime? RokDospijeca { get; set; }
        public string Napomena { get; set; }
        public bool? Placen { get; set; }
        public int KupacId { get; set; }

        public Kupci Kupac { get; set; }
    }
}
