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
    public partial class Predavac_Pocetna : Form
    {
        public Predavac_Pocetna()
        {
            InitializeComponent();
        }

        private void Predavac_Pocetna_Load(object sender, EventArgs e)
        {
            // micanje border linije oko button-a
            btnOdjava.FlatStyle = FlatStyle.Flat;
            btnOdjava.FlatAppearance.BorderSize = 0;

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

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Form1 pocetnaStranica = new();
            pocetnaStranica.Show();
            pocetnaStranica.BringToFront();
            this.Close();
        }

        private void btnPopisSvihObavijesti_Click(object sender, EventArgs e)
        {
            PregledSvihObavijesti obavijestiobavijesti = new();
            obavijestiobavijesti.Show();
            obavijestiobavijesti.BringToFront();
            this.Close();
        }

        private void btnObrisiObavijesti_Click(object sender, EventArgs e)
        {
            ObrisiObavijest obrisiObavijest = new();
            obrisiObavijest.Show();
            obrisiObavijest.BringToFront();
            this.Close();
        }

        private void btnDodajObavijesti_Click(object sender, EventArgs e)
        {
            DodajObavijest dodajObavijest = new DodajObavijest();
            dodajObavijest.Show();
            dodajObavijest.BringToFront();
            this.Close();
        }

        private void btnUrediObavijesti_Click(object sender, EventArgs e)
        {
            UrediObavijest urediObavijest = new UrediObavijest();
            urediObavijest.Show();
            urediObavijest.BringToFront();
            this.Close();
        }
    }
}
