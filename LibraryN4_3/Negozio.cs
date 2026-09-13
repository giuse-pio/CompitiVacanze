namespace LibraryN4_3
{
    public class Negozio
    {
        public List<Famiglia> Famiglie { get; set; }

        public int EtaMediaPraticantiDiUnoSport(SportPraticante sport)
        {
            int somma = 0;
            int count = 0;
            foreach(var f in Famiglie)
            {
                foreach(var p in f.Persone)
                {
                    if (p.Sport == sport)
                    {
                        somma += p.Eta;
                        count++;
                    }
                }
            }
            return somma / count;
        }
    }
}
