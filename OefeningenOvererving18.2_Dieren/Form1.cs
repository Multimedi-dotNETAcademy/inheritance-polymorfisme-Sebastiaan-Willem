using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningenOvererving18._2_Dieren
{
    public partial class Form1 : Form
    {
        Dier huidigDier;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            huidigDier = BepaalDier();

            lblHuidigDier.Text = huidigDier.GetType().Name + " " + huidigDier.Naam;
            lblHuidigDier.Visible = true;

            btnEten.Enabled = true;
            btnPraten.Enabled = true;
            btnStrelen.Enabled = true;
        }



        private Dier BepaalDier()
        {
            string naam = txtNaam.Text;

            if (rbtnKat.Checked)
            {
                var dier = new Kat(naam);
                return dier;
            }
            else if(rbtnPapegaai.Checked)
            {
                var dier = new Papegaai(naam);
                return dier;
            }
            else if(rbtnMens.Checked)
            {
                var dier = new Mens(naam);
                return dier;
            }
            else
                return null;
        }

        private void btnStrelen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(huidigDier.Strelen(), "Strelen");
        }

        private void btnEten_Click(object sender, EventArgs e)
        {
            MessageBox.Show(huidigDier.Eten(), "Eten");
        }

        private void btnPraten_Click(object sender, EventArgs e)
        {
            if(listBoxPraten.SelectedItem == null)
            {
                MessageBox.Show("Geen zin geselecteerd!", "INFO", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(huidigDier.Praten(listBoxPraten.SelectedItem.ToString()), "Praten");
        }
    }
}
