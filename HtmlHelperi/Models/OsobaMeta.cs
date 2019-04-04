using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HtmlHelperi.Models
{
    [DisplayName("Osoba")]
    public class OsobaMeta
    {
        [HiddenInput (DisplayValue =false)]
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

        [Display(Name="Mjesto stanovanja")]
        [UIHint("TemplMjesta")]
        public string MjestoStanovanja { get; set; }

        [UIHint("TemplSpol")]
        public string Spol { get; set; }

        public bool Zaposlen { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }

        [UIHint("MultilineText")]
        public string Napomena { get; set; }

        public Adresa AdresaOsobe { get; set; }
    }
}