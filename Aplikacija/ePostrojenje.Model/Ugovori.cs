using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model
{
    public class Ugovori
    {
        public int UgovorId { get; set; }
        public string BrojUgovora { get; set; }
        public string Opis { get; set; }
        public DateTime DatumSklapanja { get; set; }
        public bool Status { get; set; }
        public int OsobljeId { get; set; }
        public int KupacId { get; set; }
        public int TarifniStavId { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
    }
}
