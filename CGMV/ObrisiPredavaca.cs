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
        public ObrisiPredavaca()
        {
            InitializeComponent();
        }

        private void ObrisiPredavaca_Load(object sender, EventArgs e)
        {
            List<string> predavaci = new List<string>();

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
            }

            cbPredavaci.DataSource = predavaci;
        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {

            Administrator_Pocetna admin = new Administrator_Pocetna();
            admin.Show();
            admin.BringToFront();

            this.Hide();
        }

        private void BtnObriši_Click(object sender, EventArgs e)
        {
            List<string> linije = File.ReadAllLines("ListaPredavaca.txt").ToList();

            StringBuilder noviKontent = new StringBuilder();
            foreach (string line in linije)
            {
                string[] dijelovi = line.Split('|');
                if (!(dijelovi[0] == cbPredavaci.Text && dijelovi[1] == cbPredavaci.Text))
                {
                    noviKontent.AppendLine(line); // Add the line to the new contents.
                }
            }

            try
            {
                // Write the updated contents to the file.
                File.WriteAllText("ListaPredavaca.txt", noviKontent.ToString());

                // Remove the selected item from the combo box.
                cbPredavaci.Items.Remove(cbPredavaci.SelectedItem);

                DialogResult result = MessageBox.Show("Predavač uspješno obrisan", "Confirmation", MessageBoxButtons.OK);

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
