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
    public partial class DodajObavijest : Form
    {
        private const string PATH1 = "ListaObavijesti.txt";
        private const string PATH2 = "ListaKolegija.txt";
        private const string PATH3 = "ListaPredavaca.txt";
        private const string PATH4 = "UlogiraniUser.txt";

        List<Obavijest> obavijesti = new List<Obavijest>();

        public DodajObavijest()
        {
            InitializeComponent();
            LoadData();
        }
        
        private void LoadData()
        {
            //LoadCourses();
            //LoadLecturers();
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
                if(kolegiji.Count == 0)
                {
                    CBOdabirKolegija.DataSource = "";
                }
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
                    if(kolegiji.Count == 0)
                    {
                        CBOdabirKolegija.DataSource = "";
                    }
                    if (kolegiji[i].Predavac.Email == user)
                    {
                        kolegijiforcb.Add(kolegiji[i]);
                    }
                }
                CBOdabirKolegija.DataSource = kolegijiforcb;
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
            LoadNotifications();
        }

        private void LoadCourses()
        {
            List<Kolegij> kolegiji = new List<Kolegij>();
            string[] svikolegiji = File.ReadAllLines(PATH2);
            foreach (var item in svikolegiji)
            {
                kolegiji.Add(Kolegij.ParseFromFileLine(item));
            }
            CBOdabirKolegija.DataSource = kolegiji;
        }

        private void LoadLecturers()
        {
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

        private void LoadNotifications()
        {
            if (!File.Exists(PATH1))
            {
                File.Create(PATH1);
            }
            Obavijest obavijest = new Obavijest();
            string[] file = File.ReadAllLines(PATH1);
            try
            {
                foreach (string line in file)
                {
                    obavijest = Obavijest.ParseFromFileLine(line);
                    obavijesti.Add(obavijest);
                }
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message);
            }
        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {
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

        private void BtnKreirajObavijest_Click(object sender, EventArgs e)
        {
            if (!formValid())
            {
                return;
            }
            if (!kolegijPostoji())
            {
                return;
            }

            Osoba osoba = new Osoba();
            string mail = CBKreiraoObavijest.Text;
            osoba.Email = mail;

            Obavijest obavijest = new()
            {
                Naslov = TBNaslov.Text,
                Opis = TBOpis.Text,
                Autor = osoba,
                DatumObjave = DateTime.Now,
                DatumIsteka = dtpIstekObavijesti.Value
            };
            obavijesti.Add(obavijest);
            try
            {
                File.WriteAllLines(PATH1, obavijesti.Select(k => k.FormatForFileLine()));
                MessageBox.Show("Obavijest uspješno dodana!");
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
            catch (Exception me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private bool kolegijPostoji()
        {
            List<Obavijest> obavijesti = new List<Obavijest>();
            string[] detalji;
            try
            {
                detalji = File.ReadAllLines(PATH1);
                foreach (var item in detalji)
                {
                    obavijesti.Add(Obavijest.ParseFromFileLine(item));
                }
                foreach (var item in obavijesti)
                {
                    if (item.Naslov == TBNaslov.Text)
                    {
                        MessageBox.Show("Obavijest već postoji, nemoguć unos!");
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


    }
}
