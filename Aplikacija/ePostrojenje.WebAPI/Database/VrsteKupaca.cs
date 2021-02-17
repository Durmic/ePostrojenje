using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class VrsteKupaca
    {
        public VrsteKupaca()
        {
            Kupci = new HashSet<Kupci>();
        }

        public int VrstaKupcaId { get; set; }
        public decimal Popust { get; set; }
        public string Napomena { get; set; }

        public ICollection<Kupci> Kupci { get; set; }
    }
}
