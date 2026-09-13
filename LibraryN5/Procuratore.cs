namespace LibraryN5
{
    public class Procuratore
    {
        public List<Squadra> Squadre { get; set; }

        public float ValoreMegioGiocatoriRuolo(Ruolo ruolo)
        {
            float somma = 0;
            int numeroGiocatori = 0;
            foreach(var s in Squadre)
            {
                foreach(var g in s.Giocatori)
                {
                    if(g.Ruolo== ruolo)
                    {
                        numeroGiocatori++;
                        somma += g.Valore;
                    }
                }
            }
            return somma / numeroGiocatori;
        }

        public List<Giocatore> GiocatoriConStessoRuoloInferioreValoreMedio(Ruolo ruolo)
        {
            List<Giocatore> GiocatoriConValoreMedioInferiore = new List<Giocatore>();
            float valoreMedio = ValoreMegioGiocatoriRuolo(ruolo);
            foreach (var s in Squadre)
            {
                foreach (var g in s.Giocatori)
                {
                    if (g.Ruolo == ruolo && g.Valore < valoreMedio)
                    {
                        GiocatoriConValoreMedioInferiore.Add(g);
                    }
                }
            }
            return GiocatoriConValoreMedioInferiore;
        }
    }

}