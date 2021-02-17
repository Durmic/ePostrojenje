using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model.Requests
{
    public class UgovoriUpdateRequest
    {
        public string BrojUgovora { get; set; }
        public string Opis { get; set; }
        public DateTime DatumSklapanja { get; set; }
        public bool Status { get; set; }
        public int OsobljeId { get; set; }
    }
}
