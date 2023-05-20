using Entiteti;
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
        private const char SEPARATOR = '|';
        List<Osoba> predavaci = new();
        private string predavac;

        public UrediPredavacaGlavnaForma(string odabraniPredavac)
        {
            predavac = odabraniPredavac;

            InitializeComponent();
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            
            LoadData();
            InsertNew();

            Administrator_Pocetna administrator_Pocetna = new Administrator_Pocetna();
            administrator_Pocetna.Show();
            administrator_Pocetna.BringToFront();
            this.Close();
        }

        private void InsertNew()
        {
            if (!formValid())
            {
                return;
            }
            if (!predavacPostoji())
            {
                return;
            }

            Osoba osoba = new()
            {
                Ime = tbIme.Text,
                Prezime = tbPrezime.Text,
                Email = tbEmail.Text,
                Lozinka = tbLozinka.Text,
            };
            predavaci.Add(osoba);
            try
            {
                File.WriteAllLines(PATH, predavaci.Select(k => k.FormatForFileLine()));
                DeleteSelected();
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message);
            }

        }

        private void LoadData()
        {
            Osoba osoba1 = new Osoba();
            string[] file = File.ReadAllLines(PATH);
            try
            {
                foreach (string line in file)
                {
                    osoba1 = Osoba.ParseFromFileLine(line);
                    predavaci.Add(osoba1);
                }
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message);
            }
        }

        private void DeleteSelected()
        {
            List<string> linije = File.ReadAllLines(PATH).ToList();

            StringBuilder noviKontent = new StringBuilder();
            foreach (string line in linije)
            {
                string[] dijelovi = line.Split(SEPARATOR);
                string[] imeiprezime = predavac.Split(' ');
                if (!(dijelovi[0] == imeiprezime[0] && dijelovi[1] == imeiprezime[1]))
                {
                    noviKontent.AppendLine(line);
                }
            }

            try
            {
                File.WriteAllText(PATH, noviKontent.ToString());
                DialogResult result = MessageBox.Show("Predavač uspješno promijenjen!", "Confirmation",
                    MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            UrediPredavaca urediPredavaca = new UrediPredavaca();
            urediPredavaca.Show();
            urediPredavaca.BringToFront();
            this.Hide();
        }


        private bool predavacPostoji()
        {
            List<Osoba> osobe = new List<Osoba>();
            string[] detalji;
            try
            {
                detalji = File.ReadAllLines(PATH);
                foreach (var item in detalji)
                {
                    osobe.Add(Osoba.ParseFromFileLine(item));
                }
                foreach (var item in osobe)
                {
                    if (item.Ime == tbIme.Text && item.Prezime == tbPrezime.Text)
                    {
                        MessageBox.Show("Predavač već postoji, nemoguć unos!");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.Message);
                return false;
            }
        }
        private bool formValid()
        {
            if (String.IsNullOrEmpty(tbIme.Text)
                || String.IsNullOrEmpty(tbPrezime.Text)
                || String.IsNullOrEmpty(tbEmail.Text)
                || String.IsNullOrEmpty(tbLozinka.Text)
                || String.IsNullOrEmpty(tbPotvrdiLozinku.Text)
                )
            {
                MessageBox.Show("Molimo unesite sve potrebne informacije");
                return false;
            }

            if (tbLozinka.Text != tbPotvrdiLozinku.Text)
            {
                MessageBox.Show("Greška prilikom promjene lozinke");
                return false;
            }

            return true;
        }





    }
}