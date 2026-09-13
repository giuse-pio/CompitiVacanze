using System.ComponentModel;

namespace LibraryN3
{
    public class Film
    {
        public int ID { get; set; }
        public string Titolo { get; set; }
        public List<Artista> Artisti { get; set; } = new List<Artista>();
        public List<Recensione> Recenzioni { get; set; } = new List<Recensione>();
    }
}