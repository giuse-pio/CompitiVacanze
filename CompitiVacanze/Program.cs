using LibraryN3;
using LibraryN4._2;
using LibraryN4_4;
using Library5_2;
namespace CompitiVacanze

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///* ESERCIZIO 3 */
            Console.WriteLine("inserisci il nome dell'artista");
            string nome = Console.ReadLine();
            Console.WriteLine("inserisci il cognome dell'artista");
            string cognome = Console.ReadLine();
            Artista a = new Artista()
            {
                Nome = nome,
                Cognome = cognome
            };
            Console.WriteLine("Artista creato");
            Console.WriteLine($"Nome: {a.Nome}");
            Console.WriteLine($"Cognome: {a.Cognome}");



            ///* ESERCIZIO 4.2 */
            Console.WriteLine("inserisci i valori dei quadrati, seguiti da Q#:");
            string inputq1 = Console.ReadLine();
            Quadrato q1 = Quadrato.Parse(inputq1);

            string inputq2 = Console.ReadLine();
            Quadrato q2 = Quadrato.Parse(inputq2);

            Quadrato somma = q1 + q2;
            Quadrato differenza = q1 - q2;

            Console.WriteLine($"Primo quadrato: {q1}");
            Console.WriteLine($"Secondo quadrato: {q2}");
            Console.WriteLine($"Somma: {somma}");
            Console.WriteLine($"Differenza: {differenza}");
            Console.WriteLine($"Uguaglianza: {q1 == q2}");

            /* ESERCIZIO 4.4 */
            Console.WriteLine("inserisci i valori dei Cerchi, seguiti da C^:");
            string inputc1 = Console.ReadLine();
            Cerchio c1 = Cerchio.Parse(inputc1);

            string inputc2 = Console.ReadLine();
            Cerchio c2 = Cerchio.Parse(inputc2);

            Cerchio sommaC = c1 + c2;
            Cerchio differenzaC = c1 - c2;

            Console.WriteLine($"Primo cerchio: {c1}");
            Console.WriteLine($"Secondo cerchio: {c2}");
            Console.WriteLine($"Somma: {sommaC}");
            Console.WriteLine($"Differenza: {differenzaC}");
            Console.WriteLine($"Uguaglianza: {c1 == c2}");



            /* ESERCIZIO 5.2 */
            Console.Write("Inserisci il primo triangolo (es. Tv5): ");
            string input1 = Console.ReadLine();
            Console.Write("Inserisci il secondo triangolo (es. Tv3): ");
            string input2 = Console.ReadLine();
            bool t1Valido = Triangolo.TryParse(input1, out Triangolo t1);
            bool t2Valido = Triangolo.TryParse(input2, out Triangolo t2);

            if (t1Valido && t2Valido)
            {
                Triangolo sommaTriangolo = t1 + t2;
                Console.WriteLine($"Primo triangolo: {t1}");
                Console.WriteLine($"Secondo triangolo: {t2}");
                Console.WriteLine($"Somma aree: {sommaTriangolo}");
                Console.WriteLine($"t1>t2? {t1 > t2}");
                Console.WriteLine($"Uguaglianza {t1 == t2}");
            }
            else
            {
                Console.WriteLine("\nErrore: Uno o entrambi i valori inseriti non sono rappresentazioni valide di un triangolo (devono iniziare con 'Tv').");
            }
        }

    }
}

