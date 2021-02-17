using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Potrosnje
    {
        public int PotrosnjaId { get; set; }
        public decimal UkupnaPotrosnja { get; set; }
        public DateTime? OdDatuma { get; set; }
        public DateTime? DoDatuma { get; set; }
        public int? TarifniStavId { get; set; }
        public int? RacunId { get; set; }

        public Racuni Racun { get; set; }
        public TarifniStavovi TarifniStav { get; set; }
    }
}
