using System;
using System.Windows.Forms;

namespace Overerving
{
    public class Rekening
    {
        private decimal _minimum;
        private string _rekeningNr;
        private decimal _saldo;

        public decimal Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        public string RekeningNr
        {
            get { return _rekeningNr; }
            set { _rekeningNr = value; }
        }

        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < Minimum)
                {
                    MessageBox.Show($"Saldo kan niet onder {Minimum} gaan");
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public Rekening(string rekeningNr = "Be 0 0000 0000 0000", decimal saldo = 0, decimal minimum = 0)
        {
            RekeningNr = rekeningNr;
            Saldo = saldo;
            Minimum = minimum;
        }

        public void Storten(string bedrag)
        {
            Saldo += ConvertToDecimal(bedrag);
        }

        public void Afhalen(string bedrag)
        {
            Saldo -= ConvertToDecimal(bedrag);
        }

        public override string ToString()
        {
            return $"Rekeningnummer {RekeningNr} met saldo {Saldo}";
        }

        private decimal ConvertToDecimal(string bedrag)
        {
            try
            {
                decimal dec = Convert.ToDecimal(bedrag);
                return dec;
            }
            catch (Exception)
            {
                MessageBox.Show("invoer moet een nr zijn");
                return 0;
            }
        }
    }
}