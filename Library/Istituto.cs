namespace Library
{
    public class Istituto
    {
        public string Denominazione { get; set; }
        public string Nazione { get; set; }
        public string Recapito { get; set; }
        public List<Ordine> Ordini { get; set; } = new List<Ordine>();
    }
}