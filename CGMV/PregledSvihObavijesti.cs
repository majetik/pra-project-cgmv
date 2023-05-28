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
    public partial class PregledSvihObavijesti : Form
    {
        private const string PATH4 = "UlogiraniUser.txt";
        private const string PATH = "ListaObavijesti.txt";
        private const string PATH2 = "UlogiraniUser.txt";
        List<Obavijest> obavijesti = new List<Obavijest>();
        public PregledSvihObavijesti()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
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

        private void PregledSvihObavijesti_Load(object sender, EventArgs e)
        {
            LoadAllNotification();
            SetAllNotification();
        }

        private void SetAllNotification()
        {
            List<ObavijestUC> obavijestUCs = new List<ObavijestUC>(); 
            foreach (Obavijest obavijest in obavijesti)
            {
                obavijestUCs.Add(new ObavijestUC(obavijest));
            }
            flpObavijesti.Controls.AddRange(obavijestUCs.ToArray());
        }

        private void LoadAllNotification()
        {

            string[] sveobavijesti = File.ReadAllLines(PATH);
            foreach (var item in sveobavijesti)
            {
                obavijesti.Add(Obavijest.ParseFromFileLine(item));
            }
        }
    }
}
