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
    public partial class ObrisiKolegij : Form
    {
        private const string PATH = "ListaKolegija.txt";
        private const char SEPARATOR = '|';
        List<Kolegij> kolegiji = new List<Kolegij>();
        public ObrisiKolegij()
        {
            InitializeComponent();
        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {
            Administrator_Pocetna admin = new Administrator_Pocetna();
            admin.Show();
            admin.BringToFront();
            this.Close();
        }

        private void ObrisiKolegij_Load(object sender, EventArgs e)
        {
            
            string[] svikolegiji = File.ReadAllLines(PATH);
            foreach (var item in svikolegiji)
            {
                kolegiji.Add(Kolegij.ParseFromFileLine(item));
            }
            CMOdaberiKolegij.DataSource = kolegiji;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (kolegiji.Count == 0)
            {
                return;
            }
            List<string> linije = File.ReadAllLines("ListaKolegija.txt").ToList();
            StringBuilder noviKontent = new StringBuilder();
            foreach (string line in linije)
            {
                string[] dijelovi = line.Split(SEPARATOR);
                if (!(dijelovi[0] == CMOdaberiKolegij.Text))
                {
                    noviKontent.AppendLine(line);
                }
            }
            try
            {
                File.WriteAllText("ListaKolegija.txt", noviKontent.ToString());
                DialogResult result = MessageBox.Show("Kolegij uspješno obrisan!", "Confirmation",
                    MessageBoxButtons.OK);
                List<Kolegij> kolegiji = new List<Kolegij>();
                string[] svikolegiji = File.ReadAllLines(PATH);
                foreach (var item in svikolegiji)
                {
                    kolegiji.Add(Kolegij.ParseFromFileLine(item));
                }
                CMOdaberiKolegij.DataSource = kolegiji;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
