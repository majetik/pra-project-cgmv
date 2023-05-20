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
    public partial class DodajKolegij : Form
    {
        private const string PATH = "ListaKolegija.txt";
        private const char DEL = '|';
        List<Kolegij> kolegiji = new();
        public DodajKolegij()
        {
            InitializeComponent();
            LoadData();
        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {
            Administrator_Pocetna adminPocetna = new();
            adminPocetna.Show();
            adminPocetna.BringToFront();
            this.Close();
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

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (!formValid())
            {
                return;
            }
            if (!collegeexists())
            {
                return;
            }

            Kolegij kolegij = new()
            {
                Naziv = TBImeKolegija.Text,
                Sifra = TBSifraKolegija.Text
            };

            kolegiji.Add(kolegij);

            try
            {
                File.WriteAllLines(PATH, kolegiji.Select(k => k.FormatForFileLine()));
                //this.Refresh();
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message);
            }
        }
        private bool collegeexists()
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
                    if (item.Naziv == TBImeKolegija.Text)
                    {
                        MessageBox.Show("Kolegij već postoji, nemoguć unos!");
                        return false;
                    }
                }
                MessageBox.Show("Kolegij uspješno dodan!");
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
            if (String.IsNullOrEmpty(TBImeKolegija.Text)
                || String.IsNullOrEmpty(TBSifraKolegija.Text))
            {
                MessageBox.Show("Molimo unesite sve potrebne informacije");
                return false;
            }
            return true;
        }


    }
}
