using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenOvererving18._2_Dieren
{
    class Papegaai : Dier
    {
        readonly Random random = new Random();
        public Papegaai(string naam) : base(naam)
        {

        }

        public override string Praten(string zin)
        {
            if(random.Next(1,5) == 1)
            {
                return "Koko kopke krabben";
            }
            else
            {
                return zin;
            }            
        }

        public override string Strelen()
        {
            return "Koko";
        }
    }
}
