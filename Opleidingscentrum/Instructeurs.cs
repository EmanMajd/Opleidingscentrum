using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Opleidingscentrum
{
    public class Instructeurs : Personeelsleden,Ikost
    {
        private string emailAddress;
        Vakgebieden vakgebieden;

        public Instructeurs(string personeelnummer, string voornaam, string familienaam, double brutomaandloon , string email ,Vakgebieden vakgebieden) 
            : base(personeelnummer, voornaam, familienaam, brutomaandloon)
        {
            this.EmailAddress = email;
            this.vakgebieden = vakgebieden;
        }

        public string EmailAddress
        {
            get => emailAddress;
            set => emailAddress = value.Contains('@') ? value : "Onbekend email adres";
          
        }

        public override void GegevensTonen()
        {
            Console.WriteLine($"PersoneelsNummer : {Personeelsnummer}");
            Console.WriteLine($"Instructuur: {Voornaam} {Familienaam}");
            Console.WriteLine($"BrutomaandLoon : {Brutomaandloon}");
            Console.WriteLine($"Email  :  {emailAddress}");
            Console.WriteLine($"Maandalijk Kost : {base.maandKost}");
        }
    }
}
