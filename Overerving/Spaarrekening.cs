using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    public class Spaarrekening : Rekening
    {
        private int _percentage;

        public int Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public Spaarrekening(int rente)
            : base("Be 05 1565 4545 4565 2", 0)
        {
            Percentage = rente;
        }

        public string SchrijfRenteBij()
        {
            Saldo = Saldo / 100 * (100 + Percentage);
            return $"Rekeningnummer {RekeningNr} met saldo {Saldo} (percentage {Percentage})";
        }
    }
}