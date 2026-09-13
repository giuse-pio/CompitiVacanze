namespace LibraryN2
{
    public class Evento
    {
        public string Luogo { get; set; }
        public string Artista { get; set; }
        public string Titolo { get; set; }
        public List<Post> Post { get; set; }
        public DateTime Data { get; set; }
        public List<string> Categoria { get; set; }


        public float VotoMedioPerQuestoEvento()
        {
            float somma = 0;
            foreach (var p in Post)
            {
                somma += p.Voto;
            }
            return somma / Post.Count;
        }

    }
}