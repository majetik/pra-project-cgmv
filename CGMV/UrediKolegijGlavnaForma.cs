using Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGMV
{
    public partial class UrediKolegijGlavnaForma : Form
    {
        private const string PATH = "ListaKolegija.txt";
        private const char SEPARATOR = '|';
        List<Kolegij> kolegiji = new();
        private string kolegij;
        public UrediKolegijGlavnaForma(string odabranikolegij)
        {
            InitializeComponent();
            kolegij = odabranikolegij;
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            LoadData();
            InsertNew();
        }

        private void InsertNew()
        {
            if (!formValid())
            {
                return;
            }
            if (!kolegijPostoji())
            {
                return;
            }

            Kolegij kolegij = new()
            {
                Naziv = tbNazivKolegija.Text,
                Sifra = tbSifraKolegija.Text
            };
            kolegiji.Add(kolegij);
            try
            {
                File.WriteAllLines(PATH, kolegiji.Select(k => k.FormatForFileLine()));
                DeleteSelected();
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void LoadData()
        {
            Kolegij kolegij1 = new Kolegij();
            string[] file = File.ReadAllLines(PATH);
            try
            {
                foreach (string line in file)
                {
                    kolegij1 = Kolegij.ParseFromFileLine(line);
                    kolegiji.Add(kolegij1);
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
                if (!(dijelovi[0] == kolegij))
                {
                    noviKontent.AppendLine(line);
                }
            }
            try
            {
                File.WriteAllText("ListaKolegija.txt", noviKontent.ToString());
                DialogResult result = MessageBox.Show("Kolegij uspješno promijenjen!", "Confirmation",
                    MessageBoxButtons.OK);
                Administrator_Pocetna administrator_Pocetna = new Administrator_Pocetna();
                administrator_Pocetna.Show();
                administrator_Pocetna.BringToFront();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool kolegijPostoji()
        {
            List<Kolegij> kolegiji = new List<Kolegij>();
            string[] detalji;
            try
            {
                detalji = File.ReadAllLines(PATH);
                foreach (var item in detalji)
                {
                    kolegiji.Add(Kolegij.ParseFromFileLine(item));
                }
                foreach (var item in kolegiji)
                {
                    if (item.Naziv == tbNazivKolegija.Text)
                    {
                        MessageBox.Show("Kolegij već postoji, nemoguć unos!");
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
            if (String.IsNullOrEmpty(tbNazivKolegija.Text)
                || String.IsNullOrEmpty(tbSifraKolegija.Text))
            {
                MessageBox.Show("Molimo unesite sve potrebne informacije");
                return false;
            }
            return true;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            UrediKolegij urediKolegij = new UrediKolegij();
            urediKolegij.Show();
            urediKolegij.BringToFront();
            this.Close();
        }
    }
}
