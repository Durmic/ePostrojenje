using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model
{
    public class Kupci
    {
        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public string Pitanje { get; set; }
        public string Odgovor { get; set; }
    }
}
