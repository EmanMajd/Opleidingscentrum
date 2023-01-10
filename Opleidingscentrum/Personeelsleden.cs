using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleidingscentrum
{
    public abstract class Personeelsleden : Ikost
    {
        private string personeelsnummer;
        private string voornaam;
        private string familienaam;
        private double brutomaandloon;
        public static string[] verplichteVerlofperiodes = {
            "Kerstmis : 25/12/2020 - 1/01/2021" ,
            "ZomerVakantie : 1/07/2020 - 31/07/2020"
        };

        public Personeelsleden(string personeelnummer, string voornaam, string familienaam, double brutomaandloon) {
            this.personeelsnummer = personeelnummer;
            this.voornaam = voornaam;
            this.familienaam = familienaam;
            this.brutomaandloon = brutomaandloon;


        }



        public string Familienaam { get => familienaam; set => familienaam = value; }
        public string Voornaam { get => voornaam; set => voornaam = value; }
        public double Brutomaandloon { get => brutomaandloon; set => brutomaandloon = value; }
        public string Personeelsnummer { get => personeelsnummer;  }

        public double maandKost {

            get{

                return (brutomaandloon * 60) / 100;
            }
        }

        public abstract void GegevensTonen();
    }
}
