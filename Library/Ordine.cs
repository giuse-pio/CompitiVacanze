using System.Reflection.Metadata.Ecma335;

namespace Library
{
    public class Ordine
    {
        public Rivista Rivista { get; set; }
        public DateTime DataOrdine { get; set; }
        public int Quantita { get; set; }
    }
}