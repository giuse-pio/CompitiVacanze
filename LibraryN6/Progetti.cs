using System.Data;

namespace LibraryN6
{
    public class Progetti
    {
        public string Finalita { get; set; }
        public string Beneficiari { get; set; }
        public string Ricompensa { get; set; }
        public float ImportoRichiesto { get; set; }
        public DateTime TempoLimite { get; set; }
        public List<Donazioni> Donazioni { get; set; } = new List<Donazioni>();


        
    }
}