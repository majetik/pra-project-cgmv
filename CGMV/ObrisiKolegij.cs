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
    public partial class ObrisiKolegij : Form
    {
        private const string PATH = "ListaKolegija.txt";
        public ObrisiKolegij()
        {
            InitializeComponent();
        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {
            Administrator_Pocetna admin = new Administrator_Pocetna();
            admin.Show();
            admin.BringToFront();

            this.Hide();
        }

        private void ObrisiKolegij_Load(object sender, EventArgs e)
        {
            List<string> kolegiji = new List<string>();

            using (StreamReader sr = new StreamReader(PATH))
            {
                while (!sr.EndOfStream)
                {
                    string linija = sr.ReadLine();
                    string[] detalji = linija.Split('|');

                    string naziv = detalji[0];
                    string sifra = detalji[1];

                    kolegiji.Add($"{naziv} {sifra}");
                }
            }

            CMOdaberiKolegij.DataSource = kolegiji;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            List<string> linije = File.ReadAllLines("ListaKolegija.txt").ToList();

            StringBuilder noviKontent = new StringBuilder();
            foreach (string line in linije)
            {
                string[] dijelovi = line.Split('|');
                if (!(dijelovi[0] == CMOdaberiKolegij.Text && dijelovi[1] == CMOdaberiKolegij.Text))
                {
                    noviKontent.AppendLine(line);
                }
            }

            try
            {
                File.WriteAllText("ListaKolegija.txt", noviKontent.ToString());

                CMOdaberiKolegij.Items.Remove(CMOdaberiKolegij.SelectedItem);

                DialogResult result = MessageBox.Show("Kolegij uspješno obrisan!", "Confirmation", MessageBoxButtons.OK);

                Administrator_Pocetna admin = new Administrator_Pocetna();
                admin.Show();
                admin.BringToFront();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
