namespace Opleidingscentrum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(String x in Personeelsleden.verplichteVerlofperiodes)
            {

                Console.WriteLine("Verlofperiode  " + x);

            }

            Console.WriteLine();
            Ikost[] objecten = new Ikost[5];
            
            objecten[0] = new Instructeurs("1","Chris","Van Loon",2500.99,"lkdgdkl2@", Vakgebieden.Ontwikkeling);
            objecten[1] = new Medewerkers("2", "Eman", "Kalloub", 1500.15, 10);
            objecten[2] = new Medewerkers("3", "Majd", "Alqutati", 2000.20, 15);
            objecten[3] = new Infrastructuur("Gebouw 1 ", 1500);
            objecten[4] = new Infrastructuur("Gebouw 2 ", 1700);

            double totaalMaandKost = 0;
            foreach (Ikost ikost in objecten)
            {
                ikost.GegevensTonen();
                Console.WriteLine();

                totaalMaandKost += ikost.maandKost;
            }

            Console.WriteLine($"Totaal Mandelijkse Kosten : {totaalMaandKost}");
            
        }
    }
}