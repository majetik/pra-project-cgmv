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
    public partial class UrediPredavaca : Form
    {
        private const string PATH = "ListaPredavaca.txt";
        public UrediPredavaca()
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

        private void UrediPredavaca_Load(object sender, EventArgs e)
        {
            List<Osoba> osobe = new List<Osoba>();
            string[] sveosobe = File.ReadAllLines(PATH);
            foreach (var item in sveosobe)
            {
                osobe.Add(Osoba.ParseFromFileLine(item));
            }
            cbPredavaci.DataSource = osobe;
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            if (cbPredavaci.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite Predavača");
            }
            else
            {
                string odabraniPredavac = cbPredavaci.SelectedItem.ToString();
                UrediPredavacaGlavnaForma uredipredavacaGlavnaForma = new(odabraniPredavac);
                uredipredavacaGlavnaForma.Show();
                uredipredavacaGlavnaForma.BringToFront();
                this.Hide();
            }
        }
        
    }
}