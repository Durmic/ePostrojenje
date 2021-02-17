using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Reklamacije
    {
        public Reklamacije()
        {
            Ocjene = new HashSet<Ocjene>();
        }

        public int ReklamacijaId { get; set; }
        public string Naslov { get; set; }
        public DateTime? DatumOtvaranja { get; set; }
        public DateTime? DatumZatvaranja { get; set; }
        public string Opis { get; set; }
        public bool? Status { get; set; }
        public int? KupacId { get; set; }
        public int? MjernoMjestoId { get; set; }
        public int? OsobljeId { get; set; }

        public Kupci Kupac { get; set; }
        public MjernaMjesta MjernoMjesto { get; set; }
        public Osoblje Osoblje { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
    }
}
