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
    public partial class ObrisiPredavaca : Form
    {
        private const string PATH = "ListaPredavaca.txt";
        private const char SEPARATOR = '|';
        public ObrisiPredavaca()
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
        private void ObrisiPredavaca_Load(object sender, EventArgs e)
        {
            List<Osoba> osobe = new List<Osoba>();
            string[] sveosobe = File.ReadAllLines(PATH);
            foreach (var item in sveosobe)
            {
                osobe.Add(Osoba.ParseFromFileLine(item));
            }
            cbPredavaci.DataSource = osobe;
        }

        private void BtnObriši_Click(object sender, EventArgs e)
        {
            List<string> linije = File.ReadAllLines(PATH).ToList();

            StringBuilder noviKontent = new StringBuilder();
            foreach (string line in linije)
            {
                string[] dijelovi = line.Split(SEPARATOR);
                string[] imeiprezime = cbPredavaci.Text.Split(' ');
                if (!(dijelovi[0] == imeiprezime[0] && dijelovi[1] == imeiprezime[1]))
                {
                    noviKontent.AppendLine(line);
                }
            }
            try
            {
                File.WriteAllText(PATH, noviKontent.ToString());
                DialogResult result = MessageBox.Show("Predavač uspješno obrisan!", "Confirmation",
                    MessageBoxButtons.OK);
                List<Osoba> predavaci = new List<Osoba>();
                string[] svikolegiji = File.ReadAllLines(PATH);
                foreach (var item in svikolegiji)
                {
                    predavaci.Add(Osoba.ParseFromFileLine(item));
                }
                cbPredavaci.DataSource = predavaci;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
