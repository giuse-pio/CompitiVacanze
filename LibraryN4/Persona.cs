namespace LibraryN4
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public List<Animale> Animali { get; set; } = new List<Animale>();


        public float EtaMediaAnimaliDellaPersona()
        {
            float etaMedia = 0;
            foreach (var animale in Animali)
            {
                etaMedia += animale.Eta;
            }
            return etaMedia;
        }
    }
}