using System.Reflection.Metadata.Ecma335;

namespace LibraryN2
{
    public class WebCommunity
    {
        public List<Evento> Eventi { get; set; }
        public List<Membro> Membri { get; set; }

        public List<Evento> EventiInData(DateTime data)
        {
            List<Evento> EventiFinali = new List<Evento>();
            foreach (var ev in Eventi)
            {
                if (ev.Data == data)
                {
                    EventiFinali.Add(ev);
                }
            }
            return EventiFinali;
        }

        public List<Membro> MembriNoCommento()
        {
            List<Membro> MemrbriZeroCommenti = new List<Membro>();
            foreach (var m in Membri)
            {
                if (m.Commenti.Count == 0)
                {
                    MemrbriZeroCommenti.Add(m);
                }

            }
            return MemrbriZeroCommenti;
        }


        public Evento EventoVotoMedioPiuAlto()
        {
            Evento eventoPiuAlto = null;
            float votoPiuAlto = 0;
            foreach (var e in Eventi)
            {
                float votoMedio = e.VotoMedioPerQuestoEvento();
                if (votoMedio > votoPiuAlto)
                {
                    votoPiuAlto = votoMedio;
                    eventoPiuAlto = e;
                }
            }
            return eventoPiuAlto;
        }
    }
}
