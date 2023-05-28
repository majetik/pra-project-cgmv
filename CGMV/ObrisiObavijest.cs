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
    public partial class ObrisiObavijest : Form
    {
        
        private const string PATH = "ListaObavijesti.txt";
        private const string PATH2 = "UlogiraniUser.txt";
        private const char SEPARATOR = '|';
        string ulogiraniUser = File.ReadAllText(PATH2);

        public ObrisiObavijest()
        {
            InitializeComponent();
        }
        List<Obavijest> obavijesti = new List<Obavijest>();
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

        private void ObrisiObavijest_Load(object sender, EventArgs e)
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

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (obavijesti.Count == 0)
            {
                return;
            }
            List<string> linije = File.ReadAllLines("ListaObavijesti.txt").ToList();
            StringBuilder noviKontent = new StringBuilder();
            foreach (string line in linije)
            {
                string[] dijelovi = line.Split(SEPARATOR);
                if (!(dijelovi[0] == CMOdaberiObavijest.Text))
                {
                    noviKontent.AppendLine(line);
                }
            }
            try
            {
                File.WriteAllText("ListaObavijesti.txt", noviKontent.ToString());
                DialogResult result = MessageBox.Show("Obavijest uspješno obrisana!", "Confirmation",
                    MessageBoxButtons.OK);
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
                //List<Obavijest> obavijesti = new List<Obavijest>();
                //string[] sveobavijesti = File.ReadAllLines(PATH);
                //foreach (var item in sveobavijesti)
                //{
                //    obavijesti.Add(Obavijest.ParseFromFileLine(item));
                //}
                //CMOdaberiObavijest.DataSource = obavijesti;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
