using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Library
{
    public class CasaEditrice
    {
        public List<Rivista> Riviste { get; set; } = new List<Rivista>();
        public List<Abbonato> Abbonati { get; set; } = new List<Abbonato>();
        public List<Istituto> Istitutti { get; set; } = new List<Istituto>();

        public List<Abbonamento> ScadenzaAbbonamentiInMeseAnno(int mese, int anno)
        {
            List<Abbonamento> abbonamentiInScadenza = new List<Abbonamento>();

            foreach (var a in Abbonati)
            {
                if (a.Abbonamenti != null)
                {
                    foreach (var abb in a.Abbonamenti)
                    {
                        if (abb.DataFine.Year == anno && abb.DataFine.Month == mese)
                        {
                            abbonamentiInScadenza.Add(abb);
                        }
                    }
                }
            }

            return abbonamentiInScadenza;
        }

        public bool abbonamentoRinnovato(Abbonamento abbonamentoV)
        {
            if (abbonamentoV == null) return false;

            foreach (var abbonato in Abbonati)
            {
                if (abbonato.Abbonamenti != null && abbonato.Abbonamenti.Contains(abbonamentoV))
                {
                    foreach (var abb in abbonato.Abbonamenti)
                    {
                        if (abb.Rivista == abbonamentoV.Rivista && abb.DataInizio > abbonamentoV.DataFine)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public List<Abbonamento> GetScadutiNonRinnovati(int mese, int anno)
        {
            List<Abbonamento> abbonamentiFinali = new List<Abbonamento>();
            List<Abbonamento> abbonamentoInScadenza = ScadenzaAbbonamentiInMeseAnno(mese, anno);
            foreach (var a in abbonamentoInScadenza)
            {
                if (!abbonamentoRinnovato(a))
                {
                    abbonamentiFinali.Add(a);
                }
            }
            return abbonamentiFinali;
        }

        public float importoTotaleOrdinato(Istituto istituto, int anno)
        {
            float tot = 0f;
            foreach (var a in istituto.Ordini)
            {
                if (a.DataOrdine.Year == anno)
                {
                    if (a.Rivista != null)
                    {
                        float costoOrdine = a.Quantita * a.Rivista.PrezzoUnitario;

                        tot += costoOrdine;
                    }
                }
            }
            return tot;
        }

        public Rivista rivistaPiuCostosa()
        {
            float prezzomin = -1;
            Rivista rivistaCostosa = new Rivista();
            foreach (var r in Riviste)
            {
                if (prezzomin < r.PrezzoUnitario)
                {
                    prezzomin = r.PrezzoUnitario;
                    rivistaCostosa.PrezzoUnitario = prezzomin;
                }
            }
            return rivistaCostosa;
        }

        public List<Rivista> rivistePerAnnoEAmbito(int anno, string argomento)
        {
            List<Rivista> rivistefinali = new List<Rivista>();
            foreach(var r in Riviste)
            {
                if(r.AmbitoDisciplinare == argomento && anno == r.AnnoPubblicazione)
                {
                    rivistefinali.Add(r);
                }
            }
            return rivistefinali;
        }
    }
}