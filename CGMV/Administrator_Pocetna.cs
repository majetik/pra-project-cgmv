using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGMV
{
    public partial class Administrator_Pocetna : Form
    {
        public Administrator_Pocetna()
        {
            InitializeComponent();
        }

        private void Administrator_Pocetna_Load(object sender, EventArgs e)
        {
            // micanje border linije oko button-a
            btnOdjava.FlatStyle = FlatStyle.Flat;
            btnOdjava.FlatAppearance.BorderSize = 0;

            // micanje border linije oko textfield-a
            tbDobrodosli.BorderStyle = BorderStyle.None;

            foreach (Control control in pnlLinkovi.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.Black;
                    button.ForeColor = Color.White;
                }
            }

        }

        private void BtnOdjava_Click(object sender, EventArgs e)
        {
            Form1 pocetnaStranica = new();
            pocetnaStranica.Show();
            pocetnaStranica.BringToFront();

            this.Close();
        }

        private void BtnDodajPredavaca_Click(object sender, EventArgs e)
        {
            DodajPredavaca dodajPredavaca = new();
            dodajPredavaca.Show();
            dodajPredavaca.BringToFront();

            this.Close();
        }

        private void BtnObrisiPredavaca_Click(object sender, EventArgs e)
        {
            ObrisiPredavaca obrisiPredavaca = new();
            obrisiPredavaca.Show();
            obrisiPredavaca.BringToFront();

            this.Close();
        }

        private void btnUrediPredavaca_Click(object sender, EventArgs e)
        {
            UrediPredavaca urediPredavaca = new();
            urediPredavaca.Show();
            urediPredavaca.BringToFront();

            this.Close();
        }

        private void btnDodajKolegij_Click(object sender, EventArgs e)
        {
            DodajKolegij dodajKolegij = new();
            dodajKolegij.Show();
            dodajKolegij.BringToFront();

            this.Close();
        }

        private void btnObrisiKolegij_Click(object sender, EventArgs e)
        {
            ObrisiKolegij obrisiKolegij = new();
            obrisiKolegij.Show();
            obrisiKolegij.BringToFront();

            this.Close();
        }

    }
}
