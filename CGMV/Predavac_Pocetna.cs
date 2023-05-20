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
    public partial class Predavac_Pocetna : Form
    {
        public Predavac_Pocetna()
        {
            InitializeComponent();
        }

        private void Predavac_Pocetna_Load(object sender, EventArgs e)
        {
            // micanje border linije oko button-a
            btnOdjava.FlatStyle = FlatStyle.Flat;
            btnOdjava.FlatAppearance.BorderSize = 0;

            foreach (Control control in pnlLinkovi.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.Black;
                    button.ForeColor = Color.White;
                }
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Form1 pocetnaStranica = new();
            pocetnaStranica.Show();
            pocetnaStranica.BringToFront();
            this.Close();
        }

    }
}
