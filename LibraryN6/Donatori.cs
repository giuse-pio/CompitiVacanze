namespace LibraryN6
{
    public class Donatori
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public List<Donazioni> Donazione { get; set; } = new List<Donazioni>();
    }
}