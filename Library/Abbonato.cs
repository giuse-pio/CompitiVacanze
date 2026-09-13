using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace Library
{
    public class Abbonato
    {
        public string Nome { get; set; }
        public string Cognomome { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Residenza { get; set; }
        public string Genere { get; set; }
        public List<Abbonamento> Abbonamenti { get; set; } = new List<Abbonamento>();   


       
    }
}