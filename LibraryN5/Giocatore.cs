using System.Security.Principal;

namespace LibraryN5
{
    public enum Ruolo
    {
        Difensore,
        Attaccante,
        Centrocampista,
        Portiere
    };
    public class Giocatore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Ruolo Ruolo { get; set; }
        public int Valore { get; set; }
    }
}