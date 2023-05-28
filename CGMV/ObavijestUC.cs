using Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGMV
{
    public partial class ObavijestUC : UserControl
    {
        public Obavijest obavijest { get; set; }
        public ObavijestUC(Obavijest obavijest1)
        {
            InitializeComponent();
            obavijest = obavijest1;

            lblNaslov.Text = obavijest.Naslov;
            tbOpis.Text = obavijest.Opis;
            lblImeiPrezime.Text = obavijest.Autor.ToString();
            lblKreiranoDatuma.Text = obavijest.DatumObjave.ToString("dd.MM.yyyy");
            lblIstječeDatuma.Text = obavijest.DatumIsteka.ToString("dd.MM.yyyy");
        }
    }
}
