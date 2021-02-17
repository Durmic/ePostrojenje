using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ePostrojenje.Model.Requests
{
    public class OsobljeInsertRequest
    {
        [Required(ErrorMessage = "Ime je obavezno!")]
        [MinLength(2, ErrorMessage = "Ime mora sadrzavati minimalno dva karaktera!")]
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public DateTime DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        [EmailAddress(ErrorMessage = "Email nije u formatu!")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Ime je obavezno!")]
        [MinLength(3, ErrorMessage = "Korisnicko ime mora sadrzavati minimalno tri karaktera!")]
        public string KorisnickoIme { get; set; }

        [MinLength(3, ErrorMessage = "Password mora sadrzavati minimalno tri karaktera!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [MinLength(3)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Potvrda lozinke ne odgovara!")]
        public string PasswordConfirmation { get; set; }

        [MinLength(2)]
        [Required]
        public string Pitanje { get; set; }
        [Required]
        public string Odgovor { get; set; }

        public List<int> Odjeli { get; set; } = new List<int>();
    }
}
