using System.ComponentModel;

namespace LibraryN3
{
    public class Recensione
    {
        public string Descrizione { get; set; }
        public float Voto { get; set; }
        public Iscritto Autore{ get; set; }
    }
}