namespace LibraryN4_3
{
    public enum SportPraticante
    {
        Pallavolo,
        Calcio,
        Nuoto
    };
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public SportPraticante Sport { get; set; }
        public int Eta { get; set; }
    }
}