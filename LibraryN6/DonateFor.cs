namespace LibraryN6
{
    public class DonateFor
    {
        public List<Onlus> Onlus { get; set; } = new List<Onlus>();


        public float TotaleDonazione(Progetti progetto)
        {
            float somma = 0;
            foreach (var d in progetto.Donazioni)
            {
                somma += d.Importo;
            }
            return somma;
        }


        public List<Progetti> FinanziamentoRichiesto()
        {
            List<Progetti> progettiTot = new List<Progetti>();
            foreach (var o in Onlus)
            {
                foreach (var p in o.Progetto)
                    if (TotaleDonazione(p) >= p.ImportoRichiesto)
                        progettiTot.Add(p);
            }
            return progettiTot;
        }

        public float DonazioneMediaProgetto(Progetti progetto)
        {
            float somma = TotaleDonazione(progetto);
            int countDonazioni = progetto.Donazioni.Count;
            return somma / countDonazioni;
        }


        public float FinanziamentiTotaliOnlus(Onlus onlus)
        {
            float count = 0;
            foreach (var o in onlus.Progetto)
                count += TotaleDonazione(o);
            return count;
        }

        public Progetti NumeroDOnazionePiuAlta()
        {
            Progetti progettoMax = new();
            int maxDonazioni = -1;
            foreach (var o in Onlus)
            {
                foreach (var p in o.Progetto)
                {
                    int count = p.Donazioni.Count;
                    if (count > maxDonazioni)
                    {
                        maxDonazioni = count;
                        progettoMax = p;
                    }
                }
            }
            return progettoMax;
        }
    }
}

