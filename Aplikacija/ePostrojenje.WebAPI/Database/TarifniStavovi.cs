using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class TarifniStavovi
    {
        public TarifniStavovi()
        {
            Potrosnje = new HashSet<Potrosnje>();
            Ugovori = new HashSet<Ugovori>();
        }

        public int TarifniStavId { get; set; }
        public string Naziv { get; set; }
        public decimal? VecaTarifa { get; set; }
        public decimal? ManjaTarifa { get; set; }
        public decimal? SrednjaTarifa { get; set; }

        public ICollection<Potrosnje> Potrosnje { get; set; }
        public ICollection<Ugovori> Ugovori { get; set; }
    }
}
