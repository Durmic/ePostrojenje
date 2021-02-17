using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ePostrojenje.Model.Requests
{
    public class ObavjestenjaInsertRequest
    {
        [Required(ErrorMessage = "Naslov je obavezan!")]
        [MinLength(2, ErrorMessage = "Naslov mora sadrzavati minimalno dva karaktera!")]
        public string Naslov { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public DateTime? DatumPocetka { get; set; }
        public string Tekst { get; set; }
        public string VrstaObavjestenja { get; set; }
        public int? OsobljeId { get; set; }
    }
}
