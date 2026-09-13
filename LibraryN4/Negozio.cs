namespace LibraryN4
{
    public class Negozio
    {
        public List<Persona> Persone { get; set; } = new List<Persona>();

        public float EtaMedia(TipoAnimali tipo)
        {
            float somma = 0;
            int count = 0;

            foreach (Persona persona in Persone)
            {
                foreach (var a in persona.Animali)
                {
                    if (a.Tipo == tipo)
                    {
                        somma += a.Eta; 
                        count++;      
                    }
                }
            }
            return somma / count;
        }
    }
}
