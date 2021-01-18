using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overerving
{
    public partial class Form1 : Form
    {
        private Rekening rekening;
        private Spaarrekening spaarRekening;
        private Zichtrekening zichtrekening;

        public Form1()
        {
            InitializeComponent();
            rekening = new Rekening("BE 0645 0454 4545 5");
            spaarRekening = new Spaarrekening(5);
            zichtrekening = new Zichtrekening("BE 0645 0454 4995 5", 0, -100);
            lblPrintRekening.Text = rekening.ToString();
            lblPrintSpaarrekening.Text = spaarRekening.ToString();
            lblPrintZR.Text = zichtrekening.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            rekening.Storten(txtRekening.Text);

            lblPrintRekening.Text = rekening.ToString();
            txtRekening.Text = "";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            rekening.Afhalen(txtRekening.Text);

            lblPrintRekening.Text = rekening.ToString();
            txtRekening.Text = "";
        }

        private void btnPlusSR_Click(object sender, EventArgs e)
        {
            spaarRekening.Storten(txtSpaarrekening.Text);
            lblPrintSpaarrekening.Text = spaarRekening.ToString();
            txtSpaarrekening.Text = "";
        }

        private void btnMinSR_Click(object sender, EventArgs e)
        {
            spaarRekening.Afhalen(txtSpaarrekening.Text);
            lblPrintSpaarrekening.Text = spaarRekening.ToString();
            txtSpaarrekening.Text = "";
        }

        private void btnRente_Click(object sender, EventArgs e)
        {
            lblPrintSpaarrekening.Text = spaarRekening.SchrijfRenteBij();
        }

        private void btnPlusZR_Click(object sender, EventArgs e)
        {
            zichtrekening.Storten(txtZichtrekening.Text);
            lblPrintZR.Text = zichtrekening.ToString();
            txtZichtrekening.Text = "";
        }

        private void btnMinZR_Click(object sender, EventArgs e)
        {
            zichtrekening.Afhalen(txtZichtrekening.Text);
            lblPrintZR.Text = zichtrekening.ToString();
            txtZichtrekening.Text = "";
        }
    }
}