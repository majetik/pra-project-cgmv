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
using System.Windows.Forms.VisualStyles;

namespace CGMV
{
    public partial class SpajanjePredavacaIObavijesti : Form
    {
        private const string PATH2 = "ListaKolegija.txt";
        private const string PATH3 = "ListaPredavaca.txt";
        List<Kolegij> kolegiji = new List<Kolegij>();
        List<Osoba> osobe = new List<Osoba>();


        public SpajanjePredavacaIObavijesti()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Administrator_Pocetna administrator_Pocetna = new Administrator_Pocetna();
            administrator_Pocetna.Show();
            administrator_Pocetna.BringToFront();
            this.Hide();
        }

        private void SpajanjePredavacaIObavijesti_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadLecturers();
        }
        private void LoadCourses()
        {
            string[] svikolegiji = File.ReadAllLines(PATH2);
            foreach (var item in svikolegiji)
            {
                kolegiji.Add(Kolegij.ParseFromFileLine(item));
            }
            cbKolegij.DataSource = kolegiji;
        }

        private void LoadLecturers()
        {
            string[] sveosobe = File.ReadAllLines(PATH3);
            foreach (var item in sveosobe)
            {
                osobe.Add(Osoba.ParseFromFileLine(item));
            }
            cbPredavaca.DataSource = osobe;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            foreach (var item in kolegiji)
            {
                if (item.Naziv == cbKolegij.Text)
                {
                    foreach (var item2 in osobe)
                    {
                        string[] details = cbPredavaca.Text.Split(' ');
                        if (details[0] == item2.Ime && details[1] == item2.Prezime)
                        {
                            item.Predavac = item2;
                            File.WriteAllLines(PATH2, kolegiji.Select(k => k.FormatForFileLine()));
                            MessageBox.Show("Uspješno dodano");
                        }
                    }
                }
            }

  
            
        }
    }
}
