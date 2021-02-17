using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Osoblje
    {
        public Osoblje()
        {
            Obavjestenja = new HashSet<Obavjestenja>();
            Ocjene = new HashSet<Ocjene>();
            OdjeliOsoblje = new HashSet<OdjeliOsoblje>();
            Plate = new HashSet<Plate>();
            Reklamacije = new HashSet<Reklamacije>();
            Ugovori = new HashSet<Ugovori>();
        }

        public int OsobljeId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        public string Mail { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Pitanje { get; set; }
        public string Odgovor { get; set; }
        public int? OdjelId { get; set; }

        public ICollection<Obavjestenja> Obavjestenja { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<OdjeliOsoblje> OdjeliOsoblje { get; set; }
        public ICollection<Plate> Plate { get; set; }
        public ICollection<Reklamacije> Reklamacije { get; set; }
        public ICollection<Ugovori> Ugovori { get; set; }
    }
}
