using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleidingscentrum
{
    public class Infrastructuur : Ikost
    {
        private string naam;
        private double huurprijsPerMaand;
        public Infrastructuur(string naam,int huurprijsPerMaand)
        { 
            this.naam = naam;   
            this.huurprijsPerMaand = huurprijsPerMaand;
        }

        public string Naam { get => naam; set => naam = value; }
        public double Verhuurprijs { get => huurprijsPerMaand; set => huurprijsPerMaand = value; }

        double Ikost.maandKost => huurprijsPerMaand;

         public void GegevensTonen()
        {
            Console.WriteLine($"Infastructuur Naam : {naam}");
            Console.WriteLine($"Maandelijkse kost: {huurprijsPerMaand}");
        }
    }
}
