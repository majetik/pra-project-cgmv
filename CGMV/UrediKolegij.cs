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
    public partial class UrediKolegij : Form
    {
        private const string PATH = "ListaKolegija.txt";
        private const char SEPARATOR = '|';
        public UrediKolegij()
        {
            InitializeComponent();
        }
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Administrator_Pocetna administrator_Pocetna = new Administrator_Pocetna();
            administrator_Pocetna.Show();
            administrator_Pocetna.BringToFront();
            this.Close();
        }

        private void UrediKolegij_Load(object sender, EventArgs e)
        {
            List<Kolegij> kolegiji = new List<Kolegij>();
            string[] svikolegiji = File.ReadAllLines(PATH);
            foreach (var item in svikolegiji)
            {
                kolegiji.Add(Kolegij.ParseFromFileLine(item));
            }
            cbOdaberiKolegij.DataSource = kolegiji;
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            if (cbOdaberiKolegij.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite kolegij");
            }
            else
            {
                string odabranikolegij = cbOdaberiKolegij.SelectedItem.ToString();
                UrediKolegijGlavnaForma urediKolegijGlavnaForma = new(odabranikolegij);
                urediKolegijGlavnaForma.Show();
                urediKolegijGlavnaForma.BringToFront();
                this.Hide();
            }
        }
    }
}
