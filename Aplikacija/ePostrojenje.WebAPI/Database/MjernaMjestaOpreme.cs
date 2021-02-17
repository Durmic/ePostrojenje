using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class MjernaMjestaOpreme
    {
        public int MjernoMjestoOpremaId { get; set; }
        public DateTime? DatumPostavljanja { get; set; }
        public string VrstaUredjaja { get; set; }
        public int? MjernoMjestoId { get; set; }
        public int? OpremaId { get; set; }

        public MjernaMjesta MjernoMjesto { get; set; }
        public Opreme Oprema { get; set; }
    }
}
