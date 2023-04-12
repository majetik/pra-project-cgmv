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
        private const string PATH1 = "ListaKolegija.txt";
        private const string PATH2 = "ListaPredavaca.txt";
        public DodajObavijest()
        {
            InitializeComponent();
        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {
            Administrator_Pocetna adminPocetna = new();
            adminPocetna.Show();
            adminPocetna.BringToFront();

            this.Close();
        }

        private void DodajObavijest_Load(object sender, EventArgs e)
        {
            List<Kolegij> kolegiji = new List<Kolegij>();
            string[] svikolegiji = File.ReadAllLines(PATH1);
            foreach (var item in svikolegiji)
            {
                kolegiji.Add(Kolegij.ParseFromFileLine(item));
            }
            CBOdabirKolegija.DataSource = kolegiji;

            List<Osoba> osobe = new List<Osoba>();
            string[] sveosobe = File.ReadAllLines(PATH2);
            foreach (var item in sveosobe)
            {
                osobe.Add(Osoba.ParseFromFileLine(item));
            }
            CBKreiraoObavijest.DataSource = osobe;
        }
    }
}
