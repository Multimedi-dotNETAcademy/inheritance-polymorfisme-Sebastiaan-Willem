using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overerving
{
    internal class Zichtrekening : Rekening
    {
        private decimal _minimum;

        public decimal Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        public Zichtrekening(string rekeningNr, decimal saldo, decimal minimum)
            : base(rekeningNr, saldo, minimum)
        {
        }
    }
}