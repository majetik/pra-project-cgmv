using Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGMV
{
    public partial class UrediObavijestGlavnaForma : Form
    {
        private const string PATH = "ListaObavijesti.txt";
        private const string PATH2 = "ListaKolegija.txt";
        private const string PATH3 = "ListaPredavaca.txt";
        private const string PATH4 = "UlogiraniUser.txt";
        private const char SEPARATOR = '|';
        List<Obavijest> obavijesti = new();


        private string obavijest;
        public UrediObavijestGlavnaForma(string odabranaObavijest)
        {
            InitializeComponent();
            obavijest= odabranaObavijest;
        }
        private void BtnKreirajObavijest_Click(object sender, EventArgs e)
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
            if (!obavijestPostoji())
            {
                return;
            }

            Obavijest obavijest = new()
            {
                Naslov = TBNaslov.Text,
                Opis = TBOpis.Text,
                Autor = (Osoba)CBKreiraoObavijest.SelectedItem,
                DatumObjave = DateTime.Now,
                DatumIsteka = dtpIstekObavijesti.Value
            };
            obavijesti.Add(obavijest);
            try
            {
                File.WriteAllLines(PATH, obavijesti.Select(k => k.FormatForFileLine()));
                DeleteSelected();
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void LoadData()
        {
            Obavijest obavijest1 = new Obavijest();
            string[] file = File.ReadAllLines(PATH);
            try
            {
                foreach (string line in file)
                {
                    obavijest1 = Obavijest.ParseFromFileLine(line);
                    obavijesti.Add(obavijest1);
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
                if (!(dijelovi[0] == obavijest))
                {
                    noviKontent.AppendLine(line);
                }
            }
            try
            {
                File.WriteAllText(PATH, noviKontent.ToString());
                DialogResult result = MessageBox.Show("Obavijest uspješno promijenjena!", "Confirmation",
                    MessageBoxButtons.OK);
                if (File.ReadAllText(PATH4) != "admin")
                {
                    Predavac_Pocetna predavac_Pocetna = new Predavac_Pocetna();
                    predavac_Pocetna.Show();
                    predavac_Pocetna.BringToFront();
                    this.Hide();
                }
                else
                {
                    Administrator_Pocetna administrator_Pocetna = new Administrator_Pocetna();
                    administrator_Pocetna.Show();
                    administrator_Pocetna.BringToFront();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool obavijestPostoji()
        {
            List<Obavijest> obavijesti = new List<Obavijest>();
            string[] detalji;
            try
            {
                detalji = File.ReadAllLines(PATH);
                foreach (var item in detalji)
                {
                    obavijesti.Add(Obavijest.ParseFromFileLine(item));
                }
                foreach (var item in obavijesti)
                {
                    if (item.Naslov == TBNaslov.Text)
                    {
                        MessageBox.Show("Obaivjest već postoji, nemoguć unos!");
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
            if (String.IsNullOrEmpty(TBNaslov.Text)
                || String.IsNullOrEmpty(TBOpis.Text))
            {
                MessageBox.Show("Molimo unesite sve potrebne informacije");
                return false;
            }
            return true;
        }


        private void BtnNatrag_Click(object sender, EventArgs e)
        {

            UrediObavijest urediObavijest = new();
            urediObavijest.Show();
            urediObavijest.BringToFront();
            this.Close();
        }

        private void UrediObavijestGlavnaForma_Load(object sender, EventArgs e)
        {
            List<Kolegij> kolegijiforcb = new List<Kolegij>();
            List<Kolegij> kolegiji = new List<Kolegij>();
            string[] svikolegiji = File.ReadAllLines(PATH2);
            foreach (var item in svikolegiji)
            {
                kolegiji.Add(Kolegij.ParseFromFileLine(item));
            }
            string user = File.ReadAllText(PATH4);
            if (user == "admin")
            {
                for (int i = 0; i < kolegiji.Count; i++)
                {
                        kolegijiforcb.Add(kolegiji[i]);
                }
                CBOdabirKolegija.DataSource = kolegijiforcb;
            }
            else
            {
                for (int i = 0; i < kolegiji.Count; i++)
                {
                    if (kolegiji[i].Predavac.Email == user)
                    {
                        kolegijiforcb.Add(kolegiji[i]);
                    }
                    CBOdabirKolegija.DataSource = kolegijiforcb;
                }
            }

            //Added comment
            //Again comment
            //---
            List<Osoba> osobe = new List<Osoba>();
            string[] sveosobe = File.ReadAllLines(PATH3);
            string ulogiraniuser = File.ReadAllText(PATH4);
            List<String> ulogirani = new List<String>();
            ulogirani.Add(ulogiraniuser);
            if (ulogiraniuser == "admin")
            {
                foreach (var item in sveosobe)
                {
                    osobe.Add(Osoba.ParseFromFileLine(item));
                }
                CBKreiraoObavijest.DataSource = osobe;
            }
            else
            {
                CBKreiraoObavijest.DataSource = ulogirani;
            }


        }
    }
}
