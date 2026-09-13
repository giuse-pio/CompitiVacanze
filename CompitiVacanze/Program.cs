using LibraryN3;
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

        }

    }
}

