using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model
{
    public class Osoblje
    {
        public int OsobljeId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        public string Mail { get; set; }
        public string KorisnickoIme { get; set; }
        public string Pitanje { get; set; }
        public string Odgovor { get; set; }

        public string Password { get; set; }

        //public ICollection<OdjeliOsoblje> OdjeliOsoblje { get; set; } = new ICollection<OdjeliOsoblje>();
    }
}
