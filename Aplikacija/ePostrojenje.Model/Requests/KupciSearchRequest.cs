using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model.Requests
{
    public class KupciSearchRequest
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        //public DateTime DatumRodjenja { get; set; }
    }
}
