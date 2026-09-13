namespace LibraryN4
{
    public enum TipoAnimali
    {
        Cane,
        Gatto,
        Criceto
    };
    public class Animale
    {
        public string Nome { get; set; }
        public TipoAnimali Tipo { get; set; }
        public int Eta { get; set; }


    }
}