using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Ugovori
    {
        public int UgovorId { get; set; }
        public string BrojUgovora { get; set; }
        public string Opis { get; set; }
        public DateTime DatumSklapanja { get; set; }
        public bool? Status { get; set; }
        public int? OsobljeId { get; set; }
        public int? KupacId { get; set; }
        public int? TarifniStavId { get; set; }

        public Kupci Kupac { get; set; }
        public Osoblje Osoblje { get; set; }
        public TarifniStavovi TarifniStav { get; set; }
    }
}
