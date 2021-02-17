using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model
{
    public class RSII25092020
    {
        public int Rsid { get; set; }
        public int? KupacId { get; set; }
        public DateTime DatumLogiranja { get; set; }
        public bool? PotencijalnoMaliciozan { get; set; }
        public int? BrojPrijava { get; set; }

        public Kupci Kupac { get; set; }
    }
}
