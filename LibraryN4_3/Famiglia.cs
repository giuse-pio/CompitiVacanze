namespace LibraryN4_3
{
    public class Famiglia
    {
        public string Cognome { get; set; }
        public List<Persona> Persone { get; set; }

        public int EtaMEdiaInFamiglia()
        {
            int somma = 0;
            int count = 0;
            foreach (var p in Persone)
            {
                if (Cognome == p.Cognome)
                {
                    somma = +p.Eta;
                    count++;
                }
            }   
            return somma/count;
        }
    }
}