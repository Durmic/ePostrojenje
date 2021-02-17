using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Sluzbe
    {
        public Sluzbe()
        {
            Odjeli = new HashSet<Odjeli>();
        }

        public int SluzbaId { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }

        public ICollection<Odjeli> Odjeli { get; set; }
    }
}
