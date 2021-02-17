using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model.Requests
{
    public class ReklamacijeInsertRequest
    {
        public string Naslov { get; set; }
        public DateTime DatumOtvaranja { get; set; }
        public DateTime DatumZatvaranja { get; set; }
        public string Opis { get; set; }
        public bool? Status { get; set; }
        public int? KupacId { get; set; }
        public int? MjernoMjestoId { get; set; }
        public int? OsobljeId { get; set; }
    }
}
