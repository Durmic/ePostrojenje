using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class MjernaMjesta
    {
        public MjernaMjesta()
        {
            Kupci = new HashSet<Kupci>();
            MjernaMjestaOpreme = new HashSet<MjernaMjestaOpreme>();
            Reklamacije = new HashSet<Reklamacije>();
        }

        public int MjernoMjestoId { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string PostanskiBroj { get; set; }
        public string Pin { get; set; }

        public ICollection<Kupci> Kupci { get; set; }
        public ICollection<MjernaMjestaOpreme> MjernaMjestaOpreme { get; set; }
        public ICollection<Reklamacije> Reklamacije { get; set; }
    }
}
