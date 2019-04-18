using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ispit_MVC.Models
{
    public class Poklon
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(25)]
        public string Naziv { get; set; }
        [StringLength(25)]
        public string Velicina { get; set; }
        [StringLength(25)]
        public string Kolicina { get; set; }

        public bool Kupljen { get; set; }
    }
}