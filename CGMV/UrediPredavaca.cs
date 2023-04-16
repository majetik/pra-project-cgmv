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

            this.Hide();
        }

        private void UrediPredavaca_Load(object sender, EventArgs e)
        {
            List<string> predavaci = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(PATH))
                {
                    while (!sr.EndOfStream)
                    {

                        string linija = sr.ReadLine();
                        string[] detalji = linija.Split('|');

                        string ime = detalji[0];
                        string prezime = detalji[1];

                        predavaci.Add($"{ime} {prezime}");

                    }

                    cbPredavaci.DataSource = predavaci;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            if (cbPredavaci.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite predavača");
            }
            else
            {
                string odabraniPredavac = cbPredavaci.SelectedItem.ToString();

                UrediPredavacaGlavnaForma urediOdabranogPredavaca = new UrediPredavacaGlavnaForma(odabraniPredavac);
                urediOdabranogPredavaca.Show();
                urediOdabranogPredavaca.BringToFront();

                this.Hide();
            }
        }
    }
}