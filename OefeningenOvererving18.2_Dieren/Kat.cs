using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenOvererving18._2_Dieren
{
    class Kat : Dier
    {
        int teller;
        public Kat(string naam) : base (naam)
        {

        }

        public override string Praten(string zin)
        {
            teller++;
            if(teller % 3 == 0)
            {
                return "Miaauw";
            }
            return base.Praten(zin);
        }

        public override string Strelen()
        {
            return "Prrrrrr";
        }        
    }
}
