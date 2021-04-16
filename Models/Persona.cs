using System;
using System.ComponentModel.DataAnnotations;

namespace Marazzi.Kevin._5H.SecondaWeb.Models
{
    public class Persona
    {
        public string Nome {get;set;}

        public string Cognome {get;set;}
        public int PresonaId { get; set; }
        public DateTime Data{ get; set; }=DateTime.Now;
    }
}
