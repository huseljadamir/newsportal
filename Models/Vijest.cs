using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vijesti.Models
{
    public class Vijest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        [StringLength(20, ErrorMessage ="Maksimalno dozovljeno 20 karaktera")]
        public String Naziv { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        [StringLength(100, ErrorMessage = "Maksimalno dozovljeno 100 karaktera")]
        public String Naslov { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        [StringLength(10000, ErrorMessage = "Maksimalno dozovljeno 10000 karaktera")]
        public String Sadrzaj { get; set; }
    }
}