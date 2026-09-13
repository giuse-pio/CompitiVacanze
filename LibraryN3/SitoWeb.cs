using System.Runtime;

namespace LibraryN3
{
    public class SitoWeb
    {
        public List<Film> Films { get; set; } = new List<Film>();
        public List<Iscritto> Iscritti { get; set; } = new List<Iscritto>();


        public float PunteggioMedioFilm(Film film)
        {
            float somma = 0;
            float media = 0;
            foreach (var f in Films)
            {
                if (film.Titolo == f.Titolo)
                {
                    int i = 0;
                    foreach (var r in f.Recenzioni)
                    {
                        somma += r.Voto;
                        i++;

                    }

                    media = somma / i;
                }
            }

            return media;
        }

        public List<Film> AttoreCheHaPartecipatoNeiFilm(Artista artista)
        {
            List<Film> films = new List<Film>();
            foreach (var f in Films)
            {
                foreach (var a in f.Artisti)
                {
                    if (a.Cognome == artista.Cognome && a.Nome == artista.Nome)
                    {
                        films.Add(f);
                    }
                }
            }
            return films;
        }

        public Film FilmPunteggioMedioPiuAlto()
        {
            Film film = null;
            float punteggiopiualto = 0;
            foreach(var f in Films)
            {
                float punteggiomedio = PunteggioMedioFilm(f);
                if (punteggiomedio > punteggiopiualto)
                {
                    punteggiopiualto=punteggiomedio;
                    film = f;
                }
            }
            return film;
        }
    }
}
