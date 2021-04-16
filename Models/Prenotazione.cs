using System;
using System.ComponentModel.DataAnnotations;

namespace Marazzi.Kevin._5H.SecondaWeb
{
public class Prenotazione {
    public int PrenotazioneId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public bool? Partecipazione { get; set; }
    public DateTime DataPrenotazione{ get; set; }=DateTime.Now;
}

}
