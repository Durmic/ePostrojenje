using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model
{
    public partial class OdjeliOsoblje
    {
        public int OdjeliOsobljeId { get; set; }
        public int OdjelId { get; set; }
        public int OsobljeId { get; set; }

        public Odjeli Odjel { get; set; } 
        public Osoblje Osoblje { get; set; }
    }
}
