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
    public partial class UrediPredavacaGlavnaForma : Form
    {
        private const string PATH = "ListaPredavaca.txt";
        private string predavac;

        public UrediPredavacaGlavnaForma(string odabraniPredavac)
        {
            predavac = odabraniPredavac;

            InitializeComponent();
        }

        private void UrediPredavacaGlavnaForma_Load(object sender, EventArgs e)
        {
            string[] predavacImePrezime = predavac.Split(' ');
            string predavacIme = predavacImePrezime[0];

            using (StreamReader sr = new StreamReader(PATH))
            {
                while (!sr.EndOfStream)
                {
                    string linija = sr.ReadLine();
                    string[] detalji = linija.Split('|');

                    if (detalji[0] == predavacIme)
                    {
                        tbIme.Text = detalji[0];
                        tbPrezime.Text = detalji[1];
                        tbEmail.Text = detalji[2];
                        tbLozinka.Text = detalji[3];
                        tbPotvrdiLozinku.Text = detalji[3];

                        break;
                    }
                }
            }
        }

        // kad kliknemo "button" spremamo vrijednosti iz text-fieldova u varijable koje zatim saljmo u funkciju AzurirajPredavaca
        // Ako su zadovoljni uvjeti u funkciji AzurirajPredavaca onda se on sprema u .txt file i preusmjerava se u Admin pocetna
        private void btnNastavi_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text;
            string prezime = tbPrezime.Text;
            string email = tbEmail.Text;
            string lozinka = tbLozinka.Text;
            bool JeAdmin = false;

            try
            {
                AzurirajPredavaca(ime, prezime, email, lozinka, JeAdmin);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Administrator_Pocetna adminPocetna = new();
            adminPocetna.Show();
            adminPocetna.BringToFront();
        }


        //Metoda ne radi ispravno!! Problem kod spremanja u fajl
        // prvo projveravamo da li su sva polja popunjena, ako nisu pojavljuje se MessageBox. 
        private void AzurirajPredavaca(string ime, string prezime, string email, string lozinka, bool JeAdmin)
        {
            if (String.IsNullOrEmpty(tbIme.Text) ||
                String.IsNullOrEmpty(tbPrezime.Text) ||
                String.IsNullOrEmpty(tbEmail.Text) ||
                String.IsNullOrEmpty(tbLozinka.Text) ||
                String.IsNullOrEmpty(tbPotvrdiLozinku.Text))
            {

                MessageBox.Show("Molimo unesite sve potrebne informacije");
            }
            else if (tbLozinka.Text != tbPotvrdiLozinku.Text)
            {
                MessageBox.Show("Greška prilikom kreiranja lozinke");
            }
            else
            {
                //U ovom segmentu koda nesto ne stima
                //pretpostavka: if detalji0[] == ime, detalji[0] = ime,
                //dvaput isto ime? sta ako je korisnik izmjenio ime? onda nece nis spremiti
                string[] linije = File.ReadAllLines(PATH);

                StringBuilder sb = new StringBuilder();
                foreach (string line in linije)
                {
                    string[] detalji = line.Split('|');
                    if (detalji[0] == ime)
                    {
                        detalji[0] = ime;
                        detalji[1] = prezime;
                        detalji[2] = email;
                        detalji[3] = lozinka;
                        detalji[4] = JeAdmin.ToString();

                        sb.AppendLine(string.Join("|", detalji));
                    }
                    else
                    {
                        sb.AppendLine(line);
                    }
                }

                File.WriteAllText(PATH, sb.ToString());
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            UrediPredavaca urediPredavaca = new UrediPredavaca();
            urediPredavaca.Show();
            urediPredavaca.BringToFront();

            this.Hide();
        }
    }
}