using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model.Requests
{
    public class OsobljeUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        public string Mail { get; set; }
        public string KorisnickoIme { get; set; }
        public List<int> Odjeli { get; set; } = new List<int>();
    }
}
