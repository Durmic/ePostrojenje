using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model
{
    public class Obavjestenja
    {
        public int ObavjestenjeId { get; set; }
        public string Naslov { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public DateTime DatumPocetka { get; set; }
        public string Tekst { get; set; }
        public string VrstaObavjestenja { get; set; }
        public int OsobljeId { get; set; }

        public Osoblje Osoblje { get; set; }
    }
}
