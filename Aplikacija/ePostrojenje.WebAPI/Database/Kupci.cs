using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Kupci
    {
        public Kupci()
        {
            Racuni = new HashSet<Racuni>();
            Reklamacije = new HashSet<Reklamacije>();
            Rsii25092020 = new HashSet<Rsii25092020>();
            Ugovori = new HashSet<Ugovori>();
        }

        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Pitanje { get; set; }
        public string Odgovor { get; set; }
        public int? MjernoMjestoId { get; set; }
        public int? VrstaKupcaId { get; set; }

        public MjernaMjesta MjernoMjesto { get; set; }
        public VrsteKupaca VrstaKupca { get; set; }
        public ICollection<Racuni> Racuni { get; set; }
        public ICollection<Reklamacije> Reklamacije { get; set; }
        public ICollection<Rsii25092020> Rsii25092020 { get; set; }
        public ICollection<Ugovori> Ugovori { get; set; }
    }
}
