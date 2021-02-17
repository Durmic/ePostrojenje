using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Odjeli
    {
        public Odjeli()
        {
            OdjeliOsoblje = new HashSet<OdjeliOsoblje>();
        }

        public int OdjelId { get; set; }
        public string Naziv { get; set; }
        public DateTime? DatumOtvaranja { get; set; }
        public DateTime? DatumZatvaranja { get; set; }
        public int? SluzbaId { get; set; }

        public Sluzbe Sluzba { get; set; }
        public ICollection<OdjeliOsoblje> OdjeliOsoblje { get; set; }
    }
}
