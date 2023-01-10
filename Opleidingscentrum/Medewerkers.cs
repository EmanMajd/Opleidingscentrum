using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleidingscentrum
{
    public class Medewerkers : Personeelsleden
    {
        private int cursisten;
        public Medewerkers(string personeelnummer, string voornaam, string familienaam, double brutomaandloon,int cursisten)
            : base(personeelnummer, voornaam, familienaam, brutomaandloon)
        {
            this.Cursisten = cursisten;
        }

        public int Cursisten { get => cursisten; set => cursisten = value; }

        public override void GegevensTonen()
        {
            Console.WriteLine($"PersoneelsNummer : {Personeelsnummer}");
            Console.WriteLine($"Naam  : {Voornaam} {Familienaam}");
            Console.WriteLine($"BrutomaandLoon : {Brutomaandloon}");
            Console.WriteLine($"Medewerker  :  {cursisten} cusisten");
            Console.WriteLine($"Maandalijk Kost : {base.maandKost}");

        }
    }
}
