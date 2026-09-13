namespace LibraryN2
{
    public class Membro
    {
        public string Nickname { get; set; }
        public string Nome { get; set; }
        public string Cognoome { get; set; }
        public string Email{ get; set; }
        public List<string> CategoriaScelta{ get; set; }

        public List<Commento> Commenti { get; set; }

    }
}