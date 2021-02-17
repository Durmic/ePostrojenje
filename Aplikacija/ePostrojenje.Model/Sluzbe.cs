using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model
{
    public class Sluzbe
    {
        public int SluzbaId { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }

        public ICollection<Odjeli> Odjeli { get; set; }
    }
}
