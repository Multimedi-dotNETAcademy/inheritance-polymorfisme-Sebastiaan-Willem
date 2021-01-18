using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenOvererving18._2_Dieren
{
    class Mens : Dier
    {
        public Mens(string naam) : base (naam)
        {

        }

        public override string Eten()
        {
            return "Lekker!";
        }

        public override string Praten(string zin)
        {

            switch (zin)
            {
                case "Goeiemorgen": return "Ook een goeiemorgen!";
                case "Goeienavond": return "Ook een goeienavond!";
                case "Wat wil je eten?": return "Geen idee, kies maar.";
                case "Ik ben moe.": return "Tijd om te slapen.";
                case "Het is hier nogal stil.": return "Ik zal wat muziek afspelen.";
                case "Tot de volgende!": return "Adieu!";
                default:
                    break;
            }
            return base.Praten(zin);
        }

        public override string Strelen()
        {
            return "Blijf van mijn lijf. Arrh.";
        }
    }
}
