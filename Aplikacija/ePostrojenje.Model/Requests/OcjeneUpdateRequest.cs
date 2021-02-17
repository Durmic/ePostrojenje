using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model.Requests
{
    public class OcjeneUpdateRequest
    {
        public DateTime? Datum { get; set; }
        public int Ocjena { get; set; }
        public int? OsobljeId { get; set; }
        public int? ReklamacijaId { get; set; }
    }
}
