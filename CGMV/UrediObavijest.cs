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
    public partial class UrediObavijest : Form
    {
        private const string PATH = "ListaObavijesti.txt";
        private const char SEPARATOR = '|';
        private const string PATH2 = "UlogiraniUser.txt";
        string ulogiraniUser = File.ReadAllText(PATH2);
        List<Obavijest> obavijesti = new List<Obavijest>();

        public UrediObavijest()
        {
            InitializeComponent();
        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText(PATH2) != "admin")
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

        private void UrediObavijest_Load(object sender, EventArgs e)
        {
            string[] sveobavijesti = File.ReadAllLines(PATH);
            foreach (var item in sveobavijesti)
            {
                Obavijest ob = Obavijest.ParseFromFileLine(item);
                if (File.ReadAllText(PATH2) != "admin")
                {
                    if (ob.Autor.Email == ulogiraniUser)
                    {
                        obavijesti.Add(ob);
                    }
                }
                else
                {
                    obavijesti.Add(ob);
                }
            }
            CMOdaberiObavijest.DataSource = obavijesti;
        }

        private void BtnNastavi_Click(object sender, EventArgs e)
        {
            if (CMOdaberiObavijest.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite Obavijest");
            }
            else
            {
                string odabranaObavijest = CMOdaberiObavijest.SelectedItem.ToString();
                UrediObavijestGlavnaForma urediobavijestGlavnaForma = new(odabranaObavijest);
                urediobavijestGlavnaForma.Show();
                urediobavijestGlavnaForma.BringToFront();
                this.Hide();
            }
        }
    }
}
