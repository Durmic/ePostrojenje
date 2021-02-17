using System;
using System.Collections.Generic;

namespace ePostrojenje.WebAPI.Database
{
    public partial class Opreme
    {
        public Opreme()
        {
            MjernaMjestaOpreme = new HashSet<MjernaMjestaOpreme>();
        }

        public int OpremaId { get; set; }
        public string Naziv { get; set; }
        public string Napomena { get; set; }

        public ICollection<MjernaMjestaOpreme> MjernaMjestaOpreme { get; set; }
    }
}
